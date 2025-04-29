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
[CqlLibrary("AdultOutpatientEncounters", "4.11.000")]
public partial class AdultOutpatientEncounters_4_11_000 : ILibrary, ISingleton<AdultOutpatientEncounters_4_11_000>
{
    private AdultOutpatientEncounters_4_11_000() {}

    public static AdultOutpatientEncounters_4_11_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AdultOutpatientEncounters";
    public string Version => "4.11.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

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

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object izzzzzzzzzn_ = context.ResolveParameter("AdultOutpatientEncounters-4.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzo_);

        return izzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet izzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzs_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzu_ = context.Operators.Union<Encounter>(izzzzzzzzzr_, izzzzzzzzzt_);
        CqlValueSet izzzzzzzzzv_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzz_ = context.Operators.Union<Encounter>(izzzzzzzzzw_, izzzzzzzzzy_);
        IEnumerable<Encounter> jzzzzzzzzza_ = context.Operators.Union<Encounter>(izzzzzzzzzu_, izzzzzzzzzz_);
        CqlValueSet jzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzd_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzf_ = context.Operators.Union<Encounter>(jzzzzzzzzzc_, jzzzzzzzzze_);
        IEnumerable<Encounter> jzzzzzzzzzg_ = context.Operators.Union<Encounter>(jzzzzzzzzza_, jzzzzzzzzzf_);
        CqlValueSet jzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzj_ = context.Operators.Union<Encounter>(jzzzzzzzzzg_, jzzzzzzzzzi_);
        IEnumerable<Encounter> jzzzzzzzzzk_ = Status_1_8_000.Instance.isEncounterPerformed(context, jzzzzzzzzzj_);
        bool? jzzzzzzzzzl_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzn_ = this.Measurement_Period(context);
            Period jzzzzzzzzzo_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzo_);
            CqlInterval<CqlDateTime> jzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzp_ as object);
            bool? jzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzn_, jzzzzzzzzzq_, "day");

            return jzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzm_ = context.Operators.Where<Encounter>(jzzzzzzzzzk_, jzzzzzzzzzl_);

        return jzzzzzzzzzm_;
    }


    #endregion Expressions

}
