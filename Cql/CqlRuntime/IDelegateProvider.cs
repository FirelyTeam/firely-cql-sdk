using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ncqa.Cql.Runtime
{
    public interface IDelegateProvider
    {


        /// <summary>
        /// Get delegates for the named measure.
        /// </summary>
        DefinitionDictionary<Delegate> GetDelegatesFor(string name, string? version = null);
    }
}
