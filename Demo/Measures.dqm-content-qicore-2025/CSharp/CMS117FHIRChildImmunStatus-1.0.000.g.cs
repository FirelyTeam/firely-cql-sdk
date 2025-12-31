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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS117FHIRChildImmunStatus", "1.0.000")]
public partial class CMS117FHIRChildImmunStatus_1_0_000 : ILibrary, ISingleton<CMS117FHIRChildImmunStatus_1_0_000>
{
    private CMS117FHIRChildImmunStatus_1_0_000() {}

    public static CMS117FHIRChildImmunStatus_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS117FHIRChildImmunStatus";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Anaphylactic Reaction to DTaP Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", valueSetVersion: null)]
    public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine(CqlContext _) => _Anaphylactic_Reaction_to_DTaP_Vaccine;
    private static readonly CqlValueSet _Anaphylactic_Reaction_to_DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", null);

    [CqlValueSetDefinition("Disorders of the Immune System", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", valueSetVersion: null)]
    public CqlValueSet Disorders_of_the_Immune_System(CqlContext _) => _Disorders_of_the_Immune_System;
    private static readonly CqlValueSet _Disorders_of_the_Immune_System = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", null);

    [CqlValueSetDefinition("DTaP Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine(CqlContext _) => _DTaP_Vaccine;
    private static readonly CqlValueSet _DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", null);

    [CqlValueSetDefinition("DTaP Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine_Administered(CqlContext _) => _DTaP_Vaccine_Administered;
    private static readonly CqlValueSet _DTaP_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", null);

    [CqlValueSetDefinition("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", valueSetVersion: null)]
    public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(CqlContext _) => _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine;
    private static readonly CqlValueSet _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", null);

    [CqlValueSetDefinition("Hepatitis A", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext _) => _Hepatitis_A;
    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlValueSetDefinition("Hepatitis A Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine(CqlContext _) => _Hepatitis_A_Vaccine;
    private static readonly CqlValueSet _Hepatitis_A_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", null);

    [CqlValueSetDefinition("Hepatitis A Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine_Administered(CqlContext _) => _Hepatitis_A_Vaccine_Administered;
    private static readonly CqlValueSet _Hepatitis_A_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", null);

    [CqlValueSetDefinition("Hepatitis B", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext _) => _Hepatitis_B;
    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", null);

    [CqlValueSetDefinition("Hepatitis B Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine(CqlContext _) => _Hepatitis_B_Vaccine;
    private static readonly CqlValueSet _Hepatitis_B_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", null);

    [CqlValueSetDefinition("Hepatitis B Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine_Administered(CqlContext _) => _Hepatitis_B_Vaccine_Administered;
    private static readonly CqlValueSet _Hepatitis_B_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", null);

    [CqlValueSetDefinition("Hib Vaccine (3 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule_(CqlContext _) => _Hib_Vaccine__3_dose_schedule_;
    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", null);

    [CqlValueSetDefinition("Hib Vaccine (3 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered(CqlContext _) => _Hib_Vaccine__3_dose_schedule__Administered;
    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", null);

    [CqlValueSetDefinition("Hib Vaccine (4 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule_(CqlContext _) => _Hib_Vaccine__4_dose_schedule_;
    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", null);

    [CqlValueSetDefinition("Hib Vaccine (4 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered(CqlContext _) => _Hib_Vaccine__4_dose_schedule__Administered;
    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Inactivated Polio Vaccine (IPV)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV_(CqlContext _) => _Inactivated_Polio_Vaccine__IPV_;
    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", null);

    [CqlValueSetDefinition("Inactivated Polio Vaccine (IPV) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered(CqlContext _) => _Inactivated_Polio_Vaccine__IPV__Administered;
    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", null);

    [CqlValueSetDefinition("Child Influenza Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine(CqlContext _) => _Child_Influenza_Vaccine;
    private static readonly CqlValueSet _Child_Influenza_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", null);

    [CqlValueSetDefinition("Child Influenza Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine_Administered(CqlContext _) => _Child_Influenza_Vaccine_Administered;
    private static readonly CqlValueSet _Child_Influenza_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", null);

    [CqlValueSetDefinition("Influenza Virus LAIV Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine(CqlContext _) => _Influenza_Virus_LAIV_Vaccine;
    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", null);

    [CqlValueSetDefinition("Influenza Virus LAIV Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine_Administered(CqlContext _) => _Influenza_Virus_LAIV_Vaccine_Administered;
    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", null);

    [CqlValueSetDefinition("Intussusception", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", valueSetVersion: null)]
    public CqlValueSet Intussusception(CqlContext _) => _Intussusception;
    private static readonly CqlValueSet _Intussusception = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", null);

    [CqlValueSetDefinition("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(CqlContext _) => _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue;
    private static readonly CqlValueSet _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", null);

    [CqlValueSetDefinition("Measles", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", valueSetVersion: null)]
    public CqlValueSet Measles(CqlContext _) => _Measles;
    private static readonly CqlValueSet _Measles = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", null);

    [CqlValueSetDefinition("Measles, Mumps and Rubella (MMR) Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine(CqlContext _) => _Measles__Mumps_and_Rubella__MMR__Vaccine;
    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", null);

    [CqlValueSetDefinition("Measles, Mumps and Rubella (MMR) Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(CqlContext _) => _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered;
    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", null);

    [CqlValueSetDefinition("Mumps", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", valueSetVersion: null)]
    public CqlValueSet Mumps(CqlContext _) => _Mumps;
    private static readonly CqlValueSet _Mumps = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pneumococcal Conjugate Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine(CqlContext _) => _Pneumococcal_Conjugate_Vaccine;
    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", null);

    [CqlValueSetDefinition("Pneumococcal Conjugate Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered(CqlContext _) => _Pneumococcal_Conjugate_Vaccine_Administered;
    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (2 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered(CqlContext _) => _Rotavirus_Vaccine__2_dose_schedule__Administered;
    private static readonly CqlValueSet _Rotavirus_Vaccine__2_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (3 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_(CqlContext _) => _Rotavirus_Vaccine__3_dose_schedule_;
    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (3 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered(CqlContext _) => _Rotavirus_Vaccine__3_dose_schedule__Administered;
    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", null);

    [CqlValueSetDefinition("Rubella", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", valueSetVersion: null)]
    public CqlValueSet Rubella(CqlContext _) => _Rubella;
    private static readonly CqlValueSet _Rubella = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", null);

    [CqlValueSetDefinition("Severe Combined Immunodeficiency", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", valueSetVersion: null)]
    public CqlValueSet Severe_Combined_Immunodeficiency(CqlContext _) => _Severe_Combined_Immunodeficiency;
    private static readonly CqlValueSet _Severe_Combined_Immunodeficiency = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Varicella Zoster", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster(CqlContext _) => _Varicella_Zoster;
    private static readonly CqlValueSet _Varicella_Zoster = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", null);

    [CqlValueSetDefinition("Varicella Zoster Vaccine (VZV)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV_(CqlContext _) => _Varicella_Zoster_Vaccine__VZV_;
    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", null);

    [CqlValueSetDefinition("Varicella Zoster Vaccine (VZV) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered(CqlContext _) => _Varicella_Zoster_Vaccine__VZV__Administered;
    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)", codeId: "433621000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_ = new CqlCode("433621000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)", codeId: "428321000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_ = new CqlCode("428321000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by rotavirus vaccine (disorder)", codeId: "428331000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_rotavirus_vaccine__disorder_(CqlContext _) => _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_ = new CqlCode("428331000124103", "http://snomed.info/sct");

    [CqlCodeDefinition("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional", codeId: "99211", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext _) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("rotavirus, live, monovalent vaccine", codeId: "119", codeSystem: "http://hl7.org/fhir/sid/cvx")]
    public CqlCode rotavirus__live__monovalent_vaccine(CqlContext _) => _rotavirus__live__monovalent_vaccine;
    private static readonly CqlCode _rotavirus__live__monovalent_vaccine = new CqlCode("119", "http://hl7.org/fhir/sid/cvx");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)", codeId: "471311000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_ = new CqlCode("471311000124103", "http://snomed.info/sct");

    [CqlCodeDefinition("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach", codeId: "3E0234Z", codeSystem: "http://www.cms.gov/Medicare/Coding/ICD10")]
    public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(CqlContext _) => _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach;
    private static readonly CqlCode _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach = new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)", codeId: "471361000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_ = new CqlCode("471361000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)", codeId: "471331000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_ = new CqlCode("471331000124109", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)", codeId: "471141000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_ = new CqlCode("471141000124102", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)", codeId: "471321000124106", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_ = new CqlCode("471321000124106", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)", codeId: "471341000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_ = new CqlCode("471341000124104", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional]);

    [CqlCodeSystemDefinition("CVX", codeSystemId: "http://hl7.org/fhir/sid/cvx", codeSystemVersion: null)]
    public CqlCodeSystem CVX(CqlContext _) => _CVX;
    private static readonly CqlCodeSystem _CVX =
      new CqlCodeSystem("http://hl7.org/fhir/sid/cvx", null, [
          _rotavirus__live__monovalent_vaccine]);

    [CqlCodeSystemDefinition("ICD10", codeSystemId: "http://www.cms.gov/Medicare/Coding/ICD10", codeSystemVersion: null)]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://www.cms.gov/Medicare/Coding/ICD10", null, [
          _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS117FHIRChildImmunStatus-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _Qualifying_Encounters_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                IEnumerable<Encounter> l_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? m_(Encounter E) {
                    List<CodeableConcept> y_ = E?.Type;

                    CqlConcept z_(CodeableConcept @this) {
                        CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ae_;
                    }

                    IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);

                    bool? ab_(CqlConcept T) {
                        CqlCode af_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                        CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                        bool? ah_ = context.Operators.Equivalent(T, ag_);
                        return ah_;
                    }

                    IEnumerable<CqlConcept> ac_ = context.Operators.Where<CqlConcept>(aa_, ab_);
                    bool? ad_ = context.Operators.Exists<CqlConcept>(ac_);
                    return ad_;
                }

                IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
                CqlValueSet o_ = this.Virtual_Encounter(context);
                IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
                IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(k_, q_);
                CqlValueSet s_ = this.Telephone_Visits(context);
                IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
                IEnumerable<Encounter> v_ = Status_1_15_000.Instance.isEncounterPerformed(context, u_);

                bool? w_(Encounter ValidEncounters) {
                    CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                    Period aj_ = ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ai_, ak_, "day");
                    return al_;
                }

                IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);
                return x_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                bool? i_ = context.Operators.Equal(h_, 2);
                IEnumerable<Encounter> j_ = this.Qualifying_Encounters(context);
                bool? k_ = context.Operators.Exists<Encounter>(j_);
                bool? l_ = context.Operators.And(i_, k_);
                return l_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<CqlDate> _Date_of_Second_Birthday_Cached = new();

    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context) =>
        _Date_of_Second_Birthday_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlDate f_ = context.Operators.DateFrom(e_);
                CqlQuantity g_ = context.Operators.Quantity(2m, "years");
                CqlDate h_ = context.Operators.Add(f_, g_);
                return h_;
            });


    private Cached<CqlInterval<CqlDate>> _First_Two_Years_Cached = new();

    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context) =>
        _First_Two_Years_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlDate f_ = context.Operators.DateFrom(e_);
                CqlDate g_ = this.Date_of_Second_Birthday(context);
                CqlInterval<CqlDate> h_ = context.Operators.Interval(f_, g_, true, true);
                return h_;
            });


    private Cached<bool?> _Has_Severe_Combined_Immunodeficiency_Cached = new();

    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context) =>
        _Has_Severe_Combined_Immunodeficiency_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Severe_Combined_Immunodeficiency(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object SevereImmuneDisorder) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
                    bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");
                    return n_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                bool? i_ = context.Operators.Exists<object>(h_);
                return i_;
            });


    private Cached<bool?> _Has_Immunodeficiency_Cached = new();

    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context) =>
        _Has_Immunodeficiency_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Disorders_of_the_Immune_System(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object ImmuneDisorder) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ImmuneDisorder);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
                    bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");
                    return n_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                bool? i_ = context.Operators.Exists<object>(h_);
                return i_;
            });


    private Cached<bool?> _Has_HIV_Cached = new();

    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context) =>
        _Has_HIV_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.HIV(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object HIVDiagnosis) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
                    bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");
                    return n_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                bool? i_ = context.Operators.Exists<object>(h_);
                return i_;
            });


    private Cached<bool?> _Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Cached = new();

    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context) =>
        _Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object LymphaticMalignantNeoplasm) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
                    bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");
                    return n_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                bool? i_ = context.Operators.Exists<object>(h_);
                return i_;
            });


    private Cached<bool?> _Has_Intussusception_Cached = new();

    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context) =>
        _Has_Intussusception_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Intussusception(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object IntussusceptionDisorder) {
                    CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
                    bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");
                    return n_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                bool? i_ = context.Operators.Exists<object>(h_);
                return i_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                bool? b_ = this.Has_Severe_Combined_Immunodeficiency(context);
                bool? c_ = context.Operators.Or(a_, b_);
                bool? d_ = this.Has_Immunodeficiency(context);
                bool? e_ = context.Operators.Or(c_, d_);
                bool? f_ = this.Has_HIV(context);
                bool? g_ = context.Operators.Or(e_, f_);
                bool? h_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
                bool? i_ = context.Operators.Or(g_, h_);
                bool? j_ = this.Has_Intussusception(context);
                bool? k_ = context.Operators.Or(i_, j_);
                return k_;
            });


    private Cached<CqlInterval<CqlDate>> _Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Cached = new();

    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context) =>
        _Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlDate f_ = context.Operators.DateFrom(e_);
                CqlQuantity g_ = context.Operators.Quantity(42m, "days");
                CqlDate h_ = context.Operators.Add(f_, g_);
                CqlDate i_ = this.Date_of_Second_Birthday(context);
                CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);
                return j_;
            });


    private Cached<IEnumerable<CqlDate>> _DTaP_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context) =>
        _DTaP_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.DTaP_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization DTaPVaccination) {
                    DataType r_ = DTaPVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization DTaPVaccination) {
                    DataType x_ = DTaPVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.DTaP_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure DTaPProcedure) {
                    DataType ab_ = DTaPProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure DTaPProcedure) {
                    DataType ah_ = DTaPProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Four_DTaP_Vaccinations_Cached = new();

    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context) =>
        _Four_DTaP_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.DTaP_Immunizations_or_Procedures(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);

                (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? l_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(e_, f_);

                bool? h_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) {
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
                    CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
                    CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
                    CqlDate r_ = context.Operators.DateFrom(q_);
                    CqlQuantity s_ = context.Operators.Quantity(1m, "day");
                    CqlDate t_ = context.Operators.Add(r_, s_);
                    bool? u_ = context.Operators.SameOrAfter(o_, t_, "day");
                    CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
                    CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_);
                    CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDateTime ac_ = context.Operators.Add(aa_, s_);
                    bool? ad_ = context.Operators.SameOrAfter(y_, ac_, "day");
                    bool? ae_ = context.Operators.And(u_, ad_);
                    CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
                    CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                    CqlDate ah_ = context.Operators.DateFrom(ag_);
                    CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
                    CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                    CqlDateTime am_ = context.Operators.Add(ak_, s_);
                    bool? an_ = context.Operators.SameOrAfter(ai_, am_, "day");
                    bool? ao_ = context.Operators.And(ae_, an_);
                    return ao_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(g_, h_);
                CqlDate j_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) => tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
                IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(i_, j_);
                return k_;
            });


    private Cached<IEnumerable<object>> _DTaP_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<object> DTaP_Numerator_Inclusion_Conditions(CqlContext context) =>
        _DTaP_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                CqlValueSet f_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
                IEnumerable<object> l_ = Status_1_15_000.Instance.verified(context, k_);

                bool? m_(object DTaPConditions) {
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DTaPConditions);
                    CqlDateTime p_ = context.Operators.Start(o_);
                    CqlDate q_ = context.Operators.DateFrom(p_);
                    CqlInterval<CqlDate> r_ = this.First_Two_Years(context);
                    bool? s_ = context.Operators.In<CqlDate>(q_, r_, "day");
                    return s_;
                }

                IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);
                return n_;
            });


    private Cached<IEnumerable<CqlDate>> _Polio_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context) =>
        _Polio_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Inactivated_Polio_Vaccine__IPV_(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization PolioVaccination) {
                    DataType r_ = PolioVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization PolioVaccination) {
                    DataType x_ = PolioVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure PolioProcedure) {
                    DataType ab_ = PolioProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure PolioProcedure) {
                    DataType ah_ = PolioProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Three_Polio_Vaccinations_Cached = new();

    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context) =>
        _Three_Polio_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Polio_Immunizations_or_Procedures(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);

                (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? l_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(d_, e_);

                bool? g_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) {
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
                    CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
                    CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
                    CqlDate r_ = context.Operators.DateFrom(q_);
                    CqlQuantity s_ = context.Operators.Quantity(1m, "day");
                    CqlDate t_ = context.Operators.Add(r_, s_);
                    bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
                    CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
                    CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    CqlDate ac_ = context.Operators.Add(aa_, s_);
                    bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
                    bool? ae_ = context.Operators.And(u_, ad_);
                    return ae_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(f_, g_);

                CqlDate i_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) {
                    CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
                    CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                    CqlDate ah_ = context.Operators.DateFrom(ag_);
                    return ah_;
                }

                IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(h_, i_);
                IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                return k_;
            });


    private Cached<IEnumerable<object>> _Polio_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<object> Polio_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Polio_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object PolioConditions) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PolioConditions);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<CqlDate> _Date_of_First_Birthday_Cached = new();

    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context) =>
        _Date_of_First_Birthday_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlDate f_ = context.Operators.DateFrom(e_);
                CqlQuantity g_ = context.Operators.Quantity(1m, "year");
                CqlDate h_ = context.Operators.Add(f_, g_);
                return h_;
            });


    private Cached<CqlInterval<CqlDate>> _Date_of_First_Birthday_to_Date_of_Second_Birthday_Cached = new();

    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context) =>
        _Date_of_First_Birthday_to_Date_of_Second_Birthday_Cached.GetOrReplace(
            context,
            () => {
                CqlDate a_ = this.Date_of_First_Birthday(context);
                CqlDate b_ = this.Date_of_Second_Birthday(context);
                CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);
                return c_;
            });


    private Cached<IEnumerable<CqlDate>> _One_MMR_Vaccination_Cached = new();

    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context) =>
        _One_MMR_Vaccination_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization MMRVaccination) {
                    DataType r_ = MMRVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization MMRVaccination) {
                    DataType x_ = MMRVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure MMRProcedure) {
                    DataType ab_ = MMRProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure MMRProcedure) {
                    DataType ah_ = MMRProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<object>> _MMR_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<object> MMR_Numerator_Inclusion_Conditions(CqlContext context) =>
        _MMR_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object MMRConditions) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MMRConditions);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<IEnumerable<object>> _Measles_Indicators_Cached = new();

    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<object> Measles_Indicators(CqlContext context) =>
        _Measles_Indicators_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Measles(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
                object f_(Condition X) => X as object;
                IEnumerable<object> g_ = context.Operators.Select<Condition, object>(e_, f_);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object MeaslesDiagnosis) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<IEnumerable<object>> _Mumps_Indicators_Cached = new();

    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<object> Mumps_Indicators(CqlContext context) =>
        _Mumps_Indicators_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Mumps(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object MumpsDiagnosis) {
                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
                    CqlDateTime j_ = context.Operators.Start(i_);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
                    bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
                    return m_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<object>> _Rubella_Indicators_Cached = new();

    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<object> Rubella_Indicators(CqlContext context) =>
        _Rubella_Indicators_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Rubella(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

                bool? g_(object RubellaDiagnosis) {
                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
                    CqlDateTime j_ = context.Operators.Start(i_);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
                    bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
                    return m_;
                }

                IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<CqlDate>> _Hib_3_Dose_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context) =>
        _Hib_3_Dose_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hib_Vaccine__3_dose_schedule_(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization ThreeDoseHibVaccine) {
                    DataType r_ = ThreeDoseHibVaccine?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization ThreeDoseHibVaccine) {
                    DataType x_ = ThreeDoseHibVaccine?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure ThreeDoseHibProcedure) {
                    DataType ab_ = ThreeDoseHibProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure ThreeDoseHibProcedure) {
                    DataType ah_ = ThreeDoseHibProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Hib_4_Dose_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context) =>
        _Hib_4_Dose_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hib_Vaccine__4_dose_schedule_(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization HibVaccine) {
                    DataType r_ = HibVaccine?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization HibVaccine) {
                    DataType x_ = HibVaccine?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure HibProcedure) {
                    DataType ab_ = HibProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure HibProcedure) {
                    DataType ah_ = HibProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Hib_3_or_4_Dose_Immunizations_Cached = new();

    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context) =>
        _Hib_3_or_4_Dose_Immunizations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
                IEnumerable<CqlDate> b_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
                IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);
                return c_;
            });


    private Cached<bool?> _Has_Appropriate_Number_of_Hib_Immunizations_Cached = new();

    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context) =>
        _Has_Appropriate_Number_of_Hib_Immunizations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Hib_3_or_4_Dose_Immunizations(context);

                bool? b_(CqlDate HibImmunization) {
                    IEnumerable<CqlDate> e_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
                    int? f_ = context.Operators.Count<CqlDate>(e_);
                    bool? g_ = context.Operators.Greater(f_, 0);
                    IEnumerable<CqlDate> h_ = this.Hib_3_or_4_Dose_Immunizations(context);

                    CqlDate i_(CqlDate HibVaccinations) {
                        CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                        CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
                        CqlDate ae_ = context.Operators.DateFrom(ad_);
                        return ae_;
                    }

                    IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
                    IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                    IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
                    int? m_ = context.Operators.Count<CqlDate>(l_);
                    bool? n_ = context.Operators.GreaterOrEqual(m_, 4);
                    bool? o_ = context.Operators.And(g_, n_);
                    int? q_ = context.Operators.Count<CqlDate>(e_);
                    bool? r_ = context.Operators.Greater(q_, 0);
                    bool? s_ = context.Operators.IsFalse(r_);

                    CqlDate u_(CqlDate HibVaccinations) {
                        CqlDateTime af_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                        CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                        CqlDate ah_ = context.Operators.DateFrom(ag_);
                        return ah_;
                    }

                    IEnumerable<CqlDate> v_ = context.Operators.Select<CqlDate, CqlDate>(h_, u_);
                    IEnumerable<CqlDate> w_ = context.Operators.Distinct<CqlDate>(v_);
                    IEnumerable<CqlDate> x_ = context.Operators.Distinct<CqlDate>(w_);
                    int? y_ = context.Operators.Count<CqlDate>(x_);
                    bool? z_ = context.Operators.GreaterOrEqual(y_, 3);
                    bool? aa_ = context.Operators.And(s_, z_);
                    bool? ab_ = context.Operators.Or(o_, aa_);
                    return ab_;
                }

                IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
                bool? d_ = context.Operators.Exists<CqlDate>(c_);
                return d_;
            });


    private Cached<IEnumerable<object>> _Hib_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<object> Hib_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Hib_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object HibReaction) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HibReaction);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<IEnumerable<CqlDate>> _Hepatitis_B_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context) =>
        _Hepatitis_B_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hepatitis_B_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization HepatitisBVaccination) {
                    DataType r_ = HepatitisBVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.First_Two_Years(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization HepatitisBVaccination) {
                    DataType x_ = HepatitisBVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Hepatitis_B_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure HepatitisBProcedure) {
                    DataType ab_ = HepatitisBProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.First_Two_Years(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure HepatitisBProcedure) {
                    DataType ah_ = HepatitisBProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Three_Hepatitis_B_Vaccinations_Cached = new();

    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context) =>
        _Three_Hepatitis_B_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);

                (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? l_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(d_, e_);

                bool? g_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) {
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
                    CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
                    CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
                    CqlDate r_ = context.Operators.DateFrom(q_);
                    CqlQuantity s_ = context.Operators.Quantity(1m, "day");
                    CqlDate t_ = context.Operators.Add(r_, s_);
                    bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
                    CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
                    CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    CqlDate ac_ = context.Operators.Add(aa_, s_);
                    bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
                    bool? ae_ = context.Operators.And(u_, ad_);
                    return ae_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(f_, g_);

                CqlDate i_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) {
                    CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
                    CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                    CqlDate ah_ = context.Operators.DateFrom(ag_);
                    return ah_;
                }

                IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(h_, i_);
                IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                return k_;
            });


    private Cached<IEnumerable<CqlDate>> _NewBorn_Vaccine_Requirement_Cached = new();

    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context) =>
        _NewBorn_Vaccine_Requirement_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> d_ = Status_1_15_000.Instance.isProcedurePerformed(context, c_);

                bool? e_(Procedure NewBornVaccine) {
                    DataType j_ = NewBornVaccine?.Performed;
                    object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                    CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_ as object);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    Patient n_ = this.Patient(context);
                    Date o_ = n_?.BirthDateElement;
                    string p_ = o_?.Value;
                    CqlDate q_ = context.Operators.ConvertStringToDate(p_);
                    CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    Date u_ = n_?.BirthDateElement;
                    string v_ = u_?.Value;
                    CqlDate w_ = context.Operators.ConvertStringToDate(v_);
                    CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    CqlQuantity z_ = context.Operators.Quantity(7m, "days");
                    CqlDate aa_ = context.Operators.Add(y_, z_);
                    CqlInterval<CqlDate> ab_ = context.Operators.Interval(s_, aa_, true, true);
                    bool? ac_ = context.Operators.In<CqlDate>(m_, ab_, "day");
                    return ac_;
                }

                IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);

                CqlDate g_(Procedure NewBornVaccine) {
                    DataType ad_ = NewBornVaccine?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_ as object);
                    CqlDate ag_ = context.Operators.DateFrom(af_);
                    return ag_;
                }

                IEnumerable<CqlDate> h_ = context.Operators.Select<Procedure, CqlDate>(f_, g_);
                IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);
                return i_;
            });


    private Cached<IEnumerable<CqlDate>> _Meets_HepB_Vaccination_Requirement_Cached = new();

    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context) =>
        _Meets_HepB_Vaccination_Requirement_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
                IEnumerable<CqlDate> c_ = this.NewBorn_Vaccine_Requirement(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, c_);

                (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? l_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(d_, e_);

                bool? g_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) {
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
                    CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
                    CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
                    CqlDate r_ = context.Operators.DateFrom(q_);
                    CqlQuantity s_ = context.Operators.Quantity(1m, "day");
                    CqlDate t_ = context.Operators.Add(r_, s_);
                    bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
                    CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    CqlDateTime y_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    CqlDate ac_ = context.Operators.Add(aa_, s_);
                    bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
                    bool? ae_ = context.Operators.And(u_, ad_);
                    CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                    CqlDate ah_ = context.Operators.DateFrom(ag_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    CqlDate am_ = context.Operators.Add(ak_, s_);
                    bool? an_ = context.Operators.SameOrAfter(ah_, am_, default);
                    bool? ao_ = context.Operators.And(ae_, an_);
                    return ao_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(f_, g_);

                CqlDate i_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) {
                    CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
                    CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                    CqlDate ar_ = context.Operators.DateFrom(aq_);
                    return ar_;
                }

                IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(h_, i_);
                IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                return k_;
            });


    private Cached<IEnumerable<object>> _Hepatitis_B_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<object> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Hepatitis_B_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                CqlValueSet h_ = this.Hepatitis_B(context);
                IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> j_ = context.Operators.Union<object>(g_ as IEnumerable<object>, i_ as IEnumerable<object>);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> m_ = context.Operators.Union<object>(j_ as IEnumerable<object>, l_ as IEnumerable<object>);
                IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);

                bool? o_(object HepBConditions) {
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepBConditions);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    CqlInterval<CqlDate> t_ = this.First_Two_Years(context);
                    bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
                    return u_;
                }

                IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
                return p_;
            });


    private Cached<IEnumerable<CqlDate>> _One_Chicken_Pox_Vaccination_Cached = new();

    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context) =>
        _One_Chicken_Pox_Vaccination_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Varicella_Zoster_Vaccine__VZV_(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization ChickenPoxVaccination) {
                    DataType r_ = ChickenPoxVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization ChickenPoxVaccination) {
                    DataType x_ = ChickenPoxVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure ChickenPoxProcedure) {
                    DataType ab_ = ChickenPoxProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure ChickenPoxProcedure) {
                    DataType ah_ = ChickenPoxProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<object>> _Varicella_Zoster_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<object> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Varicella_Zoster_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Varicella_Zoster(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                CqlCode f_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
                IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
                IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> i_ = context.Operators.Union<object>(e_ as IEnumerable<object>, h_ as IEnumerable<object>);
                IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(f_);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> m_ = context.Operators.Union<object>(i_ as IEnumerable<object>, l_ as IEnumerable<object>);
                IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);

                bool? o_(object VaricellaZoster) {
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, VaricellaZoster);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    CqlInterval<CqlDate> t_ = this.First_Two_Years(context);
                    bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
                    return u_;
                }

                IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
                return p_;
            });


    private Cached<IEnumerable<CqlDate>> _Pneumococcal_Conjugate_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context) =>
        _Pneumococcal_Conjugate_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Pneumococcal_Conjugate_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization PneumococcalVaccination) {
                    DataType r_ = PneumococcalVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization PneumococcalVaccination) {
                    DataType x_ = PneumococcalVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure PneumococcalProcedure) {
                    DataType ab_ = PneumococcalProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure PneumococcalProcedure) {
                    DataType ah_ = PneumococcalProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Four_Pneumococcal_Conjugate_Vaccinations_Cached = new();

    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context) =>
        _Four_Pneumococcal_Conjugate_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);

                (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? m_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
                    return m_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(e_, f_);

                bool? h_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) {
                    CqlDateTime n_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
                    CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    CqlDateTime q_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
                    CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    CqlQuantity t_ = context.Operators.Quantity(1m, "day");
                    CqlDate u_ = context.Operators.Add(s_, t_);
                    bool? v_ = context.Operators.SameOrAfter(p_, u_, default);
                    CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
                    CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlDate ab_ = context.Operators.DateFrom(aa_);
                    CqlDate ad_ = context.Operators.Add(ab_, t_);
                    bool? ae_ = context.Operators.SameOrAfter(y_, ad_, default);
                    bool? af_ = context.Operators.And(v_, ae_);
                    CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
                    CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
                    CqlDate ai_ = context.Operators.DateFrom(ah_);
                    CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
                    CqlDate al_ = context.Operators.DateFrom(ak_);
                    CqlDate an_ = context.Operators.Add(al_, t_);
                    bool? ao_ = context.Operators.SameOrAfter(ai_, an_, default);
                    bool? ap_ = context.Operators.And(af_, ao_);
                    return ap_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(g_, h_);

                CqlDate j_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) {
                    CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
                    CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                    CqlDate as_ = context.Operators.DateFrom(ar_);
                    return as_;
                }

                IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(i_, j_);
                IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
                return l_;
            });


    private Cached<IEnumerable<object>> _Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<object> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object PneumococcalReaction) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PneumococcalReaction);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<IEnumerable<CqlDate>> _One_Hepatitis_A_Vaccinations_Cached = new();

    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context) =>
        _One_Hepatitis_A_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hepatitis_A_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization HepatitisAVaccination) {
                    DataType r_ = HepatitisAVaccination?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization HepatitisAVaccination) {
                    DataType x_ = HepatitisAVaccination?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Hepatitis_A_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure HepatitisAProcedure) {
                    DataType ab_ = HepatitisAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure HepatitisAProcedure) {
                    DataType ah_ = HepatitisAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<object>> _Hepatitis_A_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<object> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Hepatitis_A_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hepatitis_A(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                CqlCode f_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
                IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
                IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> i_ = context.Operators.Union<object>(e_ as IEnumerable<object>, h_ as IEnumerable<object>);
                IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(f_);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> m_ = context.Operators.Union<object>(i_ as IEnumerable<object>, l_ as IEnumerable<object>);
                IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);

                bool? o_(object HepatitisADiagnosis) {
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    CqlInterval<CqlDate> t_ = this.First_Two_Years(context);
                    bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
                    return u_;
                }

                IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
                return p_;
            });


    private Cached<IEnumerable<CqlDate>> _Rotavirus_2_Dose_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context) =>
        _Rotavirus_2_Dose_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.rotavirus__live__monovalent_vaccine(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Immunization> c_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> d_ = Status_1_15_000.Instance.isImmunizationAdministered(context, c_);

                bool? e_(Immunization TwoDoseRotavirusVaccine) {
                    DataType s_ = TwoDoseRotavirusVaccine?.Occurrence;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, (t_ as CqlDateTime) as object);
                    CqlDate v_ = context.Operators.DateFrom(u_);
                    CqlInterval<CqlDate> w_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? x_ = context.Operators.In<CqlDate>(v_, w_, "day");
                    return x_;
                }

                IEnumerable<Immunization> f_ = context.Operators.Where<Immunization>(d_, e_);

                CqlDate g_(Immunization TwoDoseRotavirusVaccine) {
                    DataType y_ = TwoDoseRotavirusVaccine?.Occurrence;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, (z_ as CqlDateTime) as object);
                    CqlDate ab_ = context.Operators.DateFrom(aa_);
                    return ab_;
                }

                IEnumerable<CqlDate> h_ = context.Operators.Select<Immunization, CqlDate>(f_, g_);
                IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);
                CqlValueSet j_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
                IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> l_ = Status_1_15_000.Instance.isProcedurePerformed(context, k_);

                bool? m_(Procedure TwoDoseRotavirusProcedure) {
                    DataType ac_ = TwoDoseRotavirusProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_ as object);
                    CqlDate af_ = context.Operators.DateFrom(ae_);
                    CqlInterval<CqlDate> ag_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ah_ = context.Operators.In<CqlDate>(af_, ag_, "day");
                    return ah_;
                }

                IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);

                CqlDate o_(Procedure TwoDoseRotavirusProcedure) {
                    DataType ai_ = TwoDoseRotavirusProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_ as object);
                    CqlDate al_ = context.Operators.DateFrom(ak_);
                    return al_;
                }

                IEnumerable<CqlDate> p_ = context.Operators.Select<Procedure, CqlDate>(n_, o_);
                IEnumerable<CqlDate> q_ = context.Operators.Distinct<CqlDate>(p_);
                IEnumerable<CqlDate> r_ = context.Operators.Union<CqlDate>(i_, q_);
                return r_;
            });


    private Cached<IEnumerable<CqlDate>> _Rotavirus_3_Dose_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context) =>
        _Rotavirus_3_Dose_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization ThreeDoseRotavirusVaccine) {
                    DataType r_ = ThreeDoseRotavirusVaccine?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization ThreeDoseRotavirusVaccine) {
                    DataType x_ = ThreeDoseRotavirusVaccine?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure ThreeDoseRotavirusAdministered) {
                    DataType ab_ = ThreeDoseRotavirusAdministered?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure ThreeDoseRotavirusAdministered) {
                    DataType ah_ = ThreeDoseRotavirusAdministered?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Rotavirus_2_or_3_Dose_Immunizations_Cached = new();

    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context) =>
        _Rotavirus_2_or_3_Dose_Immunizations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
                IEnumerable<CqlDate> b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
                IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);
                return c_;
            });


    private Cached<bool?> _Has_Appropriate_Number_of_Rotavirus_Immunizations_Cached = new();

    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context) =>
        _Has_Appropriate_Number_of_Rotavirus_Immunizations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);

                bool? b_(CqlDate RotavirusImmunization) {
                    IEnumerable<CqlDate> e_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
                    int? f_ = context.Operators.Count<CqlDate>(e_);
                    bool? g_ = context.Operators.Greater(f_, 0);
                    IEnumerable<CqlDate> h_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);

                    CqlDate i_(CqlDate RotavirusVaccinations) {
                        CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                        CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
                        CqlDate ae_ = context.Operators.DateFrom(ad_);
                        return ae_;
                    }

                    IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
                    IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                    IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
                    int? m_ = context.Operators.Count<CqlDate>(l_);
                    bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
                    bool? o_ = context.Operators.And(g_, n_);
                    int? q_ = context.Operators.Count<CqlDate>(e_);
                    bool? r_ = context.Operators.Greater(q_, 0);
                    bool? s_ = context.Operators.IsFalse(r_);

                    CqlDate u_(CqlDate RotavirusVaccinations) {
                        CqlDateTime af_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                        CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                        CqlDate ah_ = context.Operators.DateFrom(ag_);
                        return ah_;
                    }

                    IEnumerable<CqlDate> v_ = context.Operators.Select<CqlDate, CqlDate>(h_, u_);
                    IEnumerable<CqlDate> w_ = context.Operators.Distinct<CqlDate>(v_);
                    IEnumerable<CqlDate> x_ = context.Operators.Distinct<CqlDate>(w_);
                    int? y_ = context.Operators.Count<CqlDate>(x_);
                    bool? z_ = context.Operators.GreaterOrEqual(y_, 2);
                    bool? aa_ = context.Operators.And(s_, z_);
                    bool? ab_ = context.Operators.Or(o_, aa_);
                    return ab_;
                }

                IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
                bool? d_ = context.Operators.Exists<CqlDate>(c_);
                return d_;
            });


    private Cached<IEnumerable<object>> _Rotavirus_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<object> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Rotavirus_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_rotavirus_vaccine__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object RotavirusConditions) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RotavirusConditions);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<CqlInterval<CqlDate>> _Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Cached = new();

    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context) =>
        _Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlDate f_ = context.Operators.DateFrom(e_);
                CqlQuantity g_ = context.Operators.Quantity(180m, "days");
                CqlDate h_ = context.Operators.Add(f_, g_);
                CqlDate i_ = this.Date_of_Second_Birthday(context);
                CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);
                return j_;
            });


    private Cached<IEnumerable<CqlDate>> _Influenza_Immunizations_or_Procedures_Cached = new();

    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context) =>
        _Influenza_Immunizations_or_Procedures_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Child_Influenza_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization InfluenzaVaccine) {
                    DataType r_ = InfluenzaVaccine?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
                    bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");
                    return w_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization InfluenzaVaccine) {
                    DataType x_ = InfluenzaVaccine?.Occurrence;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, (y_ as CqlDateTime) as object);
                    CqlDate aa_ = context.Operators.DateFrom(z_);
                    return aa_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Child_Influenza_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure InfluenzaAdministration) {
                    DataType ab_ = InfluenzaAdministration?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_ as object);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
                    bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");
                    return ag_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure InfluenzaAdministration) {
                    DataType ah_ = InfluenzaAdministration?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_ as object);
                    CqlDate ak_ = context.Operators.DateFrom(aj_);
                    return ak_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<IEnumerable<CqlDate>> _Two_Influenza_Vaccinations_Cached = new();

    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context) =>
        _Two_Influenza_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Influenza_Immunizations_or_Procedures(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);

                (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? k_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);
                    return k_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(c_, d_);

                bool? f_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) {
                    CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
                    CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
                    CqlDate n_ = context.Operators.DateFrom(m_);
                    CqlDateTime o_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
                    CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
                    CqlDate q_ = context.Operators.DateFrom(p_);
                    CqlQuantity r_ = context.Operators.Quantity(1m, "day");
                    CqlDate s_ = context.Operators.Add(q_, r_);
                    bool? t_ = context.Operators.SameOrAfter(n_, s_, default);
                    return t_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(e_, f_);

                CqlDate h_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) {
                    CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
                    CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
                    CqlDate w_ = context.Operators.DateFrom(v_);
                    return w_;
                }

                IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(g_, h_);
                IEnumerable<CqlDate> j_ = context.Operators.Distinct<CqlDate>(i_);
                return j_;
            });


    private Cached<IEnumerable<CqlDate>> _LAIV_Vaccinations_Cached = new();

    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context) =>
        _LAIV_Vaccinations_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Influenza_Virus_LAIV_Vaccine(context);
                IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
                IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

                bool? d_(Immunization LAIVVaccine) {
                    DataType r_ = LAIVVaccine?.Occurrence;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, (s_ as CqlDateTime) as object);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlDate v_ = this.Date_of_Second_Birthday(context);
                    CqlInterval<CqlDate> x_ = context.Operators.Interval(v_, v_, true, true);
                    bool? y_ = context.Operators.In<CqlDate>(u_, x_, "day");
                    return y_;
                }

                IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);

                CqlDate f_(Immunization LAIVVaccine) {
                    DataType z_ = LAIVVaccine?.Occurrence;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, (aa_ as CqlDateTime) as object);
                    CqlDate ac_ = context.Operators.DateFrom(ab_);
                    return ac_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                CqlValueSet i_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
                IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

                bool? l_(Procedure InfluenzaAdministration) {
                    DataType ad_ = InfluenzaAdministration?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_ as object);
                    CqlDate ag_ = context.Operators.DateFrom(af_);
                    CqlDate ah_ = this.Date_of_Second_Birthday(context);
                    CqlInterval<CqlDate> aj_ = context.Operators.Interval(ah_, ah_, true, true);
                    bool? ak_ = context.Operators.In<CqlDate>(ag_, aj_, "day");
                    return ak_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);

                CqlDate n_(Procedure InfluenzaAdministration) {
                    DataType al_ = InfluenzaAdministration?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_ as object);
                    CqlDate ao_ = context.Operators.DateFrom(an_);
                    return ao_;
                }

                IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
                IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
                IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);
                return q_;
            });


    private Cached<bool?> _Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Cached = new();

    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context) =>
        _Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.LAIV_Vaccinations(context);
                bool? b_ = context.Operators.Exists<CqlDate>(a_);
                IEnumerable<CqlDate> c_ = this.Influenza_Immunizations_or_Procedures(context);
                bool? d_ = context.Operators.Exists<CqlDate>(c_);
                bool? e_ = context.Operators.And(b_, d_);
                return e_;
            });


    private Cached<IEnumerable<object>> _Influenza_Numerator_Inclusion_Conditions_Cached = new();

    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<object> Influenza_Numerator_Inclusion_Conditions(CqlContext context) =>
        _Influenza_Numerator_Inclusion_Conditions_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
                IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

                bool? i_(object InfluenzaConditions) {
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InfluenzaConditions);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDate> n_ = this.First_Two_Years(context);
                    bool? o_ = context.Operators.In<CqlDate>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                return j_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Four_DTaP_Vaccinations(context);
                bool? b_ = context.Operators.Exists<CqlDate>(a_);
                IEnumerable<object> c_ = this.DTaP_Numerator_Inclusion_Conditions(context);
                bool? d_ = context.Operators.Exists<object>(c_);
                bool? e_ = context.Operators.Or(b_, d_);
                IEnumerable<CqlDate> f_ = this.Three_Polio_Vaccinations(context);
                bool? g_ = context.Operators.Exists<CqlDate>(f_);
                IEnumerable<object> h_ = this.Polio_Numerator_Inclusion_Conditions(context);
                bool? i_ = context.Operators.Exists<object>(h_);
                bool? j_ = context.Operators.Or(g_, i_);
                bool? k_ = context.Operators.And(e_, j_);
                IEnumerable<CqlDate> l_ = this.One_MMR_Vaccination(context);
                bool? m_ = context.Operators.Exists<CqlDate>(l_);
                IEnumerable<object> n_ = this.MMR_Numerator_Inclusion_Conditions(context);
                bool? o_ = context.Operators.Exists<object>(n_);
                bool? p_ = context.Operators.Or(m_, o_);
                IEnumerable<object> q_ = this.Measles_Indicators(context);
                bool? r_ = context.Operators.Exists<object>(q_);
                IEnumerable<object> s_ = this.Mumps_Indicators(context);
                bool? t_ = context.Operators.Exists<object>(s_);
                bool? u_ = context.Operators.And(r_, t_);
                IEnumerable<object> v_ = this.Rubella_Indicators(context);
                bool? w_ = context.Operators.Exists<object>(v_);
                bool? x_ = context.Operators.And(u_, w_);
                bool? y_ = context.Operators.Or(p_, x_);
                bool? z_ = context.Operators.And(k_, y_);
                bool? aa_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
                IEnumerable<object> ab_ = this.Hib_Numerator_Inclusion_Conditions(context);
                bool? ac_ = context.Operators.Exists<object>(ab_);
                bool? ad_ = context.Operators.Or(aa_, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                IEnumerable<CqlDate> af_ = this.Three_Hepatitis_B_Vaccinations(context);
                bool? ag_ = context.Operators.Exists<CqlDate>(af_);
                IEnumerable<CqlDate> ah_ = this.Meets_HepB_Vaccination_Requirement(context);
                bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
                IEnumerable<object> aj_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
                bool? ak_ = context.Operators.Exists<object>(aj_);
                bool? al_ = context.Operators.Or(ai_, ak_);
                bool? am_ = context.Operators.Or(ag_, al_);
                bool? an_ = context.Operators.And(ae_, am_);
                IEnumerable<CqlDate> ao_ = this.One_Chicken_Pox_Vaccination(context);
                bool? ap_ = context.Operators.Exists<CqlDate>(ao_);
                IEnumerable<object> aq_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
                bool? ar_ = context.Operators.Exists<object>(aq_);
                bool? as_ = context.Operators.Or(ap_, ar_);
                bool? at_ = context.Operators.And(an_, as_);
                IEnumerable<CqlDate> au_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
                bool? av_ = context.Operators.Exists<CqlDate>(au_);
                IEnumerable<object> aw_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
                bool? ax_ = context.Operators.Exists<object>(aw_);
                bool? ay_ = context.Operators.Or(av_, ax_);
                bool? az_ = context.Operators.And(at_, ay_);
                IEnumerable<CqlDate> ba_ = this.One_Hepatitis_A_Vaccinations(context);
                bool? bb_ = context.Operators.Exists<CqlDate>(ba_);
                IEnumerable<object> bc_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
                bool? bd_ = context.Operators.Exists<object>(bc_);
                bool? be_ = context.Operators.Or(bb_, bd_);
                bool? bf_ = context.Operators.And(az_, be_);
                bool? bg_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
                IEnumerable<object> bh_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
                bool? bi_ = context.Operators.Exists<object>(bh_);
                bool? bj_ = context.Operators.Or(bg_, bi_);
                bool? bk_ = context.Operators.And(bf_, bj_);
                IEnumerable<CqlDate> bl_ = this.Two_Influenza_Vaccinations(context);
                bool? bm_ = context.Operators.Exists<CqlDate>(bl_);
                bool? bn_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
                bool? bo_ = context.Operators.Or(bm_, bn_);
                IEnumerable<object> bp_ = this.Influenza_Numerator_Inclusion_Conditions(context);
                bool? bq_ = context.Operators.Exists<object>(bp_);
                bool? br_ = context.Operators.Or(bo_, bq_);
                bool? bs_ = context.Operators.And(bk_, br_);
                return bs_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ = new(
       [typeof(CqlDate), typeof(CqlDate)],
       ["FluVaccination1", "FluVaccination2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["PolioVaccination1", "PolioVaccination2", "PolioVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["PneumococcalVaccination1", "PneumococcalVaccination2", "PneumococcalVaccination3", "PneumococcalVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["DTaPVaccination1", "DTaPVaccination2", "DTaPVaccination3", "DTaPVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["HepatitisBVaccination1", "HepatitisBVaccination2", "HepatitisBVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["HepatitisBVaccination1", "HepatitisBVaccination2", "NewBornVaccine3"]);

    #endregion CqlTupleMetadata Properties

}
