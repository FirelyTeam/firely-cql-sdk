/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System.Collections.Concurrent;
global using System.Collections.Immutable;
global using System.CommandLine;
global using System.CommandLine.IO;
global using System.CommandLine.NamingConventionBinder;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Text.RegularExpressions;
global using JetBrains.Annotations;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Configuration.Memory;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Logging.Abstractions;
global using Microsoft.Extensions.Options;
global using static System.FormattableString;
global using static Hl7.Cql.Packager.GlobalMethods;
global using static Hl7.Cql.Packaging.Constants;
global using CqlVersionedLibraryIdentifier = Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier;
global using ElmLibrary = Hl7.Cql.Elm.Library;
global using FhirLibrary = Hl7.Fhir.Model.Library;
