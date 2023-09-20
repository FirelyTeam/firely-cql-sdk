using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ParameterDefinitionVisitor : Visitor<ParameterDef>
    {
        public ParameterDefinitionVisitor(
            IServiceProvider services,
            TypeSpecifierVisitor typeSpecVisitor,
            ExpressionVisitor expressionVisitor) : base(services)
        {
            TypeSpecifierVisitor = typeSpecVisitor;
            ExpressionVisitor = expressionVisitor;
        }
        private TypeSpecifierVisitor TypeSpecifierVisitor { get; }
        private ExpressionVisitor ExpressionVisitor { get; }


        //: accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
        public override ParameterDef VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        {
            var paramDef = new ParameterDef();
            paramDef.accessLevel = context.accessModifier().Parse();
            paramDef.name = context.identifier().Parse();

            if (context.typeSpecifier() is { } typeSpec)
            {
                paramDef.parameterTypeSpecifier = TypeSpecifierVisitor.Visit(typeSpec);

                if (paramDef.parameterTypeSpecifier is NamedTypeSpecifier nts && nts.name?.Name != null)
                    paramDef.parameterType = new System.Xml.XmlQualifiedName(nts.name.Name);
            }

            paramDef.@default = ExpressionVisitor.Visit(context.expression());
            paramDef.localId = NextId();
            paramDef.locator = context.Locator();

            return paramDef;
        }
    }
}
