/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class ElmToolkitTests
{
    [TestMethod]
    public void AddElmFileWithDependencies_LoadsLibraryAndDependencies()
    {
        // Arrange
        var elmFile = new FileInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm", "MATGlobalCommonFunctionsFHIR4.json"));
        elmFile.Exists.Should().BeTrue("Test ELM file should exist");

        var elmToolkit = new ElmToolkit();

        // Act
        elmToolkit.AddElmFileWithDependencies(elmFile);

        // Assert
        elmToolkit.ArtifactsById.Should().HaveCount(2, "Should load the library and its FHIRHelpers dependency");

        var libraryIds = elmToolkit.ArtifactsById.Keys.Select(k => k.ToString()).ToList();
        libraryIds.Should().Contain("MATGlobalCommonFunctionsFHIR4-6.1.000", "Should load the main library");
        libraryIds.Should().Contain("FHIRHelpers-4.0.001", "Should load the FHIRHelpers dependency");
    }

    [TestMethod]
    public void AddElmFileWithDependencies_ThrowsFileNotFoundException_WhenFileDoesNotExist()
    {
        // Arrange
        var nonExistentFile = new FileInfo(Path.Combine("NonExistent", "Library.json"));
        var elmToolkit = new ElmToolkit();

        // Act & Assert
        var act = () => elmToolkit.AddElmFileWithDependencies(nonExistentFile);
        act.Should().Throw<FileNotFoundException>()
           .WithMessage("*does not exist*");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_LoadsLibraryByNameAndVersion()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act
        elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "MATGlobalCommonFunctionsFHIR4", "6.1.000");

        // Assert
        elmToolkit.ArtifactsById.Should().HaveCount(2, "Should load the library and its FHIRHelpers dependency");

        var libraryIds = elmToolkit.ArtifactsById.Keys.Select(k => k.ToString()).ToList();
        libraryIds.Should().Contain("MATGlobalCommonFunctionsFHIR4-6.1.000", "Should load the main library");
        libraryIds.Should().Contain("FHIRHelpers-4.0.001", "Should load the FHIRHelpers dependency");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_LoadsLibraryWithoutVersion()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act - Load without specifying version (should use filename without version)
        elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "FHIRHelpers");

        // Assert
        elmToolkit.ArtifactsById.Should().HaveCount(1, "Should load only FHIRHelpers (no dependencies)");

        var libraryIds = elmToolkit.ArtifactsById.Keys.Select(k => k.ToString()).ToList();
        libraryIds.Should().Contain("FHIRHelpers-4.0.001", "Should load FHIRHelpers");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_StripsCqlExtension()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act - Pass library name with .cql extension (should be stripped)
        elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "FHIRHelpers.cql");

        // Assert
        elmToolkit.ArtifactsById.Should().HaveCount(1, "Should load FHIRHelpers");

        var libraryIds = elmToolkit.ArtifactsById.Keys.Select(k => k.ToString()).ToList();
        libraryIds.Should().Contain("FHIRHelpers-4.0.001", "Should load FHIRHelpers after stripping .cql extension");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_HandlesAlreadyLoadedLibraries()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act - First load FHIRHelpers explicitly
        elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "FHIRHelpers", "4.0.001");

        // Then load MATGlobalCommonFunctionsFHIR4 which depends on FHIRHelpers
        // The implementation should handle the fact that FHIRHelpers is already in the queue
        elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "MATGlobalCommonFunctionsFHIR4", "6.1.000");

        // Assert - Should have both libraries (FHIRHelpers won't be added twice internally)
        elmToolkit.ArtifactsById.Should().HaveCount(2, "Should have both libraries loaded");

        var libraryIds = elmToolkit.ArtifactsById.Keys.Select(k => k.ToString()).ToList();
        libraryIds.Should().Contain("FHIRHelpers-4.0.001", "Should have FHIRHelpers");
        libraryIds.Should().Contain("MATGlobalCommonFunctionsFHIR4-6.1.000", "Should have MATGlobalCommonFunctionsFHIR4");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_ThrowsFileNotFoundException_WhenLibraryNotFound()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act & Assert
        var act = () => elmToolkit.AddElmFileWithDependenciesFromDirectory(elmDir, "NonExistentLibrary", "1.0.0");
        act.Should().Throw<FileNotFoundException>()
           .WithMessage("*does not exist*");
    }

    [TestMethod]
    public void AddElmFileWithDependenciesFromDirectory_CanCompileAndInvoke()
    {
        // Arrange
        var elmDir = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "..", "LibrarySets", "Demo", "Elm"));
        elmDir.Exists.Should().BeTrue("Test ELM directory should exist");

        var elmToolkit = new ElmToolkit();

        // Act - Load library with dependencies and compile
        using var librarySetInvoker = elmToolkit
                                      .AddElmFileWithDependenciesFromDirectory(elmDir, "MATGlobalCommonFunctionsFHIR4", "6.1.000")
                                      .CreateLibrarySetInvoker();

        // Assert - Should be able to create invoker and find the library
        librarySetInvoker.Should().NotBeNull();
        var libraryId = CqlVersionedLibraryIdentifier.Parse("MATGlobalCommonFunctionsFHIR4-6.1.000");

        var expressions = librarySetInvoker
                          .SelectExpressionsForLibrary(libraryId)
                          .ToList();

        expressions.Should().NotBeEmpty("Should have expressions in the loaded library");
    }
}
