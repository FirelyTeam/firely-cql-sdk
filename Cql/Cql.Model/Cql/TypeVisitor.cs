using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar.r2;

namespace Hl7.Cql.Model.Cql;
internal class TypeVisitor(ModelDefinition model)
{
    public void ParseTypeDefinitions(cqlParser.TypeDefinitionContext[] typeDefs)
    {
        var types = new List<TypeDefinition>();
        var firstPassVisitor = new FirstPassTypeVisitor(model);

        foreach (var typeDef in typeDefs)
        {
            var type = firstPassVisitor.Visit(typeDef);
            types.Add(type);
            model.TypeDefinitions.Add(type.Name, type);
        }
        // all types have been defined.  now we can resolve base types, members, generic constraints, etc.
        foreach (var typeDef in typeDefs)
        {
            var literal = typeDef.literalTypeDefinition();
            if (literal is not null)
            {
                setBaseType(literal.identifier().GetText().Dequote()!, literal.baseType());
                continue;
            }
            var @class = typeDef.classTypeDefinition();
            if (@class is not null)
            {
                setBaseType(@class.identifier().GetText().Dequote()!, @class.baseType());
                setMembers(@class.identifier().GetText().Dequote()!, @class.classElements()?.classElement());
            }
            var generic = typeDef.genericTypeDefinition();
            if (generic is not null)
            {
                var typeName = generic.identifier().GetText().Dequote()!;
                setBaseType(typeName, generic.baseType());
                setMembers(typeName, generic.classElements()?.classElement());
                setConstraints(typeName, generic.genericTypeConstraint());
            }
        }

        void setBaseType(string typeName, cqlParser.BaseTypeContext? baseTypeCtx)
        {
            if (model.TryGetType(typeName, out var type))
            {
                if (baseTypeCtx is not null)
                {
                    var baseType = parseBaseTypeSpecifier(baseTypeCtx.baseTypeSpecifier(),
                        type switch
                        {
                            GenericTypeDefinition gtd when gtd.IsTemplate => gtd.Arguments.Cast<GenericArgumentSpecifier>(),
                            _ => null,
                        });
                    if (baseType is not null)
                    {
                        type.BaseType = baseType.GetTypeDefinition();
                    }
                    else model.AddError($"Base type {baseTypeCtx.baseTypeSpecifier().GetText()} not found.", baseTypeCtx.baseTypeSpecifier().ToErrorLocation());
                }
            }
            else throw new InvalidOperationException($"Type {typeName} not found during second pass.");
        }

        void setMembers(string typeName, cqlParser.ClassElementContext[]? classElementContexts)
        {
            if (model.TryGetType(typeName, out var type) && type is ClassTypeDefinition classType)
            {
                if (classElementContexts is not null)
                {
                    foreach (var member in classElementContexts)
                    {
                        var name = member.identifier().GetText().Dequote()!;
                        var memberType = parseTypeSpecifier(member.typeSpecifier(),
                            classType switch
                            {
                                GenericTypeDefinition gtd when gtd.IsTemplate => gtd.Arguments.Cast<GenericArgumentSpecifier>(),
                                _ => null,
                            });
                        if (memberType is not null)
                            classType.AddElement(new ClassTypeElementDefinition(name, memberType, null));
                        else model.AddError($"Type {member.typeSpecifier().GetText()} not found.", member.typeSpecifier().ToErrorLocation());
                    }
                }
            }
            else throw new InvalidOperationException($"Type {typeName} not found during second pass.");
        }

        void setConstraints(string typeName, cqlParser.GenericTypeConstraintContext[]? constraints)
        {
            if (constraints is not null)
            {
                if (model.TryGetType(typeName, out var type)
                    && type is GenericTypeDefinition genericType
                    && genericType.IsTemplate)
                {
                    foreach (var constraint in constraints)
                    {
                        var arg = constraint.identifier().GetText().Dequote()!;
                        var argSpec = new GenericArgumentSpecifier(arg);
                        var constraintSpec = parseTypeSpecifier(constraint.typeSpecifier(), null);
                        if (constraintSpec is not null)
                        {
                            if (genericType.Arguments.Cast<GenericArgumentSpecifier>().Any(a => a.Argument == arg))
                                genericType.ArgumentConstraints[argSpec] = constraintSpec;
                            else model.AddError($"Argument {arg} not found in generic type {typeName}.", constraint.identifier().ToErrorLocation());
                        }
                        else model.AddError($"Type {constraint.typeSpecifier().GetText()} not found.", constraint.typeSpecifier().ToErrorLocation());
                    }
                }
                else throw new InvalidOperationException($"Type {typeName} not found during second pass.");
            }
        }

        ModelDefinition? getModel(string name)
        {
            if (name == model.Name)
                return model;
            else if (model.RequiredModels.TryGetValue(name, out var requiredModel))
                return requiredModel;
            else return null;
        }


        TypeSpecifier? parseBaseTypeSpecifier(cqlParser.BaseTypeSpecifierContext? context,
             IEnumerable<GenericArgumentSpecifier>? genericArgs)
        {
            if (context is null)
                return null;
            var nts = context.namedTypeSpecifier();
            if (nts is not null)
                return parseNamedTypeSpecifier(nts, genericArgs);
            var gts = context.genericTypeSpecifier();
            if (gts is not null)
                return parseGenericTypeSpecifier(gts, genericArgs);
            return null;
        }

        TypeSpecifier? parseTypeSpecifier(cqlParser.TypeSpecifierContext? context,
             IEnumerable<GenericArgumentSpecifier>? genericArgs)
        {
            if (context is null)
                return null;
            var nts = context.namedTypeSpecifier();
            if (nts is not null)
                return parseNamedTypeSpecifier(nts, genericArgs);
            var gts = context.genericTypeSpecifier();
            if (gts is not null)
                return parseGenericTypeSpecifier(gts, genericArgs);
            var cts = context.choiceTypeSpecifier();
            if (cts is not null)
                return parseChoiceTypeSpecifier(cts, genericArgs);
            return null;
        }

        TypeSpecifier? parseNamedTypeSpecifier(cqlParser.NamedTypeSpecifierContext nts,
            IEnumerable<GenericArgumentSpecifier>? genericArgs)
        {

            var typeName = nts!.qualifiedIdentifier().GetText().Dequote();
            var matchingArgs = genericArgs?.Where(arg => arg.Argument == typeName).ToArray();
            var matchingArg = matchingArgs?.Length switch
            {
                null or 0 => null,
                1 => matchingArgs[0],
                _ => throw new InvalidOperationException($"Generic argument {typeName} is ambiguous."),
            };
            if (matchingArg is not null)
                return matchingArg;
            else
            {
                var typeDef = getNamedType(typeName);
                return typeDef?.ToTypeSpecifier();
            }
        }

        TypeSpecifier? parseGenericTypeSpecifier(cqlParser.GenericTypeSpecifierContext gts,
             IEnumerable<GenericArgumentSpecifier>? genericArgs)
        {
            var typeDef = getNamedType(gts!.qualifiedIdentifier().GetText().Dequote());
            if (typeDef is GenericTypeDefinition gtd)
            {
                var args = gts!.typeSpecifier();
                var argSpecs = args.Select(arg => parseTypeSpecifier(arg, genericArgs)).ToList();
                if (argSpecs.Any(s => s is null))
                    return null;
                else
                    return new GenericTypeSpecifier(gtd, argSpecs.Cast<TypeSpecifier>());
            }
            else return null;
        }

        TypeSpecifier? parseChoiceTypeSpecifier(cqlParser.ChoiceTypeSpecifierContext cts,
            IEnumerable<GenericArgumentSpecifier>? genericArgs)
        {
            var args = cts!.typeSpecifier();
            var argSpecs = args.Select(arg => parseTypeSpecifier(arg, genericArgs)).ToList();
            if (argSpecs.Any(s => s is null))
                return null;
            else
                return new ChoiceTypeSpecifier(argSpecs.Cast<TypeSpecifier>().ToArray());
        }


        TypeDefinition? getNamedType(string? name)
        {
            if (name is null)
                return null;
            string[] parts = name.Split('.');
            if (parts.Length == 1) // no model specified
                return model.TryGetType(parts[0], out var type) ? type : null;
            else
            {
                for (int i = parts.Length; i > 0; i--)
                {
                    string modelName = string.Join(".", parts.Take(i));
                    ModelDefinition? model = getModel(modelName);
                    if (model != null)
                    {
                        string typeName = string.Join(".", parts.Skip(i));
                        if (model.TypeDefinitions.TryGetValue(typeName, out var type))
                            return type;
                    }
                }
            }
            return null;
        }

    }
}

file class FirstPassTypeVisitor(ModelDefinition model) : cqlBaseVisitor<TypeDefinition>
{
    public override TypeDefinition VisitLiteralTypeDefinition([NotNull] cqlParser.LiteralTypeDefinitionContext context)
    {
        var id = context.identifier().GetText().Dequote()!;
        var accessModifier = context.accessModifier().Parse();
        return new SimpleTypeDefinition(id, model, accessModifier);
    }

    public override TypeDefinition VisitClassTypeDefinition([NotNull] cqlParser.ClassTypeDefinitionContext context)
    {
        var id = context.identifier().GetText().Dequote()!;
        var accessModifier = context.accessModifier().Parse();
        return new ClassTypeDefinition(id, model, accessModifier);
    }

    public override TypeDefinition VisitGenericTypeDefinition([NotNull] cqlParser.GenericTypeDefinitionContext context)
    {
        var id = context.identifier().GetText().Dequote()!;
        var accessModifier = context.accessModifier().Parse();
        var genericArguments = context.genericArguments()?.identifier()
            .Select(id => new GenericArgumentSpecifier(id.GetText().Dequote()!))
            .ToArray()!;
        return GenericTypeDefinition.CreateTemplate(id,
            model,
            genericArguments,
            new Dictionary<GenericArgumentSpecifier, TypeSpecifier>(),
            null!,
            accessModifier);

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