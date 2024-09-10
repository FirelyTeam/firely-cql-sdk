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
using System.IO;
using System.Linq;
using System.Reflection;
using Hl7.Cql.CodeGeneration.NET.Hosting;
using Hl7.Cql.CqlToElm.Hosting;

namespace Hl7.Cql.CqlToElm.Test
{
    public class Base
    {
        protected const string SystemUri = "urn:hl7-org:elm-types:r1";

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal static CqlCodeGenerationServices CqlCodeGenerationServices;
        internal static CqlToElmServices CqlToElmServices;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        internal static CqlToElmConverter DefaultConverter => CqlToElmServices.CqlToElmConverter;

        internal static LibraryExpressionBuilder LibraryExpressionBuilder => CqlCodeGenerationServices.GetCqlCompilerServices().LibraryExpressionBuilderScoped();

        internal static CSharpLibrarySetToStreamsWriter SourceCodeWriter => CqlCodeGenerationServices.CSharpLibrarySetToStreamsWriter;

        internal static MessageProvider Messaging => CqlToElmServices.MessageProvider;

        protected static IServiceCollection ServiceCollection(Action<CqlToElmOptions>? options = null,
            Action<IModelProvider>? models = null,
            Type? libraryProviderType = null) =>
            new ServiceCollection()
                .AddSystem()
                .AddModels(models ?? (mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401)))
                .AddConfiguration(cb => cb.WithOptions(options ?? (o => { })))
                .AddMessaging()
                .AddLogging(builder => builder
                    .AddConsole())
                .AddSingleton(typeof(ILibraryProvider), libraryProviderType ?? typeof(MemoryLibraryProvider));


        protected static void ClassInitialize(Action<CqlToElmOptions>? options = null)
        {
            var services = ServiceCollection(options);
            services.AddCqlCodeGenerationServices();
            var sb = services.BuildServiceProvider();
            CqlCodeGenerationServices = sb.GetCqlCodeGenerationServices();
            CqlToElmServices = sb.GetCqlToElmServices();
        }

        protected static Library ConvertLibrary(string cql) => DefaultConverter.ConvertLibrary(cql);

        protected virtual Library ConvertLibrary(IServiceProvider services, string cql) =>
            services.GetRequiredService<CqlToElmConverter>().ConvertLibrary(cql);


        internal static Library MakeLibrary(string cql, params string[] expectedErrors)
        {
            var library = ConvertLibrary(cql);

            if (expectedErrors.Any())
                library.ShouldReportError(expectedErrors);
            else
                library.ShouldSucceed();

            return library;
        }
        internal Library MakeLibrary(IServiceProvider services, string cql, params string[] expectedErrors)
        {
            var library = ConvertLibrary(services, cql);
            if (expectedErrors.Any())
                library.ShouldReportError(expectedErrors);
            else
                library.ShouldSucceed();

            return library;
        }
        internal LibraryBuilder MakeLibraryBuilder(IServiceProvider services, string cql, params string[] expectedErrors)
        {
            using var scope = services.CreateScope();
            var builder = services.GetRequiredService<CqlToElmConverter>()
                .GetBuilder(cql, scope);
            var lib = builder.Build();
            if (expectedErrors.Any())
                lib.ShouldReportError(expectedErrors);
            else
                lib.ShouldSucceed();

            return builder;
        }
        internal static object? Run(Expression expression, CqlContext? ctx = null)
        {
            var lambda = LibraryExpressionBuilder.Lambda(expression);
            var dg = lambda.Compile();
            var result = dg.DynamicInvoke(ctx ?? FhirCqlContext.ForBundle());
            return result;
        }
        internal static T? Run<T>(Expression expression, CqlContext? ctx = null) =>
            (T?)Run(expression, ctx);

        internal static object? Run(
            Library library,
            Func<DefinitionDictionary<Delegate>, CqlContext> ctxFactory,
            string definition,
            params object[] args)
        {
            var eb = LibraryExpressionBuilder;
            var lambdas = eb.ProcessLibrary(library);
            var delegates = lambdas.CompileAll();
            var dg = delegates[library.NameAndVersion(), definition];
            var ctx = ctxFactory(delegates);
            var result = dg.DynamicInvoke(new[] { ctx }.Concat(args).ToArray());
            return result;
        }

        public void AssertResult<T>(Expression be, T expected)
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
        public void AssertNullResult(Expression be)
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


        protected void AssertIntervalType(TypeSpecifier specifier, string pointTypeName)
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

        protected void AssertIntervalType(TypeSpecifier typeSpecifier, TypeSpecifier pointType)
        {
            Assert.IsInstanceOfType(typeSpecifier, typeof(IntervalTypeSpecifier));
            var lts = (IntervalTypeSpecifier)typeSpecifier;
            Assert.IsNotNull(lts.pointType);
            Assert.AreEqual(lts.pointType, pointType);

        }

        protected void AssertChoiceType(TypeSpecifier specifier, params string[] namedTypes)
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

        protected void AssertTupleType(TypeSpecifier specifier, params (string name, string type)[] namedTypes)
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


        protected void AssertListType(TypeSpecifier specifier, string elementTypeName)
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

        protected void AssertList<T>(List list, T[] expectedValues, string? precision = null)
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

        protected Library CreateLibraryForExpression(string expression, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "func")
        {
            return MakeLibrary($@"
                library Test version '1.0.0'

                define private ""{memberName}"": {expression}");
        }

        protected Library ExpectErrorsForExpression(string expression,
            params string[] expectedErrors)
        {
            return MakeLibrary($@"
                library Test version '1.0.0'

                define private ""Has Errors"": {expression}", expectedErrors);
        }

        protected static Expression Expression(string expression, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "func")
        {
            var lib = ConvertLibrary($@"
                library Test version '1.0.0'

                define private ""{memberName}"": {expression}");
            return lib.statements[0].expression;
        }

        internal static void AddFHIRHelpers(MemoryLibraryProvider provider,
            IServiceScope scope,
            string path = @"Input\FHIRHelpers-4.0.1.cql")
        {
            var text = File.ReadAllText(path);
            var builder = DefaultConverter.GetBuilder(text, scope);
            provider.Libraries.Add("FHIRHelpers", "4.0.1", builder);
        }


        internal static string WriteCSharp(Library library)
        {
            var lambdas = LibraryExpressionBuilder.ProcessLibrary(library);
            var ls = new LibrarySet("", library);
            var csByNav = new Dictionary<string, string>();
            var callbacks = new CSharpSourceCodeWriterCallbacks(onAfterStep: afterWrite);
            SourceCodeWriter.ProcessDefinitions(lambdas, ls, callbacks);
            return csByNav[library.NameAndVersion()!];

            void afterWrite(CSharpSourceCodeStep step)
            {
                switch (step)
                {
                    case CSharpSourceCodeStep.OnStream onStream:
                        onStream.Stream.Seek(0, SeekOrigin.Begin);
                        using (var reader = new StreamReader(onStream.Stream))
                        {
                            var code = reader.ReadToEnd();
                            csByNav.Add(onStream.Name, code);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        internal static byte[] Compile(Library library)
        {
            var lambdas = LibraryExpressionBuilder.ProcessLibrary(library);
            var asm = CqlCodeGenerationServices.AssemblyCompiler;
            var dict = asm.Compile(new LibrarySet("",library), lambdas);
            return dict.Single().Value.Binary;
        }
    }
}
