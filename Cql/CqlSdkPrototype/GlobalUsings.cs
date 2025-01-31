// Global using directives

global using System.Collections.Concurrent;
global using System.Collections.Immutable;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Runtime.Loader;
global using System.Text.RegularExpressions;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Logging.Abstractions;
global using ElmLibrary = Hl7.Cql.Elm.Library;
global using CqlToElmTranslationDictionary = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Cql.CqlToElmTranslation>;
global using CqlToElmTranslationReadOnlyDictionary = System.Collections.Generic.IReadOnlyDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Cql.CqlToElmTranslation>;
global using ElmToAssemblyCompilationDictionary = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Elm.ElmToAssemblyCompilation>;
global using ElmToAssemblyCompilationReadOnlyDictionary = System.Collections.Generic.IReadOnlyDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Elm.ElmToAssemblyCompilation>;
global using AssemblyBinaryHashSet = System.Collections.Immutable.ImmutableHashSet<Hl7.Cql.CodeGeneration.NET.AssemblyBinary>;
global using AssemblyBinaryReadOnlyHashSet = System.Collections.Generic.IReadOnlySet<Hl7.Cql.CodeGeneration.NET.AssemblyBinary>;
global using FhirResourcePackagingDictionary = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Packaging.FhirResourcePackaging>;
global using FhirResourcePackagingReadOnlyDictionary = System.Collections.Generic.IReadOnlyDictionary<CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Packaging.FhirResourcePackaging>;

