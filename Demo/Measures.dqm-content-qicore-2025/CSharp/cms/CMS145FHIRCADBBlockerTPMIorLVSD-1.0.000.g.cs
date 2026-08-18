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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.7.0")]
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
            CqlBoolean w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, "day");

            CqlBoolean x_() {
                Code<Encounter.EncounterStatus> y_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? z_ = y_?.Value;
                Code<Encounter.EncounterStatus> aa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(z_);
                CqlBoolean ab_ = context.Operators.Equal(aa_, "finished");
                return ab_;
            }

            return w_
                /* CQL 'and' (217:5-218:44) */ && x_();
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
            CqlBoolean t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");

            CqlBoolean u_() {
                Code<Encounter.EncounterStatus> v_ = QualifyingEncounter?.StatusElement;
                Encounter.EncounterStatus? w_ = v_?.Value;
                Code<Encounter.EncounterStatus> x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(w_);
                CqlBoolean y_ = context.Operators.Equal(x_, "finished");
                return y_;
            }

            return t_
                /* CQL 'and' (207:5-208:49) */ && u_();
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        return p_;
    }


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, IEnumerable<Encounter> EncounterList)
    {

        bool? a_(Encounter Visit) {
            CqlBoolean d_ = this.overlapsDayOfEncounter(context, Diagnosis, Visit);
            return d_;
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        CqlBoolean c_ = context.Operators.AnyTrue(b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsDayOfEncounter")]
    public bool? overlapsDayOfEncounter(CqlContext context, Condition Diagnosis, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        bool? b_(Encounter Visit) {
            CqlBoolean g_ = AHAOverall_4_1_000.Instance.isVerified(context, Diagnosis as Condition);
            return g_;
        }


        bool? c_(Encounter Visit) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Diagnosis as Condition);
            Period i_ = Visit?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlBoolean k_ = context.Operators.Overlaps(h_, j_, "day");
            return k_;
        }

        IEnumerable<bool?> d_ = context.Operators.WhereSelect<Encounter, bool?>((IEnumerable<Encounter>)a_, b_, c_);
        IEnumerable<bool?> e_ = context.Operators.Distinct<bool?>(d_);
        CqlBoolean f_ = context.Operators.SingletonFrom<bool?>(e_);
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
                CqlBoolean j_ = this.overlapsDayOfEncounter(context, CoronaryArteryDisease as Condition, ValidQualifyingEncounter);
                return j_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Condition>(g_, h_);
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
                DataType p_ = CardiacSurgeryProcedure?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    h_ = q_ as CqlDateTime;
                }
                else
                {
                    bool s_ = q_ is CqlQuantity;
                    if (s_)
                    {
                        h_ = q_ as CqlQuantity;
                    }
                    else
                    {
                        bool t_ = q_ is CqlInterval<CqlDateTime>;
                        if (t_)
                        {
                            h_ = q_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool u_ = q_ is CqlInterval<CqlQuantity>;
                            if (u_)
                            {
                                h_ = q_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean n_ = context.Operators.Before(j_, m_, (string)default);

                CqlBoolean o_() {
                    Code<EventStatus> v_ = CardiacSurgeryProcedure?.StatusElement;
                    EventStatus? w_ = v_?.Value;
                    string x_ = context.Operators.Convert<string>(w_);
                    CqlBoolean y_ = context.Operators.Equal(x_, "completed");
                    return y_;
                }

                return n_
                    /* CQL 'and' (355:17-356:56) */ && o_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 18);

        CqlBoolean j_() {
            IEnumerable<Encounter> l_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? m_(Encounter Encounter1) {
                IEnumerable<Encounter> o_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? p_(Encounter Encounter2) {
                    Id r_ = Encounter2?.IdElement;
                    string s_ = r_?.Value;
                    Id t_ = Encounter1?.IdElement;
                    string u_ = t_?.Value;
                    CqlBoolean v_ = context.Operators.Equivalent(s_, u_);
                    return !v_;
                }

                CqlBoolean q_ = context.Operators.WhereAny<Encounter>(o_, p_);
                return q_;
            }

            CqlBoolean n_ = context.Operators.WhereAny<Encounter>(l_, m_);
            return n_;
        }


        CqlBoolean k_() {
            IEnumerable<Encounter> w_ = this.Qualifying_CAD_Encounter(context);
            CqlBoolean x_ = context.Operators.Exists<Encounter>(w_);
            return x_;
        }

        return i_
            /* CQL 'and' (340:3-344:5) */ && j_()
            /* CQL 'and' (340:3-345:41) */ && k_();
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
                CqlBoolean r_ = context.Operators.In<CqlDateTime>(k_, q_, "day");

                CqlBoolean s_() {
                    Period u_ = EncounterWithCADProxy?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    return w_ is not null;
                }


                CqlBoolean t_() {
                    IEnumerable<object> x_ = AHAOverall_4_1_000.Instance.Moderate_or_Severe_LVSD_Findings(context);
                    CqlBoolean y_ = context.Operators.Exists<object>(x_);
                    return !y_;
                }

                return r_
                    /* CQL 'and' (110:17-110:134) */ && s_()
                    /* CQL 'and' (110:17-111:61) */ && t_()
                    /* CQL 'and' (110:17-112:47) */ && AHAOverall_4_1_000.Instance.isVerified(context, MyocardialInfarction);
            }

            CqlBoolean i_ = context.Operators.WhereAny<Condition>(g_, h_);
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
        CqlBoolean a_ = this.Initial_Population(context);

        CqlBoolean b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_CAD_Encounter_and_Prior_MI(context);
            CqlBoolean d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        }

        return a_
            /* CQL 'and' (49:3-50:54) */ && b_();
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, AtrioventricularBlockDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
                DataType p_ = ImplantedCardiacPacer?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    h_ = q_ as CqlDateTime;
                }
                else
                {
                    bool s_ = q_ is CqlQuantity;
                    if (s_)
                    {
                        h_ = q_ as CqlQuantity;
                    }
                    else
                    {
                        bool t_ = q_ is CqlInterval<CqlDateTime>;
                        if (t_)
                        {
                            h_ = q_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool u_ = q_ is CqlInterval<CqlQuantity>;
                            if (u_)
                            {
                                h_ = q_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean n_ = context.Operators.Before(j_, m_, (string)default);

                CqlBoolean o_() {
                    Code<EventStatus> v_ = ImplantedCardiacPacer?.StatusElement;
                    EventStatus? w_ = v_?.Value;
                    string x_ = context.Operators.Convert<string>(w_);
                    CqlBoolean y_ = context.Operators.Equal(x_, "completed");
                    return y_;
                }

                return n_
                    /* CQL 'and' (102:19-103:56) */ && o_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer = 7924848715289777919L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
        return a_
            /* CQL 'and' (53:3-54:95) */ && !(this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_Prior_MI(context))
            /* CQL 'and' (53:3-55:91) */ && !(this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_Prior_MI(context));
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
            CqlBoolean p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);

            CqlBoolean q_() {
                Code<ObservationStatus> t_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.StatusElement;
                ObservationStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return x_;
            }


            CqlBoolean r_() {
                DataType y_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Value;
                CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
                CqlQuantity aa_ = context.Operators.Quantity(50m, "/min");
                CqlBoolean ab_ = context.Operators.Less(z_, aa_);
                return ab_;
            }


            CqlBoolean s_() {
                IEnumerable<Observation> ac_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                bool? ad_(Observation MostRecentPriorHeartRateExam) {
                    Period am_ = tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI?.Period;
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                    DataType ao_ = MostRecentPriorHeartRateExam?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                    CqlBoolean ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(an_, aq_, (string)default);

                    CqlBoolean as_() {
                        Code<ObservationStatus> au_ = MostRecentPriorHeartRateExam?.StatusElement;
                        ObservationStatus? av_ = au_?.Value;
                        string aw_ = context.Operators.Convert<string>(av_);
                        string[] ax_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                        return ay_;
                    }


                    CqlBoolean at_() {
                        DataType az_ = MostRecentPriorHeartRateExam?.Effective;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                        DataType bc_ = tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                        CqlBoolean bf_ = context.Operators.Before(bb_, be_, (string)default);
                        return bf_;
                    }

                    return ar_
                        /* CQL 'and' (68:17-69:90) */ && as_()
                        /* CQL 'and' (68:11-70:111) */ && at_();
                }

                IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(ac_, ad_);

                object af_(Observation @this) {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                    CqlDateTime bj_ = context.Operators.Start(bi_);
                    return bj_;
                }

                IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ah_ = context.Operators.Last<Observation>(ag_);
                DataType ai_ = ah_?.Value;
                CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                CqlQuantity ak_ = context.Operators.Quantity(50m, "/min");
                CqlBoolean al_ = context.Operators.Less(aj_, ak_);
                return al_;
            }

            return p_
                /* CQL 'and' (73:13-74:71) */ && q_()
                /* CQL 'and' (73:13-75:43) */ && r_()
                /* CQL 'and' (73:7-76:48) */ && s_();
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(c_, d_, e_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? g_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? tuple_ezawxthbubhdjanfnawxfxgjj) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)? bk_ = (CqlTupleMetadata_GgEMjKUjZUgEdXjOgPVEWONDD, tuple_ezawxthbubhdjanfnawxfxgjj?.HeartRateExam, tuple_ezawxthbubhdjanfnawxfxgjj?.CADEncounterMI);
            return bk_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(f_, g_);
        CqlBoolean i_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterMI)?>(h_);
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
                CqlBoolean o_ = context.Operators.Before(k_, n_, (string)default);
                return o_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
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
                CqlBoolean h_ = context.Operators.In<CqlDateTime>(e_, g_, "day");

                CqlBoolean i_() {
                    Code<MedicationRequest.MedicationrequestStatus> l_ = Order?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? m_ = l_?.Value;
                    string n_ = context.Operators.Convert<string>(m_);
                    string[] o_ = [
                        "active",
                        "completed",
                    ];
                    CqlBoolean p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
                    return p_;
                }


                CqlBoolean j_() {
                    Code<MedicationRequest.MedicationRequestIntent> q_ = Order?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                    string s_ = context.Operators.Convert<string>(r_);
                    string[] t_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    CqlBoolean u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                    return u_;
                }


                CqlBoolean k_() {
                    FhirBoolean v_ = Order?.DoNotPerformElement;
                    CqlBoolean w_ = v_?.Value;
                    return !((bool?)(/* CQL 'is true' (396:15-396:44) */ w_.IsTrue));
                }

                return (bool?)(h_
                    /* CQL 'and' (393:46-394:55) */ && i_()
                    /* CQL 'and' (393:46-395:109) */ && j_()
                    /* CQL 'and' (393:46-396:44) */ && k_());
            }
            else if (Order is MedicationRequest)
            {
                FhirDateTime x_ = Order?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                Period z_ = Visit?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlBoolean ab_ = context.Operators.In<CqlDateTime>(y_, aa_, "day");

                CqlBoolean ac_() {
                    Code<MedicationRequest.MedicationRequestIntent> ad_ = Order?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }

                return (bool?)(ab_
                    /* CQL 'and' (397:51-398:109) */ && ac_());
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        CqlBoolean c_ = context.Operators.AnyTrue(b_);
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
            CqlBoolean f_ = this.authoredDuringDayOfEncounter(context, BetaBlockerForLVSDOrdered as MedicationRequest, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
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
                    return ac_ is not null;
                }


                Timing l_(Dosage @this) {
                    Timing ad_ = @this?.Timing;
                    return ad_;
                }

                IEnumerable<Timing> m_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)j_, k_, l_);

                bool? n_(Timing @this) {
                    Timing.RepeatComponent ae_ = @this?.Repeat;
                    return ae_ is not null;
                }


                Timing.RepeatComponent o_(Timing @this) {
                    Timing.RepeatComponent af_ = @this?.Repeat;
                    return af_;
                }

                IEnumerable<Timing.RepeatComponent> p_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(m_, n_, o_);

                bool? q_(Timing.RepeatComponent @this) {
                    DataType ag_ = @this?.Bounds;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return ah_ is not null;
                }


                object r_(Timing.RepeatComponent @this) {
                    DataType ai_ = @this?.Bounds;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return aj_;
                }

                IEnumerable<object> s_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(p_, q_, r_);

                CqlInterval<CqlDateTime> t_(object DoseTime) {
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return ak_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(s_, t_);
                IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Collapse(u_, (string)default);

                object w_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime al_ = context.Operators.Start(@this);
                    return al_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> x_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> y_ = context.Operators.First<CqlInterval<CqlDateTime>>(x_);
                Period z_ = CADEncounterModerateOrSevereLVSD?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlBoolean ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                return ab_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlockerForLVSD) {
            Code<MedicationRequest.MedicationrequestStatus> am_ = ActiveBetaBlockerForLVSD?.StatusElement;
            MedicationRequest.MedicationrequestStatus? an_ = am_?.Value;
            string ao_ = context.Operators.Convert<string>(an_);
            string[] ap_ = [
                "active",
                "completed",
            ];
            CqlBoolean aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);

            CqlBoolean ar_() {
                Code<MedicationRequest.MedicationRequestIntent> as_ = ActiveBetaBlockerForLVSD?.IntentElement;
                MedicationRequest.MedicationRequestIntent? at_ = as_?.Value;
                string au_ = context.Operators.Convert<string>(at_);
                string[] av_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                return aw_;
            }

            return aq_
                /* CQL 'and' (197:7-198:126) */ && ar_();
        }

        CqlBoolean f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -6368735608539322040L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        return a_
            /* CQL 'or' (80:3-81:58) */ || this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
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
            CqlBoolean f_ = this.authoredDuringDayOfEncounter(context, BetaBlockerOrdered as MedicationRequest, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
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
                    return ac_ is not null;
                }


                Timing l_(Dosage @this) {
                    Timing ad_ = @this?.Timing;
                    return ad_;
                }

                IEnumerable<Timing> m_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)j_, k_, l_);

                bool? n_(Timing @this) {
                    Timing.RepeatComponent ae_ = @this?.Repeat;
                    return ae_ is not null;
                }


                Timing.RepeatComponent o_(Timing @this) {
                    Timing.RepeatComponent af_ = @this?.Repeat;
                    return af_;
                }

                IEnumerable<Timing.RepeatComponent> p_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(m_, n_, o_);

                bool? q_(Timing.RepeatComponent @this) {
                    DataType ag_ = @this?.Bounds;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return ah_ is not null;
                }


                object r_(Timing.RepeatComponent @this) {
                    DataType ai_ = @this?.Bounds;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return aj_;
                }

                IEnumerable<object> s_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(p_, q_, r_);

                CqlInterval<CqlDateTime> t_(object DoseTime) {
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return ak_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(s_, t_);
                IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Collapse(u_, (string)default);

                object w_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime al_ = context.Operators.Start(@this);
                    return al_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> x_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> y_ = context.Operators.First<CqlInterval<CqlDateTime>>(x_);
                Period z_ = CADEncounterMI?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlBoolean ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                return ab_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest ActiveBetaBlocker) {
            Code<MedicationRequest.MedicationrequestStatus> am_ = ActiveBetaBlocker?.StatusElement;
            MedicationRequest.MedicationrequestStatus? an_ = am_?.Value;
            string ao_ = context.Operators.Convert<string>(an_);
            string[] ap_ = [
                "active",
                "completed",
            ];
            CqlBoolean aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);

            CqlBoolean ar_() {
                Code<MedicationRequest.MedicationRequestIntent> as_ = ActiveBetaBlocker?.IntentElement;
                MedicationRequest.MedicationRequestIntent? at_ = as_?.Value;
                string au_ = context.Operators.Convert<string>(at_);
                string[] av_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                return aw_;
            }

            return aq_
                /* CQL 'and' (185:7-186:119) */ && ar_();
        }

        CqlBoolean f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -4548427469715059312L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Beta_Blocker_Therapy_Ordered(context);
        return a_
            /* CQL 'or' (84:3-85:49) */ || this.Is_Currently_Taking_Beta_Blocker_Therapy(context);
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
        CqlBoolean a_ = this.Initial_Population(context);

        CqlBoolean b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
            CqlBoolean d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        }

        return a_
            /* CQL 'and' (115:3-116:80) */ && b_();
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, AtrioventricularBlock, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, CardiacPacerDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
                    h_ = p_ as CqlDateTime;
                }
                else
                {
                    bool r_ = p_ is CqlQuantity;
                    if (r_)
                    {
                        h_ = p_ as CqlQuantity;
                    }
                    else
                    {
                        bool s_ = p_ is CqlInterval<CqlDateTime>;
                        if (s_)
                        {
                            h_ = p_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool t_ = p_ is CqlInterval<CqlQuantity>;
                            if (t_)
                            {
                                h_ = p_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean n_ = context.Operators.Before(j_, m_, (string)default);
                return n_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD without Cardiac Pacer")]
    public bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer, Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer = 599953581061905262L;

    private bool? Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        return a_
            /* CQL 'and' (119:3-120:121) */ && !(this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context))
            /* CQL 'and' (119:3-121:117) */ && !(this.Has_Cardiac_Pacer_Device_Implanted_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context));
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
            CqlBoolean p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);

            CqlBoolean q_() {
                Code<ObservationStatus> t_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.StatusElement;
                ObservationStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return x_;
            }


            CqlBoolean r_() {
                DataType y_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Value;
                CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
                CqlQuantity aa_ = context.Operators.Quantity(50m, "/min");
                CqlBoolean ab_ = context.Operators.Less(z_, aa_);
                return ab_;
            }


            CqlBoolean s_() {
                IEnumerable<Observation> ac_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                bool? ad_(Observation MostRecentPriorHeartRateExam) {
                    Period am_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD?.Period;
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                    DataType ao_ = MostRecentPriorHeartRateExam?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                    CqlBoolean ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(an_, aq_, (string)default);

                    CqlBoolean as_() {
                        Code<ObservationStatus> au_ = MostRecentPriorHeartRateExam?.StatusElement;
                        ObservationStatus? av_ = au_?.Value;
                        string aw_ = context.Operators.Convert<string>(av_);
                        string[] ax_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                        return ay_;
                    }


                    CqlBoolean at_() {
                        DataType az_ = MostRecentPriorHeartRateExam?.Effective;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                        DataType bc_ = tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                        CqlBoolean bf_ = context.Operators.Before(bb_, be_, (string)default);
                        return bf_;
                    }

                    return ar_
                        /* CQL 'and' (134:17-135:90) */ && as_()
                        /* CQL 'and' (134:11-136:111) */ && at_();
                }

                IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(ac_, ad_);

                object af_(Observation @this) {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                    CqlDateTime bj_ = context.Operators.Start(bi_);
                    return bj_;
                }

                IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ah_ = context.Operators.Last<Observation>(ag_);
                DataType ai_ = ah_?.Value;
                CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                CqlQuantity ak_ = context.Operators.Quantity(50m, "/min");
                CqlBoolean al_ = context.Operators.Less(aj_, ak_);
                return al_;
            }

            return p_
                /* CQL 'and' (139:13-140:71) */ && q_()
                /* CQL 'and' (139:13-141:43) */ && r_()
                /* CQL 'and' (139:7-142:48) */ && s_();
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(c_, d_, e_);

        (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? g_((CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? tuple_dyeiilrxycxwhkhdhbjdnjgdc) {
            (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)? bk_ = (CqlTupleMetadata_EWMjLSaIFCaWRZLQBiUcVjDES, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.HeartRateExam, tuple_dyeiilrxycxwhkhdhbjdnjgdc?.CADEncounterModerateOrSevereLVSD);
            return bk_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?, (CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(f_, g_);
        CqlBoolean i_ = context.Operators.Exists<(CqlTupleMetadata, Observation HeartRateExam, Encounter CADEncounterModerateOrSevereLVSD)?>(h_);
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
                CqlBoolean m_ = context.Operators.OverlapsAfter(j_, l_, "day");

                CqlBoolean n_() {
                    object p_ = context.Operators.LateBoundProperty<object>(Event, "clinicalStatus");
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_ as CodeableConcept);

                    CqlBoolean r_() {
                        object s_ = context.Operators.LateBoundProperty<object>(Event, "clinicalStatus");
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                        CqlCode u_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                        CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                        CqlBoolean w_ = context.Operators.Equivalent(t_, v_);
                        return w_;
                    }

                    return (CqlBoolean)(q_ is null)
                        /* CQL 'or' (377:14-379:11) */ || r_();
                }


                CqlBoolean o_() {
                    object x_ = context.Operators.LateBoundProperty<object>(Event, "verificationStatus");
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);

                    CqlBoolean z_() {
                        object aa_ = context.Operators.LateBoundProperty<object>(Event, "verificationStatus");
                        CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_ as CodeableConcept);
                        CqlCode ac_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                        CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                        CqlBoolean ae_ = context.Operators.Equivalent(ab_, ad_);
                        return ae_;
                    }

                    return (CqlBoolean)(y_ is null)
                        /* CQL 'or' (380:14-382:11) */ || z_();
                }

                return (bool?)(m_
                    /* CQL 'and' (376:47-379:11) */ && n_()
                    /* CQL 'and' (376:47-382:11) */ && o_());
            }
            else if (Event is Condition)
            {
                CqlBoolean af_ = AHAOverall_4_1_000.Instance.isVerified(context, Event as AllergyIntolerance);

                CqlBoolean ag_() {
                    CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, (Event as Condition) as Condition);
                    Period ai_ = Visit?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    CqlBoolean ak_ = context.Operators.OverlapsAfter(ah_, aj_, "day");
                    return ak_;
                }

                return (bool?)(af_
                    /* CQL 'and' (383:60-384:75) */ && ag_());
            }
            else
            {
                return false;
            }
        }

        IEnumerable<bool?> b_ = context.Operators.SelectDistinct<Encounter, bool?>(EncounterList, a_);
        CqlBoolean c_ = context.Operators.AnyTrue(b_);
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
            CqlBoolean j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, i_);
            return j_;
        }

        CqlBoolean h_ = context.Operators.WhereAny<AllergyIntolerance>(f_, g_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, ArrhythmiaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, AsthmaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, BradycardiaDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean i_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, h_);
            return i_;
        }

        CqlBoolean g_ = context.Operators.WhereAny<Condition>(e_, f_);
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
            CqlBoolean i_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis, h_);
            return i_;
        }

        CqlBoolean g_ = context.Operators.WhereAny<Condition>(e_, f_);
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
            CqlBoolean f_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis, e_);
            return f_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean h_ = this.overlapsDayOfEncounter(context, HypotensionDiagnosis as Condition, g_);
            return h_;
        }

        CqlBoolean f_ = context.Operators.WhereAny<Condition>(d_, e_);
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
            CqlBoolean j_ = this.overlapsAfterDayOfEncounter(context, BetaBlockerAllergyIntolerance, i_);
            return j_;
        }

        CqlBoolean h_ = context.Operators.WhereAny<AllergyIntolerance>(f_, g_);
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
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
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
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);

            CqlBoolean t_() {
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
                CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
                return z_;
            }


            CqlBoolean u_() {
                List<CodeableConcept> aa_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                CqlConcept ab_(CodeableConcept @this) {
                    CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ag_;
                }

                IEnumerable<CqlConcept> ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aa_, ab_);
                CqlValueSet ad_ = this.Medical_Reason(context);
                CqlBoolean ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);

                CqlBoolean af_() {
                    List<CodeableConcept> ah_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                    CqlConcept ai_(CodeableConcept @this) {
                        CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return am_;
                    }

                    IEnumerable<CqlConcept> aj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ah_, ai_);
                    CqlValueSet ak_ = this.Patient_Reason(context);
                    CqlBoolean al_ = context.Operators.ConceptsInValueSet(aj_, ak_);
                    return al_;
                }

                return ae_
                    /* CQL 'or' (323:13-325:9) */ || af_();
            }

            return s_
                /* CQL 'and' (321:13-322:129) */ && t_()
                /* CQL 'and' (321:7-325:9) */ && u_();
        }

        CqlBoolean f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions 1")]
    public bool? Denominator_Exceptions_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions_1, Denominator_Exceptions_1_Compute);

    private const long _cacheIndex_Denominator_Exceptions_1 = 9061963925225004876L;

    private bool? Denominator_Exceptions_1_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context);
        return a_
            /* CQL 'or' (290:3-291:88) */ || this.Has_Asthma_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-292:93) */ || this.Has_Bradycardia_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-293:93) */ || this.Has_Hypotension_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-294:118) */ || this.Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-295:139) */ || this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-296:141) */ || this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD(context)
            /* CQL 'or' (290:3-297:77) */ || this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(context)
            /* CQL 'or' (290:3-298:126) */ || this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_History_of_Moderate_or_Severe_LVSD_without_Cardiac_Pacer(context);
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
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
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
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);

            CqlBoolean t_() {
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
                CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
                return z_;
            }


            CqlBoolean u_() {
                List<CodeableConcept> aa_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                CqlConcept ab_(CodeableConcept @this) {
                    CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ag_;
                }

                IEnumerable<CqlConcept> ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aa_, ab_);
                CqlValueSet ad_ = this.Medical_Reason(context);
                CqlBoolean ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);

                CqlBoolean af_() {
                    List<CodeableConcept> ah_ = NoBetaBlockerForLVSDOrdered?.ReasonCode;

                    CqlConcept ai_(CodeableConcept @this) {
                        CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return am_;
                    }

                    IEnumerable<CqlConcept> aj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ah_, ai_);
                    CqlValueSet ak_ = this.Patient_Reason(context);
                    CqlBoolean al_ = context.Operators.ConceptsInValueSet(aj_, ak_);
                    return al_;
                }

                return ae_
                    /* CQL 'or' (334:13-336:9) */ || af_();
            }

            return s_
                /* CQL 'and' (332:13-333:129) */ && t_()
                /* CQL 'and' (332:7-336:9) */ && u_();
        }

        CqlBoolean f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions 2")]
    public bool? Denominator_Exceptions_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions_2, Denominator_Exceptions_2_Compute);

    private const long _cacheIndex_Denominator_Exceptions_2 = 805993342753520951L;

    private bool? Denominator_Exceptions_2_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Arrhythmia_with_Qualifying_CAD_Encounter_and_Prior_MI(context);
        return a_
            /* CQL 'or' (301:3-302:62) */ || this.Has_Asthma_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-303:67) */ || this.Has_Bradycardia_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-304:67) */ || this.Has_Hypotension_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-305:92) */ || this.Has_Consecutive_Heart_Rates_Less_than_50_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-306:113) */ || this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-307:115) */ || this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_with_Qualifying_CAD_Encounter_and_Prior_MI(context)
            /* CQL 'or' (301:3-308:76) */ || this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_Therapy(context)
            /* CQL 'or' (301:3-309:100) */ || this.Has_Atrioventricular_Block_with_Qualifying_CAD_Encounter_and_Prior_MI_without_Cardiac_Pacer(context);
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
