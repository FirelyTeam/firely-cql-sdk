/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Diagnostics;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilderContext : IBuilderContext
{
    IBuilderContext? IBuilderContext.OuterBuilderContext => LibrarySetContext;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => BuilderContextDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}