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
        CqlDateTime rzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzv_, true, true);
        object rzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.001", "Measurement Period", rzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzzzza_);
        int? szzzzzzzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzzzzzzzb_, "year");
        int? szzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzc_, 1);
        decimal? szzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime szzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(szzzzzzzzzzzzzzzzzd_, 5, 1, 0, 0, 0, 0, szzzzzzzzzzzzzzzzze_);

        return szzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzh_ = context.Operators.Start(szzzzzzzzzzzzzzzzzg_);
        int? szzzzzzzzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzzzzzzzh_, "year");
        decimal? szzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime szzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(szzzzzzzzzzzzzzzzzi_, 4, 30, 23, 59, 59, 0, szzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzl_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzm_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzm_, true, true);

        return szzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Earliest Antidepressant Dispensed During Intake Period")]
    public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzo_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> szzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> szzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> szzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationDispense>(szzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationDispense> szzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isMedicationDispensed(context, szzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzu_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate tzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzd_);
            CqlDateTime tzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzg_ = this.Intake_Period(context);
            bool? tzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzg_, "day");

            return tzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationDispense> szzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationDispense>(szzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? szzzzzzzzzzzzzzzzzw_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate tzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzi_);
            CqlDateTime tzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzzj_);
            CqlDate tzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? tzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, tzzzzzzzzzzzzzzzzzl_);

            return tzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> szzzzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(szzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> szzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(szzzzzzzzzzzzzzzzzx_);
        object szzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this)
        {
            CqlDate tzzzzzzzzzzzzzzzzzn_ = @this?.AntidepressantDate;

            return tzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> tzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(szzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? tzzzzzzzzzzzzzzzzzb_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(tzzzzzzzzzzzzzzzzza_);
        CqlDate tzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzb_?.AntidepressantDate;

        return tzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate tzzzzzzzzzzzzzzzzzo_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);

        return tzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzp_ = this.Major_Depression(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzr_(Condition MajorDepression)
        {
            CqlDate tzzzzzzzzzzzzzzzzzu_ = this.IPSD(context);
            bool? tzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzu_ is null));
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime tzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzw_);
            CqlDate tzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzx_);
            CqlQuantity uzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(60m, "days");
            CqlDate uzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzza_);
            CqlDate uzzzzzzzzzzzzzzzzze_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzze_, true, true);
            bool? uzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzf_, default);
            bool? uzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzu_ is null));
            bool? uzzzzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzj_);

            return uzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzr_);
        bool? tzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzo_);
        CqlValueSet uzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzs_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzu_);
        CqlValueSet uzzzzzzzzzzzzzzzzzw_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzy_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzza_);
        CqlValueSet vzzzzzzzzzzzzzzzzzc_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzzzze_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzg_);
        CqlValueSet vzzzzzzzzzzzzzzzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzzzzk_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isEncounterPerformed(context, vzzzzzzzzzzzzzzzzzn_);
        bool? vzzzzzzzzzzzzzzzzzp_(Encounter ValidEncounter)
        {
            Period vzzzzzzzzzzzzzzzzzr_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzs_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzt_);
            CqlDate vzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzu_);
            CqlDate vzzzzzzzzzzzzzzzzzw_ = this.IPSD(context);
            CqlQuantity vzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(60m, "days");
            CqlDate vzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzx_);
            CqlDate wzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzb_, true, true);
            bool? wzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzc_, default);
            bool? wzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzw_ is null));
            bool? wzzzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzf_);

            return wzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string wzzzzzzzzzzzzzzzzzj_ = wzzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate wzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzj_);
        CqlDate wzzzzzzzzzzzzzzzzzl_ = this.IPSD(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzl_);
        CqlDate wzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzm_);
        int? wzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzn_, "year");
        bool? wzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzo_, 18);
        bool? wzzzzzzzzzzzzzzzzzq_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounters(context);
        bool? wzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzt_);

        return wzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlValueSet wzzzzzzzzzzzzzzzzzx_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationActive(context, xzzzzzzzzzzzzzzzzzb_);
        bool? xzzzzzzzzzzzzzzzzzd_(MedicationRequest ActiveAntidepressant)
        {
            CqlDate xzzzzzzzzzzzzzzzzzh_ = this.IPSD(context);
            bool? xzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzh_ is null));
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate xzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzj_?.low;
            CqlDateTime xzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzk_);
            CqlDate xzzzzzzzzzzzzzzzzzn_ = xzzzzzzzzzzzzzzzzzj_?.high;
            CqlDateTime xzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzzzq_ = xzzzzzzzzzzzzzzzzzj_?.lowClosed;
            bool? xzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzj_?.highClosed;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, xzzzzzzzzzzzzzzzzzt_);
            CqlQuantity xzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(105m, "days");
            CqlDate xzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzh_, true, false);
            bool? yzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzz_, default);
            bool? yzzzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzza_);

            return yzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzd_);
        bool? xzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(xzzzzzzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzc_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationDispense>(yzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationDispensed(context, yzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzi_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate yzzzzzzzzzzzzzzzzzm_ = this.IPSD(context);
            CqlQuantity yzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(114m, "days");
            CqlDate yzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzp_, true, true);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzr_ = context.Operators.Intersect<CqlDate>(yzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzq_);

            return yzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(yzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(yzzzzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzzzzzzs_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? yzzzzzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, yzzzzzzzzzzzzzzzzzs_);
        bool? yzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzt_, 84);

        return yzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzzzzzv_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

        return yzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzw_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> zzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationDispense>(yzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationDispense> zzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationDispensed(context, zzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzc_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate zzzzzzzzzzzzzzzzzzg_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(231m, "days");
            CqlDate zzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzj_, true, true);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzl_ = context.Operators.Intersect<CqlDate>(zzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(zzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(zzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzzzzzzm_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? zzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, zzzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzn_, 180);

        return zzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzp_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

        return zzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
