using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.CqlToElm.Test
{
    public class Base
    {
        protected const string SystemUri = "urn:hl7-org:elm-types:r1";

        internal static CqlToElmConverter DefaultConverter => Services.GetRequiredService<CqlToElmConverter>();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected static IServiceProvider Services;

        internal static ExpressionBuilder ExpressionBuilder;

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        protected static void ClassInitialize(Action<CqlToElmOptions>? options = null)
        {
            var services = new ServiceCollection()
                .AddModels(mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401))
                .AddVisitors()
                .AddContext()
                .AddLocalIdProvider()
                .AddConfiguration(cb => cb.WithOptions(options ?? (o => { })))
                .AddLogging(builder => builder
                    .AddConsole()
                    .ThrowOn(LogLevel.Error))
                .AddTransient<InvocationBuilder>()
                .AddSingleton<TypeConverter>()
                .AddSingleton<ElmFactory>()
                .AddScoped<CqlToElmConverter>();
            Services = services.BuildServiceProvider();

            var lib = new Library
            {
                identifier = new VersionedIdentifier { id = "Lambdas", version = "1.0.0" }
            };
            ExpressionBuilder = ExpressionBuilderFor(lib);
        }


        protected virtual Library ConvertLibrary(string cql) => DefaultConverter.ConvertLibrary(cql);

        internal Library MakeLibrary(string cql, params string[] expectedErrors)
        {
            var library = ConvertLibrary(cql);

            if (expectedErrors.Any())
                library.ShouldReportError(expectedErrors);
            else
                library.ShouldSucceed();

            return library;
        }

        internal static object? Run(Expression expression, CqlContext? ctx = null)
        {
            var lambda = ExpressionBuilder.Lambda(expression);
            var dg = lambda.Compile();
            var result = dg.DynamicInvoke(ctx ?? FhirCqlContext.ForBundle());
            return result;
        }
        internal static T? Run<T>(Expression expression, CqlContext? ctx = null) =>
            (T?)Run(expression, ctx);

        internal static object? Run(Library library,
            Func<DefinitionDictionary<Delegate>, CqlContext> ctxFactory,
            string definition,
            params object[] args)
        {
            var eb = ExpressionBuilderFor(library);
            var lambdas = eb.Build();
            var delegates = lambdas.CompileAll();
            var dg = delegates[library.NameAndVersion, definition];
            var ctx = ctxFactory(delegates);
            var result = dg.DynamicInvoke(new[] { ctx }.Concat(args).ToArray());
            return result;
        }

        internal static ExpressionBuilder ExpressionBuilderFor(Library lib)
        {
            var tr = FhirTypeResolver.Default;
            var tc = FhirTypeConverter.Default;
            var tm = new TypeManager(tr);
            var binding = new CqlOperatorsBinding(tr, tc);
            var logger = Services.GetRequiredService<ILogger<ExpressionBuilder>>();
            var expressionBuilder = new ExpressionBuilder(binding, tm, lib, logger);
            return expressionBuilder;
        }

        public void AssertResult<T>(Expression be, T expected)
        {
            var lambda = ExpressionBuilder.Lambda(@be);
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
            var lambda = ExpressionBuilder.Lambda(@be);
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

            var lambda = ExpressionBuilder.Lambda(list);
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

        protected Library createLibraryForExpression(string expression, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "func")
        {
            return MakeLibrary($@"
                library AsTest version '1.0.0'

                define private ""{memberName}"": {expression}");
        }
    }
}
