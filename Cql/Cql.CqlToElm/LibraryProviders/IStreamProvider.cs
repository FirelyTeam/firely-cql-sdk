using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal interface IStreamProvider
    {
        bool TryGet(string id, string? version, out Stream? stream);
    }
}
