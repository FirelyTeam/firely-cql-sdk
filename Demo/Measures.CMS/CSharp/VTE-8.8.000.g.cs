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
        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("VTE-8.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Admission without VTE or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition EncDx)
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncDx?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Venous_Thromboembolism(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Obstetrics_VTE(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, 18);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Intersect<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Encounter?.Period;
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "days");
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Period;
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.StartOfFirstICU(context, Encounter);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "day");
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
