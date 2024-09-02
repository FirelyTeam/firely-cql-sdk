/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.IO;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal class StubCSharpCodeStreamPostProcessor : CSharpCodeStreamPostProcessor
{
    public override void ProcessStream(string name, Stream stream)
    {
    }
}