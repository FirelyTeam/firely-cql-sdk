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
[CqlLibrary("AntidepressantMedicationManagementFHIR", "0.1.001")]
public partial class AntidepressantMedicationManagementFHIR_0_1_001 : ILibrary, ISingleton<AntidepressantMedicationManagementFHIR_0_1_001>
{
    private AntidepressantMedicationManagementFHIR_0_1_001() {}

    public static AntidepressantMedicationManagementFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AntidepressantMedicationManagementFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Antidepressant Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", valueSetVersion: null)]
    public CqlValueSet Antidepressant_Medication(CqlContext _) => _Antidepressant_Medication;
    private static readonly CqlValueSet _Antidepressant_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Major Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", valueSetVersion: null)]
    public CqlValueSet Major_Depression(CqlContext _) => _Major_Depression;
    private static readonly CqlValueSet _Major_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzza_ = context.Operators.Interval(uzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzz_, true, true);
        object vzzzzzzzzzzzzzzb_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.001", "Measurement Period", vzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzc_);

        return vzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzze_);
        int? vzzzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzzzzf_, "year");
        int? vzzzzzzzzzzzzzzh_ = context.Operators.Subtract(vzzzzzzzzzzzzzzg_, 1);
        decimal? vzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime vzzzzzzzzzzzzzzj_ = context.Operators.DateTime(vzzzzzzzzzzzzzzh_, 5, 1, 0, 0, 0, 0, vzzzzzzzzzzzzzzi_);

        return vzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzl_ = context.Operators.Start(vzzzzzzzzzzzzzzk_);
        int? vzzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzzzzl_, "year");
        decimal? vzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime vzzzzzzzzzzzzzzo_ = context.Operators.DateTime(vzzzzzzzzzzzzzzm_, 4, 30, 23, 59, 59, 0, vzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzp_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzq_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzr_ = context.Operators.Interval(vzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzq_, true, true);

        return vzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Earliest Antidepressant Dispensed During Intake Period")]
    public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzs_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, vzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, vzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationDispense>(vzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isMedicationDispensed(context, vzzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzzy_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate wzzzzzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzzzzzh_);
            CqlDateTime wzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzk_ = this.Intake_Period(context);
            bool? wzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzk_, "day");

            return wzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationDispense>(vzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? wzzzzzzzzzzzzzza_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate wzzzzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzn_);
            CqlDate wzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? wzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, wzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> wzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(vzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> wzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(wzzzzzzzzzzzzzzb_);
        object wzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this)
        {
            CqlDate wzzzzzzzzzzzzzzr_ = @this?.AntidepressantDate;

            return wzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> wzzzzzzzzzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(wzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? wzzzzzzzzzzzzzzf_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(wzzzzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzzzzg_ = wzzzzzzzzzzzzzzf_?.AntidepressantDate;

        return wzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate wzzzzzzzzzzzzzzs_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);

        return wzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzt_ = this.Major_Depression(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzv_(Condition MajorDepression)
        {
            CqlDate wzzzzzzzzzzzzzzy_ = this.IPSD(context);
            bool? wzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzy_ is null));
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime xzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzza_);
            CqlDate xzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzb_);
            CqlQuantity xzzzzzzzzzzzzzze_ = context.Operators.Quantity(60m, "days");
            CqlDate xzzzzzzzzzzzzzzf_ = context.Operators.Subtract(wzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzzi_ = context.Operators.Add(wzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzj_ = context.Operators.Interval(xzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzi_, true, true);
            bool? xzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzj_, default);
            bool? xzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzy_ is null));
            bool? xzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzm_);
            bool? xzzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzr_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzs_);
        CqlValueSet xzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzw_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzy_);
        CqlValueSet yzzzzzzzzzzzzzza_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzc_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzze_);
        CqlValueSet yzzzzzzzzzzzzzzg_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzi_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzk_);
        CqlValueSet yzzzzzzzzzzzzzzm_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzo_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzzzr_);
        bool? yzzzzzzzzzzzzzzt_(Encounter ValidEncounter)
        {
            Period yzzzzzzzzzzzzzzv_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzw_ as object);
            CqlDateTime yzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzx_);
            CqlDate yzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzy_);
            CqlDate zzzzzzzzzzzzzzza_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzzzzzzb_ = context.Operators.Quantity(60m, "days");
            CqlDate zzzzzzzzzzzzzzzc_ = context.Operators.Subtract(zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzb_);
            CqlDate zzzzzzzzzzzzzzzf_ = context.Operators.Add(zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzf_, true, true);
            bool? zzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzg_, default);
            bool? zzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzza_ is null));
            bool? zzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzt_);

        return yzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzl_?.BirthDateElement;
        string zzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzm_?.Value;
        CqlDate zzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzn_);
        CqlDate zzzzzzzzzzzzzzzp_ = this.IPSD(context);
        CqlDateTime zzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzp_);
        CqlDate zzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzq_);
        int? zzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzr_, "year");
        bool? zzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzs_, 18);
        bool? zzzzzzzzzzzzzzzu_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzv_ = context.Operators.And(zzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        bool? zzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzw_);
        bool? zzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzza_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlValueSet azzzzzzzzzzzzzzzb_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isMedicationActive(context, azzzzzzzzzzzzzzzf_);
        bool? azzzzzzzzzzzzzzzh_(MedicationRequest ActiveAntidepressant)
        {
            CqlDate azzzzzzzzzzzzzzzl_ = this.IPSD(context);
            bool? azzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzl_ is null));
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate azzzzzzzzzzzzzzzo_ = azzzzzzzzzzzzzzzn_?.low;
            CqlDateTime azzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzo_);
            CqlDate azzzzzzzzzzzzzzzr_ = azzzzzzzzzzzzzzzn_?.high;
            CqlDateTime azzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzzzzu_ = azzzzzzzzzzzzzzzn_?.lowClosed;
            bool? azzzzzzzzzzzzzzzw_ = azzzzzzzzzzzzzzzn_?.highClosed;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzx_ = context.Operators.Interval(azzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, azzzzzzzzzzzzzzzx_);
            CqlQuantity bzzzzzzzzzzzzzzza_ = context.Operators.Quantity(105m, "days");
            CqlDate bzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(azzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzl_, true, false);
            bool? bzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzd_, default);
            bool? bzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzh_);
        bool? azzzzzzzzzzzzzzzj_ = context.Operators.Exists<MedicationRequest>(azzzzzzzzzzzzzzzi_);
        bool? azzzzzzzzzzzzzzzk_ = context.Operators.Or(azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzg_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationDispense>(bzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationDispensed(context, bzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzm_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate bzzzzzzzzzzzzzzzq_ = this.IPSD(context);
            CqlQuantity bzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(114m, "days");
            CqlDate bzzzzzzzzzzzzzzzt_ = context.Operators.Add(bzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzu_ = context.Operators.Interval(bzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzt_, true, true);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzv_ = context.Operators.Intersect<CqlDate>(bzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(bzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzw_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? bzzzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, bzzzzzzzzzzzzzzzw_);
        bool? bzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzx_, 84);

        return bzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzz_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

        return bzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzza_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> czzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, czzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> czzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, czzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> czzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationDispense>(czzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationDispense> czzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationDispensed(context, czzzzzzzzzzzzzzze_);
        CqlInterval<CqlDate> czzzzzzzzzzzzzzzg_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate czzzzzzzzzzzzzzzk_ = this.IPSD(context);
            CqlQuantity czzzzzzzzzzzzzzzm_ = context.Operators.Quantity(231m, "days");
            CqlDate czzzzzzzzzzzzzzzn_ = context.Operators.Add(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzo_ = context.Operators.Interval(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzn_, true, true);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzp_ = context.Operators.Intersect<CqlDate>(czzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzo_);

            return czzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzzzq_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? czzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, czzzzzzzzzzzzzzzq_);
        bool? czzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzzzr_, 180);

        return czzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzt_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

        return czzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
