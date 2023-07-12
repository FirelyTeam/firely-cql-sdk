/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class Expression
    {
        public int? localId { get; set; }
        public string? locator { get; set; }
        public string? resultTypeName { get; set; }
        /* 
         * Examples of dataType string:
         *  - {http://hl7.org/fhir}Patient
         *  
         */
        public string? dataType { get; set; }
        public string? type { get; set; }
        public TypeSpecifierExpression? resultTypeSpecifier { get; set; }
    }
}