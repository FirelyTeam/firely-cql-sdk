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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("AlaraCommonFunctions", "1.5.000")]
public partial class AlaraCommonFunctions_1_5_000 : ILibrary, ISingleton<AlaraCommonFunctions_1_5_000>
{
    private AlaraCommonFunctions_1_5_000() {}

    public static AlaraCommonFunctions_1_5_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "AlaraCommonFunctions";
    string ILibrary.Version => "1.5.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Abdomen and Pelvis High Dose")]
    public CqlCode Abdomen_and_Pelvis_High_Dose(CqlContext context) =>
        new CqlCode("LA31754-7", "http://loinc.org", default, default);



    [CqlDeclaration("Abdomen and Pelvis Low Dose")]
    public CqlCode Abdomen_and_Pelvis_Low_Dose(CqlContext context) =>
        new CqlCode("LA31752-1", "http://loinc.org", default, default);



    [CqlDeclaration("Abdomen and Pelvis Routine Dose")]
    public CqlCode Abdomen_and_Pelvis_Routine_Dose(CqlContext context) =>
        new CqlCode("LA31753-9", "http://loinc.org", default, default);



    [CqlDeclaration("Calculated CT global noise")]
    public CqlCode Calculated_CT_global_noise(CqlContext context) =>
        new CqlCode("96912-1", "http://loinc.org", default, default);



    [CqlDeclaration("Calculated CT size-adjusted dose")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext context) =>
        new CqlCode("96913-9", "http://loinc.org", default, default);



    [CqlDeclaration("Cardiac High Dose or Chest High Dose")]
    public CqlCode Cardiac_High_Dose_or_Chest_High_Dose(CqlContext context) =>
        new CqlCode("LA31761-2", "http://loinc.org", default, default);



    [CqlDeclaration("Cardiac Low Dose")]
    public CqlCode Cardiac_Low_Dose(CqlContext context) =>
        new CqlCode("LA31755-4", "http://loinc.org", default, default);



    [CqlDeclaration("Cardiac Routine Dose")]
    public CqlCode Cardiac_Routine_Dose(CqlContext context) =>
        new CqlCode("LA31756-2", "http://loinc.org", default, default);



    [CqlDeclaration("Chest Low Dose")]
    public CqlCode Chest_Low_Dose(CqlContext context) =>
        new CqlCode("LA31758-8", "http://loinc.org", default, default);



    [CqlDeclaration("Chest Routine Dose")]
    public CqlCode Chest_Routine_Dose(CqlContext context) =>
        new CqlCode("LA31759-6", "http://loinc.org", default, default);



    [CqlDeclaration("Extremity")]
    public CqlCode Extremity(CqlContext context) =>
        new CqlCode("LA31765-3", "http://loinc.org", default, default);



    [CqlDeclaration("Head High Dose")]
    public CqlCode Head_High_Dose(CqlContext context) =>
        new CqlCode("LA31764-6", "http://loinc.org", default, default);



    [CqlDeclaration("Head Low Dose")]
    public CqlCode Head_Low_Dose(CqlContext context) =>
        new CqlCode("LA31762-0", "http://loinc.org", default, default);



    [CqlDeclaration("Head Routine Dose")]
    public CqlCode Head_Routine_Dose(CqlContext context) =>
        new CqlCode("LA31763-8", "http://loinc.org", default, default);



    [CqlDeclaration("Neck or Cervical Spine")]
    public CqlCode Neck_or_Cervical_Spine(CqlContext context) =>
        new CqlCode("LA31766-1", "http://loinc.org", default, default);



    [CqlDeclaration("Simultaneous Chest and Abdomen and Pelvis")]
    public CqlCode Simultaneous_Chest_and_Abdomen_and_Pelvis(CqlContext context) =>
        new CqlCode("LA31768-7", "http://loinc.org", default, default);



    [CqlDeclaration("Simultaneous Head and Neck High Dose")]
    public CqlCode Simultaneous_Head_and_Neck_High_Dose(CqlContext context) =>
        new CqlCode("LA31770-3", "http://loinc.org", default, default);



    [CqlDeclaration("Simultaneous Head and Neck Routine Dose")]
    public CqlCode Simultaneous_Head_and_Neck_Routine_Dose(CqlContext context) =>
        new CqlCode("LA31769-5", "http://loinc.org", default, default);



    [CqlDeclaration("Simultaneous Thoracic and Lumbar Spine")]
    public CqlCode Simultaneous_Thoracic_and_Lumbar_Spine(CqlContext context) =>
        new CqlCode("LA31851-1", "http://loinc.org", default, default);



    [CqlDeclaration("Thoracic or Lumbar Spine")]
    public CqlCode Thoracic_or_Lumbar_Spine(CqlContext context) =>
        new CqlCode("LA31767-9", "http://loinc.org", default, default);



    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("LA31754-7", "http://loinc.org", default, default),
            new CqlCode("LA31752-1", "http://loinc.org", default, default),
            new CqlCode("LA31753-9", "http://loinc.org", default, default),
            new CqlCode("96912-1", "http://loinc.org", default, default),
            new CqlCode("96913-9", "http://loinc.org", default, default),
            new CqlCode("LA31761-2", "http://loinc.org", default, default),
            new CqlCode("LA31755-4", "http://loinc.org", default, default),
            new CqlCode("LA31756-2", "http://loinc.org", default, default),
            new CqlCode("LA31758-8", "http://loinc.org", default, default),
            new CqlCode("LA31759-6", "http://loinc.org", default, default),
            new CqlCode("LA31765-3", "http://loinc.org", default, default),
            new CqlCode("LA31764-6", "http://loinc.org", default, default),
            new CqlCode("LA31762-0", "http://loinc.org", default, default),
            new CqlCode("LA31763-8", "http://loinc.org", default, default),
            new CqlCode("LA31766-1", "http://loinc.org", default, default),
            new CqlCode("LA31768-7", "http://loinc.org", default, default),
            new CqlCode("LA31770-3", "http://loinc.org", default, default),
            new CqlCode("LA31769-5", "http://loinc.org", default, default),
            new CqlCode("LA31851-1", "http://loinc.org", default, default),
            new CqlCode("LA31767-9", "http://loinc.org", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> a_ = Obs?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            CodeableConcept h_ = C?.Code;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            CqlCode j_ = this.Calculated_CT_global_noise(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            DataType m_ = C?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            string o_ = (n_ as CqlQuantity)?.unit;
            bool? p_ = context.Operators.Equal(o_, "[hnsf'U]");
            bool? q_ = context.Operators.And(l_, p_);

            return q_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            decimal? t_ = (s_ as CqlQuantity)?.value;

            return t_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> a_ = Obs?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            CodeableConcept h_ = C?.Code;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            CqlCode j_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            DataType m_ = C?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            string o_ = (n_ as CqlQuantity)?.unit;
            bool? p_ = context.Operators.Equal(o_, "mGy.cm");
            bool? q_ = context.Operators.And(l_, p_);

            return q_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            decimal? t_ = (s_ as CqlQuantity)?.value;

            return t_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Obs?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlCode[] c_ = (b_ as CqlConcept)?.codes;
        bool? d_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)c_, code);
        decimal? e_ = this.Global_Noise_Value(context, Obs);
        bool? f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
        decimal? g_ = this.Size_Adjusted_Value(context, Obs);
        bool? h_ = context.Operators.GreaterOrEqual(g_, sizeDoseThreshold);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.And(d_, i_);

        return j_;
    }


    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode a_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? b_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? d_ = this.Qualifies(context, Obs, a_, b_, c_);
        CqlCode e_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? f_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? g_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? h_ = this.Qualifies(context, Obs, e_, f_, g_);
        bool? i_ = context.Operators.Or(d_, h_);
        CqlCode j_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? l_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? m_ = this.Qualifies(context, Obs, j_, f_, l_);
        bool? n_ = context.Operators.Or(i_, m_);
        CqlCode o_ = this.Cardiac_Low_Dose(context);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? q_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? r_ = this.Qualifies(context, Obs, o_, p_, q_);
        bool? s_ = context.Operators.Or(n_, r_);
        CqlCode t_ = this.Cardiac_Routine_Dose(context);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? v_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? w_ = this.Qualifies(context, Obs, t_, u_, v_);
        bool? x_ = context.Operators.Or(s_, w_);
        CqlCode y_ = this.Chest_Low_Dose(context);
        decimal? aa_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? ab_ = this.Qualifies(context, Obs, y_, p_, aa_);
        bool? ac_ = context.Operators.Or(x_, ab_);
        CqlCode ad_ = this.Chest_Routine_Dose(context);
        decimal? ae_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? ag_ = this.Qualifies(context, Obs, ad_, ae_, aa_);
        bool? ah_ = context.Operators.Or(ac_, ag_);
        CqlCode ai_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? al_ = this.Qualifies(context, Obs, ai_, ae_, ak_);
        bool? am_ = context.Operators.Or(ah_, al_);
        CqlCode an_ = this.Head_Low_Dose(context);
        decimal? ao_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? ap_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? aq_ = this.Qualifies(context, Obs, an_, ao_, ap_);
        bool? ar_ = context.Operators.Or(am_, aq_);
        CqlCode as_ = this.Head_Routine_Dose(context);
        decimal? au_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? av_ = this.Qualifies(context, Obs, as_, ao_, au_);
        bool? aw_ = context.Operators.Or(ar_, av_);
        CqlCode ax_ = this.Head_High_Dose(context);
        decimal? az_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? ba_ = this.Qualifies(context, Obs, ax_, ao_, az_);
        bool? bb_ = context.Operators.Or(aw_, ba_);
        CqlCode bc_ = this.Extremity(context);
        decimal? bd_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? be_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? bf_ = this.Qualifies(context, Obs, bc_, bd_, be_);
        bool? bg_ = context.Operators.Or(bb_, bf_);
        CqlCode bh_ = this.Neck_or_Cervical_Spine(context);
        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? bk_ = this.Qualifies(context, Obs, bh_, bi_, l_);
        bool? bl_ = context.Operators.Or(bg_, bk_);
        CqlCode bm_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? bp_ = this.Qualifies(context, Obs, bm_, bi_, l_);
        bool? bq_ = context.Operators.Or(bl_, bp_);
        CqlCode br_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bt_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? bu_ = this.Qualifies(context, Obs, br_, f_, bt_);
        bool? bv_ = context.Operators.Or(bq_, bu_);
        CqlCode bw_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? by_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? bz_ = this.Qualifies(context, Obs, bw_, bi_, by_);
        bool? ca_ = context.Operators.Or(bv_, bz_);
        CqlCode cb_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? cd_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? ce_ = this.Qualifies(context, Obs, cb_, bi_, cd_);
        bool? cf_ = context.Operators.Or(ca_, ce_);
        CqlCode cg_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? ci_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? cj_ = this.Qualifies(context, Obs, cg_, bi_, ci_);
        bool? ck_ = context.Operators.Or(cf_, cj_);

        return ck_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseResult1000", "EarlierGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["KCCQLifeQuality", "KCCQSymptomStability", "KCCQSelfEfficacy", "KCCQSymptoms", "KCCQPhysicalLimits", "KCCQSocialLimits"]);

    private static CqlTupleMetadata CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["QualifyingEncounter", "LowGlucoseTest", "FollowupGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36OrthogonalDate", "FollowupVR36OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS10Date", "FollowupPROMIS10Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
        [typeof(Encounter), typeof(Condition)],
        ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialMLHFQDate", "FollowupMLHFQDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
        [typeof(Encounter), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
        [typeof(CqlDate)],
        ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstRespRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new(
        [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
        ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OfficeVisit1", "OfficeVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["Promis29Sleep", "Promis29SocialRoles", "Promis29Physical", "Promis29Pain", "Promis29Fatigue", "Promis29Depression", "Promis29Anxiety"]);

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj = new(
        [typeof(Observation), typeof(Observation)],
        ["KCCQ12Item", "KCCQ12Summary"]);

    private static CqlTupleMetadata CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQTotalScore", "FollowupKCCQTotalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    private static CqlTupleMetadata CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS29Date", "FollowupPROMIS29Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK = new(
        [typeof(Observation), typeof(Observation)],
        ["VR36MentalAssessment", "VR36PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf = new(
        [typeof(Observation), typeof(Observation)],
        ["MLHFQPhysical", "MLHFQEmotional"]);

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["period", "periodStart"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQ12Date", "FollowupKCCQ12Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN = new(
        [typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?), typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?)],
        ["FirstUSSAssessment", "FollowUpUSSAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
        [typeof(Observation), typeof(Encounter)],
        ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    private static CqlTupleMetadata CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12ObliqueDate", "FollowupVR12ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO = new(
        [typeof(Encounter), typeof(MedicationAdministration), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicMedication", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga = new(
        [typeof(CqlDateTime), typeof(int?)],
        ["effectiveDatetime", "valueInteger"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
        [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["HOOSLifeQuality", "HOOSSport", "HOOSActivityScore", "HOOSSymptoms", "HOOSPain"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQAssessmentDate", "FollowupKCCQAssessmentDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    private static CqlTupleMetadata CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36ObliqueDate", "FollowupVR36ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12OrthogonalDate", "FollowupVR12OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayNumber", "dayPeriod"]);

}
