﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Logging
{
    internal class Locator
    {
        public Locator()
        {
        }

        public Locator(int line1, int col1, int line2, int col2)
        {
            StartLine = line1;
            StartColumn = col1;
            EndLine = line2;
            EndColumn = col2;
        }

        public Locator((int?, int?, int?, int?) tuple)
        {
            StartLine = tuple.Item1!.Value;
            StartColumn = tuple.Item2!.Value;
            EndLine = tuple.Item3!.Value;
            EndColumn = tuple.Item4!.Value;
        }

        public Locator((int, int, int, int) tuple)
        {
            StartLine = tuple.Item1;
            StartColumn = tuple.Item2;
            EndLine = tuple.Item3;
            EndColumn = tuple.Item4;
        }

        public int StartLine { get; set; }
        public int StartColumn { get; set; }

        public int EndLine { get; set; }
        public int EndColumn { get; set; }

        public RangeComparisonResult CompareTo(Locator other)
        {
            // cases:
            // (50:10,60:12) compared to (49:30,50:9)
            // (49:30,50:9) compared to (50:10,60:12)
            // (10:10, 20:20) compared to (15:15, 16:16)
            // (15:15, 16:16) compared to (10:10, 20:20)

            if (StartLine == other.StartLine && StartColumn == other.StartColumn &&
                EndLine == other.EndLine && EndColumn == other.EndColumn)
                return RangeComparisonResult.ExactlyEqual;

            bool thisStartBefore = false;
            bool thisStartEqual = false;
            bool thisEndBefore = false;
            bool thisEndEqual = false;

            if (StartLine < other.StartLine)
            {
                thisStartBefore = true;

            }
            else if (StartLine == other.StartLine)
            {
                if (StartColumn < other.StartColumn)
                {
                    thisStartBefore = true;
                }
                else if (StartColumn == other.StartColumn)
                    thisStartEqual = true;
            }

            if (EndLine < other.EndLine)
            {
                thisEndBefore = true;

            }
            else if (EndLine == other.EndLine)
            {

                if (EndColumn < other.EndColumn)
                {
                    thisEndBefore = true;
                }
                else if (EndColumn == other.EndColumn)
                    thisEndEqual = true;
            }

            if (thisStartBefore && thisEndBefore)
                return RangeComparisonResult.Before;
            else if ((thisStartBefore || thisStartEqual) && (thisEndBefore == false || thisEndEqual))
                return RangeComparisonResult.Contains;
            else if (thisStartBefore == false && thisEndBefore == false)
                return RangeComparisonResult.After;
            else if ((thisStartEqual || thisStartBefore == false) && (thisEndEqual || thisEndBefore))
                return RangeComparisonResult.ContainedBy;

            throw new ArgumentException("Illegal Bounds");
        }

        private int Compare(int line1, int col1, int line2, int col2)
        {
            if (line1 < line2)
                return -1;
            else if (line1 == line2)
                return col1 - col2;
            else return 1;
        }
    }

    internal enum RangeComparisonResult
    {
        Before,
        Contains,
        ContainedBy,
        After,
        ExactlyEqual
    };
}
