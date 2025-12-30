/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;

namespace Hl7.Cql.CodeGeneration.NET;

[DebuggerDisplay("{ToString(),nq}")]
internal class IndentedStringBuilder
{
    public static implicit operator string(IndentedStringBuilder isb) => isb.ToString();

    private IndentScope _leafIndentScope;

    public IndentedStringBuilder(
        StringBuilder? stringBuilder = null,
        int indent = 0)
    {
        _leafIndentScope = new IndentScope(this, indent);
        StringBuilder = stringBuilder ?? new();
    }

    public IndentedStringBuilder Append(int addIndent, string text = "") =>
        AppendCore(addIndent, text, addNewLine: false);

    public IndentedStringBuilder Append(string text = "") =>
        AppendCore(0, text, addNewLine: false);

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(string text = "") =>
        AppendCore(0, text, addNewLine: true);

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent plus an additional indent from <paramref name="addIndent"/>.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(int addIndent, string multilineText = "") =>
        AppendCore(addIndent, multilineText, addNewLine: true);

    private IndentedStringBuilder AppendCore(
        int addIndent,
        string multilineText,
        bool addNewLine = false)
    {
        var lines = multilineText.Split(Environment.NewLine);
        var sb = StringBuilder;

        for (var index = 0; index < lines.Length; index++)
        {
            var line = lines[index];
            if (line.Length > 0)
            {
                int finalIndent = 0;
                if (sb.AtBeginningOfLine())
                {
                    int leadingTabs = line.TakeWhile(c => c == '\t').Count();
                    line = line[leadingTabs..];
                    if (line.Length > 0)
                        finalIndent = IndentLevel + leadingTabs + addIndent;
                }

                sb.Append(finalIndent, line);
            }

            if (addNewLine || index < lines.Length - 1)
                sb.AppendLine();
        }

        return this;
    }

    public IndentScope Indent(int addIndent = 1)
    {
        if (addIndent < 1)
            throw new ArgumentOutOfRangeException(nameof(addIndent), addIndent, "Must be one or greater.");

        var indentScope = new IndentScope(this, addIndent);
        _leafIndentScope = indentScope;
        return _leafIndentScope;
    }

    public IndentedStringBuilder Unindent() =>
        _leafIndentScope.Unindent();

    public int IndentLevel => _leafIndentScope.IndentLevel;

    public StringBuilder StringBuilder { get; }

    public override string ToString() => StringBuilder.ToString();

    public class IndentScope : IDisposable
    {
        public IndentedStringBuilder Builder { get; }

        private readonly IndentScope _previousScope; // null? then we are the root

        public int IndentLevel { get; }

        internal IndentScope(
            IndentedStringBuilder owner,
            int addIndent)
        {
            Builder = owner;
            IndentScope? ownerLeafIndentScope = owner?._leafIndentScope; // the root scope will be null, since we are constructing it before setting it to the field
            _previousScope = ownerLeafIndentScope ?? this;
            IndentLevel = _previousScope.IndentLevel + addIndent;
        }

        public IndentedStringBuilder Unindent()
        {
            if (ReferenceEquals(_previousScope, this))
                return Builder; // We are the root scope, so nothing to unindent.

            if (Builder._leafIndentScope != this)
                throw new InvalidOperationException("Scoped Unindent should occur in reverse sequence.");

            Builder._leafIndentScope = _previousScope;
            return Builder;
        }

        void IDisposable.Dispose() => Unindent(); // Only unindent on an explicit Dispose and not via finalizer.
    }
}

