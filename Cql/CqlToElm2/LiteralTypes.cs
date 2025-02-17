using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2;
internal record LiteralTypeNames(string Any = "System.Any",
    string Integer = "System.Integer",
    string Decimal = "System.Decimal",
    string Boolean = "System.Boolean",
    string Code = "System.Code",
    string CodeSystem = "System.CodeSystem",
    string Concept = "System.Concept",
    string Date = "System.Date",
    string DateTime = "System.DateTime",
    string Interval = "System.Interval",
    string List = "System.List",
    string Long = "System.Long",
    string Quantity = "System.Quantity",
    string Ratio = "System.Ratio",
    string String = "System.String",
    string Time = "System.Time",
    string ValueSet = "System.ValueSet");
