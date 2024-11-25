/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Microsoft.Extensions.Options;

namespace Hl7.Cql.CodeGeneration.NET;

partial class CSharpCodeWriterOptions
{
    internal partial class Validator : IValidateOptions<CSharpCodeWriterOptions>
    {
        public ValidateOptionsResult Validate(string? name, CSharpCodeWriterOptions options) =>
            ValidateOptionsResult.Success;
    }
}