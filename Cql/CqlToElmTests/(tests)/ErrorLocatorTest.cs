/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    using DateTime = Hl7.Cql.Elm.DateTime;

    /// <summary>
    /// Locators follow the reference translator: 1-based characters, a span running from the first character of
    /// the first token through the last character of the last token, and <c>line:char</c> for a single character.
    /// </summary>
    [TestClass]
    public class ErrorLocatorTest : Base
    {
        [TestMethod]
        public void Errors_Carry_The_Position_Of_The_Expression_They_Are_Reported_On()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ErrorLocatorTest version '1.0.0'

                using Unknown version '1.0.0'

                define "Unresolved Identifier": NoSuchThing + 1

                define "Unresolved Overload": Length(1, 2)

                define "Case Mismatch":
                  case 1
                    when 'a' then 1
                    else 2
                  end

                define "Unresolved Source": NoSuchDefine E return E

                define "Duplicate": 1

                define "Duplicate": 2
                """,
                "Identifier Duplicate is already in use in this library.",
                "Model Unknown version 1.0.0 is not available.",
                "Could not resolve identifier NoSuchThing in the current library.",
                "Could not resolve call to operator Length with signature (Integer, Integer).",
                // Left loose: this message currently names the expected and found types the wrong way round and ends
                // in a stray quote; the test is about its position, not its text.
                "Expected an expression of type *",
                "Could not resolve identifier NoSuchDefine in the current library.");

            var errors = library.GetErrors();
            errors.Should().AllSatisfy(e =>
            {
                e.startLineSpecified.Should().BeTrue();
                e.startCharSpecified.Should().BeTrue();
                e.endLineSpecified.Should().BeTrue();
                e.endCharSpecified.Should().BeTrue();
            });

            ShouldBeAt(errors, "Model Unknown*", 3, 1, 3, 29);
            ShouldBeAt(errors, "*NoSuchThing*", 5, 33, 5, 43);
            ShouldBeAt(errors, "*operator Length*", 7, 31, 7, 42);
            ShouldBeAt(errors, "Expected an expression*", 11, 5, 11, 19);
            ShouldBeAt(errors, "*NoSuchDefine*", 15, 29, 15, 40);
            ShouldBeAt(errors, "*Duplicate*", 19, 1, 19, 21);
        }

        [TestMethod]
        public void Expression_Locators_Span_From_The_First_Through_The_Last_Character()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ExpressionLocatorTest version '1.0.0'

                define "Sum": 1 + 22
                """);

            var add = library.statements[0].expression.Should().BeOfType<Add>().Subject;
            add.locator.Should().Be("3:15-3:20");
            add.operand[0].locator.Should().Be("3:15");
            add.operand[1].locator.Should().Be("3:19-3:20");
        }

        [TestMethod]
        public void Literal_Component_Locators_Are_The_Exact_Token_Span()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library LiteralLocatorTest version '1.0.0'

                define "Date": @2013-01-02
                define "DateTime": @2013-01-02T12:30:45.123+01:00
                define "Time": @T12:30:45.1
                define "Hour With Zone": @2013-01-02T12Z
                """);

            var date = library.ShouldDefine<ExpressionDef>("Date").expression.Should().BeOfType<Date>().Subject;
            date.locator.Should().Be("3:16-3:26");
            date.year.locator.Should().Be("3:17-3:20");
            date.month.locator.Should().Be("3:22-3:23");
            date.day.locator.Should().Be("3:25-3:26");

            var dateTime = library.ShouldDefine<ExpressionDef>("DateTime").expression.Should().BeOfType<DateTime>().Subject;
            dateTime.locator.Should().Be("4:20-4:49");
            dateTime.year.locator.Should().Be("4:21-4:24");
            dateTime.month.locator.Should().Be("4:26-4:27");
            dateTime.day.locator.Should().Be("4:29-4:30");
            dateTime.hour.locator.Should().Be("4:32-4:33");
            dateTime.minute.locator.Should().Be("4:35-4:36");
            dateTime.second.locator.Should().Be("4:38-4:39");
            dateTime.millisecond.locator.Should().Be("4:41-4:43");
            dateTime.timezoneOffset.locator.Should().Be("4:44-4:49");

            var time = library.ShouldDefine<ExpressionDef>("Time").expression.Should().BeOfType<Time>().Subject;
            time.locator.Should().Be("5:16-5:27");
            time.hour.locator.Should().Be("5:18-5:19");
            time.minute.locator.Should().Be("5:21-5:22");
            time.second.locator.Should().Be("5:24-5:25");
            time.millisecond.locator.Should().Be("5:27");

            var withZone = library.ShouldDefine<ExpressionDef>("Hour With Zone").expression.Should().BeOfType<DateTime>().Subject;
            withZone.locator.Should().Be("6:26-6:40");
            withZone.hour.locator.Should().Be("6:38-6:39");
            withZone.timezoneOffset.locator.Should().Be("6:40");
        }

        [TestMethod]
        [DataRow("\n", DisplayName = "LF")]
        [DataRow("\r\n", DisplayName = "CRLF")]
        public void Locators_Of_Tokens_Spanning_Lines_End_On_The_Last_Line_Of_The_Token(string newline)
        {
            var library = CreateCqlToolkit().MakeLibrary(string.Join(newline,
                "library MultilineLocatorTest version '1.0.0'",
                "",
                "define \"Multiline String\": 'first",
                "second'",
                "define \"Split",
                "Name\": 1",
                "define \"Reference\": \"Split",
                "Name\""));

            var literal = library.ShouldDefine<ExpressionDef>("Multiline String").expression.Should().BeOfType<Literal>().Subject;
            literal.locator.Should().Be("3:28-4:7");

            var reference = library.ShouldDefine<ExpressionDef>("Reference").expression.Should().BeOfType<ExpressionRef>().Subject;
            reference.locator.Should().Be("7:21-8:5");
        }

        [TestMethod]
        public void An_Error_Takes_The_Locator_Of_Its_Node_Whichever_Is_Set_First()
        {
            var located = new Null().WithLocator("2:3-4:5").AddError("located first");
            var error = located.GetErrors().Should().ContainSingle().Subject;
            (error.startLine, error.startChar, error.endLine, error.endChar).Should().Be((2, 3, 4, 5));

            var errored = new Null().AddError("errored first");
            errored.GetErrors().Should().ContainSingle().Which.startLineSpecified.Should().BeFalse();
            errored.WithLocator("7:8");
            error = errored.GetErrors().Should().ContainSingle().Subject;
            (error.startLine, error.startChar, error.endLine, error.endChar).Should().Be((7, 8, 7, 8));
        }

        private static void ShouldBeAt(CqlToElmError[] errors, string messagePattern,
            int startLine, int startChar, int endLine, int endChar)
        {
            var error = errors.Should().ContainSingle(e => System.IO.Enumeration.FileSystemName.MatchesSimpleExpression(messagePattern, e.message, false))
                              .Subject;
            (error.startLine, error.startChar, error.endLine, error.endChar)
                .Should().Be((startLine, startChar, endLine, endChar), because: error.message);
        }
    }
}
