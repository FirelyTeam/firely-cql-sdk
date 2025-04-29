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
        object rzzzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("VTE-8.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Admission without VTE or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzz_(Condition EncDx)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzd_ = EncDx?.Code;
                CqlConcept szzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzf_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? szzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzf_);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzj_ = this.Venous_Thromboembolism(context);
                bool? szzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzj_);
                bool? szzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzk_);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzo_ = this.Obstetrics_VTE(context);
                bool? szzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzo_);
                bool? szzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzp_);

                return szzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzz_);
            bool? szzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzza_);
            bool? szzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzb_);

            return szzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? szzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            Patient szzzzzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date szzzzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string szzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate szzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzy_);
            Period tzzzzzzzzzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzc_);
            int? tzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzd_, "year");
            bool? tzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzze_, 18);

            return tzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzu_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Intersect<Encounter>(szzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

        return tzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzi_);
        Period tzzzzzzzzzzzzzzzzzzzzzk_ = Encounter?.Period;
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzm_);
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "days");
        CqlDate tzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzp_, true, true);

        return tzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent tzzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period tzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzr_?.Period;
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzy_ = this.StartOfFirstICU(context, Encounter);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzy_);
        CqlQuantity uzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "day");
        CqlDate uzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzb_, true, true);

        return uzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
