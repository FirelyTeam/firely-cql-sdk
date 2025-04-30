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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC:2.69")]
    public CqlCodeSystem LOINC_2_69(CqlContext _) => _LOINC_2_69;
    private static readonly CqlCodeSystem _LOINC_2_69 =
      new CqlCodeSystem("http://loinc.org", "2.69",
          _Birth_date,
          _Heart_rate,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime vzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzg_, true, false);
        object vzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", vzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzj_);

        return vzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> vzzzzzzzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzp_ = context.Operators.Start(Value);
        CqlDateTime vzzzzzzzzzzzzzzzzq_ = context.Operators.End(Value);
        int? vzzzzzzzzzzzzzzzzr_ = context.Operators.DifferenceBetween(vzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzq_, "day");

        return vzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzs_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet vzzzzzzzzzzzzzzzzu_ = this.Medicare_payer(context);
        IEnumerable<Coverage> vzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> vzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<Encounter, Coverage>(vzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? vzzzzzzzzzzzzzzzzx_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? wzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> vzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(vzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzf_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string wzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzg_, "finished");
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? wzzzzzzzzzzzzzzzzj_ = this.LengthInDays(context, wzzzzzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzzzzzk_ = context.Operators.Less(wzzzzzzzzzzzzzzzzj_, 365);
            bool? wzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzk_);
            Period wzzzzzzzzzzzzzzzzm_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzzzzzzzo_ = context.Operators.End(wzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzp_, "day");
            bool? wzzzzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzq_);
            Patient wzzzzzzzzzzzzzzzzs_ = this.Patient(context);
            Date wzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzs_?.BirthDateElement;
            string wzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzt_?.Value;
            CqlDate wzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzzzzzzzy_ = context.Operators.Start(wzzzzzzzzzzzzzzzzx_);
            CqlDate wzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzy_);
            int? xzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzz_, "year");
            CqlInterval<int?> xzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(65, 94, true, true);
            bool? xzzzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(xzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzb_, default);
            bool? xzzzzzzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzc_);

            return xzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> wzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(vzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzz_);
        Encounter wzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(wzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);

        return xzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);
        string xzzzzzzzzzzzzzzzzg_(Encounter Encounter)
        {
            string xzzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string xzzzzzzzzzzzzzzzzk_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzj_ ?? "", ",");
            Id xzzzzzzzzzzzzzzzzl_ = Encounter?.IdElement;
            string xzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzzzzl_);
            string xzzzzzzzzzzzzzzzzn_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzk_ ?? "", xzzzzzzzzzzzzzzzzm_ ?? "");
            string xzzzzzzzzzzzzzzzzo_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzn_ ?? "", " , ");
            bool? xzzzzzzzzzzzzzzzzp_(Observation Exam)
            {
                DataType yzzzzzzzzzzzzzzzzj_ = Exam?.Effective;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzk_);
                bool? yzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzl_ is null));
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzzzzzzp_ = context.Operators.Start(yzzzzzzzzzzzzzzzzo_);
                Period yzzzzzzzzzzzzzzzzq_ = Encounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzq_);
                CqlDateTime yzzzzzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzzzzzr_);
                CqlQuantity yzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzq_);
                CqlDateTime yzzzzzzzzzzzzzzzzx_ = context.Operators.Start(yzzzzzzzzzzzzzzzzw_);
                CqlQuantity yzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzz_ = context.Operators.Add(yzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzza_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzz_, true, true);
                bool? zzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzza_, default);
                bool? zzzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzb_);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzd_ = Exam?.StatusElement;
                string zzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzzzd_);
                string[] zzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? zzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzg_);
                DataType zzzzzzzzzzzzzzzzzi_ = Exam?.Value;
                bool? zzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzi_ is null));
                bool? zzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(ExamList, xzzzzzzzzzzzzzzzzp_);
            object xzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzzzzzzzm_);

                return zzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzs_);
            DataType xzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzt_?.Value;
            CqlQuantity xzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzu_ as Quantity);
            string xzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertQuantityToString(xzzzzzzzzzzzzzzzzv_);
            string xzzzzzzzzzzzzzzzzx_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzo_ ?? "", xzzzzzzzzzzzzzzzzw_ ?? "");
            string xzzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzx_ ?? "", ",");
            bool? xzzzzzzzzzzzzzzzzz_(Observation Exam)
            {
                DataType zzzzzzzzzzzzzzzzzo_ = Exam?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzo_);
                CqlDateTime zzzzzzzzzzzzzzzzzq_ = context.Operators.Start(zzzzzzzzzzzzzzzzzp_);
                bool? zzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzq_ is null));
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzo_);
                CqlDateTime zzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzt_);
                Period zzzzzzzzzzzzzzzzzv_ = Encounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzv_);
                CqlDateTime zzzzzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzzzzw_);
                CqlQuantity zzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzv_);
                CqlDateTime azzzzzzzzzzzzzzzzzc_ = context.Operators.Start(azzzzzzzzzzzzzzzzzb_);
                CqlQuantity azzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzze_ = context.Operators.Add(azzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzze_, true, true);
                bool? azzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzf_, default);
                bool? azzzzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzg_);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzi_ = Exam?.StatusElement;
                string azzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzzi_);
                string[] azzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? azzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzl_);
                DataType azzzzzzzzzzzzzzzzzn_ = Exam?.Value;
                bool? azzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzn_ is null));
                bool? azzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzo_);

                return azzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(ExamList, xzzzzzzzzzzzzzzzzz_);
            object yzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzr_);

                return azzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzc_);
            DataType yzzzzzzzzzzzzzzzze_ = yzzzzzzzzzzzzzzzzd_?.Effective;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzze_);
            CqlDateTime yzzzzzzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzzzzzzf_);
            string yzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateTimeToString(yzzzzzzzzzzzzzzzzg_);
            string yzzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzzy_ ?? "", yzzzzzzzzzzzzzzzzh_ ?? "");

            return yzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<string> xzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, string>(xzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzg_);
        IEnumerable<string> xzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<string>(xzzzzzzzzzzzzzzzzh_);

        return xzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzt_ = this.Inpatient_Encounters(context);
        string azzzzzzzzzzzzzzzzzu_(Encounter Encounter)
        {
            string azzzzzzzzzzzzzzzzzx_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string azzzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate(azzzzzzzzzzzzzzzzzx_ ?? "", ",");
            Id azzzzzzzzzzzzzzzzzz_ = Encounter?.IdElement;
            string bzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzzz_);
            string bzzzzzzzzzzzzzzzzzb_ = context.Operators.Concatenate(azzzzzzzzzzzzzzzzzy_ ?? "", bzzzzzzzzzzzzzzzzza_ ?? "");
            string bzzzzzzzzzzzzzzzzzc_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzzb_ ?? "", ",");
            bool? bzzzzzzzzzzzzzzzzzd_(Observation Lab)
            {
                Instant bzzzzzzzzzzzzzzzzzw_ = Lab?.IssuedElement;
                bool? bzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzw_ is null));
                CqlDateTime bzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bzzzzzzzzzzzzzzzzzw_);
                Period czzzzzzzzzzzzzzzzza_ = Encounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzzc_ = context.Operators.Start(czzzzzzzzzzzzzzzzzb_);
                CqlQuantity czzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzzh_ = context.Operators.Start(czzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzj_ = context.Operators.Add(czzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(czzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzj_, true, true);
                bool? czzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzk_, default);
                bool? czzzzzzzzzzzzzzzzzm_ = context.Operators.And(bzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzl_);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzn_ = Lab?.StatusElement;
                string czzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzzn_);
                string[] czzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? czzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzr_ = context.Operators.And(czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzq_);
                DataType czzzzzzzzzzzzzzzzzs_ = Lab?.Value;
                bool? czzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzs_ is null));
                bool? czzzzzzzzzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzt_);

                return czzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(LabList, bzzzzzzzzzzzzzzzzzd_);
            object bzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;

                return czzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzg_);
            DataType bzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzh_?.Value;
            CqlQuantity bzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzi_ as Quantity);
            string bzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertQuantityToString(bzzzzzzzzzzzzzzzzzj_);
            string bzzzzzzzzzzzzzzzzzl_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzzc_ ?? "", bzzzzzzzzzzzzzzzzzk_ ?? "");
            string bzzzzzzzzzzzzzzzzzm_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzzl_ ?? "", ",");
            bool? bzzzzzzzzzzzzzzzzzn_(Observation Lab)
            {
                Instant czzzzzzzzzzzzzzzzzw_ = Lab?.IssuedElement;
                bool? czzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzw_ is null));
                CqlDateTime czzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzzzzzzzzzzzzzzzzw_);
                Period dzzzzzzzzzzzzzzzzza_ = Encounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzza_);
                CqlDateTime dzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzb_);
                CqlQuantity dzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzza_);
                CqlDateTime dzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzj_, true, true);
                bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzk_, default);
                bool? dzzzzzzzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzl_);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzn_ = Lab?.StatusElement;
                string dzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzzn_);
                string[] dzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? dzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzq_);
                DataType dzzzzzzzzzzzzzzzzzs_ = Lab?.Value;
                bool? dzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzs_ is null));
                bool? dzzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzt_);

                return dzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(LabList, bzzzzzzzzzzzzzzzzzn_);
            object bzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant dzzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;

                return dzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzq_);
            Instant bzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzr_?.IssuedElement;
            CqlDateTime bzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bzzzzzzzzzzzzzzzzzs_);
            string bzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateTimeToString(bzzzzzzzzzzzzzzzzzt_);
            string bzzzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzzm_ ?? "", bzzzzzzzzzzzzzzzzzu_ ?? "");

            return bzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<string> azzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, string>(azzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzu_);
        IEnumerable<string> azzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<string>(azzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzw_ = this.Heart_rate(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> dzzzzzzzzzzzzzzzzzz_ = this.FirstPhysicalExamWithEncounterId(context, dzzzzzzzzzzzzzzzzzy_, "FirstHeartRate");
        CqlCode ezzzzzzzzzzzzzzzzza_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzd_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzzc_, "FirstSystolicBP");
        CqlValueSet ezzzzzzzzzzzzzzzzze_ = this.Body_temperature(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzg_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzzf_, "FirstTemperature");
        CqlCode ezzzzzzzzzzzzzzzzzh_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzk_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzzj_, "FirstO2Saturation");
        CqlValueSet ezzzzzzzzzzzzzzzzzl_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzn_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzzm_, "FirstHematocrit");
        CqlValueSet ezzzzzzzzzzzzzzzzzo_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzq_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzzp_, "FirstPlateletCount");
        CqlValueSet ezzzzzzzzzzzzzzzzzr_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzt_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzzs_, "FirstWhiteBloodCell");
        CqlValueSet ezzzzzzzzzzzzzzzzzu_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzw_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzzv_, "FirstSodium");
        CqlValueSet ezzzzzzzzzzzzzzzzzx_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzzz_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzzy_, "FirstBicarbonate");
        CqlValueSet fzzzzzzzzzzzzzzzzza_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzc_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzzzb_, "FirstCreatinine");
        IEnumerable<string>[] fzzzzzzzzzzzzzzzzzd_ = [
            dzzzzzzzzzzzzzzzzzz_,
            ezzzzzzzzzzzzzzzzzd_,
            ezzzzzzzzzzzzzzzzzg_,
            ezzzzzzzzzzzzzzzzzk_,
            ezzzzzzzzzzzzzzzzzn_,
            ezzzzzzzzzzzzzzzzzq_,
            ezzzzzzzzzzzzzzzzzt_,
            ezzzzzzzzzzzzzzzzzw_,
            ezzzzzzzzzzzzzzzzzz_,
            fzzzzzzzzzzzzzzzzzc_,
        ];
        IEnumerable<string> fzzzzzzzzzzzzzzzzze_ = context.Operators.Flatten<string>(fzzzzzzzzzzzzzzzzzd_ as IEnumerable<IEnumerable<string>>);

        return fzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate fzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate fzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? fzzzzzzzzzzzzzzzzzh_ = context.Operators.DurationBetween(fzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzg_, "year");

        return fzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? fzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? fzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? fzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? fzzzzzzzzzzzzzzzzzl_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime fzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(fzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzk_, 0, 0, 0, 0, fzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(Stay);
        CqlDateTime fzzzzzzzzzzzzzzzzzo_ = context.Operators.End(Stay);
        int? fzzzzzzzzzzzzzzzzzp_ = context.Operators.DifferenceBetween(fzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzo_, "day");

        return fzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] fzzzzzzzzzzzzzzzzzq_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzr_(Encounter Visit)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzv_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? fzzzzzzzzzzzzzzzzzx_(Encounter LastED)
            {
                Period gzzzzzzzzzzzzzzzzzw_ = LastED?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzw_);
                CqlDateTime gzzzzzzzzzzzzzzzzzy_ = context.Operators.End(gzzzzzzzzzzzzzzzzzx_);
                CqlValueSet gzzzzzzzzzzzzzzzzzz_ = this.Observation_Services(context);
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? hzzzzzzzzzzzzzzzzzb_(Encounter LastObs)
                {
                    Period izzzzzzzzzzzzzzzzzs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzs_);
                    CqlDateTime izzzzzzzzzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzzzzzzzzt_);
                    Period izzzzzzzzzzzzzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzv_);
                    CqlDateTime izzzzzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzzzzw_);
                    CqlQuantity izzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzy_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzv_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzb_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzc_, true, true);
                    bool? jzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzd_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzv_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzg_);
                    bool? jzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzh_ is null));
                    bool? jzzzzzzzzzzzzzzzzzj_ = context.Operators.And(jzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzi_);

                    return jzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzb_);
                object hzzzzzzzzzzzzzzzzzd_(Encounter @this)
                {
                    Period jzzzzzzzzzzzzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzk_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzm_ = context.Operators.End(jzzzzzzzzzzzzzzzzzl_);

                    return jzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzzzzzzze_);
                Period hzzzzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzzzzf_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzg_);
                CqlDateTime hzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzh_);
                Period hzzzzzzzzzzzzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzk_);
                CqlQuantity hzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzi_ ?? hzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzm_);
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? hzzzzzzzzzzzzzzzzzq_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzzzzzzzn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzn_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzp_ = context.Operators.End(jzzzzzzzzzzzzzzzzzo_);
                    Period jzzzzzzzzzzzzzzzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzq_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzr_);
                    CqlQuantity jzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzt_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzq_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzw_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzx_, true, true);
                    bool? jzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzy_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzq_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzb_);
                    bool? kzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzc_ is null));
                    bool? kzzzzzzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzd_);

                    return kzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzq_);
                object hzzzzzzzzzzzzzzzzzs_(Encounter @this)
                {
                    Period kzzzzzzzzzzzzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzh_ = context.Operators.End(kzzzzzzzzzzzzzzzzzg_);

                    return kzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzzzzzzzt_);
                Period hzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzv_);
                CqlDateTime hzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzj_);
                CqlDateTime izzzzzzzzzzzzzzzzza_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzx_ ?? izzzzzzzzzzzzzzzzza_, true, true);
                bool? izzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzb_, default);
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? izzzzzzzzzzzzzzzzzf_(Encounter LastObs)
                {
                    Period kzzzzzzzzzzzzzzzzzi_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzk_ = context.Operators.End(kzzzzzzzzzzzzzzzzzj_);
                    Period kzzzzzzzzzzzzzzzzzl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzm_);
                    CqlQuantity kzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzr_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzs_, true, true);
                    bool? kzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzt_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzw_);
                    bool? kzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzx_ is null));
                    bool? kzzzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzy_);

                    return kzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzf_);
                object izzzzzzzzzzzzzzzzzh_(Encounter @this)
                {
                    Period lzzzzzzzzzzzzzzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzza_);
                    CqlDateTime lzzzzzzzzzzzzzzzzzc_ = context.Operators.End(lzzzzzzzzzzzzzzzzzb_);

                    return lzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(izzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(izzzzzzzzzzzzzzzzzi_);
                Period izzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzk_);
                CqlDateTime izzzzzzzzzzzzzzzzzm_ = context.Operators.Start(izzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzj_);
                CqlDateTime izzzzzzzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzzzzzzo_);
                bool? izzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)((izzzzzzzzzzzzzzzzzm_ ?? izzzzzzzzzzzzzzzzzp_) is null));
                bool? izzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzq_);

                return izzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzx_);
            object fzzzzzzzzzzzzzzzzzz_(Encounter @this)
            {
                Period lzzzzzzzzzzzzzzzzzd_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzzzzzzzf_ = context.Operators.End(lzzzzzzzzzzzzzzzzze_);

                return lzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzzzzzzzzzb_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzza_);
            Period gzzzzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzzzzb_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzc_);
            CqlDateTime gzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzd_);
            CqlValueSet gzzzzzzzzzzzzzzzzzf_ = this.Observation_Services(context);
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? gzzzzzzzzzzzzzzzzzh_(Encounter LastObs)
            {
                Period lzzzzzzzzzzzzzzzzzg_ = LastObs?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzg_);
                CqlDateTime lzzzzzzzzzzzzzzzzzi_ = context.Operators.End(lzzzzzzzzzzzzzzzzzh_);
                Period lzzzzzzzzzzzzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzk_);
                CqlQuantity lzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzq_, true, true);
                bool? lzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzr_, default);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzv_ is null));
                bool? lzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzw_);

                return lzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzh_);
            object gzzzzzzzzzzzzzzzzzj_(Encounter @this)
            {
                Period lzzzzzzzzzzzzzzzzzy_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzy_);
                CqlDateTime mzzzzzzzzzzzzzzzzza_ = context.Operators.End(lzzzzzzzzzzzzzzzzzz_);

                return mzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzzk_);
            Period gzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzl_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzn_);
            Period gzzzzzzzzzzzzzzzzzp_ = Visit?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzze_ ?? gzzzzzzzzzzzzzzzzzo_ ?? gzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzu_, true, true);

            return gzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzzzzzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzb_ = this.HospitalizationWithObservation(context, Encounter);
        int? mzzzzzzzzzzzzzzzzzc_ = this.LengthInDays(context, mzzzzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
