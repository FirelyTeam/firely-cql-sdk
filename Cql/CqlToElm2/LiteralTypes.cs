using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2;
internal record LiteralTypeNames(string[] Any,
    string[] Integer,
    string[] Decimal,
    string[] Boolean,
    string[] Code,
    string[] CodeSystem,
    string[] Concept,
    string[] Date,
    string[] DateTime,
    string[] Interval,
    string[] List,
    string[] Long,
    string[] Quantity,
    string[] Ratio,
    string[] String,
    string[] Time,
    string[] ValueSet)
{
    public static LiteralTypeNames Default => new(
        Any: new[] { "System", "Any" },
        Integer: new[] { "System", "Integer" },
        Decimal: new[] { "System", "Decimal" },
        Boolean: new[] { "System", "Boolean" },
        Code: new[] { "System", "Code" },
        CodeSystem: new[] { "System", "CodeSystem" },
        Concept: new[] { "System", "Concept" },
        Date: new[] { "System", "Date" },
        DateTime: new[] { "System", "DateTime" },
        Interval: new[] { "Interval" },
        List: new[] { "System", "List" },
        Long: new[] { "System", "Long" },
        Quantity: new[] { "System", "Quantity" },
        Ratio: new[] { "System", "Ratio" },
        String: new[] { "System", "String" },
        Time: new[] { "System", "Time" },
        ValueSet: new[] { "System", "ValueSet" });


}
