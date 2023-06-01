using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {

        protected Expression? Combine(elm.CombineExpression e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.source!, ctx);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : TranslateExpression(e.separator, ctx);
            var call = Operators.Bind(CqlOperator.Combine, ctx.RuntimeContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(elm.ConcatenateExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Concatenate, e, ctx);

        protected Expression? EndsWith(elm.EndsWithExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.EndsWith, e, ctx);

        protected Expression Indexer(elm.IndexerExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e!.operand![1]!, ctx);
            if (left.Type == typeof(string))
            {
                return Operators.Bind(CqlOperator.CharAt, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return Operators.Bind(CqlOperator.ElementAt, ctx.RuntimeContextParameter, left, right);
            }
            else throw new NotImplementedException();
        }

        protected Expression? LastPositionOf(elm.LastPositionOfExpression e, ExpressionBuilderContext ctx)
        {
            var @string = TranslateExpression(e!.@string!, ctx);
            var pattern = TranslateExpression(e!.pattern!, ctx);
            return Operators.Bind(CqlOperator.LastPositionOf, ctx.RuntimeContextParameter, @string, pattern);
        }

        protected Expression? Length(elm.LengthExpression len, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(len.operand!, ctx);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return Operators.Bind(CqlOperator.ListLength, ctx.RuntimeContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return Operators.Bind(CqlOperator.StringLength, ctx.RuntimeContextParameter, operand);
            }
            else throw new NotImplementedException();
        }

        protected Expression? Lower(elm.LowerExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Lower, e, ctx);

        protected Expression? Matches(elm.MatchesExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Matches, e, ctx);

        protected Expression PositionOf(elm.PositionOfExpression e, ExpressionBuilderContext ctx)
        {
            var @string = TranslateExpression(e!.@string!, ctx);
            var pattern = TranslateExpression(e!.pattern!, ctx);
            return Operators.Bind(CqlOperator.PositionOf, ctx.RuntimeContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(elm.ReplaceMatchesExpression e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.operand![0]!, ctx);
            var pattern = TranslateExpression(e.operand![1]!, ctx);
            var substitution = TranslateExpression(e.operand![2]!, ctx);
            return Operators.Bind(CqlOperator.ReplaceMatches, ctx.RuntimeContextParameter, source, pattern, substitution);
        }

        protected Expression Split(elm.SplitExpression e, ExpressionBuilderContext ctx)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!, ctx);
            var separator = TranslateExpression(e.separator!, ctx);
            return Operators.Bind(CqlOperator.Split, ctx.RuntimeContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(elm.StartsWithExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.StartsWith, e, ctx);

        protected Expression? Substring(elm.SubstringExpression e, ExpressionBuilderContext ctx)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!, ctx);
            var startIndex = TranslateExpression(e!.startIndex!, ctx);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length, ctx);
            return Operators.Bind(CqlOperator.Substring, ctx.RuntimeContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(elm.UpperExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Upper, e, ctx);



    }
}
