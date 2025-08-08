/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Iso8601;
using Hl7.Cql.Model;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

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
            var dataSource = new UnitTestDataSource([
                new UnitTestPatient {
                    birthDate = new DateIso8601(1983, 4, 4)
                }
            ]);

            var ctx = new CqlContext(CqlOperators.Create(new UnitTestTypeResolver(),
                dataSource: dataSource,
                now: new DateTimeIso8601(2023, 3, 28, null, null, null, null, null, null)));
            var age = ctx.Operators.Age("a");
            Assert.AreEqual(age, 39);
        }

        [TestMethod]
        public void AgeAt()
        {
            var dataSource = new UnitTestDataSource([
                new UnitTestPatient {
                    birthDate = new DateIso8601(1983, 4, 4)
                }
            ]);
            var ctx = new CqlContext(CqlOperators.Create(new UnitTestTypeResolver(),
                dataSource: dataSource,
                now: new DateTimeIso8601(2023, 3, 28, null, null, null, null, null, null)));
            var age = ctx.Operators.AgeAt(new CqlDate(2013, 3, 28), "a");
            Assert.AreEqual(age, 29);
        }

        private class UnitTestPatient
        {
            public DateIso8601 birthDate { get; set; }
        }

        private class UnitTestDataSource(IEnumerable<object> data) : IDataSource
        {
            public IList<object> Data { get; } = data?.ToList() ?? [];

#if VNEXT
            public event EventHandler DataChanged;
#endif

            public IEnumerable<T> Retrieve<T>(RetrieveParameters _) where T : class =>
                Data.OfType<T>();

        }

        private class UnitTestTypeResolver : BaseTypeResolver
        {
            internal override Type PatientType => typeof(UnitTestPatient);

            internal override PropertyInfo PatientBirthDateProperty => typeof(UnitTestPatient).GetProperty(nameof(UnitTestPatient.birthDate));

            internal override IEnumerable<Assembly> ModelAssemblies => throw new NotImplementedException();

            internal override IEnumerable<string> ModelNamespaces => throw new NotImplementedException();

            internal override PropertyInfo GetPrimaryCodePath(string typeSpecifier) => throw new NotImplementedException();

            internal override bool ShouldUseSourceObject(Type type, string propertyName) => true;
        }
    }
}
