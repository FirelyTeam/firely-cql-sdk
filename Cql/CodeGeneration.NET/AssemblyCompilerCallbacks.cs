using System;
using System.IO;

namespace Hl7.Cql.CodeGeneration.NET;

#pragma warning disable CS1591
internal class AssemblyCompilerCallbacks
{
    private readonly Action<(string name, Stream stream, bool isTuple)>? _onBeforeCompileStream;

    public AssemblyCompilerCallbacks(Action<(string name, Stream stream, bool isTuple)>? onBeforeCompileStream = null) => 
        _onBeforeCompileStream = onBeforeCompileStream;

    public void OnBeforeCompileStream(string name, Stream stream, bool isTuple) => 
        _onBeforeCompileStream?.Invoke((name, stream, isTuple));
}