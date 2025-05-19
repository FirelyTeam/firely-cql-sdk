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
    private static readonly CqlCode _Best_corrected_visual_acuity__observable_entity_ = new CqlCode("419775003", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Best_corrected_visual_acuity__observable_entity_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            DataType f_ = CataractSurgery?.Performed;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, default);
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_);
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


    [CqlExpressionDefinition("Initial Population")]
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


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet d_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet f_ = this.Amblyopia(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet k_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
            IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
            CqlValueSet o_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet q_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
            IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
            CqlValueSet u_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet w_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> y_ = context.Operators.Union<Condition>(v_, x_);
            IEnumerable<Condition> z_ = context.Operators.Union<Condition>(t_, y_);
            CqlValueSet aa_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> ab_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ac_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> ad_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(ab_, ad_);
            IEnumerable<Condition> af_ = context.Operators.Union<Condition>(z_, ae_);
            CqlValueSet ag_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ai_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ak_ = context.Operators.Union<Condition>(ah_, aj_);
            IEnumerable<Condition> al_ = context.Operators.Union<Condition>(af_, ak_);
            CqlValueSet am_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ao_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> ap_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ao_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> aq_ = context.Operators.Union<Condition>(an_, ap_);
            IEnumerable<Condition> ar_ = context.Operators.Union<Condition>(al_, aq_);
            CqlValueSet as_ = this.Corneal_Edema(context);
            IEnumerable<Condition> at_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet au_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> av_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> aw_ = context.Operators.Union<Condition>(at_, av_);
            IEnumerable<Condition> ax_ = context.Operators.Union<Condition>(ar_, aw_);
            CqlValueSet ay_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> az_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ba_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> bb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bc_ = context.Operators.Union<Condition>(az_, bb_);
            IEnumerable<Condition> bd_ = context.Operators.Union<Condition>(ax_, bc_);
            CqlValueSet be_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bg_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> bh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bi_ = context.Operators.Union<Condition>(bf_, bh_);
            IEnumerable<Condition> bj_ = context.Operators.Union<Condition>(bd_, bi_);
            CqlValueSet bk_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> bl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bm_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> bn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bo_ = context.Operators.Union<Condition>(bl_, bn_);
            IEnumerable<Condition> bp_ = context.Operators.Union<Condition>(bj_, bo_);
            CqlValueSet bq_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> br_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bs_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> bt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bu_ = context.Operators.Union<Condition>(br_, bt_);
            IEnumerable<Condition> bv_ = context.Operators.Union<Condition>(bp_, bu_);
            CqlValueSet bw_ = this.Glaucoma(context);
            IEnumerable<Condition> bx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet by_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> bz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ca_ = context.Operators.Union<Condition>(bx_, bz_);
            IEnumerable<Condition> cb_ = context.Operators.Union<Condition>(bv_, ca_);
            CqlValueSet cc_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> cd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ce_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> cf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ce_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> cg_ = context.Operators.Union<Condition>(cd_, cf_);
            IEnumerable<Condition> ch_ = context.Operators.Union<Condition>(cb_, cg_);
            CqlValueSet ci_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> cj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ci_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ck_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> cl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ck_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> cm_ = context.Operators.Union<Condition>(cj_, cl_);
            IEnumerable<Condition> cn_ = context.Operators.Union<Condition>(ch_, cm_);
            CqlValueSet co_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> cp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet cq_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> cr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> cs_ = context.Operators.Union<Condition>(cp_, cr_);
            IEnumerable<Condition> ct_ = context.Operators.Union<Condition>(cn_, cs_);
            CqlValueSet cu_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> cv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet cw_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> cx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> cy_ = context.Operators.Union<Condition>(cv_, cx_);
            IEnumerable<Condition> cz_ = context.Operators.Union<Condition>(ct_, cy_);
            CqlValueSet da_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> db_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dc_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> dd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> de_ = context.Operators.Union<Condition>(db_, dd_);
            IEnumerable<Condition> df_ = context.Operators.Union<Condition>(cz_, de_);
            CqlValueSet dg_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> dh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet di_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> dj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dk_ = context.Operators.Union<Condition>(dh_, dj_);
            IEnumerable<Condition> dl_ = context.Operators.Union<Condition>(df_, dk_);
            CqlValueSet dm_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> dn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet do_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> dp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, do_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dq_ = context.Operators.Union<Condition>(dn_, dp_);
            IEnumerable<Condition> dr_ = context.Operators.Union<Condition>(dl_, dq_);
            CqlValueSet ds_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> dt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet du_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> dv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, du_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dw_ = context.Operators.Union<Condition>(dt_, dv_);
            IEnumerable<Condition> dx_ = context.Operators.Union<Condition>(dr_, dw_);
            CqlValueSet dy_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> dz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ea_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> eb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ea_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ec_ = context.Operators.Union<Condition>(dz_, eb_);
            IEnumerable<Condition> ed_ = context.Operators.Union<Condition>(dx_, ec_);
            CqlValueSet ee_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> ef_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ee_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet eg_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> eh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ei_ = context.Operators.Union<Condition>(ef_, eh_);
            IEnumerable<Condition> ej_ = context.Operators.Union<Condition>(ed_, ei_);
            CqlValueSet ek_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> el_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ek_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet em_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> en_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> eo_ = context.Operators.Union<Condition>(el_, en_);
            IEnumerable<Condition> ep_ = context.Operators.Union<Condition>(ej_, eo_);
            CqlValueSet eq_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> er_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet es_ = this.Scleritis(context);
            IEnumerable<Condition> et_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, es_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> eu_ = context.Operators.Union<Condition>(er_, et_);
            IEnumerable<Condition> ev_ = context.Operators.Union<Condition>(ep_, eu_);
            CqlValueSet ew_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> ex_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ew_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ey_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> ez_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ey_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fa_ = context.Operators.Union<Condition>(ex_, ez_);
            IEnumerable<Condition> fb_ = context.Operators.Union<Condition>(ev_, fa_);
            CqlValueSet fc_ = this.Uveitis(context);
            IEnumerable<Condition> fd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fe_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> ff_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fe_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fg_ = context.Operators.Union<Condition>(fd_, ff_);
            IEnumerable<Condition> fh_ = context.Operators.Union<Condition>(fb_, fg_);
            CqlValueSet fi_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> fj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fk_ = context.Operators.Union<Condition>(fh_, fj_);
            bool? fl_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> fp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType fq_ = CataractSurgeryPerformed?.Performed;
                object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                CqlInterval<CqlDateTime> fs_ = QICoreCommon_2_1_000.Instance.toInterval(context, fr_);
                bool? ft_ = context.Operators.OverlapsBefore(fp_, fs_, default);
                bool? fu_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
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


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> b_(Procedure CataractSurgeryPerformed)
        {
            CqlCode d_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet g_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> i_ = context.Operators.Union<Observation>(f_, h_);
            bool? j_(Observation VisualAcuityExamPerformed)
            {
                DataType n_ = VisualAcuityExamPerformed?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                DataType r_ = CataractSurgeryPerformed?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_2_1_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(90m, "days");
                CqlDateTime aa_ = context.Operators.Add(y_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(u_, aa_, false, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(q_, ab_, "day");
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_);
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
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
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


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Expressions

}
