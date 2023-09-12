/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Hl7.Cql.Compiler
{
    internal class Hasher
    {

        private MD5 MD5 { get; } = MD5.Create();
        public virtual string Hash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hashBytes = MD5.ComputeHash(bytes);
            var alpha = ToAlphaString(hashBytes);
            return alpha;
        }

        public string ToAlphaString(byte[] toConvert, bool bigEndian = false)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (bigEndian) Array.Reverse(toConvert); // !BitConverter.IsLittleEndian might be an alternative
            BigInteger dividend = new(toConvert);
            var builder = new StringBuilder();
            while (dividend != 0)
            {
                BigInteger remainder;
                dividend = BigInteger.DivRem(dividend, 36, out remainder);
                builder.Insert(0, alphabet[Math.Abs(((int)remainder))]);
            }
            return builder.ToString();
        }

    }
}
