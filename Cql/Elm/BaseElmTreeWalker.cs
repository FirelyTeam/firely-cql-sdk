/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Elm;

/// <summary>
/// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
/// </summary>
internal abstract class BaseElmTreeWalker
{
    public virtual void Start(object root)
    {
        _visited = [];
        Walk(root);
    }

    /// <summary>
    /// Determine whether a node of a given type should be walked into.
    /// </summary>
    protected virtual bool IsRelevant(Type nodeType)
    {
        if (nodeType.IsAssignableTo(typeof(Element)) || nodeType.Assembly == typeof(Element).Assembly)
        {
            return true;
        }
        else if (nodeType.IsArray)
        {
            var elementType = nodeType.GetElementType()!;
            return IsRelevant(elementType);
        }

        return false;
    }

    /// <summary>
    /// Process a node that we have walked into.
    /// </summary>
    protected abstract bool Process(object node);

    private Stack<object> _visited = new();

    private void Walk(object? node)
    {
        if (node is null)
            return;

        if(!IsRelevant(node.GetType()))
            return;

        if (_visited.Any(i => ReferenceEquals(i, node)))
            throw new InvalidOperationException("Cycle in ELM graph detected.");

        if (Process(node))
            return;

        var propertyTuples = node.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                 .Where(p => p.CanRead && IsRelevant(p.PropertyType))
                                 .Select(p => (p, p.GetValue(node)))
                                 .Where(v => v.Item2 is not null);

        try
        {
            _visited.Push(node);

            foreach (var tuple in propertyTuples)
            {
                var propValue = tuple.Item2;
                if (propValue is IEnumerable enumerable)
                {
                    foreach (var item in enumerable)
                        Walk(item);
                }
                else
                {
                    Walk(propValue!);
                }
            }
        }
        finally
        {
            _visited.Pop();
        }
    }
}