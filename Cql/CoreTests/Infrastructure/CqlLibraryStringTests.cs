/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CoreTests.Infrastructure
{
    [TestClass]
    public class CqlLibraryStringTests
    {
        [TestMethod]
        public void Parse_ValidCqlContentWithoutVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"TestLibrary";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidCqlContentSkipCommentsAndWithoutVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = """

                /* ignore block comments */

                /*
                    ignore
                    block
                    comments

                    library WontUseThis
                */

                // ignore line comments

                library TestLibrary
                """;
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"TestLibrary";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidCqlContentWithEmptyLines_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary version '1.0.0'";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"TestLibrary-1.0.0";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidCqlContent_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary version '1.0.0'";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"TestLibrary-1.0.0";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidQualifierIdentifierAndVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library NamespaceA.NamespaceB.TestLibrary version '1.0.0'";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"NamespaceA.NamespaceB.TestLibrary-1.0.0";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidQualifierQuotedIdentifierAndVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = """library Namespace."Test Library" version '1.0.0-alpha'""";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"""Namespace.Test Library-1.0.0-alpha""";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidQualifierDelimitedIdentifierAndVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = """library Namespace.`Test Library` version '1.0.0-alpha'""";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"""Namespace.Test Library-1.0.0-alpha""";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_ValidQualifierDelimitedIdentifierAndVersionUnbalancedQuote_ThrowFormatException()
        {
            // Arrange
            string cqlContent = """library Namespace.`Test Library version '1.0.0-alpha'""";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"""Namespace.Test Library-1.0.0-alpha""";

            // Act
            Action act = () => CqlLibraryString.Parse(cqlContent);

            // Assert
            var e = Assert.ThrowsException<FormatException>(act);
            Assert.AreEqual("Not a valid Hl7.Cql.CqlToElm.CqlLibraryString: Syntax error: extraneous input '<EOF>' expecting {QUOTEDIDENTIFIER, IDENTIFIER, DELIMITEDIDENTIFIER}.", e.Message);
        }

        [TestMethod]
        public void Parse_ValidQualifierDelimitedIdentifierAndVersionWithSpaces_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = """library `Name space`.`Test Library` version '1.0.0-alpha'""";
            var expectedIdentifier = (CqlVersionedLibraryIdentifier)"""Name space.Test Library-1.0.0-alpha""";

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void Parse_InvalidCqlContent_ThrowsFormatException()
        {
            // Arrange
            string cqlContent = "invalid content";

            // Act
            Action act = () => CqlLibraryString.Parse(cqlContent);

            // Assert
            var e = Assert.ThrowsException<FormatException>(act);
            Assert.AreEqual("Not a valid Hl7.Cql.CqlToElm.CqlLibraryString: Syntax error: missing 'library' at 'invalid'.", e.Message);
        }

        [TestMethod]
        public void Parse_EmptyCqlContent_ThrowsFormatException()
        {
            // Arrange
            string cqlContent = "";

            // Act
            Action act = () => CqlLibraryString.Parse(cqlContent);

            // Assert
            var e = Assert.ThrowsException<FormatException>(act);
            Assert.AreEqual("Not a valid Hl7.Cql.CqlToElm.CqlLibraryString: Syntax error: mismatched input '<EOF>' expecting 'library'.", e.Message);
        }
    }
}
