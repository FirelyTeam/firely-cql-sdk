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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            FhirDateTime k_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");
            return n_;
        }

        bool? f_ = context.Operators.WhereAny<DeviceRequest>(d_, e_);
        bool? g_;
        // CQL 'or' (47:3-53:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode o_ = this.Medical_equipment_used(context);
            IEnumerable<CqlCode> p_ = context.Operators.ToList<CqlCode>(o_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> r_ = Status_1_15_000.Instance.isAssessmentPerformed(context, q_);

            bool? s_(Observation EquipmentUsed) {
                DataType u_ = EquipmentUsed?.Value;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlValueSet w_ = this.Frailty_Device(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                // CQL 'and' (51:9-52:88): right operand skipped when left is false
                if (x_ is false)
                {
                    return false;
                }
                else
                {
                    DataType y_ = EquipmentUsed?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                    bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, "day");
                    return x_ & ad_;
                }
            }

            bool? t_ = context.Operators.WhereAny<Observation>(r_, s_);
            g_ = f_ | t_;
        }
        bool? h_;
        // CQL 'or' (47:3-57:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlValueSet ae_ = this.Frailty_Diagnosis(context);
            IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ag_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ah_ = context.Operators.Union<Condition>(af_ as IEnumerable<Condition>, ag_ as IEnumerable<Condition>);
            IEnumerable<Condition> ai_ = Status_1_15_000.Instance.verified(context, ah_);

            bool? aj_(Condition FrailtyDiagnosis) {
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
                CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
                bool? an_ = context.Operators.Overlaps(al_, am_, "day");
                return an_;
            }

            bool? ak_ = context.Operators.WhereAny<Condition>(ai_, aj_);
            h_ = g_ | ak_;
        }
        bool? i_;
        // CQL 'or' (47:3-60:5): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            CqlValueSet ao_ = this.Frailty_Encounter(context);
            IEnumerable<Encounter> ap_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ao_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> aq_ = Status_1_15_000.Instance.isEncounterPerformed(context, ap_);

            bool? ar_(Encounter FrailtyEncounter) {
                Period at_ = FrailtyEncounter?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
                bool? aw_ = context.Operators.Overlaps(au_, av_, "day");
                return aw_;
            }

            bool? as_ = context.Operators.WhereAny<Encounter>(aq_, ar_);
            i_ = h_ | as_;
        }
        // CQL 'or' (47:3-63:5): right operand skipped when left is true
        if (i_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet ax_ = this.Frailty_Symptom(context);
            IEnumerable<Observation> ay_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
            IEnumerable<Observation> az_ = Status_1_15_000.Instance.isSymptom(context, ay_);

            bool? ba_(Observation FrailtySymptom) {
                DataType bc_ = FrailtySymptom?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlInterval<CqlDateTime> bf_ = this.Measurement_Period(context);
                bool? bg_ = context.Operators.Overlaps(be_, bf_, "day");
                return bg_;
            }

            bool? bb_ = context.Operators.WhereAny<Observation>(az_, ba_);
            return i_ | bb_;
        }
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
            bool? p_ = context.Operators.In<CqlDateTime>(i_, o_, "day");
            return p_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
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
                bool? q_ = context.Operators.Equal(m_, p_);
                // CQL 'and': right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Dementia_Medications(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return q_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest DementiaMedication) {
            CqlInterval<CqlDate> v_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate w_ = v_?.low;
            CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
            CqlDate y_ = v_?.high;
            CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
            bool? aa_ = v_?.lowClosed;
            bool? ab_ = v_?.highClosed;
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(x_, z_, aa_, ab_);
            CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlQuantity af_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
            CqlDateTime ah_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
            bool? aj_ = context.Operators.Overlaps(ac_, ai_, "day");
            return aj_;
        }

        bool? i_ = context.Operators.WhereAny<MedicationRequest>(g_, h_);
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
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
        bool? j_;
        // CQL 'and' (29:4-30:41): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
            j_ = i_ & k_;
        }
        // CQL 'and' (29:4-33:5): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            bool? l_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
            bool? m_;
            // CQL 'or' (31:9-33:5): right operand skipped when left is true
            if (l_ is true)
            {
                m_ = true;
            }
            else
            {
                bool? n_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
                m_ = l_ | n_;
            }
            return j_ & m_;
        }
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
        bool? k_;
        // CQL 'and' (36:5-37:43): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            bool? m_ = this.Has_Criteria_Indicating_Frailty(context);
            k_ = j_ & m_;
        }
        bool? l_;
        // CQL 'and' (36:3-41:3): right operand skipped when left is false
        if (k_ is false)
        {
            l_ = false;
        }
        else
        {
            bool? n_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
            bool? o_;
            // CQL 'or' (38:11-40:7): right operand skipped when left is true
            if (n_ is true)
            {
                o_ = true;
            }
            else
            {
                bool? p_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
                o_ = n_ | p_;
            }
            l_ = k_ & o_;
        }
        // CQL 'or' (36:3-44:5): right operand skipped when left is true
        if (l_ is true)
        {
            return true;
        }
        else
        {
            Patient q_ = this.Patient(context);
            Date r_ = q_?.BirthDateElement;
            string s_ = r_?.Value;
            CqlDate t_ = context.Operators.ConvertStringToDate(s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlDate w_ = context.Operators.DateFrom(v_);
            int? x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
            bool? y_ = context.Operators.GreaterOrEqual(x_, 81);
            bool? z_;
            // CQL 'and' (42:8-44:5): right operand skipped when left is false
            if (y_ is false)
            {
                z_ = false;
            }
            else
            {
                bool? aa_ = this.Has_Criteria_Indicating_Frailty(context);
                z_ = y_ & aa_;
            }
            return l_ | z_;
        }
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
        // CQL 'and' (77:3-87:17): right operand skipped when left is false
        if (i_ is false)
        {
            return false;
        }
        else
        {
            CqlCode j_ = this.Housing_status(context);
            IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
            IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> m_ = Status_1_15_000.Instance.isAssessmentPerformed(context, l_);

            bool? n_(Observation HousingStatus) {
                DataType w_ = HousingStatus?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                CqlDateTime ab_ = context.Operators.End(aa_);
                bool? ac_ = context.Operators.SameOrBefore(z_, ab_, "day");
                return ac_;
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);

            object p_(Observation @this) {
                DataType ad_ = @this?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.End(af_);
                return ag_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.Last<Observation>(q_);
            Observation[] s_ = [
                r_,
            ];

            bool? t_(Observation LastHousingStatus) {
                DataType ah_ = LastHousingStatus?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlCode aj_ = this.Lives_in_nursing_home__finding_(context);
                CqlConcept ak_ = context.Operators.ConvertCodeToConcept(aj_);
                bool? al_ = context.Operators.Equivalent(ai_ as CqlConcept, ak_);
                return al_;
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>((IEnumerable<Observation>)s_, t_);
            Observation v_ = context.Operators.SingletonFrom<Observation>(u_);
            return i_ & (!((bool?)(v_ is null)));
        }
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
