// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

namespace Hl7.Cql.Compiler;

internal enum TypeConversion
{
    NoMatch = 0,
    ExactType = 1,

    /// <summary>
    /// e.g. String is assignable to Object, and  'from' is a subtype of 'to' e.g. string -> object
    /// </summary>
    ExpressionCast = 2,

    ExpressionTypeAs = 3,

    OperatorConvert = 4,
}