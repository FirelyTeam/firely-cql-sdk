using Ncqa.Cql.MeasureCompiler;
using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.CodeGeneration.NET
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
