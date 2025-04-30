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
        CqlDateTime azzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzm_ = context.Operators.Interval(azzzzzzzzzzzzzk_, azzzzzzzzzzzzzl_, true, true);
        object azzzzzzzzzzzzzn_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.001", "Measurement Period", azzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzq_);
        int? azzzzzzzzzzzzzs_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzzzzr_, "year");
        int? azzzzzzzzzzzzzt_ = context.Operators.Subtract(azzzzzzzzzzzzzs_, 1);
        decimal? azzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime azzzzzzzzzzzzzv_ = context.Operators.DateTime(azzzzzzzzzzzzzt_, 5, 1, 0, 0, 0, 0, azzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzw_);
        int? azzzzzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzzzzx_, "year");
        decimal? azzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime bzzzzzzzzzzzzza_ = context.Operators.DateTime(azzzzzzzzzzzzzy_, 4, 30, 23, 59, 59, 0, azzzzzzzzzzzzzz_);

        return bzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime bzzzzzzzzzzzzzb_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzc_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzc_, true, true);

        return bzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Earliest Antidepressant Dispensed During Intake Period")]
    public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzze_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, bzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationDispense>(bzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzh_);
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isMedicationDispensed(context, bzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzk_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> bzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate bzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzt_);
            CqlDateTime bzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzw_ = this.Intake_Period(context);
            bool? bzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzw_, "day");

            return bzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationDispense> bzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationDispense>(bzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? bzzzzzzzzzzzzzm_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> bzzzzzzzzzzzzzy_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate bzzzzzzzzzzzzzz_ = context.Operators.Start(bzzzzzzzzzzzzzy_);
            CqlDateTime czzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzz_);
            CqlDate czzzzzzzzzzzzzb_ = context.Operators.DateFrom(czzzzzzzzzzzzza_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? czzzzzzzzzzzzzc_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, czzzzzzzzzzzzzb_);

            return czzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> bzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> bzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(bzzzzzzzzzzzzzn_);
        object bzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this)
        {
            CqlDate czzzzzzzzzzzzzd_ = @this?.AntidepressantDate;

            return czzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> bzzzzzzzzzzzzzq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(bzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? bzzzzzzzzzzzzzr_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(bzzzzzzzzzzzzzq_);
        CqlDate bzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzr_?.AntidepressantDate;

        return bzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate czzzzzzzzzzzzze_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);

        return czzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzf_ = this.Major_Depression(context);
        IEnumerable<Condition> czzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzh_(Condition MajorDepression)
        {
            CqlDate czzzzzzzzzzzzzk_ = this.IPSD(context);
            bool? czzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzk_ is null));
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime czzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzm_);
            CqlDate czzzzzzzzzzzzzo_ = context.Operators.DateFrom(czzzzzzzzzzzzzn_);
            CqlQuantity czzzzzzzzzzzzzq_ = context.Operators.Quantity(60m, "days");
            CqlDate czzzzzzzzzzzzzr_ = context.Operators.Subtract(czzzzzzzzzzzzzk_, czzzzzzzzzzzzzq_);
            CqlDate czzzzzzzzzzzzzu_ = context.Operators.Add(czzzzzzzzzzzzzk_, czzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzv_ = context.Operators.Interval(czzzzzzzzzzzzzr_, czzzzzzzzzzzzzu_, true, true);
            bool? czzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzo_, czzzzzzzzzzzzzv_, default);
            bool? czzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzk_ is null));
            bool? czzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzw_, czzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzl_, czzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzg_, czzzzzzzzzzzzzh_);
        bool? czzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzze_);
        CqlValueSet dzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzi_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzk_);
        CqlValueSet dzzzzzzzzzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzo_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzq_);
        CqlValueSet dzzzzzzzzzzzzzs_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzu_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzw_);
        CqlValueSet dzzzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzza_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzb_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzc_);
        IEnumerable<Encounter> ezzzzzzzzzzzzze_ = Status_1_8_000.Instance.isEncounterPerformed(context, ezzzzzzzzzzzzzd_);
        bool? ezzzzzzzzzzzzzf_(Encounter ValidEncounter)
        {
            Period ezzzzzzzzzzzzzh_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzi_ as object);
            CqlDateTime ezzzzzzzzzzzzzk_ = context.Operators.Start(ezzzzzzzzzzzzzj_);
            CqlDate ezzzzzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzzzzk_);
            CqlDate ezzzzzzzzzzzzzm_ = this.IPSD(context);
            CqlQuantity ezzzzzzzzzzzzzn_ = context.Operators.Quantity(60m, "days");
            CqlDate ezzzzzzzzzzzzzo_ = context.Operators.Subtract(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzn_);
            CqlDate ezzzzzzzzzzzzzr_ = context.Operators.Add(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzs_ = context.Operators.Interval(ezzzzzzzzzzzzzo_, ezzzzzzzzzzzzzr_, true, true);
            bool? ezzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzl_, ezzzzzzzzzzzzzs_, default);
            bool? ezzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzm_ is null));
            bool? ezzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzt_, ezzzzzzzzzzzzzv_);

            return ezzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzze_, ezzzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzx_ = this.Patient(context);
        Date ezzzzzzzzzzzzzy_ = ezzzzzzzzzzzzzx_?.BirthDateElement;
        string ezzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzy_?.Value;
        CqlDate fzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzz_);
        CqlDate fzzzzzzzzzzzzzb_ = this.IPSD(context);
        CqlDateTime fzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzb_);
        CqlDate fzzzzzzzzzzzzzd_ = context.Operators.DateFrom(fzzzzzzzzzzzzzc_);
        int? fzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzza_, fzzzzzzzzzzzzzd_, "year");
        bool? fzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzze_, 18);
        bool? fzzzzzzzzzzzzzg_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? fzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzi_ = this.Qualifying_Encounters(context);
        bool? fzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzi_);
        bool? fzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzl_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzm_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlValueSet fzzzzzzzzzzzzzn_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationActive(context, fzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzt_(MedicationRequest ActiveAntidepressant)
        {
            CqlDate fzzzzzzzzzzzzzx_ = this.IPSD(context);
            bool? fzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzx_ is null));
            CqlInterval<CqlDate> fzzzzzzzzzzzzzz_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate gzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzz_?.low;
            CqlDateTime gzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(gzzzzzzzzzzzzza_);
            CqlDate gzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzz_?.high;
            CqlDateTime gzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(gzzzzzzzzzzzzzd_);
            bool? gzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzz_?.lowClosed;
            bool? gzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzz_?.highClosed;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzj_ = context.Operators.Interval(gzzzzzzzzzzzzzb_, gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, gzzzzzzzzzzzzzj_);
            CqlQuantity gzzzzzzzzzzzzzm_ = context.Operators.Quantity(105m, "days");
            CqlDate gzzzzzzzzzzzzzn_ = context.Operators.Subtract(fzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzp_ = context.Operators.Interval(gzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzx_, true, false);
            bool? gzzzzzzzzzzzzzq_ = context.Operators.Overlaps(gzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzp_, default);
            bool? gzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzq_);

            return gzzzzzzzzzzzzzr_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(fzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzv_ = context.Operators.Exists<MedicationRequest>(fzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzw_ = context.Operators.Or(fzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzs_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> gzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, gzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> gzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, gzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> gzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationDispense>(gzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzv_);
        IEnumerable<MedicationDispense> gzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isMedicationDispensed(context, gzzzzzzzzzzzzzw_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzy_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> hzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate hzzzzzzzzzzzzzc_ = this.IPSD(context);
            CqlQuantity hzzzzzzzzzzzzze_ = context.Operators.Quantity(114m, "days");
            CqlDate hzzzzzzzzzzzzzf_ = context.Operators.Add(hzzzzzzzzzzzzzc_, hzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzg_ = context.Operators.Interval(hzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzf_, true, true);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzh_ = context.Operators.Intersect<CqlDate>(hzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzg_);

            return hzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(gzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzi_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? hzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, hzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzj_, 84);

        return hzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzl_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

        return hzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzm_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> hzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, hzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> hzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, hzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> hzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationDispense>(hzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzp_);
        IEnumerable<MedicationDispense> hzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isMedicationDispensed(context, hzzzzzzzzzzzzzq_);
        CqlInterval<CqlDate> hzzzzzzzzzzzzzs_(MedicationDispense Antidepressant)
        {
            CqlInterval<CqlDate> hzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate hzzzzzzzzzzzzzw_ = this.IPSD(context);
            CqlQuantity hzzzzzzzzzzzzzy_ = context.Operators.Quantity(231m, "days");
            CqlDate hzzzzzzzzzzzzzz_ = context.Operators.Add(hzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> izzzzzzzzzzzzza_ = context.Operators.Interval(hzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzz_, true, true);
            CqlInterval<CqlDate> izzzzzzzzzzzzzb_ = context.Operators.Intersect<CqlDate>(hzzzzzzzzzzzzzv_, izzzzzzzzzzzzza_);

            return izzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(hzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzc_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? izzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, izzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzd_, 180);

        return izzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? izzzzzzzzzzzzzf_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

        return izzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
