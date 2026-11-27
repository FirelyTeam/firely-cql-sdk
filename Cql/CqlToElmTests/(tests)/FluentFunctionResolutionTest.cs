/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// Which function a fluent call resolves to when the calling library and its includes define fluent functions of the
/// same name. As the reference translator does: a function of the calling library wins, and otherwise the includes are
/// searched in the order they are declared, and the first library with an applicable overload wins, even when a later
/// library has an overload that matches better.
/// </summary>
[TestClass]
public class FluentFunctionResolutionTest
{
    private static CqlToolkit Toolkit(params string[] includedLibraries)
    {
        var toolkit = new CqlToolkit(config: CqlToolkitConfig.Default);
        foreach (var cql in includedLibraries)
            toolkit.MakeLibrary(cql);
        return toolkit;
    }

    private static string Library(string name, string operandType) => $$"""
        library {{name}} version '1.0.0'

        define fluent function Conflict(x {{operandType}}): '{{name}}'
        """;

    private static FunctionRef CallsConflict(Library library) =>
        library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<FunctionRef>().Subject;

    [DataTestMethod]
    [DataRow("Foo", "Bar", "Foo")]
    [DataRow("Bar", "Foo", "Bar")]
    public void Identical_Overloads_In_Two_Includes_Resolve_To_The_First_Include(string first, string second, string expected)
    {
        var library = Toolkit(Library("Foo", "Integer"), Library("Bar", "Integer")).MakeLibrary($$"""
            library Caller version '1.0.0'

            include {{first}} version '1.0.0'
            include {{second}} version '1.0.0'

            define callsConflict: 1.Conflict()
            """);

        var call = CallsConflict(library);
        call.libraryName.Should().Be(expected);
        call.operand.Should().ContainSingle().Which.Should().BeOfType<Literal>();
    }

    [TestMethod]
    public void An_Applicable_Overload_In_An_Earlier_Include_Wins_Over_An_Exact_One_In_A_Later_Include()
    {
        var library = Toolkit(Library("D", "Decimal"), Library("I", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include D version '1.0.0'
            include I version '1.0.0'

            define callsConflict: 1.Conflict()
            """);

        var call = CallsConflict(library);
        call.libraryName.Should().Be("D");
        call.operand.Should().ContainSingle().Which.Should().BeOfType<ToDecimal>();
    }

    [TestMethod]
    public void An_Include_Without_An_Applicable_Overload_Is_Skipped()
    {
        var library = Toolkit(Library("S", "String"), Library("I", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include S version '1.0.0'
            include I version '1.0.0'

            define callsConflict: 1.Conflict()
            """);

        CallsConflict(library).libraryName.Should().Be("I");
    }

    [TestMethod]
    public void An_Applicable_Overload_In_The_Calling_Library_Wins_Over_An_Exact_One_In_An_Include()
    {
        var library = Toolkit(Library("I", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include I version '1.0.0'

            define fluent function Conflict(x Decimal): 'local'

            define callsConflict: 1.Conflict()
            """);

        var call = CallsConflict(library);
        call.libraryName.Should().BeNull();
        call.operand.Should().ContainSingle().Which.Should().BeOfType<ToDecimal>();
    }

    [TestMethod]
    public void An_Overload_In_The_Calling_Library_With_The_Same_Signature_As_An_Include_Wins()
    {
        var library = Toolkit(Library("I", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include I version '1.0.0'

            define fluent function Conflict(x Integer): 'local'

            define callsConflict: 1.Conflict()
            """);

        CallsConflict(library).libraryName.Should().BeNull();
    }

    [TestMethod]
    public void A_Call_To_An_Included_Function_Names_The_Include_By_Its_Local_Identifier()
    {
        var library = Toolkit(Library("Foo", "Integer"), Library("Bar", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include Foo version '1.0.0' called F
            include Bar version '1.0.0' called B

            define callsConflict: 1.Conflict()
            """);

        CallsConflict(library).libraryName.Should().Be("F");
    }

    [TestMethod]
    public void A_Fluent_Call_Without_An_Applicable_Overload_Is_Reported()
    {
        var library = Toolkit(Library("S", "String"), Library("D", "Date")).MakeLibrary("""
            library Caller version '1.0.0'

            include S version '1.0.0'
            include D version '1.0.0'

            define callsConflict: 1.Conflict()
            """,
            "Could not resolve call to operator Conflict with signature (Integer).");

        CallsConflict(library).libraryName.Should().BeNull();
    }
}
