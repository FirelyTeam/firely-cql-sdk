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
[CqlLibrary("ParametersExample", "0.0.1")]
public partial class ParametersExample_0_0_1 : ILibrary, ISingleton<ParametersExample_0_0_1>
{
    private ParametersExample_0_0_1() {}

    public static ParametersExample_0_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ParametersExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Marital Status
    [CqlValueSetDefinition(
        definitionName: "Marital Status",
        valueSetId: "http://hl7.org/fhir/ValueSet/marital-status",
        valueSetVersion: null)]
    public CqlValueSet Marital_Status(CqlContext context) => _Marital_Status;

    private static readonly CqlValueSet _Marital_Status = new CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "AgeThreshold")]
    public int? AgeThreshold(CqlContext context)
    {
        object szh_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)szh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient szj_ = context.Operators.SingletonFrom<Patient>(szi_);

        return szj_;
    }


    [CqlExpressionDefinition(
        definitionName: "CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate szk_ = context.Operators.Today();

        return szk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient szl_ = this.Patient(context);
        Patient[] szm_ = [
            szl_,
        ];
        bool? szn_(Patient P)
        {
            Code<AdministrativeGender> szq_ = P?.GenderElement;
            string szr_ = FHIRHelpers_4_3_000.Instance.ToString(context, szq_);
            bool? szs_ = context.Operators.Equal(szr_, "male");
            FhirBoolean szt_ = P?.ActiveElement;
            bool? szu_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, szt_);
            bool? szv_ = context.Operators.IsTrue(szu_);
            bool? szw_ = context.Operators.And(szs_, szv_);
            DataType szx_ = P?.Deceased;
            bool? szy_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, szx_ as FhirBoolean);
            bool? szz_ = context.Operators.Not(szy_);
            bool? tza_ = context.Operators.And(szw_, szz_);
            CodeableConcept tzb_ = P?.MaritalStatus;
            CqlConcept tzc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, tzb_);
            CqlValueSet tzd_ = this.Marital_Status(context);
            bool? tze_ = context.Operators.ConceptInValueSet(tzc_, tzd_);
            bool? tzf_ = context.Operators.And(tza_, tze_);

            return tzf_;
        };
        IEnumerable<Patient> szo_ = context.Operators.Where<Patient>((IEnumerable<Patient>)szm_, szn_);
        Patient szp_ = context.Operators.SingletonFrom<Patient>(szo_);

        return szp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient tzg_ = this.Patient_Filter(context);
        Date tzh_ = tzg_?.BirthDateElement;

        return tzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date tzi_ = this.Patient_Birthdate(context);
        CqlDate tzj_ = FHIRHelpers_4_3_000.Instance.ToDate(context, tzi_);
        CqlDate tzk_ = this.CurrentDate(context);
        int? tzl_ = context.Operators.DurationBetween(tzj_, tzk_, "year");

        return tzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? tzm_ = this.Patient_Age_in_Years(context);
        int? tzn_ = this.AgeThreshold(context);
        bool? tzo_ = context.Operators.Greater(tzm_, tzn_);

        return tzo_;
    }


    #endregion Expressions

}
