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
        object vzza_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)vzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzc_ = context.Operators.SingletonFrom<Patient>(vzzb_);

        return vzzc_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate vzzd_ = context.Operators.Today();

        return vzzd_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient vzze_ = this.Patient(context);
        Patient[] vzzf_ = [
            vzze_,
        ];
        bool? vzzg_(Patient P)
        {
            Code<AdministrativeGender> vzzj_ = P?.GenderElement;
            string vzzk_ = FHIRHelpers_4_3_000.Instance.ToString(context, vzzj_);
            bool? vzzl_ = context.Operators.Equal(vzzk_, "male");
            FhirBoolean vzzm_ = P?.ActiveElement;
            bool? vzzn_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, vzzm_);
            bool? vzzo_ = context.Operators.IsTrue(vzzn_);
            bool? vzzp_ = context.Operators.And(vzzl_, vzzo_);
            DataType vzzq_ = P?.Deceased;
            bool? vzzr_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, vzzq_ as FhirBoolean);
            bool? vzzs_ = context.Operators.Not(vzzr_);
            bool? vzzt_ = context.Operators.And(vzzp_, vzzs_);
            CodeableConcept vzzu_ = P?.MaritalStatus;
            CqlConcept vzzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, vzzu_);
            CqlValueSet vzzw_ = this.Marital_Status(context);
            bool? vzzx_ = context.Operators.ConceptInValueSet(vzzv_, vzzw_);
            bool? vzzy_ = context.Operators.And(vzzt_, vzzx_);

            return vzzy_;
        };
        IEnumerable<Patient> vzzh_ = context.Operators.Where<Patient>((IEnumerable<Patient>)vzzf_, vzzg_);
        Patient vzzi_ = context.Operators.SingletonFrom<Patient>(vzzh_);

        return vzzi_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient vzzz_ = this.Patient_Filter(context);
        Date wzza_ = vzzz_?.BirthDateElement;

        return wzza_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date wzzb_ = this.Patient_Birthdate(context);
        CqlDate wzzc_ = FHIRHelpers_4_3_000.Instance.ToDate(context, wzzb_);
        CqlDate wzzd_ = this.CurrentDate(context);
        int? wzze_ = context.Operators.DurationBetween(wzzc_, wzzd_, "year");

        return wzze_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? wzzf_ = this.Patient_Age_in_Years(context);
        int? wzzg_ = this.AgeThreshold(context);
        bool? wzzh_ = context.Operators.Greater(wzzf_, wzzg_);

        return wzzh_;
    }


    #endregion Expressions

}
