/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

#nullable enable

namespace Hl7.Cql.Invocation.Toolkit.Internal;

/// <summary>
/// Identifies a pooled <see cref="LibrarySetInvoker"/> by everything that determines its observable
/// behaviour: the content of the assembly binaries it was built from, the library set name, and the
/// batch-process exception continuation policy.
/// </summary>
/// <remarks>
/// The content hash exists because <see cref="AssemblyBinary"/> cannot be used as a cache key
/// directly. It is a positional record over <see cref="byte"/> arrays, so its synthesized equality
/// falls through to <see cref="EqualityComparer{T}.Default"/> for <see cref="byte"/>[], which is
/// reference identity rather than content equality. Two logically identical inputs therefore never
/// compare equal - and the convenience path via
/// <c>ElmToolkitInvocationExtensions.CreateInvocationToolkit</c> allocates fresh arrays on every
/// call. Rather than change <see cref="AssemblyBinary"/>'s shipped public equality, the content
/// identity is derived here, at the cache boundary.
/// </remarks>
internal readonly record struct LibrarySetInvokerPoolKey(
    string ContentHash,
    string LibrarySetName,
    BatchProcessExceptionContinuation Continuation)
{
    /// <summary>
    /// Content hashes already computed, keyed on the identity of the set they were computed from.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Hashing costs time proportional to the total size of the assemblies, and the pool is built to be
    /// called over and over for the same library set, so without memoizing every hit would re-run
    /// SHA-256 over multi-megabyte binaries just to discover it already had the answer.
    /// </para>
    /// <para>
    /// This table is the short-circuit for a consumer that reuses one toolkit: it turns the whole
    /// derivation into a single lookup. It deliberately is <em>not</em> the only memo, because a consumer
    /// that builds a fresh toolkit per call would never hit it - see <see cref="ArrayHashes"/>, which
    /// covers that case.
    /// </para>
    /// <para>
    /// Keying on reference identity is sound because the set is immutable and replaced wholesale:
    /// <c>InvocationToolkit.AddAssemblyBinaries</c> builds a new immutable set and swaps the field, so a
    /// given instance's content never changes. A <see cref="ConditionalWeakTable{TKey,TValue}"/> rather
    /// than a dictionary so that a set the consumer has dropped does not stay alive - and its entry
    /// leak - for the life of the process.
    /// </para>
    /// </remarks>
    private static readonly ConditionalWeakTable<AssemblyBinaryReadOnlyHashSet, string> ContentHashes = new();

    /// <summary>
    /// Derives a key from the inputs <see cref="InvocationToolkit.CreateLibrarySetInvoker(string)"/> would use.
    /// </summary>
    public static LibrarySetInvokerPoolKey Create(
        AssemblyBinaryReadOnlyHashSet assemblyBinaries,
        string librarySetName,
        BatchProcessExceptionContinuation continuation) =>
        new(GetOrComputeContentHash(assemblyBinaries), librarySetName, continuation);

    /// <summary>
    /// Returns the memoized content hash for this set instance, computing it on first use.
    /// </summary>
    /// <remarks>
    /// Under contention <see cref="ConditionalWeakTable{TKey,TValue}.GetValue"/> may run the factory
    /// more than once and keep one result. That is harmless here: hashing is pure, so every racing
    /// caller computes the same string.
    /// </remarks>
    private static string GetOrComputeContentHash(AssemblyBinaryReadOnlyHashSet assemblyBinaries) =>
        ContentHashes.GetValue(assemblyBinaries, static set => ComputeContentHash(set));

    /// <summary>
    /// Hashes each assembly binary on its own, then hashes the <em>sorted</em> per-binary hashes.
    /// </summary>
    /// <remarks>
    /// Sorting is what makes the result order-independent, which it must be because the input is a
    /// set with no meaningful order. Combining with XOR instead would collide on permutations and on
    /// duplicated entries, so the hashes are sorted and concatenated.
    /// </remarks>
    private static string ComputeContentHash(AssemblyBinaryReadOnlyHashSet assemblyBinaries)
    {
        var perBinaryHashes = new List<string>();
        foreach (var assemblyBinary in assemblyBinaries)
            perBinaryHashes.Add(HashAssemblyBinary(assemblyBinary));

        perBinaryHashes.Sort(StringComparer.Ordinal);

        return Convert.ToHexString(
            SHA256.HashData(Encoding.UTF8.GetBytes(string.Join('\n', perBinaryHashes))));
    }

    /// <summary>
    /// Hashes one binary's assembly bytes and debug symbol bytes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Debug symbols are deliberately part of the identity. Excluding them would let two entries
    /// with identical assemblies but different symbols share one pooled invoker, silently serving
    /// whichever symbols happened to be loaded first - observable in stack traces. Including them can
    /// only ever cost a redundant cache miss, which is the safe direction to err in.
    /// </para>
    /// <para>
    /// The two arrays are hashed separately and their hashes combined, rather than hashed together as
    /// one stream, so that <see cref="ArrayHashes"/> can memoize each array on its own. Combining is
    /// unambiguous without length prefixes because every component is either fixed-length hex or the
    /// <see cref="AbsentArray"/> marker, and neither can contain the separator.
    /// </para>
    /// </remarks>
    private static string HashAssemblyBinary(AssemblyBinary assemblyBinary) =>
        $"{HashArray(assemblyBinary.AssemblyBytes)}:{HashArray(assemblyBinary.DebugSymbolsBytes)}";

    /// <summary>
    /// Hashes already computed for individual byte arrays, keyed on array identity.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This is the memo that matters for the pool's real hot path. A consumer evaluating one library set
    /// per subject typically builds a fresh <see cref="InvocationToolkit"/> per call - so
    /// <see cref="ContentHashes"/>, keyed on the set instance, never gets a hit - while the underlying
    /// <see cref="byte"/> arrays come from a per-run artifact cache and are the same objects every time.
    /// Keying on the arrays therefore collapses ~10,000 full hash passes over multi-megabyte assemblies
    /// into one pass per distinct array, leaving each later call to hash only a handful of hex strings.
    /// </para>
    /// <para>
    /// Sound for the same reason the pool's whole design is: the binaries are treated as immutable once
    /// handed to a toolkit, so the same array always has the same content. Weak keys so that arrays the
    /// consumer has dropped do not stay alive, and are not themselves a leak.
    /// </para>
    /// </remarks>
    private static readonly ConditionalWeakTable<byte[], string> ArrayHashes = new();

    /// <summary>
    /// Stands in for a <see langword="null"/> array, so that absent debug symbols are distinguished from
    /// present-but-empty ones (which hash to the SHA-256 of zero bytes, a real 64-character hex string).
    /// </summary>
    private const string AbsentArray = "absent";

    /// <summary>
    /// Returns the memoized SHA-256 of one array, computing it on first use.
    /// </summary>
    private static string HashArray(byte[]? bytes) =>
        bytes is null
            ? AbsentArray
            : ArrayHashes.GetValue(bytes, static array => Convert.ToHexString(SHA256.HashData(array)));
}
