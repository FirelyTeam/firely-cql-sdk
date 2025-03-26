using Antlr4.Runtime;
using CqlToElm2Tests.Sql;
using FluentAssertions;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests;

[TestClass]
public class QueryTest
{

    internal static cqlParser getParser(string cql)
    {
        var antlStream = new AntlrInputStream(cql);
        var lexer = new cqlLexer(antlStream);
        return new cqlParser(new CommonTokenStream(lexer));
    }

    [TestMethod]
    public void Patient_Retrieve()
    {
        var provider = new MockLibraryProvider();
        var systemCql =
        @"model System version '2.0.0': 'http://cql.hl7.org/2.0.0'

        define literal type Any

        define literal type String extends Any

        define generic type List<T> extends Any {}      

        ";
        provider.Add("System", new(2, 0, 0), systemCql);
        var fhirCql =
        @"model FHIR version '4.0.0': 'http://hl7.org/fhir'

        using System version '2.0.0'

        define type Patient {
            id: String
        }
        ";
        provider.Add("FHIR", new(4, 0, 0), fhirCql);

        var libCql =
        @"library Test version '1.0.0'

        using FHIR version '4.0.0'

        define Patients: [Patient]
        ";
        var globalScope = new SymbolTable(".global");
        var visitor = new SymbolVisitor(globalScope, provider);
        var library = visitor.Visit(getParser(libCql).library()).Should().BeOfType<LibrarySymbol>().Subject;

        var patientSymbol = library.Symbols.GetUnique<ExpressionSymbol>("Patients");
        patientSymbol.Should().NotBeNull();
        var retrieve = patientSymbol!.Expression.Should().BeOfType<RetrieveExpression>().Subject;

        var evaluator = new SqlEvaluator(new SqlKata.Compilers.PostgresCompiler(), new() { });
        evaluator.Evaluate(retrieve, library.Symbols);


    }
}
