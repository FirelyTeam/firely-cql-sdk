using FluentAssertions;
using Hl7.Cql.Tools.BuildTasks;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;

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
            var cqlToElm = new CqlToCSharp() { Force = true };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")];
            cqlToElm.Execute().Should().BeTrue();
            cqlToElm.Elm.Should().NotBeEmpty();
            cqlToElm.CSharp.Should().NotBeEmpty();
            errors.Should().BeEmpty();
        }


        [TestMethod]
        public void Empty_File()
        {
            var cqlToElm = new CqlToCSharp() { Force = true };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\Empty-1.0.0.cql")];
            cqlToElm.Execute().Should().BeTrue();
            cqlToElm.Elm.Should().BeEmpty();
            cqlToElm.CSharp.Should().BeEmpty();
            errors.Should().BeEmpty();
        }

        [TestMethod]
        public void Could_Not_Resolve()
        {
            var cqlToElm = new CqlToCSharp() { Force = true };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\Errors-1.0.0.cql")];
            cqlToElm.Execute().Should().BeFalse();
            cqlToElm.Elm.Should().NotBeEmpty();
            errors.Should().NotBeEmpty();
            errors.Should().HaveCount(1);
            errors[0].Message.Should().Be("Could not resolve call to operator Add with signature (Integer, String).");
        }

        [TestMethod]
        public void Two_Files()
        {
            var cqlToElm = new CqlToCSharp() { Force = true };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            cqlToElm.Sources = [
                new TaskItem(@"Input\Cql\UsesFHIRHelpers-1.0.0.cql"),
                new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")
            ];
            cqlToElm.Execute().Should().BeTrue();
            errors.Should().BeEmpty();
            cqlToElm.Elm.Should().NotBeEmpty();
            cqlToElm.Elm.Should().HaveCount(2);
        }


        [TestMethod]
        public void Only_One_File_Specified()
        {
            var cqlToElm = new CqlToCSharp() { Force = true };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            // because FHIRHelpers is not a compilation source, this should not succeed.
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\UsesFHIRHelpers-1.0.0.cql")];
            cqlToElm.Execute().Should().BeFalse();
            errors.Should().HaveCount(1);
            errors[0].Message.Should().Be("Unable to resolve library: FHIRHelpers version '4.0.1'. Are you sure this library version exists and that you have access?");
        }


        [TestMethod]
        public void FHIRHelpers_Namespace()
        {
            var cqlToElm = new CqlToCSharp() { Force = true, Namespace = "UnitTest" };
            cqlToElm.BuildEngine = buildEngine.Object;
            cqlToElm.ElmPath = Environment.CurrentDirectory;
            cqlToElm.Sources = [new TaskItem(@"Input\Cql\FHIRHelpers-4.0.1.cql")];
            cqlToElm.Execute().Should().BeTrue();
            cqlToElm.Elm.Should().NotBeEmpty();
            cqlToElm.CSharp.Should().NotBeEmpty();
            errors.Should().BeEmpty();

        }
    }
}
