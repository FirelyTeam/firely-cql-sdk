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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active,
          _inactive,
          _recurrence,
          _relapse,
          _remission,
          _resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, [
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, [
          _allergy_confirmed,
          _allergy_refuted,
          _allergy_unconfirmed]);

    [CqlCodeSystemDefinition("Diagnosis Role")]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, [
          _Billing]);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birthdate]);

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, [
          _Community,
          _Discharge]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _confirmed,
          _differential,
          _entered_in_error,
          _provisional,
          _refuted,
          _unconfirmed]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead]);

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _ER,
          _ICU]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ro_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime rp_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> rq_ = context.Operators.Interval(ro_, rp_, true, false);
        object rr_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", rq_);

        return (CqlInterval<CqlDateTime>)rr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rt_ = context.Operators.SingletonFrom<Patient>(rs_);

        return rt_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime ru_ = context.Operators.Start(Value);
        CqlDateTime rv_ = context.Operators.End(Value);
        int? rw_ = context.Operators.DifferenceBetween(ru_, rv_, "day");

        return rw_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet rx_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> ry_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? rz_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> sb_ = EncounterInpatient?.StatusElement;
            string sc_ = FHIRHelpers_4_0_001.Instance.ToString(context, sb_);
            bool? sd_ = context.Operators.Equal(sc_, "finished");
            Period se_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> sf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, se_);
            int? sg_ = this.LengthInDays(context, sf_);
            bool? sh_ = context.Operators.LessOrEqual(sg_, 120);
            bool? si_ = context.Operators.And(sd_, sh_);
            CqlInterval<CqlDateTime> sk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, se_);
            CqlDateTime sl_ = context.Operators.End(sk_);
            CqlInterval<CqlDateTime> sm_ = this.Measurement_Period(context);
            bool? sn_ = context.Operators.In<CqlDateTime>(sl_, sm_, default);
            bool? so_ = context.Operators.And(si_, sn_);

            return so_;
        };
        IEnumerable<Encounter> sa_ = context.Operators.Where<Encounter>(ry_, rz_);

        return sa_;
    }


    [CqlExpressionDefinition("ED Visit")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet sp_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> sq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, sp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? sr_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> sw_ = EDVisit?.StatusElement;
            string sx_ = FHIRHelpers_4_0_001.Instance.ToString(context, sw_);
            bool? sy_ = context.Operators.Equal(sx_, "finished");
            Period sz_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> ta_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, sz_);
            CqlDateTime tb_ = context.Operators.End(ta_);
            Period tc_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> td_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tc_);
            CqlDateTime te_ = context.Operators.Start(td_);
            CqlQuantity tf_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime tg_ = context.Operators.Subtract(te_, tf_);
            CqlInterval<CqlDateTime> ti_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tc_);
            CqlDateTime tj_ = context.Operators.Start(ti_);
            CqlInterval<CqlDateTime> tk_ = context.Operators.Interval(tg_, tj_, true, true);
            bool? tl_ = context.Operators.In<CqlDateTime>(tb_, tk_, default);
            CqlInterval<CqlDateTime> tn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tc_);
            CqlDateTime to_ = context.Operators.Start(tn_);
            bool? tp_ = context.Operators.Not((bool?)(to_ is null));
            bool? tq_ = context.Operators.And(tl_, tp_);
            bool? tr_ = context.Operators.And(sy_, tq_);

            return tr_;
        };
        IEnumerable<Encounter> ss_ = context.Operators.Where<Encounter>(sq_, sr_);
        object st_(Encounter @this)
        {
            Period ts_ = @this?.Period;
            CqlInterval<CqlDateTime> tt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ts_);
            CqlDateTime tu_ = context.Operators.End(tt_);

            return tu_;
        };
        IEnumerable<Encounter> su_ = context.Operators.SortBy<Encounter>(ss_, st_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter sv_ = context.Operators.Last<Encounter>(su_);

        return sv_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter tv_ = this.ED_Visit(context, TheEncounter);
        Encounter[] tw_ = [
            tv_,
        ];
        CqlInterval<CqlDateTime> tx_(Encounter X)
        {
            CqlInterval<CqlDateTime> ub_()
            {
                if (X is null)
                {
                    Period uc_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> ud_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uc_);

                    return ud_;
                }
                else
                {
                    Period ue_ = X?.Period;
                    CqlInterval<CqlDateTime> uf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ue_);
                    CqlDateTime ug_ = context.Operators.Start(uf_);
                    Period uh_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> ui_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uh_);
                    CqlDateTime uj_ = context.Operators.End(ui_);
                    CqlInterval<CqlDateTime> uk_ = context.Operators.Interval(ug_, uj_, true, true);

                    return uk_;
                }
            };

            return ub_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> ty_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)tw_, tx_);
        IEnumerable<CqlInterval<CqlDateTime>> tz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ty_);
        CqlInterval<CqlDateTime> ua_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(tz_);

        return ua_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter ul_ = this.ED_Visit(context, TheEncounter);
        Encounter[] um_ = [
            ul_,
        ];
        IEnumerable<Encounter.LocationComponent> un_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> ur_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> us_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)us_;
                }
                else
                {
                    List<Encounter.LocationComponent> ut_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> uu_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] uv_ = [
                        (IEnumerable<Encounter.LocationComponent>)ut_,
                        (IEnumerable<Encounter.LocationComponent>)uu_,
                    ];
                    IEnumerable<Encounter.LocationComponent> uw_ = context.Operators.Flatten<Encounter.LocationComponent>(uv_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return uw_;
                }
            };

            return ur_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> uo_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)um_, un_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> up_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(uo_);
        IEnumerable<Encounter.LocationComponent> uq_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(up_);

        return uq_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> ux_ = this.Hospitalization(context, TheEncounter);
        int? uy_ = this.LengthInDays(context, ux_);

        return uy_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> uz_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime va_ = context.Operators.Start(uz_);

        return va_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period vb_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> vc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vb_);
        CqlDateTime vd_ = context.Operators.End(vc_);

        return vd_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ve_ = this.Hospitalization_Locations(context, TheEncounter);
        object vf_(Encounter.LocationComponent @this)
        {
            Period vl_ = @this?.Period;
            CqlInterval<CqlDateTime> vm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vl_);
            CqlDateTime vn_ = context.Operators.Start(vm_);

            return vn_;
        };
        IEnumerable<Encounter.LocationComponent> vg_ = context.Operators.SortBy<Encounter.LocationComponent>(ve_, vf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent vh_ = context.Operators.First<Encounter.LocationComponent>(vg_);
        Period vi_ = vh_?.Period;
        CqlInterval<CqlDateTime> vj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vi_);
        CqlDateTime vk_ = context.Operators.Start(vj_);

        return vk_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] vo_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> vp_(Encounter Visit)
        {
            CqlValueSet vt_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> vu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? vv_(Encounter LastED)
            {
                Period wu_ = LastED?.Period;
                CqlInterval<CqlDateTime> wv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wu_);
                CqlDateTime ww_ = context.Operators.End(wv_);
                CqlValueSet wx_ = this.Observation_Services(context);
                IEnumerable<Encounter> wy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? wz_(Encounter LastObs)
                {
                    Period yq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yq_);
                    CqlDateTime ys_ = context.Operators.End(yr_);
                    Period yt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yt_);
                    CqlDateTime yv_ = context.Operators.Start(yu_);
                    CqlQuantity yw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yx_ = context.Operators.Subtract(yv_, yw_);
                    CqlInterval<CqlDateTime> yz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yt_);
                    CqlDateTime za_ = context.Operators.Start(yz_);
                    CqlInterval<CqlDateTime> zb_ = context.Operators.Interval(yx_, za_, true, true);
                    bool? zc_ = context.Operators.In<CqlDateTime>(ys_, zb_, default);
                    CqlInterval<CqlDateTime> ze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yt_);
                    CqlDateTime zf_ = context.Operators.Start(ze_);
                    bool? zg_ = context.Operators.Not((bool?)(zf_ is null));
                    bool? zh_ = context.Operators.And(zc_, zg_);

                    return zh_;
                };
                IEnumerable<Encounter> xa_ = context.Operators.Where<Encounter>(wy_, wz_);
                object xb_(Encounter @this)
                {
                    Period zi_ = @this?.Period;
                    CqlInterval<CqlDateTime> zj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zi_);
                    CqlDateTime zk_ = context.Operators.End(zj_);

                    return zk_;
                };
                IEnumerable<Encounter> xc_ = context.Operators.SortBy<Encounter>(xa_, xb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xd_ = context.Operators.Last<Encounter>(xc_);
                Period xe_ = xd_?.Period;
                CqlInterval<CqlDateTime> xf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xe_);
                CqlDateTime xg_ = context.Operators.Start(xf_);
                Period xh_ = Visit?.Period;
                CqlInterval<CqlDateTime> xi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xh_);
                CqlDateTime xj_ = context.Operators.Start(xi_);
                CqlQuantity xk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xl_ = context.Operators.Subtract(xg_ ?? xj_, xk_);
                IEnumerable<Encounter> xn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? xo_(Encounter LastObs)
                {
                    Period zl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zl_);
                    CqlDateTime zn_ = context.Operators.End(zm_);
                    Period zo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zo_);
                    CqlDateTime zq_ = context.Operators.Start(zp_);
                    CqlQuantity zr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zs_ = context.Operators.Subtract(zq_, zr_);
                    CqlInterval<CqlDateTime> zu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zo_);
                    CqlDateTime zv_ = context.Operators.Start(zu_);
                    CqlInterval<CqlDateTime> zw_ = context.Operators.Interval(zs_, zv_, true, true);
                    bool? zx_ = context.Operators.In<CqlDateTime>(zn_, zw_, default);
                    CqlInterval<CqlDateTime> zz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zo_);
                    CqlDateTime aza_ = context.Operators.Start(zz_);
                    bool? azb_ = context.Operators.Not((bool?)(aza_ is null));
                    bool? azc_ = context.Operators.And(zx_, azb_);

                    return azc_;
                };
                IEnumerable<Encounter> xp_ = context.Operators.Where<Encounter>(xn_, xo_);
                object xq_(Encounter @this)
                {
                    Period azd_ = @this?.Period;
                    CqlInterval<CqlDateTime> aze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azd_);
                    CqlDateTime azf_ = context.Operators.End(aze_);

                    return azf_;
                };
                IEnumerable<Encounter> xr_ = context.Operators.SortBy<Encounter>(xp_, xq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xs_ = context.Operators.Last<Encounter>(xr_);
                Period xt_ = xs_?.Period;
                CqlInterval<CqlDateTime> xu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xt_);
                CqlDateTime xv_ = context.Operators.Start(xu_);
                CqlInterval<CqlDateTime> xx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xh_);
                CqlDateTime xy_ = context.Operators.Start(xx_);
                CqlInterval<CqlDateTime> xz_ = context.Operators.Interval(xl_, xv_ ?? xy_, true, true);
                bool? ya_ = context.Operators.In<CqlDateTime>(ww_, xz_, default);
                IEnumerable<Encounter> yc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? yd_(Encounter LastObs)
                {
                    Period azg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azg_);
                    CqlDateTime azi_ = context.Operators.End(azh_);
                    Period azj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azj_);
                    CqlDateTime azl_ = context.Operators.Start(azk_);
                    CqlQuantity azm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azn_ = context.Operators.Subtract(azl_, azm_);
                    CqlInterval<CqlDateTime> azp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azj_);
                    CqlDateTime azq_ = context.Operators.Start(azp_);
                    CqlInterval<CqlDateTime> azr_ = context.Operators.Interval(azn_, azq_, true, true);
                    bool? azs_ = context.Operators.In<CqlDateTime>(azi_, azr_, default);
                    CqlInterval<CqlDateTime> azu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azj_);
                    CqlDateTime azv_ = context.Operators.Start(azu_);
                    bool? azw_ = context.Operators.Not((bool?)(azv_ is null));
                    bool? azx_ = context.Operators.And(azs_, azw_);

                    return azx_;
                };
                IEnumerable<Encounter> ye_ = context.Operators.Where<Encounter>(yc_, yd_);
                object yf_(Encounter @this)
                {
                    Period azy_ = @this?.Period;
                    CqlInterval<CqlDateTime> azz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azy_);
                    CqlDateTime bza_ = context.Operators.End(azz_);

                    return bza_;
                };
                IEnumerable<Encounter> yg_ = context.Operators.SortBy<Encounter>(ye_, yf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yh_ = context.Operators.Last<Encounter>(yg_);
                Period yi_ = yh_?.Period;
                CqlInterval<CqlDateTime> yj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yi_);
                CqlDateTime yk_ = context.Operators.Start(yj_);
                CqlInterval<CqlDateTime> ym_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xh_);
                CqlDateTime yn_ = context.Operators.Start(ym_);
                bool? yo_ = context.Operators.Not((bool?)((yk_ ?? yn_) is null));
                bool? yp_ = context.Operators.And(ya_, yo_);

                return yp_;
            };
            IEnumerable<Encounter> vw_ = context.Operators.Where<Encounter>(vu_, vv_);
            object vx_(Encounter @this)
            {
                Period bzb_ = @this?.Period;
                CqlInterval<CqlDateTime> bzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzb_);
                CqlDateTime bzd_ = context.Operators.End(bzc_);

                return bzd_;
            };
            IEnumerable<Encounter> vy_ = context.Operators.SortBy<Encounter>(vw_, vx_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vz_ = context.Operators.Last<Encounter>(vy_);
            Period wa_ = vz_?.Period;
            CqlInterval<CqlDateTime> wb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wa_);
            CqlDateTime wc_ = context.Operators.Start(wb_);
            CqlValueSet wd_ = this.Observation_Services(context);
            IEnumerable<Encounter> we_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? wf_(Encounter LastObs)
            {
                Period bze_ = LastObs?.Period;
                CqlInterval<CqlDateTime> bzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bze_);
                CqlDateTime bzg_ = context.Operators.End(bzf_);
                Period bzh_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzh_);
                CqlDateTime bzj_ = context.Operators.Start(bzi_);
                CqlQuantity bzk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzl_ = context.Operators.Subtract(bzj_, bzk_);
                CqlInterval<CqlDateTime> bzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzh_);
                CqlDateTime bzo_ = context.Operators.Start(bzn_);
                CqlInterval<CqlDateTime> bzp_ = context.Operators.Interval(bzl_, bzo_, true, true);
                bool? bzq_ = context.Operators.In<CqlDateTime>(bzg_, bzp_, default);
                CqlInterval<CqlDateTime> bzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzh_);
                CqlDateTime bzt_ = context.Operators.Start(bzs_);
                bool? bzu_ = context.Operators.Not((bool?)(bzt_ is null));
                bool? bzv_ = context.Operators.And(bzq_, bzu_);

                return bzv_;
            };
            IEnumerable<Encounter> wg_ = context.Operators.Where<Encounter>(we_, wf_);
            object wh_(Encounter @this)
            {
                Period bzw_ = @this?.Period;
                CqlInterval<CqlDateTime> bzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzw_);
                CqlDateTime bzy_ = context.Operators.End(bzx_);

                return bzy_;
            };
            IEnumerable<Encounter> wi_ = context.Operators.SortBy<Encounter>(wg_, wh_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wj_ = context.Operators.Last<Encounter>(wi_);
            Period wk_ = wj_?.Period;
            CqlInterval<CqlDateTime> wl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wk_);
            CqlDateTime wm_ = context.Operators.Start(wl_);
            Period wn_ = Visit?.Period;
            CqlInterval<CqlDateTime> wo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wn_);
            CqlDateTime wp_ = context.Operators.Start(wo_);
            CqlInterval<CqlDateTime> wr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wn_);
            CqlDateTime ws_ = context.Operators.End(wr_);
            CqlInterval<CqlDateTime> wt_ = context.Operators.Interval(wc_ ?? wm_ ?? wp_, ws_, true, true);

            return wt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vq_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)vo_, vp_);
        IEnumerable<CqlInterval<CqlDateTime>> vr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vq_);
        CqlInterval<CqlDateTime> vs_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vr_);

        return vs_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> bzz_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime cza_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> czc_ = context.Operators.Interval(cza_, cza_, true, true);

                return czc_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> czd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);

                return czd_;
            }
            else if (choice is Instant)
            {
                CqlDateTime cze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> czg_ = context.Operators.Interval(cze_, cze_, true, true);

                return czg_;
            }
            else if (choice is Age)
            {
                Patient czh_ = this.Patient(context);
                Date czi_ = czh_?.BirthDateElement;
                CqlDate czj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czi_);
                CqlQuantity czk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate czl_ = context.Operators.Add(czj_, czk_);
                Date czn_ = czh_?.BirthDateElement;
                CqlDate czo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czn_);
                CqlDate czq_ = context.Operators.Add(czo_, czk_);
                CqlQuantity czr_ = context.Operators.Quantity(1m, "year");
                CqlDate czs_ = context.Operators.Add(czq_, czr_);
                CqlInterval<CqlDate> czt_ = context.Operators.Interval(czl_, czs_, true, false);
                CqlDate czu_ = czt_?.low;
                CqlDateTime czv_ = context.Operators.ConvertDateToDateTime(czu_);
                Date czx_ = czh_?.BirthDateElement;
                CqlDate czy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czx_);
                CqlDate dza_ = context.Operators.Add(czy_, czk_);
                Date dzc_ = czh_?.BirthDateElement;
                CqlDate dzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzc_);
                CqlDate dzf_ = context.Operators.Add(dzd_, czk_);
                CqlDate dzh_ = context.Operators.Add(dzf_, czr_);
                CqlInterval<CqlDate> dzi_ = context.Operators.Interval(dza_, dzh_, true, false);
                CqlDate dzj_ = dzi_?.high;
                CqlDateTime dzk_ = context.Operators.ConvertDateToDateTime(dzj_);
                Date dzm_ = czh_?.BirthDateElement;
                CqlDate dzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzm_);
                CqlDate dzp_ = context.Operators.Add(dzn_, czk_);
                Date dzr_ = czh_?.BirthDateElement;
                CqlDate dzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzr_);
                CqlDate dzu_ = context.Operators.Add(dzs_, czk_);
                CqlDate dzw_ = context.Operators.Add(dzu_, czr_);
                CqlInterval<CqlDate> dzx_ = context.Operators.Interval(dzp_, dzw_, true, false);
                bool? dzy_ = dzx_?.lowClosed;
                Date eza_ = czh_?.BirthDateElement;
                CqlDate ezb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, eza_);
                CqlDate ezd_ = context.Operators.Add(ezb_, czk_);
                Date ezf_ = czh_?.BirthDateElement;
                CqlDate ezg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezf_);
                CqlDate ezi_ = context.Operators.Add(ezg_, czk_);
                CqlDate ezk_ = context.Operators.Add(ezi_, czr_);
                CqlInterval<CqlDate> ezl_ = context.Operators.Interval(ezd_, ezk_, true, false);
                bool? ezm_ = ezl_?.highClosed;
                CqlInterval<CqlDateTime> ezn_ = context.Operators.Interval(czv_, dzk_, dzy_, ezm_);

                return ezn_;
            }
            else if (choice is Range)
            {
                Patient ezo_ = this.Patient(context);
                Date ezp_ = ezo_?.BirthDateElement;
                CqlDate ezq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezp_);
                Quantity ezr_ = (choice as Range)?.Low;
                CqlQuantity ezs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezr_);
                CqlDate ezt_ = context.Operators.Add(ezq_, ezs_);
                Date ezv_ = ezo_?.BirthDateElement;
                CqlDate ezw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezv_);
                Quantity ezx_ = (choice as Range)?.High;
                CqlQuantity ezy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezx_);
                CqlDate ezz_ = context.Operators.Add(ezw_, ezy_);
                CqlQuantity fza_ = context.Operators.Quantity(1m, "year");
                CqlDate fzb_ = context.Operators.Add(ezz_, fza_);
                CqlInterval<CqlDate> fzc_ = context.Operators.Interval(ezt_, fzb_, true, false);
                CqlDate fzd_ = fzc_?.low;
                CqlDateTime fze_ = context.Operators.ConvertDateToDateTime(fzd_);
                Date fzg_ = ezo_?.BirthDateElement;
                CqlDate fzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzg_);
                CqlQuantity fzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezr_);
                CqlDate fzk_ = context.Operators.Add(fzh_, fzj_);
                Date fzm_ = ezo_?.BirthDateElement;
                CqlDate fzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzm_);
                CqlQuantity fzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezx_);
                CqlDate fzq_ = context.Operators.Add(fzn_, fzp_);
                CqlDate fzs_ = context.Operators.Add(fzq_, fza_);
                CqlInterval<CqlDate> fzt_ = context.Operators.Interval(fzk_, fzs_, true, false);
                CqlDate fzu_ = fzt_?.high;
                CqlDateTime fzv_ = context.Operators.ConvertDateToDateTime(fzu_);
                Date fzx_ = ezo_?.BirthDateElement;
                CqlDate fzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzx_);
                CqlQuantity gza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezr_);
                CqlDate gzb_ = context.Operators.Add(fzy_, gza_);
                Date gzd_ = ezo_?.BirthDateElement;
                CqlDate gze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzd_);
                CqlQuantity gzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezx_);
                CqlDate gzh_ = context.Operators.Add(gze_, gzg_);
                CqlDate gzj_ = context.Operators.Add(gzh_, fza_);
                CqlInterval<CqlDate> gzk_ = context.Operators.Interval(gzb_, gzj_, true, false);
                bool? gzl_ = gzk_?.lowClosed;
                Date gzn_ = ezo_?.BirthDateElement;
                CqlDate gzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzn_);
                CqlQuantity gzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezr_);
                CqlDate gzr_ = context.Operators.Add(gzo_, gzq_);
                Date gzt_ = ezo_?.BirthDateElement;
                CqlDate gzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzt_);
                CqlQuantity gzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezx_);
                CqlDate gzx_ = context.Operators.Add(gzu_, gzw_);
                CqlDate gzz_ = context.Operators.Add(gzx_, fza_);
                CqlInterval<CqlDate> hza_ = context.Operators.Interval(gzr_, gzz_, true, false);
                bool? hzb_ = hza_?.highClosed;
                CqlInterval<CqlDateTime> hzc_ = context.Operators.Interval(fze_, fzv_, gzl_, hzb_);

                return hzc_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> hzd_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return hzd_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> hze_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return hze_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return bzz_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> hzf_()
        {
            bool hzg_()
            {
                DataType hzm_ = condition?.Abatement;
                bool hzn_ = hzm_ is FhirDateTime;

                return hzn_;
            };
            bool hzh_()
            {
                DataType hzo_ = condition?.Abatement;
                bool hzp_ = hzo_ is Period;

                return hzp_;
            };
            bool hzi_()
            {
                DataType hzq_ = condition?.Abatement;
                bool hzr_ = hzq_ is FhirString;

                return hzr_;
            };
            bool hzj_()
            {
                DataType hzs_ = condition?.Abatement;
                bool hzt_ = hzs_ is Age;

                return hzt_;
            };
            bool hzk_()
            {
                DataType hzu_ = condition?.Abatement;
                bool hzv_ = hzu_ is Range;

                return hzv_;
            };
            bool hzl_()
            {
                DataType hzw_ = condition?.Abatement;
                bool hzx_ = hzw_ is FhirBoolean;

                return hzx_;
            };
            if (hzg_())
            {
                DataType hzy_ = condition?.Abatement;
                CqlDateTime hzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzy_ as FhirDateTime);
                CqlDateTime izb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzy_ as FhirDateTime);
                CqlInterval<CqlDateTime> izc_ = context.Operators.Interval(hzz_, izb_, true, true);

                return izc_;
            }
            else if (hzh_())
            {
                DataType izd_ = condition?.Abatement;
                CqlInterval<CqlDateTime> ize_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izd_ as Period);

                return ize_;
            }
            else if (hzi_())
            {
                CqlInterval<CqlDateTime> izf_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return izf_;
            }
            else if (hzj_())
            {
                Patient izg_ = this.Patient(context);
                Date izh_ = izg_?.BirthDateElement;
                CqlDate izi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izh_);
                DataType izj_ = condition?.Abatement;
                CqlQuantity izk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate izl_ = context.Operators.Add(izi_, izk_);
                Date izn_ = izg_?.BirthDateElement;
                CqlDate izo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izn_);
                CqlQuantity izq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate izr_ = context.Operators.Add(izo_, izq_);
                CqlQuantity izs_ = context.Operators.Quantity(1m, "year");
                CqlDate izt_ = context.Operators.Add(izr_, izs_);
                CqlInterval<CqlDate> izu_ = context.Operators.Interval(izl_, izt_, true, false);
                CqlDate izv_ = izu_?.low;
                CqlDateTime izw_ = context.Operators.ConvertDateToDateTime(izv_);
                Date izy_ = izg_?.BirthDateElement;
                CqlDate izz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izy_);
                CqlQuantity jzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate jzc_ = context.Operators.Add(izz_, jzb_);
                Date jze_ = izg_?.BirthDateElement;
                CqlDate jzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jze_);
                CqlQuantity jzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate jzi_ = context.Operators.Add(jzf_, jzh_);
                CqlDate jzk_ = context.Operators.Add(jzi_, izs_);
                CqlInterval<CqlDate> jzl_ = context.Operators.Interval(jzc_, jzk_, true, false);
                CqlDate jzm_ = jzl_?.high;
                CqlDateTime jzn_ = context.Operators.ConvertDateToDateTime(jzm_);
                Date jzp_ = izg_?.BirthDateElement;
                CqlDate jzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzp_);
                CqlQuantity jzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate jzt_ = context.Operators.Add(jzq_, jzs_);
                Date jzv_ = izg_?.BirthDateElement;
                CqlDate jzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzv_);
                CqlQuantity jzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate jzz_ = context.Operators.Add(jzw_, jzy_);
                CqlDate kzb_ = context.Operators.Add(jzz_, izs_);
                CqlInterval<CqlDate> kzc_ = context.Operators.Interval(jzt_, kzb_, true, false);
                bool? kzd_ = kzc_?.lowClosed;
                Date kzf_ = izg_?.BirthDateElement;
                CqlDate kzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzf_);
                CqlQuantity kzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate kzj_ = context.Operators.Add(kzg_, kzi_);
                Date kzl_ = izg_?.BirthDateElement;
                CqlDate kzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzl_);
                CqlQuantity kzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izj_ as Age);
                CqlDate kzp_ = context.Operators.Add(kzm_, kzo_);
                CqlDate kzr_ = context.Operators.Add(kzp_, izs_);
                CqlInterval<CqlDate> kzs_ = context.Operators.Interval(kzj_, kzr_, true, false);
                bool? kzt_ = kzs_?.highClosed;
                CqlInterval<CqlDateTime> kzu_ = context.Operators.Interval(izw_, jzn_, kzd_, kzt_);

                return kzu_;
            }
            else if (hzk_())
            {
                Patient kzv_ = this.Patient(context);
                Date kzw_ = kzv_?.BirthDateElement;
                CqlDate kzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzw_);
                DataType kzy_ = condition?.Abatement;
                Quantity kzz_ = (kzy_ as Range)?.Low;
                CqlQuantity lza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzz_);
                CqlDate lzb_ = context.Operators.Add(kzx_, lza_);
                Date lzd_ = kzv_?.BirthDateElement;
                CqlDate lze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzd_);
                Quantity lzg_ = (kzy_ as Range)?.High;
                CqlQuantity lzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzg_);
                CqlDate lzi_ = context.Operators.Add(lze_, lzh_);
                CqlQuantity lzj_ = context.Operators.Quantity(1m, "year");
                CqlDate lzk_ = context.Operators.Add(lzi_, lzj_);
                CqlInterval<CqlDate> lzl_ = context.Operators.Interval(lzb_, lzk_, true, false);
                CqlDate lzm_ = lzl_?.low;
                CqlDateTime lzn_ = context.Operators.ConvertDateToDateTime(lzm_);
                Date lzp_ = kzv_?.BirthDateElement;
                CqlDate lzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzp_);
                Quantity lzs_ = (kzy_ as Range)?.Low;
                CqlQuantity lzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzs_);
                CqlDate lzu_ = context.Operators.Add(lzq_, lzt_);
                Date lzw_ = kzv_?.BirthDateElement;
                CqlDate lzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzw_);
                Quantity lzz_ = (kzy_ as Range)?.High;
                CqlQuantity mza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzz_);
                CqlDate mzb_ = context.Operators.Add(lzx_, mza_);
                CqlDate mzd_ = context.Operators.Add(mzb_, lzj_);
                CqlInterval<CqlDate> mze_ = context.Operators.Interval(lzu_, mzd_, true, false);
                CqlDate mzf_ = mze_?.high;
                CqlDateTime mzg_ = context.Operators.ConvertDateToDateTime(mzf_);
                Date mzi_ = kzv_?.BirthDateElement;
                CqlDate mzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzi_);
                Quantity mzl_ = (kzy_ as Range)?.Low;
                CqlQuantity mzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzl_);
                CqlDate mzn_ = context.Operators.Add(mzj_, mzm_);
                Date mzp_ = kzv_?.BirthDateElement;
                CqlDate mzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzp_);
                Quantity mzs_ = (kzy_ as Range)?.High;
                CqlQuantity mzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzs_);
                CqlDate mzu_ = context.Operators.Add(mzq_, mzt_);
                CqlDate mzw_ = context.Operators.Add(mzu_, lzj_);
                CqlInterval<CqlDate> mzx_ = context.Operators.Interval(mzn_, mzw_, true, false);
                bool? mzy_ = mzx_?.lowClosed;
                Date nza_ = kzv_?.BirthDateElement;
                CqlDate nzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nza_);
                Quantity nzd_ = (kzy_ as Range)?.Low;
                CqlQuantity nze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzd_);
                CqlDate nzf_ = context.Operators.Add(nzb_, nze_);
                Date nzh_ = kzv_?.BirthDateElement;
                CqlDate nzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzh_);
                Quantity nzk_ = (kzy_ as Range)?.High;
                CqlQuantity nzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_);
                CqlDate nzm_ = context.Operators.Add(nzi_, nzl_);
                CqlDate nzo_ = context.Operators.Add(nzm_, lzj_);
                CqlInterval<CqlDate> nzp_ = context.Operators.Interval(nzf_, nzo_, true, false);
                bool? nzq_ = nzp_?.highClosed;
                CqlInterval<CqlDateTime> nzr_ = context.Operators.Interval(lzn_, mzg_, mzy_, nzq_);

                return nzr_;
            }
            else if (hzl_())
            {
                DataType nzs_ = condition?.Onset;
                CqlInterval<CqlDateTime> nzt_ = this.Normalize_Interval(context, nzs_);
                CqlDateTime nzu_ = context.Operators.End(nzt_);
                FhirDateTime nzv_ = condition?.RecordedDateElement;
                CqlDateTime nzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzv_);
                CqlInterval<CqlDateTime> nzx_ = context.Operators.Interval(nzu_, nzw_, true, false);

                return nzx_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return hzf_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> nzy_()
        {
            bool nzz_()
            {
                CodeableConcept oza_ = condition?.ClinicalStatus;
                CqlConcept ozb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, oza_);
                CqlCode ozc_ = this.active(context);
                CqlConcept ozd_ = context.Operators.ConvertCodeToConcept(ozc_);
                bool? oze_ = context.Operators.Equivalent(ozb_, ozd_);
                CqlConcept ozg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, oza_);
                CqlCode ozh_ = this.recurrence(context);
                CqlConcept ozi_ = context.Operators.ConvertCodeToConcept(ozh_);
                bool? ozj_ = context.Operators.Equivalent(ozg_, ozi_);
                bool? ozk_ = context.Operators.Or(oze_, ozj_);
                CqlConcept ozm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, oza_);
                CqlCode ozn_ = this.relapse(context);
                CqlConcept ozo_ = context.Operators.ConvertCodeToConcept(ozn_);
                bool? ozp_ = context.Operators.Equivalent(ozm_, ozo_);
                bool? ozq_ = context.Operators.Or(ozk_, ozp_);

                return ozq_ ?? false;
            };
            if (nzz_())
            {
                DataType ozr_ = condition?.Onset;
                CqlInterval<CqlDateTime> ozs_ = this.Normalize_Interval(context, ozr_);
                CqlDateTime ozt_ = context.Operators.Start(ozs_);
                CqlInterval<CqlDateTime> ozu_ = this.Normalize_Abatement(context, condition);
                CqlDateTime ozv_ = context.Operators.End(ozu_);
                CqlInterval<CqlDateTime> ozw_ = context.Operators.Interval(ozt_, ozv_, true, true);

                return ozw_;
            }
            else
            {
                DataType ozx_ = condition?.Onset;
                CqlInterval<CqlDateTime> ozy_ = this.Normalize_Interval(context, ozx_);
                CqlDateTime ozz_ = context.Operators.Start(ozy_);
                CqlInterval<CqlDateTime> pza_ = this.Normalize_Abatement(context, condition);
                CqlDateTime pzb_ = context.Operators.End(pza_);
                CqlInterval<CqlDateTime> pzc_ = context.Operators.Interval(ozz_, pzb_, true, false);

                return pzc_;
            }
        };

        return nzy_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> pzd_ = context.Operators.Split(uri, "/");
        string pze_ = context.Operators.Last<string>(pzd_);

        return pze_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> pzf_ = Encounter?.Diagnosis;
        Condition pzg_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> pzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? pzk_(Condition C)
            {
                Id pzn_ = C?.IdElement;
                string pzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzn_);
                ResourceReference pzp_ = D?.Condition;
                FhirString pzq_ = pzp_?.ReferenceElement;
                string pzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzq_);
                string pzs_ = this.GetId(context, pzr_);
                bool? pzt_ = context.Operators.Equal(pzo_, pzs_);

                return pzt_;
            };
            IEnumerable<Condition> pzl_ = context.Operators.Where<Condition>(pzj_, pzk_);
            Condition pzm_ = context.Operators.SingletonFrom<Condition>(pzl_);

            return pzm_;
        };
        IEnumerable<Condition> pzh_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)pzf_, pzg_);
        IEnumerable<Condition> pzi_ = context.Operators.Distinct<Condition>(pzh_);

        return pzi_;
    }


    [CqlExpressionDefinition("GetCondition")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> pzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzv_(Condition C)
        {
            Id pzy_ = C?.IdElement;
            string pzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzy_);
            FhirString qza_ = reference?.ReferenceElement;
            string qzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, qza_);
            string qzc_ = this.GetId(context, qzb_);
            bool? qzd_ = context.Operators.Equal(pzz_, qzc_);

            return qzd_;
        };
        IEnumerable<Condition> pzw_ = context.Operators.Where<Condition>(pzu_, pzv_);
        Condition pzx_ = context.Operators.SingletonFrom<Condition>(pzw_);

        return pzx_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> qze_ = domainResource?.Extension;
        bool? qzf_(Extension E)
        {
            string qzk_ = E?.Url;
            FhirUri qzl_ = context.Operators.Convert<FhirUri>(qzk_);
            string qzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzl_);
            string qzn_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? qzo_ = context.Operators.Equal(qzm_, qzn_);

            return qzo_;
        };
        IEnumerable<Extension> qzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)qze_, qzf_);
        Extension qzh_(Extension E) =>
            E;
        IEnumerable<Extension> qzi_ = context.Operators.Select<Extension, Extension>(qzg_, qzh_);
        IEnumerable<Extension> qzj_ = context.Operators.Distinct<Extension>(qzi_);

        return qzj_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> qzp_ = element?.Extension;
        bool? qzq_(Extension E)
        {
            string qzv_ = E?.Url;
            FhirUri qzw_ = context.Operators.Convert<FhirUri>(qzv_);
            string qzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzw_);
            bool? qzy_ = context.Operators.Equal(qzx_, url);

            return qzy_;
        };
        IEnumerable<Extension> qzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)qzp_, qzq_);
        Extension qzs_(Extension E) =>
            E;
        IEnumerable<Extension> qzt_ = context.Operators.Select<Extension, Extension>(qzr_, qzs_);
        IEnumerable<Extension> qzu_ = context.Operators.Distinct<Extension>(qzt_);

        return qzu_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> qzz_ = this.GetExtensions(context, domainResource, url);
        Extension rza_ = context.Operators.SingletonFrom<Extension>(qzz_);

        return rza_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> rzb_ = this.GetExtensions(context, element, url);
        Extension rzc_ = context.Operators.SingletonFrom<Extension>(rzb_);

        return rzc_;
    }


    [CqlExpressionDefinition("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension rzd_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType rze_ = rzd_?.Value;

        return rze_ as CodeableConcept;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> rzf_ = Encounter?.Diagnosis;
        bool? rzg_(Encounter.DiagnosisComponent D)
        {
            PositiveInt rzo_ = D?.RankElement;
            Integer rzp_ = context.Operators.Convert<Integer>(rzo_);
            int? rzq_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, rzp_);
            bool? rzr_ = context.Operators.Equal(rzq_, 1);

            return rzr_;
        };
        IEnumerable<Encounter.DiagnosisComponent> rzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzf_, rzg_);
        Encounter.DiagnosisComponent rzi_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(rzh_);
        Encounter.DiagnosisComponent[] rzj_ = [
            rzi_,
        ];
        Condition rzk_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> rzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? rzt_(Condition C)
            {
                Id rzw_ = C?.IdElement;
                string rzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzw_);
                ResourceReference rzy_ = PD?.Condition;
                FhirString rzz_ = rzy_?.ReferenceElement;
                string sza_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzz_);
                string szb_ = this.GetId(context, sza_);
                bool? szc_ = context.Operators.Equal(rzx_, szb_);

                return szc_;
            };
            IEnumerable<Condition> rzu_ = context.Operators.Where<Condition>(rzs_, rzt_);
            Condition rzv_ = context.Operators.SingletonFrom<Condition>(rzu_);

            return rzv_;
        };
        IEnumerable<Condition> rzl_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)rzj_, rzk_);
        IEnumerable<Condition> rzm_ = context.Operators.Distinct<Condition>(rzl_);
        Condition rzn_ = context.Operators.SingletonFrom<Condition>(rzm_);

        return rzn_;
    }


    [CqlExpressionDefinition("GetLocation")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> szd_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
        bool? sze_(Location L)
        {
            Id szh_ = L?.IdElement;
            string szi_ = FHIRHelpers_4_0_001.Instance.ToString(context, szh_);
            FhirString szj_ = reference?.ReferenceElement;
            string szk_ = FHIRHelpers_4_0_001.Instance.ToString(context, szj_);
            string szl_ = this.GetId(context, szk_);
            bool? szm_ = context.Operators.Equal(szi_, szl_);

            return szm_;
        };
        IEnumerable<Location> szf_ = context.Operators.Where<Location>(szd_, sze_);
        Location szg_ = context.Operators.SingletonFrom<Location>(szf_);

        return szg_;
    }


    [CqlExpressionDefinition("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> szn_ = domainResource?.Extension;
        bool? szo_(Extension E)
        {
            string szt_ = E?.Url;
            FhirUri szu_ = context.Operators.Convert<FhirUri>(szt_);
            string szv_ = FHIRHelpers_4_0_001.Instance.ToString(context, szu_);
            string szw_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? szx_ = context.Operators.Equal(szv_, szw_);

            return szx_;
        };
        IEnumerable<Extension> szp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)szn_, szo_);
        Extension szq_(Extension E) =>
            E;
        IEnumerable<Extension> szr_ = context.Operators.Select<Extension, Extension>(szp_, szq_);
        IEnumerable<Extension> szs_ = context.Operators.Distinct<Extension>(szr_);

        return szs_;
    }


    [CqlExpressionDefinition("GetBaseExtension")]
    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> szy_ = this.GetBaseExtensions(context, domainResource, url);
        Extension szz_ = context.Operators.SingletonFrom<Extension>(szy_);

        return szz_;
    }


    [CqlExpressionDefinition("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access\ncontent that is defined by extensions but not yet surfaced in the CQL model info.")]
    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> tza_ = element?.Extension;
        bool? tzb_(Extension E)
        {
            string tzg_ = E?.Url;
            FhirUri tzh_ = context.Operators.Convert<FhirUri>(tzg_);
            string tzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzh_);
            string tzj_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? tzk_ = context.Operators.Equal(tzi_, tzj_);

            return tzk_;
        };
        IEnumerable<Extension> tzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)tza_, tzb_);
        Extension tzd_(Extension E) =>
            E;
        IEnumerable<Extension> tze_ = context.Operators.Select<Extension, Extension>(tzc_, tzd_);
        IEnumerable<Extension> tzf_ = context.Operators.Distinct<Extension>(tze_);

        return tzf_;
    }


    [CqlExpressionDefinition("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there\nis more than one extension on the given resource with the specified url.")]
    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> tzl_ = this.BaseExtensions(context, element, id);
        Extension tzm_ = context.Operators.SingletonFrom<Extension>(tzl_);

        return tzm_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CodeableConcept tzn_()
        {
            bool tzo_()
            {
                DataType tzp_ = request?.Medication;
                bool tzq_ = tzp_ is CodeableConcept;

                return tzq_;
            };
            if (tzo_())
            {
                DataType tzr_ = request?.Medication;

                return tzr_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> tzs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                bool? tzt_(Medication M)
                {
                    Id tzx_ = M?.IdElement;
                    string tzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzx_);
                    DataType tzz_ = request?.Medication;
                    FhirString uza_ = (tzz_ as ResourceReference)?.ReferenceElement;
                    string uzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, uza_);
                    string uzc_ = this.GetId(context, uzb_);
                    bool? uzd_ = context.Operators.Equal(tzy_, uzc_);

                    return uzd_;
                };
                IEnumerable<Medication> tzu_ = context.Operators.Where<Medication>(tzs_, tzt_);
                Medication tzv_ = context.Operators.SingletonFrom<Medication>(tzu_);
                CodeableConcept tzw_ = tzv_?.Code;

                return tzw_;
            }
        };

        return tzn_();
    }


    [CqlExpressionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime uze_ = context.Operators.Start(period);
        CqlDateTime uzg_ = context.Operators.MinValue<CqlDateTime>();
        bool? uzh_ = context.Operators.Equal(uze_, uzg_);
        bool? uzi_ = context.Operators.Or((bool?)(uze_ is null), uzh_);
        bool? uzj_ = context.Operators.Not(uzi_);

        return uzj_;
    }


    [CqlExpressionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime uzk_ = context.Operators.End(period);
        CqlDateTime uzm_ = context.Operators.MaxValue<CqlDateTime>();
        bool? uzn_ = context.Operators.Equal(uzk_, uzm_);
        bool? uzo_ = context.Operators.Or((bool?)(uzk_ is null), uzn_);
        bool? uzp_ = context.Operators.Not(uzo_);

        return uzp_;
    }


    [CqlExpressionDefinition("Latest")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzq_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] uzr_ = [
            uzq_,
        ];
        CqlDateTime uzs_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime uzw_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime uzx_ = context.Operators.End(period);

                    return uzx_;
                }
                else
                {
                    CqlDateTime uzy_ = context.Operators.Start(period);

                    return uzy_;
                }
            };

            return uzw_();
        };
        IEnumerable<CqlDateTime> uzt_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)uzr_, uzs_);
        IEnumerable<CqlDateTime> uzu_ = context.Operators.Distinct<CqlDateTime>(uzt_);
        CqlDateTime uzv_ = context.Operators.SingletonFrom<CqlDateTime>(uzu_);

        return uzv_;
    }


    [CqlExpressionDefinition("Earliest")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzz_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] vza_ = [
            uzz_,
        ];
        CqlDateTime vzb_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime vzf_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime vzg_ = context.Operators.Start(period);

                    return vzg_;
                }
                else
                {
                    CqlDateTime vzh_ = context.Operators.End(period);

                    return vzh_;
                }
            };

            return vzf_();
        };
        IEnumerable<CqlDateTime> vzc_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)vza_, vzb_);
        IEnumerable<CqlDateTime> vzd_ = context.Operators.Distinct<CqlDateTime>(vzc_);
        CqlDateTime vze_ = context.Operators.SingletonFrom<CqlDateTime>(vzd_);

        return vze_;
    }


    #endregion Expressions

}
