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
        object bzzzn_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)bzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzzp_ = context.Operators.SingletonFrom<Patient>(bzzzo_);

        return bzzzp_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate bzzzq_ = context.Operators.Today();

        return bzzzq_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient bzzzr_ = this.Patient(context);
        Patient[] bzzzs_ = [
            bzzzr_,
        ];
        bool? bzzzt_(Patient P)
        {
            Code<AdministrativeGender> bzzzw_ = P?.GenderElement;
            string bzzzx_ = FHIRHelpers_4_3_000.Instance.ToString(context, bzzzw_);
            bool? bzzzy_ = context.Operators.Equal(bzzzx_, "male");
            FhirBoolean bzzzz_ = P?.ActiveElement;
            bool? czzza_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, bzzzz_);
            bool? czzzb_ = context.Operators.IsTrue(czzza_);
            bool? czzzc_ = context.Operators.And(bzzzy_, czzzb_);
            DataType czzzd_ = P?.Deceased;
            bool? czzze_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, czzzd_ as FhirBoolean);
            bool? czzzf_ = context.Operators.Not(czzze_);
            bool? czzzg_ = context.Operators.And(czzzc_, czzzf_);
            CodeableConcept czzzh_ = P?.MaritalStatus;
            CqlConcept czzzi_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzzh_);
            CqlValueSet czzzj_ = this.Marital_Status(context);
            bool? czzzk_ = context.Operators.ConceptInValueSet(czzzi_, czzzj_);
            bool? czzzl_ = context.Operators.And(czzzg_, czzzk_);

            return czzzl_;
        };
        IEnumerable<Patient> bzzzu_ = context.Operators.Where<Patient>((IEnumerable<Patient>)bzzzs_, bzzzt_);
        Patient bzzzv_ = context.Operators.SingletonFrom<Patient>(bzzzu_);

        return bzzzv_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient czzzm_ = this.Patient_Filter(context);
        Date czzzn_ = czzzm_?.BirthDateElement;

        return czzzn_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date czzzo_ = this.Patient_Birthdate(context);
        CqlDate czzzp_ = FHIRHelpers_4_3_000.Instance.ToDate(context, czzzo_);
        CqlDate czzzq_ = this.CurrentDate(context);
        int? czzzr_ = context.Operators.DurationBetween(czzzp_, czzzq_, "year");

        return czzzr_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? czzzs_ = this.Patient_Age_in_Years(context);
        int? czzzt_ = this.AgeThreshold(context);
        bool? czzzu_ = context.Operators.Greater(czzzs_, czzzt_);

        return czzzu_;
    }


    #endregion Expressions

}
