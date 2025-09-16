/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Abstractions.Infrastructure;
using System.Xml.Linq;

namespace Hl7.Cql.Elm;

/// <summary>
/// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
/// </summary>
internal abstract class BaseElmTreeWalker
{
    public virtual void Start(object root)
    {
        if (_parents.Count > 0)
            throw new InvalidOperationException("Only one concurrent process allowed.");
        Walk(root, null!);
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

    private readonly List<(object node, string? path)> _parents = new();

    protected (object node, string? path)[] GetContextStack() => _parents.ToArray();

    public string ContextStackString => string.Join(
        "\n->",
        _parents
            .Select(t => t switch
            {
                ({} o, null) => $"{o}",
                ({} o, {} p) => $"{p}({o})",
            }));

    private void Walk(object? node, string? path)
    {
        if (node is null)
            return;

        if (!IsRelevant(node.GetType()))
            return;

        if (_parents.Any(kv => ReferenceEquals(kv.node, node)))
            throw new InvalidOperationException("Cycle in ELM graph detected.");

        _parents.Add((node, path!));
        try
        {
            if (Process(node))
                return;

            var propertyValues = node.GetType()
                                     .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                     .Where(p => p.CanRead && IsRelevant(p.PropertyType))
                                     .SelectWhere(property => property.GetValue(node) switch
                                     {
                                         { } value => (true, (name: property.Name, value)),
                                         null      => default,
                                     })
                ;

            foreach (var (name, value) in propertyValues)
            {
                switch (value)
                {
                    case string:
                    {
                        goto default;
                    }

                    case Array array:
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            var item = array.GetValue(i);
                            Walk(item, $"{name}[{i+1} of {array.Length}]");
                        }

                        break;
                    }

                    case IEnumerable:
                    {
                        throw new NotSupportedException();
                    }

                    default:
                    {
                        Walk(value, name);
                        break;
                    }
                }
            }

        }
        finally
        {
            _parents.RemoveAt(_parents.Count-1);
        }
    }
}