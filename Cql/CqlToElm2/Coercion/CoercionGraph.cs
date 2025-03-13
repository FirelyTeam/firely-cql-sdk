using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hl7.Cql.CqlToElm2.Coercion;

/// <summary>
/// Represents a graph of conversions between types.
/// </summary>
internal class CoercionGraph
{
    public CoercionGraph()
    {

        NullNode = new CoercionNode(NullTypeSymbol.Default);
        Nodes.Add(NullNode.Type, NullNode);
        Edges.Add(new SelfEdge(NullNode));
        Edges.Add(new FromNullEdge(NullNode, NullNode));
    }

    internal CoercionNode NullNode { get; }
    private Dictionary<TypeSymbol, CoercionNode> Nodes = new();
    private HashSet<CoercionEdge> Edges = new();
    private Dictionary<CoercionNode, Dictionary<CoercionNode, List<CoercionEdge>>> CoercionTable = new();


    /// <summary>
    /// Adds <paramref name="type"/> and its base types to the graph if any of them do not exist.
    /// </summary>
    internal CoercionNode AddType(TypeSymbol type)
    {
        if (Nodes.TryGetValue(type, out var node))
            return node;
        else
        {
            node = new CoercionNode(type);
            // add edge to itself; this may be unnecessary.
            Edges.Add(new SelfEdge(node));
            // add null conversion to itself
            Edges.Add(new FromNullEdge(NullNode, node));
            // add subtype conversion to its base type, if one exists
            if (node.Type.TypeDefinition.BaseType is not null)
            {
                var baseTypeSymbol = new TypeSymbol(node.Type.TypeDefinition.BaseType);
                var baseNode = AddType(baseTypeSymbol);
                Edges.Add(new SubtypeEdge(node, baseNode));
            }
            Nodes.Add(type, node);
            return node;
        }
    }

    internal void AddImplicitConversion(ConversionFunctionSymbol conversion)
    {
        var fromNode = AddType(conversion.From);
        var toNode = AddType(conversion.Type);
        var edge = new ImplicitConversionEdge(fromNode, toNode, conversion);
        if (!Edges.Contains(edge))
            Edges.Add(edge);
        else throw new ArgumentException($"Implciit conversion from {conversion.From} to {conversion.Type} is already defined.", nameof(conversion));
    }
    internal void AddExplicitConversion(ConversionFunctionSymbol conversion)
    {
        throw new NotImplementedException();
    }

    internal CoercionNode? GetNodeForType(TypeSymbol type)
    {
        if (Nodes.TryGetValue(type, out var node))
            return node;
        else
            return null;
    }

    public void ComputeCoercionPaths()
    {
        foreach (var node in Nodes.Values)
        {
            CoercionTable[node] = new Dictionary<CoercionNode, List<CoercionEdge>>();

            // Initialize direct edges from the graph's edges collection
            foreach (var edge in Edges)
            {
                if (!CoercionTable.TryGetValue(edge.From, out var from))
                {
                    from = new();
                    CoercionTable[edge.From] = from;
                }
                from[edge.To] = new List<CoercionEdge> { edge };
            }

            //// Ensure self-to-self paths are initialized (identity conversions)
            //CoercionTable[node][node] = new List<CoercionEdge>();
        }

        // Floyd-Warshall algorithm
        foreach (var via in Nodes.Values)
        {
            foreach (var from in Nodes.Values)
            {
                if (!CoercionTable[from].ContainsKey(via)) continue;

                foreach (var to in Nodes.Values)
                {
                    if (!CoercionTable[via].ContainsKey(to)) continue;

                    var newPath = new List<CoercionEdge>(CoercionTable[from][via]);
                    newPath.AddRange(CoercionTable[via][to]);

                    if (!CoercionTable[from].ContainsKey(to) ||
                        GetPathCost(newPath) < GetPathCost(CoercionTable[from][to]))
                    {
                        CoercionTable[from][to] = newPath;
                    }
                }
            }
        }
    }

    // Helper method to compute total cost of a path
    private int GetPathCost(List<CoercionEdge> path)
    {
        return path.Sum(edge => (int)edge.Cost);
    }

    public Expression? Coerce(Expression expression, TypeSymbol to)
    {
        var fromNode = GetNodeForType(expression.Type);
        var toNode = GetNodeForType(to);
        if (fromNode is null || toNode is null)
            return null; // No valid coercion path
        var path = coerce(fromNode, toNode);
        if (path is null)
            return null; // No valid coercion path
        var result = expression;
        foreach (var edge in path)
        {
            result = edge.Convert(result);
        }
        return result;

        IReadOnlyList<CoercionEdge>? coerce(CoercionNode from, CoercionNode to)
        {
            if (!CoercionTable.ContainsKey(from) || !CoercionTable[from].ContainsKey(to))
                return null; // No valid coercion path
            return CoercionTable[from][to].AsReadOnly();
        }
    }

    public MatchResult? GetBestSignature(Signature candidate, Signature[] overloads) =>
        GetBestSignature(GetCompatibleSignatures(candidate, overloads));

    public MatchResult? GetBestSignature(IList<MatchResult> matchResults)
    {
        if (matchResults.Count == 0)
            return null;
        var byCost = matchResults
            .GroupBy(match => match.Cost)
            .OrderBy(m => m.Key)
            .ToArray();
        if (byCost.Length == 0)
            return null;
        else {
            var byShortestPath = byCost[0]
                .GroupBy(match => match.Hops)
                .OrderBy(m => m.Key)
                .ToArray();
            if (byShortestPath.Length == 0)
                return null;
            else
            {
                var withLowestHops = byShortestPath[0].ToArray();
                return withLowestHops.Length switch
                {
                    1 => withLowestHops[0],
                    _ => null
                };
            }
        }
    }

    public MatchResult[] GetCompatibleSignatures(Signature candidate, Signature[] overloads)
    {
        overloads = explode().ToArray();

        var matches = new List<MatchResult>();

        foreach (var overload in overloads)
        {
            if (candidate.Operands.Count != overload.Operands.Count)
            {
                continue; // Skip overloads with a different number of parameters
            }

            var argumentConversions = new List<IReadOnlyList<CoercionEdge>>();
            int totalCost = 0;
            int totalHops = 0;

            for (int i = 0; i < candidate.Operands.Count; i++)
            {
                var fromNode = GetNodeForType(candidate.Operands[i]);
                var toNode = GetNodeForType(overload.Operands[i]);

                if (fromNode == null || toNode == null ||
                    !CoercionTable.TryGetValue(fromNode, out var targets) ||
                    !targets.TryGetValue(toNode, out var path))
                {
                    totalCost = int.MaxValue; // Incompatible coercion
                    break;
                }

                argumentConversions.Add(path);
                totalCost += path.Sum(e => (int)e.Cost);
                totalHops += path.Count;
            }

            if (totalCost >= (int)CoercionCost.Incompatible) continue; // Skip incompatible overloads

            matches.Add(new MatchResult(overload, argumentConversions));
        }

        return matches.ToArray();

        IEnumerable<Signature> explode()
        {
            foreach(var sig in overloads)
            {
                if (sig.IsGeneric)
                {
                    var substitutions = GenerateTypeSubstitutions(candidate, sig);
                    foreach(var binding in substitutions)
                    {
                        var boundSignature = BindSignature(sig, binding);
                        yield return boundSignature;
                    }
                }
                else yield return sig;
            }
        }

    }

    /// <summary>
    /// Merges the contents of <paramref name="other"/> into this graph.
    /// </summary>
    internal void Merge(CoercionGraph? other)
    {
        if (other is not null)
        {
            foreach (var node in other.Nodes)
                AddType(node.Key);
            foreach (var edge in other.Edges)
                if (!Edges.Contains(edge))
                    Edges.Add(edge);
        }
    }


    #region Generic inference


    internal static Dictionary<TypeSymbol, TypeSymbol>[] GenerateTypeSubstitutions(Signature candidate, Signature genericSignature)
    {
        if (candidate.Operands.Count != genericSignature.Operands.Count)
            throw new ArgumentException($"Signature and overload must have the same number of operands.");
        var subs = enumerate().ToArray();
        return subs;

        IEnumerable<Dictionary<TypeSymbol, TypeSymbol>> enumerate()
        {
            var typeParameters = new Dictionary<TypeSymbol, HashSet<TypeSymbol>>();

            for (int i = 0; i < candidate.Operands.Count; i++)
                MapGenericTypeParameters(candidate.Operands[i], genericSignature.Operands[i], typeParameters);

            var typeParamKeys = typeParameters.Keys.ToArray();

            var result = permute(typeParamKeys, typeParameters, 0, new Dictionary<TypeSymbol, TypeSymbol>())
                .ToArray();
            return result;

            IEnumerable<Dictionary<TypeSymbol, TypeSymbol>> permute(
                TypeSymbol[] keys,
                Dictionary<TypeSymbol, HashSet<TypeSymbol>> candidates,
                int index,
                Dictionary<TypeSymbol, TypeSymbol> current)
            {
                if (index == keys.Length)
                {
                    yield return new Dictionary<TypeSymbol, TypeSymbol>(current);
                    yield break;
                }

                var key = keys[index];
                foreach (var candidate in candidates[key])
                {
                    current[key] = candidate;
                    foreach (var result in permute(keys, candidates, index + 1, current))
                    {
                        yield return result;
                    }
                }
            }
        }

        void MapGenericTypeParameters(
            TypeSymbol fromType,
            TypeSymbol toType,
            Dictionary<TypeSymbol, HashSet<TypeSymbol>> typeParameters)
        {
            if (toType.TypeDefinition is GenericArgumentType)
            {
                if (!typeParameters.TryGetValue(toType, out var inferredTypes))
                {
                    inferredTypes = new HashSet<TypeSymbol>();
                    typeParameters[toType] = inferredTypes;
                }
                inferredTypes.Add(fromType);
            }
            else if (toType.TypeDefinition is GenericTypeDefinition toGeneric
                && fromType.TypeDefinition is GenericTypeDefinition fromGeneric)
            {
                if (toGeneric.Arguments.Count == fromGeneric.Arguments.Count)
                {
                    for (int i = 0; i < toGeneric.Arguments.Count; i++)
                    {
                        var fromSymbol = new TypeSymbol(fromGeneric.Arguments[i].GetTypeDefinition()
                            ?? throw new InvalidOperationException($"Cannot create TypeDefinition for {fromGeneric.Arguments[i]}"));
                        var toSymbol = new TypeSymbol(toGeneric.Arguments[i].GetTypeDefinition()
                            ?? throw new InvalidOperationException($"Cannot create TypeDefinition for {toGeneric.Arguments[i]}"));
                        MapGenericTypeParameters(fromSymbol, toSymbol, typeParameters);
                    }
                }
            }
        }
    }

    private TypeSymbol BindOperand(TypeSymbol type, Dictionary<TypeSymbol, TypeSymbol> binding)
    {
        // Check if the type is a generic argument
        if (type.TypeDefinition is GenericArgumentType genericArg)
        {
            if (binding.TryGetValue(type, out var mappedType))
                return mappedType; // Replace with mapped type
            else throw new ArgumentException($"Type {type} is a generic argument but is not mapped.");
        }

        // If it's a generic type definition, replace its type arguments
        if (type.TypeDefinition is GenericTypeDefinition genericType)
        {
            var bindings = new Dictionary<GenericArgumentSpecifier, TypeSpecifier>();
            foreach (var arg in genericType.Arguments)
            {
                var argSymbol = new TypeSymbol(arg.GetTypeDefinition()
                    ?? throw new InvalidOperationException($"Cannot create TypeDefinition for {arg}"));
                var replaced = BindOperand(argSymbol, binding);
            }
            var genericTypeDefinition = GenericTypeDefinition.Create(genericType, bindings);
            return new TypeSymbol(genericType);
        }
        return type;
    }

    private Signature BindSignature(Signature signature, Dictionary<TypeSymbol, TypeSymbol> binding)
    {
        var operands = new TypeSymbol[signature.Operands.Count];
        for (int i = 0; i < signature.Operands.Count; i++)
        {
            operands[i] = BindOperand(signature.Operands[i], binding);
        }
        return new Signature(operands);
    }


    #endregion
}
