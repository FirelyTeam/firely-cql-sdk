/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Xml.Serialization;

namespace Hl7.Cql.CqlToElm.Test.Xml
{
    // The part of the conformance suite's test schema (testSchema.xsd, the suite's tests/testSchema.xsd) that XmlTest
    // reads. The serializer ignores the elements and attributes the schema defines beyond these, so the model is
    // maintained by hand and extended only when XmlTest needs more of the schema.

    /// <summary>A test suite: the root <c>tests</c> element of a suite file.</summary>
    [XmlType(Namespace = Namespace)]
    [XmlRoot("tests", Namespace = Namespace, IsNullable = false)]
    public class Tests
    {
        public const string Namespace = "http://hl7.org/fhirpath/tests";

        [XmlElement("group")]
        public Group[]? group { get; set; }

        [XmlAttribute]
        public string? name { get; set; }

        /// <summary>The specification version in which the tested features were introduced.</summary>
        [XmlAttribute]
        public string? version { get; set; }

        /// <summary>The last specification version in which the tested features appear.</summary>
        [XmlAttribute]
        public string? versionTo { get; set; }
    }

    /// <summary>A group of tests within a suite.</summary>
    [XmlType(Namespace = Tests.Namespace)]
    public class Group
    {
        [XmlElement("test")]
        public Test[]? test { get; set; }

        [XmlAttribute]
        public string? name { get; set; }

        /// <summary>The specification version in which the tested features were introduced.</summary>
        [XmlAttribute]
        public string? version { get; set; }

        /// <summary>The last specification version in which the tested features appear.</summary>
        [XmlAttribute]
        public string? versionTo { get; set; }
    }

    /// <summary>A single test: an expression (or a library) and its expected output.</summary>
    [XmlType(Namespace = Tests.Namespace)]
    public class Test
    {
        /// <summary>The expression under test; absent when the test provides a library instead.</summary>
        [XmlElement("expression")]
        public Expression? expression { get; set; }

        /// <summary>The complete CQL library under test; absent when the test provides an expression instead.</summary>
        [XmlElement("library")]
        public Expression? library { get; set; }

        [XmlElement("output")]
        public Output[]? output { get; set; }

        [XmlAttribute]
        public string? name { get; set; }

        /// <summary>The specification version in which the tested features were introduced.</summary>
        [XmlAttribute]
        public string? version { get; set; }

        /// <summary>The last specification version in which the tested features appear.</summary>
        [XmlAttribute]
        public string? versionTo { get; set; }
    }

    /// <summary>CQL text with an <c>invalid</c> attribute saying which kind of error, if any, it is expected to produce.</summary>
    [XmlType(Namespace = Tests.Namespace)]
    public class Expression
    {
        [XmlAttribute]
        public InvalidType invalid { get; set; }

        /// <summary>Whether the <c>invalid</c> attribute is present; the serializer sets it while reading.</summary>
        [XmlIgnore]
        public bool invalidSpecified { get; set; }

        [XmlText]
        public string? Value { get; set; }
    }

    /// <summary>The kind of error a test is expected to produce.</summary>
    [XmlType(Namespace = Tests.Namespace)]
    public enum InvalidType
    {
        /// <summary>The test is expected to evaluate successfully.</summary>
        [XmlEnum("false")]
        False,

        /// <summary>The test is expected to produce a syntax error.</summary>
        [XmlEnum("syntax")]
        Syntax,

        /// <summary>The test is expected to produce a semantic error.</summary>
        [XmlEnum("semantic")]
        Semantic,

        /// <summary>The test is expected to produce an execution error.</summary>
        [XmlEnum("execution")]
        Execution,

        /// <summary>The test is expected to produce a runtime error.</summary>
        [XmlEnum("true")]
        True,
    }

    /// <summary>An expected output, as the CQL text of a literal.</summary>
    [XmlType(Namespace = Tests.Namespace)]
    public class Output
    {
        /// <summary>For a library test, the name of the define this output belongs to.</summary>
        [XmlAttribute]
        public string? name { get; set; }

        [XmlText]
        public string? Value { get; set; }
    }
}
