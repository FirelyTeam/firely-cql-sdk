/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class AsExpression : UnaryExpression
    {

        public string? asType { get; set; }
        /// <summary>
        /// Appears in some contexts where expression type is "As".  Appears to have the same meaning as <see cref="asType"/>.
        /// </summary>
        public TypeSpecifierExpression? asTypeSpecifier { get; set; }
    }


}
