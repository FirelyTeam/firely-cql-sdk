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

        IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                IEnumerable<Medication> w_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? x_(Medication M) {
                    Id ab_ = M?.IdElement;
                    string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
                    object ad_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_ as FhirString);
                    IEnumerable<string> af_ = context.Operators.Split(ae_, "/");
                    string ag_ = context.Operators.Last<string>(af_);
                    bool? ah_ = context.Operators.Equal(ac_, ag_);
                    CodeableConcept ai_ = M?.Code;
                    CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                    CqlValueSet ak_ = this.Schedule_II__and__III_Opioid_Medications(context);
                    bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                    bool? am_ = context.Operators.And(ah_, al_);
                    return am_;
                }

                IEnumerable<Medication> y_ = context.Operators.Where<Medication>(w_, x_);
                MedicationRequest z_(Medication M) => MR;
                IEnumerable<MedicationRequest> aa_ = context.Operators.Select<Medication, MedicationRequest>(y_, z_);
                return aa_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            CqlValueSet j_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            IEnumerable<MedicationRequest> m_(MedicationRequest MR) {
                IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? ao_(Medication M) {
                    Id as_ = M?.IdElement;
                    string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
                    object au_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_ as FhirString);
                    IEnumerable<string> aw_ = context.Operators.Split(av_, "/");
                    string ax_ = context.Operators.Last<string>(aw_);
                    bool? ay_ = context.Operators.Equal(at_, ax_);
                    CodeableConcept az_ = M?.Code;
                    CqlConcept ba_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, az_);
                    CqlValueSet bb_ = this.Schedule_IV_Benzodiazepines(context);
                    bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                    bool? bd_ = context.Operators.And(ay_, bc_);
                    return bd_;
                }

                IEnumerable<Medication> ap_ = context.Operators.Where<Medication>(an_, ao_);
                MedicationRequest aq_(Medication M) => MR;
                IEnumerable<MedicationRequest> ar_ = context.Operators.Select<Medication, MedicationRequest>(ap_, aq_);
                return ar_;
            }

            IEnumerable<MedicationRequest> n_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, m_);
            IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(k_, n_);

            bool? p_(MedicationRequest Medications) {
                List<CodeableConcept> be_ = Medications?.Category;

                bool? bf_(CodeableConcept C) {
                    CqlConcept bi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
                    bool? bl_ = context.Operators.Equivalent(bi_, bk_);
                    return bl_;
                }

                IEnumerable<CodeableConcept> bg_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)be_, bf_);
                bool? bh_ = context.Operators.Exists<CodeableConcept>(bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(o_, p_);
            IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(i_, q_);

            bool? s_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) {
                FhirDateTime bm_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime bn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bm_);
                Period bo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bo_);
                bool? bq_ = context.Operators.In<CqlDateTime>(bn_, bp_, (string)default);
                Code<MedicationRequest.MedicationrequestStatus> br_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string bs_ = FHIRHelpers_4_0_001.Instance.ToString(context, br_);
                bool? bt_ = context.Operators.Equal(bs_, "active");
                bool? bu_ = context.Operators.And(bq_, bt_);
                Code<MedicationRequest.MedicationRequestIntent> bv_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string bw_ = FHIRHelpers_4_0_001.Instance.ToString(context, bv_);
                bool? bx_ = context.Operators.Equal(bw_, "plan");
                bool? by_ = context.Operators.And(bu_, bx_);
                return by_;
            }

            IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
            Encounter u_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;
            IEnumerable<Encounter> v_ = context.Operators.Select<MedicationRequest, Encounter>(t_, u_);
            return v_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            CqlValueSet j_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? l_(MedicationRequest Opioids) {
                FhirDateTime s_ = Opioids?.AuthoredOnElement;
                CqlDateTime t_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, s_);
                Period u_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, u_);
                bool? w_ = context.Operators.In<CqlDateTime>(t_, v_, (string)default);
                return w_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);

            object n_(MedicationRequest Opioids) {
                DataType x_ = Opioids?.Medication;
                return x_;
            }

            IEnumerable<object> o_ = context.Operators.Select<MedicationRequest, object>(m_, n_);
            IEnumerable<object> p_ = context.Operators.Distinct<object>(o_);
            int? q_ = context.Operators.Count<object>(p_);
            bool? r_ = context.Operators.GreaterOrEqual(q_, 2);
            return r_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        IEnumerable<Encounter> e_(Encounter InpatientEncounter) {
            CqlValueSet y_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> z_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? aa_(MedicationRequest OpioidsDischarge) {
                FhirDateTime ae_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime af_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ae_);
                Period ag_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ag_);
                bool? ai_ = context.Operators.In<CqlDateTime>(af_, ah_, (string)default);
                return ai_;
            }

            IEnumerable<MedicationRequest> ab_ = context.Operators.Where<MedicationRequest>(z_, aa_);
            Encounter ac_(MedicationRequest OpioidsDischarge) => InpatientEncounter;
            IEnumerable<Encounter> ad_ = context.Operators.Select<MedicationRequest, Encounter>(ab_, ac_);
            return ad_;
        }

        IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);

        IEnumerable<Encounter> g_(Encounter InpatientEncounter) {
            CqlValueSet aj_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? al_(MedicationRequest BenzodiazepinesDischarge) {
                FhirDateTime ap_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime aq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ap_);
                Period ar_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ar_);
                bool? at_ = context.Operators.In<CqlDateTime>(aq_, as_, (string)default);
                return at_;
            }

            IEnumerable<MedicationRequest> am_ = context.Operators.Where<MedicationRequest>(ak_, al_);
            Encounter an_(MedicationRequest BenzodiazepinesDischarge) => InpatientEncounter;
            IEnumerable<Encounter> ao_ = context.Operators.Select<MedicationRequest, Encounter>(am_, an_);
            return ao_;
        }

        IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(c_, h_);
        return i_;
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
                CqlInterval<CqlDateTime> ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period ad_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_);
                bool? af_ = context.Operators.Overlaps(ac_, ae_, (string)default);
                return af_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            CqlValueSet l_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

            bool? n_(ServiceRequest PalliativeOrHospiceCareOrder) {
                FhirDateTime ag_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime ah_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ag_);
                Period ai_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ai_);
                bool? ak_ = context.Operators.In<CqlDateTime>(ah_, aj_, (string)default);
                Code<RequestIntent> al_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "order");
                bool? ao_ = context.Operators.And(ak_, an_);
                return ao_;
            }

            IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
            bool? p_ = context.Operators.Exists<ServiceRequest>(o_);
            bool? q_ = context.Operators.Or(k_, p_);
            IEnumerable<Procedure> s_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? t_(Procedure PalliativeOrHospiceCarePerformed) {
                DataType ap_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ap_);
                Period ar_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ar_);
                bool? at_ = context.Operators.Overlaps(aq_, as_, (string)default);
                return at_;
            }

            IEnumerable<Procedure> u_ = context.Operators.Where<Procedure>(s_, t_);
            bool? v_ = context.Operators.Exists<Procedure>(u_);
            bool? w_ = context.Operators.Or(q_, v_);
            IEnumerable<Encounter> x_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

            bool? y_(Encounter InpatientEncounter) {
                Encounter.HospitalizationComponent au_ = InpatientEncounter?.Hospitalization;
                CodeableConcept av_ = au_?.DischargeDisposition;
                CqlConcept aw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, av_);
                CqlValueSet ax_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                CodeableConcept ba_ = au_?.DischargeDisposition;
                CqlConcept bb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ba_);
                CqlValueSet bc_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? bd_ = context.Operators.ConceptInValueSet(bb_, bc_);
                bool? be_ = context.Operators.Or(ay_, bd_);
                CodeableConcept bg_ = au_?.DischargeDisposition;
                CqlConcept bh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bg_);
                CqlValueSet bi_ = this.Patient_Expired(context);
                bool? bj_ = context.Operators.ConceptInValueSet(bh_, bi_);
                bool? bk_ = context.Operators.Or(be_, bj_);
                return bk_;
            }

            IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);
            bool? aa_ = context.Operators.Exists<Encounter>(z_);
            bool? ab_ = context.Operators.Or(w_, aa_);
            return ab_;
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
