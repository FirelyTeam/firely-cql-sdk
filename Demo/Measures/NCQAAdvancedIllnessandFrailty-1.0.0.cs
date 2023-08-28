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

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FrailtyDeviceApplied)
		{
			var ao_ = FrailtyDeviceApplied.Effective;
			var ap_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ao_);
			var aq_ = this.Measurement_Period();
			var ar_ = context.Operators;
			var as_ = ar_.Overlaps(ap_, aq_, null);

			return as_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);
		var i_ = this.Frailty_Diagnosis();
		var k_ = b_.RetrieveByValueSet<Condition>(i_, null);
		var l_ = NCQAStatus_1_0_0.Active_Condition(k_);
		bool? m_(Condition FrailtyDiagnosis)
		{
			var at_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			var au_ = this.Measurement_Period();
			var av_ = context.Operators;
			var aw_ = av_.Overlaps(at_, au_, null);

			return aw_;
		};
		var o_ = e_.WhereOrNull<Condition>(l_, m_);
		var q_ = e_.ExistsInList<Condition>(o_);
		var s_ = e_.Or(h_, q_);
		var t_ = this.Frailty_Encounter();
		var v_ = b_.RetrieveByValueSet<Encounter>(t_, null);
		var w_ = NCQAStatus_1_0_0.Finished_Encounter(v_);
		bool? x_(Encounter FrailtyEncounter)
		{
			var ax_ = FrailtyEncounter.Period;
			var ay_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ax_);
			var az_ = this.Measurement_Period();
			var ba_ = context.Operators;
			var bb_ = ba_.Overlaps(ay_, az_, null);

			return bb_;
		};
		var z_ = e_.WhereOrNull<Encounter>(w_, x_);
		var ab_ = e_.ExistsInList<Encounter>(z_);
		var ad_ = e_.Or(s_, ab_);
		var ae_ = this.Frailty_Symptom();
		var ag_ = b_.RetrieveByValueSet<Observation>(ae_, null);
		bool? ah_(Observation FrailtySymptom)
		{
			var bc_ = FrailtySymptom.Effective;
			var bd_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bc_);
			var be_ = this.Measurement_Period();
			var bf_ = context.Operators;
			var bg_ = bf_.Overlaps(bd_, be_, null);

			return bg_;
		};
		var aj_ = e_.WhereOrNull<Observation>(ag_, ah_);
		var al_ = e_.ExistsInList<Observation>(aj_);
		var an_ = e_.Or(ad_, al_);

		return an_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Observation();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.ED();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Telephone_Visits();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		var s_ = this.Online_Assessments();
		var u_ = b_.RetrieveByValueSet<Encounter>(s_, null);
		var v_ = this.Nonacute_Inpatient();
		var x_ = b_.RetrieveByValueSet<Encounter>(v_, null);
		var z_ = g_.ListUnion<Encounter>(u_, x_);
		var ab_ = g_.ListUnion<Encounter>(r_, z_);
		var ac_ = NCQAStatus_1_0_0.Finished_Encounter(ab_);
		bool? ad_(Encounter OutpatientEncounter)
		{
			var aj_ = this.Advanced_Illness();
			var ak_ = context.DataRetriever;
			var al_ = ak_.RetrieveByValueSet<Condition>(aj_, null);
			var am_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, al_);
			var an_ = OutpatientEncounter.Period;
			var ao_ = NCQAFHIRBase_1_0_0.Normalize_Interval(an_);
			var ap_ = context.Operators;
			var aq_ = ap_.Start(ao_);
			var as_ = ap_.DateFrom(aq_);
			var at_ = this.Measurement_Period();
			var av_ = ap_.Start(at_);
			var ax_ = ap_.DateFrom(av_);
			var az_ = ap_.Quantity(1m, "year");
			var bb_ = ap_.Subtract(ax_, az_);
			var be_ = ap_.End(at_);
			var bg_ = ap_.DateFrom(be_);
			var bi_ = ap_.Interval(bb_, bg_, true, true);
			var bk_ = ap_.ElementInInterval<CqlDate>(as_, bi_, null);
			var bm_ = ap_.And(am_, bk_);

			return bm_;
		};
		var af_ = g_.WhereOrNull<Encounter>(ac_, ad_);
		CqlDate ag_(Encounter EncounterWithDiagnosis)
		{
			var bn_ = EncounterWithDiagnosis.Period;
			var bo_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bn_);
			var bp_ = context.Operators;
			var bq_ = bp_.End(bo_);
			var bs_ = bp_.DateFrom(bq_);

			return bs_;
		};
		var ai_ = g_.SelectOrNull<Encounter, CqlDate>(af_, ag_);

		return ai_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Claim>(null, null);
		var c_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(b_);
		var d_ = c_.NonacuteInpatientDischarge;
		var e_ = this.Advanced_Illness();
		var f_ = context.Operators;
		var g_ = f_.CreateValueSetFacade(e_);
		var h_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(d_, (IEnumerable<CqlCode>)g_);
		var i_ = h_.ServicePeriod;
		bool? j_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			var p_ = context.Operators;
			var q_ = p_.End(DischargeWithDiagnosis);
			var s_ = p_.DateFrom(q_);
			var t_ = this.Measurement_Period();
			var v_ = p_.Start(t_);
			var x_ = p_.DateFrom(v_);
			var z_ = p_.Quantity(1m, "year");
			var ab_ = p_.Subtract(x_, z_);
			var ae_ = p_.End(t_);
			var ag_ = p_.DateFrom(ae_);
			var ai_ = p_.Interval(ab_, ag_, true, true);
			var ak_ = p_.ElementInInterval<CqlDate>(s_, ai_, null);

			return ak_;
		};
		var l_ = f_.WhereOrNull<CqlInterval<CqlDateTime>>(i_, j_);
		CqlDate m_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var al_ = context.Operators;
			var am_ = al_.End(InpatientDischarge);
			var ao_ = al_.DateFrom(am_);

			return ao_;
		};
		var o_ = f_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(l_, m_);

		return o_;
	}

    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness() => __Nonacute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value()
    {
        if ((context.Operators.Not((bool?)(context.Operators.ListUnion<CqlDate>(this.Outpatient_Encounters_with_Advanced_Illness(), this.Nonacute_Inpatient_Discharge_with_Advanced_Illness()) == null)) ?? false))
		{
			var a__ = this.Outpatient_Encounters_with_Advanced_Illness();
			var b__ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
			var c__ = context.Operators;
			var d__ = c__.ListUnion<CqlDate>(a__, b__);

			return d__;
		}
        else if ((this.Outpatient_Encounters_with_Advanced_Illness() == null))
		{
			var a__ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

			return a__;
		}
        else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() == null))
		{
			var a__ = this.Outpatient_Encounters_with_Advanced_Illness();

			return a__;
		}
        else
		{
			IEnumerable<CqlDate> a__ = null;

			return (a__ as IEnumerable<CqlDate>);
		}
    }

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => __Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

    private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		IEnumerable<CqlDate> b_(CqlDate _OutpatientVisit1)
		{
			var n_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();

			return n_;
		};
		Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR c_(CqlDate _OutpatientVisit1, CqlDate _OutpatientVisit2)
		{
			var o_ = new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = _OutpatientVisit1,
				OutpatientVisit2 = _OutpatientVisit2,
			};

			return o_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(a_, b_, c_);
		bool? f_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var p_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit2;
			var q_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;
			var r_ = context.Operators;
			var s_ = r_.Quantity(1m, "day");
			var u_ = r_.Add(q_, s_);
			var w_ = r_.SameOrAfter(p_, u_, null);

			return w_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(e_, f_);
		CqlDate i_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var x_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;

			return x_;
		};
		var k_ = d_.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(h_, i_);
		var m_ = d_.ExistsInList<CqlDate>(k_);

		return m_;
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = NCQAStatus_1_0_0.Finished_Encounter(c_);
		bool? e_(Encounter InpatientEncounter)
		{
			var j_ = this.Advanced_Illness();
			var k_ = context.DataRetriever;
			var l_ = k_.RetrieveByValueSet<Condition>(j_, null);
			var m_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, l_);
			var n_ = InpatientEncounter.Period;
			var o_ = NCQAFHIRBase_1_0_0.Normalize_Interval(n_);
			var p_ = context.Operators;
			var q_ = p_.Start(o_);
			var s_ = p_.DateFrom(q_);
			var t_ = this.Measurement_Period();
			var v_ = p_.Start(t_);
			var x_ = p_.DateFrom(v_);
			var z_ = p_.Quantity(1m, "year");
			var ab_ = p_.Subtract(x_, z_);
			var ae_ = p_.End(t_);
			var ag_ = p_.DateFrom(ae_);
			var ai_ = p_.Interval(ab_, ag_, true, true);
			var ak_ = p_.ElementInInterval<CqlDate>(s_, ai_, null);
			var am_ = p_.And(m_, ak_);

			return am_;
		};
		var f_ = context.Operators;
		var g_ = f_.WhereOrNull<Encounter>(d_, e_);
		var i_ = f_.ExistsInList<Encounter>(g_);

		return i_;
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => __Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Claim>(null, null);
		var c_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(b_);
		var d_ = c_.AcuteInpatientDischarge;
		var e_ = this.Advanced_Illness();
		var f_ = context.Operators;
		var g_ = f_.CreateValueSetFacade(e_);
		var h_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(d_, (IEnumerable<CqlCode>)g_);
		var i_ = h_.ServicePeriod;
		bool? j_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var o_ = context.Operators;
			var p_ = o_.End(InpatientDischarge);
			var r_ = o_.DateFrom(p_);
			var s_ = this.Measurement_Period();
			var u_ = o_.Start(s_);
			var w_ = o_.DateFrom(u_);
			var y_ = o_.Quantity(1m, "year");
			var aa_ = o_.Subtract(w_, y_);
			var ad_ = o_.End(s_);
			var af_ = o_.DateFrom(ad_);
			var ah_ = o_.Interval(aa_, af_, true, true);
			var aj_ = o_.ElementInInterval<CqlDate>(r_, ah_, null);

			return aj_;
		};
		var l_ = f_.WhereOrNull<CqlInterval<CqlDateTime>>(i_, j_);
		var n_ = f_.ExistsInList<CqlInterval<CqlDateTime>>(l_);

		return n_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => __Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = this.Dementia_Medications();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationDispense>(a_, null);
		var f_ = b_.RetrieveByValueSet<MedicationDispense>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<MedicationDispense>(c_, f_);
		var i_ = NCQAStatus_1_0_0.Dispensed_Medication(h_);
		bool? j_(MedicationDispense DementiaMedDispensed)
		{
			var o_ = DementiaMedDispensed.WhenHandedOverElement;
			var p_ = NCQAFHIRBase_1_0_0.Normalize_Interval(o_);
			var q_ = context.Operators;
			var r_ = q_.Start(p_);
			var t_ = q_.DateFrom(r_);
			var u_ = this.Measurement_Period();
			var w_ = q_.Start(u_);
			var y_ = q_.DateFrom(w_);
			var aa_ = q_.Quantity(1m, "year");
			var ac_ = q_.Subtract(y_, aa_);
			var af_ = q_.End(u_);
			var ah_ = q_.DateFrom(af_);
			var aj_ = q_.Interval(ac_, ah_, true, true);
			var al_ = q_.ElementInInterval<CqlDate>(t_, aj_, null);

			return al_;
		};
		var l_ = g_.WhereOrNull<MedicationDispense>(i_, j_);
		var n_ = g_.ExistsInList<MedicationDispense>(l_);

		return n_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.End(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.Interval((int?)66, (int?)80, true, true);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var r_ = this.Has_Criteria_Indicating_Frailty();
		var t_ = d_.And(q_, r_);
		var u_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var v_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var x_ = d_.Or(u_, v_);
		var y_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var aa_ = d_.Or(x_, y_);
		var ab_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ad_ = d_.Or(aa_, ab_);
		var af_ = d_.And(t_, ad_);
		var ah_ = a_.BirthDateElement;
		var ai_ = ah_.Value;
		var ak_ = d_.TypeConverter;
		var al_ = ak_.Convert<CqlDate>(ai_);
		var ao_ = d_.End(g_);
		var aq_ = d_.DateFrom(ao_);
		var as_ = d_.CalculateAgeAt(al_, aq_, "year");
		var au_ = d_.GreaterOrEqual(as_, (int?)81);
		var ax_ = d_.And(au_, r_);
		var az_ = d_.Or(af_, ax_);

		return az_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.End(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.GreaterOrEqual(m_, (int?)66);
		var p_ = this.Has_Criteria_Indicating_Frailty();
		var r_ = d_.And(o_, p_);
		var s_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var t_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var v_ = d_.Or(s_, t_);
		var w_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var y_ = d_.Or(v_, w_);
		var z_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ab_ = d_.Or(y_, z_);
		var ad_ = d_.And(r_, ab_);

		return ad_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}