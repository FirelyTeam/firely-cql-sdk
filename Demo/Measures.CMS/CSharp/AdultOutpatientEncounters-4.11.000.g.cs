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

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object rzzzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("AdultOutpatientEncounters-4.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzx_);

        return rzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzb_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzze_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzk_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzm_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzq_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isEncounterPerformed(context, szzzzzzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzzzzzu_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzy_ as object);
            bool? tzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzz_, "day");

            return tzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
