using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("FunctionalStatusAssessmentforTotalHipReplacementFHIR", "0.0.008")]
public static class FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008
{

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public static CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public static CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("Lower Body Fractures Excluding Ankle and Foot")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178")]
	public static CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", default);

    [CqlDeclaration("Malignant Neoplasms of Lower and Unspecified Limbs")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180")]
	public static CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", default);

    [CqlDeclaration("Mechanical Complications Excluding Upper Body")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182")]
	public static CqlValueSet Mechanical_Complications_Excluding_Upper_Body(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public static CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public static CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public static CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public static CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Partial Arthroplasty of Hip")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184")]
	public static CqlValueSet Partial_Arthroplasty_of_Hip(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", default);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public static CqlValueSet Payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Primary THA Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006")]
	public static CqlValueSet Primary_THA_Procedure(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public static CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Removal, Revision and Supplement Procedures of the Lower Body and Spine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189")]
	public static CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public static CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Activities of daily living score [HOOS]")]
	public static CqlCode Activities_of_daily_living_score__HOOS_(CqlContext context) => 
		new CqlCode("72095-3", "http://loinc.org", default, default);

    [CqlDeclaration("Dead (finding)")]
	public static CqlCode Dead__finding_(CqlContext context) => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public static CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public static CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Hospice care [Minimum Data Set]")]
	public static CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => 
		new CqlCode("45755-6", "http://loinc.org", default, default);

    [CqlDeclaration("Pain score [HOOS]")]
	public static CqlCode Pain_score__HOOS_(CqlContext context) => 
		new CqlCode("72097-9", "http://loinc.org", default, default);

    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
	public static CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext context) => 
		new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("PROMIS-10 Global Mental Health (GMH) score T-score")]
	public static CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext context) => 
		new CqlCode("71969-0", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-10 Global Physical Health (GPH) score T-score")]
	public static CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext context) => 
		new CqlCode("71971-6", "http://loinc.org", default, default);

    [CqlDeclaration("Quality of life score [HOOS]")]
	public static CqlCode Quality_of_life_score__HOOS_(CqlContext context) => 
		new CqlCode("72093-8", "http://loinc.org", default, default);

    [CqlDeclaration("Severe cognitive impairment (finding)")]
	public static CqlCode Severe_cognitive_impairment__finding_(CqlContext context) => 
		new CqlCode("702956004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Sport-recreation score [HOOS]")]
	public static CqlCode Sport_recreation_score__HOOS_(CqlContext context) => 
		new CqlCode("72094-6", "http://loinc.org", default, default);

    [CqlDeclaration("survey")]
	public static CqlCode survey(CqlContext context) => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/v3-ObservationCategory", default, default);

    [CqlDeclaration("Symptoms score [HOOS]")]
	public static CqlCode Symptoms_score__HOOS_(CqlContext context) => 
		new CqlCode("72096-1", "http://loinc.org", default, default);

    [CqlDeclaration("Total interval score [HOOSJR]")]
	public static CqlCode Total_interval_score__HOOSJR_(CqlContext context) => 
		new CqlCode("82323-7", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - oblique method T-score")]
	public static CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext context) => 
		new CqlCode("72026-8", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - orthogonal method T-score")]
	public static CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext context) => 
		new CqlCode("72028-4", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - oblique method T-score")]
	public static CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext context) => 
		new CqlCode("72025-0", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - orthogonal method T-score")]
	public static CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext context) => 
		new CqlCode("72027-6", "http://loinc.org", default, default);

    [CqlDeclaration("Yes (qualifier value)")]
	public static CqlCode Yes__qualifier_value_(CqlContext context) => 
		new CqlCode("373066001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("LOINC")]
	public static CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("72095-3", "http://loinc.org", default, default),
			new CqlCode("45755-6", "http://loinc.org", default, default),
			new CqlCode("72097-9", "http://loinc.org", default, default),
			new CqlCode("71969-0", "http://loinc.org", default, default),
			new CqlCode("71971-6", "http://loinc.org", default, default),
			new CqlCode("72093-8", "http://loinc.org", default, default),
			new CqlCode("72094-6", "http://loinc.org", default, default),
			new CqlCode("72096-1", "http://loinc.org", default, default),
			new CqlCode("82323-7", "http://loinc.org", default, default),
			new CqlCode("72026-8", "http://loinc.org", default, default),
			new CqlCode("72028-4", "http://loinc.org", default, default),
			new CqlCode("72025-0", "http://loinc.org", default, default),
			new CqlCode("72027-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("CPT")]
	public static CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionCategoryCodes")]
	public static CqlCode[] ConditionCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public static CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("702956004", "http://snomed.info/sct", default, default),
			new CqlCode("373066001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public static CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/v3-ObservationCategory", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public static IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public static CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("November 1 Year Prior to the Measurement Period")]
	public static CqlDateTime November_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public static bool? Has_Qualifying_Encounter(CqlContext context)
	{
		CqlValueSet a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Outpatient_Consultation(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Office_Visit(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? g_(Encounter E)
		{
			List<CodeableConcept> t_ = E?.Type;
			CqlConcept u_(CodeableConcept @this)
			{
				CqlConcept z_ = FHIRHelpers_4_3_000.ToConcept(context, @this);

				return z_;
			};
			IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);
			bool? w_(CqlConcept T)
			{
				CqlCode aa_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
				CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
				bool? ac_ = context.Operators.Equivalent(T, ab_);

				return ac_;
			};
			IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>(v_, w_);
			bool? y_ = context.Operators.Exists<CqlConcept>(x_);

			return y_;
		};
		IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
		CqlValueSet i_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Telephone_Visits(context);
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, default);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
		CqlValueSet m_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Online_Assessments(context);
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(l_, n_);
		IEnumerable<Encounter> p_ = Status_1_6_000.isEncounterPerformed(context, o_);
		bool? q_(Encounter ValidEncounters)
		{
			CqlDateTime ad_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.November_1_Year_Prior_to_the_Measurement_Period(context);
			CqlInterval<CqlDateTime> ae_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
			Period ah_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_3_000.ToInterval(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.toInterval(context, ai_ as object);
			bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, aj_, "day");

			return ak_;
		};
		IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
		bool? s_ = context.Operators.Exists<Encounter>(r_);

		return s_;
	}

    [CqlDeclaration("November 1 Two Years Prior to the Measurement Period")]
	public static CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 2);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("October 31 Year Prior to the Measurement Period")]
	public static CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 10, 31, 23, 59, 59, 0, e_);

		return f_;
	}

    [CqlDeclaration("Total Hip Arthroplasty Procedure")]
	public static IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
	{
		CqlValueSet a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Primary_THA_Procedure(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.isProcedurePerformed(context, b_);
		bool? d_(Procedure THAProcedure)
		{
			DataType f_ = THAProcedure?.Performed;
			object g_ = FHIRHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.toInterval(context, g_);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDateTime j_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
			CqlDateTime k_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.October_31_Year_Prior_to_the_Measurement_Period(context);
			CqlInterval<CqlDateTime> l_ = context.Operators.Interval(j_, k_, true, true);
			bool? m_ = context.Operators.In<CqlDateTime>(i_, l_, "day");

			return m_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public static bool? Initial_Population(CqlContext context)
	{
		bool? a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Qualifying_Encounter(context);
		IEnumerable<Procedure> b_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		bool? c_ = context.Operators.Exists<Procedure>(b_);
		bool? d_ = context.Operators.And(a_, c_);
		Patient e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Patient(context);
		Date f_ = e_?.BirthDateElement;
		string g_ = f_?.Value;
		CqlDate h_ = context.Operators.ConvertStringToDate(g_);
		CqlInterval<CqlDateTime> i_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
		CqlDateTime j_ = context.Operators.Start(i_);
		CqlDate k_ = context.Operators.DateFrom(j_);
		int? l_ = context.Operators.CalculateAgeAt(h_, k_, "year");
		bool? m_ = context.Operators.GreaterOrEqual(l_, 19);
		bool? n_ = context.Operators.And(d_, m_);

		return n_;
	}

    [CqlDeclaration("Denominator")]
	public static bool? Denominator(CqlContext context)
	{
		bool? a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Has Severe Cognitive Impairment")]
	public static bool? Has_Severe_Cognitive_Impairment(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Severe_cognitive_impairment__finding_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.RetrieveByCodes<Condition>(b_, default);
		bool? d_(Condition Dementia)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.prevalenceInterval(context, Dementia);
			CqlInterval<CqlDateTime> h_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Measurement_Period(context);
			bool? i_ = context.Operators.Overlaps(g_, h_, default);

			return i_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
	public static bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			CqlValueSet e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
			IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(e_, default);
			bool? g_(Condition LowerBodyFracture)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(context, LowerBodyFracture);
				CqlDateTime l_ = context.Operators.Start(k_);
				DataType m_ = THAProcedure?.Performed;
				object n_ = FHIRHelpers_4_3_000.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime r_ = context.Operators.Subtract(p_, q_);
				object t_ = FHIRHelpers_4_3_000.ToValue(context, m_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlInterval<CqlDateTime> w_ = context.Operators.Interval(r_, v_, true, true);
				bool? x_ = context.Operators.In<CqlDateTime>(l_, w_, default);
				object z_ = FHIRHelpers_4_3_000.ToValue(context, m_);
				CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_0_000.toInterval(context, z_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
				bool? ad_ = context.Operators.And(x_, ac_);

				return ad_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Procedure i_(Condition LowerBodyFracture) => 
				THAProcedure;
			IEnumerable<Procedure> j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

			return j_;
		};
		IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Has Partial Hip Arthroplasty Procedure")]
	public static bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
	{
		CqlValueSet a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Partial_Arthroplasty_of_Hip(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.isProcedurePerformed(context, b_);
		IEnumerable<Procedure> d_(Procedure PartialTHAProcedure)
		{
			IEnumerable<Procedure> g_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
			bool? h_(Procedure THAProcedure)
			{
				DataType l_ = THAProcedure?.Performed;
				object m_ = FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(context, m_);
				DataType o_ = PartialTHAProcedure?.Performed;
				object p_ = FHIRHelpers_4_3_000.ToValue(context, o_);
				CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(context, p_);
				bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

				return r_;
			};
			IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure THAProcedure) => 
				PartialTHAProcedure;
			IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
	public static bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			CqlValueSet e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
			IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, default);
			IEnumerable<Procedure> g_ = Status_1_6_000.isProcedurePerformed(context, f_);
			bool? h_(Procedure RevisionTHAProcedure)
			{
				DataType l_ = THAProcedure?.Performed;
				object m_ = FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(context, m_);
				DataType o_ = RevisionTHAProcedure?.Performed;
				object p_ = FHIRHelpers_4_3_000.ToValue(context, o_);
				CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(context, p_);
				bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

				return r_;
			};
			IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure RevisionTHAProcedure) => 
				THAProcedure;
			IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
	public static bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
	{
		CqlValueSet a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition MalignantNeoplasm)
		{
			IEnumerable<Procedure> f_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
			bool? g_(Procedure THAProcedure)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(context, MalignantNeoplasm);
				DataType l_ = THAProcedure?.Performed;
				object m_ = FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(context, m_);
				bool? o_ = context.Operators.Overlaps(k_, n_, default);

				return o_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Condition i_(Procedure THAProcedure) => 
				MalignantNeoplasm;
			IEnumerable<Condition> j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Mechanical Complication")]
	public static bool? Has_Mechanical_Complication(CqlContext context)
	{
		CqlValueSet a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Mechanical_Complications_Excluding_Upper_Body(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition MechanicalComplications)
		{
			IEnumerable<Procedure> f_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
			bool? g_(Procedure THAProcedure)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(context, MechanicalComplications);
				DataType l_ = THAProcedure?.Performed;
				object m_ = FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(context, m_);
				bool? o_ = context.Operators.Overlaps(k_, n_, default);

				return o_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Condition i_(Procedure THAProcedure) => 
				MechanicalComplications;
			IEnumerable<Condition> j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
	public static bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			CqlValueSet e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Primary_THA_Procedure(context);
			IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, default);
			IEnumerable<Procedure> g_ = Status_1_6_000.isProcedurePerformed(context, f_);
			bool? h_(Procedure ElectiveTHAProcedure)
			{
				Id l_ = THAProcedure?.IdElement;
				string m_ = l_?.Value;
				Id n_ = ElectiveTHAProcedure?.IdElement;
				string o_ = n_?.Value;
				bool? p_ = context.Operators.Equivalent(m_, o_);
				bool? q_ = context.Operators.Not(p_);
				DataType r_ = ElectiveTHAProcedure?.Performed;
				object s_ = FHIRHelpers_4_3_000.ToValue(context, r_);
				CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval(context, s_);
				CqlDateTime u_ = context.Operators.Start(t_);
				DataType v_ = THAProcedure?.Performed;
				object w_ = FHIRHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.toInterval(context, w_);
				CqlDateTime y_ = context.Operators.Start(x_);
				CqlQuantity z_ = context.Operators.Quantity(1m, "year");
				CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
				object ac_ = FHIRHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.toInterval(context, ac_);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlDateTime ag_ = context.Operators.Add(ae_, z_);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(aa_, ag_, true, true);
				bool? ai_ = context.Operators.In<CqlDateTime>(u_, ah_, "day");
				bool? aj_ = context.Operators.And(q_, ai_);

				return aj_;
			};
			IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure ElectiveTHAProcedure) => 
				THAProcedure;
			IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Death Within 300 Days of the THA Procedure")]
	public static bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		bool? b_(Procedure THAProcedure)
		{
			Patient e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Patient(context);
			DataType f_ = e_?.Deceased;
			object g_ = FHIRHelpers_4_3_000.ToValue(context, f_);
			CqlDate h_ = context.Operators.DateFrom(g_ as CqlDateTime);
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			object o_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(context, o_);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlDate r_ = context.Operators.DateFrom(q_);
			CqlQuantity s_ = context.Operators.Quantity(300m, "days");
			CqlDate t_ = context.Operators.Add(r_, s_);
			CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDate>(h_, u_, "day");

			return v_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public static bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services(context);
		bool? b_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Severe_Cognitive_Impairment(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Partial_Hip_Arthroplasty_Procedure(context);
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_Mechanical_Complication(context);
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Death_Within_300_Days_of_the_THA_Procedure(context);
		bool? q_ = context.Operators.Or(o_, p_);

		return q_;
	}

    [CqlDeclaration("Date HOOS Total Assessment Completed")]
	public static IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Quality_of_life_score__HOOS_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = Status_1_6_000.isAssessmentPerformed(context, c_);
		CqlCode e_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Sport_recreation_score__HOOS_(context);
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, default);
		IEnumerable<Observation> h_ = Status_1_6_000.isAssessmentPerformed(context, g_);
		CqlCode i_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Activities_of_daily_living_score__HOOS_(context);
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<Observation> k_ = context.Operators.RetrieveByCodes<Observation>(j_, default);
		IEnumerable<Observation> l_ = Status_1_6_000.isAssessmentPerformed(context, k_);
		CqlCode m_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Symptoms_score__HOOS_(context);
		IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
		IEnumerable<Observation> o_ = context.Operators.RetrieveByCodes<Observation>(n_, default);
		IEnumerable<Observation> p_ = Status_1_6_000.isAssessmentPerformed(context, o_);
		CqlCode q_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Pain_score__HOOS_(context);
		IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
		IEnumerable<Observation> s_ = context.Operators.RetrieveByCodes<Observation>(r_, default);
		IEnumerable<Observation> t_ = Status_1_6_000.isAssessmentPerformed(context, s_);
		IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> u_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_);
		(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? v_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? ab_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

			return ab_;
		};
		IEnumerable<(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> w_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(u_, v_);
		bool? x_((Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
		{
			DataType ac_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
			object ad_ = FHIRHelpers_4_3_000.ToValue(context, ac_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.toInterval(context, ad_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlDate ag_ = context.Operators.DateFrom(af_);
			DataType ah_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
			object ai_ = FHIRHelpers_4_3_000.ToValue(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.toInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			bool? am_ = context.Operators.SameAs(ag_, al_, "day");
			DataType an_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
			object ao_ = FHIRHelpers_4_3_000.ToValue(context, an_);
			bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
			bool? aq_ = context.Operators.And(am_, ap_);
			object as_ = FHIRHelpers_4_3_000.ToValue(context, ac_);
			CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.toInterval(context, as_);
			CqlDateTime au_ = context.Operators.Start(at_);
			CqlDate av_ = context.Operators.DateFrom(au_);
			DataType aw_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
			object ax_ = FHIRHelpers_4_3_000.ToValue(context, aw_);
			CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_0_000.toInterval(context, ax_);
			CqlDateTime az_ = context.Operators.Start(ay_);
			CqlDate ba_ = context.Operators.DateFrom(az_);
			bool? bb_ = context.Operators.SameAs(av_, ba_, "day");
			bool? bc_ = context.Operators.And(aq_, bb_);
			DataType bd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
			object be_ = FHIRHelpers_4_3_000.ToValue(context, bd_);
			bool? bf_ = context.Operators.Not((bool?)(be_ is null));
			bool? bg_ = context.Operators.And(bc_, bf_);
			object bi_ = FHIRHelpers_4_3_000.ToValue(context, ac_);
			CqlInterval<CqlDateTime> bj_ = QICoreCommon_2_0_000.toInterval(context, bi_);
			CqlDateTime bk_ = context.Operators.Start(bj_);
			CqlDate bl_ = context.Operators.DateFrom(bk_);
			DataType bm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
			object bn_ = FHIRHelpers_4_3_000.ToValue(context, bm_);
			CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.toInterval(context, bn_);
			CqlDateTime bp_ = context.Operators.Start(bo_);
			CqlDate bq_ = context.Operators.DateFrom(bp_);
			bool? br_ = context.Operators.SameAs(bl_, bq_, "day");
			bool? bs_ = context.Operators.And(bg_, br_);
			DataType bt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
			object bu_ = FHIRHelpers_4_3_000.ToValue(context, bt_);
			bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
			bool? bw_ = context.Operators.And(bs_, bv_);
			object by_ = FHIRHelpers_4_3_000.ToValue(context, ac_);
			CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_0_000.toInterval(context, by_);
			CqlDateTime ca_ = context.Operators.Start(bz_);
			CqlDate cb_ = context.Operators.DateFrom(ca_);
			DataType cc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
			object cd_ = FHIRHelpers_4_3_000.ToValue(context, cc_);
			CqlInterval<CqlDateTime> ce_ = QICoreCommon_2_0_000.toInterval(context, cd_);
			CqlDateTime cf_ = context.Operators.Start(ce_);
			CqlDate cg_ = context.Operators.DateFrom(cf_);
			bool? ch_ = context.Operators.SameAs(cb_, cg_, "day");
			bool? ci_ = context.Operators.And(bw_, ch_);
			DataType cj_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
			object ck_ = FHIRHelpers_4_3_000.ToValue(context, cj_);
			bool? cl_ = context.Operators.Not((bool?)(ck_ is null));
			bool? cm_ = context.Operators.And(ci_, cl_);
			DataType cn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
			object co_ = FHIRHelpers_4_3_000.ToValue(context, cn_);
			bool? cp_ = context.Operators.Not((bool?)(co_ is null));
			bool? cq_ = context.Operators.And(cm_, cp_);

			return cq_;
		};
		IEnumerable<(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> y_ = context.Operators.Where<(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(w_, x_);
		CqlDate z_((Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
		{
			DataType cr_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
			object cs_ = FHIRHelpers_4_3_000.ToValue(context, cr_);
			CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_0_000.toInterval(context, cs_);
			CqlDateTime cu_ = context.Operators.Start(ct_);
			CqlDate cv_ = context.Operators.DateFrom(cu_);
			DataType cw_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
			object cx_ = FHIRHelpers_4_3_000.ToValue(context, cw_);
			CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_0_000.toInterval(context, cx_);
			CqlDateTime cz_ = context.Operators.Start(cy_);
			CqlDate da_ = context.Operators.DateFrom(cz_);
			DataType db_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
			object dc_ = FHIRHelpers_4_3_000.ToValue(context, db_);
			CqlInterval<CqlDateTime> dd_ = QICoreCommon_2_0_000.toInterval(context, dc_);
			CqlDateTime de_ = context.Operators.Start(dd_);
			CqlDate df_ = context.Operators.DateFrom(de_);
			DataType dg_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
			object dh_ = FHIRHelpers_4_3_000.ToValue(context, dg_);
			CqlInterval<CqlDateTime> di_ = QICoreCommon_2_0_000.toInterval(context, dh_);
			CqlDateTime dj_ = context.Operators.Start(di_);
			CqlDate dk_ = context.Operators.DateFrom(dj_);
			DataType dl_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
			object dm_ = FHIRHelpers_4_3_000.ToValue(context, dl_);
			CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.toInterval(context, dm_);
			CqlDateTime do_ = context.Operators.Start(dn_);
			CqlDate dp_ = context.Operators.DateFrom(do_);
			CqlDate[] dq_ = [
				cv_,
				da_,
				df_,
				dk_,
				dp_,
			];
			CqlDate dr_ = context.Operators.Max<CqlDate>(dq_ as IEnumerable<CqlDate>);

			return dr_;
		};
		IEnumerable<CqlDate> aa_ = context.Operators.Select<(Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(y_, z_);

		return aa_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up HOOS Assessments")]
	public static bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);

			return k_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_HOOS_Total_Assessment_Completed(context);
			bool? m_(CqlDate InitialHipAssessmentHOOS)
			{
				CqlDateTime q_ = context.Operators.Start(TotalHip);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDate s_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(InitialHipAssessmentHOOS, s_, true, true);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				CqlDate x_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				CqlInterval<CqlDate> y_ = context.Operators.Interval(InitialHipAssessmentHOOS, x_, true, true);
				CqlDate z_ = y_?.high;
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				CqlDate ac_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(InitialHipAssessmentHOOS, ac_, true, true);
				bool? ae_ = ad_?.lowClosed;
				CqlDate ag_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				CqlInterval<CqlDate> ah_ = context.Operators.Interval(InitialHipAssessmentHOOS, ag_, true, true);
				bool? ai_ = ah_?.highClosed;
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				bool? al_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
				bool? am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			IEnumerable<CqlDate> n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentHOOS) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> an_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_HOOS_Total_Assessment_Completed(context);
			bool? ao_(CqlDate FollowUpHipAssessmentHOOS)
			{
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
				CqlDate at_ = context.Operators.DateFrom(as_);
				CqlDateTime au_ = context.Operators.End(TotalHip);
				CqlDate av_ = context.Operators.DateFrom(au_);
				CqlQuantity aw_ = context.Operators.Quantity(300m, "days");
				CqlDate ax_ = context.Operators.Add(av_, aw_);
				CqlDate az_ = context.Operators.DateFrom(au_);
				CqlQuantity ba_ = context.Operators.Quantity(425m, "days");
				CqlDate bb_ = context.Operators.Add(az_, ba_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			IEnumerable<CqlDate> ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentHOOS) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Date HOOSJr Total Assessment Completed")]
	public static IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_interval_score__HOOSJR_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation HOOSJr)
		{
			DataType h_ = HOOSJr?.Value;
			object i_ = FHIRHelpers_4_3_000.ToValue(context, h_);
			bool? j_ = context.Operators.Not((bool?)(i_ is null));

			return j_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		CqlDate f_(Observation DocumentedHOOSJr)
		{
			DataType k_ = DocumentedHOOSJr?.Effective;
			object l_ = FHIRHelpers_4_3_000.ToValue(context, k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);

			return o_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Observation, CqlDate>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up HOOSJr Assessments")]
	public static bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);

			return k_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_HOOSJr_Total_Assessment_Completed(context);
			bool? m_(CqlDate InitialHipAssessment)
			{
				CqlDateTime q_ = context.Operators.Start(TotalHip);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDate s_ = context.Operators.Add(InitialHipAssessment, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(InitialHipAssessment, s_, true, true);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				CqlDate x_ = context.Operators.Add(InitialHipAssessment, r_);
				CqlInterval<CqlDate> y_ = context.Operators.Interval(InitialHipAssessment, x_, true, true);
				CqlDate z_ = y_?.high;
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				CqlDate ac_ = context.Operators.Add(InitialHipAssessment, r_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(InitialHipAssessment, ac_, true, true);
				bool? ae_ = ad_?.lowClosed;
				CqlDate ag_ = context.Operators.Add(InitialHipAssessment, r_);
				CqlInterval<CqlDate> ah_ = context.Operators.Interval(InitialHipAssessment, ag_, true, true);
				bool? ai_ = ah_?.highClosed;
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				bool? al_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
				bool? am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			IEnumerable<CqlDate> n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessment) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> an_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_HOOSJr_Total_Assessment_Completed(context);
			bool? ao_(CqlDate FollowUpHipAssessment)
			{
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
				CqlDate at_ = context.Operators.DateFrom(as_);
				CqlDateTime au_ = context.Operators.End(TotalHip);
				CqlDate av_ = context.Operators.DateFrom(au_);
				CqlQuantity aw_ = context.Operators.Quantity(300m, "days");
				CqlDate ax_ = context.Operators.Add(av_, aw_);
				CqlDate az_ = context.Operators.DateFrom(au_);
				CqlQuantity ba_ = context.Operators.Quantity(425m, "days");
				CqlDate bb_ = context.Operators.Add(az_, ba_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			IEnumerable<CqlDate> ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessment) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public static IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		CqlCode d_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, default);
		IEnumerable<ValueTuple<Observation, Observation>> g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? n_ = (_valueTuple.Item1, _valueTuple.Item2);

			return n_;
		};
		IEnumerable<(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> i_ = context.Operators.Select<ValueTuple<Observation, Observation>, (Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(g_, h_);
		bool? j_((Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			DataType o_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
			object p_ = FHIRHelpers_4_3_000.ToValue(context, o_);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(context, p_);
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			DataType t_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(context, t_);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(s_, x_, "day");
			DataType z_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
			object aa_ = FHIRHelpers_4_3_000.ToValue(context, z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(y_, ab_);
			DataType ad_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(context, ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Where<(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);
		CqlDate l_((Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			DataType ah_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
			object ai_ = FHIRHelpers_4_3_000.ToValue(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.toInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			DataType am_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
			object an_ = FHIRHelpers_4_3_000.ToValue(context, am_);
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(context, an_);
			CqlDateTime ap_ = context.Operators.Start(ao_);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate[] ar_ = [
				al_,
				aq_,
			];
			CqlDate as_ = context.Operators.Max<CqlDate>(ar_ as IEnumerable<CqlDate>);

			return as_;
		};
		IEnumerable<CqlDate> m_ = context.Operators.Select<(Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up PROMIS10 Assessments")]
	public static bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);

			return k_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_PROMIS10_Total_Assessment_Completed(context);
			bool? m_(CqlDate InitialHipAssessmentPROMIS10)
			{
				CqlDateTime q_ = context.Operators.Start(TotalHip);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDate s_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, s_, true, true);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				CqlDate x_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				CqlInterval<CqlDate> y_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, x_, true, true);
				CqlDate z_ = y_?.high;
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				CqlDate ac_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ac_, true, true);
				bool? ae_ = ad_?.lowClosed;
				CqlDate ag_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				CqlInterval<CqlDate> ah_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ag_, true, true);
				bool? ai_ = ah_?.highClosed;
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				bool? al_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
				bool? am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			IEnumerable<CqlDate> n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentPROMIS10) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> an_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_PROMIS10_Total_Assessment_Completed(context);
			bool? ao_(CqlDate FollowUpHipAssessmentPROMIS10)
			{
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
				CqlDate at_ = context.Operators.DateFrom(as_);
				CqlDateTime au_ = context.Operators.End(TotalHip);
				CqlDate av_ = context.Operators.DateFrom(au_);
				CqlQuantity aw_ = context.Operators.Quantity(300m, "days");
				CqlDate ax_ = context.Operators.Add(av_, aw_);
				CqlDate az_ = context.Operators.DateFrom(au_);
				CqlQuantity ba_ = context.Operators.Quantity(425m, "days");
				CqlDate bb_ = context.Operators.Add(az_, ba_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			IEnumerable<CqlDate> ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentPROMIS10) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public static IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		CqlCode d_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, default);
		IEnumerable<ValueTuple<Observation, Observation>> g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? n_ = (_valueTuple.Item1, _valueTuple.Item2);

			return n_;
		};
		IEnumerable<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> i_ = context.Operators.Select<ValueTuple<Observation, Observation>, (Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(g_, h_);
		bool? j_((Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType o_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
			object p_ = FHIRHelpers_4_3_000.ToValue(context, o_);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(context, p_);
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			DataType t_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(context, t_);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(s_, x_, "day");
			DataType z_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
			object aa_ = FHIRHelpers_4_3_000.ToValue(context, z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(y_, ab_);
			DataType ad_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(context, ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Where<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
		CqlDate l_((Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType ah_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
			object ai_ = FHIRHelpers_4_3_000.ToValue(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.toInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			DataType am_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
			object an_ = FHIRHelpers_4_3_000.ToValue(context, am_);
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(context, an_);
			CqlDateTime ap_ = context.Operators.Start(ao_);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate[] ar_ = [
				al_,
				aq_,
			];
			CqlDate as_ = context.Operators.Max<CqlDate>(ar_ as IEnumerable<CqlDate>);

			return as_;
		};
		IEnumerable<CqlDate> m_ = context.Operators.Select<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
	public static bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);

			return k_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_VR12_Oblique_Total_Assessment_Completed(context);
			bool? m_(CqlDate InitialHipAssessmentOblique)
			{
				CqlDateTime q_ = context.Operators.Start(TotalHip);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDate s_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(InitialHipAssessmentOblique, s_, true, true);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				CqlDate x_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				CqlInterval<CqlDate> y_ = context.Operators.Interval(InitialHipAssessmentOblique, x_, true, true);
				CqlDate z_ = y_?.high;
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				CqlDate ac_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(InitialHipAssessmentOblique, ac_, true, true);
				bool? ae_ = ad_?.lowClosed;
				CqlDate ag_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				CqlInterval<CqlDate> ah_ = context.Operators.Interval(InitialHipAssessmentOblique, ag_, true, true);
				bool? ai_ = ah_?.highClosed;
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				bool? al_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
				bool? am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			IEnumerable<CqlDate> n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentOblique) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> an_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_VR12_Oblique_Total_Assessment_Completed(context);
			bool? ao_(CqlDate FollowUpHipAssessmentOblique)
			{
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
				CqlDate at_ = context.Operators.DateFrom(as_);
				CqlDateTime au_ = context.Operators.End(TotalHip);
				CqlDate av_ = context.Operators.DateFrom(au_);
				CqlQuantity aw_ = context.Operators.Quantity(300m, "days");
				CqlDate ax_ = context.Operators.Add(av_, aw_);
				CqlDate az_ = context.Operators.DateFrom(au_);
				CqlQuantity ba_ = context.Operators.Quantity(425m, "days");
				CqlDate bb_ = context.Operators.Add(az_, ba_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			IEnumerable<CqlDate> ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentOblique) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public static IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
	{
		CqlCode a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		CqlCode d_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, default);
		IEnumerable<ValueTuple<Observation, Observation>> g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? n_ = (_valueTuple.Item1, _valueTuple.Item2);

			return n_;
		};
		IEnumerable<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> i_ = context.Operators.Select<ValueTuple<Observation, Observation>, (Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(g_, h_);
		bool? j_((Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType o_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
			object p_ = FHIRHelpers_4_3_000.ToValue(context, o_);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(context, p_);
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			DataType t_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(context, t_);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(s_, x_, "day");
			DataType z_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
			object aa_ = FHIRHelpers_4_3_000.ToValue(context, z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(y_, ab_);
			DataType ad_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(context, ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Where<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
		CqlDate l_((Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType ah_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
			object ai_ = FHIRHelpers_4_3_000.ToValue(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.toInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			DataType am_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
			object an_ = FHIRHelpers_4_3_000.ToValue(context, am_);
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(context, an_);
			CqlDateTime ap_ = context.Operators.Start(ao_);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate[] ar_ = [
				al_,
				aq_,
			];
			CqlDate as_ = context.Operators.Max<CqlDate>(ar_ as IEnumerable<CqlDate>);

			return as_;
		};
		IEnumerable<CqlDate> m_ = context.Operators.Select<(Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
	public static bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
	{
		IEnumerable<Procedure> a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Total_Hip_Arthroplasty_Procedure(context);
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			DataType i_ = THAProcedure?.Performed;
			object j_ = FHIRHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(context, j_);

			return k_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> l_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
			bool? m_(CqlDate InitialHipAssessmentOrthogonal)
			{
				CqlDateTime q_ = context.Operators.Start(TotalHip);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDate s_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, s_, true, true);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				CqlDate x_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				CqlInterval<CqlDate> y_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, x_, true, true);
				CqlDate z_ = y_?.high;
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				CqlDate ac_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ac_, true, true);
				bool? ae_ = ad_?.lowClosed;
				CqlDate ag_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				CqlInterval<CqlDate> ah_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ag_, true, true);
				bool? ai_ = ah_?.highClosed;
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				bool? al_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
				bool? am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			IEnumerable<CqlDate> n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentOrthogonal) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			IEnumerable<CqlDate> an_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
			bool? ao_(CqlDate FollowUpHipAssessmentOrthogonal)
			{
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
				CqlDate at_ = context.Operators.DateFrom(as_);
				CqlDateTime au_ = context.Operators.End(TotalHip);
				CqlDate av_ = context.Operators.DateFrom(au_);
				CqlQuantity aw_ = context.Operators.Quantity(300m, "days");
				CqlDate ax_ = context.Operators.Add(av_, aw_);
				CqlDate az_ = context.Operators.DateFrom(au_);
				CqlQuantity ba_ = context.Operators.Quantity(425m, "days");
				CqlDate bb_ = context.Operators.Add(az_, ba_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			IEnumerable<CqlDate> ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentOrthogonal) => 
				TotalHip;
			IEnumerable<CqlInterval<CqlDateTime>> ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public static bool? Numerator(CqlContext context)
	{
		bool? a_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
		bool? b_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
		bool? i_ = context.Operators.Or(g_, h_);

		return i_;
	}

}
