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
[CqlLibrary("HIVScreeningFHIR", "0.2.000")]
public partial class HIVScreeningFHIR_0_2_000 : ILibrary, ISingleton<HIVScreeningFHIR_0_2_000>
{
    private HIVScreeningFHIR_0_2_000() {}

    public static HIVScreeningFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVScreeningFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", valueSetVersion: null)]
    public CqlValueSet Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(CqlContext _) => _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_;
    private static readonly CqlValueSet _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("HIV 1 and 2 tests - Meaningful Use set", codeId: "75622-1", codeSystem: "http://loinc.org")]
    public CqlCode HIV_1_and_2_tests___Meaningful_Use_set(CqlContext _) => _HIV_1_and_2_tests___Meaningful_Use_set;
    private static readonly CqlCode _HIV_1_and_2_tests___Meaningful_Use_set = new CqlCode("75622-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatus")]
    public CqlCodeSystem ConditionVerificationStatus(CqlContext _) => _ConditionVerificationStatus;
    private static readonly CqlCodeSystem _ConditionVerificationStatus = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzy_ = context.Operators.Interval(gzzzzzzw_, gzzzzzzx_, true, true);
        object gzzzzzzz_ = context.ResolveParameter("HIVScreeningFHIR-0.2.000", "Measurement Period", gzzzzzzy_);

        return (CqlInterval<CqlDateTime>)gzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzb_ = context.Operators.SingletonFrom<Patient>(hzzzzzza_);

        return hzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet hzzzzzzc_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> hzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzze_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> hzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzg_ = context.Operators.Union<Encounter>(hzzzzzzd_, hzzzzzzf_);
        CqlValueSet hzzzzzzh_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> hzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzj_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> hzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzl_ = context.Operators.Union<Encounter>(hzzzzzzi_, hzzzzzzk_);
        IEnumerable<Encounter> hzzzzzzm_ = context.Operators.Union<Encounter>(hzzzzzzg_, hzzzzzzl_);
        CqlValueSet hzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzp_ = context.Operators.Union<Encounter>(hzzzzzzm_, hzzzzzzo_);
        bool? hzzzzzzq_(Encounter Encounter)
        {
            CqlInterval<CqlDateTime> hzzzzzzs_ = this.Measurement_Period(context);
            Period hzzzzzzt_ = Encounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzt_);
            bool? hzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzs_, hzzzzzzu_, "day");
            Code<Encounter.EncounterStatus> hzzzzzzw_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? hzzzzzzx_ = hzzzzzzw_?.Value;
            Code<Encounter.EncounterStatus> hzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzx_);
            bool? hzzzzzzz_ = context.Operators.Equal(hzzzzzzy_, "finished");
            bool? izzzzzza_ = context.Operators.And(hzzzzzzv_, hzzzzzzz_);

            return izzzzzza_;
        };
        IEnumerable<Encounter> hzzzzzzr_ = context.Operators.Where<Encounter>(hzzzzzzp_, hzzzzzzq_);

        return hzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient izzzzzzb_ = this.Patient(context);
        Date izzzzzzc_ = izzzzzzb_?.BirthDateElement;
        string izzzzzzd_ = izzzzzzc_?.Value;
        CqlDate izzzzzze_ = context.Operators.ConvertStringToDate(izzzzzzd_);
        CqlInterval<CqlDateTime> izzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzg_ = context.Operators.Start(izzzzzzf_);
        CqlDate izzzzzzh_ = context.Operators.DateFrom(izzzzzzg_);
        int? izzzzzzi_ = context.Operators.CalculateAgeAt(izzzzzze_, izzzzzzh_, "year");
        CqlInterval<int?> izzzzzzj_ = context.Operators.Interval(15, 65, true, true);
        bool? izzzzzzk_ = context.Operators.In<int?>(izzzzzzi_, izzzzzzj_, default);
        IEnumerable<Encounter> izzzzzzl_ = this.Qualifying_Encounters(context);
        bool? izzzzzzm_ = context.Operators.Exists<Encounter>(izzzzzzl_);
        bool? izzzzzzn_ = context.Operators.And(izzzzzzk_, izzzzzzm_);

        return izzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? izzzzzzo_ = this.Initial_Population(context);

        return izzzzzzo_;
    }


    [CqlExpressionDefinition("Has HIV Test Performed")]
    public bool? Has_HIV_Test_Performed(CqlContext context)
    {
        CqlValueSet izzzzzzp_ = this.Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(context);
        IEnumerable<Observation> izzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode izzzzzzr_ = this.HIV_1_and_2_tests___Meaningful_Use_set(context);
        IEnumerable<CqlCode> izzzzzzs_ = context.Operators.ToList<CqlCode>(izzzzzzr_);
        IEnumerable<Observation> izzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzu_ = context.Operators.Union<Observation>(izzzzzzq_, izzzzzzt_);
        bool? izzzzzzv_(Observation HIVTest)
        {
            DataType izzzzzzy_ = HIVTest?.Value;
            object izzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzy_);
            bool? jzzzzzza_ = context.Operators.Not((bool?)(izzzzzzz_ is null));
            Patient jzzzzzzb_ = this.Patient(context);
            Date jzzzzzzc_ = jzzzzzzb_?.BirthDateElement;
            string jzzzzzzd_ = jzzzzzzc_?.Value;
            CqlDate jzzzzzze_ = context.Operators.ConvertStringToDate(jzzzzzzd_);
            DataType jzzzzzzf_ = HIVTest?.Effective;
            object jzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzg_);
            CqlDateTime jzzzzzzi_ = context.Operators.Start(jzzzzzzh_);
            CqlDate jzzzzzzj_ = context.Operators.DateFrom(jzzzzzzi_);
            int? jzzzzzzk_ = context.Operators.CalculateAgeAt(jzzzzzze_, jzzzzzzj_, "year");
            CqlInterval<int?> jzzzzzzl_ = context.Operators.Interval(15, 65, true, true);
            bool? jzzzzzzm_ = context.Operators.In<int?>(jzzzzzzk_, jzzzzzzl_, default);
            bool? jzzzzzzn_ = context.Operators.And(jzzzzzza_, jzzzzzzm_);
            object jzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzp_);
            CqlDateTime jzzzzzzr_ = context.Operators.Start(jzzzzzzq_);
            CqlInterval<CqlDateTime> jzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzt_ = context.Operators.End(jzzzzzzs_);
            bool? jzzzzzzu_ = context.Operators.Before(jzzzzzzr_, jzzzzzzt_, default);
            bool? jzzzzzzv_ = context.Operators.And(jzzzzzzn_, jzzzzzzu_);
            Code<ObservationStatus> jzzzzzzw_ = HIVTest?.StatusElement;
            ObservationStatus? jzzzzzzx_ = jzzzzzzw_?.Value;
            Code<ObservationStatus> jzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzx_);
            bool? jzzzzzzz_ = context.Operators.Equal(jzzzzzzy_, "final");
            ObservationStatus? kzzzzzzb_ = jzzzzzzw_?.Value;
            Code<ObservationStatus> kzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzb_);
            bool? kzzzzzzd_ = context.Operators.Equal(kzzzzzzc_, "amended");
            bool? kzzzzzze_ = context.Operators.Or(jzzzzzzz_, kzzzzzzd_);
            ObservationStatus? kzzzzzzg_ = jzzzzzzw_?.Value;
            Code<ObservationStatus> kzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzg_);
            bool? kzzzzzzi_ = context.Operators.Equal(kzzzzzzh_, "corrected");
            bool? kzzzzzzj_ = context.Operators.Or(kzzzzzze_, kzzzzzzi_);
            bool? kzzzzzzk_ = context.Operators.And(jzzzzzzv_, kzzzzzzj_);

            return kzzzzzzk_;
        };
        IEnumerable<Observation> izzzzzzw_ = context.Operators.Where<Observation>(izzzzzzu_, izzzzzzv_);
        bool? izzzzzzx_ = context.Operators.Exists<Observation>(izzzzzzw_);

        return izzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? kzzzzzzl_ = this.Has_HIV_Test_Performed(context);

        return kzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet kzzzzzzm_ = this.HIV(context);
        IEnumerable<Condition> kzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzo_(Condition HIV)
        {
            CqlInterval<CqlDateTime> kzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime kzzzzzzs_ = context.Operators.Start(kzzzzzzr_);
            CqlInterval<CqlDateTime> kzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzu_ = context.Operators.Start(kzzzzzzt_);
            bool? kzzzzzzv_ = context.Operators.Before(kzzzzzzs_, kzzzzzzu_, "day");
            CodeableConcept kzzzzzzw_ = HIV?.VerificationStatus;
            CqlConcept kzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzw_);
            CqlCode kzzzzzzy_ = this.refuted(context);
            CqlConcept kzzzzzzz_ = context.Operators.ConvertCodeToConcept(kzzzzzzy_);
            bool? lzzzzzza_ = context.Operators.Equivalent(kzzzzzzx_, kzzzzzzz_);
            bool? lzzzzzzb_ = context.Operators.Not(lzzzzzza_);
            bool? lzzzzzzc_ = context.Operators.And(kzzzzzzv_, lzzzzzzb_);

            return lzzzzzzc_;
        };
        IEnumerable<Condition> kzzzzzzp_ = context.Operators.Where<Condition>(kzzzzzzn_, kzzzzzzo_);
        bool? kzzzzzzq_ = context.Operators.Exists<Condition>(kzzzzzzp_);

        return kzzzzzzq_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient lzzzzzzd_ = this.Patient(context);
        DataType lzzzzzze_ = lzzzzzzd_?.Deceased;
        object lzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzze_);
        CqlInterval<CqlDateTime> lzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzh_ = context.Operators.End(lzzzzzzg_);
        bool? lzzzzzzi_ = context.Operators.SameOrBefore(lzzzzzzf_ as CqlDateTime, lzzzzzzh_, default);

        return lzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? lzzzzzzj_ = this.Patient_Expired(context);

        return lzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> lzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return lzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return lzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return lzzzzzzn_;
    }


    #endregion Expressions

}
