using CLI.Helpers;
using Dumpify;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.FhirPath.Sprache;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace CLI
{
    internal class LibraryRunner
    {
        private readonly CommandLineOptions _opts;
        private readonly StreamWriter _writer;     

        public LibraryRunner(CommandLineOptions options)
        {
            _opts = options;
            _writer = new StreamWriter(options.OutputFile, true);

        }
        
        public void RunWithMeasuresProject()
        {
            //used for debugging with breakpoints in Measures.* project
            //if used in production scenario compile measures.* dll and reference it below instead, example Assembly.LoadFrom("Measures.Authoring")
            //see launchsettings.json
            var assembly = Assembly.LoadFrom(_opts.AssemblyPath);
            RunShared(_opts, assembly!);
        }

        public void RunWithResources()
        {
            //run using Library Resource files - production scenario, no debugging inline with measures project
            var libNameAndVersion = $"{_opts.Library}";
            Console.WriteLine($"Loading resources for Library: {libNameAndVersion}");

            var resources = ResourceHelper.LoadResources(new(_opts.ResourcesDirectory), _opts.LibraryName, _opts.LibraryVersion);
            var assembly = resources.Assemblies.FirstOrDefault(a =>
            {
                var asmName = a.GetName().Name;
                var isMatch = asmName == libNameAndVersion;
                return isMatch;
            });
            if (assembly == null)
                throw new InvalidOperationException($"Cannot find assembly '{libNameAndVersion}' in the resources.");

            RunShared(_opts, assembly);
        }
        private void RunShared(CommandLineOptions opt, Assembly assembly)
        {
            Type libraryType = ResolveLibraryType(opt, assembly) ?? throw new ArgumentException($"Unknown library: {opt.Library}");

            Console.WriteLine("Loading value sets");
            IValueSetDictionary valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetsDirectory));

            ValidateValueSets(libraryType, valueSets, opt.Library);

            Console.WriteLine("Loading test case files");
            var testDataDir = Path.Join(opt.DataDirectory, opt.LibraryName);
            var patientList = ProcessTestPatients(testDataDir, libraryType, valueSets);
            //optionally use patientList Dictionary
        }
        private Type? ResolveLibraryType(CommandLineOptions opt, Assembly assembly)
        {
            Console.WriteLine("Resolving library type from assemblies");
            var type = assembly
                .GetTypes()
                .SingleOrDefault(t =>
                {
                    var libAttr = t.GetCustomAttribute<CqlLibraryAttribute>(false);
                    var isMatch =
                        libAttr is
                        {
                            Identifier: { } libId,
                            Version: { } libVer
                        }
                        && string.Equals(libId, opt.LibraryName, StringComparison.OrdinalIgnoreCase)
                        && string.Equals(libVer, opt.LibraryVersion, StringComparison.OrdinalIgnoreCase);
                    return isMatch;
                });
            if (type == null) throw new InvalidOperationException($"Cannot find library type for {opt.Library}");

            Console.WriteLine($"Resolved library type: {type.AssemblyQualifiedName}");
            return type;
        }

        private void ValidateValueSets(Type libraryType, IValueSetDictionary valueSets, string libraryName)
        {
            var missing = libraryType.MissingValueSets(valueSets);
            if (missing.Any())
            {
                missing.DumpConsole("Missing ValueSets");
                throw new InvalidOperationException($"Cannot find valueSets {libraryName}");
            }
        }

        #region Processing Patients
        private Dictionary<string, Dictionary<string, object>> ProcessTestPatients(
            string testDataDir, Type libraryType, IValueSetDictionary valueSets)
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

                var results = ProcessPatientFiles(libraryType, testPatient, filesInPatientDir, inputParameters, valueSets);
                patientList.Add(testPatient, results);

            }

            return patientList;
        }


        private Dictionary<string, object> ProcessPatientFiles(
            Type libraryType, string testPatient, string[] filesInPatientDir, IDictionary<string, object> inputParameters, IValueSetDictionary valueSets)
        {
            if (filesInPatientDir.Length == 1)
            {
                string firstFileInDirectory = filesInPatientDir[0];
                Console.WriteLine("Loading test case bundle");
                try
                {
                    Bundle patientBundle = ResourceHelper.LoadBundle(firstFileInDirectory);
                    Console.WriteLine($"Checking first file in directory {testPatient}: {firstFileInDirectory}");
                    var result = ProcessBundle(libraryType, testPatient, patientBundle, inputParameters, valueSets);
                    return result;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    Console.WriteLine($"Trying to add bundle wrapper to {firstFileInDirectory}");
                }
            }

            var createdBundle = ResourceHelper.CreateBundle(filesInPatientDir);
            return ProcessBundle(libraryType, testPatient, createdBundle, inputParameters, valueSets);
        }
        public Dictionary<string, object> ProcessBundle(Type libraryType, string testPatient, Bundle patientBundle, IDictionary<string, object>? inputParameters, IValueSetDictionary valueSets)
        {
            Console.WriteLine("Setting up CQL context");
            CqlContext setup = FhirCqlContext.ForBundle(patientBundle, inputParameters, valueSets);
            object? instance = Activator.CreateInstance(libraryType, setup);
            Dictionary<string, object> values = new Dictionary<string, object>();
            Dictionary<string, Exception> errors = new Dictionary<string, Exception>();

            IEnumerable<(MethodInfo method, string declName)> GetMethodWithDeclarations()
            {
                foreach (MethodInfo method in libraryType.GetMethods())
                {
                    if (method.GetParameters().Length == 0)
                    {
                        CqlDeclarationAttribute? declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
                        CqlValueSetAttribute? valueset = method.GetCustomAttribute<CqlValueSetAttribute>();

                        if (declaration is { Name: { } declName } && valueset is null)
                        {
                            yield return (method, declName);
                        }
                    }
                }
            }

            foreach ((MethodInfo method, string declName) in GetMethodWithDeclarations())
            {
                Console.WriteLine($"Running method: {method.Name} ({declName})");
                try
                {
                    object value = method.Invoke(instance, [])!;
                    values.Add(declName, value);

                    var json2 = JsonSerializer.Serialize(value, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));
                    Console.WriteLine($"{declName} : {json2} \n");
                    
                }
                catch (Exception e)
                {
                    errors.Add(declName, e);
                }
            }

            Console.WriteLine($"Results: {errors.Count} error(s), {values} value(s)");
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
            _writer.WriteLine(testPatient);
            WritePatientResults(patientResults);
            _writer.WriteLine();
            _writer.Flush();
        }

        private void WriteResultsAsNdjson(string testPatient, Dictionary<string, object> patientResults)
        {
            patientResults.Add("SourceFile", testPatient);
            var json = JsonSerializer.Serialize(patientResults, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));
            _writer.WriteLine(json);
            _writer.Flush();
        }

        private void WritePatientResults(Dictionary<string, object> patientResults)
        {
            foreach (var result in patientResults)
            {
                var json = JsonSerializer.Serialize(result.Value, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));
                _writer.WriteLine($"{result.Key} : {json}");
            }
        }
    }   
    #endregion Writing Output


}
