using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __All_Primary_and_Secondary_Cancer;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hospice_Care_Referral_or_Admission;
    internal Lazy<CqlValueSet> __Palliative_or_Hospice_Care;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Schedule_II_and_III_Opioid_Medications;
    internal Lazy<CqlValueSet> __Schedule_IV_Benzodiazepines;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusion;

    #endregion
    public SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __All_Primary_and_Secondary_Cancer = new Lazy<CqlValueSet>(this.All_Primary_and_Secondary_Cancer_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hospice_Care_Referral_or_Admission = new Lazy<CqlValueSet>(this.Hospice_Care_Referral_or_Admission_Value);
        __Palliative_or_Hospice_Care = new Lazy<CqlValueSet>(this.Palliative_or_Hospice_Care_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Schedule_II_and_III_Opioid_Medications = new Lazy<CqlValueSet>(this.Schedule_II_and_III_Opioid_Medications_Value);
        __Schedule_IV_Benzodiazepines = new Lazy<CqlValueSet>(this.Schedule_IV_Benzodiazepines_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18 = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Denominator_Exclusion = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusion_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

    private CqlValueSet All_Primary_and_Secondary_Cancer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", 
			null);
    }

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
    public CqlValueSet All_Primary_and_Secondary_Cancer() => __All_Primary_and_Secondary_Cancer.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", 
			null);
    }

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hospice_Care_Referral_or_Admission_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", 
			null);
    }

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
    public CqlValueSet Hospice_Care_Referral_or_Admission() => __Hospice_Care_Referral_or_Admission.Value;

    private CqlValueSet Palliative_or_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", 
			null);
    }

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care() => __Palliative_or_Hospice_Care.Value;

    private CqlValueSet Patient_Expired_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", 
			null);
    }

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Schedule_II_and_III_Opioid_Medications_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", 
			null);
    }

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
    public CqlValueSet Schedule_II_and_III_Opioid_Medications() => __Schedule_II_and_III_Opioid_Medications.Value;

    private CqlValueSet Schedule_IV_Benzodiazepines_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", 
			null);
    }

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
    public CqlValueSet Schedule_IV_Benzodiazepines() => __Schedule_IV_Benzodiazepines.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

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

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", 
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

    private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
    {
        var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
        Func<Encounter,bool?> o_ = (EncounterInpatient) => 
        {
            var c_ = (this.Patient()?.BirthDateElement?.Value as object);
            var d_ = context?.Operators.Convert<CqlDate>(c_);
            var e_ = EncounterInpatient?.Period;
            var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
            var g_ = context?.Operators.Start(f_);
            var h_ = context?.Operators.DateFrom(g_);
            var b_ = (context?.Operators.CalculateAgeAt(d_, 
				h_, 
				"year") as object);
            var i_ = (((int?)18) as object);
            var j_ = context?.Operators.GreaterOrEqual(b_, 
				i_);
            var l_ = (EncounterInpatient?.StatusElement as object);
            var k_ = (context?.Operators.Convert<string>(l_) as object);
            var m_ = ("finished" as object);
            var n_ = context?.Operators.Equal(k_, 
				m_);
            return context?.Operators.And(j_, 
				n_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			o_);
    }
    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
    {
        var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
        Func<Encounter,IEnumerable<Encounter>> al_ = (InpatientEncounter) => 
        {
            var b_ = this.Schedule_II_and_III_Opioid_Medications();
            var c_ = context?.Operators.RetrieveByValueSet<MedicationRequest>(b_, 
				typeof(MedicationRequest).GetProperty("Medication"));
            var f_ = context?.Operators.ListUnion<MedicationRequest>(c_, 
				c_);
            var g_ = this.Schedule_IV_Benzodiazepines();
            var h_ = context?.Operators.RetrieveByValueSet<MedicationRequest>(g_, 
				typeof(MedicationRequest).GetProperty("Medication"));
            var k_ = context?.Operators.ListUnion<MedicationRequest>(h_, 
				h_);
            Func<MedicationRequest,bool?> r_ = (Medications) => 
            {
                var l_ = (Medications?.Category as IEnumerable<CodeableConcept>);
                Func<CodeableConcept,bool?> p_ = (C) => 
                {
                    var m_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
                    var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
                    var n_ = (context?.Operators.ConvertCodeToConcept(o_) as object);
                    return context?.Operators.Equivalent(m_, 
						n_);
                };
                var q_ = context?.Operators.WhereOrNull<CodeableConcept>(l_, 
					p_);
                return context?.Operators.ExistsInList<CodeableConcept>(q_);
            };
            var s_ = context?.Operators.WhereOrNull<MedicationRequest>(k_, 
				r_);
            var t_ = context?.Operators.ListUnion<MedicationRequest>(f_, 
				s_);
            Func<MedicationRequest,bool?> ai_ = (OpioidOrBenzodiazepineDischargeMedication) => 
            {
                var u_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                var v_ = FHIRHelpers_4_0_001.ToDateTime(u_);
                var w_ = InpatientEncounter?.Period;
                var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
                var y_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, 
					x_, 
					null);
                var aa_ = (OpioidOrBenzodiazepineDischargeMedication?.StatusElement as object);
                var z_ = (context?.Operators.Convert<string>(aa_) as object);
                var ab_ = ("active" as object);
                var ac_ = context?.Operators.Equal(z_, 
					ab_);
                var ad_ = context?.Operators.And(y_, 
					ac_);
                var af_ = (OpioidOrBenzodiazepineDischargeMedication?.IntentElement as object);
                var ae_ = (context?.Operators.Convert<string>(af_) as object);
                var ag_ = ("plan" as object);
                var ah_ = context?.Operators.Equal(ae_, 
					ag_);
                return context?.Operators.And(ad_, 
					ah_);
            };
            var aj_ = context?.Operators.WhereOrNull<MedicationRequest>(t_, 
				ai_);
            Func<MedicationRequest,Encounter> ak_ = (OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(aj_, 
				ak_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			al_);
    }
    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
    {
        return this.Initial_Population();
    }
    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

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

    private IEnumerable<Encounter> Numerator_Value()
    {
        var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
        Func<Encounter,bool?> n_ = (InpatientEncounter) => 
        {
            var c_ = this.Schedule_II_and_III_Opioid_Medications();
            var d_ = context?.Operators.RetrieveByValueSet<MedicationRequest>(c_, 
				typeof(MedicationRequest).GetProperty("Medication"));
            Func<MedicationRequest,bool?> i_ = (Opioids) => 
            {
                var e_ = Opioids?.AuthoredOnElement;
                var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
                var g_ = InpatientEncounter?.Period;
                var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
                return context?.Operators.ElementInInterval<CqlDateTime>(f_, 
					h_, 
					null);
            };
            var j_ = context?.Operators.WhereOrNull<MedicationRequest>(d_, 
				i_);
            Func<MedicationRequest,object> k_ = (Opioids) => (Opioids?.Medication as object);
            var l_ = context?.Operators.SelectOrNull<MedicationRequest, object>(j_, 
				k_);
            var b_ = (context?.Operators.CountOrNull<object>(l_) as object);
            var m_ = (((int?)2) as object);
            return context?.Operators.GreaterOrEqual(b_, 
				m_);
        };
        var o_ = context?.Operators.WhereOrNull<Encounter>(a_, 
			n_);
        Func<Encounter,IEnumerable<Encounter>> z_ = (InpatientEncounter) => 
        {
            var q_ = this.Schedule_II_and_III_Opioid_Medications();
            var r_ = context?.Operators.RetrieveByValueSet<MedicationRequest>(q_, 
				typeof(MedicationRequest).GetProperty("Medication"));
            Func<MedicationRequest,bool?> w_ = (OpioidsDischarge) => 
            {
                var s_ = OpioidsDischarge?.AuthoredOnElement;
                var t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
                var u_ = InpatientEncounter?.Period;
                var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
                return context?.Operators.ElementInInterval<CqlDateTime>(t_, 
					v_, 
					null);
            };
            var x_ = context?.Operators.WhereOrNull<MedicationRequest>(r_, 
				w_);
            Func<MedicationRequest,Encounter> y_ = (OpioidsDischarge) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(x_, 
				y_);
        };
        var aa_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			z_);
        Func<Encounter,IEnumerable<Encounter>> ak_ = (InpatientEncounter) => 
        {
            var ab_ = this.Schedule_IV_Benzodiazepines();
            var ac_ = context?.Operators.RetrieveByValueSet<MedicationRequest>(ab_, 
				typeof(MedicationRequest).GetProperty("Medication"));
            Func<MedicationRequest,bool?> ah_ = (BenzodiazepinesDischarge) => 
            {
                var ad_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                var ae_ = FHIRHelpers_4_0_001.ToDateTime(ad_);
                var af_ = InpatientEncounter?.Period;
                var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
                return context?.Operators.ElementInInterval<CqlDateTime>(ae_, 
					ag_, 
					null);
            };
            var ai_ = context?.Operators.WhereOrNull<MedicationRequest>(ac_, 
				ah_);
            Func<MedicationRequest,Encounter> aj_ = (BenzodiazepinesDischarge) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(ai_, 
				aj_);
        };
        var al_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(aa_, 
			ak_);
        return context?.Operators.ListUnion<Encounter>(o_, 
			al_);
    }
    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Encounter> Denominator_Exclusion_Value()
    {
        var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
        Func<Encounter,bool?> az_ = (InpatientEncounter) => 
        {
            var b_ = this.All_Primary_and_Secondary_Cancer();
            var c_ = context?.Operators.RetrieveByValueSet<Condition>(b_, 
				typeof(Condition).GetProperty("Code"));
            Func<Condition,bool?> g_ = (Cancer) => 
            {
                var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
                var e_ = InpatientEncounter?.Period;
                var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
                return context?.Operators.Overlaps(d_, 
					f_, 
					null);
            };
            var h_ = context?.Operators.WhereOrNull<Condition>(c_, 
				g_);
            var i_ = context?.Operators.ExistsInList<Condition>(h_);
            var j_ = this.Palliative_or_Hospice_Care();
            var k_ = context?.Operators.RetrieveByValueSet<ServiceRequest>(j_, 
				typeof(ServiceRequest).GetProperty("Code"));
            Func<ServiceRequest,bool?> u_ = (PalliativeOrHospiceCareOrder) => 
            {
                var l_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
                var n_ = InpatientEncounter?.Period;
                var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
                var p_ = context?.Operators.ElementInInterval<CqlDateTime>(m_, 
					o_, 
					null);
                var r_ = (PalliativeOrHospiceCareOrder?.IntentElement as object);
                var q_ = (context?.Operators.Convert<string>(r_) as object);
                var s_ = ("order" as object);
                var t_ = context?.Operators.Equal(q_, 
					s_);
                return context?.Operators.And(p_, 
					t_);
            };
            var v_ = context?.Operators.WhereOrNull<ServiceRequest>(k_, 
				u_);
            var w_ = context?.Operators.ExistsInList<ServiceRequest>(v_);
            var x_ = context?.Operators.Or(i_, 
				w_);
            var z_ = context?.Operators.RetrieveByValueSet<Procedure>(j_, 
				typeof(Procedure).GetProperty("Code"));
            Func<Procedure,bool?> ae_ = (PalliativeOrHospiceCarePerformed) => 
            {
                var aa_ = (PalliativeOrHospiceCarePerformed?.Performed as object);
                var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aa_);
                var ac_ = InpatientEncounter?.Period;
                var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
                return context?.Operators.Overlaps(ab_, 
					ad_, 
					null);
            };
            var af_ = context?.Operators.WhereOrNull<Procedure>(z_, 
				ae_);
            var ag_ = context?.Operators.ExistsInList<Procedure>(af_);
            var ah_ = context?.Operators.Or(x_, 
				ag_);
            var ai_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
            Func<Encounter,bool?> aw_ = (InpatientEncounter) => 
            {
                var aj_ = InpatientEncounter?.Hospitalization?.DischargeDisposition;
                var ak_ = FHIRHelpers_4_0_001.ToConcept(aj_);
                var al_ = this.Discharge_To_Acute_Care_Facility();
                var am_ = context?.Operators.ConceptInValueSet(ak_, 
					al_);
                var ap_ = this.Hospice_Care_Referral_or_Admission();
                var aq_ = context?.Operators.ConceptInValueSet(ak_, 
					ap_);
                var ar_ = context?.Operators.Or(am_, 
					aq_);
                var au_ = this.Patient_Expired();
                var av_ = context?.Operators.ConceptInValueSet(ak_, 
					au_);
                return context?.Operators.Or(ar_, 
					av_);
            };
            var ax_ = context?.Operators.WhereOrNull<Encounter>(ai_, 
				aw_);
            var ay_ = context?.Operators.ExistsInList<Encounter>(ax_);
            return context?.Operators.Or(ah_, 
				ay_);
        };
        var ba_ = context?.Operators.WhereOrNull<Encounter>(a_, 
			az_);
        Func<Encounter,Encounter> bb_ = (InpatientEncounter) => InpatientEncounter;
        return context?.Operators.SelectOrNull<Encounter, Encounter>(ba_, 
			bb_);
    }
    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}