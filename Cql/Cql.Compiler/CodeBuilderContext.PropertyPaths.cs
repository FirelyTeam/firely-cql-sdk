/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Element = Hl7.Cql.Elm.Element;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Resolving a property path against what is known statically about its source: the .NET type
/// and, where that type erases a CQL choice, the alternatives of the choice. Emission
/// (<see cref="BindPropertyPath"/>) and type inference (<see cref="PropertyStaticValue"/>) share
/// one resolution, so the emitted access and the inferred type cannot drift apart.
/// </summary>
/// <remarks>
/// A choice value is represented as <see cref="object"/> (or, for a FHIR choice element, the
/// element's base data type), so its static type says nothing about the elements it has. The CQL
/// specification defines access to an element of a choice type as access on every alternative that
/// has the element, the result being the choice of the alternatives' element types - a single type
/// when they all agree. Where the alternatives are known, that rule is applied at compile time by
/// emitting one type test per alternative; only where they are not is the read late-bound.
/// </remarks>
partial class CodeBuilderContext
{
    /// <summary>
    /// The alternatives of a choice type, as far as they can be inspected for their elements.
    /// </summary>
    /// <param name="Inspectable">The alternatives that resolve to a .NET type, distinct, derived types before their bases.</param>
    /// <param name="HasUninspectable">
    /// Whether the choice has an alternative whose elements cannot be inspected: one that does not
    /// resolve to a type, or one that is itself a heterogeneous choice. Such an alternative may hold
    /// the element with any type, so a read must keep a late-bound branch for it.
    /// </param>
    private sealed record ChoiceAlternatives(IReadOnlyList<Type> Inspectable, bool HasUninspectable)
    {
        /// <summary>
        /// Builds the alternatives from resolved types; <see langword="null"/> or <see cref="object"/>
        /// marks an uninspectable alternative. Returns <see langword="null"/> when there are none at all.
        /// </summary>
        public static ChoiceAlternatives? From(IEnumerable<Type?> types)
        {
            var inspectable = new List<Type>();
            var hasUninspectable = false;
            foreach (var type in types)
            {
                if (type is null || type == typeof(object))
                    hasUninspectable = true;
                else if (!inspectable.Contains(type))
                    inspectable.Add(type);
            }

            if (inspectable.Count == 0 && !hasUninspectable)
                return null;

            // A type test for a derived alternative must come before the test for its base,
            // or the base would claim the value first.
            inspectable.Sort((a, b) => InheritanceDepth(b).CompareTo(InheritanceDepth(a)));
            return new ChoiceAlternatives(inspectable, hasUninspectable);
        }

        private static int InheritanceDepth(Type type)
        {
            var depth = 0;
            for (var t = type.BaseType; t is not null; t = t.BaseType)
                depth++;
            return depth;
        }
    }

    /// <summary>
    /// What is known statically about a value: its .NET type and, when that type erases a choice,
    /// the alternatives of the choice. For a list-typed value the alternatives are those of its
    /// elements: a list is never a choice itself, and a query alias names one of its elements.
    /// </summary>
    private readonly record struct StaticValue(Type Type, ChoiceAlternatives? Alternatives);

    /// <summary>
    /// What was learned about an ELM expression while translating it, keyed by the node. A
    /// property read records the alternatives its result holds, and a query records those of
    /// its elements, so an alias or a property over either can still dispatch when the ELM node
    /// itself carries no result type.
    /// </summary>
    private readonly Dictionary<Element, StaticValue> _staticValues = new(ReferenceEqualityComparer.Instance);

    /// <summary>Memo of <see cref="ModelledValueType"/>, by the .NET type of the primitive.</summary>
    private readonly Dictionary<Type, Type?> _modelledValueTypes = new();

    /// <summary>How one segment of a property path binds to the value before it.</summary>
    private enum SegmentBinding
    {
        /// <summary>The element is a member of the static type.</summary>
        Static,

        /// <summary>The value itself stands for the element (the type resolver's source-object rule).</summary>
        SourceObject,

        /// <summary>The static type erases a choice; the element is read per alternative that has it.</summary>
        Dispatch,

        /// <summary>Neither the static type nor any known alternative has the element; the read is late-bound.</summary>
        Unresolved,
    }

    /// <summary>The resolution of one path segment.</summary>
    /// <param name="Segment">The element name.</param>
    /// <param name="Binding">How the segment binds.</param>
    /// <param name="Branches">For <see cref="SegmentBinding.Dispatch"/>: each alternative that has the element, with the element and its type (see <see cref="ElementTypeOf"/>).</param>
    /// <param name="HasUninspectableAlternative">For <see cref="SegmentBinding.Dispatch"/>: whether an alternative could not be inspected, so a late-bound arm is needed.</param>
    /// <param name="Result">What is known statically about the value the segment produces.</param>
    private sealed record SegmentResolution(
        string Segment,
        SegmentBinding Binding,
        IReadOnlyList<(Type Alternative, PropertyInfo Member, Type ElementType)>? Branches,
        bool HasUninspectableAlternative,
        StaticValue Result);

    /// <summary>
    /// The type the CQL model gives a value of <paramref name="type"/>: a FHIR choice element is
    /// declared as its base data type, which the CQL model treats as a choice, i.e. <see cref="object"/>.
    /// </summary>
    private static Type CqlTypeOf(Type type) => type == typeof(DataType) ? typeof(object) : type;

    /// <summary>The alternatives a choice element can hold, per the model, or <see langword="null"/> for a non-choice element.</summary>
    private ChoiceAlternatives? ChoiceAlternativesOf(PropertyInfo member) =>
        _typeResolver.GetChoiceTypes(member) is { } types ? ChoiceAlternatives.From(types) : null;

    /// <summary>The alternatives an ELM type specifier declares, or <see langword="null"/> when it is not a choice.</summary>
    /// <param name="typeSpecifier">The ELM type specifier, if any.</param>
    /// <param name="unwrapList">Whether to look at the element type of a list; a query alias names one element of its list-typed source.</param>
    private ChoiceAlternatives? ChoiceAlternativesOf(TypeSpecifier? typeSpecifier, bool unwrapList)
    {
        if (unwrapList && typeSpecifier is ListTypeSpecifier list)
            typeSpecifier = list.elementType;

        if (typeSpecifier is not ChoiceTypeSpecifier { choice: { Length: > 0 } choices })
            return null;

        // A nested heterogeneous choice resolves to object, which From() records as uninspectable.
        return ChoiceAlternatives.From(choices.Select(choice => TypeFor(choice, throwIfNotFound: false)));
    }

    /// <summary>
    /// The types a member may hold, as alternatives: the choice it declares, else its own type
    /// (<paramref name="elementType"/>); an erased type without declared alternatives is uninspectable.
    /// </summary>
    private IEnumerable<Type?> AlternativesHeldBy(PropertyInfo member, Type elementType)
    {
        if (ChoiceAlternativesOf(member) is { } choice)
            return choice.Inspectable.Cast<Type?>().Concat(choice.HasUninspectable ? [null] : []);

        var type = CqlTypeOf(elementType);
        return [type == typeof(object) ? null : type];
    }

    /// <summary>
    /// The type of element <paramref name="segment"/> of <paramref name="type"/>, bound to
    /// <paramref name="member"/>: the member's type, except where the model declares the element as
    /// a type the member does not have. That is the case for the value of a primitive, which the model
    /// declares as a System type (<c>FHIR.instant.value</c> is a <c>System.DateTime</c>) and the .NET
    /// model may hold in a representation of its own (a <see cref="DateTimeOffset"/>). Reading the
    /// element then converts to the model's type, so the value means what the CQL model says it means
    /// wherever it is read, whether or not the ELM states the type it expects.
    /// </summary>
    private Type ElementTypeOf(Type type, string segment, PropertyInfo member)
    {
        if (segment != "value")
            return member.PropertyType;

        if (!_modelledValueTypes.TryGetValue(type, out var modelled))
            _modelledValueTypes[type] = modelled = ModelledValueType(type, member.PropertyType);

        return modelled ?? member.PropertyType;
    }

    /// <summary>
    /// The System type the model declares for the value of the primitive <paramref name="type"/>
    /// implements, when that differs from <paramref name="memberType"/> and a value of
    /// <paramref name="memberType"/> converts to it; otherwise <see langword="null"/>.
    /// </summary>
    private Type? ModelledValueType(Type type, Type memberType)
    {
        const string modelPrefix = "FHIR.";
        const string systemPrefix = "System.";

        for (var name = _typeResolver.GetModelTypeName(type);
             name is not null && ModelMapping.TryGetValue(name, out var classInfo);
             name = classInfo.baseType is { } baseType && baseType.StartsWith(modelPrefix, StringComparison.Ordinal)
                 ? $"{{http://hl7.org/fhir}}{baseType[modelPrefix.Length..]}"
                 : null)
        {
            if (classInfo.element?.FirstOrDefault(element => element.name == "value") is not { } valueElement)
                continue;

            // A complex type's value (Quantity.value) is an element of a model type, bound as such.
            if (valueElement.elementType is not { } elementType || !elementType.StartsWith(systemPrefix, StringComparison.Ordinal))
                return null;

            var systemType = _typeResolver.ResolveType($"{{urn:hl7-org:elm-types:r1}}{elementType[systemPrefix.Length..]}", throwError: false);
            return systemType is not null
                   && systemType != memberType
                   && _cqlOperatorsBinder.TryConvert(new CodeLocal(memberType), systemType, out _)
                ? systemType
                : null;
        }

        return null;
    }

    /// <summary>What is known statically about the value of an ELM expression.</summary>
    private StaticValue? StaticValueFor(Expression expression, bool throwIfNotFound)
    {
        if (_staticValues.TryGetValue(expression, out var known))
            return known;

        switch (expression)
        {
            case AliasRef { name: { } alias } when !string.IsNullOrWhiteSpace(alias):
                return ScopeStaticValue(alias);

            case OperandRef { name: { } name } operandRef when _operands?.TryGetValue(name, out var operand) == true:
            {
                var typeSpecifier = operandRef.resultTypeSpecifier
                                    ?? (_operandTypeSpecifiers.TryGetValue(name, out var declared) ? declared : null);
                return new StaticValue(operand.Type, ChoiceAlternativesOf(typeSpecifier, unwrapList: false));
            }

            case Property { resultTypeSpecifier: null, resultTypeName: null } property when !string.IsNullOrWhiteSpace(property.path):
                return PropertyStaticValue(property, throwIfNotFound);

            // An unqualified identifier in a sort clause names an element of the implied alias
            // (see IdentifierRef(IdentifierRef)).
            case IdentifierRef { name: { } name, resultTypeSpecifier: null, resultTypeName: null } when !string.IsNullOrWhiteSpace(name) && ImpliedAlias is { } impliedAlias:
                return PropertyStaticValue(new Property { path = name, scope = impliedAlias }, throwIfNotFound);
        }

        var type = TypeFor(expression, throwIfNotFound);
        return type is null
            ? null
            : new StaticValue(type, ChoiceAlternativesOf(expression.GetTypeSpecifier(), unwrapList: _typeResolver.IsListType(type)));
    }

    /// <summary>
    /// What is known statically about a query alias: its .NET type, and the alternatives of the
    /// expression it ranges over. The scope stores the source expression for a single-source
    /// query, the aliased source for a multi-source one, the bound expression for a <c>let</c>,
    /// and the relationship clause for a <c>with</c>.
    /// </summary>
    private StaticValue ScopeStaticValue(string alias)
    {
        var (expression, element) = GetScope(alias);
        // A RelationshipClause (with/without) is an AliasedQuerySource too.
        Expression? sourceExpression = element switch
        {
            AliasedQuerySource source => source.expression,
            Expression e => e,
            _ => null,
        };

        var alternatives = (sourceExpression is not null ? StaticValueFor(sourceExpression, throwIfNotFound: false)?.Alternatives : null)
                           ?? ChoiceAlternativesOf(sourceExpression?.GetTypeSpecifier() ?? element.GetTypeSpecifier(), unwrapList: !_typeResolver.IsListType(expression.Type));

        return new StaticValue(expression.Type, alternatives);
    }

    /// <summary>
    /// What is known statically about a <see cref="Property"/> that carries no result type of its
    /// own, by resolving its path against its source.
    /// </summary>
    private StaticValue? PropertyStaticValue(Property property, bool throwIfNotFound)
    {
        StaticValue? source = property.source is { } sourceExpression
            ? StaticValueFor(sourceExpression, throwIfNotFound)
            : !string.IsNullOrWhiteSpace(property.scope)
                ? ScopeStaticValue(property.scope)
                : null;

        if (source is not { } sourceValue)
            return null;

        return ResolvePath(sourceValue, SegmentsOf(sourceValue.Type, property.path)).Result;
    }

    /// <summary>
    /// Splits a path into its segments. The path is tried as one element name first, because a
    /// quoted CQL identifier may itself contain a dot.
    /// </summary>
    private string[] SegmentsOf(Type sourceType, string path) =>
        _typeResolver.GetProperty(sourceType, path) != null ? [path] : path.Split('.');

    /// <summary>
    /// Resolves <paramref name="segments"/> against <paramref name="source"/>, one segment at a
    /// time. Resolution stops at the first segment that cannot be resolved; the segments after it
    /// are late-bound.
    /// </summary>
    private (IReadOnlyList<SegmentResolution> Resolutions, StaticValue Result) ResolvePath(StaticValue source, string[] segments)
    {
        var resolutions = new List<SegmentResolution>(segments.Length);
        var current = source;
        foreach (var segment in segments)
        {
            var resolution = ResolveSegment(current, segment);
            resolutions.Add(resolution);
            current = resolution.Result;
            if (resolution.Binding == SegmentBinding.Unresolved)
                break;
        }

        return (resolutions, current);
    }

    /// <summary>
    /// Resolves one segment: as a member of the static type first, then through the choice's
    /// alternatives when the static type erases a choice.
    /// </summary>
    private SegmentResolution ResolveSegment(StaticValue value, string segment)
    {
        if (_typeResolver.GetProperty(value.Type, segment) is { } member)
            return new SegmentResolution(segment, SegmentBinding.Static, null, false,
                new StaticValue(ElementTypeOf(value.Type, segment, member), ChoiceAlternativesOf(member)));

        if (_typeResolver.ShouldUseSourceObject(value.Type, segment))
            return new SegmentResolution(segment, SegmentBinding.SourceObject, null, false,
                new StaticValue(value.Type, null));

        if (value.Alternatives is not { } alternatives)
            return new SegmentResolution(segment, SegmentBinding.Unresolved, null, false,
                new StaticValue(typeof(object), null));

        var branches = new List<(Type Alternative, PropertyInfo Member, Type ElementType)>();
        foreach (var alternative in alternatives.Inspectable)
        {
            if (_typeResolver.GetProperty(alternative, segment) is { } branchMember)
                branches.Add((alternative, branchMember, ElementTypeOf(alternative, segment, branchMember)));
        }

        // The spec's sum type: one type when every alternative that has the element agrees, else a
        // choice of their types, represented as object. An uninspectable alternative is late-bound
        // to the agreed type, so it does not widen the result.
        var branchTypes = branches.Select(branch => CqlTypeOf(branch.ElementType)).Distinct().ToList();
        var resultType = branchTypes.Count == 1 ? branchTypes[0] : typeof(object);
        var resultAlternatives = resultType == typeof(object)
            ? ChoiceAlternatives.From(
                branches.SelectMany(branch => AlternativesHeldBy(branch.Member, branch.ElementType))
                        .Concat(alternatives.HasUninspectable ? [null] : []))
            : null;

        return new SegmentResolution(segment, SegmentBinding.Dispatch, branches, alternatives.HasUninspectable,
            new StaticValue(resultType, resultAlternatives));
    }

    /// <summary>
    /// Binds a property path off <paramref name="source"/>, one segment at a time: a member of the
    /// static type binds directly, an element of a choice is read per alternative that has it
    /// (<see cref="BindChoiceSegment"/>), and from the first segment that resolves neither way the
    /// remainder is late-bound one segment per call, so no late-bound call ever carries a dotted name.
    /// </summary>
    /// <param name="source">The value the first segment is read from.</param>
    /// <param name="sourceValue">What is known statically about <paramref name="source"/>; its type must be <paramref name="source"/>'s.</param>
    /// <param name="path">The path, possibly qualified.</param>
    /// <param name="expectedType">The type the value of the last segment is converted to, or <see langword="null"/> to use the resolved type.</param>
    /// <param name="element">The ELM property element being bound, for diagnostics.</param>
    private CodeExpression BindPropertyPath(
        CodeExpression source,
        StaticValue sourceValue,
        string path,
        Type? expectedType,
        Element element)
    {
        var segments = SegmentsOf(source.Type, path);
        var (resolutions, result) = ResolvePath(sourceValue, segments);
        expectedType ??= CqlTypeOf(result.Type);

        var current = source;
        for (var i = 0; i < resolutions.Count; i++)
        {
            var resolution = resolutions[i];
            if (resolution.Binding == SegmentBinding.Unresolved)
            {
                current = LateBoundPropertyChain(current, segments, i, expectedType, element);
                _staticValues[element] = new StaticValue(current.Type, null);
                return current;
            }

            var isLast = i == segments.Length - 1;
            var target = isLast ? expectedType : resolution.Result.Type;
            current = resolution.Binding == SegmentBinding.Dispatch
                ? BindChoiceSegment(current, resolution, target, element)
                : PropertyHelper(current, resolution.Segment, target);
        }

        _staticValues[element] = new StaticValue(current.Type, result.Alternatives);
        return current;
    }

    /// <summary>
    /// Reads an element off a choice value: a dispatch on the value's type with one arm per
    /// alternative that has the element, each reading it off the value narrowed to that alternative
    /// and converting to <paramref name="target"/>; <see langword="null"/> when the value is none of
    /// them, or a late-bound read when the choice has an alternative that could not be inspected.
    /// </summary>
    private CodeExpression BindChoiceSegment(
        CodeExpression source,
        SegmentResolution resolution,
        Type target,
        Element element)
    {
        // Every arm, including the null one, must be assignable to the target.
        if (target.IsValueType && Nullable.GetUnderlyingType(target) is null)
            target = target.MakeNullable();

        var arms = new List<CodeTypeSwitchArm>();
        foreach (var (alternative, _, elementType) in resolution.Branches!)
        {
            var narrowed = new CodeLocal(Nullable.GetUnderlyingType(alternative) ?? alternative, isNotNull: true);

            // Read the element as its own type first, then convert to the target. When no
            // conversion exists (the ELM types the element differently from the model, e.g. a
            // profile that constrains a list element to a single value), the arm falls back
            // to the late-bound read, which converts at run time or yields null, rather than
            // failing the build.
            var read = PropertyHelper(narrowed, resolution.Segment, elementType);
            var converted = ChangeType(read, target, out var conversion, throwOnError: false);
            if (conversion == TypeConversion.NoMatch)
            {
                _logger.LogWarning(
                    FormatMessage(
                        $"Element {resolution.Segment} of {alternative.Name} is a {read.Type.Name} but the expression expects a {target.Name}; the read on this alternative is late-bound.",
                        element));
                converted = LateBoundProperty(narrowed, resolution.Segment, target, element);
            }

            arms.Add(new CodeTypeSwitchArm(narrowed, converted));
        }

        if (resolution.HasUninspectableAlternative)
        {
            // Any other value may be the uninspectable alternative: read the element late-bound.
            // As the last arm it only sees values no typed arm claimed.
            if (arms.Count == 0)
                return LateBoundProperty(source, resolution.Segment, target, element);

            var other = new CodeLocal(typeof(object), isNotNull: true);
            arms.Add(new CodeTypeSwitchArm(other, LateBoundProperty(other, resolution.Segment, target, element)));
        }
        else if (arms.Count == 0)
        {
            _logger.LogWarning(
                FormatMessage($"No alternative of the choice type of the source has an element {resolution.Segment}; the property evaluates to null.", element));
            return new CodeConstant(null, target);
        }

        return new CodeTypeSwitch(source, arms, new CodeConstant(null, target), target);
    }

    /// <summary>
    /// Late-binds <paramref name="segments"/> from index <paramref name="start"/> onwards, one
    /// <see cref="ICqlOperators.LateBoundProperty{T}"/> call per segment. Intermediate segments are
    /// read as <see cref="object"/>; only the last is converted to <paramref name="expectedType"/>.
    /// </summary>
    private CodeExpression LateBoundPropertyChain(
        CodeExpression source,
        string[] segments,
        int start,
        Type expectedType,
        Element? element)
    {
        var current = source;
        for (var i = start; i < segments.Length; i++)
        {
            var isLast = i == segments.Length - 1;
            current = LateBoundProperty(current, segments[i], isLast ? expectedType : typeof(object), element);
        }

        return current;
    }

    /// <summary>
    /// Emits a late-bound read of <paramref name="path"/> off <paramref name="source"/>: the
    /// fallback when neither the static type of the source nor the alternatives of its choice type
    /// resolve the element at compile time.
    /// </summary>
    private CodeExpression LateBoundProperty(
        CodeExpression source,
        string path,
        Type expectedType,
        Element? element)
    {
        _logger.LogWarning(
            FormatMessage(
                $"Property {path} can't be known at design time and will be late-bound, which is slower and leaves the property's type and cardinality unchecked.  Consider casting the source first so that this property can be definitely bound.",
                element));

        return BindCqlOperator(nameof(ICqlOperators.LateBoundProperty), source, new CodeConstant(path, typeof(string)),
                               new CodeConstant(expectedType, typeof(Type)));
    }
}
