using FluentAssertions;
using Hl7.Cql.Tools.BuildTasks;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsTest
{
    [TestClass]
    public class CqlToElmTest
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Mock<IBuildEngine9> buildEngine;
        private List<BuildErrorEventArgs> errors;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        [TestInitialize]
        public void Startup()
        {
            buildEngine = new Mock<IBuildEngine9>();

            errors = new List<BuildErrorEventArgs>();
            buildEngine.Setup(x => x.LogErrorEvent(It.IsAny<BuildErrorEventArgs>()))
                .Callback<BuildErrorEventArgs>(e => errors.Add(e));
            var props = new Dictionary<string, string>
            {
                {  "OutputPath", Environment.CurrentDirectory },
            };
            buildEngine.Setup(x => x.GetGlobalProperties()).Returns(props);
        }

        [TestMethod]
        public void FHIRHelpers_No_Errors()
        {
            var cqlToElm = new CqlToElm();
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")];
            cqlToElm.Execute().Should().BeTrue();
            cqlToElm.ELM.Should().NotBeEmpty();
            errors.Should().BeEmpty();

        }

        [TestMethod]
        public void Could_Not_Resolve()
        {
            var cqlToElm = new CqlToElm();
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\Errors-1.0.0.cql")];
            cqlToElm.Execute().Should().BeFalse();
            cqlToElm.ELM.Should().NotBeEmpty();
            errors.Should().NotBeEmpty();
            errors.Should().HaveCount(1);
            errors[0].Message.Should().Be("Could not resolve call to operator Add with signature (Integer, String).");
        }

        [TestMethod]
        public void Two_Files()
        {
            var cqlToElm = new CqlToElm();
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.Sources = [
                new TaskItem(@"Input\Cql\UsesFHIRHelpers-1.0.0.cql"),
                new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")
            ];
            cqlToElm.Execute().Should().BeTrue();
            errors.Should().BeEmpty();
            cqlToElm.ELM.Should().NotBeEmpty();
            cqlToElm.ELM.Should().HaveCount(2);
        }


        [TestMethod]
        public void Only_One_File_Specified()
        {
            var cqlToElm = new CqlToElm();
            cqlToElm.BuildEngine = buildEngine.Object;
            // because FHIRHelpers is not a compilation source, this should not succeed.
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\UsesFHIRHelpers-1.0.0.cql")];
            cqlToElm.Execute().Should().BeFalse();
            errors.Should().HaveCount(1);
            errors[0].Message.Should().Be("Unable to resolve library: FHIRHelpers version '4.0.1'. Are you sure this library version exists and that you have access?");
        }

        [TestMethod]

        public void Deps()
        {
            string jsonContent = File.ReadAllText(@"Input\deps.json");

            // Parse JSON content
            JObject json = JObject.Parse(jsonContent);

            var libraries = json["libraries"];
            if (libraries != null)
            {
                foreach (var library in libraries.Children<JProperty>())
                {
                    string packageName = library.Name;
                    string version = packageName.Substring(packageName.IndexOf('/') + 1);
                    packageName = packageName.Substring(0, packageName.IndexOf('/'));
                    System.Diagnostics.Debug.WriteLine($"<PackageReference Include=\"{packageName}\" Version=\"{version}\" IncludeAssets=\"all\" />");
                }
            }
        }

    }
}
