using System.Text.Json;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ZReproTest : Base
    {
        [TestMethod]
        public void Repro_FromConcept_Type()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("({ 1 }) X return Tuple { key: 'ExampleConcept' }");
            var stmt = lib.statements[0].expression;
            System.Console.WriteLine("STMT TYPE: " + stmt.GetType().Name);
            var q = (Query)stmt;
            System.Console.WriteLine("QUERY resultTypeSpecifier: " + Describe(q.resultTypeSpecifier));
            System.Console.WriteLine("RETURN resultTypeSpecifier: " + Describe(q.@return?.resultTypeSpecifier));
            System.Console.WriteLine("RETURN expr type: " + Describe(q.@return?.expression?.resultTypeSpecifier));
            System.Console.WriteLine("SOURCE[0] type: " + Describe(q.source[0].resultTypeSpecifier));
        }

        private static string Describe(TypeSpecifier? ts)
        {
            if (ts is null) return "<null>";
            return ts.GetType().Name + " :: " + ts.ToString();
        }
    }
}
