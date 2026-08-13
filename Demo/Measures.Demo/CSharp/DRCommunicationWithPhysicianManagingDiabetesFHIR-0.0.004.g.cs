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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 : ILibrary, ISingleton<DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004>
{
    #region ValueSets (11)

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Level of Severity of Retinopathy Findings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", valueSetVersion: null)]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext _) => _Level_of_Severity_of_Retinopathy_Findings;
    private static readonly CqlValueSet _Level_of_Severity_of_Retinopathy_Findings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlValueSetDefinition("Macular Edema Findings Present", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Present(CqlContext _) => _Macular_Edema_Findings_Present;
    private static readonly CqlValueSet _Macular_Edema_Findings_Present = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlValueSetDefinition("Macular Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", valueSetVersion: null)]
    public CqlValueSet Macular_Exam(CqlContext _) => _Macular_Exam;
    private static readonly CqlValueSet _Macular_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    #endregion ValueSets

    #region Codes (7)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct");

    [CqlCodeDefinition("Macular edema absent (situation)", codeId: "428341000124108", codeSystem: "http://snomed.info/sct")]
    public CqlCode Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlCode _Macular_edema_absent__situation_ = new CqlCode("428341000124108", "http://snomed.info/sct");

    [CqlCodeDefinition("Medical practitioner (occupation)", codeId: "158965000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Medical_practitioner__occupation_(CqlContext _) => _Medical_practitioner__occupation_;
    private static readonly CqlCode _Medical_practitioner__occupation_ = new CqlCode("158965000", "http://snomed.info/sct");

    [CqlCodeDefinition("Ophthalmologist (occupation)", codeId: "422234006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Ophthalmologist__occupation_(CqlContext _) => _Ophthalmologist__occupation_;
    private static readonly CqlCode _Ophthalmologist__occupation_ = new CqlCode("422234006", "http://snomed.info/sct");

    [CqlCodeDefinition("Optometrist (occupation)", codeId: "28229004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Optometrist__occupation_(CqlContext _) => _Optometrist__occupation_;
    private static readonly CqlCode _Optometrist__occupation_ = new CqlCode("28229004", "http://snomed.info/sct");

    [CqlCodeDefinition("Physician (occupation)", codeId: "309343006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Physician__occupation_(CqlContext _) => _Physician__occupation_;
    private static readonly CqlCode _Physician__occupation_ = new CqlCode("309343006", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Healthcare_professional__occupation_,
          _Macular_edema_absent__situation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 2299050010152453010L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (21)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -2934060612400956580L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6149379624920616075L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 2973477727710290925L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1854590241274919068L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1804008870246239687L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Measurement_Period, Qualifying_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Measurement_Period = -7238938956640270872L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);

        bool? o_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, (string)default);
            // CQL 'and' (79:11-80:57): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                bool? w_ = context.Operators.Equal(v_, "finished");
                return t_ & w_;
            }
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Diabetic_Retinopathy_Encounter, Diabetic_Retinopathy_Encounter_Compute);

    private const long _cacheIndex_Diabetic_Retinopathy_Encounter = -4682493263808070969L;

    private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter ValidQualifyingEncounter) {
            CqlValueSet d_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? f_(Condition DiabeticRetinopathy) {
                CodeableConcept h_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, h_);
                CqlCode j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                // CQL 'and' (70:23-71:106): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                    Period n_ = ValidQualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
                    bool? p_ = context.Operators.Overlaps(m_, o_, (string)default);
                    return l_ & p_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetModifierExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);
        return b_;
    }


    [CqlFunctionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.ModifierExtension;

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


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy, Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy = -4896089256406335881L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? d_(Communication LevelOfSeverityNotCommunicated) {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? i_(Encounter EncounterDiabeticRetinopathy) {
                CqlDateTime k_;
                Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType p_ = o_?.Value;
                bool q_ = p_ is FhirDateTime;
                if (q_)
                {
                    Extension r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                    DataType s_ = r_?.Value;
                    CqlDateTime t_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, s_ as FhirDateTime);
                    k_ = t_;
                }
                else
                {
                    Extension u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                    DataType v_ = u_?.Value;
                    bool w_ = v_ is Instant;
                    if (w_)
                    {
                        Extension x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                        DataType y_ = x_?.Value;
                        CqlDateTime z_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, y_ as Instant);
                        k_ = z_;
                    }
                    else
                    {
                        k_ = default;
                    }
                }
                Period l_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, (string)default);
                return n_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Communication> e_ = context.Operators.Where<Communication>(c_, d_);

        bool? f_(Communication LevelOfSeverityNotCommunicated) {
            Code<EventStatus> aa_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
            bool? ac_ = context.Operators.Equal(ab_, "not-done");
            bool? ad_;
            // CQL 'and' (109:11-110:96): right operand skipped when left is false
            if (ac_ is false)
            {
                ad_ = false;
            }
            else
            {
                Extension ae_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
                DataType af_ = ae_?.Value;
                bool? ag_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, af_ as FhirBoolean);
                bool? ah_ = context.Operators.IsTrue(ag_);
                ad_ = ac_ & ah_;
            }
            // CQL 'and' (109:5-113:7): right operand skipped when left is false
            if (ad_ is false)
            {
                return false;
            }
            else
            {
                CodeableConcept ai_ = LevelOfSeverityNotCommunicated?.StatusReason;
                CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                CqlValueSet ak_ = this.Medical_Reason(context);
                bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                bool? am_;
                // CQL 'or' (111:11-113:7): right operand skipped when left is true
                if (al_ is true)
                {
                    am_ = true;
                }
                else
                {
                    CodeableConcept an_ = LevelOfSeverityNotCommunicated?.StatusReason;
                    CqlConcept ao_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, an_);
                    CqlValueSet ap_ = this.Patient_Reason(context);
                    bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
                    am_ = al_ | aq_;
                }
                return ad_ & am_;
            }
        }

        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema, Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema = -3194015953203176546L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlCode b_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Communication> d_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? e_(Communication MacularEdemaAbsentNotCommunicated) {
            IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? j_(Encounter EncounterDiabeticRetinopathy) {
                CqlDateTime l_;
                Extension p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType q_ = p_?.Value;
                bool r_ = q_ is FhirDateTime;
                if (r_)
                {
                    Extension s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                    DataType t_ = s_?.Value;
                    CqlDateTime u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_ as FhirDateTime);
                    l_ = u_;
                }
                else
                {
                    Extension v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                    DataType w_ = v_?.Value;
                    bool x_ = w_ is Instant;
                    if (x_)
                    {
                        Extension y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                        DataType z_ = y_?.Value;
                        CqlDateTime aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, z_ as Instant);
                        l_ = aa_;
                    }
                    else
                    {
                        l_ = default;
                    }
                }
                Period m_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, (string)default);
                return o_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        bool? g_(Communication MacularEdemaAbsentNotCommunicated) {
            Code<EventStatus> ab_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
            bool? ad_ = context.Operators.Equal(ac_, "not-done");
            bool? ae_;
            // CQL 'and' (99:11-100:99): right operand skipped when left is false
            if (ad_ is false)
            {
                ae_ = false;
            }
            else
            {
                Extension af_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
                DataType ag_ = af_?.Value;
                bool? ah_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ag_ as FhirBoolean);
                bool? ai_ = context.Operators.IsTrue(ah_);
                ae_ = ad_ & ai_;
            }
            // CQL 'and' (99:5-103:7): right operand skipped when left is false
            if (ae_ is false)
            {
                return false;
            }
            else
            {
                CodeableConcept aj_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
                CqlConcept ak_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aj_);
                CqlValueSet al_ = this.Medical_Reason(context);
                bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                bool? an_;
                // CQL 'or' (101:11-103:7): right operand skipped when left is true
                if (am_ is true)
                {
                    an_ = true;
                }
                else
                {
                    CodeableConcept ao_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
                    CqlConcept ap_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ao_);
                    CqlValueSet aq_ = this.Patient_Reason(context);
                    bool? ar_ = context.Operators.ConceptInValueSet(ap_, aq_);
                    an_ = am_ | ar_;
                }
                return ae_ & an_;
            }
        }

        IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema, Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema = 2568311099187060350L;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? d_(Communication MacularEdemaPresentNotCommunicated) {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? i_(Encounter EncounterDiabeticRetinopathy) {
                CqlDateTime k_;
                Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType p_ = o_?.Value;
                bool q_ = p_ is FhirDateTime;
                if (q_)
                {
                    Extension r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                    DataType s_ = r_?.Value;
                    CqlDateTime t_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, s_ as FhirDateTime);
                    k_ = t_;
                }
                else
                {
                    Extension u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                    DataType v_ = u_?.Value;
                    bool w_ = v_ is Instant;
                    if (w_)
                    {
                        Extension x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                        DataType y_ = x_?.Value;
                        CqlDateTime z_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, y_ as Instant);
                        k_ = z_;
                    }
                    else
                    {
                        k_ = default;
                    }
                }
                Period l_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, (string)default);
                return n_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Communication> e_ = context.Operators.Where<Communication>(c_, d_);

        bool? f_(Communication MacularEdemaPresentNotCommunicated) {
            Code<EventStatus> aa_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
            bool? ac_ = context.Operators.Equal(ab_, "not-done");
            bool? ad_;
            // CQL 'and' (119:11-120:100): right operand skipped when left is false
            if (ac_ is false)
            {
                ad_ = false;
            }
            else
            {
                Extension ae_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
                DataType af_ = ae_?.Value;
                bool? ag_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, af_ as FhirBoolean);
                bool? ah_ = context.Operators.IsTrue(ag_);
                ad_ = ac_ & ah_;
            }
            // CQL 'and' (119:5-123:7): right operand skipped when left is false
            if (ad_ is false)
            {
                return false;
            }
            else
            {
                CodeableConcept ai_ = MacularEdemaPresentNotCommunicated?.StatusReason;
                CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                CqlValueSet ak_ = this.Medical_Reason(context);
                bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                bool? am_;
                // CQL 'or' (121:11-123:7): right operand skipped when left is true
                if (al_ is true)
                {
                    am_ = true;
                }
                else
                {
                    CodeableConcept an_ = MacularEdemaPresentNotCommunicated?.StatusReason;
                    CqlConcept ao_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, an_);
                    CqlValueSet ap_ = this.Patient_Reason(context);
                    bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
                    am_ = al_ | aq_;
                }
                return ad_ & am_;
            }
        }

        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -6954175433017395973L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        bool? c_;
        // CQL 'or' (49:3-50:94): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Communication> d_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
            bool? e_ = context.Operators.Exists<Communication>(d_);
            c_ = b_ | e_;
        }
        // CQL 'or' (49:3-51:95): right operand skipped when left is true
        if (c_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Communication> f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
            bool? g_ = context.Operators.Exists<Communication>(f_);
            return c_ | g_;
        }
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 6971120082248542534L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
        bool? h_ = context.Operators.GreaterOrEqual(g_, 18);
        // CQL 'and' (64:3-65:53): right operand skipped when left is false
        if (h_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return h_ & j_;
        }
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Exam_Performed, Macular_Exam_Performed_Compute);

    private const long _cacheIndex_Macular_Exam_Performed = 6692052034929260966L;

    private IEnumerable<Observation> Macular_Exam_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation MacularExam) {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? h_(Encounter EncounterDiabeticRetinopathy) {
                Period j_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, j_);
                DataType l_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, (string)default);
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        bool? e_(Observation MacularExam) {
            Code<ObservationStatus> o_ = MacularExam?.StatusElement;
            string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_);
            string[] q_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            // CQL 'and' (92:11-93:47): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                DataType s_ = MacularExam?.Value;
                return r_ & (!((bool?)(s_ is null)));
            }
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3149268625791439418L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        // CQL 'and' (54:3-55:45): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Observation> b_ = this.Macular_Exam_Performed(context);
            bool? c_ = context.Operators.Exists<Observation>(b_);
            return a_ & c_;
        }
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Level_of_Severity_of_Retinopathy_Findings_Communicated, Level_of_Severity_of_Retinopathy_Findings_Communicated_Compute);

    private const long _cacheIndex_Level_of_Severity_of_Retinopathy_Findings_Communicated = 8122295655089432951L;

    private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? d_(Communication LevelOfSeverityCommunicated) {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? i_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime k_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime l_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, k_);
                Period m_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(l_, o_, (string)default);
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Communication> e_ = context.Operators.Where<Communication>(c_, d_);

        bool? f_(Communication LevelOfSeverityCommunicated) {
            Code<EventStatus> q_ = LevelOfSeverityCommunicated?.StatusElement;
            string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
            bool? s_ = context.Operators.Equal(r_, "completed");
            return s_;
        }

        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Edema_Absence_Communicated, Macular_Edema_Absence_Communicated_Compute);

    private const long _cacheIndex_Macular_Edema_Absence_Communicated = -7171052550869229836L;

    private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlCode b_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Communication> d_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? e_(Communication MacularEdemaAbsentCommunicated) {
            IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? j_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime l_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, (string)default);
                return q_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        bool? g_(Communication MacularEdemaAbsentCommunicated) {
            Code<EventStatus> r_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
            bool? t_ = context.Operators.Equal(s_, "completed");
            return t_;
        }

        IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Macular_Edema_Presence_Communicated, Macular_Edema_Presence_Communicated_Compute);

    private const long _cacheIndex_Macular_Edema_Presence_Communicated = -1727020035896491417L;

    private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Communication)).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));

        bool? d_(Communication MacularEdemaPresentCommunicated) {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);

            bool? i_(Encounter EncounterDiabeticRetinopathy) {
                FhirDateTime k_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime l_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, k_);
                Period m_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(l_, o_, (string)default);
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Communication> e_ = context.Operators.Where<Communication>(c_, d_);

        bool? f_(Communication MacularEdemaPresentCommunicated) {
            Code<EventStatus> q_ = MacularEdemaPresentCommunicated?.StatusElement;
            string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
            bool? s_ = context.Operators.Equal(r_, "completed");
            return s_;
        }

        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Results_of_Dilated_Macular_or_Fundus_Exam_Communicated, Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Compute);

    private const long _cacheIndex_Results_of_Dilated_Macular_or_Fundus_Exam_Communicated = 5948642944193482956L;

    private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        // CQL 'and' (58:3-61:11): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
            bool? d_ = context.Operators.Exists<Communication>(c_);
            bool? e_;
            // CQL 'or' (59:15-61:11): right operand skipped when left is true
            if (d_ is true)
            {
                e_ = true;
            }
            else
            {
                IEnumerable<Communication> f_ = this.Macular_Edema_Presence_Communicated(context);
                bool? g_ = context.Operators.Exists<Communication>(f_);
                e_ = d_ | g_;
            }
            return b_ & e_;
        }
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -8004091241498353870L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        // CQL 'and' (83:3-86:11): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
            bool? d_ = context.Operators.Exists<Communication>(c_);
            bool? e_;
            // CQL 'or' (84:15-86:11): right operand skipped when left is true
            if (d_ is true)
            {
                e_ = true;
            }
            else
            {
                IEnumerable<Communication> f_ = this.Macular_Edema_Presence_Communicated(context);
                bool? g_ = context.Operators.Exists<Communication>(f_);
                e_ = d_ | g_;
            }
            return b_ & e_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DRCommunicationWithPhysicianManagingDiabetesFHIR";
    public string Version => "0.0.004";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

}
