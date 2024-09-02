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

namespace Hl7.Cql.CqlToElm.DependencyInjection;

internal class CqlToElmServices(IServiceProvider serviceProvider) : IDisposable
{
    public IServiceProvider ServiceProvider { get; private set; } = serviceProvider;

    public CqlToElmConverter CqlToElmConverter => ServiceProvider.GetRequiredService<CqlToElmConverter>();

    public CoercionProvider CoercionProvider => ServiceProvider.GetRequiredService<CoercionProvider>();

    public ElmFactory ElmFactory => ServiceProvider.GetRequiredService<ElmFactory>();

    public SystemLibrary SystemLibrary => ServiceProvider.GetRequiredService<SystemLibrary>();

    public StreamInspector StreamInspector => ServiceProvider.GetRequiredService<StreamInspector>();

    public InvocationBuilder InvocationBuilder => ServiceProvider.GetRequiredService<InvocationBuilder>();

    public LocalIdentifierProvider LocalIdentifierProvider() => ServiceProvider.GetRequiredService<LocalIdentifierProvider>();

    public MessageProvider MessageProvider => ServiceProvider.GetRequiredService<MessageProvider>();

    public IModelProvider ModelProvider => ServiceProvider.GetRequiredService<IModelProvider>();

    public void Dispose()
    {
        var sp = ServiceProvider;
        ServiceProvider = null!;
        (sp as IDisposable)?.Dispose();
    }
}