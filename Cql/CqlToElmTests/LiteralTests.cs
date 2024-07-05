using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]

    public class LiteralTests : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
        });
#pragma warning restore IDE0060 // Remove unused parameter
        internal static InvocationBuilder InvocationBuilder => Services.GetRequiredService<InvocationBuilder>();

        [TestMethod]
        public void String_Literal()
        {
            var library = MakeLibrary(@"
                library DecimalTest version '1.0.0'

                define private String_Literal: 'test'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}String", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}String", nts.name.Name);
                Assert.AreEqual("test", literal.value);
            }
        }

        #region Decimal

        [TestMethod]
        public void Decimal_Literal()
        {
            var library = MakeLibrary(@"
                library DecimalTest version '1.0.0'

                define private Decimal_Literal: 1.0
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.AreEqual("1.0", literal.value);
            }
        }

        [TestMethod]
        public void Decimal_Negative_Literal()
        {
            var library = MakeLibrary(@"
                library DecimalTest version '1.0.0'

                define private Decimal_Literal: -123.567
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.AreEqual("-123.567", literal.value);
            }
        }

        [TestMethod]
        public void Decimal_Errors()
        {
            MakeLibrary(@"
                    library Decimal_Errors_1 version '1.0.0'

                    define private Decimal_Literal: 0.123456789
                ", "Decimal literals cannot have a mantissa longer than 8 digits.");

            // exactly 28 digits
            MakeLibrary(@"
                    library Decimal_Errors_2 version '1.0.0'

                    define private Decimal_Literal: -12345678901234567890.12345678
                ").ShouldSucceed();

            // 29 digits
            MakeLibrary(@"
                    library Decimal_Errors_3 version '1.0.0'

                    define private Decimal_Literal: -123456789012345678901.12345678
                ", "Decimal literals cannot be longer than 28 digits.");
        }

        #endregion

        #region Integer


        [TestMethod]
        public void Integer_Literal()
        {
            var library = MakeLibrary(@"
                library IntegerTest version '1.0.0'

                define private Integer_Literal: 1
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.AreEqual("1", literal.value);
            }
        }

        [TestMethod]
        public void Integer_Negative()
        {
            var library = MakeLibrary(@"
                library IntegerTest version '1.0.0'

                define private Integer_Literal: -123456789
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.AreEqual("-123456789", literal.value);
            }
        }

        [TestMethod]
        public void Integer_Overflows()
        {
            // minimum long is -9,223,372,036,854,775,808
            MakeLibrary(@"
                    library Decimal_Errors_1 version '1.0.0'

                    define private Overflow_Literal: -9223372036854775809
                ", "Unparseable numeric literal*.");

            MakeLibrary(@"
                    library Decimal_Errors_1 version '1.0.0'

                    define private Overflow_Literal: 9223372036854775808
                ", "Unparseable numeric literal*.");
        }

        #endregion

        #region Long

        [TestMethod]
        public void Long_Literal()
        {
            // max value of an int is 2,147,483,647
            // this will be parsed as a long
            var library = MakeLibrary(@"
                library LongTest version '1.0.0'

                define private Long_Literal: 2147483648L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.AreEqual("2147483648", literal.value);
            }
        }
        [TestMethod]
        public void Long_Negative()
        {
            // max value of an int is 2,147,483,647
            // this will be parsed as a long
            var library = MakeLibrary(@"
                library LongTest version '1.0.0'

                define private Long_Literal:  -2147483649L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.AreEqual("-2147483649", literal.value);
            }
        }

        [TestMethod]

        public void Long_MinValue()
        {
            var lib = CreateLibraryForExpression("-9223372036854775808L");
            var literal = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>(false);
            literal.Should().HaveType(SystemTypes.LongType);
        }

        #endregion



        [TestMethod]
        public void Boolean_Literal()
        {
            var library = MakeLibrary(@"
                library TrueTest version '1.0.0'

                define private True_Literal: true
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.AreEqual("true", literal.value);
            }

            library = MakeLibrary(@"
                library FalseTest version '1.0.0'

                define private False_Literal: false
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Literal));
            {
                var literal = (Literal)library.statements[0].expression;
                Assert.IsNotNull(literal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", literal.resultTypeName.Name);
                Assert.IsNotNull(literal.resultTypeSpecifier);
                Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.AreEqual("false", literal.value);
            }

        }

        [TestMethod]
        public void Null_Literal()
        {
            var library = MakeLibrary(@"
                library NullTest version '1.0.0'

                define private Null_Test: null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Null));
            {
                var @null = (Null)library.statements[0].expression;
                Assert.IsNotNull(@null.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Any", @null.resultTypeName.Name);
                Assert.IsNotNull(@null.resultTypeSpecifier);
                Assert.IsInstanceOfType(@null.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@null.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Any", nts.name.Name);
            }
        }

        #region Date

        [TestMethod]
        public void Date_Literal_Day_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Date));
            {
                var date = (Date)library.statements[0].expression;
                Assert.IsNotNull(date.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", date.resultTypeName.Name);
                Assert.IsNotNull(date.resultTypeSpecifier);
                Assert.IsInstanceOfType(date.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)date.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);
                Assert.IsNotNull(date.year);
                Assert.IsInstanceOfType(date.year, typeof(Literal));
                {
                    var literal = (Literal)date.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(date.month);
                Assert.IsInstanceOfType(date.month, typeof(Literal));
                {
                    var literal = (Literal)date.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(date.day);
                Assert.IsInstanceOfType(date.day, typeof(Literal));
                {
                    var literal = (Literal)date.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
            }
        }

        [TestMethod]
        public void Date_Literal_Month_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Date));
            {
                var date = (Date)library.statements[0].expression;
                Assert.IsNotNull(date.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", date.resultTypeName.Name);
                Assert.IsNotNull(date.resultTypeSpecifier);
                Assert.IsInstanceOfType(date.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)date.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);
                Assert.IsNotNull(date.year);
                Assert.IsInstanceOfType(date.year, typeof(Literal));
                {
                    var literal = (Literal)date.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(date.month);
                Assert.IsInstanceOfType(date.month, typeof(Literal));
                {
                    var literal = (Literal)date.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNull(date.day);
            }
        }

        [TestMethod]
        public void Date_Literal_Year_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Date));
            {
                var date = (Date)library.statements[0].expression;
                Assert.IsNotNull(date.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", date.resultTypeName.Name);
                Assert.IsNotNull(date.resultTypeSpecifier);
                Assert.IsInstanceOfType(date.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)date.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);
                Assert.IsNotNull(date.year);
                Assert.IsInstanceOfType(date.year, typeof(Literal));
                {
                    var literal = (Literal)date.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNull(date.month);
                Assert.IsNull(date.day);

            }
        }

        #endregion

        #region DateTime

        [TestMethod]
        public void DateTime_Literal_Millisecond_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02T01:23:45.678+01:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.DateTime));
            {
                var dateTime = (Elm.DateTime)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(dateTime.year);
                Assert.IsInstanceOfType(dateTime.year, typeof(Literal));
                {
                    var literal = (Literal)dateTime.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(dateTime.month);
                Assert.IsInstanceOfType(dateTime.month, typeof(Literal));
                {
                    var literal = (Literal)dateTime.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(dateTime.day);
                Assert.IsInstanceOfType(dateTime.day, typeof(Literal));
                {
                    var literal = (Literal)dateTime.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.second, typeof(Literal));
                {
                    var literal = (Literal)dateTime.second;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("45", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.millisecond, typeof(Literal));
                {
                    var literal = (Literal)dateTime.millisecond;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("678", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.timezoneOffset, typeof(Literal));
                {
                    var literal = (Literal)dateTime.timezoneOffset;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", ints.name.Name);
                    Assert.AreEqual("1.5", literal.value);
                }
            }
        }

        [TestMethod]
        public void DateTime_Literal_Second_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02T01:23:45+01:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.DateTime));
            {
                var dateTime = (Elm.DateTime)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(dateTime.year);
                Assert.IsInstanceOfType(dateTime.year, typeof(Literal));
                {
                    var literal = (Literal)dateTime.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(dateTime.month);
                Assert.IsInstanceOfType(dateTime.month, typeof(Literal));
                {
                    var literal = (Literal)dateTime.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(dateTime.day);
                Assert.IsInstanceOfType(dateTime.day, typeof(Literal));
                {
                    var literal = (Literal)dateTime.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.second, typeof(Literal));
                {
                    var literal = (Literal)dateTime.second;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("45", literal.value);
                }
                Assert.IsNull(dateTime.millisecond);
                Assert.IsInstanceOfType(dateTime.timezoneOffset, typeof(Literal));
                {
                    var literal = (Literal)dateTime.timezoneOffset;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", ints.name.Name);
                    Assert.AreEqual("1.5", literal.value);
                }
            }
        }

        [TestMethod]
        public void DateTime_Literal_Minute_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02T01:23+01:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.DateTime));
            {
                var dateTime = (Elm.DateTime)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(dateTime.year);
                Assert.IsInstanceOfType(dateTime.year, typeof(Literal));
                {
                    var literal = (Literal)dateTime.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(dateTime.month);
                Assert.IsInstanceOfType(dateTime.month, typeof(Literal));
                {
                    var literal = (Literal)dateTime.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(dateTime.day);
                Assert.IsInstanceOfType(dateTime.day, typeof(Literal));
                {
                    var literal = (Literal)dateTime.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsNull(dateTime.second);
                Assert.IsNull(dateTime.millisecond);
                Assert.IsInstanceOfType(dateTime.timezoneOffset, typeof(Literal));
                {
                    var literal = (Literal)dateTime.timezoneOffset;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", ints.name.Name);
                    Assert.AreEqual("1.5", literal.value);
                }
            }
        }

        [TestMethod]
        public void DateTime_Literal_Hour_Precision()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02T01+01:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.DateTime));
            {
                var dateTime = (Elm.DateTime)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(dateTime.year);
                Assert.IsInstanceOfType(dateTime.year, typeof(Literal));
                {
                    var literal = (Literal)dateTime.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(dateTime.month);
                Assert.IsInstanceOfType(dateTime.month, typeof(Literal));
                {
                    var literal = (Literal)dateTime.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(dateTime.day);
                Assert.IsInstanceOfType(dateTime.day, typeof(Literal));
                {
                    var literal = (Literal)dateTime.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNull(dateTime.minute);
                Assert.IsNull(dateTime.second);
                Assert.IsNull(dateTime.millisecond);
                Assert.IsInstanceOfType(dateTime.timezoneOffset, typeof(Literal));
                {
                    var literal = (Literal)dateTime.timezoneOffset;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", ints.name.Name);
                    Assert.AreEqual("1.5", literal.value);
                }
            }
        }

        [TestMethod]
        public void DateTime_Literal_Hour_Precision_NoOffset()
        {
            var library = MakeLibrary(@"
                library DateTest version '1.0.0'

                define private Date_Literal: @2023-01-02T01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.DateTime));
            {
                var dateTime = (Elm.DateTime)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(dateTime.year);
                Assert.IsInstanceOfType(dateTime.year, typeof(Literal));
                {
                    var literal = (Literal)dateTime.year;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2023", literal.value);
                }
                Assert.IsNotNull(dateTime.month);
                Assert.IsInstanceOfType(dateTime.month, typeof(Literal));
                {
                    var literal = (Literal)dateTime.month;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNotNull(dateTime.day);
                Assert.IsInstanceOfType(dateTime.day, typeof(Literal));
                {
                    var literal = (Literal)dateTime.day;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("2", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNull(dateTime.minute);
                Assert.IsNull(dateTime.second);
                Assert.IsNull(dateTime.millisecond);
                Assert.IsNull(dateTime.timezoneOffset);
            }
        }

        [TestMethod]
        public void DateTime_Literal_T()
        {
            var lib = CreateLibraryForExpression("@2016T");
            var dt = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTime>();
            var yearLiteral = dt.year.Should().BeOfType<Literal>().Subject;
            yearLiteral.value.Should().Be("2016");
            dt.month.Should().BeNull();
        }

        [TestMethod]
        public void Time_Literal_Millisecond_Precision()
        {
            var library = MakeLibrary(@"
                library TimeTest version '1.0.0'

                define private Time_Literal: @T01:23:45.678
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Time));
            {
                var dateTime = (Elm.Time)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.second, typeof(Literal));
                {
                    var literal = (Literal)dateTime.second;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("45", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.millisecond, typeof(Literal));
                {
                    var literal = (Literal)dateTime.millisecond;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("678", literal.value);
                }
            }
        }

        #endregion

        #region Time

        [TestMethod]
        public void Time_Literal_Second_Precision()
        {
            var library = MakeLibrary(@"
                library TimeTest version '1.0.0'

                define private Time_Literal: @T01:23:45
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Time));
            {
                var dateTime = (Elm.Time)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.second, typeof(Literal));
                {
                    var literal = (Literal)dateTime.second;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("45", literal.value);
                }
                Assert.IsNull(dateTime.millisecond);
            }
        }

        [TestMethod]
        public void Time_Literal_Minute_Precision()
        {
            var library = MakeLibrary(@"
                library TimeTest version '1.0.0'

                define private Time_Literal: @T01:23
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Time));
            {
                var dateTime = (Elm.Time)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsInstanceOfType(dateTime.minute, typeof(Literal));
                {
                    var literal = (Literal)dateTime.minute;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("23", literal.value);
                }
                Assert.IsNull(dateTime.second);
                Assert.IsNull(dateTime.millisecond);
            }
        }

        [TestMethod]
        public void Time_Literal_Hour_Precision()
        {
            var library = MakeLibrary(@"
                library TimeTest version '1.0.0'

                define private Time_Literal: @T01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Time));
            {
                var dateTime = (Elm.Time)library.statements[0].expression;
                Assert.IsNotNull(dateTime.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", dateTime.resultTypeName.Name);
                Assert.IsNotNull(dateTime.resultTypeSpecifier);
                Assert.IsInstanceOfType(dateTime.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)dateTime.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsInstanceOfType(dateTime.hour, typeof(Literal));
                {
                    var literal = (Literal)dateTime.hour;
                    Assert.IsNotNull(literal.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", literal.resultTypeName.Name);
                    Assert.IsNotNull(literal.resultTypeSpecifier);
                    Assert.IsInstanceOfType(literal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var ints = (NamedTypeSpecifier)literal.resultTypeSpecifier;
                    Assert.IsNotNull(ints.name);
                    Assert.IsNotNull(ints.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", ints.name.Name);
                    Assert.AreEqual("1", literal.value);
                }
                Assert.IsNull(dateTime.minute);
                Assert.IsNull(dateTime.second);
                Assert.IsNull(dateTime.millisecond);
            }
        }

        #endregion

        #region Quantity

        [TestMethod]
        public void Quantity_Literal()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 6.2 'gm/cm3'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(6.2m, quantity.value);
                Assert.AreEqual("gm/cm3", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Year()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 6 year
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(6m, quantity.value);
                Assert.AreEqual("a", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Years()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 6 years
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(6m, quantity.value);
                Assert.AreEqual("a", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Month()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 1.245671213 month
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(1.245671213m, quantity.value);
                Assert.AreEqual("mo", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Months()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 1.245671213 months
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(1.245671213m, quantity.value);
                Assert.AreEqual("mo", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Day()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0 day
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0m, quantity.value);
                Assert.AreEqual("d", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Days()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0 days
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0m, quantity.value);
                Assert.AreEqual("d", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Hour()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0.0 hour
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0m, quantity.value);
                Assert.AreEqual("h", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Hours()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0.0 hours
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0m, quantity.value);
                Assert.AreEqual("h", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Minute()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0.25 minute
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0.25m, quantity.value);
                Assert.AreEqual("min", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Minutes()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 0.25 minutes
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(0.25m, quantity.value);
                Assert.AreEqual("min", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Second()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 1 second
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(1m, quantity.value);
                Assert.AreEqual("s", quantity.unit);
            }
        }


        [TestMethod]
        public void Quantity_Seconds()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 1 seconds
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(1m, quantity.value);
                Assert.AreEqual("s", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Millisecond()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 2000000 millisecond
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(2000000m, quantity.value);
                Assert.AreEqual("ms", quantity.unit);
            }
        }

        [TestMethod]
        public void Quantity_Milliseconds()
        {
            var library = MakeLibrary(@"
                library QuantityTest version '1.0.0'

                define private Quantity_Literal: 2000000 milliseconds
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Quantity));
            {
                var quantity = (Elm.Quantity)library.statements[0].expression;
                Assert.IsNotNull(quantity.localId);
                Assert.IsNotNull(quantity.locator);
                Assert.AreEqual(2000000m, quantity.value);
                Assert.AreEqual("ms", quantity.unit);
            }
        }

        #endregion

        [TestMethod]
        public void Ratio_Literal()
        {
            var library = MakeLibrary(@"
                library RatioTest version '1.0.0'

                define private Ratio_Literal:  6 'gm' : 10 'cm3'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Elm.Ratio));
            {
                var ratio = (Elm.Ratio)library.statements[0].expression;
                Assert.IsNotNull(ratio.localId);
                Assert.IsNotNull(ratio.locator);
                Assert.IsNotNull(ratio.numerator);
                Assert.AreEqual(6, ratio.numerator.value);
                Assert.AreEqual("gm", ratio.numerator.unit);
                Assert.IsNotNull(ratio.denominator);
                Assert.AreEqual(10, ratio.denominator.value);
                Assert.AreEqual("cm3", ratio.denominator.unit);
            }
        }

        [TestMethod]
        public void Ceiling_1D()
        {
            var input = CreateLibraryForExpression("Ceiling(1.0)");
            var ceiling = input.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Ceiling>();
            var output = CreateLibraryForExpression("1");
            var literal = output.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            //var context = FhirCqlContext.ForBundle();
            var equalsOverload = InvocationBuilder.MatchSignature(SystemLibrary.Equal, new Expression[] { ceiling, literal });
            equalsOverload.Compatible.Should().BeTrue();
            var invokeEquals = InvocationBuilder.Invoke(equalsOverload, null);
            invokeEquals.GetErrors().Should().BeEmpty();
            var equalsCall = Run(invokeEquals);
            Assert.AreEqual(true, equalsCall);
        }
    }
}
