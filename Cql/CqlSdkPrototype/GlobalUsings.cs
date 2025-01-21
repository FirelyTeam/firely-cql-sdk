// Global using directives

global using System.Collections.Immutable;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Runtime.Loader;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using CqlApiStateEntryDictionary = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Cql.Extensibility.CqlApiStateEntry>;
global using ElmApiStateEntryDictionary = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Elm.Extensibility.ElmApiStateEntry>;