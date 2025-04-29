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
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter DeliveryEncounter)
        {
            int? dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 37);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter DeliveryEncounter)
        {
            int? dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(37m, "weeks");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null), dzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter DeliveryEncounter)
        {
            int? ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null), (bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition EncounterDiagnosis)
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterDiagnosis?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_with_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter DeliveryEncounter)
        {
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterDiagnosis?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_of_Singleton(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation Gravida)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Gravida?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Gravida?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Gravida?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Gravida?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Gravida?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Gravida?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Gravida?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Gravida?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzy_());
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, false);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
        {
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                if (hzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzc_());

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as int?;
    }


    [CqlExpressionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.____Parity(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation Parity)
        {
            object izzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                if (jzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Parity?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzg_());
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, false);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Parity?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string izzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Parity?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
        {
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                if (jzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzu_());

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation izzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        DataType izzzzzzzzzzzzzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        object izzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzf_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation PretermBirth)
        {
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PretermBirth?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PretermBirth?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PretermBirth?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                if (lzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PretermBirth?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PretermBirth?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PretermBirth?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzy_());
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, false);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PretermBirth?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PretermBirth?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
        {
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                if (mzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzm_());

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Last<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.____Births_term(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation TermBirth)
        {
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzp_ = TermBirth?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzs_ = TermBirth?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzv_ = TermBirth?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzy_ = TermBirth?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (ozzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzza_ = TermBirth?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = TermBirth?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzq_());
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, false);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzb_ = TermBirth?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzi_ = TermBirth?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
        {
            object pzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzze_());

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
        Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Singleton_Delivery(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Intersect<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter SingletonEncounterGE37Weeks)
        {
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzd_, 1);
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzf_, 0);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 0);
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzk_, 0);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation AbnormalPresentation)
                    {
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                        Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                        Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        string rzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
                    {
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzr_());

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation AbnormalPresentation)
                    {
                        object tzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            if (uzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzv_());
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                        Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                        Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        string uzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                        return uzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object uzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            if (vzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzy_());

                        return uzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation tzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation AbnormalPresentation)
                    {
                        object wzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (wzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzc_());
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                        Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                        Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        string wzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return wzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
                    {
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            if (xzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzf_());

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = wzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation AbnormalPresentation)
                    {
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return yzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (yzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzi_());
                        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                        Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                        Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        string yzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
                    {
                        object zzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (zzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return zzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation AbnormalPresentation)
                    {
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool azzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (azzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                        Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                        Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        string azzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return azzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return czzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return czzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (czzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (czzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (czzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation AbnormalPresentation)
                    {
                        object czzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AbnormalPresentation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                        Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        string dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool ezzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ThirtysevenWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterDiagnosis?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Abnormal_Presentation(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition EncounterDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterDiagnosis?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Genital_Herpes(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Abnormal_Presentation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtysevenWeeksPlusEncounter);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CSection?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CSection?.StatusElement;
                EventStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "completed");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure CSection) =>
                ThirtysevenWeeksPlusEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounter_with_Cesarean_Birth(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
