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
[CqlLibrary("CesareanBirthFHIR", "0.2.000")]
public partial class CesareanBirthFHIR_0_2_000 : ILibrary, ISingleton<CesareanBirthFHIR_0_2_000>
{
    private CesareanBirthFHIR_0_2_000() {}

    public static CesareanBirthFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CesareanBirthFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, PCMaternal_5_19_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Abnormal Presentation
    [CqlValueSetDefinition(
        definitionName: "Abnormal Presentation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105",
        valueSetVersion: null)]
    public CqlValueSet Abnormal_Presentation(CqlContext context) => _Abnormal_Presentation;

    private static readonly CqlValueSet _Abnormal_Presentation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", null);
    #endregion

    #region ValueSet: Cesarean Birth
    [CqlValueSetDefinition(
        definitionName: "Cesarean Birth",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282",
        valueSetVersion: null)]
    public CqlValueSet Cesarean_Birth(CqlContext context) => _Cesarean_Birth;

    private static readonly CqlValueSet _Cesarean_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", null);
    #endregion

    #region ValueSet: Delivery of Singleton
    [CqlValueSetDefinition(
        definitionName: "Delivery of Singleton",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99",
        valueSetVersion: null)]
    public CqlValueSet Delivery_of_Singleton(CqlContext context) => _Delivery_of_Singleton;

    private static readonly CqlValueSet _Delivery_of_Singleton = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", null);
    #endregion

    #region ValueSet: Delivery Procedures
    [CqlValueSetDefinition(
        definitionName: "Delivery Procedures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59",
        valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext context) => _Delivery_Procedures;

    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Genital Herpes
    [CqlValueSetDefinition(
        definitionName: "Genital Herpes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049",
        valueSetVersion: null)]
    public CqlValueSet Genital_Herpes(CqlContext context) => _Genital_Herpes;

    private static readonly CqlValueSet _Genital_Herpes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", null);
    #endregion

    #region ValueSet: Placenta Accreta Spectrum Previa or Vasa Previa
    [CqlValueSetDefinition(
        definitionName: "Placenta Accreta Spectrum Previa or Vasa Previa",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37",
        valueSetVersion: null)]
    public CqlValueSet Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(CqlContext context) => _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa;

    private static readonly CqlValueSet _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", null);
    #endregion

    #region ValueSet: 37 to 42 Plus Weeks Gestation
    [CqlValueSetDefinition(
        definitionName: "37 to 42 Plus Weeks Gestation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68",
        valueSetVersion: null)]
    public CqlValueSet _37_to_42_Plus_Weeks_Gestation(CqlContext context) => __37_to_42_Plus_Weeks_Gestation;

    private static readonly CqlValueSet __37_to_42_Plus_Weeks_Gestation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: [#] Births.preterm
    [CqlCodeDefinition(
        definitionName: "[#] Births.preterm",
        codeId: "11637-6",
        codeSystem: "http://loinc.org")]
    public CqlCode ____Births_preterm(CqlContext context) => _____Births_preterm;

    private static readonly CqlCode _____Births_preterm = new CqlCode("11637-6", "http://loinc.org", default, default);
    #endregion

    #region Code: [#] Births.term
    [CqlCodeDefinition(
        definitionName: "[#] Births.term",
        codeId: "11639-2",
        codeSystem: "http://loinc.org")]
    public CqlCode ____Births_term(CqlContext context) => _____Births_term;

    private static readonly CqlCode _____Births_term = new CqlCode("11639-2", "http://loinc.org", default, default);
    #endregion

    #region Code: [#] Parity
    [CqlCodeDefinition(
        definitionName: "[#] Parity",
        codeId: "11977-6",
        codeSystem: "http://loinc.org")]
    public CqlCode ____Parity(CqlContext context) => _____Parity;

    private static readonly CqlCode _____Parity = new CqlCode("11977-6", "http://loinc.org", default, default);
    #endregion

    #region Code: [#] Pregnancies
    [CqlCodeDefinition(
        definitionName: "[#] Pregnancies",
        codeId: "11996-6",
        codeSystem: "http://loinc.org")]
    public CqlCode ____Pregnancies(CqlContext context) => _____Pregnancies;

    private static readonly CqlCode _____Pregnancies = new CqlCode("11996-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Date and time of obstetric delivery
    [CqlCodeDefinition(
        definitionName: "Date and time of obstetric delivery",
        codeId: "93857-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext context) => _Date_and_time_of_obstetric_delivery;

    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            new CqlCode("11637-6", "http://loinc.org", default, default),
            new CqlCode("11639-2", "http://loinc.org", default, default),
            new CqlCode("11977-6", "http://loinc.org", default, default),
            new CqlCode("11996-6", "http://loinc.org", default, default),
            new CqlCode("93857-1", "http://loinc.org", default, default),
        ];

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter DeliveryEncounter)
        {
            int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, 37);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter DeliveryEncounter)
        {
            int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(37m, "weeks");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null), vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter DeliveryEncounter)
        {
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null), (bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition EncounterDiagnosis)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterDiagnosis?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_with_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter DeliveryEncounter)
        {
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition EncounterDiagnosis)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiagnosis?.Code;
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_of_Singleton(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation Gravida)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Gravida?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Gravida?.StatusElement;
            ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Gravida?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Gravida?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Gravida?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Gravida?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Gravida?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Gravida?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, false);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
        {
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Last<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as int?;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.____Parity(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation Parity)
        {
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Parity?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, false);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Parity?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Parity?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
        {
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Observation zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as int?;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation PretermBirth)
        {
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PretermBirth?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, false);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PretermBirth?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PretermBirth?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
        {
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_());

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as int?;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.____Births_term(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation TermBirth)
        {
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = TermBirth?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = TermBirth?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = TermBirth?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = TermBirth?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = TermBirth?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = TermBirth?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_());
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, false);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = TermBirth?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = TermBirth?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
        {
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as int?;
    }


    [CqlExpressionDefinition(
        definitionName: "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Singleton_Delivery(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Intersect<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter SingletonEncounterGE37Weeks)
        {
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, 1);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 0);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, 0);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, 0);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation AbnormalPresentation)
                    {
                        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());

                        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation AbnormalPresentation)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_());
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation AbnormalPresentation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_());

                        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation AbnormalPresentation)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
                    {
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation AbnormalPresentation)
                    {
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                        Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                        Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
                    {
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation AbnormalPresentation)
                    {
                        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                        Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                        Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
                    {
                        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_());

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ThirtysevenWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition EncounterDiagnosis)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterDiagnosis?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Abnormal_Presentation(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition EncounterDiagnosis)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterDiagnosis?.Code;
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Genital_Herpes(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Abnormal_Presentation(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtysevenWeeksPlusEncounter);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CSection?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                Code<EventStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CSection?.StatusElement;
                EventStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "completed");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure CSection) =>
                ThirtysevenWeeksPlusEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounter_with_Cesarean_Birth(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
