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
