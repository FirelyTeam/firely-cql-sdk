using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Diabetic_Retinopathy;
    internal Lazy<CqlValueSet> __Level_of_Severity_of_Retinopathy_Findings;
    internal Lazy<CqlValueSet> __Macular_Edema_Findings_Present;
    internal Lazy<CqlValueSet> __Macular_Exam;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Patient_Reason;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Healthcare_professional__occupation_;
    internal Lazy<CqlCode> __Macular_edema_absent__situation_;
    internal Lazy<CqlCode> __Medical_practitioner__occupation_;
    internal Lazy<CqlCode> __Ophthalmologist__occupation_;
    internal Lazy<CqlCode> __Optometrist__occupation_;
    internal Lazy<CqlCode> __Physician__occupation_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Diabetic_Retinopathy_Encounter;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<IEnumerable<Observation>> __Macular_Exam_Performed;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Communication>> __Level_of_Severity_of_Retinopathy_Findings_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Absence_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Presence_Communicated;
    internal Lazy<bool?> __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated;
    internal Lazy<bool?> __Numerator;

    #endregion
    public DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Diabetic_Retinopathy = new Lazy<CqlValueSet>(this.Diabetic_Retinopathy_Value);
        __Level_of_Severity_of_Retinopathy_Findings = new Lazy<CqlValueSet>(this.Level_of_Severity_of_Retinopathy_Findings_Value);
        __Macular_Edema_Findings_Present = new Lazy<CqlValueSet>(this.Macular_Edema_Findings_Present_Value);
        __Macular_Exam = new Lazy<CqlValueSet>(this.Macular_Exam_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Patient_Reason = new Lazy<CqlValueSet>(this.Patient_Reason_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Healthcare_professional__occupation_ = new Lazy<CqlCode>(this.Healthcare_professional__occupation__Value);
        __Macular_edema_absent__situation_ = new Lazy<CqlCode>(this.Macular_edema_absent__situation__Value);
        __Medical_practitioner__occupation_ = new Lazy<CqlCode>(this.Medical_practitioner__occupation__Value);
        __Ophthalmologist__occupation_ = new Lazy<CqlCode>(this.Ophthalmologist__occupation__Value);
        __Optometrist__occupation_ = new Lazy<CqlCode>(this.Optometrist__occupation__Value);
        __Physician__occupation_ = new Lazy<CqlCode>(this.Physician__occupation__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_During_Measurement_Period_Value);
        __Diabetic_Retinopathy_Encounter = new Lazy<IEnumerable<Encounter>>(this.Diabetic_Retinopathy_Encounter_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Macular_Exam_Performed = new Lazy<IEnumerable<Observation>>(this.Macular_Exam_Performed_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Level_of_Severity_of_Retinopathy_Findings_Communicated = new Lazy<IEnumerable<Communication>>(this.Level_of_Severity_of_Retinopathy_Findings_Communicated_Value);
        __Macular_Edema_Absence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Absence_Communicated_Value);
        __Macular_Edema_Presence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Presence_Communicated_Value);
        __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated = new Lazy<bool?>(this.Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", 
			null);
    }

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Diabetic_Retinopathy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", 
			null);
    }

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
    public CqlValueSet Diabetic_Retinopathy() => __Diabetic_Retinopathy.Value;

    private CqlValueSet Level_of_Severity_of_Retinopathy_Findings_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", 
			null);
    }

    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings() => __Level_of_Severity_of_Retinopathy_Findings.Value;

    private CqlValueSet Macular_Edema_Findings_Present_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", 
			null);
    }

    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
    public CqlValueSet Macular_Edema_Findings_Present() => __Macular_Edema_Findings_Present.Value;

    private CqlValueSet Macular_Exam_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", 
			null);
    }

    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
    public CqlValueSet Macular_Exam() => __Macular_Exam.Value;

    private CqlValueSet Medical_Reason_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", 
			null);
    }

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
    public CqlValueSet Medical_Reason() => __Medical_Reason.Value;

    private CqlValueSet Nursing_Facility_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", 
			null);
    }

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Office_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", 
			null);
    }

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Ophthalmological_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", 
			null);
    }

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services() => __Ophthalmological_Services.Value;

    private CqlValueSet Outpatient_Consultation_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", 
			null);
    }

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation() => __Outpatient_Consultation.Value;

    private CqlValueSet Patient_Reason_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", 
			null);
    }

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
    public CqlValueSet Patient_Reason() => __Patient_Reason.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Healthcare_professional__occupation__Value()
    {
        return new CqlCode("223366009", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Healthcare professional (occupation)")]
    public CqlCode Healthcare_professional__occupation_() => __Healthcare_professional__occupation_.Value;

    private CqlCode Macular_edema_absent__situation__Value()
    {
        return new CqlCode("428341000124108", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Macular edema absent (situation)")]
    public CqlCode Macular_edema_absent__situation_() => __Macular_edema_absent__situation_.Value;

    private CqlCode Medical_practitioner__occupation__Value()
    {
        return new CqlCode("158965000", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Medical practitioner (occupation)")]
    public CqlCode Medical_practitioner__occupation_() => __Medical_practitioner__occupation_.Value;

    private CqlCode Ophthalmologist__occupation__Value()
    {
        return new CqlCode("422234006", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Ophthalmologist (occupation)")]
    public CqlCode Ophthalmologist__occupation_() => __Ophthalmologist__occupation_.Value;

    private CqlCode Optometrist__occupation__Value()
    {
        return new CqlCode("28229004", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Optometrist (occupation)")]
    public CqlCode Optometrist__occupation_() => __Optometrist__occupation_.Value;

    private CqlCode Physician__occupation__Value()
    {
        return new CqlCode("309343006", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Physician (occupation)")]
    public CqlCode Physician__occupation_() => __Physician__occupation_.Value;

    private CqlCode[] LOINC_Value()
    {
        var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] SNOMEDCT_Value()
    {
        var a_ = new CqlCode("223366009", 
			"http://snomed.info/sct", 
			null, 
			null);
        var b_ = new CqlCode("428341000124108", 
			"http://snomed.info/sct", 
			null, 
			null);
        var c_ = new CqlCode("158965000", 
			"http://snomed.info/sct", 
			null, 
			null);
        var d_ = new CqlCode("422234006", 
			"http://snomed.info/sct", 
			null, 
			null);
        var e_ = new CqlCode("28229004", 
			"http://snomed.info/sct", 
			null, 
			null);
        var f_ = new CqlCode("309343006", 
			"http://snomed.info/sct", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};
    }
    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT() => __SNOMEDCT.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
    {
        var a_ = this.Office_Visit();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			typeof(Encounter).GetProperty("Type"));
        var c_ = this.Ophthalmological_Services();
        var d_ = context?.Operators.RetrieveByValueSet<Encounter>(c_, 
			typeof(Encounter).GetProperty("Type"));
        var e_ = context?.Operators.ListUnion<Encounter>(b_, 
			d_);
        var f_ = this.Outpatient_Consultation();
        var g_ = context?.Operators.RetrieveByValueSet<Encounter>(f_, 
			typeof(Encounter).GetProperty("Type"));
        var h_ = this.Care_Services_in_Long_Term_Residential_Facility();
        var i_ = context?.Operators.RetrieveByValueSet<Encounter>(h_, 
			typeof(Encounter).GetProperty("Type"));
        var j_ = context?.Operators.ListUnion<Encounter>(g_, 
			i_);
        var k_ = context?.Operators.ListUnion<Encounter>(e_, 
			j_);
        var l_ = this.Nursing_Facility_Visit();
        var m_ = context?.Operators.RetrieveByValueSet<Encounter>(l_, 
			typeof(Encounter).GetProperty("Type"));
        var n_ = context?.Operators.ListUnion<Encounter>(k_, 
			m_);
        Func<Encounter,bool?> w_ = (QualifyingEncounter) => 
        {
            var o_ = this.Measurement_Period();
            var p_ = QualifyingEncounter?.Period;
            var q_ = FHIRHelpers_4_0_001.ToInterval(p_);
            var r_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(o_, 
				q_, 
				null);
            var t_ = (QualifyingEncounter?.StatusElement as object);
            var s_ = (context?.Operators.Convert<string>(t_) as object);
            var u_ = ("finished" as object);
            var v_ = context?.Operators.Equal(s_, 
				u_);
            return context?.Operators.And(r_, 
				v_);
        };
        return context?.Operators.WhereOrNull<Encounter>(n_, 
			w_);
    }
    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => __Qualifying_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Value()
    {
        var a_ = this.Qualifying_Encounter_During_Measurement_Period();
        Func<Encounter,IEnumerable<Encounter>> p_ = (ValidQualifyingEncounter) => 
        {
            var b_ = this.Diabetic_Retinopathy();
            var c_ = context?.Operators.RetrieveByValueSet<Condition>(b_, 
				typeof(Condition).GetProperty("Code"));
            Func<Condition,bool?> m_ = (DiabeticRetinopathy) => 
            {
                var e_ = DiabeticRetinopathy?.ClinicalStatus;
                var d_ = (FHIRHelpers_4_0_001.ToConcept(e_) as object);
                var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
                var f_ = (context?.Operators.ConvertCodeToConcept(g_) as object);
                var h_ = context?.Operators.Equivalent(d_, 
					f_);
                var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
                var j_ = ValidQualifyingEncounter?.Period;
                var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
                var l_ = context?.Operators.Overlaps(i_, 
					k_, 
					null);
                return context?.Operators.And(h_, 
					l_);
            };
            var n_ = context?.Operators.WhereOrNull<Condition>(c_, 
				m_);
            Func<Condition,Encounter> o_ = (DiabeticRetinopathy) => ValidQualifyingEncounter;
            return context?.Operators.SelectOrNull<Condition, Encounter>(n_, 
				o_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			p_);
    }
    [CqlDeclaration("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => __Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
    {
        var a_ = (domainResource?.ModifierExtension as IEnumerable<Extension>);
        Func<Extension,bool?> f_ = (E) => 
        {
            var d_ = (E?.Url as object);
            var c_ = (context?.Operators.Convert<FhirUri>(d_) as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (context?.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", 
				url) as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,Extension> h_ = (E) => E;
        return context?.Operators.SelectOrNull<Extension, Extension>(g_, 
			h_);
    }

    [CqlDeclaration("GetModifierExtension")]
    public Extension GetModifierExtension(DomainResource domainResource, string url)
    {
        var a_ = this.GetModifierExtensions(domainResource, 
			url);
        return context?.Operators.SingleOrNull<Extension>(a_);
    }

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
    {
        var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
        var b_ = context?.Operators.RetrieveByValueSet<Communication>(a_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> k_ = (LevelOfSeverityNotCommunicated) => 
        {
            var c_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> h_ = (EncounterDiabeticRetinopathy) => 
            {
                var d_ = EncounterDiabeticRetinopathy?.Period;
                var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
                var f_ = (((MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(((DomainResource)LevelOfSeverityNotCommunicated), 
						"qicore-recorded"))?.Value as object) as Period);
                var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
                return context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, 
					g_, 
					null);
            };
            var i_ = context?.Operators.WhereOrNull<Encounter>(c_, 
				h_);
            Func<Encounter,Communication> j_ = (EncounterDiabeticRetinopathy) => LevelOfSeverityNotCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(i_, 
				j_);
        };
        var l_ = context?.Operators.SelectManyOrNull<Communication, Communication>(b_, 
			k_);
        Func<Communication,bool?> ad_ = (LevelOfSeverityNotCommunicated) => 
        {
            var n_ = (LevelOfSeverityNotCommunicated?.StatusElement as object);
            var m_ = (context?.Operators.Convert<string>(n_) as object);
            var o_ = ("not-done" as object);
            var p_ = context?.Operators.Equal(m_, 
				o_);
            var q_ = (((this.GetModifierExtension(LevelOfSeverityNotCommunicated, 
					"qicore-notDone"))?.Value as object) as FhirBoolean);
            var r_ = FHIRHelpers_4_0_001.ToBoolean(q_);
            var s_ = context?.Operators.IsTrue(r_);
            var t_ = context?.Operators.And(p_, 
				s_);
            var u_ = LevelOfSeverityNotCommunicated?.StatusReason;
            var v_ = FHIRHelpers_4_0_001.ToConcept(u_);
            var w_ = this.Medical_Reason();
            var x_ = context?.Operators.ConceptInValueSet(v_, 
				w_);
            var aa_ = this.Patient_Reason();
            var ab_ = context?.Operators.ConceptInValueSet(v_, 
				aa_);
            var ac_ = context?.Operators.Or(x_, 
				ab_);
            return context?.Operators.And(t_, 
				ac_);
        };
        return context?.Operators.WhereOrNull<Communication>(l_, 
			ad_);
    }
    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
    {
        var a_ = this.Macular_edema_absent__situation_();
        var b_ = context?.Operators.ToList<CqlCode>(a_);
        var c_ = context?.Operators.RetrieveByCodes<Communication>(b_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> l_ = (MacularEdemaAbsentNotCommunicated) => 
        {
            var d_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> i_ = (EncounterDiabeticRetinopathy) => 
            {
                var e_ = EncounterDiabeticRetinopathy?.Period;
                var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
                var g_ = (((MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(((DomainResource)MacularEdemaAbsentNotCommunicated), 
						"qicore-recorded"))?.Value as object) as Period);
                var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
                return context?.Operators.IntervalIncludesInterval<CqlDateTime>(f_, 
					h_, 
					null);
            };
            var j_ = context?.Operators.WhereOrNull<Encounter>(d_, 
				i_);
            Func<Encounter,Communication> k_ = (EncounterDiabeticRetinopathy) => MacularEdemaAbsentNotCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(j_, 
				k_);
        };
        var m_ = context?.Operators.SelectManyOrNull<Communication, Communication>(c_, 
			l_);
        Func<Communication,bool?> ae_ = (MacularEdemaAbsentNotCommunicated) => 
        {
            var o_ = (MacularEdemaAbsentNotCommunicated?.StatusElement as object);
            var n_ = (context?.Operators.Convert<string>(o_) as object);
            var p_ = ("not-done" as object);
            var q_ = context?.Operators.Equal(n_, 
				p_);
            var r_ = (((this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, 
					"qicore-notDone"))?.Value as object) as FhirBoolean);
            var s_ = FHIRHelpers_4_0_001.ToBoolean(r_);
            var t_ = context?.Operators.IsTrue(s_);
            var u_ = context?.Operators.And(q_, 
				t_);
            var v_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            var w_ = FHIRHelpers_4_0_001.ToConcept(v_);
            var x_ = this.Medical_Reason();
            var y_ = context?.Operators.ConceptInValueSet(w_, 
				x_);
            var ab_ = this.Patient_Reason();
            var ac_ = context?.Operators.ConceptInValueSet(w_, 
				ab_);
            var ad_ = context?.Operators.Or(y_, 
				ac_);
            return context?.Operators.And(u_, 
				ad_);
        };
        return context?.Operators.WhereOrNull<Communication>(m_, 
			ae_);
    }
    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
    {
        var a_ = this.Macular_Edema_Findings_Present();
        var b_ = context?.Operators.RetrieveByValueSet<Communication>(a_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> k_ = (MacularEdemaPresentNotCommunicated) => 
        {
            var c_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> h_ = (EncounterDiabeticRetinopathy) => 
            {
                var d_ = EncounterDiabeticRetinopathy?.Period;
                var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
                var f_ = (((MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(((DomainResource)MacularEdemaPresentNotCommunicated), 
						"qicore-recorded"))?.Value as object) as Period);
                var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
                return context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, 
					g_, 
					null);
            };
            var i_ = context?.Operators.WhereOrNull<Encounter>(c_, 
				h_);
            Func<Encounter,Communication> j_ = (EncounterDiabeticRetinopathy) => MacularEdemaPresentNotCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(i_, 
				j_);
        };
        var l_ = context?.Operators.SelectManyOrNull<Communication, Communication>(b_, 
			k_);
        Func<Communication,bool?> ad_ = (MacularEdemaPresentNotCommunicated) => 
        {
            var n_ = (MacularEdemaPresentNotCommunicated?.StatusElement as object);
            var m_ = (context?.Operators.Convert<string>(n_) as object);
            var o_ = ("not-done" as object);
            var p_ = context?.Operators.Equal(m_, 
				o_);
            var q_ = (((this.GetModifierExtension(MacularEdemaPresentNotCommunicated, 
					"qicore-notDone"))?.Value as object) as FhirBoolean);
            var r_ = FHIRHelpers_4_0_001.ToBoolean(q_);
            var s_ = context?.Operators.IsTrue(r_);
            var t_ = context?.Operators.And(p_, 
				s_);
            var u_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            var v_ = FHIRHelpers_4_0_001.ToConcept(u_);
            var w_ = this.Medical_Reason();
            var x_ = context?.Operators.ConceptInValueSet(v_, 
				w_);
            var aa_ = this.Patient_Reason();
            var ab_ = context?.Operators.ConceptInValueSet(v_, 
				aa_);
            var ac_ = context?.Operators.Or(x_, 
				ab_);
            return context?.Operators.And(t_, 
				ac_);
        };
        return context?.Operators.WhereOrNull<Communication>(l_, 
			ad_);
    }
    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

    private bool? Denominator_Exceptions_Value()
    {
        var a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
        var b_ = context?.Operators.ExistsInList<Communication>(a_);
        var c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
        var d_ = context?.Operators.ExistsInList<Communication>(c_);
        var e_ = context?.Operators.Or(b_, 
			d_);
        var f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
        var g_ = context?.Operators.ExistsInList<Communication>(f_);
        return context?.Operators.Or(e_, 
			g_);
    }
    [CqlDeclaration("Denominator Exceptions")]
    public bool? Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private bool? Initial_Population_Value()
    {
        var b_ = this.Patient()?.BirthDateElement?.Value;
        var c_ = context?.Operators.ConvertStringToDateTime(b_);
        var d_ = this.Measurement_Period();
        var e_ = context?.Operators.Start(d_);
        var a_ = (context?.Operators.CalculateAgeAt(c_, 
			e_, 
			"year") as object);
        var f_ = (((int?)18) as object);
        var g_ = context?.Operators.GreaterOrEqual(a_, 
			f_);
        var h_ = this.Diabetic_Retinopathy_Encounter();
        var i_ = context?.Operators.ExistsInList<Encounter>(h_);
        return context?.Operators.And(g_, 
			i_);
    }
    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Observation> Macular_Exam_Performed_Value()
    {
        var a_ = this.Macular_Exam();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,IEnumerable<Observation>> k_ = (MacularExam) => 
        {
            var c_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> h_ = (EncounterDiabeticRetinopathy) => 
            {
                var d_ = EncounterDiabeticRetinopathy?.Period;
                var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
                var f_ = (MacularExam?.Effective as object);
                var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
                return context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, 
					g_, 
					null);
            };
            var i_ = context?.Operators.WhereOrNull<Encounter>(c_, 
				h_);
            Func<Encounter,Observation> j_ = (EncounterDiabeticRetinopathy) => MacularExam;
            return context?.Operators.SelectOrNull<Encounter, Observation>(i_, 
				j_);
        };
        var l_ = context?.Operators.SelectManyOrNull<Observation, Observation>(b_, 
			k_);
        Func<Observation,bool?> v_ = (MacularExam) => 
        {
            var m_ = (MacularExam?.StatusElement as object);
            var n_ = context?.Operators.Convert<string>(m_);
            var p_ = "final";
            var q_ = "amended";
            var r_ = "corrected";
            var o_ = (new string[]
			{
				p_,
				q_,
				r_,
			} as IEnumerable<string>);
            var s_ = context?.Operators.InList<string>(n_, 
				o_);
            bool? t_ = ((bool?)((MacularExam?.Value as object) == null));
            var u_ = context?.Operators.Not(t_);
            return context?.Operators.And(s_, 
				u_);
        };
        return context?.Operators.WhereOrNull<Observation>(l_, 
			v_);
    }
    [CqlDeclaration("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed() => __Macular_Exam_Performed.Value;

    private bool? Denominator_Value()
    {
        var a_ = this.Initial_Population();
        var b_ = this.Macular_Exam_Performed();
        var c_ = context?.Operators.ExistsInList<Observation>(b_);
        return context?.Operators.And(a_, 
			c_);
    }
    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Value()
    {
        var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
        var b_ = context?.Operators.RetrieveByValueSet<Communication>(a_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> l_ = (LevelOfSeverityCommunicated) => 
        {
            var c_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> i_ = (EncounterDiabeticRetinopathy) => 
            {
                var e_ = LevelOfSeverityCommunicated?.SentElement;
                var d_ = (FHIRHelpers_4_0_001.ToDateTime(e_) as object);
                var g_ = EncounterDiabeticRetinopathy?.Period;
                var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
                var f_ = (context?.Operators.Start(h_) as object);
                return context?.Operators.After(d_, 
					f_, 
					null);
            };
            var j_ = context?.Operators.WhereOrNull<Encounter>(c_, 
				i_);
            Func<Encounter,Communication> k_ = (EncounterDiabeticRetinopathy) => LevelOfSeverityCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(j_, 
				k_);
        };
        var m_ = context?.Operators.SelectManyOrNull<Communication, Communication>(b_, 
			l_);
        Func<Communication,bool?> q_ = (LevelOfSeverityCommunicated) => 
        {
            var o_ = (LevelOfSeverityCommunicated?.StatusElement as object);
            var n_ = (context?.Operators.Convert<string>(o_) as object);
            var p_ = ("completed" as object);
            return context?.Operators.Equal(n_, 
				p_);
        };
        return context?.Operators.WhereOrNull<Communication>(m_, 
			q_);
    }
    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => __Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

    private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
    {
        var a_ = this.Macular_edema_absent__situation_();
        var b_ = context?.Operators.ToList<CqlCode>(a_);
        var c_ = context?.Operators.RetrieveByCodes<Communication>(b_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> m_ = (MacularEdemaAbsentCommunicated) => 
        {
            var d_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> j_ = (EncounterDiabeticRetinopathy) => 
            {
                var f_ = MacularEdemaAbsentCommunicated?.SentElement;
                var e_ = (FHIRHelpers_4_0_001.ToDateTime(f_) as object);
                var h_ = EncounterDiabeticRetinopathy?.Period;
                var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
                var g_ = (context?.Operators.Start(i_) as object);
                return context?.Operators.After(e_, 
					g_, 
					null);
            };
            var k_ = context?.Operators.WhereOrNull<Encounter>(d_, 
				j_);
            Func<Encounter,Communication> l_ = (EncounterDiabeticRetinopathy) => MacularEdemaAbsentCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(k_, 
				l_);
        };
        var n_ = context?.Operators.SelectManyOrNull<Communication, Communication>(c_, 
			m_);
        Func<Communication,bool?> r_ = (MacularEdemaAbsentCommunicated) => 
        {
            var p_ = (MacularEdemaAbsentCommunicated?.StatusElement as object);
            var o_ = (context?.Operators.Convert<string>(p_) as object);
            var q_ = ("completed" as object);
            return context?.Operators.Equal(o_, 
				q_);
        };
        return context?.Operators.WhereOrNull<Communication>(n_, 
			r_);
    }
    [CqlDeclaration("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => __Macular_Edema_Absence_Communicated.Value;

    private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
    {
        var a_ = this.Macular_Edema_Findings_Present();
        var b_ = context?.Operators.RetrieveByValueSet<Communication>(a_, 
			typeof(Communication).GetProperty("ReasonCode"));
        Func<Communication,IEnumerable<Communication>> l_ = (MacularEdemaPresentCommunicated) => 
        {
            var c_ = this.Diabetic_Retinopathy_Encounter();
            Func<Encounter,bool?> i_ = (EncounterDiabeticRetinopathy) => 
            {
                var e_ = MacularEdemaPresentCommunicated?.SentElement;
                var d_ = (FHIRHelpers_4_0_001.ToDateTime(e_) as object);
                var g_ = EncounterDiabeticRetinopathy?.Period;
                var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
                var f_ = (context?.Operators.Start(h_) as object);
                return context?.Operators.After(d_, 
					f_, 
					null);
            };
            var j_ = context?.Operators.WhereOrNull<Encounter>(c_, 
				i_);
            Func<Encounter,Communication> k_ = (EncounterDiabeticRetinopathy) => MacularEdemaPresentCommunicated;
            return context?.Operators.SelectOrNull<Encounter, Communication>(j_, 
				k_);
        };
        var m_ = context?.Operators.SelectManyOrNull<Communication, Communication>(b_, 
			l_);
        Func<Communication,bool?> q_ = (MacularEdemaPresentCommunicated) => 
        {
            var o_ = (MacularEdemaPresentCommunicated?.StatusElement as object);
            var n_ = (context?.Operators.Convert<string>(o_) as object);
            var p_ = ("completed" as object);
            return context?.Operators.Equal(n_, 
				p_);
        };
        return context?.Operators.WhereOrNull<Communication>(m_, 
			q_);
    }
    [CqlDeclaration("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => __Macular_Edema_Presence_Communicated.Value;

    private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
    {
        var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
        var b_ = context?.Operators.ExistsInList<Communication>(a_);
        var c_ = this.Macular_Edema_Absence_Communicated();
        var d_ = context?.Operators.ExistsInList<Communication>(c_);
        var e_ = this.Macular_Edema_Presence_Communicated();
        var f_ = context?.Operators.ExistsInList<Communication>(e_);
        var g_ = context?.Operators.Or(d_, 
			f_);
        return context?.Operators.And(b_, 
			g_);
    }
    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

    private bool? Numerator_Value()
    {
        var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
        var b_ = context?.Operators.ExistsInList<Communication>(a_);
        var c_ = this.Macular_Edema_Absence_Communicated();
        var d_ = context?.Operators.ExistsInList<Communication>(c_);
        var e_ = this.Macular_Edema_Presence_Communicated();
        var f_ = context?.Operators.ExistsInList<Communication>(e_);
        var g_ = context?.Operators.Or(d_, 
			f_);
        return context?.Operators.And(b_, 
			g_);
    }
    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}