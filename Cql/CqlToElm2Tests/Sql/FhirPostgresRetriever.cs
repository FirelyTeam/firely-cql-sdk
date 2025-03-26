using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests.Sql;
internal class FhirPostgresRetriever: Retriever
{
    public override string Uri => "http://hl7.org/fhir";

    public override Query Retrieve(string resourceType)
    {
        var lower = resourceType.ToLowerInvariant();
        return lower switch
        {
            _ => SelectAll(lower)
        };
    }

    private Query SelectAll(string table) => new Query(table).Select();
}
