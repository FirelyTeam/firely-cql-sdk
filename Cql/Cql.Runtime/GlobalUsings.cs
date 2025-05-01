/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System;
global using System.Collections;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Runtime.ExceptionServices;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Nodes;
global using System.Text.Json.Serialization;
global using System.Text.RegularExpressions;
global using JetBrains.Annotations;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Logging.Abstractions;
global using Microsoft.Extensions.Options;
global using static Hl7.Cql.Comparers.CqlComparerSharedMethods;
global using CqlDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<Hl7.Cql.Abstractions.CqlDefinition>;
global using DelegateDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<System.Delegate>;