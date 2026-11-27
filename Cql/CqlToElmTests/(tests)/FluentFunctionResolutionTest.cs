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
/// same name. As the reference translator does: the functions of the calling library are searched first, then the
/// system operators, then the includes in the order they are declared, and the first with an applicable overload wins,
/// even when a later one has an overload that matches better.
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
    public void A_Call_On_The_Sorted_Element_Resolves_To_The_First_Include()
    {
        var library = Toolkit(Library("Foo", "Integer"), Library("Bar", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include Foo version '1.0.0' called F
            include Bar version '1.0.0' called B

            define callsConflict: ({1, 2}) X sort by Conflict()
            """);

        var sortBy = library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<Query>().Subject
                            .sort.by.Should().ContainSingle().Which.Should().BeOfType<ByExpression>().Subject;
        var call = sortBy.expression.Should().BeOfType<FunctionRef>().Subject;
        call.libraryName.Should().Be("F");
        call.operand.Should().ContainSingle().Which.Should().BeOfType<IdentifierRef>();
    }

    [TestMethod]
    public void A_Call_Qualified_By_A_Library_In_A_Sort_Is_Not_A_Call_On_The_Sorted_Element()
    {
        var library = Toolkit(Library("Foo", "Integer"), Library("Bar", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include Foo version '1.0.0'
            include Bar version '1.0.0'

            define callsConflict: ({1, 2}) X sort by Bar.Conflict()
            """,
            "Could not resolve call to operator Conflict with signature ().");

        var sortBy = library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<Query>().Subject
                            .sort.by.Should().ContainSingle().Which.Should().BeOfType<ByExpression>().Subject;
        sortBy.expression.Should().BeOfType<FunctionRef>().Which.libraryName.Should().NotBe("Foo");
    }

    [TestMethod]
    public void A_Fluent_Call_In_A_Sort_Is_Not_A_Call_On_The_Sorted_Element()
    {
        // F(x, y) would apply to the sorted element and the target; the fluent call has its own target, so it is F(5).
        var library = Toolkit("""
            library Two version '1.0.0'

            define fluent function F(x Integer): 'one'
            define fluent function F(x Integer, y Integer): 'two'
            """).MakeLibrary("""
            library Caller version '1.0.0'

            include Two version '1.0.0'

            define callsConflict: ({1, 2}) X sort by 5.F()
            """);

        var sortBy = library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<Query>().Subject
                            .sort.by.Should().ContainSingle().Which.Should().BeOfType<ByExpression>().Subject;
        var call = sortBy.expression.Should().BeOfType<FunctionRef>().Subject;
        call.libraryName.Should().Be("Two");
        call.operand.Should().ContainSingle().Which.Should().BeOfType<Literal>();
    }

    [TestMethod]
    public void An_Applicable_Function_Of_The_Calling_Library_Wins_Over_An_Exact_System_Operator()
    {
        var library = new CqlToolkit(config: CqlToolkitConfig.Default).MakeLibrary("""
            library Caller version '1.0.0'

            define fluent function Abs(x Decimal): 'local'

            define callsConflict: 1.Abs()
            """);

        var call = CallsConflict(library);
        call.libraryName.Should().BeNull();
        call.operand.Should().ContainSingle().Which.Should().BeOfType<ToDecimal>();
    }

    [TestMethod]
    public void Fluent_Calls_In_A_Function_Body_And_A_Query_Search_The_Includes_Of_The_Library()
    {
        var library = Toolkit(Library("Foo", "Integer"), Library("Bar", "Integer")).MakeLibrary("""
            library Caller version '1.0.0'

            include Foo version '1.0.0'
            include Bar version '1.0.0'

            define function G(): 1.Conflict()
            define callsConflict: ({1, 2}) X return X.Conflict()
            """);

        library.statements.OfType<FunctionDef>().Single().expression.Should().BeOfType<FunctionRef>()
               .Which.libraryName.Should().Be("Foo");
        library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<Query>()
               .Which.@return.expression.Should().BeOfType<FunctionRef>().Which.libraryName.Should().Be("Foo");
    }

    [TestMethod]
    public void A_Candidate_On_Which_The_Call_Is_Ambiguous_Is_Skipped()
    {
        // The calling library has two equally good overloads for null, so the call goes on to the include.
        var library = Toolkit(Library("D", "Decimal")).MakeLibrary("""
            library Caller version '1.0.0'

            include D version '1.0.0'

            define fluent function Conflict(x Integer): 'Integer'
            define fluent function Conflict(x String): 'String'

            define callsConflict: null.Conflict()
            """);

        CallsConflict(library).libraryName.Should().Be("D");
    }

    [TestMethod]
    public void A_System_Operator_Applicable_To_A_Fluent_Call_Wins_Over_An_Included_Fluent_Function()
    {
        // The system Truncate(Decimal) applies to an Integer, so it is the candidate found first; it is not fluent,
        // so the call is an error, as in the reference translator.
        var library = Toolkit("""
            library I version '1.0.0'

            define fluent function Truncate(x Integer): 'I'
            """).MakeLibrary("""
            library Caller version '1.0.0'

            include I version '1.0.0'

            define callsConflict: 1.Truncate()
            """,
            "Function 'Truncate' is called fluently, but its definition is not marked as fluent.");

        library.statements.Single(d => d.name == "callsConflict").expression.Should().BeOfType<Truncate>();
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
