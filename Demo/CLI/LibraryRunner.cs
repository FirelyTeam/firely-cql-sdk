/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CLI.Helpers;
using Dumpify;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace CLI
{
    internal class LibraryRunner
    {
        private readonly CommandLineOptions _opts;
        private readonly StreamWriter? _writer;

        public LibraryRunner(CommandLineOptions options)
        {
            _opts = options;
            if (!string.IsNullOrEmpty(_opts.OutputFile))
            {
                _writer = new StreamWriter(options.OutputFile, true);
            }
        }

        public void RunWithMeasuresProject()
        {
            //used for debugging with breakpoints in Measures.* project
            //if used in production scenario compile measures.* dll and reference it below instead, example Assembly.LoadFrom("Measures.Authoring")
            //see launchsettings.json
            var assemblyBinary = AssemblyBinary.Default.LoadFromFile(new FileInfo(_opts.AssemblyPath));
            using var librarySetInvoker = new InvocationToolkit()
                      .AddAssemblyBinaries(assemblyBinary)
                      .CreateLibrarySetInvoker();
            RunShared(_opts, librarySetInvoker);
        }

        public void RunWithResources()
        {
            //run using Library Resource files - production scenario, no debugging inline with measures project
            Console.WriteLine($"Loading resources for Library: {_opts.Library}");
            var libraryIdentifier = _opts.LibraryIdentifier;
            using var librarySetInvoker = new InvocationToolkit()
                                          .AddAssemblyBinariesFromFhirLibraryAndDependencies(libraryIdentifier, ResourceFileInfoResolvers.FromDirectory(new(_opts.ResourcesDirectory)))
                                          .CreateLibrarySetInvoker(libraryIdentifier);
            RunShared(_opts, librarySetInvoker);
        }

        private void RunShared(CommandLineOptions opt, LibrarySetInvoker librarySetInvoker)
        {
            Console.WriteLine("Loading value sets");
            IValueSetDictionary valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetsDirectory));

            Console.WriteLine("Loading test case files");
            var testDataDir = Path.Join(opt.DataDirectory, (string)opt.LibraryIdentifier.Identifier);
            var patientList = ProcessTestPatients(testDataDir, librarySetInvoker, valueSets);
            //optionally use patientList Dictionary
        }

        #region Processing Patients
        private Dictionary<string, Dictionary<string, object>> ProcessTestPatients(
            string testDataDir,
            LibrarySetInvoker librarySetInvoker,
            IValueSetDictionary valueSets)
        {
            var patientList = new Dictionary<string, Dictionary<string, object>>();
            var testPatients = Directory.EnumerateDirectories(testDataDir);

            //TODO: research test parameter location relative to test data files in vs-code tool
            //try top level input, but will use input if found later in patient directory
            IDictionary<string, object> inputParameters = new Dictionary<string, object>();
            var inputParameterFile = @"InputParameters.json";
            string[] filesToSkip = { $"{inputParameterFile}" }; // Add more files as needed
            var inputlocationTop = Path.Combine(testDataDir, inputParameterFile);
            if (File.Exists(inputlocationTop))
            {
                inputParameters = ResourceHelper.LoadInputParameters(inputlocationTop);
            }

            foreach (var testPatient in testPatients)
            {
                testPatient.DumpConsole("PatientID");

                var inputLocation = Path.Combine(testPatient, inputParameterFile);
                if (File.Exists(inputLocation))
                {
                    inputParameters = ResourceHelper.LoadInputParameters(inputLocation);
                }

                //testPatient represents the path of a single patient.
                //There can only be 1 bundle OR multiple FHIR resources.
                //This logic can be improved, but is good for demoing for now.
                var filesInPatientDir = Directory
                    .EnumerateFiles(testPatient, "*.json", SearchOption.AllDirectories)
                    .Where(file => !filesToSkip.Contains(Path.GetFileName(file)))
                    .ToArray();

                if (filesInPatientDir.Length == 0)
                {
                    Console.WriteLine($"Directory {testPatient} is empty");
                    continue;
                }

                var results = ProcessPatientFiles(librarySetInvoker, testPatient, filesInPatientDir, inputParameters, valueSets);
                patientList.Add(testPatient, results);

            }

            return patientList;
        }


        private Dictionary<string, object> ProcessPatientFiles(
            LibrarySetInvoker librarySetInvoker, string testPatient, string[] filesInPatientDir, IDictionary<string, object> inputParameters, IValueSetDictionary valueSets)
        {
            if (filesInPatientDir.Length == 1)
            {
                string firstFileFromDirectory = filesInPatientDir[0];
                Console.WriteLine("Loading test case bundle");
                try
                {
                    Bundle patientBundle = ResourceHelper.LoadBundle(firstFileFromDirectory);
                    Console.WriteLine($"Checking first file in directory {testPatient}: {firstFileFromDirectory}");
                    var result = ProcessBundle(librarySetInvoker, testPatient, patientBundle, inputParameters, valueSets);
                    return result;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    Console.WriteLine($"Trying to add bundle wrapper to {firstFileFromDirectory}");
                }
            }

            var createdBundle = ResourceHelper.CreateBundle(filesInPatientDir);
            return ProcessBundle(librarySetInvoker, testPatient, createdBundle, inputParameters, valueSets);
        }

        public Dictionary<string, object> ProcessBundle(LibrarySetInvoker librarySetInvoker, string testPatient, Bundle patientBundle, IDictionary<string, object>? inputParameters, IValueSetDictionary valueSets)
        {
            Console.WriteLine("Setting up CQL context");
            CqlContext setup = FhirCqlContext.ForBundle(patientBundle, inputParameters, valueSets);
            Dictionary<string, object> values = new Dictionary<string, object>();
            Dictionary<string, Exception> errors = new Dictionary<string, Exception>();

            // Get expressions from the library set (excluding functions for simplicity in demo)
            librarySetInvoker.LibraryInvokers.TryGetValue(_opts.LibraryIdentifier, out var libraryInvoker);
            var expressions = libraryInvoker!.SelectExpressions().ToList();

            // Invoke all expressions and collect results
            var results = expressions.SelectResults(setup, new SelectResultsOptions(
                InvocationExceptionCallback: (definition, exception, _) =>
                {
                    var errorKey = $"{definition.LibraryInvoker.LibraryIdentifier.Identifier}-{definition.DefinitionSignature.Name}";
                    errors.TryAdd(errorKey, exception);
                }
            )).ToList();

            // Process successful results
            foreach (var (definitionInvoker, invocationResult) in results)
            {
                // Use library identifier and definition name to create unique key
                var declName = $"{definitionInvoker.LibraryInvoker.LibraryIdentifier.Identifier}-{definitionInvoker.DefinitionSignature.Name}";
                Console.WriteLine($"Running definition: {definitionInvoker.DefinitionSignature.Name}");

                // Use TryAdd to avoid duplicate key exceptions
                if (!values.TryAdd(declName, invocationResult!))
                {
                    Console.WriteLine($"Warning: Duplicate definition {declName} skipped.");
                    continue;
                }

                var json2 = JsonSerializer.Serialize(invocationResult, new JsonSerializerOptions().ForFhir(new FhirJsonPocoDeserializerSettings { Validator = null }));
                Console.WriteLine($"{definitionInvoker.DefinitionSignature.Name} : {json2} \n");
            }

            Console.WriteLine($"Results: {errors.Count} error(s), {values.Count} value(s)");
            errors.DumpConsole("Errors");
            values.DumpConsole("Values");
            WriteResults(testPatient, values);
            return values;
        }
        #endregion Processing Patients

        #region Writing Output
        private void WriteResults(string testPatient, Dictionary<string, object> patientResults)
        {
            if (string.IsNullOrEmpty(_opts.OutputFile))
            {
                Console.WriteLine("No output file defined.");
                return;
            }

            switch (_opts.ResultsType)
            {
                case ResultsType.Text:
                    WriteResultsAsText(testPatient, patientResults);
                    break;
                case ResultsType.Ndjson:
                    WriteResultsAsNdjson(testPatient, patientResults);
                    break;
                default:
                    Console.WriteLine("No results type defined.");
                    break;
            }
        }

        private void WriteResultsAsText(string testPatient, Dictionary<string, object> patientResults)
        {
            _writer?.WriteLine(testPatient);
            WritePatientResults(patientResults);
            _writer?.WriteLine();
            _writer?.Flush();
        }

        private void WriteResultsAsNdjson(string testPatient, Dictionary<string, object> patientResults)
        {
            patientResults.Add("SourceFile", testPatient);
            var json = JsonSerializer.Serialize(patientResults, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));
            _writer?.WriteLine(json);
            _writer?.Flush();
        }

        private void WritePatientResults(Dictionary<string, object> patientResults)
        {
            foreach (var result in patientResults)
            {
                var json = JsonSerializer.Serialize(result.Value, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));
                _writer?.WriteLine($"{result.Key} : {json}");
            }
        }
        #endregion Writing Output
    }
}
