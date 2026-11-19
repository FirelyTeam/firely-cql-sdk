/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Buffers;

namespace Hl7.Cql.Elm.Serialization;

/// <summary>
/// An <see cref="IBufferWriter{T}"/> over a buffer rented from <see cref="ArrayPool{T}.Shared"/>, which a
/// <see cref="Utf8JsonWriter"/> fills and the caller reads through <see cref="WrittenSpan"/> before disposing.
/// </summary>
internal sealed class PooledByteBufferWriter : IBufferWriter<byte>, IDisposable
{
    private byte[] _buffer;
    private int _written;

    internal PooledByteBufferWriter(int initialCapacity)
    {
        _buffer = ArrayPool<byte>.Shared.Rent(Math.Max(initialCapacity, 256));
    }

    internal ReadOnlySpan<byte> WrittenSpan => _buffer.AsSpan(0, _written);

    public void Advance(int count)
    {
        if ((uint)count > (uint)(_buffer.Length - _written))
            throw new ArgumentOutOfRangeException(nameof(count), count, "Cannot advance past the end of the buffer, or by a negative count.");

        _written += count;
    }

    public Memory<byte> GetMemory(int sizeHint = 0)
    {
        Grow(sizeHint);
        return _buffer.AsMemory(_written);
    }

    public Span<byte> GetSpan(int sizeHint = 0)
    {
        Grow(sizeHint);
        return _buffer.AsSpan(_written);
    }

    public void Dispose()
    {
        var buffer = _buffer;
        _buffer = [];
        _written = 0;
        if (buffer.Length > 0)
            ArrayPool<byte>.Shared.Return(buffer);
    }

    private void Grow(int sizeHint)
    {
        var needed = Math.Max(sizeHint, 1);
        if (_buffer.Length - _written >= needed)
            return;

        // Computed in long so neither the doubling nor the sum overflows; Array.MaxLength caps the result.
        var required = (long)_written + needed;
        if (required > Array.MaxLength)
            throw new OutOfMemoryException($"The buffer cannot grow to {required} bytes, past the maximum array length of {Array.MaxLength}.");

        var larger = ArrayPool<byte>.Shared.Rent((int)Math.Max(required, Math.Min((long)_buffer.Length * 2, Array.MaxLength)));
        _buffer.AsSpan(0, _written).CopyTo(larger);
        ArrayPool<byte>.Shared.Return(_buffer);
        _buffer = larger;
    }
}
