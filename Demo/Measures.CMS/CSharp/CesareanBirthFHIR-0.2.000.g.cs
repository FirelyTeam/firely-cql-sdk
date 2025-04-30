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
        CqlDateTime xzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzg_ = context.Operators.Interval(xzzzzzzzzzzze_, xzzzzzzzzzzzf_, true, true);
        object xzzzzzzzzzzzh_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", xzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzi_);

        return xzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzzzzzzl_(Encounter DeliveryEncounter)
        {
            int? xzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? xzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzn_, 37);

            return xzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzk_, xzzzzzzzzzzzl_);

        return xzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzzzzzzq_(Encounter DeliveryEncounter)
        {
            int? xzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity xzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity xzzzzzzzzzzzu_ = context.Operators.Quantity(37m, "weeks");
            bool? xzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzt_, xzzzzzzzzzzzu_);
            bool? xzzzzzzzzzzzw_ = context.Operators.And((bool?)(xzzzzzzzzzzzs_ is null), xzzzzzzzzzzzv_);

            return xzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzp_, xzzzzzzzzzzzq_);

        return xzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzzzzzzy_(Encounter DeliveryEncounter)
        {
            int? yzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity yzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? yzzzzzzzzzzzc_ = context.Operators.And((bool?)(yzzzzzzzzzzza_ is null), (bool?)(yzzzzzzzzzzzb_ is null));
            IEnumerable<Condition> yzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? yzzzzzzzzzzze_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzzzzzi_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzi_);
                CqlValueSet yzzzzzzzzzzzk_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? yzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzj_, yzzzzzzzzzzzk_);

                return yzzzzzzzzzzzl_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzf_ = context.Operators.Where<Condition>(yzzzzzzzzzzzd_, yzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzf_);
            bool? yzzzzzzzzzzzh_ = context.Operators.And(yzzzzzzzzzzzc_, yzzzzzzzzzzzg_);

            return yzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzx_, xzzzzzzzzzzzy_);

        return xzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzm_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> yzzzzzzzzzzzn_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> yzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzm_, yzzzzzzzzzzzn_);
        IEnumerable<Encounter> yzzzzzzzzzzzp_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> yzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzo_, yzzzzzzzzzzzp_);

        return yzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_with_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? yzzzzzzzzzzzs_(Encounter DeliveryEncounter)
        {
            IEnumerable<Condition> yzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? yzzzzzzzzzzzv_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzzzzzy_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzy_);
                CqlValueSet zzzzzzzzzzzza_ = this.Delivery_of_Singleton(context);
                bool? zzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzz_, zzzzzzzzzzzza_);

                return zzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzw_ = context.Operators.Where<Condition>(yzzzzzzzzzzzu_, yzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzw_);

            return yzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzr_, yzzzzzzzzzzzs_);

        return yzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode zzzzzzzzzzzzc_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzc_);
        IEnumerable<Observation> zzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? zzzzzzzzzzzzf_(Observation Gravida)
        {
            DataType zzzzzzzzzzzzm_ = Gravida?.Value;
            object zzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzm_);
            bool? zzzzzzzzzzzzo_ = context.Operators.Not((bool?)(zzzzzzzzzzzzn_ is null));
            Code<ObservationStatus> zzzzzzzzzzzzp_ = Gravida?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzq_ = zzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzq_);
            string zzzzzzzzzzzzs_ = context.Operators.Convert<string>(zzzzzzzzzzzzr_);
            string[] zzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzu_ = context.Operators.In<string>(zzzzzzzzzzzzs_, zzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzv_ = context.Operators.And(zzzzzzzzzzzzo_, zzzzzzzzzzzzu_);
            object zzzzzzzzzzzzw_()
            {
                bool azzzzzzzzzzzzi_()
                {
                    DataType azzzzzzzzzzzzl_ = Gravida?.Effective;
                    object azzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzl_);
                    bool azzzzzzzzzzzzn_ = azzzzzzzzzzzzm_ is CqlDateTime;

                    return azzzzzzzzzzzzn_;
                };
                bool azzzzzzzzzzzzj_()
                {
                    DataType azzzzzzzzzzzzo_ = Gravida?.Effective;
                    object azzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzo_);
                    bool azzzzzzzzzzzzq_ = azzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzq_;
                };
                bool azzzzzzzzzzzzk_()
                {
                    DataType azzzzzzzzzzzzr_ = Gravida?.Effective;
                    object azzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzr_);
                    bool azzzzzzzzzzzzt_ = azzzzzzzzzzzzs_ is CqlDateTime;

                    return azzzzzzzzzzzzt_;
                };
                if (azzzzzzzzzzzzi_())
                {
                    DataType azzzzzzzzzzzzu_ = Gravida?.Effective;
                    object azzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzu_);

                    return (azzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzj_())
                {
                    DataType azzzzzzzzzzzzw_ = Gravida?.Effective;
                    object azzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzw_);

                    return (azzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzk_())
                {
                    DataType azzzzzzzzzzzzy_ = Gravida?.Effective;
                    object azzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzy_);

                    return (azzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzw_());
            CqlDateTime zzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity zzzzzzzzzzzzz_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime azzzzzzzzzzzza_ = context.Operators.Subtract(zzzzzzzzzzzzy_, zzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzza_, zzzzzzzzzzzzy_, true, false);
            bool? azzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzx_, azzzzzzzzzzzzc_, default);
            bool? azzzzzzzzzzzzf_ = context.Operators.Not((bool?)(zzzzzzzzzzzzy_ is null));
            bool? azzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzd_, azzzzzzzzzzzzf_);
            bool? azzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzv_, azzzzzzzzzzzzg_);

            return azzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzg_ = context.Operators.Where<Observation>(zzzzzzzzzzzze_, zzzzzzzzzzzzf_);
        object zzzzzzzzzzzzh_(Observation @this)
        {
            object bzzzzzzzzzzzza_()
            {
                bool bzzzzzzzzzzzzc_()
                {
                    DataType bzzzzzzzzzzzzf_ = @this?.Effective;
                    object bzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzf_);
                    bool bzzzzzzzzzzzzh_ = bzzzzzzzzzzzzg_ is CqlDateTime;

                    return bzzzzzzzzzzzzh_;
                };
                bool bzzzzzzzzzzzzd_()
                {
                    DataType bzzzzzzzzzzzzi_ = @this?.Effective;
                    object bzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzi_);
                    bool bzzzzzzzzzzzzk_ = bzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzk_;
                };
                bool bzzzzzzzzzzzze_()
                {
                    DataType bzzzzzzzzzzzzl_ = @this?.Effective;
                    object bzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzl_);
                    bool bzzzzzzzzzzzzn_ = bzzzzzzzzzzzzm_ is CqlDateTime;

                    return bzzzzzzzzzzzzn_;
                };
                if (bzzzzzzzzzzzzc_())
                {
                    DataType bzzzzzzzzzzzzo_ = @this?.Effective;
                    object bzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzo_);

                    return (bzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzd_())
                {
                    DataType bzzzzzzzzzzzzq_ = @this?.Effective;
                    object bzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzq_);

                    return (bzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzze_())
                {
                    DataType bzzzzzzzzzzzzs_ = @this?.Effective;
                    object bzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzs_);

                    return (bzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzza_());

            return bzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzg_, zzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Observation zzzzzzzzzzzzj_ = context.Operators.Last<Observation>(zzzzzzzzzzzzi_);
        DataType zzzzzzzzzzzzk_ = zzzzzzzzzzzzj_?.Value;
        object zzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzk_);

        return zzzzzzzzzzzzl_ as int?;
    }


    [CqlExpressionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode bzzzzzzzzzzzzu_ = this.____Parity(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzu_);
        IEnumerable<Observation> bzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? bzzzzzzzzzzzzx_(Observation Parity)
        {
            object czzzzzzzzzzzze_()
            {
                bool dzzzzzzzzzzzza_()
                {
                    DataType dzzzzzzzzzzzzd_ = Parity?.Effective;
                    object dzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzd_);
                    bool dzzzzzzzzzzzzf_ = dzzzzzzzzzzzze_ is CqlDateTime;

                    return dzzzzzzzzzzzzf_;
                };
                bool dzzzzzzzzzzzzb_()
                {
                    DataType dzzzzzzzzzzzzg_ = Parity?.Effective;
                    object dzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzg_);
                    bool dzzzzzzzzzzzzi_ = dzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzi_;
                };
                bool dzzzzzzzzzzzzc_()
                {
                    DataType dzzzzzzzzzzzzj_ = Parity?.Effective;
                    object dzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzj_);
                    bool dzzzzzzzzzzzzl_ = dzzzzzzzzzzzzk_ is CqlDateTime;

                    return dzzzzzzzzzzzzl_;
                };
                if (dzzzzzzzzzzzza_())
                {
                    DataType dzzzzzzzzzzzzm_ = Parity?.Effective;
                    object dzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzm_);

                    return (dzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzb_())
                {
                    DataType dzzzzzzzzzzzzo_ = Parity?.Effective;
                    object dzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzo_);

                    return (dzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzc_())
                {
                    DataType dzzzzzzzzzzzzq_ = Parity?.Effective;
                    object dzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzq_);

                    return (dzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzze_());
            CqlDateTime czzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity czzzzzzzzzzzzh_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime czzzzzzzzzzzzi_ = context.Operators.Subtract(czzzzzzzzzzzzg_, czzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzk_ = context.Operators.Interval(czzzzzzzzzzzzi_, czzzzzzzzzzzzg_, true, false);
            bool? czzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzf_, czzzzzzzzzzzzk_, default);
            bool? czzzzzzzzzzzzn_ = context.Operators.Not((bool?)(czzzzzzzzzzzzg_ is null));
            bool? czzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzl_, czzzzzzzzzzzzn_);
            Code<ObservationStatus> czzzzzzzzzzzzp_ = Parity?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzq_ = czzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzq_);
            string czzzzzzzzzzzzs_ = context.Operators.Convert<string>(czzzzzzzzzzzzr_);
            string[] czzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzu_ = context.Operators.In<string>(czzzzzzzzzzzzs_, czzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzo_, czzzzzzzzzzzzu_);
            DataType czzzzzzzzzzzzw_ = Parity?.Value;
            object czzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzw_);
            bool? czzzzzzzzzzzzy_ = context.Operators.Not((bool?)(czzzzzzzzzzzzx_ is null));
            bool? czzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzv_, czzzzzzzzzzzzy_);

            return czzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzw_, bzzzzzzzzzzzzx_);
        object bzzzzzzzzzzzzz_(Observation @this)
        {
            object dzzzzzzzzzzzzs_()
            {
                bool dzzzzzzzzzzzzu_()
                {
                    DataType dzzzzzzzzzzzzx_ = @this?.Effective;
                    object dzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzx_);
                    bool dzzzzzzzzzzzzz_ = dzzzzzzzzzzzzy_ is CqlDateTime;

                    return dzzzzzzzzzzzzz_;
                };
                bool dzzzzzzzzzzzzv_()
                {
                    DataType ezzzzzzzzzzzza_ = @this?.Effective;
                    object ezzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzza_);
                    bool ezzzzzzzzzzzzc_ = ezzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzc_;
                };
                bool dzzzzzzzzzzzzw_()
                {
                    DataType ezzzzzzzzzzzzd_ = @this?.Effective;
                    object ezzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzd_);
                    bool ezzzzzzzzzzzzf_ = ezzzzzzzzzzzze_ is CqlDateTime;

                    return ezzzzzzzzzzzzf_;
                };
                if (dzzzzzzzzzzzzu_())
                {
                    DataType ezzzzzzzzzzzzg_ = @this?.Effective;
                    object ezzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzg_);

                    return (ezzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzv_())
                {
                    DataType ezzzzzzzzzzzzi_ = @this?.Effective;
                    object ezzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzi_);

                    return (ezzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzw_())
                {
                    DataType ezzzzzzzzzzzzk_ = @this?.Effective;
                    object ezzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzk_);

                    return (ezzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzs_());

            return dzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> czzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzy_, bzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Observation czzzzzzzzzzzzb_ = context.Operators.Last<Observation>(czzzzzzzzzzzza_);
        DataType czzzzzzzzzzzzc_ = czzzzzzzzzzzzb_?.Value;
        object czzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzc_);

        return czzzzzzzzzzzzd_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode ezzzzzzzzzzzzm_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzm_);
        IEnumerable<Observation> ezzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzzzzzzp_(Observation PretermBirth)
        {
            object ezzzzzzzzzzzzw_()
            {
                bool fzzzzzzzzzzzzs_()
                {
                    DataType fzzzzzzzzzzzzv_ = PretermBirth?.Effective;
                    object fzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzv_);
                    bool fzzzzzzzzzzzzx_ = fzzzzzzzzzzzzw_ is CqlDateTime;

                    return fzzzzzzzzzzzzx_;
                };
                bool fzzzzzzzzzzzzt_()
                {
                    DataType fzzzzzzzzzzzzy_ = PretermBirth?.Effective;
                    object fzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzy_);
                    bool gzzzzzzzzzzzza_ = fzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzza_;
                };
                bool fzzzzzzzzzzzzu_()
                {
                    DataType gzzzzzzzzzzzzb_ = PretermBirth?.Effective;
                    object gzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzb_);
                    bool gzzzzzzzzzzzzd_ = gzzzzzzzzzzzzc_ is CqlDateTime;

                    return gzzzzzzzzzzzzd_;
                };
                if (fzzzzzzzzzzzzs_())
                {
                    DataType gzzzzzzzzzzzze_ = PretermBirth?.Effective;
                    object gzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzze_);

                    return (gzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzzt_())
                {
                    DataType gzzzzzzzzzzzzg_ = PretermBirth?.Effective;
                    object gzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzg_);

                    return (gzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzzzzzzu_())
                {
                    DataType gzzzzzzzzzzzzi_ = PretermBirth?.Effective;
                    object gzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzi_);

                    return (gzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzw_());
            CqlDateTime ezzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity ezzzzzzzzzzzzz_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime fzzzzzzzzzzzza_ = context.Operators.Subtract(ezzzzzzzzzzzzy_, ezzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzc_ = context.Operators.Interval(fzzzzzzzzzzzza_, ezzzzzzzzzzzzy_, true, false);
            bool? fzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzx_, fzzzzzzzzzzzzc_, default);
            bool? fzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzy_ is null));
            bool? fzzzzzzzzzzzzg_ = context.Operators.And(fzzzzzzzzzzzzd_, fzzzzzzzzzzzzf_);
            Code<ObservationStatus> fzzzzzzzzzzzzh_ = PretermBirth?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzi_ = fzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzi_);
            string fzzzzzzzzzzzzk_ = context.Operators.Convert<string>(fzzzzzzzzzzzzj_);
            string[] fzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzm_ = context.Operators.In<string>(fzzzzzzzzzzzzk_, fzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzg_, fzzzzzzzzzzzzm_);
            DataType fzzzzzzzzzzzzo_ = PretermBirth?.Value;
            object fzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzp_ is null));
            bool? fzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzn_, fzzzzzzzzzzzzq_);

            return fzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzq_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzo_, ezzzzzzzzzzzzp_);
        object ezzzzzzzzzzzzr_(Observation @this)
        {
            object gzzzzzzzzzzzzk_()
            {
                bool gzzzzzzzzzzzzm_()
                {
                    DataType gzzzzzzzzzzzzp_ = @this?.Effective;
                    object gzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzp_);
                    bool gzzzzzzzzzzzzr_ = gzzzzzzzzzzzzq_ is CqlDateTime;

                    return gzzzzzzzzzzzzr_;
                };
                bool gzzzzzzzzzzzzn_()
                {
                    DataType gzzzzzzzzzzzzs_ = @this?.Effective;
                    object gzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzs_);
                    bool gzzzzzzzzzzzzu_ = gzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzu_;
                };
                bool gzzzzzzzzzzzzo_()
                {
                    DataType gzzzzzzzzzzzzv_ = @this?.Effective;
                    object gzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzv_);
                    bool gzzzzzzzzzzzzx_ = gzzzzzzzzzzzzw_ is CqlDateTime;

                    return gzzzzzzzzzzzzx_;
                };
                if (gzzzzzzzzzzzzm_())
                {
                    DataType gzzzzzzzzzzzzy_ = @this?.Effective;
                    object gzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzy_);

                    return (gzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzn_())
                {
                    DataType hzzzzzzzzzzzza_ = @this?.Effective;
                    object hzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzza_);

                    return (hzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzo_())
                {
                    DataType hzzzzzzzzzzzzc_ = @this?.Effective;
                    object hzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzc_);

                    return (hzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzk_());

            return gzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzq_, ezzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzt_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzs_);
        DataType ezzzzzzzzzzzzu_ = ezzzzzzzzzzzzt_?.Value;
        object ezzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzv_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode hzzzzzzzzzzzze_ = this.____Births_term(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzze_);
        IEnumerable<Observation> hzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzh_(Observation TermBirth)
        {
            object hzzzzzzzzzzzzo_()
            {
                bool izzzzzzzzzzzzk_()
                {
                    DataType izzzzzzzzzzzzn_ = TermBirth?.Effective;
                    object izzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzn_);
                    bool izzzzzzzzzzzzp_ = izzzzzzzzzzzzo_ is CqlDateTime;

                    return izzzzzzzzzzzzp_;
                };
                bool izzzzzzzzzzzzl_()
                {
                    DataType izzzzzzzzzzzzq_ = TermBirth?.Effective;
                    object izzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzq_);
                    bool izzzzzzzzzzzzs_ = izzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzs_;
                };
                bool izzzzzzzzzzzzm_()
                {
                    DataType izzzzzzzzzzzzt_ = TermBirth?.Effective;
                    object izzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzt_);
                    bool izzzzzzzzzzzzv_ = izzzzzzzzzzzzu_ is CqlDateTime;

                    return izzzzzzzzzzzzv_;
                };
                if (izzzzzzzzzzzzk_())
                {
                    DataType izzzzzzzzzzzzw_ = TermBirth?.Effective;
                    object izzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzw_);

                    return (izzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzl_())
                {
                    DataType izzzzzzzzzzzzy_ = TermBirth?.Effective;
                    object izzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzy_);

                    return (izzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzm_())
                {
                    DataType jzzzzzzzzzzzza_ = TermBirth?.Effective;
                    object jzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzza_);

                    return (jzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzo_());
            CqlDateTime hzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity hzzzzzzzzzzzzr_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime hzzzzzzzzzzzzs_ = context.Operators.Subtract(hzzzzzzzzzzzzq_, hzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzu_ = context.Operators.Interval(hzzzzzzzzzzzzs_, hzzzzzzzzzzzzq_, true, false);
            bool? hzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzp_, hzzzzzzzzzzzzu_, default);
            bool? hzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzq_ is null));
            bool? hzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzv_, hzzzzzzzzzzzzx_);
            Code<ObservationStatus> hzzzzzzzzzzzzz_ = TermBirth?.StatusElement;
            ObservationStatus? izzzzzzzzzzzza_ = hzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzza_);
            string izzzzzzzzzzzzc_ = context.Operators.Convert<string>(izzzzzzzzzzzzb_);
            string[] izzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzze_ = context.Operators.In<string>(izzzzzzzzzzzzc_, izzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzy_, izzzzzzzzzzzze_);
            DataType izzzzzzzzzzzzg_ = TermBirth?.Value;
            object izzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzg_);
            bool? izzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzh_ is null));
            bool? izzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzf_, izzzzzzzzzzzzi_);

            return izzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzg_, hzzzzzzzzzzzzh_);
        object hzzzzzzzzzzzzj_(Observation @this)
        {
            object jzzzzzzzzzzzzc_()
            {
                bool jzzzzzzzzzzzze_()
                {
                    DataType jzzzzzzzzzzzzh_ = @this?.Effective;
                    object jzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzh_);
                    bool jzzzzzzzzzzzzj_ = jzzzzzzzzzzzzi_ is CqlDateTime;

                    return jzzzzzzzzzzzzj_;
                };
                bool jzzzzzzzzzzzzf_()
                {
                    DataType jzzzzzzzzzzzzk_ = @this?.Effective;
                    object jzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzk_);
                    bool jzzzzzzzzzzzzm_ = jzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzm_;
                };
                bool jzzzzzzzzzzzzg_()
                {
                    DataType jzzzzzzzzzzzzn_ = @this?.Effective;
                    object jzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzn_);
                    bool jzzzzzzzzzzzzp_ = jzzzzzzzzzzzzo_ is CqlDateTime;

                    return jzzzzzzzzzzzzp_;
                };
                if (jzzzzzzzzzzzze_())
                {
                    DataType jzzzzzzzzzzzzq_ = @this?.Effective;
                    object jzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzq_);

                    return (jzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzf_())
                {
                    DataType jzzzzzzzzzzzzs_ = @this?.Effective;
                    object jzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzs_);

                    return (jzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzg_())
                {
                    DataType jzzzzzzzzzzzzu_ = @this?.Effective;
                    object jzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzu_);

                    return (jzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzc_());

            return jzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzi_, hzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzk_);
        DataType hzzzzzzzzzzzzm_ = hzzzzzzzzzzzzl_?.Value;
        object hzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzn_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzw_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzx_ = this.Encounter_with_Singleton_Delivery(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzy_ = context.Operators.Intersect<Encounter>(jzzzzzzzzzzzzw_, jzzzzzzzzzzzzx_);
        bool? jzzzzzzzzzzzzz_(Encounter SingletonEncounterGE37Weeks)
        {
            int? kzzzzzzzzzzzzb_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzzzzzzzc_ = context.Operators.Equal(kzzzzzzzzzzzzb_, 1);
            int? kzzzzzzzzzzzzd_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzd_, 0);
            bool? kzzzzzzzzzzzzf_ = context.Operators.Or(kzzzzzzzzzzzzc_, kzzzzzzzzzzzze_);
            int? kzzzzzzzzzzzzg_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzzzzzzzh_ = context.Operators.Equal(kzzzzzzzzzzzzg_, 0);
            int? kzzzzzzzzzzzzi_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzzzzzzzj_ = context.Operators.Equal(kzzzzzzzzzzzzi_, 0);
            bool? kzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzh_, kzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzl_ = context.Operators.Or(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzy_, jzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzm_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? kzzzzzzzzzzzzn_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            object kzzzzzzzzzzzzp_()
            {
                bool kzzzzzzzzzzzzz_()
                {
                    CqlValueSet lzzzzzzzzzzzzc_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> lzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? lzzzzzzzzzzzze_(Observation AbnormalPresentation)
                    {
                        object lzzzzzzzzzzzzm_()
                        {
                            bool lzzzzzzzzzzzzx_()
                            {
                                DataType mzzzzzzzzzzzza_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzza_);
                                bool mzzzzzzzzzzzzc_ = mzzzzzzzzzzzzb_ is CqlDateTime;

                                return mzzzzzzzzzzzzc_;
                            };
                            bool lzzzzzzzzzzzzy_()
                            {
                                DataType mzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzd_);
                                bool mzzzzzzzzzzzzf_ = mzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzf_;
                            };
                            bool lzzzzzzzzzzzzz_()
                            {
                                DataType mzzzzzzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzg_);
                                bool mzzzzzzzzzzzzi_ = mzzzzzzzzzzzzh_ is CqlDateTime;

                                return mzzzzzzzzzzzzi_;
                            };
                            if (lzzzzzzzzzzzzx_())
                            {
                                DataType mzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzj_);

                                return (mzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzy_())
                            {
                                DataType mzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzl_);

                                return (mzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzz_())
                            {
                                DataType mzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzn_);

                                return (mzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzm_());
                        CqlDateTime lzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? lzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzn_, lzzzzzzzzzzzzo_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzq_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzr_ = lzzzzzzzzzzzzq_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzr_);
                        string lzzzzzzzzzzzzt_ = context.Operators.Convert<string>(lzzzzzzzzzzzzs_);
                        string[] lzzzzzzzzzzzzu_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzv_ = context.Operators.In<string>(lzzzzzzzzzzzzt_, lzzzzzzzzzzzzu_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzp_, lzzzzzzzzzzzzv_);

                        return lzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzd_, lzzzzzzzzzzzze_);
                    object lzzzzzzzzzzzzg_(Observation @this)
                    {
                        object mzzzzzzzzzzzzp_()
                        {
                            bool mzzzzzzzzzzzzr_()
                            {
                                DataType mzzzzzzzzzzzzu_ = @this?.Effective;
                                object mzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzu_);
                                bool mzzzzzzzzzzzzw_ = mzzzzzzzzzzzzv_ is CqlDateTime;

                                return mzzzzzzzzzzzzw_;
                            };
                            bool mzzzzzzzzzzzzs_()
                            {
                                DataType mzzzzzzzzzzzzx_ = @this?.Effective;
                                object mzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzx_);
                                bool mzzzzzzzzzzzzz_ = mzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzz_;
                            };
                            bool mzzzzzzzzzzzzt_()
                            {
                                DataType nzzzzzzzzzzzza_ = @this?.Effective;
                                object nzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzza_);
                                bool nzzzzzzzzzzzzc_ = nzzzzzzzzzzzzb_ is CqlDateTime;

                                return nzzzzzzzzzzzzc_;
                            };
                            if (mzzzzzzzzzzzzr_())
                            {
                                DataType nzzzzzzzzzzzzd_ = @this?.Effective;
                                object nzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzd_);

                                return (nzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzs_())
                            {
                                DataType nzzzzzzzzzzzzf_ = @this?.Effective;
                                object nzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzf_);

                                return (nzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzt_())
                            {
                                DataType nzzzzzzzzzzzzh_ = @this?.Effective;
                                object nzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzh_);

                                return (nzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzp_());

                        return mzzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzf_, lzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzh_);
                    DataType lzzzzzzzzzzzzj_ = lzzzzzzzzzzzzi_?.Effective;
                    object lzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzj_);
                    bool lzzzzzzzzzzzzl_ = lzzzzzzzzzzzzk_ is CqlDateTime;

                    return lzzzzzzzzzzzzl_;
                };
                bool lzzzzzzzzzzzza_()
                {
                    CqlValueSet nzzzzzzzzzzzzj_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> nzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nzzzzzzzzzzzzl_(Observation AbnormalPresentation)
                    {
                        object nzzzzzzzzzzzzt_()
                        {
                            bool ozzzzzzzzzzzze_()
                            {
                                DataType ozzzzzzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzh_);
                                bool ozzzzzzzzzzzzj_ = ozzzzzzzzzzzzi_ is CqlDateTime;

                                return ozzzzzzzzzzzzj_;
                            };
                            bool ozzzzzzzzzzzzf_()
                            {
                                DataType ozzzzzzzzzzzzk_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzk_);
                                bool ozzzzzzzzzzzzm_ = ozzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzm_;
                            };
                            bool ozzzzzzzzzzzzg_()
                            {
                                DataType ozzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzn_);
                                bool ozzzzzzzzzzzzp_ = ozzzzzzzzzzzzo_ is CqlDateTime;

                                return ozzzzzzzzzzzzp_;
                            };
                            if (ozzzzzzzzzzzze_())
                            {
                                DataType ozzzzzzzzzzzzq_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzq_);

                                return (ozzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzf_())
                            {
                                DataType ozzzzzzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzs_);

                                return (ozzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzg_())
                            {
                                DataType ozzzzzzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzu_);

                                return (ozzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzt_());
                        CqlDateTime nzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? nzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzv_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzx_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzy_ = nzzzzzzzzzzzzx_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzy_);
                        string ozzzzzzzzzzzza_ = context.Operators.Convert<string>(nzzzzzzzzzzzzz_);
                        string[] ozzzzzzzzzzzzb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ozzzzzzzzzzzzc_ = context.Operators.In<string>(ozzzzzzzzzzzza_, ozzzzzzzzzzzzb_ as IEnumerable<string>);
                        bool? ozzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzw_, ozzzzzzzzzzzzc_);

                        return ozzzzzzzzzzzzd_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzl_);
                    object nzzzzzzzzzzzzn_(Observation @this)
                    {
                        object ozzzzzzzzzzzzw_()
                        {
                            bool ozzzzzzzzzzzzy_()
                            {
                                DataType pzzzzzzzzzzzzb_ = @this?.Effective;
                                object pzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzb_);
                                bool pzzzzzzzzzzzzd_ = pzzzzzzzzzzzzc_ is CqlDateTime;

                                return pzzzzzzzzzzzzd_;
                            };
                            bool ozzzzzzzzzzzzz_()
                            {
                                DataType pzzzzzzzzzzzze_ = @this?.Effective;
                                object pzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzze_);
                                bool pzzzzzzzzzzzzg_ = pzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzg_;
                            };
                            bool pzzzzzzzzzzzza_()
                            {
                                DataType pzzzzzzzzzzzzh_ = @this?.Effective;
                                object pzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzh_);
                                bool pzzzzzzzzzzzzj_ = pzzzzzzzzzzzzi_ is CqlDateTime;

                                return pzzzzzzzzzzzzj_;
                            };
                            if (ozzzzzzzzzzzzy_())
                            {
                                DataType pzzzzzzzzzzzzk_ = @this?.Effective;
                                object pzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzk_);

                                return (pzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzz_())
                            {
                                DataType pzzzzzzzzzzzzm_ = @this?.Effective;
                                object pzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzm_);

                                return (pzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pzzzzzzzzzzzza_())
                            {
                                DataType pzzzzzzzzzzzzo_ = @this?.Effective;
                                object pzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzo_);

                                return (pzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzw_());

                        return ozzzzzzzzzzzzx_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzm_, nzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzo_);
                    DataType nzzzzzzzzzzzzq_ = nzzzzzzzzzzzzp_?.Effective;
                    object nzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzq_);
                    bool nzzzzzzzzzzzzs_ = nzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzs_;
                };
                bool lzzzzzzzzzzzzb_()
                {
                    CqlValueSet pzzzzzzzzzzzzq_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> pzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzzzzzzs_(Observation AbnormalPresentation)
                    {
                        object qzzzzzzzzzzzza_()
                        {
                            bool qzzzzzzzzzzzzl_()
                            {
                                DataType qzzzzzzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzo_);
                                bool qzzzzzzzzzzzzq_ = qzzzzzzzzzzzzp_ is CqlDateTime;

                                return qzzzzzzzzzzzzq_;
                            };
                            bool qzzzzzzzzzzzzm_()
                            {
                                DataType qzzzzzzzzzzzzr_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzr_);
                                bool qzzzzzzzzzzzzt_ = qzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzt_;
                            };
                            bool qzzzzzzzzzzzzn_()
                            {
                                DataType qzzzzzzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzu_);
                                bool qzzzzzzzzzzzzw_ = qzzzzzzzzzzzzv_ is CqlDateTime;

                                return qzzzzzzzzzzzzw_;
                            };
                            if (qzzzzzzzzzzzzl_())
                            {
                                DataType qzzzzzzzzzzzzx_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzx_);

                                return (qzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzm_())
                            {
                                DataType qzzzzzzzzzzzzz_ = AbnormalPresentation?.Effective;
                                object rzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzz_);

                                return (rzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzn_())
                            {
                                DataType rzzzzzzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object rzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzb_);

                                return (rzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzza_());
                        CqlDateTime qzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? qzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzb_, qzzzzzzzzzzzzc_, default);
                        Code<ObservationStatus> qzzzzzzzzzzzze_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? qzzzzzzzzzzzzf_ = qzzzzzzzzzzzze_?.Value;
                        Code<ObservationStatus> qzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzf_);
                        string qzzzzzzzzzzzzh_ = context.Operators.Convert<string>(qzzzzzzzzzzzzg_);
                        string[] qzzzzzzzzzzzzi_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? qzzzzzzzzzzzzj_ = context.Operators.In<string>(qzzzzzzzzzzzzh_, qzzzzzzzzzzzzi_ as IEnumerable<string>);
                        bool? qzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzd_, qzzzzzzzzzzzzj_);

                        return qzzzzzzzzzzzzk_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzr_, pzzzzzzzzzzzzs_);
                    object pzzzzzzzzzzzzu_(Observation @this)
                    {
                        object rzzzzzzzzzzzzd_()
                        {
                            bool rzzzzzzzzzzzzf_()
                            {
                                DataType rzzzzzzzzzzzzi_ = @this?.Effective;
                                object rzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzi_);
                                bool rzzzzzzzzzzzzk_ = rzzzzzzzzzzzzj_ is CqlDateTime;

                                return rzzzzzzzzzzzzk_;
                            };
                            bool rzzzzzzzzzzzzg_()
                            {
                                DataType rzzzzzzzzzzzzl_ = @this?.Effective;
                                object rzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzl_);
                                bool rzzzzzzzzzzzzn_ = rzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzn_;
                            };
                            bool rzzzzzzzzzzzzh_()
                            {
                                DataType rzzzzzzzzzzzzo_ = @this?.Effective;
                                object rzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzo_);
                                bool rzzzzzzzzzzzzq_ = rzzzzzzzzzzzzp_ is CqlDateTime;

                                return rzzzzzzzzzzzzq_;
                            };
                            if (rzzzzzzzzzzzzf_())
                            {
                                DataType rzzzzzzzzzzzzr_ = @this?.Effective;
                                object rzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzr_);

                                return (rzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzg_())
                            {
                                DataType rzzzzzzzzzzzzt_ = @this?.Effective;
                                object rzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzt_);

                                return (rzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzh_())
                            {
                                DataType rzzzzzzzzzzzzv_ = @this?.Effective;
                                object rzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzv_);

                                return (rzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzd_());

                        return rzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzt_, pzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzv_);
                    DataType pzzzzzzzzzzzzx_ = pzzzzzzzzzzzzw_?.Effective;
                    object pzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzx_);
                    bool pzzzzzzzzzzzzz_ = pzzzzzzzzzzzzy_ is CqlDateTime;

                    return pzzzzzzzzzzzzz_;
                };
                if (kzzzzzzzzzzzzz_())
                {
                    CqlValueSet rzzzzzzzzzzzzx_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzz_(Observation AbnormalPresentation)
                    {
                        object szzzzzzzzzzzzg_()
                        {
                            bool szzzzzzzzzzzzr_()
                            {
                                DataType szzzzzzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzu_);
                                bool szzzzzzzzzzzzw_ = szzzzzzzzzzzzv_ is CqlDateTime;

                                return szzzzzzzzzzzzw_;
                            };
                            bool szzzzzzzzzzzzs_()
                            {
                                DataType szzzzzzzzzzzzx_ = AbnormalPresentation?.Effective;
                                object szzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzx_);
                                bool szzzzzzzzzzzzz_ = szzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzzzzzzz_;
                            };
                            bool szzzzzzzzzzzzt_()
                            {
                                DataType tzzzzzzzzzzzza_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzza_);
                                bool tzzzzzzzzzzzzc_ = tzzzzzzzzzzzzb_ is CqlDateTime;

                                return tzzzzzzzzzzzzc_;
                            };
                            if (szzzzzzzzzzzzr_())
                            {
                                DataType tzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzd_);

                                return (tzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzs_())
                            {
                                DataType tzzzzzzzzzzzzf_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzf_);

                                return (tzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzt_())
                            {
                                DataType tzzzzzzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzh_);

                                return (tzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzg_());
                        CqlDateTime szzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? szzzzzzzzzzzzj_ = context.Operators.SameOrBefore(szzzzzzzzzzzzh_, szzzzzzzzzzzzi_, default);
                        Code<ObservationStatus> szzzzzzzzzzzzk_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? szzzzzzzzzzzzl_ = szzzzzzzzzzzzk_?.Value;
                        Code<ObservationStatus> szzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzl_);
                        string szzzzzzzzzzzzn_ = context.Operators.Convert<string>(szzzzzzzzzzzzm_);
                        string[] szzzzzzzzzzzzo_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzzzzzzp_ = context.Operators.In<string>(szzzzzzzzzzzzn_, szzzzzzzzzzzzo_ as IEnumerable<string>);
                        bool? szzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzj_, szzzzzzzzzzzzp_);

                        return szzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzza_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzy_, rzzzzzzzzzzzzz_);
                    object szzzzzzzzzzzzb_(Observation @this)
                    {
                        object tzzzzzzzzzzzzj_()
                        {
                            bool tzzzzzzzzzzzzl_()
                            {
                                DataType tzzzzzzzzzzzzo_ = @this?.Effective;
                                object tzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzo_);
                                bool tzzzzzzzzzzzzq_ = tzzzzzzzzzzzzp_ is CqlDateTime;

                                return tzzzzzzzzzzzzq_;
                            };
                            bool tzzzzzzzzzzzzm_()
                            {
                                DataType tzzzzzzzzzzzzr_ = @this?.Effective;
                                object tzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzr_);
                                bool tzzzzzzzzzzzzt_ = tzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzt_;
                            };
                            bool tzzzzzzzzzzzzn_()
                            {
                                DataType tzzzzzzzzzzzzu_ = @this?.Effective;
                                object tzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzu_);
                                bool tzzzzzzzzzzzzw_ = tzzzzzzzzzzzzv_ is CqlDateTime;

                                return tzzzzzzzzzzzzw_;
                            };
                            if (tzzzzzzzzzzzzl_())
                            {
                                DataType tzzzzzzzzzzzzx_ = @this?.Effective;
                                object tzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzx_);

                                return (tzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzm_())
                            {
                                DataType tzzzzzzzzzzzzz_ = @this?.Effective;
                                object uzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzz_);

                                return (uzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzn_())
                            {
                                DataType uzzzzzzzzzzzzb_ = @this?.Effective;
                                object uzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzb_);

                                return (uzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzj_());

                        return tzzzzzzzzzzzzk_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzza_, szzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation szzzzzzzzzzzzd_ = context.Operators.Last<Observation>(szzzzzzzzzzzzc_);
                    DataType szzzzzzzzzzzze_ = szzzzzzzzzzzzd_?.Effective;
                    object szzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzze_);

                    return (szzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzza_())
                {
                    CqlValueSet uzzzzzzzzzzzzd_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> uzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? uzzzzzzzzzzzzf_(Observation AbnormalPresentation)
                    {
                        object uzzzzzzzzzzzzm_()
                        {
                            bool uzzzzzzzzzzzzx_()
                            {
                                DataType vzzzzzzzzzzzza_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzza_);
                                bool vzzzzzzzzzzzzc_ = vzzzzzzzzzzzzb_ is CqlDateTime;

                                return vzzzzzzzzzzzzc_;
                            };
                            bool uzzzzzzzzzzzzy_()
                            {
                                DataType vzzzzzzzzzzzzd_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzd_);
                                bool vzzzzzzzzzzzzf_ = vzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzf_;
                            };
                            bool uzzzzzzzzzzzzz_()
                            {
                                DataType vzzzzzzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzg_);
                                bool vzzzzzzzzzzzzi_ = vzzzzzzzzzzzzh_ is CqlDateTime;

                                return vzzzzzzzzzzzzi_;
                            };
                            if (uzzzzzzzzzzzzx_())
                            {
                                DataType vzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzj_);

                                return (vzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzy_())
                            {
                                DataType vzzzzzzzzzzzzl_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzl_);

                                return (vzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzz_())
                            {
                                DataType vzzzzzzzzzzzzn_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzn_);

                                return (vzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzm_());
                        CqlDateTime uzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? uzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzn_, uzzzzzzzzzzzzo_, default);
                        Code<ObservationStatus> uzzzzzzzzzzzzq_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? uzzzzzzzzzzzzr_ = uzzzzzzzzzzzzq_?.Value;
                        Code<ObservationStatus> uzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzr_);
                        string uzzzzzzzzzzzzt_ = context.Operators.Convert<string>(uzzzzzzzzzzzzs_);
                        string[] uzzzzzzzzzzzzu_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? uzzzzzzzzzzzzv_ = context.Operators.In<string>(uzzzzzzzzzzzzt_, uzzzzzzzzzzzzu_ as IEnumerable<string>);
                        bool? uzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzv_);

                        return uzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(uzzzzzzzzzzzze_, uzzzzzzzzzzzzf_);
                    object uzzzzzzzzzzzzh_(Observation @this)
                    {
                        object vzzzzzzzzzzzzp_()
                        {
                            bool vzzzzzzzzzzzzr_()
                            {
                                DataType vzzzzzzzzzzzzu_ = @this?.Effective;
                                object vzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzu_);
                                bool vzzzzzzzzzzzzw_ = vzzzzzzzzzzzzv_ is CqlDateTime;

                                return vzzzzzzzzzzzzw_;
                            };
                            bool vzzzzzzzzzzzzs_()
                            {
                                DataType vzzzzzzzzzzzzx_ = @this?.Effective;
                                object vzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzx_);
                                bool vzzzzzzzzzzzzz_ = vzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzz_;
                            };
                            bool vzzzzzzzzzzzzt_()
                            {
                                DataType wzzzzzzzzzzzza_ = @this?.Effective;
                                object wzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzza_);
                                bool wzzzzzzzzzzzzc_ = wzzzzzzzzzzzzb_ is CqlDateTime;

                                return wzzzzzzzzzzzzc_;
                            };
                            if (vzzzzzzzzzzzzr_())
                            {
                                DataType wzzzzzzzzzzzzd_ = @this?.Effective;
                                object wzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzd_);

                                return (wzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzs_())
                            {
                                DataType wzzzzzzzzzzzzf_ = @this?.Effective;
                                object wzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzf_);

                                return (wzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzt_())
                            {
                                DataType wzzzzzzzzzzzzh_ = @this?.Effective;
                                object wzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzh_);

                                return (wzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime vzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzp_());

                        return vzzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzg_, uzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation uzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzi_);
                    DataType uzzzzzzzzzzzzk_ = uzzzzzzzzzzzzj_?.Effective;
                    object uzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzk_);

                    return (uzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzb_())
                {
                    CqlValueSet wzzzzzzzzzzzzj_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> wzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? wzzzzzzzzzzzzl_(Observation AbnormalPresentation)
                    {
                        object wzzzzzzzzzzzzs_()
                        {
                            bool xzzzzzzzzzzzzd_()
                            {
                                DataType xzzzzzzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzg_);
                                bool xzzzzzzzzzzzzi_ = xzzzzzzzzzzzzh_ is CqlDateTime;

                                return xzzzzzzzzzzzzi_;
                            };
                            bool xzzzzzzzzzzzze_()
                            {
                                DataType xzzzzzzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzj_);
                                bool xzzzzzzzzzzzzl_ = xzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                                return xzzzzzzzzzzzzl_;
                            };
                            bool xzzzzzzzzzzzzf_()
                            {
                                DataType xzzzzzzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzm_);
                                bool xzzzzzzzzzzzzo_ = xzzzzzzzzzzzzn_ is CqlDateTime;

                                return xzzzzzzzzzzzzo_;
                            };
                            if (xzzzzzzzzzzzzd_())
                            {
                                DataType xzzzzzzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzp_);

                                return (xzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else if (xzzzzzzzzzzzze_())
                            {
                                DataType xzzzzzzzzzzzzr_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzr_);

                                return (xzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzzzzzzf_())
                            {
                                DataType xzzzzzzzzzzzzt_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzt_);

                                return (xzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzs_());
                        CqlDateTime wzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? wzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzt_, wzzzzzzzzzzzzu_, default);
                        Code<ObservationStatus> wzzzzzzzzzzzzw_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? wzzzzzzzzzzzzx_ = wzzzzzzzzzzzzw_?.Value;
                        Code<ObservationStatus> wzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzx_);
                        string wzzzzzzzzzzzzz_ = context.Operators.Convert<string>(wzzzzzzzzzzzzy_);
                        string[] xzzzzzzzzzzzza_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? xzzzzzzzzzzzzb_ = context.Operators.In<string>(wzzzzzzzzzzzzz_, xzzzzzzzzzzzza_ as IEnumerable<string>);
                        bool? xzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzv_, xzzzzzzzzzzzzb_);

                        return xzzzzzzzzzzzzc_;
                    };
                    IEnumerable<Observation> wzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzk_, wzzzzzzzzzzzzl_);
                    object wzzzzzzzzzzzzn_(Observation @this)
                    {
                        object xzzzzzzzzzzzzv_()
                        {
                            bool xzzzzzzzzzzzzx_()
                            {
                                DataType yzzzzzzzzzzzza_ = @this?.Effective;
                                object yzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzza_);
                                bool yzzzzzzzzzzzzc_ = yzzzzzzzzzzzzb_ is CqlDateTime;

                                return yzzzzzzzzzzzzc_;
                            };
                            bool xzzzzzzzzzzzzy_()
                            {
                                DataType yzzzzzzzzzzzzd_ = @this?.Effective;
                                object yzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzd_);
                                bool yzzzzzzzzzzzzf_ = yzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                                return yzzzzzzzzzzzzf_;
                            };
                            bool xzzzzzzzzzzzzz_()
                            {
                                DataType yzzzzzzzzzzzzg_ = @this?.Effective;
                                object yzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzg_);
                                bool yzzzzzzzzzzzzi_ = yzzzzzzzzzzzzh_ is CqlDateTime;

                                return yzzzzzzzzzzzzi_;
                            };
                            if (xzzzzzzzzzzzzx_())
                            {
                                DataType yzzzzzzzzzzzzj_ = @this?.Effective;
                                object yzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzj_);

                                return (yzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else if (xzzzzzzzzzzzzy_())
                            {
                                DataType yzzzzzzzzzzzzl_ = @this?.Effective;
                                object yzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzl_);

                                return (yzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzzzzzzz_())
                            {
                                DataType yzzzzzzzzzzzzn_ = @this?.Effective;
                                object yzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzn_);

                                return (yzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime xzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzv_());

                        return xzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Observation> wzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzm_, wzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation wzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(wzzzzzzzzzzzzo_);
                    DataType wzzzzzzzzzzzzq_ = wzzzzzzzzzzzzp_?.Effective;
                    object wzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzq_);

                    return (wzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime kzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzp_());
            Period kzzzzzzzzzzzzr_ = ThirtysevenWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzq_, kzzzzzzzzzzzzs_, default);
            IEnumerable<Condition> kzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? kzzzzzzzzzzzzv_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzzzzzzp_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzp_);
                CqlValueSet yzzzzzzzzzzzzr_ = this.Abnormal_Presentation(context);
                bool? yzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzq_, yzzzzzzzzzzzzr_);

                return yzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> kzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzu_, kzzzzzzzzzzzzv_);
            bool? kzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzy_ = context.Operators.Or(kzzzzzzzzzzzzt_, kzzzzzzzzzzzzx_);

            return kzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzt_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? yzzzzzzzzzzzzu_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            IEnumerable<Condition> yzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? yzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept zzzzzzzzzzzzza_ = EncounterDiagnosis?.Code;
                CqlConcept zzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzza_);
                CqlValueSet zzzzzzzzzzzzzc_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? zzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzb_, zzzzzzzzzzzzzc_);
                CqlConcept zzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzza_);
                CqlValueSet zzzzzzzzzzzzzg_ = this.Genital_Herpes(context);
                bool? zzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzf_, zzzzzzzzzzzzzg_);
                bool? zzzzzzzzzzzzzi_ = context.Operators.Or(zzzzzzzzzzzzzd_, zzzzzzzzzzzzzh_);

                return zzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzw_, yzzzzzzzzzzzzx_);
            bool? yzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzy_);

            return yzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzt_, yzzzzzzzzzzzzu_);

        return yzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzj_ = this.Encounter_with_Abnormal_Presentation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzk_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzj_, zzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzm_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return zzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzn_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);

        return zzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return zzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzp_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzq_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            CqlValueSet zzzzzzzzzzzzzs_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> zzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? zzzzzzzzzzzzzu_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtysevenWeeksPlusEncounter);
                DataType zzzzzzzzzzzzzz_ = CSection?.Performed;
                object azzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzy_, azzzzzzzzzzzzzb_, default);
                Code<EventStatus> azzzzzzzzzzzzzd_ = CSection?.StatusElement;
                EventStatus? azzzzzzzzzzzzze_ = azzzzzzzzzzzzzd_?.Value;
                string azzzzzzzzzzzzzf_ = context.Operators.Convert<string>(azzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzg_ = context.Operators.Equal(azzzzzzzzzzzzzf_, "completed");
                bool? azzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzc_, azzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> zzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzt_, zzzzzzzzzzzzzu_);
            Encounter zzzzzzzzzzzzzw_(Procedure CSection) =>
                ThirtysevenWeeksPlusEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Encounter>(zzzzzzzzzzzzzv_, zzzzzzzzzzzzzw_);

            return zzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzp_, zzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzi_ = this.Delivery_Encounter_with_Cesarean_Birth(context);

        return azzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> azzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return azzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}
