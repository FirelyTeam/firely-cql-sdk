using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2;
internal interface ILibraryProvider
{
    public TextReader? GetLibraryCql(string libraryName, Version? version);
}
