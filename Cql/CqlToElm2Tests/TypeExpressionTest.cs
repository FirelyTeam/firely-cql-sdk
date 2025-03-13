using Antlr4.Runtime;
using FluentAssertions;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;

namespace CqlToElm2Tests;

[TestClass]
public class TypeExpressionTest
{
    internal static cqlParser getParser(string cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        return new cqlParser(new CommonTokenStream(lexer));
    }

    [TestMethod]
    public void ToInteger_FromBoolean()
    {
        var provider = new MockLibraryProvider();
        var cql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

        define literal type Any

        define literal type Integer extends Any
        define literal type Boolean extends Any

        define public operator=(left Boolean, right Boolean) returns Boolean: external

         define public function ToInteger(argument Boolean) returns Integer: if argument = true then 1 else 0
        ";

        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var model = visitor.Visit(getParser(cql).model()).Should().BeOfType<ModelSymbol>().Subject;
        model.Should().NotBeNull();
        var opEquals = model.Symbols.GetUnique<FunctionSymbol>($"$(operator=)");
        opEquals.Should().NotBeNull();

        var toInteger = model.Symbols.GetUnique("ToInteger").Should().NotBeNull()
            .And.BeOfType<FunctionSymbol>().Subject;
        var conditional = toInteger.Body.Should().NotBeNull().And.BeOfType<ConditionalExpression>().Subject;
        conditional.Cases.Should().HaveCount(1);
        conditional.Cases[0].When.Should().NotBeNull();
        conditional.Cases[0].Then.Should().BeOfType<LiteralExpression>().Subject.Value.Should().Be(1);
        conditional.Else.Should().NotBeNull();
        conditional.Else.Should().BeOfType<LiteralExpression>().Subject.Value.Should().Be(0);
    }

    [TestMethod]
    public void ToInteger_FromString()
    {
        var provider = new MockLibraryProvider();
        var cql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

        define literal type Any

        define literal type Integer extends Any
        define literal type String extends Any

         define public function ToInteger(argument String) returns Integer: external
        ";

        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var model = visitor.Visit(getParser(cql).model()).Should().BeOfType<ModelSymbol>().Subject;
        model.Should().NotBeNull();
        var toInteger = model.Symbols.GetUnique("ToInteger").Should().NotBeNull()
            .And.BeOfType<FunctionSymbol>().Subject;
        var conditional = toInteger.Body.Should().NotBeNull().And.BeOfType<ConditionalExpression>().Subject;
        conditional.Cases.Should().HaveCount(1);
        conditional.Cases[0].When.Should().NotBeNull();
        conditional.Cases[0].Then.Should().BeOfType<LiteralExpression>().Subject.Value.Should().Be(1);

        conditional.Else.Should().NotBeNull();
        conditional.Else.Should().BeOfType<LiteralExpression>().Subject.Value.Should().Be(0);
    }
}
