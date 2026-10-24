/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// A cycle of includes is reported as an error on the include that closes it, naming the libraries along the cycle from
    /// the one that sorts first, and the translation of the other libraries goes on. CQL does not allow circular library
    /// references.
    /// </summary>
    [TestClass]
    public class IncludeCycleTest : Base
    {
        private const string CycleAIncludesB = """
            library CycleA version '1.0.0'
            include CycleB version '1.0.0' called B
            define X: 1
            """;

        private const string CycleBIncludesA = """
            library CycleB version '1.0.0'
            include CycleA version '1.0.0' called A
            define Y: 2
            """;

        [TestMethod]
        public void TwoLibrariesThatIncludeEachOther_TranslatedTogether_ReportTheCycleOnce()
        {
            var libraries = Translate(CycleAIncludesB, CycleBIncludesA);

            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: CycleA version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "CycleA version '1.0.0', which includes CycleB version '1.0.0', which includes CycleA version '1.0.0'.");
        }

        [TestMethod]
        public void TwoLibrariesThatIncludeEachOther_TranslatedTogetherInTheOtherOrder_ReportTheSameCycleOnce()
        {
            // The cycle is reported from the library that sorts first, whichever library the translation meets it from.
            var libraries = Translate(CycleBIncludesA, CycleAIncludesB);

            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: CycleA version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "CycleA version '1.0.0', which includes CycleB version '1.0.0', which includes CycleA version '1.0.0'.");
        }

        [TestMethod]
        public void ThreeLibrariesThatIncludeOneAnotherInARing_ReportTheCycleFromTheLibraryThatSortsFirst()
        {
            // The walk reaches the ring at RingC, through a library outside it, and the report still starts at RingA.
            var libraries = Translate(
                """
                library Outside version '1.0.0'
                include RingC version '1.0.0' called C
                define X: C.Z
                """,
                """
                library RingC version '1.0.0'
                include RingA version '1.0.0' called A
                define Z: 3
                """,
                """
                library RingA version '1.0.0'
                include RingB version '1.0.0' called B
                define X: 1
                """,
                """
                library RingB version '1.0.0'
                include RingC version '1.0.0' called C
                define Y: 2
                """);

            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: RingA version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "RingA version '1.0.0', which includes RingB version '1.0.0', which includes RingC version '1.0.0', which includes RingA version '1.0.0'.");
        }

        [DataTestMethod]
        [DataRow(CycleAIncludesB, CycleBIncludesA, "CycleB", DisplayName = "CycleA first")]
        [DataRow(CycleBIncludesA, CycleAIncludesB, "CycleA", DisplayName = "CycleB first")]
        public void TwoLibrariesThatIncludeEachOther_TranslatedOneAfterTheOther_TranslateWithoutEndlessRecursion(
            string first,
            string second,
            string missingFromTheFirst)
        {
            // The first library is translated before the second exists, so its include of the second is not resolved, and
            // its ELM records that. The second includes the first as translated: a library already resolved is not parsed
            // again, so neither the second nor its include of the first recurses into the cycle.
            var cqlToolkit = CreateCqlToolkit();
            cqlToolkit.MakeLibrary(
                first,
                $"Unable to resolve library: {missingFromTheFirst} version '1.0.0'. Are you sure this library version exists and that you have access?");

            cqlToolkit.MakeLibrary(second);
        }

        [TestMethod]
        public void ThreeLibrariesThatIncludeOneAnotherInARing_ReportTheCycleOnce()
        {
            var libraries = Translate(
                """
                library RingA version '1.0.0'
                include RingB version '1.0.0' called B
                define X: 1
                """,
                """
                library RingB version '1.0.0'
                include RingC version '1.0.0' called C
                define Y: 2
                """,
                """
                library RingC version '1.0.0'
                include RingA version '1.0.0' called A
                define Z: 3
                """);

            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: RingA version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "RingA version '1.0.0', which includes RingB version '1.0.0', which includes RingC version '1.0.0', which includes RingA version '1.0.0'.");
        }

        [TestMethod]
        public void ALibraryThatIncludesItself_ReportsTheCycle()
        {
            var libraries = Translate(
                """
                library Self version '1.0.0'
                include Self version '1.0.0' called Me
                define X: 1
                """);

            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: Self version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "Self version '1.0.0', which includes Self version '1.0.0'.");
        }

        [TestMethod]
        public void ALibraryIncludedByTwoLibraries_IsNoCycle()
        {
            var libraries = Translate(
                """
                library Root version '1.0.0'
                include Left version '1.0.0' called L
                include Right version '1.0.0' called R
                include Shared version '1.0.0' called S
                define X: L.A + R.B + S.C
                """,
                """
                library Left version '1.0.0'
                include Shared version '1.0.0' called S
                define A: S.C
                """,
                """
                library Right version '1.0.0'
                include Shared version '1.0.0' called S
                define B: S.C
                """,
                """
                library Shared version '1.0.0'
                define C: 1
                """);

            foreach (var library in libraries)
                library.ShouldSucceed();
        }

        [TestMethod]
        public void ALibraryOutsideTheCycleThatIncludesIt_TranslatesWithTheCycleReportedOnItsLibraries()
        {
            var libraries = Translate(
                """
                library Outside version '1.0.0'
                include CycleA version '1.0.0' called A
                define X: A.X
                """,
                CycleAIncludesB,
                CycleBIncludesA);

            libraries[0].ShouldSucceed();
            ShouldReportOneCycle(
                libraries,
                "Unable to resolve library: CycleA version '1.0.0'. Its includes form a cycle, which CQL does not allow: " +
                "CycleA version '1.0.0', which includes CycleB version '1.0.0', which includes CycleA version '1.0.0'.");
        }

        // Translates the libraries in one toolkit, with one TranslateToElm call, and returns their ELM in the given order.
        private static Library[] Translate(params string[] cqls)
        {
            var cqlLibraryStrings = cqls.Select(CqlLibraryString.Parse).ToArray();
            var artifactsById = CreateCqlToolkit()
                .AddCqlLibraries(cqlLibraryStrings)
                .TranslateToElm()
                .ArtifactsById;
            return [.. cqlLibraryStrings.Select(cql => artifactsById[cql].ResultElmLibrary!)];
        }

        // Exactly one error among the libraries, which names the cycle; the libraries it does not land on translated.
        private static void ShouldReportOneCycle(Library[] libraries, string expectedError)
        {
            var errors = libraries.SelectMany(library => library.GetErrors()).Where(error => error.errorSeverity == ErrorSeverity.error).ToArray();
            errors.Should().ContainSingle().Which.message.Should().Be(expectedError);
        }
    }
}
