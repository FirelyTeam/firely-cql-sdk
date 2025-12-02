/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;
using Hl7.Cql.Toolkit;

namespace CqlSdkExamples;

partial class Program
{
    void SupportCMS69PCSBMIScreenAndFollowUpQDM()
    {
        // This example first packages CQL libraries into FHIR resources,
        // then loads the packaged resources and invokes them.

        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "900 Support CMS69PCSBMIScreenAndFollowUpQDM_14_0_000"));

        // Switch to project directory
        var lastPart = new DirectoryInfo(Environment.CurrentDirectory).Name;
        Environment.CurrentDirectory = Path.Combine(ProjectDirectory, lastPart);

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Elm files extracted from zip file linked in https://ecqi.healthit.gov/ecqm/ec/2026/cms0068v15?qt-tabs_measure=specifications-and-data-elements
        var elmDir = new DirectoryInfo("elm");
        var dllDir = new DirectoryInfo("dll");
        var resDir = new DirectoryInfo("res");

        BuildDllsIfNeeded(
            loggerFactory,
            elmDir,
            dllDir);

        Run(
            loggerFactory,
            dllDir);
    }

    private static void Run(
        ILoggerFactory loggerFactory,
        DirectoryInfo dllDir)
    {
        var librarySetInvoker = new InvocationToolkit(loggerFactory)
                                .AddAssemblyBinaryFilesFromDirectory(directory: dllDir)
                                .CreateLibrarySetInvoker();

        IDictionary<string, object> dicData =
            new Dictionary<string, object>
            {
                {
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        new CqlDateTime(2024, 1, 1, 0, 0, 0, 0, 0, 0),
                        new CqlDateTime(2024, 12, 31, 0, 0, 0, 0, 0, 0),
                        true,
                        true)
                }
            };
        Bundle bundle = BuildPatient69Bundle();
        CqlContext context = CreateContextcms69(bundle, dicData);
        //LibrarySetInvokerExtensions.
        var results =
            string.Join(Environment.NewLine,
            librarySetInvoker
                 .SetIgnoreEnumerationExceptions()
                 .SelectExpressions()
                 .SelectResults(context)
                 .Select(r => $"{r.definitionInvoker} = {JsonSerializer.Serialize(r.invocationResult)}")
                 );
    }

    static CqlContext CreateContextcms69(
        Bundle bundle,
        IDictionary<string, object> dicData)
    {
        Dictionary<string, object>? parameters;

        parameters = new Dictionary<string, object>
        {
            ["Measurement Period"] = new CqlInterval<CqlDateTime>(
           new CqlDateTime(2025, 1, 1, 0, 0, 0, 0, 0, 0),
           new CqlDateTime(2025, 12, 31, 23, 59, 59, 0, 0, 0),
           true, true
           //inclusiveStart: true,
           //inclusiveEnd: true
           )
        };
        //    var valueSets = new InMemoryValueSetDictionary();

        //    // Example: add one test VS for CMS69
        //    valueSets.Add(
        //        id: "EncounterToAssessBMI",   // must match the id/url used in the CQL
        //        version: null,
        //        codes: new[]
        //        {
        //new CqlCode("99213", "2.16.840.1.113883.6.12", null, null),
        //            // add more codes
        //        });
        FhirCqlContextOptions fhirCqlContextOptions = new FhirCqlContextOptions()
        {

        };

        var valueSets = new InMemoryValueSetDictionary();
        // Example: encounter value set containing office visits
        // id must match the value set name/identifier in your CMS69 CQL.
        valueSets.Add(
            id: "urn:oid:2.16.840.1.113883.3.600.1.1751", // FIX to match your CQL/ELM EncounterToAssessBMI18AndOlder
            version: null,
            codes: new[]
            {
                    new CqlCode("99213", "http://www.ama-assn.org/go/cpt", null, null),//2.16.840.1.113883.6.12
                    new CqlCode("99214", "http://www.ama-assn.org/go/cpt", null, null)
            });
        // 2) Physical Exam / Observation: "BMI LOINC Value"
        valueSets.Add(
            id: "urn:oid:2.16.840.1.113883.3.600.1.681",
            version: null,
            codes: new[]
            {
        // BMI LOINC used in your bundle
        new CqlCode("39156-5", "http://loinc.org", null, null),
            });
        //// Example: BMI observation value set (if measure uses a BMI VS explicitly)
        //valueSets.Add(
        //     id: "BMI", // again, match your CQL's value set id/url
        //    version: null,
        //    codes: new[]
        //    {
        //        new CqlCode("39156-5", "http://loinc.org", null, null)
        //    });



        //valueSets.Add(
        //    id: "EncounterToAssessBMI",
        //    version: null,
        //    codes: new[]
        //    {
        //        new CqlCode("99213", "2.16.840.1.113883.6.12", null, null)
        //    });
        var ctx = FhirCqlContext.ForBundle(bundle, dicData, valueSets, null, fhirCqlContextOptions);


        // This is the Firely helper that ties Bundle + parameters into the engine.
        //return FhirCqlContext.ForBundle(bundle, dicData);
        return ctx;
    }

    private void BuildDllsIfNeeded(
        ILoggerFactory loggerFactory,
        DirectoryInfo elmDir,
        DirectoryInfo dllDir)
    {
        if (dllDir.Exists
            && dllDir.EnumerateFiles("*.dll").Any())
        {
            loggerFactory
                .CreateLogger<Program>()
                .LogInformation("DLLs already exist, skipping CQL to DLL compilation.");
            return;
        }


        _ = new ElmToolkit(
                loggerFactory,
                config: new()
                {
                    DebugSymbolsFormat = DebugSymbolsFormat.Embedded // Include debug symbols for stepping through code during debugging
                },
                batchProcessExceptionContinuation: BatchProcessExceptionContinuation.Continue)
            .AddElmFilesFromDirectory(elmDir)
            .CompileToAssemblies()
            .SaveAssemblyBinariesToDirectory(dllDir);
    }


    static Bundle BuildPatient69Bundle()
    {
        // -----------------------------
        // Patient: "1 N GP Adult"
        // -----------------------------
        var patient = new Patient
        {
            Id = "pat1",
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Text = "1 N GP Adult",
                    Family = "GP",
                    Given = new[] { "1", "N" }
                }
            },
            Gender = AdministrativeGender.Female,
            // QDM birthDateTime: 1981-01-13T17:15:00+00:00
            BirthDate = "1981-01-13",
            Address = new List<Address>
            {
                new Address
                {
                    Line = new[] { "202 Burlington Rd." },
                    City = "Bedford",
                    State = "MA",
                    PostalCode = "01730",
                    Country = "US"
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint
                {
                    System = ContactPoint.ContactPointSystem.Phone,
                    Use = ContactPoint.ContactPointUse.Home,
                    Value = "555-555-2003"
                }
            }
        };

        // Race & Ethnicity extensions (from screenshot)
        patient.Extension = new List<Extension>
        {
            // Race: 1002-5 American Indian or Alaska Native (CDCREC)
            new Extension
            {
                Url = "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race",
                Value = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding("urn:oid:2.16.840.1.113883.6.238", "1002-5", "American Indian or Alaska Native")
                    }
                }
            },
            // Ethnicity: 2135-2 Hispanic or Latino
            new Extension
            {
                Url = "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity",
                Value = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding("urn:oid:2.16.840.1.113883.6.238", "2135-2", "Hispanic or Latino")
                    }
                }
            }
        };

        // -------------------------------------
        // Coverage / Payer: 1 - MEDICARE
        // (QDM::PatientCharacteristicPayer)
        // -------------------------------------
        var coverage = new Coverage
        {
            Id = "cov1",
            Status = FinancialResourceStatusCodes.Active,
            Beneficiary = new ResourceReference("Patient/pat1"),
            Type = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    // Source of Payment Typology: 1 - MEDICARE
                    new Coding(
                        "urn:oid:2.16.840.1.113883.3.221.5",
                        "1",
                        "MEDICARE")
                }
            },
            Period = new Period
            {
                // From screenshot: Relevant Period Start ~ 1981-01-17T17:15:00Z
                Start = "1981-01-17T17:15:00Z"
            }
        };

        // ------------------------------------------------------
        // Encounter 1: Encounter to Evaluate BMI (CPT 99203)
        // Time: 2024-05-31T08:00:00Z – 08:15:00Z
        // ------------------------------------------------------
        var enc1 = new Encounter
        {
            Id = "enc1",
            Status = Encounter.EncounterStatus.Finished,
            Class = new Coding(
                "http://terminology.hl7.org/CodeSystem/v3-ActCode",
                "AMB",
                "ambulatory"),
            Type = new List<CodeableConcept>
            {
                new CodeableConcept(
                    "http://www.ama-assn.org/go/cpt",
                    "99203",
                    "Office or other outpatient visit for the evaluation and management of a new patient",
                    null)
            },
            Subject = new ResourceReference("Patient/pat1"),
            Period = new Period
            {
                Start = "2024-05-31T08:00:00Z",
                End = "2024-05-31T08:15:00Z"
            }
        };

        // ------------------------------------------------------
        // Encounter 2: Encounter to Evaluate BMI (CPT 99213)
        // Time: 2024-08-03T08:00:00Z – 08:30:00Z
        // (this encounter has the BMI + follow-up)
        // ------------------------------------------------------
        var enc2 = new Encounter
        {
            Id = "enc2",
            Status = Encounter.EncounterStatus.Finished,
            Class = new Coding(
                "http://terminology.hl7.org/CodeSystem/v3-ActCode",
                "AMB",
                "ambulatory"),
            Type = new List<CodeableConcept>
            {
                new CodeableConcept(
                    "http://www.ama-assn.org/go/cpt",
                    "99213",
                    "Office or other outpatient visit for the evaluation and management of an established patient",
                    null)
            },
            Subject = new ResourceReference("Patient/pat1"),
            Period = new Period
            {
                Start = "2024-08-03T08:00:00Z",
                End = "2024-08-03T08:30:00Z"
            }
        };

        // ------------------------------------------------------
        // InterventionOrder: Follow Up for Above Normal BMI
        // Codes: HCPCS S9451 + SNOMED 304549008
        // Reason: SNOMED 162863004 (BMI 25–29 overweight)
        // Author Date: 2024-08-03T08:00:00Z
        // ------------------------------------------------------
        var followUp = new ServiceRequest
        {
            Id = "srv-followup",
            Status = RequestStatus.Active,
            Intent = RequestIntent.Plan,
            Subject = new ResourceReference("Patient/pat1"),
            Encounter = new ResourceReference("Encounter/enc2"),
            AuthoredOnElement = new FhirDateTime("2024-08-03T08:00:00Z"),
            Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding("http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets", "S9451",
                               "Exercise classes, non-physician provider, per session"),
                    new Coding("http://snomed.info/sct", "304549008",
                               "Giving encouragement to exercise (procedure)")
                }
            },
            ReasonCode = new List<CodeableConcept>
            {
                new CodeableConcept(
                    "http://snomed.info/sct",
                    "162863004",
                    "Body mass index 25-29 - overweight (finding)",
                    null)
            }
        };

        // ------------------------------------------------------
        // PhysicalExamPerformed: BMI
        // LOINC 39156-5, Result = 30 kg/m2
        // Relevant DateTime: 2024-08-03T08:00:00Z
        // ------------------------------------------------------
        var bmiObs = new Observation
        {
            Id = "obs-bmi",
            Status = ObservationStatus.Final,
            Code = new CodeableConcept(
                "http://loinc.org",
                "39156-5",
                "Body mass index (BMI) [Ratio]",
                ""),
            Subject = new ResourceReference("Patient/pat1"),
            Effective = new FhirDateTime("2024-08-03T08:00:00Z"),
            Value = new Quantity(30m, "kg/m2"),
            Encounter = new ResourceReference("Encounter/enc2")
        };

        // -------------------------
        // Build the Bundle
        // -------------------------
        var bundle = new Bundle
        {
            Type = Bundle.BundleType.Collection
        };

        void Add(Resource r) =>
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = r });

        Add(patient);
        Add(coverage);
        Add(enc1);
        Add(enc2);
        Add(followUp);
        Add(bmiObs);

        return bundle;
    }
}