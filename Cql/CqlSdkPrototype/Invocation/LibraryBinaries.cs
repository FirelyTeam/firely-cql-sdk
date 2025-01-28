namespace CqlSdkPrototype.Invocation;

public readonly record struct LibraryBinaries(byte[] AssemblyBytes, byte[]? DebugSymbolsBytes = null);