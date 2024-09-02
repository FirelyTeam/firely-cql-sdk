using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InstanceTest : Base
    {

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

        [TestMethod]
        public void Concept_Instance()
        {
            var library = CreateLibraryForExpression("Concept { codes: Code { code: '8480-6' } }");
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