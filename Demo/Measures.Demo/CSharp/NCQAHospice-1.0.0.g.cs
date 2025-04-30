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
        object rzzzi_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzk_ = context.Operators.SingletonFrom<Patient>(rzzzj_);

        return rzzzk_;
    }


    [CqlExpressionDefinition("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter(CqlContext context)
    {
        CqlValueSet rzzzl_ = this.Hospice_Intervention(context);
        IEnumerable<Procedure> rzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> rzzzn_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, rzzzm_);
        bool? rzzzo_(Procedure HospiceInt)
        {
            DataType rzzzy_ = HospiceInt?.Performed;
            CqlInterval<CqlDateTime> rzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzy_);
            CqlInterval<CqlDateTime> szzza_ = this.Measurement_Period(context);
            bool? szzzb_ = context.Operators.Overlaps(rzzzz_, szzza_, default);

            return szzzb_;
        };
        IEnumerable<Procedure> rzzzp_ = context.Operators.Where<Procedure>(rzzzn_, rzzzo_);
        bool? rzzzq_ = context.Operators.Exists<Procedure>(rzzzp_);
        CqlValueSet rzzzr_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> rzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzt_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, rzzzs_);
        bool? rzzzu_(Encounter HospiceEnc)
        {
            Period szzzc_ = HospiceEnc?.Period;
            CqlInterval<CqlDateTime> szzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzc_ as object);
            CqlInterval<CqlDateTime> szzze_ = this.Measurement_Period(context);
            bool? szzzf_ = context.Operators.Overlaps(szzzd_, szzze_, default);

            return szzzf_;
        };
        IEnumerable<Encounter> rzzzv_ = context.Operators.Where<Encounter>(rzzzt_, rzzzu_);
        bool? rzzzw_ = context.Operators.Exists<Encounter>(rzzzv_);
        bool? rzzzx_ = context.Operators.Or(rzzzq_, rzzzw_);

        return rzzzx_;
    }


    #endregion Expressions

}
