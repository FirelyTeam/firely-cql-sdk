using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public interface IValueSetFacade: IEnumerable<CqlCode>
    {
        public bool? IsCodeInValueSet(CqlCode? code);

    }
}
