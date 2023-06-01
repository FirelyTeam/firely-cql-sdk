/* 
 * Copyright (c) 2020, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

#nullable enable

using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using System.Collections.Concurrent;
using System.Reflection;

namespace Hl7.Fhir.Introspection
{
    public class EnumMemberMapping
    {
        private EnumMemberMapping(string name, string system, string description)
        {
            Name = name;
            System = system;
            Description = description;
        }

        public string Name { get; }
        public string System { get; }
        public string Description { get; }

        public static bool TryCreate(Type type, out EnumMemberMapping? result, FhirRelease release = (FhirRelease)int.MaxValue)
        {
            result = default;
            if (!type.IsEnum) return false;

            if (GetAttribute<FhirEnumerationAttribute>(type.GetTypeInfo(), release) is not { } typeAttribute) return false;

            result = new EnumMapping(typeAttribute.BindingName, type, release);
            return true;
        }
    }


    /// <summary>
    /// A container for the metadata of a FHIR valueset as present on the (generated) .NET POCO enum.
    /// </summary>
    public class EnumMapping
    {
        private static readonly ConcurrentDictionary<(Type, FhirRelease), EnumMapping?> _mappedEnums = new();

        public static void Clear() => _mappedEnums.Clear();

        /// <summary>
        /// Gets the <see cref="ClassMapping"/> for the given <see cref="Type"/>. Calling this function multiple
        /// times for the same type and release will return the same ClassMapping.
        /// </summary>
        /// <returns>true if the mapping was found or false if it was not one of the supported and reflectable types.</returns>
        /// <remarks>For classes shared across FHIR versions, there may be metadata present for different versions
        /// of FHIR, the <paramref name="release"/> is used to select which subset of metadata to extract. </remarks>
        /// <seealso cref="TryCreate(Type, out ClassMapping?, FhirRelease)"/>
        public static bool TryGetMappingForEnum(Type t, FhirRelease release, out EnumMapping? mapping)
        {
            mapping = _mappedEnums.GetOrAdd((t, release), createMapping);
            return mapping is not null;

            static EnumMapping? createMapping((Type, FhirRelease) typeAndRelease) =>
                TryCreate(typeAndRelease.Item1, out var m, typeAndRelease.Item2) ? m : null;
        }

        /// <summary>
        /// Inspects the given type, extracting metadata from its attributes and creating a new <see cref="ClassMapping"/>.
        /// </summary>
        /// <remarks>For classes shared across FHIR versions, there may be metadata present for different versions
        /// of FHIR, the <paramref name="release"/> is used to select which subset of metadata to extract.</remarks>
        public static bool TryCreate(Type type, out EnumMapping? result, FhirRelease release = (FhirRelease)int.MaxValue)
        {
            result = default;
            if (!type.IsEnum) return false;

            if (GetAttribute<FhirEnumerationAttribute>(type.GetTypeInfo(), release) is not { } typeAttribute) return false;

            result = new EnumMapping(typeAttribute.BindingName, type, release);
            return true;
        }

        private EnumMapping(string name, Type nativeType, FhirRelease release)
        {
            Name = name;
            NativeType = nativeType;
            Release = release;
        }

        /// <summary>
        /// The FHIR release which this mapping reflects.
        /// </summary>
        /// <remarks>The mapping will contain the metadata that applies to this version (or older), using the
        /// newest metadata when multiple exist.</remarks>
        public FhirRelease? Release { get; }

        /// <summary>
        /// Name of the mapping.
        /// </summary>
        /// <remarks>
        /// This is the FHIR name for the type as specified in <see cref="FhirTypeAttribute.Name"/> but not always:
        /// <list type="bullet">
        /// <item>FHIR <c>code</c> types with required bindings are modelled in the POCO as a <see cref="Code{T}"/>,
        /// the mapping name for these will be <c>code&lt;name of enum&gt;</c></item>
        /// <item>The System/CQL primitives from <see cref="Hl7.Fhir.ElementModel.Types"/> all have their names
        /// prepended with "System.", e.g. "System.Integer".</item>
        /// <item>.NET primitive types have their <see cref="Type.FullName"/> name prepended with "Net.", e.g. "Net.System.Int32".</item>
        /// </list>
        /// </remarks>
        public string Name { get; private set; }

        /// <summary>
        /// The .NET class that implements the FHIR datatype/resource
        /// </summary>
        public Type NativeType { get; private set; }


        internal static T? GetAttribute<T>(MemberInfo t, FhirRelease version) where T : Attribute => GetAttributes<T>(t, version).LastOrDefault();

        internal static IEnumerable<T> GetAttributes<T>(MemberInfo t, FhirRelease version) where T : Attribute => ReflectionHelper.GetAttributes<T>(t).Where(a => a.AppliesToRelease(version));

        private readonly Dictionary<string, Enum> _literalToEnum = new();
        private readonly Dictionary<string, Enum> _lowercaseLiteralToEnum = new();
        private readonly Dictionary<Enum, string> _enumToLiteral = new();

        public string GetLiteral(Enum value) =>
            !_enumToLiteral.TryGetValue(value, out string? result)
                ? throw new InvalidOperationException($"Should only pass enum values that are member of the given enum: {value} is not a member of {Name}.")
                : result;

        public Enum? ParseLiteral(string? literal, bool ignoreCase)
        {
            if (literal is null) return null;

            var success = ignoreCase
                ? _lowercaseLiteralToEnum.TryGetValue(literal.ToLowerInvariant(), out Enum? result)
                : _literalToEnum.TryGetValue(literal, out result);

            return success ? result : null;
        }

        public static EnumMapping Create(Type enumType)
        {
            if (enumType is null) throw new ArgumentNullException(nameof(enumType));
            if (!enumType.IsEnum()) throw new ArgumentException($"Type {enumType.Name} is not an enumerated type", nameof(enumType));

            var result = new EnumMapping(getEnumName(enumType), enumType);

            foreach (var enumValue in ReflectionHelper.FindEnumFields(enumType))
            {
                var attr = ReflectionHelper.GetAttribute<EnumLiteralAttribute>(enumValue);
                string literal = attr?.Literal ?? enumValue.Name;
                var value = (Enum)enumValue.GetValue(null)!;

                result._enumToLiteral.Add(value, literal);
                result._literalToEnum.Add(literal, value);
                result._lowercaseLiteralToEnum.Add(literal.ToLowerInvariant(), value);
            }

            return result;

            static string getEnumName(Type t)
            {
                var attr = t.GetTypeInfo().GetCustomAttribute<FhirEnumerationAttribute>();
                return attr != null ? attr.BindingName : t.Name;
            }
        }
    }


}
}

#nullable restore