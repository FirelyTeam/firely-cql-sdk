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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.0.0")]
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
                IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? u_(Medication M) {
                    Id w_ = M?.IdElement;
                    string x_ = FHIRHelpers_4_0_001.Instance.ToString(context, w_);
                    object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_ as FhirString);
                    IEnumerable<string> aa_ = context.Operators.Split(z_, "/");
                    string ab_ = context.Operators.Last<string>(aa_);
                    bool? ac_ = context.Operators.Equal(x_, ab_);
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Schedule_II__and__III_Opioid_Medications(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    bool? ah_ = context.Operators.And(ac_, ag_);
                    return ah_;
                }

                bool? v_ = context.Operators.WhereAny<Medication>(t_, u_);
                return v_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            CqlValueSet j_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

            bool? l_(MedicationRequest MR) {
                IEnumerable<Medication> ai_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                bool? aj_(Medication M) {
                    Id al_ = M?.IdElement;
                    string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                    object an_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                    string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_ as FhirString);
                    IEnumerable<string> ap_ = context.Operators.Split(ao_, "/");
                    string aq_ = context.Operators.Last<string>(ap_);
                    bool? ar_ = context.Operators.Equal(am_, aq_);
                    CodeableConcept as_ = M?.Code;
                    CqlConcept at_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, as_);
                    CqlValueSet au_ = this.Schedule_IV_Benzodiazepines(context);
                    bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                    bool? aw_ = context.Operators.And(ar_, av_);
                    return aw_;
                }

                bool? ak_ = context.Operators.WhereAny<Medication>(ai_, aj_);
                return ak_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(f_, l_);
            IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);

            bool? o_(MedicationRequest Medications) {
                List<CodeableConcept> ax_ = Medications?.Category;

                bool? ay_(CodeableConcept C) {
                    CqlConcept ba_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                    bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                    return bd_;
                }

                bool? az_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)ax_, ay_);
                return az_;
            }

            IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);
            IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(i_, p_);

            bool? r_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) {
                FhirDateTime be_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime bf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, be_);
                Period bg_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(bf_, bh_, (string)default);
                Code<MedicationRequest.MedicationrequestStatus> bj_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string bk_ = FHIRHelpers_4_0_001.Instance.ToString(context, bj_);
                bool? bl_ = context.Operators.Equal(bk_, "active");
                bool? bm_ = context.Operators.And(bi_, bl_);
                Code<MedicationRequest.MedicationRequestIntent> bn_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string bo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bn_);
                bool? bp_ = context.Operators.Equal(bo_, "plan");
                bool? bq_ = context.Operators.And(bm_, bp_);
                return bq_;
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
                CqlInterval<CqlDateTime> w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period x_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.Overlaps(w_, y_, (string)default);
                return z_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            CqlValueSet j_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> k_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

            bool? l_(ServiceRequest PalliativeOrHospiceCareOrder) {
                FhirDateTime aa_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aa_);
                Period ac_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, (string)default);
                Code<RequestIntent> af_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                bool? ah_ = context.Operators.Equal(ag_, "order");
                bool? ai_ = context.Operators.And(ae_, ah_);
                return ai_;
            }

            bool? m_ = context.Operators.WhereAny<ServiceRequest>(k_, l_);
            bool? n_ = context.Operators.Or(i_, m_);
            IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? p_(Procedure PalliativeOrHospiceCarePerformed) {
                DataType aj_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_);
                Period al_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                bool? an_ = context.Operators.Overlaps(ak_, am_, (string)default);
                return an_;
            }

            bool? q_ = context.Operators.WhereAny<Procedure>(o_, p_);
            bool? r_ = context.Operators.Or(n_, q_);
            IEnumerable<Encounter> s_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);

            bool? t_(Encounter InpatientEncounter) {
                Encounter.HospitalizationComponent ao_ = InpatientEncounter?.Hospitalization;
                CodeableConcept ap_ = ao_?.DischargeDisposition;
                CqlConcept aq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ap_);
                CqlValueSet ar_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                CqlValueSet at_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? au_ = context.Operators.ConceptInValueSet(aq_, at_);
                bool? av_ = context.Operators.Or(as_, au_);
                CqlValueSet aw_ = this.Patient_Expired(context);
                bool? ax_ = context.Operators.ConceptInValueSet(aq_, aw_);
                bool? ay_ = context.Operators.Or(av_, ax_);
                return ay_;
            }

            bool? u_ = context.Operators.WhereAny<Encounter>(s_, t_);
            bool? v_ = context.Operators.Or(r_, u_);
            return v_;
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
