using System;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;

#pragma warning disable RS0037
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0016

namespace Hl7.Cql.Tuples;

public readonly record struct StructuralValueMetadata
{
    public StructuralValueMetadata(
        Type[] ItemTypes,
        string[] ItemNames)
    {
        this.ItemTypes = ItemTypes;
        this.ItemNames = ItemNames;
        Signature = string.Join("&", ItemTypes.Zip(ItemNames).Select(t => $"{t.Item1.ToCSharpString()} {t.Item2}"));
    }

    public Type[] ItemTypes { get; }

    public string[] ItemNames { get; }

    public string Signature { get; }

    public void Deconstruct(
        out Type[] itemTypes,
        out string[] itemNames,
        out string signature)
    {
        itemTypes = ItemTypes;
        itemNames = ItemNames;
        signature = Signature;
    }
    public override string ToString() => Signature;

    public bool Equals(StructuralValueMetadata? other) =>
        other is {} o &&
        Signature == o.Signature;
}