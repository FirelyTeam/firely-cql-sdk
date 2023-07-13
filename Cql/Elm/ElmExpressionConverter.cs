﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Expressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Hl7.Cql.Elm
{
    public class ElmExpressionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(Expression);

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {

            if (reader.TokenType == JsonToken.Null)
                return null!;
            var expression = JToken.ReadFrom(reader);
            var rawType = expression["type"];
            var type = expression["type"]?.ToString();
            Expression? expressionInstance = type switch
            {
                // Keep alphabetized please
                "Abs" => new AbsExpression(),
                "Add" => new AddExpression(),
                "After" => new AfterExpression(),
                "AggregateClause" => new AggregateQueryExpression(),
                "AliasRef" => new AliasRefExpression(),
                "AllTrue" => new AllTrueExpression(),
                "And" => new AndExpression(),
                "AnyTrue" => new AnyTrueExpression(),
                "AnyInValueSet" => new AnyInValueSetExpression(),
                "As" => new AsExpression(),
                "Avg" => new AvgExpression(),
                "Before" => new BeforeExpression(),
                "CalculateAge" => new CalculateAgeExpression(),
                "CalculateAgeAt" => new CalculateAgeAtExpression(),
                "Case" => new CaseExpression(),
                "Ceiling" => new CeilingExpression(),
                "Coalesce" => new CoalesceExpression(),
                "CodeRef" => new CodeRefExpression(),
                "Collapse" => new CollapseExpression(),
                "Combine" => new CombineExpression(),
                "Concatenate" => new ConcatenateExpression(),
                "Contains" => new ContainsExpression(),
                "ConvertQuantity" => new ConvertQuantityExpression(),
                "ConvertsToBoolean" => new ConvertsToBooleanExpression(),
                "ConvertsToDate" => new ConvertsToDateExpression(),
                "ConvertsToDateTime" => new ConvertsToDateTimeExpression(),
                "ConvertsToDecimal" => new ConvertsToDecimalExpression(),
                "ConvertsToLong" => new ConvertsToLongExpression(),
                "ConvertsToInteger" => new ConvertsToIntegerExpression(),
                "ConvertsToQuantity" => new ConvertsToQuantityExpression(),
                "ConvertsToString" => new ConvertsToStringExpression(),
                "Count" => new CountExpression(),
                "Date" => new DateExpression(),
                "DateFrom" => new DateFromExpression(),
                "DateTime" => new DateTimeExpression(),
                "DateTimeComponentFrom" => new DateTimeComponentFromExpression(),
                "Descendents" => new DescendentsExpression(),
                "DifferenceBetween" => new DifferenceBetweenExpression(),
                "Distinct" => new DistinctExpression(),
                "Divide" => new DivideExpression(),
                "DurationBetween" => new DurationBetweenExpression(),
                "End" => new EndExpression(),
                "Ends" => new EndsExpression(),
                "EndsWith" => new EndsWithExpression(),
                "Equal" => new EqualExpression(),
                "Equivalent" => new EquivalentExpression(),
                "Except" => new ExceptExpression(),
                "Expand" => new ExpandExpression(),
                "ExpandValueSet" => new ExpandValueSetExpression(),
                "Exists" => new ExistsExpression(),
                "Exp" => new ExpExpression(),
                "ExpressionRef" => new ExpressionRefExpression(),
                "First" => new FirstExpression(),
                "Flatten" => new FlattenExpression(),
                "Floor" => new FloorExpression(),
                "FunctionRef" => new FunctionRefExpression(),
                "GeometricMean" => new GeometricMeanExpression(),
                "Greater" => new GreaterExpression(),
                "GreaterOrEqual" => new GreaterOrEqualExpression(),
                "HighBoundary" => new HighBoundaryExpression(),
                "IdentifierRef" => new IdentifierRefExpression(),
                "If" => new IfExpression(),
                "Interval" => new IntervalExpression(),
                "Includes" => new Expressions.IncludesExpression(),
                "IncludedIn" => new IncludedInExpression(),
                "In" => new InExpression(),
                "Indexer" => new IndexerExpression(),
                "IndexOf" => new IndexOfExpression(),
                "Instance" => new InstanceExpression(),
                "Intersect" => new IntersectExpression(),
                "InValueSet" => new InValueSetExpression(),
                "Is" => new IsExpression(),
                "IsFalse" => new IsFalseExpression(),
                "IsNull" => new IsNullExpression(),
                "IsTrue" => new IsTrueExpression(),
                "LastPositionOf" => new LastPositionOfExpression(),
                "Less" => new LessExpression(),
                "LessOrEqual" => new LessOrEqualExpression(),
                "Last" => new LastExpression(),
                "Length" => new LengthExpression(),
                "List" => new ListExpression(),
                "Literal" => new LiteralExpression(),
                "Ln" => new LnExpression(),
                "Log" => new LogExpression(),
                "LowBoundary" => new LowBoundaryExpression(),
                "Lower" => new LowerExpression(),
                "Matches" => new MatchesExpression(),
                "Max" => new MaxExpression(),
                "MaxValue" => new MaximumExpression(),
                "Maximum" => new MaximumExpression(),
                "Median" => new MedianExpression(),
                "Meets" => new MeetsExpression(),
                "MeetsBefore" => new MeetsBeforeExpression(),
                "MeetsAfter" => new MeetsAfterExpression(),
                "Message" => new MessageExpression(),
                "Min" => new MinExpression(),
                "MinValue" => new MinimumExpression(),
                "Minimum" => new MinimumExpression(),
                "Mode" => new ModeExpression(),
                "Modulo" => new ModuloExpression(),
                "Multiply" => new MultiplyExpression(),
                "NamedTypeSpecifier" => new NamedTypeSpecifierExpression(),
                "Not" => new NotExpression(),
                "Now" => new NowExpression(),
                "Null" => new NullExpression(),
                "Negate" => new NegateExpression(),
                "OperandRef" => new OperandRefExpression(),
                "Or" => new OrExpression(),
                "Overlaps" => new OverlapsExpression(),
                "OverlapsAfter" => new OverlapsAfterExpression(),
                "OverlapsBefore" => new OverlapsBeforeExpression(),
                "ParameterRef" => new ParameterRefExpression(),
                "PointFrom" => new PointFromExpression(),
                "PopulationStdDev" => new PopulationStdDevExpression(),
                "PopulationVariance" => new PopulationVarianceExpression(),
                "PositionOf" => new PositionOfExpression(),
                "Power" => new PowerExpression(),
                "Precision" => new PrecisionExpression(),
                "Predecessor" => new PredecessorExpression(),
                "Product" => new ProductExpression(),
                "Property" => new PropertyExpression(),
                "ProperContains" => new ProperContainsExpression(),
                "ProperIn" => new ProperInExpression(),
                "ProperIncludes" => new ProperIncludesExpression(),
                "ProperIncludedIn" => new ProperIncludedInExpression(),
                "Quantity" => new QuantityExpression(),
                "Query" => new QueryExpression(),
                "QueryLetRef" => new QueryLetRefExpression(),
                "Ratio" => new RatioExpression(),
                "ReplaceMatches" => new ReplaceMatchesExpression(),
                "Retrieve" => new RetrieveExpression(),
                "Round" => new RoundExpression(),
                "SameAs" => new SameAsExpression(),
                "SameOrAfter" => new SameOrAfterExpression(),
                "SameOrBefore" => new SameOrBeforeExpression(),
                "SingletonFrom" => new SingletonFromExpression(),
                "Slice" => new SliceExpression(),
                "Successor" => new SuccessorExpression(),
                "Split" => new SplitExpression(),
                "Start" => new StartExpression(),
                "Starts" => new StartsExpression(),
                "StartsWith" => new StartsWithExpression(),
                "StdDev" => new StdDevExpression(),
                "Substring" => new SubstringExpression(),
                "Subtract" => new SubtractExpression(),
                "Sum" => new SumExpression(),
                "Tail" => new TailExpression(),
                "Time" => new TimeExpression(),
                "TimeOfDay" => new TimeOfDayExpression(),
                "TimezoneOffsetFrom" => new TimezoneOffsetFromExpression(),
                "ToBoolean" => new ToBooleanExpression(),
                "ToConcept" => new ToConceptExpression(),
                "ToDate" => new ToDateExpression(),
                "ToDateTime" => new ToDateTimeExpression(),
                "Today" => new TodayExpression(),
                "ToDecimal" => new ToDecimalExpression(),
                "ToInteger" => new ToIntegerExpression(),
                "ToList" => new ToListExpression(),
                "ToQuantity" => new ToQuantityExpression(),
                "ToString" => new ToStringExpression(),
                "ToTime" => new ToTimeExpression(),
                "Truncate" => new TruncateExpression(),
                "TruncatedDivide" => new TruncatedDivideExpression(),
                "Tuple" => new TupleExpression(),
                "Union" => new UnionExpression(),
                "Upper" => new UpperExpression(),
                "ValueSetRef" => new ValueSetRefExpression(),
                "Variance" => new VarianceExpression(),
                "With" => new WithExpression(),
                "Width" => new WidthExpression(),
                "Xor" => new XorExpression(),
                _ => new Expression(),
            };
            var expReader = expression.CreateReader();
            expReader.MaxDepth = 128;
            serializer.Populate(expReader, expressionInstance);
            return expressionInstance;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
