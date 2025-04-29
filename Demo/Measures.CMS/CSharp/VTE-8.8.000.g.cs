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

    #region ValueSet: Obstetrical or Pregnancy Related Conditions
    [CqlValueSetDefinition(
        definitionName: "Obstetrical or Pregnancy Related Conditions",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263",
        valueSetVersion: null)]
    public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions(CqlContext context) => _Obstetrical_or_Pregnancy_Related_Conditions;

    private static readonly CqlValueSet _Obstetrical_or_Pregnancy_Related_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);
    #endregion

    #region ValueSet: Obstetrics VTE
    [CqlValueSetDefinition(
        definitionName: "Obstetrics VTE",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264",
        valueSetVersion: null)]
    public CqlValueSet Obstetrics_VTE(CqlContext context) => _Obstetrics_VTE;

    private static readonly CqlValueSet _Obstetrics_VTE = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", null);
    #endregion

    #region ValueSet: Venous Thromboembolism
    [CqlValueSetDefinition(
        definitionName: "Venous Thromboembolism",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279",
        valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism(CqlContext context) => _Venous_Thromboembolism;

    private static readonly CqlValueSet _Venous_Thromboembolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzzzzzzzzzd_ = context.ResolveParameter("VTE-8.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzze_);

        return yzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Admission without VTE or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? yzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> yzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? yzzzzzzzzzzk_(Condition EncDx)
            {
                CodeableConcept yzzzzzzzzzzo_ = EncDx?.Code;
                CqlConcept yzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzo_);
                CqlValueSet yzzzzzzzzzzq_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? yzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzp_, yzzzzzzzzzzq_);
                CqlConcept yzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzo_);
                CqlValueSet yzzzzzzzzzzu_ = this.Venous_Thromboembolism(context);
                bool? yzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzt_, yzzzzzzzzzzu_);
                bool? yzzzzzzzzzzw_ = context.Operators.Or(yzzzzzzzzzzr_, yzzzzzzzzzzv_);
                CqlConcept yzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzo_);
                CqlValueSet yzzzzzzzzzzz_ = this.Obstetrics_VTE(context);
                bool? zzzzzzzzzzza_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzy_, yzzzzzzzzzzz_);
                bool? zzzzzzzzzzzb_ = context.Operators.Or(yzzzzzzzzzzw_, zzzzzzzzzzza_);

                return zzzzzzzzzzzb_;
            };
            IEnumerable<Condition> yzzzzzzzzzzl_ = context.Operators.Where<Condition>(yzzzzzzzzzzj_, yzzzzzzzzzzk_);
            bool? yzzzzzzzzzzm_ = context.Operators.Exists<Condition>(yzzzzzzzzzzl_);
            bool? yzzzzzzzzzzn_ = context.Operators.Not(yzzzzzzzzzzm_);

            return yzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzi_ = context.Operators.Where<Encounter>(yzzzzzzzzzzg_, yzzzzzzzzzzh_);

        return yzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? zzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            Patient zzzzzzzzzzzh_ = this.Patient(context);
            Date zzzzzzzzzzzi_ = zzzzzzzzzzzh_?.BirthDateElement;
            string zzzzzzzzzzzj_ = zzzzzzzzzzzi_?.Value;
            CqlDate zzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzj_);
            Period zzzzzzzzzzzl_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzl_);
            CqlDateTime zzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzm_);
            CqlDate zzzzzzzzzzzo_ = context.Operators.DateFrom(zzzzzzzzzzzn_);
            int? zzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzk_, zzzzzzzzzzzo_, "year");
            bool? zzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzp_, 18);

            return zzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> zzzzzzzzzzze_ = context.Operators.Where<Encounter>(zzzzzzzzzzzc_, zzzzzzzzzzzd_);
        IEnumerable<Encounter> zzzzzzzzzzzf_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
        IEnumerable<Encounter> zzzzzzzzzzzg_ = context.Operators.Intersect<Encounter>(zzzzzzzzzzze_, zzzzzzzzzzzf_);

        return zzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzr_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

        return zzzzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime zzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzs_);
        CqlDate zzzzzzzzzzzu_ = context.Operators.DateFrom(zzzzzzzzzzzt_);
        Period zzzzzzzzzzzv_ = Encounter?.Period;
        CqlInterval<CqlDateTime> zzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzv_);
        CqlDateTime zzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzw_);
        CqlDate zzzzzzzzzzzy_ = context.Operators.DateFrom(zzzzzzzzzzzx_);
        CqlQuantity zzzzzzzzzzzz_ = context.Operators.Quantity(1m, "days");
        CqlDate azzzzzzzzzzza_ = context.Operators.Add(zzzzzzzzzzzy_, zzzzzzzzzzzz_);
        CqlInterval<CqlDate> azzzzzzzzzzzb_ = context.Operators.Interval(zzzzzzzzzzzu_, azzzzzzzzzzza_, true, true);

        return azzzzzzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent azzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period azzzzzzzzzzzd_ = azzzzzzzzzzzc_?.Period;
        CqlInterval<CqlDateTime> azzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzd_);
        CqlDateTime azzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzze_);

        return azzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime azzzzzzzzzzzh_ = context.Operators.Start(azzzzzzzzzzzg_);
        CqlDate azzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzh_);
        CqlDateTime azzzzzzzzzzzj_ = this.StartOfFirstICU(context, Encounter);
        CqlDate azzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzj_);
        CqlQuantity azzzzzzzzzzzl_ = context.Operators.Quantity(1m, "day");
        CqlDate azzzzzzzzzzzm_ = context.Operators.Add(azzzzzzzzzzzk_, azzzzzzzzzzzl_);
        CqlInterval<CqlDate> azzzzzzzzzzzn_ = context.Operators.Interval(azzzzzzzzzzzi_, azzzzzzzzzzzm_, true, true);

        return azzzzzzzzzzzn_;
    }


    #endregion Expressions

}
