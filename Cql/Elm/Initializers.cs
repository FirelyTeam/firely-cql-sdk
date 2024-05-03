/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;

namespace Hl7.Cql.Elm
{
    internal static class Initializers
    {
        private static readonly ObjectIDGenerator _idGenerator = new();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

        public static string NextId() => NextId(Random.Shared.Next());

        public static T WithId<T>(this T t) where T : Element
        {
            t.localId = NextId(t);

            return t;
        }


        public static T With<T>(this T me, Action<T> action)
        {
            action(me);
            return me;
        }

        public static T WithLocator<T>(this T t, string? locator) where T : Element
        {
            t.WithId();
            t.locator = locator;

            return t;
        }

        public static T WithResultType<T>(this T t, TypeSpecifier? type) where T : Element
        {
            t.resultTypeSpecifier = type;

            if (type is NamedTypeSpecifier nts)
                t.resultTypeName = nts.name;

            return t;
        }

        public static XmlQualifiedName? TryToQualifiedName(this TypeSpecifier? type)
        {
            if (type is NamedTypeSpecifier nts)
                return nts.name;
            else
                return null;
        }

    }


}
