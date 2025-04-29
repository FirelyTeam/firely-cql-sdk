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

    #region ValueSet: Body weight
    [CqlValueSetDefinition(
        definitionName: "Body weight",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159",
        valueSetVersion: null)]
    public CqlValueSet Body_weight(CqlContext context) => _Body_weight;

    private static readonly CqlValueSet _Body_weight = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", null);
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

    #region ValueSet: Glucose lab test
    [CqlValueSetDefinition(
        definitionName: "Glucose lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134",
        valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext context) => _Glucose_lab_test;

    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);
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

    #region ValueSet: Potassium lab test
    [CqlValueSetDefinition(
        definitionName: "Potassium lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117",
        valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext context) => _Potassium_lab_test;

    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);
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

    #region Code: Respiratory rate
    [CqlCodeDefinition(
        definitionName: "Respiratory rate",
        codeId: "9279-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext context) => _Respiratory_rate;

    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org", default, default);
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
        CqlCode[] mzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
            new CqlCode("8867-4", "http://loinc.org", default, default),
            new CqlCode("59408-5", "http://loinc.org", default, default),
            new CqlCode("9279-1", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return mzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzq_, true, false);
        object mzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", mzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> mzzzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] mzzzzzzzzzzzzzzzzz_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzza_(Encounter Visit)
        {
            CqlValueSet nzzzzzzzzzzzzzzzze_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? nzzzzzzzzzzzzzzzzg_(Encounter LastED)
            {
                Period ozzzzzzzzzzzzzzzzf_ = LastED?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzf_);
                CqlDateTime ozzzzzzzzzzzzzzzzh_ = context.Operators.End(ozzzzzzzzzzzzzzzzg_);
                CqlValueSet ozzzzzzzzzzzzzzzzi_ = this.Observation_Services(context);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ozzzzzzzzzzzzzzzzk_(Encounter LastObs)
                {
                    Period qzzzzzzzzzzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzb_);
                    CqlDateTime qzzzzzzzzzzzzzzzzd_ = context.Operators.End(qzzzzzzzzzzzzzzzzc_);
                    Period qzzzzzzzzzzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzzf_);
                    CqlQuantity qzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzl_, true, true);
                    bool? qzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzze_);
                    CqlDateTime qzzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzzp_);
                    bool? qzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzq_ is null));
                    bool? qzzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzr_);

                    return qzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzk_);
                object ozzzzzzzzzzzzzzzzm_(Encounter @this)
                {
                    Period qzzzzzzzzzzzzzzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzt_);
                    CqlDateTime qzzzzzzzzzzzzzzzzv_ = context.Operators.End(qzzzzzzzzzzzzzzzzu_);

                    return qzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Encounter>(ozzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ozzzzzzzzzzzzzzzzo_ = context.Operators.Last<Encounter>(ozzzzzzzzzzzzzzzzn_);
                Period ozzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzo_?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzp_);
                CqlDateTime ozzzzzzzzzzzzzzzzr_ = context.Operators.Start(ozzzzzzzzzzzzzzzzq_);
                Period ozzzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzzt_);
                CqlQuantity ozzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ozzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzr_ ?? ozzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzv_);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ozzzzzzzzzzzzzzzzz_(Encounter LastObs)
                {
                    Period qzzzzzzzzzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzw_);
                    CqlDateTime qzzzzzzzzzzzzzzzzy_ = context.Operators.End(qzzzzzzzzzzzzzzzzx_);
                    Period qzzzzzzzzzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzzza_);
                    CqlQuantity rzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzg_, true, true);
                    bool? rzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzz_);
                    CqlDateTime rzzzzzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzzzzzk_);
                    bool? rzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzl_ is null));
                    bool? rzzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzm_);

                    return rzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzz_);
                object pzzzzzzzzzzzzzzzzb_(Encounter @this)
                {
                    Period rzzzzzzzzzzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzo_);
                    CqlDateTime rzzzzzzzzzzzzzzzzq_ = context.Operators.End(rzzzzzzzzzzzzzzzzp_);

                    return rzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Encounter>(pzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzzc_);
                Period pzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzd_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzg_ ?? pzzzzzzzzzzzzzzzzj_, true, true);
                bool? pzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzk_, default);
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? pzzzzzzzzzzzzzzzzo_(Encounter LastObs)
                {
                    Period rzzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzr_);
                    CqlDateTime rzzzzzzzzzzzzzzzzt_ = context.Operators.End(rzzzzzzzzzzzzzzzzs_);
                    Period rzzzzzzzzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzu_);
                    CqlDateTime rzzzzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzzzzv_);
                    CqlQuantity rzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzu_);
                    CqlDateTime szzzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzc_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzb_, true, true);
                    bool? szzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzu_);
                    CqlDateTime szzzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzzf_);
                    bool? szzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzg_ is null));
                    bool? szzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzh_);

                    return szzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzo_);
                object pzzzzzzzzzzzzzzzzq_(Encounter @this)
                {
                    Period szzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzj_);
                    CqlDateTime szzzzzzzzzzzzzzzzl_ = context.Operators.End(szzzzzzzzzzzzzzzzk_);

                    return szzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Encounter>(pzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzzr_);
                Period pzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzzx_);
                bool? pzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)((pzzzzzzzzzzzzzzzzv_ ?? pzzzzzzzzzzzzzzzzy_) is null));
                bool? qzzzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzz_);

                return qzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzg_);
            object nzzzzzzzzzzzzzzzzi_(Encounter @this)
            {
                Period szzzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzm_);
                CqlDateTime szzzzzzzzzzzzzzzzo_ = context.Operators.End(szzzzzzzzzzzzzzzzn_);

                return szzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzzj_);
            Period nzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzk_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzl_);
            CqlDateTime nzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzm_);
            CqlValueSet nzzzzzzzzzzzzzzzzo_ = this.Observation_Services(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? nzzzzzzzzzzzzzzzzq_(Encounter LastObs)
            {
                Period szzzzzzzzzzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzp_);
                CqlDateTime szzzzzzzzzzzzzzzzr_ = context.Operators.End(szzzzzzzzzzzzzzzzq_);
                Period szzzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzs_);
                CqlDateTime szzzzzzzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzzzzzzt_);
                CqlQuantity szzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime szzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzs_);
                CqlDateTime szzzzzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzza_ = context.Operators.Interval(szzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzz_, true, true);
                bool? tzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzzzzzs_);
                CqlDateTime tzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzze_ is null));
                bool? tzzzzzzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzq_);
            object nzzzzzzzzzzzzzzzzs_(Encounter @this)
            {
                Period tzzzzzzzzzzzzzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzh_);
                CqlDateTime tzzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzzzi_);

                return tzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzzt_);
            Period nzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzu_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzv_);
            CqlDateTime nzzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzzw_);
            Period nzzzzzzzzzzzzzzzzy_ = Visit?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzzzd_ = context.Operators.End(ozzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzze_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzn_ ?? nzzzzzzzzzzzzzzzzx_ ?? ozzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzd_, true, true);

            return ozzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)mzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzzzzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime tzzzzzzzzzzzzzzzzk_ = context.Operators.Start(Value);
        CqlDateTime tzzzzzzzzzzzzzzzzl_ = context.Operators.End(Value);
        int? tzzzzzzzzzzzzzzzzm_ = context.Operators.DifferenceBetween(tzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzl_, "day");

        return tzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzn_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzp_ = this.Medicare_payer(context);
        IEnumerable<Coverage> tzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> tzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, Coverage>(tzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tzzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> tzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(tzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzza_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string uzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzb_, "finished");
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzd_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? uzzzzzzzzzzzzzzzze_ = this.LengthInDays(context, uzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzf_ = context.Operators.Less(uzzzzzzzzzzzzzzzze_, 365);
            bool? uzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzf_);
            Period uzzzzzzzzzzzzzzzzh_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzzj_ = context.Operators.End(uzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzk_, "day");
            bool? uzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzl_);
            Patient uzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date uzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string uzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate uzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzzt_ = context.Operators.Start(uzzzzzzzzzzzzzzzzs_);
            CqlDate uzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzt_);
            int? uzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzu_, "year");
            bool? uzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzv_, 65);
            bool? uzzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> tzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(tzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzu_);
        Encounter tzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(tzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);

        return uzzzzzzzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        string vzzzzzzzzzzzzzzzza_(Encounter Encounter)
        {
            string vzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string vzzzzzzzzzzzzzzzze_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzzd_ ?? "", ",");
            Id vzzzzzzzzzzzzzzzzf_ = Encounter?.IdElement;
            string vzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzzzzf_);
            string vzzzzzzzzzzzzzzzzh_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzze_ ?? "", vzzzzzzzzzzzzzzzzg_ ?? "");
            string vzzzzzzzzzzzzzzzzi_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzzh_ ?? "", ",");
            bool? vzzzzzzzzzzzzzzzzj_(Observation Exam)
            {
                DataType wzzzzzzzzzzzzzzzzd_ = Exam?.Effective;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzze_);
                bool? wzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzf_ is null));
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzzzzi_);
                Period wzzzzzzzzzzzzzzzzk_ = Encounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzzzzzzl_);
                CqlQuantity wzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzq_);
                CqlQuantity wzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzt_ = context.Operators.Add(wzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzt_, true, true);
                bool? wzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzu_, default);
                bool? wzzzzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzx_ = Exam?.StatusElement;
                string wzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzzx_);
                string[] wzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? xzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzza_);
                DataType xzzzzzzzzzzzzzzzzc_ = Exam?.Value;
                bool? xzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzc_ is null));
                bool? xzzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzd_);

                return xzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(ExamList, vzzzzzzzzzzzzzzzzj_);
            object vzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzzf_);
                CqlDateTime xzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzg_);

                return xzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzm_);
            DataType vzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzn_?.Value;
            CqlQuantity vzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzo_ as Quantity);
            string vzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertQuantityToString(vzzzzzzzzzzzzzzzzp_);
            string vzzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzzi_ ?? "", vzzzzzzzzzzzzzzzzq_ ?? "");
            string vzzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzzr_ ?? "", ",");
            bool? vzzzzzzzzzzzzzzzzt_(Observation Exam)
            {
                DataType xzzzzzzzzzzzzzzzzi_ = Exam?.Effective;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzzk_ = context.Operators.Start(xzzzzzzzzzzzzzzzzj_);
                bool? xzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzk_ is null));
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzzn_);
                Period xzzzzzzzzzzzzzzzzp_ = Encounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzq_);
                CqlQuantity xzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzv_);
                CqlQuantity xzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzy_ = context.Operators.Add(xzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzy_, true, true);
                bool? yzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzz_, default);
                bool? yzzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzza_);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzc_ = Exam?.StatusElement;
                string yzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzzzzc_);
                string[] yzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? yzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzf_);
                DataType yzzzzzzzzzzzzzzzzh_ = Exam?.Value;
                bool? yzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzh_ is null));
                bool? yzzzzzzzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzi_);

                return yzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(ExamList, vzzzzzzzzzzzzzzzzt_);
            object vzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzzzzzk_);
                CqlDateTime yzzzzzzzzzzzzzzzzm_ = context.Operators.Start(yzzzzzzzzzzzzzzzzl_);

                return yzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzw_);
            DataType vzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzx_?.Effective;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzzzy_);
            CqlDateTime wzzzzzzzzzzzzzzzza_ = context.Operators.Start(vzzzzzzzzzzzzzzzzz_);
            string wzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateTimeToString(wzzzzzzzzzzzzzzzza_);
            string wzzzzzzzzzzzzzzzzc_ = context.Operators.Concatenate(vzzzzzzzzzzzzzzzzs_ ?? "", wzzzzzzzzzzzzzzzzb_ ?? "");

            return wzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<string> vzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, string>(uzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzza_);
        IEnumerable<string> vzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<string>(vzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzn_ = this.Inpatient_Encounters(context);
        string yzzzzzzzzzzzzzzzzo_(Encounter Encounter)
        {
            string yzzzzzzzzzzzzzzzzr_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string yzzzzzzzzzzzzzzzzs_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzzr_ ?? "", ",");
            Id yzzzzzzzzzzzzzzzzt_ = Encounter?.IdElement;
            string yzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzzzzt_);
            string yzzzzzzzzzzzzzzzzv_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzzs_ ?? "", yzzzzzzzzzzzzzzzzu_ ?? "");
            string yzzzzzzzzzzzzzzzzw_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzzv_ ?? "", ",");
            bool? yzzzzzzzzzzzzzzzzx_(Observation Exam)
            {
                DataType zzzzzzzzzzzzzzzzzr_ = Exam?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzzs_);
                bool? zzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzt_ is null));
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzzzzw_);
                Period zzzzzzzzzzzzzzzzzy_ = Encounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzzzzzzzzz_);
                CqlQuantity azzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzzzzzzh_ = context.Operators.Add(azzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzh_, true, true);
                bool? azzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzi_, default);
                bool? azzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzj_);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzl_ = Exam?.StatusElement;
                string azzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzzl_);
                string[] azzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? azzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzo_);
                DataType azzzzzzzzzzzzzzzzzq_ = Exam?.Value;
                bool? azzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzq_ is null));
                bool? azzzzzzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzr_);

                return azzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ExamList, yzzzzzzzzzzzzzzzzx_);
            object yzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzt_);
                CqlDateTime azzzzzzzzzzzzzzzzzv_ = context.Operators.Start(azzzzzzzzzzzzzzzzzu_);

                return azzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzza_);
            DataType zzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzb_?.Value;
            CqlQuantity zzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzzc_ as Quantity);
            string zzzzzzzzzzzzzzzzze_ = context.Operators.ConvertQuantityToString(zzzzzzzzzzzzzzzzzd_);
            string zzzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate(yzzzzzzzzzzzzzzzzw_ ?? "", zzzzzzzzzzzzzzzzze_ ?? "");
            string zzzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(zzzzzzzzzzzzzzzzzf_ ?? "", ",");
            bool? zzzzzzzzzzzzzzzzzh_(Observation Exam)
            {
                DataType azzzzzzzzzzzzzzzzzw_ = Exam?.Effective;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzy_ is null));
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzw_);
                CqlDateTime bzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzb_);
                Period bzzzzzzzzzzzzzzzzzd_ = Encounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(bzzzzzzzzzzzzzzzzze_);
                CqlQuantity bzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzj_);
                CqlDateTime bzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzm_, true, true);
                bool? bzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzn_, default);
                bool? bzzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzq_ = Exam?.StatusElement;
                string bzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzzzq_);
                string[] bzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzt_);
                DataType bzzzzzzzzzzzzzzzzzv_ = Exam?.Value;
                bool? bzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzv_ is null));
                bool? bzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(ExamList, zzzzzzzzzzzzzzzzzh_);
            object zzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzk_);
            DataType zzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzl_?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzm_);
            CqlDateTime zzzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzzn_);
            string zzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateTimeToString(zzzzzzzzzzzzzzzzzo_);
            string zzzzzzzzzzzzzzzzzq_ = context.Operators.Concatenate(zzzzzzzzzzzzzzzzzg_ ?? "", zzzzzzzzzzzzzzzzzp_ ?? "");

            return zzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<string> yzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, string>(yzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzo_);
        IEnumerable<string> yzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<string>(yzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounters(context);
        string czzzzzzzzzzzzzzzzzc_(Encounter Encounter)
        {
            string czzzzzzzzzzzzzzzzzf_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string czzzzzzzzzzzzzzzzzg_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzf_ ?? "", ",");
            Id czzzzzzzzzzzzzzzzzh_ = Encounter?.IdElement;
            string czzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzzh_);
            string czzzzzzzzzzzzzzzzzj_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzg_ ?? "", czzzzzzzzzzzzzzzzzi_ ?? "");
            string czzzzzzzzzzzzzzzzzk_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzj_ ?? "", ",");
            bool? czzzzzzzzzzzzzzzzzl_(Observation Lab)
            {
                Instant dzzzzzzzzzzzzzzzzze_ = Lab?.IssuedElement;
                bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzze_ is null));
                CqlDateTime dzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzzze_);
                Period dzzzzzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzj_);
                CqlQuantity dzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzr_, true, true);
                bool? dzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzs_, default);
                bool? dzzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzv_ = Lab?.StatusElement;
                string dzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzzv_);
                string[] dzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? dzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzy_);
                DataType ezzzzzzzzzzzzzzzzza_ = Lab?.Value;
                bool? ezzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzza_ is null));
                bool? ezzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzb_);

                return ezzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(LabList, czzzzzzzzzzzzzzzzzl_);
            object czzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;

                return ezzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzo_);
            DataType czzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzp_?.Value;
            CqlQuantity czzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzq_ as Quantity);
            string czzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertQuantityToString(czzzzzzzzzzzzzzzzzr_);
            string czzzzzzzzzzzzzzzzzt_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzk_ ?? "", czzzzzzzzzzzzzzzzzs_ ?? "");
            string czzzzzzzzzzzzzzzzzu_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzt_ ?? "", ",");
            bool? czzzzzzzzzzzzzzzzzv_(Observation Lab)
            {
                Instant ezzzzzzzzzzzzzzzzze_ = Lab?.IssuedElement;
                bool? ezzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzze_ is null));
                CqlDateTime ezzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzzzzzzze_);
                Period ezzzzzzzzzzzzzzzzzi_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzi_);
                CqlDateTime ezzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzj_);
                CqlQuantity ezzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzi_);
                CqlDateTime ezzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzo_);
                CqlDateTime ezzzzzzzzzzzzzzzzzr_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzr_, true, true);
                bool? ezzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzs_, default);
                bool? ezzzzzzzzzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzv_ = Lab?.StatusElement;
                string ezzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzzv_);
                string[] ezzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzy_);
                DataType fzzzzzzzzzzzzzzzzza_ = Lab?.Value;
                bool? fzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzza_ is null));
                bool? fzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzb_);

                return fzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(LabList, czzzzzzzzzzzzzzzzzv_);
            object czzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;

                return fzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzy_);
            Instant dzzzzzzzzzzzzzzzzza_ = czzzzzzzzzzzzzzzzzz_?.IssuedElement;
            CqlDateTime dzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzzza_);
            string dzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateTimeToString(dzzzzzzzzzzzzzzzzzb_);
            string dzzzzzzzzzzzzzzzzzd_ = context.Operators.Concatenate(czzzzzzzzzzzzzzzzzu_ ?? "", dzzzzzzzzzzzzzzzzzc_ ?? "");

            return dzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<string> czzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, string>(czzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzc_);
        IEnumerable<string> czzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<string>(czzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzze_ = this.Heart_rate(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzh_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzzg_, "FirstHeartRate");
        CqlCode fzzzzzzzzzzzzzzzzzi_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzl_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzzk_, "FirstSystolicBP");
        CqlCode fzzzzzzzzzzzzzzzzzm_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzp_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzzo_, "FirstRespRate");
        CqlValueSet fzzzzzzzzzzzzzzzzzq_ = this.Body_temperature(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzs_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzzr_, "FirstTemperature");
        CqlCode fzzzzzzzzzzzzzzzzzt_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzw_ = this.FirstPhysicalExamWithEncounterId(context, fzzzzzzzzzzzzzzzzzv_, "FirstO2Saturation");
        CqlValueSet fzzzzzzzzzzzzzzzzzx_ = this.Body_weight(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> fzzzzzzzzzzzzzzzzzz_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, fzzzzzzzzzzzzzzzzzy_, "FirstWeight");
        CqlValueSet gzzzzzzzzzzzzzzzzza_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzc_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzb_, "FirstHematocrit");
        CqlValueSet gzzzzzzzzzzzzzzzzzd_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzf_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzze_, "FirstWhiteBloodCell");
        CqlValueSet gzzzzzzzzzzzzzzzzzg_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzi_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzh_, "FirstPotassium");
        CqlValueSet gzzzzzzzzzzzzzzzzzj_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzl_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzk_, "FirstSodium");
        CqlValueSet gzzzzzzzzzzzzzzzzzm_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzo_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzn_, "FirstBicarbonate");
        CqlValueSet gzzzzzzzzzzzzzzzzzp_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzr_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzq_, "FirstCreatinine");
        CqlValueSet gzzzzzzzzzzzzzzzzzs_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> gzzzzzzzzzzzzzzzzzu_ = this.FirstLabTestWithEncounterId(context, gzzzzzzzzzzzzzzzzzt_, "FirstGlucose");
        IEnumerable<string>[] gzzzzzzzzzzzzzzzzzv_ = [
            fzzzzzzzzzzzzzzzzzh_,
            fzzzzzzzzzzzzzzzzzl_,
            fzzzzzzzzzzzzzzzzzp_,
            fzzzzzzzzzzzzzzzzzs_,
            fzzzzzzzzzzzzzzzzzw_,
            fzzzzzzzzzzzzzzzzzz_,
            gzzzzzzzzzzzzzzzzzc_,
            gzzzzzzzzzzzzzzzzzf_,
            gzzzzzzzzzzzzzzzzzi_,
            gzzzzzzzzzzzzzzzzzl_,
            gzzzzzzzzzzzzzzzzzo_,
            gzzzzzzzzzzzzzzzzzr_,
            gzzzzzzzzzzzzzzzzzu_,
        ];
        IEnumerable<string> gzzzzzzzzzzzzzzzzzw_ = context.Operators.Flatten<string>(gzzzzzzzzzzzzzzzzzv_ as IEnumerable<IEnumerable<string>>);

        return gzzzzzzzzzzzzzzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDate gzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
        CqlDate gzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateTimeToDate(AsOf);
        int? gzzzzzzzzzzzzzzzzzz_ = context.Operators.DurationBetween(gzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzy_, "year");

        return gzzzzzzzzzzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? hzzzzzzzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? hzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? hzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? hzzzzzzzzzzzzzzzzzd_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime hzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(hzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzc_, 0, 0, 0, 0, hzzzzzzzzzzzzzzzzzd_);

        return hzzzzzzzzzzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(Stay);
        CqlDateTime hzzzzzzzzzzzzzzzzzg_ = context.Operators.End(Stay);
        int? hzzzzzzzzzzzzzzzzzh_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzg_, "day");

        return hzzzzzzzzzzzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzi_ = this.HospitalizationWithObservation(context, Encounter);
        int? hzzzzzzzzzzzzzzzzzj_ = this.LengthInDays(context, hzzzzzzzzzzzzzzzzzi_);

        return hzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
        [typeof(Encounter), typeof(Coverage)],
        ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}
