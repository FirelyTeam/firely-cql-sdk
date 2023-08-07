#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;

namespace Hl7.Cql.Graph
{
    public abstract class ExecutionContext
    {
        protected ExecutionContext(ExecutionLog log, Random random)
        {
            Log = log;
            Random = random;
        }

        public ExecutionLog Log { get; }

        public Random Random { get; }

        public IList<GraphException> Exceptions { get; } = new List<GraphException>();

    }
}
