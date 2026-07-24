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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public partial class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012 : ILibrary, ISingleton<SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012>
{
    #region ValueSets (8)

    [CqlValueSetDefinition("All Primary and Secondary Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", valueSetVersion: null)]
    public CqlValueSet All_Primary_and_Secondary_Cancer(CqlContext _) => _All_Primary_and_Secondary_Cancer;
    private static readonly CqlValueSet _All_Primary_and_Secondary_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Schedule II & III Opioid Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", valueSetVersion: null)]
    public CqlValueSet Schedule_II__and__III_Opioid_Medications(CqlContext _) => _Schedule_II__and__III_Opioid_Medications;
    private static readonly CqlValueSet _Schedule_II__and__III_Opioid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

    [CqlValueSetDefinition("Schedule IV Benzodiazepines", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", valueSetVersion: null)]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext _) => _Schedule_IV_Benzodiazepines;
    private static readonly CqlValueSet _Schedule_IV_Benzodiazepines = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6669692820371050143L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (10)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3137868249854205925L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18, Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Compute);

    private const long _cacheIndex_Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18 = 3432424292580369448L;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter EncounterInpatient) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            Code<Encounter.EncounterStatus> n_ = EncounterInpatient?.StatusElement;
            string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "finished");
            bool? q_ = context.Operators.And(m_, p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 9018903564446859966L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? v_(Medication M) {
                    Id y_ = M?.IdElement;
                    string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
                    object aa_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_ as FhirString);
                    IEnumerable<string> ac_ = context.Operators.Split(ab_, "/");
                    string ad_ = context.Operators.Last<string>(ac_);
                    bool? ae_ = context.Operators.Equal(z_, ad_);
                    CodeableConcept af_ = M?.Code;
                    CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_);
                    CqlValueSet ah_ = this.Schedule_II__and__III_Opioid_Medications(context);
                    bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                    bool? aj_ = context.Operators.And(ae_, ai_);
                    return aj_;
                }

                IEnumerable<Medication> w_ = context.Operators.Where<Medication>(u_, v_);
                bool? x_ = context.Operators.Exists<Medication>(w_);
                return x_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            CqlValueSet j_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? l_(MedicationRequest MR) {
                IEnumerable<Medication> ak_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? al_(Medication M) {
                    Id ao_ = M?.IdElement;
                    string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                    object aq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string ar_ = FHIRHelpers_4_0_001.Instance.ToString(context, aq_ as FhirString);
                    IEnumerable<string> as_ = context.Operators.Split(ar_, "/");
                    string at_ = context.Operators.Last<string>(as_);
                    bool? au_ = context.Operators.Equal(ap_, at_);
                    CodeableConcept av_ = M?.Code;
                    CqlConcept aw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, av_);
                    CqlValueSet ax_ = this.Schedule_IV_Benzodiazepines(context);
                    bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                    bool? az_ = context.Operators.And(au_, ay_);
                    return az_;
                }

                IEnumerable<Medication> am_ = context.Operators.Where<Medication>(ak_, al_);
                bool? an_ = context.Operators.Exists<Medication>(am_);
                return an_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(f_, l_);
            IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);

            bool? o_(MedicationRequest Medications) {
                List<CodeableConcept> ba_ = Medications?.Category;

                bool? bb_(CodeableConcept C) {
                    CqlConcept be_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                    bool? bh_ = context.Operators.Equivalent(be_, bg_);
                    return bh_;
                }

                IEnumerable<CodeableConcept> bc_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ba_, bb_);
                bool? bd_ = context.Operators.Exists<CodeableConcept>(bc_);
                return bd_;
            }

            IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);
            IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(i_, p_);

            bool? r_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) {
                FhirDateTime bi_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime bj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bi_);
                Period bk_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bk_);
                bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, (string)default);
                Code<MedicationRequest.MedicationrequestStatus> bn_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string bo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bn_);
                bool? bp_ = context.Operators.Equal(bo_, "active");
                bool? bq_ = context.Operators.And(bm_, bp_);
                Code<MedicationRequest.MedicationRequestIntent> br_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string bs_ = FHIRHelpers_4_0_001.Instance.ToString(context, br_);
                bool? bt_ = context.Operators.Equal(bs_, "plan");
                bool? bu_ = context.Operators.And(bq_, bt_);
                return bu_;
            }

            IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);
            bool? t_ = context.Operators.Exists<MedicationRequest>(s_);
            return t_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -2148238633346245748L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -7346475095800049932L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2601078950244055456L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -8388746364952351607L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -2931171329986460123L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5589410208927547108L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet i_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? k_(MedicationRequest Opioids) {
                FhirDateTime r_ = Opioids?.AuthoredOnElement;
                CqlDateTime s_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, r_);
                Period t_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, t_);
                bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, (string)default);
                return v_;
            }

            IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(j_, k_);

            object m_(MedicationRequest Opioids) {
                DataType w_ = Opioids?.Medication;
                return w_;
            }

            IEnumerable<object> n_ = context.Operators.Select<MedicationRequest, object>(l_, m_);
            IEnumerable<object> o_ = context.Operators.Distinct<object>(n_);
            int? p_ = context.Operators.Count<object>(o_);
            bool? q_ = context.Operators.GreaterOrEqual(p_, 2);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter InpatientEncounter) {
            CqlValueSet x_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? z_(MedicationRequest OpioidsDischarge) {
                FhirDateTime ac_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime ad_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ac_);
                Period ae_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ae_);
                bool? ag_ = context.Operators.In<CqlDateTime>(ad_, af_, (string)default);
                return ag_;
            }

            IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
            bool? ab_ = context.Operators.Exists<MedicationRequest>(aa_);
            return ab_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);

        bool? f_(Encounter InpatientEncounter) {
            CqlValueSet ah_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? aj_(MedicationRequest BenzodiazepinesDischarge) {
                FhirDateTime am_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime an_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, am_);
                Period ao_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, (string)default);
                return aq_;
            }

            IEnumerable<MedicationRequest> ak_ = context.Operators.Where<MedicationRequest>(ai_, aj_);
            bool? al_ = context.Operators.Exists<MedicationRequest>(ak_);
            return al_;
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(c_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = -1298983561246115144L;

    private IEnumerable<Encounter> Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet g_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? i_(Condition Cancer) {
                CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period ac_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.Overlaps(ab_, ad_, (string)default);
                return ae_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            CqlValueSet l_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

            bool? n_(ServiceRequest PalliativeOrHospiceCareOrder) {
                FhirDateTime af_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime ag_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, af_);
                Period ah_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                bool? aj_ = context.Operators.In<CqlDateTime>(ag_, ai_, (string)default);
                Code<RequestIntent> ak_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string al_ = FHIRHelpers_4_0_001.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "order");
                bool? an_ = context.Operators.And(aj_, am_);
                return an_;
            }

            IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
            bool? p_ = context.Operators.Exists<ServiceRequest>(o_);
            bool? q_ = context.Operators.Or(k_, p_);
            IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? s_(Procedure PalliativeOrHospiceCarePerformed) {
                DataType ao_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ao_);
                Period aq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_);
                bool? as_ = context.Operators.Overlaps(ap_, ar_, (string)default);
                return as_;
            }

            IEnumerable<Procedure> t_ = context.Operators.Where<Procedure>(r_, s_);
            bool? u_ = context.Operators.Exists<Procedure>(t_);
            bool? v_ = context.Operators.Or(q_, u_);
            IEnumerable<Encounter> w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

            bool? x_(Encounter InpatientEncounter) {
                Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
                CodeableConcept au_ = at_?.DischargeDisposition;
                CqlConcept av_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, au_);
                CqlValueSet aw_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                CqlValueSet ay_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? az_ = context.Operators.ConceptInValueSet(av_, ay_);
                bool? ba_ = context.Operators.Or(ax_, az_);
                CqlValueSet bb_ = this.Patient_Expired(context);
                bool? bc_ = context.Operators.ConceptInValueSet(av_, bb_);
                bool? bd_ = context.Operators.Or(ba_, bc_);
                return bd_;
            }

            IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
            bool? z_ = context.Operators.Exists<Encounter>(y_);
            bool? aa_ = context.Operators.Or(v_, z_);
            return aa_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter InpatientEncounter) => InpatientEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012() {}

    public static SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SafeUseofOpioidsConcurrentPrescribingFHIR";
    public string Version => "0.0.012";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

}
