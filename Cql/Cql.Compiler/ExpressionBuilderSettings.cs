/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Describes settings to control the behavior of <see cref="ExpressionBuilder"/>
    /// </summary>
    /// <param name="AllowScopeRedefinition"></param>
    /// <param name="AllowUnresolvedExternals"></param>
#pragma warning disable RS0016 // Add public types and members to the declared API
    public record ExpressionBuilderSettings(bool AllowScopeRedefinition, bool AllowUnresolvedExternals);
#pragma warning restore RS0016 // Add public types and members to the declared API
}
