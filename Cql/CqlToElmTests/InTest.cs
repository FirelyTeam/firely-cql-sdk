using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter
        
        [TestMethod]
        public void Starts_Properly_Within_Start()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library InTest version '1.0.0'

                define private Starts_Properly_Within_Start: Interval[@2023, @2030] starts properly within 1 year of start Interval[@2022, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var includedIn = (In)library.statements[0].expression;
                Assert.IsFalse(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Properly_Within_Start()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library InTest version '1.0.0'

                define private Properly_Within_Start: Interval[@2023, @2030] properly within 1 year of start Interval[@2022, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var includedIn = (In)library.statements[0].expression;
                Assert.IsFalse(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Elm.ToList));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        //[TestMethod]
        //public void Properly_Within()
        //{
        //    var library = DefaultConverter.Convert(@"
        //        library InTest version '1.0.0'

        //        define private Properly_Within: Interval[@2023, @2030] properly within 1 year of Interval[@2022, @2030]
        //    ");
        //    Assert.IsNotNull(library.statements);
        //    Assert.AreEqual(1, library.statements.Length);
        //    Assert.IsNotNull(library.statements[0].expression.localId);
        //    Assert.IsNotNull(library.statements[0].expression.locator);
        //    Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
        //    {
        //        var includedIn = (In)library.statements[0].expression;
        //        Assert.IsFalse(includedIn.precisionSpecified);
        //        Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
        //        Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
        //        Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
        //        Assert.IsNotNull(includedIn.operand);
        //        Assert.AreEqual(2, includedIn.operand.Length);
        //        Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
        //        Assert.IsInstanceOfType(includedIn.operand[1], typeof(Elm.ToList));
        //        var result = Run(includedIn);
        //        Assert.IsInstanceOfType(result, typeof(bool?));
        //        Assert.AreEqual(false, result);
        //    }
        //}
    }
}
