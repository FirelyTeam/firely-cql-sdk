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
        CqlDateTime wzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzg_ = context.Operators.Interval(wzzzzzzzzzzzze_, wzzzzzzzzzzzzf_, true, true);
        object wzzzzzzzzzzzzh_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", wzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzk_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, wzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzn_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period wzzzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzq_);
            bool? wzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzp_, wzzzzzzzzzzzzr_, "day");

            return wzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzm_, wzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzt_ = this.Patient(context);
        Date wzzzzzzzzzzzzu_ = wzzzzzzzzzzzzt_?.BirthDateElement;
        string wzzzzzzzzzzzzv_ = wzzzzzzzzzzzzu_?.Value;
        CqlDate wzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzy_ = context.Operators.Start(wzzzzzzzzzzzzx_);
        CqlDate wzzzzzzzzzzzzz_ = context.Operators.DateFrom(wzzzzzzzzzzzzy_);
        int? xzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzw_, wzzzzzzzzzzzzz_, "year");
        CqlInterval<int?> xzzzzzzzzzzzzb_ = context.Operators.Interval(1, 20, true, true);
        bool? xzzzzzzzzzzzzc_ = context.Operators.In<int?>(xzzzzzzzzzzzza_, xzzzzzzzzzzzzb_, default);
        IEnumerable<Encounter> xzzzzzzzzzzzzd_ = this.Qualifying_Encounters(context);
        bool? xzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzd_);
        bool? xzzzzzzzzzzzzf_ = context.Operators.And(xzzzzzzzzzzzzc_, xzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? xzzzzzzzzzzzzh_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return xzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzi_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, xzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzl_(Procedure FluorideApplication)
        {
            DataType xzzzzzzzzzzzzs_ = FluorideApplication?.Performed;
            object xzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzt_);
            CqlDateTime xzzzzzzzzzzzzv_ = context.Operators.End(xzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzv_, xzzzzzzzzzzzzw_, "day");

            return xzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzk_, xzzzzzzzzzzzzl_);
        CqlDate xzzzzzzzzzzzzn_(Procedure FluorideApplication)
        {
            DataType xzzzzzzzzzzzzy_ = FluorideApplication?.Performed;
            object xzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzz_);
            CqlDateTime yzzzzzzzzzzzzb_ = context.Operators.End(yzzzzzzzzzzzza_);
            CqlDate yzzzzzzzzzzzzc_ = context.Operators.DateFrom(yzzzzzzzzzzzzb_);

            return yzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, CqlDate>(xzzzzzzzzzzzzm_, xzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzo_);
        int? xzzzzzzzzzzzzq_ = context.Operators.Count<CqlDate>(xzzzzzzzzzzzzp_);
        bool? xzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzq_, 2);

        return xzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient yzzzzzzzzzzzzd_ = this.Patient(context);
        Date yzzzzzzzzzzzze_ = yzzzzzzzzzzzzd_?.BirthDateElement;
        string yzzzzzzzzzzzzf_ = yzzzzzzzzzzzze_?.Value;
        CqlDate yzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzi_ = context.Operators.Start(yzzzzzzzzzzzzh_);
        CqlDate yzzzzzzzzzzzzj_ = context.Operators.DateFrom(yzzzzzzzzzzzzi_);
        int? yzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> yzzzzzzzzzzzzl_ = context.Operators.Interval(1, 5, true, true);
        bool? yzzzzzzzzzzzzm_ = context.Operators.In<int?>(yzzzzzzzzzzzzk_, yzzzzzzzzzzzzl_, default);

        return yzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient yzzzzzzzzzzzzn_ = this.Patient(context);
        Date yzzzzzzzzzzzzo_ = yzzzzzzzzzzzzn_?.BirthDateElement;
        string yzzzzzzzzzzzzp_ = yzzzzzzzzzzzzo_?.Value;
        CqlDate yzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzr_);
        CqlDate yzzzzzzzzzzzzt_ = context.Operators.DateFrom(yzzzzzzzzzzzzs_);
        int? yzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzq_, yzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> yzzzzzzzzzzzzv_ = context.Operators.Interval(6, 12, true, true);
        bool? yzzzzzzzzzzzzw_ = context.Operators.In<int?>(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzv_, default);

        return yzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient yzzzzzzzzzzzzx_ = this.Patient(context);
        Date yzzzzzzzzzzzzy_ = yzzzzzzzzzzzzx_?.BirthDateElement;
        string yzzzzzzzzzzzzz_ = yzzzzzzzzzzzzy_?.Value;
        CqlDate zzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzc_ = context.Operators.Start(zzzzzzzzzzzzzb_);
        CqlDate zzzzzzzzzzzzzd_ = context.Operators.DateFrom(zzzzzzzzzzzzzc_);
        int? zzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzza_, zzzzzzzzzzzzzd_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzf_ = context.Operators.Interval(13, 20, true, true);
        bool? zzzzzzzzzzzzzg_ = context.Operators.In<int?>(zzzzzzzzzzzzze_, zzzzzzzzzzzzzf_, default);

        return zzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
