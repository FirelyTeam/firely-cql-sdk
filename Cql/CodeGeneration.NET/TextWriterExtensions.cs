/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq;
using System.Reflection;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal static class TextWriterExtensions
    {
        private static string IndentString(int indent) => new string(Enumerable.Repeat('\t', indent).ToArray());

        public static void AppendLine(this StringBuilder sb, int indent, string text)
        {
            sb.Append(IndentString(indent));
            sb.AppendLine(text);
        }

        public static void Append(this StringBuilder sb, int indent, string text)
        {
            sb.Append(IndentString(indent));
            sb.Append(text);
        }

        public static bool IsExtensionMethod(this MethodInfo info) =>
            info.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), true);

    }
}

