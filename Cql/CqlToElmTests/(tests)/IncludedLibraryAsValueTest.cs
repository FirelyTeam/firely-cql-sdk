/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.CqlToElm.Test;

[TestClass]
public class IncludedLibraryAsValueTest : Base
{
    private const string Cql = """
        library IncludedLibraryAsValue version '1.0.0'

        include FHIRHelpers version '4.0.1' called FH

        define private "actual": FH
        """;

    private static Library MakeLibraryWithError(CqlToolkit cqlToolkit) =>
        cqlToolkit.MakeLibrary(Cql, cqlToolkit.GetMessageProvider().ExpressionCannotBeLibraryRef("FH"));

    [TestMethod]
    public void IncludedLibraryAsValue_IsNotAnIncludeRef_AndSerializes()
    {
        var library = MakeLibraryWithError(CreateCqlToolkit().AddFHIRHelpers());

        library.statements.Single().expression.Should().NotBeOfType<IncludeRef>();

        var json = library.SerializeToJson();
        json.Should().NotContain("IncludeRef");
    }

    [TestMethod]
    public void IncludedLibraryAsValue_ElmFileIsSaved()
    {
        var directory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "IncludedLibraryAsValue-" + Guid.NewGuid().ToString("N")));
        try
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            MakeLibraryWithError(cqlToolkit);

            cqlToolkit.SaveElmFilesToDirectory(directory);

            var file = directory.GetFiles("IncludedLibraryAsValue*.json").Should().ContainSingle().Subject;
            File.ReadAllText(file.FullName).Should().NotContain("IncludeRef");
        }
        finally
        {
            if (directory.Exists)
                directory.Delete(recursive: true);
        }
    }

    [TestMethod]
    public void UsingIncludeAndFunction_SerializesAndParsesBack()
    {
        var library = CreateCqlToolkit().AddFHIRHelpers().MakeLibrary("""
            library UsingIncludeAndFunction version '1.0.0'

            using FHIR version '4.0.1'

            include FHIRHelpers version '4.0.1' called FH

            define function "Twice"(x Integer): x * 2

            define private "actual": "Twice"(2)
            """);

        var json = library.SerializeToJson();
        var parsed = Library.ParseFromJson(json);

        parsed.statements.Select(s => s.name).Should().Contain("actual");
        parsed.includes.Should().ContainSingle(i => i.localIdentifier == "FH");
    }
}
