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
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.001", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzh_);

        return uzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzj_);
        int? uzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(uzzzzzzzzzzzzzzzzzzzzzk_, "year");
        int? uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzl_, 1);
        decimal? uzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(uzzzzzzzzzzzzzzzzzzzzzm_, 5, 1, 0, 0, 0, 0, uzzzzzzzzzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzp_);
        int? uzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(uzzzzzzzzzzzzzzzzzzzzzq_, "year");
        decimal? uzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(uzzzzzzzzzzzzzzzzzzzzzr_, 4, 30, 23, 59, 59, 0, uzzzzzzzzzzzzzzzzzzzzzs_);

        return uzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzu_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzv_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzv_, true, true);

        return uzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Earliest Antidepressant Dispensed During Intake Period")]
    public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzx_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> uzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationDispense>(uzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationDispensed(context, vzzzzzzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzzzzzzd_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzp_ = this.Intake_Period(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationDispense> vzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationDispense>(vzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? vzzzzzzzzzzzzzzzzzzzzzf_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? vzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, vzzzzzzzzzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> vzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(vzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> vzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(vzzzzzzzzzzzzzzzzzzzzzg_);
        object vzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this)
        {
            CqlDate vzzzzzzzzzzzzzzzzzzzzzw_ = @this?.AntidepressantDate;

            return vzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> vzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(vzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? vzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(vzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzk_?.AntidepressantDate;

        return vzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate vzzzzzzzzzzzzzzzzzzzzzx_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);

        return vzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzy_ = this.Major_Depression(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzzzzzzzza_(Condition MajorDepression)
        {
            CqlDate wzzzzzzzzzzzzzzzzzzzzzd_ = this.IPSD(context);
            bool? wzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzd_ is null));
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(60m, "days");
            CqlDate wzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzf_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzh_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzl_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzn_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzr_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzt_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isEncounterPerformed(context, xzzzzzzzzzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            Period yzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzf_ = this.IPSD(context);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(60m, "days");
            CqlDate yzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzu_ = this.IPSD(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzv_);
        int? yzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzw_, "year");
        bool? yzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzx_, 18);
        bool? yzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounters(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzzzzb_);
        bool? zzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzc_);

        return zzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzf_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzg_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationActive(context, zzzzzzzzzzzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest ActiveAntidepressant)
        {
            CqlDate zzzzzzzzzzzzzzzzzzzzzzq_ = this.IPSD(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzq_ is null));
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzs_?.low;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzs_?.high;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzw_);
            bool? zzzzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzzzs_?.lowClosed;
            bool? azzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzzs_?.highClosed;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, azzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(105m, "days");
            CqlDate azzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzq_, true, false);
            bool? azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? azzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzj_);

            return azzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzo_);

        return zzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzl_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> azzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> azzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> azzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationDispense>(azzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationDispense> azzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isMedicationDispensed(context, azzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzr_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzv_ = this.IPSD(context);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(114m, "days");
            CqlDate azzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Intersect<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzz_);

            return bzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(azzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzzzzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzb_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? bzzzzzzzzzzzzzzzzzzzzzzc_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, bzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzc_, 84);

        return bzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzze_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

        return bzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzf_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationDispense>(bzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isMedicationDispensed(context, bzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzl_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzp_ = this.IPSD(context);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(231m, "days");
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Intersect<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzt_);

            return bzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(bzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzzzzzzzzzzzzzzzzzzm_);

        return bzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzv_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? bzzzzzzzzzzzzzzzzzzzzzzw_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, bzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzw_, 180);

        return bzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzy_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

        return bzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
