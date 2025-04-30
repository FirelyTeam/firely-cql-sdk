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
[CqlLibrary("POAGOpticNerveEvaluationFHIR", "0.1.000")]
public partial class POAGOpticNerveEvaluationFHIR_0_1_000 : ILibrary, ISingleton<POAGOpticNerveEvaluationFHIR_0_1_000>
{
    private POAGOpticNerveEvaluationFHIR_0_1_000() {}

    public static POAGOpticNerveEvaluationFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "POAGOpticNerveEvaluationFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Cup to Disc Ratio", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", valueSetVersion: null)]
    public CqlValueSet Cup_to_Disc_Ratio(CqlContext _) => _Cup_to_Disc_Ratio;
    private static readonly CqlValueSet _Cup_to_Disc_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Optic Disc Exam for Structural Abnormalities", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", valueSetVersion: null)]
    public CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities(CqlContext _) => _Optic_Disc_Exam_for_Structural_Abnormalities;
    private static readonly CqlValueSet _Optic_Disc_Exam_for_Structural_Abnormalities = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Primary Open-Angle Glaucoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", valueSetVersion: null)]
    public CqlValueSet Primary_Open_Angle_Glaucoma(CqlContext _) => _Primary_Open_Angle_Glaucoma;
    private static readonly CqlValueSet _Primary_Open_Angle_Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("POAGOpticNerveEvaluationFHIR-0.1.000", "Measurement Period", tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "finished");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Coding uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Class;
            CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToCode(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.@virtual(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Primary Open Angle Glaucoma Encounter")]
    public IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Primary_Open_Angle_Glaucoma(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition PrimaryOpenAngleGlaucoma)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PrimaryOpenAngleGlaucoma);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isActive(context, PrimaryOpenAngleGlaucoma);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = PrimaryOpenAngleGlaucoma?.VerificationStatus;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition PrimaryOpenAngleGlaucoma) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Condition, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 18);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Medical Reason for Not Performing Cup to Disc Ratio")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation CupToDiscExamNotPerformed)
        {
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterWithPOAG)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CupToDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterWithPOAG) =>
                CupToDiscExamNotPerformed;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation CupToDiscExamNotPerformed)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Extension @this)
            {
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Url;
                FhirString xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(CupToDiscExamNotPerformed is DomainResource
                    ? (CupToDiscExamNotPerformed as DomainResource).Extension
                    : default), xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Extension @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Value;

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CodeableConcept);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Medical_Reason(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Medical Reason for Not Performing Optic Disc Exam")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation OpticDiscExamNotPerformed)
        {
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterWithPOAG)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = OpticDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterWithPOAG) =>
                OpticDiscExamNotPerformed;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation OpticDiscExamNotPerformed)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Url;
                FhirString yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Extension> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(OpticDiscExamNotPerformed is DomainResource
                    ? (OpticDiscExamNotPerformed as DomainResource).Extension
                    : default), yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Extension @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Value;

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CodeableConcept);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Medical_Reason(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Cup to Disc Ratio Performed with Result")]
    public IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation CupToDiscExamPerformed)
        {
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterWithPOAG)
            {
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CupToDiscExamPerformed?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterWithPOAG) =>
                CupToDiscExamPerformed;
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CupToDiscExamPerformed)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CupToDiscExamPerformed?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CupToDiscExamPerformed?.StatusElement;
            ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Optic Disc Exam Performed with Result")]
    public IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation OpticDiscExamPerformed)
        {
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter EncounterWithPOAG)
            {
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = OpticDiscExamPerformed?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter EncounterWithPOAG) =>
                OpticDiscExamPerformed;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation OpticDiscExamPerformed)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = OpticDiscExamPerformed?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = OpticDiscExamPerformed?.StatusElement;
            ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Cup_to_Disc_Ratio_Performed_with_Result(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Optic_Disc_Exam_Performed_with_Result(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
