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
        object nzzzzzzzzzzzzzzv_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzw_);

        return nzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzy_ = this.Hospice_Intervention(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ozzzzzzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, nzzzzzzzzzzzzzzz_);
        bool? ozzzzzzzzzzzzzzb_(Procedure HospiceInt)
        {
            DataType ozzzzzzzzzzzzzzl_ = HospiceInt?.Performed;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzo_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzn_, default);

            return ozzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzb_);
        bool? ozzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzc_);
        CqlValueSet ozzzzzzzzzzzzzze_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, ozzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzh_(Encounter HospiceEnc)
        {
            Period ozzzzzzzzzzzzzzp_ = HospiceEnc?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzp_ as object);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzs_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzr_, default);

            return ozzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzh_);
        bool? ozzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzi_);
        bool? ozzzzzzzzzzzzzzk_ = context.Operators.Or(ozzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
