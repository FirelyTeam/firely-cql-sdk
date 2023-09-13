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
    public class RetrieveTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        // WIP
        //[TestMethod]
        //public void Retrieve_AllTerms()
        //{
        //    var library = DefaultConverter.ConvertLibrary(@"
        //        library RetrieveTest version '1.0.0'

        //        using FHIR version '4.0.1'

        //        valueset ""terminology"": 'http://ncqa.org'

        //        context Patient

        //        define private Retrieve_AllTerms: [Patient->Condition: code in ""terminology""]
        //    ");
        //    Assert.IsNotNull(library.statements);
        //    Assert.AreEqual(1, library.statements.Length);
        //    Assert.IsNotNull(library.statements[0].expression.localId);
        //    Assert.IsNotNull(library.statements[0].expression.locator);
        //    Assert.IsInstanceOfType(library.statements[0].expression, typeof(Retrieve));
        //}

    }
}
