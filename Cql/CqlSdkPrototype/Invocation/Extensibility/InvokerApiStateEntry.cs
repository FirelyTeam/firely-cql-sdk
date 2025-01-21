namespace CqlSdkPrototype.Invocation.Extensibility;

public readonly record struct InvokerApiStateEntry(byte[] AssemblyBytes, byte[]? DebugSymbolsBytes = null);