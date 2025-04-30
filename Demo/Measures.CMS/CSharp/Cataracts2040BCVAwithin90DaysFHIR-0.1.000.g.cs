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
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Best_corrected_visual_acuity__observable_entity_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime pzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzl_ = context.Operators.Interval(pzzzzzzzzzzzzj_, pzzzzzzzzzzzzk_, true, true);
        object pzzzzzzzzzzzzm_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", pzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzp_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? pzzzzzzzzzzzzr_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            DataType pzzzzzzzzzzzzu_ = CataractSurgery?.Performed;
            object pzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzt_, pzzzzzzzzzzzzw_, default);
            object pzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzz_);
            CqlDateTime qzzzzzzzzzzzzb_ = context.Operators.Start(qzzzzzzzzzzzza_);
            CqlDateTime qzzzzzzzzzzzzd_ = context.Operators.End(pzzzzzzzzzzzzt_);
            CqlQuantity qzzzzzzzzzzzze_ = context.Operators.Quantity(92m, "days");
            CqlDateTime qzzzzzzzzzzzzf_ = context.Operators.Subtract(qzzzzzzzzzzzzd_, qzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzb_, qzzzzzzzzzzzzf_, default);
            bool? qzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzx_, qzzzzzzzzzzzzg_);
            Code<EventStatus> qzzzzzzzzzzzzi_ = CataractSurgery?.StatusElement;
            EventStatus? qzzzzzzzzzzzzj_ = qzzzzzzzzzzzzi_?.Value;
            string qzzzzzzzzzzzzk_ = context.Operators.Convert<string>(qzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzl_ = context.Operators.Equal(qzzzzzzzzzzzzk_, "completed");
            bool? qzzzzzzzzzzzzm_ = context.Operators.And(qzzzzzzzzzzzzh_, qzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzq_, pzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context)
    {
        IEnumerable<Procedure> qzzzzzzzzzzzzn_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        bool? qzzzzzzzzzzzzo_(Procedure CataractSurgeryPerformed)
        {
            Patient qzzzzzzzzzzzzq_ = this.Patient(context);
            Date qzzzzzzzzzzzzr_ = qzzzzzzzzzzzzq_?.BirthDateElement;
            string qzzzzzzzzzzzzs_ = qzzzzzzzzzzzzr_?.Value;
            CqlDate qzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzzzzzu_);
            CqlDate qzzzzzzzzzzzzw_ = context.Operators.DateFrom(qzzzzzzzzzzzzv_);
            int? qzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzt_, qzzzzzzzzzzzzw_, "year");
            bool? qzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzx_, 18);

            return qzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzn_, qzzzzzzzzzzzzo_);

        return qzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> qzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> rzzzzzzzzzzzza_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzb_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet rzzzzzzzzzzzzd_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> rzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzf_ = this.Amblyopia(context);
            IEnumerable<Condition> rzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(rzzzzzzzzzzzze_, rzzzzzzzzzzzzg_);
            CqlValueSet rzzzzzzzzzzzzi_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> rzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzk_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> rzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzj_, rzzzzzzzzzzzzl_);
            IEnumerable<Condition> rzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzh_, rzzzzzzzzzzzzm_);
            CqlValueSet rzzzzzzzzzzzzo_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> rzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzq_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> rzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzp_, rzzzzzzzzzzzzr_);
            IEnumerable<Condition> rzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzn_, rzzzzzzzzzzzzs_);
            CqlValueSet rzzzzzzzzzzzzu_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> rzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzw_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> rzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzv_, rzzzzzzzzzzzzx_);
            IEnumerable<Condition> rzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzt_, rzzzzzzzzzzzzy_);
            CqlValueSet szzzzzzzzzzzza_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> szzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzc_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> szzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzze_ = context.Operators.Union<Condition>(szzzzzzzzzzzzb_, szzzzzzzzzzzzd_);
            IEnumerable<Condition> szzzzzzzzzzzzf_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzz_, szzzzzzzzzzzze_);
            CqlValueSet szzzzzzzzzzzzg_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> szzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzi_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> szzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzk_ = context.Operators.Union<Condition>(szzzzzzzzzzzzh_, szzzzzzzzzzzzj_);
            IEnumerable<Condition> szzzzzzzzzzzzl_ = context.Operators.Union<Condition>(szzzzzzzzzzzzf_, szzzzzzzzzzzzk_);
            CqlValueSet szzzzzzzzzzzzm_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> szzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzo_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> szzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzq_ = context.Operators.Union<Condition>(szzzzzzzzzzzzn_, szzzzzzzzzzzzp_);
            IEnumerable<Condition> szzzzzzzzzzzzr_ = context.Operators.Union<Condition>(szzzzzzzzzzzzl_, szzzzzzzzzzzzq_);
            CqlValueSet szzzzzzzzzzzzs_ = this.Corneal_Edema(context);
            IEnumerable<Condition> szzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzu_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> szzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzw_ = context.Operators.Union<Condition>(szzzzzzzzzzzzt_, szzzzzzzzzzzzv_);
            IEnumerable<Condition> szzzzzzzzzzzzx_ = context.Operators.Union<Condition>(szzzzzzzzzzzzr_, szzzzzzzzzzzzw_);
            CqlValueSet szzzzzzzzzzzzy_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> szzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzza_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> tzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(szzzzzzzzzzzzz_, tzzzzzzzzzzzzb_);
            IEnumerable<Condition> tzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(szzzzzzzzzzzzx_, tzzzzzzzzzzzzc_);
            CqlValueSet tzzzzzzzzzzzze_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> tzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzg_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> tzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzf_, tzzzzzzzzzzzzh_);
            IEnumerable<Condition> tzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzd_, tzzzzzzzzzzzzi_);
            CqlValueSet tzzzzzzzzzzzzk_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> tzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzm_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> tzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzl_, tzzzzzzzzzzzzn_);
            IEnumerable<Condition> tzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzj_, tzzzzzzzzzzzzo_);
            CqlValueSet tzzzzzzzzzzzzq_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> tzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzs_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> tzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzr_, tzzzzzzzzzzzzt_);
            IEnumerable<Condition> tzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzp_, tzzzzzzzzzzzzu_);
            CqlValueSet tzzzzzzzzzzzzw_ = this.Glaucoma(context);
            IEnumerable<Condition> tzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzy_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> tzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzza_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzx_, tzzzzzzzzzzzzz_);
            IEnumerable<Condition> uzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzv_, uzzzzzzzzzzzza_);
            CqlValueSet uzzzzzzzzzzzzc_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> uzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzze_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> uzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzd_, uzzzzzzzzzzzzf_);
            IEnumerable<Condition> uzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzb_, uzzzzzzzzzzzzg_);
            CqlValueSet uzzzzzzzzzzzzi_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> uzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzk_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> uzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzj_, uzzzzzzzzzzzzl_);
            IEnumerable<Condition> uzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzh_, uzzzzzzzzzzzzm_);
            CqlValueSet uzzzzzzzzzzzzo_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> uzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzq_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> uzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzr_);
            IEnumerable<Condition> uzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzn_, uzzzzzzzzzzzzs_);
            CqlValueSet uzzzzzzzzzzzzu_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> uzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzw_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> uzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzx_);
            IEnumerable<Condition> uzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzt_, uzzzzzzzzzzzzy_);
            CqlValueSet vzzzzzzzzzzzza_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> vzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzc_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> vzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzze_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzb_, vzzzzzzzzzzzzd_);
            IEnumerable<Condition> vzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzz_, vzzzzzzzzzzzze_);
            CqlValueSet vzzzzzzzzzzzzg_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzi_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzh_, vzzzzzzzzzzzzj_);
            IEnumerable<Condition> vzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzf_, vzzzzzzzzzzzzk_);
            CqlValueSet vzzzzzzzzzzzzm_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> vzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzo_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> vzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzn_, vzzzzzzzzzzzzp_);
            IEnumerable<Condition> vzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzl_, vzzzzzzzzzzzzq_);
            CqlValueSet vzzzzzzzzzzzzs_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzu_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> vzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzv_);
            IEnumerable<Condition> vzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzr_, vzzzzzzzzzzzzw_);
            CqlValueSet vzzzzzzzzzzzzy_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> vzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzza_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> wzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzz_, wzzzzzzzzzzzzb_);
            IEnumerable<Condition> wzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzx_, wzzzzzzzzzzzzc_);
            CqlValueSet wzzzzzzzzzzzze_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> wzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzg_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> wzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzf_, wzzzzzzzzzzzzh_);
            IEnumerable<Condition> wzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzd_, wzzzzzzzzzzzzi_);
            CqlValueSet wzzzzzzzzzzzzk_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> wzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzm_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> wzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzl_, wzzzzzzzzzzzzn_);
            IEnumerable<Condition> wzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzj_, wzzzzzzzzzzzzo_);
            CqlValueSet wzzzzzzzzzzzzq_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> wzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzs_ = this.Scleritis(context);
            IEnumerable<Condition> wzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzr_, wzzzzzzzzzzzzt_);
            IEnumerable<Condition> wzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzp_, wzzzzzzzzzzzzu_);
            CqlValueSet wzzzzzzzzzzzzw_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> wzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzy_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> wzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzza_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzx_, wzzzzzzzzzzzzz_);
            IEnumerable<Condition> xzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzv_, xzzzzzzzzzzzza_);
            CqlValueSet xzzzzzzzzzzzzc_ = this.Uveitis(context);
            IEnumerable<Condition> xzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzze_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> xzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzd_, xzzzzzzzzzzzzf_);
            IEnumerable<Condition> xzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzb_, xzzzzzzzzzzzzg_);
            CqlValueSet xzzzzzzzzzzzzi_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> xzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzh_, xzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzl_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType xzzzzzzzzzzzzq_ = CataractSurgeryPerformed?.Performed;
                object xzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzr_);
                bool? xzzzzzzzzzzzzt_ = context.Operators.OverlapsBefore(xzzzzzzzzzzzzp_, xzzzzzzzzzzzzs_, default);
                bool? xzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
                bool? xzzzzzzzzzzzzv_ = context.Operators.And(xzzzzzzzzzzzzt_, xzzzzzzzzzzzzu_);

                return xzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzk_, xzzzzzzzzzzzzl_);
            Procedure xzzzzzzzzzzzzn_(Condition ComorbidDiagnosis) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> xzzzzzzzzzzzzo_ = context.Operators.Select<Condition, Procedure>(xzzzzzzzzzzzzm_, xzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzc_ = context.Operators.SelectMany<Procedure, Procedure>(rzzzzzzzzzzzza_, rzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> xzzzzzzzzzzzzw_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzx_(Procedure CataractSurgeryPerformed)
        {
            CqlCode xzzzzzzzzzzzzz_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> yzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzz_);
            IEnumerable<Observation> yzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet yzzzzzzzzzzzzc_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> yzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> yzzzzzzzzzzzze_ = context.Operators.Union<Observation>(yzzzzzzzzzzzzb_, yzzzzzzzzzzzzd_);
            bool? yzzzzzzzzzzzzf_(Observation VisualAcuityExamPerformed)
            {
                DataType yzzzzzzzzzzzzj_ = VisualAcuityExamPerformed?.Effective;
                object yzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzk_);
                CqlDateTime yzzzzzzzzzzzzm_ = context.Operators.Start(yzzzzzzzzzzzzl_);
                DataType yzzzzzzzzzzzzn_ = CataractSurgeryPerformed?.Performed;
                object yzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzo_);
                CqlDateTime yzzzzzzzzzzzzq_ = context.Operators.End(yzzzzzzzzzzzzp_);
                object yzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzs_);
                CqlDateTime yzzzzzzzzzzzzu_ = context.Operators.End(yzzzzzzzzzzzzt_);
                CqlQuantity yzzzzzzzzzzzzv_ = context.Operators.Quantity(90m, "days");
                CqlDateTime yzzzzzzzzzzzzw_ = context.Operators.Add(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzx_ = context.Operators.Interval(yzzzzzzzzzzzzq_, yzzzzzzzzzzzzw_, false, true);
                bool? yzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzm_, yzzzzzzzzzzzzx_, "day");
                object zzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzza_);
                CqlDateTime zzzzzzzzzzzzzc_ = context.Operators.End(zzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzc_ is null));
                bool? zzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzy_, zzzzzzzzzzzzzd_);
                Code<ObservationStatus> zzzzzzzzzzzzzf_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzg_ = zzzzzzzzzzzzzf_?.Value;
                Code<ObservationStatus> zzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzg_);
                string zzzzzzzzzzzzzi_ = context.Operators.Convert<string>(zzzzzzzzzzzzzh_);
                string[] zzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                    "preliminary",
                ];
                bool? zzzzzzzzzzzzzk_ = context.Operators.In<string>(zzzzzzzzzzzzzi_, zzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzze_, zzzzzzzzzzzzzk_);
                DataType zzzzzzzzzzzzzm_ = VisualAcuityExamPerformed?.Value;
                object zzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzm_);
                CqlValueSet zzzzzzzzzzzzzo_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? zzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzn_ as CqlConcept, zzzzzzzzzzzzzo_);
                bool? zzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzp_);

                return zzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(yzzzzzzzzzzzze_, yzzzzzzzzzzzzf_);
            Procedure yzzzzzzzzzzzzh_(Observation VisualAcuityExamPerformed) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> yzzzzzzzzzzzzi_ = context.Operators.Select<Observation, Procedure>(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzh_);

            return yzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzy_ = context.Operators.SelectMany<Procedure, Procedure>(xzzzzzzzzzzzzw_, xzzzzzzzzzzzzx_);

        return xzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
