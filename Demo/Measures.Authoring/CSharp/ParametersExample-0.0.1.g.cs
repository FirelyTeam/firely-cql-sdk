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
        object lzzz_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)lzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzb_ = context.Operators.SingletonFrom<Patient>(mzza_);

        return mzzb_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate mzzc_ = context.Operators.Today();

        return mzzc_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient mzzd_ = this.Patient(context);
        Patient[] mzze_ = [
            mzzd_,
        ];
        bool? mzzf_(Patient P)
        {
            Code<AdministrativeGender> mzzi_ = P?.GenderElement;
            string mzzj_ = FHIRHelpers_4_3_000.Instance.ToString(context, mzzi_);
            bool? mzzk_ = context.Operators.Equal(mzzj_, "male");
            FhirBoolean mzzl_ = P?.ActiveElement;
            bool? mzzm_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, mzzl_);
            bool? mzzn_ = context.Operators.IsTrue(mzzm_);
            bool? mzzo_ = context.Operators.And(mzzk_, mzzn_);
            DataType mzzp_ = P?.Deceased;
            bool? mzzq_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, mzzp_ as FhirBoolean);
            bool? mzzr_ = context.Operators.Not(mzzq_);
            bool? mzzs_ = context.Operators.And(mzzo_, mzzr_);
            CodeableConcept mzzt_ = P?.MaritalStatus;
            CqlConcept mzzu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, mzzt_);
            CqlValueSet mzzv_ = this.Marital_Status(context);
            bool? mzzw_ = context.Operators.ConceptInValueSet(mzzu_, mzzv_);
            bool? mzzx_ = context.Operators.And(mzzs_, mzzw_);

            return mzzx_;
        };
        IEnumerable<Patient> mzzg_ = context.Operators.Where<Patient>((IEnumerable<Patient>)mzze_, mzzf_);
        Patient mzzh_ = context.Operators.SingletonFrom<Patient>(mzzg_);

        return mzzh_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient mzzy_ = this.Patient_Filter(context);
        Date mzzz_ = mzzy_?.BirthDateElement;

        return mzzz_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date nzza_ = this.Patient_Birthdate(context);
        CqlDate nzzb_ = FHIRHelpers_4_3_000.Instance.ToDate(context, nzza_);
        CqlDate nzzc_ = this.CurrentDate(context);
        int? nzzd_ = context.Operators.DurationBetween(nzzb_, nzzc_, "year");

        return nzzd_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? nzze_ = this.Patient_Age_in_Years(context);
        int? nzzf_ = this.AgeThreshold(context);
        bool? nzzg_ = context.Operators.Greater(nzze_, nzzf_);

        return nzzg_;
    }


    #endregion Expressions

}
