// See https://aka.ms/new-console-template for more information

using CqlSdkUseCases;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;

// Load the ELM files from the directory

ProgramInputArgs[] exampleInputArgs = [
    new ("Demo", "C:\\Dev\\firely-cql-sdk\\LibrarySets\\Demo\\Elm", "Demo\\CSharp", "Demo\\Dll"),
    new ("CMS", "C:\\Dev\\firely-cql-sdk\\LibrarySets\\CMS\\Elm", "CMS\\CSharp", "CSM\\Dll", FileFilter:IncludeFilesForCms()),
];

CqlSdk cqlSdk = CqlSdk.Build();

foreach (var cqlExampleInputArg in exampleInputArgs)
{
    Console.WriteLine($"Loading ELM into LibrarySet '{cqlExampleInputArg.Name}'");
    DirectoryInfo elmDir = new DirectoryInfo(cqlExampleInputArg.ElmDir);
    DirectoryInfo csharpDir = new DirectoryInfo(cqlExampleInputArg.CSharpDir);
    DirectoryInfo dllDir = new DirectoryInfo(cqlExampleInputArg.DllDir);
    LibrarySet librarySet = new LibrarySet(cqlExampleInputArg.Name);
    librarySet.LoadLibrariesFromDirectory(elmDir, includeFile:cqlExampleInputArg.FileFilter);

    ElmToCSharpSdk elmToCSharpSdk = cqlSdk.ElmToCSharpSdkProvider.ForLibrarySet(librarySet);
    CSharpToBinarySdk cSharpToBinarySdk = cqlSdk.CSharpToBinarySdkProvider.ForLibrarySet(librarySet);

    // ELM -> C#
    Console.WriteLine("Generate LibrarySet to C#");
    csharpDir.Create();
    dllDir.Create();
    await foreach (var (library, csharpCodeStream) in elmToCSharpSdk.GenerateCSharp(CancellationToken.None))
    {
        var libraryVersionedIdentifier = library.GetVersionedIdentifier();

        Console.WriteLine($"Library: {libraryVersionedIdentifier}");
        await using var fileWriter = File.OpenWrite(Path.Combine(csharpDir.FullName, $"{libraryVersionedIdentifier}.g.cs"));
        csharpCodeStream.CopyTo(fileWriter);

        var assemblyStream = cSharpToBinarySdk.CompileToAssembly(library, csharpCodeStream);
        await using var dllWriter = File.OpenWrite(Path.Combine(dllDir.FullName, $"{libraryVersionedIdentifier}.dll"));
        assemblyStream.CopyTo(dllWriter);
    }
}

Console.WriteLine("Goodbye");

Func<FileInfo, bool> IncludeFilesForCms()
{
    HashSet<string> hardcodedSkipCmsFiles =
    [

        // These contain a union between incompatible tuples,
        // see https://chat.fhir.org/#narrow/stream/179220-cql/topic/Union.20of.20tuples.20with.20convertible.20types
        "AntithromboticTherapyByEndofHospitalDay2FHIR.json",
        "IntensiveCareUnitVenousThromboembolismProphylaxisFHIR.json",
        "VenousThromboembolismProphylaxisFHIR.json",

        // These uses choice types, move into a property on such a choice, and then calls an
        // overloaded function, so we cannot find out which overload to call.
        // A solution is to either a) Introduce choice types in our system instead of object,
        // b) introduce runtime resolution, based on the runtime types of the arguments when one of
        // the arguments is a choice (=object).
        "InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR.json",
        "PCSBMIScreenAndFollowUpFHIR.json",
    ];

    return file => !hardcodedSkipCmsFiles.Contains(file.Name);
}