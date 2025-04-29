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

    #region ValueSet: Acute and Subacute Iridocyclitis
    [CqlValueSetDefinition(
        definitionName: "Acute and Subacute Iridocyclitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241",
        valueSetVersion: null)]
    public CqlValueSet Acute_and_Subacute_Iridocyclitis(CqlContext context) => _Acute_and_Subacute_Iridocyclitis;

    private static readonly CqlValueSet _Acute_and_Subacute_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241", null);
    #endregion

    #region ValueSet: Amblyopia
    [CqlValueSetDefinition(
        definitionName: "Amblyopia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448",
        valueSetVersion: null)]
    public CqlValueSet Amblyopia(CqlContext context) => _Amblyopia;

    private static readonly CqlValueSet _Amblyopia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448", null);
    #endregion

    #region ValueSet: Best Corrected Visual Acuity Exam Using Snellen Chart
    [CqlValueSetDefinition(
        definitionName: "Best Corrected Visual Acuity Exam Using Snellen Chart",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560",
        valueSetVersion: null)]
    public CqlValueSet Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(CqlContext context) => _Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart;

    private static readonly CqlValueSet _Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560", null);
    #endregion

    #region ValueSet: Burn Confined to Eye and Adnexa
    [CqlValueSetDefinition(
        definitionName: "Burn Confined to Eye and Adnexa",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409",
        valueSetVersion: null)]
    public CqlValueSet Burn_Confined_to_Eye_and_Adnexa(CqlContext context) => _Burn_Confined_to_Eye_and_Adnexa;

    private static readonly CqlValueSet _Burn_Confined_to_Eye_and_Adnexa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409", null);
    #endregion

    #region ValueSet: Cataract Congenital
    [CqlValueSetDefinition(
        definitionName: "Cataract Congenital",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412",
        valueSetVersion: null)]
    public CqlValueSet Cataract_Congenital(CqlContext context) => _Cataract_Congenital;

    private static readonly CqlValueSet _Cataract_Congenital = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412", null);
    #endregion

    #region ValueSet: Cataract Mature or Hypermature
    [CqlValueSetDefinition(
        definitionName: "Cataract Mature or Hypermature",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413",
        valueSetVersion: null)]
    public CqlValueSet Cataract_Mature_or_Hypermature(CqlContext context) => _Cataract_Mature_or_Hypermature;

    private static readonly CqlValueSet _Cataract_Mature_or_Hypermature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413", null);
    #endregion

    #region ValueSet: Cataract Posterior Polar
    [CqlValueSetDefinition(
        definitionName: "Cataract Posterior Polar",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414",
        valueSetVersion: null)]
    public CqlValueSet Cataract_Posterior_Polar(CqlContext context) => _Cataract_Posterior_Polar;

    private static readonly CqlValueSet _Cataract_Posterior_Polar = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414", null);
    #endregion

    #region ValueSet: Cataract Secondary to Ocular Disorders
    [CqlValueSetDefinition(
        definitionName: "Cataract Secondary to Ocular Disorders",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410",
        valueSetVersion: null)]
    public CqlValueSet Cataract_Secondary_to_Ocular_Disorders(CqlContext context) => _Cataract_Secondary_to_Ocular_Disorders;

    private static readonly CqlValueSet _Cataract_Secondary_to_Ocular_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410", null);
    #endregion

    #region ValueSet: Cataract Surgery
    [CqlValueSetDefinition(
        definitionName: "Cataract Surgery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411",
        valueSetVersion: null)]
    public CqlValueSet Cataract_Surgery(CqlContext context) => _Cataract_Surgery;

    private static readonly CqlValueSet _Cataract_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411", null);
    #endregion

    #region ValueSet: Central Corneal Ulcer
    [CqlValueSetDefinition(
        definitionName: "Central Corneal Ulcer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428",
        valueSetVersion: null)]
    public CqlValueSet Central_Corneal_Ulcer(CqlContext context) => _Central_Corneal_Ulcer;

    private static readonly CqlValueSet _Central_Corneal_Ulcer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428", null);
    #endregion

    #region ValueSet: Certain Types of Iridocyclitis
    [CqlValueSetDefinition(
        definitionName: "Certain Types of Iridocyclitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415",
        valueSetVersion: null)]
    public CqlValueSet Certain_Types_of_Iridocyclitis(CqlContext context) => _Certain_Types_of_Iridocyclitis;

    private static readonly CqlValueSet _Certain_Types_of_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415", null);
    #endregion

    #region ValueSet: Choroidal Degenerations
    [CqlValueSetDefinition(
        definitionName: "Choroidal Degenerations",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450",
        valueSetVersion: null)]
    public CqlValueSet Choroidal_Degenerations(CqlContext context) => _Choroidal_Degenerations;

    private static readonly CqlValueSet _Choroidal_Degenerations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450", null);
    #endregion

    #region ValueSet: Choroidal Detachment
    [CqlValueSetDefinition(
        definitionName: "Choroidal Detachment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451",
        valueSetVersion: null)]
    public CqlValueSet Choroidal_Detachment(CqlContext context) => _Choroidal_Detachment;

    private static readonly CqlValueSet _Choroidal_Detachment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451", null);
    #endregion

    #region ValueSet: Choroidal Hemorrhage and Rupture
    [CqlValueSetDefinition(
        definitionName: "Choroidal Hemorrhage and Rupture",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452",
        valueSetVersion: null)]
    public CqlValueSet Choroidal_Hemorrhage_and_Rupture(CqlContext context) => _Choroidal_Hemorrhage_and_Rupture;

    private static readonly CqlValueSet _Choroidal_Hemorrhage_and_Rupture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452", null);
    #endregion

    #region ValueSet: Chronic Iridocyclitis
    [CqlValueSetDefinition(
        definitionName: "Chronic Iridocyclitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416",
        valueSetVersion: null)]
    public CqlValueSet Chronic_Iridocyclitis(CqlContext context) => _Chronic_Iridocyclitis;

    private static readonly CqlValueSet _Chronic_Iridocyclitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416", null);
    #endregion

    #region ValueSet: Cloudy Cornea
    [CqlValueSetDefinition(
        definitionName: "Cloudy Cornea",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417",
        valueSetVersion: null)]
    public CqlValueSet Cloudy_Cornea(CqlContext context) => _Cloudy_Cornea;

    private static readonly CqlValueSet _Cloudy_Cornea = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417", null);
    #endregion

    #region ValueSet: Corneal Edema
    [CqlValueSetDefinition(
        definitionName: "Corneal Edema",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418",
        valueSetVersion: null)]
    public CqlValueSet Corneal_Edema(CqlContext context) => _Corneal_Edema;

    private static readonly CqlValueSet _Corneal_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418", null);
    #endregion

    #region ValueSet: Degeneration of Macula and Posterior Pole
    [CqlValueSetDefinition(
        definitionName: "Degeneration of Macula and Posterior Pole",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453",
        valueSetVersion: null)]
    public CqlValueSet Degeneration_of_Macula_and_Posterior_Pole(CqlContext context) => _Degeneration_of_Macula_and_Posterior_Pole;

    private static readonly CqlValueSet _Degeneration_of_Macula_and_Posterior_Pole = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453", null);
    #endregion

    #region ValueSet: Degenerative Disorders of Globe
    [CqlValueSetDefinition(
        definitionName: "Degenerative Disorders of Globe",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454",
        valueSetVersion: null)]
    public CqlValueSet Degenerative_Disorders_of_Globe(CqlContext context) => _Degenerative_Disorders_of_Globe;

    private static readonly CqlValueSet _Degenerative_Disorders_of_Globe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454", null);
    #endregion

    #region ValueSet: Diabetic Macular Edema
    [CqlValueSetDefinition(
        definitionName: "Diabetic Macular Edema",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455",
        valueSetVersion: null)]
    public CqlValueSet Diabetic_Macular_Edema(CqlContext context) => _Diabetic_Macular_Edema;

    private static readonly CqlValueSet _Diabetic_Macular_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455", null);
    #endregion

    #region ValueSet: Diabetic Retinopathy
    [CqlValueSetDefinition(
        definitionName: "Diabetic Retinopathy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327",
        valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext context) => _Diabetic_Retinopathy;

    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);
    #endregion

    #region ValueSet: Disorders of Cornea Including Corneal Opacity
    [CqlValueSetDefinition(
        definitionName: "Disorders of Cornea Including Corneal Opacity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419",
        valueSetVersion: null)]
    public CqlValueSet Disorders_of_Cornea_Including_Corneal_Opacity(CqlContext context) => _Disorders_of_Cornea_Including_Corneal_Opacity;

    private static readonly CqlValueSet _Disorders_of_Cornea_Including_Corneal_Opacity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419", null);
    #endregion

    #region ValueSet: Disorders of Optic Chiasm
    [CqlValueSetDefinition(
        definitionName: "Disorders of Optic Chiasm",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457",
        valueSetVersion: null)]
    public CqlValueSet Disorders_of_Optic_Chiasm(CqlContext context) => _Disorders_of_Optic_Chiasm;

    private static readonly CqlValueSet _Disorders_of_Optic_Chiasm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457", null);
    #endregion

    #region ValueSet: Disorders of Visual Cortex
    [CqlValueSetDefinition(
        definitionName: "Disorders of Visual Cortex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458",
        valueSetVersion: null)]
    public CqlValueSet Disorders_of_Visual_Cortex(CqlContext context) => _Disorders_of_Visual_Cortex;

    private static readonly CqlValueSet _Disorders_of_Visual_Cortex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458", null);
    #endregion

    #region ValueSet: Disseminated Chorioretinitis and Disseminated Retinochoroiditis
    [CqlValueSetDefinition(
        definitionName: "Disseminated Chorioretinitis and Disseminated Retinochoroiditis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459",
        valueSetVersion: null)]
    public CqlValueSet Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(CqlContext context) => _Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis;

    private static readonly CqlValueSet _Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459", null);
    #endregion

    #region ValueSet: Focal Chorioretinitis and Focal Retinochoroiditis
    [CqlValueSetDefinition(
        definitionName: "Focal Chorioretinitis and Focal Retinochoroiditis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460",
        valueSetVersion: null)]
    public CqlValueSet Focal_Chorioretinitis_and_Focal_Retinochoroiditis(CqlContext context) => _Focal_Chorioretinitis_and_Focal_Retinochoroiditis;

    private static readonly CqlValueSet _Focal_Chorioretinitis_and_Focal_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460", null);
    #endregion

    #region ValueSet: Glaucoma
    [CqlValueSetDefinition(
        definitionName: "Glaucoma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423",
        valueSetVersion: null)]
    public CqlValueSet Glaucoma(CqlContext context) => _Glaucoma;

    private static readonly CqlValueSet _Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423", null);
    #endregion

    #region ValueSet: Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes
    [CqlValueSetDefinition(
        definitionName: "Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461",
        valueSetVersion: null)]
    public CqlValueSet Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(CqlContext context) => _Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes;

    private static readonly CqlValueSet _Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461", null);
    #endregion

    #region ValueSet: Hereditary Choroidal Dystrophies
    [CqlValueSetDefinition(
        definitionName: "Hereditary Choroidal Dystrophies",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462",
        valueSetVersion: null)]
    public CqlValueSet Hereditary_Choroidal_Dystrophies(CqlContext context) => _Hereditary_Choroidal_Dystrophies;

    private static readonly CqlValueSet _Hereditary_Choroidal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462", null);
    #endregion

    #region ValueSet: Hereditary Corneal Dystrophies
    [CqlValueSetDefinition(
        definitionName: "Hereditary Corneal Dystrophies",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424",
        valueSetVersion: null)]
    public CqlValueSet Hereditary_Corneal_Dystrophies(CqlContext context) => _Hereditary_Corneal_Dystrophies;

    private static readonly CqlValueSet _Hereditary_Corneal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424", null);
    #endregion

    #region ValueSet: Hereditary Retinal Dystrophies
    [CqlValueSetDefinition(
        definitionName: "Hereditary Retinal Dystrophies",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463",
        valueSetVersion: null)]
    public CqlValueSet Hereditary_Retinal_Dystrophies(CqlContext context) => _Hereditary_Retinal_Dystrophies;

    private static readonly CqlValueSet _Hereditary_Retinal_Dystrophies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463", null);
    #endregion

    #region ValueSet: Hypotony of Eye
    [CqlValueSetDefinition(
        definitionName: "Hypotony of Eye",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426",
        valueSetVersion: null)]
    public CqlValueSet Hypotony_of_Eye(CqlContext context) => _Hypotony_of_Eye;

    private static readonly CqlValueSet _Hypotony_of_Eye = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426", null);
    #endregion

    #region ValueSet: Injury to Optic Nerve and Pathways
    [CqlValueSetDefinition(
        definitionName: "Injury to Optic Nerve and Pathways",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427",
        valueSetVersion: null)]
    public CqlValueSet Injury_to_Optic_Nerve_and_Pathways(CqlContext context) => _Injury_to_Optic_Nerve_and_Pathways;

    private static readonly CqlValueSet _Injury_to_Optic_Nerve_and_Pathways = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427", null);
    #endregion

    #region ValueSet: Macular Scar of Posterior Polar
    [CqlValueSetDefinition(
        definitionName: "Macular Scar of Posterior Polar",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559",
        valueSetVersion: null)]
    public CqlValueSet Macular_Scar_of_Posterior_Polar(CqlContext context) => _Macular_Scar_of_Posterior_Polar;

    private static readonly CqlValueSet _Macular_Scar_of_Posterior_Polar = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559", null);
    #endregion

    #region ValueSet: Morgagnian Cataract
    [CqlValueSetDefinition(
        definitionName: "Morgagnian Cataract",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558",
        valueSetVersion: null)]
    public CqlValueSet Morgagnian_Cataract(CqlContext context) => _Morgagnian_Cataract;

    private static readonly CqlValueSet _Morgagnian_Cataract = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558", null);
    #endregion

    #region ValueSet: Nystagmus and Other Irregular Eye Movements
    [CqlValueSetDefinition(
        definitionName: "Nystagmus and Other Irregular Eye Movements",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465",
        valueSetVersion: null)]
    public CqlValueSet Nystagmus_and_Other_Irregular_Eye_Movements(CqlContext context) => _Nystagmus_and_Other_Irregular_Eye_Movements;

    private static readonly CqlValueSet _Nystagmus_and_Other_Irregular_Eye_Movements = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465", null);
    #endregion

    #region ValueSet: Open Wound of Eyeball
    [CqlValueSetDefinition(
        definitionName: "Open Wound of Eyeball",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430",
        valueSetVersion: null)]
    public CqlValueSet Open_Wound_of_Eyeball(CqlContext context) => _Open_Wound_of_Eyeball;

    private static readonly CqlValueSet _Open_Wound_of_Eyeball = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430", null);
    #endregion

    #region ValueSet: Optic Atrophy
    [CqlValueSetDefinition(
        definitionName: "Optic Atrophy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466",
        valueSetVersion: null)]
    public CqlValueSet Optic_Atrophy(CqlContext context) => _Optic_Atrophy;

    private static readonly CqlValueSet _Optic_Atrophy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466", null);
    #endregion

    #region ValueSet: Optic Neuritis
    [CqlValueSetDefinition(
        definitionName: "Optic Neuritis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467",
        valueSetVersion: null)]
    public CqlValueSet Optic_Neuritis(CqlContext context) => _Optic_Neuritis;

    private static readonly CqlValueSet _Optic_Neuritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467", null);
    #endregion

    #region ValueSet: Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis
    [CqlValueSetDefinition(
        definitionName: "Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468",
        valueSetVersion: null)]
    public CqlValueSet Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(CqlContext context) => _Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis;

    private static readonly CqlValueSet _Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468", null);
    #endregion

    #region ValueSet: Other Background Retinopathy and Retinal Vascular Changes
    [CqlValueSetDefinition(
        definitionName: "Other Background Retinopathy and Retinal Vascular Changes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469",
        valueSetVersion: null)]
    public CqlValueSet Other_Background_Retinopathy_and_Retinal_Vascular_Changes(CqlContext context) => _Other_Background_Retinopathy_and_Retinal_Vascular_Changes;

    private static readonly CqlValueSet _Other_Background_Retinopathy_and_Retinal_Vascular_Changes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469", null);
    #endregion

    #region ValueSet: Other Disorders of Optic Nerve
    [CqlValueSetDefinition(
        definitionName: "Other Disorders of Optic Nerve",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471",
        valueSetVersion: null)]
    public CqlValueSet Other_Disorders_of_Optic_Nerve(CqlContext context) => _Other_Disorders_of_Optic_Nerve;

    private static readonly CqlValueSet _Other_Disorders_of_Optic_Nerve = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471", null);
    #endregion

    #region ValueSet: Other Endophthalmitis
    [CqlValueSetDefinition(
        definitionName: "Other Endophthalmitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473",
        valueSetVersion: null)]
    public CqlValueSet Other_Endophthalmitis(CqlContext context) => _Other_Endophthalmitis;

    private static readonly CqlValueSet _Other_Endophthalmitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473", null);
    #endregion

    #region ValueSet: Other Proliferative Retinopathy
    [CqlValueSetDefinition(
        definitionName: "Other Proliferative Retinopathy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480",
        valueSetVersion: null)]
    public CqlValueSet Other_Proliferative_Retinopathy(CqlContext context) => _Other_Proliferative_Retinopathy;

    private static readonly CqlValueSet _Other_Proliferative_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480", null);
    #endregion

    #region ValueSet: Pathologic Myopia
    [CqlValueSetDefinition(
        definitionName: "Pathologic Myopia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432",
        valueSetVersion: null)]
    public CqlValueSet Pathologic_Myopia(CqlContext context) => _Pathologic_Myopia;

    private static readonly CqlValueSet _Pathologic_Myopia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432", null);
    #endregion

    #region ValueSet: Posterior Lenticonus
    [CqlValueSetDefinition(
        definitionName: "Posterior Lenticonus",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433",
        valueSetVersion: null)]
    public CqlValueSet Posterior_Lenticonus(CqlContext context) => _Posterior_Lenticonus;

    private static readonly CqlValueSet _Posterior_Lenticonus = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433", null);
    #endregion

    #region ValueSet: Prior Penetrating Keratoplasty
    [CqlValueSetDefinition(
        definitionName: "Prior Penetrating Keratoplasty",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475",
        valueSetVersion: null)]
    public CqlValueSet Prior_Penetrating_Keratoplasty(CqlContext context) => _Prior_Penetrating_Keratoplasty;

    private static readonly CqlValueSet _Prior_Penetrating_Keratoplasty = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475", null);
    #endregion

    #region ValueSet: Purulent Endophthalmitis
    [CqlValueSetDefinition(
        definitionName: "Purulent Endophthalmitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477",
        valueSetVersion: null)]
    public CqlValueSet Purulent_Endophthalmitis(CqlContext context) => _Purulent_Endophthalmitis;

    private static readonly CqlValueSet _Purulent_Endophthalmitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477", null);
    #endregion

    #region ValueSet: Retinal Detachment with Retinal Defect
    [CqlValueSetDefinition(
        definitionName: "Retinal Detachment with Retinal Defect",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478",
        valueSetVersion: null)]
    public CqlValueSet Retinal_Detachment_with_Retinal_Defect(CqlContext context) => _Retinal_Detachment_with_Retinal_Defect;

    private static readonly CqlValueSet _Retinal_Detachment_with_Retinal_Defect = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478", null);
    #endregion

    #region ValueSet: Retinal Vascular Occlusion
    [CqlValueSetDefinition(
        definitionName: "Retinal Vascular Occlusion",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479",
        valueSetVersion: null)]
    public CqlValueSet Retinal_Vascular_Occlusion(CqlContext context) => _Retinal_Vascular_Occlusion;

    private static readonly CqlValueSet _Retinal_Vascular_Occlusion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479", null);
    #endregion

    #region ValueSet: Retrolental Fibroplasias
    [CqlValueSetDefinition(
        definitionName: "Retrolental Fibroplasias",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438",
        valueSetVersion: null)]
    public CqlValueSet Retrolental_Fibroplasias(CqlContext context) => _Retrolental_Fibroplasias;

    private static readonly CqlValueSet _Retrolental_Fibroplasias = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438", null);
    #endregion

    #region ValueSet: Scleritis
    [CqlValueSetDefinition(
        definitionName: "Scleritis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1",
        valueSetVersion: null)]
    public CqlValueSet Scleritis(CqlContext context) => _Scleritis;

    private static readonly CqlValueSet _Scleritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1", null);
    #endregion

    #region ValueSet: Separation of Retinal Layers
    [CqlValueSetDefinition(
        definitionName: "Separation of Retinal Layers",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482",
        valueSetVersion: null)]
    public CqlValueSet Separation_of_Retinal_Layers(CqlContext context) => _Separation_of_Retinal_Layers;

    private static readonly CqlValueSet _Separation_of_Retinal_Layers = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482", null);
    #endregion

    #region ValueSet: Traumatic Cataract
    [CqlValueSetDefinition(
        definitionName: "Traumatic Cataract",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443",
        valueSetVersion: null)]
    public CqlValueSet Traumatic_Cataract(CqlContext context) => _Traumatic_Cataract;

    private static readonly CqlValueSet _Traumatic_Cataract = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443", null);
    #endregion

    #region ValueSet: Uveitis
    [CqlValueSetDefinition(
        definitionName: "Uveitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444",
        valueSetVersion: null)]
    public CqlValueSet Uveitis(CqlContext context) => _Uveitis;

    private static readonly CqlValueSet _Uveitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444", null);
    #endregion

    #region ValueSet: Vascular Disorders of Iris and Ciliary Body
    [CqlValueSetDefinition(
        definitionName: "Vascular Disorders of Iris and Ciliary Body",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445",
        valueSetVersion: null)]
    public CqlValueSet Vascular_Disorders_of_Iris_and_Ciliary_Body(CqlContext context) => _Vascular_Disorders_of_Iris_and_Ciliary_Body;

    private static readonly CqlValueSet _Vascular_Disorders_of_Iris_and_Ciliary_Body = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445", null);
    #endregion

    #region ValueSet: Visual Acuity 20/40 or Better
    [CqlValueSetDefinition(
        definitionName: "Visual Acuity 20/40 or Better",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483",
        valueSetVersion: null)]
    public CqlValueSet Visual_Acuity_20_40_or_Better(CqlContext context) => _Visual_Acuity_20_40_or_Better;

    private static readonly CqlValueSet _Visual_Acuity_20_40_or_Better = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483", null);
    #endregion

    #region ValueSet: Visual Field Defects
    [CqlValueSetDefinition(
        definitionName: "Visual Field Defects",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446",
        valueSetVersion: null)]
    public CqlValueSet Visual_Field_Defects(CqlContext context) => _Visual_Field_Defects;

    private static readonly CqlValueSet _Visual_Field_Defects = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Best corrected visual acuity (observable entity)
    [CqlCodeDefinition(
        definitionName: "Best corrected visual acuity (observable entity)",
        codeId: "419775003",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Best_corrected_visual_acuity__observable_entity_(CqlContext context) => _Best_corrected_visual_acuity__observable_entity_;

    private static readonly CqlCode _Best_corrected_visual_acuity__observable_entity_ = new CqlCode("419775003", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
            new CqlCode("419775003", "http://snomed.info/sct", default, default),
        ];

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "Measurement Period", yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cataract Surgery Between January and September of Measurement Period")]
    public IEnumerable<Procedure> Cataract_Surgery_Between_January_and_September_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cataract_Surgery(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure CataractSurgery)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CataractSurgery?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(92m, "days");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Code<EventStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CataractSurgery?.StatusElement;
            EventStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Procedure> Initial_Population(CqlContext context)
    {
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure CataractSurgeryPerformed)
        {
            Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "year");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 18);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Procedure> Denominator(CqlContext context)
    {
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Procedure> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure CataractSurgeryPerformed)
        {
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Acute_and_Subacute_Iridocyclitis(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Amblyopia(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Burn_Confined_to_Eye_and_Adnexa(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Cataract_Secondary_to_Ocular_Disorders(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cataract_Congenital(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Cataract_Mature_or_Hypermature(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Cataract_Posterior_Polar(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Central_Corneal_Ulcer(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Certain_Types_of_Iridocyclitis(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Choroidal_Degenerations(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Choroidal_Detachment(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Choroidal_Hemorrhage_and_Rupture(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Chronic_Iridocyclitis(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cloudy_Cornea(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Corneal_Edema(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Disorders_of_Cornea_Including_Corneal_Opacity(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Degeneration_of_Macula_and_Posterior_Pole(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Degenerative_Disorders_of_Globe(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Diabetic_Macular_Edema(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Disorders_of_Optic_Chiasm(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Disorders_of_Visual_Cortex(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Disseminated_Chorioretinitis_and_Disseminated_Retinochoroiditis(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Focal_Chorioretinitis_and_Focal_Retinochoroiditis(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glaucoma(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Glaucoma_Associated_with_Congenital_Anomalies_and_Dystrophies_and_Systemic_Syndromes(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Hereditary_Choroidal_Dystrophies(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hereditary_Corneal_Dystrophies(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Hereditary_Retinal_Dystrophies(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Hypotony_of_Eye(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Injury_to_Optic_Nerve_and_Pathways(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Macular_Scar_of_Posterior_Polar(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Morgagnian_Cataract(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Nystagmus_and_Other_Irregular_Eye_Movements(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Open_Wound_of_Eyeball(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Optic_Atrophy(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Optic_Neuritis(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Other_and_Unspecified_Forms_of_Chorioretinitis_and_Retinochoroiditis(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Other_Background_Retinopathy_and_Retinal_Vascular_Changes(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Other_Disorders_of_Optic_Nerve(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Other_Endophthalmitis(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Other_Proliferative_Retinopathy(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Pathologic_Myopia(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Posterior_Lenticonus(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Prior_Penetrating_Keratoplasty(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Purulent_Endophthalmitis(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Retinal_Detachment_with_Retinal_Defect(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Retinal_Vascular_Occlusion(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Retrolental_Fibroplasias(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Scleritis(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Separation_of_Retinal_Layers(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Traumatic_Cataract(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Uveitis(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Vascular_Disorders_of_Iris_and_Ciliary_Body(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Visual_Field_Defects(context);
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ComorbidDiagnosis)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ComorbidDiagnosis);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CataractSurgeryPerformed?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.OverlapsBefore(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isActive(context, ComorbidDiagnosis);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Procedure gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition ComorbidDiagnosis) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Procedure, Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Procedure> Numerator(CqlContext context)
    {
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Cataract_Surgery_Between_January_and_September_of_Measurement_Period(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure CataractSurgeryPerformed)
        {
            CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Best_corrected_visual_acuity__observable_entity_(context);
            IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Best_Corrected_Visual_Acuity_Exam_Using_Snellen_Chart(context);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation VisualAcuityExamPerformed)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = VisualAcuityExamPerformed?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CataractSurgeryPerformed?.Performed;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(90m, "days");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, false, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = VisualAcuityExamPerformed?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                    "preliminary",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = VisualAcuityExamPerformed?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Visual_Acuity_20_40_or_Better(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Procedure gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation VisualAcuityExamPerformed) =>
                CataractSurgeryPerformed;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Observation, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Procedure, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
