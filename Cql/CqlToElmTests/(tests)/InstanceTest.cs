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
                EnableListDemotion:true,
                EnableListPromotion:true,
                EnableIntervalDemotion: true,
                EnableIntervalPromotion: true
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
    }
}