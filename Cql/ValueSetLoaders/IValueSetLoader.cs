using Ncqa.Cql.Runtime;
using Ncqa.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.ValueSetLoaders
{
    public interface IValueSetLoader
    {
        IValueSetDictionary Load();
        void Load(IValueSetDictionary dictionary);
    }
}
