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
[CqlLibrary("MultipleResourcesExample", "0.0.1")]
public class MultipleResourcesExample_0_0_1
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Lung_Cancer;
    internal Lazy<CqlValueSet> __Condition_Clinical_Status;
    internal Lazy<CqlCode> __Tobacco_Smoking_Status;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Observation>> __Smoking_status_observation;
    internal Lazy<IEnumerable<Condition>> __Lung_cancer_diagnosis;

    #endregion
    public MultipleResourcesExample_0_0_1(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Lung_Cancer = new Lazy<CqlValueSet>(this.Lung_Cancer_Value);
        __Condition_Clinical_Status = new Lazy<CqlValueSet>(this.Condition_Clinical_Status_Value);
        __Tobacco_Smoking_Status = new Lazy<CqlCode>(this.Tobacco_Smoking_Status_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Smoking_status_observation = new Lazy<IEnumerable<Observation>>(this.Smoking_status_observation_Value);
        __Lung_cancer_diagnosis = new Lazy<IEnumerable<Condition>>(this.Lung_cancer_diagnosis_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet Lung_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", default);

    [CqlDeclaration("Lung Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89")]
	public CqlValueSet Lung_Cancer() => 
		__Lung_Cancer.Value;

	private CqlValueSet Condition_Clinical_Status_Value() => 
		new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", default);

    [CqlDeclaration("Condition Clinical Status")]
    [CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical")]
	public CqlValueSet Condition_Clinical_Status() => 
		__Condition_Clinical_Status.Value;

	private CqlCode Tobacco_Smoking_Status_Value() => 
		new CqlCode("72166-2", "http://loinc.org", default, default);

    [CqlDeclaration("Tobacco Smoking Status")]
	public CqlCode Tobacco_Smoking_Status() => 
		__Tobacco_Smoking_Status.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("72166-2", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Observation> Smoking_status_observation_Value()
	{
		CqlCode a_ = this.Tobacco_Smoking_Status();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? d_(Observation O)
		{
			Code<ObservationStatus> f_ = O?.StatusElement;
			string g_ = FHIRHelpers_4_3_000.ToString(f_);
			string[] h_ = [
				"final",
				"amended",
			];
			bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);

			return i_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Smoking status observation")]
	public IEnumerable<Observation> Smoking_status_observation() => 
		__Smoking_status_observation.Value;

	private IEnumerable<Condition> Lung_cancer_diagnosis_Value()
	{
		CqlValueSet a_ = this.Lung_Cancer();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition C)
		{
			CodeableConcept e_ = C?.ClinicalStatus;
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			CqlValueSet g_ = this.Condition_Clinical_Status();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Lung cancer diagnosis")]
	public IEnumerable<Condition> Lung_cancer_diagnosis() => 
		__Lung_cancer_diagnosis.Value;

}
