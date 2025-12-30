using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private class DefinitionWriter
    {
        private readonly LambdaDefinitionWriter _lambdaDefinitionWriter;

        public DefinitionWriter(
            LibraryWriter LibraryWriter,
            CqlDefinition CqlDefinition)
        {
            this.LibraryWriter = LibraryWriter;
            this.CqlDefinition = CqlDefinition;
            _lambdaDefinitionWriter = new LambdaDefinitionWriter(this.LibraryWriter);
        }

        private IndentedStringBuilder ISB => LibraryWriter.ISB;
        public LibraryWriter LibraryWriter { get; }
        public CqlDefinition CqlDefinition { get; }

        public void AppendDefinition()
        {
            switch (CqlDefinition)
            {
                case CqlValueSetDefinition vsd:
                    AppendValueSetDefinition(vsd);
                    return;

                case CqlConceptDefinition ccd:
                    AppendConceptDefinition(ccd);
                    return;

                case CqlCodeSystemDefinition csd:
                    AppendCodeSystemDefinition(csd);
                    return;

                case CqlCodeDefinition cd:
                    AppendCodeDefinition(cd);
                    return;

                case CqlLambdaDefinition ld:
                    _lambdaDefinitionWriter.AppendLambdaDefinition(ld);
                    break;

                default:
                    throw new NotSupportedException($"No support for {CqlDefinition.GetType()}");
            }
        }

        private void AppendCodeDefinition(
            CqlCodeDefinition cd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
            var quotedCodeId = cd.Code.code!.QuoteString();
            var quotedCodeSystem = cd.Code.system.QuoteOrNullString();
            ISB.AppendLine(
                $$"""
                  [CqlCodeDefinition({{quotedName}}, codeId: {{quotedCodeId}}, codeSystem: {{quotedCodeSystem}})]
                  public CqlCode {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlCode {{fieldName}} = new CqlCode({{quotedCodeId}}, {{quotedCodeSystem}});
                  """);
        }

        private void AppendCodeSystemDefinition(
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
            ISB.AppendLine(
                $$"""
                  [CqlCodeSystemDefinition({{quotedName}}, codeSystemId: {{quotedCodeSystemId}}, codeSystemVersion: {{quotedCodeSystemVersion}})]
                  public CqlCodeSystem {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlCodeSystem {{fieldName}} =
                    new CqlCodeSystem({{quotedCodeSystemId}}, {{quotedCodeSystemVersion}}, [{{arrayOfCodes}}]);
                  """);
        }

        private void AppendConceptDefinition(
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
            ISB.AppendLine(
                $$"""
                  [CqlConceptDefinition({{quotedName}})]
                  public CqlConcept {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlConcept {{fieldName}} =
                    new CqlConcept([{{arrayOfCodes}}],
                        {{quotedConceptDisplay}});
                  """);
        }

        private void AppendValueSetDefinition(
            CqlValueSetDefinition vsd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(CqlDefinition);
            string quotedValueSetId = vsd.ValueSetId.QuoteString();
            string quotedValueSetVersion = vsd.ValueSetVersion.QuoteOrNullString();
            ISB.AppendLine(
                $$"""
                  [CqlValueSetDefinition({{quotedName}}, valueSetId: {{quotedValueSetId}}, valueSetVersion: {{quotedValueSetVersion}})]
                  public CqlValueSet {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlValueSet {{fieldName}} = new CqlValueSet({{quotedValueSetId}}, {{quotedValueSetVersion}});
                  """);
        }

        public void Deconstruct(
            out LibraryWriter LibraryWriter,
            out CqlDefinition CqlDefinition)
        {
            LibraryWriter = this.LibraryWriter;
            CqlDefinition = this.CqlDefinition;
        }
    }
}