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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.1.000")]
public partial class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000>
{
    private HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000() {}

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance];
    #endregion Library Members

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);


    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Glucose Lab Test Mass Per Volume")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34")]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", default);


    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
    public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", default);


    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date(CqlContext context) => 
        new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter InpatientEncounter)
        {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
            bool? t_ = context.Operators.And(n_, s_);
            Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);

            return y_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? b_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> d_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? e_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, d_);

            return e_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet f_ = this.Diabetes(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? h_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> n_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(m_, o_, default);

                return p_;
            };
            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? j_(Condition Diabetes) => 
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> k_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter q_ = Hospitalization?.encounter;

            return q_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet b_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> g_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(a_, f_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? h_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? n_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> i_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(g_, h_);
        bool? j_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> o_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? p_ = o_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> q_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? t_ = o_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> u_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(t_);
            bool? v_ = context.Operators.Equal(u_, "not-done");
            bool? w_ = context.Operators.Not(v_);
            bool? x_ = context.Operators.And(r_, w_);
            CqlInterval<CqlDateTime> y_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType z_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_1_000.Instance.ToInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, ab_, default);
            bool? ad_ = context.Operators.And(x_, ac_);

            return ad_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> k_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(i_, j_);
        Encounter l_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter ae_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return ae_;
        };
        IEnumerable<Encounter> m_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(k_, l_);

        return m_;
    }


    [CqlDeclaration("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet f_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? h_(Observation GlucoseTest)
            {
                object l_()
                {
                    bool ah_()
                    {
                        DataType ak_ = GlucoseTest?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;

                        return am_;
                    };
                    bool ai_()
                    {
                        DataType an_ = GlucoseTest?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;

                        return ap_;
                    };
                    bool aj_()
                    {
                        DataType aq_ = GlucoseTest?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlDateTime;

                        return as_;
                    };
                    if (ah_())
                    {
                        DataType at_ = GlucoseTest?.Effective;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                        return (au_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        DataType av_ = GlucoseTest?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                        return (aw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        DataType ax_ = GlucoseTest?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                        return (ay_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime m_ = QICoreCommon_2_1_000.Instance.Earliest(context, l_());
                CqlInterval<CqlDateTime> n_ = Hospitalization?.hospitalizationPeriod;
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
                Code<ObservationStatus> p_ = GlucoseTest?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
                bool? v_ = context.Operators.And(o_, u_);
                ObservationStatus? x_ = p_?.Value;
                Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
                bool? z_ = context.Operators.Equal(y_, "cancelled");
                bool? aa_ = context.Operators.Not(z_);
                bool? ab_ = context.Operators.And(v_, aa_);
                DataType ac_ = GlucoseTest?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlQuantity ae_ = context.Operators.Quantity(200m, "mg/dL");
                bool? af_ = context.Operators.GreaterOrEqual(ad_ as CqlQuantity, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);

                return ag_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? j_(Observation GlucoseTest) => 
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> k_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter az_ = Hospitalization?.encounter;

            return az_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        return a_;
    }

    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        CqlQuantity d_ = context.Operators.Quantity(10m, "days");
        CqlDateTime e_ = context.Operators.Add(a_, d_);
        CqlDateTime[] f_ = [
            b_,
            e_,
        ];
        CqlDateTime g_ = context.Operators.Min<CqlDateTime>(f_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> h_ = context.Operators.Interval(a_, g_, true, true);

        return h_;
    }

    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
        int? g_(CqlInterval<int?> DayExpand)
        {
            int? i_ = context.Operators.End(DayExpand);

            return i_;
        };
        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

        return h_;
    }

    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayNumber)
        {
            CqlDateTime d_ = context.Operators.Start(Period);
            CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
            int? f_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
            CqlQuantity h_ = context.Operators.Multiply(e_, g_);
            CqlDateTime i_ = context.Operators.Add(d_, h_);
            CqlDateTime j_()
            {
                bool m_()
                {
                    CqlDateTime n_ = context.Operators.Start(Period);
                    CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
                    int? p_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
                    CqlQuantity r_ = context.Operators.Multiply(o_, q_);
                    CqlDateTime s_ = context.Operators.Add(n_, r_);
                    CqlDateTime t_ = context.Operators.End(Period);
                    int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
                    bool? v_ = context.Operators.Less(u_, 24);

                    return v_ ?? false;
                };
                if (m_())
                {
                    CqlDateTime w_ = context.Operators.Start(Period);
                    CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
                    int? y_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
                    CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
                    CqlDateTime ab_ = context.Operators.Add(w_, aa_);

                    return ab_;
                }
                else
                {
                    CqlDateTime ac_ = context.Operators.Start(Period);
                    CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
                    CqlDateTime ag_ = context.Operators.Add(ac_, af_);

                    return ag_;
                }
            };
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? l_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, k_);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? b_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> d_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> f_ = this.Hospital_Days_Max_10(context, d_);
            CqlInterval<CqlDateTime> h_ = this.Hospital_Days_Max_10(context, d_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> i_ = this.Days_In_Period(context, h_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? j_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, d_, f_, i_);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> a_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter d_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> e_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> f_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? g_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? j_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> k_ = EncounterDay?.dayPeriod;
                CqlValueSet l_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> m_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? n_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> ac_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    Code<ObservationStatus> ae_ = context.Operators.Convert<Code<ObservationStatus>>(ad_);
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, ag_ as IEnumerable<string>);
                    ObservationStatus? aj_ = ac_?.Value;
                    Code<ObservationStatus> ak_ = context.Operators.Convert<Code<ObservationStatus>>(aj_);
                    bool? al_ = context.Operators.Equal(ak_, "cancelled");
                    bool? am_ = context.Operators.Not(al_);
                    bool? an_ = context.Operators.And(ah_, am_);
                    DataType ao_ = GlucoseTest?.Value;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    CqlQuantity aq_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? ar_ = context.Operators.Greater(ap_ as CqlQuantity, aq_);
                    bool? as_ = context.Operators.And(an_, ar_);
                    object at_()
                    {
                        bool ay_()
                        {
                            DataType bb_ = GlucoseTest?.Effective;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlDateTime;

                            return bd_;
                        };
                        bool az_()
                        {
                            DataType be_ = GlucoseTest?.Effective;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlInterval<CqlDateTime>;

                            return bg_;
                        };
                        bool ba_()
                        {
                            DataType bh_ = GlucoseTest?.Effective;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlDateTime;

                            return bj_;
                        };
                        if (ay_())
                        {
                            DataType bk_ = GlucoseTest?.Effective;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);

                            return (bl_ as CqlDateTime) as object;
                        }
                        else if (az_())
                        {
                            DataType bm_ = GlucoseTest?.Effective;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);

                            return (bn_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ba_())
                        {
                            DataType bo_ = GlucoseTest?.Effective;
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);

                            return (bp_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime au_ = QICoreCommon_2_1_000.Instance.Earliest(context, at_());
                    CqlInterval<CqlDateTime> av_ = EncounterDay?.dayPeriod;
                    bool? aw_ = context.Operators.In<CqlDateTime>(au_, av_, default);
                    bool? ax_ = context.Operators.And(as_, aw_);

                    return ax_;
                };
                IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
                bool? p_ = context.Operators.Exists<Observation>(o_);
                IEnumerable<Observation> r_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? s_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> bq_ = GlucoseTest?.StatusElement;
                    ObservationStatus? br_ = bq_?.Value;
                    Code<ObservationStatus> bs_ = context.Operators.Convert<Code<ObservationStatus>>(br_);
                    string bt_ = context.Operators.Convert<string>(bs_);
                    string[] bu_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bv_ = context.Operators.In<string>(bt_, bu_ as IEnumerable<string>);
                    ObservationStatus? bx_ = bq_?.Value;
                    Code<ObservationStatus> by_ = context.Operators.Convert<Code<ObservationStatus>>(bx_);
                    bool? bz_ = context.Operators.Equal(by_, "cancelled");
                    bool? ca_ = context.Operators.Not(bz_);
                    bool? cb_ = context.Operators.And(bv_, ca_);
                    DataType cc_ = GlucoseTest?.Value;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    CqlQuantity ce_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? cf_ = context.Operators.GreaterOrEqual(cd_ as CqlQuantity, ce_);
                    bool? cg_ = context.Operators.And(cb_, cf_);
                    object ch_()
                    {
                        bool cm_()
                        {
                            DataType cp_ = GlucoseTest?.Effective;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlDateTime;

                            return cr_;
                        };
                        bool cn_()
                        {
                            DataType cs_ = GlucoseTest?.Effective;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlInterval<CqlDateTime>;

                            return cu_;
                        };
                        bool co_()
                        {
                            DataType cv_ = GlucoseTest?.Effective;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlDateTime;

                            return cx_;
                        };
                        if (cm_())
                        {
                            DataType cy_ = GlucoseTest?.Effective;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);

                            return (cz_ as CqlDateTime) as object;
                        }
                        else if (cn_())
                        {
                            DataType da_ = GlucoseTest?.Effective;
                            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);

                            return (db_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (co_())
                        {
                            DataType dc_ = GlucoseTest?.Effective;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);

                            return (dd_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime ci_ = QICoreCommon_2_1_000.Instance.Earliest(context, ch_());
                    CqlInterval<CqlDateTime> cj_ = EncounterDay?.dayPeriod;
                    bool? ck_ = context.Operators.In<CqlDateTime>(ci_, cj_, default);
                    bool? cl_ = context.Operators.And(cg_, ck_);

                    return cl_;
                };
                IEnumerable<Observation> t_ = context.Operators.Where<Observation>(r_, s_);
                bool? u_ = context.Operators.Exists<Observation>(t_);
                IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? x_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> de_ = GlucoseTest?.StatusElement;
                    ObservationStatus? df_ = de_?.Value;
                    Code<ObservationStatus> dg_ = context.Operators.Convert<Code<ObservationStatus>>(df_);
                    string dh_ = context.Operators.Convert<string>(dg_);
                    string[] di_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? dj_ = context.Operators.In<string>(dh_, di_ as IEnumerable<string>);
                    ObservationStatus? dl_ = de_?.Value;
                    Code<ObservationStatus> dm_ = context.Operators.Convert<Code<ObservationStatus>>(dl_);
                    bool? dn_ = context.Operators.Equal(dm_, "cancelled");
                    bool? do_ = context.Operators.Not(dn_);
                    bool? dp_ = context.Operators.And(dj_, do_);
                    object dq_()
                    {
                        bool dv_()
                        {
                            DataType dy_ = GlucoseTest?.Effective;
                            object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                            bool ea_ = dz_ is CqlDateTime;

                            return ea_;
                        };
                        bool dw_()
                        {
                            DataType eb_ = GlucoseTest?.Effective;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            bool ed_ = ec_ is CqlInterval<CqlDateTime>;

                            return ed_;
                        };
                        bool dx_()
                        {
                            DataType ee_ = GlucoseTest?.Effective;
                            object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                            bool eg_ = ef_ is CqlDateTime;

                            return eg_;
                        };
                        if (dv_())
                        {
                            DataType eh_ = GlucoseTest?.Effective;
                            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);

                            return (ei_ as CqlDateTime) as object;
                        }
                        else if (dw_())
                        {
                            DataType ej_ = GlucoseTest?.Effective;
                            object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);

                            return (ek_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (dx_())
                        {
                            DataType el_ = GlucoseTest?.Effective;
                            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);

                            return (em_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime dr_ = QICoreCommon_2_1_000.Instance.Earliest(context, dq_());
                    CqlInterval<CqlDateTime> ds_ = EncounterDay?.dayPeriod;
                    bool? dt_ = context.Operators.In<CqlDateTime>(dr_, ds_, default);
                    bool? du_ = context.Operators.And(dp_, dt_);

                    return du_;
                };
                IEnumerable<Observation> y_ = context.Operators.Where<Observation>(w_, x_);
                bool? z_ = context.Operators.Exists<Observation>(y_);
                bool? aa_ = context.Operators.Not(z_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ab_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, j_, k_, p_, u_, aa_);

                return ab_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> h_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(f_, g_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? i_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, d_, e_, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> a_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter d_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> e_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> f_ = EncounterWithResultDays?.relevantDays;
            bool? g_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? l_ = EncounterDay?.dayNumber;
                bool? m_ = context.Operators.Greater(l_, 1);

                return m_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(f_, g_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? i_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? n_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> o_ = EncounterDay?.dayPeriod;
                bool? p_ = EncounterDay?.hasSevereResult;
                bool? q_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> r_ = EncounterWithResultDays?.relevantDays;
                int? t_ = context.Operators.Subtract(n_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? u_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(r_, t_);
                bool? v_ = u_?.hasElevatedResult;
                bool? w_ = context.Operators.And(q_, v_);
                int? z_ = context.Operators.Subtract(n_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? aa_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(r_, z_);
                bool? ab_ = aa_?.hasElevatedResult;
                bool? ac_ = context.Operators.And(w_, ab_);
                bool? ad_ = context.Operators.Or(p_, ac_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? ae_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, n_, o_, ad_);

                return ae_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> j_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(h_, i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? k_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, d_, e_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? k_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType l_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlQuantity n_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? o_ = context.Operators.GreaterOrEqual(m_ as CqlQuantity, n_);
            Code<ObservationStatus> p_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
            bool? v_ = context.Operators.And(o_, u_);
            object w_()
            {
                bool aj_()
                {
                    DataType am_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;

                    return ao_;
                };
                bool ak_()
                {
                    DataType ap_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlInterval<CqlDateTime>;

                    return ar_;
                };
                bool al_()
                {
                    DataType as_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;

                    return au_;
                };
                if (aj_())
                {
                    DataType av_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                    return (aw_ as CqlDateTime) as object;
                }
                else if (ak_())
                {
                    DataType ax_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                    return (ay_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (al_())
                {
                    DataType az_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                    return (ba_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime x_ = QICoreCommon_2_1_000.Instance.Earliest(context, w_());
            CqlInterval<CqlDateTime> y_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ad_ = context.Operators.Start(y_);
            CqlQuantity ae_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime af_ = context.Operators.Add(ad_, ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(x_, ag_, default);
            bool? ai_ = context.Operators.And(v_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(f_, g_);
        Observation i_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) => 
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(h_, i_);

        return j_;
    }


    [CqlDeclaration("Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        IEnumerable<Observation> b_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? f_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? l_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object m_()
            {
                bool aq_()
                {
                    DataType at_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;

                    return av_;
                };
                bool ar_()
                {
                    DataType aw_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;

                    return ay_;
                };
                bool as_()
                {
                    DataType az_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlDateTime;

                    return bb_;
                };
                if (aq_())
                {
                    DataType bc_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                    return (bd_ as CqlDateTime) as object;
                }
                else if (ar_())
                {
                    DataType be_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                    return (bf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (as_())
                {
                    DataType bg_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);

                    return (bh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime n_ = QICoreCommon_2_1_000.Instance.Earliest(context, m_());
            CqlInterval<CqlDateTime> o_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime t_ = context.Operators.Start(o_);
            CqlQuantity u_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime v_ = context.Operators.Add(t_, u_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(r_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
            object y_()
            {
                bool bi_()
                {
                    DataType bl_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlDateTime;

                    return bn_;
                };
                bool bj_()
                {
                    DataType bo_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlDateTime>;

                    return bq_;
                };
                bool bk_()
                {
                    DataType br_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlDateTime;

                    return bt_;
                };
                if (bi_())
                {
                    DataType bu_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);

                    return (bv_ as CqlDateTime) as object;
                }
                else if (bj_())
                {
                    DataType bw_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);

                    return (bx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bk_())
                {
                    DataType by_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);

                    return (bz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.Earliest(context, y_());
            CqlDateTime ab_ = context.Operators.Start(o_);
            CqlDateTime ad_ = context.Operators.Subtract(ab_, q_);
            object ae_()
            {
                bool ca_()
                {
                    DataType cd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;

                    return cf_;
                };
                bool cb_()
                {
                    DataType cg_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlDateTime>;

                    return ci_;
                };
                bool cc_()
                {
                    DataType cj_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;

                    return cl_;
                };
                if (ca_())
                {
                    DataType cm_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                    return (cn_ as CqlDateTime) as object;
                }
                else if (cb_())
                {
                    DataType co_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                    return (cp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cc_())
                {
                    DataType cq_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);

                    return (cr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime af_ = QICoreCommon_2_1_000.Instance.Earliest(context, ae_());
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, false);
            bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, default);
            bool? ai_ = context.Operators.And(x_, ah_);
            Id aj_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string ak_ = aj_?.Value;
            Id al_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string am_ = al_?.Value;
            bool? an_ = context.Operators.Equivalent(ak_, am_);
            bool? ao_ = context.Operators.Not(an_);
            bool? ap_ = context.Operators.And(ai_, ao_);

            return ap_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) => 
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(i_, j_);

        return k_;
    }


    [CqlDeclaration("Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? b_(Observation GlucoseResult1000)
        {
            Id d_ = GlucoseResult1000?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? g_(Observation @this)
            {
                string m_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? n_ = context.Operators.Not((bool?)(m_ is null));

                return n_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            string i_(Observation @this)
            {
                string o_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return o_;
            };
            IEnumerable<string> j_ = context.Operators.Select<Observation, string>(h_, i_);
            bool? k_ = context.Operators.In<string>(e_, j_);
            bool? l_ = context.Operators.Not(k_);

            return l_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> d_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? e_(Observation FirstGlucoseResult)
            {
                DataType i_ = FirstGlucoseResult?.Value;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlQuantity k_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? l_ = context.Operators.GreaterOrEqual(j_ as CqlQuantity, k_);
                object m_()
                {
                    bool z_()
                    {
                        DataType ac_ = FirstGlucoseResult?.Effective;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlDateTime;

                        return ae_;
                    };
                    bool aa_()
                    {
                        DataType af_ = FirstGlucoseResult?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlDateTime>;

                        return ah_;
                    };
                    bool ab_()
                    {
                        DataType ai_ = FirstGlucoseResult?.Effective;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;

                        return ak_;
                    };
                    if (z_())
                    {
                        DataType al_ = FirstGlucoseResult?.Effective;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                        return (am_ as CqlDateTime) as object;
                    }
                    else if (aa_())
                    {
                        DataType an_ = FirstGlucoseResult?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                        return (ao_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ab_())
                    {
                        DataType ap_ = FirstGlucoseResult?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);

                        return (aq_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime n_ = QICoreCommon_2_1_000.Instance.Earliest(context, m_());
                CqlInterval<CqlDateTime> o_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                CqlDateTime t_ = context.Operators.Start(o_);
                CqlQuantity u_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(r_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
                bool? y_ = context.Operators.And(l_, x_);

                return y_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation FirstGlucoseResult) => 
                InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return a_;
    }


    [CqlDeclaration("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Days_with_Hyperglycemic_Events(context);
        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> f_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? g_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? j_ = EligibleEventDay?.hasHyperglycemicEvent;

                return j_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> h_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(f_, g_);
            bool? i_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter k_ = HyperglycemicEventDays?.encounter;

            return k_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Hyperglycemic_Events(context);

        return a_;
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

    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_()
        {
            bool b_()
            {
                string c_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> d_ = this.Denominator_Exclusions(context);
                bool? e_(Encounter @this)
                {
                    string j_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));

                    return k_;
                };
                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                string g_(Encounter @this)
                {
                    string l_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return l_;
                };
                IEnumerable<string> h_ = context.Operators.Select<Encounter, string>(f_, g_);
                bool? i_ = context.Operators.In<string>(c_, h_);

                return i_ ?? false;
            };
            if (b_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> m_ = this.Days_with_Hyperglycemic_Events(context);
                bool? n_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter s_ = EncounterWithEventDays?.encounter;
                    bool? t_ = context.Operators.Equal(s_, QualifyingEncounter);

                    return t_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(m_, n_);
                int? p_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 
                    0;
                IEnumerable<int?> q_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(o_, p_);
                int? r_ = context.Operators.SingletonFrom<int?>(q_);

                return r_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> u_ = this.Days_with_Hyperglycemic_Events(context);
                bool? v_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter aa_ = EncounterWithEventDays?.encounter;
                    bool? ab_ = context.Operators.Equal(aa_, QualifyingEncounter);

                    return ab_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> w_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(u_, v_);
                int? x_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ac_ = EncounterWithEventDays?.eligibleEventDays;
                    int? ad_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ac_);

                    return ad_;
                };
                IEnumerable<int?> y_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(w_, x_);
                int? z_ = context.Operators.SingletonFrom<int?>(y_);

                return z_;
            }
        };

        return a_();
    }

    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_()
        {
            bool b_()
            {
                string c_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> d_ = this.Denominator_Exclusions(context);
                bool? e_(Encounter @this)
                {
                    string j_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));

                    return k_;
                };
                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                string g_(Encounter @this)
                {
                    string l_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return l_;
                };
                IEnumerable<string> h_ = context.Operators.Select<Encounter, string>(f_, g_);
                bool? i_ = context.Operators.In<string>(c_, h_);

                return i_ ?? false;
            };
            if (b_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> m_ = this.Days_with_Hyperglycemic_Events(context);
                bool? n_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter s_ = EncounterWithEventDays?.encounter;
                    bool? t_ = context.Operators.Equal(s_, QualifyingEncounter);

                    return t_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(m_, n_);
                int? p_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 
                    0;
                IEnumerable<int?> q_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(o_, p_);
                int? r_ = context.Operators.SingletonFrom<int?>(q_);

                return r_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> u_ = this.Days_with_Hyperglycemic_Events(context);
                bool? v_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter aa_ = EncounterWithEventDays?.encounter;
                    bool? ab_ = context.Operators.Equal(aa_, QualifyingEncounter);

                    return ab_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> w_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(u_, v_);
                int? x_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ac_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? ad_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? ag_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return ag_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ae_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ac_, ad_);
                    int? af_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ae_);

                    return af_;
                };
                IEnumerable<int?> y_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(w_, x_);
                int? z_ = context.Operators.SingletonFrom<int?>(y_);

                return z_;
            }
        };

        return a_();
    }

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayNumber", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
        [typeof(Encounter), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseResult1000", "EarlierGlucoseTest"]);

}
