using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    /// <summary>
    /// Implements a substitute for Lazy that does not cache values, making debugging easier.
    /// </summary>
    public class DebugLazy<T>
    {
        public DebugLazy(Func<T> valueFactory, bool isThreadSafe = false)
        {
            ValueFactory = valueFactory;
        }

        public Func<T> ValueFactory { get; }

        public T Value => ValueFactory();
    }
}
