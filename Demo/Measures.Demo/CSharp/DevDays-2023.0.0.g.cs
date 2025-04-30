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
[CqlLibrary("DevDays", "2023.0.0")]
public partial class DevDays_2023_0_0 : ILibrary, ISingleton<DevDays_2023_0_0>
{
    private DevDays_2023_0_0() {}

    public static DevDays_2023_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DevDays";
    public string Version => "2023.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("Sucked into jet engine", codeId: "V97.33", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine(CqlContext _) => _Sucked_into_jet_engine;
    private static readonly CqlCode _Sucked_into_jet_engine = new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10");

    [CqlCodeDefinition("Sucked into jet engine, subsequent encounter", codeId: "V97.33XD", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext _) => _Sucked_into_jet_engine__subsequent_encounter;
    private static readonly CqlCode _Sucked_into_jet_engine__subsequent_encounter = new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10")]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10", null, [
          _Sucked_into_jet_engine,
          _Sucked_into_jet_engine__subsequent_encounter]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object mzzzzzzzzzzzt_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzu_);

        return mzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
    {
        IEnumerable<Condition> mzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzzzzzzzzzx_(Condition c)
        {
            CodeableConcept mzzzzzzzzzzzz_ = c?.Code;
            List<Coding> nzzzzzzzzzzza_ = mzzzzzzzzzzzz_?.Coding;
            bool? nzzzzzzzzzzzb_(Coding coding)
            {
                CqlCode nzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode nzzzzzzzzzzzk_ = this.Sucked_into_jet_engine(context);
                bool? nzzzzzzzzzzzl_ = context.Operators.Equivalent(nzzzzzzzzzzzj_, nzzzzzzzzzzzk_);

                return nzzzzzzzzzzzl_;
            };
            IEnumerable<Coding> nzzzzzzzzzzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzzzzzza_, nzzzzzzzzzzzb_);
            bool? nzzzzzzzzzzzd_ = context.Operators.Exists<Coding>(nzzzzzzzzzzzc_);
            DataType nzzzzzzzzzzze_ = c?.Onset;
            CqlDateTime nzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzze_ as FhirDateTime);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzf_, nzzzzzzzzzzzg_, default);
            bool? nzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzd_, nzzzzzzzzzzzh_);

            return nzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzy_ = context.Operators.Where<Condition>(mzzzzzzzzzzzw_, mzzzzzzzzzzzx_);

        return mzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
    {
        IEnumerable<Condition> nzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzzzn_(Condition c)
        {
            CodeableConcept nzzzzzzzzzzzp_ = c?.Code;
            List<Coding> nzzzzzzzzzzzq_ = nzzzzzzzzzzzp_?.Coding;
            bool? nzzzzzzzzzzzr_(Coding coding)
            {
                CqlCode nzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode ozzzzzzzzzzza_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? ozzzzzzzzzzzb_ = context.Operators.Equivalent(nzzzzzzzzzzzz_, ozzzzzzzzzzza_);

                return ozzzzzzzzzzzb_;
            };
            IEnumerable<Coding> nzzzzzzzzzzzs_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzq_, nzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzt_ = context.Operators.Exists<Coding>(nzzzzzzzzzzzs_);
            DataType nzzzzzzzzzzzu_ = c?.Onset;
            CqlDateTime nzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzzu_ as FhirDateTime);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzv_, nzzzzzzzzzzzw_, default);
            bool? nzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzt_, nzzzzzzzzzzzx_);

            return nzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzm_, nzzzzzzzzzzzn_);

        return nzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzzzzzzc_ = this.Jet_engine_conditions(context);
        bool? ozzzzzzzzzzzd_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzc_);

        return ozzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzzzzzze_ = this.Subsequent_encounters(context);
        bool? ozzzzzzzzzzzf_ = context.Operators.Exists<Condition>(ozzzzzzzzzzze_);

        return ozzzzzzzzzzzf_;
    }


    #endregion Expressions

}
