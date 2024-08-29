/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler;

internal enum TypeConversion
{
    // Type 'Source' is not convertible to type 'Target'
    NoMatch = 0,

    // Type 'Source' is exactly type 'Target'
    ExactType = 1,

    // Can cast 'Source' to 'Target' because 'Source' derives from 'Target'. e.g. (Target)source; // Casting down
    ExpressionCast = 2,

    // Can safely cast 'Source' as 'Target' because 'Source' derives from 'Target' e.g. (source as Target) // Casting up
    ExpressionTypeAs = 3,

    // No direct cast from 'Source' to 'Target', a cql operator is needed
    OperatorConvert = 4,
}