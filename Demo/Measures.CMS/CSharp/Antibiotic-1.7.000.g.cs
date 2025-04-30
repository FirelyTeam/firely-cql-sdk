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
        object azzzzzzzzzzx_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzy_);

        return azzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Comorbid Condition History")]
    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> bzzzzzzzzzza_(Encounter eDate)
        {
            bool? bzzzzzzzzzzf_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime bzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzj_);
                CqlDate bzzzzzzzzzzl_ = context.Operators.DateFrom(bzzzzzzzzzzk_);
                Period bzzzzzzzzzzm_ = eDate?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzn_ as object);
                CqlDateTime bzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzo_);
                CqlDate bzzzzzzzzzzq_ = context.Operators.DateFrom(bzzzzzzzzzzp_);
                CqlQuantity bzzzzzzzzzzr_ = context.Operators.Quantity(1m, "year");
                CqlDate bzzzzzzzzzzs_ = context.Operators.Subtract(bzzzzzzzzzzq_, bzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzu_ as object);
                CqlDateTime bzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzv_);
                CqlDate bzzzzzzzzzzx_ = context.Operators.DateFrom(bzzzzzzzzzzw_);
                CqlInterval<CqlDate> bzzzzzzzzzzy_ = context.Operators.Interval(bzzzzzzzzzzs_, bzzzzzzzzzzx_, true, true);
                bool? bzzzzzzzzzzz_ = context.Operators.In<CqlDate>(bzzzzzzzzzzl_, bzzzzzzzzzzy_, default);

                return bzzzzzzzzzzz_;
            };
            IEnumerable<Condition> bzzzzzzzzzzg_ = context.Operators.Where<Condition>(comorbidConditions, bzzzzzzzzzzf_);
            Encounter bzzzzzzzzzzh_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> bzzzzzzzzzzi_ = context.Operators.Select<Condition, Encounter>(bzzzzzzzzzzg_, bzzzzzzzzzzh_);

            return bzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, bzzzzzzzzzza_);
        Encounter bzzzzzzzzzzc_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> bzzzzzzzzzzd_ = context.Operators.Select<Encounter, Encounter>(bzzzzzzzzzzb_, bzzzzzzzzzzc_);
        IEnumerable<Encounter> bzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzd_);

        return bzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Competing Diagnosis History")]
    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> czzzzzzzzzza_(Encounter eDate)
        {
            bool? czzzzzzzzzzf_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime czzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzj_);
                Period czzzzzzzzzzl_ = eDate?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzq_ = context.Operators.Start(czzzzzzzzzzp_);
                CqlQuantity czzzzzzzzzzr_ = context.Operators.Quantity(3m, "days");
                CqlDateTime czzzzzzzzzzs_ = context.Operators.Add(czzzzzzzzzzq_, czzzzzzzzzzr_);
                CqlInterval<CqlDateTime> czzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzn_, czzzzzzzzzzs_, true, true);
                bool? czzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzk_, czzzzzzzzzzt_, "day");
                CqlInterval<CqlDateTime> czzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzx_ = context.Operators.Start(czzzzzzzzzzw_);
                bool? czzzzzzzzzzy_ = context.Operators.Not((bool?)(czzzzzzzzzzx_ is null));
                bool? czzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzu_, czzzzzzzzzzy_);

                return czzzzzzzzzzz_;
            };
            IEnumerable<Condition> czzzzzzzzzzg_ = context.Operators.Where<Condition>(competingConditions, czzzzzzzzzzf_);
            Encounter czzzzzzzzzzh_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> czzzzzzzzzzi_ = context.Operators.Select<Condition, Encounter>(czzzzzzzzzzg_, czzzzzzzzzzh_);

            return czzzzzzzzzzi_;
        };
        IEnumerable<Encounter> czzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, czzzzzzzzzza_);
        Encounter czzzzzzzzzzc_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> czzzzzzzzzzd_ = context.Operators.Select<Encounter, Encounter>(czzzzzzzzzzb_, czzzzzzzzzzc_);
        IEnumerable<Encounter> czzzzzzzzzze_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzd_);

        return czzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Antibiotic Medication History")]
    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> dzzzzzzzzzza_(Encounter DateOfEpisode)
        {
            bool? dzzzzzzzzzzc_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> dzzzzzzzzzzg_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period dzzzzzzzzzzh_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzi_ as object);
                CqlDateTime dzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzj_);
                CqlDate dzzzzzzzzzzl_ = context.Operators.DateFrom(dzzzzzzzzzzk_);
                CqlQuantity dzzzzzzzzzzm_ = context.Operators.Quantity(30m, "days");
                CqlDate dzzzzzzzzzzn_ = context.Operators.Subtract(dzzzzzzzzzzl_, dzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzp_ as object);
                CqlDateTime dzzzzzzzzzzr_ = context.Operators.Start(dzzzzzzzzzzq_);
                CqlDate dzzzzzzzzzzs_ = context.Operators.DateFrom(dzzzzzzzzzzr_);
                CqlQuantity dzzzzzzzzzzt_ = context.Operators.Quantity(1m, "day");
                CqlDate dzzzzzzzzzzu_ = context.Operators.Subtract(dzzzzzzzzzzs_, dzzzzzzzzzzt_);
                CqlInterval<CqlDate> dzzzzzzzzzzv_ = context.Operators.Interval(dzzzzzzzzzzn_, dzzzzzzzzzzu_, true, true);
                bool? dzzzzzzzzzzw_ = context.Operators.Overlaps(dzzzzzzzzzzg_, dzzzzzzzzzzv_, "day");

                return dzzzzzzzzzzw_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(antibioticMedications, dzzzzzzzzzzc_);
            Encounter dzzzzzzzzzze_(MedicationRequest ActiveMedication) =>
                DateOfEpisode;
            IEnumerable<Encounter> dzzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(dzzzzzzzzzzd_, dzzzzzzzzzze_);

            return dzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, dzzzzzzzzzza_);

        return dzzzzzzzzzzb_;
    }


    #endregion Expressions

}
