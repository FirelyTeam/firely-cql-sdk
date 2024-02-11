/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Hl7.Cql.Compiler.Infrastructure;
using elm = Hl7.Cql.Elm;


namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The TypeManager class maps ELM types to .NET types usually through its <see cref="Resolver"/>, and
    /// also creates new types (e.g. for Tuples) as needed.
    /// </summary>
    internal class TypeManager
    {
        /// <summary>
        /// Gets the assembly name for any generated types created by this type manager.
        /// </summary>
        public string AssemblyName { get; }
        /// <summary>
        /// Gets the <see cref="TypeResolver"/> this TypeManager uses.
        /// </summary>
        public TypeResolver Resolver { get; }
        /// <summary>
        /// Gets the namespace for generated tuple types as supplied in the constructor.
        /// </summary>
        public string TupleTypeNamespace { get; }
        /// <summary>
        /// Gets the tuple types created by this <see cref="TypeManager"/>.
        /// </summary>
        public IEnumerable<Type> TupleTypes => TupleTypeList;

        private readonly List<Type> TupleTypeList = new List<Type>();
        private ModuleBuilder ModuleBuilder { get; }
        internal Hasher Hasher { get; } = new Hasher();

        /// <summary>
        /// Creates an instance with the specified resolver, assembly name, and tuple type namespace.
        /// </summary>
        /// <param name="resolver">The <see cref="TypeResolver"/> that this instance uses.</param>
        /// <param name="assemblyName">The name of the assembly in which generated tuple types will be created. If not specified, the value will be "Tuples".</param>
        /// <param name="tupleTypeNamespace">The namespace of all generated tuple types.  If not specified, the value will be "Tuples".</param>
        /// <exception cref="ArgumentNullException">If <paramref name="resolver"/> is <c>null</c>.</exception>
        public TypeManager(TypeResolver resolver, string assemblyName = "Tuples", string? tupleTypeNamespace = "Tuples")
        {
            if (string.IsNullOrWhiteSpace(assemblyName))
                assemblyName = "Tuples";
            if (string.IsNullOrWhiteSpace(tupleTypeNamespace))
                tupleTypeNamespace = "Tuples";
            AssemblyName = assemblyName;
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(AssemblyName), AssemblyBuilderAccess.Run);
            ModuleBuilder = assemblyBuilder.DefineDynamicModule(AssemblyName);
            Resolver = resolver.ArgNotNull();
            TupleTypeNamespace = tupleTypeNamespace;
        }

        internal Type? TypeFor(
            Element element,
            ExpressionBuilderContext context,
            bool throwIfNotFound = true)
        {
            if (element?.resultTypeSpecifier != null)
                return TypeFor(element.resultTypeSpecifier, context);

            if (!string.IsNullOrWhiteSpace(element?.resultTypeName?.Name))
                return Resolver.ResolveType(element!.resultTypeName!.Name)
                       ?? throw new ArgumentException("Cannot resolve type for expression");

            switch (element)
            {
                case ExpressionRef expressionRef:
                {
                    var libraryName = expressionRef.libraryName ?? context.Builder.LibraryKey;
                    if (!context.Definitions.TryGetValue(libraryName, expressionRef.name, out var definition))
                        throw new InvalidOperationException($"Unabled to get an expression by name : '{libraryName}.{expressionRef.name}'");

                    var returnType = definition!.ReturnType;
                    if (ReflectionUtility.IsNullable(returnType))
                        returnType = returnType.GetGenericArguments()[0];

                    return returnType;
                }

                case ExpressionDef { expression: not null } def:
                {
                    var type = TypeFor(def.expression, context, false);
                    if (type == null)
                    {
                        if (def.expression is SingletonFrom singleton)
                        {
                            type = TypeFor(singleton, context, false);
                            if (type == null)
                            {
                                if (singleton.operand is Retrieve retrieve && retrieve.dataType != null)
                                {
                                    type = Resolver.ResolveType(retrieve.dataType.Name);
                                    if (type != null)
                                        return type;
                                }
                            }
                            else return type;
                        }
                    }

                    break;
                }

                case Property propertyExpression when !string.IsNullOrWhiteSpace(propertyExpression.path):
                {
                    Type? sourceType = null;
                    if (propertyExpression.source != null)
                        sourceType = TypeFor(propertyExpression.source!, context);
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
                        return typeof(object); // this is likely a choice
                    }

                    break;
                }

                case AliasRef aliasRef when !string.IsNullOrWhiteSpace(aliasRef.name):
                {
                    var scope = context.GetScope(aliasRef.name);
                    return scope.Item1.Type;
                }

                case OperandRef operandRef when !string.IsNullOrWhiteSpace(operandRef.name):
                {
                    context.Operands.TryGetValue(operandRef.name, out var operand);
                    if (operand != null)
                        return operand.Type;
                    break;
                }
            }
            if (throwIfNotFound)
                throw new ArgumentException("Cannot resolve type for expression");
            
            return null;
        }

        internal Type TypeFor(TypeSpecifier resultTypeSpecifier,
            ExpressionBuilderContext context)
        {
            if (resultTypeSpecifier == null) 
                return typeof(object);

            if (resultTypeSpecifier is IntervalTypeSpecifier interval)
            {
                var pointType = TypeFor(interval.pointType!, context);
                var intervalType = typeof(CqlInterval<>).MakeGenericType(pointType);
                return intervalType;
            }

            if (resultTypeSpecifier is NamedTypeSpecifier named)
            {
                var type = Resolver.ResolveType(named.name.Name!);
                if (type == null)
                    throw new ArgumentException("Cannot resolve type for expression");
                return type!;
            }

            if (resultTypeSpecifier is ChoiceTypeSpecifier)
            {
                return typeof(object);
            }

            if (resultTypeSpecifier is ListTypeSpecifier list)
            {
                if (list.elementType == null)
                    throw new ArgumentException("ListTypeSpecifier must have a non-null elementType");
                var elementType = TypeFor(list.elementType, context);
                if (elementType == null)
                    throw new ArgumentException("Cannot resolve type for expression");

                var enumerableOfElementType = typeof(IEnumerable<>).MakeGenericType(elementType);
                return enumerableOfElementType;
            }

            if (resultTypeSpecifier is TupleTypeSpecifier tuple)
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
                    return TypeFor(tuple.resultTypeSpecifier, context);

                return TupleTypeFor(tuple, context);
            }

            throw new NotImplementedException();
        }

        internal static string PrettyTypeName(Type type)
        {
            string typeName = type.Name;
            if (type.IsGenericType)
            {
                if (type.IsGenericTypeDefinition == false && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    typeName = Nullable.GetUnderlyingType(type)!.Name;
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

        internal Type TupleTypeFor(TupleTypeSpecifier tuple, ExpressionBuilderContext context, Func<Type, Type>? changeType = null)
        {
            var elements = tuple.element;

            if (elements?.Length == 0)
                return typeof(object);

            var elementTuples = elements!
                .Select(e => (e.name, e.elementType))
                .ToArray();
            return TupleTypeFor(elementTuples, context, changeType);
        }

        internal Type TupleTypeFor(elm.Tuple tuple, ExpressionBuilderContext context, Func<Type, Type>? changeType = null)
        {
            var elements = tuple.element;

            if (elements?.Length == 0)
                return typeof(object);

            var elementTuples = elements!
                .Select(e => (e.name, e.value.resultTypeSpecifier.NotNull($"Tuple element value does not have a resultTypeSpecifier")))
                .ToArray();
            return TupleTypeFor(elementTuples, context, changeType);
        }

        internal Type TupleTypeFor((string name, TypeSpecifier elementType)[] elements, ExpressionBuilderContext context, Func<Type, Type>? changeType)
        {
            var elementInfo = elements!
                                .ToDictionary(el => el.name, el =>
                                {
                                    Type? type;
                                    if (el.elementType != null)
                                        type = TypeFor(el.elementType!, context);
                                    else
                                    {
                                        var msg = $"Tuple element {el.name} has a null {nameof(el.elementType)} property.  This property is required.";
                                        context.LogError(msg);
                                        throw new InvalidOperationException(msg);
                                    }
                                    if (changeType != null)
                                        type = changeType(type);
                                    return type;
                                });
            var allTypes = TupleTypes;
            foreach (var type in allTypes)
            {
                var typeIsMatch = true;
                foreach (var kvp in elementInfo)
                {
                    var normalizedKey = ExpressionBuilderContext.NormalizeIdentifier(kvp.Key);
                    var typeProperty = type.GetProperty(normalizedKey!);
                    if (typeProperty == null || typeProperty.PropertyType != kvp.Value)
                    {
                        typeIsMatch = false;
                        break;
                    }
                }
                if (typeIsMatch)
                    return type;
            }

            var typeName = $"{TupleTypeNamespace}.{TupleTypeNameFor(elementInfo)}";

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
            AddTupleType(typeInfo!);
            return typeInfo!;
        }

        /// <summary>
        /// Gets a unique tuple name given the elements (members) of the type.
        /// This method must return the same value for equal values of <paramref name="elementInfo"/>.
        /// Equality is determined by comparing <see cref="KeyValuePair{TKey,TValue}.Key"/> using default string equality
        /// and <see cref="KeyValuePair{TKey,TValue}.Value"/> using default equality.
        /// </summary>
        /// <param name="elementInfo">Key value pairs where key is the name of the element and the value is its type.</param>
        /// <returns>The unique tuple type name.</returns>
        protected virtual string TupleTypeNameFor(IEnumerable<KeyValuePair<string, Type>> elementInfo)
        {
            var hashInput = string.Join("+", elementInfo
                .OrderBy(k => k.Key)
                .Select(kvp => $"{kvp.Key}:{PrettyTypeName(kvp.Value)}"));
            var tupleId = Hasher.Hash(hashInput);
            var ns = TupleTypeNamespace;
            return $"Tuple_{tupleId}";
        }


        private void AddTupleType(Type type)
        {
            if (TupleTypeList.Contains(type))
                throw new ArgumentException($"Type {type.Name} already exists", nameof(type));
            TupleTypeList.Add(type);
        }

        private static void DefineProperty(TypeBuilder myTypeBuilder, string normalizedName, string cqlName, Type type)
        {
            var fieldBuilder = myTypeBuilder.DefineField($"_{normalizedName}", type, FieldAttributes.Private);
            var propertyBuilder = myTypeBuilder.DefineProperty(normalizedName, PropertyAttributes.None, type, null);
            var customAttributeBuilder = new CustomAttributeBuilder(typeof(CqlDeclarationAttribute).GetConstructor(new[] { typeof(string) })!, new object?[] { cqlName });
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
