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
using TestConsoleAppFhir.resources.output._69;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("HospiceQDM", "7.0.000")]
public partial class HospiceQDM_7_0_000 : ILibrary, ISingleton<HospiceQDM_7_0_000>
{
    private HospiceQDM_7_0_000() {}

    public static HospiceQDM_7_0_000 Instance { get; } = new();

    #region ILibrary Implementation

public string Name => "HospiceQDM";
public string Version => "7.0.000";
    public ILibrary[] Dependencies => [CQMCommonQDM_9_0_000.Instance];

#endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "urn:oid:2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("urn:oid:2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "urn:oid:2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("urn:oid:2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "urn:oid:2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("urn:oid:2.16.840.1.113883.3.464.1003.1003", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "urn:oid:2.16.840.1.113883.6.96")]
public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "urn:oid:2.16.840.1.113883.6.96");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "urn:oid:2.16.840.1.113883.6.96")]
public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "urn:oid:2.16.840.1.113883.6.96");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "urn:oid:2.16.840.1.113883.6.1")]
public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "urn:oid:2.16.840.1.113883.6.1");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "urn:oid:2.16.840.1.113883.6.96")]
public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "urn:oid:2.16.840.1.113883.6.96");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "urn:oid:2.16.840.1.113883.6.96", codeSystemVersion: null)]
public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
private static readonly CqlCodeSystem _SNOMEDCT =
  new CqlCodeSystem("urn:oid:2.16.840.1.113883.6.96", null, [
      _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
      _Discharge_to_home_for_hospice_care__procedure_,
      _Yes__qualifier_value_]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "urn:oid:2.16.840.1.113883.6.1", codeSystemVersion: null)]
public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
private static readonly CqlCodeSystem _LOINC =
  new CqlCodeSystem("urn:oid:2.16.840.1.113883.6.1", null, [
      _Hospice_care__Minimum_Data_Set_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("HospiceQDM-7.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<PositiveEncounterPerformed> b_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, a_, default, "PositiveEncounterPerformed"));
        bool? c_(PositiveEncounterPerformed InpatientEncounter)
        {
            CqlCode ak_ = context.Operators.LateBoundProperty<CqlCode>(InpatientEncounter, "dischargeDisposition");
            CqlCode al_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            bool? am_ = context.Operators.Equivalent(ak_, al_);
            CqlCode ao_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            bool? ap_ = context.Operators.Equivalent(ak_, ao_);
            bool? aq_ = context.Operators.Or(am_, ap_);
            CqlInterval<CqlDateTime> ar_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(InpatientEncounter, "relevantPeriod");
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
            bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, "day");
            bool? av_ = context.Operators.And(aq_, au_);

            return av_;
        };
        IEnumerable<PositiveEncounterPerformed> d_ = context.Operators.Where<PositiveEncounterPerformed>(b_, c_);
        bool? e_ = context.Operators.Exists<PositiveEncounterPerformed>(d_);
        CqlValueSet f_ = this.Hospice_Encounter(context);
        IEnumerable<PositiveEncounterPerformed> g_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, f_, default, "PositiveEncounterPerformed"));
        bool? h_(PositiveEncounterPerformed HospiceEncounter)
        {
            CqlInterval<CqlDateTime> aw_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HospiceEncounter, "relevantPeriod");
            CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
            bool? ay_ = context.Operators.Overlaps(aw_, ax_, "day");

            return ay_;
        };
        IEnumerable<PositiveEncounterPerformed> i_ = context.Operators.Where<PositiveEncounterPerformed>(g_, h_);
        bool? j_ = context.Operators.Exists<PositiveEncounterPerformed>(i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlCode l_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<PositiveAssessmentPerformed> n_ = context.Operators.Retrieve<PositiveAssessmentPerformed>(new RetrieveParameters(default, default, m_, "PositiveAssessmentPerformed"));
        bool? o_(PositiveAssessmentPerformed HospiceAssessment)
        {
            object az_ = context.Operators.LateBoundProperty<object>(HospiceAssessment, "result");
            CqlCode ba_ = this.Yes__qualifier_value_(context);
            bool? bb_ = context.Operators.Equivalent(az_ as CqlCode, ba_);
            CqlDateTime bc_ = context.Operators.LateBoundProperty<CqlDateTime>(HospiceAssessment, "relevantDatetime");
            CqlInterval<CqlDateTime> bd_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HospiceAssessment, "relevantPeriod");
            CqlInterval<CqlDateTime> be_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, bc_, bd_);
            CqlInterval<CqlDateTime> bf_ = this.Measurement_Period(context);
            bool? bg_ = context.Operators.Overlaps(be_, bf_, "day");
            bool? bh_ = context.Operators.And(bb_, bg_);

            return bh_;
        };
        IEnumerable<PositiveAssessmentPerformed> p_ = context.Operators.Where<PositiveAssessmentPerformed>(n_, o_);
        bool? q_ = context.Operators.Exists<PositiveAssessmentPerformed>(p_);
        bool? r_ = context.Operators.Or(k_, q_);
        CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<PositiveInterventionOrder> t_ = context.Operators.Retrieve<PositiveInterventionOrder>(new RetrieveParameters(default, s_, default, "PositiveInterventionOrder"));
        bool? u_(PositiveInterventionOrder HospiceOrder)
        {
            CqlDateTime bi_ = context.Operators.LateBoundProperty<CqlDateTime>(HospiceOrder, "authorDatetime");
            CqlInterval<CqlDateTime> bj_ = this.Measurement_Period(context);
            bool? bk_ = context.Operators.In<CqlDateTime>(bi_, bj_, "day");

            return bk_;
        };
        IEnumerable<PositiveInterventionOrder> v_ = context.Operators.Where<PositiveInterventionOrder>(t_, u_);
        bool? w_ = context.Operators.Exists<PositiveInterventionOrder>(v_);
        bool? x_ = context.Operators.Or(r_, w_);
        IEnumerable<PositiveInterventionPerformed> z_ = context.Operators.Retrieve<PositiveInterventionPerformed>(new RetrieveParameters(default, s_, default, "PositiveInterventionPerformed"));
        bool? aa_(PositiveInterventionPerformed HospicePerformed)
        {
            CqlDateTime bl_ = context.Operators.LateBoundProperty<CqlDateTime>(HospicePerformed, "relevantDatetime");
            CqlInterval<CqlDateTime> bm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HospicePerformed, "relevantPeriod");
            CqlInterval<CqlDateTime> bn_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, bl_, bm_);
            CqlInterval<CqlDateTime> bo_ = this.Measurement_Period(context);
            bool? bp_ = context.Operators.Overlaps(bn_, bo_, "day");

            return bp_;
        };
        IEnumerable<PositiveInterventionPerformed> ab_ = context.Operators.Where<PositiveInterventionPerformed>(z_, aa_);
        bool? ac_ = context.Operators.Exists<PositiveInterventionPerformed>(ab_);
        bool? ad_ = context.Operators.Or(x_, ac_);
        CqlValueSet ae_ = this.Hospice_Diagnosis(context);
        IEnumerable<Diagnosis> af_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, ae_, default, default));
        bool? ag_(Diagnosis HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> bq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HospiceCareDiagnosis, "prevalencePeriod");
            CqlInterval<CqlDateTime> br_ = this.Measurement_Period(context);
            bool? bs_ = context.Operators.Overlaps(bq_, br_, "day");

            return bs_;
        };
        IEnumerable<Diagnosis> ah_ = context.Operators.Where<Diagnosis>(af_, ag_);
        bool? ai_ = context.Operators.Exists<Diagnosis>(ah_);
        bool? aj_ = context.Operators.Or(ad_, ai_);

        return aj_;
    }


    [CqlExpressionDefinition("Patient")]
    public PatientDetails Patient(CqlContext context)
    {
        IEnumerable<PatientDetails> a_ = context.Operators.Retrieve<PatientDetails>(new RetrieveParameters(default, default, default, "Patient"));
        PatientDetails b_ = context.Operators.SingletonFrom<PatientDetails>(a_);

        return b_;
    }


    #endregion Functions and Expressions

}
