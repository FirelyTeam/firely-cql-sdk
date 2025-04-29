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

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter eDate)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = eDate?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "year");
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(comorbidConditions, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Condition, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter eDate)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = eDate?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(3m, "days");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(competingConditions, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Condition, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter DateOfEpisode)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(30m, "days");
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1m, "day");
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(antibioticMedications, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest ActiveMedication) =>
                DateOfEpisode;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
