/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class VariableNameGenerator
    {
        private readonly object SyncRoot = new();
        public string Postfix { get; }

        private List<string> Reserved { get; }

        private readonly List<char> Letters = [(char)('a' - 1)];
        private readonly string Prefix = string.Empty;


        /// <summary>
        /// Create a new VariableNameGenerator with an (optional) set of extra reserved variable names
        /// introduced in a scope, which continues naming where the parent scope left off.
        /// </summary>
        public VariableNameGenerator ForNewScope(IEnumerable<ParameterExpression>? scopeVariables)
        {
            var newReservations = scopeVariables?.Where(p => p.Name is not null).Select(p => p.Name!);
            return ForNewScope(newReservations);
        }

        /// <inheritdoc cref="ForNewScope(IEnumerable{ParameterExpression}?)"/>
        public VariableNameGenerator ForNewScope(IEnumerable<string>? scopeNames)
        {
            var newGenerator = new VariableNameGenerator(Letters, Reserved.Concat(scopeNames ?? []), Postfix);
            return newGenerator;
        }

        public VariableNameGenerator(IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? [];
            Postfix = postfix;
        }

        public VariableNameGenerator(IEnumerable<ParameterExpression> reserved, string postfix = "") :
            this(reserved.Where(p => p.Name is not null).Select(p => p.Name!), postfix)
        {
            // Nothing           
        }

        internal VariableNameGenerator(List<char> state, IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? [];
            Postfix = postfix;
            Letters = state;
        }

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
                while (Reserved.Contains(vn) || SyntaxFacts.GetKeywordKind(vn) != SyntaxKind.None);

                return vn;
            }
        }

        public static string? NormalizeIdentifier(string? identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                return null;
            
            if (identifier.StartsWith('$'))
                identifier = identifier[1..];

            identifier = identifier.Replace("\"",string.Empty);
            identifier = identifier.Replace("'",string.Empty);
            identifier = identifier.Replace("&","and");
            
            // If we start with an invalid character for the start position, add an underscore
            if (!SyntaxFacts.IsIdentifierStartCharacter(identifier[0]) && 
                SyntaxFacts.IsIdentifierPartCharacter(identifier[0]))
                identifier = "_" + identifier;

            // go over the string and replace all characters that are not allowed in an identifier
            var replaced = identifier.Select(c => SyntaxFacts.IsIdentifierPartCharacter(c) ? c : '_');
            identifier = string.Concat(replaced);
            
            if (SyntaxFacts.GetKeywordKind(identifier) != SyntaxKind.None)
                identifier = $"@{identifier}";
            
            return identifier;
        }

    }
}
