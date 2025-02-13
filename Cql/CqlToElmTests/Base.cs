using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Model;
using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Invocation.Fluent;
using CqlSdkPrototype.Invocation.Fluent.Extensions;

namespace Hl7.Cql.CqlToElm.Test
{
    using Expression = Hl7.Cql.Elm.Expression;
    using ChoiceTypeSpecifier = Hl7.Cql.Elm.ChoiceTypeSpecifier;
    using IntervalTypeSpecifier = Hl7.Cql.Elm.IntervalTypeSpecifier;
    using ListTypeSpecifier = Hl7.Cql.Elm.ListTypeSpecifier;
    using NamedTypeSpecifier = Hl7.Cql.Elm.NamedTypeSpecifier;
    using TupleTypeSpecifier = Hl7.Cql.Elm.TupleTypeSpecifier;
    using TypeSpecifier = Hl7.Cql.Elm.TypeSpecifier;

    public class Base
    {
        protected const string SystemUri = "urn:hl7-org:elm-types:r1";

        internal static object? Run(
            Expression expression,
            Library library,
            CqlContext? ctx = null)
        {
            ctx ??= DefaultCqlContext;
            var elmToolkit = ToFluentElmToolkit();
            var lambda = elmToolkit.Lambda(expression);
            var expressionName = "TempExpression";
            var elmToolkitServices = elmToolkit;
            LibrarySet librarySet = new("TempLibrarySet", library);
            DefinitionDictionary<LambdaExpression> definitions = new();
            definitions.Add(library.GetVersionedIdentifier()!, expressionName, lambda);

            var generateCSharp =
                elmToolkitServices
                    .GetLibrarySetCSharpCodeGenerator()
                    .GenerateEachLibraryToCSharp(librarySet, definitions)
                    .ToList();

            var compile =
                elmToolkitServices
                    .GetAssemblyCompiler()
                    .CompileEachLibraryToAssemblies(generateCSharp, librarySet, elmToolkit.ProcessorConfig.AssemblyCompilerDebugInformationFormat)
                    .ToList();

            var assemblyBytes = compile.Single().assemblyBinaryWithSourceCode.AssemblyBytes;

            using var librarySetInvoker =
                new FluentInvocationToolkit()
                    .AddAssemblyBinaries(AssemblyBinary.Default with { AssemblyBytes = assemblyBytes })
                    .ToLibrarySetInvoker();

            var result = librarySetInvoker
                .GetLibraryDefinitionResult(ctx!, CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier), expressionName);
            return result;
        }

        private static readonly CqlContext DefaultCqlContext = FhirCqlContext.CreateContext();

        internal static T? Run<T>(
            Expression expression,
            Library library,
            CqlContext? ctx = null) =>
            (T?)Run(expression, library, ctx);

        protected static void AssertResult<T>(Expression be, T expected)
        {
            var lambda = ToFluentElmToolkit().Lambda(@be);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();

            try
            {
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(T));
                Assert.AreEqual(expected, result);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException!;
            }
        }

        protected static void AssertNullResult(Expression be)
        {
            var lambda = ToFluentElmToolkit().Lambda(@be);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();

            try
            {
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException!;
            }
        }


        protected static void AssertIntervalType(TypeSpecifier specifier, string pointTypeName)
        {
            Assert.IsInstanceOfType(specifier, typeof(IntervalTypeSpecifier));
            var lts = (IntervalTypeSpecifier)specifier;
            Assert.IsNotNull(lts.pointType);
            Assert.IsNull(lts.resultTypeName);
            Assert.IsInstanceOfType(lts.pointType, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)lts.pointType;
            Assert.IsNotNull(nts.name);
            Assert.AreEqual(pointTypeName, nts.name.Name);
        }

        protected static void AssertIntervalType(TypeSpecifier typeSpecifier, TypeSpecifier pointType)
        {
            Assert.IsInstanceOfType(typeSpecifier, typeof(IntervalTypeSpecifier));
            var lts = (IntervalTypeSpecifier)typeSpecifier;
            Assert.IsNotNull(lts.pointType);
            Assert.AreEqual(lts.pointType, pointType);
        }

        protected static void AssertChoiceType(TypeSpecifier specifier, params string[] namedTypes)
        {
            Assert.IsInstanceOfType(specifier, typeof(ChoiceTypeSpecifier));
            var cts = (ChoiceTypeSpecifier)specifier;
            CollectionAssert.AllItemsAreInstancesOfType(cts.choice, typeof(NamedTypeSpecifier));
            var choiceNames = cts.choice
                                 .OfType<NamedTypeSpecifier>()
                                 .Select(nts => nts.name?.Name)
                                 .ToArray();
            CollectionAssert.AreEqual(namedTypes, choiceNames);
        }

        protected static void AssertTupleType(TypeSpecifier specifier, params (string name, string type)[] namedTypes)
        {
            Assert.IsInstanceOfType(specifier, typeof(TupleTypeSpecifier));
            var tts = (TupleTypeSpecifier)specifier;
            Assert.AreEqual(namedTypes?.Length, tts.element?.Length);
            Assert.IsNotNull(tts.element);
            for (int i = 0; i < namedTypes?.Length; i++)
            {
                Assert.AreEqual(namedTypes[i].name, tts.element[i].name);
                Assert.IsInstanceOfType(tts.element[i].elementType, typeof(NamedTypeSpecifier));
                Assert.AreEqual(namedTypes[i].type, ((NamedTypeSpecifier)tts.element[i].elementType).name?.Name);
            }
        }


        protected static void AssertListType(TypeSpecifier specifier, string elementTypeName)
        {
            Assert.IsInstanceOfType(specifier, typeof(ListTypeSpecifier));
            var lts = (ListTypeSpecifier)specifier;
            Assert.IsNotNull(lts.elementType);
            Assert.IsNull(lts.resultTypeName);
            Assert.IsInstanceOfType(lts.elementType, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)lts.elementType;
            Assert.IsNotNull(nts.name);
            Assert.AreEqual(elementTypeName, nts.name.Name);
        }

        protected static void AssertList<T>(
            List list,
            T[] expectedValues,
            string? precision = null)
        {
            Assert.IsNotNull(list.element);
            Assert.AreEqual(expectedValues.Length, list.element.Length);

            var lambda = ToFluentElmToolkit().Lambda(list);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<T?>));
            var array = ((IEnumerable<T?>)result).ToArray();
            Assert.AreEqual(expectedValues.Length, array.Length);
            for (int i = 0; i < expectedValues.Length; i++)
                Assert.AreEqual(true, ctx.Operators.Comparer.Equals(expectedValues[i], array[i], precision));
        }

        private static ILoggerFactory LoggerFactory { get; } =
            new ServiceCollection()
                .AddLogging(lb => lb.AddConsole())
                .BuildServiceProvider()
                .GetRequiredService<ILoggerFactory>();

        protected static FluentCqlToolkit CreateFluentCqlToolkit(
            ImmutableHashSet<CqlModel>? Models = null,
            ImmutableHashSet<ModelInfo>? ModelInfos = null,
            AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool EnableListPromotion = false,
            bool EnableListDemotion = false,
            bool EnableIntervalPromotion = false,
            bool EnableIntervalDemotion = false,
            bool AllowNullIntervals = false) =>
            new(
                LoggerFactory,
                new CqlToElmTranslatorConfig(
                    EnumerationExceptionHandling: EnumerationExceptionHandling.Throw,
                    Models: Models ?? [CqlModel.ElmR1, CqlModel.Fhir401],
                    ModelInfos: ModelInfos,
                    AmbiguousTypeBehavior: AmbiguousTypeBehavior,
                    EnableListDemotion: EnableListDemotion,
                    EnableListPromotion: EnableListPromotion,
                    EnableIntervalDemotion: EnableIntervalDemotion,
                    EnableIntervalPromotion: EnableIntervalPromotion,
                    AllowNullIntervals: AllowNullIntervals
                ));

        internal static FluentElmToolkit ToFluentElmToolkit(
            ImmutableHashSet<CqlModel>? models = null,
            ImmutableHashSet<ModelInfo>? modelInfos = null,
            AmbiguousTypeBehavior ambiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool enableListPromotion = false) =>
            CreateFluentCqlToolkit(models, modelInfos, ambiguousTypeBehavior, enableListPromotion)
                .ToFluentElmToolkit(_ => new ElmToAssemblyCompilerConfig(
                                        EnumerationExceptionHandling.Throw,
                                        Debugger.IsAttached ? AssemblyCompilerDebugInformationFormat.Embedded : AssemblyCompilerDebugInformationFormat.None));
    }
}