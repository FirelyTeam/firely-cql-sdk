using Hl7.Cql.CqlToElm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;

namespace CoreTests.Infrastructure
{
    [TestClass]
    public class CqlLibraryStringTests
    {
        [TestMethod]
        public void FromCql_LibraryContainsDashes()
        {
            var libraryString = CqlLibraryString.Parse(
                """
                library "num-con-mon" version '1.0.0'
                """);

            Assert.AreEqual("num-con-mon", libraryString.LibraryIdentifier.Identifier.ToString());
            Assert.AreEqual("1.0.0", libraryString.LibraryIdentifier.Version.ToString());
            Assert.AreEqual("num-con-mon-1.0.0", libraryString.LibraryIdentifier.ToString());

            var libraryString2 = (CqlVersionedLibraryIdentifier)"num-con-mon-1.0.0";
            Assert.AreEqual("num-con-mon-1.0.0", libraryString2);
        }

        [TestMethod]
        public void FromCql_ValidCqlContentWithoutVersion_ReturnsCqlLibraryString()
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
        public void FromCql_ValidCqlContentSkipCommentsAndWithoutVersion_ReturnsCqlLibraryString()
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
            var expectedIdentifier = CqlVersionedLibraryIdentifier.FromNameAndVersion(
                CqlLibraryIdentifier.Parse("TestLibrary"));

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.LibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void FromCql_ValidCqlContentWithEmptyLines_ReturnsCqlLibraryString()
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
        public void FromCql_ValidCqlContent_ReturnsCqlLibraryString()
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
        [ExpectedException(typeof(FormatException))]
        public void FromCql_InvalidCqlContent_ThrowsFormatException()
        {
            // Arrange
            string cqlContent = "invalid content";

            // Act
            CqlLibraryString.Parse(cqlContent);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void FromCql_EmptyCqlContent_ThrowsFormatException()
        {
            // Arrange
            string cqlContent = "";

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => CqlLibraryString.Parse(cqlContent));
        }
    }
}
