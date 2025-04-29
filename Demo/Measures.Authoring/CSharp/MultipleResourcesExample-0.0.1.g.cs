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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("MultipleResourcesExample", "0.0.1")]
public partial class MultipleResourcesExample_0_0_1 : ILibrary, ISingleton<MultipleResourcesExample_0_0_1>
{
    private MultipleResourcesExample_0_0_1() {}

    public static MultipleResourcesExample_0_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "MultipleResourcesExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Lung Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", valueSetVersion: null)]
    public CqlValueSet Lung_Cancer(CqlContext _) => _Lung_Cancer;
    private static readonly CqlValueSet _Lung_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", null);

    [CqlValueSetDefinition("Condition Clinical Status", valueSetId: "http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", valueSetVersion: null)]
    public CqlValueSet Condition_Clinical_Status(CqlContext _) => _Condition_Clinical_Status;
    private static readonly CqlValueSet _Condition_Clinical_Status = new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Tobacco Smoking Status", codeId: "72166-2", codeSystem: "http://loinc.org")]
    public CqlCode Tobacco_Smoking_Status(CqlContext _) => _Tobacco_Smoking_Status;
    private static readonly CqlCode _Tobacco_Smoking_Status = new CqlCode("72166-2", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzi_ = context.Operators.SingletonFrom<Patient>(nzzh_);

        return nzzi_;
    }


    [CqlExpressionDefinition("Smoking status observation")]
    public IEnumerable<Observation> Smoking_status_observation(CqlContext context)
    {
        CqlCode nzzj_ = this.Tobacco_Smoking_Status(context);
        IEnumerable<CqlCode> nzzk_ = context.Operators.ToList<CqlCode>(nzzj_);
        IEnumerable<Observation> nzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzk_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? nzzm_(Observation O)
        {
            Code<ObservationStatus> nzzo_ = O?.StatusElement;
            string nzzp_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzo_);
            string[] nzzq_ = [
                "final",
                "amended",
            ];
            bool? nzzr_ = context.Operators.In<string>(nzzp_, nzzq_ as IEnumerable<string>);

            return nzzr_;
        };
        IEnumerable<Observation> nzzn_ = context.Operators.Where<Observation>(nzzl_, nzzm_);

        return nzzn_;
    }


    [CqlExpressionDefinition("Lung cancer diagnosis")]
    public IEnumerable<Condition> Lung_cancer_diagnosis(CqlContext context)
    {
        CqlValueSet nzzs_ = this.Lung_Cancer(context);
        IEnumerable<Condition> nzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzu_(Condition C)
        {
            CodeableConcept nzzw_ = C?.ClinicalStatus;
            CqlConcept nzzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, nzzw_);
            CqlValueSet nzzy_ = this.Condition_Clinical_Status(context);
            bool? nzzz_ = context.Operators.ConceptInValueSet(nzzx_, nzzy_);

            return nzzz_;
        };
        IEnumerable<Condition> nzzv_ = context.Operators.Where<Condition>(nzzt_, nzzu_);

        return nzzv_;
    }


    #endregion Expressions

}
