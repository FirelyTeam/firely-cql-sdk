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
[CqlLibrary("CMS128FHIRAntidepressantMgmt", "1.0.000")]
public partial class CMS128FHIRAntidepressantMgmt_1_0_000 : ILibrary, ISingleton<CMS128FHIRAntidepressantMgmt_1_0_000>
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
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -3336974086985530416L;

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
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -2851133471298809693L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("May 1 of the Year Prior to the Measurement Period")]
    public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_May_1_of_the_Year_Prior_to_the_Measurement_Period, May_1_of_the_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_May_1_of_the_Year_Prior_to_the_Measurement_Period = 2260567419969860535L;

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
        context.GetOrCompute(_cacheIndex_April_30_of_the_Measurement_Period, April_30_of_the_Measurement_Period_Compute);

    private const long _cacheIndex_April_30_of_the_Measurement_Period = 274231522783341163L;

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
        context.GetOrCompute(_cacheIndex_Intake_Period, Intake_Period_Compute);

    private const long _cacheIndex_Intake_Period = 5805669011297124889L;

    private CqlInterval<CqlDateTime> Intake_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
        CqlDateTime b_ = this.April_30_of_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        return c_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IPSD, IPSD_Compute);

    private const long _cacheIndex_IPSD = -1010214378857822330L;

    private CqlDate IPSD_Compute(CqlContext context)
    {
        IEnumerable<MedicationDispense> a_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        bool? b_(MedicationDispense MR) {
            IEnumerable<Medication> p_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? q_(Medication M) {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                // CQL 'and': right operand skipped when left is false
                if (w_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Antidepressant_Medication(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    return w_ & aa_;
                }
            }

            bool? r_ = context.Operators.WhereAny<Medication>(p_, q_);
            return r_;
        }

        IEnumerable<MedicationDispense> c_ = context.Operators.Where<MedicationDispense>(a_, b_);
        CqlValueSet d_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> e_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(c_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        bool? h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> ab_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate ac_ = context.Operators.Start(ab_);
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
            CqlInterval<CqlDateTime> ae_ = this.Intake_Period(context);
            bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, "day");
            return af_;
        }


        (CqlTupleMetadata, CqlDate AntidepressantDate)? i_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> ag_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate ah_ = context.Operators.Start(ag_);
            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            (CqlTupleMetadata, CqlDate AntidepressantDate)? ak_ = (CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL, aj_);
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> j_ = context.Operators.WhereSelect<MedicationDispense, (CqlTupleMetadata, CqlDate AntidepressantDate)?>(g_, h_, i_);
        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(j_);

        object l_((CqlTupleMetadata, CqlDate AntidepressantDate)? @this) {
            CqlDate al_ = @this?.AntidepressantDate;
            return al_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate AntidepressantDate)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate AntidepressantDate)? n_ = context.Operators.First<(CqlTupleMetadata, CqlDate AntidepressantDate)?>(m_);
        CqlDate o_ = n_?.AntidepressantDate;
        return o_;
    }


    [CqlExpressionDefinition("Has IPSD and Major Depression Diagnosis")]
    public bool? Has_IPSD_and_Major_Depression_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_IPSD_and_Major_Depression_Diagnosis, Has_IPSD_and_Major_Depression_Diagnosis_Compute);

    private const long _cacheIndex_Has_IPSD_and_Major_Depression_Diagnosis = 7846530698326160153L;

    private bool? Has_IPSD_and_Major_Depression_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Depression(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition MajorDepression) {
            CqlDate h_ = this.IPSD(context);
            bool? i_ = !((bool?)(h_ is null));
            // CQL 'and' (43:7-44:94): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MajorDepression);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDate l_ = context.Operators.DateFrom(k_);
                CqlDate m_ = this.IPSD(context);
                CqlQuantity n_ = context.Operators.Quantity(60m, "days");
                CqlDate o_ = context.Operators.Subtract(m_, n_);
                CqlDate p_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDate> q_ = context.Operators.Interval(o_, p_, true, true);
                bool? r_ = context.Operators.In<CqlDate>(l_, q_, (string)default);
                bool? s_;
                // CQL 'and' (44:13-44:94): right operand skipped when left is false
                if (r_ is false)
                {
                    s_ = false;
                }
                else
                {
                    CqlDate t_ = this.IPSD(context);
                    s_ = r_ & (!((bool?)(t_ is null)));
                }
                return i_ & s_;
            }
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -5099802547552683180L;

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
            CqlDate an_ = context.Operators.Add(ak_, al_);
            CqlInterval<CqlDate> ao_ = context.Operators.Interval(am_, an_, true, true);
            bool? ap_ = context.Operators.In<CqlDate>(aj_, ao_, (string)default);
            // CQL 'and' (74:5-74:75): right operand skipped when left is false
            if (ap_ is false)
            {
                return false;
            }
            else
            {
                CqlDate aq_ = this.IPSD(context);
                return ap_ & (!((bool?)(aq_ is null)));
            }
        }

        IEnumerable<Encounter> af_ = context.Operators.Where<Encounter>(ad_, ae_);
        return af_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -8837015647708587567L;

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
        bool? j_;
        // CQL 'and' (32:3-33:49): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            bool? k_ = this.Has_IPSD_and_Major_Depression_Diagnosis(context);
            j_ = i_ & k_;
        }
        // CQL 'and' (32:3-34:38): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> l_ = this.Qualifying_Encounters(context);
            bool? m_ = context.Operators.Exists<Encounter>(l_);
            return j_ & m_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 2673262951145358635L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -6056780603594220787L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        // CQL 'or' (80:3-84:5): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? c_(MedicationRequest MR) {
                IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? l_(Medication M) {
                    object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                    string q_ = context.Operators.Last<string>(p_);
                    bool? r_ = context.Operators.Equal(n_, q_);
                    // CQL 'and': right operand skipped when left is false
                    if (r_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept s_ = M?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        CqlValueSet u_ = this.Antidepressant_Medication(context);
                        bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                        return r_ & v_;
                    }
                }

                bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
                return m_;
            }

            IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
            CqlValueSet e_ = this.Antidepressant_Medication(context);
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(d_, f_);
            IEnumerable<MedicationRequest> h_ = Status_1_15_000.Instance.isMedicationActive(context, g_);

            bool? i_(MedicationRequest ActiveAntidepressant) {
                CqlDate w_ = this.IPSD(context);
                bool? x_ = !((bool?)(w_ is null));
                // CQL 'and' (82:9-83:137): right operand skipped when left is false
                if (x_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> y_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveAntidepressant);
                    CqlDate z_ = y_?.low;
                    CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                    CqlDate ab_ = y_?.high;
                    CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
                    bool? ad_ = y_?.lowClosed;
                    bool? ae_ = y_?.highClosed;
                    CqlInterval<CqlDateTime> af_ = context.Operators.Interval(aa_, ac_, ad_, ae_);
                    CqlInterval<CqlDate> ag_ = CQMCommon_4_1_000.Instance.ToDateInterval(context, af_);
                    CqlDate ah_ = this.IPSD(context);
                    CqlQuantity ai_ = context.Operators.Quantity(105m, "days");
                    CqlDate aj_ = context.Operators.Subtract(ah_, ai_);
                    CqlInterval<CqlDate> ak_ = context.Operators.Interval(aj_, ah_, true, false);
                    bool? al_ = context.Operators.Overlaps(ag_, ak_, (string)default);
                    return x_ & al_;
                }
            }

            bool? j_ = context.Operators.WhereAny<MedicationRequest>(h_, i_);
            return a_ | j_;
        }
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD, Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Compute);

    private const long _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD = -7118600492049709655L;

    private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Compute(CqlContext context)
    {
        IEnumerable<MedicationDispense> a_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        bool? b_(MedicationDispense MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                // CQL 'and': right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Antidepressant_Medication(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return q_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationDispense> c_ = context.Operators.Where<MedicationDispense>(a_, b_);
        CqlValueSet d_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> e_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(c_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        CqlInterval<CqlDate> h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> v_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate w_ = this.IPSD(context);
            CqlQuantity x_ = context.Operators.Quantity(114m, "days");
            CqlDate y_ = context.Operators.Add(w_, x_);
            CqlInterval<CqlDate> z_ = context.Operators.Interval(w_, y_, true, true);
            CqlInterval<CqlDate> aa_ = context.Operators.Intersect<CqlDate>(v_, z_);
            return aa_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.SelectDistinct<MedicationDispense, CqlInterval<CqlDate>>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days, Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Compute);

    private const long _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days = -2653868503490197179L;

    private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 84);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = 3518313745077296512L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
    public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD, Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Compute);

    private const long _cacheIndex_Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD = 42974837852135066L;

    private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Compute(CqlContext context)
    {
        IEnumerable<MedicationDispense> a_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));

        bool? b_(MedicationDispense MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                // CQL 'and': right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Antidepressant_Medication(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return q_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationDispense> c_ = context.Operators.Where<MedicationDispense>(a_, b_);
        CqlValueSet d_ = this.Antidepressant_Medication(context);
        IEnumerable<MedicationDispense> e_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationdispense"));
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(c_, e_);
        IEnumerable<MedicationDispense> g_ = Status_1_15_000.Instance.isMedicationDispensed(context, f_);

        CqlInterval<CqlDate> h_(MedicationDispense Antidepressant) {
            CqlInterval<CqlDate> v_ = CumulativeMedicationDuration_6_0_000.Instance.medicationDispensePeriod(context, Antidepressant);
            CqlDate w_ = this.IPSD(context);
            CqlQuantity x_ = context.Operators.Quantity(231m, "days");
            CqlDate y_ = context.Operators.Add(w_, x_);
            CqlInterval<CqlDate> z_ = context.Operators.Interval(w_, y_, true, true);
            CqlInterval<CqlDate> aa_ = context.Operators.Intersect<CqlDate>(v_, z_);
            return aa_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.SelectDistinct<MedicationDispense, CqlInterval<CqlDate>>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
    public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days, Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Compute);

    private const long _cacheIndex_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days = -1810768940264149742L;

    private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
        int? b_ = CumulativeMedicationDuration_6_0_000.Instance.cumulativeDuration(context, a_);
        bool? c_ = context.Operators.GreaterOrEqual(b_, 180);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = 949383832859615730L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3720173879420837916L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4996892276186901500L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6643813119908974830L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 4969765333250476527L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS128FHIRAntidepressantMgmt_1_0_000() {}

    public static CMS128FHIRAntidepressantMgmt_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS128FHIRAntidepressantMgmt";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
       [typeof(CqlDate)],
       ["AntidepressantDate"]);

    #endregion CqlTupleMetadata Properties

}
