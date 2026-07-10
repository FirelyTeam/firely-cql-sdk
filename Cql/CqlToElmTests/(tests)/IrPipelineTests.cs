/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.Logging.Abstractions;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// First end-to-end integration tests for the phase-4 typed-IR builder pipeline
/// (<see cref="IrLibraryExpressionBuilder"/> et al.) feeding into the phase-3
/// <see cref="CSharpIrEmitter"/>. Nothing exercised this combination before these tests; the
/// assertions are deliberately loose (shape-level <see cref="StringAssert.Contains"/> checks,
/// not byte-exact comparisons) since byte-parity with the old pipeline is a phase-5 concern.
/// </summary>
[TestClass]
public class IrPipelineTests : Base
{
    /// <summary>Test stand-in for the scaffolding writer's naming conventions (mirrors
    /// <c>CSharpIrEmitterTests.TestNamingConventions</c> in CoreTests, which lives in a
    /// different assembly and isn't shared).</summary>
    private sealed class TestNamingConventions : ICSharpNamingConventions
    {
        public string TupleMetadataFieldName(Type tupleType) => "CqlTupleMetadata_TEST";

        public string DefinitionTarget(IrDefinitionCall dc) => dc.IsLocalLibrary
            ? $"this.{dc.DefinitionName}"
            : $"{dc.LibraryName}_{dc.LibraryVersion.Replace('.', '_')}.Instance.{dc.DefinitionName}";
    }

    /// <summary>
    /// Builds a <see cref="Library"/> from CQL source, then runs it through the typed-IR
    /// builder chain, mirroring the composition <c>ElmToolkitServices.AddCqlCompilerServices</c>
    /// wires up via DI for the old (Linq.Expressions) pipeline -- see
    /// <c>Cql\CodeGeneration.NET\Toolkit\Internal\ElmToolkitServices.cs</c> -- but constructed by
    /// hand with <see cref="NullLogger{T}"/>/<see cref="NullLoggerFactory"/> instances, since
    /// these new Ir* classes are not (yet) registered in that container.
    /// </summary>
    private static (Library library, IrDefinitionDictionary definitions) BuildIr(string cql)
    {
        var library = CreateCqlToolkit().MakeLibrary(cql);
        return (library, BuildIrDefinitions(library));
    }

    /// <inheritdoc cref="BuildIr"/>
    private static IrDefinitionDictionary BuildIrDefinitions(Library library)
    {
        var typeResolver = FhirTypeResolver.Default;
        var typeConverter = FhirTypeConverter
            .Create(Hl7.Fhir.Model.ModelInfo.ModelInspector)
            .UseLogger(NullLogger<TypeConverter>.Instance);
        typeConverter.CaptureAvailableConverters();

        var tupleBuilderCache = new TupleBuilderCache(NullLogger<TupleBuilderCache>.Instance);
        var libraryPreprocessorBuilder = new LibraryPreprocessorBuilder(NullLoggerFactory.Instance);
        var cqlOperatorsBinder = new IrCqlOperatorsBinder(NullLogger<IrCqlOperatorsBinder>.Instance, typeResolver, typeConverter);
        var cqlContextBinder = new IrCqlContextBinder();

        var expressionBuilder = new IrExpressionBuilder(
            NullLogger<IrExpressionBuilder>.Instance,
            ExpressionBuilderSettings.Default,
            cqlOperatorsBinder,
            tupleBuilderCache,
            typeResolver,
            typeConverter,
            cqlContextBinder);

        var libraryExpressionBuilder = new IrLibraryExpressionBuilder(
            NullLogger<IrLibraryExpressionBuilder>.Instance,
            expressionBuilder,
            libraryPreprocessorBuilder);

        return libraryExpressionBuilder.ProcessLibrary(library);
    }

    /// <summary>
    /// Fetches a top-level definition of the given name from the library's own definitions
    /// (as opposed to any included library's) and emits its body as C# via
    /// <see cref="CSharpIrEmitter"/>. Filtering by name (rather than relying on there being a
    /// single definition) matters because a <c>context Patient</c>/default-context library gets
    /// a synthesized context definition alongside the CQL-authored ones (see
    /// <c>ContextDefTest</c>).
    /// </summary>
    private static string EmitDefinition(Library library, IrDefinitionDictionary definitions, string name)
    {
        var lambdaDefinition = definitions
            .SelectDefinitionsByLibraryName(library.VersionedLibraryIdentifier)
            .Select(d => d.definition)
            .OfType<IrLambdaDefinition>()
            .First(d => d.Name == name);

        var emitter = new CSharpIrEmitter(new TypeToCSharpConverter(), new TestNamingConventions());
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
        // is trivial enough to inline (see CSharpIrEmitterTests.Conditional_*).
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
    /// Phase-5 smoke test: run one CQL library end to end through BOTH C#-generation
    /// pipelines — the existing Expression-based <c>LibrarySetCSharpCodeGenerator</c> (via the
    /// toolkit services, see <see cref="Base.Run"/>) and the typed-IR
    /// <c>IrLibrarySetCSharpCodeGenerator</c> — and assert the generated library files are
    /// byte-identical (modulo line endings, like <c>CSharpGenerationGoldenTests</c>).
    /// </summary>
    [TestMethod]
    public void SmokeTest_OldAndIrPipelines_GenerateIdenticalCSharp()
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

        // Old pipeline: build definitions and generate C# through the toolkit services.
        var elmToolkit = CreateElmToolkit();
        var oldDefinitions = elmToolkit.ProcessLibrary(library);
        var oldCSharp = elmToolkit
            .GetLibrarySetCSharpCodeGenerator()
            .GenerateEachLibraryToCSharp(librarySet, oldDefinitions)
            .Single().cSharp;

        // New pipeline: same Library instance through the typed-IR builder + generator.
        var irDefinitions = BuildIrDefinitions(library);
        var newCSharp = new IrLibrarySetCSharpCodeGenerator(FhirTypeResolver.Default, new TypeToCSharpConverter())
            .GenerateEachLibraryToCSharp(librarySet, irDefinitions)
            .Single().cSharp;

        AssertEqualCSharp(oldCSharp, newCSharp);
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
