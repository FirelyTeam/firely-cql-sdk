using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Hl7.Cql.Model
{
    internal class GenericTypeDefinition : ClassTypeDefinition
    {
        public static GenericTypeDefinition CreateTemplate(string name,
            ModelDefinition model,
            IList<GenericArgumentSpecifier> arguments,
            Dictionary<GenericArgumentSpecifier, TypeSpecifier> constraints,
            TypeDefinition baseType,
            AccessModifier access) =>
            new(name,
                model,
                arguments.Cast<TypeSpecifier>().ToList(),
                constraints.ToDictionary(kvp=>kvp.Key as TypeSpecifier, kvp=>kvp.Value),
                baseType,
                access);
        public static GenericTypeDefinition Create(GenericTypeDefinition template,
            Dictionary<GenericArgumentSpecifier, TypeSpecifier> argumentBindings)
        {
            var orderedArgs = new TypeSpecifier[argumentBindings.Count];
            foreach (var kvp in argumentBindings)
            {
                int index = -1;
                for(int i = 0; i < template.Arguments.Count; i++)
                {
                    if (template.Arguments[i].Equals(kvp.Key))
                    {
                        index = i;
                        break;
                    }
                }
                if (index > -1)
                    orderedArgs[index] = kvp.Value;
                else throw new ArgumentException($"Argument {kvp.Key.Argument} is not an argument of template {template.Name}");
            }
            return new GenericTypeDefinition(template.Name, template.Model!, orderedArgs, null, template.BaseType!, AccessModifier.Public);
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
            ArgumentConstraints = constraints ?? new Dictionary<TypeSpecifier, TypeSpecifier>();

        }

        internal IDictionary<TypeSpecifier, TypeSpecifier> ArgumentConstraints;


        /// <summary>
        /// Maps the names of arguments to their constraints.
        /// Types without practical constraints should use some base type, such as System.Any.
        /// </summary>
        public IReadOnlyDictionary<TypeSpecifier, TypeSpecifier> Constraints => ArgumentConstraints.AsReadOnly();
        public IReadOnlyList<TypeSpecifier> Arguments { get; }
        public override TypeSpecifier ToTypeSpecifier() => new GenericTypeSpecifier(this, Arguments);

        public bool IsTemplate => Arguments.All(arg=>arg is GenericArgumentSpecifier);

        public GenericTypeDefinition MakeGenericType(params TypeSpecifier[] arguments) =>
            IsTemplate switch
            {
                true => new(Name, Model!, arguments, null, BaseType!, Access),
                false => throw new InvalidOperationException("This is not a generic template.")
            };

        public override string ToString() => $"{Name}<{string.Join(", ", Arguments)}>";
    }
}
