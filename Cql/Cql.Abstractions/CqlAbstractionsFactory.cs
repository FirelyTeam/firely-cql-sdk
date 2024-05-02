/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Abstractions;

internal class CqlAbstractionsFactory : CqlFactoryBase
{
    protected CqlAbstractionsFactory(ILoggerFactory loggerFactory) : base(loggerFactory)
    {
    }
}