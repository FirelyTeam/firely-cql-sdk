#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        #region Combine
        public string? Combine(IEnumerable<string> source, string? separator)
        {
            if (source == null)
                return null;
            var result = string.Join(separator ?? string.Empty, source);
            return result;
        }
        #endregion

        #region Concatenate

        public string? Concatenate(string? left, string? right) =>
            (left == null || right == null) ? null : string.Concat(left, right);


        #endregion

        #region EndsWith
        public bool? EndsWith(string argument, string suffix)
        {
            if (argument == null || suffix == null) return null;
            else return argument.Substring(argument.Length - suffix.Length).Equals(suffix);
        }

        #endregion

        #region Indexer
        public string? StringIndexer(string? argument, int? index)
        {
            if (argument == null || index == null)
                return null;
            if (index < 0 || index >= argument.Length)
                return null;
            else
            {
                var value = argument[index.Value];
                return value.ToString();
            }
        }

        #endregion

        #region LastPositionOf
        public int? LastPositionOf(string? argument, string? pattern)
        {
            if (pattern == null || argument == null)
                return null;
            else
                return argument.LastIndexOf(pattern);
        }

        #endregion

        #region Length
        public int? StringLength(string argument)
        {
            if (argument == null)
                return 0;
            else
                return argument.Length;
        }

        #endregion

        #region Lower
        public string? Lower(string argument)
        {
            if (argument == null)
                return null;
            else
                return argument.ToLower(CultureInfo.InvariantCulture);
        }

        #endregion

        #region Matches
        public bool? Matches(string source, string pattern)
        {
            if (source == null || pattern == null) return null;
            else
            {
                if (pattern[0].Equals("^") == false) pattern = "^" + pattern;
                if (pattern[pattern.Length - 1].Equals("$") == false) pattern += "$";
                Regex rx = new(pattern);
                MatchCollection matches = rx.Matches(source);
                if (matches.Count == 1) return true;
                else return false;
            }
        }
        #endregion

        #region PositionOf
        public int? PositionOf(string pattern, string argument)
        {
            if (argument == null || pattern == null) return null;
            else return argument.IndexOf(pattern);
        }
        #endregion

        #region ReplaceMatches
        public string? ReplaceMatches(string source, string pattern, string substitution)
        {
            if (source == null || pattern == null || substitution == null)
                return null;
            var result = Regex.Replace(source, pattern, substitution);
            return result;
        }
        #endregion

        #region Split
        public IEnumerable<string>? Split(string stringToSplit, string separator)
        {
            if (stringToSplit == null)
                return null;
            if (separator == null)
                return new[] { stringToSplit };
            else return stringToSplit.Split(separator.ToCharArray());
        }
        #endregion

        #region SplitOnMatches
        public IEnumerable<string>? SplitOnMatches(string stringToSplit, string separatorPattern)
        {
            if (stringToSplit == null || separatorPattern == null) return null;
            else return Regex.Split(stringToSplit, separatorPattern);
        }
        #endregion

        #region StartsWith
        public bool? StartsWith(string argument, string prefix)
        {
            if (argument == null || prefix == null) return null;
            else return argument.StartsWith(prefix);
        }
        #endregion

        #region Substring
        public string? Substring(string source, int? startIndex, int? length = null)
        {
            if (source == null
                || startIndex == null
                || startIndex.Value < 0
                || startIndex.Value >= source.Length)
                return null;
            if (length == null)
            {
                return source.Substring(startIndex.Value);
            }
            else
            {
                if (length.Value < 0)
                    return null;
                var subLength = Math.Min(length.Value, source.Length);
                return source.Substring(startIndex.Value, subLength);
            }
        }
        #endregion

        #region Upper
        public string? Upper(string argument)
        {
            if (argument == null) return null;
            else return argument.ToUpper(CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
