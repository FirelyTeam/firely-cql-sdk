#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        public bool? And(bool? left, bool? right)
        {
            if (left == false || right == false)
                return false;
            else if (left == true && right == true)
                return true;
            else return null;
        }
        public bool? And(Lazy<bool?> left, Lazy<bool?> right)
        {
            if (left.Value == false || right.Value == false)
                return false;
            else if (left.Value == true && right.Value == true)
                return true;
            else return null;
        }

        public bool? And(bool? left, Lazy<bool?> right)
        {
            if (left == false || right.Value == false)
                return false;
            else if (left == true && right.Value == true)
                return true;
            else return null;
        }

        public bool? And(Lazy<bool?> left, bool? right)
        {
            if (left.Value == false || right == false)
                return false;
            else if (left.Value == true && right == true)
                return true;
            else return null;
        }

        public bool? Implies(bool? left, bool? right)
        {
            if (left == true)
                return right;
            else if (left == false)
                return true;
            else
            {
                if (right == true)
                    return true;
                else return null;
            }
        }
        public bool? Implies(Lazy<bool?> left, Lazy<bool?> right)
        {
            if (left.Value == true) return right.Value;
            else if (left.Value == false) return true;
            else
            {
                if (right.Value == true) return true;
                else return null;
            }
        }

        public bool? Not(bool? @this)
        {
            if (@this == null)
                return null;
            else if (@this.Value == true)
                return false;
            else return true;
        }

        public bool? Or(bool? left, bool? right)
        {
            if (left == true || right == true)
                return true;
            else if (left == null || right == null)
                return null;
            else return false;
        }
        public bool? Or(Lazy<bool?> left, Lazy<bool?> right)
        {
            if (left.Value == true || right.Value == true)
                return true;
            else if (left.Value == null || right.Value == null)
                return null;
            else return false;
        }


        public bool? Xor(bool? left, bool? right)
        {
            if (left == true)
            {
                if (right == null)
                    return null;
                else return !right.Value;
            }
            else if (left == false)
                return right;
            else return null;
        }

        public bool? Xor(Lazy<bool?> left, Lazy<bool?> right)
        {
            if (left.Value == true)
            {
                if (right.Value == null) return null;
                else return !right.Value;
            }
            else if (left.Value == false) return right.Value;
            else return null;
        }

    }
}
