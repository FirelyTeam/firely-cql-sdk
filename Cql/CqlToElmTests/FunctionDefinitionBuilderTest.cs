using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FunctionDefinitionBuilderTest : Base
    {
        internal static InvocationBuilder InvocationBuilder => Services.GetRequiredService<InvocationBuilder>();

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(options =>
        {
            options.EnableListPromotion = true;
            options.EnableListDemotion = true;
            options.EnableIntervalPromotion = true;
            options.EnableIntervalDemotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        private static ParameterTypeSpecifier Generic(string parameterName = "T") => new ParameterTypeSpecifier { parameterName = parameterName };

        [TestMethod]
        public void ForSimpleTypes()
        {
            var generic = Generic();
            var genericFunction = new SystemFunction<Abs>(new[] { generic }, generic);
            var overload = genericFunction.For(generic,
                SystemTypes.IntegerType,
                SystemTypes.DecimalType);
            Assert.AreEqual(2, overload.Functions.Length);
            var first = overload.Functions[0];
            Assert.AreEqual(1, first.operand.Length);
            Assert.AreEqual(SystemTypes.IntegerType, first.operand[0].operandTypeSpecifier);
            var second = overload.Functions[1];
            Assert.AreEqual(1, second.operand.Length);
            Assert.AreEqual(SystemTypes.DecimalType, second.operand[0].operandTypeSpecifier);
        }
    }
}
