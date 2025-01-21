namespace CqlSdkPrototype.Runtime.Extensibility;

public readonly record struct RuntimeApiStateEntry(byte[] AssemblyBytes, byte[]? DebugSymbolsBytes = null);