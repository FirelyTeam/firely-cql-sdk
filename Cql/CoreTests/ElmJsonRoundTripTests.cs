/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Hl7.Cql.Elm;

namespace CoreTests;

/// <summary>
/// Reads and writes every ELM JSON file kept in the repository. Serializing what was parsed, parsing that and
/// serializing again must give the same text: the serialized form is a fixed point of the reader and the writer.
/// </summary>
[TestClass]
public partial class ElmJsonRoundTripTests
{
    private static readonly string[] SearchedFolders = ["Cql/CoreTests/Input/ELM", "LibrarySets", "Demo", "Examples"];

    [GeneratedRegex(@"\A\uFEFF?\s*\{\s*""library""")]
    private static partial Regex LibraryDocumentStart();

    /// <summary>
    /// The path, relative to the repository root, of each distinct ELM library file in the searched folders.
    /// </summary>
    private static IEnumerable<object[]> ElmFiles => FindElmFiles().Select(path => new object[] { path });

    [TestMethod]
    [DynamicData(nameof(ElmFiles))]
    public void ParseAndSerialize_ReachesAFixedPoint(string relativePath)
    {
        var json = File.ReadAllText(Path.Combine(RepositoryRoot.FullName, relativePath));

        var once = Library.ParseFromJson(json).SerializeToJson(writeIndented: false);
        var twice = Library.ParseFromJson(once).SerializeToJson(writeIndented: false);

        // Compare by equality of the strings without letting a failure print megabytes of JSON.
        (once == twice).Should().BeTrue($"serializing the parsed output of {relativePath} again should not change it");
    }

    [TestMethod]
    public void ElmFiles_AreFound()
    {
        ElmFiles.Should().NotBeEmpty();
    }

    private static DirectoryInfo RepositoryRoot { get; } = FindRepositoryRoot();

    private static DirectoryInfo FindRepositoryRoot()
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir != null; dir = dir.Parent)
        {
            if (dir.EnumerateFiles("*.slnx").Any() || dir.EnumerateFiles("*.sln").Any())
                return dir;
        }

        throw new InvalidOperationException("Could not find a parent directory containing a solution file.");
    }

    private static List<string> FindElmFiles()
    {
        var root = RepositoryRoot;
        var seenContent = new HashSet<string>();
        var found = new List<string>();

        foreach (var folder in SearchedFolders)
        {
            var dir = Path.Combine(root.FullName, folder);
            if (!Directory.Exists(dir))
                continue;

            foreach (var file in Directory.EnumerateFiles(dir, "*.json", SearchOption.AllDirectories).Order(StringComparer.Ordinal))
            {
                var relative = Path.GetRelativePath(root.FullName, file).Replace('\\', '/');
                if (relative.Contains("/bin/") || relative.Contains("/obj/"))
                    continue;

                var bytes = File.ReadAllBytes(file);
                if (!LibraryDocumentStart().IsMatch(Encoding.UTF8.GetString(bytes, 0, Math.Min(bytes.Length, 256))))
                    continue;

                if (seenContent.Add(System.Convert.ToHexString(SHA256.HashData(bytes))))
                    found.Add(relative);
            }
        }

        return found;
    }
}
