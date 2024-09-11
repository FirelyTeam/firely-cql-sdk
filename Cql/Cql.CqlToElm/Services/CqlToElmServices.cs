/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CqlToElm.Services;

internal static class CqlToElmServices
{
    public static CqlToElmConverter GetCqlToElmConverter(this IServiceProvider sp) => sp.GetRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this IServiceProvider sp) => sp.GetRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this IServiceProvider sp) => sp.GetRequiredService<ElmFactory>();

    public static SystemLibrary GetSystemLibrary(this IServiceProvider sp) => sp.GetRequiredService<SystemLibrary>();

    public static StreamInspector GetStreamInspector(this IServiceProvider sp) => sp.GetRequiredService<StreamInspector>();

    public static InvocationBuilder GetInvocationBuilder(this IServiceProvider sp) => sp.GetRequiredService<InvocationBuilder>();

    public static LocalIdentifierProvider GetLocalIdentifierProviderTransient(this IServiceProvider sp) => sp.GetRequiredService<LocalIdentifierProvider>();

    public static MessageProvider GetMessageProvider(this IServiceProvider sp) => sp.GetRequiredService<MessageProvider>();

    public static IModelProvider GetModelProvider(this IServiceProvider sp) => sp.GetRequiredService<IModelProvider>();
}