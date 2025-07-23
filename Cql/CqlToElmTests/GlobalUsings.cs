/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System;
global using System.Collections.Generic;
global using System.Collections.Immutable;
global using System.Diagnostics;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Text;
global using System.Xml.Serialization;
global using FluentAssertions;
global using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
global using Hl7.Cql.Invocation.Toolkit.Extensions;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
global using CqlDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<Hl7.Cql.Abstractions.CqlDefinition>;
global using DelegateDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<System.Delegate>;
