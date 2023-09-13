using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    internal class LocalIdentifierProvider
    {
        private int _identifier = 1;
        public string Next() => _identifier++.ToString(CultureInfo.InvariantCulture);
    }
}
