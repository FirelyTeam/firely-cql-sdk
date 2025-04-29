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
        object vzzzzzzzzzze_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzf_);

        return vzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Comorbid Condition History")]
    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> vzzzzzzzzzzh_(Encounter eDate)
        {
            bool? vzzzzzzzzzzm_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime vzzzzzzzzzzr_ = context.Operators.Start(vzzzzzzzzzzq_);
                CqlDate vzzzzzzzzzzs_ = context.Operators.DateFrom(vzzzzzzzzzzr_);
                Period vzzzzzzzzzzt_ = eDate?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzu_ as object);
                CqlDateTime vzzzzzzzzzzw_ = context.Operators.Start(vzzzzzzzzzzv_);
                CqlDate vzzzzzzzzzzx_ = context.Operators.DateFrom(vzzzzzzzzzzw_);
                CqlQuantity vzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
                CqlDate vzzzzzzzzzzz_ = context.Operators.Subtract(vzzzzzzzzzzx_, vzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzb_ as object);
                CqlDateTime wzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzc_);
                CqlDate wzzzzzzzzzze_ = context.Operators.DateFrom(wzzzzzzzzzzd_);
                CqlInterval<CqlDate> wzzzzzzzzzzf_ = context.Operators.Interval(vzzzzzzzzzzz_, wzzzzzzzzzze_, true, true);
                bool? wzzzzzzzzzzg_ = context.Operators.In<CqlDate>(vzzzzzzzzzzs_, wzzzzzzzzzzf_, default);

                return wzzzzzzzzzzg_;
            };
            IEnumerable<Condition> vzzzzzzzzzzn_ = context.Operators.Where<Condition>(comorbidConditions, vzzzzzzzzzzm_);
            Encounter vzzzzzzzzzzo_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> vzzzzzzzzzzp_ = context.Operators.Select<Condition, Encounter>(vzzzzzzzzzzn_, vzzzzzzzzzzo_);

            return vzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, vzzzzzzzzzzh_);
        Encounter vzzzzzzzzzzj_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> vzzzzzzzzzzk_ = context.Operators.Select<Encounter, Encounter>(vzzzzzzzzzzi_, vzzzzzzzzzzj_);
        IEnumerable<Encounter> vzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(vzzzzzzzzzzk_);

        return vzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Competing Diagnosis History")]
    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> wzzzzzzzzzzh_(Encounter eDate)
        {
            bool? wzzzzzzzzzzm_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime wzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzq_);
                Period wzzzzzzzzzzs_ = eDate?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzs_);
                CqlDateTime wzzzzzzzzzzu_ = context.Operators.Start(wzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzs_);
                CqlDateTime wzzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzzw_);
                CqlQuantity wzzzzzzzzzzy_ = context.Operators.Quantity(3m, "days");
                CqlDateTime wzzzzzzzzzzz_ = context.Operators.Add(wzzzzzzzzzzx_, wzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> xzzzzzzzzzza_ = context.Operators.Interval(wzzzzzzzzzzu_, wzzzzzzzzzzz_, true, true);
                bool? xzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzr_, xzzzzzzzzzza_, "day");
                CqlInterval<CqlDateTime> xzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzs_);
                CqlDateTime xzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzd_);
                bool? xzzzzzzzzzzf_ = context.Operators.Not((bool?)(xzzzzzzzzzze_ is null));
                bool? xzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzb_, xzzzzzzzzzzf_);

                return xzzzzzzzzzzg_;
            };
            IEnumerable<Condition> wzzzzzzzzzzn_ = context.Operators.Where<Condition>(competingConditions, wzzzzzzzzzzm_);
            Encounter wzzzzzzzzzzo_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> wzzzzzzzzzzp_ = context.Operators.Select<Condition, Encounter>(wzzzzzzzzzzn_, wzzzzzzzzzzo_);

            return wzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, wzzzzzzzzzzh_);
        Encounter wzzzzzzzzzzj_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> wzzzzzzzzzzk_ = context.Operators.Select<Encounter, Encounter>(wzzzzzzzzzzi_, wzzzzzzzzzzj_);
        IEnumerable<Encounter> wzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzk_);

        return wzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Antibiotic Medication History")]
    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> xzzzzzzzzzzh_(Encounter DateOfEpisode)
        {
            bool? xzzzzzzzzzzj_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> xzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period xzzzzzzzzzzo_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzp_ as object);
                CqlDateTime xzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzq_);
                CqlDate xzzzzzzzzzzs_ = context.Operators.DateFrom(xzzzzzzzzzzr_);
                CqlQuantity xzzzzzzzzzzt_ = context.Operators.Quantity(30m, "days");
                CqlDate xzzzzzzzzzzu_ = context.Operators.Subtract(xzzzzzzzzzzs_, xzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzw_ as object);
                CqlDateTime xzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzx_);
                CqlDate xzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzy_);
                CqlQuantity yzzzzzzzzzza_ = context.Operators.Quantity(1m, "day");
                CqlDate yzzzzzzzzzzb_ = context.Operators.Subtract(xzzzzzzzzzzz_, yzzzzzzzzzza_);
                CqlInterval<CqlDate> yzzzzzzzzzzc_ = context.Operators.Interval(xzzzzzzzzzzu_, yzzzzzzzzzzb_, true, true);
                bool? yzzzzzzzzzzd_ = context.Operators.Overlaps(xzzzzzzzzzzn_, yzzzzzzzzzzc_, "day");

                return yzzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> xzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(antibioticMedications, xzzzzzzzzzzj_);
            Encounter xzzzzzzzzzzl_(MedicationRequest ActiveMedication) =>
                DateOfEpisode;
            IEnumerable<Encounter> xzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(xzzzzzzzzzzk_, xzzzzzzzzzzl_);

            return xzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, xzzzzzzzzzzh_);

        return xzzzzzzzzzzi_;
    }


    #endregion Expressions

}
