using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public interface IDataRetriever
    {
        IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, 
            PropertyInfo? codeProperty = null)
            where T : class;
        IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null,
            PropertyInfo? codeProperty = null)
            where T : class;
    }
}
