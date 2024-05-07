// See https://aka.ms/new-console-template for more information

using Hl7.Cql.CodeGeneration.NET;
using Microsoft.CodeAnalysis;

var solutionDir = new DirectoryInfo(Environment.CurrentDirectory);
while (!File.Exists(Path.Combine(solutionDir!.FullName, "CqlAndDemo.sln")))
    solutionDir = solutionDir.Parent;

CSharpCodeWriterTypeFormat csTypeFormat = CSharpCodeWriterTypeFormat.Explicit;
(string subDir, string measureSubDir)[] iteration = [
    ("Demo", "Measures"),
    ("CMS", "Measures-cms")
];

bool first = true;
foreach ((string librarySetSubDir, string measuresSubDir) in iteration)
{
    string[] arguments =
        CommandLineParser
                    .SplitCommandLineIntoArguments(
                        $"""
                        --override-utc-date-time "1970-01-01T00:00:00.000Z"
                        --canonical-root-url "https://fire.ly/fhir/"
                        --elm "{solutionDir}/LibrarySets/{librarySetSubDir}/Elm"
                        --cql "{solutionDir}/LibrarySets/{librarySetSubDir}/Cql"
                        --fhir "{solutionDir}/LibrarySets/{librarySetSubDir}/Resources"
                        --cs "{solutionDir}/Demo/{measuresSubDir}"
                        --cs-typeformat {csTypeFormat}
                        --f true
                        {(first ? "" : "--log-dont-clear true")}
                        """.Replace("\n", " "),
                        removeHashComments: true)
                    .ToArray();

    Hl7.Cql.Packager.Program.Main(arguments);
    first = false;
}
