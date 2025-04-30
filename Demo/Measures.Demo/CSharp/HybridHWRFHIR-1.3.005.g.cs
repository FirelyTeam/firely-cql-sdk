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
[CqlLibrary("HybridHWRFHIR", "1.3.005")]
public partial class HybridHWRFHIR_1_3_005 : ILibrary, ISingleton<HybridHWRFHIR_1_3_005>
{
    private HybridHWRFHIR_1_3_005() {}

    public static HybridHWRFHIR_1_3_005 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HybridHWRFHIR";
    public string Version => "1.3.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Body weight", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", valueSetVersion: null)]
    public CqlValueSet Body_weight(CqlContext _) => _Body_weight;
    private static readonly CqlValueSet _Body_weight = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", null);

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

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

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

    [CqlValueSetDefinition("Potassium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext _) => _Potassium_lab_test;
    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

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

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org");

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
          _Respiratory_rate,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime wzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzp_ = context.Operators.Interval(wzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzo_, true, false);
        object wzzzzzzzzzzzzzzzq_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", wzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzr_);

        return wzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> wzzzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] wzzzzzzzzzzzzzzzx_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzy_(Encounter Visit)
        {
            CqlValueSet xzzzzzzzzzzzzzzzc_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? xzzzzzzzzzzzzzzze_(Encounter LastED)
            {
                Period yzzzzzzzzzzzzzzzd_ = LastED?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzd_);
                CqlDateTime yzzzzzzzzzzzzzzzf_ = context.Operators.End(yzzzzzzzzzzzzzzze_);
                CqlValueSet yzzzzzzzzzzzzzzzg_ = this.Observation_Services(context);
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? yzzzzzzzzzzzzzzzi_(Encounter LastObs)
                {
                    Period zzzzzzzzzzzzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzz_);
                    CqlDateTime azzzzzzzzzzzzzzzzb_ = context.Operators.End(azzzzzzzzzzzzzzzza_);
                    Period azzzzzzzzzzzzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzc_);
                    CqlDateTime azzzzzzzzzzzzzzzze_ = context.Operators.Start(azzzzzzzzzzzzzzzzd_);
                    CqlQuantity azzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(azzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzc_);
                    CqlDateTime azzzzzzzzzzzzzzzzj_ = context.Operators.Start(azzzzzzzzzzzzzzzzi_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzk_ = context.Operators.Interval(azzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzj_, true, true);
                    bool? azzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzk_, default);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzc_);
                    CqlDateTime azzzzzzzzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzzzzzzzn_);
                    bool? azzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzo_ is null));
                    bool? azzzzzzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzp_);

                    return azzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzi_);
                object yzzzzzzzzzzzzzzzk_(Encounter @this)
                {
                    Period azzzzzzzzzzzzzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzr_);
                    CqlDateTime azzzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzzs_);

                    return azzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Encounter>(yzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzzzzzzzzzm_ = context.Operators.Last<Encounter>(yzzzzzzzzzzzzzzzl_);
                Period yzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzm_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzn_);
                CqlDateTime yzzzzzzzzzzzzzzzp_ = context.Operators.Start(yzzzzzzzzzzzzzzzo_);
                Period yzzzzzzzzzzzzzzzq_ = Visit?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzq_);
                CqlDateTime yzzzzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzzzzr_);
                CqlQuantity yzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime yzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzp_ ?? yzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzt_);
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? yzzzzzzzzzzzzzzzx_(Encounter LastObs)
                {
                    Period azzzzzzzzzzzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzu_);
                    CqlDateTime azzzzzzzzzzzzzzzzw_ = context.Operators.End(azzzzzzzzzzzzzzzzv_);
                    Period azzzzzzzzzzzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzx_);
                    CqlDateTime azzzzzzzzzzzzzzzzz_ = context.Operators.Start(azzzzzzzzzzzzzzzzy_);
                    CqlQuantity bzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzx_);
                    CqlDateTime bzzzzzzzzzzzzzzzze_ = context.Operators.Start(bzzzzzzzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzze_, true, true);
                    bool? bzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzf_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzx_);
                    CqlDateTime bzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzi_);
                    bool? bzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzj_ is null));
                    bool? bzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzk_);

                    return bzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzx_);
                object yzzzzzzzzzzzzzzzz_(Encounter @this)
                {
                    Period bzzzzzzzzzzzzzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzm_);
                    CqlDateTime bzzzzzzzzzzzzzzzzo_ = context.Operators.End(bzzzzzzzzzzzzzzzzn_);

                    return bzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Encounter> zzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Encounter>(yzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzzzzzzzzzb_ = context.Operators.Last<Encounter>(zzzzzzzzzzzzzzzza_);
                Period zzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzb_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzc_);
                CqlDateTime zzzzzzzzzzzzzzzze_ = context.Operators.Start(zzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzq_);
                CqlDateTime zzzzzzzzzzzzzzzzh_ = context.Operators.Start(zzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzi_ = context.Operators.Interval(yzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzze_ ?? zzzzzzzzzzzzzzzzh_, true, true);
                bool? zzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzi_, default);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? zzzzzzzzzzzzzzzzm_(Encounter LastObs)
                {
                    Period bzzzzzzzzzzzzzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzp_);
                    CqlDateTime bzzzzzzzzzzzzzzzzr_ = context.Operators.End(bzzzzzzzzzzzzzzzzq_);
                    Period bzzzzzzzzzzzzzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzs_);
                    CqlDateTime bzzzzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzzzzt_);
                    CqlQuantity bzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzs_);
                    CqlDateTime bzzzzzzzzzzzzzzzzz_ = context.Operators.Start(bzzzzzzzzzzzzzzzzy_);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzza_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzz_, true, true);
                    bool? czzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzza_, default);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzs_);
                    CqlDateTime czzzzzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzzzzd_);
                    bool? czzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzze_ is null));
                    bool? czzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzf_);

                    return czzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzm_);
                object zzzzzzzzzzzzzzzzo_(Encounter @this)
                {
                    Period czzzzzzzzzzzzzzzzh_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzh_);
                    CqlDateTime czzzzzzzzzzzzzzzzj_ = context.Operators.End(czzzzzzzzzzzzzzzzi_);

                    return czzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Encounter>(zzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzzzzzzzzzq_ = context.Operators.Last<Encounter>(zzzzzzzzzzzzzzzzp_);
                Period zzzzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzzzq_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzq_);
                CqlDateTime zzzzzzzzzzzzzzzzw_ = context.Operators.Start(zzzzzzzzzzzzzzzzv_);
                bool? zzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)((zzzzzzzzzzzzzzzzt_ ?? zzzzzzzzzzzzzzzzw_) is null));
                bool? zzzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzx_);

                return zzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzze_);
            object xzzzzzzzzzzzzzzzg_(Encounter @this)
            {
                Period czzzzzzzzzzzzzzzzk_ = @this?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzk_);
                CqlDateTime czzzzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzzzl_);

                return czzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Encounter>(xzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzzzzzzzzzi_ = context.Operators.Last<Encounter>(xzzzzzzzzzzzzzzzh_);
            Period xzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzi_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzj_);
            CqlDateTime xzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzk_);
            CqlValueSet xzzzzzzzzzzzzzzzm_ = this.Observation_Services(context);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? xzzzzzzzzzzzzzzzo_(Encounter LastObs)
            {
                Period czzzzzzzzzzzzzzzzn_ = LastObs?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzn_);
                CqlDateTime czzzzzzzzzzzzzzzzp_ = context.Operators.End(czzzzzzzzzzzzzzzzo_);
                Period czzzzzzzzzzzzzzzzq_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzq_);
                CqlDateTime czzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzr_);
                CqlQuantity czzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzq_);
                CqlDateTime czzzzzzzzzzzzzzzzx_ = context.Operators.Start(czzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzy_ = context.Operators.Interval(czzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzx_, true, true);
                bool? czzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzy_, default);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzq_);
                CqlDateTime dzzzzzzzzzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzzzzzzzzzb_);
                bool? dzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzc_ is null));
                bool? dzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzd_);

                return dzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzo_);
            object xzzzzzzzzzzzzzzzq_(Encounter @this)
            {
                Period dzzzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzf_);
                CqlDateTime dzzzzzzzzzzzzzzzzh_ = context.Operators.End(dzzzzzzzzzzzzzzzzg_);

                return dzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Encounter>(xzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzzzzzzzzzs_ = context.Operators.Last<Encounter>(xzzzzzzzzzzzzzzzr_);
            Period xzzzzzzzzzzzzzzzt_ = xzzzzzzzzzzzzzzzs_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzt_);
            CqlDateTime xzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzu_);
            Period xzzzzzzzzzzzzzzzw_ = Visit?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzw_);
            CqlDateTime yzzzzzzzzzzzzzzzb_ = context.Operators.End(yzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzc_ = context.Operators.Interval(xzzzzzzzzzzzzzzzl_ ?? xzzzzzzzzzzzzzzzv_ ?? xzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzb_, true, true);

            return yzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)wzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzi_ = context.Operators.Start(Value);
        CqlDateTime dzzzzzzzzzzzzzzzzj_ = context.Operators.End(Value);
        int? dzzzzzzzzzzzzzzzzk_ = context.Operators.DifferenceBetween(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_, "day");

        return dzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzl_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzn_ = this.Medicare_payer(context);
        IEnumerable<Coverage> dzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> dzzzzzzzzzzzzzzzzp_ = context.Operators.CrossJoin<Encounter, Coverage>(dzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? dzzzzzzzzzzzzzzzzq_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? dzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> dzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(dzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzy_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string dzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzzzza_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzz_, "finished");
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzb_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? ezzzzzzzzzzzzzzzzc_ = this.LengthInDays(context, ezzzzzzzzzzzzzzzzb_);
            bool? ezzzzzzzzzzzzzzzzd_ = context.Operators.Less(ezzzzzzzzzzzzzzzzc_, 365);
            bool? ezzzzzzzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzd_);
            Period ezzzzzzzzzzzzzzzzf_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzf_);
            CqlDateTime ezzzzzzzzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzi_, "day");
            bool? ezzzzzzzzzzzzzzzzk_ = context.Operators.And(ezzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzj_);
            Patient ezzzzzzzzzzzzzzzzl_ = this.Patient(context);
            Date ezzzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzzl_?.BirthDateElement;
            string ezzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzm_?.Value;
            CqlDate ezzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzf_);
            CqlDateTime ezzzzzzzzzzzzzzzzr_ = context.Operators.Start(ezzzzzzzzzzzzzzzzq_);
            CqlDate ezzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzr_);
            int? ezzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzs_, "year");
            bool? ezzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzt_, 65);
            bool? ezzzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzu_);

            return ezzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> dzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(dzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzs_);
        Encounter dzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(dzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<Encounter>(dzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);

        return ezzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzx_ = this.Inpatient_Encounters(context);
        string ezzzzzzzzzzzzzzzzy_(Encounter Encounter)
        {
            string fzzzzzzzzzzzzzzzzb_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string fzzzzzzzzzzzzzzzzc_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzb_ ?? "", ",");
            Id fzzzzzzzzzzzzzzzzd_ = Encounter?.IdElement;
            string fzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzzzd_);
            string fzzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzc_ ?? "", fzzzzzzzzzzzzzzzze_ ?? "");
            string fzzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzf_ ?? "", ",");
            bool? fzzzzzzzzzzzzzzzzh_(Observation Exam)
            {
                DataType gzzzzzzzzzzzzzzzzb_ = Exam?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzd_ is null));
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzzzzzzzzzg_);
                Period gzzzzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzi_);
                CqlDateTime gzzzzzzzzzzzzzzzzk_ = context.Operators.Start(gzzzzzzzzzzzzzzzzj_);
                CqlQuantity gzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzi_);
                CqlDateTime gzzzzzzzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzzzzzzzo_);
                CqlQuantity gzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzr_ = context.Operators.Add(gzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzr_, true, true);
                bool? gzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzs_, default);
                bool? gzzzzzzzzzzzzzzzzu_ = context.Operators.And(gzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzv_ = Exam?.StatusElement;
                string gzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzzv_);
                string[] gzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? gzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzy_);
                DataType hzzzzzzzzzzzzzzzza_ = Exam?.Value;
                bool? hzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzza_ is null));
                bool? hzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzb_);

                return hzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(ExamList, fzzzzzzzzzzzzzzzzh_);
            object fzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType hzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzzd_);
                CqlDateTime hzzzzzzzzzzzzzzzzf_ = context.Operators.Start(hzzzzzzzzzzzzzzzze_);

                return hzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzk_);
            DataType fzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzl_?.Value;
            CqlQuantity fzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzzzzzzzzzzzzm_ as Quantity);
            string fzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertQuantityToString(fzzzzzzzzzzzzzzzzn_);
            string fzzzzzzzzzzzzzzzzp_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzg_ ?? "", fzzzzzzzzzzzzzzzzo_ ?? "");
            string fzzzzzzzzzzzzzzzzq_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzp_ ?? "", ",");
            bool? fzzzzzzzzzzzzzzzzr_(Observation Exam)
            {
                DataType hzzzzzzzzzzzzzzzzg_ = Exam?.Effective;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzzg_);
                CqlDateTime hzzzzzzzzzzzzzzzzi_ = context.Operators.Start(hzzzzzzzzzzzzzzzzh_);
                bool? hzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzi_ is null));
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzzg_);
                CqlDateTime hzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzl_);
                Period hzzzzzzzzzzzzzzzzn_ = Encounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzo_);
                CqlQuantity hzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzzt_);
                CqlQuantity hzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzw_ = context.Operators.Add(hzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzw_, true, true);
                bool? hzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzx_, default);
                bool? hzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzy_);
                Code<ObservationStatus> izzzzzzzzzzzzzzzza_ = Exam?.StatusElement;
                string izzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzza_);
                string[] izzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? izzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzze_ = context.Operators.And(hzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzd_);
                DataType izzzzzzzzzzzzzzzzf_ = Exam?.Value;
                bool? izzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzf_ is null));
                bool? izzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ExamList, fzzzzzzzzzzzzzzzzr_);
            object fzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                DataType izzzzzzzzzzzzzzzzi_ = @this?.Effective;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzzi_);
                CqlDateTime izzzzzzzzzzzzzzzzk_ = context.Operators.Start(izzzzzzzzzzzzzzzzj_);

                return izzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzu_);
            DataType fzzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzzv_?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzw_);
            CqlDateTime fzzzzzzzzzzzzzzzzy_ = context.Operators.Start(fzzzzzzzzzzzzzzzzx_);
            string fzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateTimeToString(fzzzzzzzzzzzzzzzzy_);
            string gzzzzzzzzzzzzzzzza_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzq_ ?? "", fzzzzzzzzzzzzzzzzz_ ?? "");

            return gzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<string> ezzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, string>(ezzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzy_);
        IEnumerable<string> fzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<string>(ezzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzl_ = this.Inpatient_Encounters(context);
        string izzzzzzzzzzzzzzzzm_(Encounter Encounter)
        {
            string izzzzzzzzzzzzzzzzp_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string izzzzzzzzzzzzzzzzq_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzp_ ?? "", ",");
            Id izzzzzzzzzzzzzzzzr_ = Encounter?.IdElement;
            string izzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzr_);
            string izzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzq_ ?? "", izzzzzzzzzzzzzzzzs_ ?? "");
            string izzzzzzzzzzzzzzzzu_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzt_ ?? "", ",");
            bool? izzzzzzzzzzzzzzzzv_(Observation Exam)
            {
                DataType jzzzzzzzzzzzzzzzzp_ = Exam?.Effective;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzp_);
                CqlDateTime jzzzzzzzzzzzzzzzzr_ = context.Operators.Start(jzzzzzzzzzzzzzzzzq_);
                bool? jzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzr_ is null));
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzp_);
                CqlDateTime jzzzzzzzzzzzzzzzzv_ = context.Operators.Start(jzzzzzzzzzzzzzzzzu_);
                Period jzzzzzzzzzzzzzzzzw_ = Encounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzw_);
                CqlDateTime jzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzx_);
                CqlQuantity jzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzw_);
                CqlDateTime kzzzzzzzzzzzzzzzzd_ = context.Operators.Start(kzzzzzzzzzzzzzzzzc_);
                CqlDateTime kzzzzzzzzzzzzzzzzf_ = context.Operators.Add(kzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzf_, true, true);
                bool? kzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzg_, default);
                bool? kzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzh_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzj_ = Exam?.StatusElement;
                string kzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzzzj_);
                string[] kzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? kzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzm_);
                DataType kzzzzzzzzzzzzzzzzo_ = Exam?.Value;
                bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzo_ is null));
                bool? kzzzzzzzzzzzzzzzzq_ = context.Operators.And(kzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzp_);

                return kzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(ExamList, izzzzzzzzzzzzzzzzv_);
            object izzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType kzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzr_);
                CqlDateTime kzzzzzzzzzzzzzzzzt_ = context.Operators.Start(kzzzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzy_);
            DataType jzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzz_?.Value;
            CqlQuantity jzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzzzzzzzzzzzzzzzza_ as Quantity);
            string jzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertQuantityToString(jzzzzzzzzzzzzzzzzb_);
            string jzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzu_ ?? "", jzzzzzzzzzzzzzzzzc_ ?? "");
            string jzzzzzzzzzzzzzzzze_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzzd_ ?? "", ",");
            bool? jzzzzzzzzzzzzzzzzf_(Observation Exam)
            {
                DataType kzzzzzzzzzzzzzzzzu_ = Exam?.Effective;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzu_);
                CqlDateTime kzzzzzzzzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzzzzzzzzv_);
                bool? kzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzw_ is null));
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzzzzzzz_);
                Period lzzzzzzzzzzzzzzzzb_ = Encounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzb_);
                CqlDateTime lzzzzzzzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzzzzzzzc_);
                CqlQuantity lzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzb_);
                CqlDateTime lzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzh_);
                CqlDateTime lzzzzzzzzzzzzzzzzk_ = context.Operators.Add(lzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzk_, true, true);
                bool? lzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzl_, default);
                bool? lzzzzzzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzm_);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzo_ = Exam?.StatusElement;
                string lzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzzo_);
                string[] lzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? lzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzr_);
                DataType lzzzzzzzzzzzzzzzzt_ = Exam?.Value;
                bool? lzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzt_ is null));
                bool? lzzzzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzu_);

                return lzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(ExamList, jzzzzzzzzzzzzzzzzf_);
            object jzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzzzzx_);

                return lzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzi_);
            DataType jzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzj_?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzk_);
            CqlDateTime jzzzzzzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzzzzzzl_);
            string jzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateTimeToString(jzzzzzzzzzzzzzzzzm_);
            string jzzzzzzzzzzzzzzzzo_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzze_ ?? "", jzzzzzzzzzzzzzzzzn_ ?? "");

            return jzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<string> izzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, string>(izzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzm_);
        IEnumerable<string> izzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<string>(izzzzzzzzzzzzzzzzn_);

        return izzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        string mzzzzzzzzzzzzzzzza_(Encounter Encounter)
        {
            string mzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string mzzzzzzzzzzzzzzzze_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzd_ ?? "", ",");
            Id mzzzzzzzzzzzzzzzzf_ = Encounter?.IdElement;
            string mzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzzzf_);
            string mzzzzzzzzzzzzzzzzh_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzze_ ?? "", mzzzzzzzzzzzzzzzzg_ ?? "");
            string mzzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzh_ ?? "", ",");
            bool? mzzzzzzzzzzzzzzzzj_(Observation Lab)
            {
                Instant nzzzzzzzzzzzzzzzzc_ = Lab?.IssuedElement;
                bool? nzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzc_ is null));
                CqlDateTime nzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzzzzzzzc_);
                Period nzzzzzzzzzzzzzzzzg_ = Encounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzzzzzzh_);
                CqlQuantity nzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzp_ = context.Operators.Add(nzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzp_, true, true);
                bool? nzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzq_, default);
                bool? nzzzzzzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzr_);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzt_ = Lab?.StatusElement;
                string nzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzzzt_);
                string[] nzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? nzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzw_);
                DataType nzzzzzzzzzzzzzzzzy_ = Lab?.Value;
                bool? nzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzy_ is null));
                bool? ozzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzz_);

                return ozzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(LabList, mzzzzzzzzzzzzzzzzj_);
            object mzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;

                return ozzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzm_);
            DataType mzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzn_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzo_ as Quantity);
            string mzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertQuantityToString(mzzzzzzzzzzzzzzzzp_);
            string mzzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzi_ ?? "", mzzzzzzzzzzzzzzzzq_ ?? "");
            string mzzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzr_ ?? "", ",");
            bool? mzzzzzzzzzzzzzzzzt_(Observation Lab)
            {
                Instant ozzzzzzzzzzzzzzzzc_ = Lab?.IssuedElement;
                bool? ozzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzc_ is null));
                CqlDateTime ozzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ozzzzzzzzzzzzzzzzc_);
                Period ozzzzzzzzzzzzzzzzg_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzg_);
                CqlDateTime ozzzzzzzzzzzzzzzzi_ = context.Operators.Start(ozzzzzzzzzzzzzzzzh_);
                CqlQuantity ozzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzg_);
                CqlDateTime ozzzzzzzzzzzzzzzzn_ = context.Operators.Start(ozzzzzzzzzzzzzzzzm_);
                CqlDateTime ozzzzzzzzzzzzzzzzp_ = context.Operators.Add(ozzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzq_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzp_, true, true);
                bool? ozzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzq_, default);
                bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzr_);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzt_ = Lab?.StatusElement;
                string ozzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzzt_);
                string[] ozzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ozzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzw_);
                DataType ozzzzzzzzzzzzzzzzy_ = Lab?.Value;
                bool? ozzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzy_ is null));
                bool? pzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzz_);

                return pzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(LabList, mzzzzzzzzzzzzzzzzt_);
            object mzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant pzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;

                return pzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzw_);
            Instant mzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzx_?.IssuedElement;
            CqlDateTime mzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzzzzzzzzzzzzzzzy_);
            string nzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateTimeToString(mzzzzzzzzzzzzzzzzz_);
            string nzzzzzzzzzzzzzzzzb_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzs_ ?? "", nzzzzzzzzzzzzzzzza_ ?? "");

            return nzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<string> mzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, string>(lzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzza_);
        IEnumerable<string> mzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<string>(mzzzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzc_ = this.Heart_rate(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzf_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzze_, "FirstHeartRate");
        CqlCode pzzzzzzzzzzzzzzzzg_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzj_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzi_, "FirstSystolicBP");
        CqlCode pzzzzzzzzzzzzzzzzk_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzn_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzm_, "FirstRespRate");
        CqlValueSet pzzzzzzzzzzzzzzzzo_ = this.Body_temperature(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzq_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzp_, "FirstTemperature");
        CqlCode pzzzzzzzzzzzzzzzzr_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzu_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzt_, "FirstO2Saturation");
        CqlValueSet pzzzzzzzzzzzzzzzzv_ = this.Body_weight(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzx_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, pzzzzzzzzzzzzzzzzw_, "FirstWeight");
        CqlValueSet pzzzzzzzzzzzzzzzzy_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzza_ = this.FirstLabTestWithEncounterId(context, pzzzzzzzzzzzzzzzzz_, "FirstHematocrit");
        CqlValueSet qzzzzzzzzzzzzzzzzb_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzd_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzc_, "FirstWhiteBloodCell");
        CqlValueSet qzzzzzzzzzzzzzzzze_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzg_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzf_, "FirstPotassium");
        CqlValueSet qzzzzzzzzzzzzzzzzh_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzj_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzi_, "FirstSodium");
        CqlValueSet qzzzzzzzzzzzzzzzzk_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzm_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzl_, "FirstBicarbonate");
        CqlValueSet qzzzzzzzzzzzzzzzzn_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzp_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzo_, "FirstCreatinine");
        CqlValueSet qzzzzzzzzzzzzzzzzq_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzs_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzr_, "FirstGlucose");
        IEnumerable<string>[] qzzzzzzzzzzzzzzzzt_ = [
            pzzzzzzzzzzzzzzzzf_,
            pzzzzzzzzzzzzzzzzj_,
            pzzzzzzzzzzzzzzzzn_,
            pzzzzzzzzzzzzzzzzq_,
            pzzzzzzzzzzzzzzzzu_,
            pzzzzzzzzzzzzzzzzx_,
            qzzzzzzzzzzzzzzzza_,
            qzzzzzzzzzzzzzzzzd_,
            qzzzzzzzzzzzzzzzzg_,
            qzzzzzzzzzzzzzzzzj_,
            qzzzzzzzzzzzzzzzzm_,
            qzzzzzzzzzzzzzzzzp_,
            qzzzzzzzzzzzzzzzzs_,
        ];
        IEnumerable<string> qzzzzzzzzzzzzzzzzu_ = context.Operators.Flatten<string>(qzzzzzzzzzzzzzzzzt_ as IEnumerable<IEnumerable<string>>);

        return qzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate qzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate qzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? qzzzzzzzzzzzzzzzzx_ = context.Operators.DurationBetween(qzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzw_, "year");

        return qzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? qzzzzzzzzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? qzzzzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? rzzzzzzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? rzzzzzzzzzzzzzzzzb_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime rzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(qzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzza_, 0, 0, 0, 0, rzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzd_ = context.Operators.Start(Stay);
        CqlDateTime rzzzzzzzzzzzzzzzze_ = context.Operators.End(Stay);
        int? rzzzzzzzzzzzzzzzzf_ = context.Operators.DifferenceBetween(rzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzze_, "day");

        return rzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzg_ = this.HospitalizationWithObservation(context, Encounter);
        int? rzzzzzzzzzzzzzzzzh_ = this.LengthInDays(context, rzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzh_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
