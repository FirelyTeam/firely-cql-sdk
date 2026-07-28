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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.0.006")]
public partial class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006 : ILibrary, ISingleton<HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006>
{
    #region ValueSets (5)

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlValueSetDefinition("Hypoglycemics Treatment Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext _) => _Hypoglycemics_Treatment_Medications;
    private static readonly CqlValueSet _Hypoglycemics_Treatment_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

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

    private const long _cacheIndex_Measurement_Period = 7229425209739707094L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7064636126919639898L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3665060999434607160L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -6483302258536386303L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 5851744314889379873L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4575297161029434069L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_During_Measurement_Period, Inpatient_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Inpatient_Encounter_During_Measurement_Period = 1514258567180264524L;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 1141502000733248456L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter InpatientEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime i_ = context.Operators.Start(h_);
            int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
            bool? k_ = context.Operators.GreaterOrEqual(j_, 18);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters_With_Hospitalization_Period, Qualifying_Encounters_With_Hospitalization_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounters_With_Hospitalization_Period = -4834500073043937916L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? b_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? f_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, e_);
            return f_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters_With_Existing_Diabetes_Diagnosis, Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Compute);

    private const long _cacheIndex_Qualifying_Encounters_With_Existing_Diabetes_Diagnosis = -5618647880876658695L;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization) {
            CqlValueSet g_ = this.Diabetes(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? i_(Condition DiabetesDiagnosis) {
                CodeableConcept l_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l_);
                CqlCode n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                CqlInterval<CqlDateTime> q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime t_ = context.Operators.End(s_);
                bool? u_ = context.Operators.Before(r_, t_, (string)default);
                bool? v_ = context.Operators.And(p_, u_);
                return v_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization) {
            Encounter w_ = EncounterWithHospitalization?.encounter;
            return w_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters_With_Hypoglycemic_Medication, Qualifying_Encounters_With_Hypoglycemic_Medication_Compute);

    private const long _cacheIndex_Qualifying_Encounters_With_Hypoglycemic_Medication = 6975104613581080996L;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet b_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));

        bool? e_(MedicationAdministration MR) {
            IEnumerable<Medication> p_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? q_(Medication M) {
                Id t_ = M?.IdElement;
                string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
                object v_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string w_ = FHIRHelpers_4_0_001.Instance.ToString(context, v_ as FhirString);
                IEnumerable<string> x_ = context.Operators.Split(w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                bool? z_ = context.Operators.Equal(u_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Hypoglycemics_Treatment_Medications(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
            }

            IEnumerable<Medication> r_ = context.Operators.Where<Medication>(p_, q_);
            bool? s_ = context.Operators.Exists<Medication>(r_);
            return s_;
        }

        IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> h_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? i_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? af_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> j_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(h_, i_);

        bool? k_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ag_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string ah_ = FHIRHelpers_4_0_001.Instance.ToString(context, ag_);
            bool? ai_ = context.Operators.Equal(ah_, "completed");
            CqlInterval<CqlDateTime> aj_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType ak_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ak_);
            bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aj_, al_, (string)default);
            bool? an_ = context.Operators.And(ai_, am_);
            return an_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> l_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(j_, k_);

        Encounter m_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb) {
            Encounter ao_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;
            return ao_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        return o_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab, Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Compute);

    private const long _cacheIndex_Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab = -683012518414920298L;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization) {
            CqlValueSet g_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            bool? i_(Observation BloodGlucoseLab) {
                DataType l_ = BloodGlucoseLab?.Effective;
                CqlDateTime m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, l_ as FhirDateTime);
                CqlInterval<CqlDateTime> n_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);
                Code<ObservationStatus> p_ = BloodGlucoseLab?.StatusElement;
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                bool? r_ = context.Operators.Equal(q_, "final");
                bool? s_ = context.Operators.And(o_, r_);
                DataType t_ = BloodGlucoseLab?.Value;
                CqlQuantity u_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, t_ as Quantity);
                CqlQuantity v_ = context.Operators.Quantity(200m, "mg/dL");
                bool? w_ = context.Operators.GreaterOrEqual(u_, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            bool? k_ = context.Operators.Exists<Observation>(j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization) {
            Encounter y_ = EncounterWithHospitalization?.encounter;
            return y_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8241298423647171943L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 4368623145748242140L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlFunctionDefinition("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        CqlQuantity c_ = context.Operators.Quantity(10m, "days");
        CqlDateTime d_ = context.Operators.Add(a_, c_);
        CqlDateTime[] e_ = [
            b_,
            d_,
        ];
        CqlDateTime f_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)e_);
        CqlInterval<CqlDateTime> g_ = context.Operators.Interval(a_, f_, true, true);
        return g_;
    }


    [CqlFunctionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);

        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex) {
            CqlDateTime e_ = context.Operators.Start(Period);
            CqlQuantity f_ = context.Operators.Quantity(24m, "hours");
            int? g_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity h_ = context.Operators.ConvertIntegerToQuantity(g_);
            CqlQuantity i_ = context.Operators.Multiply(f_, h_);
            CqlDateTime j_ = context.Operators.Add(e_, i_);

            CqlDateTime k_() {

                bool n_() {
                    CqlDateTime o_ = context.Operators.Start(Period);
                    CqlQuantity p_ = context.Operators.Quantity(24m, "hours");
                    int? q_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity r_ = context.Operators.ConvertIntegerToQuantity(q_);
                    CqlQuantity s_ = context.Operators.Multiply(p_, r_);
                    CqlDateTime t_ = context.Operators.Add(o_, s_);
                    CqlDateTime u_ = context.Operators.End(Period);
                    int? v_ = context.Operators.DurationBetween(t_, u_, "hour");
                    bool? w_ = context.Operators.Less(v_, 24);
                    return w_ ?? false;
                }

                if (n_())
                {
                    CqlDateTime x_ = context.Operators.Start(Period);
                    CqlQuantity y_ = context.Operators.Quantity(24m, "hours");
                    int? z_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity aa_ = context.Operators.ConvertIntegerToQuantity(z_);
                    CqlQuantity ab_ = context.Operators.Multiply(y_, aa_);
                    CqlDateTime ac_ = context.Operators.Add(x_, ab_);
                    return ac_;
                }
                else
                {
                    CqlDateTime ad_ = context.Operators.Start(Period);
                    CqlQuantity ae_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity af_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity ag_ = context.Operators.Multiply(ae_, af_);
                    CqlDateTime ah_ = context.Operators.Add(ad_, ag_);
                    return ah_;
                }
            }

            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(j_, k_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? m_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((IEnumerable<CqlInterval<int?>>)e_, (CqlQuantity)default);

        int? g_(CqlInterval<int?> DayExpand) {
            int? j_ = context.Operators.End(DayExpand);
            return j_;
        }

        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);
        IEnumerable<int?> i_ = context.Operators.Distinct<int?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pertinent_Encounters_With_Days, Pertinent_Encounters_With_Days_Compute);

    private const long _cacheIndex_Pertinent_Encounters_With_Days = -9104963593437595L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? b_(Encounter PertinentEncounter) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> f_ = this.Crop_Interval_to_10_Days(context, e_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> g_ = this.Days_In_Period(context, f_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? h_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, e_, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pertinent_Encounters_With_Glucose_Result_Days, Pertinent_Encounters_With_Glucose_Result_Days_Compute);

    private const long _cacheIndex_Pertinent_Encounters_With_Glucose_Result_Days = 9202032992156266560L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> a_ = this.Pertinent_Encounters_With_Days(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays) {
            Encounter e_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> f_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> g_ = PertinentEncounterDays?.relevantDays;

            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? h_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay) {
                int? l_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> m_ = EncounterDay?.dayPeriod;
                CqlValueSet n_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

                bool? p_(Observation BloodGlucoseLab1) {
                    Code<ObservationStatus> aa_ = BloodGlucoseLab1?.StatusElement;
                    string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
                    bool? ac_ = context.Operators.Equal(ab_, "final");
                    DataType ad_ = BloodGlucoseLab1?.Value;
                    CqlQuantity ae_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ad_ as Quantity);
                    CqlQuantity af_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? ag_ = context.Operators.Greater(ae_, af_);
                    bool? ah_ = context.Operators.And(ac_, ag_);
                    DataType ai_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime aj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ai_ as FhirDateTime);
                    CqlInterval<CqlDateTime> ak_ = EncounterDay?.dayPeriod;
                    bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, (string)default);
                    bool? am_ = context.Operators.And(ah_, al_);
                    return am_;
                }

                IEnumerable<Observation> q_ = context.Operators.Where<Observation>(o_, p_);
                bool? r_ = context.Operators.Exists<Observation>(q_);

                bool? s_(Observation BloodGlucoseLab2) {
                    Code<ObservationStatus> an_ = BloodGlucoseLab2?.StatusElement;
                    string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_);
                    bool? ap_ = context.Operators.Equal(ao_, "final");
                    DataType aq_ = BloodGlucoseLab2?.Value;
                    CqlQuantity ar_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aq_ as Quantity);
                    CqlQuantity as_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? at_ = context.Operators.GreaterOrEqual(ar_, as_);
                    bool? au_ = context.Operators.And(ap_, at_);
                    DataType av_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime aw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, av_ as FhirDateTime);
                    CqlInterval<CqlDateTime> ax_ = EncounterDay?.dayPeriod;
                    bool? ay_ = context.Operators.In<CqlDateTime>(aw_, ax_, (string)default);
                    bool? az_ = context.Operators.And(au_, ay_);
                    return az_;
                }

                IEnumerable<Observation> t_ = context.Operators.Where<Observation>(o_, s_);
                bool? u_ = context.Operators.Exists<Observation>(t_);

                bool? v_(Observation BloodGlucoseLab3) {
                    Code<ObservationStatus> ba_ = BloodGlucoseLab3?.StatusElement;
                    string bb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ba_);
                    bool? bc_ = context.Operators.Equal(bb_, "final");
                    DataType bd_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime be_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bd_ as FhirDateTime);
                    CqlInterval<CqlDateTime> bf_ = EncounterDay?.dayPeriod;
                    bool? bg_ = context.Operators.In<CqlDateTime>(be_, bf_, (string)default);
                    bool? bh_ = context.Operators.And(bc_, bg_);
                    return bh_;
                }

                IEnumerable<Observation> w_ = context.Operators.Where<Observation>(o_, v_);
                bool? x_ = context.Operators.Exists<Observation>(w_);
                bool? y_ = context.Operators.Not(x_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? z_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, l_, m_, r_, u_, y_);
                return z_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> i_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(g_, h_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? k_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, e_, f_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pertinent_Encounters_With_Hyperglycemic_Event_Days, Pertinent_Encounters_With_Hyperglycemic_Event_Days_Compute);

    private const long _cacheIndex_Pertinent_Encounters_With_Hyperglycemic_Event_Days = -8343402975753121456L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> a_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays) {
            Encounter e_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> f_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> g_ = EncounterWithResultDays?.relevantDays;

            bool? h_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay) {
                int? n_ = EncounterDay?.dayIndex;
                bool? o_ = context.Operators.Greater(n_, 1);
                return o_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> i_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(g_, h_);

            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? j_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay) {
                int? p_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> q_ = EncounterDay?.dayPeriod;
                bool? r_ = EncounterDay?.hasSevereResult;
                bool? s_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> t_ = EncounterWithResultDays?.relevantDays;
                int? u_ = context.Operators.Subtract(p_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? v_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(t_, u_);
                bool? w_ = v_?.hasElevatedResult;
                bool? x_ = context.Operators.And(s_, w_);
                int? y_ = context.Operators.Subtract(p_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? z_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(t_, y_);
                bool? aa_ = z_?.hasElevatedResult;
                bool? ab_ = context.Operators.And(x_, aa_);
                bool? ac_ = context.Operators.Or(r_, ab_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? ad_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, p_, q_, ac_);
                return ad_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> k_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(k_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? m_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, e_, f_, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3908218439360313143L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> g_ = EncounterWithEventDays?.eligibleEventDays;

            bool? h_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                bool? k_ = EligibleEventDay?.hasHyperglycemicEvent;
                return k_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> i_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(g_, h_);
            bool? j_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            Encounter l_ = EncounterWithEventDays?.encounter;
            return l_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            Encounter h_ = EncounterWithEventDays?.encounter;
            bool? i_ = context.Operators.Equal(h_, QualifyingEncounter);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

        int? d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> j_ = EncounterWithEventDays?.eligibleEventDays;
            int? k_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(j_);
            return k_;
        }

        IEnumerable<int?> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(c_, d_);
        IEnumerable<int?> f_ = context.Operators.Distinct<int?>(e_);
        int? g_ = context.Operators.SingletonFrom<int?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            Encounter h_ = EncounterWithEventDays?.encounter;
            bool? i_ = context.Operators.Equal(h_, QualifyingEncounter);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

        int? d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> j_ = EncounterWithEventDays?.eligibleEventDays;

            bool? k_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                bool? n_ = EligibleEventDay?.hasHyperglycemicEvent;
                return n_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> l_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(j_, k_);
            int? m_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(l_);
            return m_;
        }

        IEnumerable<int?> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(c_, d_);
        IEnumerable<int?> f_ = context.Operators.Distinct<int?>(e_);
        int? g_ = context.Operators.SingletonFrom<int?>(f_);
        return g_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006() {}

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR";
    public string Version => "0.0.006";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>)],
       ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB = new(
       [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
       ["EncounterWithHospitalization", "HypoglycemicMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
       ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
       ["dayIndex", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoResult"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
       ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
       ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>)],
       ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
       ["encounter", "hospitalizationPeriod"]);

    #endregion CqlTupleMetadata Properties

}
