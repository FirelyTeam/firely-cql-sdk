using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests.Sql;
internal abstract class Retriever
{
    public abstract string Uri { get; }

    public abstract Query Retrieve(string resourceType);

}
