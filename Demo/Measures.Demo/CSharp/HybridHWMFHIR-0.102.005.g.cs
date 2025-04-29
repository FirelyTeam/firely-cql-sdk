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
        CqlDateTime xzzzzzzzzzzzzzh_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime xzzzzzzzzzzzzzi_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzj_ = context.Operators.Interval(xzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzi_, true, false);
        object xzzzzzzzzzzzzzk_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", xzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient xzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzl_);

        return xzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> xzzzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> xzzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> xzzzzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime xzzzzzzzzzzzzzr_ = context.Operators.Start(Value);
        CqlDateTime xzzzzzzzzzzzzzs_ = context.Operators.End(Value);
        int? xzzzzzzzzzzzzzt_ = context.Operators.DifferenceBetween(xzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzs_, "day");

        return xzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzu_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet xzzzzzzzzzzzzzw_ = this.Medicare_payer(context);
        IEnumerable<Coverage> xzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, xzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> xzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<Encounter, Coverage>(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? xzzzzzzzzzzzzzz_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? yzzzzzzzzzzzzzg_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return yzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> yzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(xzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzh_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string yzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzh_);
            bool? yzzzzzzzzzzzzzj_ = context.Operators.Equal(yzzzzzzzzzzzzzi_, "finished");
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? yzzzzzzzzzzzzzl_ = this.LengthInDays(context, yzzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzzm_ = context.Operators.Less(yzzzzzzzzzzzzzl_, 365);
            bool? yzzzzzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzm_);
            Period yzzzzzzzzzzzzzo_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzo_);
            CqlDateTime yzzzzzzzzzzzzzq_ = context.Operators.End(yzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzr_, "day");
            bool? yzzzzzzzzzzzzzt_ = context.Operators.And(yzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzs_);
            Patient yzzzzzzzzzzzzzu_ = this.Patient(context);
            Date yzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzu_?.BirthDateElement;
            string yzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzv_?.Value;
            CqlDate yzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzo_);
            CqlDateTime zzzzzzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzzzzzz_);
            CqlDate zzzzzzzzzzzzzzb_ = context.Operators.DateFrom(zzzzzzzzzzzzzza_);
            int? zzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzb_, "year");
            CqlInterval<int?> zzzzzzzzzzzzzzd_ = context.Operators.Interval(65, 94, true, true);
            bool? zzzzzzzzzzzzzze_ = context.Operators.In<int?>(zzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzd_, default);
            bool? zzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzt_, zzzzzzzzzzzzzze_);

            return zzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> yzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(yzzzzzzzzzzzzza_, yzzzzzzzzzzzzzb_);
        Encounter yzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> yzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(yzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzf_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzzzze_);

        return yzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);

        return zzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        string zzzzzzzzzzzzzzi_(Encounter Encounter)
        {
            string zzzzzzzzzzzzzzl_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string zzzzzzzzzzzzzzm_ = context.Operators.Concatenate(zzzzzzzzzzzzzzl_ ?? "", ",");
            Id zzzzzzzzzzzzzzn_ = Encounter?.IdElement;
            string zzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzn_);
            string zzzzzzzzzzzzzzp_ = context.Operators.Concatenate(zzzzzzzzzzzzzzm_ ?? "", zzzzzzzzzzzzzzo_ ?? "");
            string zzzzzzzzzzzzzzq_ = context.Operators.Concatenate(zzzzzzzzzzzzzzp_ ?? "", " , ");
            bool? zzzzzzzzzzzzzzr_(Observation Exam)
            {
                DataType azzzzzzzzzzzzzzl_ = Exam?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzn_ is null));
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzzq_);
                Period azzzzzzzzzzzzzzs_ = Encounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzzzzzzt_);
                CqlQuantity azzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzw_ = context.Operators.Subtract(azzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzz_ = context.Operators.Start(azzzzzzzzzzzzzzy_);
                CqlQuantity bzzzzzzzzzzzzzza_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzb_ = context.Operators.Add(azzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzb_, true, true);
                bool? bzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzc_, default);
                bool? bzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzd_);
                Code<ObservationStatus> bzzzzzzzzzzzzzzf_ = Exam?.StatusElement;
                string bzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzf_);
                string[] bzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bzzzzzzzzzzzzzzi_ = context.Operators.In<string>(bzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzi_);
                DataType bzzzzzzzzzzzzzzk_ = Exam?.Value;
                bool? bzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzk_ is null));
                bool? bzzzzzzzzzzzzzzm_ = context.Operators.And(bzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzl_);

                return bzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ExamList, zzzzzzzzzzzzzzr_);
            object zzzzzzzzzzzzzzt_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzn_ = @this?.Effective;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzn_);
                CqlDateTime bzzzzzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzzzzzo_);

                return bzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzu_);
            DataType zzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzv_?.Value;
            CqlQuantity zzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzzzzzzzzzzw_ as Quantity);
            string zzzzzzzzzzzzzzy_ = context.Operators.ConvertQuantityToString(zzzzzzzzzzzzzzx_);
            string zzzzzzzzzzzzzzz_ = context.Operators.Concatenate(zzzzzzzzzzzzzzq_ ?? "", zzzzzzzzzzzzzzy_ ?? "");
            string azzzzzzzzzzzzzza_ = context.Operators.Concatenate(zzzzzzzzzzzzzzz_ ?? "", ",");
            bool? azzzzzzzzzzzzzzb_(Observation Exam)
            {
                DataType bzzzzzzzzzzzzzzq_ = Exam?.Effective;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzq_);
                CqlDateTime bzzzzzzzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzzzzzzzr_);
                bool? bzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzs_ is null));
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzq_);
                CqlDateTime bzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzv_);
                Period bzzzzzzzzzzzzzzx_ = Encounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzx_);
                CqlDateTime bzzzzzzzzzzzzzzz_ = context.Operators.Start(bzzzzzzzzzzzzzzy_);
                CqlQuantity czzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzb_ = context.Operators.Subtract(bzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzzd_);
                CqlQuantity czzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzg_ = context.Operators.Add(czzzzzzzzzzzzzze_, czzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzh_ = context.Operators.Interval(czzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzg_, true, true);
                bool? czzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzh_, default);
                bool? czzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzi_);
                Code<ObservationStatus> czzzzzzzzzzzzzzk_ = Exam?.StatusElement;
                string czzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzk_);
                string[] czzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? czzzzzzzzzzzzzzn_ = context.Operators.In<string>(czzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzn_);
                DataType czzzzzzzzzzzzzzp_ = Exam?.Value;
                bool? czzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzp_ is null));
                bool? czzzzzzzzzzzzzzr_ = context.Operators.And(czzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzq_);

                return czzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(ExamList, azzzzzzzzzzzzzzb_);
            object azzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzs_ = @this?.Effective;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzs_);
                CqlDateTime czzzzzzzzzzzzzzu_ = context.Operators.Start(czzzzzzzzzzzzzzt_);

                return czzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(azzzzzzzzzzzzzze_);
            DataType azzzzzzzzzzzzzzg_ = azzzzzzzzzzzzzzf_?.Effective;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzg_);
            CqlDateTime azzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzh_);
            string azzzzzzzzzzzzzzj_ = context.Operators.ConvertDateTimeToString(azzzzzzzzzzzzzzi_);
            string azzzzzzzzzzzzzzk_ = context.Operators.Concatenate(azzzzzzzzzzzzzza_ ?? "", azzzzzzzzzzzzzzj_ ?? "");

            return azzzzzzzzzzzzzzk_;
        };
        IEnumerable<string> zzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, string>(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzi_);
        IEnumerable<string> zzzzzzzzzzzzzzk_ = context.Operators.Distinct<string>(zzzzzzzzzzzzzzj_);

        return zzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzv_ = this.Inpatient_Encounters(context);
        string czzzzzzzzzzzzzzw_(Encounter Encounter)
        {
            string czzzzzzzzzzzzzzz_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string dzzzzzzzzzzzzzza_ = context.Operators.Concatenate(czzzzzzzzzzzzzzz_ ?? "", ",");
            Id dzzzzzzzzzzzzzzb_ = Encounter?.IdElement;
            string dzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzb_);
            string dzzzzzzzzzzzzzzd_ = context.Operators.Concatenate(dzzzzzzzzzzzzzza_ ?? "", dzzzzzzzzzzzzzzc_ ?? "");
            string dzzzzzzzzzzzzzze_ = context.Operators.Concatenate(dzzzzzzzzzzzzzzd_ ?? "", ",");
            bool? dzzzzzzzzzzzzzzf_(Observation Lab)
            {
                Instant dzzzzzzzzzzzzzzy_ = Lab?.IssuedElement;
                bool? dzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzy_ is null));
                CqlDateTime ezzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzy_);
                Period ezzzzzzzzzzzzzzc_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzc_);
                CqlDateTime ezzzzzzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzzzzzd_);
                CqlQuantity ezzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzg_ = context.Operators.Subtract(ezzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzc_);
                CqlDateTime ezzzzzzzzzzzzzzj_ = context.Operators.Start(ezzzzzzzzzzzzzzi_);
                CqlDateTime ezzzzzzzzzzzzzzl_ = context.Operators.Add(ezzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzm_ = context.Operators.Interval(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzl_, true, true);
                bool? ezzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzm_, default);
                bool? ezzzzzzzzzzzzzzo_ = context.Operators.And(dzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzn_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzp_ = Lab?.StatusElement;
                string ezzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzp_);
                string[] ezzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzzs_ = context.Operators.In<string>(ezzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzs_);
                DataType ezzzzzzzzzzzzzzu_ = Lab?.Value;
                bool? ezzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzu_ is null));
                bool? ezzzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(LabList, dzzzzzzzzzzzzzzf_);
            object dzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzx_ = @this?.IssuedElement;

                return ezzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzi_);
            DataType dzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzj_?.Value;
            CqlQuantity dzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dzzzzzzzzzzzzzzk_ as Quantity);
            string dzzzzzzzzzzzzzzm_ = context.Operators.ConvertQuantityToString(dzzzzzzzzzzzzzzl_);
            string dzzzzzzzzzzzzzzn_ = context.Operators.Concatenate(dzzzzzzzzzzzzzze_ ?? "", dzzzzzzzzzzzzzzm_ ?? "");
            string dzzzzzzzzzzzzzzo_ = context.Operators.Concatenate(dzzzzzzzzzzzzzzn_ ?? "", ",");
            bool? dzzzzzzzzzzzzzzp_(Observation Lab)
            {
                Instant ezzzzzzzzzzzzzzy_ = Lab?.IssuedElement;
                bool? ezzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzy_ is null));
                CqlDateTime fzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzzzzy_);
                Period fzzzzzzzzzzzzzzc_ = Encounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzzd_);
                CqlQuantity fzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzzg_ = context.Operators.Subtract(fzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzzl_ = context.Operators.Add(fzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzm_ = context.Operators.Interval(fzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzl_, true, true);
                bool? fzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzm_, default);
                bool? fzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzn_);
                Code<ObservationStatus> fzzzzzzzzzzzzzzp_ = Lab?.StatusElement;
                string fzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzp_);
                string[] fzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? fzzzzzzzzzzzzzzs_ = context.Operators.In<string>(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzs_);
                DataType fzzzzzzzzzzzzzzu_ = Lab?.Value;
                bool? fzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzu_ is null));
                bool? fzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzv_);

                return fzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(LabList, dzzzzzzzzzzzzzzp_);
            object dzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzx_ = @this?.IssuedElement;

                return fzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzs_);
            Instant dzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzt_?.IssuedElement;
            CqlDateTime dzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzu_);
            string dzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateTimeToString(dzzzzzzzzzzzzzzv_);
            string dzzzzzzzzzzzzzzx_ = context.Operators.Concatenate(dzzzzzzzzzzzzzzo_ ?? "", dzzzzzzzzzzzzzzw_ ?? "");

            return dzzzzzzzzzzzzzzx_;
        };
        IEnumerable<string> czzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, string>(czzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzw_);
        IEnumerable<string> czzzzzzzzzzzzzzy_ = context.Operators.Distinct<string>(czzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzy_ = this.Heart_rate(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> gzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzb_ = this.FirstPhysicalExamWithEncounterId(context, gzzzzzzzzzzzzzza_, "FirstHeartRate");
        CqlCode gzzzzzzzzzzzzzzc_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> gzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzf_ = this.FirstPhysicalExamWithEncounterId(context, gzzzzzzzzzzzzzze_, "FirstSystolicBP");
        CqlValueSet gzzzzzzzzzzzzzzg_ = this.Body_temperature(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzi_ = this.FirstPhysicalExamWithEncounterId(context, gzzzzzzzzzzzzzzh_, "FirstTemperature");
        CqlCode gzzzzzzzzzzzzzzj_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzm_ = this.FirstPhysicalExamWithEncounterId(context, gzzzzzzzzzzzzzzl_, "FirstO2Saturation");
        CqlValueSet gzzzzzzzzzzzzzzn_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzp_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzo_, "FirstHematocrit");
        CqlValueSet gzzzzzzzzzzzzzzq_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzs_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzr_, "FirstPlateletCount");
        CqlValueSet gzzzzzzzzzzzzzzt_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzv_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzu_, "FirstWhiteBloodCell");
        CqlValueSet gzzzzzzzzzzzzzzw_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzy_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzx_, "FirstSodium");
        CqlValueSet gzzzzzzzzzzzzzzz_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> hzzzzzzzzzzzzzzb_ = this.FirstLabTestWithEncounterId(context, hzzzzzzzzzzzzzza_, "FirstBicarbonate");
        CqlValueSet hzzzzzzzzzzzzzzc_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> hzzzzzzzzzzzzzze_ = this.FirstLabTestWithEncounterId(context, hzzzzzzzzzzzzzzd_, "FirstCreatinine");
        IEnumerable<string>[] hzzzzzzzzzzzzzzf_ = [
            gzzzzzzzzzzzzzzb_,
            gzzzzzzzzzzzzzzf_,
            gzzzzzzzzzzzzzzi_,
            gzzzzzzzzzzzzzzm_,
            gzzzzzzzzzzzzzzp_,
            gzzzzzzzzzzzzzzs_,
            gzzzzzzzzzzzzzzv_,
            gzzzzzzzzzzzzzzy_,
            hzzzzzzzzzzzzzzb_,
            hzzzzzzzzzzzzzze_,
        ];
        IEnumerable<string> hzzzzzzzzzzzzzzg_ = context.Operators.Flatten<string>(hzzzzzzzzzzzzzzf_ as IEnumerable<IEnumerable<string>>);

        return hzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate hzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate hzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? hzzzzzzzzzzzzzzj_ = context.Operators.DurationBetween(hzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzi_, "year");

        return hzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? hzzzzzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? hzzzzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? hzzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? hzzzzzzzzzzzzzzn_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime hzzzzzzzzzzzzzzo_ = context.Operators.DateTime(hzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzm_, 0, 0, 0, 0, hzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime hzzzzzzzzzzzzzzp_ = context.Operators.Start(Stay);
        CqlDateTime hzzzzzzzzzzzzzzq_ = context.Operators.End(Stay);
        int? hzzzzzzzzzzzzzzr_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzq_, "day");

        return hzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] hzzzzzzzzzzzzzzs_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzt_(Encounter Visit)
        {
            CqlValueSet hzzzzzzzzzzzzzzx_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> hzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? hzzzzzzzzzzzzzzz_(Encounter LastED)
            {
                Period izzzzzzzzzzzzzzy_ = LastED?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzza_ = context.Operators.End(izzzzzzzzzzzzzzz_);
                CqlValueSet jzzzzzzzzzzzzzzb_ = this.Observation_Services(context);
                IEnumerable<Encounter> jzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? jzzzzzzzzzzzzzzd_(Encounter LastObs)
                {
                    Period kzzzzzzzzzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzu_);
                    CqlDateTime kzzzzzzzzzzzzzzw_ = context.Operators.End(kzzzzzzzzzzzzzzv_);
                    Period kzzzzzzzzzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzx_);
                    CqlDateTime kzzzzzzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzzzzzzy_);
                    CqlQuantity lzzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzzzzzzzb_ = context.Operators.Subtract(kzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzx_);
                    CqlDateTime lzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzf_ = context.Operators.Interval(lzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzze_, true, true);
                    bool? lzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzf_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzx_);
                    CqlDateTime lzzzzzzzzzzzzzzj_ = context.Operators.Start(lzzzzzzzzzzzzzzi_);
                    bool? lzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzj_ is null));
                    bool? lzzzzzzzzzzzzzzl_ = context.Operators.And(lzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzk_);

                    return lzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> jzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzd_);
                object jzzzzzzzzzzzzzzf_(Encounter @this)
                {
                    Period lzzzzzzzzzzzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzm_);
                    CqlDateTime lzzzzzzzzzzzzzzo_ = context.Operators.End(lzzzzzzzzzzzzzzn_);

                    return lzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Encounter> jzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Encounter>(jzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzzzzzzzzzzzzh_ = context.Operators.Last<Encounter>(jzzzzzzzzzzzzzzg_);
                Period jzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzh_?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzi_);
                CqlDateTime jzzzzzzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzzzzzzj_);
                Period jzzzzzzzzzzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzl_);
                CqlDateTime jzzzzzzzzzzzzzzn_ = context.Operators.Start(jzzzzzzzzzzzzzzm_);
                CqlQuantity jzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime jzzzzzzzzzzzzzzp_ = context.Operators.Subtract(jzzzzzzzzzzzzzzk_ ?? jzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzo_);
                IEnumerable<Encounter> jzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? jzzzzzzzzzzzzzzs_(Encounter LastObs)
                {
                    Period lzzzzzzzzzzzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzp_);
                    CqlDateTime lzzzzzzzzzzzzzzr_ = context.Operators.End(lzzzzzzzzzzzzzzq_);
                    Period lzzzzzzzzzzzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzs_);
                    CqlDateTime lzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzt_);
                    CqlQuantity lzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzzzzzzzw_ = context.Operators.Subtract(lzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzs_);
                    CqlDateTime lzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzy_);
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzz_, true, true);
                    bool? mzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzza_, default);
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzs_);
                    CqlDateTime mzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzd_);
                    bool? mzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzze_ is null));
                    bool? mzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzf_);

                    return mzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Encounter> jzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzs_);
                object jzzzzzzzzzzzzzzu_(Encounter @this)
                {
                    Period mzzzzzzzzzzzzzzh_ = @this?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzh_);
                    CqlDateTime mzzzzzzzzzzzzzzj_ = context.Operators.End(mzzzzzzzzzzzzzzi_);

                    return mzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Encounter> jzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Encounter>(jzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzzzzzzzzzzzzw_ = context.Operators.Last<Encounter>(jzzzzzzzzzzzzzzv_);
                Period jzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzw_?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzx_);
                CqlDateTime jzzzzzzzzzzzzzzz_ = context.Operators.Start(jzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzd_ = context.Operators.Interval(jzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzz_ ?? kzzzzzzzzzzzzzzc_, true, true);
                bool? kzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzd_, default);
                IEnumerable<Encounter> kzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? kzzzzzzzzzzzzzzh_(Encounter LastObs)
                {
                    Period mzzzzzzzzzzzzzzk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzk_);
                    CqlDateTime mzzzzzzzzzzzzzzm_ = context.Operators.End(mzzzzzzzzzzzzzzl_);
                    Period mzzzzzzzzzzzzzzn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzn_);
                    CqlDateTime mzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzo_);
                    CqlQuantity mzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzzzzzzzzzzzr_ = context.Operators.Subtract(mzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzq_);
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzn_);
                    CqlDateTime mzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzt_);
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzv_ = context.Operators.Interval(mzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzu_, true, true);
                    bool? mzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzv_, default);
                    CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzn_);
                    CqlDateTime mzzzzzzzzzzzzzzz_ = context.Operators.Start(mzzzzzzzzzzzzzzy_);
                    bool? nzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzz_ is null));
                    bool? nzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzza_);

                    return nzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> kzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzh_);
                object kzzzzzzzzzzzzzzj_(Encounter @this)
                {
                    Period nzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzc_);
                    CqlDateTime nzzzzzzzzzzzzzze_ = context.Operators.End(nzzzzzzzzzzzzzzd_);

                    return nzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> kzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Encounter>(kzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzzzzzzzzzzzl_ = context.Operators.Last<Encounter>(kzzzzzzzzzzzzzzk_);
                Period kzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzm_);
                CqlDateTime kzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)((kzzzzzzzzzzzzzzo_ ?? kzzzzzzzzzzzzzzr_) is null));
                bool? kzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzz_);
            object izzzzzzzzzzzzzzb_(Encounter @this)
            {
                Period nzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzf_);
                CqlDateTime nzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzg_);

                return nzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzzc_ = context.Operators.SortBy<Encounter>(izzzzzzzzzzzzzza_, izzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzzzzzzzzzzzzd_ = context.Operators.Last<Encounter>(izzzzzzzzzzzzzzc_);
            Period izzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzd_?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzze_);
            CqlDateTime izzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzf_);
            CqlValueSet izzzzzzzzzzzzzzh_ = this.Observation_Services(context);
            IEnumerable<Encounter> izzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? izzzzzzzzzzzzzzj_(Encounter LastObs)
            {
                Period nzzzzzzzzzzzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzk_ = context.Operators.End(nzzzzzzzzzzzzzzj_);
                Period nzzzzzzzzzzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime nzzzzzzzzzzzzzzp_ = context.Operators.Subtract(nzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzt_ = context.Operators.Interval(nzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzs_, true, true);
                bool? nzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzw_);
                bool? nzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzx_ is null));
                bool? nzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzy_);

                return nzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzj_);
            object izzzzzzzzzzzzzzl_(Encounter @this)
            {
                Period ozzzzzzzzzzzzzza_ = @this?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzza_);
                CqlDateTime ozzzzzzzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzzzzzzb_);

                return ozzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzzm_ = context.Operators.SortBy<Encounter>(izzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzzzzzzzzzzzzn_ = context.Operators.Last<Encounter>(izzzzzzzzzzzzzzm_);
            Period izzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzn_?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzo_);
            CqlDateTime izzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzp_);
            Period izzzzzzzzzzzzzzr_ = Visit?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzx_ = context.Operators.Interval(izzzzzzzzzzzzzzg_ ?? izzzzzzzzzzzzzzq_ ?? izzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzw_, true, true);

            return izzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)hzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzv_);

        return hzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzd_ = this.HospitalizationWithObservation(context, Encounter);
        int? ozzzzzzzzzzzzzze_ = this.LengthInDays(context, ozzzzzzzzzzzzzzd_);

        return ozzzzzzzzzzzzzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
