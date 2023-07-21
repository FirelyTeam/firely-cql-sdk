using Hl7.Cql.Iso8601;
using Hl7.Cql.Model;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CoreTests
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void Model_FhirR4()
        {
            _ = Models.Fhir401;
        }


        [TestMethod]
        public void Age()
        {
            var dataRetriever = new UnitTestDataRetriever(new[] {
                new UnitTestPatient {
                    birthDate = new DateIso8601(1983, 4, 4)
                }
            });

            var ctx = new CqlContext(CqlOperators.Create(new UnitTestTypeResolver(),
                dataRetriever: dataRetriever,
                now: new DateTimeIso8601(2023, 3, 28, null, null, null, null, null, null)));
            var age = ctx.Operators.Age("a");
            Assert.AreEqual(age, 39);
        }

        [TestMethod]
        public void AgeAt()
        {
            var dataRetriever = new UnitTestDataRetriever(new[] {
                new UnitTestPatient {
                    birthDate = new DateIso8601(1983, 4, 4)
                }
            });
            var ctx = new CqlContext(CqlOperators.Create(new UnitTestTypeResolver(),
                dataRetriever: dataRetriever,
                now: new DateTimeIso8601(2023, 3, 28, null, null, null, null, null, null)));
            var age = ctx.Operators.AgeAt(new CqlDate(2013, 3, 28), "a");
            Assert.AreEqual(age, 29);
        }

        private class UnitTestPatient
        {
            public DateIso8601 birthDate { get; set; }
        }

        private class UnitTestDataRetriever : IDataRetriever
        {
            public UnitTestDataRetriever(IEnumerable<object> data)
            {
                Data = data?.ToList() ?? new List<object>();
            }

            public IList<object> Data { get; }

            public IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode> codes = null) where T : class =>
                Data.OfType<T>();

            public IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet valueSet = null) where T : class =>
                Data.OfType<T>();
        }

        private class UnitTestTypeResolver : BaseTypeResolver
        {
            public override Type PatientType => typeof(UnitTestPatient);

            public override PropertyInfo PatientBirthDateProperty => typeof(UnitTestPatient).GetProperty(nameof(UnitTestPatient.birthDate));

            public override IEnumerable<Assembly> ModelAssemblies => throw new NotImplementedException();

            public override IEnumerable<string> ModelNamespaces => throw new NotImplementedException();
        }
    }
}
