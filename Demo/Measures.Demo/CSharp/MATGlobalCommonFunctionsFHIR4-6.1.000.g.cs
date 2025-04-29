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
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("allergy-active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext _) => _allergy_active;
    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext _) => _allergy_confirmed;
    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("allergy-inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext _) => _allergy_inactive;
    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext _) => _allergy_refuted;
    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("allergy-resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext _) => _allergy_resolved;
    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext _) => _allergy_unconfirmed;
    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("Birthdate", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext _) => _Birthdate;
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Community", codeId: "community", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext _) => _Community;
    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("Dead", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext _) => _Dead;
    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("Discharge", codeId: "discharge", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext _) => _Discharge;
    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("ER", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext _) => _ER;
    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlCodeDefinition("ICU", codeId: "ICU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext _) => _ICU;
    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlCodeDefinition("inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext _) => _inactive;
    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("recurrence", codeId: "recurrence", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext _) => _recurrence;
    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("relapse", codeId: "relapse", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext _) => _relapse;
    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("remission", codeId: "remission", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext _) => _remission;
    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext _) => _resolved;
    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("Diagnosis Role")]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role = new CqlCodeSystem();

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wp_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime wq_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> wr_ = context.Operators.Interval(wp_, wq_, true, false);
        object ws_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", wr_);

        return (CqlInterval<CqlDateTime>)ws_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wu_ = context.Operators.SingletonFrom<Patient>(wt_);

        return wu_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime wv_ = context.Operators.Start(Value);
        CqlDateTime ww_ = context.Operators.End(Value);
        int? wx_ = context.Operators.DifferenceBetween(wv_, ww_, "day");

        return wx_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet wy_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> wz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? xa_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> xc_ = EncounterInpatient?.StatusElement;
            string xd_ = FHIRHelpers_4_0_001.Instance.ToString(context, xc_);
            bool? xe_ = context.Operators.Equal(xd_, "finished");
            Period xf_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> xg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xf_);
            int? xh_ = this.LengthInDays(context, xg_);
            bool? xi_ = context.Operators.LessOrEqual(xh_, 120);
            bool? xj_ = context.Operators.And(xe_, xi_);
            CqlInterval<CqlDateTime> xl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xf_);
            CqlDateTime xm_ = context.Operators.End(xl_);
            CqlInterval<CqlDateTime> xn_ = this.Measurement_Period(context);
            bool? xo_ = context.Operators.In<CqlDateTime>(xm_, xn_, default);
            bool? xp_ = context.Operators.And(xj_, xo_);

            return xp_;
        };
        IEnumerable<Encounter> xb_ = context.Operators.Where<Encounter>(wz_, xa_);

        return xb_;
    }


    [CqlExpressionDefinition("ED Visit")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet xq_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> xr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? xs_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> xx_ = EDVisit?.StatusElement;
            string xy_ = FHIRHelpers_4_0_001.Instance.ToString(context, xx_);
            bool? xz_ = context.Operators.Equal(xy_, "finished");
            Period ya_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> yb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ya_);
            CqlDateTime yc_ = context.Operators.End(yb_);
            Period yd_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> ye_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yd_);
            CqlDateTime yf_ = context.Operators.Start(ye_);
            CqlQuantity yg_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime yh_ = context.Operators.Subtract(yf_, yg_);
            CqlInterval<CqlDateTime> yj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yd_);
            CqlDateTime yk_ = context.Operators.Start(yj_);
            CqlInterval<CqlDateTime> yl_ = context.Operators.Interval(yh_, yk_, true, true);
            bool? ym_ = context.Operators.In<CqlDateTime>(yc_, yl_, default);
            CqlInterval<CqlDateTime> yo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yd_);
            CqlDateTime yp_ = context.Operators.Start(yo_);
            bool? yq_ = context.Operators.Not((bool?)(yp_ is null));
            bool? yr_ = context.Operators.And(ym_, yq_);
            bool? ys_ = context.Operators.And(xz_, yr_);

            return ys_;
        };
        IEnumerable<Encounter> xt_ = context.Operators.Where<Encounter>(xr_, xs_);
        object xu_(Encounter @this)
        {
            Period yt_ = @this?.Period;
            CqlInterval<CqlDateTime> yu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yt_);
            CqlDateTime yv_ = context.Operators.End(yu_);

            return yv_;
        };
        IEnumerable<Encounter> xv_ = context.Operators.SortBy<Encounter>(xt_, xu_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter xw_ = context.Operators.Last<Encounter>(xv_);

        return xw_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter yw_ = this.ED_Visit(context, TheEncounter);
        Encounter[] yx_ = [
            yw_,
        ];
        CqlInterval<CqlDateTime> yy_(Encounter X)
        {
            CqlInterval<CqlDateTime> zc_()
            {
                if (X is null)
                {
                    Period zd_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> ze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zd_);

                    return ze_;
                }
                else
                {
                    Period zf_ = X?.Period;
                    CqlInterval<CqlDateTime> zg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zf_);
                    CqlDateTime zh_ = context.Operators.Start(zg_);
                    Period zi_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> zj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zi_);
                    CqlDateTime zk_ = context.Operators.End(zj_);
                    CqlInterval<CqlDateTime> zl_ = context.Operators.Interval(zh_, zk_, true, true);

                    return zl_;
                }
            };

            return zc_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> yz_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yx_, yy_);
        IEnumerable<CqlInterval<CqlDateTime>> za_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yz_);
        CqlInterval<CqlDateTime> zb_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(za_);

        return zb_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter zm_ = this.ED_Visit(context, TheEncounter);
        Encounter[] zn_ = [
            zm_,
        ];
        IEnumerable<Encounter.LocationComponent> zo_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> zs_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> zt_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)zt_;
                }
                else
                {
                    List<Encounter.LocationComponent> zu_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> zv_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] zw_ = [
                        (IEnumerable<Encounter.LocationComponent>)zu_,
                        (IEnumerable<Encounter.LocationComponent>)zv_,
                    ];
                    IEnumerable<Encounter.LocationComponent> zx_ = context.Operators.Flatten<Encounter.LocationComponent>(zw_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return zx_;
                }
            };

            return zs_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zp_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)zn_, zo_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zq_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(zp_);
        IEnumerable<Encounter.LocationComponent> zr_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(zq_);

        return zr_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zy_ = this.Hospitalization(context, TheEncounter);
        int? zz_ = this.LengthInDays(context, zy_);

        return zz_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> aza_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime azb_ = context.Operators.Start(aza_);

        return azb_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period azc_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> azd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azc_);
        CqlDateTime aze_ = context.Operators.End(azd_);

        return aze_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> azf_ = this.Hospitalization_Locations(context, TheEncounter);
        object azg_(Encounter.LocationComponent @this)
        {
            Period azm_ = @this?.Period;
            CqlInterval<CqlDateTime> azn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azm_);
            CqlDateTime azo_ = context.Operators.Start(azn_);

            return azo_;
        };
        IEnumerable<Encounter.LocationComponent> azh_ = context.Operators.SortBy<Encounter.LocationComponent>(azf_, azg_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent azi_ = context.Operators.First<Encounter.LocationComponent>(azh_);
        Period azj_ = azi_?.Period;
        CqlInterval<CqlDateTime> azk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azj_);
        CqlDateTime azl_ = context.Operators.Start(azk_);

        return azl_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] azp_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> azq_(Encounter Visit)
        {
            CqlValueSet azu_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> azv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? azw_(Encounter LastED)
            {
                Period bzv_ = LastED?.Period;
                CqlInterval<CqlDateTime> bzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzv_);
                CqlDateTime bzx_ = context.Operators.End(bzw_);
                CqlValueSet bzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> bzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? cza_(Encounter LastObs)
                {
                    Period dzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzr_);
                    CqlDateTime dzt_ = context.Operators.End(dzs_);
                    Period dzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzu_);
                    CqlDateTime dzw_ = context.Operators.Start(dzv_);
                    CqlQuantity dzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzy_ = context.Operators.Subtract(dzw_, dzx_);
                    CqlInterval<CqlDateTime> eza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzu_);
                    CqlDateTime ezb_ = context.Operators.Start(eza_);
                    CqlInterval<CqlDateTime> ezc_ = context.Operators.Interval(dzy_, ezb_, true, true);
                    bool? ezd_ = context.Operators.In<CqlDateTime>(dzt_, ezc_, default);
                    CqlInterval<CqlDateTime> ezf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzu_);
                    CqlDateTime ezg_ = context.Operators.Start(ezf_);
                    bool? ezh_ = context.Operators.Not((bool?)(ezg_ is null));
                    bool? ezi_ = context.Operators.And(ezd_, ezh_);

                    return ezi_;
                };
                IEnumerable<Encounter> czb_ = context.Operators.Where<Encounter>(bzz_, cza_);
                object czc_(Encounter @this)
                {
                    Period ezj_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezj_);
                    CqlDateTime ezl_ = context.Operators.End(ezk_);

                    return ezl_;
                };
                IEnumerable<Encounter> czd_ = context.Operators.SortBy<Encounter>(czb_, czc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cze_ = context.Operators.Last<Encounter>(czd_);
                Period czf_ = cze_?.Period;
                CqlInterval<CqlDateTime> czg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czf_);
                CqlDateTime czh_ = context.Operators.Start(czg_);
                Period czi_ = Visit?.Period;
                CqlInterval<CqlDateTime> czj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czi_);
                CqlDateTime czk_ = context.Operators.Start(czj_);
                CqlQuantity czl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czm_ = context.Operators.Subtract(czh_ ?? czk_, czl_);
                IEnumerable<Encounter> czo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? czp_(Encounter LastObs)
                {
                    Period ezm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezm_);
                    CqlDateTime ezo_ = context.Operators.End(ezn_);
                    Period ezp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezp_);
                    CqlDateTime ezr_ = context.Operators.Start(ezq_);
                    CqlQuantity ezs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezt_ = context.Operators.Subtract(ezr_, ezs_);
                    CqlInterval<CqlDateTime> ezv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezp_);
                    CqlDateTime ezw_ = context.Operators.Start(ezv_);
                    CqlInterval<CqlDateTime> ezx_ = context.Operators.Interval(ezt_, ezw_, true, true);
                    bool? ezy_ = context.Operators.In<CqlDateTime>(ezo_, ezx_, default);
                    CqlInterval<CqlDateTime> fza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezp_);
                    CqlDateTime fzb_ = context.Operators.Start(fza_);
                    bool? fzc_ = context.Operators.Not((bool?)(fzb_ is null));
                    bool? fzd_ = context.Operators.And(ezy_, fzc_);

                    return fzd_;
                };
                IEnumerable<Encounter> czq_ = context.Operators.Where<Encounter>(czo_, czp_);
                object czr_(Encounter @this)
                {
                    Period fze_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fze_);
                    CqlDateTime fzg_ = context.Operators.End(fzf_);

                    return fzg_;
                };
                IEnumerable<Encounter> czs_ = context.Operators.SortBy<Encounter>(czq_, czr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czt_ = context.Operators.Last<Encounter>(czs_);
                Period czu_ = czt_?.Period;
                CqlInterval<CqlDateTime> czv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czu_);
                CqlDateTime czw_ = context.Operators.Start(czv_);
                CqlInterval<CqlDateTime> czy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czi_);
                CqlDateTime czz_ = context.Operators.Start(czy_);
                CqlInterval<CqlDateTime> dza_ = context.Operators.Interval(czm_, czw_ ?? czz_, true, true);
                bool? dzb_ = context.Operators.In<CqlDateTime>(bzx_, dza_, default);
                IEnumerable<Encounter> dzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? dze_(Encounter LastObs)
                {
                    Period fzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzh_);
                    CqlDateTime fzj_ = context.Operators.End(fzi_);
                    Period fzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzk_);
                    CqlDateTime fzm_ = context.Operators.Start(fzl_);
                    CqlQuantity fzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzo_ = context.Operators.Subtract(fzm_, fzn_);
                    CqlInterval<CqlDateTime> fzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzk_);
                    CqlDateTime fzr_ = context.Operators.Start(fzq_);
                    CqlInterval<CqlDateTime> fzs_ = context.Operators.Interval(fzo_, fzr_, true, true);
                    bool? fzt_ = context.Operators.In<CqlDateTime>(fzj_, fzs_, default);
                    CqlInterval<CqlDateTime> fzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzk_);
                    CqlDateTime fzw_ = context.Operators.Start(fzv_);
                    bool? fzx_ = context.Operators.Not((bool?)(fzw_ is null));
                    bool? fzy_ = context.Operators.And(fzt_, fzx_);

                    return fzy_;
                };
                IEnumerable<Encounter> dzf_ = context.Operators.Where<Encounter>(dzd_, dze_);
                object dzg_(Encounter @this)
                {
                    Period fzz_ = @this?.Period;
                    CqlInterval<CqlDateTime> gza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzz_);
                    CqlDateTime gzb_ = context.Operators.End(gza_);

                    return gzb_;
                };
                IEnumerable<Encounter> dzh_ = context.Operators.SortBy<Encounter>(dzf_, dzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzi_ = context.Operators.Last<Encounter>(dzh_);
                Period dzj_ = dzi_?.Period;
                CqlInterval<CqlDateTime> dzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzj_);
                CqlDateTime dzl_ = context.Operators.Start(dzk_);
                CqlInterval<CqlDateTime> dzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czi_);
                CqlDateTime dzo_ = context.Operators.Start(dzn_);
                bool? dzp_ = context.Operators.Not((bool?)((dzl_ ?? dzo_) is null));
                bool? dzq_ = context.Operators.And(dzb_, dzp_);

                return dzq_;
            };
            IEnumerable<Encounter> azx_ = context.Operators.Where<Encounter>(azv_, azw_);
            object azy_(Encounter @this)
            {
                Period gzc_ = @this?.Period;
                CqlInterval<CqlDateTime> gzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzc_);
                CqlDateTime gze_ = context.Operators.End(gzd_);

                return gze_;
            };
            IEnumerable<Encounter> azz_ = context.Operators.SortBy<Encounter>(azx_, azy_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter bza_ = context.Operators.Last<Encounter>(azz_);
            Period bzb_ = bza_?.Period;
            CqlInterval<CqlDateTime> bzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzb_);
            CqlDateTime bzd_ = context.Operators.Start(bzc_);
            CqlValueSet bze_ = this.Observation_Services(context);
            IEnumerable<Encounter> bzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? bzg_(Encounter LastObs)
            {
                Period gzf_ = LastObs?.Period;
                CqlInterval<CqlDateTime> gzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzf_);
                CqlDateTime gzh_ = context.Operators.End(gzg_);
                Period gzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzi_);
                CqlDateTime gzk_ = context.Operators.Start(gzj_);
                CqlQuantity gzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzm_ = context.Operators.Subtract(gzk_, gzl_);
                CqlInterval<CqlDateTime> gzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzi_);
                CqlDateTime gzp_ = context.Operators.Start(gzo_);
                CqlInterval<CqlDateTime> gzq_ = context.Operators.Interval(gzm_, gzp_, true, true);
                bool? gzr_ = context.Operators.In<CqlDateTime>(gzh_, gzq_, default);
                CqlInterval<CqlDateTime> gzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzi_);
                CqlDateTime gzu_ = context.Operators.Start(gzt_);
                bool? gzv_ = context.Operators.Not((bool?)(gzu_ is null));
                bool? gzw_ = context.Operators.And(gzr_, gzv_);

                return gzw_;
            };
            IEnumerable<Encounter> bzh_ = context.Operators.Where<Encounter>(bzf_, bzg_);
            object bzi_(Encounter @this)
            {
                Period gzx_ = @this?.Period;
                CqlInterval<CqlDateTime> gzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzx_);
                CqlDateTime gzz_ = context.Operators.End(gzy_);

                return gzz_;
            };
            IEnumerable<Encounter> bzj_ = context.Operators.SortBy<Encounter>(bzh_, bzi_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter bzk_ = context.Operators.Last<Encounter>(bzj_);
            Period bzl_ = bzk_?.Period;
            CqlInterval<CqlDateTime> bzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzl_);
            CqlDateTime bzn_ = context.Operators.Start(bzm_);
            Period bzo_ = Visit?.Period;
            CqlInterval<CqlDateTime> bzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzo_);
            CqlDateTime bzq_ = context.Operators.Start(bzp_);
            CqlInterval<CqlDateTime> bzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzo_);
            CqlDateTime bzt_ = context.Operators.End(bzs_);
            CqlInterval<CqlDateTime> bzu_ = context.Operators.Interval(bzd_ ?? bzn_ ?? bzq_, bzt_, true, true);

            return bzu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> azr_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)azp_, azq_);
        IEnumerable<CqlInterval<CqlDateTime>> azs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azr_);
        CqlInterval<CqlDateTime> azt_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(azs_);

        return azt_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hza_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime hzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> hzd_ = context.Operators.Interval(hzb_, hzb_, true, true);

                return hzd_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> hze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);

                return hze_;
            }
            else if (choice is Instant)
            {
                CqlDateTime hzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> hzh_ = context.Operators.Interval(hzf_, hzf_, true, true);

                return hzh_;
            }
            else if (choice is Age)
            {
                Patient hzi_ = this.Patient(context);
                Date hzj_ = hzi_?.BirthDateElement;
                CqlDate hzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzj_);
                CqlQuantity hzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate hzm_ = context.Operators.Add(hzk_, hzl_);
                Date hzo_ = hzi_?.BirthDateElement;
                CqlDate hzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzo_);
                CqlDate hzr_ = context.Operators.Add(hzp_, hzl_);
                CqlQuantity hzs_ = context.Operators.Quantity(1m, "year");
                CqlDate hzt_ = context.Operators.Add(hzr_, hzs_);
                CqlInterval<CqlDate> hzu_ = context.Operators.Interval(hzm_, hzt_, true, false);
                CqlDate hzv_ = hzu_?.low;
                CqlDateTime hzw_ = context.Operators.ConvertDateToDateTime(hzv_);
                Date hzy_ = hzi_?.BirthDateElement;
                CqlDate hzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzy_);
                CqlDate izb_ = context.Operators.Add(hzz_, hzl_);
                Date izd_ = hzi_?.BirthDateElement;
                CqlDate ize_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izd_);
                CqlDate izg_ = context.Operators.Add(ize_, hzl_);
                CqlDate izi_ = context.Operators.Add(izg_, hzs_);
                CqlInterval<CqlDate> izj_ = context.Operators.Interval(izb_, izi_, true, false);
                CqlDate izk_ = izj_?.high;
                CqlDateTime izl_ = context.Operators.ConvertDateToDateTime(izk_);
                Date izn_ = hzi_?.BirthDateElement;
                CqlDate izo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izn_);
                CqlDate izq_ = context.Operators.Add(izo_, hzl_);
                Date izs_ = hzi_?.BirthDateElement;
                CqlDate izt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izs_);
                CqlDate izv_ = context.Operators.Add(izt_, hzl_);
                CqlDate izx_ = context.Operators.Add(izv_, hzs_);
                CqlInterval<CqlDate> izy_ = context.Operators.Interval(izq_, izx_, true, false);
                bool? izz_ = izy_?.lowClosed;
                Date jzb_ = hzi_?.BirthDateElement;
                CqlDate jzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzb_);
                CqlDate jze_ = context.Operators.Add(jzc_, hzl_);
                Date jzg_ = hzi_?.BirthDateElement;
                CqlDate jzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzg_);
                CqlDate jzj_ = context.Operators.Add(jzh_, hzl_);
                CqlDate jzl_ = context.Operators.Add(jzj_, hzs_);
                CqlInterval<CqlDate> jzm_ = context.Operators.Interval(jze_, jzl_, true, false);
                bool? jzn_ = jzm_?.highClosed;
                CqlInterval<CqlDateTime> jzo_ = context.Operators.Interval(hzw_, izl_, izz_, jzn_);

                return jzo_;
            }
            else if (choice is Range)
            {
                Patient jzp_ = this.Patient(context);
                Date jzq_ = jzp_?.BirthDateElement;
                CqlDate jzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzq_);
                Quantity jzs_ = (choice as Range)?.Low;
                CqlQuantity jzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzs_);
                CqlDate jzu_ = context.Operators.Add(jzr_, jzt_);
                Date jzw_ = jzp_?.BirthDateElement;
                CqlDate jzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzw_);
                Quantity jzy_ = (choice as Range)?.High;
                CqlQuantity jzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzy_);
                CqlDate kza_ = context.Operators.Add(jzx_, jzz_);
                CqlQuantity kzb_ = context.Operators.Quantity(1m, "year");
                CqlDate kzc_ = context.Operators.Add(kza_, kzb_);
                CqlInterval<CqlDate> kzd_ = context.Operators.Interval(jzu_, kzc_, true, false);
                CqlDate kze_ = kzd_?.low;
                CqlDateTime kzf_ = context.Operators.ConvertDateToDateTime(kze_);
                Date kzh_ = jzp_?.BirthDateElement;
                CqlDate kzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzh_);
                CqlQuantity kzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzs_);
                CqlDate kzl_ = context.Operators.Add(kzi_, kzk_);
                Date kzn_ = jzp_?.BirthDateElement;
                CqlDate kzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzn_);
                CqlQuantity kzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzy_);
                CqlDate kzr_ = context.Operators.Add(kzo_, kzq_);
                CqlDate kzt_ = context.Operators.Add(kzr_, kzb_);
                CqlInterval<CqlDate> kzu_ = context.Operators.Interval(kzl_, kzt_, true, false);
                CqlDate kzv_ = kzu_?.high;
                CqlDateTime kzw_ = context.Operators.ConvertDateToDateTime(kzv_);
                Date kzy_ = jzp_?.BirthDateElement;
                CqlDate kzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzy_);
                CqlQuantity lzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzs_);
                CqlDate lzc_ = context.Operators.Add(kzz_, lzb_);
                Date lze_ = jzp_?.BirthDateElement;
                CqlDate lzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lze_);
                CqlQuantity lzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzy_);
                CqlDate lzi_ = context.Operators.Add(lzf_, lzh_);
                CqlDate lzk_ = context.Operators.Add(lzi_, kzb_);
                CqlInterval<CqlDate> lzl_ = context.Operators.Interval(lzc_, lzk_, true, false);
                bool? lzm_ = lzl_?.lowClosed;
                Date lzo_ = jzp_?.BirthDateElement;
                CqlDate lzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzo_);
                CqlQuantity lzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzs_);
                CqlDate lzs_ = context.Operators.Add(lzp_, lzr_);
                Date lzu_ = jzp_?.BirthDateElement;
                CqlDate lzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzu_);
                CqlQuantity lzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzy_);
                CqlDate lzy_ = context.Operators.Add(lzv_, lzx_);
                CqlDate mza_ = context.Operators.Add(lzy_, kzb_);
                CqlInterval<CqlDate> mzb_ = context.Operators.Interval(lzs_, mza_, true, false);
                bool? mzc_ = mzb_?.highClosed;
                CqlInterval<CqlDateTime> mzd_ = context.Operators.Interval(kzf_, kzw_, lzm_, mzc_);

                return mzd_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> mze_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return mze_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> mzf_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return mzf_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return hza_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> mzg_()
        {
            bool mzh_()
            {
                DataType mzn_ = condition?.Abatement;
                bool mzo_ = mzn_ is FhirDateTime;

                return mzo_;
            };
            bool mzi_()
            {
                DataType mzp_ = condition?.Abatement;
                bool mzq_ = mzp_ is Period;

                return mzq_;
            };
            bool mzj_()
            {
                DataType mzr_ = condition?.Abatement;
                bool mzs_ = mzr_ is FhirString;

                return mzs_;
            };
            bool mzk_()
            {
                DataType mzt_ = condition?.Abatement;
                bool mzu_ = mzt_ is Age;

                return mzu_;
            };
            bool mzl_()
            {
                DataType mzv_ = condition?.Abatement;
                bool mzw_ = mzv_ is Range;

                return mzw_;
            };
            bool mzm_()
            {
                DataType mzx_ = condition?.Abatement;
                bool mzy_ = mzx_ is FhirBoolean;

                return mzy_;
            };
            if (mzh_())
            {
                DataType mzz_ = condition?.Abatement;
                CqlDateTime nza_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzz_ as FhirDateTime);
                CqlDateTime nzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzz_ as FhirDateTime);
                CqlInterval<CqlDateTime> nzd_ = context.Operators.Interval(nza_, nzc_, true, true);

                return nzd_;
            }
            else if (mzi_())
            {
                DataType nze_ = condition?.Abatement;
                CqlInterval<CqlDateTime> nzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nze_ as Period);

                return nzf_;
            }
            else if (mzj_())
            {
                CqlInterval<CqlDateTime> nzg_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return nzg_;
            }
            else if (mzk_())
            {
                Patient nzh_ = this.Patient(context);
                Date nzi_ = nzh_?.BirthDateElement;
                CqlDate nzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzi_);
                DataType nzk_ = condition?.Abatement;
                CqlQuantity nzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate nzm_ = context.Operators.Add(nzj_, nzl_);
                Date nzo_ = nzh_?.BirthDateElement;
                CqlDate nzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzo_);
                CqlQuantity nzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate nzs_ = context.Operators.Add(nzp_, nzr_);
                CqlQuantity nzt_ = context.Operators.Quantity(1m, "year");
                CqlDate nzu_ = context.Operators.Add(nzs_, nzt_);
                CqlInterval<CqlDate> nzv_ = context.Operators.Interval(nzm_, nzu_, true, false);
                CqlDate nzw_ = nzv_?.low;
                CqlDateTime nzx_ = context.Operators.ConvertDateToDateTime(nzw_);
                Date nzz_ = nzh_?.BirthDateElement;
                CqlDate oza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzz_);
                CqlQuantity ozc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate ozd_ = context.Operators.Add(oza_, ozc_);
                Date ozf_ = nzh_?.BirthDateElement;
                CqlDate ozg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozf_);
                CqlQuantity ozi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate ozj_ = context.Operators.Add(ozg_, ozi_);
                CqlDate ozl_ = context.Operators.Add(ozj_, nzt_);
                CqlInterval<CqlDate> ozm_ = context.Operators.Interval(ozd_, ozl_, true, false);
                CqlDate ozn_ = ozm_?.high;
                CqlDateTime ozo_ = context.Operators.ConvertDateToDateTime(ozn_);
                Date ozq_ = nzh_?.BirthDateElement;
                CqlDate ozr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozq_);
                CqlQuantity ozt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate ozu_ = context.Operators.Add(ozr_, ozt_);
                Date ozw_ = nzh_?.BirthDateElement;
                CqlDate ozx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozw_);
                CqlQuantity ozz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate pza_ = context.Operators.Add(ozx_, ozz_);
                CqlDate pzc_ = context.Operators.Add(pza_, nzt_);
                CqlInterval<CqlDate> pzd_ = context.Operators.Interval(ozu_, pzc_, true, false);
                bool? pze_ = pzd_?.lowClosed;
                Date pzg_ = nzh_?.BirthDateElement;
                CqlDate pzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzg_);
                CqlQuantity pzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate pzk_ = context.Operators.Add(pzh_, pzj_);
                Date pzm_ = nzh_?.BirthDateElement;
                CqlDate pzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzm_);
                CqlQuantity pzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzk_ as Age);
                CqlDate pzq_ = context.Operators.Add(pzn_, pzp_);
                CqlDate pzs_ = context.Operators.Add(pzq_, nzt_);
                CqlInterval<CqlDate> pzt_ = context.Operators.Interval(pzk_, pzs_, true, false);
                bool? pzu_ = pzt_?.highClosed;
                CqlInterval<CqlDateTime> pzv_ = context.Operators.Interval(nzx_, ozo_, pze_, pzu_);

                return pzv_;
            }
            else if (mzl_())
            {
                Patient pzw_ = this.Patient(context);
                Date pzx_ = pzw_?.BirthDateElement;
                CqlDate pzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzx_);
                DataType pzz_ = condition?.Abatement;
                Quantity qza_ = (pzz_ as Range)?.Low;
                CqlQuantity qzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qza_);
                CqlDate qzc_ = context.Operators.Add(pzy_, qzb_);
                Date qze_ = pzw_?.BirthDateElement;
                CqlDate qzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qze_);
                Quantity qzh_ = (pzz_ as Range)?.High;
                CqlQuantity qzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzh_);
                CqlDate qzj_ = context.Operators.Add(qzf_, qzi_);
                CqlQuantity qzk_ = context.Operators.Quantity(1m, "year");
                CqlDate qzl_ = context.Operators.Add(qzj_, qzk_);
                CqlInterval<CqlDate> qzm_ = context.Operators.Interval(qzc_, qzl_, true, false);
                CqlDate qzn_ = qzm_?.low;
                CqlDateTime qzo_ = context.Operators.ConvertDateToDateTime(qzn_);
                Date qzq_ = pzw_?.BirthDateElement;
                CqlDate qzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzq_);
                Quantity qzt_ = (pzz_ as Range)?.Low;
                CqlQuantity qzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzt_);
                CqlDate qzv_ = context.Operators.Add(qzr_, qzu_);
                Date qzx_ = pzw_?.BirthDateElement;
                CqlDate qzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzx_);
                Quantity rza_ = (pzz_ as Range)?.High;
                CqlQuantity rzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rza_);
                CqlDate rzc_ = context.Operators.Add(qzy_, rzb_);
                CqlDate rze_ = context.Operators.Add(rzc_, qzk_);
                CqlInterval<CqlDate> rzf_ = context.Operators.Interval(qzv_, rze_, true, false);
                CqlDate rzg_ = rzf_?.high;
                CqlDateTime rzh_ = context.Operators.ConvertDateToDateTime(rzg_);
                Date rzj_ = pzw_?.BirthDateElement;
                CqlDate rzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzj_);
                Quantity rzm_ = (pzz_ as Range)?.Low;
                CqlQuantity rzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzm_);
                CqlDate rzo_ = context.Operators.Add(rzk_, rzn_);
                Date rzq_ = pzw_?.BirthDateElement;
                CqlDate rzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzq_);
                Quantity rzt_ = (pzz_ as Range)?.High;
                CqlQuantity rzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzt_);
                CqlDate rzv_ = context.Operators.Add(rzr_, rzu_);
                CqlDate rzx_ = context.Operators.Add(rzv_, qzk_);
                CqlInterval<CqlDate> rzy_ = context.Operators.Interval(rzo_, rzx_, true, false);
                bool? rzz_ = rzy_?.lowClosed;
                Date szb_ = pzw_?.BirthDateElement;
                CqlDate szc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szb_);
                Quantity sze_ = (pzz_ as Range)?.Low;
                CqlQuantity szf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, sze_);
                CqlDate szg_ = context.Operators.Add(szc_, szf_);
                Date szi_ = pzw_?.BirthDateElement;
                CqlDate szj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szi_);
                Quantity szl_ = (pzz_ as Range)?.High;
                CqlQuantity szm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szl_);
                CqlDate szn_ = context.Operators.Add(szj_, szm_);
                CqlDate szp_ = context.Operators.Add(szn_, qzk_);
                CqlInterval<CqlDate> szq_ = context.Operators.Interval(szg_, szp_, true, false);
                bool? szr_ = szq_?.highClosed;
                CqlInterval<CqlDateTime> szs_ = context.Operators.Interval(qzo_, rzh_, rzz_, szr_);

                return szs_;
            }
            else if (mzm_())
            {
                DataType szt_ = condition?.Onset;
                CqlInterval<CqlDateTime> szu_ = this.Normalize_Interval(context, szt_);
                CqlDateTime szv_ = context.Operators.End(szu_);
                FhirDateTime szw_ = condition?.RecordedDateElement;
                CqlDateTime szx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, szw_);
                CqlInterval<CqlDateTime> szy_ = context.Operators.Interval(szv_, szx_, true, false);

                return szy_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return mzg_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> szz_()
        {
            bool tza_()
            {
                CodeableConcept tzb_ = condition?.ClinicalStatus;
                CqlConcept tzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzb_);
                CqlCode tzd_ = this.active(context);
                CqlConcept tze_ = context.Operators.ConvertCodeToConcept(tzd_);
                bool? tzf_ = context.Operators.Equivalent(tzc_, tze_);
                CqlConcept tzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzb_);
                CqlCode tzi_ = this.recurrence(context);
                CqlConcept tzj_ = context.Operators.ConvertCodeToConcept(tzi_);
                bool? tzk_ = context.Operators.Equivalent(tzh_, tzj_);
                bool? tzl_ = context.Operators.Or(tzf_, tzk_);
                CqlConcept tzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzb_);
                CqlCode tzo_ = this.relapse(context);
                CqlConcept tzp_ = context.Operators.ConvertCodeToConcept(tzo_);
                bool? tzq_ = context.Operators.Equivalent(tzn_, tzp_);
                bool? tzr_ = context.Operators.Or(tzl_, tzq_);

                return tzr_ ?? false;
            };
            if (tza_())
            {
                DataType tzs_ = condition?.Onset;
                CqlInterval<CqlDateTime> tzt_ = this.Normalize_Interval(context, tzs_);
                CqlDateTime tzu_ = context.Operators.Start(tzt_);
                CqlInterval<CqlDateTime> tzv_ = this.Normalize_Abatement(context, condition);
                CqlDateTime tzw_ = context.Operators.End(tzv_);
                CqlInterval<CqlDateTime> tzx_ = context.Operators.Interval(tzu_, tzw_, true, true);

                return tzx_;
            }
            else
            {
                DataType tzy_ = condition?.Onset;
                CqlInterval<CqlDateTime> tzz_ = this.Normalize_Interval(context, tzy_);
                CqlDateTime uza_ = context.Operators.Start(tzz_);
                CqlInterval<CqlDateTime> uzb_ = this.Normalize_Abatement(context, condition);
                CqlDateTime uzc_ = context.Operators.End(uzb_);
                CqlInterval<CqlDateTime> uzd_ = context.Operators.Interval(uza_, uzc_, true, false);

                return uzd_;
            }
        };

        return szz_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> uze_ = context.Operators.Split(uri, "/");
        string uzf_ = context.Operators.Last<string>(uze_);

        return uzf_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> uzg_ = Encounter?.Diagnosis;
        Condition uzh_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> uzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? uzl_(Condition C)
            {
                Id uzo_ = C?.IdElement;
                string uzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzo_);
                ResourceReference uzq_ = D?.Condition;
                FhirString uzr_ = uzq_?.ReferenceElement;
                string uzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzr_);
                string uzt_ = this.GetId(context, uzs_);
                bool? uzu_ = context.Operators.Equal(uzp_, uzt_);

                return uzu_;
            };
            IEnumerable<Condition> uzm_ = context.Operators.Where<Condition>(uzk_, uzl_);
            Condition uzn_ = context.Operators.SingletonFrom<Condition>(uzm_);

            return uzn_;
        };
        IEnumerable<Condition> uzi_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)uzg_, uzh_);
        IEnumerable<Condition> uzj_ = context.Operators.Distinct<Condition>(uzi_);

        return uzj_;
    }


    [CqlExpressionDefinition("GetCondition")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> uzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? uzw_(Condition C)
        {
            Id uzz_ = C?.IdElement;
            string vza_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzz_);
            FhirString vzb_ = reference?.ReferenceElement;
            string vzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzb_);
            string vzd_ = this.GetId(context, vzc_);
            bool? vze_ = context.Operators.Equal(vza_, vzd_);

            return vze_;
        };
        IEnumerable<Condition> uzx_ = context.Operators.Where<Condition>(uzv_, uzw_);
        Condition uzy_ = context.Operators.SingletonFrom<Condition>(uzx_);

        return uzy_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> vzf_ = domainResource?.Extension;
        bool? vzg_(Extension E)
        {
            string vzl_ = E?.Url;
            FhirUri vzm_ = context.Operators.Convert<FhirUri>(vzl_);
            string vzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzm_);
            string vzo_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? vzp_ = context.Operators.Equal(vzn_, vzo_);

            return vzp_;
        };
        IEnumerable<Extension> vzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)vzf_, vzg_);
        Extension vzi_(Extension E) =>
            E;
        IEnumerable<Extension> vzj_ = context.Operators.Select<Extension, Extension>(vzh_, vzi_);
        IEnumerable<Extension> vzk_ = context.Operators.Distinct<Extension>(vzj_);

        return vzk_;
    }


    [CqlExpressionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> vzq_ = element?.Extension;
        bool? vzr_(Extension E)
        {
            string vzw_ = E?.Url;
            FhirUri vzx_ = context.Operators.Convert<FhirUri>(vzw_);
            string vzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzx_);
            bool? vzz_ = context.Operators.Equal(vzy_, url);

            return vzz_;
        };
        IEnumerable<Extension> vzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)vzq_, vzr_);
        Extension vzt_(Extension E) =>
            E;
        IEnumerable<Extension> vzu_ = context.Operators.Select<Extension, Extension>(vzs_, vzt_);
        IEnumerable<Extension> vzv_ = context.Operators.Distinct<Extension>(vzu_);

        return vzv_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> wza_ = this.GetExtensions(context, domainResource, url);
        Extension wzb_ = context.Operators.SingletonFrom<Extension>(wza_);

        return wzb_;
    }


    [CqlExpressionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> wzc_ = this.GetExtensions(context, element, url);
        Extension wzd_ = context.Operators.SingletonFrom<Extension>(wzc_);

        return wzd_;
    }


    [CqlExpressionDefinition("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension wze_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType wzf_ = wze_?.Value;

        return wzf_ as CodeableConcept;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> wzg_ = Encounter?.Diagnosis;
        bool? wzh_(Encounter.DiagnosisComponent D)
        {
            PositiveInt wzp_ = D?.RankElement;
            Integer wzq_ = context.Operators.Convert<Integer>(wzp_);
            int? wzr_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, wzq_);
            bool? wzs_ = context.Operators.Equal(wzr_, 1);

            return wzs_;
        };
        IEnumerable<Encounter.DiagnosisComponent> wzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzg_, wzh_);
        Encounter.DiagnosisComponent wzj_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(wzi_);
        Encounter.DiagnosisComponent[] wzk_ = [
            wzj_,
        ];
        Condition wzl_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> wzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? wzu_(Condition C)
            {
                Id wzx_ = C?.IdElement;
                string wzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzx_);
                ResourceReference wzz_ = PD?.Condition;
                FhirString xza_ = wzz_?.ReferenceElement;
                string xzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, xza_);
                string xzc_ = this.GetId(context, xzb_);
                bool? xzd_ = context.Operators.Equal(wzy_, xzc_);

                return xzd_;
            };
            IEnumerable<Condition> wzv_ = context.Operators.Where<Condition>(wzt_, wzu_);
            Condition wzw_ = context.Operators.SingletonFrom<Condition>(wzv_);

            return wzw_;
        };
        IEnumerable<Condition> wzm_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)wzk_, wzl_);
        IEnumerable<Condition> wzn_ = context.Operators.Distinct<Condition>(wzm_);
        Condition wzo_ = context.Operators.SingletonFrom<Condition>(wzn_);

        return wzo_;
    }


    [CqlExpressionDefinition("GetLocation")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> xze_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
        bool? xzf_(Location L)
        {
            Id xzi_ = L?.IdElement;
            string xzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzi_);
            FhirString xzk_ = reference?.ReferenceElement;
            string xzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzk_);
            string xzm_ = this.GetId(context, xzl_);
            bool? xzn_ = context.Operators.Equal(xzj_, xzm_);

            return xzn_;
        };
        IEnumerable<Location> xzg_ = context.Operators.Where<Location>(xze_, xzf_);
        Location xzh_ = context.Operators.SingletonFrom<Location>(xzg_);

        return xzh_;
    }


    [CqlExpressionDefinition("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> xzo_ = domainResource?.Extension;
        bool? xzp_(Extension E)
        {
            string xzu_ = E?.Url;
            FhirUri xzv_ = context.Operators.Convert<FhirUri>(xzu_);
            string xzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzv_);
            string xzx_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? xzy_ = context.Operators.Equal(xzw_, xzx_);

            return xzy_;
        };
        IEnumerable<Extension> xzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)xzo_, xzp_);
        Extension xzr_(Extension E) =>
            E;
        IEnumerable<Extension> xzs_ = context.Operators.Select<Extension, Extension>(xzq_, xzr_);
        IEnumerable<Extension> xzt_ = context.Operators.Distinct<Extension>(xzs_);

        return xzt_;
    }


    [CqlExpressionDefinition("GetBaseExtension")]
    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> xzz_ = this.GetBaseExtensions(context, domainResource, url);
        Extension yza_ = context.Operators.SingletonFrom<Extension>(xzz_);

        return yza_;
    }


    [CqlExpressionDefinition("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access\ncontent that is defined by extensions but not yet surfaced in the CQL model info.")]
    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> yzb_ = element?.Extension;
        bool? yzc_(Extension E)
        {
            string yzh_ = E?.Url;
            FhirUri yzi_ = context.Operators.Convert<FhirUri>(yzh_);
            string yzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzi_);
            string yzk_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? yzl_ = context.Operators.Equal(yzj_, yzk_);

            return yzl_;
        };
        IEnumerable<Extension> yzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)yzb_, yzc_);
        Extension yze_(Extension E) =>
            E;
        IEnumerable<Extension> yzf_ = context.Operators.Select<Extension, Extension>(yzd_, yze_);
        IEnumerable<Extension> yzg_ = context.Operators.Distinct<Extension>(yzf_);

        return yzg_;
    }


    [CqlExpressionDefinition("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there\nis more than one extension on the given resource with the specified url.")]
    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> yzm_ = this.BaseExtensions(context, element, id);
        Extension yzn_ = context.Operators.SingletonFrom<Extension>(yzm_);

        return yzn_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CodeableConcept yzo_()
        {
            bool yzp_()
            {
                DataType yzq_ = request?.Medication;
                bool yzr_ = yzq_ is CodeableConcept;

                return yzr_;
            };
            if (yzp_())
            {
                DataType yzs_ = request?.Medication;

                return yzs_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> yzt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                bool? yzu_(Medication M)
                {
                    Id yzy_ = M?.IdElement;
                    string yzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzy_);
                    DataType zza_ = request?.Medication;
                    FhirString zzb_ = (zza_ as ResourceReference)?.ReferenceElement;
                    string zzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzb_);
                    string zzd_ = this.GetId(context, zzc_);
                    bool? zze_ = context.Operators.Equal(yzz_, zzd_);

                    return zze_;
                };
                IEnumerable<Medication> yzv_ = context.Operators.Where<Medication>(yzt_, yzu_);
                Medication yzw_ = context.Operators.SingletonFrom<Medication>(yzv_);
                CodeableConcept yzx_ = yzw_?.Code;

                return yzx_;
            }
        };

        return yzo_();
    }


    [CqlExpressionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime zzf_ = context.Operators.Start(period);
        CqlDateTime zzh_ = context.Operators.MinValue<CqlDateTime>();
        bool? zzi_ = context.Operators.Equal(zzf_, zzh_);
        bool? zzj_ = context.Operators.Or((bool?)(zzf_ is null), zzi_);
        bool? zzk_ = context.Operators.Not(zzj_);

        return zzk_;
    }


    [CqlExpressionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime zzl_ = context.Operators.End(period);
        CqlDateTime zzn_ = context.Operators.MaxValue<CqlDateTime>();
        bool? zzo_ = context.Operators.Equal(zzl_, zzn_);
        bool? zzp_ = context.Operators.Or((bool?)(zzl_ is null), zzo_);
        bool? zzq_ = context.Operators.Not(zzp_);

        return zzq_;
    }


    [CqlExpressionDefinition("Latest")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> zzr_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] zzs_ = [
            zzr_,
        ];
        CqlDateTime zzt_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime zzx_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime zzy_ = context.Operators.End(period);

                    return zzy_;
                }
                else
                {
                    CqlDateTime zzz_ = context.Operators.Start(period);

                    return zzz_;
                }
            };

            return zzx_();
        };
        IEnumerable<CqlDateTime> zzu_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)zzs_, zzt_);
        IEnumerable<CqlDateTime> zzv_ = context.Operators.Distinct<CqlDateTime>(zzu_);
        CqlDateTime zzw_ = context.Operators.SingletonFrom<CqlDateTime>(zzv_);

        return zzw_;
    }


    [CqlExpressionDefinition("Earliest")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> azza_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] azzb_ = [
            azza_,
        ];
        CqlDateTime azzc_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime azzg_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime azzh_ = context.Operators.Start(period);

                    return azzh_;
                }
                else
                {
                    CqlDateTime azzi_ = context.Operators.End(period);

                    return azzi_;
                }
            };

            return azzg_();
        };
        IEnumerable<CqlDateTime> azzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)azzb_, azzc_);
        IEnumerable<CqlDateTime> azze_ = context.Operators.Distinct<CqlDateTime>(azzd_);
        CqlDateTime azzf_ = context.Operators.SingletonFrom<CqlDateTime>(azze_);

        return azzf_;
    }


    #endregion Expressions

}
