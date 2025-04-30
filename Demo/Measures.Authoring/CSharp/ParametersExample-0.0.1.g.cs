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

    [CqlValueSetDefinition("Marital Status", valueSetId: "http://hl7.org/fhir/ValueSet/marital-status", valueSetVersion: null)]
    public CqlValueSet Marital_Status(CqlContext _) => _Marital_Status;
    private static readonly CqlValueSet _Marital_Status = new CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("AgeThreshold")]
    public int? AgeThreshold(CqlContext context)
    {
        object uzze_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)uzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient uzzg_ = context.Operators.SingletonFrom<Patient>(uzzf_);

        return uzzg_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate uzzh_ = context.Operators.Today();

        return uzzh_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient uzzi_ = this.Patient(context);
        Patient[] uzzj_ = [
            uzzi_,
        ];
        bool? uzzk_(Patient P)
        {
            Code<AdministrativeGender> uzzn_ = P?.GenderElement;
            string uzzo_ = FHIRHelpers_4_3_000.Instance.ToString(context, uzzn_);
            bool? uzzp_ = context.Operators.Equal(uzzo_, "male");
            FhirBoolean uzzq_ = P?.ActiveElement;
            bool? uzzr_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, uzzq_);
            bool? uzzs_ = context.Operators.IsTrue(uzzr_);
            bool? uzzt_ = context.Operators.And(uzzp_, uzzs_);
            DataType uzzu_ = P?.Deceased;
            bool? uzzv_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, uzzu_ as FhirBoolean);
            bool? uzzw_ = context.Operators.Not(uzzv_);
            bool? uzzx_ = context.Operators.And(uzzt_, uzzw_);
            CodeableConcept uzzy_ = P?.MaritalStatus;
            CqlConcept uzzz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzzy_);
            CqlValueSet vzza_ = this.Marital_Status(context);
            bool? vzzb_ = context.Operators.ConceptInValueSet(uzzz_, vzza_);
            bool? vzzc_ = context.Operators.And(uzzx_, vzzb_);

            return vzzc_;
        };
        IEnumerable<Patient> uzzl_ = context.Operators.Where<Patient>((IEnumerable<Patient>)uzzj_, uzzk_);
        Patient uzzm_ = context.Operators.SingletonFrom<Patient>(uzzl_);

        return uzzm_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient vzzd_ = this.Patient_Filter(context);
        Date vzze_ = vzzd_?.BirthDateElement;

        return vzze_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date vzzf_ = this.Patient_Birthdate(context);
        CqlDate vzzg_ = FHIRHelpers_4_3_000.Instance.ToDate(context, vzzf_);
        CqlDate vzzh_ = this.CurrentDate(context);
        int? vzzi_ = context.Operators.DurationBetween(vzzg_, vzzh_, "year");

        return vzzi_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? vzzj_ = this.Patient_Age_in_Years(context);
        int? vzzk_ = this.AgeThreshold(context);
        bool? vzzl_ = context.Operators.Greater(vzzj_, vzzk_);

        return vzzl_;
    }


    #endregion Expressions

}
