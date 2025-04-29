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
[CqlLibrary("AdultOutpatientEncountersFHIR4", "2.2.000")]
public partial class AdultOutpatientEncountersFHIR4_2_2_000 : ILibrary, ISingleton<AdultOutpatientEncountersFHIR4_2_2_000>
{
    private AdultOutpatientEncountersFHIR4_2_2_000() {}

    public static AdultOutpatientEncountersFHIR4_2_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AdultOutpatientEncountersFHIR4";
    public string Version => "2.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzn_ = context.ResolveParameter("AdultOutpatientEncountersFHIR4-2.2.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzp_ = context.Operators.SingletonFrom<Patient>(yzo_);

        return yzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet yzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet yzs_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> yzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> yzu_ = context.Operators.Union<Encounter>(yzr_, yzt_);
        CqlValueSet yzv_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> yzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet yzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> yzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> yzz_ = context.Operators.Union<Encounter>(yzw_, yzy_);
        IEnumerable<Encounter> zza_ = context.Operators.Union<Encounter>(yzu_, yzz_);
        CqlValueSet zzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> zzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzd_ = context.Operators.Union<Encounter>(zza_, zzc_);
        bool? zze_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> zzg_ = ValidEncounter?.StatusElement;
            string zzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzg_);
            bool? zzi_ = context.Operators.Equal(zzh_, "finished");
            CqlInterval<CqlDateTime> zzj_ = this.Measurement_Period(context);
            Period zzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> zzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzk_ as object);
            bool? zzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzj_, zzl_, default);
            bool? zzn_ = context.Operators.And(zzi_, zzm_);

            return zzn_;
        };
        IEnumerable<Encounter> zzf_ = context.Operators.Where<Encounter>(zzd_, zze_);

        return zzf_;
    }


    #endregion Expressions

}
