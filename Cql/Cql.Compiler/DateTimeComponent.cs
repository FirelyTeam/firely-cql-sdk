/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler
{
    internal enum DateTimeComponent
    {
        date,
        time,
        year,
        month,
        day,
        hour,
        minute,
        second,
        millisecond,
        timezoneoffset
    }
}
