using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ParameterDefinitionVisitor : Visitor<ParameterDef>
    {
        public ParameterDefinitionVisitor(
            TypeSpecifierVisitor typeSpecVisitor,
            ExpressionVisitor expressionVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            typeSpecifierVisitor = typeSpecVisitor;
            this.expressionVisitor = expressionVisitor;
        }

        private readonly TypeSpecifierVisitor typeSpecifierVisitor;
        private readonly ExpressionVisitor expressionVisitor;

        //: accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
        public override ParameterDef VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        {
            var paramDef = new ParameterDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                @default = expressionVisitor.Visit(context.expression()),
            }.WithLocator(context.Locator());

            if (context.typeSpecifier() is { } typeSpec)
            {
                paramDef.parameterTypeSpecifier = typeSpecifierVisitor.Visit(typeSpec);
                paramDef.parameterType = paramDef.parameterTypeSpecifier.TryToQualifiedName();
            }

            return paramDef;
        }
    }
}
