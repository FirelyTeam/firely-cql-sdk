using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using elm = Ncqa.Elm.Expressions;


namespace Ncqa.Cql.MeasureCompiler
{
    public class TypeManager
    {
        public string AssemblyName { get; } = "Ncqa.Cql.Generated";

        private IDictionary<string, IList<Type>> TupleTypes = new Dictionary<string, IList<Type>>();
        private ModuleBuilder ModuleBuilder { get; }
        public TypeResolver Resolver { get; }
        public string? TupleTypeNamespace { get; }
        public Hasher Hasher { get; } = new Hasher();

        public TypeManager(TypeResolver? resolver, string? tupleTypeNamespace = "Tuples")
        {
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(AssemblyName), AssemblyBuilderAccess.Run);
            ModuleBuilder = assemblyBuilder.DefineDynamicModule(AssemblyName);
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            TupleTypeNamespace = tupleTypeNamespace;
        }

        public Type? TypeFor(string library, 
            elm.Expression expression, 
            ExpressionBuilderContext context, 
            bool throwIfNotFound = true)
        {
            if (expression!.resultTypeSpecifier != null)
                return TypeFor(library, expression.resultTypeSpecifier, context);
            else if (!string.IsNullOrWhiteSpace(expression!.resultTypeName))
                return Resolver.ResolveType(expression!.resultTypeName!)
                    ?? throw new ArgumentException("Cannot resolve type for expression");
            else if (expression is elm.DefinitionExpression def && def.expression != null)
            {
                var type = TypeFor(library, def.expression, context, false);
                if (type == null)
                {
                    if (def.expression is elm.SingletonFromExpression singleton)
                    {
                        type = TypeFor(library, singleton, context, false);
                        if (type == null)
                        {
                            if (singleton.operand is elm.RetrieveExpression retrieve && retrieve.dataType != null)
                            {
                                type = Resolver.ResolveType(retrieve.dataType);
                                if (type != null)
                                    return type;
                            }
                        }
                        else return type;
                    }
                }
            }
            else if (expression is elm.PropertyExpression propertyExpression && !string.IsNullOrWhiteSpace(propertyExpression.path))
            {
                Type? sourceType = null;
                if (propertyExpression.source != null)
                    sourceType = TypeFor(library, propertyExpression.source!, context);
                else if (propertyExpression.scope != null)
                {
                    var scope = context.GetScope(propertyExpression.scope);
                    sourceType = scope.Item1.Type;
                }
                if (sourceType != null)
                {
                    var property = Resolver.GetProperty(sourceType, propertyExpression.path);
                    if (property != null)
                        return property.PropertyType;
                    else return typeof(object); // this is likely a choice
                }
            }
            else if (expression is elm.AliasRefExpression aliasRef && !string.IsNullOrWhiteSpace(aliasRef.name))
            {
                var scope = context.GetScope(aliasRef.name);
                return scope.Item1.Type;
            }
            if (throwIfNotFound)
                throw new ArgumentException("Cannot resolve type for expression");
            else return null;
        }

        public Type TypeFor(string library, 
            elm.TypeSpecifierExpression resultTypeSpecifier,
            ExpressionBuilderContext context,
            bool throwIfNotFound = true)
        {
            if (resultTypeSpecifier == null) return typeof(object);
            else if (resultTypeSpecifier.type == "IntervalTypeSpecifier")
            {
                var pointType = TypeFor(library, resultTypeSpecifier.pointType!, context);
                var intervalType = typeof(CqlInterval<>).MakeGenericType(pointType);
                return intervalType;
            }
            else if (resultTypeSpecifier.type == "NamedTypeSpecifier")
            {
                var type = Resolver.ResolveType(resultTypeSpecifier.name!);
                if (type == null && throwIfNotFound)
                    throw new ArgumentException("Cannot resolve type for expression");
                return type!;
            }
            else if (resultTypeSpecifier.type == "ChoiceTypeSpecifier")
            {
                return typeof(object);
            }
            else if (resultTypeSpecifier.type == "ListTypeSpecifier")
            {
                if (resultTypeSpecifier.elementType == null)
                    throw new ArgumentException("ListTypeSpecifier must have a non-null elementType");
                var elementType = TypeFor(library, resultTypeSpecifier.elementType, context);
                if (elementType == null && throwIfNotFound)
                    throw new ArgumentException("Cannot resolve type for expression");
                var enumerableOfElementType = typeof(IEnumerable<>).MakeGenericType(elementType);
                return enumerableOfElementType;
            }
            else if (resultTypeSpecifier.type == "TupleTypeSpecifier")
            {
                // witnessed in ELM:
                //"type" : "TupleTypeSpecifier",
                //"resultTypeSpecifier" : {
                //      "type" : "TupleTypeSpecifier",
                //      "element": { ... x ... }
                // },
                // "element": { ... y ... }
                //
                // In the example above, x and y have different structures.
                // Code handles x but not y
                if (resultTypeSpecifier.resultTypeSpecifier != null)
                    return TupleTypeFor(library, resultTypeSpecifier.resultTypeSpecifier, context);
                else return TupleTypeFor(library, resultTypeSpecifier, context);
            }
            else throw new NotImplementedException();
        }

        public static string PrettyTypeName(Type type)
        {
            string typeName = type.Name;
            if (type.IsGenericType)
            {
                if (type.IsGenericTypeDefinition == false && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    typeName = Nullable.GetUnderlyingType(type).Name;
                }
                else
                {
                    if (type.IsGenericType)
                    {
                        var tildeIndex = type.Name.IndexOf('`');
                        var rootName = type.Name.Substring(0, tildeIndex);
                        var genericArgumentNames = type.GetGenericArguments()
                            .Select(arg => PrettyTypeName(arg));
                        var prettyName = $"{rootName}{string.Join("", genericArgumentNames)}";
                        typeName = prettyName;
                    }
                }
            }
            return typeName;
        }

        public Type TupleTypeFor(string library, elm.TypeSpecifierExpression tuple, ExpressionBuilderContext context, Func<Type, Type>? changeType = null)
        {
            if (tuple.element?.Length == 0)
                return typeof(object);
            else
            {
                var elementInfo = tuple.element
                    .ToDictionary(el => el.name, el =>
                    {
                        Type? type;
                        if (el.elementType != null)
                            type = TypeFor(library, el.elementType!, context);
                        else
                        {
                            var msg = $"Tuple element {el.name} has a null {nameof(el.elementType)} property.  This property is required.";
                            context.LogError(msg, tuple);
                            throw new InvalidOperationException(msg);
                        }
                        if (changeType != null)
                            type = changeType(type);
                        return type;
                    });
                var allTypes = TupleTypes.Values
                    .SelectMany(type => type);
                foreach (var type in allTypes)
                {
                    var typeIsMatch = true;
                    foreach (var kvp in elementInfo)
                    {
                        var normalizedKey = ExpressionBuilderContext.NormalizeIdentifier(kvp.Key);
                        var typeProperty = type.GetProperty(normalizedKey);
                        if (typeProperty == null || typeProperty.PropertyType != kvp.Value)
                        {
                            typeIsMatch = false;
                            break;
                        }
                    }
                    if (typeIsMatch)
                        return type;
                }

                var hashInput = string.Join("+", elementInfo
                    .Keys
                    .OrderBy(k => k)
                    .Select(key => $"{key}:{PrettyTypeName(elementInfo[key])}"));
                var tupleId = Hasher.Hash(hashInput);
                var ns = TupleTypeNamespace ?? ExpressionBuilderContext.NormalizeIdentifier(library);
                var typeName = $"{TupleTypeNamespace}.Tuple_{tupleId}";
                var myTypeBuilder = ModuleBuilder.DefineType(typeName, TypeAttributes.Public | TypeAttributes.Class, typeof(TupleBaseType));

                foreach (var kvp in elementInfo)
                {
                    if (kvp.Key != null)
                    {
                        var name = ExpressionBuilderContext.NormalizeIdentifier(kvp.Key);
                        var type = kvp.Value;
                        DefineProperty(myTypeBuilder, name!, kvp.Key, type);
                    }
                }
                var typeInfo = myTypeBuilder.CreateTypeInfo();
                AddTupleType(library, typeInfo!);
                return typeInfo!;
            }

        }

        private void AddTupleType(string library, Type type)
        {
            if (!TupleTypes.TryGetValue(TupleTypeNamespace ?? library, out IList<Type> types))
            {
                types = new List<Type>();
                TupleTypes.Add(TupleTypeNamespace ?? library, types);
            }
            if (types.Contains(type))
                throw new ArgumentException($"Type {type.Name} already exists for library {library}", nameof(type));
            types.Add(type);
        }

        public IEnumerable<Type> GetTupleTypes(string library)
        {
            if (TupleTypes.TryGetValue(TupleTypeNamespace ?? library, out IList<Type> types))
                return types;
            else return Enumerable.Empty<Type>();
        }


        private static void DefineProperty(TypeBuilder myTypeBuilder, string normalizedName, string cqlName, Type type)
        {
            var fieldBuilder = myTypeBuilder.DefineField($"_{normalizedName}", type, FieldAttributes.Private);
            var propertyBuilder = myTypeBuilder.DefineProperty(normalizedName, PropertyAttributes.None, type, null);
            var customAttributeBuilder = new CustomAttributeBuilder(typeof(Runtime.CqlDeclarationAttribute).GetConstructor(new[] { typeof(string) }), new object?[] { cqlName });
            propertyBuilder.SetCustomAttribute(customAttributeBuilder);
            MethodAttributes attributes = MethodAttributes.Public
                    | MethodAttributes.SpecialName
                    | MethodAttributes.HideBySig;
            {
                var get = myTypeBuilder.DefineMethod($"get_{normalizedName}", attributes, type, Type.EmptyTypes);
                ILGenerator getIL = get.GetILGenerator();
                getIL.Emit(OpCodes.Ldarg_0);
                getIL.Emit(OpCodes.Ldfld, fieldBuilder);
                getIL.Emit(OpCodes.Ret);
                propertyBuilder.SetGetMethod(get);
            }

            {
                var set = myTypeBuilder.DefineMethod($"set_{normalizedName}", attributes, null, new Type[] { type });
                ILGenerator setIL = set.GetILGenerator();
                setIL.Emit(OpCodes.Ldarg_0);
                setIL.Emit(OpCodes.Ldarg_1);
                setIL.Emit(OpCodes.Stfld, fieldBuilder);
                setIL.Emit(OpCodes.Ret);
                propertyBuilder.SetSetMethod(set);
            }
        }


    }
}
