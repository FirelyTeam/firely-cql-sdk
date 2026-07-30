/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InstanceTest : Base
    {

        [TestMethod]
        public void Concept_Instance()
        {
            var library = CreateCqlToolkit(
                DisableListDemotion:false,
                DisableListPromotion:false
                ).MakeLibraryFromExpression("Concept { codes: Code { code: '8480-6' } }");
            var instance = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Instance>();
            instance.element.Should().HaveCount(1);
            instance.element[0].name.Should().Be("codes");
            var toList = instance.element[0].value.Should().BeOfType<ToList>().Subject;
            var listInstance = toList.operand.Should().BeOfType<Instance>().Subject;
            listInstance.element.Should().HaveCount(1);
            var instanceElement = listInstance.element[0].Should().BeOfType<InstanceElement>().Subject;
            instanceElement.value.Should().BeLiteralString("8480-6");
            instanceElement.name.Should().Be("code");
        }

        [TestMethod]
        public void Concept_Instance_Element_Not_Coercible()
        {
            // Without list promotion the single Code cannot be coerced to List<Code>, which must yield a
            // translation error naming the element instead of throwing (#1416).
            CreateCqlToolkit()
                .MakeLibraryFromExpression(
                    "Concept { codes: Code { code: '8480-6' } }",
                    expectedErrors: ["The value for element codes of type 'Code' cannot be converted to the declared type 'List<Code>'."]);
        }
    }
}
