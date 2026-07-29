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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.7.0")]
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
            if (X is null)
            {
                Period g_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, g_);
                return h_;
            }
            else
            {
                Period i_ = X?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, true);
                return o_;
            }
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
            if (EDEncounter is null)
            {
                List<Encounter.LocationComponent> g_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)g_;
            }
            else
            {
                List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] j_ = [
                    (IEnumerable<Encounter.LocationComponent>)h_,
                    (IEnumerable<Encounter.LocationComponent>)i_,
                ];
                IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)j_);
                return k_;
            }
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
        if (choice is FhirDateTime)
        {
            CqlDateTime a_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
            CqlInterval<CqlDateTime> b_ = context.Operators.Interval(a_, a_, true, true);
            return b_;
        }
        else if (choice is Period)
        {
            CqlInterval<CqlDateTime> c_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);
            return c_;
        }
        else if (choice is Instant)
        {
            CqlDateTime d_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
            CqlInterval<CqlDateTime> e_ = context.Operators.Interval(d_, d_, true, true);
            return e_;
        }
        else if (choice is Age)
        {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            CqlDate h_ = FHIRHelpers_4_0_001.Instance.ToDate(context, g_);
            CqlQuantity i_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
            CqlDate j_ = context.Operators.Add(h_, i_);
            CqlDateTime k_ = context.Operators.ConvertDateToDateTime(j_);
            CqlQuantity l_ = context.Operators.Quantity(1m, "year");
            CqlDate m_ = context.Operators.Add(j_, l_);
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, false);
            return o_;
        }
        else if (choice is Range)
        {
            Patient p_ = this.Patient(context);
            Date q_ = p_?.BirthDateElement;
            CqlDate r_ = FHIRHelpers_4_0_001.Instance.ToDate(context, q_);
            Quantity s_ = (choice as Range)?.Low;
            CqlQuantity t_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, s_);
            CqlDate u_ = context.Operators.Add(r_, t_);
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
            Quantity w_ = (choice as Range)?.High;
            CqlQuantity x_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, w_);
            CqlDate y_ = context.Operators.Add(r_, x_);
            CqlQuantity z_ = context.Operators.Quantity(1m, "year");
            CqlDate aa_ = context.Operators.Add(y_, z_);
            CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(v_, ab_, true, false);
            return ac_;
        }
        else if (choice is Timing)
        {
            CqlInterval<CqlDateTime> ad_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return ad_;
        }
        else if (choice is FhirString)
        {
            CqlInterval<CqlDateTime> ae_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return ae_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        DataType a_ = condition?.Abatement;
        bool b_ = a_ is FhirDateTime;
        if (b_)
        {
            DataType c_ = condition?.Abatement;
            CqlDateTime d_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, c_ as FhirDateTime);
            CqlInterval<CqlDateTime> e_ = context.Operators.Interval(d_, d_, true, true);
            return e_;
        }
        else
        {
            DataType f_ = condition?.Abatement;
            bool g_ = f_ is Period;
            if (g_)
            {
                DataType h_ = condition?.Abatement;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_ as Period);
                return i_;
            }
            else
            {
                DataType j_ = condition?.Abatement;
                bool k_ = j_ is FhirString;
                if (k_)
                {
                    CqlInterval<CqlDateTime> l_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                    return l_;
                }
                else
                {
                    DataType m_ = condition?.Abatement;
                    bool n_ = m_ is Age;
                    if (n_)
                    {
                        Patient o_ = this.Patient(context);
                        Date p_ = o_?.BirthDateElement;
                        CqlDate q_ = FHIRHelpers_4_0_001.Instance.ToDate(context, p_);
                        DataType r_ = condition?.Abatement;
                        CqlQuantity s_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, r_ as Age);
                        CqlDate t_ = context.Operators.Add(q_, s_);
                        CqlDateTime u_ = context.Operators.ConvertDateToDateTime(t_);
                        CqlQuantity v_ = context.Operators.Quantity(1m, "year");
                        CqlDate w_ = context.Operators.Add(t_, v_);
                        CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
                        CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, true, false);
                        return y_;
                    }
                    else
                    {
                        DataType z_ = condition?.Abatement;
                        bool aa_ = z_ is Range;
                        if (aa_)
                        {
                            Patient ab_ = this.Patient(context);
                            Date ac_ = ab_?.BirthDateElement;
                            CqlDate ad_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ac_);
                            DataType ae_ = condition?.Abatement;
                            Quantity af_ = (ae_ as Range)?.Low;
                            CqlQuantity ag_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, af_);
                            CqlDate ah_ = context.Operators.Add(ad_, ag_);
                            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
                            Quantity aj_ = (ae_ as Range)?.High;
                            CqlQuantity ak_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aj_);
                            CqlDate al_ = context.Operators.Add(ad_, ak_);
                            CqlQuantity am_ = context.Operators.Quantity(1m, "year");
                            CqlDate an_ = context.Operators.Add(al_, am_);
                            CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ai_, ao_, true, false);
                            return ap_;
                        }
                        else
                        {
                            DataType aq_ = condition?.Abatement;
                            bool ar_ = aq_ is FhirBoolean;
                            if (ar_)
                            {
                                DataType as_ = condition?.Onset;
                                CqlInterval<CqlDateTime> at_ = this.Normalize_Interval(context, as_);
                                CqlDateTime au_ = context.Operators.End(at_);
                                FhirDateTime av_ = condition?.RecordedDateElement;
                                CqlDateTime aw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, av_);
                                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(au_, aw_, true, false);
                                return ax_;
                            }
                            else
                            {
                                return null as CqlInterval<CqlDateTime>;
                            }
                        }
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.ClinicalStatus;
        CqlConcept b_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, a_);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = this.recurrence(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(b_, g_);
        bool? i_ = context.Operators.Or(e_, h_);
        CqlCode j_ = this.relapse(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        bool? l_ = context.Operators.Equivalent(b_, k_);
        bool? m_ = context.Operators.Or(i_, l_);
        if (m_ ?? false)
        {
            DataType n_ = condition?.Onset;
            CqlInterval<CqlDateTime> o_ = this.Normalize_Interval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlInterval<CqlDateTime> q_ = this.Normalize_Abatement(context, condition);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
            return s_;
        }
        else
        {
            DataType t_ = condition?.Onset;
            CqlInterval<CqlDateTime> u_ = this.Normalize_Interval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlInterval<CqlDateTime> w_ = this.Normalize_Abatement(context, condition);
            CqlDateTime x_ = context.Operators.End(w_);
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, false);
            return y_;
        }
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
        DataType a_ = request?.Medication;
        bool b_ = a_ is CodeableConcept;
        if (b_)
        {
            DataType c_ = request?.Medication;
            return c_ as CodeableConcept;
        }
        else
        {
            IEnumerable<Medication> d_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? e_(Medication M) {
                Id i_ = M?.IdElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                DataType k_ = request?.Medication;
                FhirString l_ = (k_ as ResourceReference)?.ReferenceElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                string n_ = this.GetId(context, m_);
                bool? o_ = context.Operators.Equal(j_, n_);
                return o_;
            }

            IEnumerable<Medication> f_ = context.Operators.Where<Medication>(d_, e_);
            Medication g_ = context.Operators.SingletonFrom<Medication>(f_);
            CodeableConcept h_ = g_?.Code;
            return h_;
        }
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
            if ((this.HasEnd(context, period)) ?? false)
            {
                CqlDateTime g_ = context.Operators.End(period);
                return g_;
            }
            else
            {
                CqlDateTime h_ = context.Operators.Start(period);
                return h_;
            }
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
            if ((this.HasStart(context, period)) ?? false)
            {
                CqlDateTime g_ = context.Operators.Start(period);
                return g_;
            }
            else
            {
                CqlDateTime h_ = context.Operators.End(period);
                return h_;
            }
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
