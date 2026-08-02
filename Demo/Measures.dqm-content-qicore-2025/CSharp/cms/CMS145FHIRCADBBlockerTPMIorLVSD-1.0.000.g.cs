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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.0.0")]
[CqlLibrary("CMS145FHIRCADBBlockerTPMIorLVSD", "1.0.000")]
public partial class CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000 : ILibrary, ISingleton<CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000>
{
    #region ValueSets (28)

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

    #region Codes (1)

    [CqlCodeDefinition("Substance with beta adrenergic receptor antagonist mechanism of action (substance)", codeId: "373254001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -3838999943742845946L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS145FHIRCADBBlockerTPMIorLVSD-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (51)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4943327489850151171L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Measurement_Period, Qualifying_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Measurement_Period = -2871022325888111391L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Outpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Outpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounter_During_Measurement_Period, Outpatient_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Outpatient_Encounter_During_Measurement_Period = 4185720693783375476L;

    private IEnumerable<Encounter> Outpatient_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
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
    }


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            bool? d_ = this.overlapsDayOfEncounter(context, Diagnosis, Visit);
            return d_;
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        bool? c_ = context.Operators.AnyTrue(b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        bool? b_(Encounter Visit) {
            bool? g_ = AHAOverall_4_1_000.Instance.isVerified(context, Diagnosis as Condition);
            return g_;
        }


        bool? c_(Encounter Visit) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Diagnosis as Condition);
            Period i_ = Visit?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            bool? k_ = context.Operators.Overlaps(h_, j_, "day");
            return k_;
        }

        IEnumerable<bool?> d_ = context.Operators.WhereSelect<Encounter, bool?>((IEnumerable<Encounter>)a_, b_, c_);
        IEnumerable<bool?> e_ = context.Operators.Distinct<bool?>(d_);
        bool? f_ = context.Operators.SingletonFrom<bool?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Coronary Artery Disease Encounter")]
    public IEnumerable<Encounter> Coronary_Artery_Disease_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Coronary_Artery_Disease_Encounter, Coronary_Artery_Disease_Encounter_Compute);

    private const long _cacheIndex_Coronary_Artery_Disease_Encounter = 6894080970263121722L;

    private IEnumerable<Encounter> Coronary_Artery_Disease_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter ValidQualifyingEncounter) {
            CqlValueSet d_ = this.Coronary_Artery_Disease_No_MI(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition CoronaryArteryDisease) {
                bool? j_ = this.overlapsDayOfEncounter(context, CoronaryArteryDisease as Condition, ValidQualifyingEncounter);
                return j_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("History of Cardiac Surgery Prior to Encounter")]
    public IEnumerable<Encounter> History_of_Cardiac_Surgery_Prior_to_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_History_of_Cardiac_Surgery_Prior_to_Encounter, History_of_Cardiac_Surgery_Prior_to_Encounter_Compute);

    private const long _cacheIndex_History_of_Cardiac_Surgery_Prior_to_Encounter = 6248196608709177427L;

    private IEnumerable<Encounter> History_of_Cardiac_Surgery_Prior_to_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter ValidQualifyingEncounter) {
            CqlValueSet d_ = this.Cardiac_Surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure CardiacSurgeryProcedure) {
                object h_;
                DataType t_ = CardiacSurgeryProcedure?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    DataType w_ = CardiacSurgeryProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    h_ = x_ as CqlDateTime;
                }
                else
                {
                    DataType y_ = CardiacSurgeryProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;
                    if (aa_)
                    {
                        DataType ab_ = CardiacSurgeryProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        h_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ad_ = CardiacSurgeryProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            DataType ag_ = CardiacSurgeryProcedure?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            h_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ai_ = CardiacSurgeryProcedure?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                DataType al_ = CardiacSurgeryProcedure?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                h_ = am_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                bool? n_ = context.Operators.Before(j_, m_, (string)default);
                Code<EventStatus> o_ = CardiacSurgeryProcedure?.StatusElement;
                EventStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                bool? r_ = context.Operators.Equal(q_, "completed");
                bool? s_ = context.Operators.And(n_, r_);
                return s_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualifying CAD Encounter")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_CAD_Encounter, Qualifying_CAD_Encounter_Compute);

    private const long _cacheIndex_Qualifying_CAD_Encounter = 8366230998328308210L;

    private IEnumerable<Encounter> Qualifying_CAD_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Coronary_Artery_Disease_Encounter(context);
        IEnumerable<Encounter> b_ = this.History_of_Cardiac_Surgery_Prior_to_Encounter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -8015939987437211170L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
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

        bool? k_(Encounter Encounter1) {
            IEnumerable<Encounter> q_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? r_(Encounter Encounter2) {
                Id t_ = Encounter2?.IdElement;
                string u_ = t_?.Value;
                Id v_ = Encounter1?.IdElement;
                string w_ = v_?.Value;
                bool? x_ = context.Operators.Equivalent(u_, w_);
                bool? y_ = context.Operators.Not(x_);
                return y_;
            }

            bool? s_ = context.Operators.WhereAny<Encounter>(q_, r_);
            return s_;
        }

        bool? l_ = context.Operators.WhereAny<Encounter>(j_, k_);
        bool? m_ = context.Operators.And(i_, l_);
        IEnumerable<Encounter> n_ = this.Qualifying_CAD_Encounter(context);
        bool? o_ = context.Operators.Exists<Encounter>(n_);
        bool? p_ = context.Operators.And(m_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Qualifying CAD Encounter and Prior MI")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_CAD_Encounter_and_Prior_MI, Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Qualifying_CAD_Encounter_and_Prior_MI = -5145744575977972721L;

    private IEnumerable<Encounter> Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_CAD_Encounter(context);

        bool? b_(Encounter EncounterWithCADProxy) {
            CqlValueSet d_ = this.Myocardial_Infarction(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition MyocardialInfarction) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MyocardialInfarction);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = EncounterWithCADProxy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "years");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, false);
                bool? r_ = context.Operators.In<CqlDateTime>(k_, q_, "day");
                bool? s_ = context.Operators.Not((bool?)(n_ is null));
                bool? t_ = context.Operators.And(r_, s_);
                IEnumerable<object> u_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);
                bool? v_ = context.Operators.Exists<object>(u_);
                bool? w_ = context.Operators.Not(v_);
                bool? x_ = context.Operators.And(t_, w_);
                bool? y_ = AHAOverall_4_1_000.Instance.isVerified(context, MyocardialInfarction);
                bool? z_ = context.Operators.And(x_, y_);
                return z_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = -4261843835990479910L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI = -2639165688219748952L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition AtrioventricularBlockDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.overlapsDayOfEncounter(context, AtrioventricularBlockDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI = -2301010253886131830L;

    private bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition CardiacPacerDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI = 4674704661872179046L;

    private bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ImplantedCardiacPacer) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? f_(Encounter CADEncounterMI) {
                object h_;
                DataType t_ = ImplantedCardiacPacer?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    DataType w_ = ImplantedCardiacPacer?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    h_ = x_ as CqlDateTime;
                }
                else
                {
                    DataType y_ = ImplantedCardiacPacer?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;
                    if (aa_)
                    {
                        DataType ab_ = ImplantedCardiacPacer?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        h_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ad_ = ImplantedCardiacPacer?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            DataType ag_ = ImplantedCardiacPacer?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            h_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ai_ = ImplantedCardiacPacer?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                DataType al_ = ImplantedCardiacPacer?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                h_ = am_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                bool? n_ = context.Operators.Before(j_, m_, (string)default);
                Code<EventStatus> o_ = ImplantedCardiacPacer?.StatusElement;
                EventStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                bool? r_ = context.Operators.Equal(q_, "completed");
                bool? s_ = context.Operators.And(n_, r_);
                return s_;
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer = 7924848715289777919L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
        bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
        bool? c_ = context.Operators.Not(b_);
        bool? d_ = context.Operators.And(a_, c_);
        bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
        bool? f_ = context.Operators.Not(e_);
        bool? g_ = context.Operators.And(d_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and Prior MI")]
    [CqlTag("code", "Heart rate - 8867-4")]
    [CqlTag("profile", "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI = -1405931838525896459L;

    private bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
        IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? j_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
            Period k_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            DataType m_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);
            Code<ObservationStatus> q_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            DataType w_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Value;
            CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
            CqlQuantity y_ = context.Operators.Quantity(50m, "/min");
            bool? z_ = context.Operators.Less(x_, y_);
            bool? aa_ = context.Operators.And(v_, z_);
            IEnumerable<Observation> ab_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? ac_(Observation MostRecentPriorHeartRateExam) {
                Period al_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                DataType an_ = MostRecentPriorHeartRateExam?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, ap_, (string)default);
                Code<ObservationStatus> ar_ = MostRecentPriorHeartRateExam?.StatusElement;
                ObservationStatus? as_ = ar_?.Value;
                string at_ = context.Operators.Convert<string>(as_);
                string[] au_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                bool? aw_ = context.Operators.And(aq_, av_);
                DataType ax_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                bool? ba_ = context.Operators.Before(ap_, az_, (string)default);
                bool? bb_ = context.Operators.And(aw_, ba_);
                return bb_;
            }

            IEnumerable<Observation> ad_ = context.Operators.Where<Observation>(ab_, ac_);

            object ae_(Observation @this) {
                DataType bc_ = @this?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                return bf_;
            }

            IEnumerable<Observation> af_ = context.Operators.SortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ag_ = context.Operators.Last<Observation>(af_);
            DataType ah_ = ag_?.Value;
            CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
            bool? aj_ = context.Operators.Less(ai_, y_);
            bool? ak_ = context.Operators.And(aa_, aj_);
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(c_, d_, e_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? g_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? bg_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam, tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI);
            return bg_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(f_, g_);
        bool? i_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public IEnumerable<Encounter> Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -376240068842855892L;

    private IEnumerable<Encounter> Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_CAD_Encounter(context);

        bool? b_(Encounter EncounterWithCADProxy) {
            IEnumerable<object> d_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);

            bool? e_(object LVSDFindings) {
                CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object h_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(g_ ?? j_);
                Period l_ = EncounterWithCADProxy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                bool? o_ = context.Operators.Before(k_, n_, (string)default);
                return o_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("authoredDuringDayOfEncounter")]
    public bool? authoredDuringDayOfEncounter(CqlContext context, MedicationRequest Order, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            if (Order is MedicationRequest)
            {
                FhirDateTime d_ = Order?.AuthoredOnElement;
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                Period f_ = Visit?.Period;
                CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                bool? h_ = context.Operators.In<CqlDateTime>(e_, g_, "day");
                Code<MedicationRequest.MedicationrequestStatus> i_ = Order?.StatusElement;
                MedicationRequest.MedicationrequestStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "active",
                    "completed",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                bool? n_ = context.Operators.And(h_, m_);
                Code<MedicationRequest.MedicationRequestIntent> o_ = Order?.IntentElement;
                MedicationRequest.MedicationRequestIntent? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                bool? t_ = context.Operators.And(n_, s_);
                FhirBoolean u_ = Order?.DoNotPerformElement;
                bool? v_ = u_?.Value;
                bool? w_ = context.Operators.IsTrue(v_);
                bool? x_ = context.Operators.Not(w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }
            else if (Order is MedicationRequest)
            {
                FhirDateTime z_ = Order?.AuthoredOnElement;
                CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
                Period ab_ = Visit?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, "day");
                Code<MedicationRequest.MedicationRequestIntent> ae_ = Order?.IntentElement;
                MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                return aj_;
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        bool? c_ = context.Operators.AnyTrue(b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Beta_Blocker_Therapy_for_LVSD_Ordered, Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Compute);

    private const long _cacheIndex_Has_Beta_Blocker_Therapy_for_LVSD_Ordered = -5965564790916757780L;

    private bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest BetaBlockerForLVSDOrdered) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.authoredDuringDayOfEncounter(context, BetaBlockerForLVSDOrdered as MedicationRequest, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD, Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Compute);

    private const long _cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD = 2996237725122511548L;

    private bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest ActiveBetaBlockerForLVSD) {
            IEnumerable<Encounter> g_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter CADEncounterModerateOrSevereLVSD) {
                List<Dosage> j_ = ActiveBetaBlockerForLVSD?.DosageInstruction;

                bool? k_(Dosage @this) {
                    Timing ac_ = @this?.Timing;
                    bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                    return ad_;
                }


                Timing l_(Dosage @this) {
                    Timing ae_ = @this?.Timing;
                    return ae_;
                }

                IEnumerable<Timing> m_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)j_, k_, l_);

                bool? n_(Timing @this) {
                    Timing.RepeatComponent af_ = @this?.Repeat;
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    return ag_;
                }


                Timing.RepeatComponent o_(Timing @this) {
                    Timing.RepeatComponent ah_ = @this?.Repeat;
                    return ah_;
                }

                IEnumerable<Timing.RepeatComponent> p_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(m_, n_, o_);

                bool? q_(Timing.RepeatComponent @this) {
                    DataType ai_ = @this?.Bounds;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    return ak_;
                }


                object r_(Timing.RepeatComponent @this) {
                    DataType al_ = @this?.Bounds;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return am_;
                }

                IEnumerable<object> s_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(p_, q_, r_);

                CqlInterval<CqlDateTime> t_(object DoseTime) {
                    CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return an_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(s_, t_);
                IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Collapse(u_, (string)default);

                object w_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ao_ = context.Operators.Start(@this);
                    return ao_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> x_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> y_ = context.Operators.First<CqlInterval<CqlDateTime>>(x_);
                Period z_ = CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                return ab_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlockerForLVSD) {
            Code<MedicationRequest.MedicationrequestStatus> ap_ = ActiveBetaBlockerForLVSD?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aq_ = ap_?.Value;
            string ar_ = context.Operators.Convert<string>(aq_);
            string[] as_ = [
                "active",
                "completed",
            ];
            bool? at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
            Code<MedicationRequest.MedicationRequestIntent> au_ = ActiveBetaBlockerForLVSD?.IntentElement;
            MedicationRequest.MedicationRequestIntent? av_ = au_?.Value;
            string aw_ = context.Operators.Convert<string>(av_);
            string[] ax_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
            bool? az_ = context.Operators.And(at_, ay_);
            return az_;
        }

        bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -6368735608539322040L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy Ordered")]
    public bool? Has_Beta_Blocker_Therapy_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Beta_Blocker_Therapy_Ordered, Has_Beta_Blocker_Therapy_Ordered_Compute);

    private const long _cacheIndex_Has_Beta_Blocker_Therapy_Ordered = -5499340533497537456L;

    private bool? Has_Beta_Blocker_Therapy_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest BetaBlockerOrdered) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.authoredDuringDayOfEncounter(context, BetaBlockerOrdered as MedicationRequest, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy, Is_Currently_Taking_Beta_Blocker_Therapy_Compute);

    private const long _cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy = 5490054796664819259L;

    private bool? Is_Currently_Taking_Beta_Blocker_Therapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest ActiveBetaBlocker) {
            IEnumerable<Encounter> g_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? h_(Encounter CADEncounterMI) {
                List<Dosage> j_ = ActiveBetaBlocker?.DosageInstruction;

                bool? k_(Dosage @this) {
                    Timing ac_ = @this?.Timing;
                    bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                    return ad_;
                }


                Timing l_(Dosage @this) {
                    Timing ae_ = @this?.Timing;
                    return ae_;
                }

                IEnumerable<Timing> m_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)j_, k_, l_);

                bool? n_(Timing @this) {
                    Timing.RepeatComponent af_ = @this?.Repeat;
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    return ag_;
                }


                Timing.RepeatComponent o_(Timing @this) {
                    Timing.RepeatComponent ah_ = @this?.Repeat;
                    return ah_;
                }

                IEnumerable<Timing.RepeatComponent> p_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(m_, n_, o_);

                bool? q_(Timing.RepeatComponent @this) {
                    DataType ai_ = @this?.Bounds;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    return ak_;
                }


                object r_(Timing.RepeatComponent @this) {
                    DataType al_ = @this?.Bounds;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return am_;
                }

                IEnumerable<object> s_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(p_, q_, r_);

                CqlInterval<CqlDateTime> t_(object DoseTime) {
                    CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return an_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(s_, t_);
                IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Collapse(u_, (string)default);

                object w_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ao_ = context.Operators.Start(@this);
                    return ao_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> x_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> y_ = context.Operators.First<CqlInterval<CqlDateTime>>(x_);
                Period z_ = CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                return ab_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlocker) {
            Code<MedicationRequest.MedicationrequestStatus> ap_ = ActiveBetaBlocker?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aq_ = ap_?.Value;
            string ar_ = context.Operators.Convert<string>(aq_);
            string[] as_ = [
                "active",
                "completed",
            ];
            bool? at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
            Code<MedicationRequest.MedicationRequestIntent> au_ = ActiveBetaBlocker?.IntentElement;
            MedicationRequest.MedicationRequestIntent? av_ = au_?.Value;
            string aw_ = context.Operators.Convert<string>(av_);
            string[] ax_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
            bool? az_ = context.Operators.And(at_, ay_);
            return az_;
        }

        bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -4548427469715059312L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Beta_Blocker_Therapy_Ordered(context);
        bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -7423650110453256790L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6388569736345981558L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 9040851014390617956L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -2799688591257334892L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = 933938835741446785L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -6207236433083765932L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition AtrioventricularBlock) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, AtrioventricularBlock, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = 611146825355432056L;

    private bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition CardiacPacerDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -5776210879261728691L;

    private bool? Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ImplantedCardiacPacer) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? f_(Encounter CADEncounterModerateOrSevereLVSD) {
                object h_;
                DataType o_ = ImplantedCardiacPacer?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    DataType r_ = ImplantedCardiacPacer?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlDateTime;
                }
                else
                {
                    DataType t_ = ImplantedCardiacPacer?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlQuantity;
                    if (v_)
                    {
                        DataType w_ = ImplantedCardiacPacer?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        DataType y_ = ImplantedCardiacPacer?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            DataType ab_ = ImplantedCardiacPacer?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ad_ = ImplantedCardiacPacer?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            bool af_ = ae_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                DataType ag_ = ImplantedCardiacPacer?.Performed;
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                h_ = ah_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                bool? n_ = context.Operators.Before(j_, m_, (string)default);
                return n_;
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer = 599953581061905262L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        bool? c_ = context.Operators.Not(b_);
        bool? d_ = context.Operators.And(a_, c_);
        bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        bool? f_ = context.Operators.Not(e_);
        bool? g_ = context.Operators.And(d_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    [CqlTag("code", "Heart rate - 8867-4")]
    [CqlTag("profile", "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -5565858988664934775L;

    private bool? Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
        IEnumerable<Encounter> b_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? j_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
            Period k_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            DataType m_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);
            Code<ObservationStatus> q_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            DataType w_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Value;
            CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
            CqlQuantity y_ = context.Operators.Quantity(50m, "/min");
            bool? z_ = context.Operators.Less(x_, y_);
            bool? aa_ = context.Operators.And(v_, z_);
            IEnumerable<Observation> ab_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? ac_(Observation MostRecentPriorHeartRateExam) {
                Period al_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                DataType an_ = MostRecentPriorHeartRateExam?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, ap_, (string)default);
                Code<ObservationStatus> ar_ = MostRecentPriorHeartRateExam?.StatusElement;
                ObservationStatus? as_ = ar_?.Value;
                string at_ = context.Operators.Convert<string>(as_);
                string[] au_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                bool? aw_ = context.Operators.And(aq_, av_);
                DataType ax_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                bool? ba_ = context.Operators.Before(ap_, az_, (string)default);
                bool? bb_ = context.Operators.And(aw_, ba_);
                return bb_;
            }

            IEnumerable<Observation> ad_ = context.Operators.Where<Observation>(ab_, ac_);

            object ae_(Observation @this) {
                DataType bc_ = @this?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                return bf_;
            }

            IEnumerable<Observation> af_ = context.Operators.SortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ag_ = context.Operators.Last<Observation>(af_);
            DataType ah_ = ag_?.Value;
            CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
            bool? aj_ = context.Operators.Less(ai_, y_);
            bool? ak_ = context.Operators.And(aa_, aj_);
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(c_, d_, e_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? g_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? bg_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD);
            return bg_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(f_, g_);
        bool? i_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(h_);
        return i_;
    }


    [CqlFunctionDefinition("overlapsAfterDayOfEncounter")]
    public bool? overlapsAfterDayOfEncounter(CqlContext context, object Event, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            if (Event is AllergyIntolerance)
            {
                object d_ = context.Operators.LateBoundProperty<object>(Event, "onset");
                object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
                CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.toInterval(context, e_);
                CqlDateTime g_ = context.Operators.Start(f_);
                object h_ = context.Operators.LateBoundProperty<object>(Event, "lastOccurrence");
                CqlDateTime i_ = context.Operators.LateBoundProperty<CqlDateTime>(h_, "value");
                CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
                Period k_ = Visit?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.OverlapsAfter(j_, l_, "day");
                object n_ = context.Operators.LateBoundProperty<object>(Event, "clinicalStatus");
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_ as CodeableConcept);
                CqlCode p_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or((bool?)(o_ is null), r_);
                bool? t_ = context.Operators.And(m_, s_);
                object u_ = context.Operators.LateBoundProperty<object>(Event, "verificationStatus");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                CqlCode w_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(v_, x_);
                bool? z_ = context.Operators.Or((bool?)(v_ is null), y_);
                bool? aa_ = context.Operators.And(t_, z_);
                return aa_;
            }
            else if (Event is Condition)
            {
                bool? ab_ = AHAOverall_4_1_000.Instance.isVerified(context, Event as AllergyIntolerance);
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, (Event as Condition) as Condition);
                Period ad_ = Visit?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                bool? af_ = context.Operators.OverlapsAfter(ac_, ae_, "day");
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        bool? c_ = context.Operators.AnyTrue(b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI = -4012373805650300700L;

    private bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

        bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
            IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, i_);
            return j_;
        }

        bool? h_ = context.Operators.WhereAny<AllergyIntolerance>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Arrhythmia with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -5223679050506082360L;

    private bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Arrhythmia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition ArrhythmiaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Arrhythmia with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI = -1244530858248924349L;

    private bool? Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Arrhythmia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition ArrhythmiaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Asthma with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = 2985822784455938123L;

    private bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Asthma(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition AsthmaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Asthma with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI = 8978242064543891408L;

    private bool? Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Asthma(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition AsthmaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Bradycardia with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = 4922721093598094238L;

    private bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bradycardia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition BradycardiaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Bradycardia with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI = -7350147551858302813L;

    private bool? Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bradycardia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition BradycardiaDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? f_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -5097226349740322634L;

    private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);

        bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis) {
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, h_);
            return i_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI = -1090306935350505599L;

    private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);

        bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis) {
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? i_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, h_);
            return i_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Hypotension with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -3060424530178371983L;

    private bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hypotension(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition HypotensionDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? f_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis, e_);
            return f_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Hypotension with Qualifying CAD Encounter and Prior MI")]
    public bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI, Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute);

    private const long _cacheIndex_Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI = -5880257001685299859L;

    private bool? Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hypotension(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition HypotensionDiagnosis) {
            IEnumerable<Encounter> g_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? h_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis as Condition, g_);
            return h_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and History of Moderate or Severe LVSD")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD, Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD = -7221263534210068778L;

    private bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

        bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
            IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, i_);
            return j_;
        }

        bool? h_ = context.Operators.WhereAny<AllergyIntolerance>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD, Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Compute);

    private const long _cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD = -4668274905280302578L;

    private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

        bool? c_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            IEnumerable<Encounter> g_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter LVSDVisit) {
                FhirDateTime j_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = LVSDVisit?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> o_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "active",
                "completed",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            Code<MedicationRequest.MedicationRequestIntent> t_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            bool? y_ = context.Operators.And(s_, x_);
            List<CodeableConcept> z_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

            CqlConcept aa_(CodeableConcept @this) {
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ak_;
            }

            IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);
            CqlValueSet ac_ = this.Medical_Reason(context);
            bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);

            CqlConcept ae_(CodeableConcept @this) {
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return al_;
            }

            IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, ae_);
            CqlValueSet ag_ = this.Patient_Reason(context);
            bool? ah_ = context.Operators.ConceptsInValueSet(af_, ag_);
            bool? ai_ = context.Operators.Or(ad_, ah_);
            bool? aj_ = context.Operators.And(y_, ai_);
            return aj_;
        }

        bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions 1")]
    public bool? Denominator_Exceptions_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions_1, Denominator_Exceptions_1_Compute);

    private const long _cacheIndex_Denominator_Exceptions_1 = 9061963925225004876L;

    private bool? Denominator_Exceptions_1_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker Therapy")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy, Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy_Compute);

    private const long _cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy = 882942456773908318L;

    private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

        bool? c_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            IEnumerable<Encounter> g_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? h_(Encounter PriorMIVisit) {
                FhirDateTime j_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = PriorMIVisit?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> o_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "active",
                "completed",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            Code<MedicationRequest.MedicationRequestIntent> t_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            bool? y_ = context.Operators.And(s_, x_);
            List<CodeableConcept> z_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

            CqlConcept aa_(CodeableConcept @this) {
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ak_;
            }

            IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);
            CqlValueSet ac_ = this.Medical_Reason(context);
            bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);

            CqlConcept ae_(CodeableConcept @this) {
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return al_;
            }

            IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, ae_);
            CqlValueSet ag_ = this.Patient_Reason(context);
            bool? ah_ = context.Operators.ConceptsInValueSet(af_, ag_);
            bool? ai_ = context.Operators.Or(ad_, ah_);
            bool? aj_ = context.Operators.And(y_, ai_);
            return aj_;
        }

        bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions 2")]
    public bool? Denominator_Exceptions_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions_2, Denominator_Exceptions_2_Compute);

    private const long _cacheIndex_Denominator_Exceptions_2 = 805993342753520951L;

    private bool? Denominator_Exceptions_2_Compute(CqlContext context)
    {
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
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000() {}

    public static CMS145FHIRCADBBlockerTPMIorLVSD_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS145FHIRCADBBlockerTPMIorLVSD";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AHAOverall_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES = new(
       [typeof(Observation), typeof(Encounter)],
       ["HeartRateExam", "CADEncounterModerateOrSevereLVSD"]);

    private static CqlTupleMetadata CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD = new(
       [typeof(Observation), typeof(Encounter)],
       ["HeartRateExam", "CADEncounterMI"]);

    #endregion CqlTupleMetadata Properties

}
