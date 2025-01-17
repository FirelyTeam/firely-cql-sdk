using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model
{
    internal class ModelDefinition
    {
        public ModelDefinition(string name,
            string version,
            string url)
        {
            Name = name;
            Version = version;
            Uri = url;
        }

        public string Name { get; }
        public string Version { get; }
        public string Uri { get; }

        internal Dictionary<string, ContextDefinition> Contexts { get; set; } = new();

        internal Dictionary<string, TypeDefinition> TypeDefinitions { get; set; } = new();
        internal Dictionary<TypeSpecifier, Dictionary<TypeSpecifier, string>> ImplicitConversions { get; set; } =
            new(EqualityComparer<TypeSpecifier>.Default);

        public bool TryGetType(string qualifiedName, [NotNullWhen(true)] out TypeDefinition? type) =>
            TypeDefinitions.TryGetValue(qualifiedName, out type);

        public bool TryGetImplicitConversion(TypeSpecifier from, TypeSpecifier to, [NotNullWhen(true)] out string? function)
        {
            if (ImplicitConversions.TryGetValue(from, out var tos))
            {
                if (tos.TryGetValue(to, out function))
                    return true;
            }
            function = null;
            return false;
        }

        public IEnumerable<KeyValuePair<TypeSpecifier, string>> ImplicitConversionsFrom(TypeSpecifier from) =>
            ImplicitConversions.TryGetValue(from, out var tos)
                ? tos.Select(kvp => new KeyValuePair<TypeSpecifier, string>(kvp.Key, kvp.Value))
                : Enumerable.Empty<KeyValuePair<TypeSpecifier, string>>();

    }

    internal abstract class TypeDefinition
    {
        protected TypeDefinition(string name, ModelDefinition model, AccessModifier access)
        {
            Name = name;
            Model = model;
            Access = access;
        }

        public string Name { get; internal set; }

        public AccessModifier Access { get; internal set; }

        /// <summary>
        /// The canonical URI of the profile of this type, if applicable.
        /// </summary>
        public string? Identifier { get; internal set; }

        public TypeDefinition? BaseType { get; internal set; }

        public ModelDefinition Model { get; internal set; }

        public abstract TypeSpecifier ToTypeSpecifier();
    }

    internal class SimpleTypeDefinition : TypeDefinition
    {
        internal SimpleTypeDefinition(string name, ModelDefinition model, AccessModifier access)
            : base(name, model, access)
        {
        }
        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }

    internal class ClassTypeDefinition : TypeDefinition
    {
        internal ClassTypeDefinition(string name,
            ModelDefinition model,
            AccessModifier access) : base(name, model,access)
        {
            Elements = new ReadOnlyCollection<ClassTypeElementDefinition>([]);
        }

        public ReadOnlyCollection<ClassTypeElementDefinition> Elements { get; internal set; }

        public bool TryGetElement(string name, [NotNullWhen(true)] out ClassTypeElementDefinition? element)
        {
            foreach (var e in Elements)
            {
                if (e.Name == name)
                {
                    element = e;
                    return true;
                }
            }
            element = null;
            return false;
        }

        /// <summary>
        /// If this type is retrievable, this element definition is the code path to use
        /// in retrieves when no code property is explicitly declared.
        /// </summary>
        public ClassTypeElementDefinition? PrimaryCodePath { get; internal set; }

        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }

    internal class GenericTypeDefinition : ClassTypeDefinition
    {
        public static GenericTypeDefinition CreateTemplate(string name,
            ModelDefinition model,
            IList<GenericArgumentSpecifier> arguments,
            IDictionary<GenericArgumentSpecifier, TypeSpecifier> constraints,
            TypeDefinition baseType,
            AccessModifier access) =>
            new(name,
                model,
                arguments.Cast<TypeSpecifier>().ToList(),
                constraints.ToDictionary(kvp=>kvp.Key as TypeSpecifier, kvp=>kvp.Value),
                baseType,
                access);
        public static GenericTypeDefinition Create(GenericTypeDefinition template,
            IDictionary<GenericArgumentSpecifier, TypeSpecifier> argumentBindings)
        {
            var orderedArgs = new TypeSpecifier[argumentBindings.Count];
            foreach (var kvp in argumentBindings)
            {
                int index = -1;
                for(int i = 0; i < template.Arguments.Count; i++)
                {
                    if (template.Arguments[i].Equals(kvp.Key.Argument))
                    {
                        index = i;
                        break;
                    }
                }
                if (index > -1)
                    orderedArgs[index] = kvp.Value;
                else throw new ArgumentException($"Argument {kvp.Key.Argument} is not an argument of template {template.Name}");
            }
            return new GenericTypeDefinition(template.Name, template.Model, orderedArgs, null, template.BaseType!, AccessModifier.Public);
        }

        private GenericTypeDefinition(string name,
            ModelDefinition model,
            IList<TypeSpecifier> arguments,
            IDictionary<TypeSpecifier, TypeSpecifier>? constraints,
            TypeDefinition baseType,
            AccessModifier access) : base(name, model, access)
        {
            Arguments = arguments.AsReadOnly();
            BaseType = baseType;
            Constraints = (constraints ?? new Dictionary<TypeSpecifier,TypeSpecifier>()).AsReadOnly();

        }

        /// <summary>
        /// Maps the names of arguments to their constraints.
        /// Types without practical constraints should use some base type, such as System.Any.
        /// </summary>
        public IReadOnlyDictionary<TypeSpecifier, TypeSpecifier> Constraints { get; }
        public IReadOnlyList<TypeSpecifier> Arguments { get; }
        public override TypeSpecifier ToTypeSpecifier() => new GenericTypeSpecifier(this, Arguments);

        public bool IsTemplate => Arguments.All(arg=>arg is GenericArgumentSpecifier);

        public GenericTypeDefinition MakeGenericType(params TypeSpecifier[] arguments) =>
            IsTemplate switch
            {
                true => new(Name, Model, arguments, null, BaseType!, Access),
                false => throw new InvalidOperationException("This is not a generic template.")
            };
    }

    internal class ClassTypeElementDefinition
    {

        public ClassTypeElementDefinition(string name, TypeSpecifier type, string? targetCql)
        {
            Name = name;
            Type = type;
            TargetCql = targetCql;
        }

        public string Name { get; }

        public TypeSpecifier Type { get; }

        public string? TargetCql { get; }

    }


    internal abstract class TypeSpecifier: IEquatable<TypeSpecifier>
    {
        public abstract bool Equals(TypeSpecifier? other);
        public abstract bool IsSubtypeOf(TypeSpecifier other);
        protected internal abstract TypeDefinition? GetTypeDefinition();
    }

    internal class NamedTypeSpecifier: TypeSpecifier
    {
        public NamedTypeSpecifier(TypeDefinition type)
        {
            Type = type;
        }

        public TypeDefinition Type { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is NamedTypeSpecifier otherNts)
                return Type.Name == otherNts.Type.Name;
            else return false;
        }

        protected internal override TypeDefinition? GetTypeDefinition() => Type;
        public override bool IsSubtypeOf(TypeSpecifier other)
        {
            var otherType = other.GetTypeDefinition();
            if (otherType != null)
            {
                var t = Type;
                while (t != null)
                {
                    if (t.Equals(otherType))
                        return true;
                    else t = t.BaseType;
                }
                return false;
            }
            return false;
        }

        public override string ToString() => $"{Type.Model.Name}.{Type.Name}";

        public override int GetHashCode() => typeof(NamedTypeSpecifier).GetHashCode() ^ Type.Name.GetHashCode();

        
    }

    internal class ChoiceTypeSpecifier : TypeSpecifier
    {
        public ChoiceTypeSpecifier(TypeSpecifier[] choices)
        {
            Choices = choices;
        }

        public TypeSpecifier[] Choices { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is ChoiceTypeSpecifier otherChoice)
                return setEquals(Choices, otherChoice.Choices);
            else return false;
            // TODO: this is a copy from the ELM version
            bool setEquals<T>(IEnumerable<T>? a, IEnumerable<T>? b)
            {
                // tried using HashSet<>.SetEquals and it does not work even though all hashcodes are equal
                var bCodes = b?
                    .Select(_b => _b?.GetHashCode() ?? default)
                    .ToArray()
                    ?? Array.Empty<int>();
                if (a?.Count() != b?.Count())
                    return false;
                foreach (var aCode in a?.Select(_a => _a?.GetHashCode() ?? default) ?? Enumerable.Empty<int>())
                {
                    if (!bCodes.Contains(aCode))
                        return false;
                }
                return true;
            }
        }

        // choice types are never subtypes of other types
        public override bool IsSubtypeOf(TypeSpecifier other) => false;
        // choices don't have a single type definition
        protected internal override TypeDefinition? GetTypeDefinition() => null;

        public override string ToString() =>
            $"Choice<{string.Join(", ", Choices.Select(c=>c.ToString()))}>";

        public override int GetHashCode()
        {
            var code = typeof(ChoiceTypeSpecifier).GetHashCode();
            foreach(var choice in Choices)
            {
                code ^= choice.GetHashCode();
            }
            return code;
        }

    }

    internal class GenericTypeSpecifier : TypeSpecifier
    {
        public GenericTypeSpecifier(GenericTypeDefinition type, IEnumerable<TypeSpecifier> arguments)
        {
            Type = type;
            Arguments = arguments.ToList().AsReadOnly();
        }

        public GenericTypeDefinition Type { get; }

        public IReadOnlyList<TypeSpecifier> Arguments { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is GenericTypeSpecifier otherGts)
            {
                return Type.Name == otherGts.Type.Name
                    && Arguments.SequenceEqual(otherGts.Arguments);
            }
            else
                return false;
        }

        public override bool IsSubtypeOf(TypeSpecifier other)
        {
            var otherType = other.GetTypeDefinition();
            if (otherType != null)
            {
                TypeDefinition? t = Type;
                while (t != null)
                {
                    if (t.Equals(otherType))
                        return true;
                    else t = t.BaseType;
                }
                return false;
            }
            return false;
        }

        public override string ToString() =>
            $"{Type.Name}<{string.Join(", ", Arguments.Select(c=>c.ToString()))}>";

        protected internal override TypeDefinition? GetTypeDefinition() => Type;

        public override int GetHashCode()
        {
            var code = typeof(GenericArgumentSpecifier).GetHashCode() ^ Type.Name.GetHashCode();
            foreach (var arg in Arguments)
            {
                code ^= arg.GetHashCode();
            }
            return code;
        }
    }

    internal class GenericArgumentSpecifier : TypeSpecifier
    {
        public static readonly GenericArgumentSpecifier T = new("T");

        public GenericArgumentSpecifier(string argument)
        {
            Argument = argument;
        }
        public string Argument { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is GenericArgumentSpecifier otherGas)
                return Argument == otherGas.Argument;
            else
                return false;
        }

        public override bool IsSubtypeOf(TypeSpecifier other) => false;

        protected internal override TypeDefinition? GetTypeDefinition() => null;
        public override string ToString() => Argument;

        public override int GetHashCode() =>
            typeof(GenericArgumentSpecifier).GetHashCode() ^ Argument.GetHashCode();
    }

    internal class ContextDefinition
    {
        public ContextDefinition(string name, ModelDefinition model, TypeDefinition type)
        {
            Name = name;
            Model = model;
            Type = type;
        }

        public string Name { get; internal set; }
        public ModelDefinition Model { get; }
        public TypeDefinition Type { get; internal set; }
    }

    /// <summary>
    /// Public or private.
    /// </summary>
    public enum AccessModifier
    {
        /// <summary>
        /// Public
        /// </summary>
        Public,
        /// <summary>
        /// Private
        /// </summary>
        Private,
    }
}
