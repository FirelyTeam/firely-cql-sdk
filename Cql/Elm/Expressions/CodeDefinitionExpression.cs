/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{

    // code "virtual": 'VR' from "ActEncounterCodes"
    // becomes
    // code "<name>" : <id> from <codeSystem.name>
    public class CodeDefinitionExpression : Expression
    {
        /// <summary>
        /// The left hand side of the code expression, e.g., code {name} : {id} from {codeSystem.name}
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// The right hand side of the code expression, e.g., code {name} : {id} from {codeSystem.name}
        /// </summary>
        public string? id { get; set; }

        public CodeSystemExpression? codeSystem { get; set; }


        public class CodeSystemExpression : Expression
        {
            public string? name { get; set; }
        }
    }
}
