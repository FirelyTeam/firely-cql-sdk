/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Ir;

namespace Hl7.Cql.CodeGeneration.NET;

partial class IrLibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Port of <c>LibrarySetCSharpCodeGenerator.LambdaDefinitionWriter</c>'s non-body logic
    /// (attributes incl. tags, cache-key generation + <c>GetOrCompute</c> wrapper for
    /// parameterless definitions, method naming, parameter list, return type) onto
    /// <see cref="IrLambdaDefinition"/>. The method bodies themselves are produced by
    /// <see cref="CSharpIrEmitter"/> — which replaces the old writer's four visitor passes
    /// plus recursive <c>BuildExpression</c> printing.
    /// </summary>
    private record LambdaDefinitionWriter(LibraryWriter LibraryWriter)
    {
        private TypeToCSharpConverter TypeToCSharpConverter => LibraryWriter.LibrarySetWriter.TypeToCSharpConverter;

        private IndentedStringBuilder ISB => LibraryWriter.ISB;

        public void AppendLambdaDefinition(
            IrLambdaDefinition ld)
        {
            var (quotedName, methodName, _) = GetMemberNames(ld);

            // NOTE: unlike the old CqlLambdaDefinition, the IR lambda does not carry the
            // implicit CqlContext parameter (see IrLambdaDefinition remarks) — these are only
            // the CQL operands; the printed signature prepends "CqlContext context" explicitly.
            var parameters = ld.Lambda.Parameters;
            var returnType = TypeToCSharpConverter.ToCSharp(ld.Lambda.Body.Type);

            var useCache = parameters is not { Count: > 0 };

            // Emit the body before printing the signature: emitting is what assigns the
            // parameter names (honoring hints unless they collide), and it decides between
            // block form and the expression-bodied (=> expr;) form — the same decision the
            // old writer made on "did the visitors leave a BlockExpression".
            var emitter = LibraryWriter.Emitter;
            string lambdaBody;
            bool bodyIsBlock;
            if (emitter.TryEmitExpressionBody(ld.Lambda) is { } expressionBody)
            {
                lambdaBody = expressionBody;
                bodyIsBlock = false;
            }
            else
            {
                lambdaBody = emitter.EmitBodyBlock(ld.Lambda);
                bodyIsBlock = true;
            }

            // Map the IR definition type onto the old attribute names:
            // IrExpressionDefinition => [CqlExpressionDefinition("...")], etc.
            var definitionAttributeTypeName = $"Cql{ld.GetType().Name["Ir".Length..]}";

            // [CqlExpressionDefinition("Patient")] or [CqlFunctionDefinition("Patient")]
            ISB.AppendLine($"[{definitionAttributeTypeName}({quotedName})]");

            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName2", "tagValue")]
            if (ld is IrExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        ISB.AppendLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            // Signature
            ISB.Append($"public {returnType} {methodName}");

            // Extract original parameter names if this is an IrFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames =
                ld is IrFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                    ? functionDef.OriginalParameterNames
                    : null;
            var lambdaParameters = BuildLambdaParameters(ld.Lambda, emitter.GetParameterNames(ld.Lambda), originalParameterNames);

            if (useCache)
            {
                // Generate cache key from library identifier and definition name
                var libraryVersionedIdentifier = LibraryWriter.LibraryName.ToString();
                var definitionName = ld.Name;
                var cacheKey = LibraryWriter.LibrarySetWriter.CacheKeyGenerator.GenerateCacheKey(libraryVersionedIdentifier, definitionName);
                var cacheIndexFieldName = $"_cacheIndex_{methodName}";
                var computeMethodName = $"{methodName}_Compute";

                // Public method delegates to context.GetOrCompute with a private compute method (no closure)
                ISB.AppendLine($"{lambdaParameters} =>");
                using (ISB.Indent())
                {
                    ISB.AppendLine($"context.GetOrCompute({cacheIndexFieldName}, {computeMethodName});");
                }
                ISB.AppendLine();

                // Const cache index field (value is a compile-time literal)
                ISB.AppendLine($"private const long {cacheIndexFieldName} = {cacheKey}L;");
                ISB.AppendLine();

                // Private compute method containing the actual logic
                var semicolon = bodyIsBlock ? "" : ";";
                var lambdaOperator = bodyIsBlock ? "" : " =>";
                ISB.AppendLine(
                    $"""
                     private {returnType} {computeMethodName}{lambdaParameters}{lambdaOperator}
                     {lambdaBody}{semicolon}

                     """);
            }
            else
            {
                var lambdaOperator = bodyIsBlock ? "" : " =>";
                var semicolon = bodyIsBlock ? "" : ";";
                ISB.AppendLine(
                    $"""
                     {lambdaParameters}{lambdaOperator}
                     {lambdaBody}{semicolon}

                     """);
            }
        }

        private string BuildLambdaParameters(
            IrLambda lambda,
            IReadOnlyList<string> parameterNames,
            IReadOnlyDictionary<string, string>? originalParameterNames)
        {
            var parameters = lambda.Parameters.Select((p, i) =>
            {
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(p.Type);
                var parameterName = parameterNames[i].EscapeKeywords();

                // Add attribute if original name differs from normalized name. The dictionary
                // is keyed by the normalized CQL operand name, which is the parameter's name
                // hint (the emitter only deviates from the hint on collisions).
                var attributePrefix = "";
                if (originalParameterNames?.TryGetValue(p.NameHint ?? parameterNames[i], out var originalName) == true)
                {
                    attributePrefix = $"[CqlFunctionParameter({originalName.QuoteString()})] ";
                }

                return $"{attributePrefix}{typeDeclaration} {parameterName}";
            }).ToList();

            // inserts the context parameter in the start of the parameter list; the IR lambda
            // does not carry it (see IrLambdaDefinition remarks) but the generated method does.
            parameters.Insert(0, "CqlContext context");

            return $"({string.Join(", ", parameters)})";
        }
    }
}
