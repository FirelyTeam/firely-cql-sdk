using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET
{
    public interface ILambdaProvider
    {
        /// <summary>
        /// Gets the <see cref="TypeManager"/> used in generating the <see cref="LambdaExpression"/>s.
        /// </summary>
        TypeManager TypeManager { get; }

        /// <summary>
        /// Get lamba expressions for the named measure.
        /// </summary>
        DefinitionDictionary<LambdaExpression> GetLambdaExpressionsFor(string name, string? version);

    }
}
