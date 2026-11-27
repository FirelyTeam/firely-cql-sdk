/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.RegularExpressions;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Test.ElmComparison;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit.Internal;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// Translates every CQL corpus in the repository with the .NET CQL-to-ELM translator and compares
/// the outcome per library against a committed known-pass file in <c>Input/Census</c>.
/// See <c>Input/Census/README.md</c> for the file formats and how to refresh them.
/// </summary>
[TestClass]
public class TranslatorCensusTest
{
    /// <summary>
    /// The solution filter at the repository root, used to locate the source tree from the test binaries.
    /// </summary>
    private const string RepositoryRootMarker = "Cql-Sdk.slnf";

    /// <summary>
    /// Gets or sets the MSTest context, used to locate the results directory and to attach the report.
    /// </summary>
    public TestContext TestContext { get; set; } = null!;

    /// <summary>
    /// One translator run over one directory of CQL files.
    /// </summary>
    /// <param name="Name">The name of the run; also the stem of its known-pass (or counts) file.</param>
    /// <param name="RelativeDirectory">The directory holding the CQL files, relative to the repository root.</param>
    /// <param name="Models">The bundled models selected in addition to <see cref="CqlToolkitConfig.DefaultCqlModels"/>.</param>
    /// <param name="CountsOnly">
    /// When <see langword="true"/>, the baseline holds only outcome counts, and library names and messages
    /// are written to the report file only.
    /// </param>
    /// <param name="InconclusiveWhenAbsent">
    /// When <see langword="true"/>, a missing directory makes the test inconclusive instead of failing it.
    /// </param>
    /// <param name="ReferenceElmDirectory">
    /// The directory holding the reference ELM the Java translator produced for this corpus with these models,
    /// relative to the repository root; <see langword="null"/> when there is none. The ELM of every clean library is
    /// compared with it structurally, as a report only.
    /// </param>
    public sealed record CensusCorpus(
        string Name,
        string RelativeDirectory,
        CqlModel[] Models,
        bool CountsOnly = false,
        bool InconclusiveWhenAbsent = false,
        string? ReferenceElmDirectory = null)
    {
        /// <summary>
        /// The committed baseline file name for this run.
        /// </summary>
        public string BaselineFileName => CountsOnly ? $"{Name}.counts.txt" : $"{Name}.known-pass.txt";

        /// <summary>
        /// The committed baseline file name for compiling the clean libraries of this run.
        /// </summary>
        public string CompileBaselineFileName => CountsOnly ? $"{Name}.compile-counts.txt" : $"{Name}.known-compile.txt";

        /// <inheritdoc />
        public override string ToString() => Name;
    }

    private static readonly CqlModel[] QiCore411 = [CqlModel.QICore411, CqlModel.USCore311];
    private static readonly CqlModel[] QiCore600 = [CqlModel.QICore600, CqlModel.USCore610];

    /// <summary>
    /// All census runs. Corpora that need QICore are run both without and with the QICore and US Core model infos.
    /// The reference ELM of a corpus is compared only with the run whose models it was produced with; the authoring
    /// corpus has no reference ELM.
    /// </summary>
    public static IEnumerable<object[]> Corpora()
    {
        yield return [new CensusCorpus("demo", "LibrarySets/Demo/Cql", [], ReferenceElmDirectory: "LibrarySets/Demo/Elm")];
        yield return [new CensusCorpus("rr23", "LibrarySets/RR23/Cql", [], ReferenceElmDirectory: "LibrarySets/RR23/Elm")];
        yield return [new CensusCorpus("coretests-hl7", "Cql/CoreTests/Input/ELM/HL7", [], ReferenceElmDirectory: "Cql/CoreTests/Input/ELM/HL7")];
        yield return [new CensusCorpus("authoring", "Demo/Measures.Authoring/Input/cql", [])];
        yield return [new CensusCorpus("authoring-qicore-4.1.1", "Demo/Measures.Authoring/Input/cql", QiCore411)];
        yield return [new CensusCorpus("dqm-qicore-2025", "LibrarySets/dqm-content-qicore-2025/Cql", [])];
        yield return [new CensusCorpus("dqm-qicore-2025-qicore-6.0.0", "LibrarySets/dqm-content-qicore-2025/Cql", QiCore600, ReferenceElmDirectory: "LibrarySets/dqm-content-qicore-2025/Elm")];
        yield return [new CensusCorpus("hedis-2025", "submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025/Cql", [], CountsOnly: true, InconclusiveWhenAbsent: true, ReferenceElmDirectory: "submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025/Elm")];
    }

    /// <summary>
    /// The display name of a census row.
    /// </summary>
    public static string DisplayName(MethodInfo method, object[] data) => $"TranslatorCensus: {data[0]}";

    /// <summary>
    /// Translates one corpus, writes the report and the candidate baseline as result files, and then
    /// fails when the corpus has regressed against the committed baseline.
    /// </summary>
    [DataTestMethod]
    [DynamicData(nameof(Corpora), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DisplayName))]
    public void TranslatorCensus(CensusCorpus corpus)
    {
        var repositoryRoot = new DirectoryInfo(AppContext.BaseDirectory).FindParentDirectoryContaining(RepositoryRootMarker)
                             ?? throw new InvalidOperationException($"Could not find a parent directory of '{AppContext.BaseDirectory}' containing '{RepositoryRootMarker}'.");
        var corpusDirectory = new DirectoryInfo(Path.Combine(repositoryRoot.FullName, corpus.RelativeDirectory));
        var cqlFileCount = corpusDirectory.Exists ? CqlFiles(corpusDirectory).Count() : 0;

        if (cqlFileCount == 0)
        {
            var message = $"Corpus '{corpus.Name}' has no CQL files in '{corpusDirectory.FullName}'.";
            if (corpus.InconclusiveWhenAbsent)
                Assert.Inconclusive(message);
            Assert.Fail(message);
        }

        var stopwatch = Stopwatch.StartNew();
        var results = Translate(corpusDirectory, corpus.Models);
        stopwatch.Stop();

        var counts = CensusCounts.Of(results);
        var baselinePath = Path.Combine(AppContext.BaseDirectory, "Input", "Census", corpus.BaselineFileName);

        // Write the artifacts before asserting anything, so a regression still leaves the report behind.
        var outputDirectory = Path.Combine(ResultsRoot(), "TranslatorCensus");
        Directory.CreateDirectory(outputDirectory);
        var reportPath = Path.Combine(outputDirectory, $"{corpus.Name}.report.txt");
        File.WriteAllText(reportPath, BuildReport(corpus, cqlFileCount, results, counts, stopwatch.Elapsed));
        var candidatePath = Path.Combine(outputDirectory, corpus.BaselineFileName);
        File.WriteAllText(candidatePath, corpus.CountsOnly ? BuildCountsFile(corpus, counts) : BuildKnownPassFile(corpus, results));
        // A counts-only corpus is licensed content: its report names libraries and quotes messages,
        // so it stays on the machine that ran the test and is not attached to the published results.
        if (!corpus.CountsOnly)
            TestContext.AddResultFile(reportPath);
        TestContext.AddResultFile(candidatePath);

        TestContext.WriteLine(string.Create(CultureInfo.InvariantCulture, $"{corpus.Name}: {counts} in {stopwatch.Elapsed.TotalSeconds:F1}s"));
        TestContext.WriteLine($"Report: {reportPath}");
        TestContext.WriteLine($"Candidate baseline: {candidatePath}");

        // An exception in the ELM checks is reported after the census assertions, so it cannot hide a regression.
        ElmCheckSummary? elmCheck = null;
        Exception? elmCheckError = null;
        try
        {
            elmCheck = CheckElm(corpus, repositoryRoot, results, outputDirectory);
        }
        catch (Exception e)
        {
            elmCheckError = e;
        }

        // Compiling the clean libraries is the next level; an exception in it is also reported after the census assertions.
        CompileSummary? compile = null;
        Exception? compileError = null;
        try
        {
            compile = CompileCorpus(corpus, results, outputDirectory);
        }
        catch (Exception e)
        {
            compileError = e;
        }

        // Every file must have an outcome: a file that cannot be loaded is a crash, not a silent omission.
        if (cqlFileCount != counts.Total)
            Assert.Fail($"{corpus.Name}: {cqlFileCount} CQL files, but {counts.Total} outcomes ({counts}); every file must have exactly one outcome. See the report file for details.");

        if (!File.Exists(baselinePath))
            Assert.Fail($"Baseline file '{corpus.BaselineFileName}' is missing from Input/Census. Copy the candidate '{candidatePath}' there.");

        if (corpus.CountsOnly)
            CompareCounts(corpus, counts, baselinePath);
        else
            CompareKnownPass(corpus, results, baselinePath);

        // A counts-only corpus is licensed content, and an exception message can name its files.
        if (elmCheckError is not null)
            Assert.Fail(corpus.CountsOnly
                            ? $"{corpus.Name}: the ELM checks threw {elmCheckError.GetType().Name}."
                            : $"{corpus.Name}: the ELM checks threw {elmCheckError}");

        // The structural comparison with the reference ELM is a report only; the independent checkers are a gate.
        if (elmCheck!.FailedLibraries > 0)
            Assert.Fail($"{corpus.Name}: the ELM of {elmCheck.FailedLibraries} of {elmCheck.CheckedLibraries} clean libraries does not read back as written or is not valid against the ELM schema. See {elmCheck.ReportFileName} for details.");

        if (compileError is not null)
            Assert.Fail(corpus.CountsOnly
                            ? $"{corpus.Name}: compiling the clean libraries threw {compileError.GetType().Name}."
                            : $"{corpus.Name}: compiling the clean libraries threw {compileError}");

        var compileBaselinePath = Path.Combine(AppContext.BaseDirectory, "Input", "Census", corpus.CompileBaselineFileName);
        if (!File.Exists(compileBaselinePath))
            Assert.Fail($"Baseline file '{corpus.CompileBaselineFileName}' is missing from Input/Census. Copy the candidate '{compile!.CandidatePath}' there.");
        if (corpus.CountsOnly)
            CompareCompileCounts(corpus, compile!.Counts, compileBaselinePath);
        else
            CompareKnownCompile(corpus, compile!.Results, compileBaselinePath);
    }

    /// <summary>
    /// A file whose library declaration cannot be parsed, or whose identifier another file already declares,
    /// gets a crash outcome instead of being left out of the census.
    /// </summary>
    [TestMethod]
    public void TranslatorCensusRecordsUnloadableFilesAsCrashes()
    {
        var directory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), $"TranslatorCensus-{Guid.NewGuid():N}"));
        try
        {
            File.WriteAllText(Path.Combine(directory.FullName, "a-valid.cql"), "library Valid version '1.0.0'\n\ndefine X: 1\n");
            File.WriteAllText(Path.Combine(directory.FullName, "b-duplicate.cql"), "library Valid version '1.0.0'\n\ndefine Y: 2\n");
            File.WriteAllText(Path.Combine(directory.FullName, "c-malformed.cql"), "this is not a library declaration\n");

            var results = Translate(directory, []);

            Assert.AreEqual(CqlFiles(directory).Count(), results.Count);
            var byId = results.ToDictionary(r => r.Id, StringComparer.Ordinal);
            Assert.AreEqual(Outcome.Clean, byId["Valid-1.0.0"].Outcome);
            Assert.AreEqual(Outcome.Crash, byId["b-duplicate.cql"].Outcome);
            StringAssert.Contains(byId["b-duplicate.cql"].Details.Single(), "duplicate library identifier");
            Assert.AreEqual(Outcome.Crash, byId["c-malformed.cql"].Outcome);
            StringAssert.StartsWith(byId["c-malformed.cql"].Details.Single(), "load failed:");
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    /// <summary>
    /// A clean library compiles; one that includes a library with translation errors is blocked; one whose ELM cannot
    /// be compiled fails; and one that includes it is a cascade. Through a chain of includes, blocked and cascade name
    /// the library at its root.
    /// </summary>
    [TestMethod]
    public void CompileClassifiesCleanLibrariesByWhyTheyDoNotCompile()
    {
        var directory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), $"TranslatorCensus-{Guid.NewGuid():N}"));
        try
        {
            File.WriteAllText(Path.Combine(directory.FullName, "a.cql"), "library A version '1.0.0'\n\ndefine X: 1\n");
            File.WriteAllText(Path.Combine(directory.FullName, "b.cql"), "library B version '1.0.0'\n\ninclude A version '1.0.0'\n\ndefine Y: A.X + 1\n");
            File.WriteAllText(Path.Combine(directory.FullName, "broken.cql"), "library Broken version '1.0.0'\n\ndefine X: 1 + 'a'\n");
            File.WriteAllText(Path.Combine(directory.FullName, "c.cql"), "library C version '1.0.0'\n\ninclude Broken version '1.0.0'\n\ndefine Y: 1\n");
            File.WriteAllText(Path.Combine(directory.FullName, "d.cql"), "library D version '1.0.0'\n\ndefine X: 1\n\ndefine Y: X\n");
            File.WriteAllText(Path.Combine(directory.FullName, "e.cql"), "library E version '1.0.0'\n\ninclude D version '1.0.0'\n\ndefine Z: D.X\n");
            File.WriteAllText(Path.Combine(directory.FullName, "f.cql"), "library F version '1.0.0'\n\ninclude E version '1.0.0'\n\ndefine W: E.Z\n");
            File.WriteAllText(Path.Combine(directory.FullName, "g.cql"), "library G version '1.0.0'\n\ninclude C version '1.0.0'\n\ndefine V: 1\n");

            // D translates cleanly; make its ELM uncompilable by pointing Y at a definition that does not exist.
            var results = Translate(directory, [])
                          .Select(r => r.Id == "D-1.0.0" ? r with { ElmJson = WithDanglingExpressionRef(r.ElmJson!) } : r)
                          .ToList();

            var byId = Compile(results).ToDictionary(r => r.Id, StringComparer.Ordinal);

            byId.Keys.Should().BeEquivalentTo("A-1.0.0", "B-1.0.0", "C-1.0.0", "D-1.0.0", "E-1.0.0", "F-1.0.0", "G-1.0.0");
            byId["A-1.0.0"].Outcome.Should().Be(CompileOutcome.Compiled);
            byId["B-1.0.0"].Outcome.Should().Be(CompileOutcome.Compiled);
            byId["C-1.0.0"].Should().Be(new CompileResult("C-1.0.0", CompileOutcome.Blocked, "includes Broken-1.0.0, which did not translate cleanly"));
            byId["D-1.0.0"].Outcome.Should().Be(CompileOutcome.Failed);
            byId["D-1.0.0"].Detail.Should().Contain("D-1.0.0").And.Contain("Exception");
            byId["E-1.0.0"].Should().Be(new CompileResult("E-1.0.0", CompileOutcome.Cascade, "includes D-1.0.0, which failed to compile"));
            // Through a chain, the root cause is named, not the library in between.
            byId["F-1.0.0"].Should().Be(new CompileResult("F-1.0.0", CompileOutcome.Cascade, "includes D-1.0.0, which failed to compile"));
            byId["G-1.0.0"].Should().Be(new CompileResult("G-1.0.0", CompileOutcome.Blocked, "includes Broken-1.0.0, which did not translate cleanly"));
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    private static string WithDanglingExpressionRef(string elmJson)
    {
        var document = System.Text.Json.Nodes.JsonNode.Parse(elmJson, documentOptions: ElmNormalizer.DocumentOptions)!;
        var y = document["library"]!["statements"]!["def"]!.AsArray().Single(d => (string?)d!["name"] == "Y")!;
        y["expression"]!["name"] = "Missing";
        return document.ToJsonString();
    }

    /// <summary>
    /// The directory the report and candidate baseline are written to: the test results directory
    /// (<c>--results-directory</c>), which is the parent of the run's deployment directory.
    /// MSTest deletes the deployment directory, including <see cref="TestContext.TestRunResultsDirectory"/>,
    /// when every test passes, so files written there would be gone before anyone can copy them.
    /// </summary>
    private string ResultsRoot() =>
        (TestContext.TestRunDirectory is { } runDirectory ? Path.GetDirectoryName(runDirectory) : null)
        ?? TestContext.TestRunResultsDirectory
        ?? AppContext.BaseDirectory;

    /// <summary>
    /// Fails when the number of clean libraries dropped below the committed count.
    /// Only counts are reported, never library names.
    /// </summary>
    private void CompareCounts(CensusCorpus corpus, CensusCounts counts, string baselinePath)
    {
        var baseline = CensusCounts.Parse(ReadBaselineLines(baselinePath));

        if (counts.Total != baseline.Total)
            TestContext.WriteLine($"WARNING: {corpus.Name} now has {counts.Total} libraries; the baseline has {baseline.Total}.");
        if (counts.Clean > baseline.Clean)
            TestContext.WriteLine($"WARNING: {corpus.Name} now has {counts.Clean} clean libraries; the baseline has {baseline.Clean}. Copy the candidate counts file into Input/Census.");

        if (counts.Clean < baseline.Clean)
            Assert.Fail($"{corpus.Name}: {counts.Clean} libraries translate cleanly, below the baseline of {baseline.Clean}. Now {counts}; baseline {baseline}. See the report file for details.");
    }

    /// <summary>
    /// Fails when a listed library is no longer clean or no longer present;
    /// reports clean libraries that are not listed as warnings.
    /// </summary>
    private void CompareKnownPass(CensusCorpus corpus, IReadOnlyList<LibraryResult> results, string baselinePath)
    {
        var expected = new HashSet<string>(ReadBaselineLines(baselinePath), StringComparer.Ordinal);
        var byId = results.ToDictionary(r => r.Id, StringComparer.Ordinal);

        var missing = expected.Where(id => !byId.ContainsKey(id)).OrderBy(id => id, StringComparer.Ordinal).ToList();
        var regressed = expected.Where(byId.ContainsKey).Select(id => byId[id]).Where(r => r.Outcome != Outcome.Clean).OrderBy(r => r.Id, StringComparer.Ordinal).ToList();
        var promoted = results.Where(r => r.Outcome == Outcome.Clean && !expected.Contains(r.Id)).ToList();

        foreach (var r in promoted)
            TestContext.WriteLine($"WARNING: {r.Id} now translates cleanly but is not listed in {corpus.BaselineFileName}; add it.");

        if (missing.Count == 0 && regressed.Count == 0)
            return;

        var message = new StringBuilder($"{corpus.Name}: libraries listed in {corpus.BaselineFileName} no longer translate cleanly.");
        foreach (var r in regressed)
            message.AppendLine().Append($"  {r.Id}: {r.Outcome}: {r.ReportLines.FirstOrDefault()}");
        foreach (var id in missing)
            message.AppendLine().Append($"  {id}: not found in the corpus");
        Assert.Fail(message.ToString());
    }

    /// <summary>
    /// Reads the non-blank, non-comment lines of a baseline file, trimmed.
    /// </summary>
    private static IEnumerable<string> ReadBaselineLines(string path) =>
        File.ReadLines(path)
            .Select(line => line.Trim())
            .Where(line => line.Length > 0 && !line.StartsWith('#'));

    #region Translation

    /// <summary>
    /// The outcome of translating one library.
    /// </summary>
    public enum Outcome
    {
        /// <summary>The ELM carries no error-severity annotations.</summary>
        Clean,

        /// <summary>The ELM carries one or more error-severity annotations.</summary>
        Errors,

        /// <summary>Translation threw an exception.</summary>
        Crash,
    }

    /// <summary>
    /// The translation result of one library.
    /// </summary>
    /// <param name="Id">
    /// The library identifier, as <see cref="CqlVersionedLibraryIdentifier.ToString"/> prints it; for a file that
    /// could not be loaded, its path relative to the corpus directory.
    /// </param>
    /// <param name="Outcome">Whether translation was clean, reported errors, or crashed.</param>
    /// <param name="Details">The error messages, or for a crash a single line describing the exception.</param>
    /// <param name="UnspecifiedSeverityCount">The number of annotations without a specified severity, which the error filter treats as info.</param>
    /// <param name="CrashLocation">For a crash, the first stack frame inside the translator, if any.</param>
    /// <param name="ElmJson">The emitted ELM as JSON, for every library that did not crash and could be written.</param>
    /// <param name="ElmWriteError">The exception writing the ELM as JSON threw, for a library that could not be written.</param>
    private sealed record LibraryResult(
        string Id,
        Outcome Outcome,
        IReadOnlyList<string> Details,
        int UnspecifiedSeverityCount,
        string? CrashLocation = null,
        string? ElmJson = null,
        string? ElmWriteError = null)
    {
        /// <summary>
        /// The details as they appear in the histogram: normalized, and for a crash prefixed and followed by its location.
        /// </summary>
        public IEnumerable<string> HistogramMessages =>
            Outcome == Outcome.Crash
                ? Details.Select(d => $"Crash: {Normalize(d)}{CrashLocation}")
                : Details.Select(Normalize);

        /// <summary>
        /// The details as they appear in the per-library lines of the report.
        /// </summary>
        public IEnumerable<string> ReportLines =>
            Outcome == Outcome.Crash
                ? Details.Select(d => $"{d}{CrashLocation}".ReplaceLineEndings(" "))
                : Details.Select(d => d.ReplaceLineEndings(" "));
    }

    /// <summary>
    /// The CQL files of a corpus directory, including its subdirectories.
    /// </summary>
    private static IEnumerable<FileInfo> CqlFiles(DirectoryInfo directory) =>
        directory.EnumerateFiles("*.cql", SearchOption.AllDirectories);

    /// <summary>
    /// Translates each library in the directory individually, so one exception cannot hide the others.
    /// Returns exactly one result per CQL file: a file that cannot be loaded is a <see cref="Outcome.Crash"/>.
    /// </summary>
    private static IReadOnlyList<LibraryResult> Translate(DirectoryInfo directory, CqlModel[] models)
    {
        var (libraries, results) = LoadLibraries(directory);
        var toolkit = new CqlToolkit(
                          NullLoggerFactory.Instance,
                          new CqlToolkitConfig(Models: CqlToolkitConfig.DefaultCqlModels.Union(models), AmbiguousTypeBehavior: AmbiguousTypeBehavior.PreferModel))
                      .SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation.Continue);
        toolkit.AddCqlLibraries(libraries);
        var provider = (LibraryBuilderProvider)toolkit.ServiceProvider.GetRequiredService<ILibraryProvider>();

        foreach (var id in libraries.Select(l => l.LibraryIdentifier))
        {
            try
            {
                if (!toolkit.ArtifactsById.ContainsKey(id))
                    throw new InvalidOperationException("the toolkit did not register the library");
                if (!provider.TryResolveLibrary(id, out var builder, out var error))
                    throw new InvalidOperationException($"resolve failed: {error}");

                var elm = builder.Build();
                var annotations = elm.GetErrors();
                var errors = annotations
                             .Where(e => e.errorSeverity != ErrorSeverity.warning && e.errorSeverity != ErrorSeverity.info)
                             .Select(e => e.message ?? "")
                             .ToList();
                var unspecified = annotations.Count(e => !e.errorSeveritySpecified);
                // A library that translates but cannot be written fails the ELM checks, not the translation outcome.
                string? json = null, writeError = null;
                try
                {
                    json = elm.SerializeToJson(writeIndented: false);
                }
                catch (Exception e)
                {
                    writeError = $"{e.GetType().Name}: {e.Message}";
                }

                results.Add(new LibraryResult(id.ToString(), errors.Count == 0 ? Outcome.Clean : Outcome.Errors, errors, unspecified, ElmJson: json, ElmWriteError: writeError));
            }
            catch (Exception e)
            {
                var (description, location) = DescribeCrash(e);
                results.Add(new LibraryResult(id.ToString(), Outcome.Crash, [description], 0, location));
            }
        }

        return results.OrderBy(r => r.Id, StringComparer.Ordinal).ToList();
    }

    /// <summary>
    /// Parses the library declaration of every CQL file in the directory. A file that cannot be parsed, or that
    /// declares an identifier an earlier file already declared, becomes a <see cref="Outcome.Crash"/> result keyed
    /// by its path relative to the directory, so it is counted instead of being dropped.
    /// </summary>
    private static (List<CqlLibraryString> Libraries, List<LibraryResult> LoadFailures) LoadLibraries(DirectoryInfo directory)
    {
        var libraries = new List<CqlLibraryString>();
        var loadFailures = new List<LibraryResult>();
        var loadedFrom = new Dictionary<CqlVersionedLibraryIdentifier, string>();

        foreach (var file in CqlFiles(directory).OrderBy(f => f.FullName, StringComparer.Ordinal))
        {
            var relativePath = Path.GetRelativePath(directory.FullName, file.FullName).Replace(Path.DirectorySeparatorChar, '/');
            CqlLibraryString library;
            try
            {
                library = CqlLibraryString.Parse(File.ReadAllText(file.FullName));
            }
            catch (Exception e)
            {
                var (description, location) = DescribeCrash(e);
                loadFailures.Add(new LibraryResult(relativePath, Outcome.Crash, [$"load failed: {description}"], 0, location));
                continue;
            }

            if (loadedFrom.TryGetValue(library.LibraryIdentifier, out var firstPath))
            {
                loadFailures.Add(new LibraryResult(relativePath, Outcome.Crash, [$"duplicate library identifier '{library.LibraryIdentifier}', already declared in '{firstPath}'"], 0));
                continue;
            }

            loadedFrom.Add(library.LibraryIdentifier, relativePath);
            libraries.Add(library);
        }

        return (libraries, loadFailures);
    }

    /// <summary>
    /// Describes an exception by type and message, and separately by the first stack frame inside the translator.
    /// </summary>
    private static (string Description, string Location) DescribeCrash(Exception exception)
    {
        while (exception is TargetInvocationException { InnerException: { } inner })
            exception = inner;
        if (exception is AggregateException { InnerExceptions.Count: 1 } aggregate)
            exception = aggregate.InnerExceptions[0];

        var frame = new StackTrace(exception, false)
                    .GetFrames()
                    .Select(f => f.GetMethod())
                    .FirstOrDefault(m => m?.DeclaringType?.Namespace?.StartsWith("Hl7.Cql.CqlToElm", StringComparison.Ordinal) == true);
        var location = frame is null ? "" : $" at {frame.DeclaringType!.FullName}.{frame.Name}";
        return ($"{exception.GetType().Name}: {exception.Message}", location);
    }

    #endregion

    #region ELM checks

    /// <summary>
    /// The outcome of the ELM checks of one corpus.
    /// </summary>
    /// <param name="CheckedLibraries">The number of clean libraries whose ELM was checked.</param>
    /// <param name="FailedLibraries">The number of those whose ELM failed a check.</param>
    /// <param name="ReportFileName">The name of the report file the details are in.</param>
    private sealed record ElmCheckSummary(int CheckedLibraries, int FailedLibraries, string ReportFileName);

    /// <summary>
    /// The independent checkers' findings for one library.
    /// </summary>
    private sealed record CheckFailure(string Id, Outcome Outcome, IReadOnlyList<string> Problems);

    private static ElmOutputCheckers? _elmOutputCheckers;

    /// <summary>
    /// Runs the independent checkers on the ELM of every library that did not crash, and compares the ELM of every
    /// clean library with the reference ELM, if the corpus has any. Writes the results to
    /// <c>&lt;run&gt;.elm-report.txt</c>; for a counts-only corpus that report is not attached, and
    /// <c>&lt;run&gt;.elm-counts.txt</c> with only the counts is attached instead.
    /// </summary>
    /// <remarks>
    /// Only the checks of clean libraries count towards the returned summary, which fails the test. The ELM of a
    /// library with translation errors holds placeholders where translation failed, so its findings are reported
    /// but do not fail the test.
    /// </remarks>
    private ElmCheckSummary CheckElm(CensusCorpus corpus, DirectoryInfo repositoryRoot, IReadOnlyList<LibraryResult> results, string outputDirectory)
    {
        var checkers = _elmOutputCheckers ??= new ElmOutputCheckers(Path.Combine(repositoryRoot.FullName, "Cql", "Elm", "Schema"));

        var checkFailures = new List<CheckFailure>();
        foreach (var result in results.Where(r => r.Outcome != Outcome.Crash))
        {
            IReadOnlyList<string> problems = result.ElmJson is { } json ? checkers.Check(json) : [$"writer: {result.ElmWriteError}"];
            if (problems.Count > 0)
                checkFailures.Add(new CheckFailure(result.Id, result.Outcome, problems));
        }

        var checkedLibraries = results.Count(r => r.Outcome == Outcome.Clean);
        var failedLibraries = checkFailures.Count(f => f.Outcome == Outcome.Clean);

        var comparison = corpus.ReferenceElmDirectory is { } referenceDirectory
                             ? CompareWithReference(results, new DirectoryInfo(Path.Combine(repositoryRoot.FullName, referenceDirectory)))
                             : null;

        var reportFileName = $"{corpus.Name}.elm-report.txt";
        var reportPath = Path.Combine(outputDirectory, reportFileName);
        File.WriteAllText(reportPath, BuildElmReport(corpus, checkedLibraries, checkFailures, comparison));
        if (corpus.CountsOnly)
        {
            var countsPath = Path.Combine(outputDirectory, $"{corpus.Name}.elm-counts.txt");
            File.WriteAllText(countsPath, BuildElmCounts(corpus, checkedLibraries, failedLibraries, checkFailures.Count - failedLibraries, comparison));
            TestContext.AddResultFile(countsPath);
        }
        else
        {
            TestContext.AddResultFile(reportPath);
        }

        TestContext.WriteLine($"ELM report: {reportPath}");
        if (comparison is not null)
            TestContext.WriteLine($"{corpus.Name}: {comparison.Summary}");
        return new ElmCheckSummary(checkedLibraries, failedLibraries, reportFileName);
    }

    /// <summary>
    /// The structural comparison of a corpus with its reference ELM.
    /// </summary>
    /// <param name="Divergences">The divergences of each compared library, by library identifier.</param>
    /// <param name="NoReference">The clean libraries for which the reference directory holds no ELM.</param>
    /// <param name="NotCompared">The libraries that are not compared because they did not translate cleanly, or
    /// because their ELM could not be written.</param>
    /// <param name="ComparisonErrors">The clean libraries whose comparison threw, with the exception.</param>
    private sealed record ReferenceComparison(
        IReadOnlyDictionary<string, IReadOnlyList<Divergence>> Divergences,
        IReadOnlyList<string> NoReference,
        int NotCompared,
        IReadOnlyDictionary<string, string> ComparisonErrors)
    {
        public int Total(DivergenceKind kind) => Divergences.Values.Sum(list => list.Count(d => d.Kind == kind));

        public int IdenticalLibraries => Divergences.Values.Count(list => list.Count == 0);

        public string Summary =>
            $"{Divergences.Count} libraries compared with the reference ELM, {IdenticalLibraries} identical, "
            + $"{Divergences.Values.Sum(list => list.Count)} divergences ("
            + string.Join(", ", Enum.GetValues<DivergenceKind>().Select(kind => $"{kind} {Total(kind)}"))
            + $"); {NoReference.Count} without reference ELM, {NotCompared} not clean or not written, "
            + $"{ComparisonErrors.Count} failed to compare";
    }

    private static ReferenceComparison CompareWithReference(IReadOnlyList<LibraryResult> results, DirectoryInfo referenceDirectory)
    {
        var references = IndexReferenceElm(referenceDirectory);
        var divergences = new SortedDictionary<string, IReadOnlyList<Divergence>>(StringComparer.Ordinal);
        var noReference = new List<string>();
        var errors = new SortedDictionary<string, string>(StringComparer.Ordinal);
        foreach (var result in results.Where(r => r.Outcome == Outcome.Clean && r.ElmJson is not null))
        {
            if (!references.TryGetValue(result.Id, out var referenceFile))
            {
                noReference.Add(result.Id);
                continue;
            }

            try
            {
                var actual = ElmNormalizer.NormalizeLibraryJson(result.ElmJson!);
                var reference = ElmNormalizer.NormalizeLibraryJson(File.ReadAllText(referenceFile.FullName));
                divergences.Add(result.Id, ElmStructuralDiff.Compare(actual, reference));
            }
            catch (Exception e)
            {
                // The comparison is a report: one library it cannot compare must not stop the census.
                errors.Add(result.Id, $"{e.GetType().Name}: {e.Message}");
            }
        }

        return new ReferenceComparison(divergences, noReference, results.Count(r => r.Outcome != Outcome.Clean || r.ElmJson is null), errors);
    }

    /// <summary>
    /// The ELM JSON files of a directory, by the library identifier they declare, as the census names libraries.
    /// A file that is not ELM, or that declares no identifier, is left out.
    /// </summary>
    private static Dictionary<string, FileInfo> IndexReferenceElm(DirectoryInfo directory)
    {
        var index = new Dictionary<string, FileInfo>(StringComparer.Ordinal);
        if (!directory.Exists)
            return index;
        foreach (var file in directory.EnumerateFiles("*.json", SearchOption.AllDirectories).OrderBy(f => f.FullName, StringComparer.Ordinal))
        {
            string id;
            try
            {
                var identifier = System.Text.Json.Nodes.JsonNode.Parse(File.ReadAllText(file.FullName), documentOptions: ElmNormalizer.DocumentOptions)?["library"]?["identifier"];
                if (identifier?["id"] is not System.Text.Json.Nodes.JsonValue nameValue || !nameValue.TryGetValue<string>(out var name))
                    continue;
                var version = identifier["version"] is System.Text.Json.Nodes.JsonValue versionValue && versionValue.TryGetValue<string>(out var v) ? v : null;
                id = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(name, version).ToString();
            }
            catch (Exception e) when (e is System.Text.Json.JsonException or ArgumentException or FormatException or InvalidOperationException)
            {
                continue;
            }

            index.TryAdd(id, file);
        }

        return index;
    }

    /// <summary>
    /// The most divergences listed per library in the report; the counts per kind cover all of them.
    /// </summary>
    private const int MaxListedDivergences = 100;

    private static string BuildElmReport(CensusCorpus corpus, int checkedLibraries, List<CheckFailure> checkFailures, ReferenceComparison? comparison)
    {
        var report = new StringBuilder();
        report.AppendLine($"# ELM checks: {corpus.Name}");
        report.AppendLine($"Directory: {corpus.RelativeDirectory}");
        report.AppendLine($"Reference ELM: {corpus.ReferenceElmDirectory ?? "(none)"}");
        report.AppendLine();

        report.AppendLine("## Independent checkers (read back by the Hl7.Cql.Elm reader, valid against the ELM schema)");
        var clean = checkFailures.Where(f => f.Outcome == Outcome.Clean).ToList();
        var withErrors = checkFailures.Where(f => f.Outcome != Outcome.Clean).ToList();
        report.AppendLine($"Clean libraries checked: {checkedLibraries}, failed: {clean.Count}");
        AppendCheckFailures(report, clean);
        report.AppendLine($"Libraries with translation errors that fail a check (reported, not failing the test): {withErrors.Count}");
        AppendCheckFailures(report, withErrors);

        report.AppendLine();
        report.AppendLine("## Structural comparison with the reference ELM (a report, not a gate)");
        if (comparison is null)
        {
            report.AppendLine("This corpus has no reference ELM.");
            return report.ToString();
        }

        report.AppendLine(comparison.Summary);
        foreach (var id in comparison.NoReference)
            report.AppendLine($"No reference ELM: {id}");
        foreach (var (id, error) in comparison.ComparisonErrors)
            report.AppendLine($"Failed to compare: {id}: {error.ReplaceLineEndings(" ")}");
        report.AppendLine();

        report.AppendLine("### Histogram (libraries, occurrences, kind, property, normalized detail)");
        var histogram = comparison.Divergences
                                  .SelectMany(entry => entry.Value.Select(d => (Id: entry.Key, Key: $"{d.Kind}: {LastProperty(d.Path)}: {Normalize(d.Detail)}")))
                                  .GroupBy(x => x.Key, StringComparer.Ordinal)
                                  .Select(g => (Key: g.Key, Libraries: g.Select(x => x.Id).Distinct(StringComparer.Ordinal).Count(), Occurrences: g.Count()))
                                  .OrderByDescending(x => x.Libraries)
                                  .ThenByDescending(x => x.Occurrences)
                                  .ThenBy(x => x.Key, StringComparer.Ordinal);
        foreach (var (key, libraries, occurrences) in histogram)
            report.AppendLine(CultureInfo.InvariantCulture, $"{libraries,5} {occurrences,6}  {key}");
        report.AppendLine();

        report.AppendLine("### Libraries");
        foreach (var (id, divergences) in comparison.Divergences)
        {
            var perKind = string.Join(", ", divergences.GroupBy(d => d.Kind).OrderBy(g => g.Key).Select(g => $"{g.Key} {g.Count()}"));
            report.AppendLine($"{id}: {divergences.Count}{(divergences.Count > 0 ? $" ({perKind})" : "")}");
            foreach (var divergence in divergences.Take(MaxListedDivergences))
                report.AppendLine($"         {divergence.ToString().ReplaceLineEndings(" ")}");
            if (divergences.Count > MaxListedDivergences)
                report.AppendLine($"         … {divergences.Count - MaxListedDivergences} more");
        }

        return report.ToString();
    }

    /// <summary>
    /// The last property of a divergence path, without indexes or definition names:
    /// <c>statements[X].expression.operand[0]</c> gives <c>operand</c>. A definition key may itself hold brackets and
    /// dots, such as the operand types of a function, so only a dot outside brackets separates properties.
    /// </summary>
    private static string LastProperty(string path)
    {
        var depth = 0;
        var start = 0;
        for (var i = path.Length - 1; i >= 0; i--)
        {
            if (path[i] == ']')
                depth++;
            else if (path[i] == '[')
                depth--;
            else if (path[i] == '.' && depth == 0)
            {
                start = i + 1;
                break;
            }
        }

        var segment = path[start..];
        var bracket = segment.IndexOf('[');
        return bracket < 0 ? segment : segment[..bracket];
    }

    private static void AppendCheckFailures(StringBuilder report, IEnumerable<CheckFailure> failures)
    {
        foreach (var failure in failures)
        {
            report.AppendLine(failure.Id);
            foreach (var problem in failure.Problems)
                report.AppendLine($"         {problem.ReplaceLineEndings(" ")}");
        }
    }

    /// <summary>
    /// The counts of the ELM checks of a counts-only corpus: no library names, definition names or literals.
    /// </summary>
    private static string BuildElmCounts(CensusCorpus corpus, int checkedLibraries, int failedLibraries, int failedLibrariesWithErrors, ReferenceComparison? comparison)
    {
        var file = new StringBuilder();
        file.AppendLine($"# ELM check counts for {corpus.RelativeDirectory}; only counts, because the corpus is licensed content.");
        file.AppendLine(CultureInfo.InvariantCulture, $"checkedClean={checkedLibraries}");
        file.AppendLine(CultureInfo.InvariantCulture, $"checkFailuresClean={failedLibraries}");
        file.AppendLine(CultureInfo.InvariantCulture, $"checkFailuresWithErrors={failedLibrariesWithErrors}");
        if (comparison is null)
            return file.ToString();
        file.AppendLine(CultureInfo.InvariantCulture, $"compared={comparison.Divergences.Count}");
        file.AppendLine(CultureInfo.InvariantCulture, $"identical={comparison.IdenticalLibraries}");
        file.AppendLine(CultureInfo.InvariantCulture, $"noReference={comparison.NoReference.Count}");
        file.AppendLine(CultureInfo.InvariantCulture, $"notCompared={comparison.NotCompared}");
        file.AppendLine(CultureInfo.InvariantCulture, $"comparisonErrors={comparison.ComparisonErrors.Count}");
        foreach (var kind in Enum.GetValues<DivergenceKind>())
            file.AppendLine(CultureInfo.InvariantCulture, $"{kind}={comparison.Total(kind)}");
        return file.ToString();
    }

    #endregion

    #region Compilation

    /// <summary>
    /// The outcome of compiling one clean library to C# and an assembly.
    /// </summary>
    public enum CompileOutcome
    {
        /// <summary>The library compiled to an assembly.</summary>
        Compiled,

        /// <summary>A library it includes, directly or indirectly, did not translate cleanly, so it was not compiled.</summary>
        Blocked,

        /// <summary>The library itself failed to compile: in the ELM preprocessor, the code builder, C# generation or the C# compiler.</summary>
        Failed,

        /// <summary>A library it includes, directly or indirectly, was compiled with it and failed.</summary>
        Cascade,
    }

    /// <summary>
    /// The compile result of one clean library.
    /// </summary>
    /// <param name="Id">The library identifier, as in <see cref="LibraryResult.Id"/>.</param>
    /// <param name="Outcome">Whether it compiled, and if not, why.</param>
    /// <param name="Detail">For a library that did not compile, the dependency or the failure responsible.</param>
    private sealed record CompileResult(string Id, CompileOutcome Outcome, string? Detail = null);

    /// <summary>
    /// The number of clean libraries per compile outcome.
    /// </summary>
    private readonly record struct CompileCounts(int Compiled, int Blocked, int Failed, int Cascade)
    {
        public static CompileCounts Of(IReadOnlyList<CompileResult> results) =>
            new(results.Count(r => r.Outcome == CompileOutcome.Compiled),
                results.Count(r => r.Outcome == CompileOutcome.Blocked),
                results.Count(r => r.Outcome == CompileOutcome.Failed),
                results.Count(r => r.Outcome == CompileOutcome.Cascade));

        /// <summary>
        /// Parses <c>key=value</c> lines for the keys <c>compiled</c>, <c>blocked</c>, <c>failed</c> and <c>cascade</c>.
        /// </summary>
        public static CompileCounts Parse(IEnumerable<string> lines)
        {
            var values = lines
                         .Select(line => line.Split('=', 2))
                         .ToDictionary(parts => parts[0].Trim(), parts => int.Parse(parts[1].Trim(), CultureInfo.InvariantCulture), StringComparer.OrdinalIgnoreCase);
            return new(values["compiled"], values["blocked"], values["failed"], values["cascade"]);
        }

        public override string ToString() => $"compiled {Compiled}, blocked {Blocked}, failed {Failed}, cascade {Cascade}";
    }

    /// <summary>
    /// The compile stage of one corpus.
    /// </summary>
    /// <param name="Results">One result per clean library.</param>
    /// <param name="Counts">The number of results per outcome.</param>
    /// <param name="CandidatePath">Where the candidate compile baseline was written.</param>
    private sealed record CompileSummary(IReadOnlyList<CompileResult> Results, CompileCounts Counts, string CandidatePath);

    /// <summary>
    /// Compiles the clean libraries of a corpus, writes the compile report and the candidate compile baseline, and
    /// attaches them; for a counts-only corpus only the candidate, which holds counts, is attached.
    /// </summary>
    private CompileSummary CompileCorpus(CensusCorpus corpus, IReadOnlyList<LibraryResult> results, string outputDirectory)
    {
        var stopwatch = Stopwatch.StartNew();
        var compileResults = Compile(results);
        stopwatch.Stop();
        var counts = CompileCounts.Of(compileResults);

        var reportPath = Path.Combine(outputDirectory, $"{corpus.Name}.compile-report.txt");
        File.WriteAllText(reportPath, BuildCompileReport(corpus, compileResults, counts, stopwatch.Elapsed));
        var candidatePath = Path.Combine(outputDirectory, corpus.CompileBaselineFileName);
        File.WriteAllText(candidatePath, corpus.CountsOnly ? BuildCompileCountsFile(corpus, counts) : BuildKnownCompileFile(corpus, compileResults));
        if (!corpus.CountsOnly)
            TestContext.AddResultFile(reportPath);
        TestContext.AddResultFile(candidatePath);

        TestContext.WriteLine(string.Create(CultureInfo.InvariantCulture, $"{corpus.Name}: {counts} in {stopwatch.Elapsed.TotalSeconds:F1}s"));
        TestContext.WriteLine($"Compile report: {reportPath}");
        return new CompileSummary(compileResults, counts, candidatePath);
    }

    /// <summary>
    /// Compiles the ELM of every clean library to C# and an assembly, as the Java leg compiles the reference ELM.
    /// The ELM compiled is the JSON read back, which the ELM checks validated: what a consumer of the JSON gets.
    /// Returns one result per clean library.
    /// </summary>
    /// <remarks>
    /// A library is compiled together with the libraries it includes, so a library whose includes did not all
    /// translate cleanly is <see cref="CompileOutcome.Blocked"/> and is not compiled at all. Of the libraries compiled,
    /// one without an assembly has <see cref="CompileOutcome.Failed"/> itself, or, when a library it includes has no
    /// assembly either, is a <see cref="CompileOutcome.Cascade"/>.
    /// </remarks>
    private static IReadOnlyList<CompileResult> Compile(IReadOnlyList<LibraryResult> results)
    {
        var compileResults = new Dictionary<string, CompileResult>(StringComparer.Ordinal);
        var libraries = new Dictionary<string, Library>(StringComparer.Ordinal);
        foreach (var result in results.Where(r => r.Outcome == Outcome.Clean))
        {
            if (result.ElmJson is null)
            {
                compileResults[result.Id] = new CompileResult(result.Id, CompileOutcome.Failed, $"the ELM could not be written: {result.ElmWriteError}");
                continue;
            }

            try
            {
                libraries[result.Id] = Library.ParseFromJson(result.ElmJson);
            }
            catch (Exception e)
            {
                compileResults[result.Id] = new CompileResult(result.Id, CompileOutcome.Failed, $"the ELM could not be read: {e.GetType().Name}: {e.Message}");
            }
        }

        var includes = libraries.ToDictionary(
            entry => entry.Key,
            entry => (entry.Value.includes ?? []).Select(include => include.VersionedLibraryIdentifier.ToString()).ToArray(),
            StringComparer.Ordinal);

        // A library is blocked when any library it includes, directly or indirectly, cannot be compiled with it: one
        // that did not translate cleanly, or whose ELM could not be written or read back. The blocking library named
        // is that one, not a library in between that is itself blocked.
        var blockedBy = new Dictionary<string, string?>(StringComparer.Ordinal);
        string? BlockingInclude(string id, HashSet<string> visiting)
        {
            if (blockedBy.TryGetValue(id, out var known))
                return known;
            if (!visiting.Add(id))
                return null;
            string? blocking = null;
            foreach (var include in includes[id])
            {
                blocking = libraries.ContainsKey(include) ? BlockingInclude(include, visiting) : include;
                if (blocking is not null)
                    break;
            }

            visiting.Remove(id);
            blockedBy[id] = blocking;
            return blocking;
        }

        var toCompile = new List<(string Id, Library Library)>();
        foreach (var (id, library) in libraries)
        {
            if (BlockingInclude(id, []) is not { } blocking)
                toCompile.Add((id, library));
            else if (compileResults.ContainsKey(blocking))
                compileResults[id] = new CompileResult(id, CompileOutcome.Blocked, $"includes {blocking}, whose ELM could not be written or read back");
            else
                compileResults[id] = new CompileResult(id, CompileOutcome.Blocked, $"includes {blocking}, which did not translate cleanly");
        }

        var loggerFactory = new FailureCollectingLoggerFactory();
        var toolkit = new ElmToolkit(loggerFactory, new ElmToolkitConfig(AllowInvalidCSharp: false), BatchProcessExceptionContinuation.Continue)
                      .AddElmLibraries(toCompile.Select(c => c.Library))
                      .CompileToAssemblies();
        var compiled = toolkit.GetElmToAssemblyResults().Select(r => r.libraryIdentifier.ToString()).ToHashSet(StringComparer.Ordinal);

        // A library compiled with a library it includes that has no assembly fails because of that library. The one
        // named is the deepest such library, which failed itself, not a library in between that is itself a cascade.
        string? FailedInclude(string id, HashSet<string> visited)
        {
            foreach (var include in includes[id])
            {
                if (!visited.Add(include))
                    continue;
                if (FailedInclude(include, visited) is { } deeper)
                    return deeper;
                if (!compiled.Contains(include))
                    return include;
            }

            return null;
        }

        foreach (var (id, _) in toCompile)
        {
            if (compiled.Contains(id))
                compileResults[id] = new CompileResult(id, CompileOutcome.Compiled);
            else if (FailedInclude(id, []) is { } failedInclude)
                compileResults[id] = new CompileResult(id, CompileOutcome.Cascade, $"includes {failedInclude}, which failed to compile");
            else
                compileResults[id] = new CompileResult(id, CompileOutcome.Failed, loggerFactory.FailureOf(id) ?? "no assembly, and no failure was logged");
        }

        return compileResults.Values.OrderBy(r => r.Id, StringComparer.Ordinal).ToList();
    }

    /// <summary>
    /// Collects the failures the <see cref="ElmToolkit"/> logs, by the library they name. With
    /// <see cref="BatchProcessExceptionContinuation.Continue"/> it logs a failing library as a warning with the
    /// exception, and names the library in a <c>lib</c> or <c>id</c> argument.
    /// </summary>
    private sealed class FailureCollectingLoggerFactory : ILoggerFactory, ILogger
    {
        private readonly Dictionary<string, string> _failures = new(StringComparer.Ordinal);

        /// <summary>
        /// The first failure logged for the library: the log message, then the innermost exception's type and the first
        /// line of its message, followed by the line after it when the first ends in a colon, as a list of C# compiler
        /// errors does.
        /// </summary>
        public string? FailureOf(string id)
        {
            lock (_failures)
                return _failures.GetValueOrDefault(id);
        }

        public ILogger CreateLogger(string categoryName) => this;

        public void AddProvider(ILoggerProvider provider)
        {
        }

        public void Dispose()
        {
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Warning;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (exception is null || state is not IReadOnlyList<KeyValuePair<string, object?>> arguments)
                return;
            var library = arguments.FirstOrDefault(a => a.Key is "lib" or "id").Value?.ToString();
            if (library is null)
                return;

            // Wrappers such as "Exception occurred during expression building" carry the cause as their inner exception.
            while (exception.InnerException is { } inner)
                exception = inner;
            var lines = exception.Message.ReplaceLineEndings("\n").Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var message = lines.Length switch
            {
                0 => "",
                > 1 when lines[0].EndsWith(':') => $"{lines[0]} {lines[1]}",
                _ => lines[0],
            };
            lock (_failures)
                _failures.TryAdd(library, $"{formatter(state, null)}: {exception.GetType().Name}: {message}");
        }
    }

    /// <summary>
    /// Fails when a listed library no longer compiles or is no longer clean; reports compiled libraries that are not
    /// listed as warnings.
    /// </summary>
    private void CompareKnownCompile(CensusCorpus corpus, IReadOnlyList<CompileResult> results, string baselinePath)
    {
        var expected = new HashSet<string>(ReadBaselineLines(baselinePath), StringComparer.Ordinal);
        var byId = results.ToDictionary(r => r.Id, StringComparer.Ordinal);

        var lost = expected.Where(id => !byId.ContainsKey(id)).OrderBy(id => id, StringComparer.Ordinal).ToList();
        var regressed = expected.Where(byId.ContainsKey).Select(id => byId[id]).Where(r => r.Outcome != CompileOutcome.Compiled).OrderBy(r => r.Id, StringComparer.Ordinal).ToList();
        foreach (var r in results.Where(r => r.Outcome == CompileOutcome.Compiled && !expected.Contains(r.Id)))
            TestContext.WriteLine($"WARNING: {r.Id} now compiles but is not listed in {corpus.CompileBaselineFileName}; add it.");

        if (lost.Count == 0 && regressed.Count == 0)
            return;

        var message = new StringBuilder($"{corpus.Name}: libraries listed in {corpus.CompileBaselineFileName} no longer compile.");
        foreach (var r in regressed)
            message.AppendLine().Append($"  {r.Id}: {r.Outcome}: {r.Detail}");
        foreach (var id in lost)
            message.AppendLine().Append($"  {id}: no longer translates cleanly");
        Assert.Fail(message.ToString());
    }

    /// <summary>
    /// Fails when fewer clean libraries compile than the committed count. Only counts are reported, never library names.
    /// </summary>
    private void CompareCompileCounts(CensusCorpus corpus, CompileCounts counts, string baselinePath)
    {
        var baseline = CompileCounts.Parse(ReadBaselineLines(baselinePath));
        if (counts.Compiled > baseline.Compiled)
            TestContext.WriteLine($"WARNING: {corpus.Name} now has {counts.Compiled} compiling libraries; the baseline has {baseline.Compiled}. Copy the candidate compile counts file into Input/Census.");
        if (counts.Compiled < baseline.Compiled)
            Assert.Fail($"{corpus.Name}: {counts.Compiled} libraries compile, below the baseline of {baseline.Compiled}. Now {counts}; baseline {baseline}. See the compile report file for details.");
    }

    private static string BuildCompileReport(CensusCorpus corpus, IReadOnlyList<CompileResult> results, CompileCounts counts, TimeSpan elapsed)
    {
        var report = new StringBuilder();
        report.AppendLine($"# Compile census: {corpus.Name}");
        report.AppendLine($"Directory: {corpus.RelativeDirectory}");
        report.AppendLine($"Clean libraries: {results.Count}");
        report.AppendLine($"Summary: {counts}");
        report.AppendLine(CultureInfo.InvariantCulture, $"Elapsed: {elapsed.TotalSeconds:F1}s");
        report.AppendLine();

        report.AppendLine("## Histogram of failures (libraries, normalized failure)");
        var histogram = results
                        .Where(r => r.Outcome == CompileOutcome.Failed)
                        .GroupBy(r => Normalize(r.Detail ?? ""), StringComparer.Ordinal)
                        .Select(g => (Failure: g.Key, Libraries: g.Count()))
                        .OrderByDescending(x => x.Libraries)
                        .ThenBy(x => x.Failure, StringComparer.Ordinal);
        foreach (var (failure, libraries) in histogram)
            report.AppendLine(CultureInfo.InvariantCulture, $"{libraries,5}  {failure}");
        report.AppendLine();

        report.AppendLine("## Libraries");
        foreach (var r in results)
        {
            report.AppendLine($"{r.Outcome,-8} {r.Id}");
            if (r.Detail is { } detail)
                report.AppendLine($"         {detail.ReplaceLineEndings(" ")}");
        }

        return report.ToString();
    }

    private static string BuildKnownCompileFile(CensusCorpus corpus, IReadOnlyList<CompileResult> results)
    {
        var file = new StringBuilder();
        file.AppendLine($"# Libraries in {corpus.RelativeDirectory} whose .NET-translated ELM compiles to an assembly");
        if (corpus.Models.Length > 0)
            file.AppendLine($"# with models {string.Join(", ", corpus.Models)}.");
        file.AppendLine("# Checked by TranslatorCensusTest: a listed library that no longer compiles fails the test.");
        file.AppendLine("# Refresh by copying the candidate file the test writes next to its report over this one; see README.md.");
        foreach (var id in results.Where(r => r.Outcome == CompileOutcome.Compiled).Select(r => r.Id))
            file.AppendLine(id);
        return file.ToString();
    }

    private static string BuildCompileCountsFile(CensusCorpus corpus, CompileCounts counts)
    {
        var file = new StringBuilder();
        file.AppendLine($"# Compile outcome counts of the clean libraries in {corpus.RelativeDirectory}.");
        file.AppendLine("# Checked by TranslatorCensusTest: the test fails when fewer libraries than 'compiled' compile to an assembly.");
        file.AppendLine("# Only counts are kept here because the corpus is licensed content; see README.md.");
        file.AppendLine("# Refresh by copying the candidate file the test writes next to its report over this one.");
        file.AppendLine(CultureInfo.InvariantCulture, $"compiled={counts.Compiled}");
        file.AppendLine(CultureInfo.InvariantCulture, $"blocked={counts.Blocked}");
        file.AppendLine(CultureInfo.InvariantCulture, $"failed={counts.Failed}");
        file.AppendLine(CultureInfo.InvariantCulture, $"cascade={counts.Cascade}");
        return file.ToString();
    }

    #endregion

    #region Counts, report and baseline files

    /// <summary>
    /// The number of libraries per outcome.
    /// </summary>
    private readonly record struct CensusCounts(int Total, int Clean, int Errors, int Crash)
    {
        public static CensusCounts Of(IReadOnlyList<LibraryResult> results) =>
            new(results.Count,
                results.Count(r => r.Outcome == Outcome.Clean),
                results.Count(r => r.Outcome == Outcome.Errors),
                results.Count(r => r.Outcome == Outcome.Crash));

        /// <summary>
        /// Parses <c>key=value</c> lines for the keys <c>total</c>, <c>clean</c>, <c>errors</c> and <c>crash</c>.
        /// </summary>
        public static CensusCounts Parse(IEnumerable<string> lines)
        {
            var values = lines
                         .Select(line => line.Split('=', 2))
                         .ToDictionary(parts => parts[0].Trim(), parts => int.Parse(parts[1].Trim(), CultureInfo.InvariantCulture), StringComparer.OrdinalIgnoreCase);
            return new(values["total"], values["clean"], values["errors"], values["crash"]);
        }

        public override string ToString() => $"total {Total}, clean {Clean}, errors {Errors}, crash {Crash}";
    }

    private static readonly Regex DoubleQuoted = new("\"[^\"]*\"", RegexOptions.Compiled);
    private static readonly Regex SingleQuoted = new("'[^']*'", RegexOptions.Compiled);
    private static readonly Regex Digits = new(@"\b[0-9]+\b", RegexOptions.Compiled);

    /// <summary>
    /// Replaces quoted strings and stand-alone digit runs, so messages that differ only in identifiers
    /// or positions group together. Digits inside a word (<c>hl7</c>, <c>net8</c>) are kept.
    /// </summary>
    private static string Normalize(string message)
    {
        var normalized = DoubleQuoted.Replace(message, "\"…\"");
        normalized = SingleQuoted.Replace(normalized, "'…'");
        normalized = Digits.Replace(normalized, "N");
        return normalized.ReplaceLineEndings(" ");
    }

    private static string BuildReport(CensusCorpus corpus, int cqlFileCount, IReadOnlyList<LibraryResult> results, CensusCounts counts, TimeSpan elapsed)
    {
        var report = new StringBuilder();
        report.AppendLine($"# Translator census: {corpus.Name}");
        report.AppendLine($"Directory: {corpus.RelativeDirectory}");
        report.AppendLine($"Additional models: {(corpus.Models.Length == 0 ? "(none)" : string.Join(", ", corpus.Models))}");
        report.AppendLine($"Framework: {RuntimeInformationDescription}");
        report.AppendLine($"CQL files: {cqlFileCount}");
        report.AppendLine($"Summary: {counts}");
        report.AppendLine(CultureInfo.InvariantCulture, $"Elapsed: {elapsed.TotalSeconds:F1}s");
        var unspecified = results.Sum(r => r.UnspecifiedSeverityCount);
        if (unspecified > 0)
            report.AppendLine($"Annotations without a specified severity (counted as info): {unspecified}");
        report.AppendLine();

        report.AppendLine("## Histogram (libraries, occurrences, normalized message)");
        var histogram = results
                        .SelectMany(r => r.HistogramMessages.Select(message => (r.Id, Message: message)))
                        .GroupBy(x => x.Message, StringComparer.Ordinal)
                        .Select(g => (Message: g.Key, Libraries: g.Select(x => x.Id).Distinct(StringComparer.Ordinal).Count(), Occurrences: g.Count()))
                        .OrderByDescending(x => x.Libraries)
                        .ThenByDescending(x => x.Occurrences)
                        .ThenBy(x => x.Message, StringComparer.Ordinal);
        foreach (var (message, libraries, occurrences) in histogram)
            report.AppendLine(CultureInfo.InvariantCulture, $"{libraries,5} {occurrences,6}  {message}");
        report.AppendLine();

        report.AppendLine("## Libraries");
        foreach (var r in results)
        {
            report.AppendLine($"{r.Outcome,-6} {r.Id}");
            foreach (var line in r.ReportLines)
                report.AppendLine($"         {line}");
        }

        return report.ToString();
    }

    private static string RuntimeInformationDescription => System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

    private static string BuildKnownPassFile(CensusCorpus corpus, IReadOnlyList<LibraryResult> results)
    {
        var file = new StringBuilder();
        file.AppendLine($"# Libraries in {corpus.RelativeDirectory} that the .NET translator translates without errors");
        if (corpus.Models.Length > 0)
            file.AppendLine($"# with models {string.Join(", ", corpus.Models)}.");
        file.AppendLine("# Checked by TranslatorCensusTest: a listed library that no longer translates cleanly fails the test.");
        file.AppendLine("# Refresh by copying the candidate file the test writes next to its report over this one; see README.md.");
        foreach (var id in results.Where(r => r.Outcome == Outcome.Clean).Select(r => r.Id).OrderBy(id => id, StringComparer.Ordinal))
            file.AppendLine(id);
        return file.ToString();
    }

    private static string BuildCountsFile(CensusCorpus corpus, CensusCounts counts)
    {
        var file = new StringBuilder();
        file.AppendLine($"# Translation outcome counts for {corpus.RelativeDirectory}.");
        file.AppendLine("# Checked by TranslatorCensusTest: the test fails when fewer libraries than 'clean' translate without errors.");
        file.AppendLine("# Only counts are kept here because the corpus is licensed content; see README.md.");
        file.AppendLine("# Refresh by copying the candidate file the test writes next to its report over this one.");
        file.AppendLine(CultureInfo.InvariantCulture, $"total={counts.Total}");
        file.AppendLine(CultureInfo.InvariantCulture, $"clean={counts.Clean}");
        file.AppendLine(CultureInfo.InvariantCulture, $"errors={counts.Errors}");
        file.AppendLine(CultureInfo.InvariantCulture, $"crash={counts.Crash}");
        return file.ToString();
    }

    #endregion
}
