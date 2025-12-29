using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private record DefinitionWriter
    (
        LibraryWriter LibraryWriter,
        CqlDefinition CqlDefinition) : IAddIndentMutable<DefinitionWriter>
    {
        public DefinitionWriter AddIndent(int addIndent = 1) =>
            this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };

        private IndentedTextWriter tw => LibraryWriter.IndentedTextWriter;

        public void WriteDefinition()
        {
            var name = CqlDefinition.Name;
            string quotedName = name.QuoteString();
            string methodName = IdentifierNormalizer.Normalize(name);
            string fieldName = IdentifierNormalizer.Normalize($"_{name}"); ;
            var definitionAttributeTypeName = CqlDefinition.GetType().Name;

            switch (CqlDefinition)
            {
                case CqlValueSetDefinition vsd:
                {
                    string quotedValueSetId = vsd.ValueSetId.QuoteString();
                    string quotedValueSetVersion = vsd.ValueSetVersion.QuoteOrNullString();
                    tw.WriteLine(
                        $$"""
                          [CqlValueSetDefinition({{quotedName}}, valueSetId: {{quotedValueSetId}}, valueSetVersion: {{quotedValueSetVersion}})]
                          public CqlValueSet {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlValueSet {{fieldName}} = new CqlValueSet({{quotedValueSetId}}, {{quotedValueSetVersion}});
                          """);
                }
                    return;

                case CqlConceptDefinition ccd:
                {
                    string quotedConceptDisplay = ccd.Display.QuoteOrNullString();
                    string arrayOfCodes = string.Join(
                        ",",
                        ccd.Codes.Select(code =>
                        {
                            var cqlCodeDefinition = LibraryWriter.CodeDefinitions.FirstOrDefault(codeDefinition => codeDefinition.Code == code);
                            var codeField = cqlCodeDefinition is not null
                                                ? IdentifierNormalizer.Normalize($"_{cqlCodeDefinition.Name}")
                                                : $"new CqlCode({code.code!.QuoteString()}, {code.system.QuoteOrNullString()})";
                            return $"""

                                          {codeField}
                                    """;
                        }));
                    tw.WriteLine(
                        $$"""
                          [CqlConceptDefinition({{quotedName}})]
                          public CqlConcept {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlConcept {{fieldName}} =
                            new CqlConcept([{{arrayOfCodes}}],
                                {{quotedConceptDisplay}});
                          """);
                }
                    return;

                case CqlCodeSystemDefinition csd:
                {
                    string quotedCodeSystemId = csd.CodeSystem.id!.QuoteString();
                    string quotedCodeSystemVersion = csd.CodeSystem.version.QuoteOrNullString();
                    string arrayOfCodes = string.Join(
                        ",",
                        csd.CodeSystem.codes.Select(code =>
                        {
                            var cqlCodeDefinition = LibraryWriter.CodeDefinitions.FirstOrDefault(codeDefinition => codeDefinition.Code == code);
                            var codeField = cqlCodeDefinition is not null
                                                ? IdentifierNormalizer.Normalize($"_{cqlCodeDefinition.Name}")
                                                : $"new CqlCode({code.code!.QuoteString()}, {code.system.QuoteOrNullString()})";
                            return $"""

                                          {codeField}
                                    """;
                        }));
                    tw.WriteLine(
                        $$"""
                          [CqlCodeSystemDefinition({{quotedName}}, codeSystemId: {{quotedCodeSystemId}}, codeSystemVersion: {{quotedCodeSystemVersion}})]
                          public CqlCodeSystem {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlCodeSystem {{fieldName}} =
                            new CqlCodeSystem({{quotedCodeSystemId}}, {{quotedCodeSystemVersion}}, [{{arrayOfCodes}}]);
                          """);
                }
                    return;

                case CqlCodeDefinition cd:
                {
                    var quotedCodeId = cd.Code.code!.QuoteString();
                    var quotedCodeSystem = cd.Code.system.QuoteOrNullString();
                    tw.WriteLine(
                        $$"""
                          [CqlCodeDefinition({{quotedName}}, codeId: {{quotedCodeId}}, codeSystem: {{quotedCodeSystem}})]
                          public CqlCode {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlCode {{fieldName}} = new CqlCode({{quotedCodeId}}, {{quotedCodeSystem}});
                          """);
                }
                    return;
            }

            if (CqlDefinition is not CqlLambdaDefinition ld)
                throw new NotSupportedException($"No support for {CqlDefinition.GetType()}");

            tw.WriteLine(
                $"""
                 [{definitionAttributeTypeName}({quotedName})]
                 """);

            if (CqlDefinition is CqlExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        tw.WriteLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            VariableNameGenerator variableNameGenerator = new([], postfix: "_");

            var visitedBody = Transform(
                ld.LambdaExpression.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(variableNameGenerator),
                new LocalVariableDeduper(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter)
            );

            // Skip CqlContext
            var definitionToCSharpCodeProcessor = new LibraryDefinitionCSharpCodeGenerator(
                LibraryWriter.LibrarySetWriter.TupleMetadataBuilder,
                LibraryWriter.LibraryName,
                LibraryWriter.LibrarySetWriter.TypeToCSharpConverter,
                0);

            var parameters = ld.LambdaExpression.Parameters.Skip(1);
            var transformedLambda = Expression.Lambda(visitedBody, parameters);

            // Extract original parameter names if this is a CqlFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames = CqlDefinition is CqlFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                                                                              ? functionDef.OriginalParameterNames
                                                                              : null;

            var definitionWithBody = definitionToCSharpCodeProcessor.ProcessDefinition(transformedLambda, methodName, specifiers: "public", originalParameterNames);
            tw.WriteLine(definitionWithBody);
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }
    }

}