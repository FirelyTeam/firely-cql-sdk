using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ReflectionUtility
{
    public static ConstructorInfo? ConstructorOf<T>(Expression<Func<T>> fnToCtor)
        => fnToCtor.Body is NewExpression ne
            ? ne.Constructor
            : null;
}