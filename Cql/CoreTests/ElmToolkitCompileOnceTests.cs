/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// Covers <see cref="ElmToolkit.CompileToAssemblies"/> only doing the work once per set of artifacts.
/// </summary>
/// <remarks>
/// Its original guard required <em>every</em> library to have produced an assembly, which never holds
/// once one legitimately produces none — so repeat calls rebuilt definitions, regenerated C# and
/// recompiled the whole set before discarding the result.
/// </remarks>
[TestClass]
public class ElmToolkitCompileOnceTests
{
    private const string CompileLogMessage = "Compiling ELM into C# and .NET Binaries";

    [TestMethod]
    public void CompileToAssemblies_CalledTwice_CompilesOnlyOnce()
    {
        var compiles = 0;
        var toolkit = CreateToolkit(() => compiles++);

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles, "The first call should compile.");

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles, "A repeat call on unchanged artifacts should not compile again.");
    }

    /// <summary>
    /// The case the original guard got wrong. A library whose dependencies are missing is dropped from
    /// the set and never produces an assembly, so "every library has an assembly" stays false forever and
    /// each repeat call rebuilt definitions, regenerated C# and recompiled the whole set to no effect.
    /// </summary>
    [TestMethod]
    public void CompileToAssemblies_WithALibraryThatProducesNoAssembly_StillCompilesOnlyOnce()
    {
        var compiles = 0;
        var toolkit = CreateToolkit(() => compiles++).AddElmLibraries([LibraryWithAMissingDependency()]);

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles, "The first call should compile.");
        Assert.IsTrue(
            toolkit.ArtifactsById.Values.Any(a => a.Results?.AssemblyBinary is null),
            "This test is only meaningful while some library produces no assembly.");

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles, "A repeat call on unchanged artifacts should not compile again.");
    }

    [TestMethod]
    public void CompileToAssemblies_AfterAddingALibrary_CompilesAgain()
    {
        var compiles = 0;
        var toolkit = CreateToolkit(() => compiles++);

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles);

        toolkit = toolkit.AddElmLibraries([LibraryWithAMissingDependency()]);
        toolkit.CompileToAssemblies();

        Assert.AreEqual(2, compiles, "Adding a library should re-open the work.");
    }

    [TestMethod]
    public void CompileToAssemblies_AfterChangingTheContinuation_CompilesAgain()
    {
        var compiles = 0;
        var toolkit = CreateToolkit(() => compiles++).AddElmLibraries([LibraryWithAMissingDependency()]);

        toolkit.CompileToAssemblies();
        Assert.AreEqual(1, compiles);

        // Compilation honours the continuation policy, so changing it has to re-open the work.
        toolkit.SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation.Continue);
        toolkit.CompileToAssemblies();

        Assert.AreEqual(2, compiles, "Changing the continuation should allow the set to be compiled again.");
    }

    /// <summary>
    /// A library referencing a library that is not in the set. It is removed before compilation, so it
    /// never gains an assembly.
    /// </summary>
    private static Library LibraryWithAMissingDependency() =>
        new()
        {
            identifier = new VersionedIdentifier { id = "LibraryWithAMissingDependency", version = "1.0.0" },
            includes = [new IncludeDef { localIdentifier = "Absent", path = "ThisLibraryDoesNotExist", version = "1.0.0" }],
        };

    private static ElmToolkit CreateToolkit(Action onCompile) =>
        new ElmToolkit(new CallbackLoggerFactory(message =>
            {
                if (message.StartsWith(CompileLogMessage, StringComparison.Ordinal))
                    onCompile();
            }))
            .AddElmFilesFromDirectory(LibrarySetsDirs.Demo.ElmDir);

    /// <summary>
    /// An <see cref="ILoggerFactory"/> that reports every message logged, so a test can observe whether
    /// the toolkit entered its compile path.
    /// </summary>
    private sealed class CallbackLoggerFactory(Action<string> onMessage) : ILoggerFactory
    {
        public ILogger CreateLogger(string categoryName) => new CallbackLogger(onMessage);

        public void AddProvider(ILoggerProvider provider) { }

        public void Dispose() { }

        private sealed class CallbackLogger(Action<string> onMessage) : ILogger
        {
            public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

            public bool IsEnabled(LogLevel logLevel) => true;

            public void Log<TState>(
                LogLevel logLevel,
                EventId eventId,
                TState state,
                Exception? exception,
                Func<TState, Exception?, string> formatter) =>
                onMessage(formatter(state, exception));
        }
    }
}
