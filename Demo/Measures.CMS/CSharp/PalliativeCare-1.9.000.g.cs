﻿using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("PalliativeCare", "1.9.000")]
public class PalliativeCare_1_9_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_Care_Intervention;
    internal Lazy<CqlValueSet> __Palliative_Care_Diagnosis;
    internal Lazy<CqlCode> __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Palliative_Care_in_the_Measurement_Period;

    #endregion
    public PalliativeCare_1_9_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value);
        __Palliative_Care_Diagnosis = new Lazy<CqlValueSet>(this.Palliative_Care_Diagnosis_Value);
        __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new Lazy<CqlCode>(this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Palliative_Care_in_the_Measurement_Period = new Lazy<bool?>(this.Has_Palliative_Care_in_the_Measurement_Period_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlValueSet Palliative_Care_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    [CqlDeclaration("Palliative Care Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167")]
	public CqlValueSet Palliative_Care_Diagnosis() => 
		__Palliative_Care_Diagnosis.Value;

	private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() => 
		new CqlCode("71007-9", "http://loinc.org", null, null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => 
		__Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("71007-9", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("PalliativeCare-1.9.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Palliative_Care_in_the_Measurement_Period_Value()
	{
		var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.isAssessmentPerformed(c_);
		bool? e_(Observation PalliativeAssessment)
		{
			var ab_ = PalliativeAssessment?.Effective;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = QICoreCommon_2_0_000.toInterval(ac_);
			var ae_ = this.Measurement_Period();
			var af_ = context.Operators.Overlaps(ad_, ae_, "day");

			return af_;
		};
		var f_ = context.Operators.Where<Observation>(d_, e_);
		var g_ = context.Operators.Exists<Observation>(f_);
		var h_ = this.Palliative_Care_Diagnosis();
		var i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition PalliativeDiagnosis)
		{
			var ag_ = QICoreCommon_2_0_000.prevalenceInterval(PalliativeDiagnosis);
			var ah_ = this.Measurement_Period();
			var ai_ = context.Operators.Overlaps(ag_, ah_, "day");

			return ai_;
		};
		var k_ = context.Operators.Where<Condition>(i_, j_);
		var l_ = context.Operators.Exists<Condition>(k_);
		var m_ = context.Operators.Or(g_, l_);
		var n_ = this.Palliative_Care_Encounter();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = Status_1_6_000.isEncounterPerformed(o_);
		bool? q_(Encounter PalliativeEncounter)
		{
			var aj_ = PalliativeEncounter?.Period;
			var ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
			var al_ = QICoreCommon_2_0_000.toInterval((ak_ as object));
			var am_ = this.Measurement_Period();
			var an_ = context.Operators.Overlaps(al_, am_, "day");

			return an_;
		};
		var r_ = context.Operators.Where<Encounter>(p_, q_);
		var s_ = context.Operators.Exists<Encounter>(r_);
		var t_ = context.Operators.Or(m_, s_);
		var u_ = this.Palliative_Care_Intervention();
		var v_ = context.Operators.RetrieveByValueSet<Procedure>(u_, null);
		var w_ = Status_1_6_000.isInterventionPerformed(v_);
		bool? x_(Procedure PalliativeIntervention)
		{
			var ao_ = PalliativeIntervention?.Performed;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.toInterval(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = context.Operators.Overlaps(aq_, ar_, "day");

			return as_;
		};
		var y_ = context.Operators.Where<Procedure>(w_, x_);
		var z_ = context.Operators.Exists<Procedure>(y_);
		var aa_ = context.Operators.Or(t_, z_);

		return aa_;
	}

    [CqlDeclaration("Has Palliative Care in the Measurement Period")]
	public bool? Has_Palliative_Care_in_the_Measurement_Period() => 
		__Has_Palliative_Care_in_the_Measurement_Period.Value;

}