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
[CqlLibrary("AHAOverall", "2.8.000")]
public partial class AHAOverall_2_8_000 : ILibrary, ISingleton<AHAOverall_2_8_000>
{
    private AHAOverall_2_8_000() {}

    public static AHAOverall_2_8_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "AHAOverall";
    string ILibrary.Version => "2.8.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);



    [CqlDeclaration("Ejection Fraction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134")]
    public CqlValueSet Ejection_Fraction(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", default);



    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
    public CqlValueSet Heart_Failure(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", default);



    [CqlDeclaration("Heart Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33")]
    public CqlValueSet Heart_Transplant(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", default);



    [CqlDeclaration("Heart Transplant Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56")]
    public CqlValueSet Heart_Transplant_Complications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", default);



    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);



    [CqlDeclaration("Left Ventricular Assist Device Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58")]
    public CqlValueSet Left_Ventricular_Assist_Device_Complications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", default);



    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
    public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", default);



    [CqlDeclaration("Moderate or Severe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092")]
    public CqlValueSet Moderate_or_Severe(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", default);



    [CqlDeclaration("Moderate or Severe LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090")]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", default);



    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);



    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);



    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);



    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
    public CqlValueSet Patient_Provider_Interaction(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", default);



    [CqlDeclaration("Left ventricular systolic dysfunction (disorder)")]
    public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext context) =>
        new CqlCode("134401001", "http://snomed.info/sct", default, default);



    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("134401001", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? a_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept b_ = condition?.VerificationStatus;
        CqlConcept c_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, b_);
        CqlCode d_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(c_, e_);
        bool? g_ = context.Operators.And(a_, f_);

        return g_;
    }


    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> a_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? b_ = a_?.Value;
        Code<Encounter.EncounterStatus> c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(b_);
        bool? d_ = context.Operators.Equal(c_, "finished");

        return d_;
    }



    [CqlDeclaration("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: care services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014) home healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016) nursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012) office visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001) outpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
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
            IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? u_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period z_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.Overlaps(y_, aa_, default);
                bool? ac_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? ad_ = context.Operators.And(ab_, ac_);

                return ad_;
            };
            IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
            Encounter w_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

            return x_;
        };
        IEnumerable<Encounter> p_ = context.Operators.SelectMany<Encounter, Encounter>(n_, o_);
        bool? q_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            Period af_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
            bool? ai_ = this.isFinished(context, QualifyingEncounter);
            bool? aj_ = context.Operators.And(ah_, ai_);

            return aj_;
        };
        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

        return r_;
    }



    [CqlDeclaration("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union of the following: Observations where the final, amended or correction ejection fraction result is <= 40 Moderate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet a_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation EjectionFraction)
        {
            DataType p_ = EjectionFraction?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(40m, "%");
            bool? s_ = context.Operators.LessOrEqual(q_ as CqlQuantity, r_);
            Code<ObservationStatus> t_ = EjectionFraction?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(u_);
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? y_ = context.Operators.In<string>(w_, x_ as IEnumerable<string>);
            bool? z_ = context.Operators.And(s_, y_);

            return z_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        CqlValueSet e_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode g_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? j_(Condition LVSDDiagnosis)
        {
            CodeableConcept aa_ = LVSDDiagnosis?.Severity;
            CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
            CqlValueSet ac_ = this.Moderate_or_Severe(context);
            bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);

            return ad_;
        };
        IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
        IEnumerable<Condition> l_ = context.Operators.Union<Condition>(f_, k_);
        bool? m_(Condition ModerateOrSevereLVSD)
        {
            bool? ae_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return ae_;
        };
        IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(d_ as IEnumerable<object>, n_ as IEnumerable<object>);

        return o_;
    }



    [CqlDeclaration("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> b_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> d_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? e_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_);
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



    [CqlDeclaration("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet a_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime m_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime p_ = context.Operators.Start(o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                bool? t_ = context.Operators.Before(n_ ?? p_, s_, default);

                return t_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_(Condition HeartTransplantComplications)
        {
            bool? u_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return u_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);

        return g_;
    }



    [CqlDeclaration("Has Left Ventricular Assist Device")]
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
                DataType m_ = LVADOutpatient?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                bool? t_ = context.Operators.Before(p_, s_, default);

                return t_;
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
            Code<EventStatus> u_ = LVADOutpatient?.StatusElement;
            EventStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            bool? x_ = context.Operators.Equal(w_, "completed");

            return x_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        bool? g_ = context.Operators.Exists<Procedure>(f_);

        return g_;
    }



    [CqlDeclaration("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition LVADComplications)
        {
            IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime m_ = LVADComplications?.RecordedDateElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime p_ = context.Operators.Start(o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                bool? t_ = context.Operators.Before(n_ ?? p_, s_, default);

                return t_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_(Condition LVADComplications)
        {
            bool? u_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return u_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);

        return g_;
    }



    [CqlDeclaration("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: office visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001) outpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008) nursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012) care services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014) home healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016) patient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
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



    [CqlDeclaration("Has Heart Transplant")]
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
                DataType m_ = HeartTransplant?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                bool? t_ = context.Operators.Before(p_, s_, default);

                return t_;
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
            Code<EventStatus> u_ = HeartTransplant?.StatusElement;
            EventStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            bool? x_ = context.Operators.Equal(w_, "completed");

            return x_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        bool? g_ = context.Operators.Exists<Procedure>(f_);

        return g_;
    }



    [CqlDeclaration("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria: 18 years of age or older, has two Has two Qualifying Outpatient Encounters During Measurement Period Has a Heart Failure Outpatient Encounter")]
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


    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
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


    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
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


    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType e_ = Procedure?.Performed;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_);
            Period h_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            bool? j_ = context.Operators.OverlapsAfter(g_, i_, "day");
            Code<EventStatus> k_ = Procedure?.StatusElement;
            EventStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            bool? n_ = context.Operators.Equal(m_, "completed");
            bool? o_ = context.Operators.And(j_, n_);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType e_ = AllergyIntolerance?.Onset;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.Start(g_);
            FhirDateTime i_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
            Period l_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.OverlapsAfter(k_, m_, "day");
            CodeableConcept o_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlCode q_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
            bool? s_ = context.Operators.Equivalent(p_, r_);
            bool? t_ = context.Operators.And(n_, s_);
            CodeableConcept u_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
            CqlCode w_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
            bool? y_ = context.Operators.Equivalent(v_, x_);
            bool? z_ = context.Operators.And(t_, y_);

            return z_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


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
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

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


    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType e_ = HeartRateObservation?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_);
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


    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

}
