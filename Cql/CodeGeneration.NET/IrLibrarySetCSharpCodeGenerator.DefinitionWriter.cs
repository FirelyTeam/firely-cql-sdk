/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;

namespace Hl7.Cql.CodeGeneration.NET;

partial class IrLibrarySetCSharpCodeGenerator
{
    // Verbatim port of LibrarySetCSharpCodeGenerator.DefinitionWriter onto the typed IR:
    // the value set / concept / code system / code writers are Expression-free and copied
    // as-is; only the lambda definitions dispatch to the IR-based LambdaDefinitionWriter.
    private class DefinitionWriter
    {
        private readonly LambdaDefinitionWriter _lambdaDefinitionWriter;

        public DefinitionWriter(
            LibraryWriter LibraryWriter,
            IrDefinition IrDefinition)
        {
            this.LibraryWriter = LibraryWriter;
            this.IrDefinition = IrDefinition;
            _lambdaDefinitionWriter = new LambdaDefinitionWriter(this.LibraryWriter);
        }

        private IndentedStringBuilder ISB => LibraryWriter.ISB;
        public LibraryWriter LibraryWriter { get; }
        public IrDefinition IrDefinition { get; }

        public void AppendDefinition()
        {
            switch (IrDefinition)
            {
                case IrValueSetDefinition vsd:
                    AppendValueSetDefinition(vsd);
                    return;

                case IrConceptDefinition ccd:
                    AppendConceptDefinition(ccd);
                    return;

                case IrCodeSystemDefinition csd:
                    AppendCodeSystemDefinition(csd);
                    return;

                case IrCodeDefinition cd:
                    AppendCodeDefinition(cd);
                    return;

                case IrLambdaDefinition ld:
                    _lambdaDefinitionWriter.AppendLambdaDefinition(ld);
                    break;

                default:
                    throw new NotSupportedException($"No support for {IrDefinition.GetType()}");
            }
        }

        private void AppendCodeDefinition(
            IrCodeDefinition cd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(IrDefinition);
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
            IrCodeSystemDefinition csd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(IrDefinition);
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
            IrConceptDefinition ccd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(IrDefinition);
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
            IrValueSetDefinition vsd)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(IrDefinition);
            string quotedValueSetId = vsd.ValueSetId.QuoteString();
            string quotedValueSetVersion = vsd.ValueSetVersion.QuoteOrNullString();
            ISB.AppendLine(
                $$"""
                  [CqlValueSetDefinition({{quotedName}}, valueSetId: {{quotedValueSetId}}, valueSetVersion: {{quotedValueSetVersion}})]
                  public CqlValueSet {{methodName}}(CqlContext _) => {{fieldName}};
                  private static readonly CqlValueSet {{fieldName}} = new CqlValueSet({{quotedValueSetId}}, {{quotedValueSetVersion}});
                  """);
        }
    }
}
