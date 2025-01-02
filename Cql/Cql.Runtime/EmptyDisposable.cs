using System;

namespace Hl7.Cql.Runtime;

internal readonly record struct EmptyDisposable : IDisposable
{
    public void Dispose()
    {
    }
}