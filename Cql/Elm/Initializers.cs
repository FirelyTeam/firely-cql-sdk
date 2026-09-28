/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Threading;

namespace Hl7.Cql.Elm
{
    internal static class Initializers
    {
        // Every translation and compilation in the process numbers its elements here, possibly on several threads at
        // once, so the table is thread-safe; it holds its keys weakly, so an element's id does not keep the element alive.
        private static readonly ConditionalWeakTable<object, string> _ids = new();
        private static long _lastId;

        /// <summary>
        /// The id of <paramref name="context"/>: the same id every time for the same object, and a different one for
        /// every other object. Ids count up from 1 in the order the objects are first seen.
        /// </summary>
        public static string NextId(object context) => _ids.GetValue(context, static _ => NextId());

        /// <summary>A new id, not given to any object.</summary>
        public static string NextId() => Interlocked.Increment(ref _lastId).ToString(CultureInfo.InvariantCulture);

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
