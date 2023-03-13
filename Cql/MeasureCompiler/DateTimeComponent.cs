using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.MeasureCompiler
{
    public enum DateTimeComponent
    {
        /// <summary>
        /// Extracts the date of its argument (with no time components) as Date
        /// </summary>
        date,
        /// <summary>
        /// Extracts the time of its argument as Time
        /// </summary>
        time,
        year,
        month,
        day,
        hour,
        minute,
        second,
        millisecond,
        /// <summary>
        /// Extracts the timezone offset component of its argument as decimal
        /// </summary>
        timezoneoffset
    }
}
