﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

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
