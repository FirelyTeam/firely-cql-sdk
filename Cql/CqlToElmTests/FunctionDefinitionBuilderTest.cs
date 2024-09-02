using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    internal class FunctionDefinitionBuilderTest : Base
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
            var fns = overload.Functions.ToArray();
            Assert.AreEqual(2, fns.Length);
            var first = fns[0];
            var fo = first.Operands.ToArray();
            Assert.AreEqual(1, fo.Length);
            Assert.AreEqual(SystemTypes.IntegerType, fo[0].operandTypeSpecifier);
            var second = fns[1];
            var so = second.Operands.ToArray();
            Assert.AreEqual(1, so.Length);
            Assert.AreEqual(SystemTypes.DecimalType, so[0].operandTypeSpecifier);
        }
    }
}
