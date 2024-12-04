// See https://aka.ms/new-console-template for more information

using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.CodeAnalysis;

MeasuresDirSet[] measureDirSets =
[
    new MeasuresDirSet("Demo"),
    new MeasuresDirSet("CMS"),
    new MeasuresDirSet("Authoring")
        .Mutate(m => m with
        {
            CqlDir = $"{m.MeasuresProjectRootDir}/Input/cql",
            ElmDir = $"{m.MeasuresProjectRootDir}/Elm"
        }),
];

bool first = true;
foreach (MeasuresDirSet dirSet in measureDirSets)
{
    string[] arguments =
		CommandLineParser
			.SplitCommandLineIntoArguments(
				$"""
					 --override-utc-date-time "1970-01-01T00:00:00.000Z"
					 --canonical-root-url "https://fire.ly/fhir/"
					 --elm "{dirSet.ElmDir}"
					 --cql "{dirSet.CqlDir}"
					 --fhir "{dirSet.FhirDir}"
					 --dll "{dirSet.DllDir}"
					 --cs "{dirSet.CSharpDir}"
					 --log-debug true
					 {(first ? "" : "--log-dont-clear true")}
					 """.Replace("\n", " "),
				removeHashComments: true)
			.ToArray();

	Hl7.Cql.Packager.Program.Main(arguments);
	first = false;
}

file record MeasuresDirSet
{
	public static string SolutionDir { get; } = new DirectoryInfo(Environment.CurrentDirectory)
        .FindParentDirectoryContaining("*.sln")!
        .FullName;


    public MeasuresDirSet(string Name)
    {
        this.Name = Name;
        LibrarySetsRootDir = $"{SolutionDir}/LibrarySets/{Name}";
        MeasuresProjectRootDir = $"{SolutionDir}/Demo/Measures.{Name}";
        ElmDir = $"{LibrarySetsRootDir}/Elm";
		CqlDir = $"{LibrarySetsRootDir}/Cql";
		FhirDir = $"{LibrarySetsRootDir}/Resources";
		DllDir = $"{LibrarySetsRootDir}/Assemblies";
		CSharpDir = $"{MeasuresProjectRootDir}/CSharp";
    }

    public string Name { get; }
    public string LibrarySetsRootDir { get; }
    public string MeasuresProjectRootDir { get; }
    public string ElmDir { get; init; }
    public string CqlDir { get; init; }
    public string FhirDir { get; }
    public string DllDir { get; }
    public string CSharpDir { get; }
	public MeasuresDirSet Mutate(Func<MeasuresDirSet, MeasuresDirSet> mutator) => mutator(this);
}