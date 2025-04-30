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
        object vzzzzzzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("VTE-8.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzze_);

        return vzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Admission without VTE or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzk_(Condition EncDx)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzo_ = EncDx?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Venous_Thromboembolism(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Obstetrics_VTE(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(vzzzzzzzzzzzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzh_);

        return vzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            Patient wzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            Date wzzzzzzzzzzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
            string wzzzzzzzzzzzzzzzzzzzzzzzj_ = wzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzj_);
            Period wzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? wzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzo_, "year");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzp_, 18);

            return wzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Intersect<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzf_);

        return wzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzt_);
        Period wzzzzzzzzzzzzzzzzzzzzzzzv_ = Encounter?.Period;
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "days");
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzza_, true, true);

        return xzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent xzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period xzzzzzzzzzzzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzzzzzzzzzzzc_?.Period;
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzj_ = this.StartOfFirstICU(context, Encounter);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "day");
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);

        return xzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}
