using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("PalliativeCareFHIR", "0.6.000")]
public class PalliativeCareFHIR_0_6_000
{

    public static PalliativeCareFHIR_0_6_000 Instance { get; }  = new();

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
	public CqlValueSet Palliative_Care_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
	public CqlValueSet Palliative_Care_Intervention(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext context) => 
		new CqlCode("71007-9", "http://loinc.org", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey(CqlContext context) => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("71007-9", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
	public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
	{
		var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation PalliativeAssessment)
		{
			var s_ = context.Operators.Convert<string>(PalliativeAssessment?.StatusElement);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.InList<string>(s_, (t_ as IEnumerable<string>));
			bool? v_(CodeableConcept PalliativeAssessmentCategory)
			{
				var ad_ = this.survey(context);
				var ae_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
				var af_ = context.Operators.CodeInList(ad_, (ae_?.codes as IEnumerable<CqlCode>));

				return af_;
			};
			var w_ = context.Operators.WhereOrNull<CodeableConcept>((PalliativeAssessment?.Category as IEnumerable<CodeableConcept>), v_);
			var x_ = context.Operators.ExistsInList<CodeableConcept>(w_);
			var y_ = context.Operators.And(u_, x_);
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, PalliativeAssessment?.Effective);
			var aa_ = this.Measurement_Period(context);
			var ab_ = context.Operators.Overlaps(z_, aa_, null);
			var ac_ = context.Operators.And(y_, ab_);

			return ac_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		var f_ = context.Operators.ExistsInList<Observation>(e_);
		var g_ = this.Palliative_Care_Encounter(context);
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		bool? i_(Encounter PalliativeEncounter)
		{
			var ag_ = context.Operators.Convert<string>(PalliativeEncounter?.StatusElement);
			var ah_ = context.Operators.Equal(ag_, "finished");
			var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (PalliativeEncounter?.Period as object));
			var aj_ = this.Measurement_Period(context);
			var ak_ = context.Operators.Overlaps(ai_, aj_, null);
			var al_ = context.Operators.And(ah_, ak_);

			return al_;
		};
		var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = context.Operators.Or(f_, k_);
		var m_ = this.Palliative_Care_Intervention(context);
		var n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		bool? o_(Procedure PalliativeIntervention)
		{
			var am_ = context.Operators.Convert<string>(PalliativeIntervention?.StatusElement);
			var an_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
			var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, PalliativeIntervention?.Performed);
			var aq_ = this.Measurement_Period(context);
			var ar_ = context.Operators.Overlaps(ap_, aq_, null);
			var as_ = context.Operators.And(ao_, ar_);

			return as_;
		};
		var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
		var q_ = context.Operators.ExistsInList<Procedure>(p_);
		var r_ = context.Operators.Or(l_, q_);

		return r_;
	}

}