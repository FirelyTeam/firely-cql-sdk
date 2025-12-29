using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private record DefinitionWriter(
        LibraryWriter LibraryWriter,
        CqlDefinition CqlDefinition) : IAddIndentMutable<DefinitionWriter>
    {
        public DefinitionWriter AddIndent(int addIndent = 1) =>
            this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };

        // ReSharper disable once InconsistentNaming
        private IndentedStringBuilder isb => LibraryWriter.isb;

        public void WriteDefinition()
        {
            switch (CqlDefinition)
            {
                case CqlValueSetDefinition vsd:
                    WriteValueSetDefinition(vsd);
                    return;

                case CqlConceptDefinition ccd:
                    WriteConceptDefinition(ccd);
                    return;

                case CqlCodeSystemDefinition csd:
                    WriteCodeSystemDefinition(csd);
                    return;

                case CqlCodeDefinition cd:
                    WriteCodeDefinition(cd);
                    return;

                case CqlLambdaDefinition ld:
                    new LambdaDefinitionWriter(LibraryWriter, LibraryWriter.isb).WriteDefinition(ld);
                    break;

                default:
                    throw new NotSupportedException($"No support for {CqlDefinition.GetType()}");
            }
        }

        private void WriteCodeDefinition(
            CqlCodeDefinition cd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
            var quotedCodeId = cd.Code.code!.QuoteString();
            var quotedCodeSystem = cd.Code.system.QuoteOrNullString();
            isb.AppendLine(
                $$"""
                  [CqlCodeDefinition({{quotedName}}, codeId: {{quotedCodeId}}, codeSystem: {{quotedCodeSystem}})]
                  public CqlCode {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlCode {{fieldName}} = new CqlCode({{quotedCodeId}}, {{quotedCodeSystem}});
                  """);
        }

        private void WriteCodeSystemDefinition(
            CqlCodeSystemDefinition csd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
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
            isb.AppendLine(
                $$"""
                  [CqlCodeSystemDefinition({{quotedName}}, codeSystemId: {{quotedCodeSystemId}}, codeSystemVersion: {{quotedCodeSystemVersion}})]
                  public CqlCodeSystem {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlCodeSystem {{fieldName}} =
                    new CqlCodeSystem({{quotedCodeSystemId}}, {{quotedCodeSystemVersion}}, [{{arrayOfCodes}}]);
                  """);
        }

        private void WriteConceptDefinition(
            CqlConceptDefinition ccd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
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
            isb.AppendLine(
                $$"""
                  [CqlConceptDefinition({{quotedName}})]
                  public CqlConcept {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlConcept {{fieldName}} =
                    new CqlConcept([{{arrayOfCodes}}],
                        {{quotedConceptDisplay}});
                  """);
        }

        private void WriteValueSetDefinition(
            CqlValueSetDefinition vsd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
            string quotedValueSetId = vsd.ValueSetId.QuoteString();
            string quotedValueSetVersion = vsd.ValueSetVersion.QuoteOrNullString();
            isb.AppendLine(
                $$"""
                  [CqlValueSetDefinition({{quotedName}}, valueSetId: {{quotedValueSetId}}, valueSetVersion: {{quotedValueSetVersion}})]
                  public CqlValueSet {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlValueSet {{fieldName}} = new CqlValueSet({{quotedValueSetId}}, {{quotedValueSetVersion}});
                  """);
        }
    }
}