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

    #region ValueSet: Clinical Oral Evaluation
    [CqlValueSetDefinition(
        definitionName: "Clinical Oral Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext context) => _Clinical_Oral_Evaluation;

    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);
    #endregion

    #region ValueSet: Discharged to Health Care Facility for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Health Care Facility for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);
    #endregion

    #region ValueSet: Discharged to Home for Hosice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Home for Hosice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hosice_Care(CqlContext context) => _Discharged_to_Home_for_Hosice_Care;

    private static readonly CqlValueSet _Discharged_to_Home_for_Hosice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Fluoride Varnish Application for Children
    [CqlValueSetDefinition(
        definitionName: "Fluoride Varnish Application for Children",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002",
        valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext context) => _Fluoride_Varnish_Application_for_Children;

    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "year");
        CqlInterval<int?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(1, 20, true, true);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<int?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure FluorideApplication)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FluorideApplication?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure FluorideApplication)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FluorideApplication?.Performed;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, 2);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
        CqlInterval<int?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(1, 5, true, true);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<int?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        CqlInterval<int?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(6, 12, true, true);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<int?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(13, 20, true, true);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}
