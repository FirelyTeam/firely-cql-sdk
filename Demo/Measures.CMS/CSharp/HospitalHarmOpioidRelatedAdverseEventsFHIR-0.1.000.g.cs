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
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzb_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            Patient hzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzzzk_);
            Period hzzzzzzzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzo_);
            int? hzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzp_, "year");
            bool? hzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzq_, 18);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? hzzzzzzzzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzza_, "finished");
            bool? izzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Opioid Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Administration(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzd_ = this.Opioids__All(context);
        IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationAdministration>(izzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzzzzzzi_(MedicationAdministration Opioids)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> izzzzzzzzzzzzzzzzzzzzzzk_ = Opioids?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? izzzzzzzzzzzzzzzzzzzzzzl_ = izzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> izzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(izzzzzzzzzzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzm_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? izzzzzzzzzzzzzzzzzzzzzzp_ = izzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> izzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(izzzzzzzzzzzzzzzzzzzzzzp_);
            bool? izzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzq_, "not-done");
            bool? izzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(izzzzzzzzzzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzs_);

            return izzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationAdministration>(izzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzi_);

        return izzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Opioid Administration Outside of Operating Room")]
    public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzv_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzzx_ = this.Opioid_Administration(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzy_(MedicationAdministration OpioidGiven)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzc_ = OpioidGiven?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? jzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzg_, default);
                List<Encounter.LocationComponent> jzzzzzzzzzzzzzzzzzzzzzzi_ = InpatientEncounter?.Location;
                bool? jzzzzzzzzzzzzzzzzzzzzzzj_(Encounter.LocationComponent EncounterLocation)
                {
                    ResourceReference jzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterLocation?.Location;
                    Location jzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetLocation(context, jzzzzzzzzzzzzzzzzzzzzzzo_);
                    List<CodeableConcept> jzzzzzzzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzzzzzzzp_?.Type;
                    CqlConcept jzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
                    {
                        CqlConcept kzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                        return kzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzr_);
                    CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzt_ = this.Operating_Room_Suite(context);
                    bool? jzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzt_);
                    DataType jzzzzzzzzzzzzzzzzzzzzzzv_ = OpioidGiven?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzw_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzx_);
                    Period jzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool? kzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzza_, default);
                    bool? kzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzb_);

                    return kzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Encounter.LocationComponent> jzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)jzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.LocationComponent>(jzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzm_);

                return jzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationAdministration>(izzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzza_(MedicationAdministration OpioidGiven) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationAdministration, Encounter>(izzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzza_);

            return jzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzv_);

        return izzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room(context);

        return kzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzg_ = this.Opioid_Antagonist(context);
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationAdministration>(kzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzl_(MedicationAdministration AntagonistGiven)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzn_ = AntagonistGiven?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? kzzzzzzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(kzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzp_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? kzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(kzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzt_, "not-done");
            bool? kzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationAdministration>(kzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
    public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(CqlContext context)
    {
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzx_ = this.Opioid_Antagonist_Administration(context);
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzzzzzzzzzzzy_ = this.Opioid_Administration(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzz_ = this.Denominator(context);
        IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> lzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzz_);
        (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? lzzzzzzzzzzzzzzzzzzzzzzb_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? lzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return lzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> lzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(lzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad)
        {
            List<Encounter.LocationComponent> lzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge?.Location;
            bool? lzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.LocationComponent EncounterLocation)
            {
                ResourceReference nzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterLocation?.Location;
                Location nzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.GetLocation(context, nzzzzzzzzzzzzzzzzzzzzzzf_);
                List<CodeableConcept> nzzzzzzzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzzzzzzzg_?.Type;
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzi_(CodeableConcept @this)
                {
                    CqlConcept nzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return nzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzk_ = this.Operating_Room_Suite(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType nzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzo_);
                Period nzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzr_, default);
                bool? nzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzs_);

                return nzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter.LocationComponent> lzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)lzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.LocationComponent>(lzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(lzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge);
            bool? lzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzs_, default);
            DataType lzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidGiven?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzs_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzz_);
            object mzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzd_);
            object mzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzj_);
            object mzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzo_, true, false);
            bool? mzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzp_, default);
            object mzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzw_);
            MedicationAdministration.DosageComponent mzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Dosage;
            CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzzzzy_?.Route;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzb_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> lzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(lzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzd_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad) =>
            tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?, Encounter>(lzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(context);

        return nzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new(
        [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
        ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);

    #endregion CqlTupleMetadata Properties

}
