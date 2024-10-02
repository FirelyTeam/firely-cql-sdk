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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", default);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", default);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlValueSet Palliative_Care_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", default);

    [CqlDeclaration("Palliative Care Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167")]
	public CqlValueSet Palliative_Care_Diagnosis() => 
		__Palliative_Care_Diagnosis.Value;

	private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() => 
		new CqlCode("71007-9", "http://loinc.org", default, default);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => 
		__Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("71007-9", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("PalliativeCare-1.9.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Palliative_Care_in_the_Measurement_Period_Value()
	{
		CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> d_ = Status_1_6_000.isAssessmentPerformed(c_);
		bool? e_(Observation PalliativeAssessment)
		{
			DataType ab_ = PalliativeAssessment?.Effective;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.toInterval(ac_);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period();
			bool? af_ = context.Operators.Overlaps(ad_, ae_, "day");

			return af_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		bool? g_ = context.Operators.Exists<Observation>(f_);
		CqlValueSet h_ = this.Palliative_Care_Diagnosis();
		IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? j_(Condition PalliativeDiagnosis)
		{
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.prevalenceInterval(PalliativeDiagnosis);
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period();
			bool? ai_ = context.Operators.Overlaps(ag_, ah_, "day");

			return ai_;
		};
		IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
		bool? l_ = context.Operators.Exists<Condition>(k_);
		bool? m_ = context.Operators.Or(g_, l_);
		CqlValueSet n_ = this.Palliative_Care_Encounter();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = Status_1_6_000.isEncounterPerformed(o_);
		bool? q_(Encounter PalliativeEncounter)
		{
			Period aj_ = PalliativeEncounter?.Period;
			CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.toInterval(ak_ as object);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period();
			bool? an_ = context.Operators.Overlaps(al_, am_, "day");

			return an_;
		};
		IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
		bool? s_ = context.Operators.Exists<Encounter>(r_);
		bool? t_ = context.Operators.Or(m_, s_);
		CqlValueSet u_ = this.Palliative_Care_Intervention();
		IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> w_ = Status_1_6_000.isInterventionPerformed(v_);
		bool? x_(Procedure PalliativeIntervention)
		{
			DataType ao_ = PalliativeIntervention?.Performed;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.toInterval(ap_);
			CqlInterval<CqlDateTime> ar_ = this.Measurement_Period();
			bool? as_ = context.Operators.Overlaps(aq_, ar_, "day");

			return as_;
		};
		IEnumerable<Procedure> y_ = context.Operators.Where<Procedure>(w_, x_);
		bool? z_ = context.Operators.Exists<Procedure>(y_);
		bool? aa_ = context.Operators.Or(t_, z_);

		return aa_;
	}

    [CqlDeclaration("Has Palliative Care in the Measurement Period")]
	public bool? Has_Palliative_Care_in_the_Measurement_Period() => 
		__Has_Palliative_Care_in_the_Measurement_Period.Value;

}
