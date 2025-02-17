using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm;
internal class LiteralTypes
{

    /// <summary>
    /// Resolves literal types named by <see cref="CqlToElmOptions.LiteralTypeNames"/> and caches them.
    /// </summary>
    /// <param name="options">Options which control the literal type names to use during parsing.</param>
    /// <param name="provider">The model provider used to resolve the named types to type definitions.</param>
    /// <param name="model">If specified, all literal types will be resolved from only this model.</param>
    /// <exception cref="InvalidOperationException">If any of the types cannot be resolved.</exception>
    public LiteralTypes(CqlToElmOptions options, Model.IModelProvider provider, Model.ModelDefinition? model = null)
    {
        Provider = provider;

        if (model is not null)
        {
            Model.TypeDefinition? type;
            if (model.TryGetType(options.LiteralTypeNames.Default, out type))
                AnyType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Default} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Boolean, out type))
                BooleanType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Boolean} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Code, out type))
                CodeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Code} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.CodeSystem, out type))
                CodeSystemType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.CodeSystem} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Concept, out type))
                ConceptType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Concept} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Date, out type))
                DateType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Date} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.DateTime, out type))
                DateTimeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.DateTime} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Decimal, out type))
                DecimalType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Decimal} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Integer, out type))
                IntegerType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Integer} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Interval, out type) && type is Model.GenericTypeDefinition itd)
                IntervalTemplate = itd;
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Interval} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.List, out type) && type is Model.GenericTypeDefinition ltd)
                ListTemplate = itd;
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.List} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Long, out type))
                LongType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Long} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Quantity, out type))
                QuantityType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Quantity} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.Ratio, out type))
                RatioType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Ratio} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.String, out type))
                StringType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.String, out type))
                TimeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
            if (model.TryGetType(options.LiteralTypeNames.ValueSet, out type))
                ValueSetType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
        }
        else
        {
            Model.TypeDefinition? type;
            if (provider.TryGetType(options.LiteralTypeNames.Default, out type))
                AnyType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Default} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Boolean, out type))
                BooleanType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Boolean} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Code, out type))
                CodeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Code} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.CodeSystem, out type))
                CodeSystemType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.CodeSystem} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Concept, out type))
                ConceptType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Concept} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Date, out type))
                DateType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Date} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.DateTime, out type))
                DateTimeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.DateTime} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Decimal, out type))
                DecimalType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Decimal} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Integer, out type))
                IntegerType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Integer} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Interval, out type) && type is Model.GenericTypeDefinition itd)
                IntervalTemplate = itd;
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Interval} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.List, out type) && type is Model.GenericTypeDefinition ltd)
                ListTemplate = itd;
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.List} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Long, out type))
                LongType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Long} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Quantity, out type))
                QuantityType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Quantity} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.Ratio, out type))
                RatioType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Ratio} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.String, out type))
                StringType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.String, out type))
                TimeType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
            if (provider.TryGetType(options.LiteralTypeNames.ValueSet, out type))
                ValueSetType = TypeHelpers.ToElmSpecifier(type.ToTypeSpecifier());
            else throw new InvalidOperationException($"Literal type {options.LiteralTypeNames.Time} could not be resolved.");
        }
    }

    public Model.IModelProvider Provider { get; }

    public TypeSpecifier AnyType { get; }
    public TypeSpecifier BooleanType { get; }
    public TypeSpecifier CodeType { get; }
    public TypeSpecifier CodeSystemType { get; }
    public TypeSpecifier ConceptType { get; }
    public TypeSpecifier DateType { get; }
    public TypeSpecifier DateTimeType { get; }
    public TypeSpecifier DecimalType { get; }
    public TypeSpecifier IntegerType { get; }
    public Model.GenericTypeDefinition IntervalTemplate { get; }
    public Model.GenericTypeDefinition ListTemplate { get; }
    public TypeSpecifier LongType { get; }
    public TypeSpecifier QuantityType { get; }
    public TypeSpecifier RatioType { get; }
    public TypeSpecifier StringType { get; }
    public TypeSpecifier TimeType { get; }
    public TypeSpecifier ValueSetType { get; }

    public IEnumerable<TypeSpecifier> NumericTypes
    {
        get
        {
            yield return IntegerType;
            yield return LongType;
            yield return DecimalType;
            yield return QuantityType;
        }
    }
    public IEnumerable<TypeSpecifier> OrderedTypes
    {
        get
        {
            yield return IntegerType;
            yield return LongType;
            yield return DecimalType;
            yield return QuantityType;
            yield return DateType;
            yield return TimeType;
            yield return DateTimeType;
            yield return StringType;
        }
    }

    /// <summary>
    /// The types that are valid interval point types, which can be both used in comparison expressions and for which have predecessor and successor operators defined.
    /// </summary>
    internal IEnumerable<TypeSpecifier> IntervalPointTypes
    {
        get
        {
            yield return IntegerType;
            yield return LongType;
            yield return DecimalType;
            yield return QuantityType;
            yield return DateType;
            yield return TimeType;
            yield return DateTimeType;
        }
    }

    public TypeSpecifier ToListType(TypeSpecifier elementType) =>
       ListTemplate.MakeGenericType(elementType.ToModelSpecifier(Provider)).ToTypeSpecifier().ToElmSpecifier();

    public TypeSpecifier ToIntervalType(TypeSpecifier pointType) =>
        IntervalTemplate.MakeGenericType(pointType.ToModelSpecifier(Provider)).ToTypeSpecifier().ToElmSpecifier();

}
