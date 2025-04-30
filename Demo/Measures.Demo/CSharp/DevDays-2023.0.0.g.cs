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
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10", null,
          _Sucked_into_jet_engine,
          _Sucked_into_jet_engine__subsequent_encounter);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ozzzzzzzzq_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzr_);

        return ozzzzzzzzs_;
    }


    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
    {
        IEnumerable<Condition> ozzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ozzzzzzzzu_(Condition c)
        {
            CodeableConcept ozzzzzzzzw_ = c?.Code;
            List<Coding> ozzzzzzzzx_ = ozzzzzzzzw_?.Coding;
            bool? ozzzzzzzzy_(Coding coding)
            {
                CqlCode pzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode pzzzzzzzzh_ = this.Sucked_into_jet_engine(context);
                bool? pzzzzzzzzi_ = context.Operators.Equivalent(pzzzzzzzzg_, pzzzzzzzzh_);

                return pzzzzzzzzi_;
            };
            IEnumerable<Coding> ozzzzzzzzz_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzzzzx_, ozzzzzzzzy_);
            bool? pzzzzzzzza_ = context.Operators.Exists<Coding>(ozzzzzzzzz_);
            DataType pzzzzzzzzb_ = c?.Onset;
            CqlDateTime pzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzzzzzzzb_ as FhirDateTime);
            CqlInterval<CqlDateTime> pzzzzzzzzd_ = this.Measurement_Period(context);
            bool? pzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzc_, pzzzzzzzzd_, default);
            bool? pzzzzzzzzf_ = context.Operators.And(pzzzzzzzza_, pzzzzzzzze_);

            return pzzzzzzzzf_;
        };
        IEnumerable<Condition> ozzzzzzzzv_ = context.Operators.Where<Condition>(ozzzzzzzzt_, ozzzzzzzzu_);

        return ozzzzzzzzv_;
    }


    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
    {
        IEnumerable<Condition> pzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzzzzzzzzk_(Condition c)
        {
            CodeableConcept pzzzzzzzzm_ = c?.Code;
            List<Coding> pzzzzzzzzn_ = pzzzzzzzzm_?.Coding;
            bool? pzzzzzzzzo_(Coding coding)
            {
                CqlCode pzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode pzzzzzzzzx_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? pzzzzzzzzy_ = context.Operators.Equivalent(pzzzzzzzzw_, pzzzzzzzzx_);

                return pzzzzzzzzy_;
            };
            IEnumerable<Coding> pzzzzzzzzp_ = context.Operators.Where<Coding>((IEnumerable<Coding>)pzzzzzzzzn_, pzzzzzzzzo_);
            bool? pzzzzzzzzq_ = context.Operators.Exists<Coding>(pzzzzzzzzp_);
            DataType pzzzzzzzzr_ = c?.Onset;
            CqlDateTime pzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzzzzzzzr_ as FhirDateTime);
            CqlInterval<CqlDateTime> pzzzzzzzzt_ = this.Measurement_Period(context);
            bool? pzzzzzzzzu_ = context.Operators.In<CqlDateTime>(pzzzzzzzzs_, pzzzzzzzzt_, default);
            bool? pzzzzzzzzv_ = context.Operators.And(pzzzzzzzzq_, pzzzzzzzzu_);

            return pzzzzzzzzv_;
        };
        IEnumerable<Condition> pzzzzzzzzl_ = context.Operators.Where<Condition>(pzzzzzzzzj_, pzzzzzzzzk_);

        return pzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> pzzzzzzzzz_ = this.Jet_engine_conditions(context);
        bool? qzzzzzzzza_ = context.Operators.Exists<Condition>(pzzzzzzzzz_);

        return qzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Condition> qzzzzzzzzb_ = this.Subsequent_encounters(context);
        bool? qzzzzzzzzc_ = context.Operators.Exists<Condition>(qzzzzzzzzb_);

        return qzzzzzzzzc_;
    }


    #endregion Expressions

}
