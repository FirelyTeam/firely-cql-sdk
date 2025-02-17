// * Copyright (c) 2023, NCQA and contributors
// * See the file CONTRIBUTORS for details.
// * 
// * This file is licensed under the BSD 3-Clause license
// * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
// */


using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.Extensions.DependencyInjection;
using System;
using Hl7.Cql.Elm;
using Hl7.Cql.Model.ModelProviders;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml;

namespace Hl7.Cql.CqlToElm.System
{
    /// <summary>
    /// ELM System version 1.0.0
    /// </summary>
    internal class System100 : Library, ISymbolScope
    {
        public static string? Version => "1.0.0.";

        public System100(CqlToElmOptions options, Model.IModelProvider modelProvider)
        {

            identifier = new VersionedIdentifier() { id = options.SystemElmModelUri, version = options.SystemElmModelVersion };

            var fields = typeof(System100)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(field => typeof(IDefinitionElement).IsAssignableFrom(field.FieldType));
            foreach (var field in fields)
            {
                var value = field.GetValue(null) as IDefinitionElement;
#if DEBUG
                if (value is null)
                    throw new InvalidOperationException();
#endif
                symbols.Add(value!.Name, value);
            }


            Options = options;
            ModelProvider = modelProvider;
            Operators = new(this);
            Invokers = new(this);

            if (!ModelProvider.TryGetModel(options.SystemElmModelUri!, options.SystemElmModelVersion, out var model))
                throw new InvalidOperationException($"Model {options.SystemElmModelUri} version {options.SystemElmModelVersion} could not be resolved.");
            else Model = model;

            SystemTypes = new LiteralTypes(options, modelProvider, model);
        }
        private readonly Dictionary<string, IDefinitionElement> symbols = new();

        public CqlToElmOptions Options { get; }
        public Model.IModelProvider ModelProvider { get; }
        public Model.ModelDefinition Model { get; }
        public SystemOperators Operators { get; }
        internal Invokers Invokers { get; }
        internal LiteralTypes SystemTypes { get; }
        public string Name => "System";


        public TypeSpecifier AnyType => SystemTypes.AnyType;
        public TypeSpecifier BooleanType => SystemTypes.BooleanType;
        public TypeSpecifier CodeType => SystemTypes.CodeType;
        public TypeSpecifier CodeSystemType => SystemTypes.CodeSystemType;
        public TypeSpecifier ConceptType => SystemTypes.ConceptType;
        public TypeSpecifier DateType => SystemTypes.DateType;
        public TypeSpecifier DateTimeType => SystemTypes.DateTimeType;
        public TypeSpecifier DecimalType => SystemTypes.DecimalType;
        public TypeSpecifier IntegerType => SystemTypes.IntegerType;
        public Model.GenericTypeDefinition IntervalTemplate => SystemTypes.IntervalTemplate;
        public Model.GenericTypeDefinition ListTemplate => SystemTypes.ListTemplate;
        public TypeSpecifier LongType => SystemTypes.LongType;
        public TypeSpecifier QuantityType => SystemTypes.QuantityType;
        public TypeSpecifier RatioType => SystemTypes.RatioType;
        public TypeSpecifier StringType => SystemTypes.StringType;
        public TypeSpecifier TimeType => SystemTypes.TimeType;
        public TypeSpecifier ValueSetType => SystemTypes.ValueSetType;

        public IEnumerable<TypeSpecifier> NumericTypes => SystemTypes.NumericTypes;
        public IEnumerable<TypeSpecifier> IntervalPointTypes => SystemTypes.IntervalPointTypes;
        public IEnumerable<TypeSpecifier> OrderedTypes => SystemTypes.OrderedTypes;




        public ISymbolScope? Parent => null;

        public void Dispose() { } // do nothing

        public bool TryAdd(IDefinitionElement symbol) => throw new NotSupportedException($"Symbols cannot be added to the System scope.");

        public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol) =>
            symbols.TryGetValue(identifier, out symbol);

        public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
        {
            if (symbols.TryGetValue(identifier, out var local) && local is IFunctionElement function)
            {
                symbol = function;
                return true;
            }
            symbol = null;
            return false;
        }

        public bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
        {
            // there are no fluent functions in the system library
            symbol = null;
            return false;
        }

        public bool TryResolveType(string identifier, [NotNullWhen(true)] out TypeDef? type)
        {
            if (TryResolveSymbol(identifier, out var symbol) && symbol is TypeDef td)
            {
                type = td;
                return true;
            }
            type = null;
            return false;
        }

        public bool TryResolveContextDefinition(string identifier, [NotNullWhen(true)] out ContextDefinitionSymbol? context)
        {
            context = null;
            return false;
        }

        public ISymbolScope EnterScope(string name) => throw new NotSupportedException($"You cannot enter a scope from the System scope.");

        public IEnumerator<IDefinitionElement> GetEnumerator() => symbols.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<ReferencedLibrary> ReferencedLibraries => Enumerable.Empty<ReferencedLibrary>();
        public IEnumerable<UsingDefSymbol> ReferencedModels => Enumerable.Empty<UsingDefSymbol>();

        // Note: generic T does not match List<T> or Interval<T>.
        // For functions that could take a T, a List<T>, or an Interval<T> and need to know what T is (e.g., because the function returns the same type as a parameter),
        // you need to create an OverloadedFunctionDef that accepts all 3 variants.
        // If you don't need T for anything other than parameter matching, you can use Any, which should match Lists and Intervals.

        // Alphabetized

        public class SystemOperators(System100 System)
        {
            public OverloadedFunctionDef Abs = unary<Abs>(T, T).For(T, System.NumericTypes.ToArray());
            public OverloadedFunctionDef Add = binary<Add>(T, T, T).For(T, [System.IntegerType, System.LongType, System.DecimalType, System.QuantityType])
                .Combine(binary<Add>(T, System.QuantityType, T).For(T, System.DateType, System.TimeType, System.TimeType))
                .Combine(binary<Concatenate>(System.StringType, System.StringType, System.StringType, "Add"));

            public SystemFunction<CalculateAge> AgeInYears = nullary<CalculateAge>(System.IntegerType, "AgeInYears")
                .InvokeWith(System.Invokers.AgeInYears);
            public SystemFunction<CalculateAge> AgeInMonths = nullary<CalculateAge>(System.IntegerType, "AgeInMonths")
                .InvokeWith(System.Invokers.AgeInMonths);
            public SystemFunction<CalculateAge> AgeInWeeks = nullary<CalculateAge>(System.IntegerType, "AgeInWeeks")
                .InvokeWith(System.Invokers.AgeInWeeks);
            public SystemFunction<CalculateAge> AgeInDays = nullary<CalculateAge>(System.IntegerType, "AgeInDays")
                .InvokeWith(System.Invokers.AgeInDays);
            public SystemFunction<CalculateAge> AgeInHours = nullary<CalculateAge>(System.IntegerType, "AgeInHours")
                .InvokeWith(System.Invokers.AgeInHours);
            public SystemFunction<CalculateAge> AgeInMinutes = nullary<CalculateAge>(System.IntegerType, "AgeInMinutes")
                .InvokeWith(System.Invokers.AgeInMinutes);
            public SystemFunction<CalculateAge> AgeInSeconds = nullary<CalculateAge>(System.IntegerType, "AgeInSeconds")
                .InvokeWith(System.Invokers.AgeInSeconds);

            public OverloadedFunctionDef AgeInYearsAt = unary<CalculateAgeAt>(T, System.IntegerType, "AgeInYearsAt")
                .InvokeWith(System.Invokers.AgeInYearsAt)
                .For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef AgeInMonthsAt = unary<CalculateAgeAt>(T, System.IntegerType, "AgeInMonthsAt")
                .InvokeWith(System.Invokers.AgeInMonthsAt)
                .For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef AgeInWeeksAt = unary<CalculateAgeAt>(T, System.IntegerType, "AgeInWeeksAt")
                .InvokeWith(System.Invokers.AgeInWeeksAt)
                .For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef AgeInDaysAt = unary<CalculateAgeAt>(T, System.IntegerType, "AgeInDaysAt")
                .InvokeWith(System.Invokers.AgeInDaysAt)
                .For(T, System.DateType, System.TimeType);
            public SystemFunction<CalculateAgeAt> AgeInHoursAt = binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "AgeInHoursAt")
                .InvokeWith(System.Invokers.AgeInHoursAt);
            public SystemFunction<CalculateAgeAt> AgeInMinutesAt = binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "AgeInMinutesAt")
                .InvokeWith(System.Invokers.AgeInMinutesAt);
            public SystemFunction<CalculateAgeAt> AgeInSecondsAt = binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "AgeInSecondsAt")
                .InvokeWith(System.Invokers.AgeInSecondsAt);

            public SystemFunction<AllTrue> AllTrue => aggregate<AllTrue>(System.BooleanType, System.BooleanType);
            public SystemFunction<And> And => binary<And>(System.BooleanType, System.BooleanType, System.BooleanType);
            public SystemFunction<AnyTrue> AnyTrue => aggregate<AnyTrue>(System.BooleanType, System.BooleanType);
            public OverloadedFunctionDef AnyInValueSet => binary<AnyInValueSet>(T, System.ValueSetType, System.BooleanType).For(T, System.StringType.ToListType(System), System.CodeType.ToListType(System), System.ConceptType.ToListType(System));
            public OverloadedFunctionDef Avg => aggregate<Avg>(T, T).For(T, System.DecimalType, System.QuantityType);
            public OverloadedFunctionDef Between => nary<Between>([T, T, T], 3, System.BooleanType).For(T, System.OrderedTypes.ToArray());

            public OverloadedFunctionDef CalculateAgeInYears => unary<CalculateAge>(T, System.IntegerType, "CalculateAgeInYears").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInMonths => unary<CalculateAge>(T, System.IntegerType, "CalculateAgeInMonths").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInWeeks => unary<CalculateAge>(T, System.IntegerType, "CalculateAgeInWeeks").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInDays => unary<CalculateAge>(T, System.IntegerType, "CalculateAgeInDays").For(T, System.DateType, System.TimeType);
            public SystemFunction<CalculateAge> CalculateAgeInHours => unary<CalculateAge>(System.TimeType, System.IntegerType, "CalculateAgeInHours");
            public SystemFunction<CalculateAge> CalculateAgeInMinutes => unary<CalculateAge>(System.TimeType, System.IntegerType, "CalculateAgeInMinutes");
            public SystemFunction<CalculateAge> CalculateAgeInSeconds => unary<CalculateAge>(System.TimeType, System.IntegerType, "CalculateAgeInSeconds");

            public OverloadedFunctionDef CalculateAgeInYearsAt => binary<CalculateAgeAt>(T, T, System.IntegerType, "CalculateAgeInYearsAt").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInMonthsAt => binary<CalculateAgeAt>(T, T, System.IntegerType, "CalculateAgeInMonthsAt").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInWeeksAt => binary<CalculateAgeAt>(T, T, System.IntegerType, "CalculateAgeInWeeksAt").For(T, System.DateType, System.TimeType);
            public OverloadedFunctionDef CalculateAgeInDaysAt => binary<CalculateAgeAt>(T, T, System.IntegerType, "CalculateAgeInDaysAt").For(T, System.DateType, System.TimeType);
            public SystemFunction<CalculateAgeAt> CalculateAgeInHoursAt => binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "CalculateAgeInHoursAt");
            public SystemFunction<CalculateAgeAt> CalculateAgeInMinutesAt => binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "CalculateAgeInMinutesAt");
            public SystemFunction<CalculateAgeAt> CalculateAgeInSecondsAt => binary<CalculateAgeAt>(System.TimeType, System.TimeType, System.IntegerType, "CalculateAgeInSecondsAt");

            public SystemFunction<Case> Case => new SystemFunction<Case>([System.BooleanType, T, T], T);
            public SystemFunction<Ceiling> Ceiling => unary<Ceiling>(System.DecimalType, System.IntegerType);
            public OverloadedFunctionDef Coalesce => nary<Coalesce>([T, T, T, T, T], 2, T).Combine(unary<Coalesce>(T.ToListType(System), T));
            public OverloadedFunctionDef Collapse => unary<Collapse>(T.ToIntervalType(System).ToListType(System), T.ToIntervalType(System).ToListType(System))
                    .For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType)
                    .Combine(binary<Collapse>(T.ToIntervalType(System).ToListType(System), System.QuantityType, T.ToIntervalType(System).ToListType(System))
                        .For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType));
            public SystemFunction<Combine> Combine => nary<Combine>([System.StringType.ToListType(System), System.StringType], 1, System.StringType);
            public SystemFunction<Concatenate> Concatenate => binary<Concatenate>(System.StringType, System.StringType, System.StringType);
            public OverloadedFunctionDef Contains => OverloadedFunctionDef.Create(binary<Contains>(T.ToListType(System), T, System.BooleanType), binary<Contains>(T.ToIntervalType(System), T, System.BooleanType));
            public SystemFunction<Count> Count => aggregate<Count>(T, System.IntegerType);
            public SystemFunction<Date> Date => nary<Date>(System.IntegerType, 3, 1, System.DateType);
            public SystemFunction<DateFrom> DateFrom => unary<DateFrom>(System.TimeType, System.DateType);
            public SystemFunction<Elm.DateTime> DateTime => nary<Elm.DateTime>([System.IntegerType, System.IntegerType, System.IntegerType, System.IntegerType, System.IntegerType, System.IntegerType, System.IntegerType, System.DecimalType], 1, System.TimeType);
            public SystemFunction<Descendents> Descendants => unary<Descendents>(System.AnyType, System.AnyType, "descendents").MakeFluent(); // this is always called like <any>.descendents()
            public OverloadedFunctionDef DifferenceBetween => binaryWithPrecision<DifferenceBetween>(T, T, System.IntegerType)
                .ValidateWith(db => Validators.Validate(db, System))
                .For(T, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<Distinct> Distinct => unary<Distinct>(T.ToListType(System), T.ToListType(System));
            public OverloadedFunctionDef Divide => binary<Divide>(T, T, T).For(T, System.DecimalType, System.QuantityType);
            public OverloadedFunctionDef DurationBetween => binaryWithPrecision<DurationBetween>(T, T, System.IntegerType)
                .ValidateWith(db => Validators.Validate(db, System))
                .For(T, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<End> End => unary<End>(T.ToIntervalType(System), T);
            public SystemFunction<Ends> Ends => binaryWithPrecision<Ends>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType);
            public SystemFunction<EndsWith> EndsWith => binary<EndsWith>(System.StringType, System.StringType, System.BooleanType);
            public OverloadedFunctionDef Equal => binary<Equal>(T, T, System.BooleanType).WithListAndIntervalVariants(T, System);
            public OverloadedFunctionDef Equivalent => binary<Equivalent>(T, T, System.BooleanType).WithListAndIntervalVariants(T, System);
            public OverloadedFunctionDef Except => binary<Except>(T.ToIntervalType(System), T.ToIntervalType(System), T.ToIntervalType(System)).For(T, System.IntervalPointTypes.ToArray())
                .Combine(binary<Except>(T.ToListType(System), T.ToListType(System), T.ToListType(System)));
            public SystemFunction<Exists> Exists => unary<Exists>(T.ToListType(System), System.BooleanType);
            public SystemFunction<Exp> Exp => unary<Exp>(System.DecimalType, System.DecimalType);
            public OverloadedFunctionDef Expand => OverloadedFunctionDef.Create(
                binary<Expand>(T.ToIntervalType(System).ToListType(System), System.QuantityType, T.ToIntervalType(System).ToListType(System))
                    .For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType),
                binary<Expand>(T.ToIntervalType(System), System.QuantityType, T.ToListType(System))
                    .For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType));
            public SystemFunction<First> First => unary<First>(T.ToListType(System), T);
            public SystemFunction<Flatten> Flatten => unary<Flatten>(T.ToListType(System).ToListType(System), T.ToListType(System),
                invoker: System.Invokers.Flatten);
            public SystemFunction<Floor> Floor => unary<Floor>(System.DecimalType, System.IntegerType);
            public OverloadedFunctionDef HighBoundary => binary<HighBoundary>(T, System.IntegerType, T).For(T, System.DecimalType, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<Implies> Implies => binary<Implies>(System.BooleanType, System.BooleanType, System.BooleanType);
            public OverloadedFunctionDef In => binaryWithPrecision<In>(T, T.ToIntervalType(System), System.BooleanType).For(T, System.OrderedTypes.ToArray())
                .Combine(binary<In>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType).For(T, System.IntervalPointTypes.ToArray()))
                .Combine(binary<In>(T, T.ToListType(System), System.BooleanType));
            public OverloadedFunctionDef IncludedIn => OverloadedFunctionDef.Create(binary<IncludedIn>(T.ToListType(System), T.ToListType(System), System.BooleanType), binaryWithPrecision<IncludedIn>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public OverloadedFunctionDef Includes => OverloadedFunctionDef.Create(
                binary<Contains>(T.ToListType(System), T, System.BooleanType, nameof(Elm.Includes)),
                binary<Includes>(T.ToListType(System), T.ToListType(System), System.BooleanType),
                binaryWithPrecision<Contains>(T.ToIntervalType(System), T, System.BooleanType, nameof(Elm.Includes)),
                binaryWithPrecision<Includes>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public SystemFunction<Indexer> Indexer => binary<Indexer>(System.StringType, System.IntegerType, System.StringType);
            public SystemFunction<IndexOf> IndexOf => binary<IndexOf>(T.ToListType(System), T, System.IntegerType);
            public SystemFunction<ToLong> IntegerToLong => unary<ToLong>(System.IntegerType, System.LongType);
            public OverloadedFunctionDef Intersect => binary<Intersect>(T.ToIntervalType(System), T.ToIntervalType(System), T.ToIntervalType(System)).For(T, System.IntervalPointTypes.ToArray())
                .Combine(binary<Intersect>(T.ToListType(System), T.ToListType(System), T.ToListType(System)));
            public OverloadedFunctionDef Interval => nary<Interval>([T, T, System.BooleanType, System.BooleanType,], 4, T.ToIntervalType(System))
                .For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType);
            public OverloadedFunctionDef InValueSet => binary<InValueSet>(T, System.ValueSetType, System.BooleanType).For(T, System.StringType, System.CodeType, System.ConceptType);
            public SystemFunction<IsFalse> IsFalse => unary<IsFalse>(System.BooleanType, System.BooleanType);
            public SystemFunction<IsNull> IsNull => unary<IsNull>(System.AnyType, System.BooleanType);
            public SystemFunction<IsTrue> IsTrue => unary<IsTrue>(System.BooleanType, System.BooleanType);
            public OverloadedFunctionDef Greater => binary<Greater>(T, T, System.BooleanType).For(T, System.OrderedTypes.ToArray());
            public OverloadedFunctionDef GreaterOrEqual => binary<GreaterOrEqual>(T, T, System.BooleanType).For(T, System.OrderedTypes.ToArray());
            public SystemFunction<Last> Last => unary<Last>(T.ToListType(System), T);
            public SystemFunction<LastPositionOf> LastPositionOf => binary<LastPositionOf>(System.StringType, System.StringType, System.IntegerType);
            public OverloadedFunctionDef Length => unary<Length>(T.ToListType(System), System.IntegerType)
                .Combine(unary<Length>(System.StringType, System.IntegerType));
            public OverloadedFunctionDef Less => binary<Less>(T, T, System.BooleanType).For(T, System.OrderedTypes.ToArray());
            public OverloadedFunctionDef LessOrEqual => binary<LessOrEqual>(T, T, System.BooleanType).For(T, System.OrderedTypes.ToArray());
            public SystemFunction<Ln> Ln => unary<Ln>(System.DecimalType, System.DecimalType);
            public SystemFunction<Log> Log => binary<Log>(System.DecimalType, System.DecimalType, System.DecimalType);
            public SystemFunction<Lower> Lower => unary<Lower>(System.StringType, System.StringType);
            public OverloadedFunctionDef LowBoundary => binary<LowBoundary>(T, System.IntegerType, T).For(T, System.DecimalType, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<Matches> Matches => binary<Matches>(System.StringType, System.StringType, System.BooleanType);
            public OverloadedFunctionDef Max => aggregate<Max>(T, T).For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType, System.StringType);
            public SystemFunction<MaxValue> MaxValue => nullary<MaxValue>(T);
            public OverloadedFunctionDef Median => aggregate<Median>(T, T).For(T, System.DecimalType, System.QuantityType);
            public OverloadedFunctionDef Message => nary<Message>([T, System.BooleanType, System.StringType, System.StringType, System.StringType], 5, T)
                .Combine(
                    nary<Message>([T.ToListType(System), System.BooleanType, System.StringType, System.StringType, System.StringType], 5, T.ToListType(System)),
                    nary<Message>([T.ToIntervalType(System), System.BooleanType, System.StringType, System.StringType, System.StringType], 5, T.ToIntervalType(System)));
            public OverloadedFunctionDef Min => aggregate<Min>(T, T).For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.DateType, System.TimeType, System.TimeType, System.StringType);
            public SystemFunction<MinValue> MinValue => nullary<MinValue>(T);
            public SystemFunction<Mode> Mode => aggregate<Mode>(T, T);
            public OverloadedFunctionDef Modulo => binary<Modulo>(T, T, T).For(T, System.NumericTypes.ToArray());
            public OverloadedFunctionDef Multiply => binary<Multiply>(T, T, T).For(T, System.NumericTypes.ToArray());
            public SystemFunction<Not> Not => unary<Not>(System.BooleanType, System.BooleanType);
            public SystemFunction<Now> Now => nullary<Now>(System.TimeType);
            public OverloadedFunctionDef NotEqual => binary<NotEqual>(T, T, System.BooleanType).WithListAndIntervalVariants(T, System);
            public SystemFunction<Or> Or => binary<Or>(System.BooleanType, System.BooleanType, System.BooleanType);
            public SystemFunction<Overlaps> Overlaps => binaryWithPrecision<Overlaps>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType);
            public SystemFunction<OverlapsAfter> OverlapsAfter => binaryWithPrecision<OverlapsAfter>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType);
            public SystemFunction<OverlapsBefore> OverlapsBefore => binaryWithPrecision<OverlapsBefore>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType);
            public SystemFunction<PointFrom> PointFrom => unary<PointFrom>(T.ToIntervalType(System), T);
            public OverloadedFunctionDef PopulationStdDev => aggregate<PopulationStdDev>(T, T).For(T, System.DecimalType, System.QuantityType);
            public OverloadedFunctionDef PopulationVariance => aggregate<PopulationVariance>(T, T).For(T, System.DecimalType, System.QuantityType);
            public SystemFunction<PositionOf> PositionOf => binary<PositionOf>(System.StringType, System.StringType, System.IntegerType);
            public OverloadedFunctionDef Power => binary<Power>(T, T, T).For(T, System.IntegerType, System.LongType, System.DecimalType);
            public OverloadedFunctionDef Precision => unary<Precision>(T, System.IntegerType).For(T, System.DecimalType, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<Predecessor> Predecessor => unary<Predecessor>(T, T);
            public OverloadedFunctionDef Product => aggregate<Product>(T, T).For(T, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType);
            public OverloadedFunctionDef ProperBetween => nary<ProperBetween>([T, T, T], 3, System.BooleanType).For(T, System.OrderedTypes.ToArray());
            public OverloadedFunctionDef ProperIn => OverloadedFunctionDef.Create(binaryWithPrecision<ProperIn>(T, T.ToIntervalType(System), System.BooleanType), binaryWithPrecision<ProperIn>(T, T.ToListType(System), System.BooleanType));
            public OverloadedFunctionDef ProperIncludedIn => OverloadedFunctionDef.Create(binary<ProperIncludedIn>(T.ToListType(System), T.ToListType(System), System.BooleanType), binaryWithPrecision<ProperIncludedIn>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public OverloadedFunctionDef ProperIncludes => OverloadedFunctionDef.Create(
                binary<ProperContains>(T.ToListType(System), T, System.BooleanType, nameof(Elm.ProperIncludes)),
                binary<ProperIncludes>(T.ToListType(System), T.ToListType(System), System.BooleanType),
                binaryWithPrecision<ProperContains>(T.ToIntervalType(System), T, System.BooleanType, nameof(Elm.ProperIncludes)),
                binaryWithPrecision<ProperIncludes>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public SystemFunction<ReplaceMatches> ReplaceMatches => nary<ReplaceMatches>([System.StringType, System.StringType, System.StringType], 3, System.StringType);
            public SystemFunction<Round> Round => nary<Round>([System.DecimalType, System.IntegerType], 1, System.DecimalType);
            public OverloadedFunctionDef Same => binaryWithPrecision<SameAs>(T, T, System.BooleanType).For(T, System.DateType, System.TimeType, System.TimeType)
                .Combine(binaryWithPrecision<SameAs>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public OverloadedFunctionDef SameOrAfter => binaryWithPrecision<SameOrAfter>(T, T, System.BooleanType).For(T, System.DateType, System.TimeType, System.TimeType)
                .Combine(binaryWithPrecision<SameOrAfter>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public OverloadedFunctionDef SameOrBefore => binaryWithPrecision<SameOrBefore>(T, T, System.BooleanType).For(T, System.DateType, System.TimeType, System.TimeType)
                .Combine(binaryWithPrecision<SameOrBefore>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType));
            public SystemFunction<SingletonFrom> SingletonFrom => unary<SingletonFrom>(T.ToListType(System), T);
            public SystemFunction<Slice> Skip => binary<Slice>(T.ToListType(System), System.IntegerType, T.ToListType(System), "Skip");
            public SystemFunction<Split> Split => binary<Split>(System.StringType, System.StringType, System.StringType.ToListType(System));
            public SystemFunction<Start> Start => unary<Start>(T.ToIntervalType(System), T);
            public SystemFunction<Starts> Starts => binaryWithPrecision<Starts>(T.ToIntervalType(System), T.ToIntervalType(System), System.BooleanType);

            public SystemFunction<StartsWith> StartsWith => binary<StartsWith>(System.StringType, System.StringType, System.BooleanType);
            public OverloadedFunctionDef StdDev => aggregate<StdDev>(T, T).For(T, System.DecimalType, System.QuantityType);
            public SystemFunction<Substring> Substring => nary<Substring>([System.StringType, System.IntegerType, System.IntegerType], 2, System.StringType);
            public OverloadedFunctionDef Subtract => binary<Subtract>(T, T, T).For(T, System.NumericTypes.ToArray()).Combine(binary<Subtract>(T, System.QuantityType, T).For(T, System.DateType, System.TimeType, System.TimeType));
            public SystemFunction<Successor> Successor => unary<Successor>(T, T);
            public OverloadedFunctionDef Sum => aggregate<Sum>(T, T).For(T, System.NumericTypes.ToArray());
            public SystemFunction<Slice> Take => binary<Slice>(T.ToListType(System), System.IntegerType, T.ToListType(System), "Take");
            public SystemFunction<Slice> Tail => unary<Slice>(T.ToListType(System), T.ToListType(System), "Tail");
            public SystemFunction<Time> Time => nary<Time>(System.IntegerType, 4, 1, System.TimeType);
            public OverloadedFunctionDef TimeComponent => unaryWithPrecision<DateTimeComponentFrom>(T, System.IntegerType)
                .ValidateWith((dtc) => Validators.Validate(dtc, System))
                .For(T, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<TimeFrom> TimeFrom => unary<TimeFrom>(System.TimeType, System.TimeType);
            public SystemFunction<TimezoneOffsetFrom> TimezoneOffsetFrom => unary<TimezoneOffsetFrom>(System.TimeType, System.DecimalType);
            public SystemFunction<TimeOfDay> TimeOfDay => nullary<TimeOfDay>(System.TimeType);
            public OverloadedFunctionDef ToBoolean => unary<ToBoolean>(T, System.BooleanType).For(T, System.IntegerType, System.LongType, System.DecimalType, System.StringType);
            public OverloadedFunctionDef ToConcept => unary<ToConcept>(T, System.ConceptType).For(T, System.CodeType, System.CodeType.ToListType(System));
            public OverloadedFunctionDef ToDateTime => unary<ToDateTime>(T, System.TimeType).For(T, System.DateType, System.StringType);
            public OverloadedFunctionDef ToDecimal => unary<ToDecimal>(T, System.DecimalType).For(T, System.BooleanType, System.StringType);
            public OverloadedFunctionDef ToInteger => unary<ToInteger>(T, System.IntegerType).For(T, System.BooleanType, System.StringType, System.LongType);
            public SystemFunction<Today> Today => nullary<Today>(System.DateType);
            public SystemFunction<ToList> ToList => unary<ToList>(T, T.ToListType(System));
            public OverloadedFunctionDef ToQuantity => unary<ToQuantity>(T, System.QuantityType).For(T, System.DecimalType, System.IntegerType, System.RatioType, System.StringType);
            public OverloadedFunctionDef ToStringFunction => unary<ToString>(T, System.StringType).For(T, System.BooleanType, System.IntegerType, System.LongType, System.DecimalType, System.QuantityType, System.RatioType, System.DateType, System.TimeType, System.TimeType);
            public SystemFunction<ToTime> ToTime => unary<ToTime>(System.StringType, System.TimeType);
            public SystemFunction<Truncate> Truncate => unary<Truncate>(System.DecimalType, System.IntegerType);
            public OverloadedFunctionDef TruncatedDivide => binary<TruncatedDivide>(T, T, T).For(T, System.NumericTypes.ToArray());
            public OverloadedFunctionDef Union => binary<Union>(T.ToIntervalType(System), T.ToIntervalType(System), T.ToIntervalType(System)).For(T, System.IntervalPointTypes.ToArray())
                .Combine(binary<Union>(T.ToListType(System), T.ToListType(System), T.ToListType(System)));
            public SystemFunction<Upper> Upper => unary<Upper>(System.StringType, System.StringType);
            public OverloadedFunctionDef Variance => aggregate<Variance>(T, T).For(T, System.DecimalType, System.QuantityType);
            public SystemFunction<Width> Width => unary<Width>(T.ToIntervalType(System), T);
            public SystemFunction<Xor> Xor => binary<Xor>(System.BooleanType, System.BooleanType, System.BooleanType);

            private static SystemFunction<T> nullary<T>(TypeSpecifier result, string? name = null) where T : Expression =>
                new(EmptyOperands, result, name ?? typeof(T).Name);
            private static SystemFunction<T> unary<T>(TypeSpecifier argument, TypeSpecifier result, string? name = null,
                Func<InvocationBuilder, Expression[], Expression>? invoker = null) where T : Expression =>
                new([argument], result, name ?? typeof(T).Name, invoker: invoker);
            private SystemFunction<T> unaryWithPrecision<T>(TypeSpecifier argument, TypeSpecifier result, string? name = null) where T : Expression =>
                new([argument, System.StringType], result, name ?? typeof(T).Name, 1);
            private static SystemFunction<T> binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result, string? name = null) where T : Expression =>
                new([first, second], result, name ?? typeof(T).Name);
            private SystemFunction<T> binaryWithPrecision<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result, string? name = null) where T : Expression =>
                new([first, second, System.StringType,], result, name ?? typeof(T).Name, 2);
            private static SystemFunction<T> nary<T>(TypeSpecifier[] operands, int requiredParameterCount, TypeSpecifier result, string? name = null) where T : Expression =>
                new(operands, result, name ?? typeof(T).Name, requiredParameterCount);
            private static SystemFunction<T> nary<T>(TypeSpecifier operandType, int operandCount, int requiredParameterCount, TypeSpecifier result) where T : Expression =>
                new(Enumerable.Range(0, operandCount).Select(i => operandType).ToArray(), result, typeof(T).Name, requiredParameterCount);
            private SystemFunction<T> aggregate<T>(TypeSpecifier source, TypeSpecifier result) where T : AggregateExpression =>
                new([source.ToListType(System)], result, typeof(T).Name);

            public static readonly TypeSpecifier[] EmptyOperands = global::System.Array.Empty<TypeSpecifier>();

            private readonly static ParameterTypeSpecifier T = new ParameterTypeSpecifier { parameterName = nameof(T) };


        }
    }

    internal class Invokers(System100 System)
    {
        private static readonly NamedTypeSpecifier FhirPatientType = new NamedTypeSpecifier
        {
            name = new XmlQualifiedName("{http://hl7.org/fhir}Patient"),
            resultTypeName = new XmlQualifiedName("{http://hl7.org/fhir}Patient")
        };
        private static readonly NamedTypeSpecifier FhirDateType = new NamedTypeSpecifier
        {
            name = new XmlQualifiedName("{http://hl7.org/fhir}date"),
            resultTypeName = new XmlQualifiedName("{http://hl7.org/fhir}date")
        };
        private static readonly NamedTypeSpecifier FhirDateTimeType = new NamedTypeSpecifier
        {
            name = new XmlQualifiedName("{http://hl7.org/fhir}dateTime"),
            resultTypeName = new XmlQualifiedName("{http://hl7.org/fhir}dateTime")
        };
        private static readonly Property PatientBirthDate = new Property
        {
            path = "birthDate",
            source = new ExpressionRef { name = "Patient" }.WithResultType(FhirPatientType)
        }.WithResultType(FhirDateType);

        private readonly ToDateTime PatientBirthDateTime = new ToDateTime
        {
            operand = PatientBirthDate,
        }.WithResultType(System.DateTimeType);

        private Expression BirthDateExpressionFor(Expression arg) =>
            arg.resultTypeSpecifier == System.DateTimeType || arg.resultTypeSpecifier == FhirDateTimeType
                ? PatientBirthDateTime
                : PatientBirthDate;

        public Expression AgeInYearsAt(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInYearsAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInMonthsAt(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInMonthsAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInDaysAt(InvocationBuilder builder, Expression[] args) =>
             builder.Invoke(System.Operators.CalculateAgeInDaysAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInWeeksAt(InvocationBuilder builder, Expression[] args) =>
             builder.Invoke(System.Operators.CalculateAgeInWeeksAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInHoursAt(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInHoursAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInMinutesAt(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInMinutesAt, BirthDateExpressionFor(args[0]), args[0]);
        public Expression AgeInSecondsAt(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInSecondsAt, BirthDateExpressionFor(args[0]), args[0]);

        public Expression AgeInYears(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInYears, PatientBirthDate);
        public Expression AgeInMonths(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInMonths, PatientBirthDate);
        public Expression AgeInWeeks(InvocationBuilder builder, Expression[] args) =>
              builder.Invoke(System.Operators.CalculateAgeInWeeks, PatientBirthDate);
        public Expression AgeInDays(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInDays, PatientBirthDate);
        public Expression AgeInHours(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInHours, PatientBirthDateTime);
        public Expression AgeInMinutes(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInMinutes, PatientBirthDateTime);
        public Expression AgeInSeconds(InvocationBuilder builder, Expression[] args) =>
            builder.Invoke(System.Operators.CalculateAgeInSeconds, PatientBirthDateTime);


        public Expression Flatten(InvocationBuilder builder, Expression[] args)
        {
            var operand = args[0];
            // there is special logic for handling a List<ValueSet>
            if (operand.resultTypeSpecifier == System.ValueSetType.ToListType(System))
            {
                var result = builder.CoercionProvider
                    .Coerce(operand, System.CodeType
                    .ToListType(System)
                    .ToListType(System));
                if (!result.Success)
                    throw new InvalidOperationException($"Coercion provider declined to convert List<ValueSet> to List<List<Code>>");
                return builder.Invoke(System.Operators.Flatten, result.Result);
            }
            return builder.Invoke(System.Operators.Flatten, operand);
        }
    }

    file static class Validators
    {
        internal static void Validate(DifferenceBetween db, System100 system) => db
            .HasSameOperandTypes()
            .HasValidPrecision(db.operand[0].resultTypeSpecifier, db.precisionSpecified, db.precision, system);
        internal static void Validate(DurationBetween db, System100 system) => db
            .HasSameOperandTypes()
            .HasValidPrecision(db.operand[0].resultTypeSpecifier, db.precisionSpecified, db.precision, system);

        internal static void Validate(DateTimeComponentFrom dtc, System100 system) =>
            dtc.HasValidPrecision(dtc.operand.resultTypeSpecifier, dtc.precisionSpecified, dtc.precision, system);

        public static T HasSameOperandTypes<T>(this T element) where T : Element =>
            element switch
            {
                BinaryExpression be when be.operand[0].resultTypeSpecifier != be.operand[1].resultTypeSpecifier => element.AddError("Both operands must have the same type."),
                TernaryExpression te when te.operand.Distinct().Count() > 1 => element.AddError("Both operands must have the same type."),
                _ => element
            };

        public static T HasValidPrecision<T>(this T element,
                TypeSpecifier operandType, bool precisionSpecified, DateTimePrecision precision, System100 system)
            where T : Element
        {
            if (precisionSpecified)
            {
                // For Date values, precision must be one of: years, months, weeks, or days.
                if (operandType == system.DateType && precision > DateTimePrecision.Day)
                    element.AddError("For Date values, precision must be one of: years, months, weeks, or days.");
                else if (operandType == system.TimeType && precision < DateTimePrecision.Hour)
                    element.AddError("For Time values, precision must be one of: hours, minutes, seconds, or milliseconds.");
            }
            return element;
        }
    }
    file static class FunctionDefinitionBuilders
    {
        /// <summary>
        /// Creates overloads by replacing <paramref name="typeArgument"/> in all operands and the return type of <paramref name="def"/> for each <paramref name="replacements"/>.
        /// </summary>
        /// <typeparam name="T">The ELM type of expression to which <paramref name="def"/> will be translated.</typeparam>
        /// <param name="def">The base function which contains generic operands.</param>
        /// <param name="typeArgument">The generic type argument found in operands and the return type to replace.</param>
        /// <param name="replacements">The types with which to replace <paramref name="typeArgument"/>.</param>
        /// <returns>A new <see cref="OverloadedFunctionDef"/> containing all the new overloads.</returns>
        /// <exception cref="ArgumentException">If <paramref name="def"/> has no operands, or the resulting replacements would create duplicate overloads, or the replacements would not create at least 2 overloads.</exception>
        public static OverloadedFunctionDef For<T>(this SystemFunction<T> def, ParameterTypeSpecifier typeArgument, params TypeSpecifier[] replacements)
            where T : Element
        {
            if (replacements.Length < 2)
                throw new ArgumentException($"At least two types must be supplied to create overloads.", nameof(replacements));
            var functions = new FunctionDef[replacements.Length];
            var operandCount = def.operand?.Count() ?? 0;
            if (operandCount > 0)
            {

                for (int i = 0; i < replacements.Length; i++)
                {
                    var genericMap = new Dictionary<string, TypeSpecifier> { { typeArgument.parameterName, replacements![i] } };
                    var overload = CreateOverload(def, operandCount, genericMap);
                    functions[i] = overload;
                }
                var overloaded = OverloadedFunctionDef.Create(functions);
                return overloaded;
            }
            else throw new ArgumentException($"Function has no operands", nameof(def));
        }
        public static OverloadedFunctionDef WithListAndIntervalVariants<T>(this SystemFunction<T> def, ParameterTypeSpecifier typeArgument, System100 systemLibrary)
            where T : Element =>
            OverloadedFunctionDef.Create(For(def, typeArgument, typeArgument.ToIntervalType(systemLibrary), typeArgument.ToListType(systemLibrary)).Functions.Append(def).Reverse().ToArray());

        internal static SystemFunction CreateOverload<T>(SystemFunction<T> baseFunctionDef, int operandCount, Dictionary<string, TypeSpecifier> replacements) where T : Element
        {
            var newOperands = new OperandDef[operandCount];
            for (int j = 0; j < operandCount; j++)
            {
                var existingOperand = baseFunctionDef.operand![j];
                var operandType = InvocationBuilder.ReplaceGenericType(existingOperand.operandTypeSpecifier, replacements);
                var newOperand = new OperandDef
                {
                    name = existingOperand.name,
                    annotation = existingOperand.annotation,
                    locator = existingOperand.locator,
                    operandTypeSpecifier = operandType,
                    resultTypeName = operandType is NamedTypeSpecifier onts ? onts.name : null,
                    resultTypeSpecifier = operandType,
                };
                newOperands[j] = newOperand;
            }
            var newReturnType = InvocationBuilder.ReplaceGenericType(baseFunctionDef.resultTypeSpecifier, replacements);
            var overload = baseFunctionDef.CreateOverload(newOperands, newReturnType);
            overload.Invoker = baseFunctionDef.Invoker;
            return overload;
        }

        internal static TypeSpecifier ReplaceGenericType(TypeSpecifier type, IDictionary<string, TypeSpecifier> replacements,
            System100 systemLibrary)
        {
            if (type is ParameterTypeSpecifier generic)
            {
                if (replacements.TryGetValue(generic.parameterName, out var resolvedType))
                    return resolvedType;
                else throw new ArgumentException($"Generic type {generic.parameterName} does not have a replacement defined.", nameof(replacements));
            }
            else if (type is GenericTypeSpecifier gts)
            {
                var newArguments = gts.typeArgument!.Select(ta => ReplaceGenericType(ta, replacements, systemLibrary));
                return new GenericTypeSpecifier
                {
                    type = gts.type,
                    typeArgument = newArguments.ToArray()
                };
            }
            else return type;
        }

        public static OverloadedFunctionDef Combine(this OverloadedFunctionDef @this, params OverloadedFunctionDef[] overloadedFunctions) =>
            OverloadedFunctionDef.Create(@this.Functions.Concat(overloadedFunctions.SelectMany(def => def.Functions)).ToArray());

        public static OverloadedFunctionDef Combine<T>(this SystemFunction<T> @this, params SystemFunction<T>[] functions) where T : Element =>
            OverloadedFunctionDef.Create(functions.Append(@this).ToArray());

        public static OverloadedFunctionDef Combine<T>(this OverloadedFunctionDef @this, params SystemFunction<T>[] functions) where T : Element =>
            OverloadedFunctionDef.Create(@this.Functions.Concat(functions).ToArray());

        public static SystemFunction<T> MakeFluent<T>(this SystemFunction<T> function)
            where T : Element
        {
            function.fluent = true;
            function.fluentSpecified = true;
            return function;
        }
    }

    internal static class TypeExtensions
    {
        public static TypeSpecifier ToListType(this TypeSpecifier elementType, System100 system) =>
            system.ListTemplate.MakeGenericType(elementType.ToModelSpecifier(system.ModelProvider)).ToTypeSpecifier().ToElmSpecifier();

        public static TypeSpecifier ToIntervalType(this TypeSpecifier pointType, System100 system) =>
            system.IntervalTemplate.MakeGenericType(pointType.ToModelSpecifier(system.ModelProvider)).ToTypeSpecifier().ToElmSpecifier();
    }
}