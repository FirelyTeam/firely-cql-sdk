/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;
using System.Reflection;

namespace CoreTests
{
    [TestClass]
    public class LibraryPreprocessorTest
    {
        private static DirectoryInfo ElmDir => LibrarySetsDirs.Demo.ElmDir;

        private Library FHIRHelpers() =>
            Library.LoadFromJson(new FileInfo(Path.Combine(ElmDir.FullName, "FHIRHelpers.json")));

        [TestMethod]
        public void MATGlobal_Add_ResultTypeSpecifier()
        {
            var file = new FileInfo(Path.Combine(ElmDir.FullName, "MATGlobalCommonFunctionsFHIR4.json"));
            file.Exists.Should().BeTrue();

            var lib = Library.LoadFromJson(file);
            var rtsChecker = new ResultTypeSpecifierChecker();
            rtsChecker.Start(lib);
            // there are nodes missing resultTypeSpecifiers.
            rtsChecker.Nodes.Should().NotBeEmpty();

            var ls = new LibrarySet("", FHIRHelpers(), lib);
            var pp = new LibraryPreprocessor(ls, NullLoggerFactory.Instance);
            pp.PreprocessLibrary(lib);
            rtsChecker = new ResultTypeSpecifierChecker();
            rtsChecker.Start(lib);
            // after pre-processing the library, there should be no such nodes remaining.
            rtsChecker.Nodes.Should().BeEmpty();
        }

        [TestMethod]
        public void LegacyPowerIntegerResultType_IsNormalizedToDecimal()
        {
            var power = new Power
            {
                locator = "1:1-1:16",
                operand =
                [
                    new Literal
                    {
                        value = "10",
                        valueType = SystemTypes.IntegerType.name,
                        resultTypeSpecifier = SystemTypes.IntegerType,
                        resultTypeName = SystemTypes.IntegerType.name
                    },
                    new Literal
                    {
                        value = "2",
                        valueType = SystemTypes.IntegerType.name,
                        resultTypeSpecifier = SystemTypes.IntegerType,
                        resultTypeName = SystemTypes.IntegerType.name
                    }
                ],
                resultTypeSpecifier = SystemTypes.IntegerType,
                resultTypeName = SystemTypes.IntegerType.name
            };

            var lib = new Library
            {
                identifier = new VersionedIdentifier { id = "LegacyPowerTest", version = "1.0.0" },
                schemaIdentifier = new VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                statements =
                [
                    new ExpressionDef
                    {
                        name = "PowExpr",
                        context = "Patient",
                        expression = power,
                        resultTypeSpecifier = SystemTypes.IntegerType,
                        resultTypeName = SystemTypes.IntegerType.name
                    }
                ]
            };

            var ls = new LibrarySet("", lib);
            var pp = new LibraryPreprocessor(ls, NullLoggerFactory.Instance);
            pp.PreprocessLibrary(lib);

            power.resultTypeSpecifier.Should().BeEquivalentTo(SystemTypes.DecimalType);
            power.resultTypeName.Should().Be(SystemTypes.DecimalType.name);
        }

        [TestMethod]
        public void ImplicitListQuery_ReturnClause_GetsListElementType()
        {
            // The Java translator types the Query it synthesizes for list traversal over a property
            // (source alias `$this`, `return all ...`) as a list, but leaves its ReturnClause untyped.
            var lib = Library.LoadFromJson(new FileInfo(Path.Combine(ElmDir.FullName, "ColorectalCancerScreeningsFHIR.json")));
            var queries = new List<Query>();
            new ElmTreeWalker(node =>
            {
                if (node is Query { resultTypeSpecifier: ListTypeSpecifier, @return.resultTypeSpecifier: null } query)
                    queries.Add(query);
                return false;
            }).Start(lib);
            queries.Should().NotBeEmpty();

            new MissingResultTypeSpecifierCorrector(NullLogger<MissingResultTypeSpecifierCorrector>.Instance).Fix(lib);

            queries.Should().AllSatisfy(query =>
                query.@return.resultTypeSpecifier.Should().BeSameAs(((ListTypeSpecifier)query.resultTypeSpecifier).elementType));
        }

        [TestMethod]
        public void ImplicitMultiSourceTupleReturn_TupleAndElements_GetTypes()
        {
            // For a multi-source query without a return clause, the Java translator synthesizes
            // `return Tuple { alias: alias, ... }` and leaves both the Tuple and its element values untyped.
            var lib = LoadDqm("CMS951FHIRKidneyHealthEval");
            var tuples = new List<(Hl7.Cql.Elm.Tuple tuple, TupleTypeSpecifier type)>();
            new ElmTreeWalker(node =>
            {
                if (node is Query { resultTypeSpecifier: ListTypeSpecifier { elementType: TupleTypeSpecifier type }, @return.expression: Hl7.Cql.Elm.Tuple { resultTypeSpecifier: null } tuple }
                    && tuple.element.All(e => e.value.resultTypeSpecifier is null))
                    tuples.Add((tuple, type));
                return false;
            }).Start(lib);
            tuples.Should().NotBeEmpty();

            new MissingResultTypeSpecifierCorrector(NullLogger<MissingResultTypeSpecifierCorrector>.Instance).Fix(lib);

            tuples.Should().AllSatisfy(t =>
            {
                t.tuple.resultTypeSpecifier.Should().BeSameAs(t.type);
                t.tuple.element.Select(e => e.value.resultTypeSpecifier)
                    .Should().Equal(t.type.element.Select(e => e.elementType));
            });
        }

        [TestMethod]
        public void CallToNonOverloadedFunction_GetsSignature()
        {
            // With its default signature level, the Java translator emits an empty signature on calls to a
            // function that has no overloads, such as most FHIRHelpers 4.4 conversions.
            var fhirHelpers = LoadDqm("FHIRHelpers");
            var lib = LoadDqm("QICoreCommon");
            var refs = new List<FunctionRef>();
            new ElmTreeWalker(node =>
            {
                if (node is FunctionRef { libraryName: "FHIRHelpers", signature: null, operand.Length: > 0 } functionRef)
                    refs.Add(functionRef);
                return false;
            }).Start(lib);
            refs.Should().NotBeEmpty();

            var ls = new LibrarySet("", fhirHelpers, lib);
            new ExpressionRefCorrector(NullLogger<ExpressionRefCorrector>.Instance, ls).Fix(lib);

            refs.Should().AllSatisfy(r => r.signature.Should().HaveSameCount(r.operand));
        }

        [TestMethod]
        public void ProfiledBoundElementValue_IsTypedAsString()
        {
            // Through QICore, the Java translator gives `periodUnit.value` the type of the binding (UnitsOfTime)
            // and leaves `periodUnit` itself untyped; through plain FHIR it types them String and UnitsOfTime.
            var lib = LoadDqm("CumulativeMedicationDuration");
            var props = new List<Property>();
            new ElmTreeWalker(node =>
            {
                if (node is Property { path: "value", source: Property { path: "periodUnit" } } valueProp)
                    props.Add(valueProp);
                return false;
            }).Start(lib);
            props.Should().NotBeEmpty();
            props.Should().AllSatisfy(p => p.resultTypeName.Name.Should().Be("{http://hl7.org/fhir}UnitsOfTime"));

            new ProfiledValueSetPropertyCorrector(NullLogger<ProfiledValueSetPropertyCorrector>.Instance).Fix(lib);

            props.Should().AllSatisfy(p =>
            {
                p.resultTypeName.Should().Be(SystemTypes.StringType.name);
                ((Property)p.source).resultTypeName.Name.Should().Be("{http://hl7.org/fhir}UnitsOfTime");
            });
        }

        private static Library LoadDqm(string name) =>
            Library.LoadFromJson(new FileInfo(Path.Combine(LibrarySetsDirs.DqmQiCore2025.ElmDir.FullName, name + ".json")));

        // CqlOperatorsBinder's Coalesce coverage now lives in CqlOperatorsBinderTests.cs.
        // TestTypeResolver stays here because those tests still use it from the same project.
    }

    internal class TestTypeResolver : BaseTypeResolver
    {
        internal override PatientTypeInfo CreatePatientTypeInfo() =>
            new PatientTypeInfo(
                resolveType: () => typeof(object),
                resolveBirthDateGetter: _ => null);

        internal override IEnumerable<Assembly> ModelAssemblies => [];

        internal override IEnumerable<string> ModelNamespaces => [];

        internal override PropertyInfo GetPrimaryCodePath(string typeSpecifier) => throw new NotImplementedException();

        internal override bool ShouldUseSourceObject(Type type, string propertyName) => false;
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
