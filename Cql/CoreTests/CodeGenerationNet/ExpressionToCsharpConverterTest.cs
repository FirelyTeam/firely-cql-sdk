using System;
using System.Linq.Expressions;
using Hl7.Cql.CodeGeneration.NET;
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
}
