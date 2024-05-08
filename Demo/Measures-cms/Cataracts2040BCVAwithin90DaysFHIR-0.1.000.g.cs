﻿using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("Cataracts2040BCVAwithin90DaysFHIR", "0.1.000")]
public class Cataracts2040BCVAwithin90DaysFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_and_Subacute_Iridocyclitis;
    internal Lazy<CqlValueSet> __Amblyopia;
    internal Lazy<CqlValueSet> __Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart;
    internal Lazy<CqlValueSet> __Burn_Confined_to_Eye_and_Adnexa;
    internal Lazy<CqlValueSet> __Cataract_Congenital;
    internal Lazy<CqlValueSet> __Cataract_Mature_or_Hypermature;
    internal Lazy<CqlValueSet> __Cataract_Posterior_Polar;
    internal Lazy<CqlValueSet> __Cataract_Secondary_to_Ocular_Disorders;
    internal Lazy<CqlValueSet> __Cataract_Surgery;
    internal Lazy<CqlValueSet> __Central_Corneal_Ulcer;
    internal Lazy<CqlValueSet> __Certain_Types_of_Iridocyclitis;
    internal Lazy<CqlValueSet> __Choroidal_Degenerations;
    internal Lazy<CqlValueSet> __Choroidal_Detachment;
    internal Lazy<CqlValueSet> __Choroidal_Hemorrhage_and_Rupture;
    internal Lazy<CqlValueSet> __Chronic_Iridocyclitis;
    internal Lazy<CqlValueSet> __Cloudy_Cornea;
    internal Lazy<CqlValueSet> __Corneal_Edema;
    internal Lazy<CqlValueSet> __Degeneration_of_Macula_and_Posterior_Pole;
    internal Lazy<CqlValueSet> __Degenerative_Disorders_of_Globe;
    internal Lazy<CqlValueSet> __Diabetic_Macular_Edema;
    internal Lazy<CqlValueSet> __Diabetic_Retinopathy;
    internal Lazy<CqlValueSet> __Disorders_of_Cornea_Including_Corneal_Opacity;
    internal Lazy<CqlValueSet> __Disorders_of_Optic_Chiasm;
    internal Lazy<CqlValueSet> __Disorders_of_Visual_Cortex;
    internal Lazy<CqlValueSet> __Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis;
    internal Lazy<CqlValueSet> __Focal_Chorioretinitis_and_Focal_Retinochoroiditis;
    internal Lazy<CqlValueSet> __Glaucoma;
    internal Lazy<CqlValueSet> __Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes;
    internal Lazy<CqlValueSet> __Hereditary_Choroidal_Dystrophies;
    internal Lazy<CqlValueSet> __Hereditary_Corneal_Dystrophies;
    internal Lazy<CqlValueSet> __Hereditary_Retinal_Dystrophies;
    internal Lazy<CqlValueSet> __Hypotony_of_Eye;
    internal Lazy<CqlValueSet> __Injury_to_Optic_Nerve_and_Pathways;
    internal Lazy<CqlValueSet> __Macular_Scar_of_Posterior_Polar;
    internal Lazy<CqlValueSet> __Morgagnian_Cataract;
    internal Lazy<CqlValueSet> __Nystagmus_and_Other_Irregular_Eye_Movements;
    internal Lazy<CqlValueSet> __Open_Wound_of_Eyeball;
    internal Lazy<CqlValueSet> __Optic_Atrophy;
    internal Lazy<CqlValueSet> __Optic_Neuritis;
    internal Lazy<CqlValueSet> __Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis;
    internal Lazy<CqlValueSet> __Other_Background_Retinopathy_and_Retinal_Vascular_Changes;
    internal Lazy<CqlValueSet> __Other_Disorders_of_Optic_Nerve;
    internal Lazy<CqlValueSet> __Other_Endophthalmitis;
    internal Lazy<CqlValueSet> __Other_Proliferative_Retinopathy;
    internal Lazy<CqlValueSet> __Pathologic_Myopia;
    internal Lazy<CqlValueSet> __Posterior_Lenticonus;
    internal Lazy<CqlValueSet> __Prior_Penetrating_Keratoplasty;
    internal Lazy<CqlValueSet> __Purulent_Endophthalmitis;
    internal Lazy<CqlValueSet> __Retinal_Detachment_with_Retinal_Defect;
    internal Lazy<CqlValueSet> __Retinal_Vascular_Occlusion;
    internal Lazy<CqlValueSet> __Retrolental_Fibroplasias;
    internal Lazy<CqlValueSet> __Scleritis;
    internal Lazy<CqlValueSet> __Separation_of_Retinal_Layers;
    internal Lazy<CqlValueSet> __Traumatic_Cataract;
    internal Lazy<CqlValueSet> __Uveitis;
    internal Lazy<CqlValueSet> __Vascular_Disorders_of_Iris_and_Ciliary_Body;
    internal Lazy<CqlValueSet> __Visual_Acuity_20_40_or_Better;
    internal Lazy<CqlValueSet> __Visual_Field_Defects;
    internal Lazy<CqlCode> __Best_corrected_visual_acuity__observable_entity_;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Procedure>> __Cataract_Surgery_Between_January_and_September_of_Measurement_Period;
    internal Lazy<IEnumerable<Procedure>> __Initial_Population;
    internal Lazy<IEnumerable<Procedure>> __Denominator;
    internal Lazy<IEnumerable<Procedure>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Procedure>> __Numerator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public Cataracts2040BCVAwithin90DaysFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Acute_and_Subacute_Iridocyclitis = new Lazy<CqlValueSet>(this.Acute_and_Subacute_Iridocyclitis_Value);
        __Amblyopia = new Lazy<CqlValueSet>(this.Amblyopia_Value);
        __Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart = new Lazy<CqlValueSet>(this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart_Value);
        __Burn_Confined_to_Eye_and_Adnexa = new Lazy<CqlValueSet>(this.Burn_Confined_to_Eye_and_Adnexa_Value);
        __Cataract_Congenital = new Lazy<CqlValueSet>(this.Cataract_Congenital_Value);
        __Cataract_Mature_or_Hypermature = new Lazy<CqlValueSet>(this.Cataract_Mature_or_Hypermature_Value);
        __Cataract_Posterior_Polar = new Lazy<CqlValueSet>(this.Cataract_Posterior_Polar_Value);
        __Cataract_Secondary_to_Ocular_Disorders = new Lazy<CqlValueSet>(this.Cataract_Secondary_to_Ocular_Disorders_Value);
        __Cataract_Surgery = new Lazy<CqlValueSet>(this.Cataract_Surgery_Value);
        __Central_Corneal_Ulcer = new Lazy<CqlValueSet>(this.Central_Corneal_Ulcer_Value);
        __Certain_Types_of_Iridocyclitis = new Lazy<CqlValueSet>(this.Certain_Types_of_Iridocyclitis_Value);
        __Choroidal_Degenerations = new Lazy<CqlValueSet>(this.Choroidal_Degenerations_Value);
        __Choroidal_Detachment = new Lazy<CqlValueSet>(this.Choroidal_Detachment_Value);
        __Choroidal_Hemorrhage_and_Rupture = new Lazy<CqlValueSet>(this.Choroidal_Hemorrhage_and_Rupture_Value);
        __Chronic_Iridocyclitis = new Lazy<CqlValueSet>(this.Chronic_Iridocyclitis_Value);
        __Cloudy_Cornea = new Lazy<CqlValueSet>(this.Cloudy_Cornea_Value);
        __Corneal_Edema = new Lazy<CqlValueSet>(this.Corneal_Edema_Value);
        __Degeneration_of_Macula_and_Posterior_Pole = new Lazy<CqlValueSet>(this.Degeneration_of_Macula_and_Posterior_Pole_Value);
        __Degenerative_Disorders_of_Globe = new Lazy<CqlValueSet>(this.Degenerative_Disorders_of_Globe_Value);
        __Diabetic_Macular_Edema = new Lazy<CqlValueSet>(this.Diabetic_Macular_Edema_Value);
        __Diabetic_Retinopathy = new Lazy<CqlValueSet>(this.Diabetic_Retinopathy_Value);
        __Disorders_of_Cornea_Including_Corneal_Opacity = new Lazy<CqlValueSet>(this.Disorders_of_Cornea_Including_Corneal_Opacity_Value);
        __Disorders_of_Optic_Chiasm = new Lazy<CqlValueSet>(this.Disorders_of_Optic_Chiasm_Value);
        __Disorders_of_Visual_Cortex = new Lazy<CqlValueSet>(this.Disorders_of_Visual_Cortex_Value);
        __Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis = new Lazy<CqlValueSet>(this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis_Value);
        __Focal_Chorioretinitis_and_Focal_Retinochoroiditis = new Lazy<CqlValueSet>(this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis_Value);
        __Glaucoma = new Lazy<CqlValueSet>(this.Glaucoma_Value);
        __Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes = new Lazy<CqlValueSet>(this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes_Value);
        __Hereditary_Choroidal_Dystrophies = new Lazy<CqlValueSet>(this.Hereditary_Choroidal_Dystrophies_Value);
        __Hereditary_Corneal_Dystrophies = new Lazy<CqlValueSet>(this.Hereditary_Corneal_Dystrophies_Value);
        __Hereditary_Retinal_Dystrophies = new Lazy<CqlValueSet>(this.Hereditary_Retinal_Dystrophies_Value);
        __Hypotony_of_Eye = new Lazy<CqlValueSet>(this.Hypotony_of_Eye_Value);
        __Injury_to_Optic_Nerve_and_Pathways = new Lazy<CqlValueSet>(this.Injury_to_Optic_Nerve_and_Pathways_Value);
        __Macular_Scar_of_Posterior_Polar = new Lazy<CqlValueSet>(this.Macular_Scar_of_Posterior_Polar_Value);
        __Morgagnian_Cataract = new Lazy<CqlValueSet>(this.Morgagnian_Cataract_Value);
        __Nystagmus_and_Other_Irregular_Eye_Movements = new Lazy<CqlValueSet>(this.Nystagmus_and_Other_Irregular_Eye_Movements_Value);
        __Open_Wound_of_Eyeball = new Lazy<CqlValueSet>(this.Open_Wound_of_Eyeball_Value);
        __Optic_Atrophy = new Lazy<CqlValueSet>(this.Optic_Atrophy_Value);
        __Optic_Neuritis = new Lazy<CqlValueSet>(this.Optic_Neuritis_Value);
        __Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis = new Lazy<CqlValueSet>(this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis_Value);
        __Other_Background_Retinopathy_and_Retinal_Vascular_Changes = new Lazy<CqlValueSet>(this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes_Value);
        __Other_Disorders_of_Optic_Nerve = new Lazy<CqlValueSet>(this.Other_Disorders_of_Optic_Nerve_Value);
        __Other_Endophthalmitis = new Lazy<CqlValueSet>(this.Other_Endophthalmitis_Value);
        __Other_Proliferative_Retinopathy = new Lazy<CqlValueSet>(this.Other_Proliferative_Retinopathy_Value);
        __Pathologic_Myopia = new Lazy<CqlValueSet>(this.Pathologic_Myopia_Value);
        __Posterior_Lenticonus = new Lazy<CqlValueSet>(this.Posterior_Lenticonus_Value);
        __Prior_Penetrating_Keratoplasty = new Lazy<CqlValueSet>(this.Prior_Penetrating_Keratoplasty_Value);
        __Purulent_Endophthalmitis = new Lazy<CqlValueSet>(this.Purulent_Endophthalmitis_Value);
        __Retinal_Detachment_with_Retinal_Defect = new Lazy<CqlValueSet>(this.Retinal_Detachment_with_Retinal_Defect_Value);
        __Retinal_Vascular_Occlusion = new Lazy<CqlValueSet>(this.Retinal_Vascular_Occlusion_Value);
        __Retrolental_Fibroplasias = new Lazy<CqlValueSet>(this.Retrolental_Fibroplasias_Value);
        __Scleritis = new Lazy<CqlValueSet>(this.Scleritis_Value);
        __Separation_of_Retinal_Layers = new Lazy<CqlValueSet>(this.Separation_of_Retinal_Layers_Value);
        __Traumatic_Cataract = new Lazy<CqlValueSet>(this.Traumatic_Cataract_Value);
        __Uveitis = new Lazy<CqlValueSet>(this.Uveitis_Value);
        __Vascular_Disorders_of_Iris_and_Ciliary_Body = new Lazy<CqlValueSet>(this.Vascular_Disorders_of_Iris_and_Ciliary_Body_Value);
        __Visual_Acuity_20_40_or_Better = new Lazy<CqlValueSet>(this.Visual_Acuity_20_40_or_Better_Value);
        __Visual_Field_Defects = new Lazy<CqlValueSet>(this.Visual_Field_Defects_Value);
        __Best_corrected_visual_acuity__observable_entity_ = new Lazy<CqlCode>(this.Best_corrected_visual_acuity__observable_entity__Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Cataract_Surgery_Between_January_and_September_of_Measurement_Period = new Lazy<IEnumerable<Procedure>>(this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<IEnumerable<Procedure>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Procedure>>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Procedure>>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<IEnumerable<Procedure>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Acute_and_Subacute_Iridocyclitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241", null);

    [CqlDeclaration("Acute and Subacute Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241")]
	public CqlValueSet Acute_and_Subacute_Iridocyclitis() => 
		__Acute_and_Subacute_Iridocyclitis.Value;

	private CqlValueSet Amblyopia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448", null);

    [CqlDeclaration("Amblyopia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448")]
	public CqlValueSet Amblyopia() => 
		__Amblyopia.Value;

	private CqlValueSet Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560", null);

    [CqlDeclaration("Best Corrected Visual Acuity Exam Using Snellen Chart")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560")]
	public CqlValueSet Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart() => 
		__Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart.Value;

	private CqlValueSet Burn_Confined_to_Eye_and_Adnexa_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409", null);

    [CqlDeclaration("Burn Confined to Eye and Adnexa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409")]
	public CqlValueSet Burn_Confined_to_Eye_and_Adnexa() => 
		__Burn_Confined_to_Eye_and_Adnexa.Value;

	private CqlValueSet Cataract_Congenital_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412", null);

    [CqlDeclaration("Cataract Congenital")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412")]
	public CqlValueSet Cataract_Congenital() => 
		__Cataract_Congenital.Value;

	private CqlValueSet Cataract_Mature_or_Hypermature_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413", null);

    [CqlDeclaration("Cataract Mature or Hypermature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413")]
	public CqlValueSet Cataract_Mature_or_Hypermature() => 
		__Cataract_Mature_or_Hypermature.Value;

	private CqlValueSet Cataract_Posterior_Polar_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414", null);

    [CqlDeclaration("Cataract Posterior Polar")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414")]
	public CqlValueSet Cataract_Posterior_Polar() => 
		__Cataract_Posterior_Polar.Value;

	private CqlValueSet Cataract_Secondary_to_Ocular_Disorders_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410", null);

    [CqlDeclaration("Cataract Secondary to Ocular Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410")]
	public CqlValueSet Cataract_Secondary_to_Ocular_Disorders() => 
		__Cataract_Secondary_to_Ocular_Disorders.Value;

	private CqlValueSet Cataract_Surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411", null);

    [CqlDeclaration("Cataract Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411")]
	public CqlValueSet Cataract_Surgery() => 
		__Cataract_Surgery.Value;

	private CqlValueSet Central_Corneal_Ulcer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428", null);

    [CqlDeclaration("Central Corneal Ulcer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428")]
	public CqlValueSet Central_Corneal_Ulcer() => 
		__Central_Corneal_Ulcer.Value;

	private CqlValueSet Certain_Types_of_Iridocyclitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415", null);

    [CqlDeclaration("Certain Types of Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415")]
	public CqlValueSet Certain_Types_of_Iridocyclitis() => 
		__Certain_Types_of_Iridocyclitis.Value;

	private CqlValueSet Choroidal_Degenerations_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450", null);

    [CqlDeclaration("Choroidal Degenerations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450")]
	public CqlValueSet Choroidal_Degenerations() => 
		__Choroidal_Degenerations.Value;

	private CqlValueSet Choroidal_Detachment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451", null);

    [CqlDeclaration("Choroidal Detachment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451")]
	public CqlValueSet Choroidal_Detachment() => 
		__Choroidal_Detachment.Value;

	private CqlValueSet Choroidal_Hemorrhage_and_Rupture_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452", null);

    [CqlDeclaration("Choroidal Hemorrhage and Rupture")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452")]
	public CqlValueSet Choroidal_Hemorrhage_and_Rupture() => 
		__Choroidal_Hemorrhage_and_Rupture.Value;

	private CqlValueSet Chronic_Iridocyclitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416", null);

    [CqlDeclaration("Chronic Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416")]
	public CqlValueSet Chronic_Iridocyclitis() => 
		__Chronic_Iridocyclitis.Value;

	private CqlValueSet Cloudy_Cornea_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417", null);

    [CqlDeclaration("Cloudy Cornea")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417")]
	public CqlValueSet Cloudy_Cornea() => 
		__Cloudy_Cornea.Value;

	private CqlValueSet Corneal_Edema_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418", null);

    [CqlDeclaration("Corneal Edema")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418")]
	public CqlValueSet Corneal_Edema() => 
		__Corneal_Edema.Value;

	private CqlValueSet Degeneration_of_Macula_and_Posterior_Pole_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453", null);

    [CqlDeclaration("Degeneration of Macula and Posterior Pole")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453")]
	public CqlValueSet Degeneration_of_Macula_and_Posterior_Pole() => 
		__Degeneration_of_Macula_and_Posterior_Pole.Value;

	private CqlValueSet Degenerative_Disorders_of_Globe_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454", null);

    [CqlDeclaration("Degenerative Disorders of Globe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454")]
	public CqlValueSet Degenerative_Disorders_of_Globe() => 
		__Degenerative_Disorders_of_Globe.Value;

	private CqlValueSet Diabetic_Macular_Edema_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455", null);

    [CqlDeclaration("Diabetic Macular Edema")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455")]
	public CqlValueSet Diabetic_Macular_Edema() => 
		__Diabetic_Macular_Edema.Value;

	private CqlValueSet Diabetic_Retinopathy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy() => 
		__Diabetic_Retinopathy.Value;

	private CqlValueSet Disorders_of_Cornea_Including_Corneal_Opacity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419", null);

    [CqlDeclaration("Disorders of Cornea Including Corneal Opacity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419")]
	public CqlValueSet Disorders_of_Cornea_Including_Corneal_Opacity() => 
		__Disorders_of_Cornea_Including_Corneal_Opacity.Value;

	private CqlValueSet Disorders_of_Optic_Chiasm_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457", null);

    [CqlDeclaration("Disorders of Optic Chiasm")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457")]
	public CqlValueSet Disorders_of_Optic_Chiasm() => 
		__Disorders_of_Optic_Chiasm.Value;

	private CqlValueSet Disorders_of_Visual_Cortex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458", null);

    [CqlDeclaration("Disorders of Visual Cortex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458")]
	public CqlValueSet Disorders_of_Visual_Cortex() => 
		__Disorders_of_Visual_Cortex.Value;

	private CqlValueSet Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459", null);

    [CqlDeclaration("Disseminated Chorioretinitis and Disseminated Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459")]
	public CqlValueSet Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis() => 
		__Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis.Value;

	private CqlValueSet Focal_Chorioretinitis_and_Focal_Retinochoroiditis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460", null);

    [CqlDeclaration("Focal Chorioretinitis and Focal Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460")]
	public CqlValueSet Focal_Chorioretinitis_and_Focal_Retinochoroiditis() => 
		__Focal_Chorioretinitis_and_Focal_Retinochoroiditis.Value;

	private CqlValueSet Glaucoma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423", null);

    [CqlDeclaration("Glaucoma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423")]
	public CqlValueSet Glaucoma() => 
		__Glaucoma.Value;

	private CqlValueSet Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461", null);

    [CqlDeclaration("Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461")]
	public CqlValueSet Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes() => 
		__Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes.Value;

	private CqlValueSet Hereditary_Choroidal_Dystrophies_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462", null);

    [CqlDeclaration("Hereditary Choroidal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462")]
	public CqlValueSet Hereditary_Choroidal_Dystrophies() => 
		__Hereditary_Choroidal_Dystrophies.Value;

	private CqlValueSet Hereditary_Corneal_Dystrophies_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424", null);

    [CqlDeclaration("Hereditary Corneal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424")]
	public CqlValueSet Hereditary_Corneal_Dystrophies() => 
		__Hereditary_Corneal_Dystrophies.Value;

	private CqlValueSet Hereditary_Retinal_Dystrophies_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463", null);

    [CqlDeclaration("Hereditary Retinal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463")]
	public CqlValueSet Hereditary_Retinal_Dystrophies() => 
		__Hereditary_Retinal_Dystrophies.Value;

	private CqlValueSet Hypotony_of_Eye_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426", null);

    [CqlDeclaration("Hypotony of Eye")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426")]
	public CqlValueSet Hypotony_of_Eye() => 
		__Hypotony_of_Eye.Value;

	private CqlValueSet Injury_to_Optic_Nerve_and_Pathways_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427", null);

    [CqlDeclaration("Injury to Optic Nerve and Pathways")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427")]
	public CqlValueSet Injury_to_Optic_Nerve_and_Pathways() => 
		__Injury_to_Optic_Nerve_and_Pathways.Value;

	private CqlValueSet Macular_Scar_of_Posterior_Polar_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559", null);

    [CqlDeclaration("Macular Scar of Posterior Polar")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559")]
	public CqlValueSet Macular_Scar_of_Posterior_Polar() => 
		__Macular_Scar_of_Posterior_Polar.Value;

	private CqlValueSet Morgagnian_Cataract_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558", null);

    [CqlDeclaration("Morgagnian Cataract")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558")]
	public CqlValueSet Morgagnian_Cataract() => 
		__Morgagnian_Cataract.Value;

	private CqlValueSet Nystagmus_and_Other_Irregular_Eye_Movements_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465", null);

    [CqlDeclaration("Nystagmus and Other Irregular Eye Movements")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465")]
	public CqlValueSet Nystagmus_and_Other_Irregular_Eye_Movements() => 
		__Nystagmus_and_Other_Irregular_Eye_Movements.Value;

	private CqlValueSet Open_Wound_of_Eyeball_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430", null);

    [CqlDeclaration("Open Wound of Eyeball")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430")]
	public CqlValueSet Open_Wound_of_Eyeball() => 
		__Open_Wound_of_Eyeball.Value;

	private CqlValueSet Optic_Atrophy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466", null);

    [CqlDeclaration("Optic Atrophy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466")]
	public CqlValueSet Optic_Atrophy() => 
		__Optic_Atrophy.Value;

	private CqlValueSet Optic_Neuritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467", null);

    [CqlDeclaration("Optic Neuritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467")]
	public CqlValueSet Optic_Neuritis() => 
		__Optic_Neuritis.Value;

	private CqlValueSet Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468", null);

    [CqlDeclaration("Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468")]
	public CqlValueSet Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis() => 
		__Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis.Value;

	private CqlValueSet Other_Background_Retinopathy_and_Retinal_Vascular_Changes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469", null);

    [CqlDeclaration("Other Background Retinopathy and Retinal Vascular Changes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469")]
	public CqlValueSet Other_Background_Retinopathy_and_Retinal_Vascular_Changes() => 
		__Other_Background_Retinopathy_and_Retinal_Vascular_Changes.Value;

	private CqlValueSet Other_Disorders_of_Optic_Nerve_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471", null);

    [CqlDeclaration("Other Disorders of Optic Nerve")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471")]
	public CqlValueSet Other_Disorders_of_Optic_Nerve() => 
		__Other_Disorders_of_Optic_Nerve.Value;

	private CqlValueSet Other_Endophthalmitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473", null);

    [CqlDeclaration("Other Endophthalmitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473")]
	public CqlValueSet Other_Endophthalmitis() => 
		__Other_Endophthalmitis.Value;

	private CqlValueSet Other_Proliferative_Retinopathy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480", null);

    [CqlDeclaration("Other Proliferative Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480")]
	public CqlValueSet Other_Proliferative_Retinopathy() => 
		__Other_Proliferative_Retinopathy.Value;

	private CqlValueSet Pathologic_Myopia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432", null);

    [CqlDeclaration("Pathologic Myopia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432")]
	public CqlValueSet Pathologic_Myopia() => 
		__Pathologic_Myopia.Value;

	private CqlValueSet Posterior_Lenticonus_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433", null);

    [CqlDeclaration("Posterior Lenticonus")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433")]
	public CqlValueSet Posterior_Lenticonus() => 
		__Posterior_Lenticonus.Value;

	private CqlValueSet Prior_Penetrating_Keratoplasty_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475", null);

    [CqlDeclaration("Prior Penetrating Keratoplasty")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475")]
	public CqlValueSet Prior_Penetrating_Keratoplasty() => 
		__Prior_Penetrating_Keratoplasty.Value;

	private CqlValueSet Purulent_Endophthalmitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477", null);

    [CqlDeclaration("Purulent Endophthalmitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477")]
	public CqlValueSet Purulent_Endophthalmitis() => 
		__Purulent_Endophthalmitis.Value;

	private CqlValueSet Retinal_Detachment_with_Retinal_Defect_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478", null);

    [CqlDeclaration("Retinal Detachment with Retinal Defect")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478")]
	public CqlValueSet Retinal_Detachment_with_Retinal_Defect() => 
		__Retinal_Detachment_with_Retinal_Defect.Value;

	private CqlValueSet Retinal_Vascular_Occlusion_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479", null);

    [CqlDeclaration("Retinal Vascular Occlusion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479")]
	public CqlValueSet Retinal_Vascular_Occlusion() => 
		__Retinal_Vascular_Occlusion.Value;

	private CqlValueSet Retrolental_Fibroplasias_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438", null);

    [CqlDeclaration("Retrolental Fibroplasias")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438")]
	public CqlValueSet Retrolental_Fibroplasias() => 
		__Retrolental_Fibroplasias.Value;

	private CqlValueSet Scleritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1", null);

    [CqlDeclaration("Scleritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1")]
	public CqlValueSet Scleritis() => 
		__Scleritis.Value;

	private CqlValueSet Separation_of_Retinal_Layers_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482", null);

    [CqlDeclaration("Separation of Retinal Layers")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482")]
	public CqlValueSet Separation_of_Retinal_Layers() => 
		__Separation_of_Retinal_Layers.Value;

	private CqlValueSet Traumatic_Cataract_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443", null);

    [CqlDeclaration("Traumatic Cataract")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443")]
	public CqlValueSet Traumatic_Cataract() => 
		__Traumatic_Cataract.Value;

	private CqlValueSet Uveitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444", null);

    [CqlDeclaration("Uveitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444")]
	public CqlValueSet Uveitis() => 
		__Uveitis.Value;

	private CqlValueSet Vascular_Disorders_of_Iris_and_Ciliary_Body_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445", null);

    [CqlDeclaration("Vascular Disorders of Iris and Ciliary Body")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445")]
	public CqlValueSet Vascular_Disorders_of_Iris_and_Ciliary_Body() => 
		__Vascular_Disorders_of_Iris_and_Ciliary_Body.Value;

	private CqlValueSet Visual_Acuity_20_40_or_Better_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483", null);

    [CqlDeclaration("Visual Acuity 20/40 or Better")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483")]
	public CqlValueSet Visual_Acuity_20_40_or_Better() => 
		__Visual_Acuity_20_40_or_Better.Value;

	private CqlValueSet Visual_Field_Defects_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446", null);

    [CqlDeclaration("Visual Field Defects")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446")]
	public CqlValueSet Visual_Field_Defects() => 
		__Visual_Field_Defects.Value;

	private CqlCode Best_corrected_visual_acuity__observable_entity__Value() => 
		new CqlCode("419775003", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Best corrected visual acuity (observable entity)")]
	public CqlCode Best_corrected_visual_acuity__observable_entity_() => 
		__Best_corrected_visual_acuity__observable_entity_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("419775003", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Cataract_Surgery();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure CataractSurgery)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			DataType f_ = CataractSurgery?.Performed;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.toInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, null);
			object k_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlDateTime o_ = context.Operators.End(e_);
			CqlQuantity p_ = context.Operators.Quantity(92m, "days");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			bool? r_ = context.Operators.SameOrBefore(m_, q_, null);
			bool? s_ = context.Operators.And(i_, r_);
			Code<EventStatus> t_ = CataractSurgery?.StatusElement;
			EventStatus? u_ = t_?.Value;
			string v_ = context.Operators.Convert<string>(u_);
			bool? w_ = context.Operators.Equal(v_, "completed");
			bool? x_ = context.Operators.And(s_, w_);

			return x_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cataract Surgery Between January and September of Measurement Period")]
	public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period() => 
		__Cataract_Surgery_Between_January_and_September_of_Measurement_Period.Value;

	private IEnumerable<Procedure> Initial_Population_Value()
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		bool? b_(Procedure CataractSurgeryPerformed)
		{
			Patient d_ = this.Patient();
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 18);

			return l_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Procedure> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Procedure> Denominator_Value()
	{
		IEnumerable<Procedure> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Procedure> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Procedure> Denominator_Exclusions_Value()
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			CqlValueSet d_ = this.Acute_and_Subacute_Iridocyclitis();
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			CqlValueSet f_ = this.Amblyopia();
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			IEnumerable<Condition> h_ = context.Operators.ListUnion<Condition>(e_, g_);
			CqlValueSet i_ = this.Burn_Confined_to_Eye_and_Adnexa();
			IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			CqlValueSet k_ = this.Cataract_Secondary_to_Ocular_Disorders();
			IEnumerable<Condition> l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
			IEnumerable<Condition> m_ = context.Operators.ListUnion<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.ListUnion<Condition>(h_, m_);
			CqlValueSet o_ = this.Cataract_Congenital();
			IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
			CqlValueSet q_ = this.Cataract_Mature_or_Hypermature();
			IEnumerable<Condition> r_ = context.Operators.RetrieveByValueSet<Condition>(q_, null);
			IEnumerable<Condition> s_ = context.Operators.ListUnion<Condition>(p_, r_);
			IEnumerable<Condition> t_ = context.Operators.ListUnion<Condition>(n_, s_);
			CqlValueSet u_ = this.Cataract_Posterior_Polar();
			IEnumerable<Condition> v_ = context.Operators.RetrieveByValueSet<Condition>(u_, null);
			CqlValueSet w_ = this.Central_Corneal_Ulcer();
			IEnumerable<Condition> x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			IEnumerable<Condition> y_ = context.Operators.ListUnion<Condition>(v_, x_);
			IEnumerable<Condition> z_ = context.Operators.ListUnion<Condition>(t_, y_);
			CqlValueSet aa_ = this.Certain_Types_of_Iridocyclitis();
			IEnumerable<Condition> ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, null);
			CqlValueSet ac_ = this.Choroidal_Degenerations();
			IEnumerable<Condition> ad_ = context.Operators.RetrieveByValueSet<Condition>(ac_, null);
			IEnumerable<Condition> ae_ = context.Operators.ListUnion<Condition>(ab_, ad_);
			IEnumerable<Condition> af_ = context.Operators.ListUnion<Condition>(z_, ae_);
			CqlValueSet ag_ = this.Choroidal_Detachment();
			IEnumerable<Condition> ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, null);
			CqlValueSet ai_ = this.Choroidal_Hemorrhage_and_Rupture();
			IEnumerable<Condition> aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, null);
			IEnumerable<Condition> ak_ = context.Operators.ListUnion<Condition>(ah_, aj_);
			IEnumerable<Condition> al_ = context.Operators.ListUnion<Condition>(af_, ak_);
			CqlValueSet am_ = this.Chronic_Iridocyclitis();
			IEnumerable<Condition> an_ = context.Operators.RetrieveByValueSet<Condition>(am_, null);
			CqlValueSet ao_ = this.Cloudy_Cornea();
			IEnumerable<Condition> ap_ = context.Operators.RetrieveByValueSet<Condition>(ao_, null);
			IEnumerable<Condition> aq_ = context.Operators.ListUnion<Condition>(an_, ap_);
			IEnumerable<Condition> ar_ = context.Operators.ListUnion<Condition>(al_, aq_);
			CqlValueSet as_ = this.Corneal_Edema();
			IEnumerable<Condition> at_ = context.Operators.RetrieveByValueSet<Condition>(as_, null);
			CqlValueSet au_ = this.Disorders_of_Cornea_Including_Corneal_Opacity();
			IEnumerable<Condition> av_ = context.Operators.RetrieveByValueSet<Condition>(au_, null);
			IEnumerable<Condition> aw_ = context.Operators.ListUnion<Condition>(at_, av_);
			IEnumerable<Condition> ax_ = context.Operators.ListUnion<Condition>(ar_, aw_);
			CqlValueSet ay_ = this.Degeneration_of_Macula_and_Posterior_Pole();
			IEnumerable<Condition> az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, null);
			CqlValueSet ba_ = this.Degenerative_Disorders_of_Globe();
			IEnumerable<Condition> bb_ = context.Operators.RetrieveByValueSet<Condition>(ba_, null);
			IEnumerable<Condition> bc_ = context.Operators.ListUnion<Condition>(az_, bb_);
			IEnumerable<Condition> bd_ = context.Operators.ListUnion<Condition>(ax_, bc_);
			CqlValueSet be_ = this.Diabetic_Macular_Edema();
			IEnumerable<Condition> bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, null);
			CqlValueSet bg_ = this.Diabetic_Retinopathy();
			IEnumerable<Condition> bh_ = context.Operators.RetrieveByValueSet<Condition>(bg_, null);
			IEnumerable<Condition> bi_ = context.Operators.ListUnion<Condition>(bf_, bh_);
			IEnumerable<Condition> bj_ = context.Operators.ListUnion<Condition>(bd_, bi_);
			CqlValueSet bk_ = this.Disorders_of_Optic_Chiasm();
			IEnumerable<Condition> bl_ = context.Operators.RetrieveByValueSet<Condition>(bk_, null);
			CqlValueSet bm_ = this.Disorders_of_Visual_Cortex();
			IEnumerable<Condition> bn_ = context.Operators.RetrieveByValueSet<Condition>(bm_, null);
			IEnumerable<Condition> bo_ = context.Operators.ListUnion<Condition>(bl_, bn_);
			IEnumerable<Condition> bp_ = context.Operators.ListUnion<Condition>(bj_, bo_);
			CqlValueSet bq_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis();
			IEnumerable<Condition> br_ = context.Operators.RetrieveByValueSet<Condition>(bq_, null);
			CqlValueSet bs_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis();
			IEnumerable<Condition> bt_ = context.Operators.RetrieveByValueSet<Condition>(bs_, null);
			IEnumerable<Condition> bu_ = context.Operators.ListUnion<Condition>(br_, bt_);
			IEnumerable<Condition> bv_ = context.Operators.ListUnion<Condition>(bp_, bu_);
			CqlValueSet bw_ = this.Glaucoma();
			IEnumerable<Condition> bx_ = context.Operators.RetrieveByValueSet<Condition>(bw_, null);
			CqlValueSet by_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes();
			IEnumerable<Condition> bz_ = context.Operators.RetrieveByValueSet<Condition>(by_, null);
			IEnumerable<Condition> ca_ = context.Operators.ListUnion<Condition>(bx_, bz_);
			IEnumerable<Condition> cb_ = context.Operators.ListUnion<Condition>(bv_, ca_);
			CqlValueSet cc_ = this.Hereditary_Choroidal_Dystrophies();
			IEnumerable<Condition> cd_ = context.Operators.RetrieveByValueSet<Condition>(cc_, null);
			CqlValueSet ce_ = this.Hereditary_Corneal_Dystrophies();
			IEnumerable<Condition> cf_ = context.Operators.RetrieveByValueSet<Condition>(ce_, null);
			IEnumerable<Condition> cg_ = context.Operators.ListUnion<Condition>(cd_, cf_);
			IEnumerable<Condition> ch_ = context.Operators.ListUnion<Condition>(cb_, cg_);
			CqlValueSet ci_ = this.Hereditary_Retinal_Dystrophies();
			IEnumerable<Condition> cj_ = context.Operators.RetrieveByValueSet<Condition>(ci_, null);
			CqlValueSet ck_ = this.Hypotony_of_Eye();
			IEnumerable<Condition> cl_ = context.Operators.RetrieveByValueSet<Condition>(ck_, null);
			IEnumerable<Condition> cm_ = context.Operators.ListUnion<Condition>(cj_, cl_);
			IEnumerable<Condition> cn_ = context.Operators.ListUnion<Condition>(ch_, cm_);
			CqlValueSet co_ = this.Injury_to_Optic_Nerve_and_Pathways();
			IEnumerable<Condition> cp_ = context.Operators.RetrieveByValueSet<Condition>(co_, null);
			CqlValueSet cq_ = this.Macular_Scar_of_Posterior_Polar();
			IEnumerable<Condition> cr_ = context.Operators.RetrieveByValueSet<Condition>(cq_, null);
			IEnumerable<Condition> cs_ = context.Operators.ListUnion<Condition>(cp_, cr_);
			IEnumerable<Condition> ct_ = context.Operators.ListUnion<Condition>(cn_, cs_);
			CqlValueSet cu_ = this.Morgagnian_Cataract();
			IEnumerable<Condition> cv_ = context.Operators.RetrieveByValueSet<Condition>(cu_, null);
			CqlValueSet cw_ = this.Nystagmus_and_Other_Irregular_Eye_Movements();
			IEnumerable<Condition> cx_ = context.Operators.RetrieveByValueSet<Condition>(cw_, null);
			IEnumerable<Condition> cy_ = context.Operators.ListUnion<Condition>(cv_, cx_);
			IEnumerable<Condition> cz_ = context.Operators.ListUnion<Condition>(ct_, cy_);
			CqlValueSet da_ = this.Open_Wound_of_Eyeball();
			IEnumerable<Condition> db_ = context.Operators.RetrieveByValueSet<Condition>(da_, null);
			CqlValueSet dc_ = this.Optic_Atrophy();
			IEnumerable<Condition> dd_ = context.Operators.RetrieveByValueSet<Condition>(dc_, null);
			IEnumerable<Condition> de_ = context.Operators.ListUnion<Condition>(db_, dd_);
			IEnumerable<Condition> df_ = context.Operators.ListUnion<Condition>(cz_, de_);
			CqlValueSet dg_ = this.Optic_Neuritis();
			IEnumerable<Condition> dh_ = context.Operators.RetrieveByValueSet<Condition>(dg_, null);
			CqlValueSet di_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis();
			IEnumerable<Condition> dj_ = context.Operators.RetrieveByValueSet<Condition>(di_, null);
			IEnumerable<Condition> dk_ = context.Operators.ListUnion<Condition>(dh_, dj_);
			IEnumerable<Condition> dl_ = context.Operators.ListUnion<Condition>(df_, dk_);
			CqlValueSet dm_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes();
			IEnumerable<Condition> dn_ = context.Operators.RetrieveByValueSet<Condition>(dm_, null);
			CqlValueSet do_ = this.Other_Disorders_of_Optic_Nerve();
			IEnumerable<Condition> dp_ = context.Operators.RetrieveByValueSet<Condition>(do_, null);
			IEnumerable<Condition> dq_ = context.Operators.ListUnion<Condition>(dn_, dp_);
			IEnumerable<Condition> dr_ = context.Operators.ListUnion<Condition>(dl_, dq_);
			CqlValueSet ds_ = this.Other_Endophthalmitis();
			IEnumerable<Condition> dt_ = context.Operators.RetrieveByValueSet<Condition>(ds_, null);
			CqlValueSet du_ = this.Other_Proliferative_Retinopathy();
			IEnumerable<Condition> dv_ = context.Operators.RetrieveByValueSet<Condition>(du_, null);
			IEnumerable<Condition> dw_ = context.Operators.ListUnion<Condition>(dt_, dv_);
			IEnumerable<Condition> dx_ = context.Operators.ListUnion<Condition>(dr_, dw_);
			CqlValueSet dy_ = this.Pathologic_Myopia();
			IEnumerable<Condition> dz_ = context.Operators.RetrieveByValueSet<Condition>(dy_, null);
			CqlValueSet ea_ = this.Posterior_Lenticonus();
			IEnumerable<Condition> eb_ = context.Operators.RetrieveByValueSet<Condition>(ea_, null);
			IEnumerable<Condition> ec_ = context.Operators.ListUnion<Condition>(dz_, eb_);
			IEnumerable<Condition> ed_ = context.Operators.ListUnion<Condition>(dx_, ec_);
			CqlValueSet ee_ = this.Prior_Penetrating_Keratoplasty();
			IEnumerable<Condition> ef_ = context.Operators.RetrieveByValueSet<Condition>(ee_, null);
			CqlValueSet eg_ = this.Purulent_Endophthalmitis();
			IEnumerable<Condition> eh_ = context.Operators.RetrieveByValueSet<Condition>(eg_, null);
			IEnumerable<Condition> ei_ = context.Operators.ListUnion<Condition>(ef_, eh_);
			IEnumerable<Condition> ej_ = context.Operators.ListUnion<Condition>(ed_, ei_);
			CqlValueSet ek_ = this.Retinal_Detachment_with_Retinal_Defect();
			IEnumerable<Condition> el_ = context.Operators.RetrieveByValueSet<Condition>(ek_, null);
			CqlValueSet em_ = this.Retinal_Vascular_Occlusion();
			IEnumerable<Condition> en_ = context.Operators.RetrieveByValueSet<Condition>(em_, null);
			IEnumerable<Condition> eo_ = context.Operators.ListUnion<Condition>(el_, en_);
			IEnumerable<Condition> ep_ = context.Operators.ListUnion<Condition>(ej_, eo_);
			CqlValueSet eq_ = this.Retrolental_Fibroplasias();
			IEnumerable<Condition> er_ = context.Operators.RetrieveByValueSet<Condition>(eq_, null);
			CqlValueSet es_ = this.Scleritis();
			IEnumerable<Condition> et_ = context.Operators.RetrieveByValueSet<Condition>(es_, null);
			IEnumerable<Condition> eu_ = context.Operators.ListUnion<Condition>(er_, et_);
			IEnumerable<Condition> ev_ = context.Operators.ListUnion<Condition>(ep_, eu_);
			CqlValueSet ew_ = this.Separation_of_Retinal_Layers();
			IEnumerable<Condition> ex_ = context.Operators.RetrieveByValueSet<Condition>(ew_, null);
			CqlValueSet ey_ = this.Traumatic_Cataract();
			IEnumerable<Condition> ez_ = context.Operators.RetrieveByValueSet<Condition>(ey_, null);
			IEnumerable<Condition> fa_ = context.Operators.ListUnion<Condition>(ex_, ez_);
			IEnumerable<Condition> fb_ = context.Operators.ListUnion<Condition>(ev_, fa_);
			CqlValueSet fc_ = this.Uveitis();
			IEnumerable<Condition> fd_ = context.Operators.RetrieveByValueSet<Condition>(fc_, null);
			CqlValueSet fe_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body();
			IEnumerable<Condition> ff_ = context.Operators.RetrieveByValueSet<Condition>(fe_, null);
			IEnumerable<Condition> fg_ = context.Operators.ListUnion<Condition>(fd_, ff_);
			IEnumerable<Condition> fh_ = context.Operators.ListUnion<Condition>(fb_, fg_);
			CqlValueSet fi_ = this.Visual_Field_Defects();
			IEnumerable<Condition> fj_ = context.Operators.RetrieveByValueSet<Condition>(fi_, null);
			IEnumerable<Condition> fk_ = context.Operators.ListUnion<Condition>(fh_, fj_);
			bool? fl_(Condition ComorbidDiagnosis)
			{
				CqlInterval<CqlDateTime> fp_ = QICoreCommon_2_0_000.prevalenceInterval(ComorbidDiagnosis);
				DataType fq_ = CataractSurgeryPerformed?.Performed;
				object fr_ = FHIRHelpers_4_3_000.ToValue(fq_);
				CqlInterval<CqlDateTime> fs_ = QICoreCommon_2_0_000.toInterval(fr_);
				bool? ft_ = context.Operators.OverlapsBefore(fp_, fs_, null);
				bool? fu_ = QICoreCommon_2_0_000.isActive(ComorbidDiagnosis);
				bool? fv_ = context.Operators.And(ft_, fu_);

				return fv_;
			};
			IEnumerable<Condition> fm_ = context.Operators.Where<Condition>(fk_, fl_);
			Procedure fn_(Condition ComorbidDiagnosis) => 
				CataractSurgeryPerformed;
			IEnumerable<Procedure> fo_ = context.Operators.Select<Condition, Procedure>(fm_, fn_);

			return fo_;
		};
		IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Procedure> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Procedure> Numerator_Value()
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			CqlCode d_ = this.Best_corrected_visual_acuity__observable_entity_();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			CqlValueSet g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart();
			IEnumerable<Observation> h_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
			IEnumerable<Observation> i_ = context.Operators.ListUnion<Observation>(f_, h_);
			bool? j_(Observation VisualAcuityExamPerformed)
			{
				DataType n_ = VisualAcuityExamPerformed?.Effective;
				object o_ = FHIRHelpers_4_3_000.ToValue(n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				DataType r_ = CataractSurgeryPerformed?.Performed;
				object s_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval(s_);
				CqlDateTime u_ = context.Operators.End(t_);
				object w_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.toInterval(w_);
				CqlDateTime y_ = context.Operators.End(x_);
				CqlQuantity z_ = context.Operators.Quantity(90m, "days");
				CqlDateTime aa_ = context.Operators.Add(y_, z_);
				CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(u_, aa_, false, true);
				bool? ac_ = context.Operators.In<CqlDateTime>(q_, ab_, "day");
				object ae_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.toInterval(ae_);
				CqlDateTime ag_ = context.Operators.End(af_);
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
				bool? ai_ = context.Operators.And(ac_, ah_);
				Code<ObservationStatus> aj_ = VisualAcuityExamPerformed?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				Code<ObservationStatus> al_ = context.Operators.Convert<Code<ObservationStatus>>(ak_);
				string am_ = context.Operators.Convert<string>(al_);
				string[] an_ = new string[]
				{
					"final",
					"amended",
					"corrected",
					"preliminary",
				};
				bool? ao_ = context.Operators.In<string>(am_, (an_ as IEnumerable<string>));
				bool? ap_ = context.Operators.And(ai_, ao_);
				DataType aq_ = VisualAcuityExamPerformed?.Value;
				object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
				CqlValueSet as_ = this.Visual_Acuity_20_40_or_Better();
				bool? at_ = context.Operators.ConceptInValueSet((ar_ as CqlConcept), as_);
				bool? au_ = context.Operators.And(ap_, at_);

				return au_;
			};
			IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
			Procedure l_(Observation VisualAcuityExamPerformed) => 
				CataractSurgeryPerformed;
			IEnumerable<Procedure> m_ = context.Operators.Select<Observation, Procedure>(k_, l_);

			return m_;
		};
		IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Procedure> Numerator() => 
		__Numerator.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
