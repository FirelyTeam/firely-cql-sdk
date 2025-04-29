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

    #region ValueSet: Care Services in Long-Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long-Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Cup to Disc Ratio
    [CqlValueSetDefinition(
        definitionName: "Cup to Disc Ratio",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333",
        valueSetVersion: null)]
    public CqlValueSet Cup_to_Disc_Ratio(CqlContext context) => _Cup_to_Disc_Ratio;

    private static readonly CqlValueSet _Cup_to_Disc_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", null);
    #endregion

    #region ValueSet: Face-to-Face Interaction
    [CqlValueSetDefinition(
        definitionName: "Face-to-Face Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext context) => _Face_to_Face_Interaction;

    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Optic Disc Exam for Structural Abnormalities
    [CqlValueSetDefinition(
        definitionName: "Optic Disc Exam for Structural Abnormalities",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334",
        valueSetVersion: null)]
    public CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities(CqlContext context) => _Optic_Disc_Exam_for_Structural_Abnormalities;

    private static readonly CqlValueSet _Optic_Disc_Exam_for_Structural_Abnormalities = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Primary Open-Angle Glaucoma
    [CqlValueSetDefinition(
        definitionName: "Primary Open-Angle Glaucoma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326",
        valueSetVersion: null)]
    public CqlValueSet Primary_Open_Angle_Glaucoma(CqlContext context) => _Primary_Open_Angle_Glaucoma;

    private static readonly CqlValueSet _Primary_Open_Angle_Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: AMB
    [CqlCodeDefinition(
        definitionName: "AMB",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext context) => _AMB;

    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] zzzzzzzzzzl_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return zzzzzzzzzzl_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzo_ = context.Operators.Interval(zzzzzzzzzzm_, zzzzzzzzzzn_, true, true);
        object zzzzzzzzzzp_ = context.ResolveParameter("POAGOpticNerveEvaluationFHIR-0.1.000", "Measurement Period", zzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzq_);

        return zzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzw_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzy_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzza_ = context.Operators.Union<Encounter>(zzzzzzzzzzx_, zzzzzzzzzzz_);
        CqlValueSet azzzzzzzzzzb_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> azzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzd_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzf_ = context.Operators.Union<Encounter>(azzzzzzzzzzc_, azzzzzzzzzze_);
        IEnumerable<Encounter> azzzzzzzzzzg_ = context.Operators.Union<Encounter>(azzzzzzzzzza_, azzzzzzzzzzf_);
        CqlValueSet azzzzzzzzzzh_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> azzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzj_ = context.Operators.Union<Encounter>(azzzzzzzzzzg_, azzzzzzzzzzi_);
        bool? azzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzm_ = this.Measurement_Period(context);
            Period azzzzzzzzzzn_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzn_);
            bool? azzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzm_, azzzzzzzzzzo_, default);
            Code<Encounter.EncounterStatus> azzzzzzzzzzq_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? azzzzzzzzzzr_ = azzzzzzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzr_);
            bool? azzzzzzzzzzt_ = context.Operators.Equal(azzzzzzzzzzs_, "finished");
            bool? azzzzzzzzzzu_ = context.Operators.And(azzzzzzzzzzp_, azzzzzzzzzzt_);
            Coding azzzzzzzzzzv_ = QualifyingEncounter?.Class;
            CqlCode azzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, azzzzzzzzzzv_);
            CqlCode azzzzzzzzzzx_ = this.@virtual(context);
            bool? azzzzzzzzzzy_ = context.Operators.Equivalent(azzzzzzzzzzw_, azzzzzzzzzzx_);
            bool? azzzzzzzzzzz_ = context.Operators.Not(azzzzzzzzzzy_);
            bool? bzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzu_, azzzzzzzzzzz_);

            return bzzzzzzzzzza_;
        };
        IEnumerable<Encounter> azzzzzzzzzzl_ = context.Operators.Where<Encounter>(azzzzzzzzzzj_, azzzzzzzzzzk_);

        return azzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Primary Open Angle Glaucoma Encounter")]
    public IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzb_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> bzzzzzzzzzzc_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet bzzzzzzzzzze_ = this.Primary_Open_Angle_Glaucoma(context);
            IEnumerable<Condition> bzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bzzzzzzzzzzg_(Condition PrimaryOpenAngleGlaucoma)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PrimaryOpenAngleGlaucoma);
                Period bzzzzzzzzzzl_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzl_);
                bool? bzzzzzzzzzzn_ = context.Operators.Overlaps(bzzzzzzzzzzk_, bzzzzzzzzzzm_, default);
                bool? bzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isActive(context, PrimaryOpenAngleGlaucoma);
                bool? bzzzzzzzzzzp_ = context.Operators.And(bzzzzzzzzzzn_, bzzzzzzzzzzo_);
                CodeableConcept bzzzzzzzzzzq_ = PrimaryOpenAngleGlaucoma?.VerificationStatus;
                CqlConcept bzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzq_);
                CqlCode bzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept bzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzs_);
                bool? bzzzzzzzzzzu_ = context.Operators.Equivalent(bzzzzzzzzzzr_, bzzzzzzzzzzt_);
                CqlConcept bzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzq_);
                CqlCode bzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept bzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzx_);
                bool? bzzzzzzzzzzz_ = context.Operators.Equivalent(bzzzzzzzzzzw_, bzzzzzzzzzzy_);
                bool? czzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzu_, bzzzzzzzzzzz_);
                CqlConcept czzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzq_);
                CqlCode czzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept czzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzd_);
                bool? czzzzzzzzzzf_ = context.Operators.Equivalent(czzzzzzzzzzc_, czzzzzzzzzze_);
                bool? czzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzza_, czzzzzzzzzzf_);
                bool? czzzzzzzzzzh_ = context.Operators.Not(czzzzzzzzzzg_);
                bool? czzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzp_, czzzzzzzzzzh_);

                return czzzzzzzzzzi_;
            };
            IEnumerable<Condition> bzzzzzzzzzzh_ = context.Operators.Where<Condition>(bzzzzzzzzzzf_, bzzzzzzzzzzg_);
            Encounter bzzzzzzzzzzi_(Condition PrimaryOpenAngleGlaucoma) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(bzzzzzzzzzzh_, bzzzzzzzzzzi_);

            return bzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzb_, bzzzzzzzzzzc_);

        return bzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzj_ = this.Patient(context);
        Date czzzzzzzzzzk_ = czzzzzzzzzzj_?.BirthDateElement;
        string czzzzzzzzzzl_ = czzzzzzzzzzk_?.Value;
        CqlDate czzzzzzzzzzm_ = context.Operators.ConvertStringToDate(czzzzzzzzzzl_);
        CqlInterval<CqlDateTime> czzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzo_ = context.Operators.Start(czzzzzzzzzzn_);
        CqlDate czzzzzzzzzzp_ = context.Operators.DateFrom(czzzzzzzzzzo_);
        int? czzzzzzzzzzq_ = context.Operators.CalculateAgeAt(czzzzzzzzzzm_, czzzzzzzzzzp_, "year");
        bool? czzzzzzzzzzr_ = context.Operators.GreaterOrEqual(czzzzzzzzzzq_, 18);
        IEnumerable<Encounter> czzzzzzzzzzs_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
        bool? czzzzzzzzzzt_ = context.Operators.Exists<Encounter>(czzzzzzzzzzs_);
        bool? czzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzr_, czzzzzzzzzzt_);

        return czzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? czzzzzzzzzzv_ = this.Initial_Population(context);

        return czzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical Reason for Not Performing Cup to Disc Ratio")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzw_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> czzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> czzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> dzzzzzzzzzza_ = context.Operators.Union<Observation>(czzzzzzzzzzx_, czzzzzzzzzzz_);
        IEnumerable<Observation> dzzzzzzzzzzb_(Observation CupToDiscExamNotPerformed)
        {
            IEnumerable<Encounter> dzzzzzzzzzzf_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? dzzzzzzzzzzg_(Encounter EncounterWithPOAG)
            {
                Instant dzzzzzzzzzzk_ = CupToDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzl_ = dzzzzzzzzzzk_?.Value;
                CqlDateTime dzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzl_);
                Period dzzzzzzzzzzn_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzn_);
                bool? dzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzm_, dzzzzzzzzzzo_, default);

                return dzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzh_ = context.Operators.Where<Encounter>(dzzzzzzzzzzf_, dzzzzzzzzzzg_);
            Observation dzzzzzzzzzzi_(Encounter EncounterWithPOAG) =>
                CupToDiscExamNotPerformed;
            IEnumerable<Observation> dzzzzzzzzzzj_ = context.Operators.Select<Encounter, Observation>(dzzzzzzzzzzh_, dzzzzzzzzzzi_);

            return dzzzzzzzzzzj_;
        };
        IEnumerable<Observation> dzzzzzzzzzzc_ = context.Operators.SelectMany<Observation, Observation>(dzzzzzzzzzza_, dzzzzzzzzzzb_);
        bool? dzzzzzzzzzzd_(Observation CupToDiscExamNotPerformed)
        {
            bool? dzzzzzzzzzzq_(Extension @this)
            {
                string dzzzzzzzzzzy_ = @this?.Url;
                FhirString dzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzy_);
                string ezzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzz_);
                bool? ezzzzzzzzzzb_ = context.Operators.Equal(ezzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return ezzzzzzzzzzb_;
            };
            IEnumerable<Extension> dzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(CupToDiscExamNotPerformed is DomainResource
                    ? (CupToDiscExamNotPerformed as DomainResource).Extension
                    : default), dzzzzzzzzzzq_);
            object dzzzzzzzzzzs_(Extension @this)
            {
                DataType ezzzzzzzzzzc_ = @this?.Value;

                return ezzzzzzzzzzc_;
            };
            IEnumerable<object> dzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzr_, dzzzzzzzzzzs_);
            object dzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzt_);
            CqlConcept dzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzu_ as CodeableConcept);
            CqlValueSet dzzzzzzzzzzw_ = this.Medical_Reason(context);
            bool? dzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzv_, dzzzzzzzzzzw_);

            return dzzzzzzzzzzx_;
        };
        IEnumerable<Observation> dzzzzzzzzzze_ = context.Operators.Where<Observation>(dzzzzzzzzzzc_, dzzzzzzzzzzd_);

        return dzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical Reason for Not Performing Optic Disc Exam")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzd_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> ezzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> ezzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> ezzzzzzzzzzh_ = context.Operators.Union<Observation>(ezzzzzzzzzze_, ezzzzzzzzzzg_);
        IEnumerable<Observation> ezzzzzzzzzzi_(Observation OpticDiscExamNotPerformed)
        {
            IEnumerable<Encounter> ezzzzzzzzzzm_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? ezzzzzzzzzzn_(Encounter EncounterWithPOAG)
            {
                Instant ezzzzzzzzzzr_ = OpticDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzs_ = ezzzzzzzzzzr_?.Value;
                CqlDateTime ezzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzs_);
                Period ezzzzzzzzzzu_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzu_);
                bool? ezzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzt_, ezzzzzzzzzzv_, default);

                return ezzzzzzzzzzw_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzo_ = context.Operators.Where<Encounter>(ezzzzzzzzzzm_, ezzzzzzzzzzn_);
            Observation ezzzzzzzzzzp_(Encounter EncounterWithPOAG) =>
                OpticDiscExamNotPerformed;
            IEnumerable<Observation> ezzzzzzzzzzq_ = context.Operators.Select<Encounter, Observation>(ezzzzzzzzzzo_, ezzzzzzzzzzp_);

            return ezzzzzzzzzzq_;
        };
        IEnumerable<Observation> ezzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(ezzzzzzzzzzh_, ezzzzzzzzzzi_);
        bool? ezzzzzzzzzzk_(Observation OpticDiscExamNotPerformed)
        {
            bool? ezzzzzzzzzzx_(Extension @this)
            {
                string fzzzzzzzzzzf_ = @this?.Url;
                FhirString fzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzf_);
                string fzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzg_);
                bool? fzzzzzzzzzzi_ = context.Operators.Equal(fzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return fzzzzzzzzzzi_;
            };
            IEnumerable<Extension> ezzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(OpticDiscExamNotPerformed is DomainResource
                    ? (OpticDiscExamNotPerformed as DomainResource).Extension
                    : default), ezzzzzzzzzzx_);
            object ezzzzzzzzzzz_(Extension @this)
            {
                DataType fzzzzzzzzzzj_ = @this?.Value;

                return fzzzzzzzzzzj_;
            };
            IEnumerable<object> fzzzzzzzzzza_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzy_, ezzzzzzzzzzz_);
            object fzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzza_);
            CqlConcept fzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzb_ as CodeableConcept);
            CqlValueSet fzzzzzzzzzzd_ = this.Medical_Reason(context);
            bool? fzzzzzzzzzze_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzc_, fzzzzzzzzzzd_);

            return fzzzzzzzzzze_;
        };
        IEnumerable<Observation> ezzzzzzzzzzl_ = context.Operators.Where<Observation>(ezzzzzzzzzzj_, ezzzzzzzzzzk_);

        return ezzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> fzzzzzzzzzzk_ = this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(context);
        bool? fzzzzzzzzzzl_ = context.Operators.Exists<Observation>(fzzzzzzzzzzk_);
        IEnumerable<Observation> fzzzzzzzzzzm_ = this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam(context);
        bool? fzzzzzzzzzzn_ = context.Operators.Exists<Observation>(fzzzzzzzzzzm_);
        bool? fzzzzzzzzzzo_ = context.Operators.Or(fzzzzzzzzzzl_, fzzzzzzzzzzn_);

        return fzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cup to Disc Ratio Performed with Result")]
    public IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzp_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> fzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzr_(Observation CupToDiscExamPerformed)
        {
            IEnumerable<Encounter> fzzzzzzzzzzv_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? fzzzzzzzzzzw_(Encounter EncounterWithPOAG)
            {
                Period gzzzzzzzzzza_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzza_);
                DataType gzzzzzzzzzzc_ = CupToDiscExamPerformed?.Effective;
                object gzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> gzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzd_);
                bool? gzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzb_, gzzzzzzzzzze_, default);

                return gzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzzzv_, fzzzzzzzzzzw_);
            Observation fzzzzzzzzzzy_(Encounter EncounterWithPOAG) =>
                CupToDiscExamPerformed;
            IEnumerable<Observation> fzzzzzzzzzzz_ = context.Operators.Select<Encounter, Observation>(fzzzzzzzzzzx_, fzzzzzzzzzzy_);

            return fzzzzzzzzzzz_;
        };
        IEnumerable<Observation> fzzzzzzzzzzs_ = context.Operators.SelectMany<Observation, Observation>(fzzzzzzzzzzq_, fzzzzzzzzzzr_);
        bool? fzzzzzzzzzzt_(Observation CupToDiscExamPerformed)
        {
            DataType gzzzzzzzzzzg_ = CupToDiscExamPerformed?.Value;
            object gzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzg_);
            bool? gzzzzzzzzzzi_ = context.Operators.Not((bool?)(gzzzzzzzzzzh_ is null));
            Code<ObservationStatus> gzzzzzzzzzzj_ = CupToDiscExamPerformed?.StatusElement;
            ObservationStatus? gzzzzzzzzzzk_ = gzzzzzzzzzzj_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzk_);
            string gzzzzzzzzzzm_ = context.Operators.Convert<string>(gzzzzzzzzzzl_);
            string[] gzzzzzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzo_ = context.Operators.In<string>(gzzzzzzzzzzm_, gzzzzzzzzzzn_ as IEnumerable<string>);
            bool? gzzzzzzzzzzp_ = context.Operators.And(gzzzzzzzzzzi_, gzzzzzzzzzzo_);

            return gzzzzzzzzzzp_;
        };
        IEnumerable<Observation> fzzzzzzzzzzu_ = context.Operators.Where<Observation>(fzzzzzzzzzzs_, fzzzzzzzzzzt_);

        return fzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Optic Disc Exam Performed with Result")]
    public IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzq_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> gzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzs_(Observation OpticDiscExamPerformed)
        {
            IEnumerable<Encounter> gzzzzzzzzzzw_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
            bool? gzzzzzzzzzzx_(Encounter EncounterWithPOAG)
            {
                Period hzzzzzzzzzzb_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzb_);
                DataType hzzzzzzzzzzd_ = OpticDiscExamPerformed?.Effective;
                object hzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzze_);
                bool? hzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzc_, hzzzzzzzzzzf_, default);

                return hzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzy_ = context.Operators.Where<Encounter>(gzzzzzzzzzzw_, gzzzzzzzzzzx_);
            Observation gzzzzzzzzzzz_(Encounter EncounterWithPOAG) =>
                OpticDiscExamPerformed;
            IEnumerable<Observation> hzzzzzzzzzza_ = context.Operators.Select<Encounter, Observation>(gzzzzzzzzzzy_, gzzzzzzzzzzz_);

            return hzzzzzzzzzza_;
        };
        IEnumerable<Observation> gzzzzzzzzzzt_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzr_, gzzzzzzzzzzs_);
        bool? gzzzzzzzzzzu_(Observation OpticDiscExamPerformed)
        {
            DataType hzzzzzzzzzzh_ = OpticDiscExamPerformed?.Value;
            object hzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzh_);
            bool? hzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzi_ is null));
            Code<ObservationStatus> hzzzzzzzzzzk_ = OpticDiscExamPerformed?.StatusElement;
            ObservationStatus? hzzzzzzzzzzl_ = hzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> hzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzl_);
            string hzzzzzzzzzzn_ = context.Operators.Convert<string>(hzzzzzzzzzzm_);
            string[] hzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzp_ = context.Operators.In<string>(hzzzzzzzzzzn_, hzzzzzzzzzzo_ as IEnumerable<string>);
            bool? hzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzj_, hzzzzzzzzzzp_);

            return hzzzzzzzzzzq_;
        };
        IEnumerable<Observation> gzzzzzzzzzzv_ = context.Operators.Where<Observation>(gzzzzzzzzzzt_, gzzzzzzzzzzu_);

        return gzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzr_ = this.Cup_to_Disc_Ratio_Performed_with_Result(context);
        bool? hzzzzzzzzzzs_ = context.Operators.Exists<Observation>(hzzzzzzzzzzr_);
        IEnumerable<Observation> hzzzzzzzzzzt_ = this.Optic_Disc_Exam_Performed_with_Result(context);
        bool? hzzzzzzzzzzu_ = context.Operators.Exists<Observation>(hzzzzzzzzzzt_);
        bool? hzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzs_, hzzzzzzzzzzu_);

        return hzzzzzzzzzzv_;
    }


    #endregion Expressions

}
