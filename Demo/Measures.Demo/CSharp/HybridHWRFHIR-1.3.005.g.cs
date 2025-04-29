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
        CqlDateTime mzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzr_ = context.Operators.Interval(mzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzq_, true, false);
        object mzzzzzzzzzzzzzzzs_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", mzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> mzzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] mzzzzzzzzzzzzzzzz_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzza_(Encounter Visit)
        {
            CqlValueSet nzzzzzzzzzzzzzzze_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? nzzzzzzzzzzzzzzzg_(Encounter LastED)
            {
                Period ozzzzzzzzzzzzzzzf_ = LastED?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzf_);
                CqlDateTime ozzzzzzzzzzzzzzzh_ = context.Operators.End(ozzzzzzzzzzzzzzzg_);
                CqlValueSet ozzzzzzzzzzzzzzzi_ = this.Observation_Services(context);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ozzzzzzzzzzzzzzzk_(Encounter LastObs)
                {
                    Period qzzzzzzzzzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzb_);
                    CqlDateTime qzzzzzzzzzzzzzzzd_ = context.Operators.End(qzzzzzzzzzzzzzzzc_);
                    Period qzzzzzzzzzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzf_);
                    CqlQuantity qzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzm_ = context.Operators.Interval(qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzl_, true, true);
                    bool? qzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzp_);
                    bool? qzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzq_ is null));
                    bool? qzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzr_);

                    return qzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzk_);
                object ozzzzzzzzzzzzzzzm_(Encounter @this)
                {
                    Period qzzzzzzzzzzzzzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzt_);
                    CqlDateTime qzzzzzzzzzzzzzzzv_ = context.Operators.End(qzzzzzzzzzzzzzzzu_);

                    return qzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Encounter>(ozzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ozzzzzzzzzzzzzzzo_ = context.Operators.Last<Encounter>(ozzzzzzzzzzzzzzzn_);
                Period ozzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzo_?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzp_);
                CqlDateTime ozzzzzzzzzzzzzzzr_ = context.Operators.Start(ozzzzzzzzzzzzzzzq_);
                Period ozzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzt_);
                CqlQuantity ozzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ozzzzzzzzzzzzzzzw_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzr_ ?? ozzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzv_);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ozzzzzzzzzzzzzzzz_(Encounter LastObs)
                {
                    Period qzzzzzzzzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzw_);
                    CqlDateTime qzzzzzzzzzzzzzzzy_ = context.Operators.End(qzzzzzzzzzzzzzzzx_);
                    Period qzzzzzzzzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzza_);
                    CqlQuantity rzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzh_ = context.Operators.Interval(rzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzg_, true, true);
                    bool? rzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzzzzk_);
                    bool? rzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzl_ is null));
                    bool? rzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzm_);

                    return rzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzz_);
                object pzzzzzzzzzzzzzzzb_(Encounter @this)
                {
                    Period rzzzzzzzzzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzo_);
                    CqlDateTime rzzzzzzzzzzzzzzzq_ = context.Operators.End(rzzzzzzzzzzzzzzzp_);

                    return rzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Encounter>(pzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzd_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzc_);
                Period pzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzd_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ozzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzg_ ?? pzzzzzzzzzzzzzzzj_, true, true);
                bool? pzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzk_, default);
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? pzzzzzzzzzzzzzzzo_(Encounter LastObs)
                {
                    Period rzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzr_);
                    CqlDateTime rzzzzzzzzzzzzzzzt_ = context.Operators.End(rzzzzzzzzzzzzzzzs_);
                    Period rzzzzzzzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzu_);
                    CqlDateTime rzzzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzzzv_);
                    CqlQuantity rzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzu_);
                    CqlDateTime szzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzc_ = context.Operators.Interval(rzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzb_, true, true);
                    bool? szzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzu_);
                    CqlDateTime szzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzf_);
                    bool? szzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzg_ is null));
                    bool? szzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzh_);

                    return szzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzo_);
                object pzzzzzzzzzzzzzzzq_(Encounter @this)
                {
                    Period szzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzj_);
                    CqlDateTime szzzzzzzzzzzzzzzl_ = context.Operators.End(szzzzzzzzzzzzzzzk_);

                    return szzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Encounter>(pzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzs_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzr_);
                Period pzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzx_);
                bool? pzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)((pzzzzzzzzzzzzzzzv_ ?? pzzzzzzzzzzzzzzzy_) is null));
                bool? qzzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzz_);

                return qzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzg_);
            object nzzzzzzzzzzzzzzzi_(Encounter @this)
            {
                Period szzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzm_);
                CqlDateTime szzzzzzzzzzzzzzzo_ = context.Operators.End(szzzzzzzzzzzzzzzn_);

                return szzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzk_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzj_);
            Period nzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzk_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzl_);
            CqlDateTime nzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzm_);
            CqlValueSet nzzzzzzzzzzzzzzzo_ = this.Observation_Services(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? nzzzzzzzzzzzzzzzq_(Encounter LastObs)
            {
                Period szzzzzzzzzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzp_);
                CqlDateTime szzzzzzzzzzzzzzzr_ = context.Operators.End(szzzzzzzzzzzzzzzq_);
                Period szzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzs_);
                CqlDateTime szzzzzzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzzzzzt_);
                CqlQuantity szzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime szzzzzzzzzzzzzzzw_ = context.Operators.Subtract(szzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzs_);
                CqlDateTime szzzzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzza_ = context.Operators.Interval(szzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzz_, true, true);
                bool? tzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzs_);
                CqlDateTime tzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzze_ is null));
                bool? tzzzzzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzq_);
            object nzzzzzzzzzzzzzzzs_(Encounter @this)
            {
                Period tzzzzzzzzzzzzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzzzzh_);
                CqlDateTime tzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzzi_);

                return tzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzt_);
            Period nzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzu_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzv_);
            CqlDateTime nzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzw_);
            Period nzzzzzzzzzzzzzzzy_ = Visit?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzzd_ = context.Operators.End(ozzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzze_ = context.Operators.Interval(nzzzzzzzzzzzzzzzn_ ?? nzzzzzzzzzzzzzzzx_ ?? ozzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzd_, true, true);

            return ozzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)mzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime tzzzzzzzzzzzzzzzk_ = context.Operators.Start(Value);
        CqlDateTime tzzzzzzzzzzzzzzzl_ = context.Operators.End(Value);
        int? tzzzzzzzzzzzzzzzm_ = context.Operators.DifferenceBetween(tzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzl_, "day");

        return tzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzn_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzp_ = this.Medicare_payer(context);
        IEnumerable<Coverage> tzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> tzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, Coverage>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> tzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(tzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzza_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string uzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzzzzzc_ = context.Operators.Equal(uzzzzzzzzzzzzzzzb_, "finished");
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzd_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? uzzzzzzzzzzzzzzze_ = this.LengthInDays(context, uzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzf_ = context.Operators.Less(uzzzzzzzzzzzzzzze_, 365);
            bool? uzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzf_);
            Period uzzzzzzzzzzzzzzzh_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzj_ = context.Operators.End(uzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzk_, "day");
            bool? uzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzl_);
            Patient uzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date uzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string uzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzo_?.Value;
            CqlDate uzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzt_ = context.Operators.Start(uzzzzzzzzzzzzzzzs_);
            CqlDate uzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzt_);
            int? uzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzu_, "year");
            bool? uzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzv_, 65);
            bool? uzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> tzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(tzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzu_);
        Encounter tzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(tzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);

        return uzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        string vzzzzzzzzzzzzzzza_(Encounter Encounter)
        {
            string vzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string vzzzzzzzzzzzzzzze_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzd_ ?? "", ",");
            Id vzzzzzzzzzzzzzzzf_ = Encounter?.IdElement;
            string vzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzzzf_);
            string vzzzzzzzzzzzzzzzh_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzze_ ?? "", vzzzzzzzzzzzzzzzg_ ?? "");
            string vzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzh_ ?? "", ",");
            bool? vzzzzzzzzzzzzzzzj_(Observation Exam)
            {
                DataType wzzzzzzzzzzzzzzzd_ = Exam?.Effective;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzze_);
                bool? wzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzf_ is null));
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzzzi_);
                Period wzzzzzzzzzzzzzzzk_ = Encounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzzzzzl_);
                CqlQuantity wzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzq_);
                CqlQuantity wzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzt_ = context.Operators.Add(wzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzu_ = context.Operators.Interval(wzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzt_, true, true);
                bool? wzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzu_, default);
                bool? wzzzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzx_ = Exam?.StatusElement;
                string wzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzx_);
                string[] wzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? xzzzzzzzzzzzzzzza_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzza_);
                DataType xzzzzzzzzzzzzzzzc_ = Exam?.Value;
                bool? xzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzc_ is null));
                bool? xzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzd_);

                return xzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(ExamList, vzzzzzzzzzzzzzzzj_);
            object vzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzf_ = @this?.Effective;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzf_);
                CqlDateTime xzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzg_);

                return xzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzm_);
            DataType vzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzn_?.Value;
            CqlQuantity vzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzo_ as Quantity);
            string vzzzzzzzzzzzzzzzq_ = context.Operators.ConvertQuantityToString(vzzzzzzzzzzzzzzzp_);
            string vzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzi_ ?? "", vzzzzzzzzzzzzzzzq_ ?? "");
            string vzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzr_ ?? "", ",");
            bool? vzzzzzzzzzzzzzzzt_(Observation Exam)
            {
                DataType xzzzzzzzzzzzzzzzi_ = Exam?.Effective;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzk_ = context.Operators.Start(xzzzzzzzzzzzzzzzj_);
                bool? xzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzk_ is null));
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzn_);
                Period xzzzzzzzzzzzzzzzp_ = Encounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzq_);
                CqlQuantity xzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzv_);
                CqlQuantity xzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzy_ = context.Operators.Add(xzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzz_ = context.Operators.Interval(xzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzy_, true, true);
                bool? yzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzz_, default);
                bool? yzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzza_);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzc_ = Exam?.StatusElement;
                string yzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzzzc_);
                string[] yzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? yzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzf_);
                DataType yzzzzzzzzzzzzzzzh_ = Exam?.Value;
                bool? yzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzh_ is null));
                bool? yzzzzzzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzi_);

                return yzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(ExamList, vzzzzzzzzzzzzzzzt_);
            object vzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzk_ = @this?.Effective;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzk_);
                CqlDateTime yzzzzzzzzzzzzzzzm_ = context.Operators.Start(yzzzzzzzzzzzzzzzl_);

                return yzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzw_);
            DataType vzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzx_?.Effective;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzzy_);
            CqlDateTime wzzzzzzzzzzzzzzza_ = context.Operators.Start(vzzzzzzzzzzzzzzzz_);
            string wzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateTimeToString(wzzzzzzzzzzzzzzza_);
            string wzzzzzzzzzzzzzzzc_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzs_ ?? "", wzzzzzzzzzzzzzzzb_ ?? "");

            return wzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<string> vzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, string>(uzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzza_);
        IEnumerable<string> vzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<string>(vzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzn_ = this.Inpatient_Encounters(context);
        string yzzzzzzzzzzzzzzzo_(Encounter Encounter)
        {
            string yzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string yzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzr_ ?? "", ",");
            Id yzzzzzzzzzzzzzzzt_ = Encounter?.IdElement;
            string yzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzzzt_);
            string yzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzs_ ?? "", yzzzzzzzzzzzzzzzu_ ?? "");
            string yzzzzzzzzzzzzzzzw_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzv_ ?? "", ",");
            bool? yzzzzzzzzzzzzzzzx_(Observation Exam)
            {
                DataType zzzzzzzzzzzzzzzzr_ = Exam?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzs_);
                bool? zzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzt_ is null));
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzzzw_);
                Period zzzzzzzzzzzzzzzzy_ = Encounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzzzzzzzz_);
                CqlQuantity azzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(azzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzzzzzh_ = context.Operators.Add(azzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzi_ = context.Operators.Interval(azzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzh_, true, true);
                bool? azzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzi_, default);
                bool? azzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzj_);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzl_ = Exam?.StatusElement;
                string azzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzl_);
                string[] azzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? azzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzo_);
                DataType azzzzzzzzzzzzzzzzq_ = Exam?.Value;
                bool? azzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzq_ is null));
                bool? azzzzzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzr_);

                return azzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ExamList, yzzzzzzzzzzzzzzzx_);
            object yzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzt_ = @this?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzt_);
                CqlDateTime azzzzzzzzzzzzzzzzv_ = context.Operators.Start(azzzzzzzzzzzzzzzzu_);

                return azzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzza_);
            DataType zzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzb_?.Value;
            CqlQuantity zzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzc_ as Quantity);
            string zzzzzzzzzzzzzzzze_ = context.Operators.ConvertQuantityToString(zzzzzzzzzzzzzzzzd_);
            string zzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzw_ ?? "", zzzzzzzzzzzzzzzze_ ?? "");
            string zzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(zzzzzzzzzzzzzzzzf_ ?? "", ",");
            bool? zzzzzzzzzzzzzzzzh_(Observation Exam)
            {
                DataType azzzzzzzzzzzzzzzzw_ = Exam?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzy_ is null));
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzw_);
                CqlDateTime bzzzzzzzzzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzzzzzzzzzb_);
                Period bzzzzzzzzzzzzzzzzd_ = Encounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzf_ = context.Operators.Start(bzzzzzzzzzzzzzzzze_);
                CqlQuantity bzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzzzzzzzj_);
                CqlDateTime bzzzzzzzzzzzzzzzzm_ = context.Operators.Add(bzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzm_, true, true);
                bool? bzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzn_, default);
                bool? bzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzq_ = Exam?.StatusElement;
                string bzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzzq_);
                string[] bzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzt_);
                DataType bzzzzzzzzzzzzzzzzv_ = Exam?.Value;
                bool? bzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzv_ is null));
                bool? bzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(ExamList, zzzzzzzzzzzzzzzzh_);
            object zzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzk_);
            DataType zzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzl_?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzm_);
            CqlDateTime zzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzn_);
            string zzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateTimeToString(zzzzzzzzzzzzzzzzo_);
            string zzzzzzzzzzzzzzzzq_ = context.Operators.Concatenate(zzzzzzzzzzzzzzzzg_ ?? "", zzzzzzzzzzzzzzzzp_ ?? "");

            return zzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<string> yzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, string>(yzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzo_);
        IEnumerable<string> yzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<string>(yzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounters(context);
        string czzzzzzzzzzzzzzzzc_(Encounter Encounter)
        {
            string czzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string czzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzf_ ?? "", ",");
            Id czzzzzzzzzzzzzzzzh_ = Encounter?.IdElement;
            string czzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzh_);
            string czzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzg_ ?? "", czzzzzzzzzzzzzzzzi_ ?? "");
            string czzzzzzzzzzzzzzzzk_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzj_ ?? "", ",");
            bool? czzzzzzzzzzzzzzzzl_(Observation Lab)
            {
                Instant dzzzzzzzzzzzzzzzze_ = Lab?.IssuedElement;
                bool? dzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzze_ is null));
                CqlDateTime dzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzze_);
                Period dzzzzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzj_);
                CqlQuantity dzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzr_ = context.Operators.Add(dzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzr_, true, true);
                bool? dzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzs_, default);
                bool? dzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzv_ = Lab?.StatusElement;
                string dzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzv_);
                string[] dzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? dzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzy_);
                DataType ezzzzzzzzzzzzzzzza_ = Lab?.Value;
                bool? ezzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzza_ is null));
                bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzb_);

                return ezzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(LabList, czzzzzzzzzzzzzzzzl_);
            object czzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;

                return ezzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzo_);
            DataType czzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzp_?.Value;
            CqlQuantity czzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzq_ as Quantity);
            string czzzzzzzzzzzzzzzzs_ = context.Operators.ConvertQuantityToString(czzzzzzzzzzzzzzzzr_);
            string czzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzk_ ?? "", czzzzzzzzzzzzzzzzs_ ?? "");
            string czzzzzzzzzzzzzzzzu_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzt_ ?? "", ",");
            bool? czzzzzzzzzzzzzzzzv_(Observation Lab)
            {
                Instant ezzzzzzzzzzzzzzzze_ = Lab?.IssuedElement;
                bool? ezzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzze_ is null));
                CqlDateTime ezzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzzzzzze_);
                Period ezzzzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzi_);
                CqlDateTime ezzzzzzzzzzzzzzzzk_ = context.Operators.Start(ezzzzzzzzzzzzzzzzj_);
                CqlQuantity ezzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzi_);
                CqlDateTime ezzzzzzzzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzzzzzzzo_);
                CqlDateTime ezzzzzzzzzzzzzzzzr_ = context.Operators.Add(ezzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzs_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzr_, true, true);
                bool? ezzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzs_, default);
                bool? ezzzzzzzzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzv_ = Lab?.StatusElement;
                string ezzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzv_);
                string[] ezzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzy_);
                DataType fzzzzzzzzzzzzzzzza_ = Lab?.Value;
                bool? fzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzza_ is null));
                bool? fzzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzb_);

                return fzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(LabList, czzzzzzzzzzzzzzzzv_);
            object czzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;

                return fzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzy_);
            Instant dzzzzzzzzzzzzzzzza_ = czzzzzzzzzzzzzzzzz_?.IssuedElement;
            CqlDateTime dzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzza_);
            string dzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateTimeToString(dzzzzzzzzzzzzzzzzb_);
            string dzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzu_ ?? "", dzzzzzzzzzzzzzzzzc_ ?? "");

            return dzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<string> czzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, string>(czzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzc_);
        IEnumerable<string> czzzzzzzzzzzzzzzze_ = context.Operators.Distinct<string>(czzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzze_ = this.Heart_rate(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzh_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzg_, "FirstHeartRate");
        CqlCode fzzzzzzzzzzzzzzzzi_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzl_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzk_, "FirstSystolicBP");
        CqlCode fzzzzzzzzzzzzzzzzm_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzp_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzo_, "FirstRespRate");
        CqlValueSet fzzzzzzzzzzzzzzzzq_ = this.Body_temperature(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzs_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzr_, "FirstTemperature");
        CqlCode fzzzzzzzzzzzzzzzzt_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzw_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzv_, "FirstO2Saturation");
        CqlValueSet fzzzzzzzzzzzzzzzzx_ = this.Body_weight(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzz_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, fzzzzzzzzzzzzzzzzy_, "FirstWeight");
        CqlValueSet gzzzzzzzzzzzzzzzza_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzc_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzb_, "FirstHematocrit");
        CqlValueSet gzzzzzzzzzzzzzzzzd_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzf_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzze_, "FirstWhiteBloodCell");
        CqlValueSet gzzzzzzzzzzzzzzzzg_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzi_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzh_, "FirstPotassium");
        CqlValueSet gzzzzzzzzzzzzzzzzj_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzl_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzk_, "FirstSodium");
        CqlValueSet gzzzzzzzzzzzzzzzzm_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzo_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzn_, "FirstBicarbonate");
        CqlValueSet gzzzzzzzzzzzzzzzzp_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzr_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzq_, "FirstCreatinine");
        CqlValueSet gzzzzzzzzzzzzzzzzs_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzu_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzt_, "FirstGlucose");
        IEnumerable<string>[] gzzzzzzzzzzzzzzzzv_ = [
            fzzzzzzzzzzzzzzzzh_,
            fzzzzzzzzzzzzzzzzl_,
            fzzzzzzzzzzzzzzzzp_,
            fzzzzzzzzzzzzzzzzs_,
            fzzzzzzzzzzzzzzzzw_,
            fzzzzzzzzzzzzzzzzz_,
            gzzzzzzzzzzzzzzzzc_,
            gzzzzzzzzzzzzzzzzf_,
            gzzzzzzzzzzzzzzzzi_,
            gzzzzzzzzzzzzzzzzl_,
            gzzzzzzzzzzzzzzzzo_,
            gzzzzzzzzzzzzzzzzr_,
            gzzzzzzzzzzzzzzzzu_,
        ];
        IEnumerable<string> gzzzzzzzzzzzzzzzzw_ = context.Operators.Flatten<string>(gzzzzzzzzzzzzzzzzv_ as IEnumerable<IEnumerable<string>>);

        return gzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate gzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate gzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? gzzzzzzzzzzzzzzzzz_ = context.Operators.DurationBetween(gzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzy_, "year");

        return gzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? hzzzzzzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? hzzzzzzzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? hzzzzzzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? hzzzzzzzzzzzzzzzzd_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime hzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(hzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzc_, 0, 0, 0, 0, hzzzzzzzzzzzzzzzzd_);

        return hzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzf_ = context.Operators.Start(Stay);
        CqlDateTime hzzzzzzzzzzzzzzzzg_ = context.Operators.End(Stay);
        int? hzzzzzzzzzzzzzzzzh_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzg_, "day");

        return hzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzi_ = this.HospitalizationWithObservation(context, Encounter);
        int? hzzzzzzzzzzzzzzzzj_ = this.LengthInDays(context, hzzzzzzzzzzzzzzzzi_);

        return hzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
