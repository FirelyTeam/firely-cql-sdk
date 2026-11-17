/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Threading;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test;

[TestClass]
public class SaveElmFilesToDirectoryTest : Base
{
    private const string Cql = """
        library SaveElmFilesToDirectory version '1.0.0'

        define private "answer": not true
        """;

    private const int TooDeepForTheSerializer = 5000;
    private const int DeepStackBytes = 256 * 1024 * 1024;

    private static DirectoryInfo NewDirectory() =>
        Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "SaveElmFilesToDirectory-" + Guid.NewGuid().ToString("N")));

    private static (Library library, string fileName) Translate(CqlToolkit cqlToolkit, DirectoryInfo directory)
    {
        var library = cqlToolkit.MakeLibrary(Cql);
        var (libraryIdentifier, _) = cqlToolkit.GetCqlToolkitResults().Single();
        return (library, Path.Combine(directory.FullName, $"{libraryIdentifier}.json"));
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void Save_OverALongerExistingFile_LeavesExactlyTheSerializedUtf8Bytes(bool writeIndented)
    {
        var directory = NewDirectory();
        try
        {
            var cqlToolkit = CreateCqlToolkit();
            var (library, fileName) = Translate(cqlToolkit, directory);
            var expected = Encoding.UTF8.GetBytes(library.SerializeToJson(writeIndented));
            File.WriteAllText(fileName, new string('x', expected.Length + 1000));

            cqlToolkit.SaveElmFilesToDirectory(directory, writeIndented);

            File.ReadAllBytes(fileName).Should().Equal(expected);
            directory.GetFiles().Should().ContainSingle().Which.FullName.Should().Be(fileName);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void Save_OfALibraryThatCannotBeWritten_KeepsTheOldFileAndLeavesNothingElse(bool writeIndented)
    {
        var directory = NewDirectory();
        try
        {
            var cqlToolkit = CreateCqlToolkit();
            var (library, fileName) = Translate(cqlToolkit, directory);
            const string oldContent = """{"library":"old content"}""";
            File.WriteAllText(fileName, oldContent);
            library.statements.Single().expression = NestedNots(TooDeepForTheSerializer);

            Exception? failure = null;
            var thread = new Thread(() =>
            {
                try { cqlToolkit.SaveElmFilesToDirectory(directory, writeIndented); }
                catch (Exception e) { failure = e; }
            }, DeepStackBytes);
            thread.Start();
            thread.Join();

            failure.Should().NotBeNull();
            File.ReadAllText(fileName).Should().Be(oldContent);
            directory.GetFiles().Should().ContainSingle().Which.FullName.Should().Be(fileName);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    [TestMethod]
    public void Save_OfALibraryThatCannotBeWritten_LeavesNoFileWhenNoneExisted()
    {
        var directory = NewDirectory();
        try
        {
            var cqlToolkit = CreateCqlToolkit();
            var (library, _) = Translate(cqlToolkit, directory);
            library.statements.Single().expression = NestedNots(TooDeepForTheSerializer);

            Exception? failure = null;
            var thread = new Thread(() =>
            {
                try { cqlToolkit.SaveElmFilesToDirectory(directory); }
                catch (Exception e) { failure = e; }
            }, DeepStackBytes);
            thread.Start();
            thread.Join();

            failure.Should().NotBeNull();
            directory.GetFiles().Should().BeEmpty();
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    private static Expression NestedNots(int depth)
    {
        Expression expression = new Literal { value = "true", valueType = new System.Xml.XmlQualifiedName("Boolean", "urn:hl7-org:elm-types:r1") };
        for (var i = 0; i < depth; i++)
            expression = new Not { operand = expression };
        return expression;
    }
}
