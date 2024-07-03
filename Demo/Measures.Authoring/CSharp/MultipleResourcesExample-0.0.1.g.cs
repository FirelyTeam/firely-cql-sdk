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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", null);

    [CqlDeclaration("Lung Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89")]
	public CqlValueSet Lung_Cancer() => 
		__Lung_Cancer.Value;

	private CqlValueSet Condition_Clinical_Status_Value() => 
		new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", null);

    [CqlDeclaration("Condition Clinical Status")]
    [CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical")]
	public CqlValueSet Condition_Clinical_Status() => 
		__Condition_Clinical_Status.Value;

	private CqlCode Tobacco_Smoking_Status_Value() => 
		new CqlCode("72166-2", "http://loinc.org", null, null);

    [CqlDeclaration("Tobacco Smoking Status")]
	public CqlCode Tobacco_Smoking_Status() => 
		__Tobacco_Smoking_Status.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("72166-2", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Observation> Smoking_status_observation_Value()
	{
		var a_ = this.Tobacco_Smoking_Status();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation O)
		{
			var f_ = O?.StatusElement;
			var g_ = FHIRHelpers_4_3_000.ToString(f_);
			var h_ = new string[]
			{
				"final",
				"amended",
			};
			var i_ = context.Operators.In<string>(g_, (h_ as IEnumerable<string>));

			return i_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Smoking status observation")]
	public IEnumerable<Observation> Smoking_status_observation() => 
		__Smoking_status_observation.Value;

	private IEnumerable<Condition> Lung_cancer_diagnosis_Value()
	{
		var a_ = this.Lung_Cancer();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition C)
		{
			var e_ = C?.ClinicalStatus;
			var f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			var g_ = this.Condition_Clinical_Status();
			var h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Lung cancer diagnosis")]
	public IEnumerable<Condition> Lung_cancer_diagnosis() => 
		__Lung_cancer_diagnosis.Value;

}