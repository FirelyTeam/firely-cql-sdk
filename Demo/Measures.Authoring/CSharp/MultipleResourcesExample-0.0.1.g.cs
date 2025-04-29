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

    #region ValueSet: Lung Cancer
    [CqlValueSetDefinition(
        definitionName: "Lung Cancer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89",
        valueSetVersion: null)]
    public CqlValueSet Lung_Cancer(CqlContext context) => _Lung_Cancer;

    private static readonly CqlValueSet _Lung_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", null);
    #endregion

    #region ValueSet: Condition Clinical Status
    [CqlValueSetDefinition(
        definitionName: "Condition Clinical Status",
        valueSetId: "http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical",
        valueSetVersion: null)]
    public CqlValueSet Condition_Clinical_Status(CqlContext context) => _Condition_Clinical_Status;

    private static readonly CqlValueSet _Condition_Clinical_Status = new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Tobacco Smoking Status
    [CqlCodeDefinition(
        definitionName: "Tobacco Smoking Status",
        codeId: "72166-2",
        codeSystem: "http://loinc.org")]
    public CqlCode Tobacco_Smoking_Status(CqlContext context) => _Tobacco_Smoking_Status;

    private static readonly CqlCode _Tobacco_Smoking_Status = new CqlCode("72166-2", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] bzx_ = [
            new CqlCode("72166-2", "http://loinc.org", default, default),
        ];

        return bzx_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzz_ = context.Operators.SingletonFrom<Patient>(bzy_);

        return bzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Smoking status observation")]
    public IEnumerable<Observation> Smoking_status_observation(CqlContext context)
    {
        CqlCode cza_ = this.Tobacco_Smoking_Status(context);
        IEnumerable<CqlCode> czb_ = context.Operators.ToList<CqlCode>(cza_);
        IEnumerable<Observation> czc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czb_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czd_(Observation O)
        {
            Code<ObservationStatus> czf_ = O?.StatusElement;
            string czg_ = FHIRHelpers_4_3_000.Instance.ToString(context, czf_);
            string[] czh_ = [
                "final",
                "amended",
            ];
            bool? czi_ = context.Operators.In<string>(czg_, czh_ as IEnumerable<string>);

            return czi_;
        };
        IEnumerable<Observation> cze_ = context.Operators.Where<Observation>(czc_, czd_);

        return cze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Lung cancer diagnosis")]
    public IEnumerable<Condition> Lung_cancer_diagnosis(CqlContext context)
    {
        CqlValueSet czj_ = this.Lung_Cancer(context);
        IEnumerable<Condition> czk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? czl_(Condition C)
        {
            CodeableConcept czn_ = C?.ClinicalStatus;
            CqlConcept czo_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czn_);
            CqlValueSet czp_ = this.Condition_Clinical_Status(context);
            bool? czq_ = context.Operators.ConceptInValueSet(czo_, czp_);

            return czq_;
        };
        IEnumerable<Condition> czm_ = context.Operators.Where<Condition>(czk_, czl_);

        return czm_;
    }


    #endregion Expressions

}
