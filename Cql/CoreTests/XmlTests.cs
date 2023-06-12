using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreTests
{
    [TestClass]
    public class XmlTests
    {
        [DynamicData(nameof(LoadXmlTests), DynamicDataSourceType.Method, 
            DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void RunXml(TestSchema.Group group, TestSchema.Test test)
        {

        }

        public static string DisplayName(MethodInfo method, object[] data)
        {
            var group = data[0] as TestSchema.Group;
            var test = data[1] as TestSchema.Test;
            return $"{group.name}: {test.name}";
        }
        public static IEnumerable<object[]> LoadXmlTests()
        {
            var xmlDir = new DirectoryInfo("Input\\Xml");
            var files = xmlDir.GetFiles("*.xml", SearchOption.TopDirectoryOnly);
            var serializer = new XmlSerializer(typeof(TestSchema.Tests));
            foreach(var file in files)
            {
                using var stream = file.OpenRead();
                var tests = (TestSchema.Tests)serializer.Deserialize(stream);
                foreach(var group in tests.group ?? Enumerable.Empty<TestSchema.Group>())
                {
                    foreach(var test in group.test ?? Enumerable.Empty<TestSchema.Test>())
                    {
                        yield return new object[] { group, test };
                    }
                }
            }
        }
    }
}
