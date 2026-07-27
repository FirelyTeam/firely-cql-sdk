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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("MATGlobalCommonFunctionsFHIR4", "6.1.000")]
public partial class MATGlobalCommonFunctionsFHIR4_6_1_000 : ILibrary, ISingleton<MATGlobalCommonFunctionsFHIR4_6_1_000>
{
    #region ValueSets (4)

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

    #region Codes (25)

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

    #region CodeSystems (9)

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-clinical", codeSystemVersion: null)]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active,
          _inactive,
          _recurrence,
          _relapse,
          _remission,
          _resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, [
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, [
          _allergy_confirmed,
          _allergy_refuted,
          _allergy_unconfirmed]);

    [CqlCodeSystemDefinition("Diagnosis Role", codeSystemId: "http://terminology.hl7.org/CodeSystem/diagnosis-role", codeSystemVersion: null)]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, [
          _Billing]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birthdate]);

    [CqlCodeSystemDefinition("MedicationRequestCategory", codeSystemId: "http://terminology.hl7.org/CodeSystem/medicationrequest-category", codeSystemVersion: null)]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, [
          _Community,
          _Discharge]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _confirmed,
          _differential,
          _entered_in_error,
          _provisional,
          _refuted,
          _unconfirmed]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead]);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _ER,
          _ICU]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -5789223673792619521L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (33)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -988373218840019440L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter, Inpatient_Encounter_Compute);

    private const long _cacheIndex_Inpatient_Encounter = -1760786125302252719L;

    private IEnumerable<Encounter> Inpatient_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter EncounterInpatient) {
            Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "finished");
            Period h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            int? j_ = this.LengthInDays(context, i_);
            bool? k_ = context.Operators.LessOrEqual(j_, 120);
            bool? l_ = context.Operators.And(g_, k_);
            CqlDateTime m_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);
            bool? p_ = context.Operators.And(l_, o_);
            return p_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("ED Visit")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter EDVisit) {
            Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            Period k_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            Period n_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(r_, p_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(m_, s_, (string)default);
            bool? u_ = context.Operators.Not((bool?)(p_ is null));
            bool? v_ = context.Operators.And(t_, u_);
            bool? w_ = context.Operators.And(j_, v_);
            return w_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period x_ = @this?.Period;
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
            CqlDateTime z_ = context.Operators.End(y_);
            return z_;
        }

        IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter g_ = context.Operators.Last<Encounter>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];

        CqlInterval<CqlDateTime> c_(Encounter X) {

            CqlInterval<CqlDateTime> g_() {
                if (X is null)
                {
                    Period h_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
                    return i_;
                }
                else
                {
                    Period j_ = X?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, j_);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    Period m_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, true);
                    return p_;
                }
            }

            return g_();
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);
        CqlInterval<CqlDateTime> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];

        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter) {

            IEnumerable<Encounter.LocationComponent> g_() {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                    return (IEnumerable<Encounter.LocationComponent>)h_;
                }
                else
                {
                    List<Encounter.LocationComponent> i_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> j_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] k_ = [
                        (IEnumerable<Encounter.LocationComponent>)i_,
                        (IEnumerable<Encounter.LocationComponent>)j_,
                    ];
                    IEnumerable<Encounter.LocationComponent> l_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)k_);
                    return l_;
                }
            }

            return g_();
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> e_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Hospitalization Length of Stay")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Admission Time")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, a_);
        CqlDateTime c_ = context.Operators.End(b_);
        return c_;
    }


    [CqlFunctionDefinition("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);

        object b_(Encounter.LocationComponent @this) {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? h_(Encounter LastED) {
                Period ae_ = LastED?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.End(af_);
                CqlValueSet ah_ = this.Observation_Services(context);
                IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

                bool? aj_(Encounter LastObs) {
                    Period bq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bq_);
                    CqlDateTime bs_ = context.Operators.End(br_);
                    Period bt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    CqlQuantity bw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
                    CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bx_, bv_, true, true);
                    bool? bz_ = context.Operators.In<CqlDateTime>(bs_, by_, (string)default);
                    bool? ca_ = context.Operators.Not((bool?)(bv_ is null));
                    bool? cb_ = context.Operators.And(bz_, ca_);
                    return cb_;
                }

                IEnumerable<Encounter> ak_ = context.Operators.Where<Encounter>(ai_, aj_);

                object al_(Encounter @this) {
                    Period cc_ = @this?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.End(cd_);
                    return ce_;
                }

                IEnumerable<Encounter> am_ = context.Operators.SortBy<Encounter>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter an_ = context.Operators.Last<Encounter>(am_);
                Period ao_ = an_?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                Period ar_ = Visit?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlQuantity au_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime av_ = context.Operators.Subtract(aq_ ?? at_, au_);

                bool? aw_(Encounter LastObs) {
                    Period cf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime ch_ = context.Operators.End(cg_);
                    Period ci_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ci_);
                    CqlDateTime ck_ = context.Operators.Start(cj_);
                    CqlQuantity cl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cm_ = context.Operators.Subtract(ck_, cl_);
                    CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(cm_, ck_, true, true);
                    bool? co_ = context.Operators.In<CqlDateTime>(ch_, cn_, (string)default);
                    bool? cp_ = context.Operators.Not((bool?)(ck_ is null));
                    bool? cq_ = context.Operators.And(co_, cp_);
                    return cq_;
                }

                IEnumerable<Encounter> ax_ = context.Operators.Where<Encounter>(ai_, aw_);

                object ay_(Encounter @this) {
                    Period cr_ = @this?.Period;
                    CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cr_);
                    CqlDateTime ct_ = context.Operators.End(cs_);
                    return ct_;
                }

                IEnumerable<Encounter> az_ = context.Operators.SortBy<Encounter>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ba_ = context.Operators.Last<Encounter>(az_);
                Period bb_ = ba_?.Period;
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(av_, bd_ ?? at_, true, true);
                bool? bf_ = context.Operators.In<CqlDateTime>(ag_, be_, (string)default);

                bool? bg_(Encounter LastObs) {
                    Period cu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cu_);
                    CqlDateTime cw_ = context.Operators.End(cv_);
                    Period cx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cx_);
                    CqlDateTime cz_ = context.Operators.Start(cy_);
                    CqlQuantity da_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime db_ = context.Operators.Subtract(cz_, da_);
                    CqlInterval<CqlDateTime> dc_ = context.Operators.Interval(db_, cz_, true, true);
                    bool? dd_ = context.Operators.In<CqlDateTime>(cw_, dc_, (string)default);
                    bool? de_ = context.Operators.Not((bool?)(cz_ is null));
                    bool? df_ = context.Operators.And(dd_, de_);
                    return df_;
                }

                IEnumerable<Encounter> bh_ = context.Operators.Where<Encounter>(ai_, bg_);

                object bi_(Encounter @this) {
                    Period dg_ = @this?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.End(dh_);
                    return di_;
                }

                IEnumerable<Encounter> bj_ = context.Operators.SortBy<Encounter>(bh_, bi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bk_ = context.Operators.Last<Encounter>(bj_);
                Period bl_ = bk_?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                bool? bo_ = context.Operators.Not((bool?)((bn_ ?? at_) is null));
                bool? bp_ = context.Operators.And(bf_, bo_);
                return bp_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period dj_ = @this?.Period;
                CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dj_);
                CqlDateTime dl_ = context.Operators.End(dk_);
                return dl_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? r_(Encounter LastObs) {
                Period dm_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dm_);
                CqlDateTime do_ = context.Operators.End(dn_);
                Period dp_ = Visit?.Period;
                CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dp_);
                CqlDateTime dr_ = context.Operators.Start(dq_);
                CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dt_ = context.Operators.Subtract(dr_, ds_);
                CqlInterval<CqlDateTime> du_ = context.Operators.Interval(dt_, dr_, true, true);
                bool? dv_ = context.Operators.In<CqlDateTime>(do_, du_, (string)default);
                bool? dw_ = context.Operators.Not((bool?)(dr_ is null));
                bool? dx_ = context.Operators.And(dv_, dw_);
                return dx_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period dy_ = @this?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.End(dz_);
                return ea_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlDateTime ac_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ac_, true, true);
            return ad_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {

        CqlInterval<CqlDateTime> a_() {
            if (choice is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
                return c_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);
                return d_;
            }
            else if (choice is Instant)
            {
                CqlDateTime e_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> f_ = context.Operators.Interval(e_, e_, true, true);
                return f_;
            }
            else if (choice is Age)
            {
                Patient g_ = this.Patient(context);
                Date h_ = g_?.BirthDateElement;
                CqlDate i_ = FHIRHelpers_4_0_001.Instance.ToDate(context, h_);
                CqlQuantity j_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate k_ = context.Operators.Add(i_, j_);
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(k_, m_);
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, false);
                return p_;
            }
            else if (choice is Range)
            {
                Patient q_ = this.Patient(context);
                Date r_ = q_?.BirthDateElement;
                CqlDate s_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_);
                Quantity t_ = (choice as Range)?.Low;
                CqlQuantity u_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, t_);
                CqlDate v_ = context.Operators.Add(s_, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                Quantity x_ = (choice as Range)?.High;
                CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, x_);
                CqlDate z_ = context.Operators.Add(s_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
                CqlDate ab_ = context.Operators.Add(z_, aa_);
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(w_, ac_, true, false);
                return ad_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ae_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
                return ae_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> af_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return af_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                DataType h_ = condition?.Abatement;
                bool i_ = h_ is FhirDateTime;
                return i_;
            }


            bool c_() {
                DataType j_ = condition?.Abatement;
                bool k_ = j_ is Period;
                return k_;
            }


            bool d_() {
                DataType l_ = condition?.Abatement;
                bool m_ = l_ is FhirString;
                return m_;
            }


            bool e_() {
                DataType n_ = condition?.Abatement;
                bool o_ = n_ is Age;
                return o_;
            }


            bool f_() {
                DataType p_ = condition?.Abatement;
                bool q_ = p_ is Range;
                return q_;
            }


            bool g_() {
                DataType r_ = condition?.Abatement;
                bool s_ = r_ is FhirBoolean;
                return s_;
            }

            if (b_())
            {
                DataType t_ = condition?.Abatement;
                CqlDateTime u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_ as FhirDateTime);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(u_, u_, true, true);
                return v_;
            }
            else if (c_())
            {
                DataType w_ = condition?.Abatement;
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_ as Period);
                return x_;
            }
            else if (d_())
            {
                CqlInterval<CqlDateTime> y_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return y_;
            }
            else if (e_())
            {
                Patient z_ = this.Patient(context);
                Date aa_ = z_?.BirthDateElement;
                CqlDate ab_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aa_);
                DataType ac_ = condition?.Abatement;
                CqlQuantity ad_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ac_ as Age);
                CqlDate ae_ = context.Operators.Add(ab_, ad_);
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(1m, "year");
                CqlDate ah_ = context.Operators.Add(ae_, ag_);
                CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
                CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(af_, ai_, true, false);
                return aj_;
            }
            else if (f_())
            {
                Patient ak_ = this.Patient(context);
                Date al_ = ak_?.BirthDateElement;
                CqlDate am_ = FHIRHelpers_4_0_001.Instance.ToDate(context, al_);
                DataType an_ = condition?.Abatement;
                Quantity ao_ = (an_ as Range)?.Low;
                CqlQuantity ap_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ao_);
                CqlDate aq_ = context.Operators.Add(am_, ap_);
                CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
                Quantity as_ = (an_ as Range)?.High;
                CqlQuantity at_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, as_);
                CqlDate au_ = context.Operators.Add(am_, at_);
                CqlQuantity av_ = context.Operators.Quantity(1m, "year");
                CqlDate aw_ = context.Operators.Add(au_, av_);
                CqlDateTime ax_ = context.Operators.ConvertDateToDateTime(aw_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ar_, ax_, true, false);
                return ay_;
            }
            else if (g_())
            {
                DataType az_ = condition?.Onset;
                CqlInterval<CqlDateTime> ba_ = this.Normalize_Interval(context, az_);
                CqlDateTime bb_ = context.Operators.End(ba_);
                FhirDateTime bc_ = condition?.RecordedDateElement;
                CqlDateTime bd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bc_);
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(bb_, bd_, true, false);
                return be_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                CodeableConcept c_ = condition?.ClinicalStatus;
                CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlCode h_ = this.recurrence(context);
                CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
                bool? j_ = context.Operators.Equivalent(d_, i_);
                bool? k_ = context.Operators.Or(g_, j_);
                CqlCode l_ = this.relapse(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(d_, m_);
                bool? o_ = context.Operators.Or(k_, n_);
                return o_ ?? false;
            }

            if (b_())
            {
                DataType p_ = condition?.Onset;
                CqlInterval<CqlDateTime> q_ = this.Normalize_Interval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = this.Normalize_Abatement(context, condition);
                CqlDateTime t_ = context.Operators.End(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
                return u_;
            }
            else
            {
                DataType v_ = condition?.Onset;
                CqlInterval<CqlDateTime> w_ = this.Normalize_Interval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDateTime> y_ = this.Normalize_Abatement(context, condition);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, false);
                return aa_;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        Condition b_(Encounter.DiagnosisComponent D) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? f_(Condition C) {
                Id i_ = C?.IdElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                ResourceReference k_ = D?.Condition;
                FhirString l_ = k_?.ReferenceElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                string n_ = this.GetId(context, m_);
                bool? o_ = context.Operators.Equal(j_, n_);
                return o_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            Condition h_ = context.Operators.SingletonFrom<Condition>(g_);
            return h_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetCondition")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? b_(Condition C) {
            Id e_ = C?.IdElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            FhirString g_ = reference?.ReferenceElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = this.GetId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);
            return j_;
        }

        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
        Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
        return d_;
    }


    [CqlFunctionDefinition("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension a_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType b_ = a_?.Value;
        return b_ as CodeableConcept;
    }


    [CqlFunctionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);
        return b_;
    }


    [CqlFunctionDefinition("GetExtension")]
    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> a_ = this.GetExtensions(context, element, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);
        return b_;
    }


    [CqlFunctionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.Extension;

        bool? b_(Extension E) {
            FhirUri g_ = E?.UrlElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);
        return f_;
    }


    [CqlFunctionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> a_ = element?.Extension;

        bool? b_(Extension E) {
            FhirUri g_ = E?.UrlElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            bool? i_ = context.Operators.Equal(h_, url);
            return i_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);
        return f_;
    }


    [CqlFunctionDefinition("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        bool? b_(Encounter.DiagnosisComponent D) {
            PositiveInt j_ = D?.RankElement;
            Integer k_ = context.Operators.Convert<Integer>(j_);
            int? l_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, k_);
            bool? m_ = context.Operators.Equal(l_, 1);
            return m_;
        }

        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
        Encounter.DiagnosisComponent[] e_ = [
            d_,
        ];

        Condition f_(Encounter.DiagnosisComponent PD) {
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? o_(Condition C) {
                Id r_ = C?.IdElement;
                string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
                ResourceReference t_ = PD?.Condition;
                FhirString u_ = t_?.ReferenceElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                string w_ = this.GetId(context, v_);
                bool? x_ = context.Operators.Equal(s_, w_);
                return x_;
            }

            IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
            Condition q_ = context.Operators.SingletonFrom<Condition>(p_);
            return q_;
        }

        IEnumerable<Condition> g_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
        IEnumerable<Condition> h_ = context.Operators.Distinct<Condition>(g_);
        Condition i_ = context.Operators.SingletonFrom<Condition>(h_);
        return i_;
    }


    [CqlFunctionDefinition("GetLocation")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

        bool? b_(Location L) {
            Id e_ = L?.IdElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            FhirString g_ = reference?.ReferenceElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = this.GetId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);
            return j_;
        }

        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.Extension;

        bool? b_(Extension E) {
            FhirUri g_ = E?.UrlElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);
        return f_;
    }


    [CqlFunctionDefinition("GetBaseExtension")]
    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetBaseExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);
        return b_;
    }


    [CqlFunctionDefinition("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access\ncontent that is defined by extensions but not yet surfaced in the CQL model info.")]
    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> a_ = element?.Extension;

        bool? b_(Extension E) {
            FhirUri g_ = E?.UrlElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);
        return f_;
    }


    [CqlFunctionDefinition("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there\nis more than one extension on the given resource with the specified url.")]
    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> a_ = this.BaseExtensions(context, element, id);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);
        return b_;
    }


    [CqlFunctionDefinition("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {

        CodeableConcept a_() {

            bool b_() {
                DataType c_ = request?.Medication;
                bool d_ = c_ is CodeableConcept;
                return d_;
            }

            if (b_())
            {
                DataType e_ = request?.Medication;
                return e_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? g_(Medication M) {
                    Id k_ = M?.IdElement;
                    string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                    DataType m_ = request?.Medication;
                    FhirString n_ = (m_ as ResourceReference)?.ReferenceElement;
                    string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                    string p_ = this.GetId(context, o_);
                    bool? q_ = context.Operators.Equal(l_, p_);
                    return q_;
                }

                IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
                Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
                CodeableConcept j_ = i_?.Code;
                return j_;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime b_ = context.Operators.MinValue<CqlDateTime>();
        bool? c_ = context.Operators.Equal(a_, b_);
        bool? d_ = context.Operators.Or((bool?)(a_ is null), c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
    }


    [CqlFunctionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime b_ = context.Operators.MaxValue<CqlDateTime>();
        bool? c_ = context.Operators.Equal(a_, b_);
        bool? d_ = context.Operators.Or((bool?)(a_ is null), c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
    }


    [CqlFunctionDefinition("Latest")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {

            CqlDateTime g_() {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.End(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.Start(period);
                    return i_;
                }
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Earliest")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {

            CqlDateTime g_() {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.Start(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.End(period);
                    return i_;
                }
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private MATGlobalCommonFunctionsFHIR4_6_1_000() {}

    public static MATGlobalCommonFunctionsFHIR4_6_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "MATGlobalCommonFunctionsFHIR4";
    public string Version => "6.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
