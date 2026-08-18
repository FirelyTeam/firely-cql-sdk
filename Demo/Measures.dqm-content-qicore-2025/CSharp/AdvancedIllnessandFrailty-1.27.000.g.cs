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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
        IEnumerable<DeviceRequest> c_ = context.Operators.Union<DeviceRequest>(b_, b_);
        IEnumerable<DeviceRequest> d_ = Status_1_15_000.Instance.isDeviceOrderPersonalUseDevices(context, c_);

        bool? e_(DeviceRequest FrailtyDeviceOrder) {
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            FhirDateTime ai_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlBoolean al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, ak_, "day");
            return al_;
        }

        CqlBoolean f_ = context.Operators.WhereAny<DeviceRequest>(d_, e_);
        CqlCode g_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> j_ = Status_1_15_000.Instance.isAssessmentPerformed(context, i_);

        bool? k_(Observation EquipmentUsed) {
            DataType am_ = EquipmentUsed?.Value;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            CqlValueSet ao_ = this.Frailty_Device(context);
            CqlBoolean ap_ = context.Operators.ConceptInValueSet(an_ as CqlConcept, ao_);
            DataType aq_ = EquipmentUsed?.Effective;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.End(as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, "day");
            CqlBoolean aw_ = av_;
            return ap_
                /* CQL 'and' (51:9-52:88) */ && aw_;
        }

        CqlBoolean l_ = context.Operators.WhereAny<Observation>(j_, k_);
        CqlBoolean m_ = l_;
        CqlValueSet n_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> q_ = context.Operators.Union<Condition>(o_ as IEnumerable<Condition>, p_ as IEnumerable<Condition>);
        IEnumerable<Condition> r_ = Status_1_15_000.Instance.verified(context, q_);

        bool? s_(Condition FrailtyDiagnosis) {
            CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
            CqlBoolean az_ = context.Operators.Overlaps(ax_, ay_, "day");
            return az_;
        }

        CqlBoolean t_ = context.Operators.WhereAny<Condition>(r_, s_);
        CqlBoolean u_ = t_;
        CqlValueSet v_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> x_ = Status_1_15_000.Instance.isEncounterPerformed(context, w_);

        bool? y_(Encounter FrailtyEncounter) {
            Period ba_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
            CqlBoolean bd_ = context.Operators.Overlaps(bb_, bc_, "day");
            return bd_;
        }

        CqlBoolean z_ = context.Operators.WhereAny<Encounter>(x_, y_);
        CqlBoolean aa_ = z_;
        CqlValueSet ab_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> ac_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
        IEnumerable<Observation> ad_ = Status_1_15_000.Instance.isSymptom(context, ac_);

        bool? ae_(Observation FrailtySymptom) {
            DataType be_ = FrailtySymptom?.Effective;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
            CqlInterval<CqlDateTime> bh_ = this.Measurement_Period(context);
            CqlBoolean bi_ = context.Operators.Overlaps(bg_, bh_, "day");
            return bi_;
        }

        CqlBoolean af_ = context.Operators.WhereAny<Observation>(ad_, ae_);
        CqlBoolean ag_ = af_;
        return f_
            /* CQL 'or' (47:3-53:5) */ || m_
            /* CQL 'or' (47:3-57:5) */ || u_
            /* CQL 'or' (47:3-60:5) */ || aa_
            /* CQL 'or' (47:3-63:5) */ || ag_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period, Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period = 4021845699547811445L;

    private bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Advanced_Illness(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition AdvancedIllnessDiagnosis) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlQuantity l_ = context.Operators.Quantity(1m, "year");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlDateTime n_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(m_, n_, true, true);
            CqlBoolean p_ = context.Operators.In<CqlDateTime>(i_, o_, "day");
            return p_;
        }

        CqlBoolean g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period, Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period = -3830212988528037437L;

    private bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                CqlBoolean q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Dementia_Medications(context);
                CqlBoolean u_ = context.Operators.ConceptInValueSet(s_, t_);
                CqlBoolean v_ = u_;
                return q_
                    /* CQL 'and' */ && v_;
            }

            CqlBoolean l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest DementiaMedication) {
            CqlInterval<CqlDate> w_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate x_ = w_?.low;
            CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_);
            CqlDate z_ = w_?.high;
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlBoolean ab_ = w_?.lowClosed;
            CqlBoolean ac_ = w_?.highClosed;
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(y_, aa_, ab_, ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlQuantity ag_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
            CqlDateTime ai_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ah_, ai_, true, true);
            CqlBoolean ak_ = context.Operators.Overlaps(ad_, aj_, "day");
            return ak_;
        }

        CqlBoolean i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
        return i_;
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
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 66);
        CqlBoolean j_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        CqlBoolean k_ = j_
            /* CQL 'or' (31:9-33:5) */ || this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        return i_
            /* CQL 'and' (29:4-30:41) */ && this.Has_Criteria_Indicating_Frailty(context)
            /* CQL 'and' (29:4-33:5) */ && k_;
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
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        CqlBoolean k_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        CqlBoolean l_ = k_
            /* CQL 'or' (38:11-40:7) */ || this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        CqlBoolean m_ = context.Operators.GreaterOrEqual(h_, 81);
        CqlBoolean n_ = m_
            /* CQL 'and' (42:8-44:5) */ && this.Has_Criteria_Indicating_Frailty(context);
        return (j_
            /* CQL 'and' (36:5-37:43) */ && this.Has_Criteria_Indicating_Frailty(context)
            /* CQL 'and' (36:3-41:3) */ && l_)
            /* CQL 'or' (36:3-44:5) */ || n_;
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
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 66);
        CqlCode j_ = this.Housing_status(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> m_ = Status_1_15_000.Instance.isAssessmentPerformed(context, l_);

        bool? n_(Observation HousingStatus) {
            DataType x_ = HousingStatus?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlBoolean ad_ = context.Operators.SameOrBefore(aa_, ac_, "day");
            return ad_;
        }

        IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);

        object p_(Observation @this) {
            DataType ae_ = @this?.Effective;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
            CqlDateTime ah_ = context.Operators.End(ag_);
            return ah_;
        }

        IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
        Observation r_ = context.Operators.Last<Observation>(q_);
        Observation[] s_ = [
            r_,
        ];

        bool? t_(Observation LastHousingStatus) {
            DataType ai_ = LastHousingStatus?.Value;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlCode ak_ = this.Lives_in_nursing_home__finding_(context);
            CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
            CqlBoolean am_ = context.Operators.Equivalent(aj_ as CqlConcept, al_);
            return am_;
        }

        IEnumerable<Observation> u_ = context.Operators.Where<Observation>((IEnumerable<Observation>)s_, t_);
        Observation v_ = context.Operators.SingletonFrom<Observation>(u_);
        CqlBoolean w_ = (CqlBoolean)(v_ is not null);
        return i_
            /* CQL 'and' (77:3-87:17) */ && w_;
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
