using System.Diagnostics;
using System.Runtime.CompilerServices;

#pragma warning disable RS0037
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0016

namespace Hl7.Cql.Tuples;

public interface IStructuralValue : ITuple
{
    StructuralValueMetadata GetMetadata();
}

public interface IStructuralValue<out T1> : IStructuralValue
{
    T1 Item1 { get; }
}

public interface IStructuralValue<out T1, out T2> : IStructuralValue<T1>
{
    T2 Item2 { get; }
}

public interface IStructuralValue<out T1, out T2, out T3> : IStructuralValue<T2>
{
    T3 Item3 { get; }
}