using System;
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period_Value()
	{
		var a_ = this.Cataract_Surgery();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure CataractSurgery)
		{
			var e_ = this.Measurement_Period();
			var f_ = FHIRHelpers_4_3_000.ToValue(CataractSurgery?.Performed);
			var g_ = QICoreCommon_2_0_000.toInterval(f_);
			var h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);
			var j_ = QICoreCommon_2_0_000.toInterval(f_);
			var k_ = context.Operators.Start(j_);
			var m_ = context.Operators.End(e_);
			var n_ = context.Operators.Quantity(92m, "days");
			var o_ = context.Operators.Subtract(m_, n_);
			var p_ = context.Operators.SameOrBefore(k_, o_, null);
			var q_ = context.Operators.And(h_, p_);
			var r_ = context.Operators.Convert<string>(CataractSurgery?.StatusElement?.Value);
			var s_ = context.Operators.Equal(r_, "completed");
			var t_ = context.Operators.And(q_, s_);

			return t_;
		};
		var d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cataract Surgery Between January and September of Measurement Period")]
	public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period() => 
		__Cataract_Surgery_Between_January_and_September_of_Measurement_Period.Value;

	private IEnumerable<Procedure> Initial_Population_Value()
	{
		var a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		bool? b_(Procedure CataractSurgeryPerformed)
		{
			var d_ = this.Patient();
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = this.Measurement_Period();
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.GreaterOrEqual(i_, 18);

			return j_;
		};
		var c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Procedure> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Procedure> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Procedure> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Procedure> Denominator_Exclusions_Value()
	{
		var a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			var d_ = this.Acute_and_Subacute_Iridocyclitis();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			var f_ = this.Amblyopia();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			var h_ = context.Operators.ListUnion<Condition>(e_, g_);
			var i_ = this.Burn_Confined_to_Eye_and_Adnexa();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			var k_ = this.Cataract_Secondary_to_Ocular_Disorders();
			var l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
			var m_ = context.Operators.ListUnion<Condition>(j_, l_);
			var n_ = context.Operators.ListUnion<Condition>(h_, m_);
			var o_ = this.Cataract_Congenital();
			var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
			var q_ = this.Cataract_Mature_or_Hypermature();
			var r_ = context.Operators.RetrieveByValueSet<Condition>(q_, null);
			var s_ = context.Operators.ListUnion<Condition>(p_, r_);
			var t_ = context.Operators.ListUnion<Condition>(n_, s_);
			var u_ = this.Cataract_Posterior_Polar();
			var v_ = context.Operators.RetrieveByValueSet<Condition>(u_, null);
			var w_ = this.Central_Corneal_Ulcer();
			var x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			var y_ = context.Operators.ListUnion<Condition>(v_, x_);
			var z_ = context.Operators.ListUnion<Condition>(t_, y_);
			var aa_ = this.Certain_Types_of_Iridocyclitis();
			var ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, null);
			var ac_ = this.Choroidal_Degenerations();
			var ad_ = context.Operators.RetrieveByValueSet<Condition>(ac_, null);
			var ae_ = context.Operators.ListUnion<Condition>(ab_, ad_);
			var af_ = context.Operators.ListUnion<Condition>(z_, ae_);
			var ag_ = this.Choroidal_Detachment();
			var ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, null);
			var ai_ = this.Choroidal_Hemorrhage_and_Rupture();
			var aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, null);
			var ak_ = context.Operators.ListUnion<Condition>(ah_, aj_);
			var al_ = context.Operators.ListUnion<Condition>(af_, ak_);
			var am_ = this.Chronic_Iridocyclitis();
			var an_ = context.Operators.RetrieveByValueSet<Condition>(am_, null);
			var ao_ = this.Cloudy_Cornea();
			var ap_ = context.Operators.RetrieveByValueSet<Condition>(ao_, null);
			var aq_ = context.Operators.ListUnion<Condition>(an_, ap_);
			var ar_ = context.Operators.ListUnion<Condition>(al_, aq_);
			var as_ = this.Corneal_Edema();
			var at_ = context.Operators.RetrieveByValueSet<Condition>(as_, null);
			var au_ = this.Disorders_of_Cornea_Including_Corneal_Opacity();
			var av_ = context.Operators.RetrieveByValueSet<Condition>(au_, null);
			var aw_ = context.Operators.ListUnion<Condition>(at_, av_);
			var ax_ = context.Operators.ListUnion<Condition>(ar_, aw_);
			var ay_ = this.Degeneration_of_Macula_and_Posterior_Pole();
			var az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, null);
			var ba_ = this.Degenerative_Disorders_of_Globe();
			var bb_ = context.Operators.RetrieveByValueSet<Condition>(ba_, null);
			var bc_ = context.Operators.ListUnion<Condition>(az_, bb_);
			var bd_ = context.Operators.ListUnion<Condition>(ax_, bc_);
			var be_ = this.Diabetic_Macular_Edema();
			var bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, null);
			var bg_ = this.Diabetic_Retinopathy();
			var bh_ = context.Operators.RetrieveByValueSet<Condition>(bg_, null);
			var bi_ = context.Operators.ListUnion<Condition>(bf_, bh_);
			var bj_ = context.Operators.ListUnion<Condition>(bd_, bi_);
			var bk_ = this.Disorders_of_Optic_Chiasm();
			var bl_ = context.Operators.RetrieveByValueSet<Condition>(bk_, null);
			var bm_ = this.Disorders_of_Visual_Cortex();
			var bn_ = context.Operators.RetrieveByValueSet<Condition>(bm_, null);
			var bo_ = context.Operators.ListUnion<Condition>(bl_, bn_);
			var bp_ = context.Operators.ListUnion<Condition>(bj_, bo_);
			var bq_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis();
			var br_ = context.Operators.RetrieveByValueSet<Condition>(bq_, null);
			var bs_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis();
			var bt_ = context.Operators.RetrieveByValueSet<Condition>(bs_, null);
			var bu_ = context.Operators.ListUnion<Condition>(br_, bt_);
			var bv_ = context.Operators.ListUnion<Condition>(bp_, bu_);
			var bw_ = this.Glaucoma();
			var bx_ = context.Operators.RetrieveByValueSet<Condition>(bw_, null);
			var by_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes();
			var bz_ = context.Operators.RetrieveByValueSet<Condition>(by_, null);
			var ca_ = context.Operators.ListUnion<Condition>(bx_, bz_);
			var cb_ = context.Operators.ListUnion<Condition>(bv_, ca_);
			var cc_ = this.Hereditary_Choroidal_Dystrophies();
			var cd_ = context.Operators.RetrieveByValueSet<Condition>(cc_, null);
			var ce_ = this.Hereditary_Corneal_Dystrophies();
			var cf_ = context.Operators.RetrieveByValueSet<Condition>(ce_, null);
			var cg_ = context.Operators.ListUnion<Condition>(cd_, cf_);
			var ch_ = context.Operators.ListUnion<Condition>(cb_, cg_);
			var ci_ = this.Hereditary_Retinal_Dystrophies();
			var cj_ = context.Operators.RetrieveByValueSet<Condition>(ci_, null);
			var ck_ = this.Hypotony_of_Eye();
			var cl_ = context.Operators.RetrieveByValueSet<Condition>(ck_, null);
			var cm_ = context.Operators.ListUnion<Condition>(cj_, cl_);
			var cn_ = context.Operators.ListUnion<Condition>(ch_, cm_);
			var co_ = this.Injury_to_Optic_Nerve_and_Pathways();
			var cp_ = context.Operators.RetrieveByValueSet<Condition>(co_, null);
			var cq_ = this.Macular_Scar_of_Posterior_Polar();
			var cr_ = context.Operators.RetrieveByValueSet<Condition>(cq_, null);
			var cs_ = context.Operators.ListUnion<Condition>(cp_, cr_);
			var ct_ = context.Operators.ListUnion<Condition>(cn_, cs_);
			var cu_ = this.Morgagnian_Cataract();
			var cv_ = context.Operators.RetrieveByValueSet<Condition>(cu_, null);
			var cw_ = this.Nystagmus_and_Other_Irregular_Eye_Movements();
			var cx_ = context.Operators.RetrieveByValueSet<Condition>(cw_, null);
			var cy_ = context.Operators.ListUnion<Condition>(cv_, cx_);
			var cz_ = context.Operators.ListUnion<Condition>(ct_, cy_);
			var da_ = this.Open_Wound_of_Eyeball();
			var db_ = context.Operators.RetrieveByValueSet<Condition>(da_, null);
			var dc_ = this.Optic_Atrophy();
			var dd_ = context.Operators.RetrieveByValueSet<Condition>(dc_, null);
			var de_ = context.Operators.ListUnion<Condition>(db_, dd_);
			var df_ = context.Operators.ListUnion<Condition>(cz_, de_);
			var dg_ = this.Optic_Neuritis();
			var dh_ = context.Operators.RetrieveByValueSet<Condition>(dg_, null);
			var di_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis();
			var dj_ = context.Operators.RetrieveByValueSet<Condition>(di_, null);
			var dk_ = context.Operators.ListUnion<Condition>(dh_, dj_);
			var dl_ = context.Operators.ListUnion<Condition>(df_, dk_);
			var dm_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes();
			var dn_ = context.Operators.RetrieveByValueSet<Condition>(dm_, null);
			var do_ = this.Other_Disorders_of_Optic_Nerve();
			var dp_ = context.Operators.RetrieveByValueSet<Condition>(do_, null);
			var dq_ = context.Operators.ListUnion<Condition>(dn_, dp_);
			var dr_ = context.Operators.ListUnion<Condition>(dl_, dq_);
			var ds_ = this.Other_Endophthalmitis();
			var dt_ = context.Operators.RetrieveByValueSet<Condition>(ds_, null);
			var du_ = this.Other_Proliferative_Retinopathy();
			var dv_ = context.Operators.RetrieveByValueSet<Condition>(du_, null);
			var dw_ = context.Operators.ListUnion<Condition>(dt_, dv_);
			var dx_ = context.Operators.ListUnion<Condition>(dr_, dw_);
			var dy_ = this.Pathologic_Myopia();
			var dz_ = context.Operators.RetrieveByValueSet<Condition>(dy_, null);
			var ea_ = this.Posterior_Lenticonus();
			var eb_ = context.Operators.RetrieveByValueSet<Condition>(ea_, null);
			var ec_ = context.Operators.ListUnion<Condition>(dz_, eb_);
			var ed_ = context.Operators.ListUnion<Condition>(dx_, ec_);
			var ee_ = this.Prior_Penetrating_Keratoplasty();
			var ef_ = context.Operators.RetrieveByValueSet<Condition>(ee_, null);
			var eg_ = this.Purulent_Endophthalmitis();
			var eh_ = context.Operators.RetrieveByValueSet<Condition>(eg_, null);
			var ei_ = context.Operators.ListUnion<Condition>(ef_, eh_);
			var ej_ = context.Operators.ListUnion<Condition>(ed_, ei_);
			var ek_ = this.Retinal_Detachment_with_Retinal_Defect();
			var el_ = context.Operators.RetrieveByValueSet<Condition>(ek_, null);
			var em_ = this.Retinal_Vascular_Occlusion();
			var en_ = context.Operators.RetrieveByValueSet<Condition>(em_, null);
			var eo_ = context.Operators.ListUnion<Condition>(el_, en_);
			var ep_ = context.Operators.ListUnion<Condition>(ej_, eo_);
			var eq_ = this.Retrolental_Fibroplasias();
			var er_ = context.Operators.RetrieveByValueSet<Condition>(eq_, null);
			var es_ = this.Scleritis();
			var et_ = context.Operators.RetrieveByValueSet<Condition>(es_, null);
			var eu_ = context.Operators.ListUnion<Condition>(er_, et_);
			var ev_ = context.Operators.ListUnion<Condition>(ep_, eu_);
			var ew_ = this.Separation_of_Retinal_Layers();
			var ex_ = context.Operators.RetrieveByValueSet<Condition>(ew_, null);
			var ey_ = this.Traumatic_Cataract();
			var ez_ = context.Operators.RetrieveByValueSet<Condition>(ey_, null);
			var fa_ = context.Operators.ListUnion<Condition>(ex_, ez_);
			var fb_ = context.Operators.ListUnion<Condition>(ev_, fa_);
			var fc_ = this.Uveitis();
			var fd_ = context.Operators.RetrieveByValueSet<Condition>(fc_, null);
			var fe_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body();
			var ff_ = context.Operators.RetrieveByValueSet<Condition>(fe_, null);
			var fg_ = context.Operators.ListUnion<Condition>(fd_, ff_);
			var fh_ = context.Operators.ListUnion<Condition>(fb_, fg_);
			var fi_ = this.Visual_Field_Defects();
			var fj_ = context.Operators.RetrieveByValueSet<Condition>(fi_, null);
			var fk_ = context.Operators.ListUnion<Condition>(fh_, fj_);
			bool? fl_(Condition ComorbidDiagnosis)
			{
				var fp_ = QICoreCommon_2_0_000.prevalenceInterval(ComorbidDiagnosis);
				var fq_ = FHIRHelpers_4_3_000.ToValue(CataractSurgeryPerformed?.Performed);
				var fr_ = QICoreCommon_2_0_000.toInterval(fq_);
				var fs_ = context.Operators.OverlapsBefore(fp_, fr_, null);
				var ft_ = QICoreCommon_2_0_000.isActive(ComorbidDiagnosis);
				var fu_ = context.Operators.And(fs_, ft_);

				return fu_;
			};
			var fm_ = context.Operators.Where<Condition>(fk_, fl_);
			Procedure fn_(Condition ComorbidDiagnosis) => 
				CataractSurgeryPerformed;
			var fo_ = context.Operators.Select<Condition, Procedure>(fm_, fn_);

			return fo_;
		};
		var c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Procedure> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Procedure> Numerator_Value()
	{
		var a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period();
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			var d_ = this.Best_corrected_visual_acuity__observable_entity_();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			var g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart();
			var h_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
			var i_ = context.Operators.ListUnion<Observation>(f_, h_);
			bool? j_(Observation VisualAcuityExamPerformed)
			{
				var n_ = FHIRHelpers_4_3_000.ToValue(VisualAcuityExamPerformed?.Effective);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.Start(o_);
				var q_ = FHIRHelpers_4_3_000.ToValue(CataractSurgeryPerformed?.Performed);
				var r_ = QICoreCommon_2_0_000.toInterval(q_);
				var s_ = context.Operators.End(r_);
				var u_ = QICoreCommon_2_0_000.toInterval(q_);
				var v_ = context.Operators.End(u_);
				var w_ = context.Operators.Quantity(90m, "days");
				var x_ = context.Operators.Add(v_, w_);
				var y_ = context.Operators.Interval(s_, x_, false, true);
				var z_ = context.Operators.In<CqlDateTime>(p_, y_, "day");
				var ab_ = QICoreCommon_2_0_000.toInterval(q_);
				var ac_ = context.Operators.End(ab_);
				var ad_ = context.Operators.Not((bool?)(ac_ is null));
				var ae_ = context.Operators.And(z_, ad_);
				var af_ = context.Operators.Convert<Code<ObservationStatus>>(VisualAcuityExamPerformed?.StatusElement?.Value);
				var ag_ = context.Operators.Convert<string>(af_);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
					"preliminary",
				};
				var ai_ = context.Operators.In<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(ae_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(VisualAcuityExamPerformed?.Value);
				var al_ = this.Visual_Acuity_20_40_or_Better();
				var am_ = context.Operators.ConceptInValueSet((ak_ as CqlConcept), al_);
				var an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			var k_ = context.Operators.Where<Observation>(i_, j_);
			Procedure l_(Observation VisualAcuityExamPerformed) => 
				CataractSurgeryPerformed;
			var m_ = context.Operators.Select<Observation, Procedure>(k_, l_);

			return m_;
		};
		var c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Procedure> Numerator() => 
		__Numerator.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
