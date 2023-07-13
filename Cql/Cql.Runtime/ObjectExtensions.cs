﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Provides extension methods.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Uses <paramref name="access"/> to retrieve a property on <paramref name="object"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="object"/></typeparam>
        /// <typeparam name="TProp">The property type returned by <paramref name="access"/></typeparam>
        /// <param name="object">The source object which is the first parameter to <paramref name="access"/>.</param>
        /// <param name="access">The function that accesses the property.</param>
        /// <returns>The value of the property, or <see langword="null"/> if <paramref name="object"/> is <see langword="null"/>.</returns>
        /// TODO: Remove this?
        public static TProp PropertyOrDefault<T, TProp>(this T @object, Func<T, TProp> access)
        {
            if (@object == null)
                return default!;
            else return access(@object);
        }
    }
}
