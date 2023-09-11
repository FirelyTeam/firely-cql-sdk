/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class VariableNameGenerator
    {
        private readonly object SyncRoot = new();
        public string Postfix { get; }

        private List<string> Reserved { get; }

        public VariableNameGenerator(IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? new List<string>();
            Postfix = postfix;
        }

        private readonly List<char> Letters = new() { (char)('a' - 1) };
        private readonly string Prefix = string.Empty;
        private readonly List<string> Generated = new();


        public virtual string Next()
        {
            lock (SyncRoot)
            {
                string vn = "";
                do
                {
                    var lastIndex = Letters.Count - 1;
                    var next = (char)(Letters[lastIndex] + 1);
                    if (next > 'z')
                    {
                        next = 'a';
                        Letters[lastIndex] = next;
                        if (Letters.Count > 1)
                        {
                            if (Letters[0] == 'z')
                            {
                                Letters.Insert(0, 'a');
                            }
                            else
                            {
                                Letters[0] = (char)(Letters[0] + 1);
                            }
                        }
                        else Letters.Insert(0, 'a');
                    }
                    else
                    {
                        Letters[lastIndex] = next;
                    }
                    vn = $"{Prefix}{new string(Letters.ToArray())}{Postfix}";
                }
                while (Reserved.Contains(vn) && SyntaxFacts.GetKeywordKind(vn) != SyntaxKind.None);
                Generated.Add(vn);
                return vn;
            }
        }

        public static string? NormalizeIdentifier(string? identifier)
        {
            if (identifier == null)
                return null;

            identifier = identifier.Replace(" ", "_");
            identifier = identifier.Replace("-", "_");
            identifier = identifier.Replace(".", "_");
            identifier = identifier.Replace(",", "_");
            identifier = identifier.Replace("[", "_");
            identifier = identifier.Replace("]", "_");
            identifier = identifier.Replace("(", "_");
            identifier = identifier.Replace(")", "_");
            identifier = identifier.Replace(":", "_");
            identifier = identifier.Replace("/", "_");
            identifier = identifier.Replace("+", "plus");
            identifier = identifier.Replace("-", "minus");
            identifier = identifier.Replace("\"", "");
            identifier = identifier.Replace("'", "");
            identifier = identifier.Replace(";", "_");
            identifier = identifier.Replace("&", "and");


            if (identifier.StartsWith("$"))
                identifier = identifier.Substring(1);
            var keyword = SyntaxFacts.GetKeywordKind(identifier);
            if (keyword != SyntaxKind.None)
            {
                identifier = $"@{identifier}";
            }
            if (char.IsDigit(identifier[0]))
                identifier = "_" + identifier;
            return identifier;
        }

    }
}
