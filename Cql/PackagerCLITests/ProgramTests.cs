/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Program_Help_ReturnsZero()
    {
        // Arrange
        var args = new[] { "--help" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().Be(0, "help command should return success");
    }

    [TestMethod]
    public void Program_Version_ReturnsZero()
    {
        // Arrange
        var args = new[] { "--version" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().Be(0, "version command should return success");
    }

    [TestMethod]
    public void Program_CqlHelp_ReturnsZero()
    {
        // Arrange
        var args = new[] { "cql", "--help" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().Be(0, "cql help command should return success");
    }

    [TestMethod]
    public void Program_ElmHelp_ReturnsZero()
    {
        // Arrange
        var args = new[] { "elm", "--help" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().Be(0, "elm help command should return success");
    }

    [TestMethod]
    public void Program_LibraryExtractAttachmentsHelp_ReturnsZero()
    {
        // Arrange
        var args = new[] { "library-extract-attachments", "--help" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().Be(0, "library-extract-attachments help command should return success");
    }

    [TestMethod]
    public void Program_NoArgs_ReturnsNonZero()
    {
        // Arrange
        var args = Array.Empty<string>();

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().NotBe(0, "program with no arguments should require a command");
    }

    [TestMethod]
    public void Program_InvalidCommand_ReturnsNonZero()
    {
        // Arrange
        var args = new[] { "invalid-command" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().NotBe(0, "invalid command should return error");
    }

    [TestMethod]
    public void Program_CqlWithoutRequiredArgs_ReturnsNonZero()
    {
        // Arrange - cql command requires --cql directory
        var args = new[] { "cql" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().NotBe(0, "cql command without required arguments should return error");
    }

    [TestMethod]
    public void Program_ElmWithoutRequiredArgs_ReturnsNonZero()
    {
        // Arrange - elm command requires --elm directory
        var args = new[] { "elm" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().NotBe(0, "elm command without required arguments should return error");
    }

    [TestMethod]
    public void Program_LibraryExtractWithoutRequiredArgs_ReturnsNonZero()
    {
        // Arrange - library-extract-attachments requires --library-file
        var args = new[] { "library-extract-attachments" };

        // Act
        var exitCode = Program.Main(args);

        // Assert
        exitCode.Should().NotBe(0, "library-extract-attachments command without required arguments should return error");
    }
}
