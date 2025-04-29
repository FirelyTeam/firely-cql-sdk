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
[CqlLibrary("HybridHWMFHIR", "0.102.005")]
public partial class HybridHWMFHIR_0_102_005 : ILibrary, ISingleton<HybridHWMFHIR_0_102_005>
{
    private HybridHWMFHIR_0_102_005() {}

    public static HybridHWMFHIR_0_102_005 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HybridHWMFHIR";
    public string Version => "0.102.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Medicare payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_payer(CqlContext _) => _Medicare_payer;
    private static readonly CqlValueSet _Medicare_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Platelet count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext _) => _Platelet_count_lab_test;
    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC:2.69")]
    public CqlCodeSystem LOINC_2_69(CqlContext _) => _LOINC_2_69;
    private static readonly CqlCodeSystem _LOINC_2_69 = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzs_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime azzzzzzzzzzzzzt_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzu_ = context.Operators.Interval(azzzzzzzzzzzzzs_, azzzzzzzzzzzzzt_, true, false);
        object azzzzzzzzzzzzzv_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", azzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime bzzzzzzzzzzzzzc_ = context.Operators.Start(Value);
        CqlDateTime bzzzzzzzzzzzzzd_ = context.Operators.End(Value);
        int? bzzzzzzzzzzzzze_ = context.Operators.DifferenceBetween(bzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzd_, "day");

        return bzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzf_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet bzzzzzzzzzzzzzh_ = this.Medicare_payer(context);
        IEnumerable<Coverage> bzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, bzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> bzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, Coverage>(bzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? bzzzzzzzzzzzzzk_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? bzzzzzzzzzzzzzr_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> bzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(bzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzs_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string bzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzs_);
            bool? bzzzzzzzzzzzzzu_ = context.Operators.Equal(bzzzzzzzzzzzzzt_, "finished");
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? bzzzzzzzzzzzzzw_ = this.LengthInDays(context, bzzzzzzzzzzzzzv_);
            bool? bzzzzzzzzzzzzzx_ = context.Operators.Less(bzzzzzzzzzzzzzw_, 365);
            bool? bzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzx_);
            Period bzzzzzzzzzzzzzz_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzz_);
            CqlDateTime czzzzzzzzzzzzzb_ = context.Operators.End(czzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzb_, czzzzzzzzzzzzzc_, "day");
            bool? czzzzzzzzzzzzze_ = context.Operators.And(bzzzzzzzzzzzzzy_, czzzzzzzzzzzzzd_);
            Patient czzzzzzzzzzzzzf_ = this.Patient(context);
            Date czzzzzzzzzzzzzg_ = czzzzzzzzzzzzzf_?.BirthDateElement;
            string czzzzzzzzzzzzzh_ = czzzzzzzzzzzzzg_?.Value;
            CqlDate czzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzz_);
            CqlDateTime czzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzk_);
            CqlDate czzzzzzzzzzzzzm_ = context.Operators.DateFrom(czzzzzzzzzzzzzl_);
            int? czzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzi_, czzzzzzzzzzzzzm_, "year");
            CqlInterval<int?> czzzzzzzzzzzzzo_ = context.Operators.Interval(65, 94, true, true);
            bool? czzzzzzzzzzzzzp_ = context.Operators.In<int?>(czzzzzzzzzzzzzn_, czzzzzzzzzzzzzo_, default);
            bool? czzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzze_, czzzzzzzzzzzzzp_);

            return czzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> bzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzm_);
        Encounter bzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> bzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(bzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);

        return czzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzs_ = this.Inpatient_Encounters(context);
        string czzzzzzzzzzzzzt_(Encounter Encounter)
        {
            string czzzzzzzzzzzzzw_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string czzzzzzzzzzzzzx_ = context.Operators.Concatenate(czzzzzzzzzzzzzw_ ?? "", ",");
            Id czzzzzzzzzzzzzy_ = Encounter?.IdElement;
            string czzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzy_);
            string dzzzzzzzzzzzzza_ = context.Operators.Concatenate(czzzzzzzzzzzzzx_ ?? "", czzzzzzzzzzzzzz_ ?? "");
            string dzzzzzzzzzzzzzb_ = context.Operators.Concatenate(dzzzzzzzzzzzzza_ ?? "", " , ");
            bool? dzzzzzzzzzzzzzc_(Observation Exam)
            {
                DataType dzzzzzzzzzzzzzw_ = Exam?.Effective;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzw_);
                CqlDateTime dzzzzzzzzzzzzzy_ = context.Operators.Start(dzzzzzzzzzzzzzx_);
                bool? dzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzy_ is null));
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzw_);
                CqlDateTime ezzzzzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzzzzb_);
                Period ezzzzzzzzzzzzzd_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzd_);
                CqlDateTime ezzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzze_);
                CqlQuantity ezzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzh_ = context.Operators.Subtract(ezzzzzzzzzzzzzf_, ezzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzd_);
                CqlDateTime ezzzzzzzzzzzzzk_ = context.Operators.Start(ezzzzzzzzzzzzzj_);
                CqlQuantity ezzzzzzzzzzzzzl_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzm_ = context.Operators.Add(ezzzzzzzzzzzzzk_, ezzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzn_ = context.Operators.Interval(ezzzzzzzzzzzzzh_, ezzzzzzzzzzzzzm_, true, true);
                bool? ezzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzc_, ezzzzzzzzzzzzzn_, default);
                bool? ezzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzo_);
                Code<ObservationStatus> ezzzzzzzzzzzzzq_ = Exam?.StatusElement;
                string ezzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzq_);
                string[] ezzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzt_ = context.Operators.In<string>(ezzzzzzzzzzzzzr_, ezzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzzzzp_, ezzzzzzzzzzzzzt_);
                DataType ezzzzzzzzzzzzzv_ = Exam?.Value;
                bool? ezzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzv_ is null));
                bool? ezzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ExamList, dzzzzzzzzzzzzzc_);
            object dzzzzzzzzzzzzze_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzy_ = @this?.Effective;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzy_);
                CqlDateTime fzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzz_);

                return fzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzd_, dzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzf_);
            DataType dzzzzzzzzzzzzzh_ = dzzzzzzzzzzzzzg_?.Value;
            CqlQuantity dzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dzzzzzzzzzzzzzh_ as Quantity);
            string dzzzzzzzzzzzzzj_ = context.Operators.ConvertQuantityToString(dzzzzzzzzzzzzzi_);
            string dzzzzzzzzzzzzzk_ = context.Operators.Concatenate(dzzzzzzzzzzzzzb_ ?? "", dzzzzzzzzzzzzzj_ ?? "");
            string dzzzzzzzzzzzzzl_ = context.Operators.Concatenate(dzzzzzzzzzzzzzk_ ?? "", ",");
            bool? dzzzzzzzzzzzzzm_(Observation Exam)
            {
                DataType fzzzzzzzzzzzzzb_ = Exam?.Effective;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzb_);
                CqlDateTime fzzzzzzzzzzzzzd_ = context.Operators.Start(fzzzzzzzzzzzzzc_);
                bool? fzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzd_ is null));
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzb_);
                CqlDateTime fzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzg_);
                Period fzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzzzzzzj_);
                CqlQuantity fzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzm_ = context.Operators.Subtract(fzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzzo_);
                CqlQuantity fzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzr_ = context.Operators.Add(fzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzs_ = context.Operators.Interval(fzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzr_, true, true);
                bool? fzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzs_, default);
                bool? fzzzzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzzzze_, fzzzzzzzzzzzzzt_);
                Code<ObservationStatus> fzzzzzzzzzzzzzv_ = Exam?.StatusElement;
                string fzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzv_);
                string[] fzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? fzzzzzzzzzzzzzy_ = context.Operators.In<string>(fzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzy_);
                DataType gzzzzzzzzzzzzza_ = Exam?.Value;
                bool? gzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzza_ is null));
                bool? gzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzb_);

                return gzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ExamList, dzzzzzzzzzzzzzm_);
            object dzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzd_ = @this?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzp_);
            DataType dzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzq_?.Effective;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzs_);
            string dzzzzzzzzzzzzzu_ = context.Operators.ConvertDateTimeToString(dzzzzzzzzzzzzzt_);
            string dzzzzzzzzzzzzzv_ = context.Operators.Concatenate(dzzzzzzzzzzzzzl_ ?? "", dzzzzzzzzzzzzzu_ ?? "");

            return dzzzzzzzzzzzzzv_;
        };
        IEnumerable<string> czzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, string>(czzzzzzzzzzzzzs_, czzzzzzzzzzzzzt_);
        IEnumerable<string> czzzzzzzzzzzzzv_ = context.Operators.Distinct<string>(czzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);
        string gzzzzzzzzzzzzzh_(Encounter Encounter)
        {
            string gzzzzzzzzzzzzzk_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string gzzzzzzzzzzzzzl_ = context.Operators.Concatenate(gzzzzzzzzzzzzzk_ ?? "", ",");
            Id gzzzzzzzzzzzzzm_ = Encounter?.IdElement;
            string gzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzm_);
            string gzzzzzzzzzzzzzo_ = context.Operators.Concatenate(gzzzzzzzzzzzzzl_ ?? "", gzzzzzzzzzzzzzn_ ?? "");
            string gzzzzzzzzzzzzzp_ = context.Operators.Concatenate(gzzzzzzzzzzzzzo_ ?? "", ",");
            bool? gzzzzzzzzzzzzzq_(Observation Lab)
            {
                Instant hzzzzzzzzzzzzzj_ = Lab?.IssuedElement;
                bool? hzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzj_ is null));
                CqlDateTime hzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzzj_);
                Period hzzzzzzzzzzzzzn_ = Encounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzo_);
                CqlQuantity hzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzt_);
                CqlDateTime hzzzzzzzzzzzzzw_ = context.Operators.Add(hzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzw_, true, true);
                bool? hzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzx_, default);
                bool? hzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzy_);
                Code<ObservationStatus> izzzzzzzzzzzzza_ = Lab?.StatusElement;
                string izzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzza_);
                string[] izzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? izzzzzzzzzzzzzd_ = context.Operators.In<string>(izzzzzzzzzzzzzb_, izzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzze_ = context.Operators.And(hzzzzzzzzzzzzzz_, izzzzzzzzzzzzzd_);
                DataType izzzzzzzzzzzzzf_ = Lab?.Value;
                bool? izzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzf_ is null));
                bool? izzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzze_, izzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(LabList, gzzzzzzzzzzzzzq_);
            object gzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant izzzzzzzzzzzzzi_ = @this?.IssuedElement;

                return izzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzt_);
            DataType gzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzu_?.Value;
            CqlQuantity gzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzzzzzzzzzv_ as Quantity);
            string gzzzzzzzzzzzzzx_ = context.Operators.ConvertQuantityToString(gzzzzzzzzzzzzzw_);
            string gzzzzzzzzzzzzzy_ = context.Operators.Concatenate(gzzzzzzzzzzzzzp_ ?? "", gzzzzzzzzzzzzzx_ ?? "");
            string gzzzzzzzzzzzzzz_ = context.Operators.Concatenate(gzzzzzzzzzzzzzy_ ?? "", ",");
            bool? hzzzzzzzzzzzzza_(Observation Lab)
            {
                Instant izzzzzzzzzzzzzj_ = Lab?.IssuedElement;
                bool? izzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzj_ is null));
                CqlDateTime izzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzzzzzzj_);
                Period izzzzzzzzzzzzzn_ = Encounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzzo_);
                CqlQuantity izzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzr_ = context.Operators.Subtract(izzzzzzzzzzzzzp_, izzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzzzzzu_ = context.Operators.Start(izzzzzzzzzzzzzt_);
                CqlDateTime izzzzzzzzzzzzzw_ = context.Operators.Add(izzzzzzzzzzzzzu_, izzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzx_ = context.Operators.Interval(izzzzzzzzzzzzzr_, izzzzzzzzzzzzzw_, true, true);
                bool? izzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzm_, izzzzzzzzzzzzzx_, default);
                bool? izzzzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzzzk_, izzzzzzzzzzzzzy_);
                Code<ObservationStatus> jzzzzzzzzzzzzza_ = Lab?.StatusElement;
                string jzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzza_);
                string[] jzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? jzzzzzzzzzzzzzd_ = context.Operators.In<string>(jzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzz_, jzzzzzzzzzzzzzd_);
                DataType jzzzzzzzzzzzzzf_ = Lab?.Value;
                bool? jzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzf_ is null));
                bool? jzzzzzzzzzzzzzh_ = context.Operators.And(jzzzzzzzzzzzzze_, jzzzzzzzzzzzzzg_);

                return jzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(LabList, hzzzzzzzzzzzzza_);
            object hzzzzzzzzzzzzzc_(Observation @this)
            {
                Instant jzzzzzzzzzzzzzi_ = @this?.IssuedElement;

                return jzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzze_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzd_);
            Instant hzzzzzzzzzzzzzf_ = hzzzzzzzzzzzzze_?.IssuedElement;
            CqlDateTime hzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzzf_);
            string hzzzzzzzzzzzzzh_ = context.Operators.ConvertDateTimeToString(hzzzzzzzzzzzzzg_);
            string hzzzzzzzzzzzzzi_ = context.Operators.Concatenate(gzzzzzzzzzzzzzz_ ?? "", hzzzzzzzzzzzzzh_ ?? "");

            return hzzzzzzzzzzzzzi_;
        };
        IEnumerable<string> gzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, string>(gzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzh_);
        IEnumerable<string> gzzzzzzzzzzzzzj_ = context.Operators.Distinct<string>(gzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzj_ = this.Heart_rate(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzj_);
        IEnumerable<Observation> jzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzk_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> jzzzzzzzzzzzzzm_ = this.FirstPhysicalExamWithEncounterId(context, jzzzzzzzzzzzzzl_, "FirstHeartRate");
        CqlCode jzzzzzzzzzzzzzn_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzn_);
        IEnumerable<Observation> jzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzo_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> jzzzzzzzzzzzzzq_ = this.FirstPhysicalExamWithEncounterId(context, jzzzzzzzzzzzzzp_, "FirstSystolicBP");
        CqlValueSet jzzzzzzzzzzzzzr_ = this.Body_temperature(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> jzzzzzzzzzzzzzt_ = this.FirstPhysicalExamWithEncounterId(context, jzzzzzzzzzzzzzs_, "FirstTemperature");
        CqlCode jzzzzzzzzzzzzzu_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzu_);
        IEnumerable<Observation> jzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzv_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> jzzzzzzzzzzzzzx_ = this.FirstPhysicalExamWithEncounterId(context, jzzzzzzzzzzzzzw_, "FirstO2Saturation");
        CqlValueSet jzzzzzzzzzzzzzy_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzza_ = this.FirstLabTestWithEncounterId(context, jzzzzzzzzzzzzzz_, "FirstHematocrit");
        CqlValueSet kzzzzzzzzzzzzzb_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzzd_ = this.FirstLabTestWithEncounterId(context, kzzzzzzzzzzzzzc_, "FirstPlateletCount");
        CqlValueSet kzzzzzzzzzzzzze_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzzg_ = this.FirstLabTestWithEncounterId(context, kzzzzzzzzzzzzzf_, "FirstWhiteBloodCell");
        CqlValueSet kzzzzzzzzzzzzzh_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzzj_ = this.FirstLabTestWithEncounterId(context, kzzzzzzzzzzzzzi_, "FirstSodium");
        CqlValueSet kzzzzzzzzzzzzzk_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzzm_ = this.FirstLabTestWithEncounterId(context, kzzzzzzzzzzzzzl_, "FirstBicarbonate");
        CqlValueSet kzzzzzzzzzzzzzn_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> kzzzzzzzzzzzzzp_ = this.FirstLabTestWithEncounterId(context, kzzzzzzzzzzzzzo_, "FirstCreatinine");
        IEnumerable<string>[] kzzzzzzzzzzzzzq_ = [
            jzzzzzzzzzzzzzm_,
            jzzzzzzzzzzzzzq_,
            jzzzzzzzzzzzzzt_,
            jzzzzzzzzzzzzzx_,
            kzzzzzzzzzzzzza_,
            kzzzzzzzzzzzzzd_,
            kzzzzzzzzzzzzzg_,
            kzzzzzzzzzzzzzj_,
            kzzzzzzzzzzzzzm_,
            kzzzzzzzzzzzzzp_,
        ];
        IEnumerable<string> kzzzzzzzzzzzzzr_ = context.Operators.Flatten<string>(kzzzzzzzzzzzzzq_ as IEnumerable<IEnumerable<string>>);

        return kzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate kzzzzzzzzzzzzzs_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate kzzzzzzzzzzzzzt_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? kzzzzzzzzzzzzzu_ = context.Operators.DurationBetween(kzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzt_, "year");

        return kzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? kzzzzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? kzzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? kzzzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? kzzzzzzzzzzzzzy_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime kzzzzzzzzzzzzzz_ = context.Operators.DateTime(kzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzx_, 0, 0, 0, 0, kzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime lzzzzzzzzzzzzza_ = context.Operators.Start(Stay);
        CqlDateTime lzzzzzzzzzzzzzb_ = context.Operators.End(Stay);
        int? lzzzzzzzzzzzzzc_ = context.Operators.DifferenceBetween(lzzzzzzzzzzzzza_, lzzzzzzzzzzzzzb_, "day");

        return lzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] lzzzzzzzzzzzzzd_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzze_(Encounter Visit)
        {
            CqlValueSet lzzzzzzzzzzzzzi_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> lzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? lzzzzzzzzzzzzzk_(Encounter LastED)
            {
                Period mzzzzzzzzzzzzzj_ = LastED?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzj_);
                CqlDateTime mzzzzzzzzzzzzzl_ = context.Operators.End(mzzzzzzzzzzzzzk_);
                CqlValueSet mzzzzzzzzzzzzzm_ = this.Observation_Services(context);
                IEnumerable<Encounter> mzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? mzzzzzzzzzzzzzo_(Encounter LastObs)
                {
                    Period ozzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzf_);
                    CqlDateTime ozzzzzzzzzzzzzh_ = context.Operators.End(ozzzzzzzzzzzzzg_);
                    Period ozzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzi_);
                    CqlDateTime ozzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzj_);
                    CqlQuantity ozzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzzzzzzzzzm_ = context.Operators.Subtract(ozzzzzzzzzzzzzk_, ozzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzi_);
                    CqlDateTime ozzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzq_ = context.Operators.Interval(ozzzzzzzzzzzzzm_, ozzzzzzzzzzzzzp_, true, true);
                    bool? ozzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzh_, ozzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzi_);
                    CqlDateTime ozzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzt_);
                    bool? ozzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzu_ is null));
                    bool? ozzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzr_, ozzzzzzzzzzzzzv_);

                    return ozzzzzzzzzzzzzw_;
                };
                IEnumerable<Encounter> mzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzo_);
                object mzzzzzzzzzzzzzq_(Encounter @this)
                {
                    Period ozzzzzzzzzzzzzx_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzx_);
                    CqlDateTime ozzzzzzzzzzzzzz_ = context.Operators.End(ozzzzzzzzzzzzzy_);

                    return ozzzzzzzzzzzzzz_;
                };
                IEnumerable<Encounter> mzzzzzzzzzzzzzr_ = context.Operators.SortBy<Encounter>(mzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzzzzzzzzzs_ = context.Operators.Last<Encounter>(mzzzzzzzzzzzzzr_);
                Period mzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzt_);
                CqlDateTime mzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzu_);
                Period mzzzzzzzzzzzzzw_ = Visit?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzw_);
                CqlDateTime mzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzx_);
                CqlQuantity mzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime nzzzzzzzzzzzzza_ = context.Operators.Subtract(mzzzzzzzzzzzzzv_ ?? mzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzz_);
                IEnumerable<Encounter> nzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? nzzzzzzzzzzzzzd_(Encounter LastObs)
                {
                    Period pzzzzzzzzzzzzza_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzza_);
                    CqlDateTime pzzzzzzzzzzzzzc_ = context.Operators.End(pzzzzzzzzzzzzzb_);
                    Period pzzzzzzzzzzzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzd_);
                    CqlDateTime pzzzzzzzzzzzzzf_ = context.Operators.Start(pzzzzzzzzzzzzze_);
                    CqlQuantity pzzzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzzzzzzzzzzzh_ = context.Operators.Subtract(pzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzd_);
                    CqlDateTime pzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzj_);
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzl_ = context.Operators.Interval(pzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzk_, true, true);
                    bool? pzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzl_, default);
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzd_);
                    CqlDateTime pzzzzzzzzzzzzzp_ = context.Operators.Start(pzzzzzzzzzzzzzo_);
                    bool? pzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzp_ is null));
                    bool? pzzzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzq_);

                    return pzzzzzzzzzzzzzr_;
                };
                IEnumerable<Encounter> nzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzd_);
                object nzzzzzzzzzzzzzf_(Encounter @this)
                {
                    Period pzzzzzzzzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzs_);
                    CqlDateTime pzzzzzzzzzzzzzu_ = context.Operators.End(pzzzzzzzzzzzzzt_);

                    return pzzzzzzzzzzzzzu_;
                };
                IEnumerable<Encounter> nzzzzzzzzzzzzzg_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter nzzzzzzzzzzzzzh_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzg_);
                Period nzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzh_?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzk_ = context.Operators.Start(nzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzw_);
                CqlDateTime nzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzo_ = context.Operators.Interval(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzk_ ?? nzzzzzzzzzzzzzn_, true, true);
                bool? nzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzo_, default);
                IEnumerable<Encounter> nzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? nzzzzzzzzzzzzzs_(Encounter LastObs)
                {
                    Period pzzzzzzzzzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzv_);
                    CqlDateTime pzzzzzzzzzzzzzx_ = context.Operators.End(pzzzzzzzzzzzzzw_);
                    Period pzzzzzzzzzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzy_);
                    CqlDateTime qzzzzzzzzzzzzza_ = context.Operators.Start(pzzzzzzzzzzzzzz_);
                    CqlQuantity qzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzzzzzzzzc_ = context.Operators.Subtract(qzzzzzzzzzzzzza_, qzzzzzzzzzzzzzb_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzy_);
                    CqlDateTime qzzzzzzzzzzzzzf_ = context.Operators.Start(qzzzzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzg_ = context.Operators.Interval(qzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzf_, true, true);
                    bool? qzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzg_, default);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzy_);
                    CqlDateTime qzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzj_);
                    bool? qzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzk_ is null));
                    bool? qzzzzzzzzzzzzzm_ = context.Operators.And(qzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzl_);

                    return qzzzzzzzzzzzzzm_;
                };
                IEnumerable<Encounter> nzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzs_);
                object nzzzzzzzzzzzzzu_(Encounter @this)
                {
                    Period qzzzzzzzzzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzn_);
                    CqlDateTime qzzzzzzzzzzzzzp_ = context.Operators.End(qzzzzzzzzzzzzzo_);

                    return qzzzzzzzzzzzzzp_;
                };
                IEnumerable<Encounter> nzzzzzzzzzzzzzv_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter nzzzzzzzzzzzzzw_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzv_);
                Period nzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzw_?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzx_);
                CqlDateTime nzzzzzzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzb_);
                bool? ozzzzzzzzzzzzzd_ = context.Operators.Not((bool?)((nzzzzzzzzzzzzzz_ ?? ozzzzzzzzzzzzzc_) is null));
                bool? ozzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzk_);
            object lzzzzzzzzzzzzzm_(Encounter @this)
            {
                Period qzzzzzzzzzzzzzq_ = @this?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzq_);
                CqlDateTime qzzzzzzzzzzzzzs_ = context.Operators.End(qzzzzzzzzzzzzzr_);

                return qzzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzn_ = context.Operators.SortBy<Encounter>(lzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter lzzzzzzzzzzzzzo_ = context.Operators.Last<Encounter>(lzzzzzzzzzzzzzn_);
            Period lzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzo_?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzq_);
            CqlValueSet lzzzzzzzzzzzzzs_ = this.Observation_Services(context);
            IEnumerable<Encounter> lzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? lzzzzzzzzzzzzzu_(Encounter LastObs)
            {
                Period qzzzzzzzzzzzzzt_ = LastObs?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzt_);
                CqlDateTime qzzzzzzzzzzzzzv_ = context.Operators.End(qzzzzzzzzzzzzzu_);
                Period qzzzzzzzzzzzzzw_ = Visit?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzw_);
                CqlDateTime qzzzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzzzx_);
                CqlQuantity qzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime rzzzzzzzzzzzzza_ = context.Operators.Subtract(qzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzw_);
                CqlDateTime rzzzzzzzzzzzzzd_ = context.Operators.Start(rzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzze_ = context.Operators.Interval(rzzzzzzzzzzzzza_, rzzzzzzzzzzzzzd_, true, true);
                bool? rzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzv_, rzzzzzzzzzzzzze_, default);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzw_);
                CqlDateTime rzzzzzzzzzzzzzi_ = context.Operators.Start(rzzzzzzzzzzzzzh_);
                bool? rzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzi_ is null));
                bool? rzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzj_);

                return rzzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzu_);
            object lzzzzzzzzzzzzzw_(Encounter @this)
            {
                Period rzzzzzzzzzzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzl_);
                CqlDateTime rzzzzzzzzzzzzzn_ = context.Operators.End(rzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzx_ = context.Operators.SortBy<Encounter>(lzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter lzzzzzzzzzzzzzy_ = context.Operators.Last<Encounter>(lzzzzzzzzzzzzzx_);
            Period lzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzy_?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzz_);
            CqlDateTime mzzzzzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzzzzzza_);
            Period mzzzzzzzzzzzzzc_ = Visit?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzzh_ = context.Operators.End(mzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzi_ = context.Operators.Interval(lzzzzzzzzzzzzzr_ ?? mzzzzzzzzzzzzzb_ ?? mzzzzzzzzzzzzze_, mzzzzzzzzzzzzzh_, true, true);

            return mzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)lzzzzzzzzzzzzzd_, lzzzzzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzo_ = this.HospitalizationWithObservation(context, Encounter);
        int? rzzzzzzzzzzzzzp_ = this.LengthInDays(context, rzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
