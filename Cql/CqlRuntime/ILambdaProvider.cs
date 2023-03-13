using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public interface ILambdaProvider
    {
        /// <summary>
        /// Get delegates for the named measure.
        /// </summary>
        DefinitionDictionary<LambdaExpression> GetLambdaExpressionsFor(string name, string? version);

    }
}
