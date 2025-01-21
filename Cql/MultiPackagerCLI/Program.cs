// See https://aka.ms/new-console-template for more information

using Hl7.Cql.Abstractions.Infrastructure;

MeasuresDirSet[] measureDirSets =
[
    // new MeasuresDirSet("Demo"),
    // new MeasuresDirSet("CMS"),
    // new MeasuresDirSet("Authoring")
    //     .Mutate(m => m with
    //     {
    //         CqlDir = $"{m.MeasuresProjectRootDir}/Input/cql",
    //         ElmDir = $"{m.MeasuresProjectRootDir}/Elm"
    //     }),
    new MeasuresDirSet("CoreTests")
        .Mutate(m => m with
        {
            CqlDir = $"{m.CoreTestsProjectRootDir}/Input/ELM/HL7",
            ElmDir = $"{m.CoreTestsProjectRootDir}/Input/ELM/HL7",
            CSharpDir = $"{m.CoreTestsProjectRootDir}/CSharp",
            DllDir = null!,
            FhirDir = null!,
        }),
];

bool first = true;
foreach (MeasuresDirSet dirSet in measureDirSets)
{
    string Arg(string argName, string? argValue) => argValue is null ? "" : $"--{argName} \"{argValue}\"";

    string[] arguments =
		CommandLineParser
			.SplitCommandLineIntoArguments(
				$"""
					 --override-utc-date-time "1970-01-01T00:00:00.000Z"
					 --canonical-root-url "https://fire.ly/fhir/"
					 {Arg("elm", dirSet.ElmDir)}
					 {Arg("cql", dirSet.CqlDir)}
					 {Arg("fhir", dirSet.FhirDir)}
					 {Arg("dll", dirSet.DllDir)}
					 {Arg("cs", dirSet.CSharpDir)}
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
        CoreTestsProjectRootDir = $"{SolutionDir}/Cql/CoreTests";
        ElmDir = $"{LibrarySetsRootDir}/Elm";
		CqlDir = $"{LibrarySetsRootDir}/Cql";
		FhirDir = $"{LibrarySetsRootDir}/Resources";
		DllDir = $"{LibrarySetsRootDir}/Assemblies";
		CSharpDir = $"{MeasuresProjectRootDir}/CSharp";
    }

    public string Name { get; }
    public string LibrarySetsRootDir { get; }
    public string MeasuresProjectRootDir { get; }
    public string CoreTestsProjectRootDir { get; }
    public string ElmDir { get; init; }
    public string CqlDir { get; init; }
    public string? FhirDir { get; init; }
    public string? DllDir { get; init; }
    public string? CSharpDir { get; init; }
	public MeasuresDirSet Mutate(Func<MeasuresDirSet, MeasuresDirSet> mutator) => mutator(this);
}