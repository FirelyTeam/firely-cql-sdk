using System;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Specification;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expression = System.Linq.Expressions.Expression;

namespace CoreTests.CodeGenerationNet;

internal class Tuple_123
{
    public string status { get; set; }
    public string result { get; set; }
}

[TestClass]
public class ExpressionToCsharpConverterTest
{
    static readonly IOptions<CSharpCodeWriterOptions> _codeWriterOptions =
        new OptionsWrapper<CSharpCodeWriterOptions>(new CSharpCodeWriterOptions());

    readonly ExpressionToCSharpConverter _converter = new(
        _codeWriterOptions,
        new TypeToCSharpConverter(),
        "");

    [TestMethod]
    public void ConvertTopLevelFunctionDefinition_OnLambdaReturningTuple_ReturnsExpectedFunction()
    {
        // Arrange
        Expression<Func<Tuple_123>> func = Expression.Lambda<Func<Tuple_123>>(
            Expression.Block(
                Expression.Assign(
                    Expression.Variable(typeof(Tuple_123), "a"),
                    Expression.MemberInit(
                        Expression.New(typeof(Tuple_123)),
                        Expression.Bind(typeof(Tuple_123).GetProperty("status"), Expression.Constant("success")),
                        Expression.Bind(typeof(Tuple_123).GetProperty("result"), Expression.Constant("some result")))),
                Expression.Variable(typeof(Tuple_123), "a")
            )
        );

        // Act
        var res = _converter.ConvertTopLevelFunctionDefinition(0, func, "TestFunction", "private");

        // Assert
        Assert.AreEqual("private dynamic TestFunction()\r\n{\r\n\tdynamic a = new ExpandoObject();\r\n\ta.status = \"success\";\r\n\ta.result = \"some result\";\r\n\r\n\r\n\treturn a;\r\n}\r\n", res);
    }

    [TestMethod]
    public void Test3()
    {
        using var serviceProvider = new ServiceCollection()
            .AddDebugLogging()
            .AddCqlCodeGenerationServices()
            .BuildServiceProvider(validateScopes: true);

        using var servicesScope = serviceProvider.CreateScope();

        var librarySet = new LibrarySet();
        librarySet.LoadLibraryAndDependencies(new DirectoryInfo(@"Input\ELM\Test"), "CqlTupleTest", "1.0.0");
        var elmPackage = librarySet.GetLibrary("CqlTupleTest-1.0.0");
        var definitions = servicesScope.ServiceProvider.GetLibraryExpressionBuilderScoped().ProcessLibrary(elmPackage);

        var writer = serviceProvider.GetCSharpLibrarySetToStreamsWriter();
        var isDone = false;

        writer.ProcessDefinitions(
            definitions,
            librarySet,
            callbacks: new(onAfterStep: step =>
            {
                switch (step)
                {
                    case CSharpSourceCodeStep.OnDone:
                        isDone = true;
                        break;
                }
            }));
        Assert.IsTrue(isDone);
    }

    //[TestMethod]
    //public void ConvertTuple()
    //{
    //    var elmDir = new DirectoryInfo(@"Input\ELM\Test");
    //    var elmLib = Library.LoadFromJson(elmDir, "CqlTupleTest", "1.0.0", true);
    //    Assert.IsTrue(elmLib.IsValidated);

    //    var logFactory = new LoggerFactory();

    //    var modelInspector = Hl7.Fhir.Model.ModelInfo.ModelInspector;
    //    var typeConverter = FhirTypeConverter
    //                        .Create(modelInspector, 0)
    //                        .UseLogger(logFactory.CreateLogger<TypeConverter>());

    //    typeConverter.CaptureAvailableConverters();

    //    var fhirTypeResolver = new FhirTypeResolver(modelInspector);

    //    var expressionBuilder = new ExpressionBuilder(
    //        logFactory.CreateLogger<ExpressionBuilder>(),
    //        ExpressionBuilderSettings.Default,
    //        new CqlOperatorsBinder(
    //            logFactory.CreateLogger<CqlOperatorsBinder>(),
    //            fhirTypeResolver,
    //            typeConverter),
    //        new TupleBuilderCache(logFactory.CreateLogger<TupleBuilderCache>()),
    //        fhirTypeResolver,
    //        new CqlContextBinder()
    //    );
    //    var libExpressionBuilder = new LibraryExpressionBuilder(
    //        logFactory.CreateLogger<LibraryExpressionBuilder>(),
    //        expressionBuilder);

    //    var definitionDictionary = libExpressionBuilder.ProcessLibrary(elmLib);
    //    definitionDictionary.TryGetValue("CqlTupleTest-1.0.0","Result", out var tupleExpression);
    //    Assert.IsNotNull(tupleExpression);

    //    var res = _converter.ConvertTopLevelFunctionDefinition(0, tupleExpression, "TestFunction", "public");
    //    Assert.IsNotNull(res);

    //    var expected = "public ExpandoObject TestFunction() => \r\n{\r\n\tExpandoObject a = new ExpandoObject();\r\n\ta.status = \"success\";\r\n\ta.result = \"some result\"\r\n\treturn a;\r\n};\r\n";
    //    Assert.AreEqual(expected, res);

    //}
}
