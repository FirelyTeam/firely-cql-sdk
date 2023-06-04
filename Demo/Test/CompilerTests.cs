using Cql;
using Hl7.Cql;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using System.Runtime.Loader;

namespace Test
{
    [TestClass]
    public class CompilerTests
    {

        private IDictionary<string, object> MY2023 =
            new Dictionary<string, object>
            {
                {
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0),
                        new CqlDateTime(2023, 12, 31, 0, 0, 0, 0, 0, 0),
                        true,
                        true)
                }
            };
    }
}