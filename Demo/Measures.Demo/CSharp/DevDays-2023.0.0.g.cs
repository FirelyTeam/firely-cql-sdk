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
    private static readonly CqlCode _Sucked_into_jet_engine = new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default);

    [CqlCodeDefinition("Sucked into jet engine, subsequent encounter", codeId: "V97.33XD", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext _) => _Sucked_into_jet_engine__subsequent_encounter;
    private static readonly CqlCode _Sucked_into_jet_engine__subsequent_encounter = new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10")]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object nzzzzzzj_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)nzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzzzzzl_ = context.Operators.SingletonFrom<Patient>(nzzzzzzk_);

        return nzzzzzzl_;
    }


    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
    {
        IEnumerable<Condition> nzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzn_(Condition c)
        {
            CodeableConcept nzzzzzzp_ = c?.Code;
            List<Coding> nzzzzzzq_ = nzzzzzzp_?.Coding;
            bool? nzzzzzzr_(Coding coding)
            {
                CqlCode nzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode ozzzzzza_ = this.Sucked_into_jet_engine(context);
                bool? ozzzzzzb_ = context.Operators.Equivalent(nzzzzzzz_, ozzzzzza_);

                return ozzzzzzb_;
            };
            IEnumerable<Coding> nzzzzzzs_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzq_, nzzzzzzr_);
            bool? nzzzzzzt_ = context.Operators.Exists<Coding>(nzzzzzzs_);
            DataType nzzzzzzu_ = c?.Onset;
            CqlDateTime nzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzu_ as FhirDateTime);
            CqlInterval<CqlDateTime> nzzzzzzw_ = this.Measurement_Period(context);
            bool? nzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzv_, nzzzzzzw_, default);
            bool? nzzzzzzy_ = context.Operators.And(nzzzzzzt_, nzzzzzzx_);

            return nzzzzzzy_;
        };
        IEnumerable<Condition> nzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzm_, nzzzzzzn_);

        return nzzzzzzo_;
    }


    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ozzzzzzd_(Condition c)
        {
            CodeableConcept ozzzzzzf_ = c?.Code;
            List<Coding> ozzzzzzg_ = ozzzzzzf_?.Coding;
            bool? ozzzzzzh_(Coding coding)
            {
                CqlCode ozzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode ozzzzzzq_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? ozzzzzzr_ = context.Operators.Equivalent(ozzzzzzp_, ozzzzzzq_);

                return ozzzzzzr_;
            };
            IEnumerable<Coding> ozzzzzzi_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzzg_, ozzzzzzh_);
            bool? ozzzzzzj_ = context.Operators.Exists<Coding>(ozzzzzzi_);
            DataType ozzzzzzk_ = c?.Onset;
            CqlDateTime ozzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ozzzzzzk_ as FhirDateTime);
            CqlInterval<CqlDateTime> ozzzzzzm_ = this.Measurement_Period(context);
            bool? ozzzzzzn_ = context.Operators.In<CqlDateTime>(ozzzzzzl_, ozzzzzzm_, default);
            bool? ozzzzzzo_ = context.Operators.And(ozzzzzzj_, ozzzzzzn_);

            return ozzzzzzo_;
        };
        IEnumerable<Condition> ozzzzzze_ = context.Operators.Where<Condition>(ozzzzzzc_, ozzzzzzd_);

        return ozzzzzze_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzs_ = this.Jet_engine_conditions(context);
        bool? ozzzzzzt_ = context.Operators.Exists<Condition>(ozzzzzzs_);

        return ozzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzu_ = this.Subsequent_encounters(context);
        bool? ozzzzzzv_ = context.Operators.Exists<Condition>(ozzzzzzu_);

        return ozzzzzzv_;
    }


    #endregion Expressions

}
