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
        CqlDateTime wzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzb_ = context.Operators.Interval(wzzzzzzz_, xzzzzzza_, true, true);
        object xzzzzzzc_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", xzzzzzzb_);

        return (CqlInterval<CqlDateTime>)xzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzze_ = context.Operators.SingletonFrom<Patient>(xzzzzzzd_);

        return xzzzzzze_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzf_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzg_(Encounter DeliveryEncounter)
        {
            int? xzzzzzzi_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? xzzzzzzj_ = context.Operators.GreaterOrEqual(xzzzzzzi_, 37);

            return xzzzzzzj_;
        };
        IEnumerable<Encounter> xzzzzzzh_ = context.Operators.Where<Encounter>(xzzzzzzf_, xzzzzzzg_);

        return xzzzzzzh_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzk_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzl_(Encounter DeliveryEncounter)
        {
            int? xzzzzzzn_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity xzzzzzzo_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity xzzzzzzp_ = context.Operators.Quantity(37m, "weeks");
            bool? xzzzzzzq_ = context.Operators.GreaterOrEqual(xzzzzzzo_, xzzzzzzp_);
            bool? xzzzzzzr_ = context.Operators.And((bool?)(xzzzzzzn_ is null), xzzzzzzq_);

            return xzzzzzzr_;
        };
        IEnumerable<Encounter> xzzzzzzm_ = context.Operators.Where<Encounter>(xzzzzzzk_, xzzzzzzl_);

        return xzzzzzzm_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzs_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? xzzzzzzt_(Encounter DeliveryEncounter)
        {
            int? xzzzzzzv_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity xzzzzzzw_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? xzzzzzzx_ = context.Operators.And((bool?)(xzzzzzzv_ is null), (bool?)(xzzzzzzw_ is null));
            IEnumerable<Condition> xzzzzzzy_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? xzzzzzzz_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzd_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzd_);
                CqlValueSet yzzzzzzf_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? yzzzzzzg_ = context.Operators.ConceptInValueSet(yzzzzzze_, yzzzzzzf_);

                return yzzzzzzg_;
            };
            IEnumerable<Condition> yzzzzzza_ = context.Operators.Where<Condition>(xzzzzzzy_, xzzzzzzz_);
            bool? yzzzzzzb_ = context.Operators.Exists<Condition>(yzzzzzza_);
            bool? yzzzzzzc_ = context.Operators.And(xzzzzzzx_, yzzzzzzb_);

            return yzzzzzzc_;
        };
        IEnumerable<Encounter> xzzzzzzu_ = context.Operators.Where<Encounter>(xzzzzzzs_, xzzzzzzt_);

        return xzzzzzzu_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzh_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> yzzzzzzi_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> yzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzh_, yzzzzzzi_);
        IEnumerable<Encounter> yzzzzzzk_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> yzzzzzzl_ = context.Operators.Union<Encounter>(yzzzzzzj_, yzzzzzzk_);

        return yzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_with_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzm_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? yzzzzzzn_(Encounter DeliveryEncounter)
        {
            IEnumerable<Condition> yzzzzzzp_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? yzzzzzzq_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzt_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzt_);
                CqlValueSet yzzzzzzv_ = this.Delivery_of_Singleton(context);
                bool? yzzzzzzw_ = context.Operators.ConceptInValueSet(yzzzzzzu_, yzzzzzzv_);

                return yzzzzzzw_;
            };
            IEnumerable<Condition> yzzzzzzr_ = context.Operators.Where<Condition>(yzzzzzzp_, yzzzzzzq_);
            bool? yzzzzzzs_ = context.Operators.Exists<Condition>(yzzzzzzr_);

            return yzzzzzzs_;
        };
        IEnumerable<Encounter> yzzzzzzo_ = context.Operators.Where<Encounter>(yzzzzzzm_, yzzzzzzn_);

        return yzzzzzzo_;
    }


    [CqlExpressionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode yzzzzzzx_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> yzzzzzzy_ = context.Operators.ToList<CqlCode>(yzzzzzzx_);
        IEnumerable<Observation> yzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? zzzzzzza_(Observation Gravida)
        {
            DataType zzzzzzzh_ = Gravida?.Value;
            object zzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzh_);
            bool? zzzzzzzj_ = context.Operators.Not((bool?)(zzzzzzzi_ is null));
            Code<ObservationStatus> zzzzzzzk_ = Gravida?.StatusElement;
            ObservationStatus? zzzzzzzl_ = zzzzzzzk_?.Value;
            Code<ObservationStatus> zzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzl_);
            string zzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzm_);
            string[] zzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzp_ = context.Operators.In<string>(zzzzzzzn_, zzzzzzzo_ as IEnumerable<string>);
            bool? zzzzzzzq_ = context.Operators.And(zzzzzzzj_, zzzzzzzp_);
            object zzzzzzzr_()
            {
                bool azzzzzzzd_()
                {
                    DataType azzzzzzzg_ = Gravida?.Effective;
                    object azzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzg_);
                    bool azzzzzzzi_ = azzzzzzzh_ is CqlDateTime;

                    return azzzzzzzi_;
                };
                bool azzzzzzze_()
                {
                    DataType azzzzzzzj_ = Gravida?.Effective;
                    object azzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzj_);
                    bool azzzzzzzl_ = azzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzl_;
                };
                bool azzzzzzzf_()
                {
                    DataType azzzzzzzm_ = Gravida?.Effective;
                    object azzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzm_);
                    bool azzzzzzzo_ = azzzzzzzn_ is CqlDateTime;

                    return azzzzzzzo_;
                };
                if (azzzzzzzd_())
                {
                    DataType azzzzzzzp_ = Gravida?.Effective;
                    object azzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzp_);

                    return (azzzzzzzq_ as CqlDateTime) as object;
                }
                else if (azzzzzzze_())
                {
                    DataType azzzzzzzr_ = Gravida?.Effective;
                    object azzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzr_);

                    return (azzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzf_())
                {
                    DataType azzzzzzzt_ = Gravida?.Effective;
                    object azzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzt_);

                    return (azzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzr_());
            CqlDateTime zzzzzzzt_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity zzzzzzzu_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime zzzzzzzv_ = context.Operators.Subtract(zzzzzzzt_, zzzzzzzu_);
            CqlInterval<CqlDateTime> zzzzzzzx_ = context.Operators.Interval(zzzzzzzv_, zzzzzzzt_, true, false);
            bool? zzzzzzzy_ = context.Operators.In<CqlDateTime>(zzzzzzzs_, zzzzzzzx_, default);
            bool? azzzzzzza_ = context.Operators.Not((bool?)(zzzzzzzt_ is null));
            bool? azzzzzzzb_ = context.Operators.And(zzzzzzzy_, azzzzzzza_);
            bool? azzzzzzzc_ = context.Operators.And(zzzzzzzq_, azzzzzzzb_);

            return azzzzzzzc_;
        };
        IEnumerable<Observation> zzzzzzzb_ = context.Operators.Where<Observation>(yzzzzzzz_, zzzzzzza_);
        object zzzzzzzc_(Observation @this)
        {
            object azzzzzzzv_()
            {
                bool azzzzzzzx_()
                {
                    DataType bzzzzzzza_ = @this?.Effective;
                    object bzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzza_);
                    bool bzzzzzzzc_ = bzzzzzzzb_ is CqlDateTime;

                    return bzzzzzzzc_;
                };
                bool azzzzzzzy_()
                {
                    DataType bzzzzzzzd_ = @this?.Effective;
                    object bzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzd_);
                    bool bzzzzzzzf_ = bzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzf_;
                };
                bool azzzzzzzz_()
                {
                    DataType bzzzzzzzg_ = @this?.Effective;
                    object bzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzg_);
                    bool bzzzzzzzi_ = bzzzzzzzh_ is CqlDateTime;

                    return bzzzzzzzi_;
                };
                if (azzzzzzzx_())
                {
                    DataType bzzzzzzzj_ = @this?.Effective;
                    object bzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzj_);

                    return (bzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (azzzzzzzy_())
                {
                    DataType bzzzzzzzl_ = @this?.Effective;
                    object bzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzl_);

                    return (bzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzz_())
                {
                    DataType bzzzzzzzn_ = @this?.Effective;
                    object bzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzn_);

                    return (bzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime azzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzv_());

            return azzzzzzzw_;
        };
        IEnumerable<Observation> zzzzzzzd_ = context.Operators.SortBy<Observation>(zzzzzzzb_, zzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        Observation zzzzzzze_ = context.Operators.Last<Observation>(zzzzzzzd_);
        DataType zzzzzzzf_ = zzzzzzze_?.Value;
        object zzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzf_);

        return zzzzzzzg_ as int?;
    }


    [CqlExpressionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode bzzzzzzzp_ = this.____Parity(context);
        IEnumerable<CqlCode> bzzzzzzzq_ = context.Operators.ToList<CqlCode>(bzzzzzzzp_);
        IEnumerable<Observation> bzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? bzzzzzzzs_(Observation Parity)
        {
            object bzzzzzzzz_()
            {
                bool czzzzzzzv_()
                {
                    DataType czzzzzzzy_ = Parity?.Effective;
                    object czzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzy_);
                    bool dzzzzzzza_ = czzzzzzzz_ is CqlDateTime;

                    return dzzzzzzza_;
                };
                bool czzzzzzzw_()
                {
                    DataType dzzzzzzzb_ = Parity?.Effective;
                    object dzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzb_);
                    bool dzzzzzzzd_ = dzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzd_;
                };
                bool czzzzzzzx_()
                {
                    DataType dzzzzzzze_ = Parity?.Effective;
                    object dzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzze_);
                    bool dzzzzzzzg_ = dzzzzzzzf_ is CqlDateTime;

                    return dzzzzzzzg_;
                };
                if (czzzzzzzv_())
                {
                    DataType dzzzzzzzh_ = Parity?.Effective;
                    object dzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzh_);

                    return (dzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (czzzzzzzw_())
                {
                    DataType dzzzzzzzj_ = Parity?.Effective;
                    object dzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzj_);

                    return (dzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzx_())
                {
                    DataType dzzzzzzzl_ = Parity?.Effective;
                    object dzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzl_);

                    return (dzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzz_());
            CqlDateTime czzzzzzzb_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity czzzzzzzc_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime czzzzzzzd_ = context.Operators.Subtract(czzzzzzzb_, czzzzzzzc_);
            CqlInterval<CqlDateTime> czzzzzzzf_ = context.Operators.Interval(czzzzzzzd_, czzzzzzzb_, true, false);
            bool? czzzzzzzg_ = context.Operators.In<CqlDateTime>(czzzzzzza_, czzzzzzzf_, default);
            bool? czzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzb_ is null));
            bool? czzzzzzzj_ = context.Operators.And(czzzzzzzg_, czzzzzzzi_);
            Code<ObservationStatus> czzzzzzzk_ = Parity?.StatusElement;
            ObservationStatus? czzzzzzzl_ = czzzzzzzk_?.Value;
            Code<ObservationStatus> czzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzl_);
            string czzzzzzzn_ = context.Operators.Convert<string>(czzzzzzzm_);
            string[] czzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzp_ = context.Operators.In<string>(czzzzzzzn_, czzzzzzzo_ as IEnumerable<string>);
            bool? czzzzzzzq_ = context.Operators.And(czzzzzzzj_, czzzzzzzp_);
            DataType czzzzzzzr_ = Parity?.Value;
            object czzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzr_);
            bool? czzzzzzzt_ = context.Operators.Not((bool?)(czzzzzzzs_ is null));
            bool? czzzzzzzu_ = context.Operators.And(czzzzzzzq_, czzzzzzzt_);

            return czzzzzzzu_;
        };
        IEnumerable<Observation> bzzzzzzzt_ = context.Operators.Where<Observation>(bzzzzzzzr_, bzzzzzzzs_);
        object bzzzzzzzu_(Observation @this)
        {
            object dzzzzzzzn_()
            {
                bool dzzzzzzzp_()
                {
                    DataType dzzzzzzzs_ = @this?.Effective;
                    object dzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzs_);
                    bool dzzzzzzzu_ = dzzzzzzzt_ is CqlDateTime;

                    return dzzzzzzzu_;
                };
                bool dzzzzzzzq_()
                {
                    DataType dzzzzzzzv_ = @this?.Effective;
                    object dzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzv_);
                    bool dzzzzzzzx_ = dzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzx_;
                };
                bool dzzzzzzzr_()
                {
                    DataType dzzzzzzzy_ = @this?.Effective;
                    object dzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzy_);
                    bool ezzzzzzza_ = dzzzzzzzz_ is CqlDateTime;

                    return ezzzzzzza_;
                };
                if (dzzzzzzzp_())
                {
                    DataType ezzzzzzzb_ = @this?.Effective;
                    object ezzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzb_);

                    return (ezzzzzzzc_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzq_())
                {
                    DataType ezzzzzzzd_ = @this?.Effective;
                    object ezzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzd_);

                    return (ezzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzr_())
                {
                    DataType ezzzzzzzf_ = @this?.Effective;
                    object ezzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzf_);

                    return (ezzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzn_());

            return dzzzzzzzo_;
        };
        IEnumerable<Observation> bzzzzzzzv_ = context.Operators.SortBy<Observation>(bzzzzzzzt_, bzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzw_ = context.Operators.Last<Observation>(bzzzzzzzv_);
        DataType bzzzzzzzx_ = bzzzzzzzw_?.Value;
        object bzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzx_);

        return bzzzzzzzy_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode ezzzzzzzh_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> ezzzzzzzi_ = context.Operators.ToList<CqlCode>(ezzzzzzzh_);
        IEnumerable<Observation> ezzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzk_(Observation PretermBirth)
        {
            object ezzzzzzzr_()
            {
                bool fzzzzzzzn_()
                {
                    DataType fzzzzzzzq_ = PretermBirth?.Effective;
                    object fzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzq_);
                    bool fzzzzzzzs_ = fzzzzzzzr_ is CqlDateTime;

                    return fzzzzzzzs_;
                };
                bool fzzzzzzzo_()
                {
                    DataType fzzzzzzzt_ = PretermBirth?.Effective;
                    object fzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzt_);
                    bool fzzzzzzzv_ = fzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzv_;
                };
                bool fzzzzzzzp_()
                {
                    DataType fzzzzzzzw_ = PretermBirth?.Effective;
                    object fzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzw_);
                    bool fzzzzzzzy_ = fzzzzzzzx_ is CqlDateTime;

                    return fzzzzzzzy_;
                };
                if (fzzzzzzzn_())
                {
                    DataType fzzzzzzzz_ = PretermBirth?.Effective;
                    object gzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzz_);

                    return (gzzzzzzza_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzo_())
                {
                    DataType gzzzzzzzb_ = PretermBirth?.Effective;
                    object gzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzb_);

                    return (gzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzp_())
                {
                    DataType gzzzzzzzd_ = PretermBirth?.Effective;
                    object gzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzd_);

                    return (gzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzr_());
            CqlDateTime ezzzzzzzt_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity ezzzzzzzu_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime ezzzzzzzv_ = context.Operators.Subtract(ezzzzzzzt_, ezzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzx_ = context.Operators.Interval(ezzzzzzzv_, ezzzzzzzt_, true, false);
            bool? ezzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzs_, ezzzzzzzx_, default);
            bool? fzzzzzzza_ = context.Operators.Not((bool?)(ezzzzzzzt_ is null));
            bool? fzzzzzzzb_ = context.Operators.And(ezzzzzzzy_, fzzzzzzza_);
            Code<ObservationStatus> fzzzzzzzc_ = PretermBirth?.StatusElement;
            ObservationStatus? fzzzzzzzd_ = fzzzzzzzc_?.Value;
            Code<ObservationStatus> fzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzd_);
            string fzzzzzzzf_ = context.Operators.Convert<string>(fzzzzzzze_);
            string[] fzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzh_ = context.Operators.In<string>(fzzzzzzzf_, fzzzzzzzg_ as IEnumerable<string>);
            bool? fzzzzzzzi_ = context.Operators.And(fzzzzzzzb_, fzzzzzzzh_);
            DataType fzzzzzzzj_ = PretermBirth?.Value;
            object fzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzj_);
            bool? fzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzk_ is null));
            bool? fzzzzzzzm_ = context.Operators.And(fzzzzzzzi_, fzzzzzzzl_);

            return fzzzzzzzm_;
        };
        IEnumerable<Observation> ezzzzzzzl_ = context.Operators.Where<Observation>(ezzzzzzzj_, ezzzzzzzk_);
        object ezzzzzzzm_(Observation @this)
        {
            object gzzzzzzzf_()
            {
                bool gzzzzzzzh_()
                {
                    DataType gzzzzzzzk_ = @this?.Effective;
                    object gzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzk_);
                    bool gzzzzzzzm_ = gzzzzzzzl_ is CqlDateTime;

                    return gzzzzzzzm_;
                };
                bool gzzzzzzzi_()
                {
                    DataType gzzzzzzzn_ = @this?.Effective;
                    object gzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzn_);
                    bool gzzzzzzzp_ = gzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzp_;
                };
                bool gzzzzzzzj_()
                {
                    DataType gzzzzzzzq_ = @this?.Effective;
                    object gzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzq_);
                    bool gzzzzzzzs_ = gzzzzzzzr_ is CqlDateTime;

                    return gzzzzzzzs_;
                };
                if (gzzzzzzzh_())
                {
                    DataType gzzzzzzzt_ = @this?.Effective;
                    object gzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzt_);

                    return (gzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzi_())
                {
                    DataType gzzzzzzzv_ = @this?.Effective;
                    object gzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzv_);

                    return (gzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzj_())
                {
                    DataType gzzzzzzzx_ = @this?.Effective;
                    object gzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzx_);

                    return (gzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzf_());

            return gzzzzzzzg_;
        };
        IEnumerable<Observation> ezzzzzzzn_ = context.Operators.SortBy<Observation>(ezzzzzzzl_, ezzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzo_ = context.Operators.Last<Observation>(ezzzzzzzn_);
        DataType ezzzzzzzp_ = ezzzzzzzo_?.Value;
        object ezzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzp_);

        return ezzzzzzzq_ as int?;
    }


    [CqlExpressionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode gzzzzzzzz_ = this.____Births_term(context);
        IEnumerable<CqlCode> hzzzzzzza_ = context.Operators.ToList<CqlCode>(gzzzzzzzz_);
        IEnumerable<Observation> hzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzc_(Observation TermBirth)
        {
            object hzzzzzzzj_()
            {
                bool izzzzzzzf_()
                {
                    DataType izzzzzzzi_ = TermBirth?.Effective;
                    object izzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzi_);
                    bool izzzzzzzk_ = izzzzzzzj_ is CqlDateTime;

                    return izzzzzzzk_;
                };
                bool izzzzzzzg_()
                {
                    DataType izzzzzzzl_ = TermBirth?.Effective;
                    object izzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzl_);
                    bool izzzzzzzn_ = izzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzn_;
                };
                bool izzzzzzzh_()
                {
                    DataType izzzzzzzo_ = TermBirth?.Effective;
                    object izzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzo_);
                    bool izzzzzzzq_ = izzzzzzzp_ is CqlDateTime;

                    return izzzzzzzq_;
                };
                if (izzzzzzzf_())
                {
                    DataType izzzzzzzr_ = TermBirth?.Effective;
                    object izzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzr_);

                    return (izzzzzzzs_ as CqlDateTime) as object;
                }
                else if (izzzzzzzg_())
                {
                    DataType izzzzzzzt_ = TermBirth?.Effective;
                    object izzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzt_);

                    return (izzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzh_())
                {
                    DataType izzzzzzzv_ = TermBirth?.Effective;
                    object izzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzv_);

                    return (izzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzj_());
            CqlDateTime hzzzzzzzl_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity hzzzzzzzm_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime hzzzzzzzn_ = context.Operators.Subtract(hzzzzzzzl_, hzzzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzzzp_ = context.Operators.Interval(hzzzzzzzn_, hzzzzzzzl_, true, false);
            bool? hzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzk_, hzzzzzzzp_, default);
            bool? hzzzzzzzs_ = context.Operators.Not((bool?)(hzzzzzzzl_ is null));
            bool? hzzzzzzzt_ = context.Operators.And(hzzzzzzzq_, hzzzzzzzs_);
            Code<ObservationStatus> hzzzzzzzu_ = TermBirth?.StatusElement;
            ObservationStatus? hzzzzzzzv_ = hzzzzzzzu_?.Value;
            Code<ObservationStatus> hzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzv_);
            string hzzzzzzzx_ = context.Operators.Convert<string>(hzzzzzzzw_);
            string[] hzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzz_ = context.Operators.In<string>(hzzzzzzzx_, hzzzzzzzy_ as IEnumerable<string>);
            bool? izzzzzzza_ = context.Operators.And(hzzzzzzzt_, hzzzzzzzz_);
            DataType izzzzzzzb_ = TermBirth?.Value;
            object izzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzb_);
            bool? izzzzzzzd_ = context.Operators.Not((bool?)(izzzzzzzc_ is null));
            bool? izzzzzzze_ = context.Operators.And(izzzzzzza_, izzzzzzzd_);

            return izzzzzzze_;
        };
        IEnumerable<Observation> hzzzzzzzd_ = context.Operators.Where<Observation>(hzzzzzzzb_, hzzzzzzzc_);
        object hzzzzzzze_(Observation @this)
        {
            object izzzzzzzx_()
            {
                bool izzzzzzzz_()
                {
                    DataType jzzzzzzzc_ = @this?.Effective;
                    object jzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzc_);
                    bool jzzzzzzze_ = jzzzzzzzd_ is CqlDateTime;

                    return jzzzzzzze_;
                };
                bool jzzzzzzza_()
                {
                    DataType jzzzzzzzf_ = @this?.Effective;
                    object jzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzf_);
                    bool jzzzzzzzh_ = jzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzh_;
                };
                bool jzzzzzzzb_()
                {
                    DataType jzzzzzzzi_ = @this?.Effective;
                    object jzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzi_);
                    bool jzzzzzzzk_ = jzzzzzzzj_ is CqlDateTime;

                    return jzzzzzzzk_;
                };
                if (izzzzzzzz_())
                {
                    DataType jzzzzzzzl_ = @this?.Effective;
                    object jzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzl_);

                    return (jzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (jzzzzzzza_())
                {
                    DataType jzzzzzzzn_ = @this?.Effective;
                    object jzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzn_);

                    return (jzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzb_())
                {
                    DataType jzzzzzzzp_ = @this?.Effective;
                    object jzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzp_);

                    return (jzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzx_());

            return izzzzzzzy_;
        };
        IEnumerable<Observation> hzzzzzzzf_ = context.Operators.SortBy<Observation>(hzzzzzzzd_, hzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzg_ = context.Operators.Last<Observation>(hzzzzzzzf_);
        DataType hzzzzzzzh_ = hzzzzzzzg_?.Value;
        object hzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzh_);

        return hzzzzzzzi_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzr_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks(context);
        IEnumerable<Encounter> jzzzzzzzs_ = this.Encounter_with_Singleton_Delivery(context);
        IEnumerable<Encounter> jzzzzzzzt_ = context.Operators.Intersect<Encounter>(jzzzzzzzr_, jzzzzzzzs_);
        bool? jzzzzzzzu_(Encounter SingletonEncounterGE37Weeks)
        {
            int? jzzzzzzzw_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? jzzzzzzzx_ = context.Operators.Equal(jzzzzzzzw_, 1);
            int? jzzzzzzzy_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? jzzzzzzzz_ = context.Operators.Equal(jzzzzzzzy_, 0);
            bool? kzzzzzzza_ = context.Operators.Or(jzzzzzzzx_, jzzzzzzzz_);
            int? kzzzzzzzb_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzzc_ = context.Operators.Equal(kzzzzzzzb_, 0);
            int? kzzzzzzzd_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? kzzzzzzze_ = context.Operators.Equal(kzzzzzzzd_, 0);
            bool? kzzzzzzzf_ = context.Operators.And(kzzzzzzzc_, kzzzzzzze_);
            bool? kzzzzzzzg_ = context.Operators.Or(kzzzzzzza_, kzzzzzzzf_);

            return kzzzzzzzg_;
        };
        IEnumerable<Encounter> jzzzzzzzv_ = context.Operators.Where<Encounter>(jzzzzzzzt_, jzzzzzzzu_);

        return jzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzh_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? kzzzzzzzi_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            object kzzzzzzzk_()
            {
                bool kzzzzzzzu_()
                {
                    CqlValueSet kzzzzzzzx_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> kzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kzzzzzzzz_(Observation AbnormalPresentation)
                    {
                        object lzzzzzzzh_()
                        {
                            bool lzzzzzzzs_()
                            {
                                DataType lzzzzzzzv_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzv_);
                                bool lzzzzzzzx_ = lzzzzzzzw_ is CqlDateTime;

                                return lzzzzzzzx_;
                            };
                            bool lzzzzzzzt_()
                            {
                                DataType lzzzzzzzy_ = AbnormalPresentation?.Effective;
                                object lzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzy_);
                                bool mzzzzzzza_ = lzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzza_;
                            };
                            bool lzzzzzzzu_()
                            {
                                DataType mzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzb_);
                                bool mzzzzzzzd_ = mzzzzzzzc_ is CqlDateTime;

                                return mzzzzzzzd_;
                            };
                            if (lzzzzzzzs_())
                            {
                                DataType mzzzzzzze_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzze_);

                                return (mzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzt_())
                            {
                                DataType mzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzg_);

                                return (mzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzu_())
                            {
                                DataType mzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object mzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzi_);

                                return (mzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzh_());
                        CqlDateTime lzzzzzzzj_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? lzzzzzzzk_ = context.Operators.SameOrBefore(lzzzzzzzi_, lzzzzzzzj_, default);
                        Code<ObservationStatus> lzzzzzzzl_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lzzzzzzzm_ = lzzzzzzzl_?.Value;
                        Code<ObservationStatus> lzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzm_);
                        string lzzzzzzzo_ = context.Operators.Convert<string>(lzzzzzzzn_);
                        string[] lzzzzzzzp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzq_ = context.Operators.In<string>(lzzzzzzzo_, lzzzzzzzp_ as IEnumerable<string>);
                        bool? lzzzzzzzr_ = context.Operators.And(lzzzzzzzk_, lzzzzzzzq_);

                        return lzzzzzzzr_;
                    };
                    IEnumerable<Observation> lzzzzzzza_ = context.Operators.Where<Observation>(kzzzzzzzy_, kzzzzzzzz_);
                    object lzzzzzzzb_(Observation @this)
                    {
                        object mzzzzzzzk_()
                        {
                            bool mzzzzzzzm_()
                            {
                                DataType mzzzzzzzp_ = @this?.Effective;
                                object mzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzp_);
                                bool mzzzzzzzr_ = mzzzzzzzq_ is CqlDateTime;

                                return mzzzzzzzr_;
                            };
                            bool mzzzzzzzn_()
                            {
                                DataType mzzzzzzzs_ = @this?.Effective;
                                object mzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzs_);
                                bool mzzzzzzzu_ = mzzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzu_;
                            };
                            bool mzzzzzzzo_()
                            {
                                DataType mzzzzzzzv_ = @this?.Effective;
                                object mzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzv_);
                                bool mzzzzzzzx_ = mzzzzzzzw_ is CqlDateTime;

                                return mzzzzzzzx_;
                            };
                            if (mzzzzzzzm_())
                            {
                                DataType mzzzzzzzy_ = @this?.Effective;
                                object mzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzy_);

                                return (mzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzn_())
                            {
                                DataType nzzzzzzza_ = @this?.Effective;
                                object nzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzza_);

                                return (nzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzo_())
                            {
                                DataType nzzzzzzzc_ = @this?.Effective;
                                object nzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzc_);

                                return (nzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzk_());

                        return mzzzzzzzl_;
                    };
                    IEnumerable<Observation> lzzzzzzzc_ = context.Operators.SortBy<Observation>(lzzzzzzza_, lzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lzzzzzzzd_ = context.Operators.Last<Observation>(lzzzzzzzc_);
                    DataType lzzzzzzze_ = lzzzzzzzd_?.Effective;
                    object lzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzze_);
                    bool lzzzzzzzg_ = lzzzzzzzf_ is CqlDateTime;

                    return lzzzzzzzg_;
                };
                bool kzzzzzzzv_()
                {
                    CqlValueSet nzzzzzzze_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> nzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nzzzzzzzg_(Observation AbnormalPresentation)
                    {
                        object nzzzzzzzo_()
                        {
                            bool nzzzzzzzz_()
                            {
                                DataType ozzzzzzzc_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzc_);
                                bool ozzzzzzze_ = ozzzzzzzd_ is CqlDateTime;

                                return ozzzzzzze_;
                            };
                            bool ozzzzzzza_()
                            {
                                DataType ozzzzzzzf_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzf_);
                                bool ozzzzzzzh_ = ozzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzh_;
                            };
                            bool ozzzzzzzb_()
                            {
                                DataType ozzzzzzzi_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzi_);
                                bool ozzzzzzzk_ = ozzzzzzzj_ is CqlDateTime;

                                return ozzzzzzzk_;
                            };
                            if (nzzzzzzzz_())
                            {
                                DataType ozzzzzzzl_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzl_);

                                return (ozzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzza_())
                            {
                                DataType ozzzzzzzn_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzn_);

                                return (ozzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzb_())
                            {
                                DataType ozzzzzzzp_ = AbnormalPresentation?.Effective;
                                object ozzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzp_);

                                return (ozzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzo_());
                        CqlDateTime nzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? nzzzzzzzr_ = context.Operators.SameOrBefore(nzzzzzzzp_, nzzzzzzzq_, default);
                        Code<ObservationStatus> nzzzzzzzs_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? nzzzzzzzt_ = nzzzzzzzs_?.Value;
                        Code<ObservationStatus> nzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzt_);
                        string nzzzzzzzv_ = context.Operators.Convert<string>(nzzzzzzzu_);
                        string[] nzzzzzzzw_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzx_ = context.Operators.In<string>(nzzzzzzzv_, nzzzzzzzw_ as IEnumerable<string>);
                        bool? nzzzzzzzy_ = context.Operators.And(nzzzzzzzr_, nzzzzzzzx_);

                        return nzzzzzzzy_;
                    };
                    IEnumerable<Observation> nzzzzzzzh_ = context.Operators.Where<Observation>(nzzzzzzzf_, nzzzzzzzg_);
                    object nzzzzzzzi_(Observation @this)
                    {
                        object ozzzzzzzr_()
                        {
                            bool ozzzzzzzt_()
                            {
                                DataType ozzzzzzzw_ = @this?.Effective;
                                object ozzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzw_);
                                bool ozzzzzzzy_ = ozzzzzzzx_ is CqlDateTime;

                                return ozzzzzzzy_;
                            };
                            bool ozzzzzzzu_()
                            {
                                DataType ozzzzzzzz_ = @this?.Effective;
                                object pzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzz_);
                                bool pzzzzzzzb_ = pzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzb_;
                            };
                            bool ozzzzzzzv_()
                            {
                                DataType pzzzzzzzc_ = @this?.Effective;
                                object pzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzc_);
                                bool pzzzzzzze_ = pzzzzzzzd_ is CqlDateTime;

                                return pzzzzzzze_;
                            };
                            if (ozzzzzzzt_())
                            {
                                DataType pzzzzzzzf_ = @this?.Effective;
                                object pzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzf_);

                                return (pzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzu_())
                            {
                                DataType pzzzzzzzh_ = @this?.Effective;
                                object pzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzh_);

                                return (pzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzv_())
                            {
                                DataType pzzzzzzzj_ = @this?.Effective;
                                object pzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzj_);

                                return (pzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzr_());

                        return ozzzzzzzs_;
                    };
                    IEnumerable<Observation> nzzzzzzzj_ = context.Operators.SortBy<Observation>(nzzzzzzzh_, nzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzk_ = context.Operators.Last<Observation>(nzzzzzzzj_);
                    DataType nzzzzzzzl_ = nzzzzzzzk_?.Effective;
                    object nzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzl_);
                    bool nzzzzzzzn_ = nzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzn_;
                };
                bool kzzzzzzzw_()
                {
                    CqlValueSet pzzzzzzzl_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> pzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzn_(Observation AbnormalPresentation)
                    {
                        object pzzzzzzzv_()
                        {
                            bool qzzzzzzzg_()
                            {
                                DataType qzzzzzzzj_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzj_);
                                bool qzzzzzzzl_ = qzzzzzzzk_ is CqlDateTime;

                                return qzzzzzzzl_;
                            };
                            bool qzzzzzzzh_()
                            {
                                DataType qzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzm_);
                                bool qzzzzzzzo_ = qzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzo_;
                            };
                            bool qzzzzzzzi_()
                            {
                                DataType qzzzzzzzp_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzp_);
                                bool qzzzzzzzr_ = qzzzzzzzq_ is CqlDateTime;

                                return qzzzzzzzr_;
                            };
                            if (qzzzzzzzg_())
                            {
                                DataType qzzzzzzzs_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzs_);

                                return (qzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzh_())
                            {
                                DataType qzzzzzzzu_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzu_);

                                return (qzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzi_())
                            {
                                DataType qzzzzzzzw_ = AbnormalPresentation?.Effective;
                                object qzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzw_);

                                return (qzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzv_());
                        CqlDateTime pzzzzzzzx_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? pzzzzzzzy_ = context.Operators.SameOrBefore(pzzzzzzzw_, pzzzzzzzx_, default);
                        Code<ObservationStatus> pzzzzzzzz_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? qzzzzzzza_ = pzzzzzzzz_?.Value;
                        Code<ObservationStatus> qzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzza_);
                        string qzzzzzzzc_ = context.Operators.Convert<string>(qzzzzzzzb_);
                        string[] qzzzzzzzd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? qzzzzzzze_ = context.Operators.In<string>(qzzzzzzzc_, qzzzzzzzd_ as IEnumerable<string>);
                        bool? qzzzzzzzf_ = context.Operators.And(pzzzzzzzy_, qzzzzzzze_);

                        return qzzzzzzzf_;
                    };
                    IEnumerable<Observation> pzzzzzzzo_ = context.Operators.Where<Observation>(pzzzzzzzm_, pzzzzzzzn_);
                    object pzzzzzzzp_(Observation @this)
                    {
                        object qzzzzzzzy_()
                        {
                            bool rzzzzzzza_()
                            {
                                DataType rzzzzzzzd_ = @this?.Effective;
                                object rzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzd_);
                                bool rzzzzzzzf_ = rzzzzzzze_ is CqlDateTime;

                                return rzzzzzzzf_;
                            };
                            bool rzzzzzzzb_()
                            {
                                DataType rzzzzzzzg_ = @this?.Effective;
                                object rzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzg_);
                                bool rzzzzzzzi_ = rzzzzzzzh_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzi_;
                            };
                            bool rzzzzzzzc_()
                            {
                                DataType rzzzzzzzj_ = @this?.Effective;
                                object rzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzj_);
                                bool rzzzzzzzl_ = rzzzzzzzk_ is CqlDateTime;

                                return rzzzzzzzl_;
                            };
                            if (rzzzzzzza_())
                            {
                                DataType rzzzzzzzm_ = @this?.Effective;
                                object rzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzm_);

                                return (rzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzb_())
                            {
                                DataType rzzzzzzzo_ = @this?.Effective;
                                object rzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzo_);

                                return (rzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzc_())
                            {
                                DataType rzzzzzzzq_ = @this?.Effective;
                                object rzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzq_);

                                return (rzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzy_());

                        return qzzzzzzzz_;
                    };
                    IEnumerable<Observation> pzzzzzzzq_ = context.Operators.SortBy<Observation>(pzzzzzzzo_, pzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzr_ = context.Operators.Last<Observation>(pzzzzzzzq_);
                    DataType pzzzzzzzs_ = pzzzzzzzr_?.Effective;
                    object pzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzs_);
                    bool pzzzzzzzu_ = pzzzzzzzt_ is CqlDateTime;

                    return pzzzzzzzu_;
                };
                if (kzzzzzzzu_())
                {
                    CqlValueSet rzzzzzzzs_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> rzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzu_(Observation AbnormalPresentation)
                    {
                        object szzzzzzzb_()
                        {
                            bool szzzzzzzm_()
                            {
                                DataType szzzzzzzp_ = AbnormalPresentation?.Effective;
                                object szzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzp_);
                                bool szzzzzzzr_ = szzzzzzzq_ is CqlDateTime;

                                return szzzzzzzr_;
                            };
                            bool szzzzzzzn_()
                            {
                                DataType szzzzzzzs_ = AbnormalPresentation?.Effective;
                                object szzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzs_);
                                bool szzzzzzzu_ = szzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzu_;
                            };
                            bool szzzzzzzo_()
                            {
                                DataType szzzzzzzv_ = AbnormalPresentation?.Effective;
                                object szzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzv_);
                                bool szzzzzzzx_ = szzzzzzzw_ is CqlDateTime;

                                return szzzzzzzx_;
                            };
                            if (szzzzzzzm_())
                            {
                                DataType szzzzzzzy_ = AbnormalPresentation?.Effective;
                                object szzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzy_);

                                return (szzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzn_())
                            {
                                DataType tzzzzzzza_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzza_);

                                return (tzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzo_())
                            {
                                DataType tzzzzzzzc_ = AbnormalPresentation?.Effective;
                                object tzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzc_);

                                return (tzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzb_());
                        CqlDateTime szzzzzzzd_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? szzzzzzze_ = context.Operators.SameOrBefore(szzzzzzzc_, szzzzzzzd_, default);
                        Code<ObservationStatus> szzzzzzzf_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? szzzzzzzg_ = szzzzzzzf_?.Value;
                        Code<ObservationStatus> szzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzg_);
                        string szzzzzzzi_ = context.Operators.Convert<string>(szzzzzzzh_);
                        string[] szzzzzzzj_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzk_ = context.Operators.In<string>(szzzzzzzi_, szzzzzzzj_ as IEnumerable<string>);
                        bool? szzzzzzzl_ = context.Operators.And(szzzzzzze_, szzzzzzzk_);

                        return szzzzzzzl_;
                    };
                    IEnumerable<Observation> rzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzt_, rzzzzzzzu_);
                    object rzzzzzzzw_(Observation @this)
                    {
                        object tzzzzzzze_()
                        {
                            bool tzzzzzzzg_()
                            {
                                DataType tzzzzzzzj_ = @this?.Effective;
                                object tzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzj_);
                                bool tzzzzzzzl_ = tzzzzzzzk_ is CqlDateTime;

                                return tzzzzzzzl_;
                            };
                            bool tzzzzzzzh_()
                            {
                                DataType tzzzzzzzm_ = @this?.Effective;
                                object tzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzm_);
                                bool tzzzzzzzo_ = tzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzo_;
                            };
                            bool tzzzzzzzi_()
                            {
                                DataType tzzzzzzzp_ = @this?.Effective;
                                object tzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzp_);
                                bool tzzzzzzzr_ = tzzzzzzzq_ is CqlDateTime;

                                return tzzzzzzzr_;
                            };
                            if (tzzzzzzzg_())
                            {
                                DataType tzzzzzzzs_ = @this?.Effective;
                                object tzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzs_);

                                return (tzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzh_())
                            {
                                DataType tzzzzzzzu_ = @this?.Effective;
                                object tzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzu_);

                                return (tzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzi_())
                            {
                                DataType tzzzzzzzw_ = @this?.Effective;
                                object tzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzw_);

                                return (tzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzze_());

                        return tzzzzzzzf_;
                    };
                    IEnumerable<Observation> rzzzzzzzx_ = context.Operators.SortBy<Observation>(rzzzzzzzv_, rzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzy_ = context.Operators.Last<Observation>(rzzzzzzzx_);
                    DataType rzzzzzzzz_ = rzzzzzzzy_?.Effective;
                    object szzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzz_);

                    return (szzzzzzza_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzv_())
                {
                    CqlValueSet tzzzzzzzy_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> tzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? uzzzzzzza_(Observation AbnormalPresentation)
                    {
                        object uzzzzzzzh_()
                        {
                            bool uzzzzzzzs_()
                            {
                                DataType uzzzzzzzv_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzv_);
                                bool uzzzzzzzx_ = uzzzzzzzw_ is CqlDateTime;

                                return uzzzzzzzx_;
                            };
                            bool uzzzzzzzt_()
                            {
                                DataType uzzzzzzzy_ = AbnormalPresentation?.Effective;
                                object uzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzy_);
                                bool vzzzzzzza_ = uzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzza_;
                            };
                            bool uzzzzzzzu_()
                            {
                                DataType vzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzb_);
                                bool vzzzzzzzd_ = vzzzzzzzc_ is CqlDateTime;

                                return vzzzzzzzd_;
                            };
                            if (uzzzzzzzs_())
                            {
                                DataType vzzzzzzze_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzze_);

                                return (vzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzt_())
                            {
                                DataType vzzzzzzzg_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzg_);

                                return (vzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzu_())
                            {
                                DataType vzzzzzzzi_ = AbnormalPresentation?.Effective;
                                object vzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzi_);

                                return (vzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzh_());
                        CqlDateTime uzzzzzzzj_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? uzzzzzzzk_ = context.Operators.SameOrBefore(uzzzzzzzi_, uzzzzzzzj_, default);
                        Code<ObservationStatus> uzzzzzzzl_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? uzzzzzzzm_ = uzzzzzzzl_?.Value;
                        Code<ObservationStatus> uzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzm_);
                        string uzzzzzzzo_ = context.Operators.Convert<string>(uzzzzzzzn_);
                        string[] uzzzzzzzp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? uzzzzzzzq_ = context.Operators.In<string>(uzzzzzzzo_, uzzzzzzzp_ as IEnumerable<string>);
                        bool? uzzzzzzzr_ = context.Operators.And(uzzzzzzzk_, uzzzzzzzq_);

                        return uzzzzzzzr_;
                    };
                    IEnumerable<Observation> uzzzzzzzb_ = context.Operators.Where<Observation>(tzzzzzzzz_, uzzzzzzza_);
                    object uzzzzzzzc_(Observation @this)
                    {
                        object vzzzzzzzk_()
                        {
                            bool vzzzzzzzm_()
                            {
                                DataType vzzzzzzzp_ = @this?.Effective;
                                object vzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzp_);
                                bool vzzzzzzzr_ = vzzzzzzzq_ is CqlDateTime;

                                return vzzzzzzzr_;
                            };
                            bool vzzzzzzzn_()
                            {
                                DataType vzzzzzzzs_ = @this?.Effective;
                                object vzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzs_);
                                bool vzzzzzzzu_ = vzzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzu_;
                            };
                            bool vzzzzzzzo_()
                            {
                                DataType vzzzzzzzv_ = @this?.Effective;
                                object vzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzv_);
                                bool vzzzzzzzx_ = vzzzzzzzw_ is CqlDateTime;

                                return vzzzzzzzx_;
                            };
                            if (vzzzzzzzm_())
                            {
                                DataType vzzzzzzzy_ = @this?.Effective;
                                object vzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzy_);

                                return (vzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzn_())
                            {
                                DataType wzzzzzzza_ = @this?.Effective;
                                object wzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzza_);

                                return (wzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzo_())
                            {
                                DataType wzzzzzzzc_ = @this?.Effective;
                                object wzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzc_);

                                return (wzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime vzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzk_());

                        return vzzzzzzzl_;
                    };
                    IEnumerable<Observation> uzzzzzzzd_ = context.Operators.SortBy<Observation>(uzzzzzzzb_, uzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation uzzzzzzze_ = context.Operators.Last<Observation>(uzzzzzzzd_);
                    DataType uzzzzzzzf_ = uzzzzzzze_?.Effective;
                    object uzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzf_);

                    return (uzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzw_())
                {
                    CqlValueSet wzzzzzzze_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> wzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? wzzzzzzzg_(Observation AbnormalPresentation)
                    {
                        object wzzzzzzzn_()
                        {
                            bool wzzzzzzzy_()
                            {
                                DataType xzzzzzzzb_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzb_);
                                bool xzzzzzzzd_ = xzzzzzzzc_ is CqlDateTime;

                                return xzzzzzzzd_;
                            };
                            bool wzzzzzzzz_()
                            {
                                DataType xzzzzzzze_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzze_);
                                bool xzzzzzzzg_ = xzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return xzzzzzzzg_;
                            };
                            bool xzzzzzzza_()
                            {
                                DataType xzzzzzzzh_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzh_);
                                bool xzzzzzzzj_ = xzzzzzzzi_ is CqlDateTime;

                                return xzzzzzzzj_;
                            };
                            if (wzzzzzzzy_())
                            {
                                DataType xzzzzzzzk_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzk_);

                                return (xzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzz_())
                            {
                                DataType xzzzzzzzm_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzm_);

                                return (xzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzza_())
                            {
                                DataType xzzzzzzzo_ = AbnormalPresentation?.Effective;
                                object xzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzo_);

                                return (xzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzn_());
                        CqlDateTime wzzzzzzzp_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, ThirtysevenWeeksPlusEncounter);
                        bool? wzzzzzzzq_ = context.Operators.SameOrBefore(wzzzzzzzo_, wzzzzzzzp_, default);
                        Code<ObservationStatus> wzzzzzzzr_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? wzzzzzzzs_ = wzzzzzzzr_?.Value;
                        Code<ObservationStatus> wzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzs_);
                        string wzzzzzzzu_ = context.Operators.Convert<string>(wzzzzzzzt_);
                        string[] wzzzzzzzv_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? wzzzzzzzw_ = context.Operators.In<string>(wzzzzzzzu_, wzzzzzzzv_ as IEnumerable<string>);
                        bool? wzzzzzzzx_ = context.Operators.And(wzzzzzzzq_, wzzzzzzzw_);

                        return wzzzzzzzx_;
                    };
                    IEnumerable<Observation> wzzzzzzzh_ = context.Operators.Where<Observation>(wzzzzzzzf_, wzzzzzzzg_);
                    object wzzzzzzzi_(Observation @this)
                    {
                        object xzzzzzzzq_()
                        {
                            bool xzzzzzzzs_()
                            {
                                DataType xzzzzzzzv_ = @this?.Effective;
                                object xzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzv_);
                                bool xzzzzzzzx_ = xzzzzzzzw_ is CqlDateTime;

                                return xzzzzzzzx_;
                            };
                            bool xzzzzzzzt_()
                            {
                                DataType xzzzzzzzy_ = @this?.Effective;
                                object xzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzy_);
                                bool yzzzzzzza_ = xzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return yzzzzzzza_;
                            };
                            bool xzzzzzzzu_()
                            {
                                DataType yzzzzzzzb_ = @this?.Effective;
                                object yzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzb_);
                                bool yzzzzzzzd_ = yzzzzzzzc_ is CqlDateTime;

                                return yzzzzzzzd_;
                            };
                            if (xzzzzzzzs_())
                            {
                                DataType yzzzzzzze_ = @this?.Effective;
                                object yzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzze_);

                                return (yzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (xzzzzzzzt_())
                            {
                                DataType yzzzzzzzg_ = @this?.Effective;
                                object yzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzg_);

                                return (yzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzu_())
                            {
                                DataType yzzzzzzzi_ = @this?.Effective;
                                object yzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzi_);

                                return (yzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime xzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzq_());

                        return xzzzzzzzr_;
                    };
                    IEnumerable<Observation> wzzzzzzzj_ = context.Operators.SortBy<Observation>(wzzzzzzzh_, wzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation wzzzzzzzk_ = context.Operators.Last<Observation>(wzzzzzzzj_);
                    DataType wzzzzzzzl_ = wzzzzzzzk_?.Effective;
                    object wzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzl_);

                    return (wzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime kzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzk_());
            Period kzzzzzzzm_ = ThirtysevenWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzm_);
            bool? kzzzzzzzo_ = context.Operators.In<CqlDateTime>(kzzzzzzzl_, kzzzzzzzn_, default);
            IEnumerable<Condition> kzzzzzzzp_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? kzzzzzzzq_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzk_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzk_);
                CqlValueSet yzzzzzzzm_ = this.Abnormal_Presentation(context);
                bool? yzzzzzzzn_ = context.Operators.ConceptInValueSet(yzzzzzzzl_, yzzzzzzzm_);

                return yzzzzzzzn_;
            };
            IEnumerable<Condition> kzzzzzzzr_ = context.Operators.Where<Condition>(kzzzzzzzp_, kzzzzzzzq_);
            bool? kzzzzzzzs_ = context.Operators.Exists<Condition>(kzzzzzzzr_);
            bool? kzzzzzzzt_ = context.Operators.Or(kzzzzzzzo_, kzzzzzzzs_);

            return kzzzzzzzt_;
        };
        IEnumerable<Encounter> kzzzzzzzj_ = context.Operators.Where<Encounter>(kzzzzzzzh_, kzzzzzzzi_);

        return kzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzo_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? yzzzzzzzp_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            IEnumerable<Condition> yzzzzzzzr_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ThirtysevenWeeksPlusEncounter);
            bool? yzzzzzzzs_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzv_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzv_);
                CqlValueSet yzzzzzzzx_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? yzzzzzzzy_ = context.Operators.ConceptInValueSet(yzzzzzzzw_, yzzzzzzzx_);
                CqlConcept zzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzv_);
                CqlValueSet zzzzzzzzb_ = this.Genital_Herpes(context);
                bool? zzzzzzzzc_ = context.Operators.ConceptInValueSet(zzzzzzzza_, zzzzzzzzb_);
                bool? zzzzzzzzd_ = context.Operators.Or(yzzzzzzzy_, zzzzzzzzc_);

                return zzzzzzzzd_;
            };
            IEnumerable<Condition> yzzzzzzzt_ = context.Operators.Where<Condition>(yzzzzzzzr_, yzzzzzzzs_);
            bool? yzzzzzzzu_ = context.Operators.Exists<Condition>(yzzzzzzzt_);

            return yzzzzzzzu_;
        };
        IEnumerable<Encounter> yzzzzzzzq_ = context.Operators.Where<Encounter>(yzzzzzzzo_, yzzzzzzzp_);

        return yzzzzzzzq_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzze_ = this.Encounter_with_Abnormal_Presentation(context);
        IEnumerable<Encounter> zzzzzzzzf_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> zzzzzzzzg_ = context.Operators.Union<Encounter>(zzzzzzzze_, zzzzzzzzf_);

        return zzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzh_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return zzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzi_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum(context);

        return zzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzj_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return zzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzk_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> zzzzzzzzl_(Encounter ThirtysevenWeeksPlusEncounter)
        {
            CqlValueSet zzzzzzzzn_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> zzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? zzzzzzzzp_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> zzzzzzzzt_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtysevenWeeksPlusEncounter);
                DataType zzzzzzzzu_ = CSection?.Performed;
                object zzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzu_);
                CqlInterval<CqlDateTime> zzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzv_);
                bool? zzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzt_, zzzzzzzzw_, default);
                Code<EventStatus> zzzzzzzzy_ = CSection?.StatusElement;
                EventStatus? zzzzzzzzz_ = zzzzzzzzy_?.Value;
                string azzzzzzzza_ = context.Operators.Convert<string>(zzzzzzzzz_);
                bool? azzzzzzzzb_ = context.Operators.Equal(azzzzzzzza_, "completed");
                bool? azzzzzzzzc_ = context.Operators.And(zzzzzzzzx_, azzzzzzzzb_);

                return azzzzzzzzc_;
            };
            IEnumerable<Procedure> zzzzzzzzq_ = context.Operators.Where<Procedure>(zzzzzzzzo_, zzzzzzzzp_);
            Encounter zzzzzzzzr_(Procedure CSection) =>
                ThirtysevenWeeksPlusEncounter;
            IEnumerable<Encounter> zzzzzzzzs_ = context.Operators.Select<Procedure, Encounter>(zzzzzzzzq_, zzzzzzzzr_);

            return zzzzzzzzs_;
        };
        IEnumerable<Encounter> zzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzk_, zzzzzzzzl_);

        return zzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzd_ = this.Delivery_Encounter_with_Cesarean_Birth(context);

        return azzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> azzzzzzzzi_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return azzzzzzzzi_;
    }


    #endregion Expressions

}
