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
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.Logging.Abstractions;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// End-to-end integration tests for the builder pipeline
/// (<see cref="LibraryCodeBuilder"/> et al.) feeding into <see cref="CSharpEmitter"/>.
/// Assertions are deliberately shape-level (<see cref="StringAssert.Contains"/> checks, not
/// byte-exact comparisons); byte-exact output is covered by the golden-file tests.
/// </summary>
[TestClass]
public class CodeModelPipelineTests : Base
{
    /// <summary>Test stand-in for the scaffolding writer's naming conventions (mirrors
    /// <c>CSharpEmitterTests.TestNamingConventions</c> in CoreTests, which lives in a
    /// different assembly and isn't shared).</summary>
    private sealed class TestNamingConventions : ICSharpNamingConventions
    {
        public string TupleMetadataFieldName(Type tupleType) => "CqlTupleMetadata_TEST";

        public string DefinitionTarget(CodeDefinitionCall dc) => dc.IsLocalLibrary
            ? $"this.{dc.DefinitionName}"
            : $"{dc.LibraryName}_{dc.LibraryVersion.Replace('.', '_')}.Instance.{dc.DefinitionName}";
    }

    /// <summary>
    /// Builds a <see cref="Library"/> from CQL source, then runs it through the
    /// expression-builder chain constructed by hand with
    /// <see cref="NullLogger{T}"/>/<see cref="NullLoggerFactory"/> instances — rather than
    /// resolved from the <c>ElmToolkitServices.AddCqlCompilerServices</c> DI composition (see
    /// <c>Cql\CodeGeneration.NET\Toolkit\Internal\ElmToolkitServices.cs</c>) — so these tests
    /// exercise the builder chain directly, independent of the toolkit's service wiring.
    /// </summary>
    private static (Library library, CqlDefinitionDictionary definitions) BuildIr(string cql)
    {
        var library = CreateCqlToolkit().MakeLibrary(cql);
        return (library, BuildCqlDefinitions(library));
    }

    /// <inheritdoc cref="BuildIr"/>
    private static CqlDefinitionDictionary BuildCqlDefinitions(Library library)
    {
        var typeResolver = FhirTypeResolver.Default;
        var typeConverter = FhirTypeConverter
            .Create(Hl7.Fhir.Model.ModelInfo.ModelInspector)
            .UseLogger(NullLogger<TypeConverter>.Instance);
        typeConverter.CaptureAvailableConverters();

        var tupleBuilderCache = new TupleBuilderCache(NullLogger<TupleBuilderCache>.Instance);
        var libraryPreprocessorBuilder = new LibraryPreprocessorBuilder(NullLoggerFactory.Instance);
        var cqlOperatorsBinder = new CqlOperatorsBinder(NullLogger<CqlOperatorsBinder>.Instance, typeResolver, typeConverter);
        var cqlContextBinder = new CqlContextBinder();

        var codeBuilder = new CodeBuilder(
            NullLogger<CodeBuilder>.Instance,
            CodeBuilderSettings.Default,
            cqlOperatorsBinder,
            tupleBuilderCache,
            typeResolver,
            typeConverter,
            cqlContextBinder);

        var libraryCodeBuilder = new LibraryCodeBuilder(
            NullLogger<LibraryCodeBuilder>.Instance,
            codeBuilder,
            libraryPreprocessorBuilder);

        return libraryCodeBuilder.ProcessLibrary(library);
    }

    /// <summary>
    /// Fetches a top-level definition of the given name from the library's own definitions
    /// (as opposed to any included library's) and emits its body as C# via
    /// <see cref="CSharpEmitter"/>. Filtering by name (rather than relying on there being a
    /// single definition) matters because a <c>context Patient</c>/default-context library gets
    /// a synthesized context definition alongside the CQL-authored ones (see
    /// <c>ContextDefTest</c>).
    /// </summary>
    private static string EmitDefinition(Library library, CqlDefinitionDictionary definitions, string name)
    {
        var lambdaDefinition = definitions
            .SelectDefinitionsByLibraryName(library.VersionedLibraryIdentifier)
            .Select(d => d.definition)
            .OfType<CqlLambdaDefinition>()
            .First(d => d.Name == name);

        var emitter = new CSharpEmitter(new TypeToCSharpConverter(), new TestNamingConventions());
        return emitter.EmitBodyBlock(lambdaDefinition.Lambda).Replace("\r\n", "\n");
    }

    /// <summary>Baseline every test asserts: the builder and emitter ran without throwing, and
    /// produced a non-empty body block that returns something.</summary>
    private static void AssertWellFormedBody(string body)
    {
        Assert.IsFalse(string.IsNullOrWhiteSpace(body));
        StringAssert.StartsWith(body, "{");
        StringAssert.Contains(body, "return ");
        StringAssert.EndsWith(body, "}");
    }

    [TestMethod]
    public void IntegerArithmetic_EmitsAddCallOnOperators()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define X: 1 + 2
            """);

        var body = EmitDefinition(library, definitions, "X");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "context.Operators");
        StringAssert.Contains(body, "Add");
    }

    [TestMethod]
    public void IfThenElse_EmitsConditional()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define X: if 1 > 0 then 10 else 20
            """);

        var body = EmitDefinition(library, definitions, "X");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "10");
        StringAssert.Contains(body, "20");
        // Either a ternary or an if/else statement, depending on whether the condition
        // is trivial enough to inline (see CSharpEmitterTests.Conditional_*).
        Assert.IsTrue(body.Contains('?') || body.Contains("if ("),
            $"Expected a ternary or if/else in the emitted body, got:\n{body}");
    }

    [TestMethod]
    public void CaseWithMultipleBranches_EmitsIfChain()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define X:
                case
                    when 1 > 0 then 10
                    when 1 = 0 then 20
                    else 30
                end
            """);

        var body = EmitDefinition(library, definitions, "X");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "10");
        StringAssert.Contains(body, "20");
        StringAssert.Contains(body, "30");
        StringAssert.Contains(body, "if (");
    }

    [TestMethod]
    public void QueryWithWhereClause_EmitsLocalFunctionWithAliasParameter()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define Q: ({ 1, 2, 3 }) N where N > 1 return N
            """);

        var body = EmitDefinition(library, definitions, "Q");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "Where");
        // The alias "N" becomes the parameter name of the emitted local function.
        StringAssert.Contains(body, "(int? N)");
    }

    [TestMethod]
    public void PropertyAccessOverFhir_EmitsNullConditionalProperty()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'
            using FHIR version '4.0.1'
            context Patient

            define GetActive: Patient.active
            """);

        var body = EmitDefinition(library, definitions, "GetActive");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "Active");
        // The null-conditional survived the port: "Patient" (the context reference) can be
        // null, so ".active" must print as "?.ActiveElement", not a plain ".ActiveElement".
        StringAssert.Contains(body, "?.ActiveElement");
    }

    [TestMethod]
    public void TupleLiteral_EmitsValueTuple()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define T: Tuple { x: 1, y: 2 }
            """);

        var body = EmitDefinition(library, definitions, "T");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "CqlTupleMetadata_TEST");
    }

    [TestMethod]
    public void EmptyTupleLiteral_EmitsObjectConstruction()
    {
        var elmLibrary = new Library
        {
            identifier = new VersionedIdentifier { id = "EmptyTupleLiteral", version = "1.0.0" },
            schemaIdentifier = new VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
            statements =
            [
                new ExpressionDef
                {
                    name = "T",
                    context = "Patient",
                    expression = new Hl7.Cql.Elm.Tuple { element = [] }
                }
            ]
        };
        var definitions = BuildCqlDefinitions(elmLibrary);

        var body = EmitDefinition(elmLibrary, definitions, "T");

        AssertWellFormedBody(body);
        StringAssert.Contains(body, "new object()");
    }

    [TestMethod]
    public void ListLiteralWithFirst_EmitsFirstCall()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define X: First({ 1, 2, 3 })
            """);

        var body = EmitDefinition(library, definitions, "X");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "First");
    }

    [TestMethod]
    public void UserDefinedFunctionCall_EmitsThisDotCall()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define function Double(x Integer): x * 2
            define UseDouble: Double(5)
            """);

        var body = EmitDefinition(library, definitions, "UseDouble");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "this.Double");
    }

    [TestMethod]
    public void ParameterDefinition_EmitsResolveParameterCall()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            parameter MyParam Integer default 5
            define UseParam: MyParam + 1
            """);

        var useParamBody = EmitDefinition(library, definitions, "UseParam");
        AssertWellFormedBody(useParamBody);
        // The reference to MyParam from within UseParam is a call to MyParam's own definition
        // (not an inlined ResolveParameter call) -- the ResolveParameter call lives inside
        // MyParam's own emitted body.
        StringAssert.Contains(useParamBody, "this.MyParam");

        var myParamBody = EmitDefinition(library, definitions, "MyParam");
        AssertWellFormedBody(myParamBody);
        StringAssert.Contains(myParamBody, "ResolveParameter");
    }

    [TestMethod]
    public void IntervalLiteral_EmitsWidthCall()
    {
        var (library, definitions) = BuildIr("""
            library IrPipeTest version '1.0.0'

            define X: width of Interval[3, 7]
            """);

        var body = EmitDefinition(library, definitions, "X");
        AssertWellFormedBody(body);
        StringAssert.Contains(body, "Width");
    }

    /// <summary>
    /// Smoke test: compare the toolkit-composed and hand-built compositions of the current
    /// builder/generator pipeline and assert that they generate identical C# (modulo line
    /// endings, like <c>CSharpGenerationGoldenTests</c>).
    /// </summary>
    [TestMethod]
    public void SmokeTest_ToolkitAndHandBuiltComposition_GenerateIdenticalCSharp()
    {
        const string cql = """
            library IrSmokeTest version '1.0.0'

            codesystem "ACME": 'http://acme.org/cs'
            valueset "Fall Injuries": 'http://acme.org/vs/falls'
            code "Tiny": 'T1' from "ACME" display 'Tiny code'
            concept "Tiny Concept": { "Tiny" } display 'Tiny concept'

            define Constant: 1
            define function Identity(x Integer): x
            define UseIdentity: Identity(3)
            define TupleValue: Tuple { x: 1, y: 2 }
            """;

        var library = CreateCqlToolkit().MakeLibrary(cql);
        LibrarySet librarySet = new("IrSmokeTest", library);

        // Toolkit composition: build definitions and generate C# through the DI-wired services.
        var elmToolkit = CreateElmToolkit();
        var toolkitDefinitions = elmToolkit.ProcessLibrary(library);
        var toolkitCSharp = elmToolkit
            .GetLibrarySetCSharpCodeGenerator()
            .GenerateEachLibraryToCSharp(librarySet, toolkitDefinitions)
            .Single().cSharp;

        // Hand-built composition: same Library instance through the hand-constructed chain.
        var handBuiltDefinitions = BuildCqlDefinitions(library);
        var handBuiltCSharp = new LibrarySetCSharpCodeGenerator(FhirTypeResolver.Default, new TypeToCSharpConverter())
            .GenerateEachLibraryToCSharp(librarySet, handBuiltDefinitions)
            .Single().cSharp;

        AssertEqualCSharp(toolkitCSharp, handBuiltCSharp);
    }

    /// <summary>Asserts the two generated sources are equal (line endings normalized) and, on
    /// mismatch, fails with the first differing line plus context — much easier to iterate on
    /// than two multi-hundred-line strings in the failure message.</summary>
    private static void AssertEqualCSharp(string oldCSharp, string newCSharp)
    {
        var oldLines = oldCSharp.Replace("\r\n", "\n").Split('\n');
        var newLines = newCSharp.Replace("\r\n", "\n").Split('\n');

        for (int i = 0; i < Math.Max(oldLines.Length, newLines.Length); i++)
        {
            var oldLine = i < oldLines.Length ? oldLines[i] : "<end of file>";
            var newLine = i < newLines.Length ? newLines[i] : "<end of file>";
            if (oldLine != newLine)
            {
                string Context(string[] lines) => string.Join("\n", lines.Skip(Math.Max(0, i - 2)).Take(8));
                Assert.Fail(
                    $"Generated C# differs at line {i + 1}.\n" +
                    $"--- old pipeline ---\n{Context(oldLines)}\n" +
                    $"--- new pipeline ---\n{Context(newLines)}");
            }
        }
    }
}
