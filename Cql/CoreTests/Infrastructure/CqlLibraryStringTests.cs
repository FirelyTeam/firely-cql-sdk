using CqlSdkPrototype.Infrastructure;

namespace CoreTests.Infrastructure
{
    [TestClass]
    public class CqlLibraryStringTests
    {
        [TestMethod]
        public void FromCql_ValidCqlContentWithoutVersion_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary";
            var expectedIdentifier = CqlVersionedLibraryIdentifier.FromNameAndVersion(
                CqlLibraryIdentifier.Parse("TestLibrary"));

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.VersionedLibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void FromCql_ValidCqlContentWithEmptyLines_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary version '1.0.0'";
            var expectedIdentifier = CqlVersionedLibraryIdentifier.FromNameAndVersion(
                CqlLibraryIdentifier.Parse("TestLibrary"),
                CqlLibraryVersion.Parse("1.0.0"));

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.VersionedLibraryIdentifier);
            Assert.AreEqual(cqlContent, result.Cql);
        }

        [TestMethod]
        public void FromCql_ValidCqlContent_ReturnsCqlLibraryString()
        {
            // Arrange
            string cqlContent = "library TestLibrary version '1.0.0'";
            var expectedIdentifier = CqlVersionedLibraryIdentifier.FromNameAndVersion(
                CqlLibraryIdentifier.Parse("TestLibrary"),
                CqlLibraryVersion.Parse("1.0.0"));

            // Act
            var result = CqlLibraryString.Parse(cqlContent);

            // Assert
            Assert.AreEqual(expectedIdentifier, result.VersionedLibraryIdentifier);
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
