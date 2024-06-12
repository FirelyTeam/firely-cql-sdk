/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchitectureTests;

[TestClass]
public class CodeFormattingTests
{
	private static DirectoryInfo _solutionDir = null!;
	private static IEnumerable<FileInfo> _allCSharpFilesUnderSolutionDir = null!;

	[ClassInitialize]
	public static void ClassInitialize(TestContext context)
	{
		_solutionDir = context.TestRunDirectory is { } ts
			               ? new DirectoryInfo(ts).FindParentDirectoryContaining("*.sln")!
			               : null!;

		_solutionDir
			.Should()
			.NotBeNull($"Could not find the solution directory while searching up from: {context.TestRunDirectory}");

		_allCSharpFilesUnderSolutionDir =
			_solutionDir.EnumerateFiles("*.cs", SearchOption.AllDirectories)
			            .Where(file => !file.Name.EndsWith(".g.cs")
			                           && !file.FullName.EndsWith("\\Cql\\Model\\modelinfo.cs")) // exclude code generated files
			;
		;
	}

	[TestMethod]
	public void Files_ShouldNotHaveLinesTrailingWhitespace()
	{
		var issues = _allCSharpFilesUnderSolutionDir
		             .SelectMany(file => LocalExtensions.IncludeOrdinal(LocalExtensions.ReadLines(file), 1)
		                                                .Where(t => LocalExtensions.HasTrailingWhitespace(t.value))
		                                                .Select(t => (filePath:file.FullName[_solutionDir.FullName.Length..], lineNum:t.ordinal, line:t.value)))
		             .ToList();

		Assert.IsFalse(
			issues.Any(),
			$"The following files have lines with trailing whitespace:\n{string.Join("\n",
					issues.GroupBy(
						issue => issue.filePath,
						(filePath,items) => $"{filePath}\n{string.Join("\n", items.Select(t => $"   {t.lineNum:-5}:{t.line}<eol>"))}"))
			}");
	}
}

file static class LocalExtensions
{
	public static IEnumerable<(T value, int ordinal)> IncludeOrdinal<T>(this IEnumerable<T> source, int start = 0)
	{
		int i = start;
		foreach (var item in source)
		{
			yield return (item, i++);
		}
	}

	public static IEnumerable<string> ReadLines(this FileInfo fileInfo)
	{
		using var streamReader = fileInfo.OpenText();
		string? line;
		while ((line = streamReader.ReadLine()) != null)
		{
			yield return line;
		}
	}

	public static bool HasTrailingWhitespace(this string line) =>
		line.Length > 0 && char.IsWhiteSpace(line[^1]);

}