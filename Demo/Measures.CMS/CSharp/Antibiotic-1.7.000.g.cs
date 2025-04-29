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
        object mzzzzzzzzzzd_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzze_);

        return mzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Comorbid Condition History")]
    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> mzzzzzzzzzzg_(Encounter eDate)
        {
            bool? mzzzzzzzzzzl_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> mzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime mzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzp_);
                CqlDate mzzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzzq_);
                Period mzzzzzzzzzzs_ = eDate?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzt_ as object);
                CqlDateTime mzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzu_);
                CqlDate mzzzzzzzzzzw_ = context.Operators.DateFrom(mzzzzzzzzzzv_);
                CqlQuantity mzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
                CqlDate mzzzzzzzzzzy_ = context.Operators.Subtract(mzzzzzzzzzzw_, mzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> nzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzza_ as object);
                CqlDateTime nzzzzzzzzzzc_ = context.Operators.Start(nzzzzzzzzzzb_);
                CqlDate nzzzzzzzzzzd_ = context.Operators.DateFrom(nzzzzzzzzzzc_);
                CqlInterval<CqlDate> nzzzzzzzzzze_ = context.Operators.Interval(mzzzzzzzzzzy_, nzzzzzzzzzzd_, true, true);
                bool? nzzzzzzzzzzf_ = context.Operators.In<CqlDate>(mzzzzzzzzzzr_, nzzzzzzzzzze_, default);

                return nzzzzzzzzzzf_;
            };
            IEnumerable<Condition> mzzzzzzzzzzm_ = context.Operators.Where<Condition>(comorbidConditions, mzzzzzzzzzzl_);
            Encounter mzzzzzzzzzzn_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> mzzzzzzzzzzo_ = context.Operators.Select<Condition, Encounter>(mzzzzzzzzzzm_, mzzzzzzzzzzn_);

            return mzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, mzzzzzzzzzzg_);
        Encounter mzzzzzzzzzzi_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> mzzzzzzzzzzj_ = context.Operators.Select<Encounter, Encounter>(mzzzzzzzzzzh_, mzzzzzzzzzzi_);
        IEnumerable<Encounter> mzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzj_);

        return mzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Competing Diagnosis History")]
    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> nzzzzzzzzzzg_(Encounter eDate)
        {
            bool? nzzzzzzzzzzl_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> nzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime nzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzp_);
                Period nzzzzzzzzzzr_ = eDate?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzzv_);
                CqlQuantity nzzzzzzzzzzx_ = context.Operators.Quantity(3m, "days");
                CqlDateTime nzzzzzzzzzzy_ = context.Operators.Add(nzzzzzzzzzzw_, nzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzz_ = context.Operators.Interval(nzzzzzzzzzzt_, nzzzzzzzzzzy_, true, true);
                bool? ozzzzzzzzzza_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzq_, nzzzzzzzzzzz_, "day");
                CqlInterval<CqlDateTime> ozzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzd_ = context.Operators.Start(ozzzzzzzzzzc_);
                bool? ozzzzzzzzzze_ = context.Operators.Not((bool?)(ozzzzzzzzzzd_ is null));
                bool? ozzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzza_, ozzzzzzzzzze_);

                return ozzzzzzzzzzf_;
            };
            IEnumerable<Condition> nzzzzzzzzzzm_ = context.Operators.Where<Condition>(competingConditions, nzzzzzzzzzzl_);
            Encounter nzzzzzzzzzzn_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> nzzzzzzzzzzo_ = context.Operators.Select<Condition, Encounter>(nzzzzzzzzzzm_, nzzzzzzzzzzn_);

            return nzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, nzzzzzzzzzzg_);
        Encounter nzzzzzzzzzzi_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> nzzzzzzzzzzj_ = context.Operators.Select<Encounter, Encounter>(nzzzzzzzzzzh_, nzzzzzzzzzzi_);
        IEnumerable<Encounter> nzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzj_);

        return nzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Antibiotic Medication History")]
    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> ozzzzzzzzzzg_(Encounter DateOfEpisode)
        {
            bool? ozzzzzzzzzzi_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> ozzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period ozzzzzzzzzzn_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzn_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzo_ as object);
                CqlDateTime ozzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzp_);
                CqlDate ozzzzzzzzzzr_ = context.Operators.DateFrom(ozzzzzzzzzzq_);
                CqlQuantity ozzzzzzzzzzs_ = context.Operators.Quantity(30m, "days");
                CqlDate ozzzzzzzzzzt_ = context.Operators.Subtract(ozzzzzzzzzzr_, ozzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzn_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzv_ as object);
                CqlDateTime ozzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzw_);
                CqlDate ozzzzzzzzzzy_ = context.Operators.DateFrom(ozzzzzzzzzzx_);
                CqlQuantity ozzzzzzzzzzz_ = context.Operators.Quantity(1m, "day");
                CqlDate pzzzzzzzzzza_ = context.Operators.Subtract(ozzzzzzzzzzy_, ozzzzzzzzzzz_);
                CqlInterval<CqlDate> pzzzzzzzzzzb_ = context.Operators.Interval(ozzzzzzzzzzt_, pzzzzzzzzzza_, true, true);
                bool? pzzzzzzzzzzc_ = context.Operators.Overlaps(ozzzzzzzzzzm_, pzzzzzzzzzzb_, "day");

                return pzzzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> ozzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(antibioticMedications, ozzzzzzzzzzi_);
            Encounter ozzzzzzzzzzk_(MedicationRequest ActiveMedication) =>
                DateOfEpisode;
            IEnumerable<Encounter> ozzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(ozzzzzzzzzzj_, ozzzzzzzzzzk_);

            return ozzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, ozzzzzzzzzzg_);

        return ozzzzzzzzzzh_;
    }


    #endregion Expressions

}
