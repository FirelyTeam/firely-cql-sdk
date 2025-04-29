/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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

            ReadOnlySpan<char> span = identifier.AsSpan();

            int leadingUnderscoreCount = 0;
            while (leadingUnderscoreCount < span.Length && span[leadingUnderscoreCount] == '_')
                leadingUnderscoreCount++;

            if (leadingUnderscoreCount > 0)
                span = span[leadingUnderscoreCount..];

            if (span.Length > 0 && span[0] == '$')
                span = span[1..];

            Span<char> buffer = stackalloc char[span.Length+2];
            int bufferIndex = 0;

            foreach (var c in span)
            {
                switch (c)
                {
                    case '"':
                    case '\'':
                        continue;
                    case '&':
                        buffer[bufferIndex++] = 'a';
                        buffer[bufferIndex++] = 'n';
                        buffer[bufferIndex++] = 'd';
                        continue;
                    default:
                        buffer[bufferIndex++] = SyntaxFacts.IsIdentifierPartCharacter(c) ? c : '_';
                        break;
                }
            }

            var normalized = buffer[..bufferIndex].ToString();

            if (normalized.Length > 0 && !SyntaxFacts.IsIdentifierStartCharacter(normalized[0]))
                //normalized = "_" + normalized;
                leadingUnderscoreCount++;

            if (leadingUnderscoreCount > 0)
                normalized = new string('_', leadingUnderscoreCount) + normalized;

            if (SyntaxFacts.GetKeywordKind(normalized) != SyntaxKind.None)
                normalized = $"@{normalized}";

            return normalized;
        }

    }
}
