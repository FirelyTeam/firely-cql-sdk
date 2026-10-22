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

        [TestMethod]
        public void Instance_Element_With_Nested_List_Element_Type_Specifier()
        {
            // The FHIR model info declares ClaimResponse.adjudication as a list whose element type is a nested
            // NamedTypeSpecifier rather than an elementType name; the instance element must resolve to that type.
            var library = CreateCqlToolkit().MakeLibrary("""
                library NestedListElement version '1.0.0'
                using FHIR version '4.0.1'

                define function "WithAdjudication"(arg ClaimResponse):
                  ClaimResponse { adjudication: arg.adjudication }
                """);

            var function = library.ShouldDefine<FunctionDef>("WithAdjudication");
            var instance = function.expression.Should().BeOfType<Instance>().Subject;
            instance.element.Should().ContainSingle();
            instance.element[0].name.Should().Be("adjudication");
            instance.element[0].value.resultTypeSpecifier.Should().Be(
                new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}ClaimResponse.Item.Adjudication").ToNamedType().ToListType());
        }
    }
}
