using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Elm
{
    internal class VersionComparer : IComparer<string>
    {
        public static VersionComparer Instance = new VersionComparer();
        private VersionComparer() { }

        public int Compare(string? x, string? y)
        {
            if (x is null)
            {
                if (y is null)
                    return 0;
                else return -1;
            }
            else if (y is null)
                return 1;
            else if(x == y)
                return 0;
            else 
            {
                
                var versionX = x.Split('.').Select(int.Parse).ToArray();
                var versionY = y.Split('.').Select(int.Parse).ToArray();
                for (int i = 0; i < Math.Max(versionX.Length, versionY.Length); i++)
                {
                    int partX = i < versionX.Length ? versionX[i] : 0;
                    int partY = i < versionY.Length ? versionY[i] : 0;

                    if (partX < partY)
                    {
                        return -1;
                    }

                    if (partX > partY)
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }
    }
}
