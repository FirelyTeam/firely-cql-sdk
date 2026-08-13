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
            // CQL 'and' (31:28-32:71): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> n_ = EncounterInpatient?.StatusElement;
                string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                bool? p_ = context.Operators.Equal(o_, "finished");
                return m_ & p_;
            }
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
                IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? u_(Medication M) {
                    Id w_ = M?.IdElement;
                    string x_ = FHIRHelpers_4_0_001.Instance.ToString(context, w_);
                    object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_ as FhirString);
                    IEnumerable<string> aa_ = context.Operators.Split(z_, "/");
                    string ab_ = context.Operators.Last<string>(aa_);
                    bool? ac_ = context.Operators.Equal(x_, ab_);
                    // CQL 'and': right operand skipped when left is false
                    if (ac_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept ad_ = M?.Code;
                        CqlConcept ae_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ad_);
                        CqlValueSet af_ = this.Schedule_II__and__III_Opioid_Medications(context);
                        bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                        return ac_ & ag_;
                    }
                }

                bool? v_ = context.Operators.WhereAny<Medication>(t_, u_);
                return v_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            CqlValueSet j_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? l_(MedicationRequest MR) {
                IEnumerable<Medication> ah_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? ai_(Medication M) {
                    Id ak_ = M?.IdElement;
                    string al_ = FHIRHelpers_4_0_001.Instance.ToString(context, ak_);
                    object am_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string an_ = FHIRHelpers_4_0_001.Instance.ToString(context, am_ as FhirString);
                    IEnumerable<string> ao_ = context.Operators.Split(an_, "/");
                    string ap_ = context.Operators.Last<string>(ao_);
                    bool? aq_ = context.Operators.Equal(al_, ap_);
                    // CQL 'and': right operand skipped when left is false
                    if (aq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept ar_ = M?.Code;
                        CqlConcept as_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ar_);
                        CqlValueSet at_ = this.Schedule_IV_Benzodiazepines(context);
                        bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
                        return aq_ & au_;
                    }
                }

                bool? aj_ = context.Operators.WhereAny<Medication>(ah_, ai_);
                return aj_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(f_, l_);
            IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);

            bool? o_(MedicationRequest Medications) {
                List<CodeableConcept> av_ = Medications?.Category;

                bool? aw_(CodeableConcept C) {
                    CqlConcept ay_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                    bool? bb_ = context.Operators.Equivalent(ay_, ba_);
                    return bb_;
                }

                bool? ax_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)av_, aw_);
                return ax_;
            }

            IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);
            IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(i_, p_);

            bool? r_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) {
                FhirDateTime bc_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime bd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.In<CqlDateTime>(bd_, bf_, (string)default);
                bool? bh_;
                // CQL 'and' (51:39-52:80): right operand skipped when left is false
                if (bg_ is false)
                {
                    bh_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationrequestStatus> bi_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                    string bj_ = FHIRHelpers_4_0_001.Instance.ToString(context, bi_);
                    bool? bk_ = context.Operators.Equal(bj_, "active");
                    bh_ = bg_ & bk_;
                }
                // CQL 'and' (51:39-52:143): right operand skipped when left is false
                if (bh_ is false)
                {
                    return false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> bl_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                    string bm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bl_);
                    bool? bn_ = context.Operators.Equal(bm_, "plan");
                    return bh_ & bn_;
                }
            }

            bool? s_ = context.Operators.WhereAny<MedicationRequest>(q_, r_);
            return s_;
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
                FhirDateTime q_ = Opioids?.AuthoredOnElement;
                CqlDateTime r_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, q_);
                Period s_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, (string)default);
                return u_;
            }


            object l_(MedicationRequest Opioids) {
                DataType v_ = Opioids?.Medication;
                return v_;
            }

            IEnumerable<object> m_ = context.Operators.WhereSelect<MedicationRequest, object>(j_, k_, l_);
            IEnumerable<object> n_ = context.Operators.Distinct<object>(m_);
            int? o_ = context.Operators.Count<object>(n_);
            bool? p_ = context.Operators.GreaterOrEqual(o_, 2);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter InpatientEncounter) {
            CqlValueSet w_ = this.Schedule_II__and__III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? y_(MedicationRequest OpioidsDischarge) {
                FhirDateTime aa_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aa_);
                Period ac_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, (string)default);
                return ae_;
            }

            bool? z_ = context.Operators.WhereAny<MedicationRequest>(x_, y_);
            return z_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);

        bool? f_(Encounter InpatientEncounter) {
            CqlValueSet af_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? ah_(MedicationRequest BenzodiazepinesDischarge) {
                FhirDateTime aj_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime ak_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aj_);
                Period al_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                bool? an_ = context.Operators.In<CqlDateTime>(ak_, am_, (string)default);
                return an_;
            }

            bool? ai_ = context.Operators.WhereAny<MedicationRequest>(ag_, ah_);
            return ai_;
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
            CqlValueSet f_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? h_(Condition Cancer) {
                CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period m_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(l_, n_, (string)default);
                return o_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            bool? j_;
            // CQL 'or' (73:33-80:29): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                CqlValueSet p_ = this.Palliative_or_Hospice_Care(context);
                IEnumerable<ServiceRequest> q_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

                bool? r_(ServiceRequest PalliativeOrHospiceCareOrder) {
                    FhirDateTime t_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                    CqlDateTime u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_);
                    Period v_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, v_);
                    bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, (string)default);
                    // CQL 'and' (78:33-79:81): right operand skipped when left is false
                    if (x_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<RequestIntent> y_ = PalliativeOrHospiceCareOrder?.IntentElement;
                        string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
                        bool? aa_ = context.Operators.Equal(z_, "order");
                        return x_ & aa_;
                    }
                }

                bool? s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
                j_ = i_ | s_;
            }
            bool? k_;
            // CQL 'or' (73:33-83:29): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
                CqlValueSet ab_ = this.Palliative_or_Hospice_Care(context);
                IEnumerable<Procedure> ac_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

                bool? ad_(Procedure PalliativeOrHospiceCarePerformed) {
                    DataType af_ = PalliativeOrHospiceCarePerformed?.Performed;
                    CqlInterval<CqlDateTime> ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, af_);
                    Period ah_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                    bool? aj_ = context.Operators.Overlaps(ag_, ai_, (string)default);
                    return aj_;
                }

                bool? ae_ = context.Operators.WhereAny<Procedure>(ac_, ad_);
                k_ = j_ | ae_;
            }
            // CQL 'or' (73:27-88:29): right operand skipped when left is true
            if (k_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Encounter> ak_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

                bool? al_(Encounter InpatientEncounter) {
                    Encounter.HospitalizationComponent an_ = InpatientEncounter?.Hospitalization;
                    CodeableConcept ao_ = an_?.DischargeDisposition;
                    CqlConcept ap_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ao_);
                    CqlValueSet aq_ = this.Discharge_To_Acute_Care_Facility(context);
                    bool? ar_ = context.Operators.ConceptInValueSet(ap_, aq_);
                    bool? as_;
                    // CQL 'or' (85:39-86:132): right operand skipped when left is true
                    if (ar_ is true)
                    {
                        as_ = true;
                    }
                    else
                    {
                        Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
                        CodeableConcept au_ = at_?.DischargeDisposition;
                        CqlConcept av_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, au_);
                        CqlValueSet aw_ = this.Hospice_Care_Referral_or_Admission(context);
                        bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                        as_ = ar_ | ax_;
                    }
                    // CQL 'or' (85:33-87:113): right operand skipped when left is true
                    if (as_ is true)
                    {
                        return true;
                    }
                    else
                    {
                        Encounter.HospitalizationComponent ay_ = InpatientEncounter?.Hospitalization;
                        CodeableConcept az_ = ay_?.DischargeDisposition;
                        CqlConcept ba_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, az_);
                        CqlValueSet bb_ = this.Patient_Expired(context);
                        bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                        return as_ | bc_;
                    }
                }

                bool? am_ = context.Operators.WhereAny<Encounter>(ak_, al_);
                return k_ | am_;
            }
        }

        Encounter c_(Encounter InpatientEncounter) => InpatientEncounter;
        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<Encounter, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
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
