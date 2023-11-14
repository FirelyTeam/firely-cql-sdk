using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class InvocationTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private Library createLibraryForExpression(string expression)
        {
            return MakeLibrary($@"
                library IsTest version '1.0.0'
    
                define four: 4
                define function double(x Integer): x * 2

                define private test: {expression}");
        }

        private ExpressionDef shouldDefineExpression(Library l, string name) =>
            l.ShouldDefine<ExpressionDef>(name);
    }
}
