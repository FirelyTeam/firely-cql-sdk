// See https://aka.ms/new-console-template for more information

using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.CodeAnalysis;

var solutionDir = new DirectoryInfo(Environment.CurrentDirectory)
	.FindParentDirectoryContaining("*.sln")!;

(string librarySetSubDir, string measureSubDir, string? cqlSubDirOverride, string? elmSubDirOverride)[] iteration = [
	("Demo", "Measures.Demo", null, null),
	("CMS", "Measures.CMS", null, null),
	("Authoring", "Measures.Authoring", "/Input/cql", "/Elm"),
];

bool first = true;
foreach ((string librarySetSubDir, string measuresSubDir, string? cqlSubDirOverride, string? elmSubDirOverride) in iteration)
{
	string librarySetsRootDir = $"{solutionDir}/LibrarySets/{librarySetSubDir}";
	string demoRootDir = $"{solutionDir}/Demo/{measuresSubDir}";

    string elmDir =
        elmSubDirOverride is null
            ? $"{librarySetsRootDir}/Elm"
            : $"{demoRootDir}{elmSubDirOverride}";
	string cqlDir =
		cqlSubDirOverride is null
            ? $"{librarySetsRootDir}/Cql"
            : $"{demoRootDir}/{cqlSubDirOverride}";
	string fhirDir = $"{librarySetsRootDir}/Resources";
	string dllDir = $"{librarySetsRootDir}/Assemblies";
    string csharpDir = $"{demoRootDir}/CSharp";

    string[] arguments =
		CommandLineParser
			.SplitCommandLineIntoArguments(
				$"""
					 --override-utc-date-time "1970-01-01T00:00:00.000Z"
					 --canonical-root-url "https://fire.ly/fhir/"
					 --elm "{elmDir}"
					 --cql "{cqlDir}"
					 --fhir "{fhirDir}"
					 --dll "{dllDir}"
					 --cs "{csharpDir}"
					 --log-debug true
					 {(first ? "" : "--log-dont-clear true")}
					 """.Replace("\n", " "),
				removeHashComments: true)
			.ToArray();

	Hl7.Cql.Packager.Program.Main(arguments);
	first = false;
}