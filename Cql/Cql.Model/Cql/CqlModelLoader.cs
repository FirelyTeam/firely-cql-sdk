using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar.r2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.Cql;
internal class CqlModelLoader(IModelProvider ModelProvider)
{
    internal ModelDefinition? Load(StreamReader cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        var parser = new cqlParser(new CommonTokenStream(lexer));
        var modelDefinition = new ModelVisitor(ModelProvider).Visit(parser.model());
        return modelDefinition;
    }
}
