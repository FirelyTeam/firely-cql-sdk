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
      new CqlCodeSystem("http://loinc.org", "2.69", [
          _Birth_date,
          _Heart_rate,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime nzzzzzzo_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime nzzzzzzp_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> nzzzzzzq_ = context.Operators.Interval(nzzzzzzo_, nzzzzzzp_, true, false);
        object nzzzzzzr_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", nzzzzzzq_);

        return (CqlInterval<CqlDateTime>)nzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzzzzzt_ = context.Operators.SingletonFrom<Patient>(nzzzzzzs_);

        return nzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> nzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> nzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return nzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> nzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return nzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return nzzzzzzx_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime nzzzzzzy_ = context.Operators.Start(Value);
        CqlDateTime nzzzzzzz_ = context.Operators.End(Value);
        int? ozzzzzza_ = context.Operators.DifferenceBetween(nzzzzzzy_, nzzzzzzz_, "day");

        return ozzzzzza_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet ozzzzzzb_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> ozzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzd_ = this.Medicare_payer(context);
        IEnumerable<Coverage> ozzzzzze_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> ozzzzzzf_ = context.Operators.CrossJoin<Encounter, Coverage>(ozzzzzzc_, ozzzzzze_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? ozzzzzzg_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? ozzzzzzn_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> ozzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(ozzzzzzf_, ozzzzzzg_);
        bool? ozzzzzzi_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> ozzzzzzo_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string ozzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzo_);
            bool? ozzzzzzq_ = context.Operators.Equal(ozzzzzzp_, "finished");
            CqlInterval<CqlDateTime> ozzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? ozzzzzzs_ = this.LengthInDays(context, ozzzzzzr_);
            bool? ozzzzzzt_ = context.Operators.Less(ozzzzzzs_, 365);
            bool? ozzzzzzu_ = context.Operators.And(ozzzzzzq_, ozzzzzzt_);
            Period ozzzzzzv_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzv_);
            CqlDateTime ozzzzzzx_ = context.Operators.End(ozzzzzzw_);
            CqlInterval<CqlDateTime> ozzzzzzy_ = this.Measurement_Period(context);
            bool? ozzzzzzz_ = context.Operators.In<CqlDateTime>(ozzzzzzx_, ozzzzzzy_, "day");
            bool? pzzzzzza_ = context.Operators.And(ozzzzzzu_, ozzzzzzz_);
            Patient pzzzzzzb_ = this.Patient(context);
            Date pzzzzzzc_ = pzzzzzzb_?.BirthDateElement;
            string pzzzzzzd_ = pzzzzzzc_?.Value;
            CqlDate pzzzzzze_ = context.Operators.ConvertStringToDate(pzzzzzzd_);
            CqlInterval<CqlDateTime> pzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzv_);
            CqlDateTime pzzzzzzh_ = context.Operators.Start(pzzzzzzg_);
            CqlDate pzzzzzzi_ = context.Operators.DateFrom(pzzzzzzh_);
            int? pzzzzzzj_ = context.Operators.CalculateAgeAt(pzzzzzze_, pzzzzzzi_, "year");
            CqlInterval<int?> pzzzzzzk_ = context.Operators.Interval(65, 94, true, true);
            bool? pzzzzzzl_ = context.Operators.In<int?>(pzzzzzzj_, pzzzzzzk_, default);
            bool? pzzzzzzm_ = context.Operators.And(pzzzzzza_, pzzzzzzl_);

            return pzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> ozzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(ozzzzzzh_, ozzzzzzi_);
        Encounter ozzzzzzk_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> ozzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(ozzzzzzj_, ozzzzzzk_);
        IEnumerable<Encounter> ozzzzzzm_ = context.Operators.Distinct<Encounter>(ozzzzzzl_);

        return ozzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzn_ = this.Inpatient_Encounters(context);

        return pzzzzzzn_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> pzzzzzzo_ = this.Inpatient_Encounters(context);
        string pzzzzzzp_(Encounter Encounter)
        {
            string pzzzzzzs_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string pzzzzzzt_ = context.Operators.Concatenate(pzzzzzzs_ ?? "", ",");
            Id pzzzzzzu_ = Encounter?.IdElement;
            string pzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzu_);
            string pzzzzzzw_ = context.Operators.Concatenate(pzzzzzzt_ ?? "", pzzzzzzv_ ?? "");
            string pzzzzzzx_ = context.Operators.Concatenate(pzzzzzzw_ ?? "", " , ");
            bool? pzzzzzzy_(Observation Exam)
            {
                DataType qzzzzzzs_ = Exam?.Effective;
                CqlInterval<CqlDateTime> qzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzs_);
                CqlDateTime qzzzzzzu_ = context.Operators.Start(qzzzzzzt_);
                bool? qzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzu_ is null));
                CqlInterval<CqlDateTime> qzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzs_);
                CqlDateTime qzzzzzzy_ = context.Operators.Start(qzzzzzzx_);
                Period qzzzzzzz_ = Encounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzz_);
                CqlDateTime rzzzzzzb_ = context.Operators.Start(rzzzzzza_);
                CqlQuantity rzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzd_ = context.Operators.Subtract(rzzzzzzb_, rzzzzzzc_);
                CqlInterval<CqlDateTime> rzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzz_);
                CqlDateTime rzzzzzzg_ = context.Operators.Start(rzzzzzzf_);
                CqlQuantity rzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime rzzzzzzi_ = context.Operators.Add(rzzzzzzg_, rzzzzzzh_);
                CqlInterval<CqlDateTime> rzzzzzzj_ = context.Operators.Interval(rzzzzzzd_, rzzzzzzi_, true, true);
                bool? rzzzzzzk_ = context.Operators.In<CqlDateTime>(qzzzzzzy_, rzzzzzzj_, default);
                bool? rzzzzzzl_ = context.Operators.And(qzzzzzzv_, rzzzzzzk_);
                Code<ObservationStatus> rzzzzzzm_ = Exam?.StatusElement;
                string rzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzm_);
                string[] rzzzzzzo_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? rzzzzzzp_ = context.Operators.In<string>(rzzzzzzn_, rzzzzzzo_ as IEnumerable<string>);
                bool? rzzzzzzq_ = context.Operators.And(rzzzzzzl_, rzzzzzzp_);
                DataType rzzzzzzr_ = Exam?.Value;
                bool? rzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzr_ is null));
                bool? rzzzzzzt_ = context.Operators.And(rzzzzzzq_, rzzzzzzs_);

                return rzzzzzzt_;
            };
            IEnumerable<Observation> pzzzzzzz_ = context.Operators.Where<Observation>(ExamList, pzzzzzzy_);
            object qzzzzzza_(Observation @this)
            {
                DataType rzzzzzzu_ = @this?.Effective;
                CqlInterval<CqlDateTime> rzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzu_);
                CqlDateTime rzzzzzzw_ = context.Operators.Start(rzzzzzzv_);

                return rzzzzzzw_;
            };
            IEnumerable<Observation> qzzzzzzb_ = context.Operators.SortBy<Observation>(pzzzzzzz_, qzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzc_ = context.Operators.First<Observation>(qzzzzzzb_);
            DataType qzzzzzzd_ = qzzzzzzc_?.Value;
            CqlQuantity qzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzzzzzd_ as Quantity);
            string qzzzzzzf_ = context.Operators.ConvertQuantityToString(qzzzzzze_);
            string qzzzzzzg_ = context.Operators.Concatenate(pzzzzzzx_ ?? "", qzzzzzzf_ ?? "");
            string qzzzzzzh_ = context.Operators.Concatenate(qzzzzzzg_ ?? "", ",");
            bool? qzzzzzzi_(Observation Exam)
            {
                DataType rzzzzzzx_ = Exam?.Effective;
                CqlInterval<CqlDateTime> rzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzx_);
                CqlDateTime rzzzzzzz_ = context.Operators.Start(rzzzzzzy_);
                bool? szzzzzza_ = context.Operators.Not((bool?)(rzzzzzzz_ is null));
                CqlInterval<CqlDateTime> szzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzx_);
                CqlDateTime szzzzzzd_ = context.Operators.Start(szzzzzzc_);
                Period szzzzzze_ = Encounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzze_);
                CqlDateTime szzzzzzg_ = context.Operators.Start(szzzzzzf_);
                CqlQuantity szzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzi_ = context.Operators.Subtract(szzzzzzg_, szzzzzzh_);
                CqlInterval<CqlDateTime> szzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzze_);
                CqlDateTime szzzzzzl_ = context.Operators.Start(szzzzzzk_);
                CqlQuantity szzzzzzm_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime szzzzzzn_ = context.Operators.Add(szzzzzzl_, szzzzzzm_);
                CqlInterval<CqlDateTime> szzzzzzo_ = context.Operators.Interval(szzzzzzi_, szzzzzzn_, true, true);
                bool? szzzzzzp_ = context.Operators.In<CqlDateTime>(szzzzzzd_, szzzzzzo_, default);
                bool? szzzzzzq_ = context.Operators.And(szzzzzza_, szzzzzzp_);
                Code<ObservationStatus> szzzzzzr_ = Exam?.StatusElement;
                string szzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzr_);
                string[] szzzzzzt_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? szzzzzzu_ = context.Operators.In<string>(szzzzzzs_, szzzzzzt_ as IEnumerable<string>);
                bool? szzzzzzv_ = context.Operators.And(szzzzzzq_, szzzzzzu_);
                DataType szzzzzzw_ = Exam?.Value;
                bool? szzzzzzx_ = context.Operators.Not((bool?)(szzzzzzw_ is null));
                bool? szzzzzzy_ = context.Operators.And(szzzzzzv_, szzzzzzx_);

                return szzzzzzy_;
            };
            IEnumerable<Observation> qzzzzzzj_ = context.Operators.Where<Observation>(ExamList, qzzzzzzi_);
            object qzzzzzzk_(Observation @this)
            {
                DataType szzzzzzz_ = @this?.Effective;
                CqlInterval<CqlDateTime> tzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzz_);
                CqlDateTime tzzzzzzb_ = context.Operators.Start(tzzzzzza_);

                return tzzzzzzb_;
            };
            IEnumerable<Observation> qzzzzzzl_ = context.Operators.SortBy<Observation>(qzzzzzzj_, qzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzm_ = context.Operators.First<Observation>(qzzzzzzl_);
            DataType qzzzzzzn_ = qzzzzzzm_?.Effective;
            CqlInterval<CqlDateTime> qzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzn_);
            CqlDateTime qzzzzzzp_ = context.Operators.Start(qzzzzzzo_);
            string qzzzzzzq_ = context.Operators.ConvertDateTimeToString(qzzzzzzp_);
            string qzzzzzzr_ = context.Operators.Concatenate(qzzzzzzh_ ?? "", qzzzzzzq_ ?? "");

            return qzzzzzzr_;
        };
        IEnumerable<string> pzzzzzzq_ = context.Operators.Select<Encounter, string>(pzzzzzzo_, pzzzzzzp_);
        IEnumerable<string> pzzzzzzr_ = context.Operators.Distinct<string>(pzzzzzzq_);

        return pzzzzzzr_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> tzzzzzzc_ = this.Inpatient_Encounters(context);
        string tzzzzzzd_(Encounter Encounter)
        {
            string tzzzzzzg_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string tzzzzzzh_ = context.Operators.Concatenate(tzzzzzzg_ ?? "", ",");
            Id tzzzzzzi_ = Encounter?.IdElement;
            string tzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzi_);
            string tzzzzzzk_ = context.Operators.Concatenate(tzzzzzzh_ ?? "", tzzzzzzj_ ?? "");
            string tzzzzzzl_ = context.Operators.Concatenate(tzzzzzzk_ ?? "", ",");
            bool? tzzzzzzm_(Observation Lab)
            {
                Instant uzzzzzzf_ = Lab?.IssuedElement;
                bool? uzzzzzzg_ = context.Operators.Not((bool?)(uzzzzzzf_ is null));
                CqlDateTime uzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzf_);
                Period uzzzzzzj_ = Encounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzj_);
                CqlDateTime uzzzzzzl_ = context.Operators.Start(uzzzzzzk_);
                CqlQuantity uzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzn_ = context.Operators.Subtract(uzzzzzzl_, uzzzzzzm_);
                CqlInterval<CqlDateTime> uzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzj_);
                CqlDateTime uzzzzzzq_ = context.Operators.Start(uzzzzzzp_);
                CqlDateTime uzzzzzzs_ = context.Operators.Add(uzzzzzzq_, uzzzzzzm_);
                CqlInterval<CqlDateTime> uzzzzzzt_ = context.Operators.Interval(uzzzzzzn_, uzzzzzzs_, true, true);
                bool? uzzzzzzu_ = context.Operators.In<CqlDateTime>(uzzzzzzi_, uzzzzzzt_, default);
                bool? uzzzzzzv_ = context.Operators.And(uzzzzzzg_, uzzzzzzu_);
                Code<ObservationStatus> uzzzzzzw_ = Lab?.StatusElement;
                string uzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzw_);
                string[] uzzzzzzy_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? uzzzzzzz_ = context.Operators.In<string>(uzzzzzzx_, uzzzzzzy_ as IEnumerable<string>);
                bool? vzzzzzza_ = context.Operators.And(uzzzzzzv_, uzzzzzzz_);
                DataType vzzzzzzb_ = Lab?.Value;
                bool? vzzzzzzc_ = context.Operators.Not((bool?)(vzzzzzzb_ is null));
                bool? vzzzzzzd_ = context.Operators.And(vzzzzzza_, vzzzzzzc_);

                return vzzzzzzd_;
            };
            IEnumerable<Observation> tzzzzzzn_ = context.Operators.Where<Observation>(LabList, tzzzzzzm_);
            object tzzzzzzo_(Observation @this)
            {
                Instant vzzzzzze_ = @this?.IssuedElement;

                return vzzzzzze_;
            };
            IEnumerable<Observation> tzzzzzzp_ = context.Operators.SortBy<Observation>(tzzzzzzn_, tzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzq_ = context.Operators.First<Observation>(tzzzzzzp_);
            DataType tzzzzzzr_ = tzzzzzzq_?.Value;
            CqlQuantity tzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzzzzzzr_ as Quantity);
            string tzzzzzzt_ = context.Operators.ConvertQuantityToString(tzzzzzzs_);
            string tzzzzzzu_ = context.Operators.Concatenate(tzzzzzzl_ ?? "", tzzzzzzt_ ?? "");
            string tzzzzzzv_ = context.Operators.Concatenate(tzzzzzzu_ ?? "", ",");
            bool? tzzzzzzw_(Observation Lab)
            {
                Instant vzzzzzzf_ = Lab?.IssuedElement;
                bool? vzzzzzzg_ = context.Operators.Not((bool?)(vzzzzzzf_ is null));
                CqlDateTime vzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, vzzzzzzf_);
                Period vzzzzzzj_ = Encounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzzzzj_);
                CqlDateTime vzzzzzzl_ = context.Operators.Start(vzzzzzzk_);
                CqlQuantity vzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzn_ = context.Operators.Subtract(vzzzzzzl_, vzzzzzzm_);
                CqlInterval<CqlDateTime> vzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzzzzj_);
                CqlDateTime vzzzzzzq_ = context.Operators.Start(vzzzzzzp_);
                CqlDateTime vzzzzzzs_ = context.Operators.Add(vzzzzzzq_, vzzzzzzm_);
                CqlInterval<CqlDateTime> vzzzzzzt_ = context.Operators.Interval(vzzzzzzn_, vzzzzzzs_, true, true);
                bool? vzzzzzzu_ = context.Operators.In<CqlDateTime>(vzzzzzzi_, vzzzzzzt_, default);
                bool? vzzzzzzv_ = context.Operators.And(vzzzzzzg_, vzzzzzzu_);
                Code<ObservationStatus> vzzzzzzw_ = Lab?.StatusElement;
                string vzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzw_);
                string[] vzzzzzzy_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? vzzzzzzz_ = context.Operators.In<string>(vzzzzzzx_, vzzzzzzy_ as IEnumerable<string>);
                bool? wzzzzzza_ = context.Operators.And(vzzzzzzv_, vzzzzzzz_);
                DataType wzzzzzzb_ = Lab?.Value;
                bool? wzzzzzzc_ = context.Operators.Not((bool?)(wzzzzzzb_ is null));
                bool? wzzzzzzd_ = context.Operators.And(wzzzzzza_, wzzzzzzc_);

                return wzzzzzzd_;
            };
            IEnumerable<Observation> tzzzzzzx_ = context.Operators.Where<Observation>(LabList, tzzzzzzw_);
            object tzzzzzzy_(Observation @this)
            {
                Instant wzzzzzze_ = @this?.IssuedElement;

                return wzzzzzze_;
            };
            IEnumerable<Observation> tzzzzzzz_ = context.Operators.SortBy<Observation>(tzzzzzzx_, tzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzza_ = context.Operators.First<Observation>(tzzzzzzz_);
            Instant uzzzzzzb_ = uzzzzzza_?.IssuedElement;
            CqlDateTime uzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzb_);
            string uzzzzzzd_ = context.Operators.ConvertDateTimeToString(uzzzzzzc_);
            string uzzzzzze_ = context.Operators.Concatenate(tzzzzzzv_ ?? "", uzzzzzzd_ ?? "");

            return uzzzzzze_;
        };
        IEnumerable<string> tzzzzzze_ = context.Operators.Select<Encounter, string>(tzzzzzzc_, tzzzzzzd_);
        IEnumerable<string> tzzzzzzf_ = context.Operators.Distinct<string>(tzzzzzze_);

        return tzzzzzzf_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode wzzzzzzf_ = this.Heart_rate(context);
        IEnumerable<CqlCode> wzzzzzzg_ = context.Operators.ToList<CqlCode>(wzzzzzzf_);
        IEnumerable<Observation> wzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzg_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzi_ = this.FirstPhysicalExamWithEncounterId(context, wzzzzzzh_, "FirstHeartRate");
        CqlCode wzzzzzzj_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> wzzzzzzk_ = context.Operators.ToList<CqlCode>(wzzzzzzj_);
        IEnumerable<Observation> wzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzk_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzm_ = this.FirstPhysicalExamWithEncounterId(context, wzzzzzzl_, "FirstSystolicBP");
        CqlValueSet wzzzzzzn_ = this.Body_temperature(context);
        IEnumerable<Observation> wzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzp_ = this.FirstPhysicalExamWithEncounterId(context, wzzzzzzo_, "FirstTemperature");
        CqlCode wzzzzzzq_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> wzzzzzzr_ = context.Operators.ToList<CqlCode>(wzzzzzzq_);
        IEnumerable<Observation> wzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzr_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzt_ = this.FirstPhysicalExamWithEncounterId(context, wzzzzzzs_, "FirstO2Saturation");
        CqlValueSet wzzzzzzu_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> wzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzw_ = this.FirstLabTestWithEncounterId(context, wzzzzzzv_, "FirstHematocrit");
        CqlValueSet wzzzzzzx_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> wzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> wzzzzzzz_ = this.FirstLabTestWithEncounterId(context, wzzzzzzy_, "FirstPlateletCount");
        CqlValueSet xzzzzzza_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> xzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> xzzzzzzc_ = this.FirstLabTestWithEncounterId(context, xzzzzzzb_, "FirstWhiteBloodCell");
        CqlValueSet xzzzzzzd_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> xzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> xzzzzzzf_ = this.FirstLabTestWithEncounterId(context, xzzzzzze_, "FirstSodium");
        CqlValueSet xzzzzzzg_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> xzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> xzzzzzzi_ = this.FirstLabTestWithEncounterId(context, xzzzzzzh_, "FirstBicarbonate");
        CqlValueSet xzzzzzzj_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> xzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> xzzzzzzl_ = this.FirstLabTestWithEncounterId(context, xzzzzzzk_, "FirstCreatinine");
        IEnumerable<string>[] xzzzzzzm_ = [
            wzzzzzzi_,
            wzzzzzzm_,
            wzzzzzzp_,
            wzzzzzzt_,
            wzzzzzzw_,
            wzzzzzzz_,
            xzzzzzzc_,
            xzzzzzzf_,
            xzzzzzzi_,
            xzzzzzzl_,
        ];
        IEnumerable<string> xzzzzzzn_ = context.Operators.Flatten<string>(xzzzzzzm_ as IEnumerable<IEnumerable<string>>);

        return xzzzzzzn_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate xzzzzzzo_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate xzzzzzzp_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? xzzzzzzq_ = context.Operators.DurationBetween(xzzzzzzo_, xzzzzzzp_, "year");

        return xzzzzzzq_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? xzzzzzzr_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? xzzzzzzs_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? xzzzzzzt_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? xzzzzzzu_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime xzzzzzzv_ = context.Operators.DateTime(xzzzzzzr_, xzzzzzzs_, xzzzzzzt_, 0, 0, 0, 0, xzzzzzzu_);

        return xzzzzzzv_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime xzzzzzzw_ = context.Operators.Start(Stay);
        CqlDateTime xzzzzzzx_ = context.Operators.End(Stay);
        int? xzzzzzzy_ = context.Operators.DifferenceBetween(xzzzzzzw_, xzzzzzzx_, "day");

        return xzzzzzzy_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] xzzzzzzz_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> yzzzzzza_(Encounter Visit)
        {
            CqlValueSet yzzzzzze_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> yzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? yzzzzzzg_(Encounter LastED)
            {
                Period zzzzzzzf_ = LastED?.Period;
                CqlInterval<CqlDateTime> zzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzf_);
                CqlDateTime zzzzzzzh_ = context.Operators.End(zzzzzzzg_);
                CqlValueSet zzzzzzzi_ = this.Observation_Services(context);
                IEnumerable<Encounter> zzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? zzzzzzzk_(Encounter LastObs)
                {
                    Period bzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzb_);
                    CqlDateTime bzzzzzzzd_ = context.Operators.End(bzzzzzzzc_);
                    Period bzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzze_);
                    CqlDateTime bzzzzzzzg_ = context.Operators.Start(bzzzzzzzf_);
                    CqlQuantity bzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzi_ = context.Operators.Subtract(bzzzzzzzg_, bzzzzzzzh_);
                    CqlInterval<CqlDateTime> bzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzze_);
                    CqlDateTime bzzzzzzzl_ = context.Operators.Start(bzzzzzzzk_);
                    CqlInterval<CqlDateTime> bzzzzzzzm_ = context.Operators.Interval(bzzzzzzzi_, bzzzzzzzl_, true, true);
                    bool? bzzzzzzzn_ = context.Operators.In<CqlDateTime>(bzzzzzzzd_, bzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzze_);
                    CqlDateTime bzzzzzzzq_ = context.Operators.Start(bzzzzzzzp_);
                    bool? bzzzzzzzr_ = context.Operators.Not((bool?)(bzzzzzzzq_ is null));
                    bool? bzzzzzzzs_ = context.Operators.And(bzzzzzzzn_, bzzzzzzzr_);

                    return bzzzzzzzs_;
                };
                IEnumerable<Encounter> zzzzzzzl_ = context.Operators.Where<Encounter>(zzzzzzzj_, zzzzzzzk_);
                object zzzzzzzm_(Encounter @this)
                {
                    Period bzzzzzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzt_);
                    CqlDateTime bzzzzzzzv_ = context.Operators.End(bzzzzzzzu_);

                    return bzzzzzzzv_;
                };
                IEnumerable<Encounter> zzzzzzzn_ = context.Operators.SortBy<Encounter>(zzzzzzzl_, zzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzo_ = context.Operators.Last<Encounter>(zzzzzzzn_);
                Period zzzzzzzp_ = zzzzzzzo_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzp_);
                CqlDateTime zzzzzzzr_ = context.Operators.Start(zzzzzzzq_);
                Period zzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> zzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzs_);
                CqlDateTime zzzzzzzu_ = context.Operators.Start(zzzzzzzt_);
                CqlQuantity zzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime zzzzzzzw_ = context.Operators.Subtract(zzzzzzzr_ ?? zzzzzzzu_, zzzzzzzv_);
                IEnumerable<Encounter> zzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? zzzzzzzz_(Encounter LastObs)
                {
                    Period bzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzw_);
                    CqlDateTime bzzzzzzzy_ = context.Operators.End(bzzzzzzzx_);
                    Period bzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzz_);
                    CqlDateTime czzzzzzzb_ = context.Operators.Start(czzzzzzza_);
                    CqlQuantity czzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czzzzzzzd_ = context.Operators.Subtract(czzzzzzzb_, czzzzzzzc_);
                    CqlInterval<CqlDateTime> czzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzz_);
                    CqlDateTime czzzzzzzg_ = context.Operators.Start(czzzzzzzf_);
                    CqlInterval<CqlDateTime> czzzzzzzh_ = context.Operators.Interval(czzzzzzzd_, czzzzzzzg_, true, true);
                    bool? czzzzzzzi_ = context.Operators.In<CqlDateTime>(bzzzzzzzy_, czzzzzzzh_, default);
                    CqlInterval<CqlDateTime> czzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzz_);
                    CqlDateTime czzzzzzzl_ = context.Operators.Start(czzzzzzzk_);
                    bool? czzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzl_ is null));
                    bool? czzzzzzzn_ = context.Operators.And(czzzzzzzi_, czzzzzzzm_);

                    return czzzzzzzn_;
                };
                IEnumerable<Encounter> azzzzzzza_ = context.Operators.Where<Encounter>(zzzzzzzy_, zzzzzzzz_);
                object azzzzzzzb_(Encounter @this)
                {
                    Period czzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzo_);
                    CqlDateTime czzzzzzzq_ = context.Operators.End(czzzzzzzp_);

                    return czzzzzzzq_;
                };
                IEnumerable<Encounter> azzzzzzzc_ = context.Operators.SortBy<Encounter>(azzzzzzza_, azzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzzzzd_ = context.Operators.Last<Encounter>(azzzzzzzc_);
                Period azzzzzzze_ = azzzzzzzd_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzze_);
                CqlDateTime azzzzzzzg_ = context.Operators.Start(azzzzzzzf_);
                CqlInterval<CqlDateTime> azzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzs_);
                CqlDateTime azzzzzzzj_ = context.Operators.Start(azzzzzzzi_);
                CqlInterval<CqlDateTime> azzzzzzzk_ = context.Operators.Interval(zzzzzzzw_, azzzzzzzg_ ?? azzzzzzzj_, true, true);
                bool? azzzzzzzl_ = context.Operators.In<CqlDateTime>(zzzzzzzh_, azzzzzzzk_, default);
                IEnumerable<Encounter> azzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? azzzzzzzo_(Encounter LastObs)
                {
                    Period czzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzr_);
                    CqlDateTime czzzzzzzt_ = context.Operators.End(czzzzzzzs_);
                    Period czzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzu_);
                    CqlDateTime czzzzzzzw_ = context.Operators.Start(czzzzzzzv_);
                    CqlQuantity czzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czzzzzzzy_ = context.Operators.Subtract(czzzzzzzw_, czzzzzzzx_);
                    CqlInterval<CqlDateTime> dzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzu_);
                    CqlDateTime dzzzzzzzb_ = context.Operators.Start(dzzzzzzza_);
                    CqlInterval<CqlDateTime> dzzzzzzzc_ = context.Operators.Interval(czzzzzzzy_, dzzzzzzzb_, true, true);
                    bool? dzzzzzzzd_ = context.Operators.In<CqlDateTime>(czzzzzzzt_, dzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> dzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzu_);
                    CqlDateTime dzzzzzzzg_ = context.Operators.Start(dzzzzzzzf_);
                    bool? dzzzzzzzh_ = context.Operators.Not((bool?)(dzzzzzzzg_ is null));
                    bool? dzzzzzzzi_ = context.Operators.And(dzzzzzzzd_, dzzzzzzzh_);

                    return dzzzzzzzi_;
                };
                IEnumerable<Encounter> azzzzzzzp_ = context.Operators.Where<Encounter>(azzzzzzzn_, azzzzzzzo_);
                object azzzzzzzq_(Encounter @this)
                {
                    Period dzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzj_);
                    CqlDateTime dzzzzzzzl_ = context.Operators.End(dzzzzzzzk_);

                    return dzzzzzzzl_;
                };
                IEnumerable<Encounter> azzzzzzzr_ = context.Operators.SortBy<Encounter>(azzzzzzzp_, azzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzzzzs_ = context.Operators.Last<Encounter>(azzzzzzzr_);
                Period azzzzzzzt_ = azzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzt_);
                CqlDateTime azzzzzzzv_ = context.Operators.Start(azzzzzzzu_);
                CqlInterval<CqlDateTime> azzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzs_);
                CqlDateTime azzzzzzzy_ = context.Operators.Start(azzzzzzzx_);
                bool? azzzzzzzz_ = context.Operators.Not((bool?)((azzzzzzzv_ ?? azzzzzzzy_) is null));
                bool? bzzzzzzza_ = context.Operators.And(azzzzzzzl_, azzzzzzzz_);

                return bzzzzzzza_;
            };
            IEnumerable<Encounter> yzzzzzzh_ = context.Operators.Where<Encounter>(yzzzzzzf_, yzzzzzzg_);
            object yzzzzzzi_(Encounter @this)
            {
                Period dzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzm_);
                CqlDateTime dzzzzzzzo_ = context.Operators.End(dzzzzzzzn_);

                return dzzzzzzzo_;
            };
            IEnumerable<Encounter> yzzzzzzj_ = context.Operators.SortBy<Encounter>(yzzzzzzh_, yzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter yzzzzzzk_ = context.Operators.Last<Encounter>(yzzzzzzj_);
            Period yzzzzzzl_ = yzzzzzzk_?.Period;
            CqlInterval<CqlDateTime> yzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzl_);
            CqlDateTime yzzzzzzn_ = context.Operators.Start(yzzzzzzm_);
            CqlValueSet yzzzzzzo_ = this.Observation_Services(context);
            IEnumerable<Encounter> yzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? yzzzzzzq_(Encounter LastObs)
            {
                Period dzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzp_);
                CqlDateTime dzzzzzzzr_ = context.Operators.End(dzzzzzzzq_);
                Period dzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzs_);
                CqlDateTime dzzzzzzzu_ = context.Operators.Start(dzzzzzzzt_);
                CqlQuantity dzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dzzzzzzzw_ = context.Operators.Subtract(dzzzzzzzu_, dzzzzzzzv_);
                CqlInterval<CqlDateTime> dzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzs_);
                CqlDateTime dzzzzzzzz_ = context.Operators.Start(dzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzza_ = context.Operators.Interval(dzzzzzzzw_, dzzzzzzzz_, true, true);
                bool? ezzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzr_, ezzzzzzza_, default);
                CqlInterval<CqlDateTime> ezzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzs_);
                CqlDateTime ezzzzzzze_ = context.Operators.Start(ezzzzzzzd_);
                bool? ezzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzze_ is null));
                bool? ezzzzzzzg_ = context.Operators.And(ezzzzzzzb_, ezzzzzzzf_);

                return ezzzzzzzg_;
            };
            IEnumerable<Encounter> yzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzp_, yzzzzzzq_);
            object yzzzzzzs_(Encounter @this)
            {
                Period ezzzzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzh_);
                CqlDateTime ezzzzzzzj_ = context.Operators.End(ezzzzzzzi_);

                return ezzzzzzzj_;
            };
            IEnumerable<Encounter> yzzzzzzt_ = context.Operators.SortBy<Encounter>(yzzzzzzr_, yzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter yzzzzzzu_ = context.Operators.Last<Encounter>(yzzzzzzt_);
            Period yzzzzzzv_ = yzzzzzzu_?.Period;
            CqlInterval<CqlDateTime> yzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzv_);
            CqlDateTime yzzzzzzx_ = context.Operators.Start(yzzzzzzw_);
            Period yzzzzzzy_ = Visit?.Period;
            CqlInterval<CqlDateTime> yzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzy_);
            CqlDateTime zzzzzzza_ = context.Operators.Start(yzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzy_);
            CqlDateTime zzzzzzzd_ = context.Operators.End(zzzzzzzc_);
            CqlInterval<CqlDateTime> zzzzzzze_ = context.Operators.Interval(yzzzzzzn_ ?? yzzzzzzx_ ?? zzzzzzza_, zzzzzzzd_, true, true);

            return zzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzb_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)xzzzzzzz_, yzzzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzb_);
        CqlInterval<CqlDateTime> yzzzzzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzzzzzc_);

        return yzzzzzzd_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> ezzzzzzzk_ = this.HospitalizationWithObservation(context, Encounter);
        int? ezzzzzzzl_ = this.LengthInDays(context, ezzzzzzzk_);

        return ezzzzzzzl_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
