/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace CoreTests
{
    [TestClass]
    public class SetLocale
    {
        private static CultureInfo original;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            // Set the locale to something else than US, to verify we are not using unqualified
            // Parses, ToStrings and converts: all should use InvariantCulture explicitly, to
            // become unsensitive to the globally set culture (here: Dutch).
            original = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("nl-nl");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Well, this thread is going to be finished anyway...
            CultureInfo.CurrentCulture = original;
        }
    }
}
