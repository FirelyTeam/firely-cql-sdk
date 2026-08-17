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
            object f_;
            DataType k_ = CataractSurgery?.Performed;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            bool m_ = l_ is CqlDateTime;
            if (m_)
            {
                f_ = l_ as CqlDateTime;
            }
            else
            {
                bool n_ = l_ is CqlQuantity;
                if (n_)
                {
                    f_ = l_ as CqlQuantity;
                }
                else
                {
                    bool o_ = l_ is CqlInterval<CqlDateTime>;
                    if (o_)
                    {
                        f_ = l_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool p_ = l_ is CqlInterval<CqlQuantity>;
                        if (p_)
                        {
                            f_ = l_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");

            CqlBoolean i_() {
                object q_;
                DataType y_ = CataractSurgery?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    q_ = z_ as CqlDateTime;
                }
                else
                {
                    bool ab_ = z_ is CqlQuantity;
                    if (ab_)
                    {
                        q_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        bool ac_ = z_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            q_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ad_ = z_ is CqlInterval<CqlQuantity>;
                            if (ad_)
                            {
                                q_ = z_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlQuantity v_ = context.Operators.Quantity(92m, "days");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                bool? x_ = context.Operators.SameOrBefore(s_, w_, "day");
                return x_;
            }


            CqlBoolean j_() {
                Code<EventStatus> ae_ = CataractSurgery?.StatusElement;
                EventStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "completed");
                return ah_;
            }

            return (bool?)(/* CQL 'and' (86:5-88:46) */ (/* CQL 'and' (86:11-87:115) */ ((CqlBoolean)h_
                && i_())
                && j_()));
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

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return /* CQL 'or' (277:52-281:3) */ (/* CQL 'or' (277:54-279:66) */ (/* CQL 'or' (277:54-278:66) */ ((CqlBoolean)h_
                || i_())
                || j_())
                || k_());
        }

        return (bool?)(/* CQL 'implies' (277:3-281:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || c_()));
    }


    [CqlExpressionDefinition("Cataract Surgeries in Patients with Significant Ocular Conditions Impacting the Visual Outcome of Surgery")]
    public IEnumerable<Procedure> Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery, Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery_Compute);

    private const long _cacheIndex_Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery = 6166762621108457820L;

    private IEnumerable<Procedure> Cataract_Surgeries_in_Patients_with_Significant_Ocular_Conditions_Impacting_the_Visual_Outcome_of_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);

        bool? b_(Procedure CataractSurgeryPerformed) {
            CqlValueSet d_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
            CqlValueSet h_ = this.Amblyopia(context);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> k_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, j_ as IEnumerable<Condition>);
            IEnumerable<Condition> l_ = context.Operators.Union<Condition>(g_, k_);
            CqlValueSet m_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> p_ = context.Operators.Union<Condition>(n_ as IEnumerable<Condition>, o_ as IEnumerable<Condition>);
            IEnumerable<Condition> q_ = context.Operators.Union<Condition>(l_, p_);
            CqlValueSet r_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> u_ = context.Operators.Union<Condition>(s_ as IEnumerable<Condition>, t_ as IEnumerable<Condition>);
            IEnumerable<Condition> v_ = context.Operators.Union<Condition>(q_, u_);
            CqlValueSet w_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> z_ = context.Operators.Union<Condition>(x_ as IEnumerable<Condition>, y_ as IEnumerable<Condition>);
            IEnumerable<Condition> aa_ = context.Operators.Union<Condition>(v_, z_);
            CqlValueSet ab_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ad_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(ac_ as IEnumerable<Condition>, ad_ as IEnumerable<Condition>);
            IEnumerable<Condition> af_ = context.Operators.Union<Condition>(aa_, ae_);
            CqlValueSet ag_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ai_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> aj_ = context.Operators.Union<Condition>(ah_ as IEnumerable<Condition>, ai_ as IEnumerable<Condition>);
            IEnumerable<Condition> ak_ = context.Operators.Union<Condition>(af_, aj_);
            CqlValueSet al_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(am_ as IEnumerable<Condition>, an_ as IEnumerable<Condition>);
            IEnumerable<Condition> ap_ = context.Operators.Union<Condition>(ak_, ao_);
            CqlValueSet aq_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> ar_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> as_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> at_ = context.Operators.Union<Condition>(ar_ as IEnumerable<Condition>, as_ as IEnumerable<Condition>);
            IEnumerable<Condition> au_ = context.Operators.Union<Condition>(ap_, at_);
            CqlValueSet av_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> aw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ax_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ay_ = context.Operators.Union<Condition>(aw_ as IEnumerable<Condition>, ax_ as IEnumerable<Condition>);
            IEnumerable<Condition> az_ = context.Operators.Union<Condition>(au_, ay_);
            CqlValueSet ba_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> bb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bd_ = context.Operators.Union<Condition>(bb_ as IEnumerable<Condition>, bc_ as IEnumerable<Condition>);
            IEnumerable<Condition> be_ = context.Operators.Union<Condition>(az_, bd_);
            CqlValueSet bf_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> bg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bi_ = context.Operators.Union<Condition>(bg_ as IEnumerable<Condition>, bh_ as IEnumerable<Condition>);
            IEnumerable<Condition> bj_ = context.Operators.Union<Condition>(be_, bi_);
            CqlValueSet bk_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> bl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bn_ = context.Operators.Union<Condition>(bl_ as IEnumerable<Condition>, bm_ as IEnumerable<Condition>);
            IEnumerable<Condition> bo_ = context.Operators.Union<Condition>(bj_, bn_);
            CqlValueSet bp_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> bq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> br_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bs_ = context.Operators.Union<Condition>(bq_ as IEnumerable<Condition>, br_ as IEnumerable<Condition>);
            IEnumerable<Condition> bt_ = context.Operators.Union<Condition>(bo_, bs_);
            CqlValueSet bu_ = this.Corneal_Edema(context);
            IEnumerable<Condition> bv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> bx_ = context.Operators.Union<Condition>(bv_ as IEnumerable<Condition>, bw_ as IEnumerable<Condition>);
            IEnumerable<Condition> by_ = context.Operators.Union<Condition>(bt_, bx_);
            CqlValueSet bz_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> ca_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cc_ = context.Operators.Union<Condition>(ca_ as IEnumerable<Condition>, cb_ as IEnumerable<Condition>);
            IEnumerable<Condition> cd_ = context.Operators.Union<Condition>(by_, cc_);
            CqlValueSet ce_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> cf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ce_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ce_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ch_ = context.Operators.Union<Condition>(cf_ as IEnumerable<Condition>, cg_ as IEnumerable<Condition>);
            IEnumerable<Condition> ci_ = context.Operators.Union<Condition>(cd_, ch_);
            CqlValueSet cj_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> ck_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cm_ = context.Operators.Union<Condition>(ck_ as IEnumerable<Condition>, cl_ as IEnumerable<Condition>);
            IEnumerable<Condition> cn_ = context.Operators.Union<Condition>(ci_, cm_);
            CqlValueSet co_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> cp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cr_ = context.Operators.Union<Condition>(cp_ as IEnumerable<Condition>, cq_ as IEnumerable<Condition>);
            IEnumerable<Condition> cs_ = context.Operators.Union<Condition>(cn_, cr_);
            CqlValueSet ct_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> cu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ct_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ct_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cw_ = context.Operators.Union<Condition>(cu_ as IEnumerable<Condition>, cv_ as IEnumerable<Condition>);
            IEnumerable<Condition> cx_ = context.Operators.Union<Condition>(cs_, cw_);
            CqlValueSet cy_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> cz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> da_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> db_ = context.Operators.Union<Condition>(cz_ as IEnumerable<Condition>, da_ as IEnumerable<Condition>);
            IEnumerable<Condition> dc_ = context.Operators.Union<Condition>(cx_, db_);
            CqlValueSet dd_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> de_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> df_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dg_ = context.Operators.Union<Condition>(de_ as IEnumerable<Condition>, df_ as IEnumerable<Condition>);
            IEnumerable<Condition> dh_ = context.Operators.Union<Condition>(dc_, dg_);
            CqlValueSet di_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> dj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dl_ = context.Operators.Union<Condition>(dj_ as IEnumerable<Condition>, dk_ as IEnumerable<Condition>);
            IEnumerable<Condition> dm_ = context.Operators.Union<Condition>(dh_, dl_);
            CqlValueSet dn_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> do_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dq_ = context.Operators.Union<Condition>(do_ as IEnumerable<Condition>, dp_ as IEnumerable<Condition>);
            IEnumerable<Condition> dr_ = context.Operators.Union<Condition>(dm_, dq_);
            CqlValueSet ds_ = this.Glaucoma(context);
            IEnumerable<Condition> dt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> du_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> dv_ = context.Operators.Union<Condition>(dt_ as IEnumerable<Condition>, du_ as IEnumerable<Condition>);
            IEnumerable<Condition> dw_ = context.Operators.Union<Condition>(dr_, dv_);
            CqlValueSet dx_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> dy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> dz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ea_ = context.Operators.Union<Condition>(dy_ as IEnumerable<Condition>, dz_ as IEnumerable<Condition>);
            IEnumerable<Condition> eb_ = context.Operators.Union<Condition>(dw_, ea_);
            CqlValueSet ec_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> ed_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ec_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ee_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ec_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ef_ = context.Operators.Union<Condition>(ed_ as IEnumerable<Condition>, ee_ as IEnumerable<Condition>);
            IEnumerable<Condition> eg_ = context.Operators.Union<Condition>(eb_, ef_);
            CqlValueSet eh_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> ei_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ej_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ek_ = context.Operators.Union<Condition>(ei_ as IEnumerable<Condition>, ej_ as IEnumerable<Condition>);
            IEnumerable<Condition> el_ = context.Operators.Union<Condition>(eg_, ek_);
            CqlValueSet em_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> en_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> eo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ep_ = context.Operators.Union<Condition>(en_ as IEnumerable<Condition>, eo_ as IEnumerable<Condition>);
            IEnumerable<Condition> eq_ = context.Operators.Union<Condition>(el_, ep_);
            CqlValueSet er_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> es_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, er_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> et_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, er_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> eu_ = context.Operators.Union<Condition>(es_ as IEnumerable<Condition>, et_ as IEnumerable<Condition>);
            IEnumerable<Condition> ev_ = context.Operators.Union<Condition>(eq_, eu_);
            CqlValueSet ew_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> ex_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ew_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ey_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ew_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ez_ = context.Operators.Union<Condition>(ex_ as IEnumerable<Condition>, ey_ as IEnumerable<Condition>);
            IEnumerable<Condition> fa_ = context.Operators.Union<Condition>(ev_, ez_);
            CqlValueSet fb_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> fc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fe_ = context.Operators.Union<Condition>(fc_ as IEnumerable<Condition>, fd_ as IEnumerable<Condition>);
            IEnumerable<Condition> ff_ = context.Operators.Union<Condition>(fa_, fe_);
            CqlValueSet fg_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> fh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fj_ = context.Operators.Union<Condition>(fh_ as IEnumerable<Condition>, fi_ as IEnumerable<Condition>);
            IEnumerable<Condition> fk_ = context.Operators.Union<Condition>(ff_, fj_);
            CqlValueSet fl_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> fm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fo_ = context.Operators.Union<Condition>(fm_ as IEnumerable<Condition>, fn_ as IEnumerable<Condition>);
            IEnumerable<Condition> fp_ = context.Operators.Union<Condition>(fk_, fo_);
            CqlValueSet fq_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> fr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ft_ = context.Operators.Union<Condition>(fr_ as IEnumerable<Condition>, fs_ as IEnumerable<Condition>);
            IEnumerable<Condition> fu_ = context.Operators.Union<Condition>(fp_, ft_);
            CqlValueSet fv_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> fw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> fx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> fy_ = context.Operators.Union<Condition>(fw_ as IEnumerable<Condition>, fx_ as IEnumerable<Condition>);
            IEnumerable<Condition> fz_ = context.Operators.Union<Condition>(fu_, fy_);
            CqlValueSet ga_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> gb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ga_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ga_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gd_ = context.Operators.Union<Condition>(gb_ as IEnumerable<Condition>, gc_ as IEnumerable<Condition>);
            IEnumerable<Condition> ge_ = context.Operators.Union<Condition>(fz_, gd_);
            CqlValueSet gf_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> gg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gi_ = context.Operators.Union<Condition>(gg_ as IEnumerable<Condition>, gh_ as IEnumerable<Condition>);
            IEnumerable<Condition> gj_ = context.Operators.Union<Condition>(ge_, gi_);
            CqlValueSet gk_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> gl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gn_ = context.Operators.Union<Condition>(gl_ as IEnumerable<Condition>, gm_ as IEnumerable<Condition>);
            IEnumerable<Condition> go_ = context.Operators.Union<Condition>(gj_, gn_);
            CqlValueSet gp_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> gq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gs_ = context.Operators.Union<Condition>(gq_ as IEnumerable<Condition>, gr_ as IEnumerable<Condition>);
            IEnumerable<Condition> gt_ = context.Operators.Union<Condition>(go_, gs_);
            CqlValueSet gu_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> gv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> gw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> gx_ = context.Operators.Union<Condition>(gv_ as IEnumerable<Condition>, gw_ as IEnumerable<Condition>);
            IEnumerable<Condition> gy_ = context.Operators.Union<Condition>(gt_, gx_);
            CqlValueSet gz_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> ha_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hc_ = context.Operators.Union<Condition>(ha_ as IEnumerable<Condition>, hb_ as IEnumerable<Condition>);
            IEnumerable<Condition> hd_ = context.Operators.Union<Condition>(gy_, hc_);
            CqlValueSet he_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> hf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, he_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hh_ = context.Operators.Union<Condition>(hf_ as IEnumerable<Condition>, hg_ as IEnumerable<Condition>);
            IEnumerable<Condition> hi_ = context.Operators.Union<Condition>(hd_, hh_);
            CqlValueSet hj_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> hk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hm_ = context.Operators.Union<Condition>(hk_ as IEnumerable<Condition>, hl_ as IEnumerable<Condition>);
            IEnumerable<Condition> hn_ = context.Operators.Union<Condition>(hi_, hm_);
            CqlValueSet ho_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> hp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ho_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ho_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hr_ = context.Operators.Union<Condition>(hp_ as IEnumerable<Condition>, hq_ as IEnumerable<Condition>);
            IEnumerable<Condition> hs_ = context.Operators.Union<Condition>(hn_, hr_);
            CqlValueSet ht_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> hu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ht_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> hv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ht_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> hw_ = context.Operators.Union<Condition>(hu_ as IEnumerable<Condition>, hv_ as IEnumerable<Condition>);
            IEnumerable<Condition> hx_ = context.Operators.Union<Condition>(hs_, hw_);
            CqlValueSet hy_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> hz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ia_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ib_ = context.Operators.Union<Condition>(hz_ as IEnumerable<Condition>, ia_ as IEnumerable<Condition>);
            IEnumerable<Condition> ic_ = context.Operators.Union<Condition>(hx_, ib_);
            CqlValueSet id_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> ie_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, id_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> if_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, id_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ig_ = context.Operators.Union<Condition>(ie_ as IEnumerable<Condition>, if_ as IEnumerable<Condition>);
            IEnumerable<Condition> ih_ = context.Operators.Union<Condition>(ic_, ig_);
            CqlValueSet ii_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> ij_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ii_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ik_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ii_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> il_ = context.Operators.Union<Condition>(ij_ as IEnumerable<Condition>, ik_ as IEnumerable<Condition>);
            IEnumerable<Condition> im_ = context.Operators.Union<Condition>(ih_, il_);
            CqlValueSet in_ = this.Scleritis(context);
            IEnumerable<Condition> io_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, in_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ip_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, in_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> iq_ = context.Operators.Union<Condition>(io_ as IEnumerable<Condition>, ip_ as IEnumerable<Condition>);
            IEnumerable<Condition> ir_ = context.Operators.Union<Condition>(im_, iq_);
            CqlValueSet is_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> it_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, is_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> iu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, is_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> iv_ = context.Operators.Union<Condition>(it_ as IEnumerable<Condition>, iu_ as IEnumerable<Condition>);
            IEnumerable<Condition> iw_ = context.Operators.Union<Condition>(ir_, iv_);
            CqlValueSet ix_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> iy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ix_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> iz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ix_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ja_ = context.Operators.Union<Condition>(iy_ as IEnumerable<Condition>, iz_ as IEnumerable<Condition>);
            IEnumerable<Condition> jb_ = context.Operators.Union<Condition>(iw_, ja_);
            CqlValueSet jc_ = this.Uveitis(context);
            IEnumerable<Condition> jd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> je_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jf_ = context.Operators.Union<Condition>(jd_ as IEnumerable<Condition>, je_ as IEnumerable<Condition>);
            IEnumerable<Condition> jg_ = context.Operators.Union<Condition>(jb_, jf_);
            CqlValueSet jh_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> ji_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jk_ = context.Operators.Union<Condition>(ji_ as IEnumerable<Condition>, jj_ as IEnumerable<Condition>);
            IEnumerable<Condition> jl_ = context.Operators.Union<Condition>(jg_, jk_);
            CqlValueSet jm_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> jn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> jo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> jp_ = context.Operators.Union<Condition>(jn_ as IEnumerable<Condition>, jo_ as IEnumerable<Condition>);
            IEnumerable<Condition> jq_ = context.Operators.Union<Condition>(jl_, jp_);

            bool? jr_(Condition ComorbidDiagnosis) {
                CqlInterval<CqlDateTime> jt_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                object ju_;
                DataType jx_ = CataractSurgeryPerformed?.Performed;
                object jy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jx_);
                bool jz_ = jy_ is CqlDateTime;
                if (jz_)
                {
                    ju_ = jy_ as CqlDateTime;
                }
                else
                {
                    bool ka_ = jy_ is CqlQuantity;
                    if (ka_)
                    {
                        ju_ = jy_ as CqlQuantity;
                    }
                    else
                    {
                        bool kb_ = jy_ is CqlInterval<CqlDateTime>;
                        if (kb_)
                        {
                            ju_ = jy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool kc_ = jy_ is CqlInterval<CqlQuantity>;
                            if (kc_)
                            {
                                ju_ = jy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ju_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> jv_ = QICoreCommon_4_0_000.Instance.toInterval(context, ju_);
                bool? jw_ = context.Operators.OverlapsBefore(jt_, jv_, "day");
                return (bool?)(/* CQL 'and' (260:17-261:44) */ ((CqlBoolean)jw_
                    && (CqlBoolean)(this.isVerified(context, ComorbidDiagnosis))));
            }

            bool? js_ = context.Operators.WhereAny<Condition>(jq_, jr_);
            return js_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
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

        bool? b_(Procedure CataractSurgeryPerformed) {
            CqlCode d_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
            CqlValueSet g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
            IEnumerable<Observation> i_ = context.Operators.Union<Observation>(f_, h_);

            bool? j_(Observation VisualAcuityExamPerformed) {
                DataType l_ = VisualAcuityExamPerformed?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                object p_;
                DataType ac_ = CataractSurgeryPerformed?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    p_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlQuantity;
                    if (af_)
                    {
                        p_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            p_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                p_ = ad_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                object s_;
                DataType ai_ = CataractSurgeryPerformed?.Performed;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    s_ = aj_ as CqlDateTime;
                }
                else
                {
                    bool al_ = aj_ is CqlQuantity;
                    if (al_)
                    {
                        s_ = aj_ as CqlQuantity;
                    }
                    else
                    {
                        bool am_ = aj_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            s_ = aj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool an_ = aj_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                s_ = aj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlQuantity v_ = context.Operators.Quantity(90m, "days");
                CqlDateTime w_ = context.Operators.Add(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(r_, w_, false, true);
                bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, "day");

                CqlBoolean z_() {
                    object ao_;
                    DataType ar_ = CataractSurgeryPerformed?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        ao_ = as_ as CqlDateTime;
                    }
                    else
                    {
                        bool au_ = as_ is CqlQuantity;
                        if (au_)
                        {
                            ao_ = as_ as CqlQuantity;
                        }
                        else
                        {
                            bool av_ = as_ is CqlInterval<CqlDateTime>;
                            if (av_)
                            {
                                ao_ = as_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aw_ = as_ is CqlInterval<CqlQuantity>;
                                if (aw_)
                                {
                                    ao_ = as_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ao_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                    CqlDateTime aq_ = context.Operators.End(ap_);
                    return !((bool?)(aq_ is null));
                }


                CqlBoolean aa_() {
                    Code<ObservationStatus> ax_ = VisualAcuityExamPerformed?.StatusElement;
                    ObservationStatus? ay_ = ax_?.Value;
                    string az_ = context.Operators.Convert<string>(ay_);
                    string[] ba_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
                    return bb_;
                }


                CqlBoolean ab_() {
                    DataType bc_ = VisualAcuityExamPerformed?.Value;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    CqlValueSet be_ = this.Visual_Acuity_20_40_or_Better(context);
                    bool? bf_ = context.Operators.ConceptInValueSet(bd_ as CqlConcept, be_);
                    return bf_;
                }

                return (bool?)(/* CQL 'and' (267:17-269:89) */ (/* CQL 'and' (267:17-268:83) */ (/* CQL 'and' (267:17-267:152) */ ((CqlBoolean)y_
                    && z_())
                    && aa_())
                    && ab_()));
            }

            bool? k_ = context.Operators.WhereAny<Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
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
