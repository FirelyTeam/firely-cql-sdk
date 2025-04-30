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
      new CqlCodeSystem("http://loinc.org", "2.69",
          _Birth_date,
          _Heart_rate,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Respiratory_rate,
          _Systolic_blood_pressure);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime azzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzm_ = context.Operators.Interval(azzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzl_, true, false);
        object azzzzzzzzzzzzzzzzn_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", azzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] azzzzzzzzzzzzzzzzu_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzv_(Encounter Visit)
        {
            CqlValueSet azzzzzzzzzzzzzzzzz_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? bzzzzzzzzzzzzzzzzb_(Encounter LastED)
            {
                Period czzzzzzzzzzzzzzzza_ = LastED?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzzzzzzzb_);
                CqlValueSet czzzzzzzzzzzzzzzzd_ = this.Observation_Services(context);
                IEnumerable<Encounter> czzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? czzzzzzzzzzzzzzzzf_(Encounter LastObs)
                {
                    Period dzzzzzzzzzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzw_);
                    CqlDateTime dzzzzzzzzzzzzzzzzy_ = context.Operators.End(dzzzzzzzzzzzzzzzzx_);
                    Period dzzzzzzzzzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzz_);
                    CqlDateTime ezzzzzzzzzzzzzzzzb_ = context.Operators.Start(ezzzzzzzzzzzzzzzza_);
                    CqlQuantity ezzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzz_);
                    CqlDateTime ezzzzzzzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzh_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzg_, true, true);
                    bool? ezzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzz_);
                    CqlDateTime ezzzzzzzzzzzzzzzzl_ = context.Operators.Start(ezzzzzzzzzzzzzzzzk_);
                    bool? ezzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzl_ is null));
                    bool? ezzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzm_);

                    return ezzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> czzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzf_);
                object czzzzzzzzzzzzzzzzh_(Encounter @this)
                {
                    Period ezzzzzzzzzzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzo_);
                    CqlDateTime ezzzzzzzzzzzzzzzzq_ = context.Operators.End(ezzzzzzzzzzzzzzzzp_);

                    return ezzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Encounter> czzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(czzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(czzzzzzzzzzzzzzzzi_);
                Period czzzzzzzzzzzzzzzzk_ = czzzzzzzzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzk_);
                CqlDateTime czzzzzzzzzzzzzzzzm_ = context.Operators.Start(czzzzzzzzzzzzzzzzl_);
                Period czzzzzzzzzzzzzzzzn_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzn_);
                CqlDateTime czzzzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzzzo_);
                CqlQuantity czzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzm_ ?? czzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzq_);
                IEnumerable<Encounter> czzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? czzzzzzzzzzzzzzzzu_(Encounter LastObs)
                {
                    Period ezzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzr_);
                    CqlDateTime ezzzzzzzzzzzzzzzzt_ = context.Operators.End(ezzzzzzzzzzzzzzzzs_);
                    Period ezzzzzzzzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzu_);
                    CqlDateTime ezzzzzzzzzzzzzzzzw_ = context.Operators.Start(ezzzzzzzzzzzzzzzzv_);
                    CqlQuantity ezzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzu_);
                    CqlDateTime fzzzzzzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzb_, true, true);
                    bool? fzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzu_);
                    CqlDateTime fzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzf_);
                    bool? fzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzg_ is null));
                    bool? fzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzh_);

                    return fzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> czzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzu_);
                object czzzzzzzzzzzzzzzzw_(Encounter @this)
                {
                    Period fzzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzj_);
                    CqlDateTime fzzzzzzzzzzzzzzzzl_ = context.Operators.End(fzzzzzzzzzzzzzzzzk_);

                    return fzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> czzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Encounter>(czzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzzzzzzzzzzzzzy_ = context.Operators.Last<Encounter>(czzzzzzzzzzzzzzzzx_);
                Period czzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzy_?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzz_);
                CqlDateTime dzzzzzzzzzzzzzzzzb_ = context.Operators.Start(dzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzn_);
                CqlDateTime dzzzzzzzzzzzzzzzze_ = context.Operators.Start(dzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzb_ ?? dzzzzzzzzzzzzzzzze_, true, true);
                bool? dzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzf_, default);
                IEnumerable<Encounter> dzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? dzzzzzzzzzzzzzzzzj_(Encounter LastObs)
                {
                    Period fzzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzm_);
                    CqlDateTime fzzzzzzzzzzzzzzzzo_ = context.Operators.End(fzzzzzzzzzzzzzzzzn_);
                    Period fzzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzp_);
                    CqlDateTime fzzzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzzzq_);
                    CqlQuantity fzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzp_);
                    CqlDateTime fzzzzzzzzzzzzzzzzw_ = context.Operators.Start(fzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzw_, true, true);
                    bool? fzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzp_);
                    CqlDateTime gzzzzzzzzzzzzzzzzb_ = context.Operators.Start(gzzzzzzzzzzzzzzzza_);
                    bool? gzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzb_ is null));
                    bool? gzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzc_);

                    return gzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Encounter> dzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_);
                object dzzzzzzzzzzzzzzzzl_(Encounter @this)
                {
                    Period gzzzzzzzzzzzzzzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzze_);
                    CqlDateTime gzzzzzzzzzzzzzzzzg_ = context.Operators.End(gzzzzzzzzzzzzzzzzf_);

                    return gzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Encounter> dzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Encounter>(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Encounter>(dzzzzzzzzzzzzzzzzm_);
                Period dzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzn_?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzq_ = context.Operators.Start(dzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzzzn_);
                CqlDateTime dzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzs_);
                bool? dzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)((dzzzzzzzzzzzzzzzzq_ ?? dzzzzzzzzzzzzzzzzt_) is null));
                bool? dzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzb_);
            object bzzzzzzzzzzzzzzzzd_(Encounter @this)
            {
                Period gzzzzzzzzzzzzzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzh_);
                CqlDateTime gzzzzzzzzzzzzzzzzj_ = context.Operators.End(gzzzzzzzzzzzzzzzzi_);

                return gzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Encounter>(bzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter bzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Encounter>(bzzzzzzzzzzzzzzzze_);
            Period bzzzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzzzf_?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzg_);
            CqlDateTime bzzzzzzzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzzzzzzzh_);
            CqlValueSet bzzzzzzzzzzzzzzzzj_ = this.Observation_Services(context);
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? bzzzzzzzzzzzzzzzzl_(Encounter LastObs)
            {
                Period gzzzzzzzzzzzzzzzzk_ = LastObs?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzk_);
                CqlDateTime gzzzzzzzzzzzzzzzzm_ = context.Operators.End(gzzzzzzzzzzzzzzzzl_);
                Period gzzzzzzzzzzzzzzzzn_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzn_);
                CqlDateTime gzzzzzzzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzzzzzzzo_);
                CqlQuantity gzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzn_);
                CqlDateTime gzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzu_, true, true);
                bool? gzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzv_, default);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzn_);
                CqlDateTime gzzzzzzzzzzzzzzzzz_ = context.Operators.Start(gzzzzzzzzzzzzzzzzy_);
                bool? hzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzz_ is null));
                bool? hzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzza_);

                return hzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzl_);
            object bzzzzzzzzzzzzzzzzn_(Encounter @this)
            {
                Period hzzzzzzzzzzzzzzzzc_ = @this?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzc_);
                CqlDateTime hzzzzzzzzzzzzzzzze_ = context.Operators.End(hzzzzzzzzzzzzzzzzd_);

                return hzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Encounter>(bzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter bzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Encounter>(bzzzzzzzzzzzzzzzzo_);
            Period bzzzzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzzzzp_?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzq_);
            CqlDateTime bzzzzzzzzzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzzzzzzzzzr_);
            Period bzzzzzzzzzzzzzzzzt_ = Visit?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzt_);
            CqlDateTime bzzzzzzzzzzzzzzzzv_ = context.Operators.Start(bzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzt_);
            CqlDateTime bzzzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzi_ ?? bzzzzzzzzzzzzzzzzs_ ?? bzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzy_, true, true);

            return bzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)azzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzzzx_);

        return azzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzf_ = context.Operators.Start(Value);
        CqlDateTime hzzzzzzzzzzzzzzzzg_ = context.Operators.End(Value);
        int? hzzzzzzzzzzzzzzzzh_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzg_, "day");

        return hzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzi_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzk_ = this.Medicare_payer(context);
        IEnumerable<Coverage> hzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> hzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Coverage>(hzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? hzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? hzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> hzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzv_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string hzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzw_, "finished");
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzy_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? hzzzzzzzzzzzzzzzzz_ = this.LengthInDays(context, hzzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzza_ = context.Operators.Less(hzzzzzzzzzzzzzzzzz_, 365);
            bool? izzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzza_);
            Period izzzzzzzzzzzzzzzzc_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzc_);
            CqlDateTime izzzzzzzzzzzzzzzze_ = context.Operators.End(izzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzf_, "day");
            bool? izzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzg_);
            Patient izzzzzzzzzzzzzzzzi_ = this.Patient(context);
            Date izzzzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzzzi_?.BirthDateElement;
            string izzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzj_?.Value;
            CqlDate izzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzc_);
            CqlDateTime izzzzzzzzzzzzzzzzo_ = context.Operators.Start(izzzzzzzzzzzzzzzzn_);
            CqlDate izzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzo_);
            int? izzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzp_, "year");
            bool? izzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzq_, 65);
            bool? izzzzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> hzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(hzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzp_);
        Encounter hzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(hzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(hzzzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzt_ = this.Inpatient_Encounters(context);

        return izzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzu_ = this.Inpatient_Encounters(context);
        string izzzzzzzzzzzzzzzzv_(Encounter Encounter)
        {
            string izzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string izzzzzzzzzzzzzzzzz_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzy_ ?? "", ",");
            Id jzzzzzzzzzzzzzzzza_ = Encounter?.IdElement;
            string jzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzza_);
            string jzzzzzzzzzzzzzzzzc_ = context.Operators.Concatenate(izzzzzzzzzzzzzzzzz_ ?? "", jzzzzzzzzzzzzzzzzb_ ?? "");
            string jzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzzc_ ?? "", ",");
            bool? jzzzzzzzzzzzzzzzze_(Observation Exam)
            {
                DataType jzzzzzzzzzzzzzzzzy_ = Exam?.Effective;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzy_);
                CqlDateTime kzzzzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzzzzz_);
                bool? kzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzza_ is null));
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzy_);
                CqlDateTime kzzzzzzzzzzzzzzzze_ = context.Operators.Start(kzzzzzzzzzzzzzzzzd_);
                Period kzzzzzzzzzzzzzzzzf_ = Encounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzzzzzg_);
                CqlQuantity kzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzzzzl_);
                CqlQuantity kzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzo_ = context.Operators.Add(kzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzo_, true, true);
                bool? kzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzp_, default);
                bool? kzzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzq_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzs_ = Exam?.StatusElement;
                string kzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzzzs_);
                string[] kzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? kzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzv_);
                DataType kzzzzzzzzzzzzzzzzx_ = Exam?.Value;
                bool? kzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzx_ is null));
                bool? kzzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzy_);

                return kzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(ExamList, jzzzzzzzzzzzzzzzze_);
            object jzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzza_ = @this?.Effective;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzza_);
                CqlDateTime lzzzzzzzzzzzzzzzzc_ = context.Operators.Start(lzzzzzzzzzzzzzzzzb_);

                return lzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzh_);
            DataType jzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzi_?.Value;
            CqlQuantity jzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzzzzzzzzzzzzzzzzj_ as Quantity);
            string jzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertQuantityToString(jzzzzzzzzzzzzzzzzk_);
            string jzzzzzzzzzzzzzzzzm_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzzd_ ?? "", jzzzzzzzzzzzzzzzzl_ ?? "");
            string jzzzzzzzzzzzzzzzzn_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzzm_ ?? "", ",");
            bool? jzzzzzzzzzzzzzzzzo_(Observation Exam)
            {
                DataType lzzzzzzzzzzzzzzzzd_ = Exam?.Effective;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzzze_);
                bool? lzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzf_ is null));
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzzzzzzj_ = context.Operators.Start(lzzzzzzzzzzzzzzzzi_);
                Period lzzzzzzzzzzzzzzzzk_ = Encounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzk_);
                CqlDateTime lzzzzzzzzzzzzzzzzm_ = context.Operators.Start(lzzzzzzzzzzzzzzzzl_);
                CqlQuantity lzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzk_);
                CqlDateTime lzzzzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzzzzq_);
                CqlQuantity lzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzt_ = context.Operators.Add(lzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzt_, true, true);
                bool? lzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzu_, default);
                bool? lzzzzzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzx_ = Exam?.StatusElement;
                string lzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzzx_);
                string[] lzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? mzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzza_);
                DataType mzzzzzzzzzzzzzzzzc_ = Exam?.Value;
                bool? mzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzc_ is null));
                bool? mzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ExamList, jzzzzzzzzzzzzzzzzo_);
            object jzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType mzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzzzzzzzf_);
                CqlDateTime mzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzg_);

                return mzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzr_);
            DataType jzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzs_?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzt_);
            CqlDateTime jzzzzzzzzzzzzzzzzv_ = context.Operators.Start(jzzzzzzzzzzzzzzzzu_);
            string jzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateTimeToString(jzzzzzzzzzzzzzzzzv_);
            string jzzzzzzzzzzzzzzzzx_ = context.Operators.Concatenate(jzzzzzzzzzzzzzzzzn_ ?? "", jzzzzzzzzzzzzzzzzw_ ?? "");

            return jzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<string> izzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, string>(izzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzv_);
        IEnumerable<string> izzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<string>(izzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounters(context);
        string mzzzzzzzzzzzzzzzzj_(Encounter Encounter)
        {
            string mzzzzzzzzzzzzzzzzm_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string mzzzzzzzzzzzzzzzzn_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzm_ ?? "", ",");
            Id mzzzzzzzzzzzzzzzzo_ = Encounter?.IdElement;
            string mzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzzzo_);
            string mzzzzzzzzzzzzzzzzq_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzn_ ?? "", mzzzzzzzzzzzzzzzzp_ ?? "");
            string mzzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzq_ ?? "", ",");
            bool? mzzzzzzzzzzzzzzzzs_(Observation Exam)
            {
                DataType nzzzzzzzzzzzzzzzzm_ = Exam?.Effective;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzzzzzzzzzn_);
                bool? nzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzo_ is null));
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzzzzzzzzzr_);
                Period nzzzzzzzzzzzzzzzzt_ = Encounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzt_);
                CqlDateTime nzzzzzzzzzzzzzzzzv_ = context.Operators.Start(nzzzzzzzzzzzzzzzzu_);
                CqlQuantity nzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzt_);
                CqlDateTime ozzzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzzz_);
                CqlDateTime ozzzzzzzzzzzzzzzzc_ = context.Operators.Add(ozzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzd_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzc_, true, true);
                bool? ozzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzd_, default);
                bool? ozzzzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzze_);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzg_ = Exam?.StatusElement;
                string ozzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzzg_);
                string[] ozzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ozzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzj_);
                DataType ozzzzzzzzzzzzzzzzl_ = Exam?.Value;
                bool? ozzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzl_ is null));
                bool? ozzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzm_);

                return ozzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(ExamList, mzzzzzzzzzzzzzzzzs_);
            object mzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzo_ = @this?.Effective;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzzzo_);
                CqlDateTime ozzzzzzzzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzzzzzzzp_);

                return ozzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzv_);
            DataType mzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzw_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzx_ as Quantity);
            string mzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertQuantityToString(mzzzzzzzzzzzzzzzzy_);
            string nzzzzzzzzzzzzzzzza_ = context.Operators.Concatenate(mzzzzzzzzzzzzzzzzr_ ?? "", mzzzzzzzzzzzzzzzzz_ ?? "");
            string nzzzzzzzzzzzzzzzzb_ = context.Operators.Concatenate(nzzzzzzzzzzzzzzzza_ ?? "", ",");
            bool? nzzzzzzzzzzzzzzzzc_(Observation Exam)
            {
                DataType ozzzzzzzzzzzzzzzzr_ = Exam?.Effective;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzzzzzzzs_);
                bool? ozzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzt_ is null));
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzw_);
                Period ozzzzzzzzzzzzzzzzy_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzy_);
                CqlDateTime pzzzzzzzzzzzzzzzza_ = context.Operators.Start(ozzzzzzzzzzzzzzzzz_);
                CqlQuantity pzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzy_);
                CqlDateTime pzzzzzzzzzzzzzzzzf_ = context.Operators.Start(pzzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzzh_ = context.Operators.Add(pzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzh_, true, true);
                bool? pzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzi_, default);
                bool? pzzzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzj_);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzl_ = Exam?.StatusElement;
                string pzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzzzl_);
                string[] pzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? pzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzp_ = context.Operators.And(pzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzo_);
                DataType pzzzzzzzzzzzzzzzzq_ = Exam?.Value;
                bool? pzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzq_ is null));
                bool? pzzzzzzzzzzzzzzzzs_ = context.Operators.And(pzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzr_);

                return pzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ExamList, nzzzzzzzzzzzzzzzzc_);
            object nzzzzzzzzzzzzzzzze_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzzu_);

                return pzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzf_);
            DataType nzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzg_?.Effective;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzzh_);
            CqlDateTime nzzzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzzzi_);
            string nzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateTimeToString(nzzzzzzzzzzzzzzzzj_);
            string nzzzzzzzzzzzzzzzzl_ = context.Operators.Concatenate(nzzzzzzzzzzzzzzzzb_ ?? "", nzzzzzzzzzzzzzzzzk_ ?? "");

            return nzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<string> mzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, string>(mzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzj_);
        IEnumerable<string> mzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<string>(mzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        string pzzzzzzzzzzzzzzzzx_(Encounter Encounter)
        {
            string qzzzzzzzzzzzzzzzza_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string qzzzzzzzzzzzzzzzzb_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzza_ ?? "", ",");
            Id qzzzzzzzzzzzzzzzzc_ = Encounter?.IdElement;
            string qzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzzzzc_);
            string qzzzzzzzzzzzzzzzze_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzzb_ ?? "", qzzzzzzzzzzzzzzzzd_ ?? "");
            string qzzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzze_ ?? "", ",");
            bool? qzzzzzzzzzzzzzzzzg_(Observation Lab)
            {
                Instant qzzzzzzzzzzzzzzzzz_ = Lab?.IssuedElement;
                bool? rzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzz_ is null));
                CqlDateTime rzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzzzzzzzzzzzz_);
                Period rzzzzzzzzzzzzzzzzd_ = Encounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzd_);
                CqlDateTime rzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzze_);
                CqlQuantity rzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzd_);
                CqlDateTime rzzzzzzzzzzzzzzzzk_ = context.Operators.Start(rzzzzzzzzzzzzzzzzj_);
                CqlDateTime rzzzzzzzzzzzzzzzzm_ = context.Operators.Add(rzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzm_, true, true);
                bool? rzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzn_, default);
                bool? rzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzq_ = Lab?.StatusElement;
                string rzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzzq_);
                string[] rzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? rzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzu_ = context.Operators.And(rzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzt_);
                DataType rzzzzzzzzzzzzzzzzv_ = Lab?.Value;
                bool? rzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzv_ is null));
                bool? rzzzzzzzzzzzzzzzzx_ = context.Operators.And(rzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzw_);

                return rzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(LabList, qzzzzzzzzzzzzzzzzg_);
            object qzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;

                return rzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzj_);
            DataType qzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzk_?.Value;
            CqlQuantity qzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzzzzzzzzzzzzzzzl_ as Quantity);
            string qzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertQuantityToString(qzzzzzzzzzzzzzzzzm_);
            string qzzzzzzzzzzzzzzzzo_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzzf_ ?? "", qzzzzzzzzzzzzzzzzn_ ?? "");
            string qzzzzzzzzzzzzzzzzp_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzzo_ ?? "", ",");
            bool? qzzzzzzzzzzzzzzzzq_(Observation Lab)
            {
                Instant rzzzzzzzzzzzzzzzzz_ = Lab?.IssuedElement;
                bool? szzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzz_ is null));
                CqlDateTime szzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, rzzzzzzzzzzzzzzzzz_);
                Period szzzzzzzzzzzzzzzzd_ = Encounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzd_);
                CqlDateTime szzzzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzzzze_);
                CqlQuantity szzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzd_);
                CqlDateTime szzzzzzzzzzzzzzzzk_ = context.Operators.Start(szzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzm_ = context.Operators.Add(szzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzm_, true, true);
                bool? szzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzn_, default);
                bool? szzzzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzq_ = Lab?.StatusElement;
                string szzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzzq_);
                string[] szzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? szzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzt_);
                DataType szzzzzzzzzzzzzzzzv_ = Lab?.Value;
                bool? szzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzv_ is null));
                bool? szzzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzw_);

                return szzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(LabList, qzzzzzzzzzzzzzzzzq_);
            object qzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;

                return szzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzt_);
            Instant qzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzu_?.IssuedElement;
            CqlDateTime qzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzzzzzzzzzzzv_);
            string qzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateTimeToString(qzzzzzzzzzzzzzzzzw_);
            string qzzzzzzzzzzzzzzzzy_ = context.Operators.Concatenate(qzzzzzzzzzzzzzzzzp_ ?? "", qzzzzzzzzzzzzzzzzx_ ?? "");

            return qzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<string> pzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, string>(pzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzx_);
        IEnumerable<string> pzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<string>(pzzzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzz_ = this.Heart_rate(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzc_ = this.FirstPhysicalExamWithEncounterId(context, tzzzzzzzzzzzzzzzzb_, "FirstHeartRate");
        CqlCode tzzzzzzzzzzzzzzzzd_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzg_ = this.FirstPhysicalExamWithEncounterId(context, tzzzzzzzzzzzzzzzzf_, "FirstSystolicBP");
        CqlCode tzzzzzzzzzzzzzzzzh_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzk_ = this.FirstPhysicalExamWithEncounterId(context, tzzzzzzzzzzzzzzzzj_, "FirstRespRate");
        CqlValueSet tzzzzzzzzzzzzzzzzl_ = this.Body_temperature(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzn_ = this.FirstPhysicalExamWithEncounterId(context, tzzzzzzzzzzzzzzzzm_, "FirstTemperature");
        CqlCode tzzzzzzzzzzzzzzzzo_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzr_ = this.FirstPhysicalExamWithEncounterId(context, tzzzzzzzzzzzzzzzzq_, "FirstO2Saturation");
        CqlValueSet tzzzzzzzzzzzzzzzzs_ = this.Body_weight(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzu_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, tzzzzzzzzzzzzzzzzt_, "FirstWeight");
        CqlValueSet tzzzzzzzzzzzzzzzzv_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> tzzzzzzzzzzzzzzzzx_ = this.FirstLabTestWithEncounterId(context, tzzzzzzzzzzzzzzzzw_, "FirstHematocrit");
        CqlValueSet tzzzzzzzzzzzzzzzzy_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzza_ = this.FirstLabTestWithEncounterId(context, tzzzzzzzzzzzzzzzzz_, "FirstWhiteBloodCell");
        CqlValueSet uzzzzzzzzzzzzzzzzb_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzzd_ = this.FirstLabTestWithEncounterId(context, uzzzzzzzzzzzzzzzzc_, "FirstPotassium");
        CqlValueSet uzzzzzzzzzzzzzzzze_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzzg_ = this.FirstLabTestWithEncounterId(context, uzzzzzzzzzzzzzzzzf_, "FirstSodium");
        CqlValueSet uzzzzzzzzzzzzzzzzh_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzzj_ = this.FirstLabTestWithEncounterId(context, uzzzzzzzzzzzzzzzzi_, "FirstBicarbonate");
        CqlValueSet uzzzzzzzzzzzzzzzzk_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzzm_ = this.FirstLabTestWithEncounterId(context, uzzzzzzzzzzzzzzzzl_, "FirstCreatinine");
        CqlValueSet uzzzzzzzzzzzzzzzzn_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> uzzzzzzzzzzzzzzzzp_ = this.FirstLabTestWithEncounterId(context, uzzzzzzzzzzzzzzzzo_, "FirstGlucose");
        IEnumerable<string>[] uzzzzzzzzzzzzzzzzq_ = [
            tzzzzzzzzzzzzzzzzc_,
            tzzzzzzzzzzzzzzzzg_,
            tzzzzzzzzzzzzzzzzk_,
            tzzzzzzzzzzzzzzzzn_,
            tzzzzzzzzzzzzzzzzr_,
            tzzzzzzzzzzzzzzzzu_,
            tzzzzzzzzzzzzzzzzx_,
            uzzzzzzzzzzzzzzzza_,
            uzzzzzzzzzzzzzzzzd_,
            uzzzzzzzzzzzzzzzzg_,
            uzzzzzzzzzzzzzzzzj_,
            uzzzzzzzzzzzzzzzzm_,
            uzzzzzzzzzzzzzzzzp_,
        ];
        IEnumerable<string> uzzzzzzzzzzzzzzzzr_ = context.Operators.Flatten<string>(uzzzzzzzzzzzzzzzzq_ as IEnumerable<IEnumerable<string>>);

        return uzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate uzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate uzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? uzzzzzzzzzzzzzzzzu_ = context.Operators.DurationBetween(uzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzt_, "year");

        return uzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? uzzzzzzzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? uzzzzzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? uzzzzzzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? uzzzzzzzzzzzzzzzzy_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime uzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(uzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzx_, 0, 0, 0, 0, uzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime vzzzzzzzzzzzzzzzza_ = context.Operators.Start(Stay);
        CqlDateTime vzzzzzzzzzzzzzzzzb_ = context.Operators.End(Stay);
        int? vzzzzzzzzzzzzzzzzc_ = context.Operators.DifferenceBetween(vzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzb_, "day");

        return vzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzd_ = this.HospitalizationWithObservation(context, Encounter);
        int? vzzzzzzzzzzzzzzzze_ = this.LengthInDays(context, vzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
