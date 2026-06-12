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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.1.0")]
[CqlLibrary("AdvancedIllnessandFrailty", "1.27.000")]
public partial class AdvancedIllnessandFrailty_1_27_000 : ILibrary, ISingleton<AdvancedIllnessandFrailty_1_27_000>
{
    #region ValueSets (6)

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    #endregion ValueSets

    #region Codes (3)

    [CqlCodeDefinition("Housing status", codeId: "71802-3", codeSystem: "http://loinc.org")]
    public CqlCode Housing_status(CqlContext _) => _Housing_status;
    private static readonly CqlCode _Housing_status = new CqlCode("71802-3", "http://loinc.org");

    [CqlCodeDefinition("Lives in nursing home (finding)", codeId: "160734000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Lives_in_nursing_home__finding_(CqlContext _) => _Lives_in_nursing_home__finding_;
    private static readonly CqlCode _Lives_in_nursing_home__finding_ = new CqlCode("160734000", "http://snomed.info/sct");

    [CqlCodeDefinition("Medical equipment used", codeId: "98181-1", codeSystem: "http://loinc.org")]
    public CqlCode Medical_equipment_used(CqlContext _) => _Medical_equipment_used;
    private static readonly CqlCode _Medical_equipment_used = new CqlCode("98181-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Housing_status,
          _Medical_equipment_used]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Lives_in_nursing_home__finding_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -892027430157829280L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.27.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (7)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -632786785956096393L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Criteria_Indicating_Frailty, Has_Criteria_Indicating_Frailty_Compute);

    private const long _cacheIndex_Has_Criteria_Indicating_Frailty = 4145412945853810829L;

    private bool? Has_Criteria_Indicating_Frailty_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> d_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> e_ = context.Operators.Union<DeviceRequest>(b_, d_);
        IEnumerable<DeviceRequest> f_ = Status_1_15_000.Instance.isDeviceOrderPersonalUseDevices(context, e_);

        bool? g_(DeviceRequest FrailtyDeviceOrder) {
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            FhirDateTime aq_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_ as object);
            bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, "day");
            return at_;
        }

        IEnumerable<DeviceRequest> h_ = context.Operators.Where<DeviceRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<DeviceRequest>(h_);
        CqlCode j_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> m_ = Status_1_15_000.Instance.isAssessmentPerformed(context, l_);

        bool? n_(Observation EquipmentUsed) {
            DataType au_ = EquipmentUsed?.Value;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            CqlValueSet aw_ = this.Frailty_Device(context);
            bool? ax_ = context.Operators.ConceptInValueSet(av_ as CqlConcept, aw_);
            DataType ay_ = EquipmentUsed?.Effective;
            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
            CqlDateTime bb_ = context.Operators.End(ba_);
            CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
            bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, "day");
            bool? be_ = context.Operators.And(ax_, bd_);
            return be_;
        }

        IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
        bool? p_ = context.Operators.Exists<Observation>(o_);
        bool? q_ = context.Operators.Or(i_, p_);
        CqlValueSet r_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> v_ = context.Operators.Union<object>(s_ as IEnumerable<object>, u_ as IEnumerable<object>);
        IEnumerable<object> w_ = Status_1_15_000.Instance.verified(context, v_);

        bool? x_(object FrailtyDiagnosis) {
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
            bool? bh_ = context.Operators.Overlaps(bf_, bg_, "day");
            return bh_;
        }

        IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
        bool? z_ = context.Operators.Exists<object>(y_);
        bool? aa_ = context.Operators.Or(q_, z_);
        CqlValueSet ab_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ad_ = Status_1_15_000.Instance.isEncounterPerformed(context, ac_);

        bool? ae_(Encounter FrailtyEncounter) {
            Period bi_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
            CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
            bool? bl_ = context.Operators.Overlaps(bj_, bk_, "day");
            return bl_;
        }

        IEnumerable<Encounter> af_ = context.Operators.Where<Encounter>(ad_, ae_);
        bool? ag_ = context.Operators.Exists<Encounter>(af_);
        bool? ah_ = context.Operators.Or(aa_, ag_);
        CqlValueSet ai_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> aj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
        IEnumerable<Observation> ak_ = Status_1_15_000.Instance.isSymptom(context, aj_);

        bool? al_(Observation FrailtySymptom) {
            DataType bm_ = FrailtySymptom?.Effective;
            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
            CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
            CqlInterval<CqlDateTime> bp_ = this.Measurement_Period(context);
            bool? bq_ = context.Operators.Overlaps(bo_, bp_, "day");
            return bq_;
        }

        IEnumerable<Observation> am_ = context.Operators.Where<Observation>(ak_, al_);
        bool? an_ = context.Operators.Exists<Observation>(am_);
        bool? ao_ = context.Operators.Or(ah_, an_);
        return ao_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period, Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period = 4021845699547811445L;

    private bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Advanced_Illness(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(object AdvancedIllnessDiagnosis) {
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(1m, "year");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlDateTime q_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, "day");
            return s_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
        bool? i_ = context.Operators.Exists<object>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period, Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period = -3830212988528037437L;

    private bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Dementia_Medications(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            MedicationRequest n_(Medication M) => MR;
            IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);
            return o_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest DementiaMedication) {
            CqlInterval<CqlDate> z_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate aa_ = z_?.low;
            CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
            CqlDate ad_ = z_?.high;
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            bool? ag_ = z_?.lowClosed;
            bool? ai_ = z_?.highClosed;
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ab_, ae_, ag_, ai_);
            CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlQuantity am_ = context.Operators.Quantity(1m, "year");
            CqlDateTime an_ = context.Operators.Subtract(al_, am_);
            CqlDateTime ap_ = context.Operators.End(ak_);
            CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(an_, ap_, true, true);
            bool? ar_ = context.Operators.Overlaps(aj_, aq_, "day");
            return ar_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty, Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty_Compute);

    private const long _cacheIndex_Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty = 1656099928315620027L;

    private bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
        bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? k_ = context.Operators.And(i_, j_);
        bool? l_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? m_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? n_ = context.Operators.Or(l_, m_);
        bool? o_ = context.Operators.And(k_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty, Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Compute);

    private const long _cacheIndex_Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty = 7309670936429856188L;

    private bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? l_ = context.Operators.And(j_, k_);
        bool? m_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? n_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? o_ = context.Operators.Or(m_, n_);
        bool? p_ = context.Operators.And(l_, o_);
        Date r_ = a_?.BirthDateElement;
        string s_ = r_?.Value;
        CqlDate t_ = context.Operators.ConvertStringToDate(s_);
        CqlDateTime v_ = context.Operators.End(e_);
        CqlDate w_ = context.Operators.DateFrom(v_);
        int? x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
        bool? y_ = context.Operators.GreaterOrEqual(x_, 81);
        bool? aa_ = context.Operators.And(y_, k_);
        bool? ab_ = context.Operators.Or(p_, aa_);
        return ab_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home, Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Compute);

    private const long _cacheIndex_Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home = -3190069561351145181L;

    private bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
        CqlCode j_ = this.Housing_status(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> m_ = Status_1_15_000.Instance.isAssessmentPerformed(context, l_);

        bool? n_(Observation HousingStatus) {
            DataType y_ = HousingStatus?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
            CqlDateTime ad_ = context.Operators.End(ac_);
            bool? ae_ = context.Operators.SameOrBefore(ab_, ad_, "day");
            return ae_;
        }

        IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);

        object p_(Observation @this) {
            DataType af_ = @this?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);
            return ai_;
        }

        IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
        Observation r_ = context.Operators.Last<Observation>(q_);
        Observation[] s_ = [
            r_,
        ];

        bool? t_(Observation LastHousingStatus) {
            DataType aj_ = LastHousingStatus?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlCode al_ = this.Lives_in_nursing_home__finding_(context);
            CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
            bool? an_ = context.Operators.Equivalent(ak_ as CqlConcept, am_);
            return an_;
        }

        IEnumerable<Observation> u_ = context.Operators.Where<Observation>((IEnumerable<Observation>)s_, t_);
        Observation v_ = context.Operators.SingletonFrom<Observation>(u_);
        bool? w_ = context.Operators.Not((bool?)(v_ is null));
        bool? x_ = context.Operators.And(i_, w_);
        return x_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private AdvancedIllnessandFrailty_1_27_000() {}

    public static AdvancedIllnessandFrailty_1_27_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "AdvancedIllnessandFrailty";
    public string Version => "1.27.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
