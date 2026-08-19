#nullable enable annotations

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
[CqlLibrary("CMS74FHIRDentalCariesPrevention", "1.0.000")]
public partial class CMS74FHIRDentalCariesPrevention_1_0_000 : ILibrary, ISingleton<CMS74FHIRDentalCariesPrevention_1_0_000>
{
    #region ValueSets (5)

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet? Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet? _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet? Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet? _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hosice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet? Discharged_to_Home_for_Hosice_Care(CqlContext _) => _Discharged_to_Home_for_Hosice_Care;
    private static readonly CqlValueSet? _Discharged_to_Home_for_Hosice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet? Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet? _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet? Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet? _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3459411623385782866L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS74FHIRDentalCariesPrevention-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5569230345433797234L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter?>? Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -1335537517400099656L;

    private IEnumerable<Encounter?>? Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter? ValidEncounter) {
            CqlInterval<CqlDateTime?>? f_ = this.Measurement_Period(context);
            Period? g_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime?>? h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            return i_;
        }

        IEnumerable<Encounter?>? e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3404065433003864595L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(1, 20, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        IEnumerable<Encounter?>? k_ = this.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 9163392405658072408L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 7868563991812526633L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8189944364767768999L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure? FluorideApplication) {
            object? j_;
            DataType? o_ = FluorideApplication?.Performed;
            object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool q_ = p_ is CqlDateTime;
            if (q_)
            {
                DataType? r_ = FluorideApplication?.Performed;
                object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                j_ = s_ as CqlDateTime;
            }
            else
            {
                DataType? t_ = FluorideApplication?.Performed;
                object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlQuantity;
                if (v_)
                {
                    DataType? w_ = FluorideApplication?.Performed;
                    object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    j_ = x_ as CqlQuantity;
                }
                else
                {
                    DataType? y_ = FluorideApplication?.Performed;
                    object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    if (aa_)
                    {
                        DataType? ab_ = FluorideApplication?.Performed;
                        object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        j_ = ac_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType? ad_ = FluorideApplication?.Performed;
                        object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        if (af_)
                        {
                            DataType? ag_ = FluorideApplication?.Performed;
                            object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            j_ = ah_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            CqlDateTime? l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
            return n_;
        }


        CqlDate? e_(Procedure? FluorideApplication) {
            object? ai_;
            DataType? am_ = FluorideApplication?.Performed;
            object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool ao_ = an_ is CqlDateTime;
            if (ao_)
            {
                DataType? ap_ = FluorideApplication?.Performed;
                object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                ai_ = aq_ as CqlDateTime;
            }
            else
            {
                DataType? ar_ = FluorideApplication?.Performed;
                object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlQuantity;
                if (at_)
                {
                    DataType? au_ = FluorideApplication?.Performed;
                    object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    ai_ = av_ as CqlQuantity;
                }
                else
                {
                    DataType? aw_ = FluorideApplication?.Performed;
                    object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        DataType? az_ = FluorideApplication?.Performed;
                        object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        ai_ = ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType? bb_ = FluorideApplication?.Performed;
                        object? bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                        if (bd_)
                        {
                            DataType? be_ = FluorideApplication?.Performed;
                            object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            ai_ = bf_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
            CqlDateTime? ak_ = context.Operators.End(aj_);
            CqlDate? al_ = context.Operators.DateFrom(ak_);
            return al_;
        }

        IEnumerable<CqlDate?>? f_ = context.Operators.WhereSelect<Procedure, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate?>? g_ = context.Operators.Distinct<CqlDate>(f_);
        int? h_ = context.Operators.Count<CqlDate>(g_);
        bool? i_ = context.Operators.GreaterOrEqual(h_, 2);
        return i_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 6383227092078244640L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(1, 5, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = 7132016695278820787L;

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(6, 12, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 6092906886529512472L;

    private bool? Stratification_3_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(13, 20, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3908866002830981138L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7258492887071442421L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 8315400797531393439L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7364382078820048309L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS74FHIRDentalCariesPrevention_1_0_000() {}

    public static CMS74FHIRDentalCariesPrevention_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS74FHIRDentalCariesPrevention";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
