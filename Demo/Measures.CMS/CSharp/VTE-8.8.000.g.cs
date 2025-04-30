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
[CqlLibrary("VTE", "8.8.000")]
public partial class VTE_8_8_000 : ILibrary, ISingleton<VTE_8_8_000>
{
    private VTE_8_8_000() {}

    public static VTE_8_8_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "VTE";
    public string Version => "8.8.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Obstetrical or Pregnancy Related Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", valueSetVersion: null)]
    public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions(CqlContext _) => _Obstetrical_or_Pregnancy_Related_Conditions;
    private static readonly CqlValueSet _Obstetrical_or_Pregnancy_Related_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);

    [CqlValueSetDefinition("Obstetrics VTE", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", valueSetVersion: null)]
    public CqlValueSet Obstetrics_VTE(CqlContext _) => _Obstetrics_VTE;
    private static readonly CqlValueSet _Obstetrics_VTE = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", null);

    [CqlValueSetDefinition("Venous Thromboembolism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism(CqlContext _) => _Venous_Thromboembolism;
    private static readonly CqlValueSet _Venous_Thromboembolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("VTE-8.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Admission without VTE or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition EncDx)
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncDx?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Venous_Thromboembolism(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Obstetrics_VTE(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            Patient fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, 18);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Intersect<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Encounter?.Period;
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "days");
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Period;
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.StartOfFirstICU(context, Encounter);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "day");
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
