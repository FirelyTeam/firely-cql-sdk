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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("MultipleResourcesExample", "0.0.1")]
public partial class MultipleResourcesExample_0_0_1 : ILibrary, ISingleton<MultipleResourcesExample_0_0_1>
{
    private MultipleResourcesExample_0_0_1() {}

    public static MultipleResourcesExample_0_0_1 Instance { get; } = new();

    #region Library Members
    public string Name => "MultipleResourcesExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Lung Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89")]
	public CqlValueSet Lung_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", default);


    [CqlDeclaration("Condition Clinical Status")]
    [CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical")]
	public CqlValueSet Condition_Clinical_Status(CqlContext context) => 
		new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", default);


    [CqlDeclaration("Tobacco Smoking Status")]
	public CqlCode Tobacco_Smoking_Status(CqlContext context) => 
		new CqlCode("72166-2", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("72166-2", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Smoking status observation")]
	public IEnumerable<Observation> Smoking_status_observation(CqlContext context)
	{
		CqlCode a_ = this.Tobacco_Smoking_Status(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation O)
		{
			Code<ObservationStatus> f_ = O?.StatusElement;
			string g_ = FHIRHelpers_4_3_000.Instance.ToString(context, f_);
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


    [CqlDeclaration("Lung cancer diagnosis")]
	public IEnumerable<Condition> Lung_cancer_diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Lung_Cancer(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition C)
		{
			CodeableConcept e_ = C?.ClinicalStatus;
			CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
			CqlValueSet g_ = this.Condition_Clinical_Status(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

}
