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
        object wzzzzze_ = context.ResolveParameter("AdultOutpatientEncounters-4.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)wzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzg_ = context.Operators.SingletonFrom<Patient>(wzzzzzf_);

        return wzzzzzg_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzh_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzj_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> wzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzl_ = context.Operators.Union<Encounter>(wzzzzzi_, wzzzzzk_);
        CqlValueSet wzzzzzm_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzo_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzq_ = context.Operators.Union<Encounter>(wzzzzzn_, wzzzzzp_);
        IEnumerable<Encounter> wzzzzzr_ = context.Operators.Union<Encounter>(wzzzzzl_, wzzzzzq_);
        CqlValueSet wzzzzzs_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> wzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzu_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> wzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzw_ = context.Operators.Union<Encounter>(wzzzzzt_, wzzzzzv_);
        IEnumerable<Encounter> wzzzzzx_ = context.Operators.Union<Encounter>(wzzzzzr_, wzzzzzw_);
        CqlValueSet wzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> wzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzza_ = context.Operators.Union<Encounter>(wzzzzzx_, wzzzzzz_);
        IEnumerable<Encounter> xzzzzzb_ = Status_1_8_000.Instance.isEncounterPerformed(context, xzzzzza_);
        bool? xzzzzzc_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> xzzzzze_ = this.Measurement_Period(context);
            Period xzzzzzf_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzg_ as object);
            bool? xzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzze_, xzzzzzh_, "day");

            return xzzzzzi_;
        };
        IEnumerable<Encounter> xzzzzzd_ = context.Operators.Where<Encounter>(xzzzzzb_, xzzzzzc_);

        return xzzzzzd_;
    }


    #endregion Expressions

}
