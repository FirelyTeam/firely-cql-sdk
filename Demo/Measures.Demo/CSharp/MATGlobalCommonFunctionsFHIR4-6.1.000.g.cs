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
[CqlLibrary("MATGlobalCommonFunctionsFHIR4", "6.1.000")]
public partial class MATGlobalCommonFunctionsFHIR4_6_1_000 : ILibrary, ISingleton<MATGlobalCommonFunctionsFHIR4_6_1_000>
{
    private MATGlobalCommonFunctionsFHIR4_6_1_000() {}

    public static MATGlobalCommonFunctionsFHIR4_6_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "MATGlobalCommonFunctionsFHIR4";
    public string Version => "6.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Present on Admission or Clinically Undetermined
    [CqlValueSetDefinition(
        definitionName: "Present on Admission or Clinically Undetermined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197",
        valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => _Present_on_Admission_or_Clinically_Undetermined;

    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: allergy-active
    [CqlCodeDefinition(
        definitionName: "allergy-active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext context) => _allergy_active;

    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-confirmed
    [CqlCodeDefinition(
        definitionName: "allergy-confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext context) => _allergy_confirmed;

    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-inactive
    [CqlCodeDefinition(
        definitionName: "allergy-inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext context) => _allergy_inactive;

    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-refuted
    [CqlCodeDefinition(
        definitionName: "allergy-refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext context) => _allergy_refuted;

    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-resolved
    [CqlCodeDefinition(
        definitionName: "allergy-resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext context) => _allergy_resolved;

    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-unconfirmed
    [CqlCodeDefinition(
        definitionName: "allergy-unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext context) => _allergy_unconfirmed;

    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: Billing
    [CqlCodeDefinition(
        definitionName: "Billing",
        codeId: "billing",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext context) => _Billing;

    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: Birthdate
    [CqlCodeDefinition(
        definitionName: "Birthdate",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext context) => _Birthdate;

    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Community
    [CqlCodeDefinition(
        definitionName: "Community",
        codeId: "community",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext context) => _Community;

    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: confirmed
    [CqlCodeDefinition(
        definitionName: "confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext context) => _confirmed;

    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: Dead
    [CqlCodeDefinition(
        definitionName: "Dead",
        codeId: "419099009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext context) => _Dead;

    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: differential
    [CqlCodeDefinition(
        definitionName: "differential",
        codeId: "differential",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext context) => _differential;

    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: Discharge
    [CqlCodeDefinition(
        definitionName: "Discharge",
        codeId: "discharge",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext context) => _Discharge;

    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: entered-in-error
    [CqlCodeDefinition(
        definitionName: "entered-in-error",
        codeId: "entered-in-error",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext context) => _entered_in_error;

    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: ER
    [CqlCodeDefinition(
        definitionName: "ER",
        codeId: "ER",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext context) => _ER;

    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);
    #endregion

    #region Code: ICU
    [CqlCodeDefinition(
        definitionName: "ICU",
        codeId: "ICU",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext context) => _ICU;

    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);
    #endregion

    #region Code: inactive
    [CqlCodeDefinition(
        definitionName: "inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext context) => _inactive;

    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: provisional
    [CqlCodeDefinition(
        definitionName: "provisional",
        codeId: "provisional",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext context) => _provisional;

    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: recurrence
    [CqlCodeDefinition(
        definitionName: "recurrence",
        codeId: "recurrence",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext context) => _recurrence;

    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: refuted
    [CqlCodeDefinition(
        definitionName: "refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext context) => _refuted;

    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: relapse
    [CqlCodeDefinition(
        definitionName: "relapse",
        codeId: "relapse",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext context) => _relapse;

    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: remission
    [CqlCodeDefinition(
        definitionName: "remission",
        codeId: "remission",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext context) => _remission;

    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: resolved
    [CqlCodeDefinition(
        definitionName: "resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext context) => _resolved;

    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: unconfirmed
    [CqlCodeDefinition(
        definitionName: "unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext context) => _unconfirmed;

    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] ut_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return ut_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] uu_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
        ];

        return uu_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] uv_ = [
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return uv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] uw_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return uw_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ux_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return ux_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] uy_ = [
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return uy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] uz_ = [
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return uz_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] va_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return va_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] vb_ = [
            new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
            new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
        ];

        return vb_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vc_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime vd_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ve_ = context.Operators.Interval(vc_, vd_, true, false);
        object vf_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", ve_);

        return (CqlInterval<CqlDateTime>)vf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vh_ = context.Operators.SingletonFrom<Patient>(vg_);

        return vh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime vi_ = context.Operators.Start(Value);
        CqlDateTime vj_ = context.Operators.End(Value);
        int? vk_ = context.Operators.DifferenceBetween(vi_, vj_, "day");

        return vk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet vl_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? vn_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> vp_ = EncounterInpatient?.StatusElement;
            string vq_ = FHIRHelpers_4_0_001.Instance.ToString(context, vp_);
            bool? vr_ = context.Operators.Equal(vq_, "finished");
            Period vs_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> vt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vs_);
            int? vu_ = this.LengthInDays(context, vt_);
            bool? vv_ = context.Operators.LessOrEqual(vu_, 120);
            bool? vw_ = context.Operators.And(vr_, vv_);
            CqlInterval<CqlDateTime> vy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vs_);
            CqlDateTime vz_ = context.Operators.End(vy_);
            CqlInterval<CqlDateTime> wa_ = this.Measurement_Period(context);
            bool? wb_ = context.Operators.In<CqlDateTime>(vz_, wa_, default);
            bool? wc_ = context.Operators.And(vw_, wb_);

            return wc_;
        };
        IEnumerable<Encounter> vo_ = context.Operators.Where<Encounter>(vm_, vn_);

        return vo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet wd_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> we_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? wf_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> wk_ = EDVisit?.StatusElement;
            string wl_ = FHIRHelpers_4_0_001.Instance.ToString(context, wk_);
            bool? wm_ = context.Operators.Equal(wl_, "finished");
            Period wn_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> wo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wn_);
            CqlDateTime wp_ = context.Operators.End(wo_);
            Period wq_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> wr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wq_);
            CqlDateTime ws_ = context.Operators.Start(wr_);
            CqlQuantity wt_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime wu_ = context.Operators.Subtract(ws_, wt_);
            CqlInterval<CqlDateTime> ww_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wq_);
            CqlDateTime wx_ = context.Operators.Start(ww_);
            CqlInterval<CqlDateTime> wy_ = context.Operators.Interval(wu_, wx_, true, true);
            bool? wz_ = context.Operators.In<CqlDateTime>(wp_, wy_, default);
            CqlInterval<CqlDateTime> xb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wq_);
            CqlDateTime xc_ = context.Operators.Start(xb_);
            bool? xd_ = context.Operators.Not((bool?)(xc_ is null));
            bool? xe_ = context.Operators.And(wz_, xd_);
            bool? xf_ = context.Operators.And(wm_, xe_);

            return xf_;
        };
        IEnumerable<Encounter> wg_ = context.Operators.Where<Encounter>(we_, wf_);
        object wh_(Encounter @this)
        {
            Period xg_ = @this?.Period;
            CqlInterval<CqlDateTime> xh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xg_);
            CqlDateTime xi_ = context.Operators.End(xh_);

            return xi_;
        };
        IEnumerable<Encounter> wi_ = context.Operators.SortBy<Encounter>(wg_, wh_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter wj_ = context.Operators.Last<Encounter>(wi_);

        return wj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter xj_ = this.ED_Visit(context, TheEncounter);
        Encounter[] xk_ = [
            xj_,
        ];
        CqlInterval<CqlDateTime> xl_(Encounter X)
        {
            CqlInterval<CqlDateTime> xp_()
            {
                if (X is null)
                {
                    Period xq_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> xr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xq_);

                    return xr_;
                }
                else
                {
                    Period xs_ = X?.Period;
                    CqlInterval<CqlDateTime> xt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xs_);
                    CqlDateTime xu_ = context.Operators.Start(xt_);
                    Period xv_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> xw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xv_);
                    CqlDateTime xx_ = context.Operators.End(xw_);
                    CqlInterval<CqlDateTime> xy_ = context.Operators.Interval(xu_, xx_, true, true);

                    return xy_;
                }
            };

            return xp_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> xm_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)xk_, xl_);
        IEnumerable<CqlInterval<CqlDateTime>> xn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xm_);
        CqlInterval<CqlDateTime> xo_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xn_);

        return xo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter xz_ = this.ED_Visit(context, TheEncounter);
        Encounter[] ya_ = [
            xz_,
        ];
        IEnumerable<Encounter.LocationComponent> yb_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> yf_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> yg_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)yg_;
                }
                else
                {
                    List<Encounter.LocationComponent> yh_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> yi_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] yj_ = [
                        (IEnumerable<Encounter.LocationComponent>)yh_,
                        (IEnumerable<Encounter.LocationComponent>)yi_,
                    ];
                    IEnumerable<Encounter.LocationComponent> yk_ = context.Operators.Flatten<Encounter.LocationComponent>(yj_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return yk_;
                }
            };

            return yf_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> yc_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)ya_, yb_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> yd_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(yc_);
        IEnumerable<Encounter.LocationComponent> ye_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(yd_);

        return ye_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> yl_ = this.Hospitalization(context, TheEncounter);
        int? ym_ = this.LengthInDays(context, yl_);

        return ym_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> yn_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime yo_ = context.Operators.Start(yn_);

        return yo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period yp_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> yq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yp_);
        CqlDateTime yr_ = context.Operators.End(yq_);

        return yr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ys_ = this.Hospitalization_Locations(context, TheEncounter);
        object yt_(Encounter.LocationComponent @this)
        {
            Period yz_ = @this?.Period;
            CqlInterval<CqlDateTime> za_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yz_);
            CqlDateTime zb_ = context.Operators.Start(za_);

            return zb_;
        };
        IEnumerable<Encounter.LocationComponent> yu_ = context.Operators.SortBy<Encounter.LocationComponent>(ys_, yt_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent yv_ = context.Operators.First<Encounter.LocationComponent>(yu_);
        Period yw_ = yv_?.Period;
        CqlInterval<CqlDateTime> yx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yw_);
        CqlDateTime yy_ = context.Operators.Start(yx_);

        return yy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] zc_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> zd_(Encounter Visit)
        {
            CqlValueSet zh_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> zi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? zj_(Encounter LastED)
            {
                Period azi_ = LastED?.Period;
                CqlInterval<CqlDateTime> azj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azi_);
                CqlDateTime azk_ = context.Operators.End(azj_);
                CqlValueSet azl_ = this.Observation_Services(context);
                IEnumerable<Encounter> azm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? azn_(Encounter LastObs)
                {
                    Period cze_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cze_);
                    CqlDateTime czg_ = context.Operators.End(czf_);
                    Period czh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czh_);
                    CqlDateTime czj_ = context.Operators.Start(czi_);
                    CqlQuantity czk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czl_ = context.Operators.Subtract(czj_, czk_);
                    CqlInterval<CqlDateTime> czn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czh_);
                    CqlDateTime czo_ = context.Operators.Start(czn_);
                    CqlInterval<CqlDateTime> czp_ = context.Operators.Interval(czl_, czo_, true, true);
                    bool? czq_ = context.Operators.In<CqlDateTime>(czg_, czp_, default);
                    CqlInterval<CqlDateTime> czs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czh_);
                    CqlDateTime czt_ = context.Operators.Start(czs_);
                    bool? czu_ = context.Operators.Not((bool?)(czt_ is null));
                    bool? czv_ = context.Operators.And(czq_, czu_);

                    return czv_;
                };
                IEnumerable<Encounter> azo_ = context.Operators.Where<Encounter>(azm_, azn_);
                object azp_(Encounter @this)
                {
                    Period czw_ = @this?.Period;
                    CqlInterval<CqlDateTime> czx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czw_);
                    CqlDateTime czy_ = context.Operators.End(czx_);

                    return czy_;
                };
                IEnumerable<Encounter> azq_ = context.Operators.SortBy<Encounter>(azo_, azp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azr_ = context.Operators.Last<Encounter>(azq_);
                Period azs_ = azr_?.Period;
                CqlInterval<CqlDateTime> azt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azs_);
                CqlDateTime azu_ = context.Operators.Start(azt_);
                Period azv_ = Visit?.Period;
                CqlInterval<CqlDateTime> azw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azv_);
                CqlDateTime azx_ = context.Operators.Start(azw_);
                CqlQuantity azy_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime azz_ = context.Operators.Subtract(azu_ ?? azx_, azy_);
                IEnumerable<Encounter> bzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? bzc_(Encounter LastObs)
                {
                    Period czz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czz_);
                    CqlDateTime dzb_ = context.Operators.End(dza_);
                    Period dzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzc_);
                    CqlDateTime dze_ = context.Operators.Start(dzd_);
                    CqlQuantity dzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzg_ = context.Operators.Subtract(dze_, dzf_);
                    CqlInterval<CqlDateTime> dzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzc_);
                    CqlDateTime dzj_ = context.Operators.Start(dzi_);
                    CqlInterval<CqlDateTime> dzk_ = context.Operators.Interval(dzg_, dzj_, true, true);
                    bool? dzl_ = context.Operators.In<CqlDateTime>(dzb_, dzk_, default);
                    CqlInterval<CqlDateTime> dzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzc_);
                    CqlDateTime dzo_ = context.Operators.Start(dzn_);
                    bool? dzp_ = context.Operators.Not((bool?)(dzo_ is null));
                    bool? dzq_ = context.Operators.And(dzl_, dzp_);

                    return dzq_;
                };
                IEnumerable<Encounter> bzd_ = context.Operators.Where<Encounter>(bzb_, bzc_);
                object bze_(Encounter @this)
                {
                    Period dzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzr_);
                    CqlDateTime dzt_ = context.Operators.End(dzs_);

                    return dzt_;
                };
                IEnumerable<Encounter> bzf_ = context.Operators.SortBy<Encounter>(bzd_, bze_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzg_ = context.Operators.Last<Encounter>(bzf_);
                Period bzh_ = bzg_?.Period;
                CqlInterval<CqlDateTime> bzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzh_);
                CqlDateTime bzj_ = context.Operators.Start(bzi_);
                CqlInterval<CqlDateTime> bzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azv_);
                CqlDateTime bzm_ = context.Operators.Start(bzl_);
                CqlInterval<CqlDateTime> bzn_ = context.Operators.Interval(azz_, bzj_ ?? bzm_, true, true);
                bool? bzo_ = context.Operators.In<CqlDateTime>(azk_, bzn_, default);
                IEnumerable<Encounter> bzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? bzr_(Encounter LastObs)
                {
                    Period dzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzu_);
                    CqlDateTime dzw_ = context.Operators.End(dzv_);
                    Period dzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzx_);
                    CqlDateTime dzz_ = context.Operators.Start(dzy_);
                    CqlQuantity eza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezb_ = context.Operators.Subtract(dzz_, eza_);
                    CqlInterval<CqlDateTime> ezd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzx_);
                    CqlDateTime eze_ = context.Operators.Start(ezd_);
                    CqlInterval<CqlDateTime> ezf_ = context.Operators.Interval(ezb_, eze_, true, true);
                    bool? ezg_ = context.Operators.In<CqlDateTime>(dzw_, ezf_, default);
                    CqlInterval<CqlDateTime> ezi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzx_);
                    CqlDateTime ezj_ = context.Operators.Start(ezi_);
                    bool? ezk_ = context.Operators.Not((bool?)(ezj_ is null));
                    bool? ezl_ = context.Operators.And(ezg_, ezk_);

                    return ezl_;
                };
                IEnumerable<Encounter> bzs_ = context.Operators.Where<Encounter>(bzq_, bzr_);
                object bzt_(Encounter @this)
                {
                    Period ezm_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezm_);
                    CqlDateTime ezo_ = context.Operators.End(ezn_);

                    return ezo_;
                };
                IEnumerable<Encounter> bzu_ = context.Operators.SortBy<Encounter>(bzs_, bzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzv_ = context.Operators.Last<Encounter>(bzu_);
                Period bzw_ = bzv_?.Period;
                CqlInterval<CqlDateTime> bzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzw_);
                CqlDateTime bzy_ = context.Operators.Start(bzx_);
                CqlInterval<CqlDateTime> cza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azv_);
                CqlDateTime czb_ = context.Operators.Start(cza_);
                bool? czc_ = context.Operators.Not((bool?)((bzy_ ?? czb_) is null));
                bool? czd_ = context.Operators.And(bzo_, czc_);

                return czd_;
            };
            IEnumerable<Encounter> zk_ = context.Operators.Where<Encounter>(zi_, zj_);
            object zl_(Encounter @this)
            {
                Period ezp_ = @this?.Period;
                CqlInterval<CqlDateTime> ezq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezp_);
                CqlDateTime ezr_ = context.Operators.End(ezq_);

                return ezr_;
            };
            IEnumerable<Encounter> zm_ = context.Operators.SortBy<Encounter>(zk_, zl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zn_ = context.Operators.Last<Encounter>(zm_);
            Period zo_ = zn_?.Period;
            CqlInterval<CqlDateTime> zp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zo_);
            CqlDateTime zq_ = context.Operators.Start(zp_);
            CqlValueSet zr_ = this.Observation_Services(context);
            IEnumerable<Encounter> zs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? zt_(Encounter LastObs)
            {
                Period ezs_ = LastObs?.Period;
                CqlInterval<CqlDateTime> ezt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezs_);
                CqlDateTime ezu_ = context.Operators.End(ezt_);
                Period ezv_ = Visit?.Period;
                CqlInterval<CqlDateTime> ezw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezv_);
                CqlDateTime ezx_ = context.Operators.Start(ezw_);
                CqlQuantity ezy_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ezz_ = context.Operators.Subtract(ezx_, ezy_);
                CqlInterval<CqlDateTime> fzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezv_);
                CqlDateTime fzc_ = context.Operators.Start(fzb_);
                CqlInterval<CqlDateTime> fzd_ = context.Operators.Interval(ezz_, fzc_, true, true);
                bool? fze_ = context.Operators.In<CqlDateTime>(ezu_, fzd_, default);
                CqlInterval<CqlDateTime> fzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezv_);
                CqlDateTime fzh_ = context.Operators.Start(fzg_);
                bool? fzi_ = context.Operators.Not((bool?)(fzh_ is null));
                bool? fzj_ = context.Operators.And(fze_, fzi_);

                return fzj_;
            };
            IEnumerable<Encounter> zu_ = context.Operators.Where<Encounter>(zs_, zt_);
            object zv_(Encounter @this)
            {
                Period fzk_ = @this?.Period;
                CqlInterval<CqlDateTime> fzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzk_);
                CqlDateTime fzm_ = context.Operators.End(fzl_);

                return fzm_;
            };
            IEnumerable<Encounter> zw_ = context.Operators.SortBy<Encounter>(zu_, zv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zx_ = context.Operators.Last<Encounter>(zw_);
            Period zy_ = zx_?.Period;
            CqlInterval<CqlDateTime> zz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zy_);
            CqlDateTime aza_ = context.Operators.Start(zz_);
            Period azb_ = Visit?.Period;
            CqlInterval<CqlDateTime> azc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azb_);
            CqlDateTime azd_ = context.Operators.Start(azc_);
            CqlInterval<CqlDateTime> azf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azb_);
            CqlDateTime azg_ = context.Operators.End(azf_);
            CqlInterval<CqlDateTime> azh_ = context.Operators.Interval(zq_ ?? aza_ ?? azd_, azg_, true, true);

            return azh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ze_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)zc_, zd_);
        IEnumerable<CqlInterval<CqlDateTime>> zf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ze_);
        CqlInterval<CqlDateTime> zg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(zf_);

        return zg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> fzn_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime fzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> fzq_ = context.Operators.Interval(fzo_, fzo_, true, true);

                return fzq_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> fzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);

                return fzr_;
            }
            else if (choice is Instant)
            {
                CqlDateTime fzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> fzu_ = context.Operators.Interval(fzs_, fzs_, true, true);

                return fzu_;
            }
            else if (choice is Age)
            {
                Patient fzv_ = this.Patient(context);
                Date fzw_ = fzv_?.BirthDateElement;
                CqlDate fzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzw_);
                CqlQuantity fzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate fzz_ = context.Operators.Add(fzx_, fzy_);
                Date gzb_ = fzv_?.BirthDateElement;
                CqlDate gzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzb_);
                CqlDate gze_ = context.Operators.Add(gzc_, fzy_);
                CqlQuantity gzf_ = context.Operators.Quantity(1m, "year");
                CqlDate gzg_ = context.Operators.Add(gze_, gzf_);
                CqlInterval<CqlDate> gzh_ = context.Operators.Interval(fzz_, gzg_, true, false);
                CqlDate gzi_ = gzh_?.low;
                CqlDateTime gzj_ = context.Operators.ConvertDateToDateTime(gzi_);
                Date gzl_ = fzv_?.BirthDateElement;
                CqlDate gzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzl_);
                CqlDate gzo_ = context.Operators.Add(gzm_, fzy_);
                Date gzq_ = fzv_?.BirthDateElement;
                CqlDate gzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzq_);
                CqlDate gzt_ = context.Operators.Add(gzr_, fzy_);
                CqlDate gzv_ = context.Operators.Add(gzt_, gzf_);
                CqlInterval<CqlDate> gzw_ = context.Operators.Interval(gzo_, gzv_, true, false);
                CqlDate gzx_ = gzw_?.high;
                CqlDateTime gzy_ = context.Operators.ConvertDateToDateTime(gzx_);
                Date hza_ = fzv_?.BirthDateElement;
                CqlDate hzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hza_);
                CqlDate hzd_ = context.Operators.Add(hzb_, fzy_);
                Date hzf_ = fzv_?.BirthDateElement;
                CqlDate hzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzf_);
                CqlDate hzi_ = context.Operators.Add(hzg_, fzy_);
                CqlDate hzk_ = context.Operators.Add(hzi_, gzf_);
                CqlInterval<CqlDate> hzl_ = context.Operators.Interval(hzd_, hzk_, true, false);
                bool? hzm_ = hzl_?.lowClosed;
                Date hzo_ = fzv_?.BirthDateElement;
                CqlDate hzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzo_);
                CqlDate hzr_ = context.Operators.Add(hzp_, fzy_);
                Date hzt_ = fzv_?.BirthDateElement;
                CqlDate hzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzt_);
                CqlDate hzw_ = context.Operators.Add(hzu_, fzy_);
                CqlDate hzy_ = context.Operators.Add(hzw_, gzf_);
                CqlInterval<CqlDate> hzz_ = context.Operators.Interval(hzr_, hzy_, true, false);
                bool? iza_ = hzz_?.highClosed;
                CqlInterval<CqlDateTime> izb_ = context.Operators.Interval(gzj_, gzy_, hzm_, iza_);

                return izb_;
            }
            else if (choice is Range)
            {
                Patient izc_ = this.Patient(context);
                Date izd_ = izc_?.BirthDateElement;
                CqlDate ize_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izd_);
                Quantity izf_ = (choice as Range)?.Low;
                CqlQuantity izg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izf_);
                CqlDate izh_ = context.Operators.Add(ize_, izg_);
                Date izj_ = izc_?.BirthDateElement;
                CqlDate izk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izj_);
                Quantity izl_ = (choice as Range)?.High;
                CqlQuantity izm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izl_);
                CqlDate izn_ = context.Operators.Add(izk_, izm_);
                CqlQuantity izo_ = context.Operators.Quantity(1m, "year");
                CqlDate izp_ = context.Operators.Add(izn_, izo_);
                CqlInterval<CqlDate> izq_ = context.Operators.Interval(izh_, izp_, true, false);
                CqlDate izr_ = izq_?.low;
                CqlDateTime izs_ = context.Operators.ConvertDateToDateTime(izr_);
                Date izu_ = izc_?.BirthDateElement;
                CqlDate izv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izu_);
                CqlQuantity izx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izf_);
                CqlDate izy_ = context.Operators.Add(izv_, izx_);
                Date jza_ = izc_?.BirthDateElement;
                CqlDate jzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jza_);
                CqlQuantity jzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izl_);
                CqlDate jze_ = context.Operators.Add(jzb_, jzd_);
                CqlDate jzg_ = context.Operators.Add(jze_, izo_);
                CqlInterval<CqlDate> jzh_ = context.Operators.Interval(izy_, jzg_, true, false);
                CqlDate jzi_ = jzh_?.high;
                CqlDateTime jzj_ = context.Operators.ConvertDateToDateTime(jzi_);
                Date jzl_ = izc_?.BirthDateElement;
                CqlDate jzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzl_);
                CqlQuantity jzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izf_);
                CqlDate jzp_ = context.Operators.Add(jzm_, jzo_);
                Date jzr_ = izc_?.BirthDateElement;
                CqlDate jzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzr_);
                CqlQuantity jzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izl_);
                CqlDate jzv_ = context.Operators.Add(jzs_, jzu_);
                CqlDate jzx_ = context.Operators.Add(jzv_, izo_);
                CqlInterval<CqlDate> jzy_ = context.Operators.Interval(jzp_, jzx_, true, false);
                bool? jzz_ = jzy_?.lowClosed;
                Date kzb_ = izc_?.BirthDateElement;
                CqlDate kzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzb_);
                CqlQuantity kze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izf_);
                CqlDate kzf_ = context.Operators.Add(kzc_, kze_);
                Date kzh_ = izc_?.BirthDateElement;
                CqlDate kzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzh_);
                CqlQuantity kzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izl_);
                CqlDate kzl_ = context.Operators.Add(kzi_, kzk_);
                CqlDate kzn_ = context.Operators.Add(kzl_, izo_);
                CqlInterval<CqlDate> kzo_ = context.Operators.Interval(kzf_, kzn_, true, false);
                bool? kzp_ = kzo_?.highClosed;
                CqlInterval<CqlDateTime> kzq_ = context.Operators.Interval(izs_, jzj_, jzz_, kzp_);

                return kzq_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> kzr_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return kzr_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> kzs_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return kzs_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return fzn_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> kzt_()
        {
            bool kzu_()
            {
                DataType lza_ = condition?.Abatement;
                bool lzb_ = lza_ is FhirDateTime;

                return lzb_;
            };
            bool kzv_()
            {
                DataType lzc_ = condition?.Abatement;
                bool lzd_ = lzc_ is Period;

                return lzd_;
            };
            bool kzw_()
            {
                DataType lze_ = condition?.Abatement;
                bool lzf_ = lze_ is FhirString;

                return lzf_;
            };
            bool kzx_()
            {
                DataType lzg_ = condition?.Abatement;
                bool lzh_ = lzg_ is Age;

                return lzh_;
            };
            bool kzy_()
            {
                DataType lzi_ = condition?.Abatement;
                bool lzj_ = lzi_ is Range;

                return lzj_;
            };
            bool kzz_()
            {
                DataType lzk_ = condition?.Abatement;
                bool lzl_ = lzk_ is FhirBoolean;

                return lzl_;
            };
            if (kzu_())
            {
                DataType lzm_ = condition?.Abatement;
                CqlDateTime lzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzm_ as FhirDateTime);
                CqlDateTime lzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzm_ as FhirDateTime);
                CqlInterval<CqlDateTime> lzq_ = context.Operators.Interval(lzn_, lzp_, true, true);

                return lzq_;
            }
            else if (kzv_())
            {
                DataType lzr_ = condition?.Abatement;
                CqlInterval<CqlDateTime> lzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzr_ as Period);

                return lzs_;
            }
            else if (kzw_())
            {
                CqlInterval<CqlDateTime> lzt_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return lzt_;
            }
            else if (kzx_())
            {
                Patient lzu_ = this.Patient(context);
                Date lzv_ = lzu_?.BirthDateElement;
                CqlDate lzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzv_);
                DataType lzx_ = condition?.Abatement;
                CqlQuantity lzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate lzz_ = context.Operators.Add(lzw_, lzy_);
                Date mzb_ = lzu_?.BirthDateElement;
                CqlDate mzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzb_);
                CqlQuantity mze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate mzf_ = context.Operators.Add(mzc_, mze_);
                CqlQuantity mzg_ = context.Operators.Quantity(1m, "year");
                CqlDate mzh_ = context.Operators.Add(mzf_, mzg_);
                CqlInterval<CqlDate> mzi_ = context.Operators.Interval(lzz_, mzh_, true, false);
                CqlDate mzj_ = mzi_?.low;
                CqlDateTime mzk_ = context.Operators.ConvertDateToDateTime(mzj_);
                Date mzm_ = lzu_?.BirthDateElement;
                CqlDate mzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzm_);
                CqlQuantity mzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate mzq_ = context.Operators.Add(mzn_, mzp_);
                Date mzs_ = lzu_?.BirthDateElement;
                CqlDate mzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzs_);
                CqlQuantity mzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate mzw_ = context.Operators.Add(mzt_, mzv_);
                CqlDate mzy_ = context.Operators.Add(mzw_, mzg_);
                CqlInterval<CqlDate> mzz_ = context.Operators.Interval(mzq_, mzy_, true, false);
                CqlDate nza_ = mzz_?.high;
                CqlDateTime nzb_ = context.Operators.ConvertDateToDateTime(nza_);
                Date nzd_ = lzu_?.BirthDateElement;
                CqlDate nze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzd_);
                CqlQuantity nzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate nzh_ = context.Operators.Add(nze_, nzg_);
                Date nzj_ = lzu_?.BirthDateElement;
                CqlDate nzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzj_);
                CqlQuantity nzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate nzn_ = context.Operators.Add(nzk_, nzm_);
                CqlDate nzp_ = context.Operators.Add(nzn_, mzg_);
                CqlInterval<CqlDate> nzq_ = context.Operators.Interval(nzh_, nzp_, true, false);
                bool? nzr_ = nzq_?.lowClosed;
                Date nzt_ = lzu_?.BirthDateElement;
                CqlDate nzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzt_);
                CqlQuantity nzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate nzx_ = context.Operators.Add(nzu_, nzw_);
                Date nzz_ = lzu_?.BirthDateElement;
                CqlDate oza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzz_);
                CqlQuantity ozc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzx_ as Age);
                CqlDate ozd_ = context.Operators.Add(oza_, ozc_);
                CqlDate ozf_ = context.Operators.Add(ozd_, mzg_);
                CqlInterval<CqlDate> ozg_ = context.Operators.Interval(nzx_, ozf_, true, false);
                bool? ozh_ = ozg_?.highClosed;
                CqlInterval<CqlDateTime> ozi_ = context.Operators.Interval(mzk_, nzb_, nzr_, ozh_);

                return ozi_;
            }
            else if (kzy_())
            {
                Patient ozj_ = this.Patient(context);
                Date ozk_ = ozj_?.BirthDateElement;
                CqlDate ozl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozk_);
                DataType ozm_ = condition?.Abatement;
                Quantity ozn_ = (ozm_ as Range)?.Low;
                CqlQuantity ozo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozn_);
                CqlDate ozp_ = context.Operators.Add(ozl_, ozo_);
                Date ozr_ = ozj_?.BirthDateElement;
                CqlDate ozs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozr_);
                Quantity ozu_ = (ozm_ as Range)?.High;
                CqlQuantity ozv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozu_);
                CqlDate ozw_ = context.Operators.Add(ozs_, ozv_);
                CqlQuantity ozx_ = context.Operators.Quantity(1m, "year");
                CqlDate ozy_ = context.Operators.Add(ozw_, ozx_);
                CqlInterval<CqlDate> ozz_ = context.Operators.Interval(ozp_, ozy_, true, false);
                CqlDate pza_ = ozz_?.low;
                CqlDateTime pzb_ = context.Operators.ConvertDateToDateTime(pza_);
                Date pzd_ = ozj_?.BirthDateElement;
                CqlDate pze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzd_);
                Quantity pzg_ = (ozm_ as Range)?.Low;
                CqlQuantity pzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzg_);
                CqlDate pzi_ = context.Operators.Add(pze_, pzh_);
                Date pzk_ = ozj_?.BirthDateElement;
                CqlDate pzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzk_);
                Quantity pzn_ = (ozm_ as Range)?.High;
                CqlQuantity pzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzn_);
                CqlDate pzp_ = context.Operators.Add(pzl_, pzo_);
                CqlDate pzr_ = context.Operators.Add(pzp_, ozx_);
                CqlInterval<CqlDate> pzs_ = context.Operators.Interval(pzi_, pzr_, true, false);
                CqlDate pzt_ = pzs_?.high;
                CqlDateTime pzu_ = context.Operators.ConvertDateToDateTime(pzt_);
                Date pzw_ = ozj_?.BirthDateElement;
                CqlDate pzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzw_);
                Quantity pzz_ = (ozm_ as Range)?.Low;
                CqlQuantity qza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzz_);
                CqlDate qzb_ = context.Operators.Add(pzx_, qza_);
                Date qzd_ = ozj_?.BirthDateElement;
                CqlDate qze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzd_);
                Quantity qzg_ = (ozm_ as Range)?.High;
                CqlQuantity qzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzg_);
                CqlDate qzi_ = context.Operators.Add(qze_, qzh_);
                CqlDate qzk_ = context.Operators.Add(qzi_, ozx_);
                CqlInterval<CqlDate> qzl_ = context.Operators.Interval(qzb_, qzk_, true, false);
                bool? qzm_ = qzl_?.lowClosed;
                Date qzo_ = ozj_?.BirthDateElement;
                CqlDate qzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzo_);
                Quantity qzr_ = (ozm_ as Range)?.Low;
                CqlQuantity qzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzr_);
                CqlDate qzt_ = context.Operators.Add(qzp_, qzs_);
                Date qzv_ = ozj_?.BirthDateElement;
                CqlDate qzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzv_);
                Quantity qzy_ = (ozm_ as Range)?.High;
                CqlQuantity qzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzy_);
                CqlDate rza_ = context.Operators.Add(qzw_, qzz_);
                CqlDate rzc_ = context.Operators.Add(rza_, ozx_);
                CqlInterval<CqlDate> rzd_ = context.Operators.Interval(qzt_, rzc_, true, false);
                bool? rze_ = rzd_?.highClosed;
                CqlInterval<CqlDateTime> rzf_ = context.Operators.Interval(pzb_, pzu_, qzm_, rze_);

                return rzf_;
            }
            else if (kzz_())
            {
                DataType rzg_ = condition?.Onset;
                CqlInterval<CqlDateTime> rzh_ = this.Normalize_Interval(context, rzg_);
                CqlDateTime rzi_ = context.Operators.End(rzh_);
                FhirDateTime rzj_ = condition?.RecordedDateElement;
                CqlDateTime rzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, rzj_);
                CqlInterval<CqlDateTime> rzl_ = context.Operators.Interval(rzi_, rzk_, true, false);

                return rzl_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return kzt_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> rzm_()
        {
            bool rzn_()
            {
                CodeableConcept rzo_ = condition?.ClinicalStatus;
                CqlConcept rzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzo_);
                CqlCode rzq_ = this.active(context);
                CqlConcept rzr_ = context.Operators.ConvertCodeToConcept(rzq_);
                bool? rzs_ = context.Operators.Equivalent(rzp_, rzr_);
                CqlConcept rzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzo_);
                CqlCode rzv_ = this.recurrence(context);
                CqlConcept rzw_ = context.Operators.ConvertCodeToConcept(rzv_);
                bool? rzx_ = context.Operators.Equivalent(rzu_, rzw_);
                bool? rzy_ = context.Operators.Or(rzs_, rzx_);
                CqlConcept sza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzo_);
                CqlCode szb_ = this.relapse(context);
                CqlConcept szc_ = context.Operators.ConvertCodeToConcept(szb_);
                bool? szd_ = context.Operators.Equivalent(sza_, szc_);
                bool? sze_ = context.Operators.Or(rzy_, szd_);

                return sze_ ?? false;
            };
            if (rzn_())
            {
                DataType szf_ = condition?.Onset;
                CqlInterval<CqlDateTime> szg_ = this.Normalize_Interval(context, szf_);
                CqlDateTime szh_ = context.Operators.Start(szg_);
                CqlInterval<CqlDateTime> szi_ = this.Normalize_Abatement(context, condition);
                CqlDateTime szj_ = context.Operators.End(szi_);
                CqlInterval<CqlDateTime> szk_ = context.Operators.Interval(szh_, szj_, true, true);

                return szk_;
            }
            else
            {
                DataType szl_ = condition?.Onset;
                CqlInterval<CqlDateTime> szm_ = this.Normalize_Interval(context, szl_);
                CqlDateTime szn_ = context.Operators.Start(szm_);
                CqlInterval<CqlDateTime> szo_ = this.Normalize_Abatement(context, condition);
                CqlDateTime szp_ = context.Operators.End(szo_);
                CqlInterval<CqlDateTime> szq_ = context.Operators.Interval(szn_, szp_, true, false);

                return szq_;
            }
        };

        return rzm_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> szr_ = context.Operators.Split(uri, "/");
        string szs_ = context.Operators.Last<string>(szr_);

        return szs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> szt_ = Encounter?.Diagnosis;
        Condition szu_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> szx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? szy_(Condition C)
            {
                Id tzb_ = C?.IdElement;
                string tzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzb_);
                ResourceReference tzd_ = D?.Condition;
                FhirString tze_ = tzd_?.ReferenceElement;
                string tzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, tze_);
                string tzg_ = this.GetId(context, tzf_);
                bool? tzh_ = context.Operators.Equal(tzc_, tzg_);

                return tzh_;
            };
            IEnumerable<Condition> szz_ = context.Operators.Where<Condition>(szx_, szy_);
            Condition tza_ = context.Operators.SingletonFrom<Condition>(szz_);

            return tza_;
        };
        IEnumerable<Condition> szv_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)szt_, szu_);
        IEnumerable<Condition> szw_ = context.Operators.Distinct<Condition>(szv_);

        return szw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> tzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tzj_(Condition C)
        {
            Id tzm_ = C?.IdElement;
            string tzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzm_);
            FhirString tzo_ = reference?.ReferenceElement;
            string tzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzo_);
            string tzq_ = this.GetId(context, tzp_);
            bool? tzr_ = context.Operators.Equal(tzn_, tzq_);

            return tzr_;
        };
        IEnumerable<Condition> tzk_ = context.Operators.Where<Condition>(tzi_, tzj_);
        Condition tzl_ = context.Operators.SingletonFrom<Condition>(tzk_);

        return tzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> tzs_ = domainResource?.Extension;
        bool? tzt_(Extension E)
        {
            string tzy_ = E?.Url;
            FhirUri tzz_ = context.Operators.Convert<FhirUri>(tzy_);
            string uza_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzz_);
            string uzb_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? uzc_ = context.Operators.Equal(uza_, uzb_);

            return uzc_;
        };
        IEnumerable<Extension> tzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)tzs_, tzt_);
        Extension tzv_(Extension E) =>
            E;
        IEnumerable<Extension> tzw_ = context.Operators.Select<Extension, Extension>(tzu_, tzv_);
        IEnumerable<Extension> tzx_ = context.Operators.Distinct<Extension>(tzw_);

        return tzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> uzd_ = element?.Extension;
        bool? uze_(Extension E)
        {
            string uzj_ = E?.Url;
            FhirUri uzk_ = context.Operators.Convert<FhirUri>(uzj_);
            string uzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzk_);
            bool? uzm_ = context.Operators.Equal(uzl_, url);

            return uzm_;
        };
        IEnumerable<Extension> uzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)uzd_, uze_);
        Extension uzg_(Extension E) =>
            E;
        IEnumerable<Extension> uzh_ = context.Operators.Select<Extension, Extension>(uzf_, uzg_);
        IEnumerable<Extension> uzi_ = context.Operators.Distinct<Extension>(uzh_);

        return uzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> uzn_ = this.GetExtensions(context, domainResource, url);
        Extension uzo_ = context.Operators.SingletonFrom<Extension>(uzn_);

        return uzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> uzp_ = this.GetExtensions(context, element, url);
        Extension uzq_ = context.Operators.SingletonFrom<Extension>(uzp_);

        return uzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension uzr_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType uzs_ = uzr_?.Value;

        return uzs_ as CodeableConcept;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> uzt_ = Encounter?.Diagnosis;
        bool? uzu_(Encounter.DiagnosisComponent D)
        {
            PositiveInt vzc_ = D?.RankElement;
            Integer vzd_ = context.Operators.Convert<Integer>(vzc_);
            int? vze_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, vzd_);
            bool? vzf_ = context.Operators.Equal(vze_, 1);

            return vzf_;
        };
        IEnumerable<Encounter.DiagnosisComponent> uzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzt_, uzu_);
        Encounter.DiagnosisComponent uzw_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(uzv_);
        Encounter.DiagnosisComponent[] uzx_ = [
            uzw_,
        ];
        Condition uzy_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> vzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? vzh_(Condition C)
            {
                Id vzk_ = C?.IdElement;
                string vzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzk_);
                ResourceReference vzm_ = PD?.Condition;
                FhirString vzn_ = vzm_?.ReferenceElement;
                string vzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzn_);
                string vzp_ = this.GetId(context, vzo_);
                bool? vzq_ = context.Operators.Equal(vzl_, vzp_);

                return vzq_;
            };
            IEnumerable<Condition> vzi_ = context.Operators.Where<Condition>(vzg_, vzh_);
            Condition vzj_ = context.Operators.SingletonFrom<Condition>(vzi_);

            return vzj_;
        };
        IEnumerable<Condition> uzz_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)uzx_, uzy_);
        IEnumerable<Condition> vza_ = context.Operators.Distinct<Condition>(uzz_);
        Condition vzb_ = context.Operators.SingletonFrom<Condition>(vza_);

        return vzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> vzr_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
        bool? vzs_(Location L)
        {
            Id vzv_ = L?.IdElement;
            string vzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzv_);
            FhirString vzx_ = reference?.ReferenceElement;
            string vzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzx_);
            string vzz_ = this.GetId(context, vzy_);
            bool? wza_ = context.Operators.Equal(vzw_, vzz_);

            return wza_;
        };
        IEnumerable<Location> vzt_ = context.Operators.Where<Location>(vzr_, vzs_);
        Location vzu_ = context.Operators.SingletonFrom<Location>(vzt_);

        return vzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> wzb_ = domainResource?.Extension;
        bool? wzc_(Extension E)
        {
            string wzh_ = E?.Url;
            FhirUri wzi_ = context.Operators.Convert<FhirUri>(wzh_);
            string wzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzi_);
            string wzk_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? wzl_ = context.Operators.Equal(wzj_, wzk_);

            return wzl_;
        };
        IEnumerable<Extension> wzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)wzb_, wzc_);
        Extension wze_(Extension E) =>
            E;
        IEnumerable<Extension> wzf_ = context.Operators.Select<Extension, Extension>(wzd_, wze_);
        IEnumerable<Extension> wzg_ = context.Operators.Distinct<Extension>(wzf_);

        return wzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> wzm_ = this.GetBaseExtensions(context, domainResource, url);
        Extension wzn_ = context.Operators.SingletonFrom<Extension>(wzm_);

        return wzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access\ncontent that is defined by extensions but not yet surfaced in the CQL model info.")]
    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> wzo_ = element?.Extension;
        bool? wzp_(Extension E)
        {
            string wzu_ = E?.Url;
            FhirUri wzv_ = context.Operators.Convert<FhirUri>(wzu_);
            string wzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzv_);
            string wzx_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? wzy_ = context.Operators.Equal(wzw_, wzx_);

            return wzy_;
        };
        IEnumerable<Extension> wzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)wzo_, wzp_);
        Extension wzr_(Extension E) =>
            E;
        IEnumerable<Extension> wzs_ = context.Operators.Select<Extension, Extension>(wzq_, wzr_);
        IEnumerable<Extension> wzt_ = context.Operators.Distinct<Extension>(wzs_);

        return wzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there\nis more than one extension on the given resource with the specified url.")]
    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> wzz_ = this.BaseExtensions(context, element, id);
        Extension xza_ = context.Operators.SingletonFrom<Extension>(wzz_);

        return xza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CodeableConcept xzb_()
        {
            bool xzc_()
            {
                DataType xzd_ = request?.Medication;
                bool xze_ = xzd_ is CodeableConcept;

                return xze_;
            };
            if (xzc_())
            {
                DataType xzf_ = request?.Medication;

                return xzf_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> xzg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                bool? xzh_(Medication M)
                {
                    Id xzl_ = M?.IdElement;
                    string xzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzl_);
                    DataType xzn_ = request?.Medication;
                    FhirString xzo_ = (xzn_ as ResourceReference)?.ReferenceElement;
                    string xzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzo_);
                    string xzq_ = this.GetId(context, xzp_);
                    bool? xzr_ = context.Operators.Equal(xzm_, xzq_);

                    return xzr_;
                };
                IEnumerable<Medication> xzi_ = context.Operators.Where<Medication>(xzg_, xzh_);
                Medication xzj_ = context.Operators.SingletonFrom<Medication>(xzi_);
                CodeableConcept xzk_ = xzj_?.Code;

                return xzk_;
            }
        };

        return xzb_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime xzs_ = context.Operators.Start(period);
        CqlDateTime xzu_ = context.Operators.MinValue<CqlDateTime>();
        bool? xzv_ = context.Operators.Equal(xzs_, xzu_);
        bool? xzw_ = context.Operators.Or((bool?)(xzs_ is null), xzv_);
        bool? xzx_ = context.Operators.Not(xzw_);

        return xzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime xzy_ = context.Operators.End(period);
        CqlDateTime yza_ = context.Operators.MaxValue<CqlDateTime>();
        bool? yzb_ = context.Operators.Equal(xzy_, yza_);
        bool? yzc_ = context.Operators.Or((bool?)(xzy_ is null), yzb_);
        bool? yzd_ = context.Operators.Not(yzc_);

        return yzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yze_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] yzf_ = [
            yze_,
        ];
        CqlDateTime yzg_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime yzk_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime yzl_ = context.Operators.End(period);

                    return yzl_;
                }
                else
                {
                    CqlDateTime yzm_ = context.Operators.Start(period);

                    return yzm_;
                }
            };

            return yzk_();
        };
        IEnumerable<CqlDateTime> yzh_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)yzf_, yzg_);
        IEnumerable<CqlDateTime> yzi_ = context.Operators.Distinct<CqlDateTime>(yzh_);
        CqlDateTime yzj_ = context.Operators.SingletonFrom<CqlDateTime>(yzi_);

        return yzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzn_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] yzo_ = [
            yzn_,
        ];
        CqlDateTime yzp_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime yzt_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime yzu_ = context.Operators.Start(period);

                    return yzu_;
                }
                else
                {
                    CqlDateTime yzv_ = context.Operators.End(period);

                    return yzv_;
                }
            };

            return yzt_();
        };
        IEnumerable<CqlDateTime> yzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)yzo_, yzp_);
        IEnumerable<CqlDateTime> yzr_ = context.Operators.Distinct<CqlDateTime>(yzq_);
        CqlDateTime yzs_ = context.Operators.SingletonFrom<CqlDateTime>(yzr_);

        return yzs_;
    }


    #endregion Expressions

}
