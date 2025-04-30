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
        object uzzy_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)uzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzza_ = context.Operators.SingletonFrom<Patient>(uzzz_);

        return vzza_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate vzzb_ = context.Operators.Today();

        return vzzb_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient vzzc_ = this.Patient(context);
        Patient[] vzzd_ = [
            vzzc_,
        ];
        bool? vzze_(Patient P)
        {
            Code<AdministrativeGender> vzzh_ = P?.GenderElement;
            string vzzi_ = FHIRHelpers_4_3_000.Instance.ToString(context, vzzh_);
            bool? vzzj_ = context.Operators.Equal(vzzi_, "male");
            FhirBoolean vzzk_ = P?.ActiveElement;
            bool? vzzl_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, vzzk_);
            bool? vzzm_ = context.Operators.IsTrue(vzzl_);
            bool? vzzn_ = context.Operators.And(vzzj_, vzzm_);
            DataType vzzo_ = P?.Deceased;
            bool? vzzp_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, vzzo_ as FhirBoolean);
            bool? vzzq_ = context.Operators.Not(vzzp_);
            bool? vzzr_ = context.Operators.And(vzzn_, vzzq_);
            CodeableConcept vzzs_ = P?.MaritalStatus;
            CqlConcept vzzt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, vzzs_);
            CqlValueSet vzzu_ = this.Marital_Status(context);
            bool? vzzv_ = context.Operators.ConceptInValueSet(vzzt_, vzzu_);
            bool? vzzw_ = context.Operators.And(vzzr_, vzzv_);

            return vzzw_;
        };
        IEnumerable<Patient> vzzf_ = context.Operators.Where<Patient>((IEnumerable<Patient>)vzzd_, vzze_);
        Patient vzzg_ = context.Operators.SingletonFrom<Patient>(vzzf_);

        return vzzg_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient vzzx_ = this.Patient_Filter(context);
        Date vzzy_ = vzzx_?.BirthDateElement;

        return vzzy_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date vzzz_ = this.Patient_Birthdate(context);
        CqlDate wzza_ = FHIRHelpers_4_3_000.Instance.ToDate(context, vzzz_);
        CqlDate wzzb_ = this.CurrentDate(context);
        int? wzzc_ = context.Operators.DurationBetween(wzza_, wzzb_, "year");

        return wzzc_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? wzzd_ = this.Patient_Age_in_Years(context);
        int? wzze_ = this.AgeThreshold(context);
        bool? wzzf_ = context.Operators.Greater(wzzd_, wzze_);

        return wzzf_;
    }


    #endregion Expressions

}
