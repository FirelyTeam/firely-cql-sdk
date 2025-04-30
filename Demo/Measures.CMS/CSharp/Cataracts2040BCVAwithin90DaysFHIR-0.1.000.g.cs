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
        CqlDateTime ozzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzj_, true, true);
        object ozzzzzzzzzzzzzzzzl_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", ozzzzzzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzo_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? ozzzzzzzzzzzzzzzzq_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            DataType ozzzzzzzzzzzzzzzzt_ = CataractSurgery?.Performed;
            object ozzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzu_);
            bool? ozzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzv_, default);
            object ozzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzy_);
            CqlDateTime pzzzzzzzzzzzzzzzza_ = context.Operators.Start(ozzzzzzzzzzzzzzzzz_);
            CqlDateTime pzzzzzzzzzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzzzzzzzzs_);
            CqlQuantity pzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(92m, "days");
            CqlDateTime pzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzd_);
            bool? pzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzze_, default);
            bool? pzzzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzf_);
            Code<EventStatus> pzzzzzzzzzzzzzzzzh_ = CataractSurgery?.StatusElement;
            EventStatus? pzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzh_?.Value;
            string pzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzi_);
            bool? pzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzj_, "completed");
            bool? pzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzq_);

        return ozzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context)
    {
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzm_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzn_(Procedure CataractSurgeryPerformed)
        {
            Patient pzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string pzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzq_?.Value;
            CqlDate pzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzzzzzzzzt_);
            CqlDate pzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzu_);
            int? pzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzv_, "year");
            bool? pzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzw_, 18);

            return pzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzz_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzza_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzc_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzze_ = this.Amblyopia(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzf_);
            CqlValueSet qzzzzzzzzzzzzzzzzh_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzzj_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzk_);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzl_);
            CqlValueSet qzzzzzzzzzzzzzzzzn_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzzp_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzq_);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzr_);
            CqlValueSet qzzzzzzzzzzzzzzzzt_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzzv_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzw_);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzx_);
            CqlValueSet qzzzzzzzzzzzzzzzzz_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzzzzzb_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzc_);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzd_);
            CqlValueSet rzzzzzzzzzzzzzzzzf_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzzzzzh_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzj_);
            CqlValueSet rzzzzzzzzzzzzzzzzl_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzzzzzn_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzo_);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzp_);
            CqlValueSet rzzzzzzzzzzzzzzzzr_ = this.Corneal_Edema(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzzzzzt_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzu_);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzv_);
            CqlValueSet rzzzzzzzzzzzzzzzzx_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet rzzzzzzzzzzzzzzzzz_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzza_);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzb_);
            CqlValueSet szzzzzzzzzzzzzzzzd_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzzzzzf_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzg_);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzh_);
            CqlValueSet szzzzzzzzzzzzzzzzj_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzzzzzl_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzm_);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzn_);
            CqlValueSet szzzzzzzzzzzzzzzzp_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzzzzzr_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzs_);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzt_);
            CqlValueSet szzzzzzzzzzzzzzzzv_ = this.Glaucoma(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzzzzzx_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzy_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzz_);
            CqlValueSet tzzzzzzzzzzzzzzzzb_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzzzzzd_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzze_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzf_);
            CqlValueSet tzzzzzzzzzzzzzzzzh_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzzzzzj_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzk_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzl_);
            CqlValueSet tzzzzzzzzzzzzzzzzn_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzzzzzp_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzq_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzr_);
            CqlValueSet tzzzzzzzzzzzzzzzzt_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet tzzzzzzzzzzzzzzzzv_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzw_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzx_);
            CqlValueSet tzzzzzzzzzzzzzzzzz_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzzzzzb_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzc_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzd_);
            CqlValueSet uzzzzzzzzzzzzzzzzf_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzzzzzh_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzj_);
            CqlValueSet uzzzzzzzzzzzzzzzzl_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzzzzzn_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzo_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzp_);
            CqlValueSet uzzzzzzzzzzzzzzzzr_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzzzzzt_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzu_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzv_);
            CqlValueSet uzzzzzzzzzzzzzzzzx_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet uzzzzzzzzzzzzzzzzz_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzza_);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzb_);
            CqlValueSet vzzzzzzzzzzzzzzzzd_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzzzzzf_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzg_);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzh_);
            CqlValueSet vzzzzzzzzzzzzzzzzj_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzzzzzl_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzm_);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzn_);
            CqlValueSet vzzzzzzzzzzzzzzzzp_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzzzzzr_ = this.Scleritis(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzs_);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzt_);
            CqlValueSet vzzzzzzzzzzzzzzzzv_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet vzzzzzzzzzzzzzzzzx_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzy_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzz_);
            CqlValueSet wzzzzzzzzzzzzzzzzb_ = this.Uveitis(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzd_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzze_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzf_);
            CqlValueSet wzzzzzzzzzzzzzzzzh_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzzzzzk_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType wzzzzzzzzzzzzzzzzp_ = CataractSurgeryPerformed?.Performed;
                object wzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzzs_ = context.Operators.OverlapsBefore(wzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzr_, default);
                bool? wzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
                bool? wzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzk_);
            Procedure wzzzzzzzzzzzzzzzzm_(Condition ComorbidDiagnosis) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Condition, Procedure>(wzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Procedure, Procedure>(pzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzv_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzw_(Procedure CataractSurgeryPerformed)
        {
            CqlCode wzzzzzzzzzzzzzzzzy_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzy_);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet xzzzzzzzzzzzzzzzzb_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Observation>(xzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzc_);
            bool? xzzzzzzzzzzzzzzzze_(Observation VisualAcuityExamPerformed)
            {
                DataType xzzzzzzzzzzzzzzzzi_ = VisualAcuityExamPerformed?.Effective;
                object xzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzj_);
                CqlDateTime xzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzk_);
                DataType xzzzzzzzzzzzzzzzzm_ = CataractSurgeryPerformed?.Performed;
                object xzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzn_);
                CqlDateTime xzzzzzzzzzzzzzzzzp_ = context.Operators.End(xzzzzzzzzzzzzzzzzo_);
                object xzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzr_);
                CqlDateTime xzzzzzzzzzzzzzzzzt_ = context.Operators.End(xzzzzzzzzzzzzzzzzs_);
                CqlQuantity xzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(90m, "days");
                CqlDateTime xzzzzzzzzzzzzzzzzv_ = context.Operators.Add(xzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzv_, false, true);
                bool? xzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzw_, "day");
                object xzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzz_);
                CqlDateTime yzzzzzzzzzzzzzzzzb_ = context.Operators.End(yzzzzzzzzzzzzzzzza_);
                bool? yzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzb_ is null));
                bool? yzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzc_);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzze_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzze_?.Value;
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzf_);
                string yzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzg_);
                string[] yzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                    "preliminary",
                ];
                bool? yzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzj_);
                DataType yzzzzzzzzzzzzzzzzl_ = VisualAcuityExamPerformed?.Value;
                object yzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzl_);
                CqlValueSet yzzzzzzzzzzzzzzzzn_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? yzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzm_ as CqlConcept, yzzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzo_);

                return yzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzze_);
            Procedure xzzzzzzzzzzzzzzzzg_(Observation VisualAcuityExamPerformed) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, Procedure>(xzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzg_);

            return xzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Procedure, Procedure>(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
