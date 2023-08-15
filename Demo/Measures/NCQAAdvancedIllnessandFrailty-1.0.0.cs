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
        var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			null);
        Func<Observation,bool?> f_ = (FrailtyDeviceApplied) => 
        {
            var c_ = (FrailtyDeviceApplied?.Effective as object);
            var d_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_);
            var e_ = this.Measurement_Period();
            return context?.Operators.Overlaps(d_, 
				e_, 
				null);
        };
        var g_ = context?.Operators.WhereOrNull<Observation>(b_, 
			f_);
        var h_ = context?.Operators.ExistsInList<Observation>(g_);
        var i_ = this.Frailty_Diagnosis();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(i_, 
			null);
        var k_ = NCQAStatus_1_0_0.Active_Condition(j_);
        Func<Condition,bool?> n_ = (FrailtyDiagnosis) => 
        {
            var l_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
            var m_ = this.Measurement_Period();
            return context?.Operators.Overlaps(l_, 
				m_, 
				null);
        };
        var o_ = context?.Operators.WhereOrNull<Condition>(k_, 
			n_);
        var p_ = context?.Operators.ExistsInList<Condition>(o_);
        var q_ = context?.Operators.Or(h_, 
			p_);
        var r_ = this.Frailty_Encounter();
        var s_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(r_, 
			null);
        var t_ = NCQAStatus_1_0_0.Finished_Encounter(s_);
        Func<Encounter,bool?> x_ = (FrailtyEncounter) => 
        {
            var u_ = (FrailtyEncounter?.Period as object);
            var v_ = NCQAFHIRBase_1_0_0.Normalize_Interval(u_);
            var w_ = this.Measurement_Period();
            return context?.Operators.Overlaps(v_, 
				w_, 
				null);
        };
        var y_ = context?.Operators.WhereOrNull<Encounter>(t_, 
			x_);
        var z_ = context?.Operators.ExistsInList<Encounter>(y_);
        var aa_ = context?.Operators.Or(q_, 
			z_);
        var ab_ = this.Frailty_Symptom();
        var ac_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ab_, 
			null);
        Func<Observation,bool?> ag_ = (FrailtySymptom) => 
        {
            var ad_ = (FrailtySymptom?.Effective as object);
            var ae_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ad_);
            var af_ = this.Measurement_Period();
            return context?.Operators.Overlaps(ae_, 
				af_, 
				null);
        };
        var ah_ = context?.Operators.WhereOrNull<Observation>(ac_, 
			ag_);
        var ai_ = context?.Operators.ExistsInList<Observation>(ah_);
        return context?.Operators.Or(aa_, 
			ai_);
    }
    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
    {
        var a_ = this.Outpatient();
        var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
        var c_ = this.Observation();
        var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, 
			null);
        var e_ = context?.Operators.ListUnion<Encounter>(b_, 
			d_);
        var f_ = this.ED();
        var g_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(f_, 
			null);
        var h_ = this.Telephone_Visits();
        var i_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			null);
        var j_ = context?.Operators.ListUnion<Encounter>(g_, 
			i_);
        var k_ = context?.Operators.ListUnion<Encounter>(e_, 
			j_);
        var l_ = this.Online_Assessments();
        var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(l_, 
			null);
        var n_ = this.Nonacute_Inpatient();
        var o_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(n_, 
			null);
        var p_ = context?.Operators.ListUnion<Encounter>(m_, 
			o_);
        var q_ = context?.Operators.ListUnion<Encounter>(k_, 
			p_);
        var r_ = NCQAStatus_1_0_0.Finished_Encounter(q_);
        Func<Encounter,bool?> aj_ = (OutpatientEncounter) => 
        {
            var s_ = this.Advanced_Illness();
            var t_ = context?.DataRetriever.RetrieveByValueSet<Condition>(s_, 
				null);
            var u_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, 
				t_);
            var v_ = (OutpatientEncounter?.Period as object);
            var w_ = NCQAFHIRBase_1_0_0.Normalize_Interval(v_);
            var x_ = context?.Operators.Start(w_);
            var y_ = context?.Operators.DateFrom(x_);
            var z_ = this.Measurement_Period();
            var aa_ = context?.Operators.Start(z_);
            var ab_ = context?.Operators.DateFrom(aa_);
            var ac_ = context?.Operators.Quantity(1m, 
				"year");
            var ad_ = context?.Operators.Subtract(ab_, 
				ac_);
            var af_ = context?.Operators.End(z_);
            var ag_ = context?.Operators.DateFrom(af_);
            var ah_ = context?.Operators.Interval(ad_, 
				ag_, 
				true, 
				true);
            var ai_ = context?.Operators.ElementInInterval<CqlDate>(y_, 
				ah_, 
				null);
            return context?.Operators.And(u_, 
				ai_);
        };
        var ak_ = context?.Operators.WhereOrNull<Encounter>(r_, 
			aj_);
        Func<Encounter,CqlDate> ao_ = (EncounterWithDiagnosis) => 
        {
            var al_ = (EncounterWithDiagnosis?.Period as object);
            var am_ = NCQAFHIRBase_1_0_0.Normalize_Interval(al_);
            var an_ = context?.Operators.End(am_);
            return context?.Operators.DateFrom(an_);
        };
        return context?.Operators.SelectOrNull<Encounter, CqlDate>(ak_, 
			ao_);
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
        var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
        var c_ = NCQAStatus_1_0_0.Finished_Encounter(b_);
        Func<Encounter,bool?> u_ = (InpatientEncounter) => 
        {
            var d_ = this.Advanced_Illness();
            var e_ = context?.DataRetriever.RetrieveByValueSet<Condition>(d_, 
				null);
            var f_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, 
				e_);
            var g_ = (InpatientEncounter?.Period as object);
            var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
            var i_ = context?.Operators.Start(h_);
            var j_ = context?.Operators.DateFrom(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.Start(k_);
            var m_ = context?.Operators.DateFrom(l_);
            var n_ = context?.Operators.Quantity(1m, 
				"year");
            var o_ = context?.Operators.Subtract(m_, 
				n_);
            var q_ = context?.Operators.End(k_);
            var r_ = context?.Operators.DateFrom(q_);
            var s_ = context?.Operators.Interval(o_, 
				r_, 
				true, 
				true);
            var t_ = context?.Operators.ElementInInterval<CqlDate>(j_, 
				s_, 
				null);
            return context?.Operators.And(f_, 
				t_);
        };
        var v_ = context?.Operators.WhereOrNull<Encounter>(c_, 
			u_);
        return context?.Operators.ExistsInList<Encounter>(v_);
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
        var b_ = context?.DataRetriever.RetrieveByValueSet<MedicationDispense>(a_, 
			null);
        var e_ = context?.Operators.ListUnion<MedicationDispense>(b_, 
			b_);
        var f_ = NCQAStatus_1_0_0.Dispensed_Medication(e_);
        Func<MedicationDispense,bool?> t_ = (DementiaMedDispensed) => 
        {
            var g_ = (DementiaMedDispensed?.WhenHandedOverElement as object);
            var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
            var i_ = context?.Operators.Start(h_);
            var j_ = context?.Operators.DateFrom(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.Start(k_);
            var m_ = context?.Operators.DateFrom(l_);
            var n_ = context?.Operators.Quantity(1m, 
				"year");
            var o_ = context?.Operators.Subtract(m_, 
				n_);
            var q_ = context?.Operators.End(k_);
            var r_ = context?.Operators.DateFrom(q_);
            var s_ = context?.Operators.Interval(o_, 
				r_, 
				true, 
				true);
            return context?.Operators.ElementInInterval<CqlDate>(j_, 
				s_, 
				null);
        };
        var u_ = context?.Operators.WhereOrNull<MedicationDispense>(f_, 
			t_);
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