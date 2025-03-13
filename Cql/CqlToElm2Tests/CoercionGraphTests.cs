using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Hl7.Cql.CqlToElm2.Coercion;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Antlr4.Runtime;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;
using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.Model;
using System.Runtime.InteropServices;

namespace CqlToElm2Tests;

[TestClass]
public class CoercionGraphTests
{
    internal static cqlParser getParser(string cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        return new cqlParser(new CommonTokenStream(lexer));
    }

    [TestMethod]
    public void Grandparent()
    {
        var provider = new MockLibraryProvider();
        var cql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

            define literal type Any

            define literal type C extends Any
            define literal type B extends C
            define literal type A extends B
        ";
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var model = visitor.Visit(getParser(cql).model()).Should().BeOfType<ModelSymbol>().Subject;

        var anyType = model.Symbols.GetUnique<TypeSymbol>("Any");
        var a = model.Symbols.GetUnique<TypeSymbol>("A");
        var b = model.Symbols.GetUnique<TypeSymbol>("B");
        var c = model.Symbols.GetUnique<TypeSymbol>("C");
        anyType.Should().NotBeNull();
        a.Should().NotBeNull();
        b.Should().NotBeNull();
        c.Should().NotBeNull();

        c!.TypeDefinition.BaseType.Should().Be(anyType!.TypeDefinition);
        b!.TypeDefinition.BaseType.Should().Be(c.TypeDefinition);
        a!.TypeDefinition.BaseType.Should().Be(b.TypeDefinition);

        var graph = new CoercionGraph();
        graph.AddType(a);
        // b and c will be added too
        var aNode = graph.GetNodeForType(a);

        var bNode = graph.GetNodeForType(b);
        bNode.Should().NotBeNull();
        var cNode = graph.GetNodeForType(c);
        cNode.Should().NotBeNull();

        graph.ComputeCoercionPaths();

        var bestMatch = graph.GetBestSignature(new Signature([a]), [new Signature([b]), new Signature([c])]);
        bestMatch.Should().NotBeNull();
        bestMatch!.Signature.Operands.Should().HaveCount(1);
        bestMatch.Signature.Operands[0].Should().Be(b);

    }

    [TestMethod]
    public void Infer_Generic_Simple()
    {
        var model = new ModelDefinition("Test", "1.0.0", "http://hl7.org");
        var t = new TypeSymbol(new GenericArgumentType("T"));
        var tSpec = (GenericArgumentSpecifier)t.TypeDefinition.ToTypeSpecifier();
        var anyType = new SimpleTypeDefinition("Any", model, AccessModifier.Public);

        var listType = GenericTypeDefinition.CreateTemplate("List", model,
            [tSpec], new() { { tSpec, anyType.ToTypeSpecifier() } }, anyType, AccessModifier.Public);

        var listOfT = new TypeSymbol(listType);

        var signature = new Signature(listOfT, t);
        var foo = new TypeSymbol(new SimpleTypeDefinition("Foo", model, AccessModifier.Public));
        var subs = CoercionGraph.GenerateTypeSubstitutions(new(foo, foo), signature);
        subs.Should().HaveCount(1);
        subs[0].ContainsKey(t).Should().BeTrue();
        subs[0][t].Should().Be(foo);
    }

    [TestMethod]
    public void Infer_Generic_Nested()
    {
        var model = new ModelDefinition("Test", "1.0.0", "http://hl7.org");
        var t = new TypeSymbol(new GenericArgumentType("T"));
        var tSpec = (GenericArgumentSpecifier)t.TypeDefinition.ToTypeSpecifier();
        var anyType = new SimpleTypeDefinition("Any", model, AccessModifier.Public);

        var listType = GenericTypeDefinition.CreateTemplate("List", model,
            [tSpec], new() { { tSpec, anyType.ToTypeSpecifier() } }, anyType, AccessModifier.Public);
        listType.ToString().Should().Be("List<T>");
        var listOfListType = GenericTypeDefinition.Create(listType, new() { { tSpec, listType.ToTypeSpecifier() } });
        listOfListType.ToString().Should().Be("List<List<T>>");


        var listOfListOfT = new TypeSymbol(listOfListType);

        var signature = new Signature(listOfListOfT, t);
        var foo = new TypeSymbol(new SimpleTypeDefinition("Foo", model, AccessModifier.Public));
        var subs = CoercionGraph.GenerateTypeSubstitutions(new(foo, foo), signature);
        subs.Should().HaveCount(1);
        subs[0].ContainsKey(t).Should().BeTrue();
        subs[0][t].Should().Be(foo);
    }


    [TestMethod]
    public void ImplicitCoercion_Integer_To_Decimal()
    {
        var provider = new MockLibraryProvider();
        var modelCql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

            define literal type Any
            define literal type Decimal
            define literal type Integer

            define public implicit conversion from Integer i to Decimal: external
        ";
        provider.Add("System", new(2, 0, 0), modelCql);

        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        visitor.Visit(getParser(modelCql).model()).Should().BeOfType<ModelSymbol>();

        var model = globalScope.GetLocalUnique<ModelSymbol>("System");
        model.Should().NotBeNull();
        model!.Symbols.OfType<TypeSymbol>().Should().HaveCount(3);
        model.Symbols.OfType<ConversionFunctionSymbol>().Should().HaveCount(1);

        var intType = model.Symbols.GetUnique<TypeSymbol>("Integer")!;
        intType.Should().NotBeNull();

        var decimalType = model.Symbols.GetUnique<TypeSymbol>("Decimal");
        decimalType.Should().NotBeNull();

        model.Symbols.CoercionGraph.Should().NotBeNull();
        var intNode = model.Symbols.CoercionGraph!.GetNodeForType(intType!);
        intNode.Should().NotBeNull();
        var decimalNode = model.Symbols.CoercionGraph!.GetNodeForType(decimalType!);
        decimalNode.Should().NotBeNull();

        var result = model.Symbols.CoercionGraph.GetBestSignature(new([intType!]), [new([decimalType!])])!;
        result.Should().NotBeNull();
        var intLiteral = new LiteralExpression(1, intType);
        var newArguments = result.CoerceArguments([intLiteral]);
        newArguments.Should().HaveCount(1);
        newArguments[0].Should().BeOfType<FunctionInvocationExpression>();

    }
}
