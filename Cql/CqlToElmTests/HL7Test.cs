using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class HL7Test: Base
    {

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [DynamicData(nameof(LoadCqlFiles), DynamicDataSourceType.Method,
          DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void ExecuteExpression(FileInfo cqlFile, Library library, ExpressionDef expression)
        {
        }

        public static string DisplayName(MethodInfo method, object[] data)
        {
            var library = (Library)data[1];
            var statement = (ExpressionDef)data[2];
            return $"{library.NameAndVersion}: {statement.name}";
        }

        public static IEnumerable<object[]> LoadCqlFiles()
        {
            var directory = new DirectoryInfo(@"Input\HL7");
            var cqlFiles = directory.GetFiles("*.cql");
            foreach(var file in cqlFiles)
            {
                using(var scope = Services.CreateScope())
                {
                    using var stream = file.OpenRead();
                    var library = DefaultConverter.ConvertLibrary(stream);
                    var errors = library.GetErrors();
                    Assert.AreEqual(0, errors.Length, errors[0].message);
                    foreach (var statement in library.statements)
                    {
                        yield return new object[] { file, library, statement };
                    }
                }
            }

        }
    }
}
