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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS145FHIRCADBBlockerTPMIorLVSD", "1.0.000")]
public partial class CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000 : ILibrary, ISingleton<CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000>
{
    private CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000() {}

    public static CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS145FHIRCADBBlockerTPMIorLVSD";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AHAOverall_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Allergy to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", valueSetVersion: null)]
    public CqlValueSet Allergy_to_Beta_Blocker_Therapy(CqlContext _) => _Allergy_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Allergy_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", null);

    [CqlValueSetDefinition("Arrhythmia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", valueSetVersion: null)]
    public CqlValueSet Arrhythmia(CqlContext _) => _Arrhythmia;
    private static readonly CqlValueSet _Arrhythmia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", null);

    [CqlValueSetDefinition("Asthma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", valueSetVersion: null)]
    public CqlValueSet Asthma(CqlContext _) => _Asthma;
    private static readonly CqlValueSet _Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", null);

    [CqlValueSetDefinition("Atrioventricular Block", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", valueSetVersion: null)]
    public CqlValueSet Atrioventricular_Block(CqlContext _) => _Atrioventricular_Block;
    private static readonly CqlValueSet _Atrioventricular_Block = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", null);

    [CqlValueSetDefinition("Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1174", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy(CqlContext _) => _Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1174", null);

    [CqlValueSetDefinition("Beta Blocker Therapy for LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_for_LVSD(CqlContext _) => _Beta_Blocker_Therapy_for_LVSD;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_for_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", null);

    [CqlValueSetDefinition("Beta Blocker Therapy Ingredient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_Ingredient(CqlContext _) => _Beta_Blocker_Therapy_Ingredient;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", null);

    [CqlValueSetDefinition("Bradycardia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", valueSetVersion: null)]
    public CqlValueSet Bradycardia(CqlContext _) => _Bradycardia;
    private static readonly CqlValueSet _Bradycardia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", null);

    [CqlValueSetDefinition("Cardiac Pacer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer(CqlContext _) => _Cardiac_Pacer;
    private static readonly CqlValueSet _Cardiac_Pacer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", null);

    [CqlValueSetDefinition("Cardiac Pacer in Situ", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer_in_Situ(CqlContext _) => _Cardiac_Pacer_in_Situ;
    private static readonly CqlValueSet _Cardiac_Pacer_in_Situ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", null);

    [CqlValueSetDefinition("Cardiac Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.371", valueSetVersion: null)]
    public CqlValueSet Cardiac_Surgery(CqlContext _) => _Cardiac_Surgery;
    private static readonly CqlValueSet _Cardiac_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.371", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Coronary Artery Disease No MI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.369", valueSetVersion: null)]
    public CqlValueSet Coronary_Artery_Disease_No_MI(CqlContext _) => _Coronary_Artery_Disease_No_MI;
    private static readonly CqlValueSet _Coronary_Artery_Disease_No_MI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.369", null);

    [CqlValueSetDefinition("Ejection Fraction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", valueSetVersion: null)]
    public CqlValueSet Ejection_Fraction(CqlContext _) => _Ejection_Fraction;
    private static readonly CqlValueSet _Ejection_Fraction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Hypotension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", valueSetVersion: null)]
    public CqlValueSet Hypotension(CqlContext _) => _Hypotension;
    private static readonly CqlValueSet _Hypotension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", null);

    [CqlValueSetDefinition("Intolerance to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", valueSetVersion: null)]
    public CqlValueSet Intolerance_to_Beta_Blocker_Therapy(CqlContext _) => _Intolerance_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Intolerance_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Moderate or Severe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe(CqlContext _) => _Moderate_or_Severe;
    private static readonly CqlValueSet _Moderate_or_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", null);

    [CqlValueSetDefinition("Moderate or Severe LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext _) => _Moderate_or_Severe_LVSD;
    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

    [CqlValueSetDefinition("Myocardial Infarction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", valueSetVersion: null)]
    public CqlValueSet Myocardial_Infarction(CqlContext _) => _Myocardial_Infarction;
    private static readonly CqlValueSet _Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Provider Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", valueSetVersion: null)]
    public CqlValueSet Patient_Provider_Interaction(CqlContext _) => _Patient_Provider_Interaction;
    private static readonly CqlValueSet _Patient_Provider_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("System Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1009", valueSetVersion: null)]
    public CqlValueSet System_Reason(CqlContext _) => _System_Reason;
    private static readonly CqlValueSet _System_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1009", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Substance with beta adrenergic receptor antagonist mechanism of action (substance)", codeId: "373254001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS145FHIRCADBBlockerTPMIorLVSD-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Outpatient_Consultation(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Nursing_Facility_Visit(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet n_ = this.Patient_Provider_Interaction(context);
                IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);

                bool? r_(Encounter ValidEncounter) {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    Period u_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, "day");
                    Code<Encounter.EncounterStatus> x_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? y_ = x_?.Value;
                    Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
                    bool? aa_ = context.Operators.Equal(z_, "finished");
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
                return s_;
            });


    private Cached<IEnumerable<Encounter>> _Outpatient_Encounter_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Outpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Outpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        _Outpatient_Encounter_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Outpatient_Consultation(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Nursing_Facility_Visit(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);

                bool? o_(Encounter QualifyingEncounter) {
                    CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                    Period r_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
                    Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
                    Encounter.EncounterStatus? v_ = u_?.Value;
                    Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                    bool? x_ = context.Operators.Equal(w_, "finished");
                    bool? y_ = context.Operators.And(t_, x_);
                    return y_;
                }

                IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
                return p_;
            });


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            bool? e_ = this.overlapsDayOfEncounter(context, Diagnosis, Visit);
            return e_;
        }

        IEnumerable<bool?> b_ = context.Operators.Select<Encounter, bool?>(EncounterList, a_);
        IEnumerable<bool?> c_ = context.Operators.Distinct<bool?>(b_);
        bool? d_ = context.Operators.AnyTrue(c_);
        return d_;
    }


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        bool? b_(Encounter Visit) {
            bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, Diagnosis as object);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)a_, b_);

        bool? d_(Encounter Visit) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Diagnosis as object);
            Period j_ = Visit?.Period;
            CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
            bool? l_ = context.Operators.Overlaps(i_, k_, "day");
            return l_;
        }

        IEnumerable<bool?> e_ = context.Operators.Select<Encounter, bool?>(c_, d_);
        IEnumerable<bool?> f_ = context.Operators.Distinct<bool?>(e_);
        bool? g_ = context.Operators.SingletonFrom<bool?>(f_);
        return g_;
    }


    private Cached<IEnumerable<Encounter>> _Coronary_Artery_Disease_Encounter_Cached = new();

    [CqlExpressionDefinition("Coronary Artery Disease Encounter")]
    public IEnumerable<Encounter> Coronary_Artery_Disease_Encounter(CqlContext context) =>
        _Coronary_Artery_Disease_Encounter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Outpatient_Encounter_During_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter) {
                    CqlValueSet d_ = this.Coronary_Artery_Disease_No_MI(context);
                    IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                    IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                    IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);

                    bool? i_(object CoronaryArteryDisease) {
                        bool? m_ = this.overlapsDayOfEncounter(context, CoronaryArteryDisease as Condition, ValidQualifyingEncounter);
                        return m_;
                    }

                    IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                    Encounter k_(object CoronaryArteryDisease) => ValidQualifyingEncounter;
                    IEnumerable<Encounter> l_ = context.Operators.Select<object, Encounter>(j_, k_);
                    return l_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _History_of_Cardiac_Surgery_Prior_to_Encounter_Cached = new();

    [CqlExpressionDefinition("History of Cardiac Surgery Prior to Encounter")]
    public IEnumerable<Encounter> History_of_Cardiac_Surgery_Prior_to_Encounter(CqlContext context) =>
        _History_of_Cardiac_Surgery_Prior_to_Encounter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Outpatient_Encounter_During_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter) {
                    CqlValueSet d_ = this.Cardiac_Surgery(context);
                    IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                    bool? f_(Procedure CardiacSurgeryProcedure) {

                        object j_() {

                            bool v_() {
                                DataType z_ = CardiacSurgeryProcedure?.Performed;
                                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                                bool ab_ = aa_ is CqlDateTime;
                                return ab_;
                            }


                            bool w_() {
                                DataType ac_ = CardiacSurgeryProcedure?.Performed;
                                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                                bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                                return ae_;
                            }


                            bool x_() {
                                DataType af_ = CardiacSurgeryProcedure?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlQuantity;
                                return ah_;
                            }


                            bool y_() {
                                DataType ai_ = CardiacSurgeryProcedure?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                                return ak_;
                            }

                            if (v_())
                            {
                                DataType al_ = CardiacSurgeryProcedure?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                return (am_ as CqlDateTime) as object;
                            }
                            else if (w_())
                            {
                                DataType an_ = CardiacSurgeryProcedure?.Performed;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                return (ao_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (x_())
                            {
                                DataType ap_ = CardiacSurgeryProcedure?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                return (aq_ as CqlQuantity) as object;
                            }
                            else if (y_())
                            {
                                DataType ar_ = CardiacSurgeryProcedure?.Performed;
                                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                                return (as_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                        CqlDateTime l_ = context.Operators.Start(k_);
                        Period m_ = ValidQualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                        CqlDateTime o_ = context.Operators.End(n_);
                        bool? p_ = context.Operators.Before(l_, o_, default);
                        Code<EventStatus> q_ = CardiacSurgeryProcedure?.StatusElement;
                        EventStatus? r_ = q_?.Value;
                        string s_ = context.Operators.Convert<string>(r_);
                        bool? t_ = context.Operators.Equal(s_, "completed");
                        bool? u_ = context.Operators.And(p_, t_);
                        return u_;
                    }

                    IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
                    Encounter h_(Procedure CardiacSurgeryProcedure) => ValidQualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_CAD_Encounter_Cached = new();

    [CqlExpressionDefinition("Qualifying CAD Encounter")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter(CqlContext context) =>
        _Qualifying_CAD_Encounter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Coronary_Artery_Disease_Encounter(context);
                IEnumerable<Encounter> b_ = this.History_of_Cardiac_Surgery_Prior_to_Encounter(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
                IEnumerable<Encounter> j_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                IEnumerable<Encounter> k_(Encounter Encounter1) {
                    IEnumerable<Encounter> r_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                    bool? s_(Encounter Encounter2) {
                        Id w_ = Encounter2?.IdElement;
                        string x_ = w_?.Value;
                        Id y_ = Encounter1?.IdElement;
                        string z_ = y_?.Value;
                        bool? aa_ = context.Operators.Equivalent(x_, z_);
                        bool? ab_ = context.Operators.Not(aa_);
                        return ab_;
                    }

                    IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
                    Encounter u_(Encounter Encounter2) => Encounter1;
                    IEnumerable<Encounter> v_ = context.Operators.Select<Encounter, Encounter>(t_, u_);
                    return v_;
                }

                IEnumerable<Encounter> l_ = context.Operators.SelectMany<Encounter, Encounter>(j_, k_);
                bool? m_ = context.Operators.Exists<Encounter>(l_);
                bool? n_ = context.Operators.And(i_, m_);
                IEnumerable<Encounter> o_ = this.Qualifying_CAD_Encounter(context);
                bool? p_ = context.Operators.Exists<Encounter>(o_);
                bool? q_ = context.Operators.And(n_, p_);
                return q_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Qualifying CAD Encounter and Prior MI")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Qualifying_CAD_Encounter(context);

                IEnumerable<Encounter> b_(Encounter EncounterWithCADProxy) {
                    CqlValueSet d_ = this.Myocardial_Infarction(context);
                    IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                    IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                    IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);

                    bool? i_(object MyocardialInfarction) {
                        CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MyocardialInfarction);
                        CqlDateTime n_ = context.Operators.Start(m_);
                        Period o_ = EncounterWithCADProxy?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        CqlDateTime q_ = context.Operators.Start(p_);
                        CqlQuantity r_ = context.Operators.Quantity(3m, "years");
                        CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                        CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        CqlDateTime v_ = context.Operators.Start(u_);
                        CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, false);
                        bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, "day");
                        CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        CqlDateTime aa_ = context.Operators.Start(z_);
                        bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                        bool? ac_ = context.Operators.And(x_, ab_);
                        IEnumerable<object> ad_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);
                        bool? ae_ = context.Operators.Exists<object>(ad_);
                        bool? af_ = context.Operators.Not(ae_);
                        bool? ag_ = context.Operators.And(ac_, af_);
                        bool? ah_ = AHAOverall_4_1_000.Instance.isVerified(context, MyocardialInfarction);
                        bool? ai_ = context.Operators.And(ag_, ah_);
                        return ai_;
                    }

                    IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                    Encounter k_(object MyocardialInfarction) => EncounterWithCADProxy;
                    IEnumerable<Encounter> l_ = context.Operators.Select<object, Encounter>(j_, k_);
                    return l_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<bool?> _Denominator_2_Cached = new();

    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        _Denominator_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? c_ = context.Operators.Exists<Encounter>(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private Cached<bool?> _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Atrioventricular_Block(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition AtrioventricularBlockDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, AtrioventricularBlockDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition CardiacPacerDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Cardiac_Pacer(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

                    bool? g_(Encounter CADEncounterMI) {

                        object k_() {

                            bool w_() {
                                DataType aa_ = ImplantedCardiacPacer?.Performed;
                                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                                bool ac_ = ab_ is CqlDateTime;
                                return ac_;
                            }


                            bool x_() {
                                DataType ad_ = ImplantedCardiacPacer?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                bool af_ = ae_ is CqlInterval<CqlDateTime>;
                                return af_;
                            }


                            bool y_() {
                                DataType ag_ = ImplantedCardiacPacer?.Performed;
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                bool ai_ = ah_ is CqlQuantity;
                                return ai_;
                            }


                            bool z_() {
                                DataType aj_ = ImplantedCardiacPacer?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                bool al_ = ak_ is CqlInterval<CqlQuantity>;
                                return al_;
                            }

                            if (w_())
                            {
                                DataType am_ = ImplantedCardiacPacer?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                return (an_ as CqlDateTime) as object;
                            }
                            else if (x_())
                            {
                                DataType ao_ = ImplantedCardiacPacer?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                return (ap_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (y_())
                            {
                                DataType aq_ = ImplantedCardiacPacer?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                return (ar_ as CqlQuantity) as object;
                            }
                            else if (z_())
                            {
                                DataType as_ = ImplantedCardiacPacer?.Performed;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                return (at_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                        CqlDateTime m_ = context.Operators.Start(l_);
                        Period n_ = CADEncounterMI?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        CqlDateTime p_ = context.Operators.End(o_);
                        bool? q_ = context.Operators.Before(m_, p_, default);
                        Code<EventStatus> r_ = ImplantedCardiacPacer?.StatusElement;
                        EventStatus? s_ = r_?.Value;
                        string t_ = context.Operators.Convert<string>(s_);
                        bool? u_ = context.Operators.Equal(t_, "completed");
                        bool? v_ = context.Operators.And(q_, u_);
                        return v_;
                    }

                    IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
                    Procedure i_(Encounter CADEncounterMI) => ImplantedCardiacPacer;
                    IEnumerable<Procedure> j_ = context.Operators.Select<Encounter, Procedure>(h_, i_);
                    return j_;
                }

                IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
                bool? e_ = context.Operators.Exists<Procedure>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Cached = new();

    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer(CqlContext context) =>
        _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? c_ = context.Operators.Not(b_);
                bool? d_ = context.Operators.And(a_, c_);
                bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? f_ = context.Operators.Not(e_);
                bool? g_ = context.Operators.And(d_, f_);
                return g_;
            });


    private Cached<bool?> _Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and Prior MI")]
    [CqlTag("code", "Heart rate - 8867-4")]
    [CqlTag("profile", "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
                IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

                (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
                    (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? l_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(c_, d_);

                bool? f_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
                    Period m_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    DataType o_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, default);
                    Code<ObservationStatus> s_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.StatusElement;
                    ObservationStatus? t_ = s_?.Value;
                    string u_ = context.Operators.Convert<string>(t_);
                    string[] v_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                    bool? x_ = context.Operators.And(r_, w_);
                    DataType y_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Value;
                    CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
                    CqlQuantity aa_ = context.Operators.Quantity(50m, "/min");
                    bool? ab_ = context.Operators.Less(z_, aa_);
                    bool? ac_ = context.Operators.And(x_, ab_);
                    IEnumerable<Observation> ad_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                    bool? ae_(Observation MostRecentPriorHeartRateExam) {
                        Period ao_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
                        CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                        DataType aq_ = MostRecentPriorHeartRateExam?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                        bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, default);
                        Code<ObservationStatus> au_ = MostRecentPriorHeartRateExam?.StatusElement;
                        ObservationStatus? av_ = au_?.Value;
                        string aw_ = context.Operators.Convert<string>(av_);
                        string[] ax_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                        bool? az_ = context.Operators.And(at_, ay_);
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
                        DataType bd_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                        bool? bg_ = context.Operators.Before(bc_, bf_, default);
                        bool? bh_ = context.Operators.And(az_, bg_);
                        return bh_;
                    }

                    IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);

                    object ag_(Observation @this) {
                        DataType bi_ = @this?.Effective;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                        CqlDateTime bl_ = context.Operators.Start(bk_);
                        return bl_;
                    }

                    IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ai_ = context.Operators.Last<Observation>(ah_);
                    DataType aj_ = ai_?.Value;
                    CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                    bool? am_ = context.Operators.Less(ak_, aa_);
                    bool? an_ = context.Operators.And(ac_, am_);
                    return an_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(e_, f_);

                (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? h_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
                    (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? bm_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam, tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI);
                    return bm_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> i_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(g_, h_);
                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(i_);
                bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(j_);
                return k_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Qualifying_CAD_Encounter(context);

                IEnumerable<Encounter> b_(Encounter EncounterWithCADProxy) {
                    IEnumerable<object> d_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);

                    bool? e_(object LVSDFindings) {
                        CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVSDFindings as object);
                        object j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                        object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                        CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                        CqlDateTime m_ = context.Operators.Start(i_ ?? l_);
                        Period n_ = EncounterWithCADProxy?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        CqlDateTime p_ = context.Operators.End(o_);
                        bool? q_ = context.Operators.Before(m_, p_, default);
                        return q_;
                    }

                    IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                    Encounter g_(object LVSDFindings) => EncounterWithCADProxy;
                    IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    [CqlFunctionDefinition("authoredDuringDayOfEncounter")]
    public bool? authoredDuringDayOfEncounter(CqlContext context, object Order, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {

            bool? e_() {
                if (Order is MedicationRequest)
                {
                    object f_ = context.Operators.LateBoundProperty<object>(Order, "authoredOn");
                    CqlDateTime g_ = context.Operators.LateBoundProperty<CqlDateTime>(f_, "value");
                    Period h_ = Visit?.Period;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                    bool? j_ = context.Operators.In<CqlDateTime>(g_, i_, "day");
                    object k_ = context.Operators.LateBoundProperty<object>(Order, "status");
                    string l_ = context.Operators.LateBoundProperty<string>(k_, "value");
                    string[] m_ = [
                        "active",
                        "completed",
                    ];
                    bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                    bool? o_ = context.Operators.And(j_, n_);
                    object p_ = context.Operators.LateBoundProperty<object>(Order, "intent");
                    string q_ = context.Operators.LateBoundProperty<string>(p_, "value");
                    string[] r_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                    bool? t_ = context.Operators.And(o_, s_);
                    object u_ = context.Operators.LateBoundProperty<object>(Order, "doNotPerform");
                    bool? v_ = context.Operators.LateBoundProperty<bool?>(u_, "value");
                    bool? w_ = context.Operators.IsTrue(v_);
                    bool? x_ = context.Operators.Not(w_);
                    bool? y_ = context.Operators.And(t_, x_);
                    return y_;
                }
                else if (Order is MedicationRequest)
                {
                    object z_ = context.Operators.LateBoundProperty<object>(Order, "authoredOn");
                    CqlDateTime aa_ = context.Operators.LateBoundProperty<CqlDateTime>(z_, "value");
                    Period ab_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, "day");
                    object ae_ = context.Operators.LateBoundProperty<object>(Order, "intent");
                    string af_ = context.Operators.LateBoundProperty<string>(ae_, "value");
                    string[] ag_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    bool? ai_ = context.Operators.And(ad_, ah_);
                    return ai_;
                }
                else
                {
                    return false;
                };
            }

            return e_();
        }

        IEnumerable<bool?> b_ = context.Operators.Select<Encounter, bool?>(EncounterList, a_);
        IEnumerable<bool?> c_ = context.Operators.Distinct<bool?>(b_);
        bool? d_ = context.Operators.AnyTrue(c_);
        return d_;
    }


    private Cached<bool?> _Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Cached = new();

    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context) =>
        _Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                bool? c_(MedicationRequest BetaBlockerForLVSDOrdered) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.authoredDuringDayOfEncounter(context, BetaBlockerForLVSDOrdered as object, f_);
                    return g_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
                bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
                return e_;
            });


    private Cached<bool?> _Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Cached = new();

    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context) =>
        _Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> c_(MedicationRequest ActiveBetaBlockerForLVSD) {
                    IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

                    bool? i_(Encounter CADEncounterModerateOrSevereLVSD) {
                        List<Dosage> m_ = ActiveBetaBlockerForLVSD?.DosageInstruction;

                        bool? n_(Dosage @this) {
                            Timing aj_ = @this?.Timing;
                            bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                            return ak_;
                        }

                        IEnumerable<Dosage> o_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)m_, n_);

                        Timing p_(Dosage @this) {
                            Timing al_ = @this?.Timing;
                            return al_;
                        }

                        IEnumerable<Timing> q_ = context.Operators.Select<Dosage, Timing>(o_, p_);

                        bool? r_(Timing @this) {
                            Timing.RepeatComponent am_ = @this?.Repeat;
                            bool? an_ = context.Operators.Not((bool?)(am_ is null));
                            return an_;
                        }

                        IEnumerable<Timing> s_ = context.Operators.Where<Timing>(q_, r_);

                        Timing.RepeatComponent t_(Timing @this) {
                            Timing.RepeatComponent ao_ = @this?.Repeat;
                            return ao_;
                        }

                        IEnumerable<Timing.RepeatComponent> u_ = context.Operators.Select<Timing, Timing.RepeatComponent>(s_, t_);

                        bool? v_(Timing.RepeatComponent @this) {
                            DataType ap_ = @this?.Bounds;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                            return ar_;
                        }

                        IEnumerable<Timing.RepeatComponent> w_ = context.Operators.Where<Timing.RepeatComponent>(u_, v_);

                        object x_(Timing.RepeatComponent @this) {
                            DataType as_ = @this?.Bounds;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            return at_;
                        }

                        IEnumerable<object> y_ = context.Operators.Select<Timing.RepeatComponent, object>(w_, x_);

                        CqlInterval<CqlDateTime> z_(object DoseTime) {
                            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                            return au_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> aa_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(y_, z_);
                        IEnumerable<CqlInterval<CqlDateTime>> ab_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(aa_);
                        IEnumerable<CqlInterval<CqlDateTime>> ac_ = context.Operators.Collapse(ab_, default);

                        object ad_(CqlInterval<CqlDateTime> @this) {
                            CqlDateTime av_ = context.Operators.Start(@this);
                            return av_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
                        CqlInterval<CqlDateTime> af_ = context.Operators.First<CqlInterval<CqlDateTime>>(ae_);
                        Period ag_ = CADEncounterModerateOrSevereLVSD?.Period;
                        CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                        bool? ai_ = context.Operators.OverlapsAfter(af_, ah_, "day");
                        return ai_;
                    }

                    IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                    MedicationRequest k_(Encounter CADEncounterModerateOrSevereLVSD) => ActiveBetaBlockerForLVSD;
                    IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);
                    return l_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);

                bool? e_(MedicationRequest ActiveBetaBlockerForLVSD) {
                    Code<MedicationRequest.MedicationrequestStatus> aw_ = ActiveBetaBlockerForLVSD?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ax_ = aw_?.Value;
                    string ay_ = context.Operators.Convert<string>(ax_);
                    string[] az_ = [
                        "active",
                        "completed",
                    ];
                    bool? ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                    Code<MedicationRequest.MedicationRequestIntent> bb_ = ActiveBetaBlockerForLVSD?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? bc_ = bb_?.Value;
                    string bd_ = context.Operators.Convert<string>(bc_);
                    string[] be_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                    bool? bg_ = context.Operators.And(ba_, bf_);
                    return bg_;
                }

                IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
                bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
                return g_;
            });


    private Cached<bool?> _Numerator_1_Cached = new();

    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        _Numerator_1_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
                bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
                bool? c_ = context.Operators.Or(a_, b_);
                return c_;
            });


    private Cached<bool?> _Has_Beta_Blocker_Therapy_Ordered_Cached = new();

    [CqlExpressionDefinition("Has Beta Blocker Therapy Ordered")]
    public bool? Has_Beta_Blocker_Therapy_Ordered(CqlContext context) =>
        _Has_Beta_Blocker_Therapy_Ordered_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                bool? c_(MedicationRequest BetaBlockerOrdered) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.authoredDuringDayOfEncounter(context, BetaBlockerOrdered as object, f_);
                    return g_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
                bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
                return e_;
            });


    private Cached<bool?> _Is_Currently_Taking_Beta_Blocker_Therapy_Cached = new();

    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy(CqlContext context) =>
        _Is_Currently_Taking_Beta_Blocker_Therapy_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> c_(MedicationRequest ActiveBetaBlocker) {
                    IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

                    bool? i_(Encounter CADEncounterMI) {
                        List<Dosage> m_ = ActiveBetaBlocker?.DosageInstruction;

                        bool? n_(Dosage @this) {
                            Timing aj_ = @this?.Timing;
                            bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                            return ak_;
                        }

                        IEnumerable<Dosage> o_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)m_, n_);

                        Timing p_(Dosage @this) {
                            Timing al_ = @this?.Timing;
                            return al_;
                        }

                        IEnumerable<Timing> q_ = context.Operators.Select<Dosage, Timing>(o_, p_);

                        bool? r_(Timing @this) {
                            Timing.RepeatComponent am_ = @this?.Repeat;
                            bool? an_ = context.Operators.Not((bool?)(am_ is null));
                            return an_;
                        }

                        IEnumerable<Timing> s_ = context.Operators.Where<Timing>(q_, r_);

                        Timing.RepeatComponent t_(Timing @this) {
                            Timing.RepeatComponent ao_ = @this?.Repeat;
                            return ao_;
                        }

                        IEnumerable<Timing.RepeatComponent> u_ = context.Operators.Select<Timing, Timing.RepeatComponent>(s_, t_);

                        bool? v_(Timing.RepeatComponent @this) {
                            DataType ap_ = @this?.Bounds;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                            return ar_;
                        }

                        IEnumerable<Timing.RepeatComponent> w_ = context.Operators.Where<Timing.RepeatComponent>(u_, v_);

                        object x_(Timing.RepeatComponent @this) {
                            DataType as_ = @this?.Bounds;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            return at_;
                        }

                        IEnumerable<object> y_ = context.Operators.Select<Timing.RepeatComponent, object>(w_, x_);

                        CqlInterval<CqlDateTime> z_(object DoseTime) {
                            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                            return au_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> aa_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(y_, z_);
                        IEnumerable<CqlInterval<CqlDateTime>> ab_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(aa_);
                        IEnumerable<CqlInterval<CqlDateTime>> ac_ = context.Operators.Collapse(ab_, default);

                        object ad_(CqlInterval<CqlDateTime> @this) {
                            CqlDateTime av_ = context.Operators.Start(@this);
                            return av_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
                        CqlInterval<CqlDateTime> af_ = context.Operators.First<CqlInterval<CqlDateTime>>(ae_);
                        Period ag_ = CADEncounterMI?.Period;
                        CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                        bool? ai_ = context.Operators.OverlapsAfter(af_, ah_, "day");
                        return ai_;
                    }

                    IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                    MedicationRequest k_(Encounter CADEncounterMI) => ActiveBetaBlocker;
                    IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);
                    return l_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);

                bool? e_(MedicationRequest ActiveBetaBlocker) {
                    Code<MedicationRequest.MedicationrequestStatus> aw_ = ActiveBetaBlocker?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ax_ = aw_?.Value;
                    string ay_ = context.Operators.Convert<string>(ax_);
                    string[] az_ = [
                        "active",
                        "completed",
                    ];
                    bool? ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                    Code<MedicationRequest.MedicationRequestIntent> bb_ = ActiveBetaBlocker?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? bc_ = bb_?.Value;
                    string bd_ = context.Operators.Convert<string>(bc_);
                    string[] be_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                    bool? bg_ = context.Operators.And(ba_, bf_);
                    return bg_;
                }

                IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
                bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
                return g_;
            });


    private Cached<bool?> _Numerator_2_Cached = new();

    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        _Numerator_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Beta_Blocker_Therapy_Ordered(context);
                bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy(context);
                bool? c_ = context.Operators.Or(a_, b_);
                return c_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<bool?> _Denominator_1_Cached = new();

    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        _Denominator_1_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? c_ = context.Operators.Exists<Encounter>(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private Cached<bool?> _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Atrioventricular_Block(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition AtrioventricularBlock) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, AtrioventricularBlock, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition CardiacPacerDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Cardiac_Pacer(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

                    bool? g_(Encounter CADEncounterModerateOrSevereLVSD) {

                        object k_() {

                            bool r_() {
                                DataType v_ = ImplantedCardiacPacer?.Performed;
                                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                                bool x_ = w_ is CqlDateTime;
                                return x_;
                            }


                            bool s_() {
                                DataType y_ = ImplantedCardiacPacer?.Performed;
                                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                                bool aa_ = z_ is CqlInterval<CqlDateTime>;
                                return aa_;
                            }


                            bool t_() {
                                DataType ab_ = ImplantedCardiacPacer?.Performed;
                                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                                bool ad_ = ac_ is CqlQuantity;
                                return ad_;
                            }


                            bool u_() {
                                DataType ae_ = ImplantedCardiacPacer?.Performed;
                                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                                bool ag_ = af_ is CqlInterval<CqlQuantity>;
                                return ag_;
                            }

                            if (r_())
                            {
                                DataType ah_ = ImplantedCardiacPacer?.Performed;
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                return (ai_ as CqlDateTime) as object;
                            }
                            else if (s_())
                            {
                                DataType aj_ = ImplantedCardiacPacer?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                return (ak_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (t_())
                            {
                                DataType al_ = ImplantedCardiacPacer?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                return (am_ as CqlQuantity) as object;
                            }
                            else if (u_())
                            {
                                DataType an_ = ImplantedCardiacPacer?.Performed;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                return (ao_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                        CqlDateTime m_ = context.Operators.Start(l_);
                        Period n_ = CADEncounterModerateOrSevereLVSD?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        CqlDateTime p_ = context.Operators.End(o_);
                        bool? q_ = context.Operators.Before(m_, p_, default);
                        return q_;
                    }

                    IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
                    Procedure i_(Encounter CADEncounterModerateOrSevereLVSD) => ImplantedCardiacPacer;
                    IEnumerable<Procedure> j_ = context.Operators.Select<Encounter, Procedure>(h_, i_);
                    return j_;
                }

                IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
                bool? e_ = context.Operators.Exists<Procedure>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Cached = new();

    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer(CqlContext context) =>
        _Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? c_ = context.Operators.Not(b_);
                bool? d_ = context.Operators.And(a_, c_);
                bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? f_ = context.Operators.Not(e_);
                bool? g_ = context.Operators.And(d_, f_);
                return g_;
            });


    private Cached<bool?> _Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    [CqlTag("code", "Heart rate - 8867-4")]
    [CqlTag("profile", "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
                IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

                (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
                    (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? l_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(c_, d_);

                bool? f_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
                    Period m_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    DataType o_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, default);
                    Code<ObservationStatus> s_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.StatusElement;
                    ObservationStatus? t_ = s_?.Value;
                    string u_ = context.Operators.Convert<string>(t_);
                    string[] v_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                    bool? x_ = context.Operators.And(r_, w_);
                    DataType y_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Value;
                    CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
                    CqlQuantity aa_ = context.Operators.Quantity(50m, "/min");
                    bool? ab_ = context.Operators.Less(z_, aa_);
                    bool? ac_ = context.Operators.And(x_, ab_);
                    IEnumerable<Observation> ad_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                    bool? ae_(Observation MostRecentPriorHeartRateExam) {
                        Period ao_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
                        CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                        DataType aq_ = MostRecentPriorHeartRateExam?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                        bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, default);
                        Code<ObservationStatus> au_ = MostRecentPriorHeartRateExam?.StatusElement;
                        ObservationStatus? av_ = au_?.Value;
                        string aw_ = context.Operators.Convert<string>(av_);
                        string[] ax_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                        bool? az_ = context.Operators.And(at_, ay_);
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
                        DataType bd_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                        bool? bg_ = context.Operators.Before(bc_, bf_, default);
                        bool? bh_ = context.Operators.And(az_, bg_);
                        return bh_;
                    }

                    IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);

                    object ag_(Observation @this) {
                        DataType bi_ = @this?.Effective;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                        CqlDateTime bl_ = context.Operators.Start(bk_);
                        return bl_;
                    }

                    IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ai_ = context.Operators.Last<Observation>(ah_);
                    DataType aj_ = ai_?.Value;
                    CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                    bool? am_ = context.Operators.Less(ak_, aa_);
                    bool? an_ = context.Operators.And(ac_, am_);
                    return an_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(e_, f_);

                (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? h_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
                    (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? bm_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD);
                    return bm_;
                }

                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> i_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(g_, h_);
                IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(i_);
                bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(j_);
                return k_;
            });


    [CqlFunctionDefinition("overlapsAfterDayOfEncounter")]
    public bool? overlapsAfterDayOfEncounter(CqlContext context, object Event, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {

            bool? e_() {
                if (Event is AllergyIntolerance)
                {
                    object f_ = context.Operators.LateBoundProperty<object>(Event, "onset");
                    object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                    CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                    CqlDateTime i_ = context.Operators.Start(h_);
                    object j_ = context.Operators.LateBoundProperty<object>(Event, "lastOccurrence");
                    CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(j_, "value");
                    CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);
                    Period m_ = Visit?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    bool? o_ = context.Operators.OverlapsAfter(l_, n_, "day");
                    object p_ = context.Operators.LateBoundProperty<object>(Event, "clinicalStatus");
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_ as CodeableConcept);
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_ as CodeableConcept);
                    CqlCode t_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                    CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                    bool? v_ = context.Operators.Equivalent(s_, u_);
                    bool? w_ = context.Operators.Or((bool?)(q_ is null), v_);
                    bool? x_ = context.Operators.And(o_, w_);
                    object y_ = context.Operators.LateBoundProperty<object>(Event, "verificationStatus");
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlCode ac_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                    bool? ae_ = context.Operators.Equivalent(ab_, ad_);
                    bool? af_ = context.Operators.Or((bool?)(z_ is null), ae_);
                    bool? ag_ = context.Operators.And(x_, af_);
                    return ag_;
                }
                else if (Event is Condition)
                {
                    bool? ah_ = AHAOverall_4_1_000.Instance.isVerified(context, Event as AllergyIntolerance);
                    CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, (Event as Condition) as object);
                    Period aj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    bool? al_ = context.Operators.OverlapsAfter(ai_, ak_, "day");
                    bool? am_ = context.Operators.And(ah_, al_);
                    return am_;
                }
                else
                {
                    return false;
                };
            }

            return e_();
        }

        IEnumerable<bool?> b_ = context.Operators.Select<Encounter, bool?>(EncounterList, a_);
        IEnumerable<bool?> c_ = context.Operators.Distinct<bool?>(b_);
        bool? d_ = context.Operators.AnyTrue(c_);
        return d_;
    }


    private Cached<bool?> _Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
                IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
                CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
                IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
                IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
                IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

                bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
                    IEnumerable<Encounter> j_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? k_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance as object, j_);
                    return k_;
                }

                IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
                bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);
                return i_;
            });


    private Cached<bool?> _Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Arrhythmia with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Arrhythmia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition ArrhythmiaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Arrhythmia with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Arrhythmia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition ArrhythmiaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Asthma with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Asthma(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition AsthmaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Asthma with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Asthma(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition AsthmaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Bradycardia with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Bradycardia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition BradycardiaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Bradycardia with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Bradycardia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition BradycardiaDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);

                bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis) {
                    IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis as object, i_);
                    return j_;
                }

                IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
                bool? h_ = context.Operators.Exists<Condition>(g_);
                return h_;
            });


    private Cached<bool?> _Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);

                bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis) {
                    IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis as object, i_);
                    return j_;
                }

                IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
                bool? h_ = context.Operators.Exists<Condition>(g_);
                return h_;
            });


    private Cached<bool?> _Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Hypotension with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hypotension(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition HypotensionDiagnosis) {
                    IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? g_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis, f_);
                    return g_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached = new();

    [CqlExpressionDefinition("Has Hypotension with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        _Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hypotension(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

                bool? f_(object HypotensionDiagnosis) {
                    IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
                    bool? j_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis as Condition, i_);
                    return j_;
                }

                IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
                bool? h_ = context.Operators.Exists<object>(g_);
                return h_;
            });


    private Cached<bool?> _Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        _Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
                IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
                CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
                IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
                IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
                IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

                bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
                    IEnumerable<Encounter> j_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                    bool? k_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance as object, j_);
                    return k_;
                }

                IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
                bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);
                return i_;
            });


    private Cached<bool?> _Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Cached = new();

    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context) =>
        _Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

                IEnumerable<MedicationRequest> c_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
                    IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

                    bool? i_(Encounter LVSDVisit) {
                        FhirDateTime m_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                        CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                        Period o_ = LVSDVisit?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                        return q_;
                    }

                    IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                    MedicationRequest k_(Encounter LVSDVisit) => NoBetaBlockerForLVSDOrdered;
                    IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);
                    return l_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);

                bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
                    Code<MedicationRequest.MedicationrequestStatus> r_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    string[] u_ = [
                        "active",
                        "completed",
                    ];
                    bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                    Code<MedicationRequest.MedicationRequestIntent> w_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? x_ = w_?.Value;
                    string y_ = context.Operators.Convert<string>(x_);
                    string[] z_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                    bool? ab_ = context.Operators.And(v_, aa_);
                    List<CodeableConcept> ac_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                    CqlConcept ad_(CodeableConcept @this) {
                        CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ao_;
                    }

                    IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
                    CqlValueSet af_ = this.Medical_Reason(context);
                    bool? ag_ = context.Operators.ConceptsInValueSet(ae_, af_);

                    CqlConcept ai_(CodeableConcept @this) {
                        CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ap_;
                    }

                    IEnumerable<CqlConcept> aj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ai_);
                    CqlValueSet ak_ = this.Patient_Reason(context);
                    bool? al_ = context.Operators.ConceptsInValueSet(aj_, ak_);
                    bool? am_ = context.Operators.Or(ag_, al_);
                    bool? an_ = context.Operators.And(ab_, am_);
                    return an_;
                }

                IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
                bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
                return g_;
            });


    private Cached<bool?> _Denominator_Exceptions_1_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions 1")]
    public bool? Denominator_Exceptions_1(CqlContext context) =>
        _Denominator_Exceptions_1_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? b_ = this.Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? c_ = context.Operators.Or(a_, b_);
                bool? d_ = this.Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? e_ = context.Operators.Or(c_, d_);
                bool? f_ = this.Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? g_ = context.Operators.Or(e_, f_);
                bool? h_ = this.Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? i_ = context.Operators.Or(g_, h_);
                bool? j_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? k_ = context.Operators.Or(i_, j_);
                bool? l_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
                bool? m_ = context.Operators.Or(k_, l_);
                bool? n_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(context);
                bool? o_ = context.Operators.Or(m_, n_);
                bool? p_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer(context);
                bool? q_ = context.Operators.Or(o_, p_);
                return q_;
            });


    private Cached<bool?> _Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy_Cached = new();

    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker Therapy")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy(CqlContext context) =>
        _Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

                IEnumerable<MedicationRequest> c_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
                    IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

                    bool? i_(Encounter PriorMIVisit) {
                        FhirDateTime m_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                        CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                        Period o_ = PriorMIVisit?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                        return q_;
                    }

                    IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                    MedicationRequest k_(Encounter PriorMIVisit) => NoBetaBlockerForLVSDOrdered;
                    IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);
                    return l_;
                }

                IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);

                bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
                    Code<MedicationRequest.MedicationrequestStatus> r_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    string[] u_ = [
                        "active",
                        "completed",
                    ];
                    bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                    Code<MedicationRequest.MedicationRequestIntent> w_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? x_ = w_?.Value;
                    string y_ = context.Operators.Convert<string>(x_);
                    string[] z_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                    bool? ab_ = context.Operators.And(v_, aa_);
                    List<CodeableConcept> ac_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                    CqlConcept ad_(CodeableConcept @this) {
                        CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ao_;
                    }

                    IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
                    CqlValueSet af_ = this.Medical_Reason(context);
                    bool? ag_ = context.Operators.ConceptsInValueSet(ae_, af_);

                    CqlConcept ai_(CodeableConcept @this) {
                        CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ap_;
                    }

                    IEnumerable<CqlConcept> aj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ai_);
                    CqlValueSet ak_ = this.Patient_Reason(context);
                    bool? al_ = context.Operators.ConceptsInValueSet(aj_, ak_);
                    bool? am_ = context.Operators.Or(ag_, al_);
                    bool? an_ = context.Operators.And(ab_, am_);
                    return an_;
                }

                IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
                bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
                return g_;
            });


    private Cached<bool?> _Denominator_Exceptions_2_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions 2")]
    public bool? Denominator_Exceptions_2(CqlContext context) =>
        _Denominator_Exceptions_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? b_ = this.Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? c_ = context.Operators.Or(a_, b_);
                bool? d_ = this.Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? e_ = context.Operators.Or(c_, d_);
                bool? f_ = this.Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? g_ = context.Operators.Or(e_, f_);
                bool? h_ = this.Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? i_ = context.Operators.Or(g_, h_);
                bool? j_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? k_ = context.Operators.Or(i_, j_);
                bool? l_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
                bool? m_ = context.Operators.Or(k_, l_);
                bool? n_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy(context);
                bool? o_ = context.Operators.Or(m_, n_);
                bool? p_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer(context);
                bool? q_ = context.Operators.Or(o_, p_);
                return q_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES = new(
       [typeof(Observation), typeof(Encounter)],
       ["HeartRateExam", "CADEncounterModerateOrSevereLVSD"]);

    private static CqlTupleMetadata CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD = new(
       [typeof(Observation), typeof(Encounter)],
       ["HeartRateExam", "CADEncounterMI"]);

    #endregion CqlTupleMetadata Properties

}
