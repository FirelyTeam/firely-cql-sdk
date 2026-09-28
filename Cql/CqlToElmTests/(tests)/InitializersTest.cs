/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Threading.Tasks;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InitializersTest
    {
        [TestMethod]
        public void NextId_ForTheSameObject_ReturnsTheSameId()
        {
            var element = new object();

            Initializers.NextId(element).Should().Be(Initializers.NextId(element));
        }

        [TestMethod]
        public void NextId_ForDifferentObjects_ReturnsDifferentIds()
        {
            Initializers.NextId(new object()).Should().NotBe(Initializers.NextId(new object()));
        }

        [TestMethod]
        public void NextId_WithoutAnObject_ReturnsADifferentIdEachTime()
        {
            Initializers.NextId().Should().NotBe(Initializers.NextId());
        }

        [TestMethod]
        public void NextId_FromManyThreadsAtOnce_GivesEachObjectOneIdOfItsOwn()
        {
            // Translations and compilations running in parallel in one process all number their ELM elements here.
            var objects = Enumerable.Range(0, 200_000).Select(_ => new object()).ToArray();
            var ids = new string[objects.Length];
            var idsAskedAgain = new string[objects.Length];

            Parallel.For(0, objects.Length, index => ids[index] = Initializers.NextId(objects[index]));
            Parallel.For(0, objects.Length, index => idsAskedAgain[index] = Initializers.NextId(objects[index]));

            ids.Distinct().Should().HaveCount(objects.Length);
            idsAskedAgain.Should().Equal(ids);
        }
    }
}
