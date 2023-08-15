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

    private CqlValueSet Acute_Inpatient_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", 
			null);
    }

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", 
			null);
    }

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Dementia_Medications_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", 
			null);
    }

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet ED_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", 
			null);
    }

    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
    public CqlValueSet ED() => __ED.Value;

    private CqlValueSet Frailty_Device_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", 
			null);
    }

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", 
			null);
    }

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", 
			null);
    }

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", 
			null);
    }

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", 
			null);
    }

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Observation_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", 
			null);
    }

    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Online_Assessments_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", 
			null);
    }

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Outpatient_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", 
			null);
    }

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlValueSet Telephone_Visits_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", 
			null);
    }

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
    {
        var a_ = this.Frailty_Device();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> g_ = (FrailtyDeviceApplied) => 
        {
            var d_ = (FrailtyDeviceApplied?.Effective as object);
            var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
            var f_ = this.Measurement_Period();
            return context?.Operators.Overlaps(e_, 
				f_, 
				null);
        };
        var h_ = context?.Operators.WhereOrNull<Observation>(c_, 
			g_);
        var i_ = context?.Operators.ExistsInList<Observation>(h_);
        var j_ = this.Frailty_Diagnosis();
        var k_ = typeof(Condition).GetProperty("Code");
        var l_ = context?.DataRetriever.RetrieveByValueSet<Condition>(j_, 
			k_);
        var m_ = NCQAStatus_1_0_0.Active_Condition(l_);
        Func<Condition,bool?> p_ = (FrailtyDiagnosis) => 
        {
            var n_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
            var o_ = this.Measurement_Period();
            return context?.Operators.Overlaps(n_, 
				o_, 
				null);
        };
        var q_ = context?.Operators.WhereOrNull<Condition>(m_, 
			p_);
        var r_ = context?.Operators.ExistsInList<Condition>(q_);
        var s_ = context?.Operators.Or(i_, 
			r_);
        var t_ = this.Frailty_Encounter();
        var u_ = typeof(Encounter).GetProperty("Type");
        var v_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(t_, 
			u_);
        var w_ = NCQAStatus_1_0_0.Finished_Encounter(v_);
        Func<Encounter,bool?> aa_ = (FrailtyEncounter) => 
        {
            var x_ = (FrailtyEncounter?.Period as object);
            var y_ = NCQAFHIRBase_1_0_0.Normalize_Interval(x_);
            var z_ = this.Measurement_Period();
            return context?.Operators.Overlaps(y_, 
				z_, 
				null);
        };
        var ab_ = context?.Operators.WhereOrNull<Encounter>(w_, 
			aa_);
        var ac_ = context?.Operators.ExistsInList<Encounter>(ab_);
        var ad_ = context?.Operators.Or(s_, 
			ac_);
        var ae_ = this.Frailty_Symptom();
        var ag_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ae_, 
			b_);
        Func<Observation,bool?> ak_ = (FrailtySymptom) => 
        {
            var ah_ = (FrailtySymptom?.Effective as object);
            var ai_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ah_);
            var aj_ = this.Measurement_Period();
            return context?.Operators.Overlaps(ai_, 
				aj_, 
				null);
        };
        var al_ = context?.Operators.WhereOrNull<Observation>(ag_, 
			ak_);
        var am_ = context?.Operators.ExistsInList<Observation>(al_);
        return context?.Operators.Or(ad_, 
			am_);
    }
    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
    {
        var a_ = this.Outpatient();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Observation();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        var h_ = this.ED();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			b_);
        var k_ = this.Telephone_Visits();
        var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, 
			b_);
        var n_ = context?.Operators.ListUnion<Encounter>(j_, 
			m_);
        var o_ = context?.Operators.ListUnion<Encounter>(g_, 
			n_);
        var p_ = this.Online_Assessments();
        var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(p_, 
			b_);
        var s_ = this.Nonacute_Inpatient();
        var u_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(s_, 
			b_);
        var v_ = context?.Operators.ListUnion<Encounter>(r_, 
			u_);
        var w_ = context?.Operators.ListUnion<Encounter>(o_, 
			v_);
        var x_ = NCQAStatus_1_0_0.Finished_Encounter(w_);
        Func<Encounter,bool?> aq_ = (OutpatientEncounter) => 
        {
            var y_ = this.Advanced_Illness();
            var z_ = typeof(Condition).GetProperty("Code");
            var aa_ = context?.DataRetriever.RetrieveByValueSet<Condition>(y_, 
				z_);
            var ab_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, 
				aa_);
            var ac_ = (OutpatientEncounter?.Period as object);
            var ad_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ac_);
            var ae_ = context?.Operators.Start(ad_);
            var af_ = context?.Operators.DateFrom(ae_);
            var ag_ = this.Measurement_Period();
            var ah_ = context?.Operators.Start(ag_);
            var ai_ = context?.Operators.DateFrom(ah_);
            var aj_ = context?.Operators.Quantity(1m, 
				"year");
            var ak_ = context?.Operators.Subtract(ai_, 
				aj_);
            var am_ = context?.Operators.End(ag_);
            var an_ = context?.Operators.DateFrom(am_);
            var ao_ = context?.Operators.Interval(ak_, 
				an_, 
				true, 
				true);
            var ap_ = context?.Operators.ElementInInterval<CqlDate>(af_, 
				ao_, 
				null);
            return context?.Operators.And(ab_, 
				ap_);
        };
        var ar_ = context?.Operators.WhereOrNull<Encounter>(x_, 
			aq_);
        Func<Encounter,CqlDate> av_ = (EncounterWithDiagnosis) => 
        {
            var as_ = (EncounterWithDiagnosis?.Period as object);
            var at_ = NCQAFHIRBase_1_0_0.Normalize_Interval(as_);
            var au_ = context?.Operators.End(at_);
            return context?.Operators.DateFrom(au_);
        };
        return context?.Operators.SelectOrNull<Encounter, CqlDate>(ar_, 
			av_);
    }
    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
    {
        var a_ = (NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis((NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context?.DataRetriever.RetrieveByValueSet<Claim>(null, 
							null)))?.NonacuteInpatientDischarge, 
				((IEnumerable<CqlCode>)context?.Operators.CreateValueSetFacade(this.Advanced_Illness()))))?.ServicePeriod;
        Func<CqlInterval<CqlDateTime>,bool?> m_ = (DischargeWithDiagnosis) => 
        {
            var b_ = context?.Operators.End(DischargeWithDiagnosis);
            var c_ = context?.Operators.DateFrom(b_);
            var d_ = this.Measurement_Period();
            var e_ = context?.Operators.Start(d_);
            var f_ = context?.Operators.DateFrom(e_);
            var g_ = context?.Operators.Quantity(1m, 
				"year");
            var h_ = context?.Operators.Subtract(f_, 
				g_);
            var j_ = context?.Operators.End(d_);
            var k_ = context?.Operators.DateFrom(j_);
            var l_ = context?.Operators.Interval(h_, 
				k_, 
				true, 
				true);
            return context?.Operators.ElementInInterval<CqlDate>(c_, 
				l_, 
				null);
        };
        var n_ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(a_, 
			m_);
        Func<CqlInterval<CqlDateTime>,CqlDate> p_ = (InpatientDischarge) => 
        {
            var o_ = context?.Operators.End(InpatientDischarge);
            return context?.Operators.DateFrom(o_);
        };
        return context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(n_, 
			p_);
    }
    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness() => __Nonacute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value()
    {
        if ((context?.Operators.Not(((bool?)(context?.Operators.ListUnion<CqlDate>(this.Outpatient_Encounters_with_Advanced_Illness(), 
					this.Nonacute_Inpatient_Discharge_with_Advanced_Illness()) == null))) ?? false))
            {
                var a__ = this.Outpatient_Encounters_with_Advanced_Illness();
                var b__ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
                return context?.Operators.ListUnion<CqlDate>(a__, 
					b__);
            }
        else if ((this.Outpatient_Encounters_with_Advanced_Illness() == null))
            {
                return this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
            }
        else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() == null))
            {
                return this.Outpatient_Encounters_with_Advanced_Illness();
            }
        else 
            return (null as IEnumerable<CqlDate>);

    }

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => __Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

    private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
    {
        var a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
        Func<CqlDate,IEnumerable<CqlDate>> b_ = (_OutpatientVisit1) => 
        {
            return this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
        };
        Func<CqlDate,CqlDate,Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR> e_ = (_OutpatientVisit1, _OutpatientVisit2) => 
        {
            var c_ = _OutpatientVisit1;
            var d_ = _OutpatientVisit2;
            return new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = c_,
				OutpatientVisit2 = d_,
			};
        };
        var f_ = context?.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(a_, 
			b_, 
			e_);
        Func<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR,bool?> i_ = (tuple_eabfagdytzfyeinnhiyiteiur) => 
        {
            var g_ = context?.Operators.Quantity(1m, 
				"day");
            var h_ = context?.Operators.Add(tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit1, 
				g_);
            return context?.Operators.SameOrAfter(tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit2, 
				h_, 
				null);
        };
        var j_ = context?.Operators.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(f_, 
			i_);
        Func<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR,CqlDate> k_ = (tuple_eabfagdytzfyeinnhiyiteiur) => tuple_eabfagdytzfyeinnhiyiteiur?.OutpatientVisit1;
        var l_ = context?.Operators.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(j_, 
			k_);
        return context?.Operators.ExistsInList<CqlDate>(l_);
    }
    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
    {
        var a_ = this.Acute_Inpatient();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = NCQAStatus_1_0_0.Finished_Encounter(c_);
        Func<Encounter,bool?> w_ = (InpatientEncounter) => 
        {
            var e_ = this.Advanced_Illness();
            var f_ = typeof(Condition).GetProperty("Code");
            var g_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, 
				f_);
            var h_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, 
				g_);
            var i_ = (InpatientEncounter?.Period as object);
            var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i_);
            var k_ = context?.Operators.Start(j_);
            var l_ = context?.Operators.DateFrom(k_);
            var m_ = this.Measurement_Period();
            var n_ = context?.Operators.Start(m_);
            var o_ = context?.Operators.DateFrom(n_);
            var p_ = context?.Operators.Quantity(1m, 
				"year");
            var q_ = context?.Operators.Subtract(o_, 
				p_);
            var s_ = context?.Operators.End(m_);
            var t_ = context?.Operators.DateFrom(s_);
            var u_ = context?.Operators.Interval(q_, 
				t_, 
				true, 
				true);
            var v_ = context?.Operators.ElementInInterval<CqlDate>(l_, 
				u_, 
				null);
            return context?.Operators.And(h_, 
				v_);
        };
        var x_ = context?.Operators.WhereOrNull<Encounter>(d_, 
			w_);
        return context?.Operators.ExistsInList<Encounter>(x_);
    }
    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => __Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
    {
        var a_ = (NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis((NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context?.DataRetriever.RetrieveByValueSet<Claim>(null, 
							null)))?.AcuteInpatientDischarge, 
				((IEnumerable<CqlCode>)context?.Operators.CreateValueSetFacade(this.Advanced_Illness()))))?.ServicePeriod;
        Func<CqlInterval<CqlDateTime>,bool?> m_ = (InpatientDischarge) => 
        {
            var b_ = context?.Operators.End(InpatientDischarge);
            var c_ = context?.Operators.DateFrom(b_);
            var d_ = this.Measurement_Period();
            var e_ = context?.Operators.Start(d_);
            var f_ = context?.Operators.DateFrom(e_);
            var g_ = context?.Operators.Quantity(1m, 
				"year");
            var h_ = context?.Operators.Subtract(f_, 
				g_);
            var j_ = context?.Operators.End(d_);
            var k_ = context?.Operators.DateFrom(j_);
            var l_ = context?.Operators.Interval(h_, 
				k_, 
				true, 
				true);
            return context?.Operators.ElementInInterval<CqlDate>(c_, 
				l_, 
				null);
        };
        var n_ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(a_, 
			m_);
        return context?.Operators.ExistsInList<CqlInterval<CqlDateTime>>(n_);
    }
    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => __Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

    private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
    {
        var a_ = this.Dementia_Medications();
        var b_ = typeof(MedicationDispense).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationDispense>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<MedicationDispense>(c_, 
			c_);
        var h_ = NCQAStatus_1_0_0.Dispensed_Medication(g_);
        Func<MedicationDispense,bool?> v_ = (DementiaMedDispensed) => 
        {
            var i_ = (DementiaMedDispensed?.WhenHandedOverElement as object);
            var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i_);
            var k_ = context?.Operators.Start(j_);
            var l_ = context?.Operators.DateFrom(k_);
            var m_ = this.Measurement_Period();
            var n_ = context?.Operators.Start(m_);
            var o_ = context?.Operators.DateFrom(n_);
            var p_ = context?.Operators.Quantity(1m, 
				"year");
            var q_ = context?.Operators.Subtract(o_, 
				p_);
            var s_ = context?.Operators.End(m_);
            var t_ = context?.Operators.DateFrom(s_);
            var u_ = context?.Operators.Interval(q_, 
				t_, 
				true, 
				true);
            return context?.Operators.ElementInInterval<CqlDate>(l_, 
				u_, 
				null);
        };
        var w_ = context?.Operators.WhereOrNull<MedicationDispense>(h_, 
			v_);
        return context?.Operators.ExistsInList<MedicationDispense>(w_);
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
        var f_ = context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year");
        var g_ = context?.Operators.Interval(((int?)66), 
			((int?)80), 
			true, 
			true);
        var h_ = context?.Operators.ElementInInterval<int?>(f_, 
			g_, 
			null);
        var i_ = this.Has_Criteria_Indicating_Frailty();
        var j_ = context?.Operators.And(h_, 
			i_);
        var k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
        var l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
        var m_ = context?.Operators.Or(k_, 
			l_);
        var n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
        var o_ = context?.Operators.Or(m_, 
			n_);
        var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
        var q_ = context?.Operators.Or(o_, 
			p_);
        var r_ = context?.Operators.And(j_, 
			q_);
        var s_ = (context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year") as object);
        var y_ = (((int?)81) as object);
        var z_ = context?.Operators.GreaterOrEqual(s_, 
			y_);
        var ab_ = context?.Operators.And(z_, 
			i_);
        return context?.Operators.Or(r_, 
			ab_);
    }
    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
    {
        var b_ = (this.Patient()?.BirthDateElement?.Value as object);
        var c_ = context?.Operators?.TypeConverter.Convert<CqlDate>(b_);
        var d_ = this.Measurement_Period();
        var e_ = context?.Operators.End(d_);
        var f_ = context?.Operators.DateFrom(e_);
        var a_ = (context?.Operators.CalculateAgeAt(c_, 
			f_, 
			"year") as object);
        var g_ = (((int?)66) as object);
        var h_ = context?.Operators.GreaterOrEqual(a_, 
			g_);
        var i_ = this.Has_Criteria_Indicating_Frailty();
        var j_ = context?.Operators.And(h_, 
			i_);
        var k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
        var l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
        var m_ = context?.Operators.Or(k_, 
			l_);
        var n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
        var o_ = context?.Operators.Or(m_, 
			n_);
        var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
        var q_ = context?.Operators.Or(o_, 
			p_);
        return context?.Operators.And(j_, 
			q_);
    }
    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}