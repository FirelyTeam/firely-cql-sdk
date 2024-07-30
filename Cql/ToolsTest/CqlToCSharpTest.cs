using FluentAssertions;
using Hl7.Cql.Tools.BuildTasks;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsTest
{
    [TestClass]
    public class CqlToCSharpTest
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
            var cqlToCs = new CqlToCSharp();
            cqlToCs.BuildEngine = buildEngine.Object;
            cqlToCs.Sources = [new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")];
            cqlToCs.Execute().Should().BeTrue();
            cqlToCs.CSharp.Should().NotBeEmpty();
            errors.Should().BeEmpty();

        }



    }
}
