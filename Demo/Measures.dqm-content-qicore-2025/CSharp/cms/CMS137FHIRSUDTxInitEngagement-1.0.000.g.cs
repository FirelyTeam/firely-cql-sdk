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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS137FHIRSUDTxInitEngagement", "1.0.000")]
public partial class CMS137FHIRSUDTxInitEngagement_1_0_000 : ILibrary, ISingleton<CMS137FHIRSUDTxInitEngagement_1_0_000>
{
    #region ValueSets (15)

    [CqlValueSetDefinition("Detoxification Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059", valueSetVersion: null)]
    public CqlValueSet Detoxification_Visit(CqlContext _) => _Detoxification_Visit;
    private static readonly CqlValueSet _Detoxification_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059", null);

    [CqlValueSetDefinition("Discharge Services Hospital Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Hospital_Inpatient(CqlContext _) => _Discharge_Services_Hospital_Inpatient;
    private static readonly CqlValueSet _Discharge_Services_Hospital_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007", null);

    [CqlValueSetDefinition("Discharge Services Hospital Inpatient Same Day Discharge", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Hospital_Inpatient_Same_Day_Discharge(CqlContext _) => _Discharge_Services_Hospital_Inpatient_Same_Day_Discharge;
    private static readonly CqlValueSet _Discharge_Services_Hospital_Inpatient_Same_Day_Discharge = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Initial Hospital Inpatient Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004", valueSetVersion: null)]
    public CqlValueSet Initial_Hospital_Inpatient_Visit(CqlContext _) => _Initial_Hospital_Inpatient_Visit;
    private static readonly CqlValueSet _Initial_Hospital_Inpatient_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Substance Use Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder(CqlContext _) => _Substance_Use_Disorder;
    private static readonly CqlValueSet _Substance_Use_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001", null);

    [CqlValueSetDefinition("Substance Use Disorder Long Acting Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication(CqlContext _) => _Substance_Use_Disorder_Long_Acting_Medication;
    private static readonly CqlValueSet _Substance_Use_Disorder_Long_Acting_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149", null);

    [CqlValueSetDefinition("Substance Use Disorder Long Acting Medication Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication_Administration(CqlContext _) => _Substance_Use_Disorder_Long_Acting_Medication_Administration;
    private static readonly CqlValueSet _Substance_Use_Disorder_Long_Acting_Medication_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156", null);

    [CqlValueSetDefinition("Substance Use Disorder Short Acting Medication", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication(CqlContext _) => _Substance_Use_Disorder_Short_Acting_Medication;
    private static readonly CqlValueSet _Substance_Use_Disorder_Short_Acting_Medication = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150", null);

    [CqlValueSetDefinition("Substance Use Disorder Short Acting Medication Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication_Administration(CqlContext _) => _Substance_Use_Disorder_Short_Acting_Medication_Administration;
    private static readonly CqlValueSet _Substance_Use_Disorder_Short_Acting_Medication_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157", null);

    [CqlValueSetDefinition("Substance Use Disorder Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005", valueSetVersion: null)]
    public CqlValueSet Substance_Use_Disorder_Treatment(CqlContext _) => _Substance_Use_Disorder_Treatment;
    private static readonly CqlValueSet _Substance_Use_Disorder_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005", null);

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

    private const long _cacheIndex_Measurement_Period = -213861832508738093L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS137FHIRSUDTxInitEngagement-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1721097001566011548L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 3378695002201602210L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Detoxification_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Initial_Hospital_Inpatient_Visit(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Discharge_Services_Hospital_Inpatient_Same_Day_Discharge(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Discharge_Services_Hospital_Inpatient(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        IEnumerable<Encounter> x_ = Status_1_15_000.Instance.isEncounterPerformed(context, w_);
        return x_;
    }


    [CqlExpressionDefinition("First SUD Episode During Measurement Period")]
    public Encounter First_SUD_Episode_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_SUD_Episode_During_Measurement_Period, First_SUD_Episode_During_Measurement_Period_Compute);

    private const long _cacheIndex_First_SUD_Episode_During_Measurement_Period = 586250289999529460L;

    private Encounter First_SUD_Episode_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        IEnumerable<Encounter> b_(Encounter ValidEncounters) {
            CqlValueSet k_ = this.Substance_Use_Disorder(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            Condition m_(Condition X) => X as Condition;
            IEnumerable<Condition> n_ = context.Operators.Select<Condition, Condition>(l_, m_);
            IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

            bool? p_(Condition SUDDiagnosis) {
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                Period u_ = ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, (string)default);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                bool? ab_ = context.Operators.In<CqlDateTime>(y_, aa_, (string)default);
                bool? ac_ = context.Operators.And(w_, ab_);
                CqlDateTime ae_ = context.Operators.Start(x_);
                CqlDateTime ag_ = context.Operators.End(t_);
                CqlQuantity ah_ = context.Operators.Quantity(47m, "days");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                bool? aj_ = context.Operators.SameOrBefore(ae_, ai_, "day");
                bool? ak_ = context.Operators.And(ac_, aj_);
                return ak_;
            }

            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            Encounter r_(Condition SUDDiagnosis) => ValidEncounters;
            IEnumerable<Encounter> s_ = context.Operators.Select<Condition, Encounter>(q_, r_);
            return s_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? d_(Encounter ValidEncounters) {
            Period al_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? ap_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, ao_, ValidEncounters);
            return ap_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Select<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(e_);

        object g_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate aq_ = @this?.ValidEncounterDate;
            return aq_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? i_ = context.Operators.First<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(h_);
        Encounter j_ = i_?.ValidEncounter;
        return j_;
    }


    [CqlExpressionDefinition("Emergency Department or Detoxification Visit")]
    public IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Emergency_Department_or_Detoxification_Visit, Emergency_Department_or_Detoxification_Visit_Compute);

    private const long _cacheIndex_Emergency_Department_or_Detoxification_Visit = 5050409531052435535L;

    private IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Detoxification_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = Status_1_15_000.Instance.isEncounterPerformed(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("History of SUD Diagnosis or Treatment")]
    public IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_History_of_SUD_Diagnosis_or_Treatment, History_of_SUD_Diagnosis_or_Treatment_Compute);

    private const long _cacheIndex_History_of_SUD_Diagnosis_or_Treatment = 1577389953795855491L;

    private IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        CqlValueSet f_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet h_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = context.Operators.Union<Procedure>(g_, i_);
        IEnumerable<Procedure> k_ = context.Operators.Union<Procedure>(e_, j_);
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isInterventionPerformed(context, k_);

        IEnumerable<Procedure> m_(Procedure Interventions) {
            Encounter an_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ao_ = [
                an_,
            ];

            bool? ap_(Encounter FirstSUDEpisode) {

                object at_() {

                    bool dc_() {
                        DataType dg_ = Interventions?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlDateTime;
                        return di_;
                    }


                    bool dd_() {
                        DataType dj_ = Interventions?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                        return dl_;
                    }


                    bool de_() {
                        DataType dm_ = Interventions?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bool do_ = dn_ is CqlQuantity;
                        return do_;
                    }


                    bool df_() {
                        DataType dp_ = Interventions?.Performed;
                        object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                        bool dr_ = dq_ is CqlInterval<CqlQuantity>;
                        return dr_;
                    }

                    if (dc_())
                    {
                        DataType ds_ = Interventions?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        return (dt_ as CqlDateTime) as object;
                    }
                    else if (dd_())
                    {
                        DataType du_ = Interventions?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        return (dv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (de_())
                    {
                        DataType dw_ = Interventions?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        return (dx_ as CqlQuantity) as object;
                    }
                    else if (df_())
                    {
                        DataType dy_ = Interventions?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        return (dz_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_());
                CqlDateTime av_ = context.Operators.Start(au_);
                Period aw_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                CqlDate az_ = context.Operators.DateFrom(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(60m, "days");
                CqlDate bb_ = context.Operators.Subtract(az_, ba_);
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(bb_, bf_, true, false);
                CqlDate bh_ = bg_?.low;
                CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDate bm_ = context.Operators.DateFrom(bl_);
                CqlDate bo_ = context.Operators.Subtract(bm_, ba_);
                CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                CqlInterval<CqlDate> bt_ = context.Operators.Interval(bo_, bs_, true, false);
                CqlDate bu_ = bt_?.high;
                CqlDateTime bv_ = context.Operators.ConvertDateToDateTime(bu_);
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                CqlDate bz_ = context.Operators.DateFrom(by_);
                CqlDate cb_ = context.Operators.Subtract(bz_, ba_);
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                CqlInterval<CqlDate> cg_ = context.Operators.Interval(cb_, cf_, true, false);
                bool? ch_ = cg_?.lowClosed;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime ck_ = context.Operators.Start(cj_);
                CqlDate cl_ = context.Operators.DateFrom(ck_);
                CqlDate cn_ = context.Operators.Subtract(cl_, ba_);
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                CqlDate cr_ = context.Operators.DateFrom(cq_);
                CqlInterval<CqlDate> cs_ = context.Operators.Interval(cn_, cr_, true, false);
                bool? ct_ = cs_?.highClosed;
                CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(bi_, bv_, ch_, ct_);
                bool? cv_ = context.Operators.In<CqlDateTime>(av_, cu_, "day");
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime cy_ = context.Operators.Start(cx_);
                CqlDate cz_ = context.Operators.DateFrom(cy_);
                bool? da_ = context.Operators.Not((bool?)(cz_ is null));
                bool? db_ = context.Operators.And(cv_, da_);
                return db_;
            }

            IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ao_, ap_);
            Procedure ar_(Encounter FirstSUDEpisode) => Interventions;
            IEnumerable<Procedure> as_ = context.Operators.Select<Encounter, Procedure>(aq_, ar_);
            return as_;
        }

        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> ea_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? eb_(Condition @this) {
                CodeableConcept eh_ = @this?.Code;
                CqlConcept ei_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eh_);
                bool? ej_ = context.Operators.Not((bool?)(ei_ is null));
                return ej_;
            }

            IEnumerable<Condition> ec_ = context.Operators.Where<Condition>(ea_, eb_);

            CqlConcept ed_(Condition @this) {
                CodeableConcept ek_ = @this?.Code;
                CqlConcept el_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ek_);
                return el_;
            }

            IEnumerable<CqlConcept> ee_ = context.Operators.Select<Condition, CqlConcept>(ec_, ed_);
            CqlValueSet ef_ = this.Substance_Use_Disorder(context);
            bool? eg_ = context.Operators.ConceptsInValueSet(ee_, ef_);
            return eg_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        IEnumerable<Encounter> t_(Encounter SUDEncounterDx) {
            Encounter em_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] en_ = [
                em_,
            ];

            bool? eo_(Encounter FirstSUDEpisode) {
                Period es_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                CqlDateTime eu_ = context.Operators.Start(et_);
                Period ev_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime ex_ = context.Operators.Start(ew_);
                CqlDate ey_ = context.Operators.DateFrom(ex_);
                CqlQuantity ez_ = context.Operators.Quantity(60m, "days");
                CqlDate fa_ = context.Operators.Subtract(ey_, ez_);
                CqlInterval<CqlDateTime> fc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime fd_ = context.Operators.Start(fc_);
                CqlDate fe_ = context.Operators.DateFrom(fd_);
                CqlInterval<CqlDate> ff_ = context.Operators.Interval(fa_, fe_, true, false);
                CqlDate fg_ = ff_?.low;
                CqlDateTime fh_ = context.Operators.ConvertDateToDateTime(fg_);
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime fk_ = context.Operators.Start(fj_);
                CqlDate fl_ = context.Operators.DateFrom(fk_);
                CqlDate fn_ = context.Operators.Subtract(fl_, ez_);
                CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime fq_ = context.Operators.Start(fp_);
                CqlDate fr_ = context.Operators.DateFrom(fq_);
                CqlInterval<CqlDate> fs_ = context.Operators.Interval(fn_, fr_, true, false);
                CqlDate ft_ = fs_?.high;
                CqlDateTime fu_ = context.Operators.ConvertDateToDateTime(ft_);
                CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime fx_ = context.Operators.Start(fw_);
                CqlDate fy_ = context.Operators.DateFrom(fx_);
                CqlDate ga_ = context.Operators.Subtract(fy_, ez_);
                CqlInterval<CqlDateTime> gc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime gd_ = context.Operators.Start(gc_);
                CqlDate ge_ = context.Operators.DateFrom(gd_);
                CqlInterval<CqlDate> gf_ = context.Operators.Interval(ga_, ge_, true, false);
                bool? gg_ = gf_?.lowClosed;
                CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime gj_ = context.Operators.Start(gi_);
                CqlDate gk_ = context.Operators.DateFrom(gj_);
                CqlDate gm_ = context.Operators.Subtract(gk_, ez_);
                CqlInterval<CqlDateTime> go_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime gp_ = context.Operators.Start(go_);
                CqlDate gq_ = context.Operators.DateFrom(gp_);
                CqlInterval<CqlDate> gr_ = context.Operators.Interval(gm_, gq_, true, false);
                bool? gs_ = gr_?.highClosed;
                CqlInterval<CqlDateTime> gt_ = context.Operators.Interval(fh_, fu_, gg_, gs_);
                bool? gu_ = context.Operators.In<CqlDateTime>(eu_, gt_, "day");
                CqlInterval<CqlDateTime> gw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                CqlDateTime gx_ = context.Operators.Start(gw_);
                CqlDate gy_ = context.Operators.DateFrom(gx_);
                bool? gz_ = context.Operators.Not((bool?)(gy_ is null));
                bool? ha_ = context.Operators.And(gu_, gz_);
                return ha_;
            }

            IEnumerable<Encounter> ep_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)en_, eo_);
            Encounter eq_(Encounter FirstSUDEpisode) => SUDEncounterDx;
            IEnumerable<Encounter> er_ = context.Operators.Select<Encounter, Encounter>(ep_, eq_);
            return er_;
        }

        IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        CqlValueSet w_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> z_(MedicationRequest MR) {
            IEnumerable<Medication> hb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hc_(Medication M) {
                object hg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hi_ = context.Operators.Split((string)hh_, "/");
                string hj_ = context.Operators.Last<string>(hi_);
                bool? hk_ = context.Operators.Equal(hg_, hj_);
                CodeableConcept hl_ = M?.Code;
                CqlConcept hm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hl_);
                CqlValueSet hn_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ho_ = context.Operators.ConceptInValueSet(hm_, hn_);
                bool? hp_ = context.Operators.And(hk_, ho_);
                return hp_;
            }

            IEnumerable<Medication> hd_ = context.Operators.Where<Medication>(hb_, hc_);
            MedicationRequest he_(Medication M) => MR;
            IEnumerable<MedicationRequest> hf_ = context.Operators.Select<Medication, MedicationRequest>(hd_, he_);
            return hf_;
        }

        IEnumerable<MedicationRequest> aa_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(y_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        CqlValueSet ac_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> af_(MedicationRequest MR) {
            IEnumerable<Medication> hq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hr_(Medication M) {
                object hv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hx_ = context.Operators.Split((string)hw_, "/");
                string hy_ = context.Operators.Last<string>(hx_);
                bool? hz_ = context.Operators.Equal(hv_, hy_);
                CodeableConcept ia_ = M?.Code;
                CqlConcept ib_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ia_);
                CqlValueSet ic_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? id_ = context.Operators.ConceptInValueSet(ib_, ic_);
                bool? ie_ = context.Operators.And(hz_, id_);
                return ie_;
            }

            IEnumerable<Medication> hs_ = context.Operators.Where<Medication>(hq_, hr_);
            MedicationRequest ht_(Medication M) => MR;
            IEnumerable<MedicationRequest> hu_ = context.Operators.Select<Medication, MedicationRequest>(hs_, ht_);
            return hu_;
        }

        IEnumerable<MedicationRequest> ag_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(y_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ad_, ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(ab_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        IEnumerable<MedicationRequest> ak_(MedicationRequest SUDMedication) {
            Encounter if_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ig_ = [
                if_,
            ];

            bool? ih_(Encounter FirstSUDEpisode) {
                FhirDateTime il_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime im_ = context.Operators.Convert<CqlDateTime>(il_);
                Period in_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime ip_ = context.Operators.Start(io_);
                CqlDate iq_ = context.Operators.DateFrom(ip_);
                CqlQuantity ir_ = context.Operators.Quantity(60m, "days");
                CqlDate is_ = context.Operators.Subtract(iq_, ir_);
                CqlInterval<CqlDateTime> iu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime iv_ = context.Operators.Start(iu_);
                CqlDate iw_ = context.Operators.DateFrom(iv_);
                CqlInterval<CqlDate> ix_ = context.Operators.Interval(is_, iw_, true, false);
                CqlDate iy_ = ix_?.low;
                CqlDateTime iz_ = context.Operators.ConvertDateToDateTime(iy_);
                CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime jc_ = context.Operators.Start(jb_);
                CqlDate jd_ = context.Operators.DateFrom(jc_);
                CqlDate jf_ = context.Operators.Subtract(jd_, ir_);
                CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime ji_ = context.Operators.Start(jh_);
                CqlDate jj_ = context.Operators.DateFrom(ji_);
                CqlInterval<CqlDate> jk_ = context.Operators.Interval(jf_, jj_, true, false);
                CqlDate jl_ = jk_?.high;
                CqlDateTime jm_ = context.Operators.ConvertDateToDateTime(jl_);
                CqlInterval<CqlDateTime> jo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime jp_ = context.Operators.Start(jo_);
                CqlDate jq_ = context.Operators.DateFrom(jp_);
                CqlDate js_ = context.Operators.Subtract(jq_, ir_);
                CqlInterval<CqlDateTime> ju_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime jv_ = context.Operators.Start(ju_);
                CqlDate jw_ = context.Operators.DateFrom(jv_);
                CqlInterval<CqlDate> jx_ = context.Operators.Interval(js_, jw_, true, false);
                bool? jy_ = jx_?.lowClosed;
                CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime kb_ = context.Operators.Start(ka_);
                CqlDate kc_ = context.Operators.DateFrom(kb_);
                CqlDate ke_ = context.Operators.Subtract(kc_, ir_);
                CqlInterval<CqlDateTime> kg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime kh_ = context.Operators.Start(kg_);
                CqlDate ki_ = context.Operators.DateFrom(kh_);
                CqlInterval<CqlDate> kj_ = context.Operators.Interval(ke_, ki_, true, false);
                bool? kk_ = kj_?.highClosed;
                CqlInterval<CqlDateTime> kl_ = context.Operators.Interval(iz_, jm_, jy_, kk_);
                bool? km_ = context.Operators.In<CqlDateTime>(im_, kl_, "day");
                CqlInterval<CqlDateTime> ko_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                CqlDateTime kp_ = context.Operators.Start(ko_);
                CqlDate kq_ = context.Operators.DateFrom(kp_);
                bool? kr_ = context.Operators.Not((bool?)(kq_ is null));
                bool? ks_ = context.Operators.And(km_, kr_);
                return ks_;
            }

            IEnumerable<Encounter> ii_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ig_, ih_);
            MedicationRequest ij_(Encounter FirstSUDEpisode) => SUDMedication;
            IEnumerable<MedicationRequest> ik_ = context.Operators.Select<Encounter, MedicationRequest>(ii_, ij_);
            return ik_;
        }

        IEnumerable<MedicationRequest> al_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(aj_, ak_);
        IEnumerable<object> am_ = context.Operators.Union<object>(v_ as IEnumerable<object>, al_ as IEnumerable<object>);
        return am_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7114531631954589718L;

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
        bool? i_ = context.Operators.GreaterOrEqual(h_, 13);
        Encounter j_ = this.First_SUD_Episode_During_Measurement_Period(context);
        bool? k_ = context.Operators.Not((bool?)(j_ is null));
        bool? l_ = context.Operators.And(i_, k_);
        IEnumerable<object> m_ = this.History_of_SUD_Diagnosis_or_Treatment(context);
        bool? n_ = context.Operators.Exists<object>(m_);
        bool? o_ = context.Operators.Not(n_);
        bool? p_ = context.Operators.And(l_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -9046258412847076761L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2195821761694915090L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_;
    }


    [CqlExpressionDefinition("Psychosocial Visit")]
    public IEnumerable<object> Psychosocial_Visit(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Psychosocial_Visit, Psychosocial_Visit_Compute);

    private const long _cacheIndex_Psychosocial_Visit = 5229788767688913214L;

    private IEnumerable<object> Psychosocial_Visit_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        IEnumerable<Procedure> f_ = Status_1_15_000.Instance.isInterventionPerformed(context, e_);
        CqlValueSet g_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet i_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);

        bool? m_(Encounter TelehealthEncounter) {
            IEnumerable<Condition> p_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, TelehealthEncounter);

            bool? q_(Condition @this) {
                CodeableConcept w_ = @this?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                return y_;
            }

            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);

            CqlConcept s_(Condition @this) {
                CodeableConcept z_ = @this?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                return aa_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<Condition, CqlConcept>(r_, s_);
            CqlValueSet u_ = this.Substance_Use_Disorder(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
            return v_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(f_ as IEnumerable<object>, n_ as IEnumerable<object>);
        return o_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Non Medication Intervention Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_Initiation_With_Non_Medication_Intervention_Dates, Treatment_Initiation_With_Non_Medication_Intervention_Dates_Compute);

    private const long _cacheIndex_Treatment_Initiation_With_Non_Medication_Intervention_Dates = -3291394688854868864L;

    private IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);

        IEnumerable<object> b_(object PsychosocialVisitProcedure) {
            Encounter l_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] m_ = [
                l_,
            ];

            bool? n_(Encounter FirstSUDEpisode) {

                object r_() {

                    bool ao_() {
                        object as_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ap_() {
                        object av_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }


                    bool aq_() {
                        object ay_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlQuantity;
                        return ba_;
                    }


                    bool ar_() {
                        object bb_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                        return bd_;
                    }

                    if (ao_())
                    {
                        object be_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        return (bf_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        object bg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        return (bh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        object bi_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return (bj_ as CqlQuantity) as object;
                    }
                    else if (ar_())
                    {
                        object bk_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        return (bl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlDate u_ = context.Operators.DateFrom(t_);
                Period v_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlDate y_ = context.Operators.DateFrom(x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlDate ac_ = context.Operators.DateFrom(ab_);
                CqlQuantity ad_ = context.Operators.Quantity(14m, "days");
                CqlDate ae_ = context.Operators.Add(ac_, ad_);
                CqlInterval<CqlDate> af_ = context.Operators.Interval(y_, ae_, true, false);
                bool? ag_ = context.Operators.In<CqlDate>(u_, af_, (string)default);
                object ah_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                string ai_ = context.Operators.LateBoundProperty<string>(ah_, "value");
                Id aj_ = FirstSUDEpisode?.IdElement;
                string ak_ = aj_?.Value;
                bool? al_ = context.Operators.Equivalent(ai_, ak_);
                bool? am_ = context.Operators.Not(al_);
                bool? an_ = context.Operators.And(ag_, am_);
                return an_;
            }

            IEnumerable<Encounter> o_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)m_, n_);
            object p_(Encounter FirstSUDEpisode) => PsychosocialVisitProcedure;
            IEnumerable<object> q_ = context.Operators.Select<Encounter, object>(o_, p_);
            return q_;
        }

        IEnumerable<object> c_ = context.Operators.SelectMany<object, object>(a_, b_);

        CqlDate d_(object PsychosocialVisitProcedure) {

            object bm_() {

                bool bq_() {
                    object bu_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlDateTime;
                    return bw_;
                }


                bool br_() {
                    object bx_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlInterval<CqlDateTime>;
                    return bz_;
                }


                bool bs_() {
                    object ca_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlQuantity;
                    return cc_;
                }


                bool bt_() {
                    object cd_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlInterval<CqlQuantity>;
                    return cf_;
                }

                if (bq_())
                {
                    object cg_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    return (ch_ as CqlDateTime) as object;
                }
                else if (br_())
                {
                    object ci_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return (cj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bs_())
                {
                    object ck_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return (cl_ as CqlQuantity) as object;
                }
                else if (bt_())
                {
                    object cm_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    return (cn_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_());
            CqlDateTime bo_ = context.Operators.Start(bn_);
            CqlDate bp_ = context.Operators.DateFrom(bo_);
            return bp_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Select<object, CqlDate>(c_, d_);

        IEnumerable<object> g_(object PsychosocialVisitEncounter) {
            Encounter co_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] cp_ = [
                co_,
            ];

            bool? cq_(Encounter FirstSUDEpisode) {
                object cu_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_ as Period);
                CqlDateTime cw_ = context.Operators.Start(cv_);
                CqlDate cx_ = context.Operators.DateFrom(cw_);
                Period cy_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                CqlDate db_ = context.Operators.DateFrom(da_);
                CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                CqlDateTime de_ = context.Operators.Start(dd_);
                CqlDate df_ = context.Operators.DateFrom(de_);
                CqlQuantity dg_ = context.Operators.Quantity(14m, "days");
                CqlDate dh_ = context.Operators.Add(df_, dg_);
                CqlInterval<CqlDate> di_ = context.Operators.Interval(db_, dh_, true, false);
                bool? dj_ = context.Operators.In<CqlDate>(cx_, di_, (string)default);
                object dk_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string dl_ = context.Operators.LateBoundProperty<string>(dk_, "value");
                Id dm_ = FirstSUDEpisode?.IdElement;
                string dn_ = dm_?.Value;
                bool? do_ = context.Operators.Equivalent(dl_, dn_);
                bool? dp_ = context.Operators.Not(do_);
                bool? dq_ = context.Operators.And(dj_, dp_);
                return dq_;
            }

            IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)cp_, cq_);
            object cs_(Encounter FirstSUDEpisode) => PsychosocialVisitEncounter;
            IEnumerable<object> ct_ = context.Operators.Select<Encounter, object>(cr_, cs_);
            return ct_;
        }

        IEnumerable<object> h_ = context.Operators.SelectMany<object, object>(a_, g_);

        CqlDate i_(object PsychosocialVisitEncounter) {
            object dr_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_ as Period);
            CqlDateTime dt_ = context.Operators.Start(ds_);
            CqlDate du_ = context.Operators.DateFrom(dt_);
            return du_;
        }

        IEnumerable<CqlDate> j_ = context.Operators.Select<object, CqlDate>(h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Union<CqlDate>(e_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Treatment Initiation With Medication Order Dates")]
    public IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_Initiation_With_Medication_Order_Dates, Treatment_Initiation_With_Medication_Order_Dates_Compute);

    private const long _cacheIndex_Treatment_Initiation_With_Medication_Order_Dates = -5155209491511971935L;

    private IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> ad_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ae_(Medication M) {
                object ai_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ak_ = context.Operators.Split((string)aj_, "/");
                string al_ = context.Operators.Last<string>(ak_);
                bool? am_ = context.Operators.Equal(ai_, al_);
                CodeableConcept an_ = M?.Code;
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, an_);
                CqlValueSet ap_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
                bool? ar_ = context.Operators.And(am_, aq_);
                return ar_;
            }

            IEnumerable<Medication> af_ = context.Operators.Where<Medication>(ad_, ae_);
            MedicationRequest ag_(Medication M) => MR;
            IEnumerable<MedicationRequest> ah_ = context.Operators.Select<Medication, MedicationRequest>(af_, ag_);
            return ah_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> j_(MedicationRequest MR) {
            IEnumerable<Medication> as_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? at_(Medication M) {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);
                CodeableConcept bc_ = M?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlValueSet be_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                bool? bg_ = context.Operators.And(bb_, bf_);
                return bg_;
            }

            IEnumerable<Medication> au_ = context.Operators.Where<Medication>(as_, at_);
            MedicationRequest av_(Medication M) => MR;
            IEnumerable<MedicationRequest> aw_ = context.Operators.Select<Medication, MedicationRequest>(au_, av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        IEnumerable<MedicationRequest> n_ = Status_1_15_000.Instance.isMedicationOrder(context, m_);

        IEnumerable<MedicationRequest> o_(MedicationRequest SUDMedication) {
            Encounter bh_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bi_ = [
                bh_,
            ];

            bool? bj_(Encounter FirstSUDEpisode) {
                FhirDateTime bn_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_ as object);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                Period bs_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                CqlDate bv_ = context.Operators.DateFrom(bu_);
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                CqlDate bz_ = context.Operators.DateFrom(by_);
                CqlQuantity ca_ = context.Operators.Quantity(14m, "days");
                CqlDate cb_ = context.Operators.Add(bz_, ca_);
                CqlInterval<CqlDate> cc_ = context.Operators.Interval(bv_, cb_, true, false);
                bool? cd_ = context.Operators.In<CqlDate>(br_, cc_, (string)default);
                return cd_;
            }

            IEnumerable<Encounter> bk_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)bi_, bj_);
            MedicationRequest bl_(Encounter FirstSUDEpisode) => SUDMedication;
            IEnumerable<MedicationRequest> bm_ = context.Operators.Select<Encounter, MedicationRequest>(bk_, bl_);
            return bm_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(n_, o_);

        CqlDate q_(MedicationRequest SUDMedication) {
            FhirDateTime ce_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
            CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_ as object);
            CqlDateTime ch_ = context.Operators.Start(cg_);
            CqlDate ci_ = context.Operators.DateFrom(ch_);
            return ci_;
        }

        IEnumerable<CqlDate> r_ = context.Operators.Select<MedicationRequest, CqlDate>(p_, q_);
        CqlValueSet s_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet u_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> w_ = context.Operators.Union<Procedure>(t_, v_);
        IEnumerable<Procedure> x_ = Status_1_15_000.Instance.isProcedurePerformed(context, w_);

        IEnumerable<Procedure> y_(Procedure SUDMedAdministration) {
            Encounter cj_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ck_ = [
                cj_,
            ];

            bool? cl_(Encounter FirstSUDEpisode) {

                object cp_() {

                    bool df_() {
                        DataType dj_ = SUDMedAdministration?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlDateTime;
                        return dl_;
                    }


                    bool dg_() {
                        DataType dm_ = SUDMedAdministration?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bool do_ = dn_ is CqlInterval<CqlDateTime>;
                        return do_;
                    }


                    bool dh_() {
                        DataType dp_ = SUDMedAdministration?.Performed;
                        object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                        bool dr_ = dq_ is CqlQuantity;
                        return dr_;
                    }


                    bool di_() {
                        DataType ds_ = SUDMedAdministration?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        bool du_ = dt_ is CqlInterval<CqlQuantity>;
                        return du_;
                    }

                    if (df_())
                    {
                        DataType dv_ = SUDMedAdministration?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        return (dw_ as CqlDateTime) as object;
                    }
                    else if (dg_())
                    {
                        DataType dx_ = SUDMedAdministration?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return (dy_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dh_())
                    {
                        DataType dz_ = SUDMedAdministration?.Performed;
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        return (ea_ as CqlQuantity) as object;
                    }
                    else if (di_())
                    {
                        DataType eb_ = SUDMedAdministration?.Performed;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        return (ec_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_());
                CqlDateTime cr_ = context.Operators.Start(cq_);
                CqlDate cs_ = context.Operators.DateFrom(cr_);
                Period ct_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlDate cw_ = context.Operators.DateFrom(cv_);
                CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                CqlDate da_ = context.Operators.DateFrom(cz_);
                CqlQuantity db_ = context.Operators.Quantity(14m, "days");
                CqlDate dc_ = context.Operators.Add(da_, db_);
                CqlInterval<CqlDate> dd_ = context.Operators.Interval(cw_, dc_, true, false);
                bool? de_ = context.Operators.In<CqlDate>(cs_, dd_, (string)default);
                return de_;
            }

            IEnumerable<Encounter> cm_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ck_, cl_);
            Procedure cn_(Encounter FirstSUDEpisode) => SUDMedAdministration;
            IEnumerable<Procedure> co_ = context.Operators.Select<Encounter, Procedure>(cm_, cn_);
            return co_;
        }

        IEnumerable<Procedure> z_ = context.Operators.SelectMany<Procedure, Procedure>(x_, y_);

        CqlDate aa_(Procedure SUDMedAdministration) {

            object ed_() {

                bool eh_() {
                    DataType el_ = SUDMedAdministration?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlDateTime;
                    return en_;
                }


                bool ei_() {
                    DataType eo_ = SUDMedAdministration?.Performed;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bool eq_ = ep_ is CqlInterval<CqlDateTime>;
                    return eq_;
                }


                bool ej_() {
                    DataType er_ = SUDMedAdministration?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlQuantity;
                    return et_;
                }


                bool ek_() {
                    DataType eu_ = SUDMedAdministration?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                    return ew_;
                }

                if (eh_())
                {
                    DataType ex_ = SUDMedAdministration?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    return (ey_ as CqlDateTime) as object;
                }
                else if (ei_())
                {
                    DataType ez_ = SUDMedAdministration?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return (fa_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ej_())
                {
                    DataType fb_ = SUDMedAdministration?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    return (fc_ as CqlQuantity) as object;
                }
                else if (ek_())
                {
                    DataType fd_ = SUDMedAdministration?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    return (fe_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ee_ = QICoreCommon_4_0_000.Instance.toInterval(context, ed_());
            CqlDateTime ef_ = context.Operators.Start(ee_);
            CqlDate eg_ = context.Operators.DateFrom(ef_);
            return eg_;
        }

        IEnumerable<CqlDate> ab_ = context.Operators.Select<Procedure, CqlDate>(z_, aa_);
        IEnumerable<CqlDate> ac_ = context.Operators.Union<CqlDate>(r_, ab_);
        return ac_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -5625741812967658730L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        IEnumerable<CqlDate> c_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention")]
    public bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention, Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Compute);

    private const long _cacheIndex_Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention = 8416184830860607988L;

    private bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Psychosocial_Visit(context);
        CqlValueSet b_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = Status_1_15_000.Instance.isProcedurePerformed(context, c_);
        IEnumerable<object> e_ = context.Operators.Union<object>(a_ as IEnumerable<object>, d_ as IEnumerable<object>);

        IEnumerable<object> f_(object ShortActingTreatment) {
            IEnumerable<CqlDate> x_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> y_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> z_ = context.Operators.Union<CqlDate>(x_, y_);
            CqlDate aa_ = context.Operators.Min<CqlDate>(z_);
            CqlDate[] ab_ = [
                aa_,
            ];

            bool? ac_(CqlDate InitiationTreatmentDate) {

                object ag_() {

                    bool bb_() {
                        object bf_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlDateTime;
                        return bh_;
                    }


                    bool bc_() {
                        object bi_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                        return bk_;
                    }


                    bool bd_() {
                        object bl_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlQuantity;
                        return bn_;
                    }


                    bool be_() {
                        object bo_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        return bq_;
                    }

                    if (bb_())
                    {
                        object br_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        return (bs_ as CqlDateTime) as object;
                    }
                    else if (bc_())
                    {
                        object bt_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        return (bu_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bd_())
                    {
                        object bv_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return (bw_ as CqlQuantity) as object;
                    }
                    else if (be_())
                    {
                        object bx_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        return (by_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlDate aj_ = context.Operators.DateFrom(ai_);
                CqlQuantity ak_ = context.Operators.Quantity(34m, "days");
                CqlDate al_ = context.Operators.Add(InitiationTreatmentDate, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitiationTreatmentDate, al_, false, true);
                bool? an_ = context.Operators.In<CqlDate>(aj_, am_, (string)default);
                bool? ao_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ap_ = context.Operators.And(an_, ao_);
                object aq_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_ as Period);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlDate at_ = context.Operators.DateFrom(as_);
                CqlDate av_ = context.Operators.Add(InitiationTreatmentDate, ak_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitiationTreatmentDate, av_, false, true);
                bool? ax_ = context.Operators.In<CqlDate>(at_, aw_, (string)default);
                bool? az_ = context.Operators.And(ax_, ao_);
                bool? ba_ = context.Operators.Or(ap_, az_);
                return ba_;
            }

            IEnumerable<CqlDate> ad_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ab_, ac_);
            object ae_(CqlDate InitiationTreatmentDate) => ShortActingTreatment;
            IEnumerable<object> af_ = context.Operators.Select<CqlDate, object>(ad_, ae_);
            return af_;
        }

        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        object h_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> i_ = context.Operators.Select<object, object>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> m_(MedicationRequest MR) {
            IEnumerable<Medication> bz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ca_(Medication M) {
                object ce_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cg_ = context.Operators.Split((string)cf_, "/");
                string ch_ = context.Operators.Last<string>(cg_);
                bool? ci_ = context.Operators.Equal(ce_, ch_);
                CodeableConcept cj_ = M?.Code;
                CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
                CqlValueSet cl_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? cm_ = context.Operators.ConceptInValueSet(ck_, cl_);
                bool? cn_ = context.Operators.And(ci_, cm_);
                return cn_;
            }

            IEnumerable<Medication> cb_ = context.Operators.Where<Medication>(bz_, ca_);
            MedicationRequest cc_(Medication M) => MR;
            IEnumerable<MedicationRequest> cd_ = context.Operators.Select<Medication, MedicationRequest>(cb_, cc_);
            return cd_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(l_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);
        IEnumerable<MedicationRequest> p_ = Status_1_15_000.Instance.isMedicationOrder(context, o_);

        IEnumerable<MedicationRequest> q_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> co_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cp_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> cq_ = context.Operators.Union<CqlDate>(co_, cp_);
            CqlDate cr_ = context.Operators.Min<CqlDate>(cq_);
            CqlDate[] cs_ = [
                cr_,
            ];

            bool? ct_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cx_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(cx_);
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_ as object);
                CqlDateTime da_ = context.Operators.Start(cz_);
                CqlDate db_ = context.Operators.DateFrom(da_);
                CqlQuantity dc_ = context.Operators.Quantity(34m, "days");
                CqlDate dd_ = context.Operators.Add(InitiationTreatmentDate, dc_);
                CqlInterval<CqlDate> de_ = context.Operators.Interval(InitiationTreatmentDate, dd_, false, true);
                bool? df_ = context.Operators.In<CqlDate>(db_, de_, (string)default);
                bool? dg_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? dh_ = context.Operators.And(df_, dg_);
                return dh_;
            }

            IEnumerable<CqlDate> cu_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)cs_, ct_);
            MedicationRequest cv_(CqlDate InitiationTreatmentDate) => ShortActingMedOrder;
            IEnumerable<MedicationRequest> cw_ = context.Operators.Select<CqlDate, MedicationRequest>(cu_, cv_);
            return cw_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(p_, q_);
        MedicationRequest s_(MedicationRequest ShortActingMedOrder) => ShortActingMedOrder;
        IEnumerable<MedicationRequest> t_ = context.Operators.Select<MedicationRequest, MedicationRequest>(r_, s_);
        IEnumerable<object> u_ = context.Operators.Union<object>(i_ as IEnumerable<object>, t_ as IEnumerable<object>);
        int? v_ = context.Operators.Count<object>(u_);
        bool? w_ = context.Operators.GreaterOrEqual(v_, 2);
        return w_;
    }


    [CqlExpressionDefinition("Has Treatment Engagement With Long Acting Medication")]
    public bool? Has_Treatment_Engagement_With_Long_Acting_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication, Has_Treatment_Engagement_With_Long_Acting_Medication_Compute);

    private const long _cacheIndex_Has_Treatment_Engagement_With_Long_Acting_Medication = 664917922855669451L;

    private bool? Has_Treatment_Engagement_With_Long_Acting_Medication_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? r_(Medication M) {
                object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(v_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
            }

            IEnumerable<Medication> s_ = context.Operators.Where<Medication>(q_, r_);
            MedicationRequest t_(Medication M) => MR;
            IEnumerable<MedicationRequest> u_ = context.Operators.Select<Medication, MedicationRequest>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        IEnumerable<MedicationRequest> h_(MedicationRequest LongActingMedOrder) {
            IEnumerable<CqlDate> af_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ag_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ah_ = context.Operators.Union<CqlDate>(af_, ag_);
            CqlDate ai_ = context.Operators.Min<CqlDate>(ah_);
            CqlDate[] aj_ = [
                ai_,
            ];

            bool? ak_(CqlDate InitiationTreatmentDate) {
                FhirDateTime ao_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime ap_ = context.Operators.Convert<CqlDateTime>(ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_ as object);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                CqlQuantity at_ = context.Operators.Quantity(34m, "days");
                CqlDate au_ = context.Operators.Add(InitiationTreatmentDate, at_);
                CqlInterval<CqlDate> av_ = context.Operators.Interval(InitiationTreatmentDate, au_, false, true);
                bool? aw_ = context.Operators.In<CqlDate>(as_, av_, (string)default);
                bool? ax_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ay_ = context.Operators.And(aw_, ax_);
                return ay_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)aj_, ak_);
            MedicationRequest am_(CqlDate InitiationTreatmentDate) => LongActingMedOrder;
            IEnumerable<MedicationRequest> an_ = context.Operators.Select<CqlDate, MedicationRequest>(al_, am_);
            return an_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        IEnumerable<Procedure> m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> az_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ba_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> bb_ = context.Operators.Union<CqlDate>(az_, ba_);
            CqlDate bc_ = context.Operators.Min<CqlDate>(bb_);
            CqlDate[] bd_ = [
                bc_,
            ];

            bool? be_(CqlDate InitiationTreatmentDate) {

                object bi_() {

                    bool bs_() {
                        DataType bw_ = LongActingTreatment?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlDateTime;
                        return by_;
                    }


                    bool bt_() {
                        DataType bz_ = LongActingTreatment?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                        return cb_;
                    }


                    bool bu_() {
                        DataType cc_ = LongActingTreatment?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlQuantity;
                        return ce_;
                    }


                    bool bv_() {
                        DataType cf_ = LongActingTreatment?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                        return ch_;
                    }

                    if (bs_())
                    {
                        DataType ci_ = LongActingTreatment?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return (cj_ as CqlDateTime) as object;
                    }
                    else if (bt_())
                    {
                        DataType ck_ = LongActingTreatment?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return (cl_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bu_())
                    {
                        DataType cm_ = LongActingTreatment?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return (cn_ as CqlQuantity) as object;
                    }
                    else if (bv_())
                    {
                        DataType co_ = LongActingTreatment?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        return (cp_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_());
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlDate bl_ = context.Operators.DateFrom(bk_);
                CqlQuantity bm_ = context.Operators.Quantity(34m, "days");
                CqlDate bn_ = context.Operators.Add(InitiationTreatmentDate, bm_);
                CqlInterval<CqlDate> bo_ = context.Operators.Interval(InitiationTreatmentDate, bn_, false, true);
                bool? bp_ = context.Operators.In<CqlDate>(bl_, bo_, (string)default);
                bool? bq_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? br_ = context.Operators.And(bp_, bq_);
                return br_;
            }

            IEnumerable<CqlDate> bf_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)bd_, be_);
            Procedure bg_(CqlDate InitiationTreatmentDate) => LongActingTreatment;
            IEnumerable<Procedure> bh_ = context.Operators.Select<CqlDate, Procedure>(bf_, bg_);
            return bh_;
        }

        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(i_ as IEnumerable<object>, n_ as IEnumerable<object>);
        bool? p_ = context.Operators.Exists<object>(o_);
        return p_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = 1834938210783437317L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Treatment_Engagement_With_Long_Acting_Medication(context);
        bool? b_ = this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 6418437819993636238L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8205811437225639691L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6782451795594240210L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1868441466622731252L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = -4824117620333877211L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(13, 17, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -8456206768832357499L;

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 64, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 9122996230781459201L;

    private bool? Stratification_3_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
        return i_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS137FHIRSUDTxInitEngagement_1_0_000() {}

    public static CMS137FHIRSUDTxInitEngagement_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS137FHIRSUDTxInitEngagement";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ = new(
       [typeof(CqlDate), typeof(Encounter)],
       ["ValidEncounterDate", "ValidEncounter"]);

    #endregion CqlTupleMetadata Properties

}
