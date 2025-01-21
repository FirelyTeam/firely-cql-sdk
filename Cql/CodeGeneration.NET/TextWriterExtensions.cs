/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET
{
    internal static class TextWriterExtensions
    {
        public const int SpacesPerIndentLevel = 4;

        public static void WriteLine(this TextWriter writer, int indent, string text = "")
        {
            if (text.Length == 0)
                writer.WriteLine(); // Blank lines should not contain dangling whitespace
            else
            {
                writer.Write(StringExtensions.IndentString(indent));
                writer.WriteLine(text);
            }
        }

        public static void AppendLine(this StringBuilder sb, int indent, string text)
        {
            sb.Append(StringExtensions.IndentString(indent));
            sb.AppendLine(text);
        }
        
        public static void Append(this StringBuilder sb, int indent, string text)
        {
            sb.Append(StringExtensions.IndentString(indent));
            sb.Append(text);
        }

        public static bool IsExtensionMethod(this MethodInfo info) =>
            info.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), true);
    }

}
