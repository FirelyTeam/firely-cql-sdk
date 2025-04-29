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
        object tzzzzzs_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)tzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzzzu_ = context.Operators.SingletonFrom<Patient>(tzzzzzt_);

        return tzzzzzu_;
    }


    [CqlExpressionDefinition("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter(CqlContext context)
    {
        CqlValueSet tzzzzzv_ = this.Hospice_Intervention(context);
        IEnumerable<Procedure> tzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> tzzzzzx_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, tzzzzzw_);
        bool? tzzzzzy_(Procedure HospiceInt)
        {
            DataType uzzzzzi_ = HospiceInt?.Performed;
            CqlInterval<CqlDateTime> uzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, uzzzzzi_);
            CqlInterval<CqlDateTime> uzzzzzk_ = this.Measurement_Period(context);
            bool? uzzzzzl_ = context.Operators.Overlaps(uzzzzzj_, uzzzzzk_, default);

            return uzzzzzl_;
        };
        IEnumerable<Procedure> tzzzzzz_ = context.Operators.Where<Procedure>(tzzzzzx_, tzzzzzy_);
        bool? uzzzzza_ = context.Operators.Exists<Procedure>(tzzzzzz_);
        CqlValueSet uzzzzzb_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> uzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzzzd_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, uzzzzzc_);
        bool? uzzzzze_(Encounter HospiceEnc)
        {
            Period uzzzzzm_ = HospiceEnc?.Period;
            CqlInterval<CqlDateTime> uzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, uzzzzzm_ as object);
            CqlInterval<CqlDateTime> uzzzzzo_ = this.Measurement_Period(context);
            bool? uzzzzzp_ = context.Operators.Overlaps(uzzzzzn_, uzzzzzo_, default);

            return uzzzzzp_;
        };
        IEnumerable<Encounter> uzzzzzf_ = context.Operators.Where<Encounter>(uzzzzzd_, uzzzzze_);
        bool? uzzzzzg_ = context.Operators.Exists<Encounter>(uzzzzzf_);
        bool? uzzzzzh_ = context.Operators.Or(uzzzzza_, uzzzzzg_);

        return uzzzzzh_;
    }


    #endregion Expressions

}
