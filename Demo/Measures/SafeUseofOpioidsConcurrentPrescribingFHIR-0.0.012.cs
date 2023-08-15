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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
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
            var d_ = context?.Operators?.TypeConverter.Convert<CqlDate>(c_);
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
            var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) as object);
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
        Func<Encounter,IEnumerable<Encounter>> ap_ = (InpatientEncounter) => 
        {
            var b_ = this.Schedule_II_and_III_Opioid_Medications();
            var c_ = typeof(MedicationRequest).GetProperty("Medication");
            var d_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(b_, 
				c_);
            var h_ = context?.Operators.ListUnion<MedicationRequest>(d_, 
				d_);
            var i_ = this.Schedule_IV_Benzodiazepines();
            var k_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(i_, 
				c_);
            var o_ = context?.Operators.ListUnion<MedicationRequest>(k_, 
				k_);
            Func<MedicationRequest,bool?> v_ = (Medications) => 
            {
                var p_ = (Medications?.Category as IEnumerable<CodeableConcept>);
                Func<CodeableConcept,bool?> t_ = (C) => 
                {
                    var q_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
                    var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
                    var r_ = (context?.Operators.ConvertCodeToConcept(s_) as object);
                    return context?.Operators.Equivalent(q_, 
						r_);
                };
                var u_ = context?.Operators.WhereOrNull<CodeableConcept>(p_, 
					t_);
                return context?.Operators.ExistsInList<CodeableConcept>(u_);
            };
            var w_ = context?.Operators.WhereOrNull<MedicationRequest>(o_, 
				v_);
            var x_ = context?.Operators.ListUnion<MedicationRequest>(h_, 
				w_);
            Func<MedicationRequest,bool?> am_ = (OpioidOrBenzodiazepineDischargeMedication) => 
            {
                var y_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                var z_ = FHIRHelpers_4_0_001.ToDateTime(y_);
                var aa_ = InpatientEncounter?.Period;
                var ab_ = FHIRHelpers_4_0_001.ToInterval(aa_);
                var ac_ = context?.Operators.ElementInInterval<CqlDateTime>(z_, 
					ab_, 
					null);
                var ae_ = (OpioidOrBenzodiazepineDischargeMedication?.StatusElement as object);
                var ad_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ae_) as object);
                var af_ = ("active" as object);
                var ag_ = context?.Operators.Equal(ad_, 
					af_);
                var ah_ = context?.Operators.And(ac_, 
					ag_);
                var aj_ = (OpioidOrBenzodiazepineDischargeMedication?.IntentElement as object);
                var ai_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_) as object);
                var ak_ = ("plan" as object);
                var al_ = context?.Operators.Equal(ai_, 
					ak_);
                return context?.Operators.And(ah_, 
					al_);
            };
            var an_ = context?.Operators.WhereOrNull<MedicationRequest>(x_, 
				am_);
            Func<MedicationRequest,Encounter> ao_ = (OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(an_, 
				ao_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			ap_);
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
        Func<Encounter,bool?> o_ = (InpatientEncounter) => 
        {
            var c_ = this.Schedule_II_and_III_Opioid_Medications();
            var d_ = typeof(MedicationRequest).GetProperty("Medication");
            var e_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(c_, 
				d_);
            Func<MedicationRequest,bool?> j_ = (Opioids) => 
            {
                var f_ = Opioids?.AuthoredOnElement;
                var g_ = FHIRHelpers_4_0_001.ToDateTime(f_);
                var h_ = InpatientEncounter?.Period;
                var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
                return context?.Operators.ElementInInterval<CqlDateTime>(g_, 
					i_, 
					null);
            };
            var k_ = context?.Operators.WhereOrNull<MedicationRequest>(e_, 
				j_);
            Func<MedicationRequest,object> l_ = (Opioids) => (Opioids?.Medication as object);
            var m_ = context?.Operators.SelectOrNull<MedicationRequest, object>(k_, 
				l_);
            var b_ = (context?.Operators.CountOrNull<object>(m_) as object);
            var n_ = (((int?)2) as object);
            return context?.Operators.GreaterOrEqual(b_, 
				n_);
        };
        var p_ = context?.Operators.WhereOrNull<Encounter>(a_, 
			o_);
        Func<Encounter,IEnumerable<Encounter>> ab_ = (InpatientEncounter) => 
        {
            var r_ = this.Schedule_II_and_III_Opioid_Medications();
            var s_ = typeof(MedicationRequest).GetProperty("Medication");
            var t_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(r_, 
				s_);
            Func<MedicationRequest,bool?> y_ = (OpioidsDischarge) => 
            {
                var u_ = OpioidsDischarge?.AuthoredOnElement;
                var v_ = FHIRHelpers_4_0_001.ToDateTime(u_);
                var w_ = InpatientEncounter?.Period;
                var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
                return context?.Operators.ElementInInterval<CqlDateTime>(v_, 
					x_, 
					null);
            };
            var z_ = context?.Operators.WhereOrNull<MedicationRequest>(t_, 
				y_);
            Func<MedicationRequest,Encounter> aa_ = (OpioidsDischarge) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(z_, 
				aa_);
        };
        var ac_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			ab_);
        Func<Encounter,IEnumerable<Encounter>> an_ = (InpatientEncounter) => 
        {
            var ad_ = this.Schedule_IV_Benzodiazepines();
            var ae_ = typeof(MedicationRequest).GetProperty("Medication");
            var af_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ad_, 
				ae_);
            Func<MedicationRequest,bool?> ak_ = (BenzodiazepinesDischarge) => 
            {
                var ag_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                var ah_ = FHIRHelpers_4_0_001.ToDateTime(ag_);
                var ai_ = InpatientEncounter?.Period;
                var aj_ = FHIRHelpers_4_0_001.ToInterval(ai_);
                return context?.Operators.ElementInInterval<CqlDateTime>(ah_, 
					aj_, 
					null);
            };
            var al_ = context?.Operators.WhereOrNull<MedicationRequest>(af_, 
				ak_);
            Func<MedicationRequest,Encounter> am_ = (BenzodiazepinesDischarge) => InpatientEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(al_, 
				am_);
        };
        var ao_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(ac_, 
			an_);
        return context?.Operators.ListUnion<Encounter>(p_, 
			ao_);
    }
    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Encounter> Denominator_Exclusion_Value()
    {
        var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
        Func<Encounter,bool?> bc_ = (InpatientEncounter) => 
        {
            var b_ = this.All_Primary_and_Secondary_Cancer();
            var c_ = typeof(Condition).GetProperty("Code");
            var d_ = context?.DataRetriever.RetrieveByValueSet<Condition>(b_, 
				c_);
            Func<Condition,bool?> h_ = (Cancer) => 
            {
                var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
                var f_ = InpatientEncounter?.Period;
                var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
                return context?.Operators.Overlaps(e_, 
					g_, 
					null);
            };
            var i_ = context?.Operators.WhereOrNull<Condition>(d_, 
				h_);
            var j_ = context?.Operators.ExistsInList<Condition>(i_);
            var k_ = this.Palliative_or_Hospice_Care();
            var l_ = typeof(ServiceRequest).GetProperty("Code");
            var m_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(k_, 
				l_);
            Func<ServiceRequest,bool?> w_ = (PalliativeOrHospiceCareOrder) => 
            {
                var n_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                var o_ = FHIRHelpers_4_0_001.ToDateTime(n_);
                var p_ = InpatientEncounter?.Period;
                var q_ = FHIRHelpers_4_0_001.ToInterval(p_);
                var r_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, 
					q_, 
					null);
                var t_ = (PalliativeOrHospiceCareOrder?.IntentElement as object);
                var s_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(t_) as object);
                var u_ = ("order" as object);
                var v_ = context?.Operators.Equal(s_, 
					u_);
                return context?.Operators.And(r_, 
					v_);
            };
            var x_ = context?.Operators.WhereOrNull<ServiceRequest>(m_, 
				w_);
            var y_ = context?.Operators.ExistsInList<ServiceRequest>(x_);
            var z_ = context?.Operators.Or(j_, 
				y_);
            var ab_ = typeof(Procedure).GetProperty("Code");
            var ac_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, 
				ab_);
            Func<Procedure,bool?> ah_ = (PalliativeOrHospiceCarePerformed) => 
            {
                var ad_ = (PalliativeOrHospiceCarePerformed?.Performed as object);
                var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
                var af_ = InpatientEncounter?.Period;
                var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
                return context?.Operators.Overlaps(ae_, 
					ag_, 
					null);
            };
            var ai_ = context?.Operators.WhereOrNull<Procedure>(ac_, 
				ah_);
            var aj_ = context?.Operators.ExistsInList<Procedure>(ai_);
            var ak_ = context?.Operators.Or(z_, 
				aj_);
            var al_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
            Func<Encounter,bool?> az_ = (InpatientEncounter) => 
            {
                var am_ = InpatientEncounter?.Hospitalization?.DischargeDisposition;
                var an_ = FHIRHelpers_4_0_001.ToConcept(am_);
                var ao_ = this.Discharge_To_Acute_Care_Facility();
                var ap_ = context?.Operators.ConceptInValueSet(an_, 
					ao_);
                var as_ = this.Hospice_Care_Referral_or_Admission();
                var at_ = context?.Operators.ConceptInValueSet(an_, 
					as_);
                var au_ = context?.Operators.Or(ap_, 
					at_);
                var ax_ = this.Patient_Expired();
                var ay_ = context?.Operators.ConceptInValueSet(an_, 
					ax_);
                return context?.Operators.Or(au_, 
					ay_);
            };
            var ba_ = context?.Operators.WhereOrNull<Encounter>(al_, 
				az_);
            var bb_ = context?.Operators.ExistsInList<Encounter>(ba_);
            return context?.Operators.Or(ak_, 
				bb_);
        };
        var bd_ = context?.Operators.WhereOrNull<Encounter>(a_, 
			bc_);
        Func<Encounter,Encounter> be_ = (InpatientEncounter) => InpatientEncounter;
        return context?.Operators.SelectOrNull<Encounter, Encounter>(bd_, 
			be_);
    }
    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}