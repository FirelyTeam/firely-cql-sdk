/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class QueryExpression : Expression
    {
        public Expression? where { get; set; }
        public SourceExpression[]? source { get; set; }
        public WithExpression[]? relationship { get; set; }
        public ReturnExpression? @return { get; set; }
        public LetExpression[]? let { get; set; }
        public SortExpression? sort { get; set; }
        public AggregateQueryExpression? aggregate { get; set; }

    }
    // note: type property is absent on return expressions... why?  who knows
    public class ReturnExpression : Expression
    {
        public Expression? expression { get; set; }
    }
    public class LetExpression : Expression
    {
        public string? identifier { get; set; }
        public Expression? expression { get; set; }
    }

    public class SortExpression : Expression
    {
        public SortBy[]? by { get; set; }
    }
    public class SortBy
    {
        public string? direction { get; set; }
        public string? type { get; set; }
        public Expression? expression { get; set; }
        public string? path { get; set; }
        public string? resultTypeName { get; set; }
        public string? locator { get; set; }
    }
}
