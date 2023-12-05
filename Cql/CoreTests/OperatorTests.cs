using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    [TestClass]
    public class OperatorTests
    {

        [TestMethod]
        public void DateTime_Compare_Days_To_Hours()
        {
            var first = new CqlDateTime(2012, 1, 1, null, null, null, null, null, null);
            var second = new CqlDateTime(2012, 1, 1, 12, null, null, null, null, null);

            var compare = first.CompareTo(second, null);
            Assert.IsNull(compare);


        }

    }
}
