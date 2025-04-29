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

    #region Code: Sucked into jet engine
    [CqlCodeDefinition(
        definitionName: "Sucked into jet engine",
        codeId: "V97.33",
        codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine(CqlContext context) => _Sucked_into_jet_engine;

    private static readonly CqlCode _Sucked_into_jet_engine = new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default);
    #endregion

    #region Code: Sucked into jet engine, subsequent encounter
    [CqlCodeDefinition(
        definitionName: "Sucked into jet engine, subsequent encounter",
        codeId: "V97.33XD",
        codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext context) => _Sucked_into_jet_engine__subsequent_encounter;

    private static readonly CqlCode _Sucked_into_jet_engine__subsequent_encounter = new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ICD10")]
    public CqlCode[] ICD10(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzb_ = [
            new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default),
            new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default),
        ];

        return jzzzzzzzzzzzzzzb_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object jzzzzzzzzzzzzzzc_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient jzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
    {
        IEnumerable<Condition> jzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzzzzzzzzzzzg_(Condition c)
        {
            CodeableConcept jzzzzzzzzzzzzzzi_ = c?.Code;
            List<Coding> jzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzi_?.Coding;
            bool? jzzzzzzzzzzzzzzk_(Coding coding)
            {
                CqlCode jzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode jzzzzzzzzzzzzzzt_ = this.Sucked_into_jet_engine(context);
                bool? jzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(jzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzt_);

                return jzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Coding> jzzzzzzzzzzzzzzl_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzk_);
            bool? jzzzzzzzzzzzzzzm_ = context.Operators.Exists<Coding>(jzzzzzzzzzzzzzzl_);
            DataType jzzzzzzzzzzzzzzn_ = c?.Onset;
            CqlDateTime jzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzn_ as FhirDateTime);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzp_, default);
            bool? jzzzzzzzzzzzzzzr_ = context.Operators.And(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
    {
        IEnumerable<Condition> jzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzzzzzzzzzzzw_(Condition c)
        {
            CodeableConcept jzzzzzzzzzzzzzzy_ = c?.Code;
            List<Coding> jzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzy_?.Coding;
            bool? kzzzzzzzzzzzzzza_(Coding coding)
            {
                CqlCode kzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode kzzzzzzzzzzzzzzj_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? kzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzj_);

                return kzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Coding> kzzzzzzzzzzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzzc_ = context.Operators.Exists<Coding>(kzzzzzzzzzzzzzzb_);
            DataType kzzzzzzzzzzzzzzd_ = c?.Onset;
            CqlDateTime kzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, kzzzzzzzzzzzzzzd_ as FhirDateTime);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzf_, default);
            bool? kzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzg_);

            return kzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> kzzzzzzzzzzzzzzl_ = this.Jet_engine_conditions(context);
        bool? kzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Condition> kzzzzzzzzzzzzzzn_ = this.Subsequent_encounters(context);
        bool? kzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
