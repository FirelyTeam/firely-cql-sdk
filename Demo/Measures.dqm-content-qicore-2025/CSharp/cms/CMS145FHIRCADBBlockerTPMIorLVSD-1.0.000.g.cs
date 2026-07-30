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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.7.0")]
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
            bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, Diagnosis as Condition);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)a_, b_);

        bool? d_(Encounter Visit) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Diagnosis as Condition);
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
                bool? k_ = this.overlapsDayOfEncounter(context, CoronaryArteryDisease as Condition, ValidQualifyingEncounter);
                return k_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            bool? j_ = context.Operators.Exists<Condition>(i_);
            return j_;
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
                object i_;
                DataType u_ = CardiacSurgeryProcedure?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    DataType x_ = CardiacSurgeryProcedure?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    i_ = y_ as CqlDateTime;
                }
                else
                {
                    DataType z_ = CardiacSurgeryProcedure?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    if (ab_)
                    {
                        DataType ac_ = CardiacSurgeryProcedure?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        i_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ae_ = CardiacSurgeryProcedure?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            DataType ah_ = CardiacSurgeryProcedure?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            i_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType aj_ = CardiacSurgeryProcedure?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                DataType am_ = CardiacSurgeryProcedure?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                i_ = an_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                bool? o_ = context.Operators.Before(k_, n_, (string)default);
                Code<EventStatus> p_ = CardiacSurgeryProcedure?.StatusElement;
                EventStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                bool? s_ = context.Operators.Equal(r_, "completed");
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
            IEnumerable<Encounter> r_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? s_(Encounter Encounter2) {
                Id v_ = Encounter2?.IdElement;
                string w_ = v_?.Value;
                Id x_ = Encounter1?.IdElement;
                string y_ = x_?.Value;
                bool? z_ = context.Operators.Equivalent(w_, y_);
                bool? aa_ = context.Operators.Not(z_);
                return aa_;
            }

            IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
            bool? u_ = context.Operators.Exists<Encounter>(t_);
            return u_;
        }

        IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
        bool? m_ = context.Operators.Exists<Encounter>(l_);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_CAD_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter>(o_);
        bool? q_ = context.Operators.And(n_, p_);
        return q_;
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
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MyocardialInfarction);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EncounterWithCADProxy?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(3m, "years");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(q_, o_, true, false);
                bool? s_ = context.Operators.In<CqlDateTime>(l_, r_, "day");
                bool? t_ = context.Operators.Not((bool?)(o_ is null));
                bool? u_ = context.Operators.And(s_, t_);
                IEnumerable<object> v_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);
                bool? w_ = context.Operators.Exists<object>(v_);
                bool? x_ = context.Operators.Not(w_);
                bool? y_ = context.Operators.And(u_, x_);
                bool? z_ = AHAOverall_4_1_000.Instance.isVerified(context, MyocardialInfarction);
                bool? aa_ = context.Operators.And(y_, z_);
                return aa_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            bool? j_ = context.Operators.Exists<Condition>(i_);
            return j_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.overlapsDayOfEncounter(context, AtrioventricularBlockDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? g_(Encounter CADEncounterMI) {
                object j_;
                DataType v_ = ImplantedCardiacPacer?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlDateTime;
                if (x_)
                {
                    DataType y_ = ImplantedCardiacPacer?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    j_ = z_ as CqlDateTime;
                }
                else
                {
                    DataType aa_ = ImplantedCardiacPacer?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlQuantity;
                    if (ac_)
                    {
                        DataType ad_ = ImplantedCardiacPacer?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        j_ = ae_ as CqlQuantity;
                    }
                    else
                    {
                        DataType af_ = ImplantedCardiacPacer?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                        if (ah_)
                        {
                            DataType ai_ = ImplantedCardiacPacer?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            j_ = aj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ak_ = ImplantedCardiacPacer?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            bool am_ = al_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                DataType an_ = ImplantedCardiacPacer?.Performed;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                j_ = ao_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, (string)default);
                Code<EventStatus> q_ = ImplantedCardiacPacer?.StatusElement;
                EventStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "completed");
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        return e_;
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
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
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
                Period an_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                DataType ap_ = MostRecentPriorHeartRateExam?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, (string)default);
                Code<ObservationStatus> at_ = MostRecentPriorHeartRateExam?.StatusElement;
                ObservationStatus? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                string[] aw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                bool? ay_ = context.Operators.And(as_, ax_);
                DataType az_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                bool? bc_ = context.Operators.Before(ar_, bb_, (string)default);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);

            object ag_(Observation @this) {
                DataType be_ = @this?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                return bh_;
            }

            IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ai_ = context.Operators.Last<Observation>(ah_);
            DataType aj_ = ai_?.Value;
            CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
            bool? al_ = context.Operators.Less(ak_, aa_);
            bool? am_ = context.Operators.And(ac_, al_);
            return am_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(e_, f_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? h_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? bi_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam, tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI);
            return bi_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> i_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(i_);
        bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(j_);
        return k_;
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
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object i_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(h_ ?? k_);
                Period m_ = EncounterWithCADProxy?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, (string)default);
                return p_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            return g_;
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
                FhirDateTime e_ = Order?.AuthoredOnElement;
                CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
                Period g_ = Visit?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                bool? i_ = context.Operators.In<CqlDateTime>(f_, h_, "day");
                Code<MedicationRequest.MedicationrequestStatus> j_ = Order?.StatusElement;
                MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "active",
                    "completed",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                bool? o_ = context.Operators.And(i_, n_);
                Code<MedicationRequest.MedicationRequestIntent> p_ = Order?.IntentElement;
                MedicationRequest.MedicationRequestIntent? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                bool? u_ = context.Operators.And(o_, t_);
                FhirBoolean v_ = Order?.DoNotPerformElement;
                bool? w_ = v_?.Value;
                bool? x_ = context.Operators.IsTrue(w_);
                bool? y_ = context.Operators.Not(x_);
                bool? z_ = context.Operators.And(u_, y_);
                return z_;
            }
            else if (Order is MedicationRequest)
            {
                FhirDateTime aa_ = Order?.AuthoredOnElement;
                CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
                Period ac_ = Visit?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, "day");
                Code<MedicationRequest.MedicationRequestIntent> af_ = Order?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                return ak_;
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.Select<Encounter, bool?>(EncounterList, a_);
        IEnumerable<bool?> c_ = context.Operators.Distinct<bool?>(b_);
        bool? d_ = context.Operators.AnyTrue(c_);
        return d_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.authoredDuringDayOfEncounter(context, BetaBlockerForLVSDOrdered as MedicationRequest, f_);
            return g_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
        return e_;
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
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? i_(Encounter CADEncounterModerateOrSevereLVSD) {
                List<Dosage> l_ = ActiveBetaBlockerForLVSD?.DosageInstruction;

                bool? m_(Dosage @this) {
                    Timing ai_ = @this?.Timing;
                    bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                    return aj_;
                }

                IEnumerable<Dosage> n_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)l_, m_);

                Timing o_(Dosage @this) {
                    Timing ak_ = @this?.Timing;
                    return ak_;
                }

                IEnumerable<Timing> p_ = context.Operators.Select<Dosage, Timing>(n_, o_);

                bool? q_(Timing @this) {
                    Timing.RepeatComponent al_ = @this?.Repeat;
                    bool? am_ = context.Operators.Not((bool?)(al_ is null));
                    return am_;
                }

                IEnumerable<Timing> r_ = context.Operators.Where<Timing>(p_, q_);

                Timing.RepeatComponent s_(Timing @this) {
                    Timing.RepeatComponent an_ = @this?.Repeat;
                    return an_;
                }

                IEnumerable<Timing.RepeatComponent> t_ = context.Operators.Select<Timing, Timing.RepeatComponent>(r_, s_);

                bool? u_(Timing.RepeatComponent @this) {
                    DataType ao_ = @this?.Bounds;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
                    return aq_;
                }

                IEnumerable<Timing.RepeatComponent> v_ = context.Operators.Where<Timing.RepeatComponent>(t_, u_);

                object w_(Timing.RepeatComponent @this) {
                    DataType ar_ = @this?.Bounds;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_;
                }

                IEnumerable<object> x_ = context.Operators.Select<Timing.RepeatComponent, object>(v_, w_);

                CqlInterval<CqlDateTime> y_(object DoseTime) {
                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return at_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> z_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(x_, y_);
                IEnumerable<CqlInterval<CqlDateTime>> aa_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(z_);
                IEnumerable<CqlInterval<CqlDateTime>> ab_ = context.Operators.Collapse(aa_, (string)default);

                object ac_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime au_ = context.Operators.Start(@this);
                    return au_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ad_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ae_ = context.Operators.First<CqlInterval<CqlDateTime>>(ad_);
                Period af_ = CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.OverlapsAfter(ae_, ag_, "day");
                return ah_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlockerForLVSD) {
            Code<MedicationRequest.MedicationrequestStatus> av_ = ActiveBetaBlockerForLVSD?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aw_ = av_?.Value;
            string ax_ = context.Operators.Convert<string>(aw_);
            string[] ay_ = [
                "active",
                "completed",
            ];
            bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
            Code<MedicationRequest.MedicationRequestIntent> ba_ = ActiveBetaBlockerForLVSD?.IntentElement;
            MedicationRequest.MedicationRequestIntent? bb_ = ba_?.Value;
            string bc_ = context.Operators.Convert<string>(bb_);
            string[] bd_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? be_ = context.Operators.In<string>(bc_, (IEnumerable<string>)bd_);
            bool? bf_ = context.Operators.And(az_, be_);
            return bf_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
        return g_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.authoredDuringDayOfEncounter(context, BetaBlockerOrdered as MedicationRequest, f_);
            return g_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
        return e_;
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
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? i_(Encounter CADEncounterMI) {
                List<Dosage> l_ = ActiveBetaBlocker?.DosageInstruction;

                bool? m_(Dosage @this) {
                    Timing ai_ = @this?.Timing;
                    bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                    return aj_;
                }

                IEnumerable<Dosage> n_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)l_, m_);

                Timing o_(Dosage @this) {
                    Timing ak_ = @this?.Timing;
                    return ak_;
                }

                IEnumerable<Timing> p_ = context.Operators.Select<Dosage, Timing>(n_, o_);

                bool? q_(Timing @this) {
                    Timing.RepeatComponent al_ = @this?.Repeat;
                    bool? am_ = context.Operators.Not((bool?)(al_ is null));
                    return am_;
                }

                IEnumerable<Timing> r_ = context.Operators.Where<Timing>(p_, q_);

                Timing.RepeatComponent s_(Timing @this) {
                    Timing.RepeatComponent an_ = @this?.Repeat;
                    return an_;
                }

                IEnumerable<Timing.RepeatComponent> t_ = context.Operators.Select<Timing, Timing.RepeatComponent>(r_, s_);

                bool? u_(Timing.RepeatComponent @this) {
                    DataType ao_ = @this?.Bounds;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
                    return aq_;
                }

                IEnumerable<Timing.RepeatComponent> v_ = context.Operators.Where<Timing.RepeatComponent>(t_, u_);

                object w_(Timing.RepeatComponent @this) {
                    DataType ar_ = @this?.Bounds;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_;
                }

                IEnumerable<object> x_ = context.Operators.Select<Timing.RepeatComponent, object>(v_, w_);

                CqlInterval<CqlDateTime> y_(object DoseTime) {
                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return at_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> z_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(x_, y_);
                IEnumerable<CqlInterval<CqlDateTime>> aa_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(z_);
                IEnumerable<CqlInterval<CqlDateTime>> ab_ = context.Operators.Collapse(aa_, (string)default);

                object ac_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime au_ = context.Operators.Start(@this);
                    return au_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ad_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ae_ = context.Operators.First<CqlInterval<CqlDateTime>>(ad_);
                Period af_ = CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.OverlapsAfter(ae_, ag_, "day");
                return ah_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlocker) {
            Code<MedicationRequest.MedicationrequestStatus> av_ = ActiveBetaBlocker?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aw_ = av_?.Value;
            string ax_ = context.Operators.Convert<string>(aw_);
            string[] ay_ = [
                "active",
                "completed",
            ];
            bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
            Code<MedicationRequest.MedicationRequestIntent> ba_ = ActiveBetaBlocker?.IntentElement;
            MedicationRequest.MedicationRequestIntent? bb_ = ba_?.Value;
            string bc_ = context.Operators.Convert<string>(bb_);
            string[] bd_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? be_ = context.Operators.In<string>(bc_, (IEnumerable<string>)bd_);
            bool? bf_ = context.Operators.And(az_, be_);
            return bf_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
        return g_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, AtrioventricularBlock, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? g_(Encounter CADEncounterModerateOrSevereLVSD) {
                object j_;
                DataType q_ = ImplantedCardiacPacer?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = ImplantedCardiacPacer?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = ImplantedCardiacPacer?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = ImplantedCardiacPacer?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = ImplantedCardiacPacer?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = ImplantedCardiacPacer?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = ImplantedCardiacPacer?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = ImplantedCardiacPacer?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                j_ = aj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, (string)default);
                return p_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        return e_;
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
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
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
                Period an_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                DataType ap_ = MostRecentPriorHeartRateExam?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, (string)default);
                Code<ObservationStatus> at_ = MostRecentPriorHeartRateExam?.StatusElement;
                ObservationStatus? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                string[] aw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                bool? ay_ = context.Operators.And(as_, ax_);
                DataType az_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                bool? bc_ = context.Operators.Before(ar_, bb_, (string)default);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);

            object ag_(Observation @this) {
                DataType be_ = @this?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                return bh_;
            }

            IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ai_ = context.Operators.Last<Observation>(ah_);
            DataType aj_ = ai_?.Value;
            CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
            bool? al_ = context.Operators.Less(ak_, aa_);
            bool? am_ = context.Operators.And(ac_, al_);
            return am_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(e_, f_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? h_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? bi_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD);
            return bi_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> i_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(i_);
        bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(j_);
        return k_;
    }


    [CqlFunctionDefinition("overlapsAfterDayOfEncounter")]
    public bool? overlapsAfterDayOfEncounter(CqlContext context, object Event, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            if (Event is AllergyIntolerance)
            {
                object e_ = context.Operators.LateBoundProperty<object>(Event, "onset");
                object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
                CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
                CqlDateTime h_ = context.Operators.Start(g_);
                object i_ = context.Operators.LateBoundProperty<object>(Event, "lastOccurrence");
                CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
                Period l_ = Visit?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.OverlapsAfter(k_, m_, "day");
                object o_ = context.Operators.LateBoundProperty<object>(Event, "clinicalStatus");
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_ as CodeableConcept);
                CqlCode q_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(p_, r_);
                bool? t_ = context.Operators.Or((bool?)(p_ is null), s_);
                bool? u_ = context.Operators.And(n_, t_);
                object v_ = context.Operators.LateBoundProperty<object>(Event, "verificationStatus");
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                bool? aa_ = context.Operators.Or((bool?)(w_ is null), z_);
                bool? ab_ = context.Operators.And(u_, aa_);
                return ab_;
            }
            else if (Event is Condition)
            {
                bool? ac_ = AHAOverall_4_1_000.Instance.isVerified(context, Event as AllergyIntolerance);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, (Event as Condition) as Condition);
                Period ae_ = Visit?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                bool? ag_ = context.Operators.OverlapsAfter(ad_, af_, "day");
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.Select<Encounter, bool?>(EncounterList, a_);
        IEnumerable<bool?> c_ = context.Operators.Distinct<bool?>(b_);
        bool? d_ = context.Operators.AnyTrue(c_);
        return d_;
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
            IEnumerable<Encounter> j_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? k_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, j_);
            return k_;
        }

        IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
        bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);
        return i_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? g_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, i_);
            return j_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        bool? h_ = context.Operators.Exists<Condition>(g_);
        return h_;
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
            IEnumerable<Encounter> i_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, i_);
            return j_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        bool? h_ = context.Operators.Exists<Condition>(g_);
        return h_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis, f_);
            return g_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        return e_;
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
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            bool? i_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis as Condition, h_);
            return i_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        return g_;
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
            IEnumerable<Encounter> j_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            bool? k_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, j_);
            return k_;
        }

        IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
        bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);
        return i_;
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
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);

            bool? i_(Encounter LVSDVisit) {
                FhirDateTime l_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = LVSDVisit?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> q_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "active",
                "completed",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            Code<MedicationRequest.MedicationRequestIntent> v_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(u_, z_);
            List<CodeableConcept> ab_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

            CqlConcept ac_(CodeableConcept @this) {
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return am_;
            }

            IEnumerable<CqlConcept> ad_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ac_);
            CqlValueSet ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptsInValueSet(ad_, ae_);

            CqlConcept ag_(CodeableConcept @this) {
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return an_;
            }

            IEnumerable<CqlConcept> ah_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ag_);
            CqlValueSet ai_ = this.Patient_Reason(context);
            bool? aj_ = context.Operators.ConceptsInValueSet(ah_, ai_);
            bool? ak_ = context.Operators.Or(af_, aj_);
            bool? al_ = context.Operators.And(aa_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
        return g_;
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
            IEnumerable<Encounter> h_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);

            bool? i_(Encounter PriorMIVisit) {
                FhirDateTime l_ = NoBetaBlockerForLVSDOrdered?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = PriorMIVisit?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest NoBetaBlockerForLVSDOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> q_ = NoBetaBlockerForLVSDOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "active",
                "completed",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            Code<MedicationRequest.MedicationRequestIntent> v_ = NoBetaBlockerForLVSDOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(u_, z_);
            List<CodeableConcept> ab_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

            CqlConcept ac_(CodeableConcept @this) {
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return am_;
            }

            IEnumerable<CqlConcept> ad_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ac_);
            CqlValueSet ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptsInValueSet(ad_, ae_);

            CqlConcept ag_(CodeableConcept @this) {
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return an_;
            }

            IEnumerable<CqlConcept> ah_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ag_);
            CqlValueSet ai_ = this.Patient_Reason(context);
            bool? aj_ = context.Operators.ConceptsInValueSet(ah_, ai_);
            bool? ak_ = context.Operators.Or(af_, aj_);
            bool? al_ = context.Operators.And(aa_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
        return g_;
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
