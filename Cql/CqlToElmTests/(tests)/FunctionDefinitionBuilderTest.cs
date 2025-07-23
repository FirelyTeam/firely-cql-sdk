/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FunctionDefinitionBuilderTest : Base
    {
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
