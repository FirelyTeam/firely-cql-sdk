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
[CqlLibrary("PrimaryCariesPreventionasOfferedbyDentistsFHIR", "0.0.002")]
public partial class PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002 : ILibrary, ISingleton<PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002>
{
    private PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002() {}

    public static PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PrimaryCariesPreventionasOfferedbyDentistsFHIR";
    public string Version => "0.0.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hosice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hosice_Care(CqlContext _) => _Discharged_to_Home_for_Hosice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hosice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isEncounterPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
        CqlInterval<int?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(1, 20, true, true);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<int?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounters(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isProcedurePerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure FluorideApplication)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FluorideApplication?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure FluorideApplication)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FluorideApplication?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Procedure, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Count<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, 2);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        CqlInterval<int?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(1, 5, true, true);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<int?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(6, 12, true, true);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(13, 20, true, true);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<int?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
