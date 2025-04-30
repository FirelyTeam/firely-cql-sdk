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
[CqlLibrary("HospitalHarmOpioidRelatedAdverseEventsFHIR", "0.1.000")]
public partial class HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000>
{
    private HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000() {}

    public static HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmOpioidRelatedAdverseEventsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Operating Room Suite", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", valueSetVersion: null)]
    public CqlValueSet Operating_Room_Suite(CqlContext _) => _Operating_Room_Suite;
    private static readonly CqlValueSet _Operating_Room_Suite = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", null);

    [CqlValueSetDefinition("Opioid Antagonist", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", valueSetVersion: null)]
    public CqlValueSet Opioid_Antagonist(CqlContext _) => _Opioid_Antagonist;
    private static readonly CqlValueSet _Opioid_Antagonist = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", null);

    [CqlValueSetDefinition("Opioids, All", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", valueSetVersion: null)]
    public CqlValueSet Opioids__All(CqlContext _) => _Opioids__All;
    private static readonly CqlValueSet _Opioids__All = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", null);

    [CqlValueSetDefinition("Routes of Administration for Opioid Antagonists", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", valueSetVersion: null)]
    public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists(CqlContext _) => _Routes_of_Administration_for_Opioid_Antagonists;
    private static readonly CqlValueSet _Routes_of_Administration_for_Opioid_Antagonists = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Dead", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext _) => _Dead;
    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("HSLOC")]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
            Date azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "year");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, 18);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "finished");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Opioid Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Administration(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Opioids__All(context);
        IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationAdministration>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationAdministration Opioids)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Opioids?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "not-done");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationAdministration>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Opioid Administration Outside of Operating Room")]
    public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Opioid_Administration(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationAdministration OpioidGiven)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = OpioidGiven?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                List<Encounter.LocationComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Location;
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter.LocationComponent EncounterLocation)
                {
                    ResourceReference czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterLocation?.Location;
                    Location czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetLocation(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Type;
                    CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(CodeableConcept @this)
                    {
                        CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Operating_Room_Suite(context);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = OpioidGiven?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter.LocationComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter.LocationComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationAdministration OpioidGiven) =>
                InpatientEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationAdministration, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Opioid_Antagonist(context);
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationAdministration>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(MedicationAdministration AntagonistGiven)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AntagonistGiven?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "not-done");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationAdministration>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
    public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(CqlContext context)
    {
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Opioid_Antagonist_Administration(context);
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Opioid_Administration(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Denominator(context);
        IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad)
        {
            List<Encounter.LocationComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge?.Location;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter.LocationComponent EncounterLocation)
            {
                ResourceReference gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterLocation?.Location;
                Location gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetLocation(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                List<CodeableConcept> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Type;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
                {
                    CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Operating_Room_Suite(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.LocationComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter.LocationComponent>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidGiven?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, false);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            MedicationAdministration.DosageComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Dosage;
            CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Route;
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad) =>
            tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge;
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new(
        [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
        ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);

    #endregion CqlTupleMetadata Properties

}
