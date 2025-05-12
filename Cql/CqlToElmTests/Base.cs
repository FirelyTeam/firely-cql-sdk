using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Cql.Model;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Invocation.Toolkit;

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
            var elmToolkit = CreateElmToolkit();
            var expressionName = "TempExpression";
            var definition = new CqlExpressionDefinition(elmToolkit.Lambda(expression), expressionName);
            var elmToolkitServices = elmToolkit;
            LibrarySet librarySet = new("TempLibrarySet", library);
            CqlDefinitionDictionary definitions = new();
            definitions.AddDefinition(library.VersionedLibraryIdentifier, expressionName, definition);

            var generateCSharp =
                elmToolkitServices
                    .GetLibrarySetCSharpCodeGenerator()
                    .GenerateEachLibraryToCSharp(librarySet, definitions)
                    .ToList();

            var compile =
                elmToolkitServices
                    .GetAssemblyCompiler()
                    .CompileEachLibraryToAssemblies(generateCSharp, librarySet, elmToolkit.Config.AssemblyCompilerDebugInformationFormat)
                    .ToList();

            var assemblyBytes = compile.Single().assemblyBinaryWithSourceCode.AssemblyBytes;

            using var librarySetInvoker =
                new InvocationToolkit()
                    .AddAssemblyBinaries(AssemblyBinary.Default with { AssemblyBytes = assemblyBytes })
                    .CreateLibrarySetInvoker();

            var result = librarySetInvoker.InvokeLibraryDefinition(ctx!, library.VersionedLibraryIdentifier, expressionName);
            return result;
        }

        private static readonly CqlContext DefaultCqlContext = FhirCqlContext.CreateContext();

        private static readonly ElmToolkitConfig ElmToolkitConfig =
            Debugger.IsAttached
            ? new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat: AssemblyCompilerDebugInformationFormat.Embedded)
            : ElmToolkitConfig.Default;

        internal static T? Run<T>(
            Expression expression,
            Library library,
            CqlContext? ctx = null) =>
            (T?)Run(expression, library, ctx);

        protected static void AssertResult<T>(Expression be, T expected)
        {
            var lambda = CreateElmToolkit().Lambda(@be);
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
            var lambda = CreateElmToolkit().Lambda(@be);
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

            var lambda = CreateElmToolkit().Lambda(list);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<T?>));
            var array = ((IEnumerable<T?>)result).ToArray();
            Assert.AreEqual(expectedValues.Length, array.Length);
            for (int i = 0; i < expectedValues.Length; i++)
                Assert.AreEqual(
                    true,
                    (expectedValues[i], array[i]) switch
                    {
                        (null, null) => true, // #REVIEW: This is overriding the spec which says that nulls are not equal
                        _            => ctx.Operators.Comparer.Equals(expectedValues[i], array[i], precision)
                    });
        }

        private static ILoggerFactory LoggerFactory { get; } =
            Microsoft.Extensions.Logging.LoggerFactory.Create(builder => builder.AddConsole());

        protected static CqlToolkit CreateCqlToolkit(
            ImmutableHashSet<CqlModel>? Models = null,
            ImmutableHashSet<ModelInfo>? ModelInfos = null,
            AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool EnableListPromotion = false,
            bool EnableListDemotion = false,
            bool EnableIntervalPromotion = false,
            bool EnableIntervalDemotion = false,
            bool AllowNullIntervals = false)
        {
            Debug.Assert(CqlToolkitConfig.DefaultCqlModels.SetEquals([CqlModel.ElmR1, CqlModel.Fhir401]));
            return new CqlToolkit(LoggerFactory,
                                  new CqlToolkitConfig(
                                      Models: Models,
                                      ModelInfos: ModelInfos,
                                      AmbiguousTypeBehavior: AmbiguousTypeBehavior,
                                      EnableListDemotion: EnableListDemotion,
                                      EnableListPromotion: EnableListPromotion,
                                      EnableIntervalDemotion: EnableIntervalDemotion,
                                      EnableIntervalPromotion: EnableIntervalPromotion,
                                      AllowNullIntervals: AllowNullIntervals
                                  ));
        }

        internal static ElmToolkit CreateElmToolkit(
            ImmutableHashSet<CqlModel>? models = null,
            ImmutableHashSet<ModelInfo>? modelInfos = null,
            AmbiguousTypeBehavior ambiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool enableListPromotion = false) =>
            CreateCqlToolkit(models, modelInfos, ambiguousTypeBehavior, enableListPromotion)
                .CreateElmToolkit(ElmToolkitConfig);
    }
}