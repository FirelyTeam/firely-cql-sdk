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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("MultipleResourcesExample", "0.0.1")]
public partial class MultipleResourcesExample_0_0_1 : ILibrary, ISingleton<MultipleResourcesExample_0_0_1>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Lung Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", valueSetVersion: null)]
    public CqlValueSet Lung_Cancer(CqlContext _) => _Lung_Cancer;
    private static readonly CqlValueSet _Lung_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", null);

    [CqlValueSetDefinition("Condition Clinical Status", valueSetId: "http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", valueSetVersion: null)]
    public CqlValueSet Condition_Clinical_Status(CqlContext _) => _Condition_Clinical_Status;
    private static readonly CqlValueSet _Condition_Clinical_Status = new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Tobacco Smoking Status", codeId: "72166-2", codeSystem: "http://loinc.org")]
    public CqlCode Tobacco_Smoking_Status(CqlContext _) => _Tobacco_Smoking_Status;
    private static readonly CqlCode _Tobacco_Smoking_Status = new CqlCode("72166-2", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Tobacco_Smoking_Status]);

    #endregion CodeSystems

    #region Functions and Expressions (3)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = 8337256495588297023L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Smoking status observation")]
    public IEnumerable<Observation> Smoking_status_observation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Smoking_status_observation, Smoking_status_observation_Compute);

    private static readonly long _cacheIndex_Smoking_status_observation = -4432068073053488285L;

    private IEnumerable<Observation> Smoking_status_observation_Compute(CqlContext context)
    {
        CqlCode a_ = this.Tobacco_Smoking_Status(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? d_(Observation O) {
            Code<ObservationStatus> f_ = O?.StatusElement;
            string g_ = FHIRHelpers_4_3_000.Instance.ToString(context, f_);
            string[] h_ = [
                "final",
                "amended",
            ];
            bool? i_ = context.Operators.In<string>(g_, (IEnumerable<string>)h_);
            return i_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Lung cancer diagnosis")]
    public IEnumerable<Condition> Lung_cancer_diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Lung_cancer_diagnosis, Lung_cancer_diagnosis_Compute);

    private static readonly long _cacheIndex_Lung_cancer_diagnosis = 8408096397658502118L;

    private IEnumerable<Condition> Lung_cancer_diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Lung_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition C) {
            CodeableConcept e_ = C?.ClinicalStatus;
            CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Condition_Clinical_Status(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private MultipleResourcesExample_0_0_1() {}

    public static MultipleResourcesExample_0_0_1 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "MultipleResourcesExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

}
