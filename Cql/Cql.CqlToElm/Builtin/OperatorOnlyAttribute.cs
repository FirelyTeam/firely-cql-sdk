/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.CqlToElm.Builtin
{
    /// <summary>
    /// Marks a <see cref="SystemLibrary"/> field that is not a CQL function. The field is left out
    /// of the symbol table, so function syntax of the same name (<c>NotEqual(1, 2)</c>,
    /// <c>"Interval"(1, 10, true, true)</c>) does not resolve to it; only the operator syntax reaches it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    internal sealed class OperatorOnlyAttribute : Attribute
    {
    }
}
