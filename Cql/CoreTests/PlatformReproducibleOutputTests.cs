/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using DateTime = System.DateTime;
using Library = Hl7.Cql.Elm.Library;
using ElmLibrarySet = Hl7.Cql.Compiler.LibrarySet;

namespace CoreTests;

/// <summary>
/// Pins that packaging the same inputs produces the same bytes on every operating system.
/// </summary>
/// <remarks>
/// The generated C# and the CQL are embedded as base64 attachments on a packaged FHIR Library, where git
/// cannot normalize them the way it normalizes a file on disk. A newline taken from the environment, or a
/// CQL file embedded as checked out, therefore makes a checked-in packaged resource a record of the
/// machine that built it. These tests feed both newline styles deliberately, because a test that only
/// exercises whatever the host platform uses would pass on both the broken and the fixed code.
/// </remarks>
[TestClass]
public class PlatformReproducibleOutputTests
{
    private const string Lf = "\n";
    private const string CrLf = "\r\n";

    [TestMethod]
    public void GeneratedCSharp_UsesAFixedNewLine_NotThePlatformOne()
    {
        var isb = new IndentedStringBuilder();
        isb.AppendLine("class A");
        isb.AppendLine("{");
        isb.AppendLine("}");

        var generated = isb.ToString();

        Assert.IsFalse(generated.Contains('\r'), "Generated C# should not contain CR, whatever the host platform uses.");
        Assert.AreEqual($"class A{Lf}{{{Lf}}}{Lf}", generated);
    }

    [TestMethod]
    public void GeneratedCSharp_IsTheSameWhicheverNewLineTheInputUses()
    {
        static string Build(string newLine)
        {
            var isb = new IndentedStringBuilder();
            isb.AppendLine($"// first{newLine}// second{newLine}// third");
            return isb.ToString();
        }

        Assert.AreEqual(Build(Lf), Build(CrLf));
        Assert.IsFalse(Build(CrLf).Contains('\r'));
    }

    [TestMethod]
    public void GeneratedCSharp_IndentsEveryLineOfAMultilineAppend_RegardlessOfNewLineStyle()
    {
        static string Build(string newLine)
        {
            var isb = new IndentedStringBuilder();
            using (isb.Indent())
            {
                isb.AppendLine($"a{newLine}b");
            }

            return isb.ToString();
        }

        // Splitting on only one style would leave the second line unindented and embedded in the first.
        var expected = $"    a{Lf}    b{Lf}";
        Assert.AreEqual(expected, Build(Lf));
        Assert.AreEqual(expected, Build(CrLf));
    }

    /// <summary>
    /// Packages the same library twice, with the CQL written each way, and compares the attachment the
    /// packager actually produces.
    /// </summary>
    /// <remarks>
    /// Deliberately goes through <see cref="ResourcePackager"/> rather than calling the normalization
    /// helper directly: a test on the helper alone stays green if the production call site is removed,
    /// which is the regression that matters.
    /// </remarks>
    [TestMethod]
    public void PackagedCqlAttachment_IsTheSameWhicheverNewLineTheSourceFileUses()
    {
        const string cqlTemplate = "library Test version '1.0.0'@@define \"X\": true@";

        var lf = PackageAndReadCqlAttachment(cqlTemplate.Replace("@", Lf));
        var crlf = PackageAndReadCqlAttachment(cqlTemplate.Replace("@", CrLf));

        Assert.IsFalse(crlf.Contains((byte)'\r'), "The packaged CQL attachment carried a CR.");
        CollectionAssert.AreEqual(lf, crlf);
    }

    private static byte[] PackageAndReadCqlAttachment(string cql)
    {
        var elmLibrary = new Library
        {
            identifier = new VersionedIdentifier { id = "Test", version = "1.0.0" },
        };

        var packager = new ResourcePackager(
            new FhirTypeResolver(ModelInfo.ModelInspector),
            (_, _, _) => "test.firely");

        var packaged = packager.PackageEachElmLibraryToFhirResources(
            librarySet: new ElmLibrarySet("", [elmLibrary]),
            inputsById: _ => new ResourcePackager.InputArtifacts(cql, elmLibrary, "namespace Test {}", [], null),
            overrideDate: new DateTime(2001, 2, 3, 4, 5, 6, DateTimeKind.Local)).Single();

        return packaged.fhirLibrary.Content
                       .Single(c => c.ContentType == "text/cql")
                       .Data!;
    }

    [TestMethod]
    public void NormalizeNewLines_LeavesTextWithoutCarriageReturnsAlone()
    {
        var text = $"a{Lf}b{Lf}";

        Assert.AreSame(text, ResourcePackager.NormalizeNewLines(text));
    }

    [TestMethod]
    public void NormalizeNewLines_RewritesALoneCarriageReturn()
    {
        Assert.AreEqual($"a{Lf}b", ResourcePackager.NormalizeNewLines("a\rb"));
    }
}
