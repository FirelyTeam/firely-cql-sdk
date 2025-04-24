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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("DepressionRemissionatTwelveMonthsFHIR", "0.2.000")]
public partial class DepressionRemissionatTwelveMonthsFHIR_0_2_000 : ILibrary, ISingleton<DepressionRemissionatTwelveMonthsFHIR_0_2_000>
{
    private DepressionRemissionatTwelveMonthsFHIR_0_2_000() {}

    public static DepressionRemissionatTwelveMonthsFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DepressionRemissionatTwelveMonthsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlValueSetDeclaration(
        declarationName: "Bipolar Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128")]
    public CqlValueSet Bipolar_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", default);


    [CqlValueSetDeclaration(
        declarationName: "Contact or Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5")]
    public CqlValueSet Contact_or_Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", default);


    [CqlValueSetDeclaration(
        declarationName: "Dysthymia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254")]
    public CqlValueSet Dysthymia(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", default);


    [CqlValueSetDeclaration(
        declarationName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlValueSetDeclaration(
        declarationName: "Hospice Care Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", default);


    [CqlValueSetDeclaration(
        declarationName: "Hospice Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165")]
    public CqlValueSet Hospice_Diagnosis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", default);


    [CqlValueSetDeclaration(
        declarationName: "Hospice Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003")]
    public CqlValueSet Hospice_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", default);


    [CqlValueSetDeclaration(
        declarationName: "Major Depression Including Remission",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444")]
    public CqlValueSet Major_Depression_Including_Remission(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", default);


    [CqlValueSetDeclaration(
        declarationName: "Palliative Care Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167")]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", default);


    [CqlValueSetDeclaration(
        declarationName: "Palliative Care Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", default);


    [CqlValueSetDeclaration(
        declarationName: "Palliative Care Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", default);


    [CqlValueSetDeclaration(
        declarationName: "Palliative or Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);


    [CqlValueSetDeclaration(
        declarationName: "Personality Disorder Emotionally Labile",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246")]
    public CqlValueSet Personality_Disorder_Emotionally_Labile(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", default);


    [CqlValueSetDeclaration(
        declarationName: "Pervasive Developmental Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152")]
    public CqlValueSet Pervasive_Developmental_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", default);


    [CqlValueSetDeclaration(
        declarationName: "PHQ 9 and PHQ 9M Tools",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263")]
    public CqlValueSet PHQ_9_and_PHQ_9M_Tools(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", default);


    [CqlValueSetDeclaration(
        declarationName: "Schizophrenia or Psychotic Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104")]
    public CqlValueSet Schizophrenia_or_Psychotic_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", default);


    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) =>
        new CqlCode("428371000124100", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) =>
        new CqlCode("428361000124107", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext context) =>
        new CqlCode("71007-9", "http://loinc.org", default, default);


    [CqlDeclaration("Hospice care [Minimum Data Set]")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) =>
        new CqlCode("45755-6", "http://loinc.org", default, default);


    [CqlDeclaration("Yes (qualifier value)")]
    public CqlCode Yes__qualifier_value_(CqlContext context) =>
        new CqlCode("373066001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("71007-9", "http://loinc.org", default, default),
            new CqlCode("45755-6", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("DepressionRemissionatTwelveMonthsFHIR-0.2.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Depression Assessments Greater than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_than_9(CqlContext context)
    {
        CqlValueSet a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation DepressionAssessment)
        {
            DataType e_ = DepressionAssessment?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Greater(f_ as int?, 9);
            Code<ObservationStatus> h_ = DepressionAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            Code<ObservationStatus> j_ = context.Operators.Convert<Code<ObservationStatus>>(i_);
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? m_ = context.Operators.In<string>(k_, l_ as IEnumerable<string>);
            bool? n_ = context.Operators.And(g_, m_);

            return n_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    // NOT A DEFINITION // 
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


    [CqlDeclaration("Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Dysthymia(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        bool? f_(Condition Depression)
        {
            bool? h_ = this.isConfirmedActiveDiagnosis(context, Depression);

            return h_;
        };
        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlQuantity c_ = context.Operators.Quantity(14m, "months");
        CqlDateTime d_ = context.Operators.Subtract(b_, c_);
        CqlDateTime f_ = context.Operators.Start(a_);
        CqlQuantity g_ = context.Operators.Quantity(2m, "months");
        CqlDateTime h_ = context.Operators.Subtract(f_, g_);
        CqlInterval<CqlDateTime> i_ = context.Operators.Interval(d_, h_, true, false);

        return i_;
    }


    [CqlDeclaration("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_(Encounter ValidEncounter)
        {
            IEnumerable<Condition> e_ = this.Depression_Diagnoses(context);
            bool? f_(Condition Depression)
            {
                Period j_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Depression);
                bool? m_ = context.Operators.Overlaps(k_, l_, default);
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Denominator_Identification_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, default);
                bool? s_ = context.Operators.And(m_, r_);
                Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? u_ = t_?.Value;
                Code<Encounter.EncounterStatus> v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(u_);
                bool? w_ = context.Operators.Equal(v_, "finished");
                bool? x_ = context.Operators.And(s_, w_);

                return x_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            Encounter h_(Condition Depression) =>
                ValidEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Depression_Assessments_Greater_than_9(context);
        IEnumerable<Observation> b_(Observation DepressionAssessment)
        {
            IEnumerable<Encounter> g_ = this.Depression_Encounter(context);
            bool? h_(Encounter DepressionEncounter)
            {
                Period l_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(7m, "days");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlDate q_ = context.Operators.ConvertDateTimeToDate(p_);
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, true);
                DataType w_ = DepressionAssessment?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
                bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(v_, y_, "day");

                return z_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter DepressionEncounter) =>
                DepressionAssessment;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

            return k_;
        };
        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
        object d_(Observation @this)
        {
            DataType aa_ = @this?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_1_000.Instance.toInterval(context, ab_);
            CqlDateTime ad_ = context.Operators.Start(ac_);

            return ad_;
        };
        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);

        return f_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        Observation e_ = this.Index_Depression_Assessment(context);
        DataType f_ = e_?.Effective;
        object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
        CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
        CqlDateTime i_ = context.Operators.Start(h_);
        int? j_ = context.Operators.CalculateAgeAt(d_, i_, "year");
        bool? k_ = context.Operators.GreaterOrEqual(j_, 12);

        return k_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context)
    {
        Observation a_ = this.Index_Depression_Assessment(context);
        Observation[] b_ = [
            a_,
        ];
        CqlInterval<CqlDate> c_(Observation FirstIndexAssessment)
        {
            DataType g_ = FirstIndexAssessment?.Effective;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.toInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlQuantity l_ = context.Operators.Quantity(12m, "months");
            CqlDate m_ = context.Operators.Add(k_, l_);
            CqlQuantity n_ = context.Operators.Quantity(60m, "days");
            CqlDate o_ = context.Operators.Subtract(m_, n_);
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            CqlDate v_ = context.Operators.Add(t_, l_);
            CqlDate x_ = context.Operators.Add(v_, n_);
            CqlInterval<CqlDate> y_ = context.Operators.Interval(o_, x_, true, true);

            return y_;
        };
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);
        CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);

        return f_;
    }


    [CqlDeclaration("Has Hospice Services in the Measure Assessment Period")]
    public bool? Has_Hospice_Services_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent ak_ = InpatientEncounter?.Hospitalization;
            CodeableConcept al_ = ak_?.DischargeDisposition;
            CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
            CqlCode an_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
            bool? ap_ = context.Operators.Equivalent(am_, ao_);
            CodeableConcept ar_ = ak_?.DischargeDisposition;
            CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_);
            CqlCode at_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
            bool? av_ = context.Operators.Equivalent(as_, au_);
            bool? aw_ = context.Operators.Or(ap_, av_);
            Period ax_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlInterval<CqlDateTime> ba_ = this.Denominator_Identification_Period(context);
            CqlDateTime bb_ = context.Operators.Start(ba_);
            CqlInterval<CqlDate> bc_ = this.Measure_Assessment_Period(context);
            CqlDate bd_ = context.Operators.End(bc_);
            CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
            CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bb_, be_, true, true);
            bool? bg_ = context.Operators.In<CqlDateTime>(az_, bf_, "day");
            bool? bh_ = context.Operators.And(aw_, bg_);
            Code<Encounter.EncounterStatus> bi_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bj_ = bi_?.Value;
            Code<Encounter.EncounterStatus> bk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bj_);
            bool? bl_ = context.Operators.Equal(bk_, "finished");
            bool? bm_ = context.Operators.And(bh_, bl_);

            return bm_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);
        CqlValueSet f_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? h_(Encounter HospiceEncounter)
        {
            Period bn_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
            CqlInterval<CqlDateTime> bp_ = this.Denominator_Identification_Period(context);
            CqlDateTime bq_ = context.Operators.Start(bp_);
            CqlInterval<CqlDate> br_ = this.Measure_Assessment_Period(context);
            CqlDate bs_ = context.Operators.End(br_);
            CqlDateTime bt_ = context.Operators.ConvertDateToDateTime(bs_);
            CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(bq_, bt_, true, true);
            bool? bv_ = context.Operators.Overlaps(bo_, bu_, "day");
            Code<Encounter.EncounterStatus> bw_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? bx_ = bw_?.Value;
            Code<Encounter.EncounterStatus> by_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bx_);
            string bz_ = context.Operators.Convert<string>(by_);
            string[] ca_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
            bool? cc_ = context.Operators.Not(cb_);
            bool? cd_ = context.Operators.And(bv_, cc_);

            return cd_;
        };
        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
        bool? j_ = context.Operators.Exists<Encounter>(i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlCode l_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? o_(Observation HospiceAssessment)
        {
            DataType ce_ = HospiceAssessment?.Value;
            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
            CqlCode cg_ = this.Yes__qualifier_value_(context);
            CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
            bool? ci_ = context.Operators.Equivalent(cf_ as CqlConcept, ch_);
            DataType cj_ = HospiceAssessment?.Effective;
            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
            CqlInterval<CqlDateTime> cl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ck_);
            CqlInterval<CqlDateTime> cm_ = this.Denominator_Identification_Period(context);
            CqlDateTime cn_ = context.Operators.Start(cm_);
            CqlInterval<CqlDate> co_ = this.Measure_Assessment_Period(context);
            CqlDate cp_ = context.Operators.End(co_);
            CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
            CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(cn_, cq_, true, true);
            bool? cs_ = context.Operators.Overlaps(cl_, cr_, "day");
            bool? ct_ = context.Operators.And(ci_, cs_);
            Code<ObservationStatus> cu_ = HospiceAssessment?.StatusElement;
            ObservationStatus? cv_ = cu_?.Value;
            Code<ObservationStatus> cw_ = context.Operators.Convert<Code<ObservationStatus>>(cv_);
            string cx_ = context.Operators.Convert<string>(cw_);
            string[] cy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cz_ = context.Operators.In<string>(cx_, cy_ as IEnumerable<string>);
            bool? da_ = context.Operators.And(ct_, cz_);

            return da_;
        };
        IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
        bool? q_ = context.Operators.Exists<Observation>(p_);
        bool? r_ = context.Operators.Or(k_, q_);
        CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? u_(ServiceRequest HospiceOrder)
        {
            FhirDateTime db_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime dc_ = context.Operators.Convert<CqlDateTime>(db_);
            CqlInterval<CqlDateTime> dd_ = this.Denominator_Identification_Period(context);
            CqlDateTime de_ = context.Operators.Start(dd_);
            CqlInterval<CqlDate> df_ = this.Measure_Assessment_Period(context);
            CqlDate dg_ = context.Operators.End(df_);
            CqlDateTime dh_ = context.Operators.ConvertDateToDateTime(dg_);
            CqlInterval<CqlDateTime> di_ = context.Operators.Interval(de_, dh_, true, true);
            bool? dj_ = context.Operators.In<CqlDateTime>(dc_, di_, "day");
            Code<RequestStatus> dk_ = HospiceOrder?.StatusElement;
            RequestStatus? dl_ = dk_?.Value;
            Code<RequestStatus> dm_ = context.Operators.Convert<Code<RequestStatus>>(dl_);
            string dn_ = context.Operators.Convert<string>(dm_);
            string[] do_ = [
                "active",
                "completed",
            ];
            bool? dp_ = context.Operators.In<string>(dn_, do_ as IEnumerable<string>);
            bool? dq_ = context.Operators.And(dj_, dp_);
            Code<RequestIntent> dr_ = HospiceOrder?.IntentElement;
            RequestIntent? ds_ = dr_?.Value;
            Code<RequestIntent> dt_ = context.Operators.Convert<Code<RequestIntent>>(ds_);
            string du_ = context.Operators.Convert<string>(dt_);
            string[] dv_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dw_ = context.Operators.In<string>(du_, dv_ as IEnumerable<string>);
            bool? dx_ = context.Operators.And(dq_, dw_);
            FhirBoolean dy_ = HospiceOrder?.DoNotPerformElement;
            bool? dz_ = dy_?.Value;
            bool? ea_ = context.Operators.IsTrue(dz_);
            bool? eb_ = context.Operators.Not(ea_);
            bool? ec_ = context.Operators.And(dx_, eb_);

            return ec_;
        };
        IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
        bool? w_ = context.Operators.Exists<ServiceRequest>(v_);
        bool? x_ = context.Operators.Or(r_, w_);
        IEnumerable<Procedure> z_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? aa_(Procedure HospicePerformed)
        {
            DataType ed_ = HospicePerformed?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            CqlInterval<CqlDateTime> ef_ = QICoreCommon_2_1_000.Instance.toInterval(context, ee_);
            CqlInterval<CqlDateTime> eg_ = this.Denominator_Identification_Period(context);
            CqlDateTime eh_ = context.Operators.Start(eg_);
            CqlInterval<CqlDate> ei_ = this.Measure_Assessment_Period(context);
            CqlDate ej_ = context.Operators.End(ei_);
            CqlDateTime ek_ = context.Operators.ConvertDateToDateTime(ej_);
            CqlInterval<CqlDateTime> el_ = context.Operators.Interval(eh_, ek_, true, true);
            bool? em_ = context.Operators.Overlaps(ef_, el_, "day");
            Code<EventStatus> en_ = HospicePerformed?.StatusElement;
            EventStatus? eo_ = en_?.Value;
            string ep_ = context.Operators.Convert<string>(eo_);
            string[] eq_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? er_ = context.Operators.In<string>(ep_, eq_ as IEnumerable<string>);
            bool? es_ = context.Operators.Not(er_);
            bool? et_ = context.Operators.And(em_, es_);

            return et_;
        };
        IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Procedure>(ab_);
        bool? ad_ = context.Operators.Or(x_, ac_);
        CqlValueSet ae_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ag_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> eu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> ev_ = this.Denominator_Identification_Period(context);
            CqlDateTime ew_ = context.Operators.Start(ev_);
            CqlInterval<CqlDate> ex_ = this.Measure_Assessment_Period(context);
            CqlDate ey_ = context.Operators.End(ex_);
            CqlDateTime ez_ = context.Operators.ConvertDateToDateTime(ey_);
            CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ew_, ez_, true, true);
            bool? fb_ = context.Operators.Overlaps(eu_, fa_, "day");
            bool? fc_ = this.isConfirmedActiveDiagnosis(context, HospiceCareDiagnosis);
            bool? fd_ = context.Operators.And(fb_, fc_);

            return fd_;
        };
        IEnumerable<Condition> ah_ = context.Operators.Where<Condition>(af_, ag_);
        bool? ai_ = context.Operators.Exists<Condition>(ah_);
        bool? aj_ = context.Operators.Or(ad_, ai_);

        return aj_;
    }


    [CqlDeclaration("Has Palliative Care in the Measure Assessment Period")]
    public bool? Has_Palliative_Care_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation PalliativeAssessment)
        {
            DataType y_ = PalliativeAssessment?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            CqlInterval<CqlDateTime> ab_ = this.Denominator_Identification_Period(context);
            CqlDateTime ac_ = context.Operators.Start(ab_);
            CqlInterval<CqlDate> ad_ = this.Measure_Assessment_Period(context);
            CqlDate ae_ = context.Operators.End(ad_);
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ac_, af_, true, true);
            bool? ah_ = context.Operators.Overlaps(aa_, ag_, default);
            Code<ObservationStatus> ai_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? aj_ = ai_?.Value;
            Code<ObservationStatus> ak_ = context.Operators.Convert<Code<ObservationStatus>>(aj_);
            string al_ = context.Operators.Convert<string>(ak_);
            string[] am_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? an_ = context.Operators.In<string>(al_, am_ as IEnumerable<string>);
            bool? ao_ = context.Operators.And(ah_, an_);

            return ao_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        CqlValueSet g_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? i_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> aq_ = this.Denominator_Identification_Period(context);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlInterval<CqlDate> as_ = this.Measure_Assessment_Period(context);
            CqlDate at_ = context.Operators.End(as_);
            CqlDateTime au_ = context.Operators.ConvertDateToDateTime(at_);
            CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ar_, au_, true, true);
            bool? aw_ = context.Operators.Overlaps(ap_, av_, default);
            bool? ax_ = this.isConfirmedActiveDiagnosis(context, PalliativeDiagnosis);
            bool? ay_ = context.Operators.And(aw_, ax_);

            return ay_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        bool? k_ = context.Operators.Exists<Condition>(j_);
        bool? l_ = context.Operators.Or(f_, k_);
        CqlValueSet m_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? o_(Encounter PalliativeEncounter)
        {
            Period az_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
            CqlInterval<CqlDateTime> bb_ = this.Denominator_Identification_Period(context);
            CqlDateTime bc_ = context.Operators.Start(bb_);
            CqlInterval<CqlDate> bd_ = this.Measure_Assessment_Period(context);
            CqlDate be_ = context.Operators.End(bd_);
            CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
            CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bc_, bf_, true, true);
            bool? bh_ = context.Operators.Overlaps(ba_, bg_, default);
            Code<Encounter.EncounterStatus> bi_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? bj_ = bi_?.Value;
            Code<Encounter.EncounterStatus> bk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bj_);
            bool? bl_ = context.Operators.Equal(bk_, "finished");
            bool? bm_ = context.Operators.And(bh_, bl_);

            return bm_;
        };
        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        bool? q_ = context.Operators.Exists<Encounter>(p_);
        bool? r_ = context.Operators.Or(l_, q_);
        CqlValueSet s_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? u_(Procedure PalliativeIntervention)
        {
            DataType bn_ = PalliativeIntervention?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bo_);
            CqlInterval<CqlDateTime> bq_ = this.Denominator_Identification_Period(context);
            CqlDateTime br_ = context.Operators.Start(bq_);
            CqlInterval<CqlDate> bs_ = this.Measure_Assessment_Period(context);
            CqlDate bt_ = context.Operators.End(bs_);
            CqlDateTime bu_ = context.Operators.ConvertDateToDateTime(bt_);
            CqlInterval<CqlDateTime> bv_ = context.Operators.Interval(br_, bu_, true, true);
            bool? bw_ = context.Operators.Overlaps(bp_, bv_, default);
            Code<EventStatus> bx_ = PalliativeIntervention?.StatusElement;
            EventStatus? by_ = bx_?.Value;
            string bz_ = context.Operators.Convert<string>(by_);
            string[] ca_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
            bool? cc_ = context.Operators.Not(cb_);
            bool? cd_ = context.Operators.And(bw_, cc_);

            return cd_;
        };
        IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>(t_, u_);
        bool? w_ = context.Operators.Exists<Procedure>(v_);
        bool? x_ = context.Operators.Or(r_, w_);

        return x_;
    }


    [CqlDeclaration("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        DataType b_ = a_?.Deceased;
        object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlInterval<CqlDate> d_ = this.Measure_Assessment_Period(context);
        CqlDate e_ = context.Operators.End(d_);
        CqlDateTime f_ = context.Operators.ConvertDateToDateTime(e_);
        bool? g_ = context.Operators.SameOrBefore(c_ as CqlDateTime, f_, default);

        return g_;
    }


    [CqlDeclaration("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context)
    {
        CqlValueSet a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet h_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
        bool? l_(Condition MentalHealthDisorderDiagnoses)
        {
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.ConvertDateTimeToDate(p_);
            CqlInterval<CqlDate> r_ = this.Measure_Assessment_Period(context);
            CqlDate s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, default);
            bool? u_ = this.isConfirmedActiveDiagnosis(context, MentalHealthDisorderDiagnoses);
            bool? v_ = context.Operators.And(t_, u_);

            return v_;
        };
        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        bool? n_ = context.Operators.Exists<Condition>(m_);

        return n_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = this.Has_Hospice_Services_in_the_Measure_Assessment_Period(context);
        bool? b_ = this.Has_Palliative_Care_in_the_Measure_Assessment_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Patient_Expired(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation DepressionAssessment)
        {
            DataType k_ = DepressionAssessment?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.ConvertDateTimeToDate(n_);
            CqlInterval<CqlDate> p_ = this.Measure_Assessment_Period(context);
            bool? q_ = context.Operators.In<CqlDate>(o_, p_, default);
            Code<ObservationStatus> r_ = DepressionAssessment?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            Code<ObservationStatus> t_ = context.Operators.Convert<Code<ObservationStatus>>(s_);
            string u_ = context.Operators.Convert<string>(t_);
            string[] v_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? w_ = context.Operators.In<string>(u_, v_ as IEnumerable<string>);
            bool? x_ = context.Operators.And(q_, w_);

            return x_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);

            return ab_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        bool? j_ = context.Operators.Less(i_ as int?, 5);

        return j_;
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


    #endregion Definition Methods

}
