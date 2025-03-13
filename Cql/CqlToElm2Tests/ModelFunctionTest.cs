using Antlr4.Runtime;
using FluentAssertions;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;
using Hl7.Cql.Operators;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests;

[TestClass]
public class ModelFunctionTest
{
    internal static cqlParser getParser(string cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        return new cqlParser(new CommonTokenStream(lexer));
    }

    [TestMethod]
    public void OperatorPlus_Decimal()
    {
        var provider = new MockLibraryProvider();
        var cql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

        define literal type Any

        define literal type Decimal extends Any

        define public function Add(left Decimal, right Decimal) returns Decimal: external
        define public operator+(left Decimal, right Decimal) returns Decimal: Add(left,right)
        ";

        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var model = visitor.Visit(getParser(cql).model()).Should().BeOfType<ModelSymbol>().Subject;

        var decimalType = model.Symbols.GetUnique<TypeSymbol>("Decimal");
        decimalType.Should().NotBeNull();

        var op = model.Symbols.GetUnique<FunctionSymbol>("$(operator+)");
        op.Should().NotBeNull();
        op!.SymbolType.Should().Be(SymbolType.Function);
        op.Name.Should().Be("$(operator+)");
        op.AccessModifier.Should().Be(Hl7.Cql.Model.AccessModifier.Public);
        op.Operands.Should().NotBeNull().And.HaveCount(2);
        op.Operands[0].Name.Should().Be("left");
        op.Operands[0].Type.Should().Be(decimalType);
        op.Operands[1].Name.Should().Be("right");
        op.Operands[1].Type.Should().Be(decimalType);
        op.Type.Should().Be(decimalType);


        var add = model.Symbols.GetUnique<FunctionSymbol>("Add");
        add.Should().NotBeNull();
        add!.SymbolType.Should().Be(SymbolType.Function);
        add!.Name.Should().Be("Add");
        add.AccessModifier.Should().Be(Hl7.Cql.Model.AccessModifier.Public);
        add.Operands.Should().NotBeNull().And.HaveCount(2);
        add.Operands[0].Name.Should().Be("left");
        add.Operands[0].Type.Should().Be(decimalType);
        add.Operands[1].Name.Should().Be("right");
        add.Operands[1].Type.Should().Be(decimalType);
        add.Type.Should().Be(decimalType);

    }

    [TestMethod]
    public void OperatorPlus_Decimal_Evaluate()
    {
        var provider = new MockLibraryProvider();
        var modelCql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

        define literal type Any

        define literal type Decimal extends Any

        define public function Add(left Decimal, right Decimal) returns Decimal: external
        define public operator+(left Decimal, right Decimal) returns Decimal: Add(left,right)
        ";
        provider.Add("System", new(2, 0, 0), modelCql);
        var libCql =
        @"library Test version '1.0.0'

        using System version '2.0.0'
        define Three: 1.0 + 2.0
        ";
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var library = visitor.Visit(getParser(libCql).library()).Should().BeOfType<LibrarySymbol>().Subject;

        var model = globalScope.GetUnique<ModelSymbol>("System");
        model.Should().NotBeNull();
        var add = model!.Symbols.GetUnique<FunctionSymbol>("Add");
        add.Should().NotBeNull();

        var evaluator = new PostgresEvaluator();
        evaluator.Implementations[add!] =
            (decimal? left, decimal? right) =>
            $"{(left?.ToString() ?? "NULL")} + {(right?.ToString() ?? "NULL")}";

        var three = library.Symbols.GetUnique<ExpressionSymbol>("Three");
        three.Should().NotBeNull();
        three!.SymbolType.Should().Be(SymbolType.Expression);
        var invocation = three.Expression.Should().BeOfType<FunctionInvocationExpression>().Subject;
        evaluator.Evaluate(three!, library.Symbols).Should().Be(3.0m);
    }

}

