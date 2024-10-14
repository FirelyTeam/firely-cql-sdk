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
[CqlLibrary("GlobalMalnutritionCompositeFHIR", "0.1.000")]
public partial class GlobalMalnutritionCompositeFHIR_0_1_000 : ILibrary, ISingleton<GlobalMalnutritionCompositeFHIR_0_1_000>
{
    private GlobalMalnutritionCompositeFHIR_0_1_000() {}

    public static GlobalMalnutritionCompositeFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "GlobalMalnutritionCompositeFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, QICoreCommon_2_0_000.Instance, CQMCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);


    [CqlDeclaration("Hospital Dietitian Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91")]
	public CqlValueSet Hospital_Dietitian_Referral	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", default);


    [CqlDeclaration("Malnutrition Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55")]
	public CqlValueSet Malnutrition_Diagnosis	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", default);


    [CqlDeclaration("Malnutrition Risk Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92")]
	public CqlValueSet Malnutrition_Risk_Screening	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", default);


    [CqlDeclaration("Malnutrition Screening At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38")]
	public CqlValueSet Malnutrition_Screening_At_Risk_Result	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38", default);


    [CqlDeclaration("Malnutrition Screening Not At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34")]
	public CqlValueSet Malnutrition_Screening_Not_At_Risk_Result	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", default);


    [CqlDeclaration("Nutrition Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21")]
	public CqlValueSet Nutrition_Assessment	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", default);


    [CqlDeclaration("Nutrition Assessment Status Moderately Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44")]
	public CqlValueSet Nutrition_Assessment_Status_Moderately_Malnourished	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44", default);


    [CqlDeclaration("Nutrition Assessment Status Not or Mildly Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48")]
	public CqlValueSet Nutrition_Assessment_Status_Not_or_Mildly_Malnourished	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48", default);


    [CqlDeclaration("Nutrition Assessment Status Severely Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42")]
	public CqlValueSet Nutrition_Assessment_Status_Severely_Malnourished	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42", default);


    [CqlDeclaration("Nutrition Care Plan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93")]
	public CqlValueSet Nutrition_Care_Plan	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", default);


    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);


    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);


    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);


    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date	(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT	(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM	(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period	(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient	(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer Type")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type	(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex	(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter	(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_		(Encounter EncounterInpatient)
		{
			Period e_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
			CqlDateTime g_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
			Patient j_ = this.Patient(context);
			Date k_ = j_?.BirthDateElement;
			string l_ = k_?.Value;
			CqlDate m_ = context.Operators.ConvertStringToDate(l_);
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
			CqlDateTime p_ = context.Operators.Start(o_);
			CqlDate q_ = context.Operators.DateFrom(p_);
			int? r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
			bool? s_ = context.Operators.GreaterOrEqual(r_, 65);
			bool? t_ = context.Operators.And(i_, s_);
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
			CqlDateTime z_ = context.Operators.End(y_);
			int? aa_ = context.Operators.DurationBetween(w_, z_, "hour");
			bool? ab_ = context.Operators.GreaterOrEqual(aa_, 24);
			bool? ac_ = context.Operators.And(t_, ab_);
			Code<Encounter.EncounterStatus> ad_ = EncounterInpatient?.StatusElement;
			Encounter.EncounterStatus? ae_ = ad_?.Value;
			Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
			bool? ag_ = context.Operators.Equal(af_, "finished");
			bool? ah_ = context.Operators.And(ac_, ag_);

			return ah_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}


    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

		return a_;
	}


    [CqlDeclaration("Measure Population")]
	public IEnumerable<Encounter> Measure_Population	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Encounter with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Hospital_Dietitian_Referral(context);
		IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? e_		(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
		{
			CodeableConcept l_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Hospital_Dietitian_Referral(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<EventStatus> p_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
			EventStatus? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"active",
				"completed",
				"in-progress",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);
			DataType v_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
			object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
			CqlDateTime x_ = QICoreCommon_2_0_000.Instance.earliest(context, w_);
			CqlInterval<CqlDateTime> y_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
			bool? z_ = context.Operators.In<CqlDateTime>(x_, y_, default);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) => 
			tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Malnutrition Risk Screening")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Malnutrition_Screening_Not_At_Risk_Result(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			object ah_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ai_ = this.Malnutrition_Screening_At_Risk_Result(context);
			bool? aj_ = context.Operators.ConceptInValueSet(ah_ as CqlConcept, ai_);
			bool? ak_ = context.Operators.Or(af_, aj_);
			bool? al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		bool? b_		(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
			bool? i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			bool? j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_		(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Encounter with Malnutrition Risk Screening Not at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Malnutrition_Screening_Not_At_Risk_Result(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			bool? ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		bool? b_		(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk(context);
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
			bool? i_ = context.Operators.Exists<Encounter>(h_);
			bool? j_ = context.Operators.Not(i_);
			bool? k_ = context.Operators.And(g_, j_);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_		(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Malnutrition_Screening_At_Risk_Result(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			bool? ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		bool? b_		(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk(context);
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
			bool? i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			bool? j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_		(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Encounter with Nutrition Assessment and Identified Status")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Nutrition_Assessment(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Nutrition_Assessment(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Nutrition_Assessment_Status_Moderately_Malnourished(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			object ah_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ai_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished(context);
			bool? aj_ = context.Operators.ConceptInValueSet(ah_ as CqlConcept, ai_);
			bool? ak_ = context.Operators.Or(af_, aj_);
			object am_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet an_ = this.Nutrition_Assessment_Status_Severely_Malnourished(context);
			bool? ao_ = context.Operators.ConceptInValueSet(am_ as CqlConcept, an_);
			bool? ap_ = context.Operators.Or(ak_, ao_);
			bool? aq_ = context.Operators.And(ab_, ap_);

			return aq_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Nutrition_Assessment(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Nutrition_Assessment(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Nutrition_Assessment_Status_Moderately_Malnourished(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			object ah_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ai_ = this.Nutrition_Assessment_Status_Severely_Malnourished(context);
			bool? aj_ = context.Operators.ConceptInValueSet(ah_ as CqlConcept, ai_);
			bool? ak_ = context.Operators.Or(af_, aj_);
			bool? al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Nutrition_Assessment(context);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_		(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Nutrition_Assessment(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.toInterval(context, y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlValueSet ae_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished(context);
			bool? af_ = context.Operators.ConceptInValueSet(ad_ as CqlConcept, ae_);
			bool? ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Malnutrition Diagnosis")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Malnutrition_Diagnosis(context);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? e_		(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
		{
			CodeableConcept l_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Malnutrition_Diagnosis(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlInterval<CqlDateTime> r_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
			bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) => 
			tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Encounter with Nutrition Care Plan")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		CqlValueSet b_ = this.Nutrition_Care_Plan(context);
		IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? e_		(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? k_ = (default(CqlTupleMetadata), _valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
		{
			CodeableConcept l_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlValueSet n_ = this.Nutrition_Care_Plan(context);
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<EventStatus> p_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
			EventStatus? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"completed",
				"in-progress",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);
			DataType v_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
			object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
			CqlDateTime x_ = QICoreCommon_2_0_000.Instance.earliest(context, w_);
			CqlInterval<CqlDateTime> y_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
			bool? z_ = context.Operators.In<CqlDateTime>(x_, y_, default);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) => 
			tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(h_, i_);

		return j_;
	}

	public int? Measure_Observation_1	(CqlContext context, Encounter MalnutritionRiskScreening) => 
		((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
			? 1
			: 0);

	public int? Measure_Observation_2	(CqlContext context, Encounter NutritionAssessment)
	{
		int? a_		()
		{
			bool b_			()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
				bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);

				return e_ ?? false;
			};
			bool c_			()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral(context);
				bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);

				return g_ ?? false;
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
				return ((context.Operators.Contains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context), NutritionAssessment)) ?? false
	? 1
	: 0);
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

	public int? Measure_Observation_3	(CqlContext context, Encounter MalnutritionDiagonsis)
	{
		int? a_		()
		{
			bool b_			()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
				bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagonsis);

				return e_ ?? false;
			};
			bool c_			()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral(context);
				bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagonsis);

				return g_ ?? false;
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
int? h_()
				{
bool i_()
					{
IEnumerable<Encounter> j_ = this.Encounter_with_Malnutrition_Diagnosis(context);
bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagonsis);

						return k_ ?? false;
					};
					if (i_())
					{
int? l_()
						{
bool m_()
							{
IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagonsis);

								return p_ ?? false;
							};
bool n_()
							{
IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagonsis);

								return r_ ?? false;
							};
							if (m_())
							{
								return 0;
							}
							else if (n_())
							{
								return 1;
							}
							else
							{
								return 0;
							}
						};

						return l_();
					}
					else
					{
						return 0;
					}
				};

				return h_();
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

	public int? Measure_Observation_4	(CqlContext context, Encounter NutritionCarePlan)
	{
		int? a_		()
		{
			bool b_			()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
				bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);

				return e_ ?? false;
			};
			bool c_			()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral(context);
				bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);

				return g_ ?? false;
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
int? h_()
				{
bool i_()
					{
IEnumerable<Encounter> j_ = this.Encounter_with_Nutrition_Care_Plan(context);
bool? k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);

						return k_ ?? false;
					};
					if (i_())
					{
int? l_()
						{
bool m_()
							{
IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);

								return p_ ?? false;
							};
bool n_()
							{
IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
bool? r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);

								return r_ ?? false;
							};
							if (m_())
							{
								return 0;
							}
							else if (n_())
							{
								return 1;
							}
							else
							{
								return 0;
							}
						};

						return l_();
					}
					else
					{
						return 0;
					}
				};

				return h_();
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

	public int? Measure_Observation_TotalMalnutritionComponentsScore	(CqlContext context, Encounter QualifyingEncounter)
	{
		int? a_ = this.Measure_Observation_1(context, QualifyingEncounter);
		int? b_ = this.Measure_Observation_2(context, QualifyingEncounter);
		int? c_ = this.Measure_Observation_3(context, QualifyingEncounter);
		int? d_ = this.Measure_Observation_4(context, QualifyingEncounter);
		int?[] e_ = [
			a_,
			b_,
			c_,
			d_,
		];
		int? f_ = context.Operators.Sum(e_ as IEnumerable<int?>);

		return f_;
	}

	public int? TotalMalnutritionCompositeScore_Eligible_Denominators	(CqlContext context, Encounter QualifyingEncounter)
	{
		int? a_		()
		{
			bool b_			()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
				bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk(context);
				bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
				bool? h_ = context.Operators.And(e_, g_);
				IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
				bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
				bool? k_ = context.Operators.Not(j_);
				bool? l_ = context.Operators.And(h_, k_);

				return l_ ?? false;
			};
			bool c_			()
			{
				IEnumerable<Encounter> m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
				bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
				IEnumerable<Encounter> o_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk(context);
				bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
				bool? q_ = context.Operators.And(n_, p_);
				IEnumerable<Encounter> r_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
				bool? s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
				bool? t_ = context.Operators.Or(q_, s_);
				IEnumerable<Encounter> u_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
				bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
				bool? w_ = context.Operators.And(t_, v_);
				IEnumerable<Encounter> x_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
				bool? y_ = context.Operators.Contains<Encounter>(x_, QualifyingEncounter);
				bool? z_ = context.Operators.Not(y_);
				bool? aa_ = context.Operators.Or(w_, z_);

				return aa_ ?? false;
			};
			if (b_())
			{
				return 1;
			}
			else if (c_())
			{
				return 2;
			}
			else
			{
				return 4;
			}
		};

		return a_();
	}

	public decimal? Measure_Observation_TotalMalnutritionCompositeScore_as_Percentage	(CqlContext context, Encounter QualifyingEncounter)
	{
		decimal? a_ = context.Operators.ConvertIntegerToDecimal(100);
		int? b_ = this.Measure_Observation_TotalMalnutritionComponentsScore(context, QualifyingEncounter);
		decimal? c_ = context.Operators.ConvertIntegerToDecimal(b_);
		int? d_ = this.TotalMalnutritionCompositeScore_Eligible_Denominators(context, QualifyingEncounter);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(d_);
		decimal? f_ = context.Operators.Divide(c_, e_);
		decimal? g_ = context.Operators.Multiply(a_, f_);

		return g_;
	}

}
