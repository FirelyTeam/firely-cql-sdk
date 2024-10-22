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
            string url,
            ClassTypeDefinition? patientType = null,
            ClassTypeElementDefinition? patientBirthDateElement = null)
        {
            Name = name;
            Version = version;
            Url = url;
            PatientType = patientType;
            PatientBirthDateElement = patientBirthDateElement;
        }

        public string Name { get; }
        public string Version { get; }
        public string Url { get; }
        //public string TargetQualifier { get; } // not sure what this is used for
        public ClassTypeDefinition? PatientType { get; internal set; }
        public ClassTypeElementDefinition? PatientBirthDateElement { get; internal set; }

        internal Dictionary<string, TypeDefinition> TypeDefinitions { get; set; } = new();
        internal Dictionary<TypeSpecifier, Dictionary<TypeSpecifier, string>> ImplicitConversions { get; set; } = new();

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
    }

    internal abstract class TypeDefinition
    {
        protected TypeDefinition(string name, ModelDefinition model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; internal set; }

        /// <summary>
        /// The canonical URI of the profile of this type, if applicable.
        /// </summary>
        public string? Identifier { get; internal set; }

        public TypeDefinition? BaseType { get; internal set; }

        public ModelDefinition Model { get; internal set; }


    }

    internal class SimpleTypeDefinition : TypeDefinition
    {
        internal SimpleTypeDefinition(string name, ModelDefinition model)
            : base(name, model)
        {
        }
        public NamedTypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);

    }

    internal class ClassTypeDefinition : TypeDefinition
    {
        internal ClassTypeDefinition(string name,
            ModelDefinition model) : base(name, model)
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

        public NamedTypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }

    internal class GenericTypeDefinition : ClassTypeDefinition
    {
        internal GenericTypeDefinition(string name,
            ModelDefinition model,
            IDictionary<string, TypeSpecifier> arguments) : base(name, model)
        {
            Arguments = arguments.AsReadOnly();
        }

        /// <summary>
        /// Maps the names of arguments to their constraints.
        /// Types without practical constraints should use some base type, such as System.Any.
        /// </summary>
        public IReadOnlyDictionary<string, TypeSpecifier> Arguments { get; }

        public GenericTypeSpecifier ToTypeSpecifier(IList<TypeSpecifier> arguments) =>
            new GenericTypeSpecifier(this, arguments);

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
    }

    internal class GenericTypeSpecifier : TypeSpecifier
    {
        public GenericTypeSpecifier(GenericTypeDefinition type, IList<TypeSpecifier> arguments)
        {
            Type = type;
            Arguments = new ReadOnlyCollection<TypeSpecifier>(arguments);
        }

        public GenericTypeDefinition Type { get; }

        public ReadOnlyCollection<TypeSpecifier> Arguments { get; }

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

        protected internal override TypeDefinition? GetTypeDefinition() => Type;
    }
}
