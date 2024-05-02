/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal static class DebugViewHelper
    {
        public static string GetDebugView(this Expression exp)
        {
            var propertyInfo = typeof(Expression).GetProperty("DebugView", BindingFlags.Instance | BindingFlags.NonPublic)!;
            return (string)propertyInfo.GetValue(exp)!;
        }
    }
}

