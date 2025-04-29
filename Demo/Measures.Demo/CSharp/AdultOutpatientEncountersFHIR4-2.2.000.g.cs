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

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object gzzzq_ = context.ResolveParameter("AdultOutpatientEncountersFHIR4-2.2.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)gzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient gzzzs_ = context.Operators.SingletonFrom<Patient>(gzzzr_);

        return gzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet gzzzt_ = this.Office_Visit(context);
        IEnumerable<Encounter> gzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet gzzzv_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> gzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> gzzzx_ = context.Operators.Union<Encounter>(gzzzu_, gzzzw_);
        CqlValueSet gzzzy_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzza_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> hzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> hzzzc_ = context.Operators.Union<Encounter>(gzzzz_, hzzzb_);
        IEnumerable<Encounter> hzzzd_ = context.Operators.Union<Encounter>(gzzzx_, hzzzc_);
        CqlValueSet hzzze_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> hzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> hzzzg_ = context.Operators.Union<Encounter>(hzzzd_, hzzzf_);
        bool? hzzzh_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> hzzzj_ = ValidEncounter?.StatusElement;
            string hzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzj_);
            bool? hzzzl_ = context.Operators.Equal(hzzzk_, "finished");
            CqlInterval<CqlDateTime> hzzzm_ = this.Measurement_Period(context);
            Period hzzzn_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzn_ as object);
            bool? hzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzm_, hzzzo_, default);
            bool? hzzzq_ = context.Operators.And(hzzzl_, hzzzp_);

            return hzzzq_;
        };
        IEnumerable<Encounter> hzzzi_ = context.Operators.Where<Encounter>(hzzzg_, hzzzh_);

        return hzzzi_;
    }


    #endregion Expressions

}
