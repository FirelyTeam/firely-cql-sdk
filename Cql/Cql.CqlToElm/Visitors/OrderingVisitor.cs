using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal record DefRef(ExpressionDef Def, Element Ref);

    internal class OrderingVisitor: cqlBaseVisitor<DefRef[]>
    {
        public OrderingVisitor(SystemLibrary systemLibrary, TypeSpecifierVisitor typeSpecifierVisitor)
        {
            SystemLibrary = systemLibrary;
            TypeSpecifierVisitor = typeSpecifierVisitor;
        }

        private Element? def;

        public SystemLibrary SystemLibrary { get; }
        public TypeSpecifierVisitor TypeSpecifierVisitor { get; }

        public override DefRef[] VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
        {
            var id = context.identifier().Parse();
            def = new ExpressionDef { name = id }.WithLocator(context.Locator());
            var defRefs = Visit(context.expression());
            return defRefs;
        }

        public override DefRef[] VisitFunctionDefinition([NotNull] cqlParser.FunctionDefinitionContext context)
        {
            var id = context.identifierOrFunctionIdentifier().Parse();
            var operands = context.operandDefinition()
                .Select(od => {

                    var type = TypeSpecifierVisitor.Visit(od.typeSpecifier());
                    return new OperandDef
                    {
                        name = od.referentialIdentifier().Parse()
                    }.WithResultType(type);
                })
                .ToArray();
            def = new FunctionDef 
            { 
                name = id ,
                operand = operands,
            }.WithLocator(context.Locator());
            var defRefs = Visit(context.functionBody());
            return defRefs;
        }

        public override DefRef[] VisitQualifiedFunction([NotNull] cqlParser.QualifiedFunctionContext context)
        {
            if (def is null) throw new InvalidOperationException();
            return Array.Empty<DefRef>();
        }

        public override DefRef[] VisitFunction([NotNull] cqlParser.FunctionContext context)
        {
            if (def is null) throw new InvalidOperationException();
            if (def is FunctionDef func)
            {
                var operandTypes = func.operand?
                    .Select(od => od.resultTypeSpecifier)
                    .ToArray()
                    ?? Array.Empty<TypeSpecifier>();
                if (SystemLibrary.IsSystemFunction(func.name, operandTypes))
                {
                }
            }
            var functionName = context.referentialIdentifier().Parse();
           
            return Array.Empty<DefRef>();
        }

        public override DefRef[] VisitQualifiedMemberInvocation([NotNull] cqlParser.QualifiedMemberInvocationContext context)
        {
            if (def is null) throw new InvalidOperationException();
            return Array.Empty<DefRef>();
        }

        public override DefRef[] VisitMemberInvocation([NotNull] cqlParser.MemberInvocationContext context)
        {
            if (def is null) throw new InvalidOperationException();
            var id = context.referentialIdentifier().Parse();
            if (def is FunctionDef func && (func.operand?.Any(op => op.name == id) ?? false))
                return Array.Empty<DefRef>();
            else
            {

            }
            return Array.Empty<DefRef>();
        }


    }
}
