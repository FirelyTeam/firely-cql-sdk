/*
// * Copyright (c) 2024, NCQA and contributors
// * See the file CONTRIBUTORS for details.
// *
// * This file is licensed under the BSD 3-Clause license
// * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
// */
// Global using directives

global using System;
global using System.Collections;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.Collections.Immutable;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Reflection.Emit;
global using System.Runtime.CompilerServices;
global using System.Security;
global using System.Text;
global using System.Threading.Tasks;
global using System.Xml;
global using Microsoft.CodeAnalysis.CSharp;
global using Microsoft.Extensions.Logging;
global using Expression = System.Linq.Expressions.Expression;
global using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;
global using CqlDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<Hl7.Cql.Abstractions.CqlDefinition>;
