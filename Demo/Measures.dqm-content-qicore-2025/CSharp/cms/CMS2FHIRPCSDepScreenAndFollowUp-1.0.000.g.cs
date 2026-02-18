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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS2FHIRPCSDepScreenAndFollowUp", "1.0.000")]
public partial class CMS2FHIRPCSDepScreenAndFollowUp_1_0_000 : ILibrary, ISingleton<CMS2FHIRPCSDepScreenAndFollowUp_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Adolescent Depression Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1567", valueSetVersion: null)]
    public CqlValueSet Adolescent_Depression_Medications(CqlContext _) => _Adolescent_Depression_Medications;
    private static readonly CqlValueSet _Adolescent_Depression_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1567", null);

    [CqlValueSetDefinition("Adult Depression Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1566", valueSetVersion: null)]
    public CqlValueSet Adult_Depression_Medications(CqlContext _) => _Adult_Depression_Medications;
    private static readonly CqlValueSet _Adult_Depression_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1566", null);

    [CqlValueSetDefinition("Bipolar Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext _) => _Bipolar_Disorder;
    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);

    [CqlValueSetDefinition("Encounter to Screen for Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1916", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Screen_for_Depression(CqlContext _) => _Encounter_to_Screen_for_Depression;
    private static readonly CqlValueSet _Encounter_to_Screen_for_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1916", null);

    [CqlValueSetDefinition("Follow Up for Adolescent Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1569", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Adolescent_Depression(CqlContext _) => _Follow_Up_for_Adolescent_Depression;
    private static readonly CqlValueSet _Follow_Up_for_Adolescent_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1569", null);

    [CqlValueSetDefinition("Follow Up for Adult Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1568", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Adult_Depression(CqlContext _) => _Follow_Up_for_Adult_Depression;
    private static readonly CqlValueSet _Follow_Up_for_Adult_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1568", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Physical Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext _) => _Physical_Therapy_Evaluation;
    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlValueSetDefinition("Referral for Adolescent Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1570", valueSetVersion: null)]
    public CqlValueSet Referral_for_Adolescent_Depression(CqlContext _) => _Referral_for_Adolescent_Depression;
    private static readonly CqlValueSet _Referral_for_Adolescent_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1570", null);

    [CqlValueSetDefinition("Referral for Adult Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1571", valueSetVersion: null)]
    public CqlValueSet Referral_for_Adult_Depression(CqlContext _) => _Referral_for_Adult_Depression;
    private static readonly CqlValueSet _Referral_for_Adult_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1571", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Adolescent depression screening assessment", codeId: "73831-0", codeSystem: "http://loinc.org")]
    public CqlCode Adolescent_depression_screening_assessment(CqlContext _) => _Adolescent_depression_screening_assessment;
    private static readonly CqlCode _Adolescent_depression_screening_assessment = new CqlCode("73831-0", "http://loinc.org");

    [CqlCodeDefinition("Adult depression screening assessment", codeId: "73832-8", codeSystem: "http://loinc.org")]
    public CqlCode Adult_depression_screening_assessment(CqlContext _) => _Adult_depression_screening_assessment;
    private static readonly CqlCode _Adult_depression_screening_assessment = new CqlCode("73832-8", "http://loinc.org");

    [CqlCodeDefinition("Depression screening declined (situation)", codeId: "720834000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_declined__situation_(CqlContext _) => _Depression_screening_declined__situation_;
    private static readonly CqlCode _Depression_screening_declined__situation_ = new CqlCode("720834000", "http://snomed.info/sct");

    [CqlCodeDefinition("Depression screening negative (finding)", codeId: "428171000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_negative__finding_(CqlContext _) => _Depression_screening_negative__finding_;
    private static readonly CqlCode _Depression_screening_negative__finding_ = new CqlCode("428171000124102", "http://snomed.info/sct");

    [CqlCodeDefinition("Depression screening positive (finding)", codeId: "428181000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_positive__finding_(CqlContext _) => _Depression_screening_positive__finding_;
    private static readonly CqlCode _Depression_screening_positive__finding_ = new CqlCode("428181000124104", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Adolescent_depression_screening_assessment,
          _Adult_depression_screening_assessment]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Depression_screening_declined__situation_,
          _Depression_screening_negative__finding_,
          _Depression_screening_positive__finding_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-5242312262230522551L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS2FHIRPCSDepScreenAndFollowUp-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(5190855989691056461L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Patient Age 12 Years or Older at Start of Measurement Period")]
    public bool? Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2783151870802141391L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.GreaterOrEqual(h_, 12);
            return i_;
        });


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-2035822618492698192L, () => {
            CqlValueSet a_ = this.Encounter_to_Screen_for_Depression(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Physical_Therapy_Evaluation(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);

            bool? i_(Encounter QualifyingEncounter) {
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                Period l_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, "day");
                Code<Encounter.EncounterStatus> o_ = QualifyingEncounter?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                bool? r_ = context.Operators.Equal(q_, "finished");
                bool? s_ = context.Operators.And(n_, r_);
                return s_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            return j_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2488112324664879244L, () => {
            bool? a_ = this.Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period(context);
            IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Measurement_Period(context);
            bool? c_ = context.Operators.Exists<Encounter>(b_);
            bool? d_ = context.Operators.And(a_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3614056152365125233L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("History of Bipolar Diagnosis Before Qualifying Encounter")]
    public IEnumerable<Condition> History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Condition>>(4747339406206575732L, () => {
            CqlValueSet a_ = this.Bipolar_Disorder(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            IEnumerable<Condition> c_(Condition BipolarDiagnosis) {
                IEnumerable<Encounter> e_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? f_(Encounter QualifyingEncounter) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BipolarDiagnosis as object);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    Period l_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    bool? o_ = context.Operators.Before(k_, n_, "day");
                    return o_;
                }

                IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
                Condition h_(Encounter QualifyingEncounter) => BipolarDiagnosis;
                IEnumerable<Condition> i_ = context.Operators.Select<Encounter, Condition>(g_, h_);
                return i_;
            }

            IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-8456017939157185868L, () => {
            IEnumerable<Condition> a_ = this.History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter(context);
            bool? b_ = context.Operators.Exists<Condition>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Patient Age 12 to 16 Years at Start of Measurement Period")]
    public bool? Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(1190507547705569881L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            CqlInterval<int?> i_ = context.Operators.Interval(12, 16, true, true);
            bool? j_ = context.Operators.In<int?>(h_, i_, default);
            return j_;
        });


    [CqlExpressionDefinition("Most Recent Adolescent Depression Screening")]
    public Observation Most_Recent_Adolescent_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Observation>(-4120863769250766051L, () => {
            CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            IEnumerable<Observation> d_(Observation AdolescentDepressionScreening) {
                IEnumerable<Encounter> i_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? j_(Encounter QualifyingEncounter) {
                    DataType n_ = AdolescentDepressionScreening?.Effective;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                    CqlDateTime q_ = context.Operators.End(p_);
                    Period r_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    CqlQuantity u_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
                    bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    bool? af_ = context.Operators.And(aa_, ae_);
                    DataType ag_ = AdolescentDepressionScreening?.Value;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                    bool? aj_ = context.Operators.And(af_, ai_);
                    Code<ObservationStatus> ak_ = AdolescentDepressionScreening?.StatusElement;
                    ObservationStatus? al_ = ak_?.Value;
                    string am_ = context.Operators.Convert<string>(al_);
                    string[] an_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                    bool? ap_ = context.Operators.And(aj_, ao_);
                    return ap_;
                }

                IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
                Observation l_(Encounter QualifyingEncounter) => AdolescentDepressionScreening;
                IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);
                return m_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

            object f_(Observation @this) {
                DataType aq_ = @this?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                return at_;
            }

            IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
            Observation h_ = context.Operators.Last<Observation>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Most Recent Adolescent Screening Negative")]
    public bool? Has_Most_Recent_Adolescent_Screening_Negative(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7795550947536406787L, () => {
            Observation a_ = this.Most_Recent_Adolescent_Depression_Screening(context);
            Observation[] b_ = [
                a_,
            ];

            bool? c_(Observation AdolescentScreen) {
                DataType g_ = AdolescentScreen?.Value;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode i_ = this.Depression_screening_negative__finding_(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
                return k_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
            Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            return f_;
        });


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adolescent Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(-2454462295688409122L, () => {
            CqlValueSet a_ = this.Adolescent_Depression_Medications(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? t_(Medication M) {
                    object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                    string aa_ = context.Operators.Last<string>(z_);
                    bool? ab_ = context.Operators.Equal(x_, aa_);
                    CodeableConcept ac_ = M?.Code;
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                    CqlValueSet ae_ = this.Adolescent_Depression_Medications(context);
                    bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                    bool? ag_ = context.Operators.And(ab_, af_);
                    return ag_;
                }

                IEnumerable<Medication> u_ = context.Operators.Where<Medication>(s_, t_);
                MedicationRequest v_(Medication M) => MR;
                IEnumerable<MedicationRequest> w_ = context.Operators.Select<Medication, MedicationRequest>(u_, v_);
                return w_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            IEnumerable<MedicationRequest> g_(MedicationRequest AdolescentMed) {
                IEnumerable<Encounter> ah_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? ai_(Encounter QualifyingEncounter) {
                    Observation am_ = this.Most_Recent_Adolescent_Depression_Screening(context);
                    DataType an_ = am_?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                    CqlDateTime aq_ = context.Operators.Start(ap_);
                    Period ar_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlQuantity au_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                    CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    CqlInterval<CqlDateTime> az_ = context.Operators.Interval(av_, ay_, true, true);
                    bool? ba_ = context.Operators.In<CqlDateTime>(aq_, az_, "day");
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime bd_ = context.Operators.Start(bc_);
                    bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                    bool? bf_ = context.Operators.And(ba_, be_);
                    CqlInterval<CqlDate> bg_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdolescentMed);
                    CqlDate bh_ = (bg_ as CqlInterval<CqlDate>)?.low;
                    CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
                    CqlDate bk_ = (bg_ as CqlInterval<CqlDate>)?.high;
                    CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
                    bool? bn_ = (bg_ as CqlInterval<CqlDate>)?.lowClosed;
                    bool? bp_ = (bg_ as CqlInterval<CqlDate>)?.highClosed;
                    CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bi_, bl_, bn_, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    bool? bu_ = context.Operators.OverlapsAfter(br_, bt_, "day");
                    bool? bv_ = context.Operators.And(bf_, bu_);
                    DataType bx_ = am_?.Value;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    CqlCode bz_ = this.Depression_screening_positive__finding_(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    bool? cb_ = context.Operators.Equivalent(by_ as CqlConcept, ca_);
                    bool? cc_ = context.Operators.And(bv_, cb_);
                    Code<MedicationRequest.MedicationrequestStatus> cd_ = AdolescentMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ce_ = cd_?.Value;
                    string cf_ = context.Operators.Convert<string>(ce_);
                    string[] cg_ = [
                        "active",
                        "completed",
                    ];
                    bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                    bool? ci_ = context.Operators.And(cc_, ch_);
                    Code<MedicationRequest.MedicationRequestIntent> cj_ = AdolescentMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ck_ = cj_?.Value;
                    string cl_ = context.Operators.Convert<string>(ck_);
                    string[] cm_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? cn_ = context.Operators.In<string>(cl_, (IEnumerable<string>)cm_);
                    bool? co_ = context.Operators.And(ci_, cn_);
                    return co_;
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);
                MedicationRequest ak_(Encounter QualifyingEncounter) => AdolescentMed;
                IEnumerable<MedicationRequest> al_ = context.Operators.Select<Encounter, MedicationRequest>(aj_, ak_);
                return al_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
            CqlValueSet i_ = this.Referral_for_Adolescent_Depression(context);
            IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? k_(ServiceRequest AdolescentReferral) {
                Code<RequestStatus> cp_ = AdolescentReferral?.StatusElement;
                RequestStatus? cq_ = cp_?.Value;
                Code<RequestStatus> cr_ = context.Operators.Convert<Code<RequestStatus>>(cq_);
                string cs_ = context.Operators.Convert<string>(cr_);
                string[] ct_ = [
                    "active",
                    "completed",
                ];
                bool? cu_ = context.Operators.In<string>(cs_, (IEnumerable<string>)ct_);
                return cu_;
            }

            IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
            IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
            CqlValueSet n_ = this.Follow_Up_for_Adolescent_Depression(context);
            IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? p_(Procedure AdolescentFollowUp) {
                Code<EventStatus> cv_ = AdolescentFollowUp?.StatusElement;
                EventStatus? cw_ = cv_?.Value;
                string cx_ = context.Operators.Convert<string>(cw_);
                bool? cy_ = context.Operators.Equal(cx_, "completed");
                return cy_;
            }

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
            IEnumerable<object> r_ = context.Operators.Union<object>(m_ as IEnumerable<object>, q_ as IEnumerable<object>);
            return r_;
        });


    [CqlExpressionDefinition("Most Recent Adolescent Depression Screening Positive and Follow Up Provided")]
    public IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>>(-3834289523634019273L, () => {
            Observation a_ = this.Most_Recent_Adolescent_Depression_Screening(context);
            Observation[] b_ = [
                a_,
            ];
            IEnumerable<object> c_ = this.Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening(context);
            IEnumerable<Encounter> d_ = this.Qualifying_Encounter_During_Measurement_Period(context);
            IEnumerable<ValueTuple<Observation, object, Encounter>> e_ = context.Operators.CrossJoin<Observation, object, Encounter>((IEnumerable<Observation>)b_, c_, d_);

            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? f_(ValueTuple<Observation, object, Encounter> _valueTuple) {
                (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? m_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> g_ = context.Operators.Select<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(e_, f_);

            bool? h_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
                DataType n_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(14m, "days");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                DataType ag_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlCode ai_ = this.Depression_screening_positive__finding_(context);
                CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
                bool? ak_ = context.Operators.Equivalent(ah_ as CqlConcept, aj_);
                bool? al_ = context.Operators.And(af_, ak_);

                object am_() {

                    bool bt_() {
                        object bx_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlDateTime;
                        return bz_;
                    }


                    bool bu_() {
                        object ca_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                        return cc_;
                    }


                    bool bv_() {
                        object cd_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlQuantity;
                        return cf_;
                    }


                    bool bw_() {
                        object cg_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                        return ci_;
                    }

                    if (bt_())
                    {
                        object cj_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return (ck_ as CqlDateTime) as object;
                    }
                    else if (bu_())
                    {
                        object cl_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        return (cm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bv_())
                    {
                        object cn_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        return (co_ as CqlQuantity) as object;
                    }
                    else if (bw_())
                    {
                        object cp_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        return (cq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, default);
                object as_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "authoredOn");
                CqlDateTime at_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime aw_ = context.Operators.End(av_);
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime az_ = context.Operators.End(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(2m, "days");
                CqlDateTime bb_ = context.Operators.Add(az_, ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(aw_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, "day");
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime bg_ = context.Operators.End(bf_);
                bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                bool? bi_ = context.Operators.And(bd_, bh_);
                bool? bj_ = context.Operators.Or(ar_, bi_);
                bool? bk_ = context.Operators.And(al_, bj_);

                object bl_() {

                    bool cr_() {
                        object cv_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlDateTime;
                        return cx_;
                    }


                    bool cs_() {
                        object cy_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlInterval<CqlDateTime>;
                        return da_;
                    }


                    bool ct_() {
                        object db_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlQuantity;
                        return dd_;
                    }


                    bool cu_() {
                        object de_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        return dg_;
                    }

                    if (cr_())
                    {
                        object dh_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        return (di_ as CqlDateTime) as object;
                    }
                    else if (cs_())
                    {
                        object dj_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        return (dk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ct_())
                    {
                        object dl_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        return (dm_ as CqlQuantity) as object;
                    }
                    else if (cu_())
                    {
                        object dn_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        return (do_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlDateTime bp_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
                CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
                bool? br_ = context.Operators.In<CqlDateTime>(bn_ ?? bp_, bq_, "day");
                bool? bs_ = context.Operators.And(bk_, br_);
                return bs_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> i_ = context.Operators.Where<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(g_, h_);

            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? j_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
                (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? dp_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter);
                return dp_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> k_ = context.Operators.Select<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Patient Age 17 Years at Start of Measurement Period")]
    public bool? Patient_Age_17_Years_at_Start_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-6839495476783362047L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.Equal(h_, 17);
            return i_;
        });


    [CqlExpressionDefinition("Most Recent Adult Depression Screening")]
    public Observation Most_Recent_Adult_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Observation>(-2260780317776156740L, () => {
            CqlCode a_ = this.Adult_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            IEnumerable<Observation> d_(Observation AdultDepressionScreening) {
                IEnumerable<Encounter> i_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? j_(Encounter QualifyingEncounter) {
                    DataType n_ = AdultDepressionScreening?.Effective;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                    CqlDateTime q_ = context.Operators.End(p_);
                    Period r_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    CqlQuantity u_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
                    bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    bool? af_ = context.Operators.And(aa_, ae_);
                    DataType ag_ = AdultDepressionScreening?.Value;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                    bool? aj_ = context.Operators.And(af_, ai_);
                    Code<ObservationStatus> ak_ = AdultDepressionScreening?.StatusElement;
                    ObservationStatus? al_ = ak_?.Value;
                    string am_ = context.Operators.Convert<string>(al_);
                    string[] an_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                    bool? ap_ = context.Operators.And(aj_, ao_);
                    return ap_;
                }

                IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
                Observation l_(Encounter QualifyingEncounter) => AdultDepressionScreening;
                IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);
                return m_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

            object f_(Observation @this) {
                DataType aq_ = @this?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                return at_;
            }

            IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
            Observation h_ = context.Operators.Last<Observation>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Most Recent Adult Screening Negative")]
    public bool? Has_Most_Recent_Adult_Screening_Negative(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2761200117802345495L, () => {
            Observation a_ = this.Most_Recent_Adult_Depression_Screening(context);
            Observation[] b_ = [
                a_,
            ];

            bool? c_(Observation AdultScreen) {
                DataType g_ = AdultScreen?.Value;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode i_ = this.Depression_screening_negative__finding_(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
                return k_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
            Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            return f_;
        });


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adult Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adult_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(8801585706686387465L, () => {
            CqlValueSet a_ = this.Adult_Depression_Medications(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? t_(Medication M) {
                    object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                    string aa_ = context.Operators.Last<string>(z_);
                    bool? ab_ = context.Operators.Equal(x_, aa_);
                    CodeableConcept ac_ = M?.Code;
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                    CqlValueSet ae_ = this.Adult_Depression_Medications(context);
                    bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                    bool? ag_ = context.Operators.And(ab_, af_);
                    return ag_;
                }

                IEnumerable<Medication> u_ = context.Operators.Where<Medication>(s_, t_);
                MedicationRequest v_(Medication M) => MR;
                IEnumerable<MedicationRequest> w_ = context.Operators.Select<Medication, MedicationRequest>(u_, v_);
                return w_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            IEnumerable<MedicationRequest> g_(MedicationRequest AdultMed) {
                IEnumerable<Encounter> ah_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? ai_(Encounter QualifyingEncounter) {
                    Observation am_ = this.Most_Recent_Adult_Depression_Screening(context);
                    DataType an_ = am_?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                    CqlDateTime aq_ = context.Operators.Start(ap_);
                    Period ar_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlQuantity au_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                    CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    CqlInterval<CqlDateTime> az_ = context.Operators.Interval(av_, ay_, true, true);
                    bool? ba_ = context.Operators.In<CqlDateTime>(aq_, az_, "day");
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime bd_ = context.Operators.Start(bc_);
                    bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                    bool? bf_ = context.Operators.And(ba_, be_);
                    CqlInterval<CqlDate> bg_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdultMed);
                    CqlDate bh_ = (bg_ as CqlInterval<CqlDate>)?.low;
                    CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
                    CqlDate bk_ = (bg_ as CqlInterval<CqlDate>)?.high;
                    CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
                    bool? bn_ = (bg_ as CqlInterval<CqlDate>)?.lowClosed;
                    bool? bp_ = (bg_ as CqlInterval<CqlDate>)?.highClosed;
                    CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bi_, bl_, bn_, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    bool? bu_ = context.Operators.OverlapsAfter(br_, bt_, "day");
                    bool? bv_ = context.Operators.And(bf_, bu_);
                    DataType bx_ = am_?.Value;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    CqlCode bz_ = this.Depression_screening_positive__finding_(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    bool? cb_ = context.Operators.Equivalent(by_ as CqlConcept, ca_);
                    bool? cc_ = context.Operators.And(bv_, cb_);
                    Code<MedicationRequest.MedicationrequestStatus> cd_ = AdultMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ce_ = cd_?.Value;
                    string cf_ = context.Operators.Convert<string>(ce_);
                    string[] cg_ = [
                        "active",
                        "completed",
                    ];
                    bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                    bool? ci_ = context.Operators.And(cc_, ch_);
                    Code<MedicationRequest.MedicationRequestIntent> cj_ = AdultMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ck_ = cj_?.Value;
                    string cl_ = context.Operators.Convert<string>(ck_);
                    string[] cm_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? cn_ = context.Operators.In<string>(cl_, (IEnumerable<string>)cm_);
                    bool? co_ = context.Operators.And(ci_, cn_);
                    return co_;
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);
                MedicationRequest ak_(Encounter QualifyingEncounter) => AdultMed;
                IEnumerable<MedicationRequest> al_ = context.Operators.Select<Encounter, MedicationRequest>(aj_, ak_);
                return al_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
            CqlValueSet i_ = this.Referral_for_Adult_Depression(context);
            IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? k_(ServiceRequest AdultReferral) {
                Code<RequestStatus> cp_ = AdultReferral?.StatusElement;
                RequestStatus? cq_ = cp_?.Value;
                Code<RequestStatus> cr_ = context.Operators.Convert<Code<RequestStatus>>(cq_);
                string cs_ = context.Operators.Convert<string>(cr_);
                string[] ct_ = [
                    "active",
                    "completed",
                ];
                bool? cu_ = context.Operators.In<string>(cs_, (IEnumerable<string>)ct_);
                return cu_;
            }

            IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
            IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
            CqlValueSet n_ = this.Follow_Up_for_Adult_Depression(context);
            IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? p_(Procedure AdultFollowUp) {
                Code<EventStatus> cv_ = AdultFollowUp?.StatusElement;
                EventStatus? cw_ = cv_?.Value;
                string cx_ = context.Operators.Convert<string>(cw_);
                bool? cy_ = context.Operators.Equal(cx_, "completed");
                return cy_;
            }

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
            IEnumerable<object> r_ = context.Operators.Union<object>(m_ as IEnumerable<object>, q_ as IEnumerable<object>);
            return r_;
        });


    [CqlExpressionDefinition("Most Recent Adult Depression Screening Positive and Follow Up Provided")]
    public IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>>(-4270614387795433444L, () => {
            Observation a_ = this.Most_Recent_Adult_Depression_Screening(context);
            Observation[] b_ = [
                a_,
            ];
            IEnumerable<object> c_ = this.Follow_Up_Intervention_for_Positive_Adult_Depression_Screening(context);
            IEnumerable<Encounter> d_ = this.Qualifying_Encounter_During_Measurement_Period(context);
            IEnumerable<ValueTuple<Observation, object, Encounter>> e_ = context.Operators.CrossJoin<Observation, object, Encounter>((IEnumerable<Observation>)b_, c_, d_);

            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? f_(ValueTuple<Observation, object, Encounter> _valueTuple) {
                (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? m_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> g_ = context.Operators.Select<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(e_, f_);

            bool? h_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
                DataType n_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(14m, "days");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                DataType ag_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlCode ai_ = this.Depression_screening_positive__finding_(context);
                CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
                bool? ak_ = context.Operators.Equivalent(ah_ as CqlConcept, aj_);
                bool? al_ = context.Operators.And(af_, ak_);

                object am_() {

                    bool bt_() {
                        object bx_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlDateTime;
                        return bz_;
                    }


                    bool bu_() {
                        object ca_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                        return cc_;
                    }


                    bool bv_() {
                        object cd_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlQuantity;
                        return cf_;
                    }


                    bool bw_() {
                        object cg_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                        return ci_;
                    }

                    if (bt_())
                    {
                        object cj_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return (ck_ as CqlDateTime) as object;
                    }
                    else if (bu_())
                    {
                        object cl_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        return (cm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bv_())
                    {
                        object cn_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        return (co_ as CqlQuantity) as object;
                    }
                    else if (bw_())
                    {
                        object cp_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        return (cq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, default);
                object as_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "authoredOn");
                CqlDateTime at_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime aw_ = context.Operators.End(av_);
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime az_ = context.Operators.End(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(2m, "days");
                CqlDateTime bb_ = context.Operators.Add(az_, ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(aw_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, "day");
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime bg_ = context.Operators.End(bf_);
                bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                bool? bi_ = context.Operators.And(bd_, bh_);
                bool? bj_ = context.Operators.Or(ar_, bi_);
                bool? bk_ = context.Operators.And(al_, bj_);

                object bl_() {

                    bool cr_() {
                        object cv_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlDateTime;
                        return cx_;
                    }


                    bool cs_() {
                        object cy_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlInterval<CqlDateTime>;
                        return da_;
                    }


                    bool ct_() {
                        object db_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlQuantity;
                        return dd_;
                    }


                    bool cu_() {
                        object de_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        return dg_;
                    }

                    if (cr_())
                    {
                        object dh_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        return (di_ as CqlDateTime) as object;
                    }
                    else if (cs_())
                    {
                        object dj_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        return (dk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ct_())
                    {
                        object dl_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        return (dm_ as CqlQuantity) as object;
                    }
                    else if (cu_())
                    {
                        object dn_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        return (do_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlDateTime bp_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
                CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
                bool? br_ = context.Operators.In<CqlDateTime>(bn_ ?? bp_, bq_, "day");
                bool? bs_ = context.Operators.And(bk_, br_);
                return bs_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> i_ = context.Operators.Where<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(g_, h_);

            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? j_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
                (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? dp_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter);
                return dp_;
            }

            IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> k_ = context.Operators.Select<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Patient Age 18 Years or Older at Start of Measurement Period")]
    public bool? Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(7123036550210893039L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
            return i_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(8434610617295647640L, () => {
            bool? a_ = this.Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period(context);
            bool? b_ = this.Has_Most_Recent_Adolescent_Screening_Negative(context);
            IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> c_ = this.Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided(context);
            bool? d_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(c_);
            bool? e_ = context.Operators.Or(b_, d_);
            bool? f_ = context.Operators.And(a_, e_);
            bool? g_ = this.Patient_Age_17_Years_at_Start_of_Measurement_Period(context);
            bool? j_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(c_);
            bool? k_ = context.Operators.Or(b_, j_);
            bool? l_ = this.Has_Most_Recent_Adult_Screening_Negative(context);
            bool? m_ = context.Operators.Or(k_, l_);
            IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> n_ = this.Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(context);
            bool? o_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(n_);
            bool? p_ = context.Operators.Or(m_, o_);
            bool? q_ = context.Operators.And(g_, p_);
            bool? r_ = context.Operators.Or(f_, q_);
            bool? s_ = this.Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(context);
            bool? v_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(n_);
            bool? w_ = context.Operators.Or(l_, v_);
            bool? x_ = context.Operators.And(s_, w_);
            bool? y_ = context.Operators.Or(r_, x_);
            return y_;
        });


    [CqlExpressionDefinition("Medical or Patient Reason for Not Screening Adolescent for Depression")]
    public IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Observation>>(-2936847757700556546L, () => {
            CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

            IEnumerable<Observation> d_(Observation NoAdolescentScreen) {
                IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? i_(Encounter QualifyingEncounter) {
                    Instant m_ = NoAdolescentScreen?.IssuedElement;
                    DateTimeOffset? n_ = m_?.Value;
                    CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                    Period p_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    bool? r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");
                    return r_;
                }

                IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                Observation k_(Encounter QualifyingEncounter) => NoAdolescentScreen;
                IEnumerable<Observation> l_ = context.Operators.Select<Encounter, Observation>(j_, k_);
                return l_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

            bool? f_(Observation NoAdolescentScreen) {

                bool? s_(Extension @this) {
                    FhirUri ak_ = @this?.UrlElement;
                    string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return am_;
                }

                IEnumerable<Extension> t_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                    ? (NoAdolescentScreen as DomainResource).Extension
                    : default), s_);

                object u_(Extension @this) {
                    DataType an_ = @this?.Value;
                    return an_;
                }

                IEnumerable<object> v_ = context.Operators.Select<Extension, object>(t_, u_);
                object w_ = context.Operators.SingletonFrom<object>(v_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlCode y_ = this.Depression_screening_declined__situation_(context);
                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(x_, z_);

                bool? ab_(Extension @this) {
                    FhirUri ao_ = @this?.UrlElement;
                    string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return aq_;
                }

                IEnumerable<Extension> ac_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                    ? (NoAdolescentScreen as DomainResource).Extension
                    : default), ab_);

                object ad_(Extension @this) {
                    DataType ar_ = @this?.Value;
                    return ar_;
                }

                IEnumerable<object> ae_ = context.Operators.Select<Extension, object>(ac_, ad_);
                object af_ = context.Operators.SingletonFrom<object>(ae_);
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                CqlValueSet ah_ = this.Medical_Reason(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                bool? aj_ = context.Operators.Or(aa_, ai_);
                return aj_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Has Adolescent Depression Screening")]
    public bool? Has_Adolescent_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6252947328516455428L, () => {
            CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            IEnumerable<Observation> d_(Observation AdolescentScreening) {
                IEnumerable<Encounter> g_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? h_(Encounter QualifyingEncounter) {
                    DataType l_ = AdolescentScreening?.Effective;
                    object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    Period p_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlQuantity s_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                    bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, "day");
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                    bool? ad_ = context.Operators.And(y_, ac_);
                    DataType ae_ = AdolescentScreening?.Value;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    bool? ah_ = context.Operators.And(ad_, ag_);
                    Code<ObservationStatus> ai_ = AdolescentScreening?.StatusElement;
                    ObservationStatus? aj_ = ai_?.Value;
                    string ak_ = context.Operators.Convert<string>(aj_);
                    string[] al_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                    bool? an_ = context.Operators.And(ah_, am_);
                    return an_;
                }

                IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                Observation j_(Encounter QualifyingEncounter) => AdolescentScreening;
                IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
                return k_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
            bool? f_ = context.Operators.Exists<Observation>(e_);
            return f_;
        });


    [CqlExpressionDefinition("Medical or Patient Reason for Not Screening Adult for Depression")]
    public IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Observation>>(-6580700843671872767L, () => {
            CqlCode a_ = this.Adult_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

            IEnumerable<Observation> d_(Observation NoAdultScreen) {
                IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? i_(Encounter QualifyingEncounter) {
                    Instant m_ = NoAdultScreen?.IssuedElement;
                    DateTimeOffset? n_ = m_?.Value;
                    CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                    Period p_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    bool? r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");
                    return r_;
                }

                IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                Observation k_(Encounter QualifyingEncounter) => NoAdultScreen;
                IEnumerable<Observation> l_ = context.Operators.Select<Encounter, Observation>(j_, k_);
                return l_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

            bool? f_(Observation NoAdultScreen) {

                bool? s_(Extension @this) {
                    FhirUri ak_ = @this?.UrlElement;
                    string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return am_;
                }

                IEnumerable<Extension> t_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                    ? (NoAdultScreen as DomainResource).Extension
                    : default), s_);

                object u_(Extension @this) {
                    DataType an_ = @this?.Value;
                    return an_;
                }

                IEnumerable<object> v_ = context.Operators.Select<Extension, object>(t_, u_);
                object w_ = context.Operators.SingletonFrom<object>(v_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlCode y_ = this.Depression_screening_declined__situation_(context);
                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(x_, z_);

                bool? ab_(Extension @this) {
                    FhirUri ao_ = @this?.UrlElement;
                    string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return aq_;
                }

                IEnumerable<Extension> ac_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                    ? (NoAdultScreen as DomainResource).Extension
                    : default), ab_);

                object ad_(Extension @this) {
                    DataType ar_ = @this?.Value;
                    return ar_;
                }

                IEnumerable<object> ae_ = context.Operators.Select<Extension, object>(ac_, ad_);
                object af_ = context.Operators.SingletonFrom<object>(ae_);
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                CqlValueSet ah_ = this.Medical_Reason(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                bool? aj_ = context.Operators.Or(aa_, ai_);
                return aj_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Has Adult Depression Screening")]
    public bool? Has_Adult_Depression_Screening(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4182860248521833426L, () => {
            CqlCode a_ = this.Adult_depression_screening_assessment(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            IEnumerable<Observation> d_(Observation AdultScreening) {
                IEnumerable<Encounter> g_ = this.Qualifying_Encounter_During_Measurement_Period(context);

                bool? h_(Encounter QualifyingEncounter) {
                    DataType l_ = AdultScreening?.Effective;
                    object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    Period p_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlQuantity s_ = context.Operators.Quantity(14m, "days");
                    CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                    bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, "day");
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                    bool? ad_ = context.Operators.And(y_, ac_);
                    DataType ae_ = AdultScreening?.Value;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    bool? ah_ = context.Operators.And(ad_, ag_);
                    Code<ObservationStatus> ai_ = AdultScreening?.StatusElement;
                    ObservationStatus? aj_ = ai_?.Value;
                    string ak_ = context.Operators.Convert<string>(aj_);
                    string[] al_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                    bool? an_ = context.Operators.And(ah_, am_);
                    return an_;
                }

                IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                Observation j_(Encounter QualifyingEncounter) => AdultScreening;
                IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
                return k_;
            }

            IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
            bool? f_ = context.Operators.Exists<Observation>(e_);
            return f_;
        });


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(5259574378864861192L, () => {
            IEnumerable<Observation> a_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression(context);
            bool? b_ = context.Operators.Exists<Observation>(a_);
            bool? c_ = this.Has_Adolescent_Depression_Screening(context);
            bool? d_ = context.Operators.Not(c_);
            bool? e_ = context.Operators.And(b_, d_);
            IEnumerable<Observation> f_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression(context);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            bool? h_ = this.Has_Adult_Depression_Screening(context);
            bool? i_ = context.Operators.Not(h_);
            bool? j_ = context.Operators.And(g_, i_);
            bool? k_ = context.Operators.Or(e_, j_);
            return k_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-4996802696824837470L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(8307048373131935046L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-7267954952347399329L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-1037285051859248970L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS2FHIRPCSDepScreenAndFollowUp_1_0_000() {}

    public static CMS2FHIRPCSDepScreenAndFollowUp_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS2FHIRPCSDepScreenAndFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe = new(
       [typeof(Observation), typeof(object), typeof(Encounter)],
       ["LastAdultScreen", "FollowUpPositiveAdultScreen", "QualifyingEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS = new(
       [typeof(Observation), typeof(object), typeof(Encounter)],
       ["LastAdolescentScreen", "FollowUpPositiveAdolescentScreen", "QualifyingEncounter"]);

    #endregion CqlTupleMetadata Properties

}
