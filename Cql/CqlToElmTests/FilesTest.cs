using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Hl7.Cql.Elm;
using FluentAssertions;
using Hl7.Cql.Runtime;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Hl7.Cql.Compiler;

namespace Hl7.Cql.CqlToElm.Test;

[TestClass]
public class FilesTest : Base
{
    // change to a path containing CQL; can include subdirectories.
    public const string Path = "C:\\Code\\Ncqa.HT.Firely\\Hedis2023\\Cql\\input";

    [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
    public static void Initialize(TestContext context)
    {
        var sc = ServiceCollection(opt =>
        {
            opt.Input = Path;
            opt.AmbiguousTypeBehavior = AmbiguousTypeBehavior.PreferModel; // match the ref implementation behavior
        },
        libraryProviderType: typeof(FileSystemLibraryProvider));
        Services = sc.BuildServiceProvider();

        var loggerFactory = Services.GetRequiredService<ILoggerFactory>();
        var cqlCompilerFactory = new CqlCompilerFactory(loggerFactory, cancellationToken: default, cacheSize: default);
        var libraryExpressionBuilder = cqlCompilerFactory.LibraryExpressionBuilder;
        LibraryExpressionBuilder = libraryExpressionBuilder;
    }
#pragma warning restore IDE0060 // Remove unused parameter

    internal static FileSystemLibraryProvider LibraryProvider => (FileSystemLibraryProvider)Services.GetRequiredService<ILibraryProvider>();

    private void TestLibrary(FileInfo fileInfo)
    {
        if (!LibraryProvider.TryResolveLibrary(fileInfo, out var _))
        {
            System.Diagnostics.Debug.WriteLine($"Processing {fileInfo.FullName}");
            var cql = File.ReadAllText(fileInfo.FullName);
            var builder = MakeLibraryBuilder(Services, cql);
            var lib = builder.Build();
            LibraryProvider.TryAddLibrary(lib.identifier.id, lib.identifier.version, fileInfo, builder);
            var errors = lib.GetErrors();
            errors.Should().BeEmpty();


            //var eb = LibraryExpressionBuilder;
            //var lambdas = eb.ProcessLibrary(lib);
            //var delegates = lambdas.CompileAll();
        }
    }

    [TestMethod]
    public void SingleFile() => TestLibrary(new FileInfo(@"C:\Code\Ncqa.HT.Firely\Hedis2023\Cql\input\measures\ENP\ENP_Details-2023.0.0.cql"));

    [DynamicData(nameof(GetTests), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DisplayName))]
    [TestMethod]
    public void Run(FileInfo file)
    {
        TestLibrary(file);
    }
    public static string DisplayName(MethodInfo method, object[] data)
    {
        var file = (FileInfo)data[0];
        return file.Name;
    }

    public static IEnumerable<object[]> GetTests()
    {
        foreach (var f in GetFiles(new DirectoryInfo(Path)))
            yield return new object[] { f };
        IEnumerable<FileInfo> GetFiles(DirectoryInfo dir)
        {
            foreach (var file in dir.EnumerateFiles("*.cql"))
                yield return file;
            foreach (var subdir in dir.EnumerateDirectories())
                foreach (var f in GetFiles(subdir))
                    yield return f;
        }
    }


}
