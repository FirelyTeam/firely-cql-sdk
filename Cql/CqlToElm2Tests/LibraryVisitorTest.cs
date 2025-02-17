using FluentAssertions;
using Antlr4.Runtime;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Hl7.Cql.Model;
using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.CqlToElm2;
using System.Runtime.CompilerServices;
using FluentAssertions.Primitives;
using Hl7.Cql.Model.ModelProviders;

namespace CqlToElm2Tests;

[TestClass]
public sealed class LibraryVisitorTest
{
    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        ModelProvider = new CachingModelProvider(new BuiltInModelProvider());
    }


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static IModelProvider ModelProvider;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    internal static cqlParser.LibraryContext parse(string cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        var parser = new cqlParser(new CommonTokenStream(lexer));
        return parser.library();
    }

    [TestMethod]
    public void Visit_Library()
    {
        var parser = parse(@"library Test version '1.0.0'");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        library.Name.Should().Be("Test");
        library.Version.Should().Be(new Version(1, 0, 0));
        library.Errors.Should().HaveCount(0);
    }

    [TestMethod]
    public void Visit_Library_No_Version()
    {
        var parser = parse(@"library Test");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        library.Name.Should().Be("Test");
        library.Version.Should().Be(new Version(1, 0, 0));
        library.Errors.Should().HaveCount(0);
    }

    [TestMethod]
    public void Using_System()
    {
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var systemSymbols = library.Symbols.GetSymbols("System");
        systemSymbols.Should().HaveCount(1);
        var system = systemSymbols[0].Should().BeOfType<ModelSymbol>().Subject;
        system.Name.Should().Be("System");
        library.Errors.Should().HaveCount(0);

        system.Model.Should().NotBeNull();
        system.Model.Name.Should().Be("System");
        system.Model.Version.Should().Be("2.0.0");
    }

    [TestMethod]
    public void Using_System_LocalAlias()
    {
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0' called System100
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var systemSymbols = library.Symbols.GetSymbols("System100");
        systemSymbols.Should().HaveCount(1);
        var system = systemSymbols[0].Should().BeOfType<ModelSymbol>().Subject;
        system.Name.Should().Be("System100");
        library.Errors.Should().HaveCount(0);

        system.Model.Should().NotBeNull();
        system.Model.Name.Should().Be("System");
        system.Model.Version.Should().Be("2.0.0");
    }


    [TestMethod]
    public void Using_System_Two_Versions()
    {
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'
            using System version '2.0.0'

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;

        var systemSymbols = library.Symbols.GetSymbols("System");
        systemSymbols.Should().HaveCount(2);
        var system1 = systemSymbols[0].Should().BeOfType<ModelSymbol>().Subject;
        system1.Name.Should().Be("System");
        system1.Model.Should().NotBeNull();
        system1.Model.Name.Should().Be("System");
        system1.Model.Version.Should().Be("2.0.0");
        library.Errors.Should().HaveCount(0);

        var system2 = systemSymbols[1].Should().BeOfType<ModelSymbol>().Subject;
        system2.Name.Should().Be("System");
        system2.Model.Should().NotBeNull();
        system2.Model.Name.Should().Be("System");
        system2.Model.Version.Should().Be("2.0.0");
        system2.Errors.Should().HaveCount(1);
        system2.Errors[0].Type.Should().Be(ErrorType.SymbolRedefinition);
    }

    [TestMethod]
    public void Using_System_Two_Versions_Aliased()
    {
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0' called System
            using System version '2.0.0' called System2

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), new MockLibraryProvider());
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;

        var systemSymbols = library.Symbols.GetSymbols("System");
        systemSymbols.Should().HaveCount(1);
        var system1 = systemSymbols[0].Should().BeOfType<ModelSymbol>().Subject;
        system1.Name.Should().Be("System");
        system1.Model.Should().NotBeNull();
        system1.Model.Name.Should().Be("System");
        system1.Model.Version.Should().Be("2.0.0");
        system1.Errors.Should().BeEmpty();

        var system2Symbols = library.Symbols.GetSymbols("System2");
        system2Symbols.Should().HaveCount(1);
        var system2 = system2Symbols[0].Should().BeOfType<ModelSymbol>().Subject;
        system2.Name.Should().Be("System2");
        system2.Model.Should().NotBeNull();
        system2.Model.Name.Should().Be("System");
        system2.Model.Version.Should().Be("2.0.0");
        system1.Errors.Should().BeEmpty();
    }

    [TestMethod]
    public void Include_FHIRHelpers()
    {
        var lp = new MockLibraryProvider();
        lp.Libraries.Add(("FHIRHelpers", new Version(4, 0, 0)), "library FHIRHelpers version '4.0.0'");

        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

           include FHIRHelpers version '4.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        test.Symbols.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
        globalScope.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
    }

    [TestMethod]
    public void Include_FHIRHelpers_Alias()
    {
        var lp = new MockLibraryProvider();
        lp.Libraries.Add(("FHIRHelpers", new Version(4, 0, 0)), "library FHIRHelpers version '4.0.0'");

        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

           include FHIRHelpers version '4.0.0' called FH
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        test.Symbols.GetLocalUnique("FH").Should().NotBeNull();
        globalScope.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
    }

    [TestMethod]
    public void Include_FHIRHelpers_Twice()
    {
        var lp = new MockLibraryProvider();
        lp.Libraries.Add(("FHIRHelpers", new Version(4, 0, 0)), "library FHIRHelpers version '4.0.0'");

        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

           include FHIRHelpers version '4.0.0'
           include FHIRHelpers version '4.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        test.Symbols.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
        test.Symbols.GetLocalSymbols("FHIRHelpers").Should().HaveCount(2);

        globalScope.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
    }

    [TestMethod]
    public void Include_FHIRHelpers_TwoAliases()
    {
        var lp = new MockLibraryProvider();
        lp.Libraries.Add(("FHIRHelpers", new Version(4, 0, 0)), "library FHIRHelpers version '4.0.0'");

        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

           include FHIRHelpers version '4.0.0'
           include FHIRHelpers version '4.0.0' called FH 
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        test.Symbols.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
        test.Symbols.GetLocalUnique("FH").Should().NotBeNull();

        globalScope.GetLocalUnique("FHIRHelpers").Should().NotBeNull();
    }

    [TestMethod]
    public void Include_NotFound()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            include FHIRHelpers version '4.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, new MockModelProvider(), lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var fh = test.Symbols.GetLocalUnique("FHIRHelpers");
        fh.Should().NotBeNull();
        fh.Errors.Should().HaveError(ErrorType.LibraryNotFound);
        globalScope.GetLocalUnique("FHIRHelpers").Should().BeNull();
    }

    [TestMethod]
    public void CodeSystem()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        css.Name.Should().Be("ICD-10");
        css.Version.Should().Be(new Version(10, 0, 0));
        css.Uri.Should().Be("http://hl7.org/fhir/sid/icd-10");
        css.Errors.Should().BeEmpty();
        css.Type.Should().NotBeNull();
        css.Type.Name.Should().Be("CodeSystem");
    }

    [TestMethod]
    public void CodeSystem_Duplicate()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        css.Name.Should().Be("ICD-10");
        css.Version.Should().Be(new Version(10, 0, 0));
        css.Uri.Should().Be("http://hl7.org/fhir/sid/icd-10");
        css.Errors.Should().BeEmpty();
        var systems = test.Symbols.GetSymbols("ICD-10");
        systems.Should().HaveCount(2);
        systems.SelectMany(s => s.Errors).Select(e => e.Type).Where(t => t == ErrorType.SymbolRedefinition).Should().HaveCount(1);
    }

    [TestMethod]
    public void Code()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
            code ""Bizarre personal appearance"": 'R46.1' from ""ICD-10"" display 'Display Clause'

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        var code = test.Symbols.GetLocalUnique<CodeSymbol>("Bizarre personal appearance"); ;
        code.Should().NotBeNull();
        code!.CodeSystem.Should().Be(css);
        code.Code.Should().Be("R46.1");
        code.Name.Should().Be("Bizarre personal appearance");
        code.Display.Should().Be("Display Clause");
    }

    [TestMethod]
    public void Code_Duplicated()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
            code ""Bizarre personal appearance"": 'R46.1' from ""ICD-10"" display 'Display Clause'
            code ""Bizarre personal appearance"": 'R46.1' from ""ICD-10"" display 'Display Clause'

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        var code = test.Symbols.GetLocalUnique<CodeSymbol>("Bizarre personal appearance");
        code.Should().NotBeNull();
        code.CodeSystem.Should().Be(css);
        code.Code.Should().Be("R46.1");
        code.Name.Should().Be("Bizarre personal appearance");
        code.Display.Should().Be("Display Clause");
        test.Symbols.GetSymbols("Bizarre personal appearance").Should().HaveCount(2);
        test.Symbols.GetSymbols("Bizarre personal appearance").Should().HaveError(ErrorType.SymbolRedefinition);
    }

    [TestMethod]
    public void Code_System_Not_Found()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            code ""Bizarre personal appearance"": 'R46.1' from ""ICD-10"" display 'Display Clause'

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().BeNull();
        var code = test.Symbols.GetLocalUnique<CodeSymbol>("Bizarre personal appearance"); ;
        code.Should().NotBeNull();
        code.CodeSystem.Should().NotBeNull();
        code.Code.Should().Be("R46.1");
        code.Name.Should().Be("Bizarre personal appearance");
        code.Display.Should().Be("Display Clause");
        code.Errors.Should().HaveError(ErrorType.CodeSystemNotFound);
    }

    [TestMethod]
    public void ValueSet()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
            valueset VS: 'https://fire.ly/ValueSet/VS' version '2.0.0' codesystems { ""ICD-10"" }

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        css!.Errors.Should().BeEmpty();
        var valueSet = test.Symbols.GetLocalUnique<ValueSetSymbol>("VS");
        valueSet.Should().NotBeNull();
        valueSet!.Name.Should().Be("VS");
        valueSet.Uri.Should().Be("https://fire.ly/ValueSet/VS");
        valueSet.Version.Should().Be(new(2, 0, 0));
        valueSet!.CodeSystems.Should().Contain(css);
    }

    [TestMethod]
    public void ValueSet_Missing_CodeSystem()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            valueset VS: 'https://fire.ly/ValueSet/VS' version '2.0.0' codesystems { ""ICD-10"" }

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().BeNull();
        var valueSet = test.Symbols.GetLocalUnique<ValueSetSymbol>("VS"); ;
        valueSet.Should().NotBeNull();
        valueSet!.Name.Should().Be("VS");
        valueSet.Uri.Should().Be("https://fire.ly/ValueSet/VS");
        valueSet.Version.Should().Be(new(2, 0, 0));
        valueSet!.CodeSystems.Should().BeEmpty();
        valueSet.Errors.Should().HaveError(ErrorType.CodeSystemNotFound);
    }

    [TestMethod]
    public void Concept()
    {
        var lp = new MockLibraryProvider();
        var parser = parse(@"
            library Test version '1.0.0'

            using System version '2.0.0'

            codesystem ""ICD-10"": 'http://hl7.org/fhir/sid/icd-10' version '10.0.0'
            code ""Bizarre personal appearance"": 'R46.1' from ""ICD-10"" display 'Display Clause'
            concept ""Con"": { ""Bizarre personal appearance"" } display 'My Concept'

        ");
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, ModelProvider, lp);
        var library = visitor.Visit(parser).Should().BeOfType<LibrarySymbol>().Subject;
        var test = globalScope.GetLocalUnique("Test").Should().NotBeNull().And.BeOfType<LibrarySymbol>().Subject;
        var css = test.Symbols.GetLocalUnique<CodeSystemSymbol>("ICD-10");
        css.Should().NotBeNull();
        var code = test.Symbols.GetLocalUnique<CodeSymbol>("Bizarre personal appearance"); ;
        code.Should().NotBeNull();
        var concept = test.Symbols.GetLocalUnique<ConceptSymbol>("Con");
        concept.Should().NotBeNull().And.NotHaveErrors();
        concept!.Name.Should().Be("Con");
        concept.Codes.Should().NotBeNull().And.Contain(code!);
        concept.Display.Should().Be("My Concept");
    }

}

file static class Extenisons
{
    public static void HaveError(this FluentAssertions.Collections.GenericCollectionAssertions<Symbol> symbols, ErrorType errorType) =>
        symbols.Subject.SelectMany(s=>s.Errors)
        .Select(e => e.Type)
        .Where(t => t == errorType)
        .Should()
        .NotBeEmpty();

    public static void HaveError(this FluentAssertions.Collections.GenericCollectionAssertions<Error> errors, ErrorType errorType) =>
        errors.Subject
        .Select(e => e.Type)
        .Where(t => t == errorType)
        .Should()
        .NotBeEmpty();

    public static void NotHaveErrors(this ObjectAssertions assertions) =>
        assertions.Subject.Should().BeAssignableTo<Symbol>().Subject.Errors.Should().BeEmpty();
}

file class MockLibraryProvider : ILibraryProvider
{
    public Dictionary<(string Id, Version? Version), string> Libraries = new();

    public TextReader? GetLibraryCql(string libraryName, Version? version)
    {
        if (Libraries.TryGetValue((libraryName, version), out var cql))
            return new StringReader(cql);
        else return null;
    }
}

file class MockModelProvider : IModelProvider
{
    public bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model)
    {
        model = new ModelDefinition(modelName, version ?? "1.0.0", $"http://{modelName}/{version}");
        return true;
    }

    public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model)
    {
        throw new NotImplementedException();
    }
}