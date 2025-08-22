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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("AHAOverall", "3.0.000")]
public partial class AHAOverall_3_0_000 : ILibrary, ISingleton<AHAOverall_3_0_000>
{
    private AHAOverall_3_0_000() {}

    public static AHAOverall_3_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AHAOverall";
    public string Version => "3.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Left ventricular systolic dysfunction (disorder)", codeId: "134401001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext _) => _Left_ventricular_systolic_dysfunction__disorder_;
    private static readonly CqlCode _Left_ventricular_systolic_dysfunction__disorder_ = new CqlCode("134401001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left_ventricular_systolic_dysfunction__disorder_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("AHAOverall-3.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlFunctionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, object condition)
    {
        bool? a_ = QICoreCommon_4_0_000.Instance.isActive(context, condition);
        object b_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept c_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, b_ as CodeableConcept);
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(c_, e_);
        bool? g_ = context.Operators.And(a_, f_);

        return g_;
    }


    [CqlFunctionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> a_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? b_ = a_?.Value;
        Code<Encounter.EncounterStatus> c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(b_);
        bool? d_ = context.Operators.Equal(c_, "finished");

        return d_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
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
        IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
        {
            CqlValueSet s_ = this.Heart_Failure(context);
            IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> w_ = context.Operators.Union<object>(t_ as IEnumerable<object>, v_ as IEnumerable<object>);
            bool? x_(object HeartFailure)
            {
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartFailure);
                Period ac_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.Overlaps(ab_, ad_, default);
                bool? af_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? ag_ = context.Operators.And(ae_, af_);

                return ag_;
            };
            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            Encounter z_(object HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> aa_ = context.Operators.Select<object, Encounter>(y_, z_);

            return aa_;
        };
        IEnumerable<Encounter> p_ = context.Operators.SelectMany<Encounter, Encounter>(n_, o_);
        bool? q_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            Period ai_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, aj_, "day");
            bool? al_ = this.isFinished(context, QualifyingEncounter);
            bool? am_ = context.Operators.And(ak_, al_);

            return am_;
        };
        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

        return r_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet a_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        bool? c_(Observation EjectionFraction)
        {
            DataType w_ = EjectionFraction?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlQuantity y_ = context.Operators.Quantity(40m, "%");
            bool? z_ = context.Operators.LessOrEqual(x_ as CqlQuantity, y_);
            Code<ObservationStatus> aa_ = EjectionFraction?.StatusElement;
            ObservationStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
            bool? af_ = context.Operators.And(z_, ae_);

            return af_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        CqlValueSet e_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> i_ = context.Operators.Union<object>(f_ as IEnumerable<object>, h_ as IEnumerable<object>);
        CqlCode j_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> p_ = context.Operators.Union<object>(l_ as IEnumerable<object>, o_ as IEnumerable<object>);
        bool? q_(object LVSDDiagnosis)
        {
            object ag_ = context.Operators.LateBoundProperty<object>(LVSDDiagnosis, "severity");
            CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
            CqlValueSet ai_ = this.Moderate_or_Severe(context);
            bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);

            return aj_;
        };
        IEnumerable<object> r_ = context.Operators.Where<object>(p_, q_);
        IEnumerable<object> s_ = context.Operators.Union<object>(i_, r_);
        bool? t_(object ModerateOrSevereLVSD)
        {
            bool? ak_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return ak_;
        };
        IEnumerable<object> u_ = context.Operators.Where<object>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(d_ as IEnumerable<object>, u_ as IEnumerable<object>);

        return v_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> b_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> d_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? e_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVSDFindings as object);
                object j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(i_ ?? l_);
                Period n_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                bool? q_ = context.Operators.Before(m_, p_, default);

                return q_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet a_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_(object HeartTransplantComplications)
        {
            IEnumerable<Encounter> k_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? l_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                object p_ = context.Operators.LateBoundProperty<object>(HeartTransplantComplications, "recordedDate");
                CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime s_ = context.Operators.Start(r_);
                Period t_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                bool? w_ = context.Operators.Before(q_ ?? s_, v_, default);

                return w_;
            };
            IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
            object n_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<object> o_ = context.Operators.Select<Encounter, object>(m_, n_);

            return o_;
        };
        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_(object HeartTransplantComplications)
        {
            bool? x_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return x_;
        };
        IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
        bool? j_ = context.Operators.Exists<object>(i_);

        return j_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                object m_()
                {
                    bool t_()
                    {
                        DataType x_ = LVADOutpatient?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;

                        return z_;
                    };
                    bool u_()
                    {
                        DataType aa_ = LVADOutpatient?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;

                        return ac_;
                    };
                    bool v_()
                    {
                        DataType ad_ = LVADOutpatient?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;

                        return af_;
                    };
                    bool w_()
                    {
                        DataType ag_ = LVADOutpatient?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;

                        return ai_;
                    };
                    if (t_())
                    {
                        DataType aj_ = LVADOutpatient?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = LVADOutpatient?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = LVADOutpatient?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = LVADOutpatient?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);

                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                Period p_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                bool? s_ = context.Operators.Before(o_, r_, default);

                return s_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

            return l_;
        };
        IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
        bool? e_(Procedure LVADOutpatient)
        {
            Code<EventStatus> ar_ = LVADOutpatient?.StatusElement;
            EventStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            bool? au_ = context.Operators.Equal(at_, "completed");

            return au_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        bool? g_ = context.Operators.Exists<Procedure>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_(object LVADComplications)
        {
            IEnumerable<Encounter> k_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? l_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                object p_ = context.Operators.LateBoundProperty<object>(LVADComplications, "recordedDate");
                CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime s_ = context.Operators.Start(r_);
                Period t_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                bool? w_ = context.Operators.Before(q_ ?? s_, v_, default);

                return w_;
            };
            IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
            object n_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<object> o_ = context.Operators.Select<Encounter, object>(m_, n_);

            return o_;
        };
        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_(object LVADComplications)
        {
            bool? x_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return x_;
        };
        IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
        bool? j_ = context.Operators.Exists<object>(i_);

        return j_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
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
        bool? r_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            Period u_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, "day");
            bool? x_ = this.isFinished(context, ValidEncounter);
            bool? y_ = context.Operators.And(w_, x_);

            return y_;
        };
        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        return s_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet a_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                object m_()
                {
                    bool t_()
                    {
                        DataType x_ = HeartTransplant?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;

                        return z_;
                    };
                    bool u_()
                    {
                        DataType aa_ = HeartTransplant?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;

                        return ac_;
                    };
                    bool v_()
                    {
                        DataType ad_ = HeartTransplant?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;

                        return af_;
                    };
                    bool w_()
                    {
                        DataType ag_ = HeartTransplant?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;

                        return ai_;
                    };
                    if (t_())
                    {
                        DataType aj_ = HeartTransplant?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = HeartTransplant?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = HeartTransplant?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = HeartTransplant?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);

                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                Period p_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                bool? s_ = context.Operators.Before(o_, r_, default);

                return s_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

            return l_;
        };
        IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
        bool? e_(Procedure HeartTransplant)
        {
            Code<EventStatus> ar_ = HeartTransplant?.StatusElement;
            EventStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            bool? au_ = context.Operators.Equal(at_, "completed");

            return au_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        bool? g_ = context.Operators.Exists<Procedure>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
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
        IEnumerable<Encounter> j_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> k_(Encounter Encounter1)
        {
            IEnumerable<Encounter> r_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? s_(Encounter Encounter2)
            {
                Id w_ = Encounter2?.IdElement;
                string x_ = w_?.Value;
                Id y_ = Encounter1?.IdElement;
                string z_ = y_?.Value;
                bool? aa_ = context.Operators.Equivalent(x_, z_);
                bool? ab_ = context.Operators.Not(aa_);

                return ab_;
            };
            IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
            Encounter u_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> v_ = context.Operators.Select<Encounter, Encounter>(t_, u_);

            return v_;
        };
        IEnumerable<Encounter> l_ = context.Operators.SelectMany<Encounter, Encounter>(j_, k_);
        bool? m_ = context.Operators.Exists<Encounter>(l_);
        bool? n_ = context.Operators.And(i_, m_);
        IEnumerable<Encounter> o_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? p_ = context.Operators.Exists<Encounter>(o_);
        bool? q_ = context.Operators.And(n_, p_);

        return q_;
    }


    [CqlFunctionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime e_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.In<CqlDateTime>(f_, h_, "day");
            Code<MedicationRequest.MedicationrequestStatus> j_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "active",
                "completed",
            ];
            bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
            bool? o_ = context.Operators.And(i_, n_);
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
            bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
            bool? u_ = context.Operators.And(o_, t_);

            return u_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, object Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Condition);
            Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.Overlaps(e_, g_, "day");
            bool? i_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? j_ = context.Operators.And(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, object Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Condition);
            Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.OverlapsAfter(e_, g_, "day");
            bool? i_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? j_ = context.Operators.And(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            object e_()
            {
                bool o_()
                {
                    DataType s_ = Procedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;

                    return u_;
                };
                bool p_()
                {
                    DataType v_ = Procedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlInterval<CqlDateTime>;

                    return x_;
                };
                bool q_()
                {
                    DataType y_ = Procedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;

                    return aa_;
                };
                bool r_()
                {
                    DataType ab_ = Procedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlQuantity>;

                    return ad_;
                };
                if (o_())
                {
                    DataType ae_ = Procedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);

                    return (af_ as CqlDateTime) as object;
                }
                else if (p_())
                {
                    DataType ag_ = Procedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);

                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (q_())
                {
                    DataType ai_ = Procedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                    return (aj_ as CqlQuantity) as object;
                }
                else if (r_())
                {
                    DataType ak_ = Procedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                    return (al_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.toInterval(context, e_());
            Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.OverlapsAfter(f_, h_, "day");
            Code<EventStatus> j_ = Procedure?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = context.Operators.And(i_, m_);

            return n_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType e_ = AllergyIntolerance?.Onset;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.Start(g_);
            FhirDateTime i_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
            Period l_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.OverlapsAfter(k_, m_, "day");
            CodeableConcept o_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlCode q_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
            CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
            bool? s_ = context.Operators.Equivalent(p_, r_);
            bool? t_ = context.Operators.And(n_, s_);
            CodeableConcept u_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
            CqlCode w_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
            CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
            bool? y_ = context.Operators.Equivalent(v_, x_);
            bool? z_ = context.Operators.And(t_, y_);

            return z_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> e_ = MedicationRequest?.DosageInstruction;
            bool? f_(Dosage @this)
            {
                Timing an_ = @this?.Timing;
                bool? ao_ = context.Operators.Not((bool?)(an_ is null));

                return ao_;
            };
            IEnumerable<Dosage> g_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)e_, f_);
            Timing h_(Dosage @this)
            {
                Timing ap_ = @this?.Timing;

                return ap_;
            };
            IEnumerable<Timing> i_ = context.Operators.Select<Dosage, Timing>(g_, h_);
            bool? j_(Timing @this)
            {
                Timing.RepeatComponent aq_ = @this?.Repeat;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));

                return ar_;
            };
            IEnumerable<Timing> k_ = context.Operators.Where<Timing>(i_, j_);
            Timing.RepeatComponent l_(Timing @this)
            {
                Timing.RepeatComponent as_ = @this?.Repeat;

                return as_;
            };
            IEnumerable<Timing.RepeatComponent> m_ = context.Operators.Select<Timing, Timing.RepeatComponent>(k_, l_);
            bool? n_(Timing.RepeatComponent @this)
            {
                DataType at_ = @this?.Bounds;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool? av_ = context.Operators.Not((bool?)(au_ is null));

                return av_;
            };
            IEnumerable<Timing.RepeatComponent> o_ = context.Operators.Where<Timing.RepeatComponent>(m_, n_);
            object p_(Timing.RepeatComponent @this)
            {
                DataType aw_ = @this?.Bounds;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                return ax_;
            };
            IEnumerable<object> q_ = context.Operators.Select<Timing.RepeatComponent, object>(o_, p_);
            CqlInterval<CqlDateTime> r_(object DoseTime)
            {
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);

                return ay_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> s_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(q_, r_);
            IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(s_);
            IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.Collapse(t_, default);
            object v_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime az_ = context.Operators.Start(@this);

                return az_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> w_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> x_ = context.Operators.First<CqlInterval<CqlDateTime>>(w_);
            Period y_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            bool? aa_ = context.Operators.OverlapsAfter(x_, z_, "day");
            Code<MedicationRequest.MedicationrequestStatus> ab_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "active",
                "completed",
            ];
            bool? af_ = context.Operators.In<string>(ad_, ae_ as IEnumerable<string>);
            bool? ag_ = context.Operators.And(aa_, af_);
            Code<MedicationRequest.MedicationRequestIntent> ah_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
            bool? am_ = context.Operators.And(ag_, al_);

            return am_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlFunctionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType e_ = HeartRateObservation?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            Period h_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            bool? j_ = context.Operators.OverlapsAfter(g_, i_, "day");
            Code<ObservationStatus> k_ = HeartRateObservation?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
            bool? p_ = context.Operators.And(j_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    #endregion Functions and Expressions

}
