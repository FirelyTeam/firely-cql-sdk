/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Maps library, definition, and signatures to expressions.
    /// </summary>
    public class ExpressionDefinitionDictionary : DefinitionDictionary<LambdaExpression> { }
}
