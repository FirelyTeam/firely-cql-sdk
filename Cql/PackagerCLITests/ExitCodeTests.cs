/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Tests;

/// <summary>
/// Tests to verify that the PackagerCLI returns appropriate exit codes
/// for various scenarios.
/// </summary>
[TestClass]
public class ExitCodeTests
{
    [TestMethod]
    public void ExitCode_SuccessfulHelp_ReturnsZero()
    {
        // Arrange & Act
        var exitCode = Program.Main(new[] { "--help" });

        // Assert
        exitCode.Should().Be(0, "successful operations should return 0");
    }

    [TestMethod]
    public void ExitCode_MissingRequiredCqlDirectory_ReturnsNonZero()
    {
        // Arrange & Act - cql command without required --cql directory
        var exitCode = Program.Main(new[] { "cql" });

        // Assert
        exitCode.Should().NotBe(0, "missing required arguments should return non-zero");
    }

    [TestMethod]
    public void ExitCode_MissingRequiredElmDirectory_ReturnsNonZero()
    {
        // Arrange & Act - elm command without required --elm directory
        var exitCode = Program.Main(new[] { "elm" });

        // Assert
        exitCode.Should().NotBe(0, "missing required arguments should return non-zero");
    }

    [TestMethod]
    public void ExitCode_MissingRequiredLibraryFile_ReturnsNonZero()
    {
        // Arrange & Act - library-extract-attachments without required --library-file
        var exitCode = Program.Main(new[] { "library-extract-attachments" });

        // Assert
        exitCode.Should().NotBe(0, "missing required arguments should return non-zero");
    }

    [TestMethod]
    public void ExitCode_NonExistentCqlDirectory_ReturnsNonZero()
    {
        // Arrange & Act - cql command with non-existent directory
        var exitCode = Program.Main(new[] { "cql", "--cql", "/path/that/does/not/exist" });

        // Assert
        exitCode.Should().NotBe(0, "non-existent directories should return error");
    }

    [TestMethod]
    public void ExitCode_NoOutputDirectoriesSpecified_ReturnsNonZero()
    {
        // Arrange - Create a temporary directory for testing
        var tempCqlDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(tempCqlDir);

        try
        {
            // Act - cql command without any output directories
            var exitCode = Program.Main(new[] { "cql", "--cql", tempCqlDir });

            // Assert
            exitCode.Should().NotBe(0, "commands should require at least one output directory");
        }
        finally
        {
            // Cleanup
            if (Directory.Exists(tempCqlDir))
            {
                Directory.Delete(tempCqlDir, true);
            }
        }
    }
}
