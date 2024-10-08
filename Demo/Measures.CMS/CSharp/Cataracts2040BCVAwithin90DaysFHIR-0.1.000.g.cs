using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("Cataracts2040BCVAwithin90DaysFHIR", "0.1.000")]
public partial class Cataracts2040BCVAwithin90DaysFHIR_0_1_000 : ILibrary, ISingleton<Cataracts2040BCVAwithin90DaysFHIR_0_1_000>
{
    private Cataracts2040BCVAwithin90DaysFHIR_0_1_000() {}

    public static Cataracts2040BCVAwithin90DaysFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "Cataracts2040BCVAwithin90DaysFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, QICoreCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Acute and Subacute Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241")]
	public CqlValueSet Acute_and_Subacute_Iridocyclitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241", default);


    [CqlDeclaration("Amblyopia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448")]
	public CqlValueSet Amblyopia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448", default);


    [CqlDeclaration("Best Corrected Visual Acuity Exam Using Snellen Chart")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560")]
	public CqlValueSet Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560", default);


    [CqlDeclaration("Burn Confined to Eye and Adnexa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409")]
	public CqlValueSet Burn_Confined_to_Eye_and_Adnexa(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409", default);


    [CqlDeclaration("Cataract Congenital")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412")]
	public CqlValueSet Cataract_Congenital(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412", default);


    [CqlDeclaration("Cataract Mature or Hypermature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413")]
	public CqlValueSet Cataract_Mature_or_Hypermature(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413", default);


    [CqlDeclaration("Cataract Posterior Polar")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414")]
	public CqlValueSet Cataract_Posterior_Polar(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414", default);


    [CqlDeclaration("Cataract Secondary to Ocular Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410")]
	public CqlValueSet Cataract_Secondary_to_Ocular_Disorders(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410", default);


    [CqlDeclaration("Cataract Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411")]
	public CqlValueSet Cataract_Surgery(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411", default);


    [CqlDeclaration("Central Corneal Ulcer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428")]
	public CqlValueSet Central_Corneal_Ulcer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428", default);


    [CqlDeclaration("Certain Types of Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415")]
	public CqlValueSet Certain_Types_of_Iridocyclitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415", default);


    [CqlDeclaration("Choroidal Degenerations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450")]
	public CqlValueSet Choroidal_Degenerations(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450", default);


    [CqlDeclaration("Choroidal Detachment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451")]
	public CqlValueSet Choroidal_Detachment(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451", default);


    [CqlDeclaration("Choroidal Hemorrhage and Rupture")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452")]
	public CqlValueSet Choroidal_Hemorrhage_and_Rupture(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452", default);


    [CqlDeclaration("Chronic Iridocyclitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416")]
	public CqlValueSet Chronic_Iridocyclitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416", default);


    [CqlDeclaration("Cloudy Cornea")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417")]
	public CqlValueSet Cloudy_Cornea(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417", default);


    [CqlDeclaration("Corneal Edema")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418")]
	public CqlValueSet Corneal_Edema(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418", default);


    [CqlDeclaration("Degeneration of Macula and Posterior Pole")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453")]
	public CqlValueSet Degeneration_of_Macula_and_Posterior_Pole(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453", default);


    [CqlDeclaration("Degenerative Disorders of Globe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454")]
	public CqlValueSet Degenerative_Disorders_of_Globe(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454", default);


    [CqlDeclaration("Diabetic Macular Edema")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455")]
	public CqlValueSet Diabetic_Macular_Edema(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455", default);


    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", default);


    [CqlDeclaration("Disorders of Cornea Including Corneal Opacity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419")]
	public CqlValueSet Disorders_of_Cornea_Including_Corneal_Opacity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419", default);


    [CqlDeclaration("Disorders of Optic Chiasm")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457")]
	public CqlValueSet Disorders_of_Optic_Chiasm(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457", default);


    [CqlDeclaration("Disorders of Visual Cortex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458")]
	public CqlValueSet Disorders_of_Visual_Cortex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458", default);


    [CqlDeclaration("Disseminated Chorioretinitis and Disseminated Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459")]
	public CqlValueSet Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459", default);


    [CqlDeclaration("Focal Chorioretinitis and Focal Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460")]
	public CqlValueSet Focal_Chorioretinitis_and_Focal_Retinochoroiditis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460", default);


    [CqlDeclaration("Glaucoma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423")]
	public CqlValueSet Glaucoma(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423", default);


    [CqlDeclaration("Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461")]
	public CqlValueSet Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461", default);


    [CqlDeclaration("Hereditary Choroidal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462")]
	public CqlValueSet Hereditary_Choroidal_Dystrophies(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462", default);


    [CqlDeclaration("Hereditary Corneal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424")]
	public CqlValueSet Hereditary_Corneal_Dystrophies(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424", default);


    [CqlDeclaration("Hereditary Retinal Dystrophies")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463")]
	public CqlValueSet Hereditary_Retinal_Dystrophies(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463", default);


    [CqlDeclaration("Hypotony of Eye")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426")]
	public CqlValueSet Hypotony_of_Eye(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426", default);


    [CqlDeclaration("Injury to Optic Nerve and Pathways")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427")]
	public CqlValueSet Injury_to_Optic_Nerve_and_Pathways(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427", default);


    [CqlDeclaration("Macular Scar of Posterior Polar")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559")]
	public CqlValueSet Macular_Scar_of_Posterior_Polar(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559", default);


    [CqlDeclaration("Morgagnian Cataract")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558")]
	public CqlValueSet Morgagnian_Cataract(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558", default);


    [CqlDeclaration("Nystagmus and Other Irregular Eye Movements")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465")]
	public CqlValueSet Nystagmus_and_Other_Irregular_Eye_Movements(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465", default);


    [CqlDeclaration("Open Wound of Eyeball")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430")]
	public CqlValueSet Open_Wound_of_Eyeball(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430", default);


    [CqlDeclaration("Optic Atrophy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466")]
	public CqlValueSet Optic_Atrophy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466", default);


    [CqlDeclaration("Optic Neuritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467")]
	public CqlValueSet Optic_Neuritis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467", default);


    [CqlDeclaration("Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468")]
	public CqlValueSet Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468", default);


    [CqlDeclaration("Other Background Retinopathy and Retinal Vascular Changes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469")]
	public CqlValueSet Other_Background_Retinopathy_and_Retinal_Vascular_Changes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469", default);


    [CqlDeclaration("Other Disorders of Optic Nerve")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471")]
	public CqlValueSet Other_Disorders_of_Optic_Nerve(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471", default);


    [CqlDeclaration("Other Endophthalmitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473")]
	public CqlValueSet Other_Endophthalmitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473", default);


    [CqlDeclaration("Other Proliferative Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480")]
	public CqlValueSet Other_Proliferative_Retinopathy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480", default);


    [CqlDeclaration("Pathologic Myopia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432")]
	public CqlValueSet Pathologic_Myopia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432", default);


    [CqlDeclaration("Posterior Lenticonus")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433")]
	public CqlValueSet Posterior_Lenticonus(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433", default);


    [CqlDeclaration("Prior Penetrating Keratoplasty")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475")]
	public CqlValueSet Prior_Penetrating_Keratoplasty(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475", default);


    [CqlDeclaration("Purulent Endophthalmitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477")]
	public CqlValueSet Purulent_Endophthalmitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477", default);


    [CqlDeclaration("Retinal Detachment with Retinal Defect")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478")]
	public CqlValueSet Retinal_Detachment_with_Retinal_Defect(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478", default);


    [CqlDeclaration("Retinal Vascular Occlusion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479")]
	public CqlValueSet Retinal_Vascular_Occlusion(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479", default);


    [CqlDeclaration("Retrolental Fibroplasias")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438")]
	public CqlValueSet Retrolental_Fibroplasias(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438", default);


    [CqlDeclaration("Scleritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1")]
	public CqlValueSet Scleritis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1", default);


    [CqlDeclaration("Separation of Retinal Layers")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482")]
	public CqlValueSet Separation_of_Retinal_Layers(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482", default);


    [CqlDeclaration("Traumatic Cataract")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443")]
	public CqlValueSet Traumatic_Cataract(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443", default);


    [CqlDeclaration("Uveitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444")]
	public CqlValueSet Uveitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444", default);


    [CqlDeclaration("Vascular Disorders of Iris and Ciliary Body")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445")]
	public CqlValueSet Vascular_Disorders_of_Iris_and_Ciliary_Body(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445", default);


    [CqlDeclaration("Visual Acuity 20/40 or Better")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483")]
	public CqlValueSet Visual_Acuity_20_40_or_Better(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483", default);


    [CqlDeclaration("Visual Field Defects")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446")]
	public CqlValueSet Visual_Field_Defects(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446", default);


    [CqlDeclaration("Best corrected visual acuity (observable entity)")]
	public CqlCode Best_corrected_visual_acuity__observable_entity_(CqlContext context) => 
		new CqlCode("419775003", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("419775003", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Cataract Surgery Between January and September of Measurement Period")]
	public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Cataract_Surgery(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure CataractSurgery)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
			DataType f_ = CataractSurgery?.Performed;
			object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.Instance.toInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, default);
			object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.toInterval(context, k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlDateTime o_ = context.Operators.End(e_);
			CqlQuantity p_ = context.Operators.Quantity(92m, "days");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			bool? r_ = context.Operators.SameOrBefore(m_, q_, default);
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


    [CqlDeclaration("Initial Population")]
	public IEnumerable<Procedure> Initial_Population(CqlContext context)
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
		bool? b_(Procedure CataractSurgeryPerformed)
		{
			Patient d_ = this.Patient(context);
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 18);

			return l_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Denominator")]
	public IEnumerable<Procedure> Denominator(CqlContext context)
	{
		IEnumerable<Procedure> a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			CqlValueSet d_ = this.Acute_and_Subacute_Iridocyclitis(context);
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
			CqlValueSet f_ = this.Amblyopia(context);
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
			IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, default);
			CqlValueSet k_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
			IEnumerable<Condition> l_ = context.Operators.RetrieveByValueSet<Condition>(k_, default);
			IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
			CqlValueSet o_ = this.Cataract_Congenital(context);
			IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, default);
			CqlValueSet q_ = this.Cataract_Mature_or_Hypermature(context);
			IEnumerable<Condition> r_ = context.Operators.RetrieveByValueSet<Condition>(q_, default);
			IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
			IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
			CqlValueSet u_ = this.Cataract_Posterior_Polar(context);
			IEnumerable<Condition> v_ = context.Operators.RetrieveByValueSet<Condition>(u_, default);
			CqlValueSet w_ = this.Central_Corneal_Ulcer(context);
			IEnumerable<Condition> x_ = context.Operators.RetrieveByValueSet<Condition>(w_, default);
			IEnumerable<Condition> y_ = context.Operators.Union<Condition>(v_, x_);
			IEnumerable<Condition> z_ = context.Operators.Union<Condition>(t_, y_);
			CqlValueSet aa_ = this.Certain_Types_of_Iridocyclitis(context);
			IEnumerable<Condition> ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, default);
			CqlValueSet ac_ = this.Choroidal_Degenerations(context);
			IEnumerable<Condition> ad_ = context.Operators.RetrieveByValueSet<Condition>(ac_, default);
			IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(ab_, ad_);
			IEnumerable<Condition> af_ = context.Operators.Union<Condition>(z_, ae_);
			CqlValueSet ag_ = this.Choroidal_Detachment(context);
			IEnumerable<Condition> ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, default);
			CqlValueSet ai_ = this.Choroidal_Hemorrhage_and_Rupture(context);
			IEnumerable<Condition> aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, default);
			IEnumerable<Condition> ak_ = context.Operators.Union<Condition>(ah_, aj_);
			IEnumerable<Condition> al_ = context.Operators.Union<Condition>(af_, ak_);
			CqlValueSet am_ = this.Chronic_Iridocyclitis(context);
			IEnumerable<Condition> an_ = context.Operators.RetrieveByValueSet<Condition>(am_, default);
			CqlValueSet ao_ = this.Cloudy_Cornea(context);
			IEnumerable<Condition> ap_ = context.Operators.RetrieveByValueSet<Condition>(ao_, default);
			IEnumerable<Condition> aq_ = context.Operators.Union<Condition>(an_, ap_);
			IEnumerable<Condition> ar_ = context.Operators.Union<Condition>(al_, aq_);
			CqlValueSet as_ = this.Corneal_Edema(context);
			IEnumerable<Condition> at_ = context.Operators.RetrieveByValueSet<Condition>(as_, default);
			CqlValueSet au_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
			IEnumerable<Condition> av_ = context.Operators.RetrieveByValueSet<Condition>(au_, default);
			IEnumerable<Condition> aw_ = context.Operators.Union<Condition>(at_, av_);
			IEnumerable<Condition> ax_ = context.Operators.Union<Condition>(ar_, aw_);
			CqlValueSet ay_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
			IEnumerable<Condition> az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, default);
			CqlValueSet ba_ = this.Degenerative_Disorders_of_Globe(context);
			IEnumerable<Condition> bb_ = context.Operators.RetrieveByValueSet<Condition>(ba_, default);
			IEnumerable<Condition> bc_ = context.Operators.Union<Condition>(az_, bb_);
			IEnumerable<Condition> bd_ = context.Operators.Union<Condition>(ax_, bc_);
			CqlValueSet be_ = this.Diabetic_Macular_Edema(context);
			IEnumerable<Condition> bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, default);
			CqlValueSet bg_ = this.Diabetic_Retinopathy(context);
			IEnumerable<Condition> bh_ = context.Operators.RetrieveByValueSet<Condition>(bg_, default);
			IEnumerable<Condition> bi_ = context.Operators.Union<Condition>(bf_, bh_);
			IEnumerable<Condition> bj_ = context.Operators.Union<Condition>(bd_, bi_);
			CqlValueSet bk_ = this.Disorders_of_Optic_Chiasm(context);
			IEnumerable<Condition> bl_ = context.Operators.RetrieveByValueSet<Condition>(bk_, default);
			CqlValueSet bm_ = this.Disorders_of_Visual_Cortex(context);
			IEnumerable<Condition> bn_ = context.Operators.RetrieveByValueSet<Condition>(bm_, default);
			IEnumerable<Condition> bo_ = context.Operators.Union<Condition>(bl_, bn_);
			IEnumerable<Condition> bp_ = context.Operators.Union<Condition>(bj_, bo_);
			CqlValueSet bq_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
			IEnumerable<Condition> br_ = context.Operators.RetrieveByValueSet<Condition>(bq_, default);
			CqlValueSet bs_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
			IEnumerable<Condition> bt_ = context.Operators.RetrieveByValueSet<Condition>(bs_, default);
			IEnumerable<Condition> bu_ = context.Operators.Union<Condition>(br_, bt_);
			IEnumerable<Condition> bv_ = context.Operators.Union<Condition>(bp_, bu_);
			CqlValueSet bw_ = this.Glaucoma(context);
			IEnumerable<Condition> bx_ = context.Operators.RetrieveByValueSet<Condition>(bw_, default);
			CqlValueSet by_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
			IEnumerable<Condition> bz_ = context.Operators.RetrieveByValueSet<Condition>(by_, default);
			IEnumerable<Condition> ca_ = context.Operators.Union<Condition>(bx_, bz_);
			IEnumerable<Condition> cb_ = context.Operators.Union<Condition>(bv_, ca_);
			CqlValueSet cc_ = this.Hereditary_Choroidal_Dystrophies(context);
			IEnumerable<Condition> cd_ = context.Operators.RetrieveByValueSet<Condition>(cc_, default);
			CqlValueSet ce_ = this.Hereditary_Corneal_Dystrophies(context);
			IEnumerable<Condition> cf_ = context.Operators.RetrieveByValueSet<Condition>(ce_, default);
			IEnumerable<Condition> cg_ = context.Operators.Union<Condition>(cd_, cf_);
			IEnumerable<Condition> ch_ = context.Operators.Union<Condition>(cb_, cg_);
			CqlValueSet ci_ = this.Hereditary_Retinal_Dystrophies(context);
			IEnumerable<Condition> cj_ = context.Operators.RetrieveByValueSet<Condition>(ci_, default);
			CqlValueSet ck_ = this.Hypotony_of_Eye(context);
			IEnumerable<Condition> cl_ = context.Operators.RetrieveByValueSet<Condition>(ck_, default);
			IEnumerable<Condition> cm_ = context.Operators.Union<Condition>(cj_, cl_);
			IEnumerable<Condition> cn_ = context.Operators.Union<Condition>(ch_, cm_);
			CqlValueSet co_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
			IEnumerable<Condition> cp_ = context.Operators.RetrieveByValueSet<Condition>(co_, default);
			CqlValueSet cq_ = this.Macular_Scar_of_Posterior_Polar(context);
			IEnumerable<Condition> cr_ = context.Operators.RetrieveByValueSet<Condition>(cq_, default);
			IEnumerable<Condition> cs_ = context.Operators.Union<Condition>(cp_, cr_);
			IEnumerable<Condition> ct_ = context.Operators.Union<Condition>(cn_, cs_);
			CqlValueSet cu_ = this.Morgagnian_Cataract(context);
			IEnumerable<Condition> cv_ = context.Operators.RetrieveByValueSet<Condition>(cu_, default);
			CqlValueSet cw_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
			IEnumerable<Condition> cx_ = context.Operators.RetrieveByValueSet<Condition>(cw_, default);
			IEnumerable<Condition> cy_ = context.Operators.Union<Condition>(cv_, cx_);
			IEnumerable<Condition> cz_ = context.Operators.Union<Condition>(ct_, cy_);
			CqlValueSet da_ = this.Open_Wound_of_Eyeball(context);
			IEnumerable<Condition> db_ = context.Operators.RetrieveByValueSet<Condition>(da_, default);
			CqlValueSet dc_ = this.Optic_Atrophy(context);
			IEnumerable<Condition> dd_ = context.Operators.RetrieveByValueSet<Condition>(dc_, default);
			IEnumerable<Condition> de_ = context.Operators.Union<Condition>(db_, dd_);
			IEnumerable<Condition> df_ = context.Operators.Union<Condition>(cz_, de_);
			CqlValueSet dg_ = this.Optic_Neuritis(context);
			IEnumerable<Condition> dh_ = context.Operators.RetrieveByValueSet<Condition>(dg_, default);
			CqlValueSet di_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
			IEnumerable<Condition> dj_ = context.Operators.RetrieveByValueSet<Condition>(di_, default);
			IEnumerable<Condition> dk_ = context.Operators.Union<Condition>(dh_, dj_);
			IEnumerable<Condition> dl_ = context.Operators.Union<Condition>(df_, dk_);
			CqlValueSet dm_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
			IEnumerable<Condition> dn_ = context.Operators.RetrieveByValueSet<Condition>(dm_, default);
			CqlValueSet do_ = this.Other_Disorders_of_Optic_Nerve(context);
			IEnumerable<Condition> dp_ = context.Operators.RetrieveByValueSet<Condition>(do_, default);
			IEnumerable<Condition> dq_ = context.Operators.Union<Condition>(dn_, dp_);
			IEnumerable<Condition> dr_ = context.Operators.Union<Condition>(dl_, dq_);
			CqlValueSet ds_ = this.Other_Endophthalmitis(context);
			IEnumerable<Condition> dt_ = context.Operators.RetrieveByValueSet<Condition>(ds_, default);
			CqlValueSet du_ = this.Other_Proliferative_Retinopathy(context);
			IEnumerable<Condition> dv_ = context.Operators.RetrieveByValueSet<Condition>(du_, default);
			IEnumerable<Condition> dw_ = context.Operators.Union<Condition>(dt_, dv_);
			IEnumerable<Condition> dx_ = context.Operators.Union<Condition>(dr_, dw_);
			CqlValueSet dy_ = this.Pathologic_Myopia(context);
			IEnumerable<Condition> dz_ = context.Operators.RetrieveByValueSet<Condition>(dy_, default);
			CqlValueSet ea_ = this.Posterior_Lenticonus(context);
			IEnumerable<Condition> eb_ = context.Operators.RetrieveByValueSet<Condition>(ea_, default);
			IEnumerable<Condition> ec_ = context.Operators.Union<Condition>(dz_, eb_);
			IEnumerable<Condition> ed_ = context.Operators.Union<Condition>(dx_, ec_);
			CqlValueSet ee_ = this.Prior_Penetrating_Keratoplasty(context);
			IEnumerable<Condition> ef_ = context.Operators.RetrieveByValueSet<Condition>(ee_, default);
			CqlValueSet eg_ = this.Purulent_Endophthalmitis(context);
			IEnumerable<Condition> eh_ = context.Operators.RetrieveByValueSet<Condition>(eg_, default);
			IEnumerable<Condition> ei_ = context.Operators.Union<Condition>(ef_, eh_);
			IEnumerable<Condition> ej_ = context.Operators.Union<Condition>(ed_, ei_);
			CqlValueSet ek_ = this.Retinal_Detachment_with_Retinal_Defect(context);
			IEnumerable<Condition> el_ = context.Operators.RetrieveByValueSet<Condition>(ek_, default);
			CqlValueSet em_ = this.Retinal_Vascular_Occlusion(context);
			IEnumerable<Condition> en_ = context.Operators.RetrieveByValueSet<Condition>(em_, default);
			IEnumerable<Condition> eo_ = context.Operators.Union<Condition>(el_, en_);
			IEnumerable<Condition> ep_ = context.Operators.Union<Condition>(ej_, eo_);
			CqlValueSet eq_ = this.Retrolental_Fibroplasias(context);
			IEnumerable<Condition> er_ = context.Operators.RetrieveByValueSet<Condition>(eq_, default);
			CqlValueSet es_ = this.Scleritis(context);
			IEnumerable<Condition> et_ = context.Operators.RetrieveByValueSet<Condition>(es_, default);
			IEnumerable<Condition> eu_ = context.Operators.Union<Condition>(er_, et_);
			IEnumerable<Condition> ev_ = context.Operators.Union<Condition>(ep_, eu_);
			CqlValueSet ew_ = this.Separation_of_Retinal_Layers(context);
			IEnumerable<Condition> ex_ = context.Operators.RetrieveByValueSet<Condition>(ew_, default);
			CqlValueSet ey_ = this.Traumatic_Cataract(context);
			IEnumerable<Condition> ez_ = context.Operators.RetrieveByValueSet<Condition>(ey_, default);
			IEnumerable<Condition> fa_ = context.Operators.Union<Condition>(ex_, ez_);
			IEnumerable<Condition> fb_ = context.Operators.Union<Condition>(ev_, fa_);
			CqlValueSet fc_ = this.Uveitis(context);
			IEnumerable<Condition> fd_ = context.Operators.RetrieveByValueSet<Condition>(fc_, default);
			CqlValueSet fe_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
			IEnumerable<Condition> ff_ = context.Operators.RetrieveByValueSet<Condition>(fe_, default);
			IEnumerable<Condition> fg_ = context.Operators.Union<Condition>(fd_, ff_);
			IEnumerable<Condition> fh_ = context.Operators.Union<Condition>(fb_, fg_);
			CqlValueSet fi_ = this.Visual_Field_Defects(context);
			IEnumerable<Condition> fj_ = context.Operators.RetrieveByValueSet<Condition>(fi_, default);
			IEnumerable<Condition> fk_ = context.Operators.Union<Condition>(fh_, fj_);
			bool? fl_(Condition ComorbidDiagnosis)
			{
				CqlInterval<CqlDateTime> fp_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
				DataType fq_ = CataractSurgeryPerformed?.Performed;
				object fr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fq_);
				CqlInterval<CqlDateTime> fs_ = QICoreCommon_2_0_000.Instance.toInterval(context, fr_);
				bool? ft_ = context.Operators.OverlapsBefore(fp_, fs_, default);
				bool? fu_ = QICoreCommon_2_0_000.Instance.isActive(context, ComorbidDiagnosis);
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


    [CqlDeclaration("Numerator")]
	public IEnumerable<Procedure> Numerator(CqlContext context)
	{
		IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
		IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
		{
			CqlCode d_ = this.Best_corrected_visual_acuity__observable_entity_(context);
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, default);
			CqlValueSet g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
			IEnumerable<Observation> h_ = context.Operators.RetrieveByValueSet<Observation>(g_, default);
			IEnumerable<Observation> i_ = context.Operators.Union<Observation>(f_, h_);
			bool? j_(Observation VisualAcuityExamPerformed)
			{
				DataType n_ = VisualAcuityExamPerformed?.Effective;
				object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.toInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				DataType r_ = CataractSurgeryPerformed?.Performed;
				object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
				CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.Instance.toInterval(context, s_);
				CqlDateTime u_ = context.Operators.End(t_);
				object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
				CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.toInterval(context, w_);
				CqlDateTime y_ = context.Operators.End(x_);
				CqlQuantity z_ = context.Operators.Quantity(90m, "days");
				CqlDateTime aa_ = context.Operators.Add(y_, z_);
				CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(u_, aa_, false, true);
				bool? ac_ = context.Operators.In<CqlDateTime>(q_, ab_, "day");
				object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
				CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.toInterval(context, ae_);
				CqlDateTime ag_ = context.Operators.End(af_);
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
				bool? ai_ = context.Operators.And(ac_, ah_);
				Code<ObservationStatus> aj_ = VisualAcuityExamPerformed?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				Code<ObservationStatus> al_ = context.Operators.Convert<Code<ObservationStatus>>(ak_);
				string am_ = context.Operators.Convert<string>(al_);
				string[] an_ = [
					"final",
					"amended",
					"corrected",
					"preliminary",
				];
				bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
				bool? ap_ = context.Operators.And(ai_, ao_);
				DataType aq_ = VisualAcuityExamPerformed?.Value;
				object ar_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aq_);
				CqlValueSet as_ = this.Visual_Acuity_20_40_or_Better(context);
				bool? at_ = context.Operators.ConceptInValueSet(ar_ as CqlConcept, as_);
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


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
