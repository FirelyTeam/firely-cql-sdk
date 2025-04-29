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

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Operating Room Suite
    [CqlValueSetDefinition(
        definitionName: "Operating Room Suite",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141",
        valueSetVersion: null)]
    public CqlValueSet Operating_Room_Suite(CqlContext context) => _Operating_Room_Suite;

    private static readonly CqlValueSet _Operating_Room_Suite = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", null);
    #endregion

    #region ValueSet: Opioid Antagonist
    [CqlValueSetDefinition(
        definitionName: "Opioid Antagonist",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119",
        valueSetVersion: null)]
    public CqlValueSet Opioid_Antagonist(CqlContext context) => _Opioid_Antagonist;

    private static readonly CqlValueSet _Opioid_Antagonist = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", null);
    #endregion

    #region ValueSet: Opioids, All
    [CqlValueSetDefinition(
        definitionName: "Opioids, All",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226",
        valueSetVersion: null)]
    public CqlValueSet Opioids__All(CqlContext context) => _Opioids__All;

    private static readonly CqlValueSet _Opioids__All = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", null);
    #endregion

    #region ValueSet: Routes of Administration for Opioid Antagonists
    [CqlValueSetDefinition(
        definitionName: "Routes of Administration for Opioid Antagonists",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187",
        valueSetVersion: null)]
    public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists(CqlContext context) => _Routes_of_Administration_for_Opioid_Antagonists;

    private static readonly CqlValueSet _Routes_of_Administration_for_Opioid_Antagonists = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Dead
    [CqlCodeDefinition(
        definitionName: "Dead",
        codeId: "419099009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext context) => _Dead;

    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "HSLOC")]
    public CqlCode[] HSLOC(CqlContext context)
    {
        CqlCode[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = []
;

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 18);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "finished");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Opioid Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Administration(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Opioids__All(context);
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationAdministration>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationAdministration Opioids)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Opioids?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "not-done");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationAdministration>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Opioid Administration Outside of Operating Room")]
    public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Opioid_Administration(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationAdministration OpioidGiven)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = OpioidGiven?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                List<Encounter.LocationComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = InpatientEncounter?.Location;
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter.LocationComponent EncounterLocation)
                {
                    ResourceReference uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterLocation?.Location;
                    Location uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.GetLocation(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    List<CodeableConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Type;
                    CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(CodeableConcept @this)
                    {
                        CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Operating_Room_Suite(context);
                    bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = OpioidGiven?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                    bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Encounter.LocationComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter.LocationComponent>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationAdministration>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationAdministration OpioidGiven) =>
                InpatientEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationAdministration, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Opioid_Antagonist(context);
        IEnumerable<MedicationAdministration> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationAdministration>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationAdministration AntagonistGiven)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AntagonistGiven?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "not-done");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationAdministration> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationAdministration>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
    public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(CqlContext context)
    {
        IEnumerable<MedicationAdministration> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Opioid_Antagonist_Administration(context);
        IEnumerable<MedicationAdministration> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Opioid_Administration(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Denominator(context);
        IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad)
        {
            List<Encounter.LocationComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge?.Location;
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter.LocationComponent EncounterLocation)
            {
                ResourceReference yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterLocation?.Location;
                Location yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.GetLocation(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                List<CodeableConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Type;
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
                {
                    CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Operating_Room_Suite(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.LocationComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter.LocationComponent>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidGiven?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, false);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            MedicationAdministration.DosageComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Dosage;
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Route;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad) =>
            tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new(
        [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
        ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);

    #endregion CqlTupleMetadata Properties

}
