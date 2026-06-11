/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;
using System.Linq.Expressions;
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
        public void CoalesceOnNullableValueTupleList_UsesValueTypeOverload()
        {
            var binder = new CqlOperatorsBinder(
                NullLogger<CqlOperatorsBinder>.Instance,
                new TestTypeResolver(),
                Hl7.Cql.Conversion.TypeConverter.Create());

            var operand = System.Linq.Expressions.Expression.Constant(new (int? isHighRisk, int? isInconclusive, DateOnly? eventDate)?[]
            {
                ((int?)1, null, new DateOnly(2026, 6, 11)),
                null
            });

            var call = (MethodCallExpression)binder.BindToMethod(nameof(ICqlOperators.Coalesce), [operand], []);

            call.Method.Name.Should().Be(nameof(ICqlOperators.CoalesceValueTypes));
            call.Method.GetGenericArguments().Single().Should().Be(typeof((int?, int?, DateOnly?)));
        }

    }

    internal class TestTypeResolver : BaseTypeResolver
    {
        internal override Type PatientType => typeof(object);

        internal override PropertyInfo? PatientBirthDateProperty => null;

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
