using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TypeExtentTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void TypeExtent_Minimum_Integer()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Integer: minimum Integer
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(int.MinValue, result);
            }

        }

        [TestMethod]
        public void TypeExtent_Maximum_Integer()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Integer: maximum Integer
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(int.MaxValue, result);
            }

        }

        [TestMethod]
        public void TypeExtent_Minimum_Long()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Long: minimum Long
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(long.MinValue, result);
            }

        }

        [TestMethod]
        public void TypeExtent_Maximum_Long()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Long: maximum Long
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(long.MaxValue, result);
            }

        }

        [TestMethod]
        public void TypeExtent_Minimum_Decimal()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Decimal: minimum Decimal
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(decimal.MinValue, result);
            }

        }

        [TestMethod]
        public void TypeExtent_Maximum_Decimal()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Decimal: maximum Decimal
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(decimal.MaxValue, result);
            }
        }

        [TestMethod]
        public void TypeExtent_Minimum_Quantity()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Quantity: minimum Quantity
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(decimal.MinValue, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }

        }

        [TestMethod]
        public void TypeExtent_Maximum_Quantity()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Quantity: maximum Quantity
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(decimal.MaxValue, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }

        }

        [TestMethod]
        public void TypeExtent_Minimum_Date()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Date: minimum Date
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDate));
                Assert.AreEqual("0001-01-01", result.ToString());
            }
        }

        [TestMethod]
        public void TypeExtent_Maximum_Date()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Date: maximum Date
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDate));
                Assert.AreEqual("9999-12-31", result.ToString());
            }
        }

        [TestMethod]
        public void TypeExtent_Minimum_DateTime()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_DateTime: minimum DateTime
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDateTime));
                Assert.AreEqual("0001-01-01T00:00:00.000Z", result.ToString());
            }
        }

        [TestMethod]
        public void TypeExtent_Maximum_DateTime()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_DateTime: maximum DateTime
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDateTime));
                Assert.AreEqual("9999-12-31T23:59:59.999Z", result.ToString());
            }
        }

        [TestMethod]
        public void TypeExtent_Minimum_Time()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Minimum_Time: minimum Time
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MinValue));
            {
                var extent = (MinValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlTime));
                Assert.AreEqual("00:00:00.000Z", result.ToString());
            }
        }

        [TestMethod]
        public void TypeExtent_Maximum_Time()
        {
            var library = MakeLibrary(@"
                library TypeExtentTest version '1.0.0'

                define private TypeExtent_Maximum_Time: maximum Time
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MaxValue));
            {
                var extent = (MaxValue)library.statements[0].expression;
                Assert.IsNotNull(extent.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", extent.resultTypeName.Name);
                Assert.IsNotNull(extent.resultTypeSpecifier);
                Assert.IsInstanceOfType(extent.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)extent.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);

                var lambda = ExpressionBuilder.Lambda(extent);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlTime));
                Assert.AreEqual("23:59:59.999Z", result.ToString());
            }
        }

    }
}
