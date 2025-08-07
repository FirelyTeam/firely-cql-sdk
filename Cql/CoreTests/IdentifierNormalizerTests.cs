/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;

namespace CoreTests;

[TestClass]
public class IdentifierNormalizerTests
{
    [TestMethod]
    public void Normalize_BasicIdentifiers_ReturnsUnchanged()
    {
        // Arrange & Act & Assert
        IdentifierNormalizer.Normalize("validIdentifier").Should().Be("validIdentifier");
        IdentifierNormalizer.Normalize("ValidIdentifier").Should().Be("ValidIdentifier");
        IdentifierNormalizer.Normalize("identifier123").Should().Be("identifier123");
        IdentifierNormalizer.Normalize("_underscore").Should().Be("_underscore");
    }

    [TestMethod]
    public void Normalize_EmptyOrNull_ReturnsUnderscore()
    {
        // Arrange & Act & Assert
        IdentifierNormalizer.Normalize("").Should().Be("_");
        IdentifierNormalizer.Normalize(null).Should().Be("_");
    }

    [TestMethod]
    public void Normalize_SpecialCharacters_ReplacedCorrectly()
    {
        // Test cases based on old ExpressionBuilderContext.NormalizeIdentifier behavior
        IdentifierNormalizer.Normalize("param with spaces").Should().Be("param_with_spaces");
        IdentifierNormalizer.Normalize("param.with.dots").Should().Be("param_with_dots");
        IdentifierNormalizer.Normalize("param,with,commas").Should().Be("param_with_commas");
        IdentifierNormalizer.Normalize("param[with]brackets").Should().Be("param_with_brackets");
        IdentifierNormalizer.Normalize("param(with)parens").Should().Be("param_with_parens");
        IdentifierNormalizer.Normalize("param:with:colons").Should().Be("param_with_colons");
        IdentifierNormalizer.Normalize("param/with/slashes").Should().Be("param_with_slashes");
        IdentifierNormalizer.Normalize("param;with;semicolons").Should().Be("param_with_semicolons");
    }

    [TestMethod]
    public void Normalize_PlusAndMinus_ReplacedWithWords()
    {
        // This is the key test case that the user is concerned about
        // Based on old ExpressionBuilderContext.NormalizeIdentifier:
        // identifier.Replace("+", "plus");
        // identifier.Replace("-", "minus"); // Note: this had a bug with double dash replacement
        IdentifierNormalizer.Normalize("param+test").Should().Be("paramplustest");
        IdentifierNormalizer.Normalize("param-test").Should().Be("paramminustest");
        IdentifierNormalizer.Normalize("add+subtract-multiply").Should().Be("addplussubtractminusmultiply");
    }

    [TestMethod]
    public void Normalize_Quotes_Removed()
    {
        // Based on old behavior:
        // identifier.Replace("\"", "");
        // identifier.Replace("'", "");
        IdentifierNormalizer.Normalize("\"quoted param\"").Should().Be("quoted_param");
        IdentifierNormalizer.Normalize("'single quoted'").Should().Be("single_quoted");
        IdentifierNormalizer.Normalize("param\"with\"quotes").Should().Be("paramwithquotes");
    }

    [TestMethod]
    public void Normalize_Ampersand_ReplacedWithAnd()
    {
        // Based on old behavior:
        // identifier.Replace("&", "and");
        IdentifierNormalizer.Normalize("param&test").Should().Be("paramandtest");
        IdentifierNormalizer.Normalize("this&that").Should().Be("thisandthat");
    }

    [TestMethod]
    public void Normalize_DollarPrefix_Removed()
    {
        // Based on old behavior:
        // if (identifier.StartsWith("$")) identifier = identifier.Substring(1);
        IdentifierNormalizer.Normalize("$identifier").Should().Be("identifier");
        IdentifierNormalizer.Normalize("$param_with_spaces").Should().Be("param_with_spaces");
    }

    [TestMethod]
    public void Normalize_StartsWithDigit_PrefixedWithUnderscore()
    {
        // Based on old behavior:
        // if (char.IsDigit(identifier[0])) identifier = "_" + identifier;
        IdentifierNormalizer.Normalize("123param").Should().Be("_123param");
        IdentifierNormalizer.Normalize("5test").Should().Be("_5test");
    }

    [TestMethod]
    public void Normalize_Keywords_PrefixedWithAt()
    {
        // Based on old behavior:
        // var keyword = SyntaxFacts.GetKeywordKind(identifier);
        // if (keyword != SyntaxKind.None) { identifier = $"@{identifier}"; }
        IdentifierNormalizer.Normalize("int").Should().Be("@int");
        IdentifierNormalizer.Normalize("string").Should().Be("@string");
        IdentifierNormalizer.Normalize("class").Should().Be("@class");
        IdentifierNormalizer.Normalize("ref").Should().Be("@ref");
    }

    [TestMethod]
    public void Normalize_ComplexExamples_MatchOldBehavior()
    {
        // Complex test cases combining multiple transformations
        IdentifierNormalizer.Normalize("\"param with spaces+and-dashes\"").Should().Be("param_with_spacesplusandminusdashes");
        IdentifierNormalizer.Normalize("$test.param&value+sum").Should().Be("test_paramandvalueplussum");
        IdentifierNormalizer.Normalize("function(param1,param2)").Should().Be("function_param1_param2_");
    }
}