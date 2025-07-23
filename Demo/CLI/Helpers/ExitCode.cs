/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
namespace CLI.Helpers;

enum ExitCode
{
    Success = 0,
    InvalidOptions = 1,
    ArgumentException = 2,
    UnknownError = 10
}
