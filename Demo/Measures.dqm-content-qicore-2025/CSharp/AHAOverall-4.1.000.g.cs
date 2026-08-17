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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("AHAOverall", "4.1.000")]
public partial class AHAOverall_4_1_000 : ILibrary, ISingleton<AHAOverall_4_1_000>
{
    #region ValueSets (14)

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Ejection Fraction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", valueSetVersion: null)]
    public CqlValueSet Ejection_Fraction(CqlContext _) => _Ejection_Fraction;
    private static readonly CqlValueSet _Ejection_Fraction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", null);

    [CqlValueSetDefinition("Heart Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", valueSetVersion: null)]
    public CqlValueSet Heart_Failure(CqlContext _) => _Heart_Failure;
    private static readonly CqlValueSet _Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    [CqlValueSetDefinition("Heart Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", valueSetVersion: null)]
    public CqlValueSet Heart_Transplant(CqlContext _) => _Heart_Transplant;
    private static readonly CqlValueSet _Heart_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", null);

    [CqlValueSetDefinition("Heart Transplant Complications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", valueSetVersion: null)]
    public CqlValueSet Heart_Transplant_Complications(CqlContext _) => _Heart_Transplant_Complications;
    private static readonly CqlValueSet _Heart_Transplant_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Left Ventricular Assist Device Complications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Complications(CqlContext _) => _Left_Ventricular_Assist_Device_Complications;
    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", null);

    [CqlValueSetDefinition("Left Ventricular Assist Device Placement", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext _) => _Left_Ventricular_Assist_Device_Placement;
    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Placement = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", null);

    [CqlValueSetDefinition("Moderate or Severe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe(CqlContext _) => _Moderate_or_Severe;
    private static readonly CqlValueSet _Moderate_or_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", null);

    [CqlValueSetDefinition("Moderate or Severe LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext _) => _Moderate_or_Severe_LVSD;
    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

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

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Left ventricular systolic dysfunction (disorder)", codeId: "134401001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext _) => _Left_ventricular_systolic_dysfunction__disorder_;
    private static readonly CqlCode _Left_ventricular_systolic_dysfunction__disorder_ = new CqlCode("134401001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left_ventricular_systolic_dysfunction__disorder_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 6517944951610092532L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("AHAOverall-4.1.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3100901233771399594L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Outpatient Encounter")]
    public IEnumerable<Encounter> Outpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounter, Outpatient_Encounter_Compute);

    private const long _cacheIndex_Outpatient_Encounter = -6041966605676774732L;

    private IEnumerable<Encounter> Outpatient_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Office_Visit(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
        return n_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = !((bool?)(b_ is null));
        // CQL 'implies' (166:3-170:3): right operand skipped when left is false
        if (c_ is false)
        {
            return true;
        }
        else
        {
            CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
            bool? f_ = context.Operators.Equivalent(b_, e_);
            bool? g_;
            // CQL 'or' (166:54-167:66): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CodeableConcept j_ = condition?.VerificationStatus;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                g_ = f_ | n_;
            }
            bool? h_;
            // CQL 'or' (166:54-168:66): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                CodeableConcept o_ = condition?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(p_, r_);
                h_ = g_ | s_;
            }
            bool? i_;
            // CQL 'or' (166:52-170:3): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CodeableConcept t_ = condition?.VerificationStatus;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                i_ = h_ | x_;
            }
            return !c_ | i_;
        }
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        CodeableConcept a_ = AllergyIntolerance?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = !((bool?)(b_ is null));
        // CQL 'implies' (249:3-251:3): right operand skipped when left is false
        if (c_ is false)
        {
            return true;
        }
        else
        {
            CqlCode d_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
            CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
            bool? f_ = context.Operators.Equivalent(b_, e_);
            bool? g_;
            // CQL 'or' (249:61-251:3): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CodeableConcept h_ = AllergyIntolerance?.VerificationStatus;
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlCode j_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                g_ = f_ | l_;
            }
            return !c_ | g_;
        }
    }


    [CqlFunctionDefinition("isEncounterFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isEncounterFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> a_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? b_ = a_?.Value;
        Code<Encounter.EncounterStatus> c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(b_);
        bool? d_ = context.Operators.Equal(c_, "finished");
        return d_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consultation (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Heart_Failure_Outpatient_Encounter, Heart_Failure_Outpatient_Encounter_Compute);

    private const long _cacheIndex_Heart_Failure_Outpatient_Encounter = 2956605661681219693L;

    private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounter(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet f_ = this.Heart_Failure(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);

            bool? j_(Condition HeartFailure) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartFailure);
                Period m_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(l_, n_, "day");
                // CQL 'and' (44:17-45:39): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    bool? p_ = this.isVerified(context, HeartFailure);
                    return o_ & p_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
            // CQL 'and' (46:5-47:53): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                bool? u_ = this.isEncounterFinished(context, QualifyingEncounter);
                return t_ & u_;
            }
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Moderate_or_Severe_LVSD_Findings, Moderate_or_Severe_LVSD_Findings_Compute);

    private const long _cacheIndex_Moderate_or_Severe_LVSD_Findings = -4227547430957034610L;

    private IEnumerable<object> Moderate_or_Severe_LVSD_Findings_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? c_(Observation EjectionFraction) {
            DataType t_ = EjectionFraction?.Value;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlQuantity v_ = context.Operators.Quantity(40m, "%");
            bool? w_ = context.Operators.LessOrEqual(u_ as CqlQuantity, v_);
            // CQL 'and' (134:7-135:74): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> x_ = EjectionFraction?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return w_ & ab_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        CqlValueSet e_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
        CqlCode i_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> m_ = context.Operators.Union<Condition>(k_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);

        bool? n_(Condition LVSDDiagnosis) {
            CodeableConcept ac_ = LVSDDiagnosis?.Severity;
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
            CqlValueSet ae_ = this.Moderate_or_Severe(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            return af_;
        }

        IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
        IEnumerable<Condition> p_ = context.Operators.Union<Condition>(h_, o_);

        bool? q_(Condition ModerateOrSevereLVSD) {
            bool? ag_ = this.isVerified(context, ModerateOrSevereLVSD);
            return ag_;
        }

        IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
        IEnumerable<object> s_ = context.Operators.Union<object>(d_ as IEnumerable<object>, r_ as IEnumerable<object>);
        return s_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD, Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD_Compute);

    private const long _cacheIndex_Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD = 5061391783387072208L;

    private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter(context);

        bool? b_(Encounter HFOutpatientEncounter) {
            IEnumerable<object> d_ = this.Moderate_or_Severe_LVSD_Findings(context);

            bool? e_(object LVSDFindings) {
                CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object h_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(g_ ?? j_);
                Period l_ = HFOutpatientEncounter?.Period;
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


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Heart_Transplant_Complications, Has_Heart_Transplant_Complications_Compute);

    private const long _cacheIndex_Has_Heart_Transplant_Complications = 6060037146234108555L;

    private bool? Has_Heart_Transplant_Complications_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition HeartTransplantComplications) {
            IEnumerable<Encounter> i_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? j_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime m_ = context.Operators.Start(l_);
                FhirDateTime n_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlDate p_ = context.Operators.DateFrom(m_ ?? o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, (string)default);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition HeartTransplantComplications) {
            bool? v_ = this.isVerified(context, HeartTransplantComplications);
            return v_;
        }

        bool? h_ = context.Operators.WhereAny<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Left_Ventricular_Assist_Device, Has_Left_Ventricular_Assist_Device_Compute);

    private const long _cacheIndex_Has_Left_Ventricular_Assist_Device = 5321459225267215221L;

    private bool? Has_Left_Ventricular_Assist_Device_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure LVADPlacement) {
            IEnumerable<Encounter> g_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                object j_;
                DataType q_ = LVADPlacement?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = LVADPlacement?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = LVADPlacement?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = LVADPlacement?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = LVADPlacement?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = LVADPlacement?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = LVADPlacement?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = LVADPlacement?.Performed;
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
                Period m_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, "day");
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure LVADPlacement) {
            Code<EventStatus> ak_ = LVADPlacement?.StatusElement;
            EventStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            bool? an_ = context.Operators.Equal(am_, "completed");
            return an_;
        }

        bool? f_ = context.Operators.WhereAny<Procedure>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Left_Ventricular_Assist_Device_Complications, Has_Left_Ventricular_Assist_Device_Complications_Compute);

    private const long _cacheIndex_Has_Left_Ventricular_Assist_Device_Complications = 1302866891469071395L;

    private bool? Has_Left_Ventricular_Assist_Device_Complications_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition LVADComplications) {
            IEnumerable<Encounter> i_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? j_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime m_ = context.Operators.Start(l_);
                FhirDateTime n_ = LVADComplications?.RecordedDateElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlDate p_ = context.Operators.DateFrom(m_ ?? o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, (string)default);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition LVADComplications) {
            bool? v_ = this.isVerified(context, LVADComplications);
            return v_;
        }

        bool? h_ = context.Operators.WhereAny<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Outpatient Encounter or Patient Provider Interaction")]
    public IEnumerable<Encounter> Outpatient_Encounter_or_Patient_Provider_Interaction(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounter_or_Patient_Provider_Interaction, Outpatient_Encounter_or_Patient_Provider_Interaction_Compute);

    private const long _cacheIndex_Outpatient_Encounter_or_Patient_Provider_Interaction = 7004331100707194591L;

    private IEnumerable<Encounter> Outpatient_Encounter_or_Patient_Provider_Interaction_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounter(context);
        CqlValueSet b_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> c_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> d_ = context.Operators.Union<Encounter>(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consultation (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Outpatient_Encounter_During_Measurement_Period, Qualifying_Outpatient_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Outpatient_Encounter_During_Measurement_Period = -7380487324297278152L;

    private IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounter_or_Patient_Provider_Interaction(context);

        bool? b_(Encounter ValidEncounter) {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            Period e_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            bool? g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, f_, "day");
            // CQL 'and' (102:5-103:48): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = this.isEncounterFinished(context, ValidEncounter);
                return g_ & h_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Heart_Transplant, Has_Heart_Transplant_Compute);

    private const long _cacheIndex_Has_Heart_Transplant = 6513985918444010793L;

    private bool? Has_Heart_Transplant_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure HeartTransplant) {
            IEnumerable<Encounter> g_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                object j_;
                DataType q_ = HeartTransplant?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = HeartTransplant?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = HeartTransplant?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = HeartTransplant?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = HeartTransplant?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = HeartTransplant?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = HeartTransplant?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = HeartTransplant?.Performed;
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
                Period m_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, (string)default);
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure HeartTransplant) {
            Code<EventStatus> ak_ = HeartTransplant?.StatusElement;
            EventStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            bool? an_ = context.Operators.Equal(am_, "completed");
            return an_;
        }

        bool? f_ = context.Operators.WhereAny<Procedure>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Is Adult With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older,\nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period, Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period_Compute);

    private const long _cacheIndex_Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period = -4441809613322863868L;

    private bool? Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period_Compute(CqlContext context)
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
        bool? j_;
        // CQL 'and' (154:3-158:5): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            IEnumerable<Encounter> k_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);

            bool? l_(Encounter Encounter1) {
                IEnumerable<Encounter> n_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);

                bool? o_(Encounter Encounter2) {
                    Id q_ = Encounter2?.IdElement;
                    string r_ = q_?.Value;
                    Id s_ = Encounter1?.IdElement;
                    string t_ = s_?.Value;
                    bool? u_ = context.Operators.Equivalent(r_, t_);
                    return !u_;
                }

                bool? p_ = context.Operators.WhereAny<Encounter>(n_, o_);
                return p_;
            }

            bool? m_ = context.Operators.WhereAny<Encounter>(k_, l_);
            j_ = i_ & m_;
        }
        // CQL 'and' (154:3-159:51): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> v_ = this.Heart_Failure_Outpatient_Encounter(context);
            bool? w_ = context.Operators.Exists<Encounter>(v_);
            return j_ & w_;
        }
    }


    [CqlFunctionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            FhirDateTime d_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
            Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.In<CqlDateTime>(e_, g_, "day");
            bool? i_;
            // CQL 'and' (183:13-184:65): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> k_ = MedicationRequest?.StatusElement;
                MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "active",
                    "completed",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                i_ = h_ & o_;
            }
            bool? j_;
            // CQL 'and' (183:13-185:119): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> p_ = MedicationRequest?.IntentElement;
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
                j_ = i_ & t_;
            }
            // CQL 'and' (183:7-189:9): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Task> u_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? v_(Task TaskReject) {
                    ResourceReference x_ = TaskReject?.Focus;
                    bool? y_ = QICoreCommon_4_0_000.Instance.references(context, x_, MedicationRequest);
                    // CQL 'and' (187:13-188:58): right operand skipped when left is false
                    if (y_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept z_ = TaskReject?.Code;
                        CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                        CqlCode ab_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                        bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                        return y_ & ad_;
                    }
                }

                bool? w_ = context.Operators.WhereAny<Task>(u_, v_);
                return j_ & !w_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isMedicationNotRequestedOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationNotRequested overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? isMedicationNotRequestedOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            FhirDateTime d_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
            Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.In<CqlDateTime>(e_, g_, "day");
            bool? i_;
            // CQL 'and' (197:13-198:65): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> k_ = MedicationRequest?.StatusElement;
                MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "completed",
                    "active",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                i_ = h_ & o_;
            }
            bool? j_;
            // CQL 'and' (197:13-199:119): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> p_ = MedicationRequest?.IntentElement;
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
                j_ = i_ & t_;
            }
            // CQL 'and' (197:7-203:9): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Task> u_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? v_(Task TaskReject) {
                    ResourceReference x_ = TaskReject?.Focus;
                    bool? y_ = QICoreCommon_4_0_000.Instance.references(context, x_, MedicationRequest);
                    // CQL 'and' (201:13-202:58): right operand skipped when left is false
                    if (y_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept z_ = TaskReject?.Code;
                        CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                        CqlCode ab_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                        bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                        return y_ & ad_;
                    }
                }

                bool? w_ = context.Operators.WhereAny<Task>(u_, v_);
                return j_ & !w_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            CqlInterval<CqlDateTime> d_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Condition);
            Period e_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            bool? g_ = context.Operators.Overlaps(d_, f_, "day");
            // CQL 'and' (211:7-212:36): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = this.isVerified(context, Condition);
                return g_ & h_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            CqlInterval<CqlDateTime> d_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Condition);
            Period e_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            bool? g_ = context.Operators.OverlapsAfter(d_, f_, "day");
            // CQL 'and' (221:7-222:36): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = this.isVerified(context, Condition);
                return g_ & h_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            object d_;
            DataType i_ = Procedure?.Performed;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            bool k_ = j_ is CqlDateTime;
            if (k_)
            {
                DataType l_ = Procedure?.Performed;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                d_ = m_ as CqlDateTime;
            }
            else
            {
                DataType n_ = Procedure?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlQuantity;
                if (p_)
                {
                    DataType q_ = Procedure?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    d_ = r_ as CqlQuantity;
                }
                else
                {
                    DataType s_ = Procedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    if (u_)
                    {
                        DataType v_ = Procedure?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        d_ = w_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType x_ = Procedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlQuantity>;
                        if (z_)
                        {
                            DataType aa_ = Procedure?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            d_ = ab_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            d_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.toInterval(context, d_);
            Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.OverlapsAfter(e_, g_, "day");
            // CQL 'and' (231:7-232:42): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                Code<EventStatus> ac_ = Procedure?.StatusElement;
                EventStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "completed");
                return h_ & af_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            DataType d_ = AllergyIntolerance?.Onset;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.toInterval(context, e_);
            CqlDateTime g_ = context.Operators.Start(f_);
            FhirDateTime h_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
            Period k_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            bool? m_ = context.Operators.OverlapsAfter(j_, l_, "day");
            // CQL 'and' (241:7-242:45): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                bool? n_ = this.isVerified(context, AllergyIntolerance);
                return m_ & n_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            List<Dosage> d_ = MedicationRequest?.DosageInstruction;

            bool? e_(Dosage @this) {
                Timing y_ = @this?.Timing;
                return !((bool?)(y_ is null));
            }


            Timing f_(Dosage @this) {
                Timing z_ = @this?.Timing;
                return z_;
            }

            IEnumerable<Timing> g_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)d_, e_, f_);

            bool? h_(Timing @this) {
                Timing.RepeatComponent aa_ = @this?.Repeat;
                return !((bool?)(aa_ is null));
            }


            Timing.RepeatComponent i_(Timing @this) {
                Timing.RepeatComponent ab_ = @this?.Repeat;
                return ab_;
            }

            IEnumerable<Timing.RepeatComponent> j_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(g_, h_, i_);

            bool? k_(Timing.RepeatComponent @this) {
                DataType ac_ = @this?.Bounds;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }


            object l_(Timing.RepeatComponent @this) {
                DataType ae_ = @this?.Bounds;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                return af_;
            }

            IEnumerable<object> m_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(j_, k_, l_);

            CqlInterval<CqlDateTime> n_(object DoseTime) {
                FhirDateTime ag_ = MedicationRequest?.AuthoredOnElement;
                CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
                CqlInterval<CqlDateTime> ai_ = this.TimingBoundToInterval(context, ah_, DoseTime);
                return ai_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> o_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(m_, n_);
            IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Collapse(o_, (string)default);

            object q_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime aj_ = context.Operators.Start(@this);
                return aj_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> r_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> s_ = context.Operators.First<CqlInterval<CqlDateTime>>(r_);
            Period t_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            bool? v_ = context.Operators.OverlapsAfter(s_, u_, "day");
            bool? w_;
            // CQL 'and' (259:13-264:65): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> ak_ = MedicationRequest?.StatusElement;
                MedicationRequest.MedicationrequestStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "active",
                    "completed",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                w_ = v_ & ao_;
            }
            bool? x_;
            // CQL 'and' (259:13-265:119): right operand skipped when left is false
            if (w_ is false)
            {
                x_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ap_ = MedicationRequest?.IntentElement;
                MedicationRequest.MedicationRequestIntent? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                string[] as_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
                x_ = w_ & at_;
            }
            // CQL 'and' (259:7-269:9): right operand skipped when left is false
            if (x_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Task> au_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? av_(Task TaskReject) {
                    ResourceReference ax_ = TaskReject?.Focus;
                    bool? ay_ = QICoreCommon_4_0_000.Instance.references(context, ax_, MedicationRequest);
                    // CQL 'and' (267:13-268:58): right operand skipped when left is false
                    if (ay_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept az_ = TaskReject?.Code;
                        CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                        CqlCode bb_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                        bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                        return ay_ & bd_;
                    }
                }

                bool? aw_ = context.Operators.WhereAny<Task>(au_, av_);
                return x_ & !aw_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
            DataType d_ = HeartRateObservation?.Effective;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.toInterval(context, e_);
            Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.OverlapsAfter(f_, h_, "day");
            // CQL 'and' (278:7-279:78): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> j_ = HeartRateObservation?.StatusElement;
                ObservationStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                return i_ & n_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("TimingBoundToInterval")]
    public CqlInterval<CqlDateTime> TimingBoundToInterval(CqlContext context, CqlDateTime startDate, object choice)
    {
        if (choice is CqlInterval<CqlDateTime>)
        {
            return choice as CqlInterval<CqlDateTime>;
        }
        else if (choice is CqlInterval<CqlQuantity>)
        {
            object a_ = context.Operators.LateBoundProperty<object>(choice, "low");
            CqlDateTime b_ = context.Operators.Add(startDate, a_ as CqlQuantity);
            object c_ = context.Operators.LateBoundProperty<object>(choice, "high");
            CqlDateTime d_ = context.Operators.Add(startDate, c_ as CqlQuantity);
            CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, true, true);
            return e_;
        }
        else if (choice is CqlQuantity)
        {
            CqlDateTime f_ = context.Operators.Add(startDate, choice as CqlQuantity);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(startDate, f_, true, false);
            return g_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private AHAOverall_4_1_000() {}

    public static AHAOverall_4_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "AHAOverall";
    public string Version => "4.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
