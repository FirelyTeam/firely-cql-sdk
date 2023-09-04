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
[CqlLibrary("HybridHWRFHIR", "1.3.005")]
public class HybridHWRFHIR_1_3_005
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bicarbonate_lab_test;
    internal Lazy<CqlValueSet> __Body_temperature;
    internal Lazy<CqlValueSet> __Body_weight;
    internal Lazy<CqlValueSet> __Creatinine_lab_test;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __Glucose_lab_test;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __Medicare_payer;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer;
    internal Lazy<CqlValueSet> __Potassium_lab_test;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<CqlValueSet> __Sodium_lab_test;
    internal Lazy<CqlValueSet> __White_blood_cells_count_lab_test;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Heart_rate;
    internal Lazy<CqlCode> __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    internal Lazy<CqlCode> __Respiratory_rate;
    internal Lazy<CqlCode> __Systolic_blood_pressure;
    internal Lazy<CqlCode[]> __LOINC_2_69;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounters;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<string>> __Results;

    #endregion
    public HybridHWRFHIR_1_3_005(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Bicarbonate_lab_test = new Lazy<CqlValueSet>(this.Bicarbonate_lab_test_Value);
        __Body_temperature = new Lazy<CqlValueSet>(this.Body_temperature_Value);
        __Body_weight = new Lazy<CqlValueSet>(this.Body_weight_Value);
        __Creatinine_lab_test = new Lazy<CqlValueSet>(this.Creatinine_lab_test_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __Glucose_lab_test = new Lazy<CqlValueSet>(this.Glucose_lab_test_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __Medicare_payer = new Lazy<CqlValueSet>(this.Medicare_payer_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer = new Lazy<CqlValueSet>(this.Payer_Value);
        __Potassium_lab_test = new Lazy<CqlValueSet>(this.Potassium_lab_test_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Sodium_lab_test = new Lazy<CqlValueSet>(this.Sodium_lab_test_Value);
        __White_blood_cells_count_lab_test = new Lazy<CqlValueSet>(this.White_blood_cells_count_lab_test_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Heart_rate = new Lazy<CqlCode>(this.Heart_rate_Value);
        __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new Lazy<CqlCode>(this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value);
        __Respiratory_rate = new Lazy<CqlCode>(this.Respiratory_rate_Value);
        __Systolic_blood_pressure = new Lazy<CqlCode>(this.Systolic_blood_pressure_Value);
        __LOINC_2_69 = new Lazy<CqlCode[]>(this.LOINC_2_69_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounters = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounters_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Results = new Lazy<IEnumerable<string>>(this.Results_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

    private CqlValueSet Bicarbonate_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", 
			null);
    }

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
    public CqlValueSet Bicarbonate_lab_test() => __Bicarbonate_lab_test.Value;

    private CqlValueSet Body_temperature_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", 
			null);
    }

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
    public CqlValueSet Body_temperature() => __Body_temperature.Value;

    private CqlValueSet Body_weight_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", 
			null);
    }

    [CqlDeclaration("Body weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159")]
    public CqlValueSet Body_weight() => __Body_weight.Value;

    private CqlValueSet Creatinine_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", 
			null);
    }

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test() => __Creatinine_lab_test.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Ethnicity_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", 
			null);
    }

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet Glucose_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);
    }

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hematocrit_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", 
			null);
    }

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test() => __Hematocrit_lab_test.Value;

    private CqlValueSet Medicare_payer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", 
			null);
    }

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_payer() => __Medicare_payer.Value;

    private CqlValueSet Observation_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);
    }

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet ONC_Administrative_Sex_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", 
			null);
    }

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", 
			null);
    }

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Potassium_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", 
			null);
    }

    [CqlDeclaration("Potassium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117")]
    public CqlValueSet Potassium_lab_test() => __Potassium_lab_test.Value;

    private CqlValueSet Race_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", 
			null);
    }

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private CqlValueSet Sodium_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", 
			null);
    }

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test() => __Sodium_lab_test.Value;

    private CqlValueSet White_blood_cells_count_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", 
			null);
    }

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
    public CqlValueSet White_blood_cells_count_lab_test() => __White_blood_cells_count_lab_test.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Heart_rate_Value()
    {
        return new CqlCode("8867-4", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Heart rate")]
    public CqlCode Heart_rate() => __Heart_rate.Value;

    private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value()
    {
        return new CqlCode("59408-5", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

    private CqlCode Respiratory_rate_Value()
    {
        return new CqlCode("9279-1", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Respiratory rate")]
    public CqlCode Respiratory_rate() => __Respiratory_rate.Value;

    private CqlCode Systolic_blood_pressure_Value()
    {
        return new CqlCode("8480-6", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure() => __Systolic_blood_pressure.Value;

    private CqlCode[] LOINC_2_69_Value()
    {
        var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
        var b_ = new CqlCode("8867-4", 
			"http://loinc.org", 
			null, 
			null);
        var c_ = new CqlCode("59408-5", 
			"http://loinc.org", 
			null, 
			null);
        var d_ = new CqlCode("9279-1", 
			"http://loinc.org", 
			null, 
			null);
        var e_ = new CqlCode("8480-6", 
			"http://loinc.org", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
		};
    }
    [CqlDeclaration("LOINC:2.69")]
    public CqlCode[] LOINC_2_69() => __LOINC_2_69.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("HybridHWRFHIR-1.3.005", 
			"Measurement Period", 
(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
((int?)1), 
((int?)1), 
((int?)0), 
((int?)0), 
((int?)0), 
((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
((int?)1), 
((int?)1), 
((int?)0), 
((int?)0), 
((int?)0), 
((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
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

    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
    {
        var b_ = TheEncounter;
        var a_ = new Encounter[]
		{
			b_,
		};
        Func<Encounter,CqlInterval<CqlDateTime>> m_ = (Visit) => 
        {
            var d_ = (context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Emergency_Department_Visit(), 
								typeof(Encounter).GetProperty("Type")), 
							(LastED) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastED?.Period)), 
										context?.Operators.Interval(context?.Operators.Subtract((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																			typeof(Encounter).GetProperty("Type")), 
																		(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																					context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																							context?.Operators.Quantity(1m, 
																								"hour")), 
																						context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																						true, 
																						true), 
																					null), 
																				context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
																	(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
																	System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))), 
												context?.Operators.Quantity(1m, 
													"hour")), 
(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																		typeof(Encounter).GetProperty("Type")), 
																	(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																				context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																						context?.Operators.Quantity(1m, 
																							"hour")), 
																					context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																					true, 
																					true), 
																				null), 
																			context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
																(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
																System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))), 
											true, 
											true), 
										null), 
									context?.Operators.Not(((bool?)((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																	typeof(Encounter).GetProperty("Type")), 
																(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																			context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																					context?.Operators.Quantity(1m, 
																						"hour")), 
																				context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																				true, 
																				true), 
																			null), 
																		context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
															(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
															System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))) == null))))), 
						(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Period;
            var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
            var f_ = (context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
								typeof(Encounter).GetProperty("Type")), 
							(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
										context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
												context?.Operators.Quantity(1m, 
													"hour")), 
											context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
											true, 
											true), 
										null), 
									context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
						(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Period;
            var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
            var h_ = Visit?.Period;
            var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
            var c_ = (context?.Operators.Start(e_) ?? (context?.Operators.Start(g_) ?? context?.Operators.Start(i_)));
            var l_ = context?.Operators.End(i_);
            return context?.Operators.Interval(c_, 
				l_, 
				true, 
				true);
        };
        var n_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, 
			m_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(n_);
    }

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
    {
        var a_ = context?.Operators.Start(Value);
        var b_ = context?.Operators.End(Value);
        return context?.Operators.DifferenceBetween(a_, 
			b_, 
			"day");
    }

    private IEnumerable<Encounter> Inpatient_Encounters_Value()
    {
        var a_ = this.Encounter_Inpatient();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			typeof(Encounter).GetProperty("Type"));
        Func<Encounter,IEnumerable<Coverage>> d_ = (_InpatientEncounter) => 
        {
            var c_ = this.Medicare_payer();
            return context?.Operators.RetrieveByValueSet<Coverage>(c_, 
				typeof(Coverage).GetProperty("Type"));
        };
        Func<Encounter,Coverage,Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV> g_ = (_InpatientEncounter, _Payer) => 
        {
            var e_ = _InpatientEncounter;
            var f_ = _Payer;
            return new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = e_,
				Payer = f_,
			};
        };
        var h_ = context?.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(b_, 
			d_, 
			g_);
        Func<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV,bool?> ag_ = (tuple_czdryxljaejapsirauhdxvhpv) => 
        {
            var j_ = (tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.StatusElement as object);
            var i_ = (context?.Operators.Convert<string>(j_) as object);
            var k_ = ("finished" as object);
            var l_ = context?.Operators.Equal(i_, 
				k_);
            var n_ = this.HospitalizationWithObservation(tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter);
            var m_ = (this.LengthInDays(n_) as object);
            var o_ = (((int?)365) as object);
            var p_ = context?.Operators.Less(m_, 
				o_);
            var q_ = context?.Operators.And(l_, 
				p_);
            var r_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
            var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
            var t_ = context?.Operators.End(s_);
            var u_ = this.Measurement_Period();
            var v_ = context?.Operators.ElementInInterval<CqlDateTime>(t_, 
				u_, 
				"day");
            var w_ = context?.Operators.And(q_, 
				v_);
            var y_ = (this.Patient()?.BirthDateElement?.Value as object);
            var z_ = context?.Operators.Convert<CqlDate>(y_);
            var ac_ = context?.Operators.Start(s_);
            var ad_ = context?.Operators.DateFrom(ac_);
            var x_ = (context?.Operators.CalculateAgeAt(z_, 
				ad_, 
				"year") as object);
            var ae_ = (((int?)65) as object);
            var af_ = context?.Operators.GreaterOrEqual(x_, 
				ae_);
            return context?.Operators.And(w_, 
				af_);
        };
        var ah_ = context?.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(h_, 
			ag_);
        Func<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV,Encounter> ai_ = (tuple_czdryxljaejapsirauhdxvhpv) => tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
        return context?.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(ah_, 
			ai_);
    }
    [CqlDeclaration("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters() => __Inpatient_Encounters.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
    {
        return this.Inpatient_Encounters();
    }
    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
    {
        var a_ = this.Inpatient_Encounters();
        Func<Encounter,string> v_ = (Encounter) => 
        {
            var h_ = ("\r\n" ?? "");
            var i_ = (CCDE ?? "");
            var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
            var j_ = ("," ?? "");
            var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
            var l_ = (Encounter?.IdElement as object);
            var k_ = (context?.Operators.Convert<string>(l_) ?? "");
            var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
            var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
            var o_ = (((context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(ExamList, 
							(Exam) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))) == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(120m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Exam?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Exam?.Value as object) == null))))), 
						(@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object))), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Value as object) as Quantity);
            var p_ = FHIRHelpers_4_0_001.ToQuantity(o_);
            var n_ = (context?.Operators.ConvertQuantityToString(p_) ?? "");
            var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
            var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
            var s_ = ((context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(ExamList, 
							(Exam) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))) == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(120m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Exam?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Exam?.Value as object) == null))))), 
						(@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object))), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Effective as object);
            var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
            var u_ = context?.Operators.Start(t_);
            var r_ = (context?.Operators.ConvertDateTimeToString(u_) ?? "");
            return context?.Operators.Concatenate(b_, 
				r_);
        };
        return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			v_);
    }

    [CqlDeclaration("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(IEnumerable<Observation> ExamList, string CCDE)
    {
        var a_ = this.Inpatient_Encounters();
        Func<Encounter,string> v_ = (Encounter) => 
        {
            var h_ = ("\r\n" ?? "");
            var i_ = (CCDE ?? "");
            var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
            var j_ = ("," ?? "");
            var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
            var l_ = (Encounter?.IdElement as object);
            var k_ = (context?.Operators.Convert<string>(l_) ?? "");
            var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
            var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
            var o_ = (((context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(ExamList, 
							(Exam) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))) == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Exam?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Exam?.Value as object) == null))))), 
						(@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object))), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Value as object) as Quantity);
            var p_ = FHIRHelpers_4_0_001.ToQuantity(o_);
            var n_ = (context?.Operators.ConvertQuantityToString(p_) ?? "");
            var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
            var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
            var s_ = ((context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(ExamList, 
							(Exam) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))) == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((Exam?.Effective as object))), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Exam?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Exam?.Value as object) == null))))), 
						(@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object))), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Effective as object);
            var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
            var u_ = context?.Operators.Start(t_);
            var r_ = (context?.Operators.ConvertDateTimeToString(u_) ?? "");
            return context?.Operators.Concatenate(b_, 
				r_);
        };
        return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			v_);
    }

    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
    {
        var a_ = this.Inpatient_Encounters();
        Func<Encounter,string> u_ = (Encounter) => 
        {
            var h_ = ("\r\n" ?? "");
            var i_ = (CCDE ?? "");
            var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
            var j_ = ("," ?? "");
            var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
            var l_ = (Encounter?.IdElement as object);
            var k_ = (context?.Operators.Convert<string>(l_) ?? "");
            var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
            var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
            var o_ = (((context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(LabList, 
							(Lab) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(Lab?.IssuedElement == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Lab?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Lab?.Value as object) == null))))), 
						(@this) => @this?.IssuedElement, 
						System.ComponentModel.ListSortDirection.Ascending)))?.Value as object) as Quantity);
            var p_ = FHIRHelpers_4_0_001.ToQuantity(o_);
            var n_ = (context?.Operators.ConvertQuantityToString(p_) ?? "");
            var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
            var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
            var s_ = (context?.Operators.FirstOfList<Observation>(context?.Operators.ListSortBy<Observation>(context?.Operators.WhereOrNull<Observation>(LabList, 
							(Lab) => context?.Operators.And(context?.Operators.And(context?.Operators.And(context?.Operators.Not(((bool?)(Lab?.IssuedElement == null))), 
											context?.Operators.ElementInInterval<CqlDateTime>(FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement), 
												context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Encounter?.Period)), 
														context?.Operators.Quantity(1440m, 
															"minutes")), 
													true, 
													true), 
												null)), 
										context?.Operators.InList<string>(context?.Operators.Convert<string>((Lab?.StatusElement as object)), 
(new string[]
											{
												"final",
												"amended",
												"preliminary",
											} as IEnumerable<string>))), 
									context?.Operators.Not(((bool?)((Lab?.Value as object) == null))))), 
						(@this) => @this?.IssuedElement, 
						System.ComponentModel.ListSortDirection.Ascending)))?.IssuedElement;
            var t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
            var r_ = (context?.Operators.ConvertDateTimeToString(t_) ?? "");
            return context?.Operators.Concatenate(b_, 
				r_);
        };
        return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			u_);
    }

    private IEnumerable<string> Results_Value()
    {
        var c_ = this.Heart_rate();
        var d_ = context?.Operators.ToList<CqlCode>(c_);
        var e_ = context?.Operators.RetrieveByCodes<Observation>(d_, 
			typeof(Observation).GetProperty("Code"));
        var b_ = this.FirstPhysicalExamWithEncounterId(e_, 
			"FirstHeartRate");
        var g_ = this.Systolic_blood_pressure();
        var h_ = context?.Operators.ToList<CqlCode>(g_);
        var i_ = context?.Operators.RetrieveByCodes<Observation>(h_, 
			typeof(Observation).GetProperty("Code"));
        var f_ = this.FirstPhysicalExamWithEncounterId(i_, 
			"FirstSystolicBP");
        var k_ = this.Respiratory_rate();
        var l_ = context?.Operators.ToList<CqlCode>(k_);
        var m_ = context?.Operators.RetrieveByCodes<Observation>(l_, 
			typeof(Observation).GetProperty("Code"));
        var j_ = this.FirstPhysicalExamWithEncounterId(m_, 
			"FirstRespRate");
        var o_ = this.Body_temperature();
        var p_ = context?.Operators.RetrieveByValueSet<Observation>(o_, 
			typeof(Observation).GetProperty("Code"));
        var n_ = this.FirstPhysicalExamWithEncounterId(p_, 
			"FirstTemperature");
        var r_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
        var s_ = context?.Operators.ToList<CqlCode>(r_);
        var t_ = context?.Operators.RetrieveByCodes<Observation>(s_, 
			typeof(Observation).GetProperty("Code"));
        var q_ = this.FirstPhysicalExamWithEncounterId(t_, 
			"FirstO2Saturation");
        var v_ = this.Body_weight();
        var w_ = context?.Operators.RetrieveByValueSet<Observation>(v_, 
			typeof(Observation).GetProperty("Code"));
        var u_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(w_, 
			"FirstWeight");
        var y_ = this.Hematocrit_lab_test();
        var z_ = context?.Operators.RetrieveByValueSet<Observation>(y_, 
			typeof(Observation).GetProperty("Code"));
        var x_ = this.FirstLabTestWithEncounterId(z_, 
			"FirstHematocrit");
        var ab_ = this.White_blood_cells_count_lab_test();
        var ac_ = context?.Operators.RetrieveByValueSet<Observation>(ab_, 
			typeof(Observation).GetProperty("Code"));
        var aa_ = this.FirstLabTestWithEncounterId(ac_, 
			"FirstWhiteBloodCell");
        var ae_ = this.Potassium_lab_test();
        var af_ = context?.Operators.RetrieveByValueSet<Observation>(ae_, 
			typeof(Observation).GetProperty("Code"));
        var ad_ = this.FirstLabTestWithEncounterId(af_, 
			"FirstPotassium");
        var ah_ = this.Sodium_lab_test();
        var ai_ = context?.Operators.RetrieveByValueSet<Observation>(ah_, 
			typeof(Observation).GetProperty("Code"));
        var ag_ = this.FirstLabTestWithEncounterId(ai_, 
			"FirstSodium");
        var ak_ = this.Bicarbonate_lab_test();
        var al_ = context?.Operators.RetrieveByValueSet<Observation>(ak_, 
			typeof(Observation).GetProperty("Code"));
        var aj_ = this.FirstLabTestWithEncounterId(al_, 
			"FirstBicarbonate");
        var an_ = this.Creatinine_lab_test();
        var ao_ = context?.Operators.RetrieveByValueSet<Observation>(an_, 
			typeof(Observation).GetProperty("Code"));
        var am_ = this.FirstLabTestWithEncounterId(ao_, 
			"FirstCreatinine");
        var aq_ = this.Glucose_lab_test();
        var ar_ = context?.Operators.RetrieveByValueSet<Observation>(aq_, 
			typeof(Observation).GetProperty("Code"));
        var ap_ = this.FirstLabTestWithEncounterId(ar_, 
			"FirstGlucose");
        var a_ = (new IEnumerable<string>[]
		{
			b_,
			f_,
			j_,
			n_,
			q_,
			u_,
			x_,
			aa_,
			ad_,
			ag_,
			aj_,
			am_,
			ap_,
		} as IEnumerable<IEnumerable<string>>);
        return context?.Operators.FlattenList<string>(a_);
    }
    [CqlDeclaration("Results")]
    public IEnumerable<string> Results() => __Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        var a_ = context?.Operators.ConvertDateTimeToDate(BirthDateTime);
        var b_ = context?.Operators.ConvertDateTimeToDate(AsOf);
        return context?.Operators.DurationBetween(a_, 
			b_, 
			"year");
    }

    [CqlDeclaration("ToDate")]
    public CqlDateTime ToDate(CqlDateTime Value)
    {
        var a_ = context?.Operators.ComponentFrom(Value, 
			"year");
        var b_ = context?.Operators.ComponentFrom(Value, 
			"month");
        var c_ = context?.Operators.ComponentFrom(Value, 
			"day");
        var d_ = context?.Operators.TimezoneOffsetFrom(Value);
        return context?.Operators.DateTime(a_, 
			b_, 
			c_, 
((int?)0), 
((int?)0), 
((int?)0), 
((int?)0), 
			d_);
    }

    [CqlDeclaration("LengthOfStay")]
    public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
    {
        var a_ = context?.Operators.Start(Stay);
        var b_ = context?.Operators.End(Stay);
        return context?.Operators.DifferenceBetween(a_, 
			b_, 
			"day");
    }

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
    {
        var a_ = this.HospitalizationWithObservation(Encounter);
        return this.LengthInDays(a_);
    }

}