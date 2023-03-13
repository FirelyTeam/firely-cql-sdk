using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Comparers
{
    public interface IEquivalentable<T>
        where T: class
    {
        bool Equivalent(T? other, string? precision);

    }
}
