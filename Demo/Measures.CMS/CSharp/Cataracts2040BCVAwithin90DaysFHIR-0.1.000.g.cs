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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("Cataracts2040BCVAwithin90DaysFHIR", "0.1.000")]
public partial class Cataracts2040BCVAwithin90DaysFHIR_0_1_000 : ILibrary, ISingleton<Cataracts2040BCVAwithin90DaysFHIR_0_1_000>
{
    private Cataracts2040BCVAwithin90DaysFHIR_0_1_000() {}

    public static Cataracts2040BCVAwithin90DaysFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Cataracts2040BCVAwithin90DaysFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Best corrected visual acuity (observable entity)", codeId: "419775003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Best_corrected_visual_acuity__observable_entity_(CqlContext _) => _Best_corrected_visual_acuity__observable_entity_;
    private static readonly CqlCode _Best_corrected_visual_acuity__observable_entity_ = new CqlCode("419775003", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CataractSurgery?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(92m, "days");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Code<EventStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CataractSurgery?.StatusElement;
            EventStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "completed");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context)
    {
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure CataractSurgeryPerformed)
        {
            Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 18);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Amblyopia(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Corneal_Edema(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Glaucoma(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Scleritis(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Uveitis(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CataractSurgeryPerformed?.Performed;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.OverlapsBefore(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Procedure czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition ComorbidDiagnosis) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Condition, Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Procedure, Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure CataractSurgeryPerformed)
        {
            CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation VisualAcuityExamPerformed)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = VisualAcuityExamPerformed?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CataractSurgeryPerformed?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, false, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                    "preliminary",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = VisualAcuityExamPerformed?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlConcept, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Procedure czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation VisualAcuityExamPerformed) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation, Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Procedure, Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
