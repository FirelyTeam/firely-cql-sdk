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
[CqlLibrary("NCQAHospice", "1.0.0")]
public partial class NCQAHospice_1_0_0 : ILibrary, ISingleton<NCQAHospice_1_0_0>
{
    private NCQAHospice_1_0_0() {}

    public static NCQAHospice_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAHospice";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", null);

    [CqlValueSetDefinition("Hospice Intervention", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", valueSetVersion: null)]
    public CqlValueSet Hospice_Intervention(CqlContext _) => _Hospice_Intervention;
    private static readonly CqlValueSet _Hospice_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzzzk_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzzzzm_ = context.Operators.SingletonFrom<Patient>(yzzzzl_);

        return yzzzzm_;
    }


    [CqlExpressionDefinition("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter(CqlContext context)
    {
        CqlValueSet yzzzzn_ = this.Hospice_Intervention(context);
        IEnumerable<Procedure> yzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzp_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, yzzzzo_);
        bool? yzzzzq_(Procedure HospiceInt)
        {
            DataType zzzzza_ = HospiceInt?.Performed;
            CqlInterval<CqlDateTime> zzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, zzzzza_);
            CqlInterval<CqlDateTime> zzzzzc_ = this.Measurement_Period(context);
            bool? zzzzzd_ = context.Operators.Overlaps(zzzzzb_, zzzzzc_, default);

            return zzzzzd_;
        };
        IEnumerable<Procedure> yzzzzr_ = context.Operators.Where<Procedure>(yzzzzp_, yzzzzq_);
        bool? yzzzzs_ = context.Operators.Exists<Procedure>(yzzzzr_);
        CqlValueSet yzzzzt_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> yzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> yzzzzv_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, yzzzzu_);
        bool? yzzzzw_(Encounter HospiceEnc)
        {
            Period zzzzze_ = HospiceEnc?.Period;
            CqlInterval<CqlDateTime> zzzzzf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, zzzzze_ as object);
            CqlInterval<CqlDateTime> zzzzzg_ = this.Measurement_Period(context);
            bool? zzzzzh_ = context.Operators.Overlaps(zzzzzf_, zzzzzg_, default);

            return zzzzzh_;
        };
        IEnumerable<Encounter> yzzzzx_ = context.Operators.Where<Encounter>(yzzzzv_, yzzzzw_);
        bool? yzzzzy_ = context.Operators.Exists<Encounter>(yzzzzx_);
        bool? yzzzzz_ = context.Operators.Or(yzzzzs_, yzzzzy_);

        return yzzzzz_;
    }


    #endregion Expressions

}
