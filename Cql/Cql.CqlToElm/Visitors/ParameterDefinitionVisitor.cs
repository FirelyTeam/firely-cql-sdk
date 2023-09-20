using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ParameterDefinitionVisitor : Visitor<ParameterDef>
    {
        public ParameterDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }
        private TypeSpecifierVisitor TypeSpecifierVisitor => Services.GetRequiredService<TypeSpecifierVisitor>();
        private ExpressionVisitor ExpressionVisitor => Services.GetRequiredService<ExpressionVisitor>();


        //: accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
        public override ParameterDef VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        {
            var paramDef = new ParameterDef();
            var index = 1;
            if (context.GetChild(0) is cqlParser.AccessModifierContext amc)
            {
                paramDef.accessLevel = amc.Parse();
                index = 2;
            }
            else paramDef.accessLevel = AccessModifier.Public;

            paramDef.name = context.identifier().Parse();
            index += 1;
            IParseTree? defaultValue = null;
            if (index < context.ChildCount)
            {
                var child = context.GetChild(index);
                if (child is TerminalNodeImpl) // type specifier not specified
                {
                    defaultValue = context.GetChild(index + 1);
                }
                else
                {
                    paramDef.parameterTypeSpecifier = TypeSpecifierVisitor.Visit(child);
                    if (paramDef.parameterTypeSpecifier is NamedTypeSpecifier nts && nts.name?.Name != null)
                        paramDef.parameterType = new System.Xml.XmlQualifiedName(nts.name.Name);
                    index += 2;
                    if (index < context.ChildCount)
                        defaultValue = context.GetChild(index);
                }
            }
            if (defaultValue != null)
            {
                paramDef.@default = ExpressionVisitor.Visit(defaultValue);
            }
            paramDef.localId = NextId();
            paramDef.locator = context.Locator();

            return paramDef;
        }
    }
}
