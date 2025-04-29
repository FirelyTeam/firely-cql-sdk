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
        object gzzzzzzzzzzzzzze_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient gzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
    {
        IEnumerable<Condition> gzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? gzzzzzzzzzzzzzzi_(Condition c)
        {
            CodeableConcept gzzzzzzzzzzzzzzk_ = c?.Code;
            List<Coding> gzzzzzzzzzzzzzzl_ = gzzzzzzzzzzzzzzk_?.Coding;
            bool? gzzzzzzzzzzzzzzm_(Coding coding)
            {
                CqlCode gzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode gzzzzzzzzzzzzzzv_ = this.Sucked_into_jet_engine(context);
                bool? gzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzv_);

                return gzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzzzzn_ = context.Operators.Where<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzo_ = context.Operators.Exists<Coding>(gzzzzzzzzzzzzzzn_);
            DataType gzzzzzzzzzzzzzzp_ = c?.Onset;
            CqlDateTime gzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, gzzzzzzzzzzzzzzp_ as FhirDateTime);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzr_, default);
            bool? gzzzzzzzzzzzzzzt_ = context.Operators.And(gzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzs_);

            return gzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
    {
        IEnumerable<Condition> gzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? gzzzzzzzzzzzzzzy_(Condition c)
        {
            CodeableConcept hzzzzzzzzzzzzzza_ = c?.Code;
            List<Coding> hzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzza_?.Coding;
            bool? hzzzzzzzzzzzzzzc_(Coding coding)
            {
                CqlCode hzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode hzzzzzzzzzzzzzzl_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? hzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzl_);

                return hzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Coding> hzzzzzzzzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzc_);
            bool? hzzzzzzzzzzzzzze_ = context.Operators.Exists<Coding>(hzzzzzzzzzzzzzzd_);
            DataType hzzzzzzzzzzzzzzf_ = c?.Onset;
            CqlDateTime hzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzzzf_ as FhirDateTime);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzh_, default);
            bool? hzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzi_);

            return hzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzzzzzzzzzzn_ = this.Jet_engine_conditions(context);
        bool? hzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzzzzzzzzzzp_ = this.Subsequent_encounters(context);
        bool? hzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzp_);

        return hzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
