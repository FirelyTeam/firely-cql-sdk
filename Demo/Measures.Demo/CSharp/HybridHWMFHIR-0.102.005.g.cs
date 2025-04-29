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

    #region ValueSet: Bicarbonate lab test
    [CqlValueSetDefinition(
        definitionName: "Bicarbonate lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139",
        valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext context) => _Bicarbonate_lab_test;

    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);
    #endregion

    #region ValueSet: Body temperature
    [CqlValueSetDefinition(
        definitionName: "Body temperature",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152",
        valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext context) => _Body_temperature;

    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);
    #endregion

    #region ValueSet: Creatinine lab test
    [CqlValueSetDefinition(
        definitionName: "Creatinine lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363",
        valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext context) => _Creatinine_lab_test;

    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: Hematocrit lab test
    [CqlValueSetDefinition(
        definitionName: "Hematocrit lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114",
        valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext context) => _Hematocrit_lab_test;

    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);
    #endregion

    #region ValueSet: Medicare payer
    [CqlValueSetDefinition(
        definitionName: "Medicare payer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10",
        valueSetVersion: null)]
    public CqlValueSet Medicare_payer(CqlContext context) => _Medicare_payer;

    private static readonly CqlValueSet _Medicare_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Payer
    [CqlValueSetDefinition(
        definitionName: "Payer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext context) => _Payer;

    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Platelet count lab test
    [CqlValueSetDefinition(
        definitionName: "Platelet count lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127",
        valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext context) => _Platelet_count_lab_test;

    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
    #endregion

    #region ValueSet: Sodium lab test
    [CqlValueSetDefinition(
        definitionName: "Sodium lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119",
        valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext context) => _Sodium_lab_test;

    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);
    #endregion

    #region ValueSet: White blood cells count lab test
    [CqlValueSetDefinition(
        definitionName: "White blood cells count lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129",
        valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => _White_blood_cells_count_lab_test;

    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Heart rate
    [CqlCodeDefinition(
        definitionName: "Heart rate",
        codeId: "8867-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext context) => _Heart_rate;

    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Oxygen saturation in Arterial blood by Pulse oximetry
    [CqlCodeDefinition(
        definitionName: "Oxygen saturation in Arterial blood by Pulse oximetry",
        codeId: "59408-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;

    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org", default, default);
    #endregion

    #region Code: Systolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Systolic blood pressure",
        codeId: "8480-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext context) => _Systolic_blood_pressure;

    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC:2.69")]
    public CqlCode[] LOINC_2_69(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzp_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
            new CqlCode("8867-4", "http://loinc.org", default, default),
            new CqlCode("59408-5", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return vzzzzzzzzzzzzzzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime vzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzs_ = context.Operators.Interval(vzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzr_, true, false);
        object vzzzzzzzzzzzzzzzt_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", vzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> vzzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime wzzzzzzzzzzzzzzza_ = context.Operators.Start(Value);
        CqlDateTime wzzzzzzzzzzzzzzzb_ = context.Operators.End(Value);
        int? wzzzzzzzzzzzzzzzc_ = context.Operators.DifferenceBetween(wzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzb_, "day");

        return wzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzd_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzzzzzzzzzzzf_ = this.Medicare_payer(context);
        IEnumerable<Coverage> wzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> wzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Coverage>(wzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? wzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? wzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> wzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(wzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzq_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string wzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzq_);
            bool? wzzzzzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzzzzzr_, "finished");
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? wzzzzzzzzzzzzzzzu_ = this.LengthInDays(context, wzzzzzzzzzzzzzzzt_);
            bool? wzzzzzzzzzzzzzzzv_ = context.Operators.Less(wzzzzzzzzzzzzzzzu_, 365);
            bool? wzzzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzv_);
            Period wzzzzzzzzzzzzzzzx_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzzzzz_ = context.Operators.End(wzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzza_, "day");
            bool? xzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzb_);
            Patient xzzzzzzzzzzzzzzzd_ = this.Patient(context);
            Date xzzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzzd_?.BirthDateElement;
            string xzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzze_?.Value;
            CqlDate xzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzx_);
            CqlDateTime xzzzzzzzzzzzzzzzj_ = context.Operators.Start(xzzzzzzzzzzzzzzzi_);
            CqlDate xzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzj_);
            int? xzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzk_, "year");
            CqlInterval<int?> xzzzzzzzzzzzzzzzm_ = context.Operators.Interval(65, 94, true, true);
            bool? xzzzzzzzzzzzzzzzn_ = context.Operators.In<int?>(xzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzm_, default);
            bool? xzzzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> wzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzk_);
        Encounter wzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(wzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);

        return xzzzzzzzzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzq_ = this.Inpatient_Encounters(context);
        string xzzzzzzzzzzzzzzzr_(Encounter Encounter)
        {
            string xzzzzzzzzzzzzzzzu_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string xzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzu_ ?? "", ",");
            Id xzzzzzzzzzzzzzzzw_ = Encounter?.IdElement;
            string xzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzzzw_);
            string xzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzv_ ?? "", xzzzzzzzzzzzzzzzx_ ?? "");
            string xzzzzzzzzzzzzzzzz_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzy_ ?? "", " , ");
            bool? yzzzzzzzzzzzzzzza_(Observation Exam)
            {
                DataType yzzzzzzzzzzzzzzzu_ = Exam?.Effective;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzw_ = context.Operators.Start(yzzzzzzzzzzzzzzzv_);
                bool? yzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzw_ is null));
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzu_);
                CqlDateTime zzzzzzzzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzzzzzzzz_);
                Period zzzzzzzzzzzzzzzzb_ = Encounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzb_);
                CqlDateTime zzzzzzzzzzzzzzzzd_ = context.Operators.Start(zzzzzzzzzzzzzzzzc_);
                CqlQuantity zzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzb_);
                CqlDateTime zzzzzzzzzzzzzzzzi_ = context.Operators.Start(zzzzzzzzzzzzzzzzh_);
                CqlQuantity zzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzk_ = context.Operators.Add(zzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzl_ = context.Operators.Interval(zzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzk_, true, true);
                bool? zzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzl_, default);
                bool? zzzzzzzzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzm_);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzo_ = Exam?.StatusElement;
                string zzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzzo_);
                string[] zzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? zzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzr_);
                DataType zzzzzzzzzzzzzzzzt_ = Exam?.Value;
                bool? zzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzt_ is null));
                bool? zzzzzzzzzzzzzzzzv_ = context.Operators.And(zzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzu_);

                return zzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(ExamList, yzzzzzzzzzzzzzzza_);
            object yzzzzzzzzzzzzzzzc_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzw_ = @this?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzw_);
                CqlDateTime zzzzzzzzzzzzzzzzy_ = context.Operators.Start(zzzzzzzzzzzzzzzzx_);

                return zzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzd_);
            DataType yzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzze_?.Value;
            CqlQuantity yzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzf_ as Quantity);
            string yzzzzzzzzzzzzzzzh_ = context.Operators.ConvertQuantityToString(yzzzzzzzzzzzzzzzg_);
            string yzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(xzzzzzzzzzzzzzzzz_ ?? "", yzzzzzzzzzzzzzzzh_ ?? "");
            string yzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzi_ ?? "", ",");
            bool? yzzzzzzzzzzzzzzzk_(Observation Exam)
            {
                DataType zzzzzzzzzzzzzzzzz_ = Exam?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzz_);
                CqlDateTime azzzzzzzzzzzzzzzzb_ = context.Operators.Start(azzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzb_ is null));
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzz_);
                CqlDateTime azzzzzzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzzzzzze_);
                Period azzzzzzzzzzzzzzzzg_ = Encounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzg_);
                CqlDateTime azzzzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzzzh_);
                CqlQuantity azzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzg_);
                CqlDateTime azzzzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzzzm_);
                CqlQuantity azzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzp_ = context.Operators.Add(azzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzq_ = context.Operators.Interval(azzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzp_, true, true);
                bool? azzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzq_, default);
                bool? azzzzzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzr_);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzt_ = Exam?.StatusElement;
                string azzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzt_);
                string[] azzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? azzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzw_);
                DataType azzzzzzzzzzzzzzzzy_ = Exam?.Value;
                bool? azzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzy_ is null));
                bool? bzzzzzzzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzz_);

                return bzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(ExamList, yzzzzzzzzzzzzzzzk_);
            object yzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzzzb_);
                CqlDateTime bzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzc_);

                return bzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzn_);
            DataType yzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzo_?.Effective;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzp_);
            CqlDateTime yzzzzzzzzzzzzzzzr_ = context.Operators.Start(yzzzzzzzzzzzzzzzq_);
            string yzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateTimeToString(yzzzzzzzzzzzzzzzr_);
            string yzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzj_ ?? "", yzzzzzzzzzzzzzzzs_ ?? "");

            return yzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<string> xzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, string>(xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzr_);
        IEnumerable<string> xzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<string>(xzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);
        string bzzzzzzzzzzzzzzzzf_(Encounter Encounter)
        {
            string bzzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string bzzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzi_ ?? "", ",");
            Id bzzzzzzzzzzzzzzzzk_ = Encounter?.IdElement;
            string bzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzzk_);
            string bzzzzzzzzzzzzzzzzm_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzj_ ?? "", bzzzzzzzzzzzzzzzzl_ ?? "");
            string bzzzzzzzzzzzzzzzzn_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzm_ ?? "", ",");
            bool? bzzzzzzzzzzzzzzzzo_(Observation Lab)
            {
                Instant czzzzzzzzzzzzzzzzh_ = Lab?.IssuedElement;
                bool? czzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzh_ is null));
                CqlDateTime czzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzzzzzzzzzzzzzzzh_);
                Period czzzzzzzzzzzzzzzzl_ = Encounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzm_);
                CqlQuantity czzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzr_);
                CqlDateTime czzzzzzzzzzzzzzzzu_ = context.Operators.Add(czzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzv_ = context.Operators.Interval(czzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzu_, true, true);
                bool? czzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzv_, default);
                bool? czzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzw_);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzy_ = Lab?.StatusElement;
                string czzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzy_);
                string[] dzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? dzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzb_);
                DataType dzzzzzzzzzzzzzzzzd_ = Lab?.Value;
                bool? dzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzd_ is null));
                bool? dzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzze_);

                return dzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(LabList, bzzzzzzzzzzzzzzzzo_);
            object bzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant dzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;

                return dzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzr_);
            DataType bzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzs_?.Value;
            CqlQuantity bzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzt_ as Quantity);
            string bzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertQuantityToString(bzzzzzzzzzzzzzzzzu_);
            string bzzzzzzzzzzzzzzzzw_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzn_ ?? "", bzzzzzzzzzzzzzzzzv_ ?? "");
            string bzzzzzzzzzzzzzzzzx_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzw_ ?? "", ",");
            bool? bzzzzzzzzzzzzzzzzy_(Observation Lab)
            {
                Instant dzzzzzzzzzzzzzzzzh_ = Lab?.IssuedElement;
                bool? dzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzh_ is null));
                CqlDateTime dzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzzh_);
                Period dzzzzzzzzzzzzzzzzl_ = Encounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzl_);
                CqlDateTime dzzzzzzzzzzzzzzzzn_ = context.Operators.Start(dzzzzzzzzzzzzzzzzm_);
                CqlQuantity dzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzl_);
                CqlDateTime dzzzzzzzzzzzzzzzzs_ = context.Operators.Start(dzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzu_ = context.Operators.Add(dzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzu_, true, true);
                bool? dzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzv_, default);
                bool? dzzzzzzzzzzzzzzzzx_ = context.Operators.And(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzw_);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzy_ = Lab?.StatusElement;
                string dzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzy_);
                string[] ezzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzb_);
                DataType ezzzzzzzzzzzzzzzzd_ = Lab?.Value;
                bool? ezzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzd_ is null));
                bool? ezzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzze_);

                return ezzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(LabList, bzzzzzzzzzzzzzzzzy_);
            object czzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;

                return ezzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzb_);
            Instant czzzzzzzzzzzzzzzzd_ = czzzzzzzzzzzzzzzzc_?.IssuedElement;
            CqlDateTime czzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzzzzzzzzzzzzzzzd_);
            string czzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateTimeToString(czzzzzzzzzzzzzzzze_);
            string czzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(bzzzzzzzzzzzzzzzzx_ ?? "", czzzzzzzzzzzzzzzzf_ ?? "");

            return czzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<string> bzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, string>(bzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzf_);
        IEnumerable<string> bzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<string>(bzzzzzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzh_ = this.Heart_rate(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzk_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzj_, "FirstHeartRate");
        CqlCode ezzzzzzzzzzzzzzzzl_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzo_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzn_, "FirstSystolicBP");
        CqlValueSet ezzzzzzzzzzzzzzzzp_ = this.Body_temperature(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzr_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzq_, "FirstTemperature");
        CqlCode ezzzzzzzzzzzzzzzzs_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzv_ = this.FirstPhysicalExamWithEncounterId(context, ezzzzzzzzzzzzzzzzu_, "FirstO2Saturation");
        CqlValueSet ezzzzzzzzzzzzzzzzw_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ezzzzzzzzzzzzzzzzy_ = this.FirstLabTestWithEncounterId(context, ezzzzzzzzzzzzzzzzx_, "FirstHematocrit");
        CqlValueSet ezzzzzzzzzzzzzzzzz_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzb_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzza_, "FirstPlateletCount");
        CqlValueSet fzzzzzzzzzzzzzzzzc_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzze_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzzd_, "FirstWhiteBloodCell");
        CqlValueSet fzzzzzzzzzzzzzzzzf_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzh_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzzg_, "FirstSodium");
        CqlValueSet fzzzzzzzzzzzzzzzzi_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzk_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzzj_, "FirstBicarbonate");
        CqlValueSet fzzzzzzzzzzzzzzzzl_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzn_ = this.FirstLabTestWithEncounterId(context, fzzzzzzzzzzzzzzzzm_, "FirstCreatinine");
        IEnumerable<string>[] fzzzzzzzzzzzzzzzzo_ = [
            ezzzzzzzzzzzzzzzzk_,
            ezzzzzzzzzzzzzzzzo_,
            ezzzzzzzzzzzzzzzzr_,
            ezzzzzzzzzzzzzzzzv_,
            ezzzzzzzzzzzzzzzzy_,
            fzzzzzzzzzzzzzzzzb_,
            fzzzzzzzzzzzzzzzze_,
            fzzzzzzzzzzzzzzzzh_,
            fzzzzzzzzzzzzzzzzk_,
            fzzzzzzzzzzzzzzzzn_,
        ];
        IEnumerable<string> fzzzzzzzzzzzzzzzzp_ = context.Operators.Flatten<string>(fzzzzzzzzzzzzzzzzo_ as IEnumerable<IEnumerable<string>>);

        return fzzzzzzzzzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate fzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate fzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? fzzzzzzzzzzzzzzzzs_ = context.Operators.DurationBetween(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzr_, "year");

        return fzzzzzzzzzzzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? fzzzzzzzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? fzzzzzzzzzzzzzzzzu_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? fzzzzzzzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? fzzzzzzzzzzzzzzzzw_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime fzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(fzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzv_, 0, 0, 0, 0, fzzzzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzy_ = context.Operators.Start(Stay);
        CqlDateTime fzzzzzzzzzzzzzzzzz_ = context.Operators.End(Stay);
        int? gzzzzzzzzzzzzzzzza_ = context.Operators.DifferenceBetween(fzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzz_, "day");

        return gzzzzzzzzzzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] gzzzzzzzzzzzzzzzzb_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzc_(Encounter Visit)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzg_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? gzzzzzzzzzzzzzzzzi_(Encounter LastED)
            {
                Period hzzzzzzzzzzzzzzzzh_ = LastED?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzh_);
                CqlDateTime hzzzzzzzzzzzzzzzzj_ = context.Operators.End(hzzzzzzzzzzzzzzzzi_);
                CqlValueSet hzzzzzzzzzzzzzzzzk_ = this.Observation_Services(context);
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? hzzzzzzzzzzzzzzzzm_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzd_);
                    CqlDateTime jzzzzzzzzzzzzzzzzf_ = context.Operators.End(jzzzzzzzzzzzzzzzze_);
                    Period jzzzzzzzzzzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzg_);
                    CqlDateTime jzzzzzzzzzzzzzzzzi_ = context.Operators.Start(jzzzzzzzzzzzzzzzzh_);
                    CqlQuantity jzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzj_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzg_);
                    CqlDateTime jzzzzzzzzzzzzzzzzn_ = context.Operators.Start(jzzzzzzzzzzzzzzzzm_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzn_, true, true);
                    bool? jzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzg_);
                    CqlDateTime jzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzr_);
                    bool? jzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzs_ is null));
                    bool? jzzzzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzt_);

                    return jzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzm_);
                object hzzzzzzzzzzzzzzzzo_(Encounter @this)
                {
                    Period jzzzzzzzzzzzzzzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzv_);
                    CqlDateTime jzzzzzzzzzzzzzzzzx_ = context.Operators.End(jzzzzzzzzzzzzzzzzw_);

                    return jzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzzzzzzp_);
                Period hzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzq_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzzzzzt_ = context.Operators.Start(hzzzzzzzzzzzzzzzzs_);
                Period hzzzzzzzzzzzzzzzzu_ = Visit?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzu_);
                CqlDateTime hzzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzzv_);
                CqlQuantity hzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzt_ ?? hzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzx_);
                IEnumerable<Encounter> izzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? izzzzzzzzzzzzzzzzb_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzzzzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzy_);
                    CqlDateTime kzzzzzzzzzzzzzzzza_ = context.Operators.End(jzzzzzzzzzzzzzzzzz_);
                    Period kzzzzzzzzzzzzzzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzb_);
                    CqlDateTime kzzzzzzzzzzzzzzzzd_ = context.Operators.Start(kzzzzzzzzzzzzzzzzc_);
                    CqlQuantity kzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzb_);
                    CqlDateTime kzzzzzzzzzzzzzzzzi_ = context.Operators.Start(kzzzzzzzzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzi_, true, true);
                    bool? kzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzj_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzb_);
                    CqlDateTime kzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzm_);
                    bool? kzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzn_ is null));
                    bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzo_);

                    return kzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzb_);
                object izzzzzzzzzzzzzzzzd_(Encounter @this)
                {
                    Period kzzzzzzzzzzzzzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzq_);
                    CqlDateTime kzzzzzzzzzzzzzzzzs_ = context.Operators.End(kzzzzzzzzzzzzzzzzr_);

                    return kzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Encounter>(izzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzzzzzzzzzzf_ = context.Operators.Last<Encounter>(izzzzzzzzzzzzzzzze_);
                Period izzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzf_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzg_);
                CqlDateTime izzzzzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzu_);
                CqlDateTime izzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzi_ ?? izzzzzzzzzzzzzzzzl_, true, true);
                bool? izzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzm_, default);
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? izzzzzzzzzzzzzzzzq_(Encounter LastObs)
                {
                    Period kzzzzzzzzzzzzzzzzt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzt_);
                    CqlDateTime kzzzzzzzzzzzzzzzzv_ = context.Operators.End(kzzzzzzzzzzzzzzzzu_);
                    Period kzzzzzzzzzzzzzzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzw_);
                    CqlDateTime kzzzzzzzzzzzzzzzzy_ = context.Operators.Start(kzzzzzzzzzzzzzzzzx_);
                    CqlQuantity kzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzz_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzw_);
                    CqlDateTime lzzzzzzzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzd_, true, true);
                    bool? lzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzze_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzw_);
                    CqlDateTime lzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzh_);
                    bool? lzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzi_ is null));
                    bool? lzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzj_);

                    return lzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzq_);
                object izzzzzzzzzzzzzzzzs_(Encounter @this)
                {
                    Period lzzzzzzzzzzzzzzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzl_);
                    CqlDateTime lzzzzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzzzzm_);

                    return lzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> izzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(izzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(izzzzzzzzzzzzzzzzt_);
                Period izzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzv_);
                CqlDateTime izzzzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzzzzzzzzz_);
                bool? jzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)((izzzzzzzzzzzzzzzzx_ ?? jzzzzzzzzzzzzzzzza_) is null));
                bool? jzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzb_);

                return jzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzi_);
            object gzzzzzzzzzzzzzzzzk_(Encounter @this)
            {
                Period lzzzzzzzzzzzzzzzzo_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzo_);
                CqlDateTime lzzzzzzzzzzzzzzzzq_ = context.Operators.End(lzzzzzzzzzzzzzzzzp_);

                return lzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzl_);
            Period gzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzm_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzn_);
            CqlDateTime gzzzzzzzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzzzzzzzo_);
            CqlValueSet gzzzzzzzzzzzzzzzzq_ = this.Observation_Services(context);
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? gzzzzzzzzzzzzzzzzs_(Encounter LastObs)
            {
                Period lzzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzr_);
                CqlDateTime lzzzzzzzzzzzzzzzzt_ = context.Operators.End(lzzzzzzzzzzzzzzzzs_);
                Period lzzzzzzzzzzzzzzzzu_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzzzzzzzzv_);
                CqlQuantity lzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzb_, true, true);
                bool? mzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzc_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzzzzzzzzf_);
                bool? mzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzg_ is null));
                bool? mzzzzzzzzzzzzzzzzi_ = context.Operators.And(mzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzh_);

                return mzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzs_);
            object gzzzzzzzzzzzzzzzzu_(Encounter @this)
            {
                Period mzzzzzzzzzzzzzzzzj_ = @this?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzj_);
                CqlDateTime mzzzzzzzzzzzzzzzzl_ = context.Operators.End(mzzzzzzzzzzzzzzzzk_);

                return mzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzzzzzzzzw_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzv_);
            Period gzzzzzzzzzzzzzzzzx_ = gzzzzzzzzzzzzzzzzw_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzx_);
            CqlDateTime gzzzzzzzzzzzzzzzzz_ = context.Operators.Start(gzzzzzzzzzzzzzzzzy_);
            Period hzzzzzzzzzzzzzzzza_ = Visit?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzc_ = context.Operators.Start(hzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzf_ = context.Operators.End(hzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzp_ ?? gzzzzzzzzzzzzzzzzz_ ?? hzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzf_, true, true);

            return hzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)gzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzm_ = this.HospitalizationWithObservation(context, Encounter);
        int? mzzzzzzzzzzzzzzzzn_ = this.LengthInDays(context, mzzzzzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
