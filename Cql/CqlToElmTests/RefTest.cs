using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class RefTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void ValueSet_Local()
        {
            var library = MakeLibrary($@"
                library {nameof(RefTest)} version '1.0.0'

                valueset ""vs"": 'http://xyz.com'

                define private {nameof(ValueSet_Local)}: ""vs""
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ValueSetRef));
            AssertType(library.statements[0].expression, $"{{{SystemUri}}}ValueSet");
            var result = Run<CqlValueSet>(library, nameof(ValueSet_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CodeSystem_Local()
        {
            var library = MakeLibrary($@"
                library {nameof(RefTest)} version '1.0.0'

                private codesystem CS: 'id' version 'version string'

                define private {nameof(CodeSystem_Local)}: ""CS""
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(CodeSystemRef));
            AssertType(library.statements[0].expression, $"{{{SystemUri}}}CodeSystem");
            var result = Run<CqlCode[]>(library, nameof(CodeSystem_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Code_Local()
        {
            var library = MakeLibrary($@"
                library {nameof(RefTest)} version '1.0.0'

                private codesystem CS: 'id' version 'version string'
                private code C: 'id' from CS display 'Code display text'

                define private {nameof(Code_Local)}: ""C""
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(CodeRef));
            AssertType(library.statements[0].expression, $"{{{SystemUri}}}Code");
            var result = Run<CqlCode>(library, nameof(Code_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Concept_Local()
        {
            var library = MakeLibrary($@"
                library {nameof(RefTest)} version '1.0.0'

                private codesystem CS: 'id' version 'version string'
                private code C: 'id' from CS display 'Code display text'
                private concept TheConcept: {{ C }} display 'My concept'

                define private {nameof(Concept_Local)}: ""TheConcept""
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ConceptRef));
            AssertType(library.statements[0].expression, $"{{{SystemUri}}}Concept");
            var result = Run<CqlConcept>(library, nameof(Concept_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Parameter()
        {
            var library = MakeLibrary($@"
                library {nameof(RefTest)} version '1.0.0'

                private parameter ""Measurement Year"" System.Integer default 2023

                define private {nameof(Parameter)}: ""Measurement Year""
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ParameterRef));
            AssertType(library.statements[0].expression, $"{{{SystemUri}}}Integer");
            var result = Run<int?>(library, nameof(Parameter));
            Assert.IsNotNull(result);
            Assert.AreEqual(2023, result);
        }

        private static T? Run<T>(Library library, string member)
        {
            var eb = ExpressionBuilderFor(library);
            var lambdas = eb.Build();
            var delegates = lambdas.CompileAll();
            var dg = delegates[library.NameAndVersion, member];
            var ctx = FhirCqlContext.ForBundle(delegates: delegates);
            var result = dg.DynamicInvoke(ctx);
            Assert.IsInstanceOfType(result, typeof(T));
            return (T?)result;
        }

        private static void AssertType(Expression expression, string typeName)
        {
            Assert.IsNotNull(expression.resultTypeName);
            Assert.AreEqual(typeName, expression.resultTypeName.Name);
            Assert.IsInstanceOfType(expression.resultTypeSpecifier, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)expression.resultTypeSpecifier;
            Assert.AreEqual(typeName, nts.name?.Name);
        }
    }
}
