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
        object tzzr_ = context.ResolveParameter("AdultOutpatientEncounters-4.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)tzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzt_ = context.Operators.SingletonFrom<Patient>(tzzs_);

        return tzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet tzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzw_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> tzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzy_ = context.Operators.Union<Encounter>(tzzv_, tzzx_);
        CqlValueSet tzzz_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzb_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzd_ = context.Operators.Union<Encounter>(uzza_, uzzc_);
        IEnumerable<Encounter> uzze_ = context.Operators.Union<Encounter>(tzzy_, uzzd_);
        CqlValueSet uzzf_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> uzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzh_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> uzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzj_ = context.Operators.Union<Encounter>(uzzg_, uzzi_);
        IEnumerable<Encounter> uzzk_ = context.Operators.Union<Encounter>(uzze_, uzzj_);
        CqlValueSet uzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> uzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzn_ = context.Operators.Union<Encounter>(uzzk_, uzzm_);
        IEnumerable<Encounter> uzzo_ = Status_1_8_000.Instance.isEncounterPerformed(context, uzzn_);
        bool? uzzp_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> uzzr_ = this.Measurement_Period(context);
            Period uzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> uzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzs_);
            CqlInterval<CqlDateTime> uzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzt_ as object);
            bool? uzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzr_, uzzu_, "day");

            return uzzv_;
        };
        IEnumerable<Encounter> uzzq_ = context.Operators.Where<Encounter>(uzzo_, uzzp_);

        return uzzq_;
    }


    #endregion Expressions

}
