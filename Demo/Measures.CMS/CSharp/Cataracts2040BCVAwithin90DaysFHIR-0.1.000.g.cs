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

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Best_corrected_visual_acuity__observable_entity_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzn_ = context.Operators.Interval(wzzzzl_, wzzzzm_, true, true);
        object wzzzzo_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", wzzzzn_);

        return (CqlInterval<CqlDateTime>)wzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzq_ = context.Operators.SingletonFrom<Patient>(wzzzzp_);

        return wzzzzq_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzr_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> wzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? wzzzzt_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> wzzzzv_ = this.Measurement_Period(context);
            DataType wzzzzw_ = CataractSurgery?.Performed;
            object wzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzw_);
            CqlInterval<CqlDateTime> wzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzx_);
            bool? wzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzv_, wzzzzy_, default);
            object xzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzw_);
            CqlInterval<CqlDateTime> xzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzb_);
            CqlDateTime xzzzzd_ = context.Operators.Start(xzzzzc_);
            CqlDateTime xzzzzf_ = context.Operators.End(wzzzzv_);
            CqlQuantity xzzzzg_ = context.Operators.Quantity(92m, "days");
            CqlDateTime xzzzzh_ = context.Operators.Subtract(xzzzzf_, xzzzzg_);
            bool? xzzzzi_ = context.Operators.SameOrBefore(xzzzzd_, xzzzzh_, default);
            bool? xzzzzj_ = context.Operators.And(wzzzzz_, xzzzzi_);
            Code<EventStatus> xzzzzk_ = CataractSurgery?.StatusElement;
            EventStatus? xzzzzl_ = xzzzzk_?.Value;
            string xzzzzm_ = context.Operators.Convert<string>(xzzzzl_);
            bool? xzzzzn_ = context.Operators.Equal(xzzzzm_, "completed");
            bool? xzzzzo_ = context.Operators.And(xzzzzj_, xzzzzn_);

            return xzzzzo_;
        };
        IEnumerable<Procedure> wzzzzu_ = context.Operators.Where<Procedure>(wzzzzs_, wzzzzt_);

        return wzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context)
    {
        IEnumerable<Procedure> xzzzzp_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        bool? xzzzzq_(Procedure CataractSurgeryPerformed)
        {
            Patient xzzzzs_ = this.Patient(context);
            Date xzzzzt_ = xzzzzs_?.BirthDateElement;
            string xzzzzu_ = xzzzzt_?.Value;
            CqlDate xzzzzv_ = context.Operators.ConvertStringToDate(xzzzzu_);
            CqlInterval<CqlDateTime> xzzzzw_ = this.Measurement_Period(context);
            CqlDateTime xzzzzx_ = context.Operators.Start(xzzzzw_);
            CqlDate xzzzzy_ = context.Operators.DateFrom(xzzzzx_);
            int? xzzzzz_ = context.Operators.CalculateAgeAt(xzzzzv_, xzzzzy_, "year");
            bool? yzzzza_ = context.Operators.GreaterOrEqual(xzzzzz_, 18);

            return yzzzza_;
        };
        IEnumerable<Procedure> xzzzzr_ = context.Operators.Where<Procedure>(xzzzzp_, xzzzzq_);

        return xzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> yzzzzb_ = this.Initial_Population(context);

        return yzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> yzzzzc_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> yzzzzd_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet yzzzzf_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> yzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzh_ = this.Amblyopia(context);
            IEnumerable<Condition> yzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzj_ = context.Operators.Union<Condition>(yzzzzg_, yzzzzi_);
            CqlValueSet yzzzzk_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> yzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzm_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> yzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzo_ = context.Operators.Union<Condition>(yzzzzl_, yzzzzn_);
            IEnumerable<Condition> yzzzzp_ = context.Operators.Union<Condition>(yzzzzj_, yzzzzo_);
            CqlValueSet yzzzzq_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> yzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzs_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> yzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzu_ = context.Operators.Union<Condition>(yzzzzr_, yzzzzt_);
            IEnumerable<Condition> yzzzzv_ = context.Operators.Union<Condition>(yzzzzp_, yzzzzu_);
            CqlValueSet yzzzzw_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> yzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzy_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> yzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzza_ = context.Operators.Union<Condition>(yzzzzx_, yzzzzz_);
            IEnumerable<Condition> zzzzzb_ = context.Operators.Union<Condition>(yzzzzv_, zzzzza_);
            CqlValueSet zzzzzc_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> zzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzze_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> zzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzg_ = context.Operators.Union<Condition>(zzzzzd_, zzzzzf_);
            IEnumerable<Condition> zzzzzh_ = context.Operators.Union<Condition>(zzzzzb_, zzzzzg_);
            CqlValueSet zzzzzi_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> zzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzk_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> zzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzm_ = context.Operators.Union<Condition>(zzzzzj_, zzzzzl_);
            IEnumerable<Condition> zzzzzn_ = context.Operators.Union<Condition>(zzzzzh_, zzzzzm_);
            CqlValueSet zzzzzo_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> zzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzq_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> zzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzs_ = context.Operators.Union<Condition>(zzzzzp_, zzzzzr_);
            IEnumerable<Condition> zzzzzt_ = context.Operators.Union<Condition>(zzzzzn_, zzzzzs_);
            CqlValueSet zzzzzu_ = this.Corneal_Edema(context);
            IEnumerable<Condition> zzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzw_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> zzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzy_ = context.Operators.Union<Condition>(zzzzzv_, zzzzzx_);
            IEnumerable<Condition> zzzzzz_ = context.Operators.Union<Condition>(zzzzzt_, zzzzzy_);
            CqlValueSet azzzzza_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> azzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzc_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> azzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzze_ = context.Operators.Union<Condition>(azzzzzb_, azzzzzd_);
            IEnumerable<Condition> azzzzzf_ = context.Operators.Union<Condition>(zzzzzz_, azzzzze_);
            CqlValueSet azzzzzg_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> azzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzi_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> azzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzk_ = context.Operators.Union<Condition>(azzzzzh_, azzzzzj_);
            IEnumerable<Condition> azzzzzl_ = context.Operators.Union<Condition>(azzzzzf_, azzzzzk_);
            CqlValueSet azzzzzm_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> azzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzo_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> azzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzq_ = context.Operators.Union<Condition>(azzzzzn_, azzzzzp_);
            IEnumerable<Condition> azzzzzr_ = context.Operators.Union<Condition>(azzzzzl_, azzzzzq_);
            CqlValueSet azzzzzs_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> azzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzu_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> azzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzw_ = context.Operators.Union<Condition>(azzzzzt_, azzzzzv_);
            IEnumerable<Condition> azzzzzx_ = context.Operators.Union<Condition>(azzzzzr_, azzzzzw_);
            CqlValueSet azzzzzy_ = this.Glaucoma(context);
            IEnumerable<Condition> azzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzza_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> bzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzc_ = context.Operators.Union<Condition>(azzzzzz_, bzzzzzb_);
            IEnumerable<Condition> bzzzzzd_ = context.Operators.Union<Condition>(azzzzzx_, bzzzzzc_);
            CqlValueSet bzzzzze_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> bzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzg_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> bzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzi_ = context.Operators.Union<Condition>(bzzzzzf_, bzzzzzh_);
            IEnumerable<Condition> bzzzzzj_ = context.Operators.Union<Condition>(bzzzzzd_, bzzzzzi_);
            CqlValueSet bzzzzzk_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> bzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzm_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> bzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzo_ = context.Operators.Union<Condition>(bzzzzzl_, bzzzzzn_);
            IEnumerable<Condition> bzzzzzp_ = context.Operators.Union<Condition>(bzzzzzj_, bzzzzzo_);
            CqlValueSet bzzzzzq_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> bzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzs_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> bzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzu_ = context.Operators.Union<Condition>(bzzzzzr_, bzzzzzt_);
            IEnumerable<Condition> bzzzzzv_ = context.Operators.Union<Condition>(bzzzzzp_, bzzzzzu_);
            CqlValueSet bzzzzzw_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> bzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzy_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> bzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzza_ = context.Operators.Union<Condition>(bzzzzzx_, bzzzzzz_);
            IEnumerable<Condition> czzzzzb_ = context.Operators.Union<Condition>(bzzzzzv_, czzzzza_);
            CqlValueSet czzzzzc_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> czzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzze_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> czzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzg_ = context.Operators.Union<Condition>(czzzzzd_, czzzzzf_);
            IEnumerable<Condition> czzzzzh_ = context.Operators.Union<Condition>(czzzzzb_, czzzzzg_);
            CqlValueSet czzzzzi_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> czzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzk_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> czzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzm_ = context.Operators.Union<Condition>(czzzzzj_, czzzzzl_);
            IEnumerable<Condition> czzzzzn_ = context.Operators.Union<Condition>(czzzzzh_, czzzzzm_);
            CqlValueSet czzzzzo_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> czzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzq_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> czzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzs_ = context.Operators.Union<Condition>(czzzzzp_, czzzzzr_);
            IEnumerable<Condition> czzzzzt_ = context.Operators.Union<Condition>(czzzzzn_, czzzzzs_);
            CqlValueSet czzzzzu_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> czzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzw_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> czzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzy_ = context.Operators.Union<Condition>(czzzzzv_, czzzzzx_);
            IEnumerable<Condition> czzzzzz_ = context.Operators.Union<Condition>(czzzzzt_, czzzzzy_);
            CqlValueSet dzzzzza_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> dzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzc_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> dzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzze_ = context.Operators.Union<Condition>(dzzzzzb_, dzzzzzd_);
            IEnumerable<Condition> dzzzzzf_ = context.Operators.Union<Condition>(czzzzzz_, dzzzzze_);
            CqlValueSet dzzzzzg_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> dzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzi_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> dzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzk_ = context.Operators.Union<Condition>(dzzzzzh_, dzzzzzj_);
            IEnumerable<Condition> dzzzzzl_ = context.Operators.Union<Condition>(dzzzzzf_, dzzzzzk_);
            CqlValueSet dzzzzzm_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> dzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzo_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> dzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzq_ = context.Operators.Union<Condition>(dzzzzzn_, dzzzzzp_);
            IEnumerable<Condition> dzzzzzr_ = context.Operators.Union<Condition>(dzzzzzl_, dzzzzzq_);
            CqlValueSet dzzzzzs_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> dzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzu_ = this.Scleritis(context);
            IEnumerable<Condition> dzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzw_ = context.Operators.Union<Condition>(dzzzzzt_, dzzzzzv_);
            IEnumerable<Condition> dzzzzzx_ = context.Operators.Union<Condition>(dzzzzzr_, dzzzzzw_);
            CqlValueSet dzzzzzy_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> dzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzza_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> ezzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzc_ = context.Operators.Union<Condition>(dzzzzzz_, ezzzzzb_);
            IEnumerable<Condition> ezzzzzd_ = context.Operators.Union<Condition>(dzzzzzx_, ezzzzzc_);
            CqlValueSet ezzzzze_ = this.Uveitis(context);
            IEnumerable<Condition> ezzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzg_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> ezzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzi_ = context.Operators.Union<Condition>(ezzzzzf_, ezzzzzh_);
            IEnumerable<Condition> ezzzzzj_ = context.Operators.Union<Condition>(ezzzzzd_, ezzzzzi_);
            CqlValueSet ezzzzzk_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> ezzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzm_ = context.Operators.Union<Condition>(ezzzzzj_, ezzzzzl_);
            bool? ezzzzzn_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> ezzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType ezzzzzs_ = CataractSurgeryPerformed?.Performed;
                object ezzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzs_);
                CqlInterval<CqlDateTime> ezzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzt_);
                bool? ezzzzzv_ = context.Operators.OverlapsBefore(ezzzzzr_, ezzzzzu_, default);
                bool? ezzzzzw_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
                bool? ezzzzzx_ = context.Operators.And(ezzzzzv_, ezzzzzw_);

                return ezzzzzx_;
            };
            IEnumerable<Condition> ezzzzzo_ = context.Operators.Where<Condition>(ezzzzzm_, ezzzzzn_);
            Procedure ezzzzzp_(Condition ComorbidDiagnosis) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> ezzzzzq_ = context.Operators.Select<Condition, Procedure>(ezzzzzo_, ezzzzzp_);

            return ezzzzzq_;
        };
        IEnumerable<Procedure> yzzzze_ = context.Operators.SelectMany<Procedure, Procedure>(yzzzzc_, yzzzzd_);

        return yzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> ezzzzzy_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> ezzzzzz_(Procedure CataractSurgeryPerformed)
        {
            CqlCode fzzzzzb_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> fzzzzzc_ = context.Operators.ToList<CqlCode>(fzzzzzb_);
            IEnumerable<Observation> fzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet fzzzzze_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> fzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> fzzzzzg_ = context.Operators.Union<Observation>(fzzzzzd_, fzzzzzf_);
            bool? fzzzzzh_(Observation VisualAcuityExamPerformed)
            {
                DataType fzzzzzl_ = VisualAcuityExamPerformed?.Effective;
                object fzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzm_);
                CqlDateTime fzzzzzo_ = context.Operators.Start(fzzzzzn_);
                DataType fzzzzzp_ = CataractSurgeryPerformed?.Performed;
                object fzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzp_);
                CqlInterval<CqlDateTime> fzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzq_);
                CqlDateTime fzzzzzs_ = context.Operators.End(fzzzzzr_);
                object fzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzp_);
                CqlInterval<CqlDateTime> fzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzu_);
                CqlDateTime fzzzzzw_ = context.Operators.End(fzzzzzv_);
                CqlQuantity fzzzzzx_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fzzzzzy_ = context.Operators.Add(fzzzzzw_, fzzzzzx_);
                CqlInterval<CqlDateTime> fzzzzzz_ = context.Operators.Interval(fzzzzzs_, fzzzzzy_, false, true);
                bool? gzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzo_, fzzzzzz_, "day");
                object gzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzp_);
                CqlInterval<CqlDateTime> gzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzc_);
                CqlDateTime gzzzzze_ = context.Operators.End(gzzzzzd_);
                bool? gzzzzzf_ = context.Operators.Not((bool?)(gzzzzze_ is null));
                bool? gzzzzzg_ = context.Operators.And(gzzzzza_, gzzzzzf_);
                Code<ObservationStatus> gzzzzzh_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? gzzzzzi_ = gzzzzzh_?.Value;
                Code<ObservationStatus> gzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzi_);
                string gzzzzzk_ = context.Operators.Convert<string>(gzzzzzj_);
                string[] gzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                    "preliminary",
                ];
                bool? gzzzzzm_ = context.Operators.In<string>(gzzzzzk_, gzzzzzl_ as IEnumerable<string>);
                bool? gzzzzzn_ = context.Operators.And(gzzzzzg_, gzzzzzm_);
                DataType gzzzzzo_ = VisualAcuityExamPerformed?.Value;
                object gzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzo_);
                CqlValueSet gzzzzzq_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? gzzzzzr_ = context.Operators.ConceptInValueSet(gzzzzzp_ as CqlConcept, gzzzzzq_);
                bool? gzzzzzs_ = context.Operators.And(gzzzzzn_, gzzzzzr_);

                return gzzzzzs_;
            };
            IEnumerable<Observation> fzzzzzi_ = context.Operators.Where<Observation>(fzzzzzg_, fzzzzzh_);
            Procedure fzzzzzj_(Observation VisualAcuityExamPerformed) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> fzzzzzk_ = context.Operators.Select<Observation, Procedure>(fzzzzzi_, fzzzzzj_);

            return fzzzzzk_;
        };
        IEnumerable<Procedure> fzzzzza_ = context.Operators.SelectMany<Procedure, Procedure>(ezzzzzy_, ezzzzzz_);

        return fzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzw_;
    }


    #endregion Expressions

}
