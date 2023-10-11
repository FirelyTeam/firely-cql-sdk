/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using static Hl7.Cql.Elm.SystemTypes;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal class IsFunctionDef : BuiltInFunctionDef
    {
        public IsFunctionDef() : base(nameof(Is), new[] { AnyType }, T) { }
    }
}