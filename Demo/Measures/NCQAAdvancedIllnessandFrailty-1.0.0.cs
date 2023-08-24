using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public class NCQAAdvancedIllnessandFrailty_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Advanced_Illness;
    internal Lazy<CqlValueSet> __Dementia_Medications;
    internal Lazy<CqlValueSet> __ED;
    internal Lazy<CqlValueSet> __Frailty_Device;
    internal Lazy<CqlValueSet> __Frailty_Diagnosis;
    internal Lazy<CqlValueSet> __Frailty_Encounter;
    internal Lazy<CqlValueSet> __Frailty_Symptom;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Criteria_Indicating_Frailty;
    internal Lazy<IEnumerable<CqlDate>> __Outpatient_Encounters_with_Advanced_Illness;
    internal Lazy<IEnumerable<CqlDate>> __Nonacute_Inpatient_Discharge_with_Advanced_Illness;
    internal Lazy<IEnumerable<CqlDate>> __Outpatient_Encounters_or_Discharges_with_Advanced_Illness;
    internal Lazy<bool?> __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service;
    internal Lazy<bool?> __Acute_Inpatient_Encounter_with_Advanced_Illness;
    internal Lazy<bool?> __Acute_Inpatient_Discharge_with_Advanced_Illness;
    internal Lazy<bool?> __Dementia_Medications_In_Year_Before_or_During_Measurement_Period;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80;

    #endregion
    public NCQAAdvancedIllnessandFrailty_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);
        NCQAEncounter_1_0_0 = new NCQAEncounter_1_0_0(context);
        NCQAClaims_1_0_0 = new NCQAClaims_1_0_0(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Advanced_Illness = new Lazy<CqlValueSet>(this.Advanced_Illness_Value);
        __Dementia_Medications = new Lazy<CqlValueSet>(this.Dementia_Medications_Value);
        __ED = new Lazy<CqlValueSet>(this.ED_Value);
        __Frailty_Device = new Lazy<CqlValueSet>(this.Frailty_Device_Value);
        __Frailty_Diagnosis = new Lazy<CqlValueSet>(this.Frailty_Diagnosis_Value);
        __Frailty_Encounter = new Lazy<CqlValueSet>(this.Frailty_Encounter_Value);
        __Frailty_Symptom = new Lazy<CqlValueSet>(this.Frailty_Symptom_Value);
        __Nonacute_Inpatient = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient = new Lazy<CqlValueSet>(this.Outpatient_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Criteria_Indicating_Frailty = new Lazy<bool?>(this.Has_Criteria_Indicating_Frailty_Value);
        __Outpatient_Encounters_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Outpatient_Encounters_with_Advanced_Illness_Value);
        __Nonacute_Inpatient_Discharge_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value);
        __Outpatient_Encounters_or_Discharges_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value);
        __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service = new Lazy<bool?>(this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value);
        __Acute_Inpatient_Encounter_with_Advanced_Illness = new Lazy<bool?>(this.Acute_Inpatient_Encounter_with_Advanced_Illness_Value);
        __Acute_Inpatient_Discharge_with_Advanced_Illness = new Lazy<bool?>(this.Acute_Inpatient_Discharge_with_Advanced_Illness_Value);
        __Dementia_Medications_In_Year_Before_or_During_Measurement_Period = new Lazy<bool?>(this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }
    public NCQAEncounter_1_0_0 NCQAEncounter_1_0_0 { get; }
    public NCQAClaims_1_0_0 NCQAClaims_1_0_0 { get; }

    #endregion

    private CqlValueSet Acute_Inpatient_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Dementia_Medications_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet ED_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);

    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
    public CqlValueSet ED() => __ED.Value;

    private CqlValueSet Frailty_Device_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Observation_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Outpatient_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var l_ = this.Frailty_Device();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Observation>(l_, null);
		var n_ = (Observation FrailtyDeviceApplied) =>
		{
			var a_ = (FrailtyDeviceApplied?.Effective as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = this.Measurement_Period();

			return context?.Operators.Overlaps(b_, c_, null);
		};
		var o_ = context?.Operators.WhereOrNull<Observation>(m_, n_);
		var p_ = context?.Operators.ExistsInList<Observation>(o_);
		var q_ = this.Frailty_Diagnosis();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Condition>(q_, null);
		var s_ = NCQAStatus_1_0_0.Active_Condition(r_);
		var t_ = (Condition FrailtyDiagnosis) =>
		{
			var d_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			var e_ = this.Measurement_Period();

			return context?.Operators.Overlaps(d_, e_, null);
		};
		var u_ = context?.Operators.WhereOrNull<Condition>(s_, t_);
		var v_ = context?.Operators.ExistsInList<Condition>(u_);
		var w_ = context?.Operators.Or(p_, v_);
		var x_ = this.Frailty_Encounter();
		var y_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = NCQAStatus_1_0_0.Finished_Encounter(y_);
		var aa_ = (Encounter FrailtyEncounter) =>
		{
			var f_ = (FrailtyEncounter?.Period as object);
			var g_ = NCQAFHIRBase_1_0_0.Normalize_Interval(f_);
			var h_ = this.Measurement_Period();

			return context?.Operators.Overlaps(g_, h_, null);
		};
		var ab_ = context?.Operators.WhereOrNull<Encounter>(z_, aa_);
		var ac_ = context?.Operators.ExistsInList<Encounter>(ab_);
		var ad_ = context?.Operators.Or(w_, ac_);
		var ae_ = this.Frailty_Symptom();
		var af_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ae_, null);
		var ag_ = (Observation FrailtySymptom) =>
		{
			var i_ = (FrailtySymptom?.Effective as object);
			var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i_);
			var k_ = this.Measurement_Period();

			return context?.Operators.Overlaps(j_, k_, null);
		};
		var ah_ = context?.Operators.WhereOrNull<Observation>(af_, ag_);
		var ai_ = context?.Operators.ExistsInList<Observation>(ah_);

		return context?.Operators.Or(ad_, ai_);
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var u_ = this.Outpatient();
		var v_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(u_, null);
		var w_ = this.Observation();
		var x_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(w_, null);
		var y_ = context?.Operators.ListUnion<Encounter>(v_, x_);
		var z_ = this.ED();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = this.Telephone_Visits();
		var ac_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ab_, null);
		var ad_ = context?.Operators.ListUnion<Encounter>(aa_, ac_);
		var ae_ = context?.Operators.ListUnion<Encounter>(y_, ad_);
		var af_ = this.Online_Assessments();
		var ag_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(af_, null);
		var ah_ = this.Nonacute_Inpatient();
		var ai_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ah_, null);
		var aj_ = context?.Operators.ListUnion<Encounter>(ag_, ai_);
		var ak_ = context?.Operators.ListUnion<Encounter>(ae_, aj_);
		var al_ = NCQAStatus_1_0_0.Finished_Encounter(ak_);
		var am_ = (Encounter OutpatientEncounter) =>
		{
			var a_ = this.Advanced_Illness();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, null);
			var c_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, b_);
			var d_ = (OutpatientEncounter?.Period as object);
			var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.DateFrom(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.Start(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Quantity(1m, "year");
			var l_ = context?.Operators.Subtract(j_, k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.DateFrom(n_);
			var p_ = context?.Operators.Interval(l_, o_, true, true);
			var q_ = context?.Operators.ElementInInterval<CqlDate>(g_, p_, null);

			return context?.Operators.And(c_, q_);
		};
		var an_ = context?.Operators.WhereOrNull<Encounter>(al_, am_);
		var ao_ = (Encounter EncounterWithDiagnosis) =>
		{
			var r_ = (EncounterWithDiagnosis?.Period as object);
			var s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(r_);
			var t_ = context?.Operators.End(s_);

			return context?.Operators.DateFrom(t_);
		};

		return context?.Operators.SelectOrNull<Encounter, CqlDate>(an_, ao_);
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var m_ = context?.DataRetriever.RetrieveByValueSet<Claim>(null, null);
		var n_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(m_);
		var o_ = n_?.NonacuteInpatientDischarge;
		var p_ = this.Advanced_Illness();
		var q_ = context?.Operators.CreateValueSetFacade(p_);
		var r_ = (IEnumerable<CqlCode>)q_;
		var s_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(o_, r_);
		var t_ = s_?.ServicePeriod;
		var u_ = (CqlInterval<CqlDateTime> DischargeWithDiagnosis) =>
		{
			var a_ = context?.Operators.End(DischargeWithDiagnosis);
			var b_ = context?.Operators.DateFrom(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.DateFrom(d_);
			var f_ = context?.Operators.Quantity(1m, "year");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Interval(g_, j_, true, true);

			return context?.Operators.ElementInInterval<CqlDate>(b_, k_, null);
		};
		var v_ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(t_, u_);
		var w_ = (CqlInterval<CqlDateTime> InpatientDischarge) =>
		{
			var l_ = context?.Operators.End(InpatientDischarge);

			return context?.Operators.DateFrom(l_);
		};

		return context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(v_, w_);
	}

    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness() => __Nonacute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value()
    {
        if ((context?.Operators.Not((bool?)(context?.Operators.ListUnion<CqlDate>(this.Outpatient_Encounters_with_Advanced_Illness(), this.Nonacute_Inpatient_Discharge_with_Advanced_Illness()) == null)) ?? false))
		{
			var a__ = this.Outpatient_Encounters_with_Advanced_Illness();
			var b__ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

			return context?.Operators.ListUnion<CqlDate>(a__, b__);
		}
        else if ((this.Outpatient_Encounters_with_Advanced_Illness() == null))
            return this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
        else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() == null))
            return this.Outpatient_Encounters_with_Advanced_Illness();
        else
            return (null as IEnumerable<CqlDate>);
    }

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => __Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

    private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var g_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		var h_ = (CqlDate _OutpatientVisit1) => this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		var i_ = (CqlDate _OutpatientVisit1, CqlDate _OutpatientVisit2) =>
		{
			var a_ = _OutpatientVisit1;
			var b_ = _OutpatientVisit2;

			return new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = a_,
				OutpatientVisit2 = b_,
			};
		};
		var j_ = context?.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(g_, h_, i_);
		var k_ = (Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur) =>
		{
			var c_ = tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit2;
			var d_ = tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit1;
			var e_ = context?.Operators.Quantity(1m, "day");
			var f_ = context?.Operators.Add(d_, e_);

			return context?.Operators.SameOrAfter(c_, f_, null);
		};
		var l_ = context?.Operators.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(j_, k_);
		var m_ = (Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur) => tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit1;
		var n_ = context?.Operators.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(l_, m_);

		return context?.Operators.ExistsInList<CqlDate>(n_);
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var r_ = this.Acute_Inpatient();
		var s_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = NCQAStatus_1_0_0.Finished_Encounter(s_);
		var u_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Advanced_Illness();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, null);
			var c_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, b_);
			var d_ = (InpatientEncounter?.Period as object);
			var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.DateFrom(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.Start(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Quantity(1m, "year");
			var l_ = context?.Operators.Subtract(j_, k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.DateFrom(n_);
			var p_ = context?.Operators.Interval(l_, o_, true, true);
			var q_ = context?.Operators.ElementInInterval<CqlDate>(g_, p_, null);

			return context?.Operators.And(c_, q_);
		};
		var v_ = context?.Operators.WhereOrNull<Encounter>(t_, u_);

		return context?.Operators.ExistsInList<Encounter>(v_);
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => __Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var l_ = context?.DataRetriever.RetrieveByValueSet<Claim>(null, null);
		var m_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(l_);
		var n_ = m_?.AcuteInpatientDischarge;
		var o_ = this.Advanced_Illness();
		var p_ = context?.Operators.CreateValueSetFacade(o_);
		var q_ = (IEnumerable<CqlCode>)p_;
		var r_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(n_, q_);
		var s_ = r_?.ServicePeriod;
		var t_ = (CqlInterval<CqlDateTime> InpatientDischarge) =>
		{
			var a_ = context?.Operators.End(InpatientDischarge);
			var b_ = context?.Operators.DateFrom(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.DateFrom(d_);
			var f_ = context?.Operators.Quantity(1m, "year");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Interval(g_, j_, true, true);

			return context?.Operators.ElementInInterval<CqlDate>(b_, k_, null);
		};
		var u_ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(s_, t_);

		return context?.Operators.ExistsInList<CqlInterval<CqlDateTime>>(u_);
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => __Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var n_ = this.Dementia_Medications();
		var o_ = context?.DataRetriever.RetrieveByValueSet<MedicationDispense>(n_, null);
		var p_ = this.Dementia_Medications();
		var q_ = context?.DataRetriever.RetrieveByValueSet<MedicationDispense>(p_, null);
		var r_ = context?.Operators.ListUnion<MedicationDispense>(o_, q_);
		var s_ = NCQAStatus_1_0_0.Dispensed_Medication(r_);
		var t_ = (MedicationDispense DementiaMedDispensed) =>
		{
			var a_ = (DementiaMedDispensed?.WhenHandedOverElement as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.Start(b_);
			var d_ = context?.Operators.DateFrom(c_);
			var e_ = this.Measurement_Period();
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.DateFrom(f_);
			var h_ = context?.Operators.Quantity(1m, "year");
			var i_ = context?.Operators.Subtract(g_, h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.DateFrom(k_);
			var m_ = context?.Operators.Interval(i_, l_, true, true);

			return context?.Operators.ElementInInterval<CqlDate>(d_, m_, null);
		};
		var u_ = context?.Operators.WhereOrNull<MedicationDispense>(s_, t_);

		return context?.Operators.ExistsInList<MedicationDispense>(u_);
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.End(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval((int?)66, (int?)80, true, true);
		var h_ = context?.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty();
		var j_ = context?.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var m_ = context?.Operators.Or(k_, l_);
		var n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var o_ = context?.Operators.Or(m_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var q_ = context?.Operators.Or(o_, p_);
		var r_ = context?.Operators.And(j_, q_);
		var s_ = (this.Patient()?.BirthDateElement?.Value as object);
		var t_ = context?.Operators?.TypeConverter.Convert<CqlDate>(s_);
		var u_ = this.Measurement_Period();
		var v_ = context?.Operators.End(u_);
		var w_ = context?.Operators.DateFrom(v_);
		var x_ = context?.Operators.CalculateAgeAt(t_, w_, "year");
		var y_ = (x_ as object);
		var z_ = ((int?)81 as object);
		var aa_ = context?.Operators.GreaterOrEqual(y_, z_);
		var ab_ = this.Has_Criteria_Indicating_Frailty();
		var ac_ = context?.Operators.And(aa_, ab_);

		return context?.Operators.Or(r_, ac_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.End(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = (f_ as object);
		var h_ = ((int?)66 as object);
		var i_ = context?.Operators.GreaterOrEqual(g_, h_);
		var j_ = this.Has_Criteria_Indicating_Frailty();
		var k_ = context?.Operators.And(i_, j_);
		var l_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var m_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var n_ = context?.Operators.Or(l_, m_);
		var o_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var p_ = context?.Operators.Or(n_, o_);
		var q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var r_ = context?.Operators.Or(p_, q_);

		return context?.Operators.And(k_, r_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}