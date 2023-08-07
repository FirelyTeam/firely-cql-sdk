using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;


namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {

        /// <summary>
        /// The and operator returns true if both its arguments are true. If either argument is false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <see cref="https://cql.hl7.org/09-b-cqlreference.html#and"/>
        protected Expression And(elm.And e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.And, e, ctx);

        /// <summary>
        /// The or operator returns true if either of its arguments are true. If both arguments are false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <see cref="https://cql.hl7.org/09-b-cqlreference.html#or"/>
        protected Expression Or(elm.Or e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Or, e, ctx);
        protected Expression Not(elm.Not e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Not, e, ctx);
        protected Expression Xor(elm.Xor e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Xor, e, ctx);


    }
}
