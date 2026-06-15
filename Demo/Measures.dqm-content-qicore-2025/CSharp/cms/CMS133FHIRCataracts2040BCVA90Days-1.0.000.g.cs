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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS133FHIRCataracts2040BCVA90Days", "1.0.000")]
public partial class CMS133FHIRCataracts2040BCVA90Days_1_0_000 : ILibrary, ISingleton<CMS133FHIRCataracts2040BCVA90Days_1_0_000>
{
    #region ValueSets (58)

    [CqlValueSetDefinition("Acute and Subacute Iridocyclitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241", valueSetVersion: null)]
    public CqlValueSet Acute_and_Subacute_Iridocyclitis(CqlContext _) => _Acute_and_Subacute_Iridocyclitis;
    private static readonly CqlValueSet _Acute_and_Subacute_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241", null);

    [CqlValueSetDefinition("Amblyopia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448", valueSetVersion: null)]
    public CqlValueSet Amblyopia(CqlContext _) => _Amblyopia;
    private static readonly CqlValueSet _Amblyopia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448", null);

    [CqlValueSetDefinition("Best Corrected Visual Acuity Exam Using Snellen Chart", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560", valueSetVersion: null)]
    public CqlValueSet Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(CqlContext _) => _Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart;
    private static readonly CqlValueSet _Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560", null);

    [CqlValueSetDefinition("Burn Confined to Eye and Adnexa", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409", valueSetVersion: null)]
    public CqlValueSet Burn_Confined_to_Eye_and_Adnexa(CqlContext _) => _Burn_Confined_to_Eye_and_Adnexa;
    private static readonly CqlValueSet _Burn_Confined_to_Eye_and_Adnexa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409", null);

    [CqlValueSetDefinition("Cataract Congenital", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412", valueSetVersion: null)]
    public CqlValueSet Cataract_Congenital(CqlContext _) => _Cataract_Congenital;
    private static readonly CqlValueSet _Cataract_Congenital = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412", null);

    [CqlValueSetDefinition("Cataract Mature or Hypermature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413", valueSetVersion: null)]
    public CqlValueSet Cataract_Mature_or_Hypermature(CqlContext _) => _Cataract_Mature_or_Hypermature;
    private static readonly CqlValueSet _Cataract_Mature_or_Hypermature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413", null);

    [CqlValueSetDefinition("Cataract Posterior Polar", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414", valueSetVersion: null)]
    public CqlValueSet Cataract_Posterior_Polar(CqlContext _) => _Cataract_Posterior_Polar;
    private static readonly CqlValueSet _Cataract_Posterior_Polar = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414", null);

    [CqlValueSetDefinition("Cataract Secondary to Ocular Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410", valueSetVersion: null)]
    public CqlValueSet Cataract_Secondary_to_Ocular_Disorders(CqlContext _) => _Cataract_Secondary_to_Ocular_Disorders;
    private static readonly CqlValueSet _Cataract_Secondary_to_Ocular_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410", null);

    [CqlValueSetDefinition("Cataract Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411", valueSetVersion: null)]
    public CqlValueSet Cataract_Surgery(CqlContext _) => _Cataract_Surgery;
    private static readonly CqlValueSet _Cataract_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411", null);

    [CqlValueSetDefinition("Central Corneal Ulcer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428", valueSetVersion: null)]
    public CqlValueSet Central_Corneal_Ulcer(CqlContext _) => _Central_Corneal_Ulcer;
    private static readonly CqlValueSet _Central_Corneal_Ulcer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428", null);

    [CqlValueSetDefinition("Certain Types of Iridocyclitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415", valueSetVersion: null)]
    public CqlValueSet Certain_Types_of_Iridocyclitis(CqlContext _) => _Certain_Types_of_Iridocyclitis;
    private static readonly CqlValueSet _Certain_Types_of_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415", null);

    [CqlValueSetDefinition("Choroidal Degenerations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450", valueSetVersion: null)]
    public CqlValueSet Choroidal_Degenerations(CqlContext _) => _Choroidal_Degenerations;
    private static readonly CqlValueSet _Choroidal_Degenerations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450", null);

    [CqlValueSetDefinition("Choroidal Detachment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451", valueSetVersion: null)]
    public CqlValueSet Choroidal_Detachment(CqlContext _) => _Choroidal_Detachment;
    private static readonly CqlValueSet _Choroidal_Detachment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451", null);

    [CqlValueSetDefinition("Choroidal Hemorrhage and Rupture", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452", valueSetVersion: null)]
    public CqlValueSet Choroidal_Hemorrhage_and_Rupture(CqlContext _) => _Choroidal_Hemorrhage_and_Rupture;
    private static readonly CqlValueSet _Choroidal_Hemorrhage_and_Rupture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452", null);

    [CqlValueSetDefinition("Chronic Iridocyclitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416", valueSetVersion: null)]
    public CqlValueSet Chronic_Iridocyclitis(CqlContext _) => _Chronic_Iridocyclitis;
    private static readonly CqlValueSet _Chronic_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416", null);

    [CqlValueSetDefinition("Cloudy Cornea", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417", valueSetVersion: null)]
    public CqlValueSet Cloudy_Cornea(CqlContext _) => _Cloudy_Cornea;
    private static readonly CqlValueSet _Cloudy_Cornea = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417", null);

    [CqlValueSetDefinition("Corneal Edema", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418", valueSetVersion: null)]
    public CqlValueSet Corneal_Edema(CqlContext _) => _Corneal_Edema;
    private static readonly CqlValueSet _Corneal_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418", null);

    [CqlValueSetDefinition("Degeneration of Macula and Posterior Pole", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453", valueSetVersion: null)]
    public CqlValueSet Degeneration_of_Macula_and_Posterior_Pole(CqlContext _) => _Degeneration_of_Macula_and_Posterior_Pole;
    private static readonly CqlValueSet _Degeneration_of_Macula_and_Posterior_Pole = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453", null);

    [CqlValueSetDefinition("Degenerative Disorders of Globe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454", valueSetVersion: null)]
    public CqlValueSet Degenerative_Disorders_of_Globe(CqlContext _) => _Degenerative_Disorders_of_Globe;
    private static readonly CqlValueSet _Degenerative_Disorders_of_Globe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454", null);

    [CqlValueSetDefinition("Diabetic Macular Edema", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455", valueSetVersion: null)]
    public CqlValueSet Diabetic_Macular_Edema(CqlContext _) => _Diabetic_Macular_Edema;
    private static readonly CqlValueSet _Diabetic_Macular_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Disorders of Cornea Including Corneal Opacity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419", valueSetVersion: null)]
    public CqlValueSet Disorders_of_Cornea_Including_Corneal_Opacity(CqlContext _) => _Disorders_of_Cornea_Including_Corneal_Opacity;
    private static readonly CqlValueSet _Disorders_of_Cornea_Including_Corneal_Opacity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419", null);

    [CqlValueSetDefinition("Disorders of Optic Chiasm", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457", valueSetVersion: null)]
    public CqlValueSet Disorders_of_Optic_Chiasm(CqlContext _) => _Disorders_of_Optic_Chiasm;
    private static readonly CqlValueSet _Disorders_of_Optic_Chiasm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457", null);

    [CqlValueSetDefinition("Disorders of Visual Cortex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458", valueSetVersion: null)]
    public CqlValueSet Disorders_of_Visual_Cortex(CqlContext _) => _Disorders_of_Visual_Cortex;
    private static readonly CqlValueSet _Disorders_of_Visual_Cortex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458", null);

    [CqlValueSetDefinition("Disseminated Chorioretinitis and Disseminated Retinochoroiditis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459", valueSetVersion: null)]
    public CqlValueSet Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(CqlContext _) => _Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis;
    private static readonly CqlValueSet _Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459", null);

    [CqlValueSetDefinition("Focal Chorioretinitis and Focal Retinochoroiditis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460", valueSetVersion: null)]
    public CqlValueSet Focal_Chorioretinitis_and_Focal_Retinochoroiditis(CqlContext _) => _Focal_Chorioretinitis_and_Focal_Retinochoroiditis;
    private static readonly CqlValueSet _Focal_Chorioretinitis_and_Focal_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460", null);

    [CqlValueSetDefinition("Glaucoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423", valueSetVersion: null)]
    public CqlValueSet Glaucoma(CqlContext _) => _Glaucoma;
    private static readonly CqlValueSet _Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423", null);

    [CqlValueSetDefinition("Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461", valueSetVersion: null)]
    public CqlValueSet Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(CqlContext _) => _Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes;
    private static readonly CqlValueSet _Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461", null);

    [CqlValueSetDefinition("Hereditary Choroidal Dystrophies", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462", valueSetVersion: null)]
    public CqlValueSet Hereditary_Choroidal_Dystrophies(CqlContext _) => _Hereditary_Choroidal_Dystrophies;
    private static readonly CqlValueSet _Hereditary_Choroidal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462", null);

    [CqlValueSetDefinition("Hereditary Corneal Dystrophies", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424", valueSetVersion: null)]
    public CqlValueSet Hereditary_Corneal_Dystrophies(CqlContext _) => _Hereditary_Corneal_Dystrophies;
    private static readonly CqlValueSet _Hereditary_Corneal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424", null);

    [CqlValueSetDefinition("Hereditary Retinal Dystrophies", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463", valueSetVersion: null)]
    public CqlValueSet Hereditary_Retinal_Dystrophies(CqlContext _) => _Hereditary_Retinal_Dystrophies;
    private static readonly CqlValueSet _Hereditary_Retinal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463", null);

    [CqlValueSetDefinition("Hypotony of Eye", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426", valueSetVersion: null)]
    public CqlValueSet Hypotony_of_Eye(CqlContext _) => _Hypotony_of_Eye;
    private static readonly CqlValueSet _Hypotony_of_Eye = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426", null);

    [CqlValueSetDefinition("Injury to Optic Nerve and Pathways", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427", valueSetVersion: null)]
    public CqlValueSet Injury_to_Optic_Nerve_and_Pathways(CqlContext _) => _Injury_to_Optic_Nerve_and_Pathways;
    private static readonly CqlValueSet _Injury_to_Optic_Nerve_and_Pathways = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427", null);

    [CqlValueSetDefinition("Macular Scar of Posterior Polar", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559", valueSetVersion: null)]
    public CqlValueSet Macular_Scar_of_Posterior_Polar(CqlContext _) => _Macular_Scar_of_Posterior_Polar;
    private static readonly CqlValueSet _Macular_Scar_of_Posterior_Polar = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559", null);

    [CqlValueSetDefinition("Morgagnian Cataract", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558", valueSetVersion: null)]
    public CqlValueSet Morgagnian_Cataract(CqlContext _) => _Morgagnian_Cataract;
    private static readonly CqlValueSet _Morgagnian_Cataract = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558", null);

    [CqlValueSetDefinition("Nystagmus and Other Irregular Eye Movements", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465", valueSetVersion: null)]
    public CqlValueSet Nystagmus_and_Other_Irregular_Eye_Movements(CqlContext _) => _Nystagmus_and_Other_Irregular_Eye_Movements;
    private static readonly CqlValueSet _Nystagmus_and_Other_Irregular_Eye_Movements = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465", null);

    [CqlValueSetDefinition("Open Wound of Eyeball", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430", valueSetVersion: null)]
    public CqlValueSet Open_Wound_of_Eyeball(CqlContext _) => _Open_Wound_of_Eyeball;
    private static readonly CqlValueSet _Open_Wound_of_Eyeball = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430", null);

    [CqlValueSetDefinition("Optic Atrophy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466", valueSetVersion: null)]
    public CqlValueSet Optic_Atrophy(CqlContext _) => _Optic_Atrophy;
    private static readonly CqlValueSet _Optic_Atrophy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466", null);

    [CqlValueSetDefinition("Optic Neuritis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467", valueSetVersion: null)]
    public CqlValueSet Optic_Neuritis(CqlContext _) => _Optic_Neuritis;
    private static readonly CqlValueSet _Optic_Neuritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467", null);

    [CqlValueSetDefinition("Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468", valueSetVersion: null)]
    public CqlValueSet Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(CqlContext _) => _Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis;
    private static readonly CqlValueSet _Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468", null);

    [CqlValueSetDefinition("Other Background Retinopathy and Retinal Vascular Changes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469", valueSetVersion: null)]
    public CqlValueSet Other_Background_Retinopathy_and_Retinal_Vascular_Changes(CqlContext _) => _Other_Background_Retinopathy_and_Retinal_Vascular_Changes;
    private static readonly CqlValueSet _Other_Background_Retinopathy_and_Retinal_Vascular_Changes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469", null);

    [CqlValueSetDefinition("Other Disorders of Optic Nerve", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471", valueSetVersion: null)]
    public CqlValueSet Other_Disorders_of_Optic_Nerve(CqlContext _) => _Other_Disorders_of_Optic_Nerve;
    private static readonly CqlValueSet _Other_Disorders_of_Optic_Nerve = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471", null);

    [CqlValueSetDefinition("Other Endophthalmitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473", valueSetVersion: null)]
    public CqlValueSet Other_Endophthalmitis(CqlContext _) => _Other_Endophthalmitis;
    private static readonly CqlValueSet _Other_Endophthalmitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473", null);

    [CqlValueSetDefinition("Other Proliferative Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480", valueSetVersion: null)]
    public CqlValueSet Other_Proliferative_Retinopathy(CqlContext _) => _Other_Proliferative_Retinopathy;
    private static readonly CqlValueSet _Other_Proliferative_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480", null);

    [CqlValueSetDefinition("Pathologic Myopia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432", valueSetVersion: null)]
    public CqlValueSet Pathologic_Myopia(CqlContext _) => _Pathologic_Myopia;
    private static readonly CqlValueSet _Pathologic_Myopia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432", null);

    [CqlValueSetDefinition("Posterior Lenticonus", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433", valueSetVersion: null)]
    public CqlValueSet Posterior_Lenticonus(CqlContext _) => _Posterior_Lenticonus;
    private static readonly CqlValueSet _Posterior_Lenticonus = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433", null);

    [CqlValueSetDefinition("Prior Penetrating Keratoplasty", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475", valueSetVersion: null)]
    public CqlValueSet Prior_Penetrating_Keratoplasty(CqlContext _) => _Prior_Penetrating_Keratoplasty;
    private static readonly CqlValueSet _Prior_Penetrating_Keratoplasty = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475", null);

    [CqlValueSetDefinition("Purulent Endophthalmitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477", valueSetVersion: null)]
    public CqlValueSet Purulent_Endophthalmitis(CqlContext _) => _Purulent_Endophthalmitis;
    private static readonly CqlValueSet _Purulent_Endophthalmitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477", null);

    [CqlValueSetDefinition("Retinal Detachment with Retinal Defect", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478", valueSetVersion: null)]
    public CqlValueSet Retinal_Detachment_with_Retinal_Defect(CqlContext _) => _Retinal_Detachment_with_Retinal_Defect;
    private static readonly CqlValueSet _Retinal_Detachment_with_Retinal_Defect = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478", null);

    [CqlValueSetDefinition("Retinal Vascular Occlusion", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479", valueSetVersion: null)]
    public CqlValueSet Retinal_Vascular_Occlusion(CqlContext _) => _Retinal_Vascular_Occlusion;
    private static readonly CqlValueSet _Retinal_Vascular_Occlusion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479", null);

    [CqlValueSetDefinition("Retrolental Fibroplasias", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438", valueSetVersion: null)]
    public CqlValueSet Retrolental_Fibroplasias(CqlContext _) => _Retrolental_Fibroplasias;
    private static readonly CqlValueSet _Retrolental_Fibroplasias = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438", null);

    [CqlValueSetDefinition("Scleritis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1", valueSetVersion: null)]
    public CqlValueSet Scleritis(CqlContext _) => _Scleritis;
    private static readonly CqlValueSet _Scleritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1", null);

    [CqlValueSetDefinition("Separation of Retinal Layers", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482", valueSetVersion: null)]
    public CqlValueSet Separation_of_Retinal_Layers(CqlContext _) => _Separation_of_Retinal_Layers;
    private static readonly CqlValueSet _Separation_of_Retinal_Layers = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482", null);

    [CqlValueSetDefinition("Traumatic Cataract", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443", valueSetVersion: null)]
    public CqlValueSet Traumatic_Cataract(CqlContext _) => _Traumatic_Cataract;
    private static readonly CqlValueSet _Traumatic_Cataract = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443", null);

    [CqlValueSetDefinition("Uveitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444", valueSetVersion: null)]
    public CqlValueSet Uveitis(CqlContext _) => _Uveitis;
    private static readonly CqlValueSet _Uveitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444", null);

    [CqlValueSetDefinition("Vascular Disorders of Iris and Ciliary Body", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445", valueSetVersion: null)]
    public CqlValueSet Vascular_Disorders_of_Iris_and_Ciliary_Body(CqlContext _) => _Vascular_Disorders_of_Iris_and_Ciliary_Body;
    private static readonly CqlValueSet _Vascular_Disorders_of_Iris_and_Ciliary_Body = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445", null);

    [CqlValueSetDefinition("Visual Acuity 20/40 or Better", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483", valueSetVersion: null)]
    public CqlValueSet Visual_Acuity_20_40_or_Better(CqlContext _) => _Visual_Acuity_20_40_or_Better;
    private static readonly CqlValueSet _Visual_Acuity_20_40_or_Better = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483", null);

    [CqlValueSetDefinition("Visual Field Defects", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446", valueSetVersion: null)]
    public CqlValueSet Visual_Field_Defects(CqlContext _) => _Visual_Field_Defects;
    private static readonly CqlValueSet _Visual_Field_Defects = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Best corrected visual acuity (observable entity)", codeId: "419775003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Best_corrected_visual_acuity__observable_entity_(CqlContext _) => _Best_corrected_visual_acuity__observable_entity_;
    private static readonly CqlCode _Best_corrected_visual_acuity__observable_entity_ = new CqlCode("419775003", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Best_corrected_visual_acuity__observable_entity_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -1753348495276809643L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS133FHIRCataracts2040BCVA90Days-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (12)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -14077989710860312L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cataract_Surgery_Between_January_and_September_of_Measurement_Period, Cataract_Surgery_Between_January_and_September_of_Measurement_Period_Compute);

    private const long _cacheIndex_Cataract_Surgery_Between_January_and_September_of_Measurement_Period = -471982616688789783L;

    private IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure CataractSurgery) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);

            object f_() {

                bool w_() {
                    DataType aa_ = CataractSurgery?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlDateTime;
                    return ac_;
                }


                bool x_() {
                    DataType ad_ = CataractSurgery?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    return af_;
                }


                bool y_() {
                    DataType ag_ = CataractSurgery?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlQuantity;
                    return ai_;
                }


                bool z_() {
                    DataType aj_ = CataractSurgery?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlQuantity>;
                    return al_;
                }

                if (w_())
                {
                    DataType am_ = CataractSurgery?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return (an_ as CqlDateTime) as object;
                }
                else if (x_())
                {
                    DataType ao_ = CataractSurgery?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (ap_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (y_())
                {
                    DataType aq_ = CataractSurgery?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return (ar_ as CqlQuantity) as object;
                }
                else if (z_())
                {
                    DataType as_ = CataractSurgery?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    return (at_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");

            object i_() {

                bool au_() {
                    DataType ay_ = CataractSurgery?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlDateTime;
                    return ba_;
                }


                bool av_() {
                    DataType bb_ = CataractSurgery?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    return bd_;
                }


                bool aw_() {
                    DataType be_ = CataractSurgery?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlQuantity;
                    return bg_;
                }


                bool ax_() {
                    DataType bh_ = CataractSurgery?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                    return bj_;
                }

                if (au_())
                {
                    DataType bk_ = CataractSurgery?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlDateTime) as object;
                }
                else if (av_())
                {
                    DataType bm_ = CataractSurgery?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (aw_())
                {
                    DataType bo_ = CataractSurgery?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlQuantity) as object;
                }
                else if (ax_())
                {
                    DataType bq_ = CataractSurgery?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return (br_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDateTime m_ = context.Operators.End(e_);
            CqlQuantity n_ = context.Operators.Quantity(92m, "days");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            bool? p_ = context.Operators.SameOrBefore(k_, o_, "day");
            bool? q_ = context.Operators.And(h_, p_);
            Code<EventStatus> r_ = CataractSurgery?.StatusElement;
            EventStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            bool? u_ = context.Operators.Equal(t_, "completed");
            bool? v_ = context.Operators.And(q_, u_);
            return v_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 156850899568859544L;

    private IEnumerable<Procedure> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);

        bool? b_(Procedure CataractSurgeryPerformed) {
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
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -7754270258949913857L;

    private IEnumerable<Procedure> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Cataract Surgeries in Patients with Significant Ocular Conditions Impacting the Visual Outcome of Surgery")]
    public IEnumerable<Procedure> Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery, Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery_Compute);

    private const long _cacheIndex_Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery = 6166762621108457820L;

    private IEnumerable<Procedure> Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);

        IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed) {
            CqlValueSet d_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
            CqlValueSet i_ = this.Amblyopia(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);
            IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
            CqlValueSet o_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_ as IEnumerable<Condition>, r_ as IEnumerable<Condition>);
            IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
            CqlValueSet u_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> y_ = context.Operators.Union<Condition>(v_ as IEnumerable<Condition>, x_ as IEnumerable<Condition>);
            IEnumerable<Condition> z_ = context.Operators.Union<Condition>(t_, y_);
            CqlValueSet aa_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> ab_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ad_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(ab_ as IEnumerable<Condition>, ad_ as IEnumerable<Condition>);
            IEnumerable<Condition> af_ = context.Operators.Union<Condition>(z_, ae_);
            CqlValueSet ag_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ak_ = context.Operators.Union<Condition>(ah_ as IEnumerable<Condition>, aj_ as IEnumerable<Condition>);
            IEnumerable<Condition> al_ = context.Operators.Union<Condition>(af_, ak_);
            CqlValueSet am_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ap_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> aq_ = context.Operators.Union<Condition>(an_ as IEnumerable<Condition>, ap_ as IEnumerable<Condition>);
            IEnumerable<Condition> ar_ = context.Operators.Union<Condition>(al_, aq_);
            CqlValueSet as_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> at_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> av_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> aw_ = context.Operators.Union<Condition>(at_ as IEnumerable<Condition>, av_ as IEnumerable<Condition>);
            IEnumerable<Condition> ax_ = context.Operators.Union<Condition>(ar_, aw_);
            CqlValueSet ay_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> az_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bc_ = context.Operators.Union<Condition>(az_ as IEnumerable<Condition>, bb_ as IEnumerable<Condition>);
            IEnumerable<Condition> bd_ = context.Operators.Union<Condition>(ax_, bc_);
            CqlValueSet be_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bi_ = context.Operators.Union<Condition>(bf_ as IEnumerable<Condition>, bh_ as IEnumerable<Condition>);
            IEnumerable<Condition> bj_ = context.Operators.Union<Condition>(bd_, bi_);
            CqlValueSet bk_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> bl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bo_ = context.Operators.Union<Condition>(bl_ as IEnumerable<Condition>, bn_ as IEnumerable<Condition>);
            IEnumerable<Condition> bp_ = context.Operators.Union<Condition>(bj_, bo_);
            CqlValueSet bq_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> br_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bu_ = context.Operators.Union<Condition>(br_ as IEnumerable<Condition>, bt_ as IEnumerable<Condition>);
            IEnumerable<Condition> bv_ = context.Operators.Union<Condition>(bp_, bu_);
            CqlValueSet bw_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> bx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ca_ = context.Operators.Union<Condition>(bx_ as IEnumerable<Condition>, bz_ as IEnumerable<Condition>);
            IEnumerable<Condition> cb_ = context.Operators.Union<Condition>(bv_, ca_);
            CqlValueSet cc_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> cd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cg_ = context.Operators.Union<Condition>(cd_ as IEnumerable<Condition>, cf_ as IEnumerable<Condition>);
            IEnumerable<Condition> ch_ = context.Operators.Union<Condition>(cb_, cg_);
            CqlValueSet ci_ = this.Corneal_Edema(context);
            IEnumerable<Condition> cj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ci_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ci_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cm_ = context.Operators.Union<Condition>(cj_ as IEnumerable<Condition>, cl_ as IEnumerable<Condition>);
            IEnumerable<Condition> cn_ = context.Operators.Union<Condition>(ch_, cm_);
            CqlValueSet co_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> cp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cs_ = context.Operators.Union<Condition>(cp_ as IEnumerable<Condition>, cr_ as IEnumerable<Condition>);
            IEnumerable<Condition> ct_ = context.Operators.Union<Condition>(cn_, cs_);
            CqlValueSet cu_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> cv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cy_ = context.Operators.Union<Condition>(cv_ as IEnumerable<Condition>, cx_ as IEnumerable<Condition>);
            IEnumerable<Condition> cz_ = context.Operators.Union<Condition>(ct_, cy_);
            CqlValueSet da_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> db_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> de_ = context.Operators.Union<Condition>(db_ as IEnumerable<Condition>, dd_ as IEnumerable<Condition>);
            IEnumerable<Condition> df_ = context.Operators.Union<Condition>(cz_, de_);
            CqlValueSet dg_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> dh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dk_ = context.Operators.Union<Condition>(dh_ as IEnumerable<Condition>, dj_ as IEnumerable<Condition>);
            IEnumerable<Condition> dl_ = context.Operators.Union<Condition>(df_, dk_);
            CqlValueSet dm_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> dn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dq_ = context.Operators.Union<Condition>(dn_ as IEnumerable<Condition>, dp_ as IEnumerable<Condition>);
            IEnumerable<Condition> dr_ = context.Operators.Union<Condition>(dl_, dq_);
            CqlValueSet ds_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> dt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dw_ = context.Operators.Union<Condition>(dt_ as IEnumerable<Condition>, dv_ as IEnumerable<Condition>);
            IEnumerable<Condition> dx_ = context.Operators.Union<Condition>(dr_, dw_);
            CqlValueSet dy_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> dz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> eb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ec_ = context.Operators.Union<Condition>(dz_ as IEnumerable<Condition>, eb_ as IEnumerable<Condition>);
            IEnumerable<Condition> ed_ = context.Operators.Union<Condition>(dx_, ec_);
            CqlValueSet ee_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> ef_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ee_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> eh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ee_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ei_ = context.Operators.Union<Condition>(ef_ as IEnumerable<Condition>, eh_ as IEnumerable<Condition>);
            IEnumerable<Condition> ej_ = context.Operators.Union<Condition>(ed_, ei_);
            CqlValueSet ek_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> el_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ek_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> en_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ek_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> eo_ = context.Operators.Union<Condition>(el_ as IEnumerable<Condition>, en_ as IEnumerable<Condition>);
            IEnumerable<Condition> ep_ = context.Operators.Union<Condition>(ej_, eo_);
            CqlValueSet eq_ = this.Glaucoma(context);
            IEnumerable<Condition> er_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> et_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> eu_ = context.Operators.Union<Condition>(er_ as IEnumerable<Condition>, et_ as IEnumerable<Condition>);
            IEnumerable<Condition> ev_ = context.Operators.Union<Condition>(ep_, eu_);
            CqlValueSet ew_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> ex_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ew_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ez_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ew_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fa_ = context.Operators.Union<Condition>(ex_ as IEnumerable<Condition>, ez_ as IEnumerable<Condition>);
            IEnumerable<Condition> fb_ = context.Operators.Union<Condition>(ev_, fa_);
            CqlValueSet fc_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> fd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ff_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fg_ = context.Operators.Union<Condition>(fd_ as IEnumerable<Condition>, ff_ as IEnumerable<Condition>);
            IEnumerable<Condition> fh_ = context.Operators.Union<Condition>(fb_, fg_);
            CqlValueSet fi_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> fj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fm_ = context.Operators.Union<Condition>(fj_ as IEnumerable<Condition>, fl_ as IEnumerable<Condition>);
            IEnumerable<Condition> fn_ = context.Operators.Union<Condition>(fh_, fm_);
            CqlValueSet fo_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> fp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fs_ = context.Operators.Union<Condition>(fp_ as IEnumerable<Condition>, fr_ as IEnumerable<Condition>);
            IEnumerable<Condition> ft_ = context.Operators.Union<Condition>(fn_, fs_);
            CqlValueSet fu_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> fv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fy_ = context.Operators.Union<Condition>(fv_ as IEnumerable<Condition>, fx_ as IEnumerable<Condition>);
            IEnumerable<Condition> fz_ = context.Operators.Union<Condition>(ft_, fy_);
            CqlValueSet ga_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> gb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ga_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ga_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ge_ = context.Operators.Union<Condition>(gb_ as IEnumerable<Condition>, gd_ as IEnumerable<Condition>);
            IEnumerable<Condition> gf_ = context.Operators.Union<Condition>(fz_, ge_);
            CqlValueSet gg_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> gh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gk_ = context.Operators.Union<Condition>(gh_ as IEnumerable<Condition>, gj_ as IEnumerable<Condition>);
            IEnumerable<Condition> gl_ = context.Operators.Union<Condition>(gf_, gk_);
            CqlValueSet gm_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> gn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gq_ = context.Operators.Union<Condition>(gn_ as IEnumerable<Condition>, gp_ as IEnumerable<Condition>);
            IEnumerable<Condition> gr_ = context.Operators.Union<Condition>(gl_, gq_);
            CqlValueSet gs_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> gt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gw_ = context.Operators.Union<Condition>(gt_ as IEnumerable<Condition>, gv_ as IEnumerable<Condition>);
            IEnumerable<Condition> gx_ = context.Operators.Union<Condition>(gr_, gw_);
            CqlValueSet gy_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> gz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hc_ = context.Operators.Union<Condition>(gz_ as IEnumerable<Condition>, hb_ as IEnumerable<Condition>);
            IEnumerable<Condition> hd_ = context.Operators.Union<Condition>(gx_, hc_);
            CqlValueSet he_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> hf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hi_ = context.Operators.Union<Condition>(hf_ as IEnumerable<Condition>, hh_ as IEnumerable<Condition>);
            IEnumerable<Condition> hj_ = context.Operators.Union<Condition>(hd_, hi_);
            CqlValueSet hk_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> hl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ho_ = context.Operators.Union<Condition>(hl_ as IEnumerable<Condition>, hn_ as IEnumerable<Condition>);
            IEnumerable<Condition> hp_ = context.Operators.Union<Condition>(hj_, ho_);
            CqlValueSet hq_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> hr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ht_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hu_ = context.Operators.Union<Condition>(hr_ as IEnumerable<Condition>, ht_ as IEnumerable<Condition>);
            IEnumerable<Condition> hv_ = context.Operators.Union<Condition>(hp_, hu_);
            CqlValueSet hw_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> hx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ia_ = context.Operators.Union<Condition>(hx_ as IEnumerable<Condition>, hz_ as IEnumerable<Condition>);
            IEnumerable<Condition> ib_ = context.Operators.Union<Condition>(hv_, ia_);
            CqlValueSet ic_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> id_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ic_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> if_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ic_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ig_ = context.Operators.Union<Condition>(id_ as IEnumerable<Condition>, if_ as IEnumerable<Condition>);
            IEnumerable<Condition> ih_ = context.Operators.Union<Condition>(ib_, ig_);
            CqlValueSet ii_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> ij_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ii_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> il_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ii_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> im_ = context.Operators.Union<Condition>(ij_ as IEnumerable<Condition>, il_ as IEnumerable<Condition>);
            IEnumerable<Condition> in_ = context.Operators.Union<Condition>(ih_, im_);
            CqlValueSet io_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> ip_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, io_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ir_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, io_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> is_ = context.Operators.Union<Condition>(ip_ as IEnumerable<Condition>, ir_ as IEnumerable<Condition>);
            IEnumerable<Condition> it_ = context.Operators.Union<Condition>(in_, is_);
            CqlValueSet iu_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> iv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, iu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ix_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, iu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> iy_ = context.Operators.Union<Condition>(iv_ as IEnumerable<Condition>, ix_ as IEnumerable<Condition>);
            IEnumerable<Condition> iz_ = context.Operators.Union<Condition>(it_, iy_);
            CqlValueSet ja_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> jb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ja_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ja_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> je_ = context.Operators.Union<Condition>(jb_ as IEnumerable<Condition>, jd_ as IEnumerable<Condition>);
            IEnumerable<Condition> jf_ = context.Operators.Union<Condition>(iz_, je_);
            CqlValueSet jg_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> jh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jk_ = context.Operators.Union<Condition>(jh_ as IEnumerable<Condition>, jj_ as IEnumerable<Condition>);
            IEnumerable<Condition> jl_ = context.Operators.Union<Condition>(jf_, jk_);
            CqlValueSet jm_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> jn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jq_ = context.Operators.Union<Condition>(jn_ as IEnumerable<Condition>, jp_ as IEnumerable<Condition>);
            IEnumerable<Condition> jr_ = context.Operators.Union<Condition>(jl_, jq_);
            CqlValueSet js_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> jt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, js_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, js_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jw_ = context.Operators.Union<Condition>(jt_ as IEnumerable<Condition>, jv_ as IEnumerable<Condition>);
            IEnumerable<Condition> jx_ = context.Operators.Union<Condition>(jr_, jw_);
            CqlValueSet jy_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> jz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> kb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> kc_ = context.Operators.Union<Condition>(jz_ as IEnumerable<Condition>, kb_ as IEnumerable<Condition>);
            IEnumerable<Condition> kd_ = context.Operators.Union<Condition>(jx_, kc_);
            CqlValueSet ke_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> kf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ke_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> kh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ke_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ki_ = context.Operators.Union<Condition>(kf_ as IEnumerable<Condition>, kh_ as IEnumerable<Condition>);
            IEnumerable<Condition> kj_ = context.Operators.Union<Condition>(kd_, ki_);
            CqlValueSet kk_ = this.Scleritis(context);
            IEnumerable<Condition> kl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> kn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ko_ = context.Operators.Union<Condition>(kl_ as IEnumerable<Condition>, kn_ as IEnumerable<Condition>);
            IEnumerable<Condition> kp_ = context.Operators.Union<Condition>(kj_, ko_);
            CqlValueSet kq_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> kr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> kt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ku_ = context.Operators.Union<Condition>(kr_ as IEnumerable<Condition>, kt_ as IEnumerable<Condition>);
            IEnumerable<Condition> kv_ = context.Operators.Union<Condition>(kp_, ku_);
            CqlValueSet kw_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> kx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> kz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> la_ = context.Operators.Union<Condition>(kx_ as IEnumerable<Condition>, kz_ as IEnumerable<Condition>);
            IEnumerable<Condition> lb_ = context.Operators.Union<Condition>(kv_, la_);
            CqlValueSet lc_ = this.Uveitis(context);
            IEnumerable<Condition> ld_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> lf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> lg_ = context.Operators.Union<Condition>(ld_ as IEnumerable<Condition>, lf_ as IEnumerable<Condition>);
            IEnumerable<Condition> lh_ = context.Operators.Union<Condition>(lb_, lg_);
            CqlValueSet li_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> lj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, li_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ll_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, li_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> lm_ = context.Operators.Union<Condition>(lj_ as IEnumerable<Condition>, ll_ as IEnumerable<Condition>);
            IEnumerable<Condition> ln_ = context.Operators.Union<Condition>(lh_, lm_);
            CqlValueSet lo_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> lp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> lr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ls_ = context.Operators.Union<Condition>(lp_ as IEnumerable<Condition>, lr_ as IEnumerable<Condition>);
            IEnumerable<Condition> lt_ = context.Operators.Union<Condition>(ln_, ls_);

            bool? lu_(Condition ComorbidDiagnosis) {
                CqlInterval<CqlDateTime> ly_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);

                object lz_() {

                    bool me_() {
                        DataType mi_ = CataractSurgeryPerformed?.Performed;
                        object mj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mi_);
                        bool mk_ = mj_ is CqlDateTime;
                        return mk_;
                    }


                    bool mf_() {
                        DataType ml_ = CataractSurgeryPerformed?.Performed;
                        object mm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ml_);
                        bool mn_ = mm_ is CqlInterval<CqlDateTime>;
                        return mn_;
                    }


                    bool mg_() {
                        DataType mo_ = CataractSurgeryPerformed?.Performed;
                        object mp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mo_);
                        bool mq_ = mp_ is CqlQuantity;
                        return mq_;
                    }


                    bool mh_() {
                        DataType mr_ = CataractSurgeryPerformed?.Performed;
                        object ms_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mr_);
                        bool mt_ = ms_ is CqlInterval<CqlQuantity>;
                        return mt_;
                    }

                    if (me_())
                    {
                        DataType mu_ = CataractSurgeryPerformed?.Performed;
                        object mv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mu_);
                        return (mv_ as CqlDateTime) as object;
                    }
                    else if (mf_())
                    {
                        DataType mw_ = CataractSurgeryPerformed?.Performed;
                        object mx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mw_);
                        return (mx_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (mg_())
                    {
                        DataType my_ = CataractSurgeryPerformed?.Performed;
                        object mz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, my_);
                        return (mz_ as CqlQuantity) as object;
                    }
                    else if (mh_())
                    {
                        DataType na_ = CataractSurgeryPerformed?.Performed;
                        object nb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, na_);
                        return (nb_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ma_ = QICoreCommon_4_0_000.Instance.toInterval(context, lz_());
                bool? mb_ = context.Operators.OverlapsBefore(ly_, ma_, "day");
                bool? mc_ = this.isVerified(context, ComorbidDiagnosis);
                bool? md_ = context.Operators.And(mb_, mc_);
                return md_;
            }

            IEnumerable<Condition> lv_ = context.Operators.Where<Condition>(lt_, lu_);
            Procedure lw_(Condition ComorbidDiagnosis) => CataractSurgeryPerformed;
            IEnumerable<Procedure> lx_ = context.Operators.Select<Condition, Procedure>(lv_, lw_);
            return lx_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -3599080278286777202L;

    private IEnumerable<Procedure> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8787873102356196514L;

    private IEnumerable<Procedure> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);

        IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed) {
            CqlCode d_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
            CqlValueSet g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
            IEnumerable<Observation> i_ = context.Operators.Union<Observation>(f_, h_);

            bool? j_(Observation VisualAcuityExamPerformed) {
                DataType n_ = VisualAcuityExamPerformed?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);

                object r_() {

                    bool ar_() {
                        DataType av_ = CataractSurgeryPerformed?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlDateTime;
                        return ax_;
                    }


                    bool as_() {
                        DataType ay_ = CataractSurgeryPerformed?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlInterval<CqlDateTime>;
                        return ba_;
                    }


                    bool at_() {
                        DataType bb_ = CataractSurgeryPerformed?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        return bd_;
                    }


                    bool au_() {
                        DataType be_ = CataractSurgeryPerformed?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                        return bg_;
                    }

                    if (ar_())
                    {
                        DataType bh_ = CataractSurgeryPerformed?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        return (bi_ as CqlDateTime) as object;
                    }
                    else if (as_())
                    {
                        DataType bj_ = CataractSurgeryPerformed?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        return (bk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (at_())
                    {
                        DataType bl_ = CataractSurgeryPerformed?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        return (bm_ as CqlQuantity) as object;
                    }
                    else if (au_())
                    {
                        DataType bn_ = CataractSurgeryPerformed?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        return (bo_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.End(s_);

                object u_() {

                    bool bp_() {
                        DataType bt_ = CataractSurgeryPerformed?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlDateTime;
                        return bv_;
                    }


                    bool bq_() {
                        DataType bw_ = CataractSurgeryPerformed?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        return by_;
                    }


                    bool br_() {
                        DataType bz_ = CataractSurgeryPerformed?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlQuantity;
                        return cb_;
                    }


                    bool bs_() {
                        DataType cc_ = CataractSurgeryPerformed?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                        return ce_;
                    }

                    if (bp_())
                    {
                        DataType cf_ = CataractSurgeryPerformed?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        return (cg_ as CqlDateTime) as object;
                    }
                    else if (bq_())
                    {
                        DataType ch_ = CataractSurgeryPerformed?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return (ci_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (br_())
                    {
                        DataType cj_ = CataractSurgeryPerformed?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return (ck_ as CqlQuantity) as object;
                    }
                    else if (bs_())
                    {
                        DataType cl_ = CataractSurgeryPerformed?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        return (cm_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(90m, "days");
                CqlDateTime y_ = context.Operators.Add(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(t_, y_, false, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");

                object ab_() {

                    bool cn_() {
                        DataType cr_ = CataractSurgeryPerformed?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlDateTime;
                        return ct_;
                    }


                    bool co_() {
                        DataType cu_ = CataractSurgeryPerformed?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                        return cw_;
                    }


                    bool cp_() {
                        DataType cx_ = CataractSurgeryPerformed?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        bool cz_ = cy_ is CqlQuantity;
                        return cz_;
                    }


                    bool cq_() {
                        DataType da_ = CataractSurgeryPerformed?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlQuantity>;
                        return dc_;
                    }

                    if (cn_())
                    {
                        DataType dd_ = CataractSurgeryPerformed?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        return (de_ as CqlDateTime) as object;
                    }
                    else if (co_())
                    {
                        DataType df_ = CataractSurgeryPerformed?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        return (dg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (cp_())
                    {
                        DataType dh_ = CataractSurgeryPerformed?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        return (di_ as CqlQuantity) as object;
                    }
                    else if (cq_())
                    {
                        DataType dj_ = CataractSurgeryPerformed?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        return (dk_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
                CqlDateTime ad_ = context.Operators.End(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                Code<ObservationStatus> ag_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                string[] aj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                bool? al_ = context.Operators.And(af_, ak_);
                DataType am_ = VisualAcuityExamPerformed?.Value;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlValueSet ao_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_ as CqlConcept, ao_);
                bool? aq_ = context.Operators.And(al_, ap_);
                return aq_;
            }

            IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
            Procedure l_(Observation VisualAcuityExamPerformed) => CataractSurgeryPerformed;
            IEnumerable<Procedure> m_ = context.Operators.Select<Observation, Procedure>(k_, l_);
            return m_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 410851233763199253L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8606949024631205076L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -2789265792709226923L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -5892648424074902819L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS133FHIRCataracts2040BCVA90Days_1_0_000() {}

    public static CMS133FHIRCataracts2040BCVA90Days_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS133FHIRCataracts2040BCVA90Days";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
