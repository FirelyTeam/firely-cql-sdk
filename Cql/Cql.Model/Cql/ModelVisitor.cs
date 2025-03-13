using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CqlToElm.Grammar.r2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.Cql;
internal class ModelVisitor(IModelProvider ModelProvider) : cqlBaseVisitor<ModelDefinition>
{
    public override ModelDefinition VisitModel([NotNull] cqlParser.ModelContext context)
    {

        var def = context.modelIdentifier();
        var id = def.qualifiedIdentifier().GetText();
        var version = def.versionSpecifier().GetText().Detick()!;
        var uri = def.modelUri().GetText().Detick()!;

        var model = new ModelDefinition(id, version, uri);

        // usings first
        foreach (var defCtx in context.modelDefinition())
        {
            var @using = defCtx.usingDefinition();
            if (@using is not null)
            {
                var usedModel = Visit(@using);
                if (usedModel is not null)
                    model.RequiredModels.Add(@using.localIdentifier().GetText(), usedModel);
                else model.AddError($"Referenced model not found.", @using.ToErrorLocation());
            }
        }

        var typeVisitor = new TypeVisitor(model);
        var typeDefContexts = context.modelDefinition()
            .Select(def => def.typeDefinition())
            .Where(d => d is not null)
            .ToArray();

        typeVisitor.ParseTypeDefinitions(typeDefContexts);

        return model;



    }

    public override ModelDefinition VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
    {
        var id = context.qualifiedIdentifier().GetText();
        var version = context.versionSpecifier()?.GetText().Detick();
        var alias = context.localIdentifier()?.GetText() ?? id;
        if (ModelProvider.TryGetModel(id, version, out var model))
            return model;
        else return null!;
    }
}




file static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerStepThrough]
    public static string? Detick(this string? text)
    {
        if (text is not null)
        {
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerStepThrough]
    public static string? Dequote(this string? text)
    {
        if (text is not null)
        {
            if (text.StartsWith(@"""") && text.EndsWith(@""""))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerStepThrough]
    public static AccessModifier Parse(this cqlParser.AccessModifierContext accessModifierContext)
    {
        return accessModifierContext switch
        {
            null => AccessModifier.Public,
            _ => accessModifierContext.GetText() switch
            {
                "private" => AccessModifier.Private,
                _ => AccessModifier.Public
            }
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerStepThrough]
    public static Version Parse(this cqlParser.VersionSpecifierContext context) =>
        context switch
        {
            null => new Version(1, 0, 0),
            _ => Version.Parse(context.GetText().Detick()!)
        };
}