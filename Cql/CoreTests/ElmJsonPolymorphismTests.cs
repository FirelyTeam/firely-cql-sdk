/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

/// <summary>
/// The "type" discriminator of ELM JSON: how it is read and written, what is rejected, how deep an expression
/// may nest, and what parsing and serializing allocate.
/// </summary>
[TestClass]
public class ElmJsonPolymorphismTests
{
    private const string Prefix = """{"library":{"identifier":{"id":"T","version":"1"},"statements":{"def":[""";
    private const string Suffix = "]}}}";

    private static string LibraryJson(string statementsJson) => Prefix + statementsJson + Suffix;

    private static string StatementWith(string expressionJson) =>
        $$"""{"name":"A","context":"Unfiltered","accessLevel":"Public","expression":{{expressionJson}}}""";

    private static Library Parse(string json) => Library.ParseFromJson(json, validate: false);

    private static Expression ParseExpression(string expressionJson) =>
        Parse(LibraryJson(StatementWith(expressionJson))).statements.Single().expression;

    private static Library LibraryWith(params ExpressionDef[] statements) =>
        new()
        {
            identifier = new VersionedIdentifier { id = "T", version = "1" },
            statements = statements,
        };

    private static ExpressionDef DefWith(Expression expression) =>
        new() { name = "A", context = "Unfiltered", accessLevel = AccessModifier.Public, expression = expression };

    private static Literal IntegerLiteral(string value = "1") =>
        new() { value = value, valueType = new System.Xml.XmlQualifiedName("Integer", "urn:hl7-org:elm-types:r1") };

    // ---- Reading the discriminator ----

    [TestMethod]
    public void Read_TypeFirst_ReadsTheNamedType()
    {
        var expression = ParseExpression("""{"type":"Literal","value":"1","valueType":"{urn:hl7-org:elm-types:r1}Integer"}""");

        expression.Should().BeOfType<Literal>().Which.value.Should().Be("1");
    }

    [TestMethod]
    public void Read_TypeNotFirst_ReadsTheNamedType()
    {
        var expression = ParseExpression("""{"value":"1","valueType":"{urn:hl7-org:elm-types:r1}Integer","type":"Literal"}""");

        expression.Should().BeOfType<Literal>().Which.value.Should().Be("1");
    }

    [TestMethod]
    public void Read_TypeNotFirst_AtSeveralNestingLevels()
    {
        var json = """
            {"operand":{"operand":{"value":"1","type":"Literal"},"type":"Not"},"type":"Not"}
            """;

        var outer = ParseExpression(json).Should().BeOfType<Not>().Subject;
        var inner = outer.operand.Should().BeOfType<Not>().Subject;
        inner.operand.Should().BeOfType<Literal>().Which.value.Should().Be("1");
    }

    public static IEnumerable<object[]> MalformedExpressions =>
    [
        ["unknown type name", """{"type":"NoSuchExpression"}"""],
        ["empty string", """{"type":""}"""],
        ["number", """{"type":1,"value":"1"}"""],
        ["boolean", """{"type":true,"value":"1"}"""],
        ["wrong case", """{"type":"literal","value":"1"}"""],
        ["elm: prefix", """{"type":"elm:Literal","value":"1"}"""],
        ["qualified name", """{"type":"{urn:hl7-org:elm:r1}Literal","value":"1"}"""],
        ["CLR full name", """{"type":"Hl7.Cql.Elm.Literal","value":"1"}"""],
        ["abstract class", """{"type":"Expression"}"""],
        ["abstract intermediate class", """{"type":"UnaryExpression","operand":{"type":"Literal","value":"1"}}"""],
        ["type outside the hierarchy", """{"type":"VersionedIdentifier","id":"x"}"""],
        ["missing type on an abstract declared type", """{"value":"1"}"""],
        ["capitalised Type key", """{"Type":"Literal","value":"1"}"""],
        ["unmapped property", """{"type":"Literal","value":"1","noSuchProperty":1}"""],
        ["node that is not an object (number)", "1"],
        ["node that is not an object (string)", "\"Literal\""],
        ["node that is not an object (array)", """[{"type":"Literal"}]"""],
    ];

    [TestMethod]
    [DynamicData(nameof(MalformedExpressions))]
    public void Read_MalformedNode_ThrowsJsonException(string description, string expressionJson)
    {
        _ = description;

        var act = () => ParseExpression(expressionJson);

        act.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void Read_NullType_ThrowsJsonExceptionNamingThePath()
    {
        var act = () => ParseExpression("""{"type":null,"value":"1"}""");

        var exception = act.Should().Throw<JsonException>().Which;
        exception.Path.Should().EndWith(".type");
    }

    // ---- Concrete declared types ----

    [TestMethod]
    public void Read_ConcreteDeclaredType_WithoutType_ReadsTheDeclaredType()
    {
        var library = Parse(LibraryJson("""{"name":"A","context":"Unfiltered","accessLevel":"Public"}"""));

        library.statements.Single().Should().BeOfType<ExpressionDef>();
    }

    [TestMethod]
    public void Read_ConcreteDeclaredType_WithItsOwnName_ReadsTheDeclaredType()
    {
        var library = Parse(LibraryJson("""{"type":"ExpressionDef","name":"A","context":"Unfiltered","accessLevel":"Public"}"""));

        library.statements.Single().Should().BeOfType<ExpressionDef>();
    }

    [TestMethod]
    public void Read_ConcreteDeclaredType_WithADerivedName_ReadsTheDerivedType()
    {
        var library = Parse(LibraryJson("""{"type":"FunctionDef","name":"F","context":"Unfiltered","accessLevel":"Public"}"""));

        library.statements.Single().Should().BeOfType<FunctionDef>();
    }

    [TestMethod]
    public void Read_ConcreteDeclaredType_WithAnUnrelatedName_ThrowsJsonException()
    {
        var act = () => Parse(LibraryJson("""{"type":"Literal","name":"A"}"""));

        act.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void Read_AliasedQuerySource_WithoutType_ReadsTheDeclaredType()
    {
        var query = ParseExpression("""{"type":"Query","source":[{"alias":"X","expression":{"type":"Null"}}]}""");

        query.Should().BeOfType<Query>().Which.source.Single().Should().BeOfType<AliasedQuerySource>();
    }

    [TestMethod]
    public void Read_AliasedQuerySource_WithItsOwnName_ReadsTheDeclaredType()
    {
        var query = ParseExpression("""{"type":"Query","source":[{"type":"AliasedQuerySource","alias":"X","expression":{"type":"Null"}}]}""");

        query.Should().BeOfType<Query>().Which.source.Single().Should().BeOfType<AliasedQuerySource>();
    }

    [TestMethod]
    public void Read_AliasedQuerySource_WithAnotherName_ThrowsJsonException()
    {
        var act = () => ParseExpression("""{"type":"Query","source":[{"type":"Literal","alias":"X"}]}""");

        act.Should().Throw<JsonException>();
    }

    // ---- Old-style "type" on concrete model classes ----

    [TestMethod]
    public void Read_OldStyleType_OnLibrary_NamingTheClass_IsAccepted()
    {
        var library = Library.ParseFromJson(
            """{"library":{"type":"Library","identifier":{"id":"T","version":"1"}}}""", validate: false);

        library.identifier.id.Should().Be("T");
    }

    [TestMethod]
    public void Read_OldStyleType_OnLibrary_NamingAnotherClass_ThrowsJsonException()
    {
        var act = () => Library.ParseFromJson(
            """{"library":{"type":"Literal","identifier":{"id":"T","version":"1"}}}""", validate: false);

        act.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void Read_OldStyleType_OnVersionedIdentifier_NamingTheClass_IsAccepted()
    {
        var library = Library.ParseFromJson(
            """{"library":{"identifier":{"type":"VersionedIdentifier","id":"T","version":"1"}}}""", validate: false);

        library.identifier.id.Should().Be("T");
    }

    [TestMethod]
    public void Read_OldStyleType_OnVersionedIdentifier_NamingAnotherClass_ThrowsJsonException()
    {
        var act = () => Library.ParseFromJson(
            """{"library":{"identifier":{"type":"Library","id":"T","version":"1"}}}""", validate: false);

        act.Should().Throw<JsonException>();
    }

    private static string TupleElementJson(string typeProperty) =>
        """{"type":"Null","resultTypeSpecifier":{"type":"TupleTypeSpecifier","element":[{TYPE"name":"a","elementType":{"type":"NamedTypeSpecifier","name":"{urn:hl7-org:elm-types:r1}Integer"}}]}}"""
            .Replace("TYPE", typeProperty);

    [TestMethod]
    public void Read_OldStyleType_OnTupleElementDefinition_NamingTheClass_IsAccepted()
    {
        var expression = ParseExpression(TupleElementJson("\"type\":\"TupleElementDefinition\","));

        var tuple = expression.resultTypeSpecifier.Should().BeOfType<TupleTypeSpecifier>().Subject;
        tuple.element.Single().name.Should().Be("a");
    }

    [TestMethod]
    public void Read_OldStyleType_OnTupleElementDefinition_NamingAnotherClass_ThrowsJsonException()
    {
        var act = () => ParseExpression(TupleElementJson("\"type\":\"NamedTypeSpecifier\","));

        act.Should().Throw<JsonException>();
    }

    private static string NarrativeJson(string typeProperty) =>
        """{"type":"Null","annotation":[{"type":"Annotation","s":{TYPE"value":["x"]}}]}"""
            .Replace("TYPE", typeProperty);

    [TestMethod]
    public void Read_OldStyleType_OnNarrative_NamingTheClass_IsAccepted()
    {
        var expression = ParseExpression(NarrativeJson("\"type\":\"Narrative\","));

        var annotation = expression.annotation.Single().Should().BeOfType<Annotation>().Subject;
        annotation.s.Text.Should().Equal("x");
    }

    [TestMethod]
    public void Read_OldStyleType_OnNarrative_NamingAnotherClass_ThrowsJsonException()
    {
        var act = () => ParseExpression(NarrativeJson("\"type\":\"Literal\","));

        act.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void Read_DefinitionWrapperTypedAsLibraryDollar_IsAccepted()
    {
        var json = """
            {"library":{"identifier":{"id":"T","version":"1"},
              "usings":{"type":"Library$Usings","def":[{"localIdentifier":"System","uri":"urn:hl7-org:elm-types:r1"}]}}}
            """;

        var library = Library.ParseFromJson(json, validate: false);

        library.usings.Single().localIdentifier.Should().Be("System");
    }

    // ---- Concrete base types ----

    [TestMethod]
    public void ReadAndWrite_ConcreteBaseType_InItsOwnSlot_RoundTrips()
    {
        var library = LibraryWith(DefWith(IntegerLiteral()));

        var json = library.SerializeToJson(writeIndented: false);
        var parsed = Library.ParseFromJson(json);

        parsed.identifier.id.Should().Be("T");
        parsed.statements.Single().Should().BeOfType<ExpressionDef>();
        parsed.SerializeToJson(writeIndented: false).Should().Be(json);
    }

    [TestMethod]
    public void ReadAndWrite_LocatorSlot_HoldingACqlToElmError_PinsTheEmittedForm()
    {
        var error = new CqlToElmError { message = "boom", errorType = ErrorType.semantic };
        var literal = IntegerLiteral();
        literal.annotation = [new Annotation { locator = error }];

        var json = LibraryWith(DefWith(literal)).SerializeToJson(writeIndented: false);

        json.Should().Contain("\"locator\":{\"type\":\"CqlToElmError\"");
        var parsed = Library.ParseFromJson(json);
        var annotation = parsed.statements.Single().expression.annotation.Single().Should().BeOfType<Annotation>().Subject;
        annotation.locator.Should().BeOfType<CqlToElmError>().Which.message.Should().Be("boom");
    }

    [TestMethod]
    public void Read_LocatorSlot_WithoutType_ReadsTheDeclaredLocator()
    {
        var expression = ParseExpression(
            """{"type":"Null","annotation":[{"type":"Annotation","locator":{"startLine":3}}]}""");

        var annotation = expression.annotation.Single().Should().BeOfType<Annotation>().Subject;
        annotation.locator.Should().BeOfType<Locator>();
    }

    // ---- Writing the discriminator ----

    [TestMethod]
    public void Write_ExpressionSlotHoldingALiteral_EmitsType()
    {
        var json = LibraryWith(DefWith(IntegerLiteral())).SerializeToJson(writeIndented: false);

        json.Should().Contain("\"expression\":{\"type\":\"Literal\"");
    }

    [TestMethod]
    public void Write_ExpressionDefInStatements_EmitsNoType()
    {
        var json = LibraryWith(DefWith(IntegerLiteral())).SerializeToJson(writeIndented: false);

        var statement = JsonNode.Parse(json)!["library"]!["statements"]!["def"]!.AsArray().Single()!.AsObject();
        statement.ContainsKey("type").Should().BeFalse();
    }

    [TestMethod]
    public void Write_FunctionDefInStatements_EmitsType()
    {
        var function = new FunctionDef { name = "F", context = "Unfiltered", accessLevel = AccessModifier.Public };

        var json = LibraryWith(function).SerializeToJson(writeIndented: false);

        var statement = JsonNode.Parse(json)!["library"]!["statements"]!["def"]!.AsArray().Single()!.AsObject();
        statement["type"]!.GetValue<string>().Should().Be("FunctionDef");
    }

    [TestMethod]
    public void Write_AliasedQuerySource_EmitsNoType()
    {
        var query = new Query
        {
            source = [new AliasedQuerySource { alias = "X", expression = new Null() }],
        };

        var json = LibraryWith(DefWith(query)).SerializeToJson(writeIndented: false);

        var source = JsonNode.Parse(json)!["library"]!["statements"]!["def"]![0]!["expression"]!["source"]![0]!.AsObject();
        source.ContainsKey("type").Should().BeFalse();
    }

    // ---- Writing a subclass that is not part of the ELM model ----

    private sealed class LiteralOutsideTheModel : Literal;

    [TestMethod]
    public void Write_SubclassOutsideTheElmModel_ThrowsNotSupportedException()
    {
        var literal = new LiteralOutsideTheModel { value = "1" };

        var act = () => LibraryWith(DefWith(literal)).SerializeToJson(writeIndented: false);

        act.Should().Throw<NotSupportedException>();
    }

    // ---- Depth ----

    // Reading and writing recurse once per nesting level, so the stack they need grows with the depth. Nesting this
    // deep does not fit on the stack of an ordinary thread, so this test runs on a thread with a large stack of its
    // own. What an ordinary thread does with such depth is pinned by the tests below.
    private const int DeepStackBytes = 64 * 1024 * 1024;

    [TestMethod]
    public void Depth_ExpressionNestedTwoThousandDeep_ParsesSerializesAndValidates()
    {
        Exception? failure = null;
        var thread = new Thread(() =>
        {
            try { ParseSerializeAndValidateNestedNots(depth: 2000); }
            catch (Exception e) { failure = e; }
        }, DeepStackBytes);
        thread.Start();
        thread.Join();

        failure.Should().BeNull();
    }

    private const int ExceedsOrdinaryStackDepth = 4000;
    private const int OneMegabyteStackBytes = 1024 * 1024;

    private static string NestedNotsJson(int depth)
    {
        var expressionJson = new StringBuilder();
        for (var i = 0; i < depth; i++)
            expressionJson.Append("""{"type":"Not","operand":""");
        expressionJson.Append("""{"type":"Literal","value":"true","valueType":"{urn:hl7-org:elm-types:r1}Boolean"}""");
        expressionJson.Append('}', depth);
        return LibraryJson(StatementWith(expressionJson.ToString()));
    }

    private static Exception? CaptureOnThread(Action action, int maxStackSize)
    {
        Exception? failure = null;
        var thread = new Thread(() =>
        {
            try { action(); }
            catch (Exception e) { failure = e; }
        }, maxStackSize);
        thread.Start();
        thread.Join();
        return failure;
    }

    [TestMethod]
    public void Depth_ParsingExpressionTooDeepForTheStack_ThrowsJsonException()
    {
        var json = NestedNotsJson(ExceedsOrdinaryStackDepth);

        var failure = CaptureOnThread(() => Library.ParseFromJson(json, validate: false), OneMegabyteStackBytes);

        failure.Should().BeOfType<JsonException>();
    }

    [TestMethod]
    public void Depth_SerializingExpressionTooDeepForTheStack_ThrowsJsonException()
    {
        Expression expression = IntegerLiteral();
        for (var i = 0; i < ExceedsOrdinaryStackDepth; i++)
            expression = new Not { operand = expression };
        var library = LibraryWith(DefWith(expression));

        var failure = CaptureOnThread(() => library.SerializeToJson(writeIndented: false), OneMegabyteStackBytes);

        failure.Should().BeOfType<JsonException>();
    }

    private static void ParseSerializeAndValidateNestedNots(int depth)
    {
        var expressionJson = new StringBuilder();
        for (var i = 0; i < depth; i++)
            expressionJson.Append("""{"type":"Not","operand":""");
        expressionJson.Append("""{"type":"Literal","value":"true","valueType":"{urn:hl7-org:elm-types:r1}Boolean"}""");
        expressionJson.Append('}', depth);

        var library = Library.ParseFromJson(LibraryJson(StatementWith(expressionJson.ToString())));
        library.Validate();

        var nested = 0;
        for (var e = library.statements.Single().expression; e is Not not; e = not.operand)
            nested++;
        nested.Should().Be(depth);

        var json = library.SerializeToJson(writeIndented: false);
        var reparsed = Library.ParseFromJson(json);
        reparsed.Validate();
        reparsed.SerializeToJson(writeIndented: false).Should().Be(json);
    }

    // ---- Allocation ----

    private const long MaxAllocatedBytesPerCharacter = 40;

    private static readonly string FhirHelpersPath = Path.Combine("Input", "ELM", "Libs", "FHIRHelpers-4.0.1.json");

    [TestMethod]
    public void Allocation_ParseFromJson_StaysUnderBytesPerInputByte()
    {
        var json = File.ReadAllText(FhirHelpersPath);
        var inputBytes = Encoding.UTF8.GetByteCount(json);
        _ = Library.ParseFromJson(json);

        var before = GC.GetAllocatedBytesForCurrentThread();
        var library = Library.ParseFromJson(json);
        var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

        Console.WriteLine($"ParseFromJson allocated {allocated} bytes for {inputBytes} input bytes: {allocated / (double)inputBytes:F1} per byte");
        library.Should().NotBeNull();
        allocated.Should().BeLessThan(inputBytes * MaxAllocatedBytesPerCharacter);
    }

    [TestMethod]
    public void Allocation_SerializeToJson_StaysUnderBytesPerOutputCharacter()
    {
        var library = Library.ParseFromJson(File.ReadAllText(FhirHelpersPath));
        _ = library.SerializeToJson(writeIndented: false);

        var before = GC.GetAllocatedBytesForCurrentThread();
        var json = library.SerializeToJson(writeIndented: false);
        var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

        Console.WriteLine($"SerializeToJson allocated {allocated} bytes for {json.Length} output characters: {allocated / (double)json.Length:F1} per character");
        allocated.Should().BeLessThan(json.Length * MaxAllocatedBytesPerCharacter);
    }
}
