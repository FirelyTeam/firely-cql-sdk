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

        bool? b_(Encounter ValidEncounters) {
            CqlValueSet k_ = this.Substance_Use_Disorder(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            Condition m_(Condition X) => X as Condition;
            IEnumerable<Condition> n_ = context.Operators.Select<Condition, Condition>(l_, m_);
            IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

            bool? p_(Condition SUDDiagnosis) {
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                Period t_ = ValidEncounters?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(s_, u_, (string)default);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SUDDiagnosis);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, (string)default);
                bool? ab_ = context.Operators.And(v_, aa_);
                CqlDateTime ad_ = context.Operators.Start(w_);
                CqlDateTime af_ = context.Operators.End(s_);
                CqlQuantity ag_ = context.Operators.Quantity(47m, "days");
                CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
                bool? ai_ = context.Operators.SameOrBefore(ad_, ah_, "day");
                bool? aj_ = context.Operators.And(ab_, ai_);
                return aj_;
            }

            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            return r_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? d_(Encounter ValidEncounters) {
            Period ak_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? ao_ = (CqlTupleMetadata_GYLjjJGJTORTXhCHiKcLEBBaJ, an_, ValidEncounters);
            return ao_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> e_ = context.Operators.Select<Encounter, (CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)?>(e_);

        object g_((CqlTupleMetadata, CqlDate ValidEncounterDate, Encounter ValidEncounter)? @this) {
            CqlDate ap_ = @this?.ValidEncounterDate;
            return ap_;
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

        bool? m_(Procedure Interventions) {
            Encounter an_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ao_ = [
                an_,
            ];

            bool? ap_(Encounter FirstSUDEpisode) {

                object as_() {

                    bool db_() {
                        DataType df_ = Interventions?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlDateTime;
                        return dh_;
                    }


                    bool dc_() {
                        DataType di_ = Interventions?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                        return dk_;
                    }


                    bool dd_() {
                        DataType dl_ = Interventions?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlQuantity;
                        return dn_;
                    }


                    bool de_() {
                        DataType do_ = Interventions?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                        return dq_;
                    }

                    if (db_())
                    {
                        DataType dr_ = Interventions?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        return (ds_ as CqlDateTime) as object;
                    }
                    else if (dc_())
                    {
                        DataType dt_ = Interventions?.Performed;
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                        return (du_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dd_())
                    {
                        DataType dv_ = Interventions?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        return (dw_ as CqlQuantity) as object;
                    }
                    else if (de_())
                    {
                        DataType dx_ = Interventions?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return (dy_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
                CqlDateTime au_ = context.Operators.Start(at_);
                Period av_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlDate ay_ = context.Operators.DateFrom(ax_);
                CqlQuantity az_ = context.Operators.Quantity(60m, "days");
                CqlDate ba_ = context.Operators.Subtract(ay_, az_);
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(ba_, be_, true, false);
                CqlDate bg_ = bf_?.low;
                CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlDate bl_ = context.Operators.DateFrom(bk_);
                CqlDate bn_ = context.Operators.Subtract(bl_, az_);
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlInterval<CqlDate> bs_ = context.Operators.Interval(bn_, br_, true, false);
                CqlDate bt_ = bs_?.high;
                CqlDateTime bu_ = context.Operators.ConvertDateToDateTime(bt_);
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                CqlDate by_ = context.Operators.DateFrom(bx_);
                CqlDate ca_ = context.Operators.Subtract(by_, az_);
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                CqlDate ce_ = context.Operators.DateFrom(cd_);
                CqlInterval<CqlDate> cf_ = context.Operators.Interval(ca_, ce_, true, false);
                bool? cg_ = cf_?.lowClosed;
                CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime cj_ = context.Operators.Start(ci_);
                CqlDate ck_ = context.Operators.DateFrom(cj_);
                CqlDate cm_ = context.Operators.Subtract(ck_, az_);
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime cp_ = context.Operators.Start(co_);
                CqlDate cq_ = context.Operators.DateFrom(cp_);
                CqlInterval<CqlDate> cr_ = context.Operators.Interval(cm_, cq_, true, false);
                bool? cs_ = cr_?.highClosed;
                CqlInterval<CqlDateTime> ct_ = context.Operators.Interval(bh_, bu_, cg_, cs_);
                bool? cu_ = context.Operators.In<CqlDateTime>(au_, ct_, "day");
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                CqlDate cy_ = context.Operators.DateFrom(cx_);
                bool? cz_ = context.Operators.Not((bool?)(cy_ is null));
                bool? da_ = context.Operators.And(cu_, cz_);
                return da_;
            }

            IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ao_, ap_);
            bool? ar_ = context.Operators.Exists<Encounter>(aq_);
            return ar_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Encounter> o_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> p_ = this.Emergency_Department_or_Detoxification_Visit(context);
        IEnumerable<Encounter> q_ = context.Operators.Except<Encounter>(o_, p_);

        bool? r_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> dz_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? ea_(Condition @this) {
                CodeableConcept eg_ = @this?.Code;
                CqlConcept eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eg_);
                bool? ei_ = context.Operators.Not((bool?)(eh_ is null));
                return ei_;
            }

            IEnumerable<Condition> eb_ = context.Operators.Where<Condition>(dz_, ea_);

            CqlConcept ec_(Condition @this) {
                CodeableConcept ej_ = @this?.Code;
                CqlConcept ek_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ej_);
                return ek_;
            }

            IEnumerable<CqlConcept> ed_ = context.Operators.Select<Condition, CqlConcept>(eb_, ec_);
            CqlValueSet ee_ = this.Substance_Use_Disorder(context);
            bool? ef_ = context.Operators.ConceptsInValueSet(ed_, ee_);
            return ef_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

        bool? t_(Encounter SUDEncounterDx) {
            Encounter el_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] em_ = [
                el_,
            ];

            bool? en_(Encounter FirstSUDEpisode) {
                Period eq_ = SUDEncounterDx?.Period;
                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eq_);
                CqlDateTime es_ = context.Operators.Start(er_);
                Period et_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime ev_ = context.Operators.Start(eu_);
                CqlDate ew_ = context.Operators.DateFrom(ev_);
                CqlQuantity ex_ = context.Operators.Quantity(60m, "days");
                CqlDate ey_ = context.Operators.Subtract(ew_, ex_);
                CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fb_ = context.Operators.Start(fa_);
                CqlDate fc_ = context.Operators.DateFrom(fb_);
                CqlInterval<CqlDate> fd_ = context.Operators.Interval(ey_, fc_, true, false);
                CqlDate fe_ = fd_?.low;
                CqlDateTime ff_ = context.Operators.ConvertDateToDateTime(fe_);
                CqlInterval<CqlDateTime> fh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fi_ = context.Operators.Start(fh_);
                CqlDate fj_ = context.Operators.DateFrom(fi_);
                CqlDate fl_ = context.Operators.Subtract(fj_, ex_);
                CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fo_ = context.Operators.Start(fn_);
                CqlDate fp_ = context.Operators.DateFrom(fo_);
                CqlInterval<CqlDate> fq_ = context.Operators.Interval(fl_, fp_, true, false);
                CqlDate fr_ = fq_?.high;
                CqlDateTime fs_ = context.Operators.ConvertDateToDateTime(fr_);
                CqlInterval<CqlDateTime> fu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fv_ = context.Operators.Start(fu_);
                CqlDate fw_ = context.Operators.DateFrom(fv_);
                CqlDate fy_ = context.Operators.Subtract(fw_, ex_);
                CqlInterval<CqlDateTime> ga_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime gb_ = context.Operators.Start(ga_);
                CqlDate gc_ = context.Operators.DateFrom(gb_);
                CqlInterval<CqlDate> gd_ = context.Operators.Interval(fy_, gc_, true, false);
                bool? ge_ = gd_?.lowClosed;
                CqlInterval<CqlDateTime> gg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime gh_ = context.Operators.Start(gg_);
                CqlDate gi_ = context.Operators.DateFrom(gh_);
                CqlDate gk_ = context.Operators.Subtract(gi_, ex_);
                CqlInterval<CqlDateTime> gm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime gn_ = context.Operators.Start(gm_);
                CqlDate go_ = context.Operators.DateFrom(gn_);
                CqlInterval<CqlDate> gp_ = context.Operators.Interval(gk_, go_, true, false);
                bool? gq_ = gp_?.highClosed;
                CqlInterval<CqlDateTime> gr_ = context.Operators.Interval(ff_, fs_, ge_, gq_);
                bool? gs_ = context.Operators.In<CqlDateTime>(es_, gr_, "day");
                CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime gv_ = context.Operators.Start(gu_);
                CqlDate gw_ = context.Operators.DateFrom(gv_);
                bool? gx_ = context.Operators.Not((bool?)(gw_ is null));
                bool? gy_ = context.Operators.And(gs_, gx_);
                return gy_;
            }

            IEnumerable<Encounter> eo_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)em_, en_);
            bool? ep_ = context.Operators.Exists<Encounter>(eo_);
            return ep_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        IEnumerable<object> v_ = context.Operators.Union<object>(n_ as IEnumerable<object>, u_ as IEnumerable<object>);
        CqlValueSet w_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? z_(MedicationRequest MR) {
            IEnumerable<Medication> gz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ha_(Medication M) {
                object hd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object he_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hf_ = context.Operators.Split((string)he_, "/");
                string hg_ = context.Operators.Last<string>(hf_);
                bool? hh_ = context.Operators.Equal(hd_, hg_);
                CodeableConcept hi_ = M?.Code;
                CqlConcept hj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hi_);
                CqlValueSet hk_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? hl_ = context.Operators.ConceptInValueSet(hj_, hk_);
                bool? hm_ = context.Operators.And(hh_, hl_);
                return hm_;
            }

            IEnumerable<Medication> hb_ = context.Operators.Where<Medication>(gz_, ha_);
            bool? hc_ = context.Operators.Exists<Medication>(hb_);
            return hc_;
        }

        IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        CqlValueSet ac_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? af_(MedicationRequest MR) {
            IEnumerable<Medication> hn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ho_(Medication M) {
                object hr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hs_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ht_ = context.Operators.Split((string)hs_, "/");
                string hu_ = context.Operators.Last<string>(ht_);
                bool? hv_ = context.Operators.Equal(hr_, hu_);
                CodeableConcept hw_ = M?.Code;
                CqlConcept hx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hw_);
                CqlValueSet hy_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? hz_ = context.Operators.ConceptInValueSet(hx_, hy_);
                bool? ia_ = context.Operators.And(hv_, hz_);
                return ia_;
            }

            IEnumerable<Medication> hp_ = context.Operators.Where<Medication>(hn_, ho_);
            bool? hq_ = context.Operators.Exists<Medication>(hp_);
            return hq_;
        }

        IEnumerable<MedicationRequest> ag_ = context.Operators.Where<MedicationRequest>(y_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ad_, ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(ab_, ah_);
        IEnumerable<MedicationRequest> aj_ = Status_1_15_000.Instance.isMedicationOrder(context, ai_);

        bool? ak_(MedicationRequest SUDMedication) {
            Encounter ib_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ic_ = [
                ib_,
            ];

            bool? id_(Encounter FirstSUDEpisode) {
                FhirDateTime ig_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime ih_ = context.Operators.Convert<CqlDateTime>(ig_);
                Period ii_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime ik_ = context.Operators.Start(ij_);
                CqlDate il_ = context.Operators.DateFrom(ik_);
                CqlQuantity im_ = context.Operators.Quantity(60m, "days");
                CqlDate in_ = context.Operators.Subtract(il_, im_);
                CqlInterval<CqlDateTime> ip_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime iq_ = context.Operators.Start(ip_);
                CqlDate ir_ = context.Operators.DateFrom(iq_);
                CqlInterval<CqlDate> is_ = context.Operators.Interval(in_, ir_, true, false);
                CqlDate it_ = is_?.low;
                CqlDateTime iu_ = context.Operators.ConvertDateToDateTime(it_);
                CqlInterval<CqlDateTime> iw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime ix_ = context.Operators.Start(iw_);
                CqlDate iy_ = context.Operators.DateFrom(ix_);
                CqlDate ja_ = context.Operators.Subtract(iy_, im_);
                CqlInterval<CqlDateTime> jc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime jd_ = context.Operators.Start(jc_);
                CqlDate je_ = context.Operators.DateFrom(jd_);
                CqlInterval<CqlDate> jf_ = context.Operators.Interval(ja_, je_, true, false);
                CqlDate jg_ = jf_?.high;
                CqlDateTime jh_ = context.Operators.ConvertDateToDateTime(jg_);
                CqlInterval<CqlDateTime> jj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime jk_ = context.Operators.Start(jj_);
                CqlDate jl_ = context.Operators.DateFrom(jk_);
                CqlDate jn_ = context.Operators.Subtract(jl_, im_);
                CqlInterval<CqlDateTime> jp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime jq_ = context.Operators.Start(jp_);
                CqlDate jr_ = context.Operators.DateFrom(jq_);
                CqlInterval<CqlDate> js_ = context.Operators.Interval(jn_, jr_, true, false);
                bool? jt_ = js_?.lowClosed;
                CqlInterval<CqlDateTime> jv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime jw_ = context.Operators.Start(jv_);
                CqlDate jx_ = context.Operators.DateFrom(jw_);
                CqlDate jz_ = context.Operators.Subtract(jx_, im_);
                CqlInterval<CqlDateTime> kb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime kc_ = context.Operators.Start(kb_);
                CqlDate kd_ = context.Operators.DateFrom(kc_);
                CqlInterval<CqlDate> ke_ = context.Operators.Interval(jz_, kd_, true, false);
                bool? kf_ = ke_?.highClosed;
                CqlInterval<CqlDateTime> kg_ = context.Operators.Interval(iu_, jh_, jt_, kf_);
                bool? kh_ = context.Operators.In<CqlDateTime>(ih_, kg_, "day");
                CqlInterval<CqlDateTime> kj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                CqlDateTime kk_ = context.Operators.Start(kj_);
                CqlDate kl_ = context.Operators.DateFrom(kk_);
                bool? km_ = context.Operators.Not((bool?)(kl_ is null));
                bool? kn_ = context.Operators.And(kh_, km_);
                return kn_;
            }

            IEnumerable<Encounter> ie_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ic_, id_);
            bool? if_ = context.Operators.Exists<Encounter>(ie_);
            return if_;
        }

        IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);
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

        bool? b_(object PsychosocialVisitProcedure) {
            Encounter l_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] m_ = [
                l_,
            ];

            bool? n_(Encounter FirstSUDEpisode) {

                object q_() {

                    bool an_() {
                        object ar_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;
                        return at_;
                    }


                    bool ao_() {
                        object au_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;
                        return aw_;
                    }


                    bool ap_() {
                        object ax_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlQuantity;
                        return az_;
                    }


                    bool aq_() {
                        object ba_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                        return bc_;
                    }

                    if (an_())
                    {
                        object bd_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return (be_ as CqlDateTime) as object;
                    }
                    else if (ao_())
                    {
                        object bf_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        return (bg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ap_())
                    {
                        object bh_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        return (bi_ as CqlQuantity) as object;
                    }
                    else if (aq_())
                    {
                        object bj_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        return (bk_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                Period u_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlDate x_ = context.Operators.DateFrom(w_);
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlDate ab_ = context.Operators.DateFrom(aa_);
                CqlQuantity ac_ = context.Operators.Quantity(14m, "days");
                CqlDate ad_ = context.Operators.Add(ab_, ac_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(x_, ad_, true, false);
                bool? af_ = context.Operators.In<CqlDate>(t_, ae_, (string)default);
                object ag_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "id");
                string ah_ = context.Operators.LateBoundProperty<string>(ag_, "value");
                Id ai_ = FirstSUDEpisode?.IdElement;
                string aj_ = ai_?.Value;
                bool? ak_ = context.Operators.Equivalent(ah_, aj_);
                bool? al_ = context.Operators.Not(ak_);
                bool? am_ = context.Operators.And(af_, al_);
                return am_;
            }

            IEnumerable<Encounter> o_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)m_, n_);
            bool? p_ = context.Operators.Exists<Encounter>(o_);
            return p_;
        }

        IEnumerable<object> c_ = context.Operators.Where<object>(a_, b_);

        CqlDate d_(object PsychosocialVisitProcedure) {

            object bl_() {

                bool bp_() {
                    object bt_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlDateTime;
                    return bv_;
                }


                bool bq_() {
                    object bw_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool by_ = bx_ is CqlInterval<CqlDateTime>;
                    return by_;
                }


                bool br_() {
                    object bz_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlQuantity;
                    return cb_;
                }


                bool bs_() {
                    object cc_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                    return ce_;
                }

                if (bp_())
                {
                    object cf_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    return (cg_ as CqlDateTime) as object;
                }
                else if (bq_())
                {
                    object ch_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    return (ci_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (br_())
                {
                    object cj_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    return (ck_ as CqlQuantity) as object;
                }
                else if (bs_())
                {
                    object cl_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitProcedure, "performed");
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    return (cm_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
            CqlDateTime bn_ = context.Operators.Start(bm_);
            CqlDate bo_ = context.Operators.DateFrom(bn_);
            return bo_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Select<object, CqlDate>(c_, d_);

        bool? g_(object PsychosocialVisitEncounter) {
            Encounter cn_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] co_ = [
                cn_,
            ];

            bool? cp_(Encounter FirstSUDEpisode) {
                object cs_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
                CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_ as Period);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                CqlDate cv_ = context.Operators.DateFrom(cu_);
                Period cw_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlDateTime cy_ = context.Operators.Start(cx_);
                CqlDate cz_ = context.Operators.DateFrom(cy_);
                CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlDateTime dc_ = context.Operators.Start(db_);
                CqlDate dd_ = context.Operators.DateFrom(dc_);
                CqlQuantity de_ = context.Operators.Quantity(14m, "days");
                CqlDate df_ = context.Operators.Add(dd_, de_);
                CqlInterval<CqlDate> dg_ = context.Operators.Interval(cz_, df_, true, false);
                bool? dh_ = context.Operators.In<CqlDate>(cv_, dg_, (string)default);
                object di_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "id");
                string dj_ = context.Operators.LateBoundProperty<string>(di_, "value");
                Id dk_ = FirstSUDEpisode?.IdElement;
                string dl_ = dk_?.Value;
                bool? dm_ = context.Operators.Equivalent(dj_, dl_);
                bool? dn_ = context.Operators.Not(dm_);
                bool? do_ = context.Operators.And(dh_, dn_);
                return do_;
            }

            IEnumerable<Encounter> cq_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)co_, cp_);
            bool? cr_ = context.Operators.Exists<Encounter>(cq_);
            return cr_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(a_, g_);

        CqlDate i_(object PsychosocialVisitEncounter) {
            object dp_ = context.Operators.LateBoundProperty<object>(PsychosocialVisitEncounter, "period");
            CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_ as Period);
            CqlDateTime dr_ = context.Operators.Start(dq_);
            CqlDate ds_ = context.Operators.DateFrom(dr_);
            return ds_;
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

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> ad_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ae_(Medication M) {
                object ah_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ai_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aj_ = context.Operators.Split((string)ai_, "/");
                string ak_ = context.Operators.Last<string>(aj_);
                bool? al_ = context.Operators.Equal(ah_, ak_);
                CodeableConcept am_ = M?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlValueSet ao_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
                bool? aq_ = context.Operators.And(al_, ap_);
                return aq_;
            }

            IEnumerable<Medication> af_ = context.Operators.Where<Medication>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Medication>(af_);
            return ag_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> ar_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? as_(Medication M) {
                object av_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ax_ = context.Operators.Split((string)aw_, "/");
                string ay_ = context.Operators.Last<string>(ax_);
                bool? az_ = context.Operators.Equal(av_, ay_);
                CodeableConcept ba_ = M?.Code;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                CqlValueSet bc_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? bd_ = context.Operators.ConceptInValueSet(bb_, bc_);
                bool? be_ = context.Operators.And(az_, bd_);
                return be_;
            }

            IEnumerable<Medication> at_ = context.Operators.Where<Medication>(ar_, as_);
            bool? au_ = context.Operators.Exists<Medication>(at_);
            return au_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        IEnumerable<MedicationRequest> n_ = Status_1_15_000.Instance.isMedicationOrder(context, m_);

        bool? o_(MedicationRequest SUDMedication) {
            Encounter bf_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] bg_ = [
                bf_,
            ];

            bool? bh_(Encounter FirstSUDEpisode) {
                FhirDateTime bk_ = SUDMedication?.AuthoredOnElement;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_ as object);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlDate bo_ = context.Operators.DateFrom(bn_);
                Period bp_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                CqlDateTime bv_ = context.Operators.Start(bu_);
                CqlDate bw_ = context.Operators.DateFrom(bv_);
                CqlQuantity bx_ = context.Operators.Quantity(14m, "days");
                CqlDate by_ = context.Operators.Add(bw_, bx_);
                CqlInterval<CqlDate> bz_ = context.Operators.Interval(bs_, by_, true, false);
                bool? ca_ = context.Operators.In<CqlDate>(bo_, bz_, (string)default);
                return ca_;
            }

            IEnumerable<Encounter> bi_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)bg_, bh_);
            bool? bj_ = context.Operators.Exists<Encounter>(bi_);
            return bj_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);

        CqlDate q_(MedicationRequest SUDMedication) {
            FhirDateTime cb_ = SUDMedication?.AuthoredOnElement;
            CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
            CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_ as object);
            CqlDateTime ce_ = context.Operators.Start(cd_);
            CqlDate cf_ = context.Operators.DateFrom(ce_);
            return cf_;
        }

        IEnumerable<CqlDate> r_ = context.Operators.Select<MedicationRequest, CqlDate>(p_, q_);
        CqlValueSet s_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet u_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> w_ = context.Operators.Union<Procedure>(t_, v_);
        IEnumerable<Procedure> x_ = Status_1_15_000.Instance.isProcedurePerformed(context, w_);

        bool? y_(Procedure SUDMedAdministration) {
            Encounter cg_ = this.First_SUD_Episode_During_Measurement_Period(context);
            Encounter[] ch_ = [
                cg_,
            ];

            bool? ci_(Encounter FirstSUDEpisode) {

                object cl_() {

                    bool db_() {
                        DataType df_ = SUDMedAdministration?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlDateTime;
                        return dh_;
                    }


                    bool dc_() {
                        DataType di_ = SUDMedAdministration?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                        return dk_;
                    }


                    bool dd_() {
                        DataType dl_ = SUDMedAdministration?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlQuantity;
                        return dn_;
                    }


                    bool de_() {
                        DataType do_ = SUDMedAdministration?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                        return dq_;
                    }

                    if (db_())
                    {
                        DataType dr_ = SUDMedAdministration?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        return (ds_ as CqlDateTime) as object;
                    }
                    else if (dc_())
                    {
                        DataType dt_ = SUDMedAdministration?.Performed;
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                        return (du_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dd_())
                    {
                        DataType dv_ = SUDMedAdministration?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        return (dw_ as CqlQuantity) as object;
                    }
                    else if (de_())
                    {
                        DataType dx_ = SUDMedAdministration?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return (dy_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_());
                CqlDateTime cn_ = context.Operators.Start(cm_);
                CqlDate co_ = context.Operators.DateFrom(cn_);
                Period cp_ = FirstSUDEpisode?.Period;
                CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                CqlDate cs_ = context.Operators.DateFrom(cr_);
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlDate cw_ = context.Operators.DateFrom(cv_);
                CqlQuantity cx_ = context.Operators.Quantity(14m, "days");
                CqlDate cy_ = context.Operators.Add(cw_, cx_);
                CqlInterval<CqlDate> cz_ = context.Operators.Interval(cs_, cy_, true, false);
                bool? da_ = context.Operators.In<CqlDate>(co_, cz_, (string)default);
                return da_;
            }

            IEnumerable<Encounter> cj_ = context.Operators.Where<Encounter>((IEnumerable<Encounter>)ch_, ci_);
            bool? ck_ = context.Operators.Exists<Encounter>(cj_);
            return ck_;
        }

        IEnumerable<Procedure> z_ = context.Operators.Where<Procedure>(x_, y_);

        CqlDate aa_(Procedure SUDMedAdministration) {

            object dz_() {

                bool ed_() {
                    DataType eh_ = SUDMedAdministration?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlDateTime;
                    return ej_;
                }


                bool ee_() {
                    DataType ek_ = SUDMedAdministration?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlDateTime>;
                    return em_;
                }


                bool ef_() {
                    DataType en_ = SUDMedAdministration?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlQuantity;
                    return ep_;
                }


                bool eg_() {
                    DataType eq_ = SUDMedAdministration?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlInterval<CqlQuantity>;
                    return es_;
                }

                if (ed_())
                {
                    DataType et_ = SUDMedAdministration?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlDateTime) as object;
                }
                else if (ee_())
                {
                    DataType ev_ = SUDMedAdministration?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ef_())
                {
                    DataType ex_ = SUDMedAdministration?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    return (ey_ as CqlQuantity) as object;
                }
                else if (eg_())
                {
                    DataType ez_ = SUDMedAdministration?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return (fa_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ea_ = QICoreCommon_4_0_000.Instance.toInterval(context, dz_());
            CqlDateTime eb_ = context.Operators.Start(ea_);
            CqlDate ec_ = context.Operators.DateFrom(eb_);
            return ec_;
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

        bool? f_(object ShortActingTreatment) {
            IEnumerable<CqlDate> x_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> y_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> z_ = context.Operators.Union<CqlDate>(x_, y_);
            CqlDate aa_ = context.Operators.Min<CqlDate>(z_);
            CqlDate[] ab_ = [
                aa_,
            ];

            bool? ac_(CqlDate InitiationTreatmentDate) {

                object af_() {

                    bool ba_() {
                        object be_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlDateTime;
                        return bg_;
                    }


                    bool bb_() {
                        object bh_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        return bj_;
                    }


                    bool bc_() {
                        object bk_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlQuantity;
                        return bm_;
                    }


                    bool bd_() {
                        object bn_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                        return bp_;
                    }

                    if (ba_())
                    {
                        object bq_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        return (br_ as CqlDateTime) as object;
                    }
                    else if (bb_())
                    {
                        object bs_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return (bt_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bc_())
                    {
                        object bu_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return (bv_ as CqlQuantity) as object;
                    }
                    else if (bd_())
                    {
                        object bw_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return (bx_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_());
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(34m, "days");
                CqlDate ak_ = context.Operators.Add(InitiationTreatmentDate, aj_);
                CqlInterval<CqlDate> al_ = context.Operators.Interval(InitiationTreatmentDate, ak_, false, true);
                bool? am_ = context.Operators.In<CqlDate>(ai_, al_, (string)default);
                bool? an_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? ao_ = context.Operators.And(am_, an_);
                object ap_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_ as Period);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                CqlDate au_ = context.Operators.Add(InitiationTreatmentDate, aj_);
                CqlInterval<CqlDate> av_ = context.Operators.Interval(InitiationTreatmentDate, au_, false, true);
                bool? aw_ = context.Operators.In<CqlDate>(as_, av_, (string)default);
                bool? ay_ = context.Operators.And(aw_, an_);
                bool? az_ = context.Operators.Or(ao_, ay_);
                return az_;
            }

            IEnumerable<CqlDate> ad_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ab_, ac_);
            bool? ae_ = context.Operators.Exists<CqlDate>(ad_);
            return ae_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
        object h_(object ShortActingTreatment) => ShortActingTreatment;
        IEnumerable<object> i_ = context.Operators.Select<object, object>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> by_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bz_(Medication M) {
                object cc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ce_ = context.Operators.Split((string)cd_, "/");
                string cf_ = context.Operators.Last<string>(ce_);
                bool? cg_ = context.Operators.Equal(cc_, cf_);
                CodeableConcept ch_ = M?.Code;
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
                CqlValueSet cj_ = this.Substance_Use_Disorder_Short_Acting_Medication(context);
                bool? ck_ = context.Operators.ConceptInValueSet(ci_, cj_);
                bool? cl_ = context.Operators.And(cg_, ck_);
                return cl_;
            }

            IEnumerable<Medication> ca_ = context.Operators.Where<Medication>(by_, bz_);
            bool? cb_ = context.Operators.Exists<Medication>(ca_);
            return cb_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);
        IEnumerable<MedicationRequest> p_ = Status_1_15_000.Instance.isMedicationOrder(context, o_);

        bool? q_(MedicationRequest ShortActingMedOrder) {
            IEnumerable<CqlDate> cm_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> cn_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> co_ = context.Operators.Union<CqlDate>(cm_, cn_);
            CqlDate cp_ = context.Operators.Min<CqlDate>(co_);
            CqlDate[] cq_ = [
                cp_,
            ];

            bool? cr_(CqlDate InitiationTreatmentDate) {
                FhirDateTime cu_ = ShortActingMedOrder?.AuthoredOnElement;
                CqlDateTime cv_ = context.Operators.Convert<CqlDateTime>(cu_);
                CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_ as object);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                CqlDate cy_ = context.Operators.DateFrom(cx_);
                CqlQuantity cz_ = context.Operators.Quantity(34m, "days");
                CqlDate da_ = context.Operators.Add(InitiationTreatmentDate, cz_);
                CqlInterval<CqlDate> db_ = context.Operators.Interval(InitiationTreatmentDate, da_, false, true);
                bool? dc_ = context.Operators.In<CqlDate>(cy_, db_, (string)default);
                bool? dd_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? de_ = context.Operators.And(dc_, dd_);
                return de_;
            }

            IEnumerable<CqlDate> cs_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)cq_, cr_);
            bool? ct_ = context.Operators.Exists<CqlDate>(cs_);
            return ct_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
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

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> q_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? r_(Medication M) {
                object u_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object v_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> w_ = context.Operators.Split((string)v_, "/");
                string x_ = context.Operators.Last<string>(w_);
                bool? y_ = context.Operators.Equal(u_, x_);
                CodeableConcept z_ = M?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                CqlValueSet ab_ = this.Substance_Use_Disorder_Long_Acting_Medication(context);
                bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<Medication> s_ = context.Operators.Where<Medication>(q_, r_);
            bool? t_ = context.Operators.Exists<Medication>(s_);
            return t_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest LongActingMedOrder) {
            IEnumerable<CqlDate> ae_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> af_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> ag_ = context.Operators.Union<CqlDate>(ae_, af_);
            CqlDate ah_ = context.Operators.Min<CqlDate>(ag_);
            CqlDate[] ai_ = [
                ah_,
            ];

            bool? aj_(CqlDate InitiationTreatmentDate) {
                FhirDateTime am_ = LongActingMedOrder?.AuthoredOnElement;
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_ as object);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlDate aq_ = context.Operators.DateFrom(ap_);
                CqlQuantity ar_ = context.Operators.Quantity(34m, "days");
                CqlDate as_ = context.Operators.Add(InitiationTreatmentDate, ar_);
                CqlInterval<CqlDate> at_ = context.Operators.Interval(InitiationTreatmentDate, as_, false, true);
                bool? au_ = context.Operators.In<CqlDate>(aq_, at_, (string)default);
                bool? av_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ak_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)ai_, aj_);
            bool? al_ = context.Operators.Exists<CqlDate>(ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlValueSet j_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

        bool? m_(Procedure LongActingTreatment) {
            IEnumerable<CqlDate> ax_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates(context);
            IEnumerable<CqlDate> ay_ = this.Treatment_Initiation_With_Medication_Order_Dates(context);
            IEnumerable<CqlDate> az_ = context.Operators.Union<CqlDate>(ax_, ay_);
            CqlDate ba_ = context.Operators.Min<CqlDate>(az_);
            CqlDate[] bb_ = [
                ba_,
            ];

            bool? bc_(CqlDate InitiationTreatmentDate) {

                object bf_() {

                    bool bp_() {
                        DataType bt_ = LongActingTreatment?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlDateTime;
                        return bv_;
                    }


                    bool bq_() {
                        DataType bw_ = LongActingTreatment?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        return by_;
                    }


                    bool br_() {
                        DataType bz_ = LongActingTreatment?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlQuantity;
                        return cb_;
                    }


                    bool bs_() {
                        DataType cc_ = LongActingTreatment?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                        return ce_;
                    }

                    if (bp_())
                    {
                        DataType cf_ = LongActingTreatment?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        return (cg_ as CqlDateTime) as object;
                    }
                    else if (bq_())
                    {
                        DataType ch_ = LongActingTreatment?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return (ci_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (br_())
                    {
                        DataType cj_ = LongActingTreatment?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return (ck_ as CqlQuantity) as object;
                    }
                    else if (bs_())
                    {
                        DataType cl_ = LongActingTreatment?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        return (cm_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_());
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlDate bi_ = context.Operators.DateFrom(bh_);
                CqlQuantity bj_ = context.Operators.Quantity(34m, "days");
                CqlDate bk_ = context.Operators.Add(InitiationTreatmentDate, bj_);
                CqlInterval<CqlDate> bl_ = context.Operators.Interval(InitiationTreatmentDate, bk_, false, true);
                bool? bm_ = context.Operators.In<CqlDate>(bi_, bl_, (string)default);
                bool? bn_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
                bool? bo_ = context.Operators.And(bm_, bn_);
                return bo_;
            }

            IEnumerable<CqlDate> bd_ = context.Operators.Where<CqlDate>((IEnumerable<CqlDate>)bb_, bc_);
            bool? be_ = context.Operators.Exists<CqlDate>(bd_);
            return be_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
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
