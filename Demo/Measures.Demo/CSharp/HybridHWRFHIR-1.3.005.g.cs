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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org", default, default);

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
        CqlDateTime wzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime wzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzh_ = context.Operators.Interval(wzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzg_, true, false);
        object wzzzzzzzzzzzzzzzi_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", wzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzj_);

        return wzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> wzzzzzzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] wzzzzzzzzzzzzzzzp_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzq_(Encounter Visit)
        {
            CqlValueSet wzzzzzzzzzzzzzzzu_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? wzzzzzzzzzzzzzzzw_(Encounter LastED)
            {
                Period xzzzzzzzzzzzzzzzv_ = LastED?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzv_);
                CqlDateTime xzzzzzzzzzzzzzzzx_ = context.Operators.End(xzzzzzzzzzzzzzzzw_);
                CqlValueSet xzzzzzzzzzzzzzzzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? yzzzzzzzzzzzzzzza_(Encounter LastObs)
                {
                    Period zzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzr_);
                    CqlDateTime zzzzzzzzzzzzzzzzt_ = context.Operators.End(zzzzzzzzzzzzzzzzs_);
                    Period zzzzzzzzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzu_);
                    CqlDateTime zzzzzzzzzzzzzzzzw_ = context.Operators.Start(zzzzzzzzzzzzzzzzv_);
                    CqlQuantity zzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzu_);
                    CqlDateTime azzzzzzzzzzzzzzzzb_ = context.Operators.Start(azzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzc_ = context.Operators.Interval(zzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzb_, true, true);
                    bool? azzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzu_);
                    CqlDateTime azzzzzzzzzzzzzzzzg_ = context.Operators.Start(azzzzzzzzzzzzzzzzf_);
                    bool? azzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzg_ is null));
                    bool? azzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzh_);

                    return azzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzza_);
                object yzzzzzzzzzzzzzzzc_(Encounter @this)
                {
                    Period azzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzj_);
                    CqlDateTime azzzzzzzzzzzzzzzzl_ = context.Operators.End(azzzzzzzzzzzzzzzzk_);

                    return azzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Encounter>(yzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzzzzzzzzze_ = context.Operators.Last<Encounter>(yzzzzzzzzzzzzzzzd_);
                Period yzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzze_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzzzzzg_);
                Period yzzzzzzzzzzzzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzi_);
                CqlDateTime yzzzzzzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzzzzzzj_);
                CqlQuantity yzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime yzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzh_ ?? yzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzl_);
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? yzzzzzzzzzzzzzzzp_(Encounter LastObs)
                {
                    Period azzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzm_);
                    CqlDateTime azzzzzzzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzzzzzzn_);
                    Period azzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzp_);
                    CqlDateTime azzzzzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzzzzq_);
                    CqlQuantity azzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzp_);
                    CqlDateTime azzzzzzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzx_ = context.Operators.Interval(azzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzw_, true, true);
                    bool? azzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzzp_);
                    CqlDateTime bzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzza_);
                    bool? bzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzb_ is null));
                    bool? bzzzzzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzc_);

                    return bzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzp_);
                object yzzzzzzzzzzzzzzzr_(Encounter @this)
                {
                    Period bzzzzzzzzzzzzzzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzze_);
                    CqlDateTime bzzzzzzzzzzzzzzzzg_ = context.Operators.End(bzzzzzzzzzzzzzzzzf_);

                    return bzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Encounter>(yzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzzzzzzzzzt_ = context.Operators.Last<Encounter>(yzzzzzzzzzzzzzzzs_);
                Period yzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzt_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzw_ = context.Operators.Start(yzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzi_);
                CqlDateTime yzzzzzzzzzzzzzzzz_ = context.Operators.Start(yzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzza_ = context.Operators.Interval(yzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzw_ ?? yzzzzzzzzzzzzzzzz_, true, true);
                bool? zzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzza_, default);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? zzzzzzzzzzzzzzzze_(Encounter LastObs)
                {
                    Period bzzzzzzzzzzzzzzzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzh_);
                    CqlDateTime bzzzzzzzzzzzzzzzzj_ = context.Operators.End(bzzzzzzzzzzzzzzzzi_);
                    Period bzzzzzzzzzzzzzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzk_);
                    CqlDateTime bzzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzzl_);
                    CqlQuantity bzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzn_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzk_);
                    CqlDateTime bzzzzzzzzzzzzzzzzr_ = context.Operators.Start(bzzzzzzzzzzzzzzzzq_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzr_, true, true);
                    bool? bzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzs_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzk_);
                    CqlDateTime bzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzv_);
                    bool? bzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzw_ is null));
                    bool? bzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzx_);

                    return bzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzze_);
                object zzzzzzzzzzzzzzzzg_(Encounter @this)
                {
                    Period bzzzzzzzzzzzzzzzzz_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzz_);
                    CqlDateTime czzzzzzzzzzzzzzzzb_ = context.Operators.End(czzzzzzzzzzzzzzzza_);

                    return czzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Encounter>(zzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzzzzzzzzzi_ = context.Operators.Last<Encounter>(zzzzzzzzzzzzzzzzh_);
                Period zzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzi_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzj_);
                CqlDateTime zzzzzzzzzzzzzzzzl_ = context.Operators.Start(zzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzi_);
                CqlDateTime zzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzn_);
                bool? zzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)((zzzzzzzzzzzzzzzzl_ ?? zzzzzzzzzzzzzzzzo_) is null));
                bool? zzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzp_);

                return zzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzw_);
            object wzzzzzzzzzzzzzzzy_(Encounter @this)
            {
                Period czzzzzzzzzzzzzzzzc_ = @this?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzze_ = context.Operators.End(czzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Encounter>(wzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzzzzzzzzza_ = context.Operators.Last<Encounter>(wzzzzzzzzzzzzzzzz_);
            Period xzzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzzza_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzb_);
            CqlDateTime xzzzzzzzzzzzzzzzd_ = context.Operators.Start(xzzzzzzzzzzzzzzzc_);
            CqlValueSet xzzzzzzzzzzzzzzze_ = this.Observation_Services(context);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? xzzzzzzzzzzzzzzzg_(Encounter LastObs)
            {
                Period czzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzh_ = context.Operators.End(czzzzzzzzzzzzzzzzg_);
                Period czzzzzzzzzzzzzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzj_);
                CqlQuantity czzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzp_, true, true);
                bool? czzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzq_, default);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzu_ = context.Operators.Start(czzzzzzzzzzzzzzzzt_);
                bool? czzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzu_ is null));
                bool? czzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzg_);
            object xzzzzzzzzzzzzzzzi_(Encounter @this)
            {
                Period czzzzzzzzzzzzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzz_ = context.Operators.End(czzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Encounter>(xzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzzzzzzzzzk_ = context.Operators.Last<Encounter>(xzzzzzzzzzzzzzzzj_);
            Period xzzzzzzzzzzzzzzzl_ = xzzzzzzzzzzzzzzzk_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzl_);
            CqlDateTime xzzzzzzzzzzzzzzzn_ = context.Operators.Start(xzzzzzzzzzzzzzzzm_);
            Period xzzzzzzzzzzzzzzzo_ = Visit?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzzzt_ = context.Operators.End(xzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzu_ = context.Operators.Interval(xzzzzzzzzzzzzzzzd_ ?? xzzzzzzzzzzzzzzzn_ ?? xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzt_, true, true);

            return xzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)wzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(wzzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime dzzzzzzzzzzzzzzzza_ = context.Operators.Start(Value);
        CqlDateTime dzzzzzzzzzzzzzzzzb_ = context.Operators.End(Value);
        int? dzzzzzzzzzzzzzzzzc_ = context.Operators.DifferenceBetween(dzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzb_, "day");

        return dzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzd_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzf_ = this.Medicare_payer(context);
        IEnumerable<Coverage> dzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> dzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Coverage>(dzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? dzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? dzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> dzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(dzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzi_);
        bool? dzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzq_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string dzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzq_);
            bool? dzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzr_, "finished");
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzt_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? dzzzzzzzzzzzzzzzzu_ = this.LengthInDays(context, dzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzv_ = context.Operators.Less(dzzzzzzzzzzzzzzzzu_, 365);
            bool? dzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzv_);
            Period dzzzzzzzzzzzzzzzzx_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzx_);
            CqlDateTime dzzzzzzzzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzza_, "day");
            bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzb_);
            Patient ezzzzzzzzzzzzzzzzd_ = this.Patient(context);
            Date ezzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzd_?.BirthDateElement;
            string ezzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzze_?.Value;
            CqlDate ezzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzx_);
            CqlDateTime ezzzzzzzzzzzzzzzzj_ = context.Operators.Start(ezzzzzzzzzzzzzzzzi_);
            CqlDate ezzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzj_);
            int? ezzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzk_, "year");
            bool? ezzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzl_, 65);
            bool? ezzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> dzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(dzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzk_);
        Encounter dzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(dzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(dzzzzzzzzzzzzzzzzn_);

        return dzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzo_ = this.Inpatient_Encounters(context);

        return ezzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);
        string ezzzzzzzzzzzzzzzzq_(Encounter Encounter)
        {
            string ezzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string ezzzzzzzzzzzzzzzzu_ = context.Operators.Concatenate(ezzzzzzzzzzzzzzzzt_ ?? "", ",");
            Id ezzzzzzzzzzzzzzzzv_ = Encounter?.IdElement;
            string ezzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzv_);
            string ezzzzzzzzzzzzzzzzx_ = context.Operators.Concatenate(ezzzzzzzzzzzzzzzzu_ ?? "", ezzzzzzzzzzzzzzzzw_ ?? "");
            string ezzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate(ezzzzzzzzzzzzzzzzx_ ?? "", ",");
            bool? ezzzzzzzzzzzzzzzzz_(Observation Exam)
            {
                DataType fzzzzzzzzzzzzzzzzt_ = Exam?.Effective;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzzzzzzu_);
                bool? fzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzv_ is null));
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzy_);
                Period gzzzzzzzzzzzzzzzza_ = Encounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzza_);
                CqlDateTime gzzzzzzzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzzzzzzzb_);
                CqlQuantity gzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzza_);
                CqlDateTime gzzzzzzzzzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzzzzzzzzzg_);
                CqlQuantity gzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzj_ = context.Operators.Add(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(gzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzj_, true, true);
                bool? gzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzk_, default);
                bool? gzzzzzzzzzzzzzzzzm_ = context.Operators.And(fzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzl_);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzn_ = Exam?.StatusElement;
                string gzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzzn_);
                string[] gzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? gzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzq_);
                DataType gzzzzzzzzzzzzzzzzs_ = Exam?.Value;
                bool? gzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzs_ is null));
                bool? gzzzzzzzzzzzzzzzzu_ = context.Operators.And(gzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzt_);

                return gzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(ExamList, ezzzzzzzzzzzzzzzzz_);
            object fzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzv_);
                CqlDateTime gzzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzzw_);

                return gzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzc_);
            DataType fzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzd_?.Value;
            CqlQuantity fzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzzzzzzzzzzzze_ as Quantity);
            string fzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertQuantityToString(fzzzzzzzzzzzzzzzzf_);
            string fzzzzzzzzzzzzzzzzh_ = context.Operators.Concatenate(ezzzzzzzzzzzzzzzzy_ ?? "", fzzzzzzzzzzzzzzzzg_ ?? "");
            string fzzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzh_ ?? "", ",");
            bool? fzzzzzzzzzzzzzzzzj_(Observation Exam)
            {
                DataType gzzzzzzzzzzzzzzzzy_ = Exam?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzzz_);
                bool? hzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzza_ is null));
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzzze_ = context.Operators.Start(hzzzzzzzzzzzzzzzzd_);
                Period hzzzzzzzzzzzzzzzzf_ = Encounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzzzzzzzg_);
                CqlQuantity hzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzl_);
                CqlQuantity hzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzo_ = context.Operators.Add(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzo_, true, true);
                bool? hzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzp_, default);
                bool? hzzzzzzzzzzzzzzzzr_ = context.Operators.And(hzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzq_);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzs_ = Exam?.StatusElement;
                string hzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzzs_);
                string[] hzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? hzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzv_);
                DataType hzzzzzzzzzzzzzzzzx_ = Exam?.Value;
                bool? hzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzx_ is null));
                bool? hzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzy_);

                return hzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(ExamList, fzzzzzzzzzzzzzzzzj_);
            object fzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType izzzzzzzzzzzzzzzza_ = @this?.Effective;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzza_);
                CqlDateTime izzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzm_);
            DataType fzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzn_?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzo_);
            CqlDateTime fzzzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzzzp_);
            string fzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateTimeToString(fzzzzzzzzzzzzzzzzq_);
            string fzzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(fzzzzzzzzzzzzzzzzi_ ?? "", fzzzzzzzzzzzzzzzzr_ ?? "");

            return fzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<string> ezzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, string>(ezzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzq_);
        IEnumerable<string> ezzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<string>(ezzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzd_ = this.Inpatient_Encounters(context);
        string izzzzzzzzzzzzzzzze_(Encounter Encounter)
        {
            string izzzzzzzzzzzzzzzzh_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string izzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzh_ ?? "", ",");
            Id izzzzzzzzzzzzzzzzj_ = Encounter?.IdElement;
            string izzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzj_);
            string izzzzzzzzzzzzzzzzl_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzi_ ?? "", izzzzzzzzzzzzzzzzk_ ?? "");
            string izzzzzzzzzzzzzzzzm_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzl_ ?? "", ",");
            bool? izzzzzzzzzzzzzzzzn_(Observation Exam)
            {
                DataType jzzzzzzzzzzzzzzzzh_ = Exam?.Effective;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzh_);
                CqlDateTime jzzzzzzzzzzzzzzzzj_ = context.Operators.Start(jzzzzzzzzzzzzzzzzi_);
                bool? jzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzj_ is null));
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzh_);
                CqlDateTime jzzzzzzzzzzzzzzzzn_ = context.Operators.Start(jzzzzzzzzzzzzzzzzm_);
                Period jzzzzzzzzzzzzzzzzo_ = Encounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzo_);
                CqlDateTime jzzzzzzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzzzzzzp_);
                CqlQuantity jzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzo_);
                CqlDateTime jzzzzzzzzzzzzzzzzv_ = context.Operators.Start(jzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzx_ = context.Operators.Add(jzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzx_, true, true);
                bool? jzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzy_, default);
                bool? kzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzz_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzb_ = Exam?.StatusElement;
                string kzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzzzb_);
                string[] kzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? kzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzze_);
                DataType kzzzzzzzzzzzzzzzzg_ = Exam?.Value;
                bool? kzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzg_ is null));
                bool? kzzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzh_);

                return kzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(ExamList, izzzzzzzzzzzzzzzzn_);
            object izzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType kzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzj_);
                CqlDateTime kzzzzzzzzzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzzzzzzzzzk_);

                return kzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzq_);
            DataType izzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzr_?.Value;
            CqlQuantity izzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzs_ as Quantity);
            string izzzzzzzzzzzzzzzzu_ = context.Operators.ConvertQuantityToString(izzzzzzzzzzzzzzzzt_);
            string izzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzm_ ?? "", izzzzzzzzzzzzzzzzu_ ?? "");
            string izzzzzzzzzzzzzzzzw_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzv_ ?? "", ",");
            bool? izzzzzzzzzzzzzzzzx_(Observation Exam)
            {
                DataType kzzzzzzzzzzzzzzzzm_ = Exam?.Effective;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzm_);
                CqlDateTime kzzzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzzzn_);
                bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzo_ is null));
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzzm_);
                CqlDateTime kzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzr_);
                Period kzzzzzzzzzzzzzzzzt_ = Encounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzu_);
                CqlQuantity kzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzt_);
                CqlDateTime lzzzzzzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzzzzzzz_);
                CqlDateTime lzzzzzzzzzzzzzzzzc_ = context.Operators.Add(lzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzc_, true, true);
                bool? lzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzd_, default);
                bool? lzzzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzze_);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzg_ = Exam?.StatusElement;
                string lzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzzg_);
                string[] lzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? lzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzj_);
                DataType lzzzzzzzzzzzzzzzzl_ = Exam?.Value;
                bool? lzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzl_ is null));
                bool? lzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzm_);

                return lzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ExamList, izzzzzzzzzzzzzzzzx_);
            object izzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzzo_);
                CqlDateTime lzzzzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzzzzp_);

                return lzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzza_);
            DataType jzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzb_?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzc_);
            CqlDateTime jzzzzzzzzzzzzzzzze_ = context.Operators.Start(jzzzzzzzzzzzzzzzzd_);
            string jzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateTimeToString(jzzzzzzzzzzzzzzzze_);
            string jzzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzw_ ?? "", jzzzzzzzzzzzzzzzzf_ ?? "");

            return jzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<string> izzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, string>(izzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzze_);
        IEnumerable<string> izzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<string>(izzzzzzzzzzzzzzzzf_);

        return izzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);
        string lzzzzzzzzzzzzzzzzs_(Encounter Encounter)
        {
            string lzzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string lzzzzzzzzzzzzzzzzw_ = context.Operators.Concatenate(lzzzzzzzzzzzzzzzzv_ ?? "", ",");
            Id lzzzzzzzzzzzzzzzzx_ = Encounter?.IdElement;
            string lzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzzx_);
            string lzzzzzzzzzzzzzzzzz_ = context.Operators.Concatenate(lzzzzzzzzzzzzzzzzw_ ?? "", lzzzzzzzzzzzzzzzzy_ ?? "");
            string mzzzzzzzzzzzzzzzza_ = context.Operators.Concatenate(lzzzzzzzzzzzzzzzzz_ ?? "", ",");
            bool? mzzzzzzzzzzzzzzzzb_(Observation Lab)
            {
                Instant mzzzzzzzzzzzzzzzzu_ = Lab?.IssuedElement;
                bool? mzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzu_ is null));
                CqlDateTime mzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzzzzzzzzzzzzzzzu_);
                Period mzzzzzzzzzzzzzzzzy_ = Encounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzy_);
                CqlDateTime nzzzzzzzzzzzzzzzza_ = context.Operators.Start(mzzzzzzzzzzzzzzzzz_);
                CqlQuantity nzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzy_);
                CqlDateTime nzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzze_);
                CqlDateTime nzzzzzzzzzzzzzzzzh_ = context.Operators.Add(nzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzh_, true, true);
                bool? nzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzi_, default);
                bool? nzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzj_);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzl_ = Lab?.StatusElement;
                string nzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzzzl_);
                string[] nzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? nzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzp_ = context.Operators.And(nzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzo_);
                DataType nzzzzzzzzzzzzzzzzq_ = Lab?.Value;
                bool? nzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzq_ is null));
                bool? nzzzzzzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzr_);

                return nzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(LabList, mzzzzzzzzzzzzzzzzb_);
            object mzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;

                return nzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzze_);
            DataType mzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzf_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzg_ as Quantity);
            string mzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertQuantityToString(mzzzzzzzzzzzzzzzzh_);
            string mzzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzza_ ?? "", mzzzzzzzzzzzzzzzzi_ ?? "");
            string mzzzzzzzzzzzzzzzzk_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzj_ ?? "", ",");
            bool? mzzzzzzzzzzzzzzzzl_(Observation Lab)
            {
                Instant nzzzzzzzzzzzzzzzzu_ = Lab?.IssuedElement;
                bool? nzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzu_ is null));
                CqlDateTime nzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzzzzzzzu_);
                Period nzzzzzzzzzzzzzzzzy_ = Encounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzy_);
                CqlDateTime ozzzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzzz_);
                CqlQuantity ozzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzy_);
                CqlDateTime ozzzzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzzzze_);
                CqlDateTime ozzzzzzzzzzzzzzzzh_ = context.Operators.Add(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzh_, true, true);
                bool? ozzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzi_, default);
                bool? ozzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzj_);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzl_ = Lab?.StatusElement;
                string ozzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzzl_);
                string[] ozzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ozzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzo_);
                DataType ozzzzzzzzzzzzzzzzq_ = Lab?.Value;
                bool? ozzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzq_ is null));
                bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzr_);

                return ozzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(LabList, mzzzzzzzzzzzzzzzzl_);
            object mzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;

                return ozzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzo_);
            Instant mzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzp_?.IssuedElement;
            CqlDateTime mzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzzzzzzzzzzzzzzzq_);
            string mzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateTimeToString(mzzzzzzzzzzzzzzzzr_);
            string mzzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzk_ ?? "", mzzzzzzzzzzzzzzzzs_ ?? "");

            return mzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<string> lzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, string>(lzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzs_);
        IEnumerable<string> lzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<string>(lzzzzzzzzzzzzzzzzt_);

        return lzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzu_ = this.Heart_rate(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ozzzzzzzzzzzzzzzzx_ = this.FirstPhysicalExamWithEncounterId(context, ozzzzzzzzzzzzzzzzw_, "FirstHeartRate");
        CqlCode ozzzzzzzzzzzzzzzzy_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzb_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzza_, "FirstSystolicBP");
        CqlCode pzzzzzzzzzzzzzzzzc_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzf_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzze_, "FirstRespRate");
        CqlValueSet pzzzzzzzzzzzzzzzzg_ = this.Body_temperature(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzi_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzh_, "FirstTemperature");
        CqlCode pzzzzzzzzzzzzzzzzj_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzm_ = this.FirstPhysicalExamWithEncounterId(context, pzzzzzzzzzzzzzzzzl_, "FirstO2Saturation");
        CqlValueSet pzzzzzzzzzzzzzzzzn_ = this.Body_weight(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzp_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, pzzzzzzzzzzzzzzzzo_, "FirstWeight");
        CqlValueSet pzzzzzzzzzzzzzzzzq_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzs_ = this.FirstLabTestWithEncounterId(context, pzzzzzzzzzzzzzzzzr_, "FirstHematocrit");
        CqlValueSet pzzzzzzzzzzzzzzzzt_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzv_ = this.FirstLabTestWithEncounterId(context, pzzzzzzzzzzzzzzzzu_, "FirstWhiteBloodCell");
        CqlValueSet pzzzzzzzzzzzzzzzzw_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> pzzzzzzzzzzzzzzzzy_ = this.FirstLabTestWithEncounterId(context, pzzzzzzzzzzzzzzzzx_, "FirstPotassium");
        CqlValueSet pzzzzzzzzzzzzzzzzz_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzb_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzza_, "FirstSodium");
        CqlValueSet qzzzzzzzzzzzzzzzzc_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzze_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzd_, "FirstBicarbonate");
        CqlValueSet qzzzzzzzzzzzzzzzzf_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzh_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzg_, "FirstCreatinine");
        CqlValueSet qzzzzzzzzzzzzzzzzi_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> qzzzzzzzzzzzzzzzzk_ = this.FirstLabTestWithEncounterId(context, qzzzzzzzzzzzzzzzzj_, "FirstGlucose");
        IEnumerable<string>[] qzzzzzzzzzzzzzzzzl_ = [
            ozzzzzzzzzzzzzzzzx_,
            pzzzzzzzzzzzzzzzzb_,
            pzzzzzzzzzzzzzzzzf_,
            pzzzzzzzzzzzzzzzzi_,
            pzzzzzzzzzzzzzzzzm_,
            pzzzzzzzzzzzzzzzzp_,
            pzzzzzzzzzzzzzzzzs_,
            pzzzzzzzzzzzzzzzzv_,
            pzzzzzzzzzzzzzzzzy_,
            qzzzzzzzzzzzzzzzzb_,
            qzzzzzzzzzzzzzzzze_,
            qzzzzzzzzzzzzzzzzh_,
            qzzzzzzzzzzzzzzzzk_,
        ];
        IEnumerable<string> qzzzzzzzzzzzzzzzzm_ = context.Operators.Flatten<string>(qzzzzzzzzzzzzzzzzl_ as IEnumerable<IEnumerable<string>>);

        return qzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate qzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate qzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? qzzzzzzzzzzzzzzzzp_ = context.Operators.DurationBetween(qzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzo_, "year");

        return qzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? qzzzzzzzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? qzzzzzzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? qzzzzzzzzzzzzzzzzs_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? qzzzzzzzzzzzzzzzzt_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime qzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(qzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzs_, 0, 0, 0, 0, qzzzzzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzv_ = context.Operators.Start(Stay);
        CqlDateTime qzzzzzzzzzzzzzzzzw_ = context.Operators.End(Stay);
        int? qzzzzzzzzzzzzzzzzx_ = context.Operators.DifferenceBetween(qzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzw_, "day");

        return qzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzy_ = this.HospitalizationWithObservation(context, Encounter);
        int? qzzzzzzzzzzzzzzzzz_ = this.LengthInDays(context, qzzzzzzzzzzzzzzzzy_);

        return qzzzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
