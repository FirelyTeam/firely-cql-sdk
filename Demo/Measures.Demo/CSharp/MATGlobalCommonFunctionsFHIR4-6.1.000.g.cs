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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.1.0")]
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

            CqlBoolean h_() {
                Period j_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, j_);
                int? l_ = this.LengthInDays(context, k_);
                bool? m_ = context.Operators.LessOrEqual(l_, 120);
                return m_;
            }


            CqlBoolean i_() {
                Period n_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                return r_;
            }

            return /* CQL 'and' (73:9-75:71) */ (/* CQL 'and' (73:15-74:64) */ ((CqlBoolean)g_
                && h_())
                && i_());
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

            CqlBoolean k_() {
                Period l_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                Period o_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);

                CqlBoolean v_() {
                    Period w_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    return !((bool?)(y_ is null));
                }

                return /* CQL 'and' (86:13-86:112) */ ((CqlBoolean)u_
                    && v_());
            }

            return /* CQL 'and' (85:7-86:112) */ ((CqlBoolean)j_
                && k_());
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period z_ = @this?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            return ab_;
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
                Period f_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, f_);
                return g_;
            }
            else
            {
                Period h_ = X?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> n_ = context.Operators.Interval(j_, m_, true, true);
                return n_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
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
                List<Encounter.LocationComponent> f_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)f_;
            }
            else
            {
                List<Encounter.LocationComponent> g_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] i_ = [
                    (IEnumerable<Encounter.LocationComponent>)g_,
                    (IEnumerable<Encounter.LocationComponent>)h_,
                ];
                IEnumerable<Encounter.LocationComponent> j_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)i_);
                return j_;
            }
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);
        return e_;
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
            CqlValueSet e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? g_(Encounter LastED) {
                Period ad_ = LastED?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlValueSet ag_ = this.Observation_Services(context);
                IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

                bool? ai_(Encounter LastObs) {
                    Period bg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.End(bh_);
                    Period bj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                    CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bn_, bl_, true, true);
                    bool? bp_ = context.Operators.In<CqlDateTime>(bi_, bo_, (string)default);

                    CqlBoolean bq_() {
                        Period br_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, br_);
                        CqlDateTime bt_ = context.Operators.Start(bs_);
                        return !((bool?)(bt_ is null));
                    }

                    return /* CQL 'and' (178:7-178:81) */ ((CqlBoolean)bp_
                        && bq_());
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period bu_ = @this?.Period;
                    CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.End(bv_);
                    return bw_;
                }

                IEnumerable<Encounter> al_ = context.Operators.SortBy<Encounter>(aj_, ak_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter am_ = context.Operators.Last<Encounter>(al_);
                Period an_ = am_?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                Period aq_ = Visit?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime au_ = context.Operators.Subtract(ap_ ?? as_, at_);

                bool? av_(Encounter LastObs) {
                    Period bx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.End(by_);
                    Period ca_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ca_);
                    CqlDateTime cc_ = context.Operators.Start(cb_);
                    CqlQuantity cd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ce_ = context.Operators.Subtract(cc_, cd_);
                    CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(ce_, cc_, true, true);
                    bool? cg_ = context.Operators.In<CqlDateTime>(bz_, cf_, (string)default);

                    CqlBoolean ch_() {
                        Period ci_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ci_);
                        CqlDateTime ck_ = context.Operators.Start(cj_);
                        return !((bool?)(ck_ is null));
                    }

                    return /* CQL 'and' (178:7-178:81) */ ((CqlBoolean)cg_
                        && ch_());
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period cl_ = @this?.Period;
                    CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cl_);
                    CqlDateTime cn_ = context.Operators.End(cm_);
                    return cn_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                bool? be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);

                CqlBoolean bf_() {
                    CqlValueSet co_ = this.Observation_Services(context);
                    IEnumerable<Encounter> cp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

                    bool? cq_(Encounter LastObs) {
                        Period db_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, db_);
                        CqlDateTime dd_ = context.Operators.End(dc_);
                        Period de_ = Visit?.Period;
                        CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, de_);
                        CqlDateTime dg_ = context.Operators.Start(df_);
                        CqlQuantity dh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime di_ = context.Operators.Subtract(dg_, dh_);
                        CqlInterval<CqlDateTime> dj_ = context.Operators.Interval(di_, dg_, true, true);
                        bool? dk_ = context.Operators.In<CqlDateTime>(dd_, dj_, (string)default);

                        CqlBoolean dl_() {
                            Period dm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dm_);
                            CqlDateTime do_ = context.Operators.Start(dn_);
                            return !((bool?)(do_ is null));
                        }

                        return /* CQL 'and' (178:7-178:81) */ ((CqlBoolean)dk_
                            && dl_());
                    }

                    IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                    object cs_(Encounter @this) {
                        Period dp_ = @this?.Period;
                        CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dp_);
                        CqlDateTime dr_ = context.Operators.End(dq_);
                        return dr_;
                    }

                    IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                    Period cv_ = cu_?.Period;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    Period cy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cy_);
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    return !((bool?)((cx_ ?? da_) is null));
                }

                return /* CQL 'and' (183:7-183:69) */ ((CqlBoolean)be_
                    && bf_());
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ds_ = @this?.Period;
                CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ds_);
                CqlDateTime du_ = context.Operators.End(dt_);
                return du_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? q_(Encounter LastObs) {
                Period dv_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                CqlDateTime dx_ = context.Operators.End(dw_);
                Period dy_ = Visit?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.Start(dz_);
                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                bool? ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                CqlBoolean ef_() {
                    Period eg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, eg_);
                    CqlDateTime ei_ = context.Operators.Start(eh_);
                    return !((bool?)(ei_ is null));
                }

                return /* CQL 'and' (178:7-178:81) */ ((CqlBoolean)ee_
                    && ef_());
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period ej_ = @this?.Period;
                CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ej_);
                CqlDateTime el_ = context.Operators.End(ek_);
                return el_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            Period y_ = Visit?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDateTime ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
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
            CqlDateTime c_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, a_ as FhirDateTime);
            CqlInterval<CqlDateTime> d_ = context.Operators.Interval(c_, c_, true, true);
            return d_;
        }
        else
        {
            bool e_ = a_ is Period;
            if (e_)
            {
                CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, a_ as Period);
                return f_;
            }
            else
            {
                bool g_ = a_ is FhirString;
                if (g_)
                {
                    CqlInterval<CqlDateTime> h_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                    return h_;
                }
                else
                {
                    bool i_ = a_ is Age;
                    if (i_)
                    {
                        Patient j_ = this.Patient(context);
                        Date k_ = j_?.BirthDateElement;
                        CqlDate l_ = FHIRHelpers_4_0_001.Instance.ToDate(context, k_);
                        CqlQuantity m_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, a_ as Age);
                        CqlDate n_ = context.Operators.Add(l_, m_);
                        CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                        CqlQuantity p_ = context.Operators.Quantity(1m, "year");
                        CqlDate q_ = context.Operators.Add(n_, p_);
                        CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                        CqlInterval<CqlDateTime> s_ = context.Operators.Interval(o_, r_, true, false);
                        return s_;
                    }
                    else
                    {
                        bool t_ = a_ is Range;
                        if (t_)
                        {
                            Patient u_ = this.Patient(context);
                            Date v_ = u_?.BirthDateElement;
                            CqlDate w_ = FHIRHelpers_4_0_001.Instance.ToDate(context, v_);
                            Quantity x_ = (a_ as Range)?.Low;
                            CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, x_);
                            CqlDate z_ = context.Operators.Add(w_, y_);
                            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                            Quantity ab_ = (a_ as Range)?.High;
                            CqlQuantity ac_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ab_);
                            CqlDate ad_ = context.Operators.Add(w_, ac_);
                            CqlQuantity ae_ = context.Operators.Quantity(1m, "year");
                            CqlDate af_ = context.Operators.Add(ad_, ae_);
                            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
                            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(aa_, ag_, true, false);
                            return ah_;
                        }
                        else
                        {
                            bool ai_ = a_ is FhirBoolean;
                            if (ai_)
                            {
                                DataType aj_ = condition?.Onset;
                                CqlInterval<CqlDateTime> ak_ = this.Normalize_Interval(context, aj_);
                                CqlDateTime al_ = context.Operators.End(ak_);
                                FhirDateTime am_ = condition?.RecordedDateElement;
                                CqlDateTime an_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, am_);
                                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(al_, an_, true, false);
                                return ao_;
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

        CqlBoolean f_() {
            CodeableConcept h_ = condition?.ClinicalStatus;
            CqlConcept i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, h_);
            CqlCode j_ = this.recurrence(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            return l_;
        }


        CqlBoolean g_() {
            CodeableConcept m_ = condition?.ClinicalStatus;
            CqlConcept n_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, m_);
            CqlCode o_ = this.relapse(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            return q_;
        }

        if (((bool?)(/* CQL 'or' (259:6-261:43) */ (/* CQL 'or' (259:6-260:46) */ ((CqlBoolean)e_
            || f_())
            || g_()))) ?? false)
        {
            DataType r_ = condition?.Onset;
            CqlInterval<CqlDateTime> s_ = this.Normalize_Interval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlInterval<CqlDateTime> u_ = this.Normalize_Abatement(context, condition);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
            return w_;
        }
        else
        {
            DataType x_ = condition?.Onset;
            CqlInterval<CqlDateTime> y_ = this.Normalize_Interval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlInterval<CqlDateTime> aa_ = this.Normalize_Abatement(context, condition);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, false);
            return ac_;
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
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? e_(Condition C) {
                Id h_ = C?.IdElement;
                string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
                ResourceReference j_ = D?.Condition;
                FhirString k_ = j_?.ReferenceElement;
                string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                string m_ = this.GetId(context, l_);
                bool? n_ = context.Operators.Equal(i_, m_);
                return n_;
            }

            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
            Condition g_ = context.Operators.SingletonFrom<Condition>(f_);
            return g_;
        }

        IEnumerable<Condition> c_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        return c_;
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
            FhirUri f_ = E?.UrlElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string h_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? i_ = context.Operators.Equal(g_, h_);
            return i_;
        }

        Extension c_(Extension E) => E;
        IEnumerable<Extension> d_ = context.Operators.WhereSelect<Extension, Extension>((IEnumerable<Extension>)a_, b_, c_);
        IEnumerable<Extension> e_ = context.Operators.Distinct<Extension>(d_);
        return e_;
    }


    [CqlFunctionDefinition("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> a_ = element?.Extension;

        bool? b_(Extension E) {
            FhirUri f_ = E?.UrlElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            bool? h_ = context.Operators.Equal(g_, url);
            return h_;
        }

        Extension c_(Extension E) => E;
        IEnumerable<Extension> d_ = context.Operators.WhereSelect<Extension, Extension>((IEnumerable<Extension>)a_, b_, c_);
        IEnumerable<Extension> e_ = context.Operators.Distinct<Extension>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        bool? b_(Encounter.DiagnosisComponent D) {
            PositiveInt i_ = D?.RankElement;
            Integer j_ = context.Operators.Convert<Integer>(i_);
            int? k_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, j_);
            bool? l_ = context.Operators.Equal(k_, 1);
            return l_;
        }

        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
        Encounter.DiagnosisComponent[] e_ = [
            d_,
        ];

        Condition f_(Encounter.DiagnosisComponent PD) {
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? n_(Condition C) {
                Id q_ = C?.IdElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                ResourceReference s_ = PD?.Condition;
                FhirString t_ = s_?.ReferenceElement;
                string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
                string v_ = this.GetId(context, u_);
                bool? w_ = context.Operators.Equal(r_, v_);
                return w_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            Condition p_ = context.Operators.SingletonFrom<Condition>(o_);
            return p_;
        }

        IEnumerable<Condition> g_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
        Condition h_ = context.Operators.SingletonFrom<Condition>(g_);
        return h_;
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
            FhirUri f_ = E?.UrlElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string h_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? i_ = context.Operators.Equal(g_, h_);
            return i_;
        }

        Extension c_(Extension E) => E;
        IEnumerable<Extension> d_ = context.Operators.WhereSelect<Extension, Extension>((IEnumerable<Extension>)a_, b_, c_);
        IEnumerable<Extension> e_ = context.Operators.Distinct<Extension>(d_);
        return e_;
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
            FhirUri f_ = E?.UrlElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string h_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? i_ = context.Operators.Equal(g_, h_);
            return i_;
        }

        Extension c_(Extension E) => E;
        IEnumerable<Extension> d_ = context.Operators.WhereSelect<Extension, Extension>((IEnumerable<Extension>)a_, b_, c_);
        IEnumerable<Extension> e_ = context.Operators.Distinct<Extension>(d_);
        return e_;
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
            return a_ as CodeableConcept;
        }
        else
        {
            IEnumerable<Medication> c_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? d_(Medication M) {
                Id h_ = M?.IdElement;
                string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
                DataType j_ = request?.Medication;
                FhirString k_ = (j_ as ResourceReference)?.ReferenceElement;
                string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                string m_ = this.GetId(context, l_);
                bool? n_ = context.Operators.Equal(i_, m_);
                return n_;
            }

            IEnumerable<Medication> e_ = context.Operators.Where<Medication>(c_, d_);
            Medication f_ = context.Operators.SingletonFrom<Medication>(e_);
            CodeableConcept g_ = f_?.Code;
            return g_;
        }
    }


    [CqlFunctionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);

        CqlBoolean b_() {
            CqlDateTime c_ = context.Operators.Start(period);
            CqlDateTime d_ = context.Operators.MinValue<CqlDateTime>();
            bool? e_ = context.Operators.Equal(c_, d_);
            return e_;
        }

        return !((bool?)(/* CQL 'or' (354:7-356:3) */ ((CqlBoolean)((bool?)(a_ is null))
            || b_())));
    }


    [CqlFunctionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);

        CqlBoolean b_() {
            CqlDateTime c_ = context.Operators.End(period);
            CqlDateTime d_ = context.Operators.MaxValue<CqlDateTime>();
            bool? e_ = context.Operators.Equal(c_, d_);
            return e_;
        }

        return !((bool?)(/* CQL 'or' (360:7-364:3) */ ((CqlBoolean)((bool?)(a_ is null))
            || b_())));
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
                CqlDateTime f_ = context.Operators.End(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.Start(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
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
                CqlDateTime f_ = context.Operators.Start(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.End(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
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
