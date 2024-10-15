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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public partial class NCQAAdvancedIllnessandFrailty_1_0_0 : ILibrary, ISingleton<NCQAAdvancedIllnessandFrailty_1_0_0>
{
private NCQAAdvancedIllnessandFrailty_1_0_0() {}

public static NCQAAdvancedIllnessandFrailty_1_0_0 Instance { get; } = new();

    #region Library Members
    public string Name => "NCQAAdvancedIllnessandFrailty";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAEncounter_1_0_0.Instance, NCQAClaims_1_0_0.Instance];
    #endregion Library Members

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
	public CqlValueSet Acute_Inpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", default);


    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
	public CqlValueSet Advanced_Illness(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", default);


    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
	public CqlValueSet Dementia_Medications(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", default);


    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
	public CqlValueSet ED(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", default);


    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
	public CqlValueSet Frailty_Device(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", default);


    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
	public CqlValueSet Frailty_Diagnosis(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", default);


    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
	public CqlValueSet Frailty_Encounter(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", default);


    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
	public CqlValueSet Frailty_Symptom(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", default);


    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
	public CqlValueSet Nonacute_Inpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", default);


    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
	public CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", default);


    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
	public CqlValueSet Outpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", default);


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
	{
		CqlValueSet a_ = this.Frailty_Device(context);
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation FrailtyDeviceApplied)
		{
			DataType z_ = FrailtyDeviceApplied?.Effective;
			CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, z_);
			CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
			bool? ac_ = context.Operators.Overlaps(aa_, ab_, default);

			return ac_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Frailty_Diagnosis(context);
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> h_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> ad_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
			bool? af_ = context.Operators.Overlaps(ad_, ae_, default);

			return af_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);
		bool? l_ = context.Operators.Or(e_, k_);
		CqlValueSet m_ = this.Frailty_Encounter(context);
		IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> o_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			Period ag_ = FrailtyEncounter?.Period;
			CqlInterval<CqlDateTime> ah_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ag_ as object);
			CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
			bool? aj_ = context.Operators.Overlaps(ah_, ai_, default);

			return aj_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.Or(l_, r_);
		CqlValueSet t_ = this.Frailty_Symptom(context);
		IEnumerable<Observation> u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? v_(Observation FrailtySymptom)
		{
			DataType ak_ = FrailtySymptom?.Effective;
			CqlInterval<CqlDateTime> al_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ak_);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
			bool? an_ = context.Operators.Overlaps(al_, am_, default);

			return an_;
		};
		IEnumerable<Observation> w_ = context.Operators.Where<Observation>(u_, v_);
		bool? x_ = context.Operators.Exists<Observation>(w_);
		bool? y_ = context.Operators.Or(s_, x_);

		return y_;
	}


    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
	{
		CqlValueSet a_ = this.Outpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet c_ = this.Observation(context);
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.ED(context);
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet h_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Online_Assessments(context);
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet n_ = this.Nonacute_Inpatient(context);
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		IEnumerable<Encounter> r_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			CqlValueSet w_ = this.Advanced_Illness(context);
			IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? y_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, x_);
			Period z_ = OutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, z_ as object);
			CqlDateTime ab_ = context.Operators.Start(aa_);
			CqlDate ac_ = context.Operators.DateFrom(ab_);
			CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
			CqlDateTime ae_ = context.Operators.Start(ad_);
			CqlDate af_ = context.Operators.DateFrom(ae_);
			CqlQuantity ag_ = context.Operators.Quantity(1m, "year");
			CqlDate ah_ = context.Operators.Subtract(af_, ag_);
			CqlDateTime aj_ = context.Operators.End(ad_);
			CqlDate ak_ = context.Operators.DateFrom(aj_);
			CqlInterval<CqlDate> al_ = context.Operators.Interval(ah_, ak_, true, true);
			bool? am_ = context.Operators.In<CqlDate>(ac_, al_, default);
			bool? an_ = context.Operators.And(y_, am_);

			return an_;
		};
		IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			Period ao_ = EncounterWithDiagnosis?.Period;
			CqlInterval<CqlDateTime> ap_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ao_ as object);
			CqlDateTime aq_ = context.Operators.End(ap_);
			CqlDate ar_ = context.Operators.DateFrom(aq_);

			return ar_;
		};
		IEnumerable<CqlDate> v_ = context.Operators.Select<Encounter, CqlDate>(t_, u_);

		return v_;
	}


    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
	public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
	{
		IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
		(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
		IEnumerable<Claim> c_ = b_?.NonacuteInpatientDischarge;
		CqlValueSet d_ = this.Advanced_Illness(context);
		IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
		(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
		IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;
		bool? h_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			CqlDateTime l_ = context.Operators.End(DischargeWithDiagnosis);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);

			return w_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);
		CqlDate j_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime x_ = context.Operators.End(InpatientDischarge);
			CqlDate y_ = context.Operators.DateFrom(x_);

			return y_;
		};
		IEnumerable<CqlDate> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(i_, j_);

		return k_;
	}


    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
	{
		IEnumerable<CqlDate> a_()
		{
			bool b_()
			{
				IEnumerable<CqlDate> c_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
				IEnumerable<CqlDate> d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
				IEnumerable<CqlDate> e_ = context.Operators.Union<CqlDate>(c_, d_);
				bool? f_ = context.Operators.Not((bool?)(e_ is null));

				return f_ ?? false;
			};
			if (b_())
			{
				IEnumerable<CqlDate> g_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
				IEnumerable<CqlDate> h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
				IEnumerable<CqlDate> i_ = context.Operators.Union<CqlDate>(g_, h_);

				return i_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
			{
				IEnumerable<CqlDate> j_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

				return j_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
			{
				IEnumerable<CqlDate> k_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

				return k_;
			}
			else
			{
				return null as IEnumerable<CqlDate>;
			}
		};

		return a_();
	}


    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? k_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(c_, d_);
		bool? f_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, m_, default);

			return n_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(e_, f_);
		CqlDate h_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) => 
			tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
		IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(g_, h_);
		bool? j_ = context.Operators.Exists<CqlDate>(i_);

		return j_;
	}


    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
	public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
	{
		CqlValueSet a_ = this.Acute_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> c_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, b_);
		bool? d_(Encounter InpatientEncounter)
		{
			CqlValueSet g_ = this.Advanced_Illness(context);
			IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? i_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, h_);
			Period j_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, j_ as object);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);
			bool? x_ = context.Operators.And(i_, w_);

			return x_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		bool? f_ = context.Operators.Exists<Encounter>(e_);

		return f_;
	}


    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
	{
		IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
		(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
		IEnumerable<Claim> c_ = b_?.AcuteInpatientDischarge;
		CqlValueSet d_ = this.Advanced_Illness(context);
		IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
		(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
		IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;
		bool? h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime k_ = context.Operators.End(InpatientDischarge);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDate q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(m_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDate>(l_, u_, default);

			return v_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);
		bool? j_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(i_);

		return j_;
	}


    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Dementia_Medications(context);
		IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
		IEnumerable<MedicationDispense> d_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
		IEnumerable<MedicationDispense> e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			FhirDateTime j_ = DementiaMedDispensed?.WhenHandedOverElement;
			CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, j_ as object);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);

			return w_;
		};
		IEnumerable<MedicationDispense> h_ = context.Operators.Where<MedicationDispense>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationDispense>(h_);

		return i_;
	}


    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
		bool? l_ = context.Operators.And(j_, k_);
		bool? m_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		bool? n_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
		bool? q_ = context.Operators.Or(o_, p_);
		bool? r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
		bool? s_ = context.Operators.Or(q_, r_);
		bool? t_ = context.Operators.And(l_, s_);
		Date v_ = a_?.BirthDateElement;
		string w_ = v_?.Value;
		CqlDate x_ = context.Operators.ConvertStringToDate(w_);
		CqlDateTime z_ = context.Operators.End(e_);
		CqlDate aa_ = context.Operators.DateFrom(z_);
		int? ab_ = context.Operators.CalculateAgeAt(x_, aa_, "year");
		bool? ac_ = context.Operators.GreaterOrEqual(ab_, 81);
		bool? ae_ = context.Operators.And(ac_, k_);
		bool? af_ = context.Operators.Or(t_, ae_);

		return af_;
	}


    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
		bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
		bool? k_ = context.Operators.And(i_, j_);
		bool? l_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		bool? m_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
		bool? n_ = context.Operators.Or(l_, m_);
		bool? o_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
		bool? p_ = context.Operators.Or(n_, o_);
		bool? q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
		bool? r_ = context.Operators.Or(p_, q_);
		bool? s_ = context.Operators.And(k_, r_);

		return s_;
	}

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);
}
