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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS128FHIRAntidepressantMgmt", "1.0.000")]
public partial class CMS128FHIRAntidepressantMgmt_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS128FHIRAntidepressantMgmt_1_0_000>
{
    #region ValueSets (12)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Antidepressant Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", valueSetVersion: null)]
    public CqlValueSet Antidepressant_Medication(CqlContext _) => _Antidepressant_Medication;
    private static readonly CqlValueSet _Antidepressant_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Major Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", valueSetVersion: null)]
    public CqlValueSet Major_Depression(CqlContext _) => _Major_Depression;
    private static readonly CqlValueSet _Major_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS128FHIRAntidepressantMgmt-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (20)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_May_1_of_the_Year_Prior_to_the_Measurement_Period, May_1_of_the_Year_Prior_to_the_Measurement_Period_Compute, context) ?? May_1_of_the_Year_Prior_to_the_Measurement_Period_Compute(context);

    private CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 5, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("April 30 of the Measurement Period")]
    public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_April_30_of_the_Measurement_Period, April_30_of_the_Measurement_Period_Compute, context) ?? April_30_of_the_Measurement_Period_Compute(context);

    private CqlDateTime April_30_of_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime e_ = context.Operators.DateTime(c_, 4, 30, 23, 59, 59, 0, d_);
        return e_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Intake_Period, Intake_Period_Compute, context) ?? Intake_Period_Compute(context);

    private CqlInterval<CqlDateTime> Intake_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime b_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        return c_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_IPSD, IPSD_Compute, context) ?? IPSD_Compute(context);

    private CqlDate IPSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> c_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        IEnumerable<MedicationDispense> d_(MedicationDispense MR) {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? r_(Medication M) {
                object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(v_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Antidepressant_Medication(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
            }

            IEnumerable<Medication> s_ = context.Operators.Where<Medication>(q_, r_);
            MedicationDispense t_(Medication M) => MR;
            IEnumerable<MedicationDispense> u_ = context.Operators.Select<Medication, MedicationDispense>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationDispense> e_ = context.Operators.SelectMany<MedicationDispense, MedicationDispense>(c_, d_);
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(b_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        bool? h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> af_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate ag_ = context.Operators.Start(af_);
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            CqlInterval<CqlDateTime> ai_ = this.Intake_Period(context);
            bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, "day");
            return aj_;
        }

        IEnumerable<MedicationDispense> i_ = context.Operators.Where<MedicationDispense>(g_, h_);

        (CqlTupleMetadata, CqlDate AntidepressantDate)? j_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> ak_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate al_ = context.Operators.Start(ak_);
            CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? ao_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, an_);
            return ao_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> k_ = context.Operators.Select<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(i_, j_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(k_);

        object m_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this) {
            CqlDate ap_ = @this?.AntidepressantDate;
            return ap_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> n_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? o_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(n_);
        CqlDate p_ = o_?.AntidepressantDate;
        return p_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_IPSD_and_Major_Depression_Diagnosis, Has_IPSD_and_Major_Depression_Diagnosis_Compute, context) ?? Has_IPSD_and_Major_Depression_Diagnosis_Compute(context);

    private bool? Has_IPSD_and_Major_Depression_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Depression(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(object MajorDepression) {
            CqlDate j_ = this.IPSD(context);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MajorDepression);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity p_ = context.Operators.Quantity(60m, "days");
            CqlDate q_ = context.Operators.Subtract(j_, p_);
            CqlDate t_ = context.Operators.Add(j_, p_);
            CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDate>(n_, u_, default);
            bool? x_ = context.Operators.Not((bool?)(j_ is null));
            bool? y_ = context.Operators.And(v_, x_);
            bool? z_ = context.Operators.And(k_, y_);
            return z_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
        bool? i_ = context.Operators.Exists<object>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute, context) ?? Qualifying_Encounters_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        IEnumerable<Encounter> ad_ = Status_1_15_000.Instance.isEncounterPerformed(context, ac_);

        bool? ae_(Encounter ValidEncounter) {
            Period ag_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            CqlDate ak_ = this.IPSD(context);
            CqlQuantity al_ = context.Operators.Quantity(60m, "days");
            CqlDate am_ = context.Operators.Subtract(ak_, al_);
            CqlDate ap_ = context.Operators.Add(ak_, al_);
            CqlInterval<CqlDate> aq_ = context.Operators.Interval(am_, ap_, true, true);
            bool? ar_ = context.Operators.In<CqlDate>(aj_, aq_, default);
            bool? at_ = context.Operators.Not((bool?)(ak_ is null));
            bool? au_ = context.Operators.And(ar_, at_);
            return au_;
        }

        IEnumerable<Encounter> af_ = context.Operators.Where<Encounter>(ad_, ae_);
        return af_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDate e_ = this.IPSD(context);
        CqlDateTime f_ = context.Operators.ConvertDateToDateTime(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
        bool? j_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
        bool? k_ = context.Operators.And(i_, j_);
        IEnumerable<Encounter> l_ = this.Qualifying_Encounters(context);
        bool? m_ = context.Operators.Exists<Encounter>(l_);
        bool? n_ = context.Operators.And(k_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        CqlValueSet b_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> e_(MedicationRequest MR) {
            IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? n_(Medication M) {
                object r_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object s_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> t_ = context.Operators.Split((string)s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(r_, u_);
                CodeableConcept w_ = M?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Antidepressant_Medication(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
            MedicationRequest p_(Medication M) => MR;
            IEnumerable<MedicationRequest> q_ = context.Operators.Select<Medication, MedicationRequest>(o_, p_);
            return q_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(d_, e_);
        IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(c_, f_);
        IEnumerable<MedicationRequest> h_ = Status_1_15_000.Instance.isMedicationActive(context, g_);

        bool? i_(MedicationRequest ActiveAntidepressant) {
            CqlDate ab_ = this.IPSD(context);
            bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
            CqlInterval<CqlDate> ad_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
            CqlDate ae_ = ad_?.low;
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
            CqlDate ah_ = ad_?.high;
            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
            bool? ak_ = ad_?.lowClosed;
            bool? am_ = ad_?.highClosed;
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(af_, ai_, ak_, am_);
            CqlInterval<CqlDate> ao_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, an_);
            CqlQuantity aq_ = context.Operators.Quantity(105m, "days");
            CqlDate ar_ = context.Operators.Subtract(ab_, aq_);
            CqlInterval<CqlDate> at_ = context.Operators.Interval(ar_, ab_, true, false);
            bool? au_ = context.Operators.Overlaps(ao_, at_, default);
            bool? av_ = context.Operators.And(ac_, au_);
            return av_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        bool? k_ = context.Operators.Exists<MedicationRequest>(j_);
        bool? l_ = context.Operators.Or(a_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD, Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Compute, context) ?? Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Compute(context);

    private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> c_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        IEnumerable<MedicationDispense> d_(MedicationDispense MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Antidepressant_Medication(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            MedicationDispense n_(Medication M) => MR;
            IEnumerable<MedicationDispense> o_ = context.Operators.Select<Medication, MedicationDispense>(m_, n_);
            return o_;
        }

        IEnumerable<MedicationDispense> e_ = context.Operators.SelectMany<MedicationDispense, MedicationDispense>(c_, d_);
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(b_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        CqlInterval<CqlDate> h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> z_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate aa_ = this.IPSD(context);
            CqlQuantity ac_ = context.Operators.Quantity(114m, "days");
            CqlDate ad_ = context.Operators.Add(aa_, ac_);
            CqlInterval<CqlDate> ae_ = context.Operators.Interval(aa_, ad_, true, true);
            CqlInterval<CqlDate> af_ = context.Operators.Intersect<CqlDate>(z_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days, Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Compute, context) ?? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Compute(context);

    private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 84);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute, context) ?? Numerator_1_Compute(context);

    private bool? Numerator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD, Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Compute, context) ?? Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Compute(context);

    private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> c_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        IEnumerable<MedicationDispense> d_(MedicationDispense MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Antidepressant_Medication(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            MedicationDispense n_(Medication M) => MR;
            IEnumerable<MedicationDispense> o_ = context.Operators.Select<Medication, MedicationDispense>(m_, n_);
            return o_;
        }

        IEnumerable<MedicationDispense> e_ = context.Operators.SelectMany<MedicationDispense, MedicationDispense>(c_, d_);
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(b_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        CqlInterval<CqlDate> h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> z_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate aa_ = this.IPSD(context);
            CqlQuantity ac_ = context.Operators.Quantity(231m, "days");
            CqlDate ad_ = context.Operators.Add(aa_, ac_);
            CqlInterval<CqlDate> ae_ = context.Operators.Interval(aa_, ad_, true, true);
            CqlInterval<CqlDate> af_ = context.Operators.Intersect<CqlDate>(z_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days, Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Compute, context) ?? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Compute(context);

    private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 180);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute, context) ?? Numerator_2_Compute(context);

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (21)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_May_1_of_the_Year_Prior_to_the_Measurement_Period = -1;
    private int _cacheIndex_April_30_of_the_Measurement_Period = -1;
    private int _cacheIndex_Intake_Period = -1;
    private int _cacheIndex_IPSD = -1;
    private int _cacheIndex_Has_IPSD_and_Major_Depression_Diagnosis = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD = -1;
    private int _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days = -1;
    private int _cacheIndex_Numerator_1 = -1;
    private int _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD = -1;
    private int _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days = -1;
    private int _cacheIndex_Numerator_2 = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_May_1_of_the_Year_Prior_to_the_Measurement_Period = index++;
        _cacheIndex_April_30_of_the_Measurement_Period = index++;
        _cacheIndex_Intake_Period = index++;
        _cacheIndex_IPSD = index++;
        _cacheIndex_Has_IPSD_and_Major_Depression_Diagnosis = index++;
        _cacheIndex_Qualifying_Encounters = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD = index++;
        _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days = index++;
        _cacheIndex_Numerator_1 = index++;
        _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD = index++;
        _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days = index++;
        _cacheIndex_Numerator_2 = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS128FHIRAntidepressantMgmt_1_0_000() {}

    public static CMS128FHIRAntidepressantMgmt_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS128FHIRAntidepressantMgmt";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (1)

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
       [typeof(CqlDate)],
       ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
