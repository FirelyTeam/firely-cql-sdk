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
        CqlDateTime szzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzz_ = context.Operators.Interval(szzzzzzzzzx_, szzzzzzzzzy_, true, true);
        object tzzzzzzzzza_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.001", "Measurement Period", szzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzb_);

        return tzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> tzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzd_);
        int? tzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(tzzzzzzzzze_, "year");
        int? tzzzzzzzzzg_ = context.Operators.Subtract(tzzzzzzzzzf_, 1);
        decimal? tzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime tzzzzzzzzzi_ = context.Operators.DateTime(tzzzzzzzzzg_, 5, 1, 0, 0, 0, 0, tzzzzzzzzzh_);

        return tzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> tzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzk_ = context.Operators.Start(tzzzzzzzzzj_);
        int? tzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(tzzzzzzzzzk_, "year");
        decimal? tzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime tzzzzzzzzzn_ = context.Operators.DateTime(tzzzzzzzzzl_, 4, 30, 23, 59, 59, 0, tzzzzzzzzzm_);

        return tzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzo_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime tzzzzzzzzzp_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> tzzzzzzzzzq_ = context.Operators.Interval(tzzzzzzzzzo_, tzzzzzzzzzp_, true, true);

        return tzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Earliest Antidepressant Dispensed During Intake Period")]
    public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzr_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> tzzzzzzzzzs_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, tzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> tzzzzzzzzzu_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, tzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> tzzzzzzzzzv_ = context.Operators.Union<MedicationDispense>(tzzzzzzzzzs_, tzzzzzzzzzu_);
        IEnumerable<MedicationDispense> tzzzzzzzzzw_ = Status_1_8_000.Instance.isMedicationDispensed(context, tzzzzzzzzzv_);
        bool? tzzzzzzzzzx_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> uzzzzzzzzzg_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate uzzzzzzzzzh_ = context.Operators.Start(uzzzzzzzzzg_);
            CqlDateTime uzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzj_ = this.Intake_Period(context);
            bool? uzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzi_, uzzzzzzzzzj_, "day");

            return uzzzzzzzzzk_;
        };
        IEnumerable<MedicationDispense> tzzzzzzzzzy_ = context.Operators.Where<MedicationDispense>(tzzzzzzzzzw_, tzzzzzzzzzx_);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? tzzzzzzzzzz_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> uzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate uzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzl_);
            CqlDateTime uzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzm_);
            CqlDate uzzzzzzzzzo_ = context.Operators.DateFrom(uzzzzzzzzzn_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? uzzzzzzzzzp_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, uzzzzzzzzzo_);

            return uzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> uzzzzzzzzza_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(tzzzzzzzzzy_, tzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> uzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(uzzzzzzzzza_);
        object uzzzzzzzzzc_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this)
        {
            CqlDate uzzzzzzzzzq_ = @this?.AntidepressantDate;

            return uzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> uzzzzzzzzzd_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(uzzzzzzzzzb_, uzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? uzzzzzzzzze_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(uzzzzzzzzzd_);
        CqlDate uzzzzzzzzzf_ = uzzzzzzzzze_?.AntidepressantDate;

        return uzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate uzzzzzzzzzr_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);

        return uzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzs_ = this.Major_Depression(context);
        IEnumerable<Condition> uzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzu_(Condition MajorDepression)
        {
            CqlDate uzzzzzzzzzx_ = this.IPSD(context);
            bool? uzzzzzzzzzy_ = context.Operators.Not((bool?)(uzzzzzzzzzx_ is null));
            CqlInterval<CqlDateTime> uzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime vzzzzzzzzza_ = context.Operators.Start(uzzzzzzzzzz_);
            CqlDate vzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzza_);
            CqlQuantity vzzzzzzzzzd_ = context.Operators.Quantity(60m, "days");
            CqlDate vzzzzzzzzze_ = context.Operators.Subtract(uzzzzzzzzzx_, vzzzzzzzzzd_);
            CqlDate vzzzzzzzzzh_ = context.Operators.Add(uzzzzzzzzzx_, vzzzzzzzzzd_);
            CqlInterval<CqlDate> vzzzzzzzzzi_ = context.Operators.Interval(vzzzzzzzzze_, vzzzzzzzzzh_, true, true);
            bool? vzzzzzzzzzj_ = context.Operators.In<CqlDate>(vzzzzzzzzzb_, vzzzzzzzzzi_, default);
            bool? vzzzzzzzzzl_ = context.Operators.Not((bool?)(uzzzzzzzzzx_ is null));
            bool? vzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzj_, vzzzzzzzzzl_);
            bool? vzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzy_, vzzzzzzzzzm_);

            return vzzzzzzzzzn_;
        };
        IEnumerable<Condition> uzzzzzzzzzv_ = context.Operators.Where<Condition>(uzzzzzzzzzt_, uzzzzzzzzzu_);
        bool? uzzzzzzzzzw_ = context.Operators.Exists<Condition>(uzzzzzzzzzv_);

        return uzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> vzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzs_ = context.Operators.Union<Encounter>(vzzzzzzzzzp_, vzzzzzzzzzr_);
        CqlValueSet vzzzzzzzzzt_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> vzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzv_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> vzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzx_ = context.Operators.Union<Encounter>(vzzzzzzzzzu_, vzzzzzzzzzw_);
        IEnumerable<Encounter> vzzzzzzzzzy_ = context.Operators.Union<Encounter>(vzzzzzzzzzs_, vzzzzzzzzzx_);
        CqlValueSet vzzzzzzzzzz_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzb_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzd_ = context.Operators.Union<Encounter>(wzzzzzzzzza_, wzzzzzzzzzc_);
        IEnumerable<Encounter> wzzzzzzzzze_ = context.Operators.Union<Encounter>(vzzzzzzzzzy_, wzzzzzzzzzd_);
        CqlValueSet wzzzzzzzzzf_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> wzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzh_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> wzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzj_ = context.Operators.Union<Encounter>(wzzzzzzzzzg_, wzzzzzzzzzi_);
        IEnumerable<Encounter> wzzzzzzzzzk_ = context.Operators.Union<Encounter>(wzzzzzzzzze_, wzzzzzzzzzj_);
        CqlValueSet wzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> wzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzn_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzp_ = context.Operators.Union<Encounter>(wzzzzzzzzzm_, wzzzzzzzzzo_);
        IEnumerable<Encounter> wzzzzzzzzzq_ = context.Operators.Union<Encounter>(wzzzzzzzzzk_, wzzzzzzzzzp_);
        IEnumerable<Encounter> wzzzzzzzzzr_ = Status_1_8_000.Instance.isEncounterPerformed(context, wzzzzzzzzzq_);
        bool? wzzzzzzzzzs_(Encounter ValidEncounter)
        {
            Period wzzzzzzzzzu_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzu_);
            CqlInterval<CqlDateTime> wzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzv_ as object);
            CqlDateTime wzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzw_);
            CqlDate wzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzx_);
            CqlDate wzzzzzzzzzz_ = this.IPSD(context);
            CqlQuantity xzzzzzzzzza_ = context.Operators.Quantity(60m, "days");
            CqlDate xzzzzzzzzzb_ = context.Operators.Subtract(wzzzzzzzzzz_, xzzzzzzzzza_);
            CqlDate xzzzzzzzzze_ = context.Operators.Add(wzzzzzzzzzz_, xzzzzzzzzza_);
            CqlInterval<CqlDate> xzzzzzzzzzf_ = context.Operators.Interval(xzzzzzzzzzb_, xzzzzzzzzze_, true, true);
            bool? xzzzzzzzzzg_ = context.Operators.In<CqlDate>(wzzzzzzzzzy_, xzzzzzzzzzf_, default);
            bool? xzzzzzzzzzi_ = context.Operators.Not((bool?)(wzzzzzzzzzz_ is null));
            bool? xzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzg_, xzzzzzzzzzi_);

            return xzzzzzzzzzj_;
        };
        IEnumerable<Encounter> wzzzzzzzzzt_ = context.Operators.Where<Encounter>(wzzzzzzzzzr_, wzzzzzzzzzs_);

        return wzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient xzzzzzzzzzk_ = this.Patient(context);
        Date xzzzzzzzzzl_ = xzzzzzzzzzk_?.BirthDateElement;
        string xzzzzzzzzzm_ = xzzzzzzzzzl_?.Value;
        CqlDate xzzzzzzzzzn_ = context.Operators.ConvertStringToDate(xzzzzzzzzzm_);
        CqlDate xzzzzzzzzzo_ = this.IPSD(context);
        CqlDateTime xzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzo_);
        CqlDate xzzzzzzzzzq_ = context.Operators.DateFrom(xzzzzzzzzzp_);
        int? xzzzzzzzzzr_ = context.Operators.CalculateAgeAt(xzzzzzzzzzn_, xzzzzzzzzzq_, "year");
        bool? xzzzzzzzzzs_ = context.Operators.GreaterOrEqual(xzzzzzzzzzr_, 18);
        bool? xzzzzzzzzzt_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? xzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzs_, xzzzzzzzzzt_);
        IEnumerable<Encounter> xzzzzzzzzzv_ = this.Qualifying_Encounters(context);
        bool? xzzzzzzzzzw_ = context.Operators.Exists<Encounter>(xzzzzzzzzzv_);
        bool? xzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzu_, xzzzzzzzzzw_);

        return xzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzy_ = this.Initial_Population(context);

        return xzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? xzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlValueSet yzzzzzzzzza_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzb_, yzzzzzzzzzd_);
        IEnumerable<MedicationRequest> yzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationActive(context, yzzzzzzzzze_);
        bool? yzzzzzzzzzg_(MedicationRequest ActiveAntidepressant)
        {
            CqlDate yzzzzzzzzzk_ = this.IPSD(context);
            bool? yzzzzzzzzzl_ = context.Operators.Not((bool?)(yzzzzzzzzzk_ is null));
            CqlInterval<CqlDate> yzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate yzzzzzzzzzn_ = yzzzzzzzzzm_?.low;
            CqlDateTime yzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzn_);
            CqlDate yzzzzzzzzzq_ = yzzzzzzzzzm_?.high;
            CqlDateTime yzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzq_);
            bool? yzzzzzzzzzt_ = yzzzzzzzzzm_?.lowClosed;
            bool? yzzzzzzzzzv_ = yzzzzzzzzzm_?.highClosed;
            CqlInterval<CqlDateTime> yzzzzzzzzzw_ = context.Operators.Interval(yzzzzzzzzzo_, yzzzzzzzzzr_, yzzzzzzzzzt_, yzzzzzzzzzv_);
            CqlInterval<CqlDate> yzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, yzzzzzzzzzw_);
            CqlQuantity yzzzzzzzzzz_ = context.Operators.Quantity(105m, "days");
            CqlDate zzzzzzzzzza_ = context.Operators.Subtract(yzzzzzzzzzk_, yzzzzzzzzzz_);
            CqlInterval<CqlDate> zzzzzzzzzzc_ = context.Operators.Interval(zzzzzzzzzza_, yzzzzzzzzzk_, true, false);
            bool? zzzzzzzzzzd_ = context.Operators.Overlaps(yzzzzzzzzzx_, zzzzzzzzzzc_, default);
            bool? zzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzl_, zzzzzzzzzzd_);

            return zzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzf_, yzzzzzzzzzg_);
        bool? yzzzzzzzzzi_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzh_);
        bool? yzzzzzzzzzj_ = context.Operators.Or(xzzzzzzzzzz_, yzzzzzzzzzi_);

        return yzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzf_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> zzzzzzzzzzg_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, zzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> zzzzzzzzzzi_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, zzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> zzzzzzzzzzj_ = context.Operators.Union<MedicationDispense>(zzzzzzzzzzg_, zzzzzzzzzzi_);
        IEnumerable<MedicationDispense> zzzzzzzzzzk_ = Status_1_8_000.Instance.isMedicationDispensed(context, zzzzzzzzzzj_);
        CqlInterval<CqlDate> zzzzzzzzzzl_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> zzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate zzzzzzzzzzp_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzr_ = context.Operators.Quantity(114m, "days");
            CqlDate zzzzzzzzzzs_ = context.Operators.Add(zzzzzzzzzzp_, zzzzzzzzzzr_);
            CqlInterval<CqlDate> zzzzzzzzzzt_ = context.Operators.Interval(zzzzzzzzzzp_, zzzzzzzzzzs_, true, true);
            CqlInterval<CqlDate> zzzzzzzzzzu_ = context.Operators.Intersect<CqlDate>(zzzzzzzzzzo_, zzzzzzzzzzt_);

            return zzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzm_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(zzzzzzzzzzk_, zzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(zzzzzzzzzzm_);

        return zzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzv_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? zzzzzzzzzzw_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, zzzzzzzzzzv_);
        bool? zzzzzzzzzzx_ = context.Operators.GreaterOrEqual(zzzzzzzzzzw_, 84);

        return zzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        bool? zzzzzzzzzzy_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

        return zzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzz_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> azzzzzzzzzza_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, zzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> azzzzzzzzzzc_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, zzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> azzzzzzzzzzd_ = context.Operators.Union<MedicationDispense>(azzzzzzzzzza_, azzzzzzzzzzc_);
        IEnumerable<MedicationDispense> azzzzzzzzzze_ = Status_1_8_000.Instance.isMedicationDispensed(context, azzzzzzzzzzd_);
        CqlInterval<CqlDate> azzzzzzzzzzf_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> azzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate azzzzzzzzzzj_ = this.IPSD(context);
            CqlQuantity azzzzzzzzzzl_ = context.Operators.Quantity(231m, "days");
            CqlDate azzzzzzzzzzm_ = context.Operators.Add(azzzzzzzzzzj_, azzzzzzzzzzl_);
            CqlInterval<CqlDate> azzzzzzzzzzn_ = context.Operators.Interval(azzzzzzzzzzj_, azzzzzzzzzzm_, true, true);
            CqlInterval<CqlDate> azzzzzzzzzzo_ = context.Operators.Intersect<CqlDate>(azzzzzzzzzzi_, azzzzzzzzzzn_);

            return azzzzzzzzzzo_;
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzg_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(azzzzzzzzzze_, azzzzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzzzg_);

        return azzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzp_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? azzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, azzzzzzzzzzp_);
        bool? azzzzzzzzzzr_ = context.Operators.GreaterOrEqual(azzzzzzzzzzq_, 180);

        return azzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? azzzzzzzzzzs_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

        return azzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzw_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
