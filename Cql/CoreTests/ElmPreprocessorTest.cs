using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    [TestClass]
    public class ElmPreprocessorTest
    {
        private Library FHIRHelpers() =>
            Library.LoadFromJson(new FileInfo(@"..\..\..\..\..\LibrarySets\Demo\Elm\FHIRHelpers.json"));

        [TestMethod]
        public void MATGlobal_Add_ResultTypeSpecifier()
        {
            var file = new FileInfo(@"..\..\..\..\..\LibrarySets\Demo\Elm\MATGlobalCommonFunctionsFHIR4.json");
            file.Exists.Should().BeTrue();

            var lib = Library.LoadFromJson(file);
            var rtsChecker = new ResultTypeSpecifierChecker();
            rtsChecker.Start(lib);
            // there are nodes missing resultTypeSpecifiers.
            rtsChecker.Nodes.Should().NotBeEmpty();

            var ls = new LibrarySet("", FHIRHelpers(), lib);
            var pp = new ElmPreprocessor(ls);
            pp.Preprocess(lib);
            rtsChecker = new ResultTypeSpecifierChecker();
            rtsChecker.Start(lib);
            // after pre-processing the library, there should be no such nodes remaining.
            rtsChecker.Nodes.Should().BeEmpty();
        }

    }

    class ResultTypeSpecifierChecker : BaseElmTreeWalker
    {
        internal List<object> Nodes = new();

        protected override bool Process(object node)
        {
            if (node switch
            {
                FunctionRef fr => fr.resultTypeSpecifier is null,
                ExpressionRef er => er.resultTypeSpecifier is null,
                _ => false
            })
            {
                Nodes.Add(node);
            }
            return false;
        }

    }
}