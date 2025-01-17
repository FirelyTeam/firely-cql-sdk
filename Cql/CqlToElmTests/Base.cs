using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Runtime;
using Expression = Hl7.Cql.Elm.Expression;
using CqlSdkPrototype.Runtime.Extensions;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Model;
using ChoiceTypeSpecifier = Hl7.Cql.Elm.ChoiceTypeSpecifier;
using IntervalTypeSpecifier = Hl7.Cql.Elm.IntervalTypeSpecifier;
using ListTypeSpecifier = Hl7.Cql.Elm.ListTypeSpecifier;
using NamedTypeSpecifier = Hl7.Cql.Elm.NamedTypeSpecifier;
using TupleTypeSpecifier = Hl7.Cql.Elm.TupleTypeSpecifier;
using TypeSpecifier = Hl7.Cql.Elm.TypeSpecifier;

namespace Hl7.Cql.CqlToElm.Test
{
    public class Base
    {
        protected const string SystemUri = "urn:hl7-org:elm-types:r1";

        protected static ServiceProvider ServiceProvider = null!;

        private static CqlToElmConverter DefaultConverter => ServiceProvider.GetCqlToElmConverter();

        internal static LibraryExpressionBuilder LibraryExpressionBuilder => ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

        protected static IServiceCollection ServiceCollection(
            Action<CqlToElmOptions>? options = null,
            Action<IModelProvider>? models = null,
            Type? libraryProviderType = null) =>
            ElmApiState.AddCqlCompilerServices(new ServiceCollection()
                                               .AddCqlToElmServices()
                                               .AddCqlToElmModels(models ?? (mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401)))
                                               .AddCqlToElmOptions(options)
                                               .AddCqlToElmMessaging()
                                               .AddLogging(builder => builder.AddConsole())
                                               .AddSingleton(typeof(ILibraryProvider), libraryProviderType ?? typeof(MemoryLibraryProvider)));


        protected static void ClassInitialize(Action<CqlToElmOptions>? options = null)
        {
            var services = ServiceCollection(options);
            ServiceProvider = services.BuildServiceProvider();
        }


        internal static byte[] Compile(Library library)
        {
            var assembly = CreateElmApi()
                           .AddElmLibraries([library])
                           .Compile()
                           .AsExtendable()
                           .Entries
                           .Values
                           .Single()
                           .AssemblyBinary;
            return assembly;
        }

        internal static LibraryBuilder MakeLibraryBuilder(
            IServiceProvider services,
            string cql,
            params string[] expectedErrors)
        {
            using var scope = services.CreateScope();
            var libraryVisitor = scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
            var builder = services.GetRequiredService<CqlToElmConverter>()
                                  .GetBuilder(libraryVisitor, cql);
            var lib = builder.Build();
            if (expectedErrors.Any())
                lib.ShouldReportError(expectedErrors);
            else
                lib.ShouldSucceed();

            return builder;
        }

        internal record LibrarySetDefinitions
        (
            LibrarySet LibrarySet,
            DefinitionDictionary<LambdaExpression> Definitions);

        internal static LibrarySetDefinitions BuildLibrarySetDefinitions(
            Library library)
        {
            LibrarySetExpressionBuilder librarySetExpressionBuilder = ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();
            LibrarySet librarySet = new LibrarySet(library.GetVersionedIdentifier()!, library);
            DefinitionDictionary<LambdaExpression> definitions = librarySetExpressionBuilder.ProcessLibrarySet(librarySet);
            return new(librarySet, definitions);
        }

        internal record LibrarySetCSharp(LibrarySetDefinitions LibrarySetDefinitions, IReadOnlyDictionary<string, string> CSharpCodeByLibraryName);

        internal static LibrarySetCSharp GenerateCSharp(LibrarySetDefinitions librarySetDefinitions)
        {
            var librarySetCSharpCodeGenerator = ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

            Dictionary<string, string> cSharpCodeByLibraryName =
                librarySetCSharpCodeGenerator
                    .GenerateCSharp(librarySetDefinitions.LibrarySet, librarySetDefinitions.Definitions)
                    .ToDictionary(o => o.library.GetVersionedIdentifier()!, o => o.cSharp);
            return new(librarySetDefinitions, cSharpCodeByLibraryName.AsReadOnly());
        }

        internal static object? Run(
            Expression expression,
            Library library,
            CqlContext? ctx = null)
        {
            ctx ??= DefaultCqlContext;
            var lambda = LibraryExpressionBuilder.Lambda(expression);
            var expressionName = "TempExpression";
            var state = CreateElmApi().AsInternal().State;
            LibrarySet librarySet = new("TempLibrarySet", library);
            DefinitionDictionary<LambdaExpression> definitions = new();
            definitions.Add(library.GetVersionedIdentifier()!, expressionName, lambda);
            var generateCSharp = state.LibrarySetCSharpCodeGenerator.GenerateCSharp(librarySet, definitions);
            var compile = state.AssemblyCompiler.Compile(librarySet, generateCSharp, state.Options.AssemblyCompilerDebugInformationFormat);
            var assemblyBytes = compile.Single().assemblyDataWithSourceCode.AssemblyBytes;

            using var scope = new RuntimeApi()
                              .AddAssemblies([AssemblyData.Default with { AssemblyBytes = assemblyBytes }])
                              .CreateRuntimeScope();
            var result = scope.GetLibraryDefinitionResult(ctx!, CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier), expressionName);
            return result;
        }

        private static readonly CqlContext DefaultCqlContext = FhirCqlContext.CreateContext();

        internal static T? Run<T>(
            Expression expression,
            Library library,
            CqlContext? ctx = null) =>
            (T?)Run(expression, library, ctx);

        internal static object? Run(
            Library library,
            Func<DefinitionDictionary<Delegate>, CqlContext> ctxFactory,
            string definition,
            params object[] args)
        {
            var eb = LibraryExpressionBuilder;
            var lambdas = eb.ProcessLibrary(library);
            var delegates = lambdas.CompileAll();
            var dg = delegates[library.GetVersionedIdentifier(), definition];
            var ctx = ctxFactory(delegates);
            var result = dg.DynamicInvoke(new[] { ctx }.Concat(args).ToArray());
            return result;
        }

        protected static void AssertResult<T>(Expression be, T expected)
        {
            var lambda = LibraryExpressionBuilder.Lambda(@be);
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
            var lambda = LibraryExpressionBuilder.Lambda(@be);
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

            var lambda = LibraryExpressionBuilder.Lambda(list);
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

        internal static void AddFHIRHelpers(
            MemoryLibraryProvider provider,
            IServiceScope scope,
            string path = @"Input\FHIRHelpers-4.0.1.cql")
        {
            var text = File.ReadAllText(path);
            var libraryVisitor = scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
            var builder = DefaultConverter.GetBuilder(libraryVisitor, text);
            provider.Libraries.Add("FHIRHelpers", "4.0.1", builder);
        }

        protected static ILoggerFactory LoggerFactory { get; } =
            new ServiceCollection()
                .AddLogging(lb => lb.AddConsole())
                .BuildServiceProvider()
                .GetRequiredService<ILoggerFactory>();

        protected static CqlApi CreateCqlApi(
            ImmutableHashSet<CqlModel>? Models = null,
            ImmutableHashSet<ModelInfo>? ModelInfos = null,
            AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool EnableListPromotion = false,
            bool EnableListDemotion = false,
            bool EnableIntervalPromotion = false,
            bool EnableIntervalDemotion = false,
            bool AllowNullIntervals = false) =>
            new CqlApi(
                LoggerFactory,
                new CqlApiOptions(
                    ProcessBatchItemExceptionHandling: ProcessBatchItemExceptionHandling.ThrowException,
                    Models: Models ?? [CqlModel.ElmR1, CqlModel.Fhir401],
                    ModelInfos: ModelInfos,
                    AmbiguousTypeBehavior: AmbiguousTypeBehavior,
                    EnableListDemotion: EnableListDemotion,
                    EnableListPromotion: EnableListPromotion,
                    EnableIntervalDemotion: EnableIntervalDemotion,
                    EnableIntervalPromotion: EnableIntervalPromotion,
                    AllowNullInterval: AllowNullIntervals
                    ));

        protected static ElmApi CreateElmApi(
            ImmutableHashSet<CqlModel>? models = null,
            ImmutableHashSet<ModelInfo>? modelInfos = null,
            AmbiguousTypeBehavior ambiguousTypeBehavior = AmbiguousTypeBehavior.Error,
            bool enableListPromotion = false) =>
            CreateCqlApi(models, modelInfos, ambiguousTypeBehavior, enableListPromotion)
                .CreateElmApi(_ => new ElmApiOptions(
                                  ProcessBatchItemExceptionHandling.ThrowException,
                                  Debugger.IsAttached ? AssemblyCompilerDebugInformationFormat.Embedded : AssemblyCompilerDebugInformationFormat.None));
    }

    internal static partial class TestExtensions
    {
        private static CqlLibraryString FHIRHelpers { get; } =
            CqlLibraryString.FromCql(File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql"));

        public static CqlApi AddFHIRHelpers(this CqlApi cqlApi) => cqlApi.AddCqlLibraryString(FHIRHelpers);

        public static Library MakeLibrary(
            this CqlApi cqlApi,
            string cql,
            params string[] expectedErrors)
        {
            var cqlLibraryString = CqlLibraryString.FromCql(cql);

            var library = cqlApi
                          .AddCqlLibraryString(cqlLibraryString)
                          .Translate()
                          .AsExtendable()
                          .Entries[cqlLibraryString.VersionedLibraryIdentifier]
                          .ElmLibrary!;

            if (expectedErrors.Any())
                library.ShouldReportError(expectedErrors);
            else
                library.ShouldSucceed();

            return library;
        }

        public static Library MakeLibraryFromExpression(
            this CqlApi cqlApi,
            string expression,
            string[]? expectedErrors = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            string cql = $"""
                library Test version '1.0.0'

                define private "{memberName}": {expression}
                """;
            var lib = cqlApi.MakeLibrary(cql, expectedErrors ?? []);
            return lib;
        }
    }
}