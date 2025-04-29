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

    [CqlValueSetDefinition("Abnormal Presentation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", valueSetVersion: null)]
    public CqlValueSet Abnormal_Presentation(CqlContext _) => _Abnormal_Presentation;
    private static readonly CqlValueSet _Abnormal_Presentation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", null);

    [CqlValueSetDefinition("Cesarean Birth", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", valueSetVersion: null)]
    public CqlValueSet Cesarean_Birth(CqlContext _) => _Cesarean_Birth;
    private static readonly CqlValueSet _Cesarean_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", null);

    [CqlValueSetDefinition("Delivery of Singleton", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", valueSetVersion: null)]
    public CqlValueSet Delivery_of_Singleton(CqlContext _) => _Delivery_of_Singleton;
    private static readonly CqlValueSet _Delivery_of_Singleton = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", null);

    [CqlValueSetDefinition("Delivery Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext _) => _Delivery_Procedures;
    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Genital Herpes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", valueSetVersion: null)]
    public CqlValueSet Genital_Herpes(CqlContext _) => _Genital_Herpes;
    private static readonly CqlValueSet _Genital_Herpes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", null);

    [CqlValueSetDefinition("Placenta Accreta Spectrum Previa or Vasa Previa", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", valueSetVersion: null)]
    public CqlValueSet Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(CqlContext _) => _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa;
    private static readonly CqlValueSet _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", null);

    [CqlValueSetDefinition("37 to 42 Plus Weeks Gestation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", valueSetVersion: null)]
    public CqlValueSet _37_to_42_Plus_Weeks_Gestation(CqlContext _) => __37_to_42_Plus_Weeks_Gestation;
    private static readonly CqlValueSet __37_to_42_Plus_Weeks_Gestation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("[#] Births.preterm", codeId: "11637-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Births_preterm(CqlContext _) => _____Births_preterm;
    private static readonly CqlCode _____Births_preterm = new CqlCode("11637-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("[#] Births.term", codeId: "11639-2", codeSystem: "http://loinc.org")]
    public CqlCode ____Births_term(CqlContext _) => _____Births_term;
    private static readonly CqlCode _____Births_term = new CqlCode("11639-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("[#] Parity", codeId: "11977-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Parity(CqlContext _) => _____Parity;
    private static readonly CqlCode _____Parity = new CqlCode("11977-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("[#] Pregnancies", codeId: "11996-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Pregnancies(CqlContext _) => _____Pregnancies;
    private static readonly CqlCode _____Pregnancies = new CqlCode("11996-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Date and time of obstetric delivery", codeId: "93857-1", codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext _) => _Date_and_time_of_obstetric_delivery;
    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzb_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzze_);

        return ozzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzh_(Encounter DeliveryEncounter)
        {
            int? ozzzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? ozzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzj_, 37);

            return ozzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzh_);

        return ozzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzm_(Encounter DeliveryEncounter)
        {
            int? ozzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(37m, "weeks");
            bool? ozzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And((bool?)(ozzzzzzzzzzzzzzzzzzzzzzo_ is null), ozzzzzzzzzzzzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzu_(Encounter DeliveryEncounter)
        {
            int? ozzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? ozzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And((bool?)(ozzzzzzzzzzzzzzzzzzzzzzw_ is null), (bool?)(ozzzzzzzzzzzzzzzzzzzzzzx_ is null));
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? pzzzzzzzzzzzzzzzzzzzzzza_(Condition EncounterDiagnosis)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzze_ = EncounterDiagnosis?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzze_);
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzg_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzg_);

                return pzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_with_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzo_(Encounter DeliveryEncounter)
        {
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? pzzzzzzzzzzzzzzzzzzzzzzr_(Condition EncounterDiagnosis)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterDiagnosis?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_of_Singleton(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzw_);

                return pzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzy_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzb_(Observation Gravida)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzi_ = Gravida?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzl_ = Gravida?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzm_);
            string qzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzn_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzq_);
            object qzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzh_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzk_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzn_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzq_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzs_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzu_ = Gravida?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzs_());
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzu_, true, false);
            bool? qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzy_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzc_);

            return rzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzb_);
        object qzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
        {
            object rzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzb_);
                    bool szzzzzzzzzzzzzzzzzzzzzzd_ = szzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzze_);
                    bool szzzzzzzzzzzzzzzzzzzzzzg_ = szzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool szzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzh_);
                    bool szzzzzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzj_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzk_);

                    return (szzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzm_);

                    return (szzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzo_);

                    return (szzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzw_());

            return rzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Observation qzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzzzzzzzzze_);
        DataType qzzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
        object qzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzzzzzzzzzzzh_ as int?;
    }


    [CqlExpressionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzq_ = this.____Parity(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? szzzzzzzzzzzzzzzzzzzzzzt_(Observation Parity)
        {
            object tzzzzzzzzzzzzzzzzzzzzzza_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzz_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzc_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool uzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzf_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzi_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzk_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzm_ = Parity?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzza_());
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzc_, true, false);
            bool? tzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzg_, default);
            bool? tzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzj_);
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzl_ = Parity?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzm_);
            string tzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzn_);
            string[] tzzzzzzzzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzs_ = Parity?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzu_);

            return tzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzt_);
        object szzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
        {
            object uzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                bool uzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzv_ = uzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                if (uzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzze_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzo_());

            return uzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Observation szzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(szzzzzzzzzzzzzzzzzzzzzzw_);
        DataType szzzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzzx_?.Value;
        object szzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzz_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzi_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzl_(Observation PretermBirth)
        {
            object vzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool wzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzr_ = PretermBirth?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzu_ = PretermBirth?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzx_ = PretermBirth?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzz_ = wzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                if (wzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzza_ = PretermBirth?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzza_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzc_ = PretermBirth?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzze_ = PretermBirth?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzze_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzs_());
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzu_, true, false);
            bool? vzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzy_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzd_ = PretermBirth?.StatusElement;
            ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzze_);
            string wzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] wzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzk_ = PretermBirth?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzl_);
        object vzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
        {
            object xzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzn_ = xzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzq_ = xzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzt_ = xzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzg_());

            return xzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Observation vzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzo_);
        DataType vzzzzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        object vzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzzzzzr_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzza_ = this.____Births_term(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzd_(Observation TermBirth)
        {
            object yzzzzzzzzzzzzzzzzzzzzzzk_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzj_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzm_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzp_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzs_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzu_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzw_ = TermBirth?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzk_());
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzm_, true, false);
            bool? yzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzq_, default);
            bool? yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzt_);
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzv_ = TermBirth?.StatusElement;
            ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzw_);
            string yzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] yzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzza_);
            DataType zzzzzzzzzzzzzzzzzzzzzzzc_ = TermBirth?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? zzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzze_);

            return zzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzd_);
        object yzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
        {
            object zzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzy_());

            return zzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Observation yzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzzzzg_);
        DataType yzzzzzzzzzzzzzzzzzzzzzzi_ = yzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        object yzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzzzj_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Singleton_Delivery(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Intersect<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzv_(Encounter SingletonEncounterGE37Weeks)
        {
            int? azzzzzzzzzzzzzzzzzzzzzzzx_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? azzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzx_, 1);
            int? azzzzzzzzzzzzzzzzzzzzzzzz_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? bzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzz_, 0);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzza_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzc_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzc_, 0);
            int? bzzzzzzzzzzzzzzzzzzzzzzze_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzze_, 0);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            object bzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                bool bzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? czzzzzzzzzzzzzzzzzzzzzzza_(Observation AbnormalPresentation)
                    {
                        object czzzzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            bool czzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return czzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool czzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return dzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool czzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (czzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (czzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (czzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzi_());
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzk_, default);
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzn_);
                        string czzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzo_);
                        string[] czzzzzzzzzzzzzzzzzzzzzzzq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? czzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzr_);

                        return czzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzza_);
                    object czzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
                    {
                        object dzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzv_ = dzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return dzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return dzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation czzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzd_);
                    DataType czzzzzzzzzzzzzzzzzzzzzzzf_ = czzzzzzzzzzzzzzzzzzzzzzze_?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool czzzzzzzzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzf_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ezzzzzzzzzzzzzzzzzzzzzzzh_(Observation AbnormalPresentation)
                    {
                        object ezzzzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool fzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                                return fzzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzl_ = fzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            if (fzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzp_());
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? ezzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzr_, default);
                        Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                        Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzu_);
                        string ezzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzv_);
                        string[] ezzzzzzzzzzzzzzzzzzzzzzzx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ezzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                        bool? ezzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzy_);

                        return ezzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzh_);
                    object ezzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object fzzzzzzzzzzzzzzzzzzzzzzzs_()
                        {
                            bool fzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzz_ = fzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzza_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            if (fzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzs_());

                        return fzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzo_(Observation AbnormalPresentation)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzw_()
                        {
                            bool hzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzk_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                                return hzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            if (hzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzv_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzx_ = AbnormalPresentation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzw_());
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? gzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzza_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzb_);
                        string hzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzc_);
                        string[] hzzzzzzzzzzzzzzzzzzzzzzze_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return hzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzo_);
                    object gzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
                    {
                        object hzzzzzzzzzzzzzzzzzzzzzzzz_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzze_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzh_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzz_());

                        return izzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzr_);
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzzzzzs_?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                if (bzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzt_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? izzzzzzzzzzzzzzzzzzzzzzzv_(Observation AbnormalPresentation)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzc_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzc_());
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzze_, default);
                        Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzg_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                        Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzzzzh_);
                        string jzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzi_);
                        string[] jzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return jzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzv_);
                    object izzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzf_());

                        return kzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation izzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzzzzzy_);
                    DataType jzzzzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzzzzz_?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? lzzzzzzzzzzzzzzzzzzzzzzzb_(Observation AbnormalPresentation)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzi_());
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzn_);
                        string lzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzo_);
                        string[] lzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return lzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzb_);
                    object lzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzs_ = mzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return mzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzzzzzzzzze_);
                    DataType lzzzzzzzzzzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzzzzzzzzzzf_?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (lzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nzzzzzzzzzzzzzzzzzzzzzzzh_(Observation AbnormalPresentation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzh_ = ozzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzo_());
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzt_);
                        string nzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzu_);
                        string[] nzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzh_);
                    object nzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzb_ = pzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzr_());

                        return ozzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzm_ = nzzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzl_());
            Period bzzzzzzzzzzzzzzzzzzzzzzzn_ = ThirtysevenWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzr_(Condition EncounterDiagnosis)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterDiagnosis?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Abnormal_Presentation(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzn_);

                return pzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzt_);

            return bzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzt_(Condition EncounterDiagnosis)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterDiagnosis?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Genital_Herpes(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzd_);

                return qzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzq_);

        return pzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Abnormal_Presentation(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtysevenWeeksPlusEncounter);
                DataType qzzzzzzzzzzzzzzzzzzzzzzzv_ = CSection?.Performed;
                object qzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzzzz_ = CSection?.StatusElement;
                EventStatus? rzzzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzc_);

                return rzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzq_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure CSection) =>
                ThirtysevenWeeksPlusEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Procedure, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounter_with_Cesarean_Birth(context);

        return rzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> rzzzzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
