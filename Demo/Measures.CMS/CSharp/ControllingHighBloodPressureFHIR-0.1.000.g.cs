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
[CqlLibrary("ControllingHighBloodPressureFHIR", "0.1.000")]
public partial class ControllingHighBloodPressureFHIR_0_1_000 : ILibrary, ISingleton<ControllingHighBloodPressureFHIR_0_1_000>
{
    private ControllingHighBloodPressureFHIR_0_1_000() {}

    public static ControllingHighBloodPressureFHIR_0_1_000 Instance { get; } = new();

    public string Name => "ControllingHighBloodPressureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Status_1_8_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance];

    [CqlDeclaration("Chronic Kidney Disease, Stage 5")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002")]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", default);

    [CqlDeclaration("Dialysis Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013")]
    public CqlValueSet Dialysis_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", default);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);

    [CqlDeclaration("ESRD Monthly Outpatient Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014")]
    public CqlValueSet ESRD_Monthly_Outpatient_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", default);

    [CqlDeclaration("Essential Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011")]
    public CqlValueSet Essential_Hypertension(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", default);

    [CqlDeclaration("Kidney Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012")]
    public CqlValueSet Kidney_Transplant(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", default);

    [CqlDeclaration("Kidney Transplant Recipient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029")]
    public CqlValueSet Kidney_Transplant_Recipient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", default);

    [CqlDeclaration("Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378")]
    public CqlValueSet Pregnancy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", default);

    [CqlDeclaration("Diastolic blood pressure")]
    public CqlCode Diastolic_blood_pressure(CqlContext context) =>
        new CqlCode("8462-4", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure(CqlContext context) =>
        new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("8462-4", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("ControllingHighBloodPressureFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("Essential Hypertension Diagnosis")]
    public IEnumerable<Condition> Essential_Hypertension_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Hypertension)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDateTime i_ = context.Operators.Start(f_);
            CqlQuantity j_ = context.Operators.Quantity(6m, "months");
            CqlDateTime k_ = context.Operators.Add(i_, j_);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(g_, k_, true, false);
            bool? m_ = context.Operators.Overlaps(e_, l_, default);

            return m_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 85, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Condition> k_ = this.Essential_Hypertension_Diagnosis(context);
        bool? l_ = context.Operators.Exists<Condition>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        IEnumerable<Encounter> n_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? o_ = context.Operators.Exists<Encounter>(n_);
        bool? p_ = context.Operators.And(m_, o_);

        return p_;
    }

    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }

    [CqlDeclaration("Pregnancy or Renal Diagnosis")]
    public IEnumerable<Condition> Pregnancy_or_Renal_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet h_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
        bool? l_(Condition PregnancyESRDDiagnosis)
        {
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.Overlaps(n_, o_, default);

            return p_;
        };
        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);

        return m_;
    }

    [CqlDeclaration("End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        IEnumerable<Procedure> f_ = Status_1_8_000.Instance.isProcedurePerformed(context, e_);
        bool? g_(Procedure ESRDProcedure)
        {
            DataType i_ = ESRDProcedure?.Performed;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.toInterval(context, j_);
            CqlDateTime l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.End(m_);
            bool? o_ = context.Operators.SameOrBefore(l_, n_, default);

            return o_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);

        return h_;
    }

    [CqlDeclaration("End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_8_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter ESRDEncounter)
        {
            Period f_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_ as object);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, default);

            return l_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        IEnumerable<Procedure> e_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? f_ = context.Operators.Exists<Procedure>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        IEnumerable<Encounter> h_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        bool? j_ = context.Operators.Or(g_, i_);
        bool? k_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? l_ = context.Operators.Or(j_, k_);
        bool? m_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? n_ = context.Operators.Or(l_, m_);
        bool? o_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? p_ = context.Operators.Or(n_, o_);

        return p_;
    }

    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? b_(Encounter E)
        {
            Id e_ = E?.IdElement;
            string f_ = e_?.Value;
            FhirString g_ = reference?.ReferenceElement;
            string h_ = g_?.Value;
            string i_ = QICoreCommon_2_1_000.Instance.getId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_ = context.Operators.SingletonFrom<Encounter>(c_);

        return d_;
    }

    [CqlDeclaration("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> b_ = Status_1_8_000.Instance.isObservationBP(context, a_);
        bool? c_(Observation BloodPressure)
        {
            ResourceReference e_ = BloodPressure?.Encounter;
            Encounter f_ = this.getEncounter(context, e_);
            Coding g_ = f_?.Class;
            CqlCode h_ = FHIRHelpers_4_4_000.Instance.ToCode(context, g_);
            string i_ = h_?.code;
            string[] j_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? k_ = context.Operators.In<string>(i_, j_ as IEnumerable<string>);
            bool? l_ = context.Operators.Not(k_);
            DataType m_ = BloodPressure?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlDateTime o_ = QICoreCommon_2_1_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
            bool? r_ = context.Operators.And(l_, q_);

            return r_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Qualifying Diastolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Diastolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> b_ = Status_1_8_000.Instance.isObservationBP(context, a_);
        bool? c_(Observation BloodPressure)
        {
            ResourceReference e_ = BloodPressure?.Encounter;
            Encounter f_ = this.getEncounter(context, e_);
            Coding g_ = f_?.Class;
            CqlCode h_ = FHIRHelpers_4_4_000.Instance.ToCode(context, g_);
            string i_ = h_?.code;
            string[] j_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? k_ = context.Operators.In<string>(i_, j_ as IEnumerable<string>);
            bool? l_ = context.Operators.Not(k_);
            DataType m_ = BloodPressure?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlDateTime o_ = QICoreCommon_2_1_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
            bool? r_ = context.Operators.And(l_, q_);

            return r_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        CqlDate b_(Observation DBPExam)
        {
            DataType j_ = DBPExam?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.latest(context, k_);
            CqlDate m_ = context.Operators.DateFrom(l_);

            return m_;
        };
        IEnumerable<CqlDate> c_ = context.Operators.Select<Observation, CqlDate>(a_, b_);
        IEnumerable<CqlDate> d_ = context.Operators.Distinct<CqlDate>(c_);
        IEnumerable<Observation> e_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        CqlDate f_(Observation SBPExam)
        {
            DataType n_ = SBPExam?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlDateTime p_ = QICoreCommon_2_1_000.Instance.latest(context, o_);
            CqlDate q_ = context.Operators.DateFrom(p_);

            return q_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Observation, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        IEnumerable<CqlDate> i_ = context.Operators.Intersect<CqlDate>(d_, h_);

        return i_;
    }

    [CqlDeclaration("Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> b_ = context.Operators.ListSort<CqlDate>(a_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate c_ = context.Operators.Last<CqlDate>(b_);

        return c_;
    }

    [CqlDeclaration("Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? b_(Observation SBPReading)
        {
            DataType i_ = SBPReading?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_2_1_000.Instance.latest(context, j_);
            CqlDate l_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            bool? n_ = context.Operators.SameAs(k_, m_, "day");

            return n_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        CqlQuantity d_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> o_ = SBPReading?.Component;
            bool? p_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept v_ = SBPComponent?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = this.Systolic_blood_pressure(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);

                return z_;
            };
            IEnumerable<Observation.ComponentComponent> q_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)o_, p_);
            CqlQuantity r_(Observation.ComponentComponent SBPComponent)
            {
                DataType aa_ = SBPComponent?.Value;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                return ab_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> s_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(q_, r_);
            IEnumerable<CqlQuantity> t_ = context.Operators.Distinct<CqlQuantity>(s_);
            CqlQuantity u_ = context.Operators.SingletonFrom<CqlQuantity>(t_);

            return u_;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        IEnumerable<CqlQuantity> g_ = context.Operators.ListSort<CqlQuantity>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity h_ = context.Operators.First<CqlQuantity>(g_);

        return h_;
    }

    [CqlDeclaration("Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context)
    {
        CqlQuantity a_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity b_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? c_ = context.Operators.Less(a_, b_);

        return c_;
    }

    [CqlDeclaration("Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        bool? b_(Observation DBPReading)
        {
            DataType i_ = DBPReading?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_2_1_000.Instance.latest(context, j_);
            CqlDate l_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            bool? n_ = context.Operators.SameAs(k_, m_, "day");

            return n_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        CqlQuantity d_(Observation DBPReading)
        {
            List<Observation.ComponentComponent> o_ = DBPReading?.Component;
            bool? p_(Observation.ComponentComponent DBPComponent)
            {
                CodeableConcept v_ = DBPComponent?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = this.Diastolic_blood_pressure(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);

                return z_;
            };
            IEnumerable<Observation.ComponentComponent> q_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)o_, p_);
            CqlQuantity r_(Observation.ComponentComponent DBPComponent)
            {
                DataType aa_ = DBPComponent?.Value;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                return ab_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> s_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(q_, r_);
            IEnumerable<CqlQuantity> t_ = context.Operators.Distinct<CqlQuantity>(s_);
            CqlQuantity u_ = context.Operators.SingletonFrom<CqlQuantity>(t_);

            return u_;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        IEnumerable<CqlQuantity> g_ = context.Operators.ListSort<CqlQuantity>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity h_ = context.Operators.First<CqlQuantity>(g_);

        return h_;
    }

    [CqlDeclaration("Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context)
    {
        CqlQuantity a_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity b_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? c_ = context.Operators.Less(a_, b_);

        return c_;
    }

    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? b_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? c_ = context.Operators.And(a_, b_);

        return c_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

}
