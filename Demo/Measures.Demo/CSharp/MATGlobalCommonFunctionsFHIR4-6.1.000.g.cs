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

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("allergy-active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext _) => _allergy_active;
    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext _) => _allergy_confirmed;
    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("allergy-inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext _) => _allergy_inactive;
    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext _) => _allergy_refuted;
    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("allergy-resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext _) => _allergy_resolved;
    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext _) => _allergy_unconfirmed;
    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("Birthdate", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext _) => _Birthdate;
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Community", codeId: "community", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext _) => _Community;
    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("Dead", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext _) => _Dead;
    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct");

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("Discharge", codeId: "discharge", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext _) => _Discharge;
    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("ER", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext _) => _ER;
    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("ICU", codeId: "ICU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext _) => _ICU;
    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext _) => _inactive;
    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("recurrence", codeId: "recurrence", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext _) => _recurrence;
    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("relapse", codeId: "relapse", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext _) => _relapse;
    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("remission", codeId: "remission", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext _) => _remission;
    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext _) => _resolved;
    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null,
          _active,
          _inactive,
          _recurrence,
          _relapse,
          _remission,
          _resolved);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null,
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null,
          _allergy_confirmed,
          _allergy_refuted,
          _allergy_unconfirmed);

    [CqlCodeSystemDefinition("Diagnosis Role")]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null,
          _Billing);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Birthdate);

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null,
          _Community,
          _Discharge);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null,
          _confirmed,
          _differential,
          _entered_in_error,
          _provisional,
          _refuted,
          _unconfirmed);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Dead);

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null,
          _ER,
          _ICU);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ut_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime uu_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> uv_ = context.Operators.Interval(ut_, uu_, true, false);
        object uw_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", uv_);

        return (CqlInterval<CqlDateTime>)uw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ux_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient uy_ = context.Operators.SingletonFrom<Patient>(ux_);

        return uy_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime uz_ = context.Operators.Start(Value);
        CqlDateTime va_ = context.Operators.End(Value);
        int? vb_ = context.Operators.DifferenceBetween(uz_, va_, "day");

        return vb_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet vc_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? ve_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> vg_ = EncounterInpatient?.StatusElement;
            string vh_ = FHIRHelpers_4_0_001.Instance.ToString(context, vg_);
            bool? vi_ = context.Operators.Equal(vh_, "finished");
            Period vj_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> vk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vj_);
            int? vl_ = this.LengthInDays(context, vk_);
            bool? vm_ = context.Operators.LessOrEqual(vl_, 120);
            bool? vn_ = context.Operators.And(vi_, vm_);
            CqlInterval<CqlDateTime> vp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vj_);
            CqlDateTime vq_ = context.Operators.End(vp_);
            CqlInterval<CqlDateTime> vr_ = this.Measurement_Period(context);
            bool? vs_ = context.Operators.In<CqlDateTime>(vq_, vr_, default);
            bool? vt_ = context.Operators.And(vn_, vs_);

            return vt_;
        };
        IEnumerable<Encounter> vf_ = context.Operators.Where<Encounter>(vd_, ve_);

        return vf_;
    }


    [CqlExpressionDefinition("ED Visit")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet vu_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> vv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? vw_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> wb_ = EDVisit?.StatusElement;
            string wc_ = FHIRHelpers_4_0_001.Instance.ToString(context, wb_);
            bool? wd_ = context.Operators.Equal(wc_, "finished");
            Period we_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> wf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, we_);
            CqlDateTime wg_ = context.Operators.End(wf_);
            Period wh_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> wi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wh_);
            CqlDateTime wj_ = context.Operators.Start(wi_);
            CqlQuantity wk_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime wl_ = context.Operators.Subtract(wj_, wk_);
            CqlInterval<CqlDateTime> wn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wh_);
            CqlDateTime wo_ = context.Operators.Start(wn_);
            CqlInterval<CqlDateTime> wp_ = context.Operators.Interval(wl_, wo_, true, true);
            bool? wq_ = context.Operators.In<CqlDateTime>(wg_, wp_, default);
            CqlInterval<CqlDateTime> ws_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wh_);
            CqlDateTime wt_ = context.Operators.Start(ws_);
            bool? wu_ = context.Operators.Not((bool?)(wt_ is null));
            bool? wv_ = context.Operators.And(wq_, wu_);
            bool? ww_ = context.Operators.And(wd_, wv_);

            return ww_;
        };
        IEnumerable<Encounter> vx_ = context.Operators.Where<Encounter>(vv_, vw_);
        object vy_(Encounter @this)
        {
            Period wx_ = @this?.Period;
            CqlInterval<CqlDateTime> wy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wx_);
            CqlDateTime wz_ = context.Operators.End(wy_);

            return wz_;
        };
        IEnumerable<Encounter> vz_ = context.Operators.SortBy<Encounter>(vx_, vy_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter wa_ = context.Operators.Last<Encounter>(vz_);

        return wa_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter xa_ = this.ED_Visit(context, TheEncounter);
        Encounter[] xb_ = [
            xa_,
        ];
        CqlInterval<CqlDateTime> xc_(Encounter X)
        {
            CqlInterval<CqlDateTime> xg_()
            {
                if (X is null)
                {
                    Period xh_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> xi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xh_);

                    return xi_;
                }
                else
                {
                    Period xj_ = X?.Period;
                    CqlInterval<CqlDateTime> xk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xj_);
                    CqlDateTime xl_ = context.Operators.Start(xk_);
                    Period xm_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> xn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xm_);
                    CqlDateTime xo_ = context.Operators.End(xn_);
                    CqlInterval<CqlDateTime> xp_ = context.Operators.Interval(xl_, xo_, true, true);

                    return xp_;
                }
            };

            return xg_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> xd_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)xb_, xc_);
        IEnumerable<CqlInterval<CqlDateTime>> xe_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xd_);
        CqlInterval<CqlDateTime> xf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xe_);

        return xf_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter xq_ = this.ED_Visit(context, TheEncounter);
        Encounter[] xr_ = [
            xq_,
        ];
        IEnumerable<Encounter.LocationComponent> xs_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> xw_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> xx_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)xx_;
                }
                else
                {
                    List<Encounter.LocationComponent> xy_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> xz_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] ya_ = [
                        (IEnumerable<Encounter.LocationComponent>)xy_,
                        (IEnumerable<Encounter.LocationComponent>)xz_,
                    ];
                    IEnumerable<Encounter.LocationComponent> yb_ = context.Operators.Flatten<Encounter.LocationComponent>(ya_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return yb_;
                }
            };

            return xw_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> xt_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)xr_, xs_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> xu_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(xt_);
        IEnumerable<Encounter.LocationComponent> xv_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(xu_);

        return xv_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> yc_ = this.Hospitalization(context, TheEncounter);
        int? yd_ = this.LengthInDays(context, yc_);

        return yd_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> ye_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime yf_ = context.Operators.Start(ye_);

        return yf_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period yg_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> yh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yg_);
        CqlDateTime yi_ = context.Operators.End(yh_);

        return yi_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> yj_ = this.Hospitalization_Locations(context, TheEncounter);
        object yk_(Encounter.LocationComponent @this)
        {
            Period yq_ = @this?.Period;
            CqlInterval<CqlDateTime> yr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yq_);
            CqlDateTime ys_ = context.Operators.Start(yr_);

            return ys_;
        };
        IEnumerable<Encounter.LocationComponent> yl_ = context.Operators.SortBy<Encounter.LocationComponent>(yj_, yk_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ym_ = context.Operators.First<Encounter.LocationComponent>(yl_);
        Period yn_ = ym_?.Period;
        CqlInterval<CqlDateTime> yo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yn_);
        CqlDateTime yp_ = context.Operators.Start(yo_);

        return yp_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] yt_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> yu_(Encounter Visit)
        {
            CqlValueSet yy_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> yz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? za_(Encounter LastED)
            {
                Period zz_ = LastED?.Period;
                CqlInterval<CqlDateTime> aza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zz_);
                CqlDateTime azb_ = context.Operators.End(aza_);
                CqlValueSet azc_ = this.Observation_Services(context);
                IEnumerable<Encounter> azd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? aze_(Encounter LastObs)
                {
                    Period bzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzv_);
                    CqlDateTime bzx_ = context.Operators.End(bzw_);
                    Period bzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzy_);
                    CqlDateTime cza_ = context.Operators.Start(bzz_);
                    CqlQuantity czb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czc_ = context.Operators.Subtract(cza_, czb_);
                    CqlInterval<CqlDateTime> cze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzy_);
                    CqlDateTime czf_ = context.Operators.Start(cze_);
                    CqlInterval<CqlDateTime> czg_ = context.Operators.Interval(czc_, czf_, true, true);
                    bool? czh_ = context.Operators.In<CqlDateTime>(bzx_, czg_, default);
                    CqlInterval<CqlDateTime> czj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzy_);
                    CqlDateTime czk_ = context.Operators.Start(czj_);
                    bool? czl_ = context.Operators.Not((bool?)(czk_ is null));
                    bool? czm_ = context.Operators.And(czh_, czl_);

                    return czm_;
                };
                IEnumerable<Encounter> azf_ = context.Operators.Where<Encounter>(azd_, aze_);
                object azg_(Encounter @this)
                {
                    Period czn_ = @this?.Period;
                    CqlInterval<CqlDateTime> czo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czn_);
                    CqlDateTime czp_ = context.Operators.End(czo_);

                    return czp_;
                };
                IEnumerable<Encounter> azh_ = context.Operators.SortBy<Encounter>(azf_, azg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azi_ = context.Operators.Last<Encounter>(azh_);
                Period azj_ = azi_?.Period;
                CqlInterval<CqlDateTime> azk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azj_);
                CqlDateTime azl_ = context.Operators.Start(azk_);
                Period azm_ = Visit?.Period;
                CqlInterval<CqlDateTime> azn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azm_);
                CqlDateTime azo_ = context.Operators.Start(azn_);
                CqlQuantity azp_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime azq_ = context.Operators.Subtract(azl_ ?? azo_, azp_);
                IEnumerable<Encounter> azs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? azt_(Encounter LastObs)
                {
                    Period czq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czq_);
                    CqlDateTime czs_ = context.Operators.End(czr_);
                    Period czt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czt_);
                    CqlDateTime czv_ = context.Operators.Start(czu_);
                    CqlQuantity czw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czx_ = context.Operators.Subtract(czv_, czw_);
                    CqlInterval<CqlDateTime> czz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czt_);
                    CqlDateTime dza_ = context.Operators.Start(czz_);
                    CqlInterval<CqlDateTime> dzb_ = context.Operators.Interval(czx_, dza_, true, true);
                    bool? dzc_ = context.Operators.In<CqlDateTime>(czs_, dzb_, default);
                    CqlInterval<CqlDateTime> dze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czt_);
                    CqlDateTime dzf_ = context.Operators.Start(dze_);
                    bool? dzg_ = context.Operators.Not((bool?)(dzf_ is null));
                    bool? dzh_ = context.Operators.And(dzc_, dzg_);

                    return dzh_;
                };
                IEnumerable<Encounter> azu_ = context.Operators.Where<Encounter>(azs_, azt_);
                object azv_(Encounter @this)
                {
                    Period dzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzi_);
                    CqlDateTime dzk_ = context.Operators.End(dzj_);

                    return dzk_;
                };
                IEnumerable<Encounter> azw_ = context.Operators.SortBy<Encounter>(azu_, azv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azx_ = context.Operators.Last<Encounter>(azw_);
                Period azy_ = azx_?.Period;
                CqlInterval<CqlDateTime> azz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azy_);
                CqlDateTime bza_ = context.Operators.Start(azz_);
                CqlInterval<CqlDateTime> bzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azm_);
                CqlDateTime bzd_ = context.Operators.Start(bzc_);
                CqlInterval<CqlDateTime> bze_ = context.Operators.Interval(azq_, bza_ ?? bzd_, true, true);
                bool? bzf_ = context.Operators.In<CqlDateTime>(azb_, bze_, default);
                IEnumerable<Encounter> bzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? bzi_(Encounter LastObs)
                {
                    Period dzl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzl_);
                    CqlDateTime dzn_ = context.Operators.End(dzm_);
                    Period dzo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzo_);
                    CqlDateTime dzq_ = context.Operators.Start(dzp_);
                    CqlQuantity dzr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzs_ = context.Operators.Subtract(dzq_, dzr_);
                    CqlInterval<CqlDateTime> dzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzo_);
                    CqlDateTime dzv_ = context.Operators.Start(dzu_);
                    CqlInterval<CqlDateTime> dzw_ = context.Operators.Interval(dzs_, dzv_, true, true);
                    bool? dzx_ = context.Operators.In<CqlDateTime>(dzn_, dzw_, default);
                    CqlInterval<CqlDateTime> dzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzo_);
                    CqlDateTime eza_ = context.Operators.Start(dzz_);
                    bool? ezb_ = context.Operators.Not((bool?)(eza_ is null));
                    bool? ezc_ = context.Operators.And(dzx_, ezb_);

                    return ezc_;
                };
                IEnumerable<Encounter> bzj_ = context.Operators.Where<Encounter>(bzh_, bzi_);
                object bzk_(Encounter @this)
                {
                    Period ezd_ = @this?.Period;
                    CqlInterval<CqlDateTime> eze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezd_);
                    CqlDateTime ezf_ = context.Operators.End(eze_);

                    return ezf_;
                };
                IEnumerable<Encounter> bzl_ = context.Operators.SortBy<Encounter>(bzj_, bzk_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzm_ = context.Operators.Last<Encounter>(bzl_);
                Period bzn_ = bzm_?.Period;
                CqlInterval<CqlDateTime> bzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzn_);
                CqlDateTime bzp_ = context.Operators.Start(bzo_);
                CqlInterval<CqlDateTime> bzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azm_);
                CqlDateTime bzs_ = context.Operators.Start(bzr_);
                bool? bzt_ = context.Operators.Not((bool?)((bzp_ ?? bzs_) is null));
                bool? bzu_ = context.Operators.And(bzf_, bzt_);

                return bzu_;
            };
            IEnumerable<Encounter> zb_ = context.Operators.Where<Encounter>(yz_, za_);
            object zc_(Encounter @this)
            {
                Period ezg_ = @this?.Period;
                CqlInterval<CqlDateTime> ezh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezg_);
                CqlDateTime ezi_ = context.Operators.End(ezh_);

                return ezi_;
            };
            IEnumerable<Encounter> zd_ = context.Operators.SortBy<Encounter>(zb_, zc_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ze_ = context.Operators.Last<Encounter>(zd_);
            Period zf_ = ze_?.Period;
            CqlInterval<CqlDateTime> zg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zf_);
            CqlDateTime zh_ = context.Operators.Start(zg_);
            CqlValueSet zi_ = this.Observation_Services(context);
            IEnumerable<Encounter> zj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? zk_(Encounter LastObs)
            {
                Period ezj_ = LastObs?.Period;
                CqlInterval<CqlDateTime> ezk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezj_);
                CqlDateTime ezl_ = context.Operators.End(ezk_);
                Period ezm_ = Visit?.Period;
                CqlInterval<CqlDateTime> ezn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezm_);
                CqlDateTime ezo_ = context.Operators.Start(ezn_);
                CqlQuantity ezp_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ezq_ = context.Operators.Subtract(ezo_, ezp_);
                CqlInterval<CqlDateTime> ezs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezm_);
                CqlDateTime ezt_ = context.Operators.Start(ezs_);
                CqlInterval<CqlDateTime> ezu_ = context.Operators.Interval(ezq_, ezt_, true, true);
                bool? ezv_ = context.Operators.In<CqlDateTime>(ezl_, ezu_, default);
                CqlInterval<CqlDateTime> ezx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezm_);
                CqlDateTime ezy_ = context.Operators.Start(ezx_);
                bool? ezz_ = context.Operators.Not((bool?)(ezy_ is null));
                bool? fza_ = context.Operators.And(ezv_, ezz_);

                return fza_;
            };
            IEnumerable<Encounter> zl_ = context.Operators.Where<Encounter>(zj_, zk_);
            object zm_(Encounter @this)
            {
                Period fzb_ = @this?.Period;
                CqlInterval<CqlDateTime> fzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzb_);
                CqlDateTime fzd_ = context.Operators.End(fzc_);

                return fzd_;
            };
            IEnumerable<Encounter> zn_ = context.Operators.SortBy<Encounter>(zl_, zm_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zo_ = context.Operators.Last<Encounter>(zn_);
            Period zp_ = zo_?.Period;
            CqlInterval<CqlDateTime> zq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zp_);
            CqlDateTime zr_ = context.Operators.Start(zq_);
            Period zs_ = Visit?.Period;
            CqlInterval<CqlDateTime> zt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zs_);
            CqlDateTime zu_ = context.Operators.Start(zt_);
            CqlInterval<CqlDateTime> zw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zs_);
            CqlDateTime zx_ = context.Operators.End(zw_);
            CqlInterval<CqlDateTime> zy_ = context.Operators.Interval(zh_ ?? zr_ ?? zu_, zx_, true, true);

            return zy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yv_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yt_, yu_);
        IEnumerable<CqlInterval<CqlDateTime>> yw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yv_);
        CqlInterval<CqlDateTime> yx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yw_);

        return yx_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> fze_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime fzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> fzh_ = context.Operators.Interval(fzf_, fzf_, true, true);

                return fzh_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> fzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);

                return fzi_;
            }
            else if (choice is Instant)
            {
                CqlDateTime fzj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> fzl_ = context.Operators.Interval(fzj_, fzj_, true, true);

                return fzl_;
            }
            else if (choice is Age)
            {
                Patient fzm_ = this.Patient(context);
                Date fzn_ = fzm_?.BirthDateElement;
                CqlDate fzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzn_);
                CqlQuantity fzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate fzq_ = context.Operators.Add(fzo_, fzp_);
                Date fzs_ = fzm_?.BirthDateElement;
                CqlDate fzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzs_);
                CqlDate fzv_ = context.Operators.Add(fzt_, fzp_);
                CqlQuantity fzw_ = context.Operators.Quantity(1m, "year");
                CqlDate fzx_ = context.Operators.Add(fzv_, fzw_);
                CqlInterval<CqlDate> fzy_ = context.Operators.Interval(fzq_, fzx_, true, false);
                CqlDate fzz_ = fzy_?.low;
                CqlDateTime gza_ = context.Operators.ConvertDateToDateTime(fzz_);
                Date gzc_ = fzm_?.BirthDateElement;
                CqlDate gzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzc_);
                CqlDate gzf_ = context.Operators.Add(gzd_, fzp_);
                Date gzh_ = fzm_?.BirthDateElement;
                CqlDate gzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzh_);
                CqlDate gzk_ = context.Operators.Add(gzi_, fzp_);
                CqlDate gzm_ = context.Operators.Add(gzk_, fzw_);
                CqlInterval<CqlDate> gzn_ = context.Operators.Interval(gzf_, gzm_, true, false);
                CqlDate gzo_ = gzn_?.high;
                CqlDateTime gzp_ = context.Operators.ConvertDateToDateTime(gzo_);
                Date gzr_ = fzm_?.BirthDateElement;
                CqlDate gzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzr_);
                CqlDate gzu_ = context.Operators.Add(gzs_, fzp_);
                Date gzw_ = fzm_?.BirthDateElement;
                CqlDate gzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzw_);
                CqlDate gzz_ = context.Operators.Add(gzx_, fzp_);
                CqlDate hzb_ = context.Operators.Add(gzz_, fzw_);
                CqlInterval<CqlDate> hzc_ = context.Operators.Interval(gzu_, hzb_, true, false);
                bool? hzd_ = hzc_?.lowClosed;
                Date hzf_ = fzm_?.BirthDateElement;
                CqlDate hzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzf_);
                CqlDate hzi_ = context.Operators.Add(hzg_, fzp_);
                Date hzk_ = fzm_?.BirthDateElement;
                CqlDate hzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzk_);
                CqlDate hzn_ = context.Operators.Add(hzl_, fzp_);
                CqlDate hzp_ = context.Operators.Add(hzn_, fzw_);
                CqlInterval<CqlDate> hzq_ = context.Operators.Interval(hzi_, hzp_, true, false);
                bool? hzr_ = hzq_?.highClosed;
                CqlInterval<CqlDateTime> hzs_ = context.Operators.Interval(gza_, gzp_, hzd_, hzr_);

                return hzs_;
            }
            else if (choice is Range)
            {
                Patient hzt_ = this.Patient(context);
                Date hzu_ = hzt_?.BirthDateElement;
                CqlDate hzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzu_);
                Quantity hzw_ = (choice as Range)?.Low;
                CqlQuantity hzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzw_);
                CqlDate hzy_ = context.Operators.Add(hzv_, hzx_);
                Date iza_ = hzt_?.BirthDateElement;
                CqlDate izb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, iza_);
                Quantity izc_ = (choice as Range)?.High;
                CqlQuantity izd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izc_);
                CqlDate ize_ = context.Operators.Add(izb_, izd_);
                CqlQuantity izf_ = context.Operators.Quantity(1m, "year");
                CqlDate izg_ = context.Operators.Add(ize_, izf_);
                CqlInterval<CqlDate> izh_ = context.Operators.Interval(hzy_, izg_, true, false);
                CqlDate izi_ = izh_?.low;
                CqlDateTime izj_ = context.Operators.ConvertDateToDateTime(izi_);
                Date izl_ = hzt_?.BirthDateElement;
                CqlDate izm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izl_);
                CqlQuantity izo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzw_);
                CqlDate izp_ = context.Operators.Add(izm_, izo_);
                Date izr_ = hzt_?.BirthDateElement;
                CqlDate izs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izr_);
                CqlQuantity izu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izc_);
                CqlDate izv_ = context.Operators.Add(izs_, izu_);
                CqlDate izx_ = context.Operators.Add(izv_, izf_);
                CqlInterval<CqlDate> izy_ = context.Operators.Interval(izp_, izx_, true, false);
                CqlDate izz_ = izy_?.high;
                CqlDateTime jza_ = context.Operators.ConvertDateToDateTime(izz_);
                Date jzc_ = hzt_?.BirthDateElement;
                CqlDate jzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzc_);
                CqlQuantity jzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzw_);
                CqlDate jzg_ = context.Operators.Add(jzd_, jzf_);
                Date jzi_ = hzt_?.BirthDateElement;
                CqlDate jzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzi_);
                CqlQuantity jzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izc_);
                CqlDate jzm_ = context.Operators.Add(jzj_, jzl_);
                CqlDate jzo_ = context.Operators.Add(jzm_, izf_);
                CqlInterval<CqlDate> jzp_ = context.Operators.Interval(jzg_, jzo_, true, false);
                bool? jzq_ = jzp_?.lowClosed;
                Date jzs_ = hzt_?.BirthDateElement;
                CqlDate jzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzs_);
                CqlQuantity jzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzw_);
                CqlDate jzw_ = context.Operators.Add(jzt_, jzv_);
                Date jzy_ = hzt_?.BirthDateElement;
                CqlDate jzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzy_);
                CqlQuantity kzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izc_);
                CqlDate kzc_ = context.Operators.Add(jzz_, kzb_);
                CqlDate kze_ = context.Operators.Add(kzc_, izf_);
                CqlInterval<CqlDate> kzf_ = context.Operators.Interval(jzw_, kze_, true, false);
                bool? kzg_ = kzf_?.highClosed;
                CqlInterval<CqlDateTime> kzh_ = context.Operators.Interval(izj_, jza_, jzq_, kzg_);

                return kzh_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> kzi_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return kzi_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> kzj_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return kzj_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return fze_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> kzk_()
        {
            bool kzl_()
            {
                DataType kzr_ = condition?.Abatement;
                bool kzs_ = kzr_ is FhirDateTime;

                return kzs_;
            };
            bool kzm_()
            {
                DataType kzt_ = condition?.Abatement;
                bool kzu_ = kzt_ is Period;

                return kzu_;
            };
            bool kzn_()
            {
                DataType kzv_ = condition?.Abatement;
                bool kzw_ = kzv_ is FhirString;

                return kzw_;
            };
            bool kzo_()
            {
                DataType kzx_ = condition?.Abatement;
                bool kzy_ = kzx_ is Age;

                return kzy_;
            };
            bool kzp_()
            {
                DataType kzz_ = condition?.Abatement;
                bool lza_ = kzz_ is Range;

                return lza_;
            };
            bool kzq_()
            {
                DataType lzb_ = condition?.Abatement;
                bool lzc_ = lzb_ is FhirBoolean;

                return lzc_;
            };
            if (kzl_())
            {
                DataType lzd_ = condition?.Abatement;
                CqlDateTime lze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzd_ as FhirDateTime);
                CqlDateTime lzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzd_ as FhirDateTime);
                CqlInterval<CqlDateTime> lzh_ = context.Operators.Interval(lze_, lzg_, true, true);

                return lzh_;
            }
            else if (kzm_())
            {
                DataType lzi_ = condition?.Abatement;
                CqlInterval<CqlDateTime> lzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzi_ as Period);

                return lzj_;
            }
            else if (kzn_())
            {
                CqlInterval<CqlDateTime> lzk_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return lzk_;
            }
            else if (kzo_())
            {
                Patient lzl_ = this.Patient(context);
                Date lzm_ = lzl_?.BirthDateElement;
                CqlDate lzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzm_);
                DataType lzo_ = condition?.Abatement;
                CqlQuantity lzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate lzq_ = context.Operators.Add(lzn_, lzp_);
                Date lzs_ = lzl_?.BirthDateElement;
                CqlDate lzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzs_);
                CqlQuantity lzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate lzw_ = context.Operators.Add(lzt_, lzv_);
                CqlQuantity lzx_ = context.Operators.Quantity(1m, "year");
                CqlDate lzy_ = context.Operators.Add(lzw_, lzx_);
                CqlInterval<CqlDate> lzz_ = context.Operators.Interval(lzq_, lzy_, true, false);
                CqlDate mza_ = lzz_?.low;
                CqlDateTime mzb_ = context.Operators.ConvertDateToDateTime(mza_);
                Date mzd_ = lzl_?.BirthDateElement;
                CqlDate mze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzd_);
                CqlQuantity mzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate mzh_ = context.Operators.Add(mze_, mzg_);
                Date mzj_ = lzl_?.BirthDateElement;
                CqlDate mzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzj_);
                CqlQuantity mzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate mzn_ = context.Operators.Add(mzk_, mzm_);
                CqlDate mzp_ = context.Operators.Add(mzn_, lzx_);
                CqlInterval<CqlDate> mzq_ = context.Operators.Interval(mzh_, mzp_, true, false);
                CqlDate mzr_ = mzq_?.high;
                CqlDateTime mzs_ = context.Operators.ConvertDateToDateTime(mzr_);
                Date mzu_ = lzl_?.BirthDateElement;
                CqlDate mzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzu_);
                CqlQuantity mzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate mzy_ = context.Operators.Add(mzv_, mzx_);
                Date nza_ = lzl_?.BirthDateElement;
                CqlDate nzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nza_);
                CqlQuantity nzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate nze_ = context.Operators.Add(nzb_, nzd_);
                CqlDate nzg_ = context.Operators.Add(nze_, lzx_);
                CqlInterval<CqlDate> nzh_ = context.Operators.Interval(mzy_, nzg_, true, false);
                bool? nzi_ = nzh_?.lowClosed;
                Date nzk_ = lzl_?.BirthDateElement;
                CqlDate nzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzk_);
                CqlQuantity nzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate nzo_ = context.Operators.Add(nzl_, nzn_);
                Date nzq_ = lzl_?.BirthDateElement;
                CqlDate nzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzq_);
                CqlQuantity nzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzo_ as Age);
                CqlDate nzu_ = context.Operators.Add(nzr_, nzt_);
                CqlDate nzw_ = context.Operators.Add(nzu_, lzx_);
                CqlInterval<CqlDate> nzx_ = context.Operators.Interval(nzo_, nzw_, true, false);
                bool? nzy_ = nzx_?.highClosed;
                CqlInterval<CqlDateTime> nzz_ = context.Operators.Interval(mzb_, mzs_, nzi_, nzy_);

                return nzz_;
            }
            else if (kzp_())
            {
                Patient oza_ = this.Patient(context);
                Date ozb_ = oza_?.BirthDateElement;
                CqlDate ozc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozb_);
                DataType ozd_ = condition?.Abatement;
                Quantity oze_ = (ozd_ as Range)?.Low;
                CqlQuantity ozf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, oze_);
                CqlDate ozg_ = context.Operators.Add(ozc_, ozf_);
                Date ozi_ = oza_?.BirthDateElement;
                CqlDate ozj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozi_);
                Quantity ozl_ = (ozd_ as Range)?.High;
                CqlQuantity ozm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozl_);
                CqlDate ozn_ = context.Operators.Add(ozj_, ozm_);
                CqlQuantity ozo_ = context.Operators.Quantity(1m, "year");
                CqlDate ozp_ = context.Operators.Add(ozn_, ozo_);
                CqlInterval<CqlDate> ozq_ = context.Operators.Interval(ozg_, ozp_, true, false);
                CqlDate ozr_ = ozq_?.low;
                CqlDateTime ozs_ = context.Operators.ConvertDateToDateTime(ozr_);
                Date ozu_ = oza_?.BirthDateElement;
                CqlDate ozv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozu_);
                Quantity ozx_ = (ozd_ as Range)?.Low;
                CqlQuantity ozy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozx_);
                CqlDate ozz_ = context.Operators.Add(ozv_, ozy_);
                Date pzb_ = oza_?.BirthDateElement;
                CqlDate pzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzb_);
                Quantity pze_ = (ozd_ as Range)?.High;
                CqlQuantity pzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pze_);
                CqlDate pzg_ = context.Operators.Add(pzc_, pzf_);
                CqlDate pzi_ = context.Operators.Add(pzg_, ozo_);
                CqlInterval<CqlDate> pzj_ = context.Operators.Interval(ozz_, pzi_, true, false);
                CqlDate pzk_ = pzj_?.high;
                CqlDateTime pzl_ = context.Operators.ConvertDateToDateTime(pzk_);
                Date pzn_ = oza_?.BirthDateElement;
                CqlDate pzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzn_);
                Quantity pzq_ = (ozd_ as Range)?.Low;
                CqlQuantity pzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzq_);
                CqlDate pzs_ = context.Operators.Add(pzo_, pzr_);
                Date pzu_ = oza_?.BirthDateElement;
                CqlDate pzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzu_);
                Quantity pzx_ = (ozd_ as Range)?.High;
                CqlQuantity pzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzx_);
                CqlDate pzz_ = context.Operators.Add(pzv_, pzy_);
                CqlDate qzb_ = context.Operators.Add(pzz_, ozo_);
                CqlInterval<CqlDate> qzc_ = context.Operators.Interval(pzs_, qzb_, true, false);
                bool? qzd_ = qzc_?.lowClosed;
                Date qzf_ = oza_?.BirthDateElement;
                CqlDate qzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzf_);
                Quantity qzi_ = (ozd_ as Range)?.Low;
                CqlQuantity qzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzi_);
                CqlDate qzk_ = context.Operators.Add(qzg_, qzj_);
                Date qzm_ = oza_?.BirthDateElement;
                CqlDate qzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzm_);
                Quantity qzp_ = (ozd_ as Range)?.High;
                CqlQuantity qzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzp_);
                CqlDate qzr_ = context.Operators.Add(qzn_, qzq_);
                CqlDate qzt_ = context.Operators.Add(qzr_, ozo_);
                CqlInterval<CqlDate> qzu_ = context.Operators.Interval(qzk_, qzt_, true, false);
                bool? qzv_ = qzu_?.highClosed;
                CqlInterval<CqlDateTime> qzw_ = context.Operators.Interval(ozs_, pzl_, qzd_, qzv_);

                return qzw_;
            }
            else if (kzq_())
            {
                DataType qzx_ = condition?.Onset;
                CqlInterval<CqlDateTime> qzy_ = this.Normalize_Interval(context, qzx_);
                CqlDateTime qzz_ = context.Operators.End(qzy_);
                FhirDateTime rza_ = condition?.RecordedDateElement;
                CqlDateTime rzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, rza_);
                CqlInterval<CqlDateTime> rzc_ = context.Operators.Interval(qzz_, rzb_, true, false);

                return rzc_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return kzk_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> rzd_()
        {
            bool rze_()
            {
                CodeableConcept rzf_ = condition?.ClinicalStatus;
                CqlConcept rzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzf_);
                CqlCode rzh_ = this.active(context);
                CqlConcept rzi_ = context.Operators.ConvertCodeToConcept(rzh_);
                bool? rzj_ = context.Operators.Equivalent(rzg_, rzi_);
                CqlConcept rzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzf_);
                CqlCode rzm_ = this.recurrence(context);
                CqlConcept rzn_ = context.Operators.ConvertCodeToConcept(rzm_);
                bool? rzo_ = context.Operators.Equivalent(rzl_, rzn_);
                bool? rzp_ = context.Operators.Or(rzj_, rzo_);
                CqlConcept rzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzf_);
                CqlCode rzs_ = this.relapse(context);
                CqlConcept rzt_ = context.Operators.ConvertCodeToConcept(rzs_);
                bool? rzu_ = context.Operators.Equivalent(rzr_, rzt_);
                bool? rzv_ = context.Operators.Or(rzp_, rzu_);

                return rzv_ ?? false;
            };
            if (rze_())
            {
                DataType rzw_ = condition?.Onset;
                CqlInterval<CqlDateTime> rzx_ = this.Normalize_Interval(context, rzw_);
                CqlDateTime rzy_ = context.Operators.Start(rzx_);
                CqlInterval<CqlDateTime> rzz_ = this.Normalize_Abatement(context, condition);
                CqlDateTime sza_ = context.Operators.End(rzz_);
                CqlInterval<CqlDateTime> szb_ = context.Operators.Interval(rzy_, sza_, true, true);

                return szb_;
            }
            else
            {
                DataType szc_ = condition?.Onset;
                CqlInterval<CqlDateTime> szd_ = this.Normalize_Interval(context, szc_);
                CqlDateTime sze_ = context.Operators.Start(szd_);
                CqlInterval<CqlDateTime> szf_ = this.Normalize_Abatement(context, condition);
                CqlDateTime szg_ = context.Operators.End(szf_);
                CqlInterval<CqlDateTime> szh_ = context.Operators.Interval(sze_, szg_, true, false);

                return szh_;
            }
        };

        return rzd_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> szi_ = context.Operators.Split(uri, "/");
        string szj_ = context.Operators.Last<string>(szi_);

        return szj_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> szk_ = Encounter?.Diagnosis;
        Condition szl_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> szo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? szp_(Condition C)
            {
                Id szs_ = C?.IdElement;
                string szt_ = FHIRHelpers_4_0_001.Instance.ToString(context, szs_);
                ResourceReference szu_ = D?.Condition;
                FhirString szv_ = szu_?.ReferenceElement;
                string szw_ = FHIRHelpers_4_0_001.Instance.ToString(context, szv_);
                string szx_ = this.GetId(context, szw_);
                bool? szy_ = context.Operators.Equal(szt_, szx_);

                return szy_;
            };
            IEnumerable<Condition> szq_ = context.Operators.Where<Condition>(szo_, szp_);
            Condition szr_ = context.Operators.SingletonFrom<Condition>(szq_);

            return szr_;
        };
        IEnumerable<Condition> szm_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)szk_, szl_);
        IEnumerable<Condition> szn_ = context.Operators.Distinct<Condition>(szm_);

        return szn_;
    }


    [CqlExpressionDefinition("GetCondition")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> szz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tza_(Condition C)
        {
            Id tzd_ = C?.IdElement;
            string tze_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzd_);
            FhirString tzf_ = reference?.ReferenceElement;
            string tzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzf_);
            string tzh_ = this.GetId(context, tzg_);
            bool? tzi_ = context.Operators.Equal(tze_, tzh_);

            return tzi_;
        };
        IEnumerable<Condition> tzb_ = context.Operators.Where<Condition>(szz_, tza_);
        Condition tzc_ = context.Operators.SingletonFrom<Condition>(tzb_);

        return tzc_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> tzj_ = domainResource?.Extension;
        bool? tzk_(Extension E)
        {
            string tzp_ = E?.Url;
            FhirUri tzq_ = context.Operators.Convert<FhirUri>(tzp_);
            string tzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzq_);
            string tzs_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? tzt_ = context.Operators.Equal(tzr_, tzs_);

            return tzt_;
        };
        IEnumerable<Extension> tzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)tzj_, tzk_);
        Extension tzm_(Extension E) =>
            E;
        IEnumerable<Extension> tzn_ = context.Operators.Select<Extension, Extension>(tzl_, tzm_);
        IEnumerable<Extension> tzo_ = context.Operators.Distinct<Extension>(tzn_);

        return tzo_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> tzu_ = element?.Extension;
        bool? tzv_(Extension E)
        {
            string uza_ = E?.Url;
            FhirUri uzb_ = context.Operators.Convert<FhirUri>(uza_);
            string uzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzb_);
            bool? uzd_ = context.Operators.Equal(uzc_, url);

            return uzd_;
        };
        IEnumerable<Extension> tzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)tzu_, tzv_);
        Extension tzx_(Extension E) =>
            E;
        IEnumerable<Extension> tzy_ = context.Operators.Select<Extension, Extension>(tzw_, tzx_);
        IEnumerable<Extension> tzz_ = context.Operators.Distinct<Extension>(tzy_);

        return tzz_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> uze_ = this.GetExtensions(context, domainResource, url);
        Extension uzf_ = context.Operators.SingletonFrom<Extension>(uze_);

        return uzf_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> uzg_ = this.GetExtensions(context, element, url);
        Extension uzh_ = context.Operators.SingletonFrom<Extension>(uzg_);

        return uzh_;
    }


    [CqlExpressionDefinition("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension uzi_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType uzj_ = uzi_?.Value;

        return uzj_ as CodeableConcept;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> uzk_ = Encounter?.Diagnosis;
        bool? uzl_(Encounter.DiagnosisComponent D)
        {
            PositiveInt uzt_ = D?.RankElement;
            Integer uzu_ = context.Operators.Convert<Integer>(uzt_);
            int? uzv_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, uzu_);
            bool? uzw_ = context.Operators.Equal(uzv_, 1);

            return uzw_;
        };
        IEnumerable<Encounter.DiagnosisComponent> uzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzk_, uzl_);
        Encounter.DiagnosisComponent uzn_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(uzm_);
        Encounter.DiagnosisComponent[] uzo_ = [
            uzn_,
        ];
        Condition uzp_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> uzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? uzy_(Condition C)
            {
                Id vzb_ = C?.IdElement;
                string vzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzb_);
                ResourceReference vzd_ = PD?.Condition;
                FhirString vze_ = vzd_?.ReferenceElement;
                string vzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, vze_);
                string vzg_ = this.GetId(context, vzf_);
                bool? vzh_ = context.Operators.Equal(vzc_, vzg_);

                return vzh_;
            };
            IEnumerable<Condition> uzz_ = context.Operators.Where<Condition>(uzx_, uzy_);
            Condition vza_ = context.Operators.SingletonFrom<Condition>(uzz_);

            return vza_;
        };
        IEnumerable<Condition> uzq_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)uzo_, uzp_);
        IEnumerable<Condition> uzr_ = context.Operators.Distinct<Condition>(uzq_);
        Condition uzs_ = context.Operators.SingletonFrom<Condition>(uzr_);

        return uzs_;
    }


    [CqlExpressionDefinition("GetLocation")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> vzi_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
        bool? vzj_(Location L)
        {
            Id vzm_ = L?.IdElement;
            string vzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzm_);
            FhirString vzo_ = reference?.ReferenceElement;
            string vzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzo_);
            string vzq_ = this.GetId(context, vzp_);
            bool? vzr_ = context.Operators.Equal(vzn_, vzq_);

            return vzr_;
        };
        IEnumerable<Location> vzk_ = context.Operators.Where<Location>(vzi_, vzj_);
        Location vzl_ = context.Operators.SingletonFrom<Location>(vzk_);

        return vzl_;
    }


    [CqlExpressionDefinition("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> vzs_ = domainResource?.Extension;
        bool? vzt_(Extension E)
        {
            string vzy_ = E?.Url;
            FhirUri vzz_ = context.Operators.Convert<FhirUri>(vzy_);
            string wza_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzz_);
            string wzb_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? wzc_ = context.Operators.Equal(wza_, wzb_);

            return wzc_;
        };
        IEnumerable<Extension> vzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)vzs_, vzt_);
        Extension vzv_(Extension E) =>
            E;
        IEnumerable<Extension> vzw_ = context.Operators.Select<Extension, Extension>(vzu_, vzv_);
        IEnumerable<Extension> vzx_ = context.Operators.Distinct<Extension>(vzw_);

        return vzx_;
    }


    [CqlExpressionDefinition("GetBaseExtension")]
    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> wzd_ = this.GetBaseExtensions(context, domainResource, url);
        Extension wze_ = context.Operators.SingletonFrom<Extension>(wzd_);

        return wze_;
    }


    [CqlExpressionDefinition("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access\ncontent that is defined by extensions but not yet surfaced in the CQL model info.")]
    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> wzf_ = element?.Extension;
        bool? wzg_(Extension E)
        {
            string wzl_ = E?.Url;
            FhirUri wzm_ = context.Operators.Convert<FhirUri>(wzl_);
            string wzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzm_);
            string wzo_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? wzp_ = context.Operators.Equal(wzn_, wzo_);

            return wzp_;
        };
        IEnumerable<Extension> wzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)wzf_, wzg_);
        Extension wzi_(Extension E) =>
            E;
        IEnumerable<Extension> wzj_ = context.Operators.Select<Extension, Extension>(wzh_, wzi_);
        IEnumerable<Extension> wzk_ = context.Operators.Distinct<Extension>(wzj_);

        return wzk_;
    }


    [CqlExpressionDefinition("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there\nis more than one extension on the given resource with the specified url.")]
    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> wzq_ = this.BaseExtensions(context, element, id);
        Extension wzr_ = context.Operators.SingletonFrom<Extension>(wzq_);

        return wzr_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CodeableConcept wzs_()
        {
            bool wzt_()
            {
                DataType wzu_ = request?.Medication;
                bool wzv_ = wzu_ is CodeableConcept;

                return wzv_;
            };
            if (wzt_())
            {
                DataType wzw_ = request?.Medication;

                return wzw_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> wzx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                bool? wzy_(Medication M)
                {
                    Id xzc_ = M?.IdElement;
                    string xzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzc_);
                    DataType xze_ = request?.Medication;
                    FhirString xzf_ = (xze_ as ResourceReference)?.ReferenceElement;
                    string xzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzf_);
                    string xzh_ = this.GetId(context, xzg_);
                    bool? xzi_ = context.Operators.Equal(xzd_, xzh_);

                    return xzi_;
                };
                IEnumerable<Medication> wzz_ = context.Operators.Where<Medication>(wzx_, wzy_);
                Medication xza_ = context.Operators.SingletonFrom<Medication>(wzz_);
                CodeableConcept xzb_ = xza_?.Code;

                return xzb_;
            }
        };

        return wzs_();
    }


    [CqlExpressionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime xzj_ = context.Operators.Start(period);
        CqlDateTime xzl_ = context.Operators.MinValue<CqlDateTime>();
        bool? xzm_ = context.Operators.Equal(xzj_, xzl_);
        bool? xzn_ = context.Operators.Or((bool?)(xzj_ is null), xzm_);
        bool? xzo_ = context.Operators.Not(xzn_);

        return xzo_;
    }


    [CqlExpressionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime xzp_ = context.Operators.End(period);
        CqlDateTime xzr_ = context.Operators.MaxValue<CqlDateTime>();
        bool? xzs_ = context.Operators.Equal(xzp_, xzr_);
        bool? xzt_ = context.Operators.Or((bool?)(xzp_ is null), xzs_);
        bool? xzu_ = context.Operators.Not(xzt_);

        return xzu_;
    }


    [CqlExpressionDefinition("Latest")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> xzv_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] xzw_ = [
            xzv_,
        ];
        CqlDateTime xzx_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime yzb_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime yzc_ = context.Operators.End(period);

                    return yzc_;
                }
                else
                {
                    CqlDateTime yzd_ = context.Operators.Start(period);

                    return yzd_;
                }
            };

            return yzb_();
        };
        IEnumerable<CqlDateTime> xzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)xzw_, xzx_);
        IEnumerable<CqlDateTime> xzz_ = context.Operators.Distinct<CqlDateTime>(xzy_);
        CqlDateTime yza_ = context.Operators.SingletonFrom<CqlDateTime>(xzz_);

        return yza_;
    }


    [CqlExpressionDefinition("Earliest")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yze_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] yzf_ = [
            yze_,
        ];
        CqlDateTime yzg_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime yzk_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime yzl_ = context.Operators.Start(period);

                    return yzl_;
                }
                else
                {
                    CqlDateTime yzm_ = context.Operators.End(period);

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


    #endregion Expressions

}
