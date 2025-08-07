/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET
{
    internal sealed class VariableNameGenerator
    {
        private readonly object _syncRoot = new();
        private readonly List<char> _letters = [(char)('a' - 1)];
        private readonly string _prefix = string.Empty;

        private string Postfix { get; }

        private List<string> Reserved { get; }

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
        private VariableNameGenerator ForNewScope(IEnumerable<string>? scopeNames)
        {
            var newGenerator = new VariableNameGenerator(_letters, Reserved.Concat(scopeNames ?? []), Postfix);
            return newGenerator;
        }

        public VariableNameGenerator(IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? [];
            Postfix = postfix;
        }

        private VariableNameGenerator(List<char> state, IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? [];
            Postfix = postfix;
            _letters = state;
        }

        public string Next()
        {
            lock (_syncRoot)
            {
                string vn = "";
                do
                {
                    var lastIndex = _letters.Count - 1;
                    var next = (char)(_letters[lastIndex] + 1);
                    if (next > 'z')
                    {
                        next = 'a';
                        _letters[lastIndex] = next;
                        if (_letters.Count > 1)
                        {
                            if (_letters[0] == 'z')
                            {
                                _letters.Insert(0, 'a');
                            }
                            else
                            {
                                _letters[0] = (char)(_letters[0] + 1);
                            }
                        }
                        else _letters.Insert(0, 'a');
                    }
                    else
                    {
                        _letters[lastIndex] = next;
                    }
                    vn = $"{_prefix}{new string(_letters.ToArray())}{Postfix}";
                }
                while (Reserved.Contains(vn) || SyntaxFacts.GetKeywordKind(vn) != SyntaxKind.None);

                return vn;
            }
        }

    }
}
