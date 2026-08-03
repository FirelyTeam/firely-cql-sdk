/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Buffers.Binary;
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
    /// Hashing is proportional to the total size of the assemblies, and the pool's intended hot path is
    /// one <see cref="LibrarySetInvokerPool.GetOrCreate"/> per subject over an unchanged toolkit - so
    /// without this every hit would re-run SHA-256 over multi-megabyte binaries just to discover it
    /// already had the answer. Memoizing turns a repeat call over the same set into a lookup.
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
    /// Debug symbols are deliberately part of the identity. Excluding them would let two entries
    /// with identical assemblies but different symbols share one pooled invoker, silently serving
    /// whichever symbols happened to be loaded first - observable in stack traces. Including them can
    /// only ever cost a redundant cache miss, which is the safe direction to err in, and hashing
    /// them costs microseconds against the price of loading an assembly.
    /// </remarks>
    private static string HashAssemblyBinary(AssemblyBinary assemblyBinary)
    {
        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        AppendLengthPrefixed(hash, assemblyBinary.AssemblyBytes);
        AppendLengthPrefixed(hash, assemblyBinary.DebugSymbolsBytes);
        return Convert.ToHexString(hash.GetHashAndReset());
    }

    /// <summary>
    /// Appends a length prefix and then the bytes, so that concatenation is unambiguous: without the
    /// prefix, <c>([1], [2, 3])</c> and <c>([1, 2], [3])</c> would hash identically. A
    /// <see langword="null"/> array is distinguished from an empty one by a length of -1.
    /// </summary>
    private static void AppendLengthPrefixed(IncrementalHash hash, byte[]? bytes)
    {
        Span<byte> lengthPrefix = stackalloc byte[sizeof(int)];
        BinaryPrimitives.WriteInt32LittleEndian(lengthPrefix, bytes?.Length ?? -1);
        hash.AppendData(lengthPrefix);

        if (bytes is { Length: > 0 })
            hash.AppendData(bytes);
    }
}
